using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_107() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81791"},
        {"Hipparcos Number", "HIP 46565"},
        {"Smithsonian Astrophysical Observation", "SAO 27272"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.44618741),
        dec: Angle.Degrees(+54.12972861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232374"},
        {"Hipparcos Number", "HIP 5120"},
        {"Smithsonian Astrophysical Observation", "SAO 21994"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.40110372),
        dec: Angle.Degrees(+54.13120899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65734"},
        {"Hipparcos Number", "HIP 39363"},
        {"Geneva Identification System", "GEN# +1.00065734"},
        {"Smithsonian Astrophysical Observation", "SAO 26637"},
        {"Wilson Evans Batten Catalogue", "WEB 7707"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.69401786),
        dec: Angle.Degrees(+54.13126320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122252"},
        {"Hipparcos Number", "HIP 68332"},
        {"Smithsonian Astrophysical Observation", "SAO 28957"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.81952109),
        dec: Angle.Degrees(+54.13269643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115243"},
        {"Hipparcos Number", "HIP 64639"},
        {"Smithsonian Astrophysical Observation", "SAO 28689"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.73317075),
        dec: Angle.Degrees(+54.13398311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236281"},
        {"Hipparcos Number", "HIP 189"},
        {"Smithsonian Astrophysical Observation", "SAO 36004"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.60528721),
        dec: Angle.Degrees(+54.13515756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84236",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10410 AB"},
        {"Henry Draper", "HD 156162"},
        {"Hipparcos Number", "HIP 84236"},
        {"Geneva Identification System", "GEN# +1.00156162"},
        {"Smithsonian Astrophysical Observation", "SAO 30299"},
        {"Wilson Evans Batten Catalogue", "WEB 14226"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.27608814),
        dec: Angle.Degrees(+54.13914972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212288"},
        {"Hipparcos Number", "HIP 110417"},
        {"Smithsonian Astrophysical Observation", "SAO 34360"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.48876512),
        dec: Angle.Degrees(+54.13960476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168130"},
        {"Hipparcos Number", "HIP 89446"},
        {"Smithsonian Astrophysical Observation", "SAO 30841"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.81595437),
        dec: Angle.Degrees(+54.14093192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221412"},
        {"Hipparcos Number", "HIP 116113"},
        {"Smithsonian Astrophysical Observation", "SAO 35509"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.90619011),
        dec: Angle.Degrees(+54.14109142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216320"},
        {"Hipparcos Number", "HIP 112829"},
        {"Smithsonian Astrophysical Observation", "SAO 34874"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.74674058),
        dec: Angle.Degrees(+54.14259970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69149"},
        {"Hipparcos Number", "HIP 40677"},
        {"Geneva Identification System", "GEN# +1.00069149"},
        {"Smithsonian Astrophysical Observation", "SAO 26760"},
        {"Wilson Evans Batten Catalogue", "WEB 7904"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.56587279),
        dec: Angle.Degrees(+54.14376822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99822",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13610 A"},
        {"Henry Draper", "HD 192967"},
        {"Hipparcos Number", "HIP 99822"},
        {"Smithsonian Astrophysical Observation", "SAO 32392"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.80673532),
        dec: Angle.Degrees(+54.14665896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97125"},
        {"Hipparcos Number", "HIP 54674"},
        {"Geneva Identification System", "GEN# +1.00097125"},
        {"Smithsonian Astrophysical Observation", "SAO 27940"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.88059335),
        dec: Angle.Degrees(+54.14929870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233837"},
        {"Hipparcos Number", "HIP 56087"},
        {"Smithsonian Astrophysical Observation", "SAO 28036"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.44950447),
        dec: Angle.Degrees(+54.14946491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234858"},
        {"Hipparcos Number", "HIP 94816"},
        {"Smithsonian Astrophysical Observation", "SAO 31544"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.40212805),
        dec: Angle.Degrees(+54.14962584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96689"},
        {"Hipparcos Number", "HIP 54501"},
        {"Geneva Identification System", "GEN# +1.00096689"},
        {"Smithsonian Astrophysical Observation", "SAO 27925"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.25117424),
        dec: Angle.Degrees(+54.15069193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4133"},
        {"Hipparcos Number", "HIP 3476"},
        {"Geneva Identification System", "GEN# +1.00004133"},
        {"Smithsonian Astrophysical Observation", "SAO 21668"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.09900243),
        dec: Angle.Degrees(+54.15231267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196017"},
        {"Hipparcos Number", "HIP 101332"},
        {"Celescope Catalog", "CEL 5105"},
        {"Geneva Identification System", "GEN# +1.00196017"},
        {"Smithsonian Astrophysical Observation", "SAO 32670"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.07103609),
        dec: Angle.Degrees(+54.15630044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14959"},
        {"Hipparcos Number", "HIP 11373"},
        {"Smithsonian Astrophysical Observation", "SAO 23332"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.62128213),
        dec: Angle.Degrees(+54.15646025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37860"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.41869374),
        dec: Angle.Degrees(+54.15716084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60471",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8535 AB"},
        {"Henry Draper", "HD 107922"},
        {"Hipparcos Number", "HIP 60471"},
        {"Smithsonian Astrophysical Observation", "SAO 28364"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.96168682),
        dec: Angle.Degrees(+54.15848576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65854"},
        {"Hipparcos Number", "HIP 39426"},
        {"Smithsonian Astrophysical Observation", "SAO 26640"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.88499562),
        dec: Angle.Degrees(+54.15990726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232279"},
        {"Hipparcos Number", "HIP 3782"},
        {"Smithsonian Astrophysical Observation", "SAO 21724"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.15170347),
        dec: Angle.Degrees(+54.16069916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38684"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.80231228),
        dec: Angle.Degrees(+54.16269672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210495"},
        {"Hipparcos Number", "HIP 109373"},
        {"Smithsonian Astrophysical Observation", "SAO 34114"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.36784367),
        dec: Angle.Degrees(+54.16769009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3240"},
        {"Hipparcos Number", "HIP 2854"},
        {"Geneva Identification System", "GEN# +1.00003240"},
        {"Smithsonian Astrophysical Observation", "SAO 21551"},
        {"Wilson Evans Batten Catalogue", "WEB 512"},
    },
    visualMagnitude: 5.08,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.03453140),
        dec: Angle.Degrees(+54.16845384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203135"},
        {"Hipparcos Number", "HIP 105182"},
        {"Smithsonian Astrophysical Observation", "SAO 33303"},
        {"Wilson Evans Batten Catalogue", "WEB 19100"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.61222807),
        dec: Angle.Degrees(+54.17380236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33973"},
        {"Hipparcos Number", "HIP 24628"},
        {"Smithsonian Astrophysical Observation", "SAO 25108"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.24527053),
        dec: Angle.Degrees(+54.17380272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33985",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5706 A"},
        {"Henry Draper", "HD 52145"},
        {"Hipparcos Number", "HIP 33985"},
        {"Smithsonian Astrophysical Observation", "SAO 26119"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.77295138),
        dec: Angle.Degrees(+54.17404718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235740"},
        {"Hipparcos Number", "HIP 109363"},
        {"Geneva Identification System", "GEN# +1.00235740"},
        {"Smithsonian Astrophysical Observation", "SAO 34112"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.34582853),
        dec: Angle.Degrees(+54.17774349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16661"},
        {"Hipparcos Number", "HIP 12637"},
        {"Smithsonian Astrophysical Observation", "SAO 23544"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.58754173),
        dec: Angle.Degrees(+54.17823923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208524"},
        {"Hipparcos Number", "HIP 108196"},
        {"Smithsonian Astrophysical Observation", "SAO 33868"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.79792391),
        dec: Angle.Degrees(+54.17861985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185978"},
        {"Hipparcos Number", "HIP 96655"},
        {"Geneva Identification System", "GEN# +1.00185978"},
        {"Smithsonian Astrophysical Observation", "SAO 31858"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.77325691),
        dec: Angle.Degrees(+54.18136648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110824"},
        {"Geneva Identification System", "GEN# +0.05302885"},
        {"Wilson Evans Batten Catalogue", "WEB 19850"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.78123207),
        dec: Angle.Degrees(+54.18157766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19456"},
        {"Hipparcos Number", "HIP 14701"},
        {"Smithsonian Astrophysical Observation", "SAO 23843"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.47939294),
        dec: Angle.Degrees(+54.18221084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203437"},
        {"Hipparcos Number", "HIP 105343"},
        {"Smithsonian Astrophysical Observation", "SAO 33336"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.05897079),
        dec: Angle.Degrees(+54.18389178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19208"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.76375049),
        dec: Angle.Degrees(+54.18444529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -300.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103927"},
        {"Hipparcos Number", "HIP 58362"},
        {"Smithsonian Astrophysical Observation", "SAO 28207"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.51222472),
        dec: Angle.Degrees(+54.18543503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11555"},
        {"Hipparcos Number", "HIP 8934"},
        {"Geneva Identification System", "GEN# +1.00011555"},
        {"Smithsonian Astrophysical Observation", "SAO 22743"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.74588685),
        dec: Angle.Degrees(+54.18885017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61812"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.01879315),
        dec: Angle.Degrees(+54.19017638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14722"},
        {"Hipparcos Number", "HIP 11201"},
        {"Geneva Identification System", "GEN# +1.00014722"},
        {"Smithsonian Astrophysical Observation", "SAO 23291"},
        {"Wilson Evans Batten Catalogue", "WEB 2348"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.05546180),
        dec: Angle.Degrees(+54.19094729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162643"},
        {"Hipparcos Number", "HIP 87210"},
        {"Smithsonian Astrophysical Observation", "SAO 30593"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.25953233),
        dec: Angle.Degrees(+54.19429854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14708"},
        {"Hipparcos Number", "HIP 11189"},
        {"Geneva Identification System", "GEN# +1.00014708"},
        {"Smithsonian Astrophysical Observation", "SAO 23289"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.02525184),
        dec: Angle.Degrees(+54.19817460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236031"},
        {"Hipparcos Number", "HIP 113897"},
        {"Geneva Identification System", "GEN# +1.00236031"},
        {"Smithsonian Astrophysical Observation", "SAO 35110"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.98995490),
        dec: Angle.Degrees(+54.19828105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117573",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17038 A"},
        {"Henry Draper", "HD 223582"},
        {"Hipparcos Number", "HIP 117573"},
        {"Geneva Identification System", "GEN# +1.00223582"},
        {"Smithsonian Astrophysical Observation", "SAO 35828"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.65825169),
        dec: Angle.Degrees(+54.19830831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232161"},
        {"Hipparcos Number", "HIP 1621"},
        {"Smithsonian Astrophysical Observation", "SAO 21309"},
        {"Wilson Evans Batten Catalogue", "WEB 295"},
    },
    visualMagnitude: 8.95,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.06924531),
        dec: Angle.Degrees(+54.20099886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3184"},
        {"Hipparcos Number", "HIP 2782"},
        {"Smithsonian Astrophysical Observation", "SAO 21541"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.87108274),
        dec: Angle.Degrees(+54.20349001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6250"},
        {"Hipparcos Number", "HIP 5016"},
        {"Geneva Identification System", "GEN# +1.00006250"},
        {"Smithsonian Astrophysical Observation", "SAO 21974"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.06973676),
        dec: Angle.Degrees(+54.20439985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172041"},
        {"Hipparcos Number", "HIP 91103"},
        {"Geneva Identification System", "GEN# +1.00172041"},
        {"Smithsonian Astrophysical Observation", "SAO 31060"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.74810912),
        dec: Angle.Degrees(+54.20904403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110025"},
        {"Geneva Identification System", "GEN# +0.05302837"},
        {"Wilson Evans Batten Catalogue", "WEB 19755"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.27724310),
        dec: Angle.Degrees(+54.20928660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197434"},
        {"Hipparcos Number", "HIP 102097"},
        {"Fundamental Katalog 5th Edition", "FK5 5820"},
        {"Geneva Identification System", "GEN# +1.00197434"},
        {"Smithsonian Astrophysical Observation", "SAO 32798"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.35501583),
        dec: Angle.Degrees(+54.20944973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234942"},
        {"Hipparcos Number", "HIP 96323"},
        {"Smithsonian Astrophysical Observation", "SAO 31795"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.76988866),
        dec: Angle.Degrees(+54.20988997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235077"},
        {"Hipparcos Number", "HIP 98511"},
        {"Smithsonian Astrophysical Observation", "SAO 32203"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.19944531),
        dec: Angle.Degrees(+54.21066147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75425",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9628 AB"},
        {"Henry Draper", "HD 137588"},
        {"Hipparcos Number", "HIP 75425"},
        {"Smithsonian Astrophysical Observation", "SAO 29514"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.14691575),
        dec: Angle.Degrees(+54.21293177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88297"},
        {"Hipparcos Number", "HIP 49991"},
        {"Smithsonian Astrophysical Observation", "SAO 27551"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.08209630),
        dec: Angle.Degrees(+54.21323426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105230",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105230"},
    },
    visualMagnitude: 11.97,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)18, 55.4300),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)12, 51.100)
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
    primaryId: "HIP 79721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79721"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.06093148),
        dec: Angle.Degrees(+54.21586063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89414"},
        {"Hipparcos Number", "HIP 50635"},
        {"Fundamental Katalog 5th Edition", "FK5 2829"},
        {"Geneva Identification System", "GEN# +1.00089414"},
        {"Smithsonian Astrophysical Observation", "SAO 27609"},
        {"Wilson Evans Batten Catalogue", "WEB 9283"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.12993389),
        dec: Angle.Degrees(+54.21685357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201293"},
        {"Hipparcos Number", "HIP 104193"},
        {"Geneva Identification System", "GEN# +1.00201293"},
        {"Smithsonian Astrophysical Observation", "SAO 33137"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.64900287),
        dec: Angle.Degrees(+54.21757814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10338",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1700 AB"},
        {"Henry Draper", "HD 13452"},
        {"Hipparcos Number", "HIP 10338"},
        {"Celescope Catalog", "CEL 222"},
        {"Geneva Identification System", "GEN# +1.00013452J"},
        {"Smithsonian Astrophysical Observation", "SAO 23037"},
        {"Wilson Evans Batten Catalogue", "WEB 2161"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.30036949),
        dec: Angle.Degrees(+54.21884192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216913"},
        {"Hipparcos Number", "HIP 113260"},
        {"Smithsonian Astrophysical Observation", "SAO 34966"},
        {"Wilson Evans Batten Catalogue", "WEB 20153"},
    },
    visualMagnitude: 9.27,
    bvColour: 2.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.03079116),
        dec: Angle.Degrees(+54.22933852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203819"},
        {"Hipparcos Number", "HIP 105559"},
        {"Geneva Identification System", "GEN# +1.00203819"},
        {"Renson", "Renson 56750"},
        {"Smithsonian Astrophysical Observation", "SAO 33371"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.67931294),
        dec: Angle.Degrees(+54.23068086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6677"},
        {"Hipparcos Number", "HIP 5347"},
        {"Smithsonian Astrophysical Observation", "SAO 22031"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.09412519),
        dec: Angle.Degrees(+54.23138755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131005"},
        {"Hipparcos Number", "HIP 72468"},
        {"Smithsonian Astrophysical Observation", "SAO 29293"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.27812043),
        dec: Angle.Degrees(+54.23150881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198596"},
        {"Hipparcos Number", "HIP 102747"},
        {"Smithsonian Astrophysical Observation", "SAO 32913"},
        {"Wilson Evans Batten Catalogue", "WEB 18629"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.28441591),
        dec: Angle.Degrees(+54.23356393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103417"},
        {"Hipparcos Number", "HIP 58079"},
        {"Smithsonian Astrophysical Observation", "SAO 28184"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.66434185),
        dec: Angle.Degrees(+54.23418690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67517"},
        {"Hipparcos Number", "HIP 40062"},
        {"Geneva Identification System", "GEN# +1.00067517"},
        {"Smithsonian Astrophysical Observation", "SAO 26714"},
        {"Wilson Evans Batten Catalogue", "WEB 7812"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.75588707),
        dec: Angle.Degrees(+54.23438325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113064"},
        {"Hipparcos Number", "HIP 63466"},
        {"Geneva Identification System", "GEN# +1.00113064"},
        {"Smithsonian Astrophysical Observation", "SAO 28598"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.07184916),
        dec: Angle.Degrees(+54.23808639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107236"},
        {"Hipparcos Number", "HIP 60107"},
        {"Smithsonian Astrophysical Observation", "SAO 28339"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.91075872),
        dec: Angle.Degrees(+54.24069136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20833"},
        {"Hipparcos Number", "HIP 15821"},
        {"Smithsonian Astrophysical Observation", "SAO 24006"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.96748176),
        dec: Angle.Degrees(+54.24199150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85876"},
        {"Hipparcos Number", "HIP 48735"},
        {"Smithsonian Astrophysical Observation", "SAO 27434"},
        {"Wilson Evans Batten Catalogue", "WEB 9062"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.10946830),
        dec: Angle.Degrees(+54.24379266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213322"},
        {"Hipparcos Number", "HIP 111006"},
        {"Celescope Catalog", "CEL 5481"},
        {"Geneva Identification System", "GEN# +1.00213322"},
        {"Smithsonian Astrophysical Observation", "SAO 34511"},
        {"Wilson Evans Batten Catalogue", "WEB 19876"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.34307814),
        dec: Angle.Degrees(+54.24591546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209022"},
        {"Hipparcos Number", "HIP 108492"},
        {"Smithsonian Astrophysical Observation", "SAO 33931"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.67777329),
        dec: Angle.Degrees(+54.24800972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111468"},
        {"Hipparcos Number", "HIP 62543"},
        {"Fundamental Katalog 5th Edition", "FK5 5134"},
        {"Geneva Identification System", "GEN# +1.00111468"},
        {"Smithsonian Astrophysical Observation", "SAO 28527"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.23136253),
        dec: Angle.Degrees(+54.24818624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112105",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16203 A"},
        {"Henry Draper", "HD 215178"},
        {"Henry Draper 2", "HD 215178A"},
        {"Hipparcos Number", "HIP 112105"},
        {"Smithsonian Astrophysical Observation", "SAO 34718"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.60011476),
        dec: Angle.Degrees(+54.24839665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43621"},
        {"Hipparcos Number", "HIP 30123"},
        {"Geneva Identification System", "GEN# +1.00043621"},
        {"Smithsonian Astrophysical Observation", "SAO 25672"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.07901956),
        dec: Angle.Degrees(+54.25000838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34544"},
        {"Hipparcos Number", "HIP 25008"},
        {"Fundamental Katalog 5th Edition", "FK5 4489"},
        {"Geneva Identification System", "GEN# +1.00034544"},
        {"Smithsonian Astrophysical Observation", "SAO 25137"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.32228173),
        dec: Angle.Degrees(+54.25248204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102777"},
        {"Hipparcos Number", "HIP 57720"},
        {"Smithsonian Astrophysical Observation", "SAO 28157"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.55860264),
        dec: Angle.Degrees(+54.25255214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216888"},
        {"Hipparcos Number", "HIP 113241"},
        {"Geneva Identification System", "GEN# +1.00216888"},
        {"Smithsonian Astrophysical Observation", "SAO 34960"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.97788064),
        dec: Angle.Degrees(+54.25366703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21726"},
        {"Hipparcos Number", "HIP 16524"},
        {"Geneva Identification System", "GEN# +1.00021726"},
        {"Smithsonian Astrophysical Observation", "SAO 24089"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.18855812),
        dec: Angle.Degrees(+54.25495520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64191"},
    },
    visualMagnitude: 11.15,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.33335732),
        dec: Angle.Degrees(+54.25601037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233157"},
        {"Hipparcos Number", "HIP 26933"},
        {"Smithsonian Astrophysical Observation", "SAO 25334"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.74458429),
        dec: Angle.Degrees(+54.25762995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232939"},
        {"Hipparcos Number", "HIP 20381"},
        {"Smithsonian Astrophysical Observation", "SAO 24564"},
        {"Wilson Evans Batten Catalogue", "WEB 3897"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.47046152),
        dec: Angle.Degrees(+54.26023812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84659"},
        {"Hipparcos Number", "HIP 48111"},
        {"Geneva Identification System", "GEN# +1.00084659"},
        {"Smithsonian Astrophysical Observation", "SAO 27384"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.14396838),
        dec: Angle.Degrees(+54.26495238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49117"},
        {"Hipparcos Number", "HIP 32772"},
        {"Smithsonian Astrophysical Observation", "SAO 25975"},
    },
    visualMagnitude: 8.98,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.49396701),
        dec: Angle.Degrees(+54.26531257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235316"},
        {"Hipparcos Number", "HIP 102001"},
        {"Smithsonian Astrophysical Observation", "SAO 32787"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.05498964),
        dec: Angle.Degrees(+54.26766385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223788"},
        {"Hipparcos Number", "HIP 117733"},
        {"Geneva Identification System", "GEN# +1.00223788"},
        {"Smithsonian Astrophysical Observation", "SAO 35856"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.16530213),
        dec: Angle.Degrees(+54.26892691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118789"},
        {"Hipparcos Number", "HIP 66497"},
        {"Smithsonian Astrophysical Observation", "SAO 28821"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.47079538),
        dec: Angle.Degrees(+54.27262959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67172"},
        {"Hipparcos Number", "HIP 39946"},
        {"Smithsonian Astrophysical Observation", "SAO 26698"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.37329986),
        dec: Angle.Degrees(+54.27299924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225190"},
        {"Hipparcos Number", "HIP 347"},
        {"Geneva Identification System", "GEN# +1.00225190"},
        {"Smithsonian Astrophysical Observation", "SAO 21050"},
    },
    visualMagnitude: 7.79,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.08869988),
        dec: Angle.Degrees(+54.27460172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233305"},
        {"Hipparcos Number", "HIP 33445"},
        {"Smithsonian Astrophysical Observation", "SAO 26057"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.30833727),
        dec: Angle.Degrees(+54.27977244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14958"},
        {"Hipparcos Number", "HIP 11371"},
        {"Geneva Identification System", "GEN# +1.00014958"},
        {"Smithsonian Astrophysical Observation", "SAO 23331"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.61529313),
        dec: Angle.Degrees(+54.28283449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77309"},
        {"Hipparcos Number", "HIP 44504"},
        {"Fundamental Katalog 5th Edition", "FK5 340"},
        {"Geneva Identification System", "GEN# +1.00077309"},
        {"Smithsonian Astrophysical Observation", "SAO 27105"},
        {"Wilson Evans Batten Catalogue", "WEB 8524"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.00167862),
        dec: Angle.Degrees(+54.28387681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40035"},
        {"Hipparcos Number", "HIP 28358"},
        {"Fundamental Katalog 5th Edition", "FK5 225"},
        {"Geneva Identification System", "GEN# +1.00040035"},
        {"Smithsonian Astrophysical Observation", "SAO 25502"},
        {"Wilson Evans Batten Catalogue", "WEB 5541"},
    },
    visualMagnitude: 3.72,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.88145972),
        dec: Angle.Degrees(+54.28498197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167042"},
        {"Hipparcos Number", "HIP 89047"},
        {"Fundamental Katalog 5th Edition", "FK5 3447"},
        {"Geneva Identification System", "GEN# +1.00167042"},
        {"Smithsonian Astrophysical Observation", "SAO 30784"},
        {"Wilson Evans Batten Catalogue", "WEB 15115"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.63138418),
        dec: Angle.Degrees(+54.28595220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 246.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107874",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15395 AB"},
        {"Henry Draper", "HD 207975"},
        {"Hipparcos Number", "HIP 107874"},
        {"Smithsonian Astrophysical Observation", "SAO 33808"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.84896680),
        dec: Angle.Degrees(+54.29265299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1994"},
        {"Hipparcos Number", "HIP 1945"},
        {"Geneva Identification System", "GEN# +1.00001994"},
        {"Wilson Evans Batten Catalogue", "WEB 365"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.14530249),
        dec: Angle.Degrees(+54.29397291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21494"},
        {"Hipparcos Number", "HIP 16327"},
        {"Smithsonian Astrophysical Observation", "SAO 24069"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.61748814),
        dec: Angle.Degrees(+54.29408984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181358"},
        {"Hipparcos Number", "HIP 94797"},
        {"Geneva Identification System", "GEN# +1.00181358"},
        {"Smithsonian Astrophysical Observation", "SAO 31538"},
        {"Wilson Evans Batten Catalogue", "WEB 16543"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.32340759),
        dec: Angle.Degrees(+54.29637299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233613"},
        {"Hipparcos Number", "HIP 45452"},
        {"Smithsonian Astrophysical Observation", "SAO 27186"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.94996785),
        dec: Angle.Degrees(+54.29765205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174981"},
        {"Hipparcos Number", "HIP 92445"},
        {"Smithsonian Astrophysical Observation", "SAO 31196"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.59037071),
        dec: Angle.Degrees(+54.30100810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224768"},
        {"Hipparcos Number", "HIP 41"},
        {"Smithsonian Astrophysical Observation", "SAO 35981"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.11656351),
        dec: Angle.Degrees(+54.30223774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80459"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.35079602),
        dec: Angle.Degrees(+54.30451781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 432.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12771"},
        {"Hipparcos Number", "HIP 9852"},
        {"Geneva Identification System", "GEN# +1.00012771"},
        {"Smithsonian Astrophysical Observation", "SAO 22925"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.68783993),
        dec: Angle.Degrees(+54.30680019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75765"},
        {"Hipparcos Number", "HIP 43718"},
        {"Smithsonian Astrophysical Observation", "SAO 27036"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.55505131),
        dec: Angle.Degrees(+54.31230339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205482"},
        {"Hipparcos Number", "HIP 106462"},
        {"Geneva Identification System", "GEN# +1.00205482"},
        {"Smithsonian Astrophysical Observation", "SAO 33528"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.44090042),
        dec: Angle.Degrees(+54.31598784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15921"},
        {"Hipparcos Number", "HIP 12068"},
        {"Smithsonian Astrophysical Observation", "SAO 23449"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.89863276),
        dec: Angle.Degrees(+54.31699554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13052"},
        {"Hipparcos Number", "HIP 10044"},
        {"Smithsonian Astrophysical Observation", "SAO 22969"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.32392808),
        dec: Angle.Degrees(+54.31993706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193468"},
        {"Hipparcos Number", "HIP 100046"},
        {"Geneva Identification System", "GEN# +1.00193468"},
        {"Smithsonian Astrophysical Observation", "SAO 32443"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.45911574),
        dec: Angle.Degrees(+54.32234272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145954"},
        {"Hipparcos Number", "HIP 79294"},
        {"Smithsonian Astrophysical Observation", "SAO 29835"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.73987480),
        dec: Angle.Degrees(+54.32452496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107036",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15220 A"},
        {"Henry Draper", "HD 206483"},
        {"Hipparcos Number", "HIP 107036"},
        {"Geneva Identification System", "GEN# +1.00206483A"},
        {"Smithsonian Astrophysical Observation", "SAO 33654"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.16291981),
        dec: Angle.Degrees(+54.32473173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72050",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9370 AB"},
        {"Henry Draper", "HD 130105"},
        {"Hipparcos Number", "HIP 72050"},
        {"Smithsonian Astrophysical Observation", "SAO 29261"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.06595382),
        dec: Angle.Degrees(+54.32541311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234387"},
        {"Hipparcos Number", "HIP 83645"},
        {"Smithsonian Astrophysical Observation", "SAO 30242"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.43255714),
        dec: Angle.Degrees(+54.32840941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13958",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2254 A"},
        {"Henry Draper", "HD 18410"},
        {"Hipparcos Number", "HIP 13958"},
        {"Renson", "Renson 4580"},
        {"Smithsonian Astrophysical Observation", "SAO 23750"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.93862638),
        dec: Angle.Degrees(+54.32917383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152674"},
        {"Hipparcos Number", "HIP 82513"},
        {"Smithsonian Astrophysical Observation", "SAO 30132"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.96653335),
        dec: Angle.Degrees(+54.33100198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13125"},
        {"Hipparcos Number", "HIP 10112"},
        {"Geneva Identification System", "GEN# +1.00013125"},
        {"Smithsonian Astrophysical Observation", "SAO 22990"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.52082388),
        dec: Angle.Degrees(+54.33127419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 710"},
        {"Hipparcos Number", "HIP 949"},
        {"Smithsonian Astrophysical Observation", "SAO 21192"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.92427022),
        dec: Angle.Degrees(+54.33552182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194575"},
        {"Hipparcos Number", "HIP 100592"},
        {"Celescope Catalog", "CEL 5052"},
        {"Smithsonian Astrophysical Observation", "SAO 32529"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.97231827),
        dec: Angle.Degrees(+54.33587113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95268"},
        {"Hipparcos Number", "HIP 53834"},
        {"Smithsonian Astrophysical Observation", "SAO 27871"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.20309651),
        dec: Angle.Degrees(+54.33610172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232977"},
        {"Hipparcos Number", "HIP 21385"},
        {"Smithsonian Astrophysical Observation", "SAO 24701"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.84697389),
        dec: Angle.Degrees(+54.33959380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11868"},
        {"Hipparcos Number", "HIP 9181"},
        {"Smithsonian Astrophysical Observation", "SAO 22797"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.54496170),
        dec: Angle.Degrees(+54.34247025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200828"},
        {"Hipparcos Number", "HIP 103955"},
        {"Geneva Identification System", "GEN# +1.00200828"},
        {"Smithsonian Astrophysical Observation", "SAO 33099"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.94667293),
        dec: Angle.Degrees(+54.34439233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87140"},
        {"Hipparcos Number", "HIP 49371"},
        {"Geneva Identification System", "GEN# +1.00087140"},
        {"Smithsonian Astrophysical Observation", "SAO 27505"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.17943220),
        dec: Angle.Degrees(+54.34546039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235887"},
        {"Hipparcos Number", "HIP 111492"},
        {"Geneva Identification System", "GEN# +1.00235887"},
        {"Smithsonian Astrophysical Observation", "SAO 34594"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.82629162),
        dec: Angle.Degrees(+54.34650832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238021"},
        {"Hipparcos Number", "HIP 56628"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.16611435),
        dec: Angle.Degrees(+54.35175746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158732"},
        {"Hipparcos Number", "HIP 85462"},
        {"Smithsonian Astrophysical Observation", "SAO 30400"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.96672602),
        dec: Angle.Degrees(+54.35242653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235451"},
        {"Hipparcos Number", "HIP 104426"},
        {"Smithsonian Astrophysical Observation", "SAO 33172"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.30585662),
        dec: Angle.Degrees(+54.35351092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159387"},
        {"Hipparcos Number", "HIP 85759"},
        {"Smithsonian Astrophysical Observation", "SAO 30438"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.86203927),
        dec: Angle.Degrees(+54.35574812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8946"},
        {"Hipparcos Number", "HIP 6932"},
        {"Smithsonian Astrophysical Observation", "SAO 22324"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.32984023),
        dec: Angle.Degrees(+54.35871755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105879"},
        {"Hipparcos Number", "HIP 59398"},
        {"Smithsonian Astrophysical Observation", "SAO 28282"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.77804555),
        dec: Angle.Degrees(+54.35895061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219444"},
        {"Hipparcos Number", "HIP 114797"},
        {"Smithsonian Astrophysical Observation", "SAO 35267"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.80890555),
        dec: Angle.Degrees(+54.35905793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8365"},
        {"Hipparcos Number", "HIP 6542"},
        {"Geneva Identification System", "GEN# +1.00008365"},
        {"Smithsonian Astrophysical Observation", "SAO 22237"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.01483603),
        dec: Angle.Degrees(+54.35914937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18187"},
        {"Hipparcos Number", "HIP 13788"},
        {"Smithsonian Astrophysical Observation", "SAO 23730"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.37376188),
        dec: Angle.Degrees(+54.35946034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99913"},
        {"Hipparcos Number", "HIP 56120"},
        {"Geneva Identification System", "GEN# +1.00099913"},
        {"Smithsonian Astrophysical Observation", "SAO 28038"},
        {"Wilson Evans Batten Catalogue", "WEB 10075"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.55359663),
        dec: Angle.Degrees(+54.36233316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233415"},
        {"Hipparcos Number", "HIP 36806"},
        {"Smithsonian Astrophysical Observation", "SAO 26409"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.55053481),
        dec: Angle.Degrees(+54.36302717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18678"},
        {"Hipparcos Number", "HIP 14147"},
        {"Geneva Identification System", "GEN# +1.00018678"},
        {"Smithsonian Astrophysical Observation", "SAO 23775"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.60166513),
        dec: Angle.Degrees(+54.36331570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83886"},
        {"Hipparcos Number", "HIP 47664"},
        {"Fundamental Katalog 5th Edition", "FK5 2775"},
        {"Geneva Identification System", "GEN# +1.00083886"},
        {"Renson", "Renson 23930"},
        {"Smithsonian Astrophysical Observation", "SAO 27359"},
        {"Wilson Evans Batten Catalogue", "WEB 8933"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.77915610),
        dec: Angle.Degrees(+54.36378463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158045"},
        {"Hipparcos Number", "HIP 85134"},
        {"Smithsonian Astrophysical Observation", "SAO 30368"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.98451515),
        dec: Angle.Degrees(+54.36489197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122601"},
        {"Hipparcos Number", "HIP 68503"},
        {"Smithsonian Astrophysical Observation", "SAO 28976"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.35174009),
        dec: Angle.Degrees(+54.36497835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235372"},
        {"Hipparcos Number", "HIP 102752"},
        {"Smithsonian Astrophysical Observation", "SAO 32915"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.29131248),
        dec: Angle.Degrees(+54.36571093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232380"},
        {"Hipparcos Number", "HIP 5214"},
        {"Smithsonian Astrophysical Observation", "SAO 22009"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.66617490),
        dec: Angle.Degrees(+54.36923508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5305"},
        {"Hipparcos Number", "HIP 4338"},
        {"Smithsonian Astrophysical Observation", "SAO 21839"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.89429941),
        dec: Angle.Degrees(+54.37239861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54123"},
        {"Hipparcos Number", "HIP 34664"},
        {"Smithsonian Astrophysical Observation", "SAO 26196"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.68161777),
        dec: Angle.Degrees(+54.37313575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235635"},
        {"Hipparcos Number", "HIP 107740"},
        {"Smithsonian Astrophysical Observation", "SAO 33788"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.38522921),
        dec: Angle.Degrees(+54.37471511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181960"},
        {"Hipparcos Number", "HIP 94974"},
        {"Celescope Catalog", "CEL 4737"},
        {"Geneva Identification System", "GEN# +1.00181960"},
        {"Smithsonian Astrophysical Observation", "SAO 31574"},
        {"Wilson Evans Batten Catalogue", "WEB 16587"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.90175662),
        dec: Angle.Degrees(+54.37605672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232657"},
        {"Hipparcos Number", "HIP 11492"},
        {"Smithsonian Astrophysical Observation", "SAO 23359"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.05613427),
        dec: Angle.Degrees(+54.38164150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207728"},
        {"Hipparcos Number", "HIP 107733"},
        {"Geneva Identification System", "GEN# +1.00207728"},
        {"Smithsonian Astrophysical Observation", "SAO 33785"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.35721124),
        dec: Angle.Degrees(+54.38194696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234888"},
        {"Hipparcos Number", "HIP 95439"},
        {"Smithsonian Astrophysical Observation", "SAO 31637"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.20668411),
        dec: Angle.Degrees(+54.38517652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18353"},
        {"Hipparcos Number", "HIP 13912"},
        {"Smithsonian Astrophysical Observation", "SAO 23747"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.79292868),
        dec: Angle.Degrees(+54.38571000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147733"},
        {"Hipparcos Number", "HIP 80091"},
        {"Smithsonian Astrophysical Observation", "SAO 29905"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.21353897),
        dec: Angle.Degrees(+54.38613277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45082"},
        {"Hipparcos Number", "HIP 30817"},
        {"Smithsonian Astrophysical Observation", "SAO 25745"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.11888358),
        dec: Angle.Degrees(+54.38662883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215066"},
        {"Hipparcos Number", "HIP 112038"},
        {"Celescope Catalog", "CEL 5513"},
        {"Geneva Identification System", "GEN# +1.00215066"},
        {"Smithsonian Astrophysical Observation", "SAO 34703"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.39282403),
        dec: Angle.Degrees(+54.38673600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207561"},
        {"Hipparcos Number", "HIP 107650"},
        {"Geneva Identification System", "GEN# +1.00207561"},
        {"Renson", "Renson 57750"},
        {"Smithsonian Astrophysical Observation", "SAO 33770"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.06671476),
        dec: Angle.Degrees(+54.38730943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177981"},
        {"Hipparcos Number", "HIP 93620"},
        {"Smithsonian Astrophysical Observation", "SAO 31361"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.97879371),
        dec: Angle.Degrees(+54.38932404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198150"},
        {"Hipparcos Number", "HIP 102483"},
        {"Smithsonian Astrophysical Observation", "SAO 32874"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.51966412),
        dec: Angle.Degrees(+54.39049779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8493"},
        {"Hipparcos Number", "HIP 6632"},
        {"Smithsonian Astrophysical Observation", "SAO 22261"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.27487917),
        dec: Angle.Degrees(+54.39072356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150677"},
        {"Hipparcos Number", "HIP 81583"},
        {"Geneva Identification System", "GEN# +1.00150677"},
        {"Smithsonian Astrophysical Observation", "SAO 30036"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.92681194),
        dec: Angle.Degrees(+54.39130076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34075"},
        {"Hipparcos Number", "HIP 24695"},
        {"Smithsonian Astrophysical Observation", "SAO 25118"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.44867128),
        dec: Angle.Degrees(+54.39290711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151778"},
        {"Hipparcos Number", "HIP 82122"},
        {"Geneva Identification System", "GEN# +1.00151778"},
        {"Smithsonian Astrophysical Observation", "SAO 30091"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.64316449),
        dec: Angle.Degrees(+54.39450596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237784"},
        {"Hipparcos Number", "HIP 44957"},
        {"Smithsonian Astrophysical Observation", "SAO 27139"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.37918478),
        dec: Angle.Degrees(+54.39620834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74699"},
        {"Hipparcos Number", "HIP 43184"},
        {"Smithsonian Astrophysical Observation", "SAO 26996"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.95656109),
        dec: Angle.Degrees(+54.39741514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21734",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21734"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.00706651),
        dec: Angle.Degrees(+54.39900815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115348"},
        {"Hipparcos Number", "HIP 64705"},
        {"Smithsonian Astrophysical Observation", "SAO 28695"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.91861479),
        dec: Angle.Degrees(+54.40297546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7178"},
        {"Hipparcos Number", "HIP 5683"},
        {"Smithsonian Astrophysical Observation", "SAO 22098"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.27325425),
        dec: Angle.Degrees(+54.40345538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23753",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3667 A"},
        {"Henry Draper", "HD 32445"},
        {"Hipparcos Number", "HIP 23753"},
        {"Smithsonian Astrophysical Observation", "SAO 25007"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.59207971),
        dec: Angle.Degrees(+54.40518250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187275"},
        {"Hipparcos Number", "HIP 97293"},
        {"Smithsonian Astrophysical Observation", "SAO 31979"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.60287713),
        dec: Angle.Degrees(+54.40560275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90249"},
        {"Hipparcos Number", "HIP 51097"},
        {"Geneva Identification System", "GEN# +1.00090249"},
        {"Smithsonian Astrophysical Observation", "SAO 27642"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.59525588),
        dec: Angle.Degrees(+54.40748340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233201"},
        {"Hipparcos Number", "HIP 28841"},
        {"Smithsonian Astrophysical Observation", "SAO 25557"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.31545260),
        dec: Angle.Degrees(+54.40790857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30480"},
        {"Hipparcos Number", "HIP 22542"},
        {"Geneva Identification System", "GEN# +1.00030480"},
        {"Smithsonian Astrophysical Observation", "SAO 24865"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.77677244),
        dec: Angle.Degrees(+54.40846766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99222"},
        {"Hipparcos Number", "HIP 55764"},
        {"Geneva Identification System", "GEN# +1.00099222"},
        {"Smithsonian Astrophysical Observation", "SAO 28013"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.39592072),
        dec: Angle.Degrees(+54.40855749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124330"},
        {"Hipparcos Number", "HIP 69322"},
        {"Geneva Identification System", "GEN# +1.00124330"},
        {"Smithsonian Astrophysical Observation", "SAO 29034"},
        {"Wilson Evans Batten Catalogue", "WEB 12090"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.82241534),
        dec: Angle.Degrees(+54.40922813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238436"},
        {"Hipparcos Number", "HIP 74610"},
        {"Smithsonian Astrophysical Observation", "SAO 29459"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.67209693),
        dec: Angle.Degrees(+54.41148233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26342"},
        {"Hipparcos Number", "HIP 19668"},
        {"Geneva Identification System", "GEN# +1.00026342"},
        {"Smithsonian Astrophysical Observation", "SAO 24468"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.20382374),
        dec: Angle.Degrees(+54.41263212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216057"},
        {"Hipparcos Number", "HIP 112641"},
        {"Celescope Catalog", "CEL 5529"},
        {"Geneva Identification System", "GEN# +1.00216057"},
        {"Smithsonian Astrophysical Observation", "SAO 34845"},
    },
    visualMagnitude: 6.14,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.19951651),
        dec: Angle.Degrees(+54.41489706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49361"},
        {"Hipparcos Number", "HIP 32887"},
        {"Geneva Identification System", "GEN# +1.00049361"},
        {"Smithsonian Astrophysical Observation", "SAO 25993"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.78513931),
        dec: Angle.Degrees(+54.41918029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214410"},
        {"Hipparcos Number", "HIP 111625"},
        {"Celescope Catalog", "CEL 5495"},
        {"Geneva Identification System", "GEN# +1.00214410"},
        {"Smithsonian Astrophysical Observation", "SAO 34619"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.19823428),
        dec: Angle.Degrees(+54.42336978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169745"},
        {"Hipparcos Number", "HIP 90095"},
        {"Smithsonian Astrophysical Observation", "SAO 30938"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.78968215),
        dec: Angle.Degrees(+54.42358620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18230"},
        {"Hipparcos Number", "HIP 13822"},
        {"Smithsonian Astrophysical Observation", "SAO 23733"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.47691488),
        dec: Angle.Degrees(+54.42433488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218697"},
        {"Hipparcos Number", "HIP 114342"},
        {"Geneva Identification System", "GEN# +1.00218697"},
        {"Smithsonian Astrophysical Observation", "SAO 35179"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.36185199),
        dec: Angle.Degrees(+54.42508120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16282"},
        {"Hipparcos Number", "HIP 12334"},
        {"Smithsonian Astrophysical Observation", "SAO 23492"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.70897073),
        dec: Angle.Degrees(+54.42731716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36678"},
        {"Hipparcos Number", "HIP 26344"},
        {"Fundamental Katalog 5th Edition", "FK5 2416"},
        {"Geneva Identification System", "GEN# +1.00036678"},
        {"Smithsonian Astrophysical Observation", "SAO 25276"},
        {"Wilson Evans Batten Catalogue", "WEB 5192"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.14677009),
        dec: Angle.Degrees(+54.42868426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153223"},
        {"Hipparcos Number", "HIP 82795"},
        {"Smithsonian Astrophysical Observation", "SAO 30156"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.80443692),
        dec: Angle.Degrees(+54.43131512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120198"},
        {"Hipparcos Number", "HIP 67231"},
        {"Geneva Identification System", "GEN# +1.00120198"},
        {"Renson", "Renson 34660"},
        {"Smithsonian Astrophysical Observation", "SAO 28885"},
        {"Wilson Evans Batten Catalogue", "WEB 11829"},
    },
    visualMagnitude: 5.68,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.64864720),
        dec: Angle.Degrees(+54.43269033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54786"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.24001172),
        dec: Angle.Degrees(+54.43286997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37216",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37216"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.66725568),
        dec: Angle.Degrees(+54.43297784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -262.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233179"},
        {"Hipparcos Number", "HIP 28108"},
        {"Smithsonian Astrophysical Observation", "SAO 25469"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.10842022),
        dec: Angle.Degrees(+54.43351969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98906",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "PM I20050+5426"},
        {"Hipparcos Number", "HIP 98906"},
        {"Cincinnati Publication", "Ci 20 1191"},
        {"Geneva Identification System", "GEN# +6.10010781"},
        {"Geneva Identification System 2", "GEN# +9.80230026"},
        {"Wilson Evans Batten Catalogue", "WEB 17561"},
    },
    visualMagnitude: 11.98,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.26398477),
        dec: Angle.Degrees(+54.43642895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1165.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -899.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222265"},
        {"Hipparcos Number", "HIP 116692"},
        {"Smithsonian Astrophysical Observation", "SAO 35637"},
        {"Wilson Evans Batten Catalogue", "WEB 20595"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.71720082),
        dec: Angle.Degrees(+54.44259372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234937"},
        {"Hipparcos Number", "HIP 96246"},
        {"Smithsonian Astrophysical Observation", "SAO 31783"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.55904631),
        dec: Angle.Degrees(+54.44396798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10109"},
        {"Hipparcos Number", "HIP 7785"},
        {"Celescope Catalog", "CEL 154"},
        {"Smithsonian Astrophysical Observation", "SAO 22492"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.05251845),
        dec: Angle.Degrees(+54.44567427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102252"},
        {"Hipparcos Number", "HIP 57424"},
        {"Smithsonian Astrophysical Observation", "SAO 28133"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.59224311),
        dec: Angle.Degrees(+54.44993865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102002",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14154 AB"},
        {"Henry Draper", "HD 235317"},
        {"Hipparcos Number", "HIP 102002"},
        {"Smithsonian Astrophysical Observation", "SAO 32788"},
        {"Wilson Evans Batten Catalogue", "WEB 18440"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.05583228),
        dec: Angle.Degrees(+54.45266478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60983"},
        {"Hipparcos Number", "HIP 37347"},
        {"Geneva Identification System", "GEN# +1.00060983"},
        {"Smithsonian Astrophysical Observation", "SAO 26452"},
        {"Wilson Evans Batten Catalogue", "WEB 7392"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.99428557),
        dec: Angle.Degrees(+54.45350781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196143"},
        {"Hipparcos Number", "HIP 101412"},
        {"Smithsonian Astrophysical Observation", "SAO 32681"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.27737658),
        dec: Angle.Degrees(+54.45695617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61750"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.82218390),
        dec: Angle.Degrees(+54.45774926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111380"},
        {"Hipparcos Number", "HIP 62487"},
        {"Geneva Identification System", "GEN# +1.00111380"},
        {"Smithsonian Astrophysical Observation", "SAO 28523"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.07833628),
        dec: Angle.Degrees(+54.46039968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65390"},
        {"Hipparcos Number", "HIP 39207"},
        {"Smithsonian Astrophysical Observation", "SAO 26620"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.30073436),
        dec: Angle.Degrees(+54.46061852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41810"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.86639563),
        dec: Angle.Degrees(+54.46078227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2364"},
        {"Geneva Identification System", "GEN# +0.05300079"},
        {"Wilson Evans Batten Catalogue", "WEB 434"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.54430960),
        dec: Angle.Degrees(+54.46332826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14015"},
        {"Hipparcos Number", "HIP 10713"},
        {"Smithsonian Astrophysical Observation", "SAO 23148"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.48677895),
        dec: Angle.Degrees(+54.46422294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232138"},
        {"Hipparcos Number", "HIP 1104"},
        {"Geneva Identification System", "GEN# +1.00232138"},
        {"Smithsonian Astrophysical Observation", "SAO 21221"},
        {"Wilson Evans Batten Catalogue", "WEB 192"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.44254987),
        dec: Angle.Degrees(+54.46459288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232302"},
        {"Hipparcos Number", "HIP 4183"},
        {"Smithsonian Astrophysical Observation", "SAO 21808"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.36685315),
        dec: Angle.Degrees(+54.46833854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234623"},
        {"Hipparcos Number", "HIP 89857"},
        {"Smithsonian Astrophysical Observation", "SAO 30907"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.06421573),
        dec: Angle.Degrees(+54.46972671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83608",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alrakis"},
        {"Aitken", "ADS 10345 AB"},
        {"Henry Draper", "HD 154905J"},
        {"Hipparcos Number", "HIP 83608"},
        {"Smithsonian Astrophysical Observation", "SAO 30239"},
    },
    visualMagnitude: 4.91,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.33409280),
        dec: Angle.Degrees(+54.46986308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232929"},
        {"Hipparcos Number", "HIP 20040"},
        {"Smithsonian Astrophysical Observation", "SAO 24527"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.46901746),
        dec: Angle.Degrees(+54.47001061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115229"},
        {"Hipparcos Number", "HIP 64631"},
        {"Smithsonian Astrophysical Observation", "SAO 28688"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.70949632),
        dec: Angle.Degrees(+54.47058271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234241"},
        {"Hipparcos Number", "HIP 76047"},
        {"Smithsonian Astrophysical Observation", "SAO 29560"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.95425851),
        dec: Angle.Degrees(+54.47144100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94194",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12144 AB"},
        {"Henry Draper", "HD 234826"},
        {"Hipparcos Number", "HIP 94194"},
        {"Smithsonian Astrophysical Observation", "SAO 31442"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.65253982),
        dec: Angle.Degrees(+54.47640926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238006"},
        {"Hipparcos Number", "HIP 56092"},
        {"Geneva Identification System", "GEN# +1.00238006"},
        {"Smithsonian Astrophysical Observation", "SAO 28037"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.47128135),
        dec: Angle.Degrees(+54.47858096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -160.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202507"},
        {"Hipparcos Number", "HIP 104829"},
        {"Geneva Identification System", "GEN# +1.00202507"},
        {"Smithsonian Astrophysical Observation", "SAO 33250"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.55662044),
        dec: Angle.Degrees(+54.48167806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237853"},
        {"Hipparcos Number", "HIP 48821"},
        {"Smithsonian Astrophysical Observation", "SAO 27439"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.37661642),
        dec: Angle.Degrees(+54.48256950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9267"},
        {"Hipparcos Number", "HIP 7171"},
        {"Smithsonian Astrophysical Observation", "SAO 22371"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.11314510),
        dec: Angle.Degrees(+54.48332544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235661"},
        {"Hipparcos Number", "HIP 108183"},
    },
    visualMagnitude: 8.82,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.77180170),
        dec: Angle.Degrees(+54.48378653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235679"},
        {"Hipparcos Number", "HIP 108476"},
        {"Geneva Identification System", "GEN# +1.00235679"},
        {"Smithsonian Astrophysical Observation", "SAO 33928"},
        {"Wilson Evans Batten Catalogue", "WEB 19533"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.62401137),
        dec: Angle.Degrees(+54.48489064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19194"},
        {"Hipparcos Number", "HIP 14518"},
        {"Smithsonian Astrophysical Observation", "SAO 23816"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.87446352),
        dec: Angle.Degrees(+54.48520705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238090"},
        {"Hipparcos Number", "HIP 59514"},
        {"Geneva Identification System", "GEN# +1.00238090"},
        {"Wilson Evans Batten Catalogue", "WEB 10581"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.08594231),
        dec: Angle.Degrees(+54.48553320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104016"},
        {"Hipparcos Number", "HIP 58419"},
        {"Smithsonian Astrophysical Observation", "SAO 28208"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.67233553),
        dec: Angle.Degrees(+54.48571234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115222",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115222"},
    },
    visualMagnitude: 11.46,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.07387557),
        dec: Angle.Degrees(+54.48738222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 171.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12303"},
        {"Hipparcos Number", "HIP 9505"},
        {"Fundamental Katalog 5th Edition", "FK5 1054"},
        {"Geneva Identification System", "GEN# +1.00012303"},
        {"Smithsonian Astrophysical Observation", "SAO 22859"},
        {"Wilson Evans Batten Catalogue", "WEB 1996"},
    },
    visualMagnitude: 4.99,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.57530917),
        dec: Angle.Degrees(+54.48754946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105755"},
        {"Hipparcos Number", "HIP 59330"},
        {"Geneva Identification System", "GEN# +1.00105755"},
        {"Smithsonian Astrophysical Observation", "SAO 28272"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.56587927),
        dec: Angle.Degrees(+54.48819684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237786"},
        {"Hipparcos Number", "HIP 44998"},
        {"Geneva Identification System", "GEN# +1.00237786"},
        {"Smithsonian Astrophysical Observation", "SAO 27143"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.48327179),
        dec: Angle.Degrees(+54.48870086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204261"},
        {"Hipparcos Number", "HIP 105795"},
        {"Smithsonian Astrophysical Observation", "SAO 33420"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.38639749),
        dec: Angle.Degrees(+54.49016119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83996",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10386 B"},
        {"Henry Draper", "HD 155674B"},
        {"Hipparcos Number", "HIP 83996"},
        {"Geneva Identification System", "GEN# +1.00155674B"},
        {"Smithsonian Astrophysical Observation", "SAO 30275"},
        {"Wilson Evans Batten Catalogue", "WEB 14192"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.55112357),
        dec: Angle.Degrees(+54.49039523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54776"},
        {"Hipparcos Number", "HIP 34893"},
        {"Smithsonian Astrophysical Observation", "SAO 26219"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.28950172),
        dec: Angle.Degrees(+54.49367597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83988",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10386 A"},
        {"Henry Draper", "HD 155674"},
        {"Hipparcos Number", "HIP 83988"},
        {"Geneva Identification System", "GEN# +1.00155674A"},
        {"Smithsonian Astrophysical Observation", "SAO 30274"},
        {"Wilson Evans Batten Catalogue", "WEB 14191"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.54343900),
        dec: Angle.Degrees(+54.49464598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38257"},
        {"Hipparcos Number", "HIP 27355"},
        {"Smithsonian Astrophysical Observation", "SAO 25377"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.90476497),
        dec: Angle.Degrees(+54.49469302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238341"},
        {"Hipparcos Number", "HIP 70068"},
        {"Geneva Identification System", "GEN# +1.00238341"},
        {"Smithsonian Astrophysical Observation", "SAO 29105"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.07659342),
        dec: Angle.Degrees(+54.50539625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235783"},
        {"Hipparcos Number", "HIP 110026"},
        {"Geneva Identification System", "GEN# +1.00235783"},
        {"Smithsonian Astrophysical Observation", "SAO 34271"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.27924558),
        dec: Angle.Degrees(+54.50762723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139778"},
        {"Hipparcos Number", "HIP 76509"},
        {"Geneva Identification System", "GEN# +1.00139778"},
        {"Smithsonian Astrophysical Observation", "SAO 29597"},
        {"Wilson Evans Batten Catalogue", "WEB 12986"},
    },
    visualMagnitude: 5.85,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.38351097),
        dec: Angle.Degrees(+54.50878294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149929"},
        {"Hipparcos Number", "HIP 81186"},
        {"Smithsonian Astrophysical Observation", "SAO 30002"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.74071989),
        dec: Angle.Degrees(+54.50907817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 182.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207131"},
        {"Hipparcos Number", "HIP 107396"},
        {"Geneva Identification System", "GEN# +1.00207131"},
        {"Smithsonian Astrophysical Observation", "SAO 33723"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.29732046),
        dec: Angle.Degrees(+54.50914247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14384"},
        {"Hipparcos Number", "HIP 10961"},
        {"Geneva Identification System", "GEN# +1.00014384"},
        {"Smithsonian Astrophysical Observation", "SAO 23229"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.30383614),
        dec: Angle.Degrees(+54.51008750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221659"},
        {"Hipparcos Number", "HIP 116291"},
        {"Smithsonian Astrophysical Observation", "SAO 35547"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.42313864),
        dec: Angle.Degrees(+54.51133416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234557"},
        {"Hipparcos Number", "HIP 88611"},
        {"Smithsonian Astrophysical Observation", "SAO 30743"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.38476476),
        dec: Angle.Degrees(+54.51407317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236284"},
        {"Hipparcos Number", "HIP 256"},
        {"Smithsonian Astrophysical Observation", "SAO 21033"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.79659523),
        dec: Angle.Degrees(+54.51584355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199191"},
        {"Hipparcos Number", "HIP 103092"},
        {"Geneva Identification System", "GEN# +1.00199191"},
        {"Smithsonian Astrophysical Observation", "SAO 32968"},
        {"Wilson Evans Batten Catalogue", "WEB 18719"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.32622220),
        dec: Angle.Degrees(+54.51766629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 179.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235725"},
        {"Hipparcos Number", "HIP 109153"},
        {"Smithsonian Astrophysical Observation", "SAO 34061"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.64828278),
        dec: Angle.Degrees(+54.51838313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192849"},
        {"Hipparcos Number", "HIP 99775"},
        {"Geneva Identification System", "GEN# +1.00192849"},
        {"Renson", "Renson 53820"},
        {"Smithsonian Astrophysical Observation", "SAO 32387"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.64610448),
        dec: Angle.Degrees(+54.51894874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77091"},
        {"Hipparcos Number", "HIP 44392"},
        {"Geneva Identification System", "GEN# +1.00077091"},
        {"Smithsonian Astrophysical Observation", "SAO 27093"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.64376474),
        dec: Angle.Degrees(+54.52193797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2505",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 434 AB"},
        {"Henry Draper", "HD 2772"},
        {"Hipparcos Number", "HIP 2505"},
        {"Geneva Identification System", "GEN# +1.00002772J"},
        {"Smithsonian Astrophysical Observation", "SAO 21489"},
        {"Wilson Evans Batten Catalogue", "WEB 458"},
    },
    visualMagnitude: 4.74,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.94299136),
        dec: Angle.Degrees(+54.52232473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78403",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9889 AB"},
        {"Henry Draper", "HD 143914"},
        {"Hipparcos Number", "HIP 78403"},
        {"Geneva Identification System", "GEN# +1.00143914J"},
        {"Renson", "Renson 40770"},
        {"Smithsonian Astrophysical Observation", "SAO 29747"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.08860880),
        dec: Angle.Degrees(+54.52248469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26512"},
        {"Hipparcos Number", "HIP 19774"},
        {"Smithsonian Astrophysical Observation", "SAO 24493"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.59339469),
        dec: Angle.Degrees(+54.52420993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54040",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8032 AB"},
        {"Henry Draper", "HD 95690"},
        {"Hipparcos Number", "HIP 54040"},
        {"Geneva Identification System", "GEN# +1.00095690"},
        {"Smithsonian Astrophysical Observation", "SAO 27886"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.86686539),
        dec: Angle.Degrees(+54.52556417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70546"},
        {"Hipparcos Number", "HIP 41264"},
        {"Geneva Identification System", "GEN# +1.00070546"},
        {"Smithsonian Astrophysical Observation", "SAO 26825"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.28753524),
        dec: Angle.Degrees(+54.52656099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60733",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60733"},
    },
    visualMagnitude: 11.40,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.70947855),
        dec: Angle.Degrees(+55.17489232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -261.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235374"},
        {"Hipparcos Number", "HIP 102765"},
        {"Smithsonian Astrophysical Observation", "SAO 32916"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.31799310),
        dec: Angle.Degrees(+54.52726115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148800"},
        {"Hipparcos Number", "HIP 80623"},
        {"Smithsonian Astrophysical Observation", "SAO 29950"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.93671674),
        dec: Angle.Degrees(+54.52771339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92952",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92952"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.06625285),
        dec: Angle.Degrees(+54.53087318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -350.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13661"},
        {"Hipparcos Number", "HIP 10463"},
        {"Celescope Catalog", "CEL 228"},
        {"Geneva Identification System", "GEN# +1.00013661"},
        {"Smithsonian Astrophysical Observation", "SAO 23073"},
        {"Wilson Evans Batten Catalogue", "WEB 2193"},
    },
    visualMagnitude: 7.85,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.72128521),
        dec: Angle.Degrees(+54.53173027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140715"},
        {"Hipparcos Number", "HIP 76942"},
        {"Smithsonian Astrophysical Observation", "SAO 29626"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.66267672),
        dec: Angle.Degrees(+54.53587471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13436"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.24383295),
        dec: Angle.Degrees(+54.53639060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232725"},
        {"Hipparcos Number", "HIP 13574"},
        {"Smithsonian Astrophysical Observation", "SAO 23690"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.71451409),
        dec: Angle.Degrees(+54.53699353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232997"},
        {"Hipparcos Number", "HIP 22039"},
        {"Fundamental Katalog 5th Edition", "FK5 4428"},
        {"Smithsonian Astrophysical Observation", "SAO 24791"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.08139705),
        dec: Angle.Degrees(+54.53708144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32974"},
        {"Hipparcos Number", "HIP 24033"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.49853451),
        dec: Angle.Degrees(+54.53795469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224015"},
        {"Hipparcos Number", "HIP 117868"},
        {"Smithsonian Astrophysical Observation", "SAO 35880"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.60892814),
        dec: Angle.Degrees(+54.53843288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238292"},
        {"Hipparcos Number", "HIP 67701"},
        {"Smithsonian Astrophysical Observation", "SAO 28914"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.01162939),
        dec: Angle.Degrees(+54.53884762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102970"},
        {"Hipparcos Number", "HIP 57823"},
        {"Smithsonian Astrophysical Observation", "SAO 28163"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.86897125),
        dec: Angle.Degrees(+54.53914689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67539"},
        {"Hipparcos Number", "HIP 40086"},
        {"Geneva Identification System", "GEN# +1.00067539"},
        {"Smithsonian Astrophysical Observation", "SAO 26717"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.82513547),
        dec: Angle.Degrees(+54.54046580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21356"},
        {"Hipparcos Number", "HIP 16230"},
        {"Smithsonian Astrophysical Observation", "SAO 24057"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.27299461),
        dec: Angle.Degrees(+54.54129464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219037"},
        {"Hipparcos Number", "HIP 114549"},
        {"Smithsonian Astrophysical Observation", "SAO 35226"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.04913029),
        dec: Angle.Degrees(+54.54225785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69793",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9208 A"},
        {"Henry Draper", "HD 125333"},
        {"Hipparcos Number", "HIP 69793"},
        {"Smithsonian Astrophysical Observation", "SAO 29083"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.26634421),
        dec: Angle.Degrees(+54.54299818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156771"},
        {"Hipparcos Number", "HIP 84493"},
        {"Smithsonian Astrophysical Observation", "SAO 30321"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.11335205),
        dec: Angle.Degrees(+54.54425528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15649"},
        {"Hipparcos Number", "HIP 11848"},
        {"Smithsonian Astrophysical Observation", "SAO 23418"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.23303713),
        dec: Angle.Degrees(+54.54450468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232814"},
        {"Hipparcos Number", "HIP 16888"},
        {"Geneva Identification System", "GEN# +1.00232814"},
        {"Smithsonian Astrophysical Observation", "SAO 24126"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.33118087),
        dec: Angle.Degrees(+54.54628410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40083"},
        {"Hipparcos Number", "HIP 28390"},
        {"Geneva Identification System", "GEN# +1.00040083"},
        {"Smithsonian Astrophysical Observation", "SAO 25505"},
        {"Wilson Evans Batten Catalogue", "WEB 5550"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.94978850),
        dec: Angle.Degrees(+54.54711179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225012"},
        {"Hipparcos Number", "HIP 202"},
        {"Geneva Identification System", "GEN# +1.00225012"},
        {"Smithsonian Astrophysical Observation", "SAO 36006"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.64173419),
        dec: Angle.Degrees(+54.55216087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91008"},
        {"Hipparcos Number", "HIP 51540"},
        {"Renson", "Renson 26170"},
        {"Smithsonian Astrophysical Observation", "SAO 27675"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.90435171),
        dec: Angle.Degrees(+54.55294787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134190"},
        {"Hipparcos Number", "HIP 73909"},
        {"Fundamental Katalog 5th Edition", "FK5 1397"},
        {"Geneva Identification System", "GEN# +1.00134190"},
        {"Smithsonian Astrophysical Observation", "SAO 29407"},
        {"Wilson Evans Batten Catalogue", "WEB 12623"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.56945460),
        dec: Angle.Degrees(+54.55628697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238120"},
        {"Hipparcos Number", "HIP 60704"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.62428954),
        dec: Angle.Degrees(+54.55648535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -213.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210616"},
        {"Hipparcos Number", "HIP 109426"},
        {"Smithsonian Astrophysical Observation", "SAO 34124"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.54729071),
        dec: Angle.Degrees(+54.55803045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115733",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16760 AB"},
        {"Henry Draper", "HD 220869"},
        {"Hipparcos Number", "HIP 115733"},
        {"Smithsonian Astrophysical Observation", "SAO 35422"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.70219966),
        dec: Angle.Degrees(+54.55984459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206823"},
        {"Hipparcos Number", "HIP 107215"},
        {"Smithsonian Astrophysical Observation", "SAO 33682"},
        {"Wilson Evans Batten Catalogue", "WEB 19365"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.73342665),
        dec: Angle.Degrees(+54.56193001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69174"},
        {"Hipparcos Number", "HIP 40699"},
        {"Geneva Identification System", "GEN# +1.00069174"},
        {"Smithsonian Astrophysical Observation", "SAO 26763"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.62025721),
        dec: Angle.Degrees(+54.56388624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104098"},
        {"Hipparcos Number", "HIP 58470"},
        {"Smithsonian Astrophysical Observation", "SAO 28209"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.86082156),
        dec: Angle.Degrees(+54.56970888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49917"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.88261228),
        dec: Angle.Degrees(+54.57715057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234828"},
        {"Hipparcos Number", "HIP 94199"},
        {"Smithsonian Astrophysical Observation", "SAO 31445"},
    },
    visualMagnitude: 9.31,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.66276972),
        dec: Angle.Degrees(+54.58007070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53170"},
        {"Hipparcos Number", "HIP 34343"},
        {"Smithsonian Astrophysical Observation", "SAO 26157"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.79211125),
        dec: Angle.Degrees(+54.58192155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116558"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.31902958),
        dec: Angle.Degrees(+54.58244230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180912"},
        {"Hipparcos Number", "HIP 94634"},
        {"Geneva Identification System", "GEN# +1.00180912"},
        {"Smithsonian Astrophysical Observation", "SAO 31518"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.85857021),
        dec: Angle.Degrees(+54.58379620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31677"},
        {"Hipparcos Number", "HIP 23315"},
        {"Smithsonian Astrophysical Observation", "SAO 24948"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.21030484),
        dec: Angle.Degrees(+54.58447985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94247"},
        {"Hipparcos Number", "HIP 53261"},
        {"Fundamental Katalog 5th Edition", "FK5 2869"},
        {"Geneva Identification System", "GEN# +1.00094247"},
        {"Smithsonian Astrophysical Observation", "SAO 27815"},
        {"Wilson Evans Batten Catalogue", "WEB 9671"},
    },
    visualMagnitude: 5.12,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.39382839),
        dec: Angle.Degrees(+54.58515228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121922"},
        {"Hipparcos Number", "HIP 68138"},
        {"Smithsonian Astrophysical Observation", "SAO 28942"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.24931074),
        dec: Angle.Degrees(+54.58580900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107293",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107293"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.98543803),
        dec: Angle.Degrees(+54.58681151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78274",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78274"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.73757533),
        dec: Angle.Degrees(+54.58697839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5881"},
        {"Hipparcos Number", "HIP 4758"},
        {"Smithsonian Astrophysical Observation", "SAO 21921"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.28748464),
        dec: Angle.Degrees(+54.58844214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108316"},
        {"Hipparcos Number", "HIP 60693"},
        {"Smithsonian Astrophysical Observation", "SAO 28386"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.58428294),
        dec: Angle.Degrees(+54.58867167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46319"},
        {"Hipparcos Number", "HIP 31498"},
        {"Fundamental Katalog 5th Edition", "FK5 4599"},
        {"Geneva Identification System", "GEN# +1.00046319"},
        {"Smithsonian Astrophysical Observation", "SAO 25828"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.95350183),
        dec: Angle.Degrees(+54.58949682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195807"},
        {"Hipparcos Number", "HIP 101222"},
        {"Geneva Identification System", "GEN# +1.00195807"},
        {"Smithsonian Astrophysical Observation", "SAO 32647"},
        {"Wilson Evans Batten Catalogue", "WEB 18287"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.76815194),
        dec: Angle.Degrees(+54.59039550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224099"},
        {"Hipparcos Number", "HIP 117920"},
        {"Smithsonian Astrophysical Observation", "SAO 35887"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.77053199),
        dec: Angle.Degrees(+54.59059336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154299"},
        {"Hipparcos Number", "HIP 83319"},
        {"Smithsonian Astrophysical Observation", "SAO 30208"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.43255855),
        dec: Angle.Degrees(+54.59593875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203592"},
        {"Hipparcos Number", "HIP 105423"},
        {"Smithsonian Astrophysical Observation", "SAO 33345"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.31127164),
        dec: Angle.Degrees(+54.59972441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70203"},
        {"Hipparcos Number", "HIP 41105"},
        {"Geneva Identification System", "GEN# +1.00070203"},
        {"Smithsonian Astrophysical Observation", "SAO 26811"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.81620542),
        dec: Angle.Degrees(+54.60007014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168826"},
        {"Hipparcos Number", "HIP 89730"},
        {"Smithsonian Astrophysical Observation", "SAO 30885"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.67077679),
        dec: Angle.Degrees(+54.60017444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7713",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1286 AB"},
        {"Henry Draper", "HD 10031"},
        {"Hipparcos Number", "HIP 7713"},
        {"Smithsonian Astrophysical Observation", "SAO 22475"},
        {"Wilson Evans Batten Catalogue", "WEB 1651"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.82244990),
        dec: Angle.Degrees(+54.60050279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116956",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16941 AB"},
        {"Henry Draper", "HD 222672"},
        {"Hipparcos Number", "HIP 116956"},
        {"Renson", "Renson 61040"},
        {"Smithsonian Astrophysical Observation", "SAO 35688"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.61369618),
        dec: Angle.Degrees(+54.60084563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218713"},
        {"Hipparcos Number", "HIP 114343"},
        {"Geneva Identification System", "GEN# +1.00218713"},
        {"Smithsonian Astrophysical Observation", "SAO 35180"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.36549532),
        dec: Angle.Degrees(+54.60085989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45173"},
        {"Hipparcos Number", "HIP 30899"},
        {"Geneva Identification System", "GEN# +1.00045173"},
        {"Smithsonian Astrophysical Observation", "SAO 25758"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.28898387),
        dec: Angle.Degrees(+54.61182255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87426"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.99111131),
        dec: Angle.Degrees(+54.61260665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 197.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107084"},
        {"Hipparcos Number", "HIP 60029"},
        {"Smithsonian Astrophysical Observation", "SAO 28332"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.66327054),
        dec: Angle.Degrees(+54.61373027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39301",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6516 AB"},
        {"Henry Draper", "HD 65582"},
        {"Hipparcos Number", "HIP 39301"},
        {"Smithsonian Astrophysical Observation", "SAO 26629"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.53084004),
        dec: Angle.Degrees(+54.61523451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4383"},
        {"Hipparcos Number", "HIP 3661"},
        {"Smithsonian Astrophysical Observation", "SAO 21696"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.71537517),
        dec: Angle.Degrees(+54.61724981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237987"},
        {"Hipparcos Number", "HIP 55226"},
        {"Smithsonian Astrophysical Observation", "SAO 27981"},
    },
    visualMagnitude: 10.24,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.64496422),
        dec: Angle.Degrees(+54.61745469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232761"},
        {"Hipparcos Number", "HIP 14854"},
        {"Smithsonian Astrophysical Observation", "SAO 23868"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.96019807),
        dec: Angle.Degrees(+54.62391183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106939",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15190 AB"},
        {"Henry Draper", "HD 235580"},
        {"Hipparcos Number", "HIP 106939"},
        {"Smithsonian Astrophysical Observation", "SAO 33635"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.87009363),
        dec: Angle.Degrees(+54.62588176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8053"},
        {"Hipparcos Number", "HIP 6311"},
        {"Celescope Catalog", "CEL 138"},
        {"Smithsonian Astrophysical Observation", "SAO 22204"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.26814447),
        dec: Angle.Degrees(+54.62874719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139493"},
        {"Hipparcos Number", "HIP 76376"},
        {"Geneva Identification System", "GEN# +1.00139493"},
        {"Smithsonian Astrophysical Observation", "SAO 29588"},
        {"Wilson Evans Batten Catalogue", "WEB 12967"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.98782390),
        dec: Angle.Degrees(+54.63056806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111094"},
    },
    visualMagnitude: 12.02,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.60053922),
        dec: Angle.Degrees(+54.63204479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124819"},
        {"Hipparcos Number", "HIP 69535"},
        {"Geneva Identification System", "GEN# +1.00124819"},
        {"Smithsonian Astrophysical Observation", "SAO 29053"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.52234554),
        dec: Angle.Degrees(+54.63746830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205949"},
        {"Hipparcos Number", "HIP 106713"},
        {"Smithsonian Astrophysical Observation", "SAO 33576"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.23966971),
        dec: Angle.Degrees(+54.63779966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187253"},
        {"Hipparcos Number", "HIP 97286"},
        {"Smithsonian Astrophysical Observation", "SAO 31975"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.58007442),
        dec: Angle.Degrees(+54.63851331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235845"},
        {"Hipparcos Number", "HIP 110772"},
        {"Geneva Identification System", "GEN# +1.00235845"},
        {"Smithsonian Astrophysical Observation", "SAO 34454"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.63341689),
        dec: Angle.Degrees(+54.64153334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1811"},
        {"Hipparcos Number", "HIP 1794"},
        {"Geneva Identification System", "GEN# +1.00001811"},
        {"Smithsonian Astrophysical Observation", "SAO 21334"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.69916587),
        dec: Angle.Degrees(+54.64544917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97589",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13018 B"},
        {"Hipparcos Number", "HIP 97589"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.53426092),
        dec: Angle.Degrees(+54.64899412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97587",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13018 A"},
        {"Henry Draper", "HD 187979"},
        {"Hipparcos Number", "HIP 97587"},
        {"Smithsonian Astrophysical Observation", "SAO 32037"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.53138084),
        dec: Angle.Degrees(+54.65179137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4285"},
        {"Hipparcos Number", "HIP 3590"},
        {"Smithsonian Astrophysical Observation", "SAO 21683"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.46993246),
        dec: Angle.Degrees(+54.65239649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191373"},
        {"Hipparcos Number", "HIP 99086"},
        {"Geneva Identification System", "GEN# +1.00191373"},
        {"Smithsonian Astrophysical Observation", "SAO 32294"},
        {"Wilson Evans Batten Catalogue", "WEB 17621"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.73599916),
        dec: Angle.Degrees(+54.65271209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234447"},
        {"Hipparcos Number", "HIP 85594"},
        {"Smithsonian Astrophysical Observation", "SAO 30422"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.36436070),
        dec: Angle.Degrees(+54.65409598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25880",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4099 AB"},
        {"Henry Draper", "HD 35961"},
        {"Hipparcos Number", "HIP 25880"},
        {"Cincinnati Publication", "Ci 18 698"},
        {"Cincinnati Publication 2", "Ci 20 332"},
        {"Geneva Identification System", "GEN# +1.00035961J"},
        {"Wilson Evans Batten Catalogue", "WEB 5025"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.87120240),
        dec: Angle.Degrees(+54.65554473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -354.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79241",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9949 A"},
        {"Henry Draper", "HD 145822"},
        {"Hipparcos Number", "HIP 79241"},
        {"Smithsonian Astrophysical Observation", "SAO 29828"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.57379850),
        dec: Angle.Degrees(+54.65791248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43944"},
        {"Hipparcos Number", "HIP 30285"},
        {"Geneva Identification System", "GEN# +1.00043944"},
        {"Smithsonian Astrophysical Observation", "SAO 25686"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.55496242),
        dec: Angle.Degrees(+54.65857969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1210"},
        {"Hipparcos Number", "HIP 1329"},
        {"Smithsonian Astrophysical Observation", "SAO 21263"},
        {"Wilson Evans Batten Catalogue", "WEB 235"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.17353050),
        dec: Angle.Degrees(+54.66015605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164345"},
        {"Hipparcos Number", "HIP 87913"},
        {"Smithsonian Astrophysical Observation", "SAO 30659"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.38042530),
        dec: Angle.Degrees(+54.66555521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122865"},
        {"Hipparcos Number", "HIP 68621"},
        {"Geneva Identification System", "GEN# +1.00122865"},
        {"Smithsonian Astrophysical Observation", "SAO 28988"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.70806382),
        dec: Angle.Degrees(+54.66610308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202529"},
        {"Hipparcos Number", "HIP 104850"},
        {"Geneva Identification System", "GEN# +1.00202529"},
        {"Smithsonian Astrophysical Observation", "SAO 33252"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.59406947),
        dec: Angle.Degrees(+54.66675496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29516"},
        {"Hipparcos Number", "HIP 21846"},
        {"Smithsonian Astrophysical Observation", "SAO 24763"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.45132028),
        dec: Angle.Degrees(+54.67134006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22981"},
    },
    visualMagnitude: 11.02,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.18032753),
        dec: Angle.Degrees(+54.67185241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109926",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15797 A"},
        {"Henry Draper", "HD 211472"},
        {"Hipparcos Number", "HIP 109926"},
        {"Cincinnati Publication", "Ci 18 2902"},
        {"Geneva Identification System", "GEN# +1.00211472"},
        {"Smithsonian Astrophysical Observation", "SAO 34243"},
        {"Wilson Evans Batten Catalogue", "WEB 19734"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.97468327),
        dec: Angle.Degrees(+54.67272055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 213.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194444"},
        {"Hipparcos Number", "HIP 100526"},
        {"Smithsonian Astrophysical Observation", "SAO 32519"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.75553117),
        dec: Angle.Degrees(+54.67289120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64665"},
        {"Hipparcos Number", "HIP 38911"},
        {"Smithsonian Astrophysical Observation", "SAO 26591"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.45200847),
        dec: Angle.Degrees(+54.67389321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238179"},
        {"Hipparcos Number", "HIP 63415"},
        {"Geneva Identification System", "GEN# +1.00238179"},
        {"Smithsonian Astrophysical Observation", "SAO 28595"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.91615068),
        dec: Angle.Degrees(+54.67655089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238343"},
        {"Hipparcos Number", "HIP 70088"},
        {"Smithsonian Astrophysical Observation", "SAO 29110"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.13510863),
        dec: Angle.Degrees(+54.67672688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233383"},
        {"Hipparcos Number", "HIP 35983"},
        {"Smithsonian Astrophysical Observation", "SAO 26330"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.23792971),
        dec: Angle.Degrees(+54.67876601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195663"},
        {"Hipparcos Number", "HIP 101163"},
        {"Geneva Identification System", "GEN# +1.00195663"},
        {"Smithsonian Astrophysical Observation", "SAO 32636"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.57781498),
        dec: Angle.Degrees(+54.68073289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76217"},
        {"Hipparcos Number", "HIP 43953"},
        {"Smithsonian Astrophysical Observation", "SAO 27055"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.27943599),
        dec: Angle.Degrees(+54.68084197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119228"},
        {"Hipparcos Number", "HIP 66738"},
        {"Fundamental Katalog 5th Edition", "FK5 3087"},
        {"Geneva Identification System", "GEN# +1.00119228"},
        {"Smithsonian Astrophysical Observation", "SAO 28843"},
        {"Wilson Evans Batten Catalogue", "WEB 11772"},
    },
    visualMagnitude: 4.63,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.18455213),
        dec: Angle.Degrees(+54.68166149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232903"},
        {"Hipparcos Number", "HIP 19482"},
        {"Smithsonian Astrophysical Observation", "SAO 24450"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.59241422),
        dec: Angle.Degrees(+54.68236741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208107"},
        {"Hipparcos Number", "HIP 107971"},
        {"Geneva Identification System", "GEN# +1.00208107"},
        {"Smithsonian Astrophysical Observation", "SAO 33825"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.11278296),
        dec: Angle.Degrees(+54.68297712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80954"},
        {"Hipparcos Number", "HIP 46154"},
        {"Smithsonian Astrophysical Observation", "SAO 27240"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.18438290),
        dec: Angle.Degrees(+54.68370896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194883"},
        {"Hipparcos Number", "HIP 100744"},
        {"Celescope Catalog", "CEL 5060"},
        {"Geneva Identification System", "GEN# +1.00194883"},
        {"Smithsonian Astrophysical Observation", "SAO 32566"},
        {"Wilson Evans Batten Catalogue", "WEB 18204"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.38672298),
        dec: Angle.Degrees(+54.68421317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118287",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17151 AB"},
        {"Henry Draper", "HD 224647"},
        {"Henry Draper 2", "HD 224646"},
        {"Hipparcos Number", "HIP 118287"},
        {"Smithsonian Astrophysical Observation", "SAO 35961"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.88242301),
        dec: Angle.Degrees(+54.68849661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237714"},
        {"Hipparcos Number", "HIP 41551"},
        {"Smithsonian Astrophysical Observation", "SAO 26853"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.09010125),
        dec: Angle.Degrees(+54.69190287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234646"},
        {"Hipparcos Number", "HIP 90294"},
        {"Smithsonian Astrophysical Observation", "SAO 30962"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.35602039),
        dec: Angle.Degrees(+54.69358995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12433"},
        {"Hipparcos Number", "HIP 9593"},
        {"Geneva Identification System", "GEN# +1.00012433"},
        {"Smithsonian Astrophysical Observation", "SAO 22877"},
        {"Wilson Evans Batten Catalogue", "WEB 2018"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.85578656),
        dec: Angle.Degrees(+54.69359533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9723"},
        {"Hipparcos Number", "HIP 7494"},
        {"Celescope Catalog", "CEL 149"},
        {"Smithsonian Astrophysical Observation", "SAO 22428"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.11684940),
        dec: Angle.Degrees(+54.69615029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223321"},
        {"Hipparcos Number", "HIP 117405"},
        {"Smithsonian Astrophysical Observation", "SAO 35781"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.09704608),
        dec: Angle.Degrees(+54.69865883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82739"},
        {"Hipparcos Number", "HIP 47095"},
        {"Smithsonian Astrophysical Observation", "SAO 27306"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.96591544),
        dec: Angle.Degrees(+54.69958648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23895"},
        {"Hipparcos Number", "HIP 18035"},
        {"Geneva Identification System", "GEN# +1.00023895"},
        {"Smithsonian Astrophysical Observation", "SAO 24261"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.82425378),
        dec: Angle.Degrees(+54.70469196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15297",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15297"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.33962935),
        dec: Angle.Degrees(+54.70950027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63932"},
        {"Hipparcos Number", "HIP 38604"},
        {"Geneva Identification System", "GEN# +1.00063932"},
        {"Smithsonian Astrophysical Observation", "SAO 26561"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.55987869),
        dec: Angle.Degrees(+54.71525139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23674"},
        {"Hipparcos Number", "HIP 17901"},
        {"Geneva Identification System", "GEN# +1.00023674"},
        {"Smithsonian Astrophysical Observation", "SAO 24250"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.43161900),
        dec: Angle.Degrees(+54.71568931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237920"},
        {"Hipparcos Number", "HIP 52251"},
        {"Smithsonian Astrophysical Observation", "SAO 27728"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.14085981),
        dec: Angle.Degrees(+54.71973233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232951"},
        {"Hipparcos Number", "HIP 20720"},
        {"Smithsonian Astrophysical Observation", "SAO 24608"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.60849993),
        dec: Angle.Degrees(+54.72060430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237751"},
        {"Hipparcos Number", "HIP 43373"},
        {"Smithsonian Astrophysical Observation", "SAO 27009"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.52502632),
        dec: Angle.Degrees(+54.72256524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89267"},
        {"Hipparcos Number", "HIP 50533"},
        {"Smithsonian Astrophysical Observation", "SAO 27601"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.81755753),
        dec: Angle.Degrees(+54.72555360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162899"},
        {"Hipparcos Number", "HIP 87300"},
        {"Fundamental Katalog 5th Edition", "FK5 5569"},
        {"Geneva Identification System", "GEN# +1.00162899"},
        {"Smithsonian Astrophysical Observation", "SAO 30602"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.57194569),
        dec: Angle.Degrees(+54.72801167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234376"},
        {"Hipparcos Number", "HIP 83102"},
        {"Smithsonian Astrophysical Observation", "SAO 30186"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.72546898),
        dec: Angle.Degrees(+54.72846133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234884"},
        {"Hipparcos Number", "HIP 95311"},
        {"Fundamental Katalog 5th Edition", "FK5 5705"},
        {"Smithsonian Astrophysical Observation", "SAO 31625"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.87311627),
        dec: Angle.Degrees(+54.73131486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63348"},
        {"Hipparcos Number", "HIP 38354"},
        {"Smithsonian Astrophysical Observation", "SAO 26536"},
        {"Wilson Evans Batten Catalogue", "WEB 7543"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.83039821),
        dec: Angle.Degrees(+54.73232051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223036"},
        {"Hipparcos Number", "HIP 117205"},
        {"Geneva Identification System", "GEN# +1.00223036"},
        {"Smithsonian Astrophysical Observation", "SAO 35738"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.47942002),
        dec: Angle.Degrees(+54.73540769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32273",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5365 A"},
        {"Henry Draper", "HD 233277"},
        {"Hipparcos Number", "HIP 32273"},
        {"Smithsonian Astrophysical Observation", "SAO 25917"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.06792523),
        dec: Angle.Degrees(+54.73707883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100105"},
        {"Hipparcos Number", "HIP 56226"},
        {"Smithsonian Astrophysical Observation", "SAO 28045"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.89543895),
        dec: Angle.Degrees(+54.73750893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6833"},
        {"Hipparcos Number", "HIP 5458"},
        {"Geneva Identification System", "GEN# +1.00006833"},
        {"Smithsonian Astrophysical Observation", "SAO 22044"},
        {"Wilson Evans Batten Catalogue", "WEB 1200"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.46768151),
        dec: Angle.Degrees(+54.73887930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99732",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13583 AB"},
        {"Henry Draper", "HD 192782"},
        {"Hipparcos Number", "HIP 99732"},
        {"Celescope Catalog", "CEL 4989"},
        {"Geneva Identification System", "GEN# +1.00192782J"},
        {"Smithsonian Astrophysical Observation", "SAO 32384"},
    },
    visualMagnitude: 8.93,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.54446135),
        dec: Angle.Degrees(+54.74437238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39518",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6545 AB"},
        {"Henry Draper", "HD 66067"},
        {"Hipparcos Number", "HIP 39518"},
        {"Smithsonian Astrophysical Observation", "SAO 26648"},
    },
    visualMagnitude: 7.64,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.15421223),
        dec: Angle.Degrees(+54.74614925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88922"},
        {"Hipparcos Number", "HIP 50346"},
        {"Smithsonian Astrophysical Observation", "SAO 27587"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.20052861),
        dec: Angle.Degrees(+54.74615819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236044"},
        {"Hipparcos Number", "HIP 114141"},
        {"Geneva Identification System", "GEN# +1.00236044"},
        {"Smithsonian Astrophysical Observation", "SAO 35150"},
        {"Wilson Evans Batten Catalogue", "WEB 20269"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.74541724),
        dec: Angle.Degrees(+54.74678488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129937"},
        {"Hipparcos Number", "HIP 71980"},
        {"Smithsonian Astrophysical Observation", "SAO 29255"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.82926931),
        dec: Angle.Degrees(+54.74823111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143466"},
        {"Hipparcos Number", "HIP 78180"},
        {"Fundamental Katalog 5th Edition", "FK5 595"},
        {"Geneva Identification System", "GEN# +1.00143466"},
        {"Smithsonian Astrophysical Observation", "SAO 29727"},
        {"Wilson Evans Batten Catalogue", "WEB 13222"},
    },
    visualMagnitude: 4.96,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.44830388),
        dec: Angle.Degrees(+54.74950359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127206"},
        {"Hipparcos Number", "HIP 70759"},
        {"Smithsonian Astrophysical Observation", "SAO 29164"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.06220260),
        dec: Angle.Degrees(+54.75041844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128001"},
        {"Hipparcos Number", "HIP 71125"},
        {"Smithsonian Astrophysical Observation", "SAO 29192"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.16747578),
        dec: Angle.Degrees(+54.75196655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111627"},
        {"Hipparcos Number", "HIP 62631"},
        {"Smithsonian Astrophysical Observation", "SAO 28531"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.50308689),
        dec: Angle.Degrees(+54.75603655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237630"},
        {"Hipparcos Number", "HIP 37449"},
        {"Smithsonian Astrophysical Observation", "SAO 26462"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.31532806),
        dec: Angle.Degrees(+54.75616428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12557"},
        {"Hipparcos Number", "HIP 9691"},
        {"Smithsonian Astrophysical Observation", "SAO 22901"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.16610253),
        dec: Angle.Degrees(+54.75638434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215252"},
        {"Hipparcos Number", "HIP 112134"},
        {"Smithsonian Astrophysical Observation", "SAO 34725"},
        {"Wilson Evans Batten Catalogue", "WEB 20011"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.71625724),
        dec: Angle.Degrees(+54.75738322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24410",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3779 AB"},
        {"Henry Draper", "HD 33552"},
        {"Hipparcos Number", "HIP 24410"},
        {"Smithsonian Astrophysical Observation", "SAO 25084"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.55105100),
        dec: Angle.Degrees(+54.75881460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232524"},
        {"Hipparcos Number", "HIP 8246"},
        {"Celescope Catalog", "CEL 166"},
        {"Geneva Identification System", "GEN# +1.00232524"},
        {"Smithsonian Astrophysical Observation", "SAO 22606"},
        {"Wilson Evans Batten Catalogue", "WEB 1758"},
    },
    visualMagnitude: 9.29,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.54255800),
        dec: Angle.Degrees(+54.75919023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74095"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.14262501),
        dec: Angle.Degrees(+54.76355036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61361"},
        {"Hipparcos Number", "HIP 37501"},
        {"Smithsonian Astrophysical Observation", "SAO 26467"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.44957092),
        dec: Angle.Degrees(+54.76578948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142106"},
        {"Hipparcos Number", "HIP 77550"},
        {"Smithsonian Astrophysical Observation", "SAO 29683"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.50634472),
        dec: Angle.Degrees(+54.76653040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37923"},
        {"Hipparcos Number", "HIP 27132"},
        {"Smithsonian Astrophysical Observation", "SAO 25352"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.29972081),
        dec: Angle.Degrees(+54.76799036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234586"},
        {"Hipparcos Number", "HIP 89243"},
        {"Smithsonian Astrophysical Observation", "SAO 30813"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.17055356),
        dec: Angle.Degrees(+54.76858163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233129"},
        {"Hipparcos Number", "HIP 25919"},
        {"Smithsonian Astrophysical Observation", "SAO 25234"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.96970307),
        dec: Angle.Degrees(+54.76993767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3882"},
        {"Hipparcos Number", "HIP 3287"},
        {"Smithsonian Astrophysical Observation", "SAO 21634"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.48788385),
        dec: Angle.Degrees(+54.77003810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102730"},
        {"Hipparcos Number", "HIP 57685"},
        {"Smithsonian Astrophysical Observation", "SAO 28155"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.46093544),
        dec: Angle.Degrees(+54.77556620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103540"},
        {"Hipparcos Number", "HIP 58143"},
        {"Geneva Identification System", "GEN# +1.00103540"},
        {"Smithsonian Astrophysical Observation", "SAO 28188"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.86874523),
        dec: Angle.Degrees(+54.77934052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95719",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12509 A"},
        {"Henry Draper", "HD 183772"},
        {"Hipparcos Number", "HIP 95719"},
        {"Geneva Identification System", "GEN# +1.00183772"},
        {"Smithsonian Astrophysical Observation", "SAO 31686"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.04128755),
        dec: Angle.Degrees(+54.77977312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23820"},
        {"Hipparcos Number", "HIP 17989"},
        {"Geneva Identification System", "GEN# +1.00023820"},
        {"Smithsonian Astrophysical Observation", "SAO 24257"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.67724890),
        dec: Angle.Degrees(+54.78426011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66786"},
    },
    visualMagnitude: 11.39,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.31985897),
        dec: Angle.Degrees(+54.78506665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100615"},
        {"Hipparcos Number", "HIP 56510"},
        {"Fundamental Katalog 5th Edition", "FK5 2925"},
        {"Geneva Identification System", "GEN# +1.00100615"},
        {"Smithsonian Astrophysical Observation", "SAO 28064"},
        {"Wilson Evans Batten Catalogue", "WEB 10154"},
    },
    visualMagnitude: 5.63,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.77040437),
        dec: Angle.Degrees(+54.78537508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111071"},
        {"Geneva Identification System", "GEN# +0.05402790"},
        {"Wilson Evans Batten Catalogue", "WEB 19888"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.52389841),
        dec: Angle.Degrees(+54.79016909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147466"},
        {"Hipparcos Number", "HIP 79966"},
        {"Smithsonian Astrophysical Observation", "SAO 29888"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.83318424),
        dec: Angle.Degrees(+54.79100518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234673"},
        {"Hipparcos Number", "HIP 90818"},
        {"Smithsonian Astrophysical Observation", "SAO 31027"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.90052975),
        dec: Angle.Degrees(+54.79204973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61237",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8594 AB"},
        {"Henry Draper", "HD 109247"},
        {"Hipparcos Number", "HIP 61237"},
        {"Smithsonian Astrophysical Observation", "SAO 28423"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.22868699),
        dec: Angle.Degrees(+54.79527793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45704"},
        {"Hipparcos Number", "HIP 31151"},
        {"Geneva Identification System", "GEN# +1.00045704"},
        {"Smithsonian Astrophysical Observation", "SAO 25792"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.05318665),
        dec: Angle.Degrees(+54.79538166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86336"},
        {"Hipparcos Number", "HIP 48974"},
        {"Smithsonian Astrophysical Observation", "SAO 27460"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.85727872),
        dec: Angle.Degrees(+54.79809840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189371"},
        {"Hipparcos Number", "HIP 98165"},
        {"Smithsonian Astrophysical Observation", "SAO 32137"},
        {"Wilson Evans Batten Catalogue", "WEB 17305"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.24293944),
        dec: Angle.Degrees(+54.79950070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235813"},
        {"Hipparcos Number", "HIP 110441"},
        {"Geneva Identification System", "GEN# +1.00235813"},
        {"Smithsonian Astrophysical Observation", "SAO 34367"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.56096158),
        dec: Angle.Degrees(+54.80036109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25189"},
        {"Geneva Identification System", "GEN# +0.05400886"},
        {"Wilson Evans Batten Catalogue", "WEB 4881"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.83317317),
        dec: Angle.Degrees(+54.80062386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -396.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94316"},
        {"Hipparcos Number", "HIP 53304"},
        {"Fundamental Katalog 5th Edition", "FK5 4963"},
        {"Smithsonian Astrophysical Observation", "SAO 27820"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.53391345),
        dec: Angle.Degrees(+54.80097223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196195"},
        {"Hipparcos Number", "HIP 101433"},
        {"Geneva Identification System", "GEN# +1.00196195"},
        {"Smithsonian Astrophysical Observation", "SAO 32688"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.34752506),
        dec: Angle.Degrees(+54.80200333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99807"},
        {"Hipparcos Number", "HIP 56070"},
        {"Geneva Identification System", "GEN# +1.00099807"},
        {"Smithsonian Astrophysical Observation", "SAO 28033"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.38223650),
        dec: Angle.Degrees(+54.80210753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129779"},
        {"Hipparcos Number", "HIP 71900"},
        {"Geneva Identification System", "GEN# +1.00129779"},
        {"Smithsonian Astrophysical Observation", "SAO 29251"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.59680361),
        dec: Angle.Degrees(+54.80343684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54216",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8050 AB"},
        {"Henry Draper", "HD 96061"},
        {"Hipparcos Number", "HIP 54216"},
        {"Smithsonian Astrophysical Observation", "SAO 27895"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.39439246),
        dec: Angle.Degrees(+54.80796477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94817"},
        {"Hipparcos Number", "HIP 53587"},
        {"Geneva Identification System", "GEN# +1.00094817"},
        {"Smithsonian Astrophysical Observation", "SAO 27848"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.44389767),
        dec: Angle.Degrees(+54.81009747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93150"},
        {"Hipparcos Number", "HIP 52700"},
        {"Smithsonian Astrophysical Observation", "SAO 27763"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.62229388),
        dec: Angle.Degrees(+54.81279958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172391"},
        {"Hipparcos Number", "HIP 91257"},
        {"Smithsonian Astrophysical Observation", "SAO 31073"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.22065318),
        dec: Angle.Degrees(+54.81371902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87483"},
        {"Hipparcos Number", "HIP 49539"},
        {"Smithsonian Astrophysical Observation", "SAO 27521"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.72325658),
        dec: Angle.Degrees(+54.81511993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220240"},
        {"Hipparcos Number", "HIP 115336"},
        {"Geneva Identification System", "GEN# +1.00220240"},
        {"Smithsonian Astrophysical Observation", "SAO 35353"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.42032906),
        dec: Angle.Degrees(+54.81598481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232946"},
        {"Hipparcos Number", "HIP 20655"},
        {"Smithsonian Astrophysical Observation", "SAO 24599"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.38944064),
        dec: Angle.Degrees(+54.81874266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12025"},
        {"Hipparcos Number", "HIP 9306"},
        {"Geneva Identification System", "GEN# +1.00012025"},
        {"Smithsonian Astrophysical Observation", "SAO 22817"},
        {"Wilson Evans Batten Catalogue", "WEB 1954"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.89622399),
        dec: Angle.Degrees(+54.82226179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90715"},
        {"Hipparcos Number", "HIP 51391"},
        {"Smithsonian Astrophysical Observation", "SAO 27660"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.44948626),
        dec: Angle.Degrees(+54.82569057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25948"},
        {"Hipparcos Number", "HIP 19400"},
        {"Geneva Identification System", "GEN# +1.00025948"},
        {"Smithsonian Astrophysical Observation", "SAO 24440"},
        {"Wilson Evans Batten Catalogue", "WEB 3727"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.34233945),
        dec: Angle.Degrees(+54.82908817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55417"},
    },
    visualMagnitude: 10.79,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.23635839),
        dec: Angle.Degrees(+54.83286998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212106"},
        {"Hipparcos Number", "HIP 110309"},
        {"Geneva Identification System", "GEN# +1.00212106"},
        {"Smithsonian Astrophysical Observation", "SAO 34333"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.14434260),
        dec: Angle.Degrees(+54.84202846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235394"},
        {"Hipparcos Number", "HIP 103132"},
        {"Smithsonian Astrophysical Observation", "SAO 32974"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.42810330),
        dec: Angle.Degrees(+54.84249444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76272"},
        {"Hipparcos Number", "HIP 43981"},
        {"Geneva Identification System", "GEN# +1.00076272"},
        {"Smithsonian Astrophysical Observation", "SAO 27059"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.34361578),
        dec: Angle.Degrees(+54.84618093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216189"},
        {"Hipparcos Number", "HIP 112734"},
        {"Celescope Catalog", "CEL 5530"},
        {"Geneva Identification System", "GEN# +1.00216189"},
        {"Smithsonian Astrophysical Observation", "SAO 34859"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.44843672),
        dec: Angle.Degrees(+54.84682774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10108"},
        {"Hipparcos Number", "HIP 7790"},
        {"Geneva Identification System", "GEN# +1.00010108"},
        {"Smithsonian Astrophysical Observation", "SAO 22494"},
        {"Wilson Evans Batten Catalogue", "WEB 1670"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.06962968),
        dec: Angle.Degrees(+54.84688133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83325"},
        {"Hipparcos Number", "HIP 47404"},
        {"Smithsonian Astrophysical Observation", "SAO 27329"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.86823038),
        dec: Angle.Degrees(+54.84789287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3239"},
        {"Hipparcos Number", "HIP 2850"},
        {"Smithsonian Astrophysical Observation", "SAO 21549"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.02438099),
        dec: Angle.Degrees(+54.84847184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36915",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36915"},
    },
    visualMagnitude: 11.36,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.84164068),
        dec: Angle.Degrees(+54.84968136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109894"},
        {"Hipparcos Number", "HIP 61631"},
        {"Geneva Identification System", "GEN# +1.00109894"},
        {"Smithsonian Astrophysical Observation", "SAO 28458"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.48540217),
        dec: Angle.Degrees(+54.85312539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129079"},
        {"Hipparcos Number", "HIP 71602"},
        {"Geneva Identification System", "GEN# +1.00129079"},
        {"Smithsonian Astrophysical Observation", "SAO 29232"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.65644271),
        dec: Angle.Degrees(+54.85324294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45743"},
        {"Hipparcos Number", "HIP 31162"},
        {"Geneva Identification System", "GEN# +1.00045743"},
        {"Smithsonian Astrophysical Observation", "SAO 25794"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.08319104),
        dec: Angle.Degrees(+54.85383884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128781"},
        {"Hipparcos Number", "HIP 71463"},
        {"Smithsonian Astrophysical Observation", "SAO 29219"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.22610391),
        dec: Angle.Degrees(+54.85524058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13737"},
        {"Hipparcos Number", "HIP 10528"},
        {"Smithsonian Astrophysical Observation", "SAO 23097"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.91887270),
        dec: Angle.Degrees(+54.85581143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51638"},
        {"Hipparcos Number", "HIP 33816"},
        {"Smithsonian Astrophysical Observation", "SAO 26094"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.30671912),
        dec: Angle.Degrees(+54.85675967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223151"},
        {"Hipparcos Number", "HIP 117282"},
        {"Smithsonian Astrophysical Observation", "SAO 35755"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.71946307),
        dec: Angle.Degrees(+54.86125086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125632"},
        {"Hipparcos Number", "HIP 69958"},
        {"Geneva Identification System", "GEN# +1.00125632"},
        {"Smithsonian Astrophysical Observation", "SAO 29098"},
        {"Wilson Evans Batten Catalogue", "WEB 12166"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.73303042),
        dec: Angle.Degrees(+54.86377384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235949"},
        {"Hipparcos Number", "HIP 112398"},
        {"Smithsonian Astrophysical Observation", "SAO 34780"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.49514014),
        dec: Angle.Degrees(+54.86448935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32156"},
        {"Hipparcos Number", "HIP 23576"},
        {"Smithsonian Astrophysical Observation", "SAO 24987"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.03549364),
        dec: Angle.Degrees(+54.86452924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37735"},
        {"Hipparcos Number", "HIP 27027"},
        {"Smithsonian Astrophysical Observation", "SAO 25344"},
    },
    visualMagnitude: 6.95,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.99416761),
        dec: Angle.Degrees(+54.86486621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220908"},
        {"Hipparcos Number", "HIP 115761"},
        {"Geneva Identification System", "GEN# +1.00220908"},
        {"Smithsonian Astrophysical Observation", "SAO 35430"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.79141408),
        dec: Angle.Degrees(+54.86619054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238321"},
        {"Hipparcos Number", "HIP 68778"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.16291602),
        dec: Angle.Degrees(+54.86620043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 117.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120771"},
        {"Hipparcos Number", "HIP 67511"},
        {"Fundamental Katalog 5th Edition", "FK5 5221"},
        {"Geneva Identification System", "GEN# +1.00120771"},
        {"Smithsonian Astrophysical Observation", "SAO 28899"},
        {"Wilson Evans Batten Catalogue", "WEB 11872"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.50436383),
        dec: Angle.Degrees(+54.86945751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176730"},
        {"Hipparcos Number", "HIP 93173"},
        {"Geneva Identification System", "GEN# +1.00176730"},
        {"Smithsonian Astrophysical Observation", "SAO 31303"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.67440540),
        dec: Angle.Degrees(+54.87000574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238062"},
        {"Hipparcos Number", "HIP 58673"},
        {"Smithsonian Astrophysical Observation", "SAO 28223"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.45765984),
        dec: Angle.Degrees(+54.87097466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45593"},
        {"Hipparcos Number", "HIP 31103"},
        {"Geneva Identification System", "GEN# +1.00045593"},
        {"Smithsonian Astrophysical Observation", "SAO 25785"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.90281204),
        dec: Angle.Degrees(+54.87141469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140154"},
        {"Hipparcos Number", "HIP 76697"},
        {"Smithsonian Astrophysical Observation", "SAO 29611"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.91468519),
        dec: Angle.Degrees(+54.87207376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215757"},
        {"Hipparcos Number", "HIP 112434"},
        {"Celescope Catalog", "CEL 5522"},
        {"Geneva Identification System", "GEN# +1.00215757"},
        {"Smithsonian Astrophysical Observation", "SAO 34793"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.62327629),
        dec: Angle.Degrees(+54.87209555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206509"},
        {"Hipparcos Number", "HIP 107041"},
        {"Fundamental Katalog 5th Edition", "FK5 3731"},
        {"Geneva Identification System", "GEN# +1.00206509"},
        {"Smithsonian Astrophysical Observation", "SAO 33656"},
        {"Wilson Evans Batten Catalogue", "WEB 19337"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.18041373),
        dec: Angle.Degrees(+54.87214237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150028"},
        {"Hipparcos Number", "HIP 81228"},
        {"Smithsonian Astrophysical Observation", "SAO 30009"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.85560567),
        dec: Angle.Degrees(+54.87439279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235363"},
        {"Hipparcos Number", "HIP 102524"},
        {"Smithsonian Astrophysical Observation", "SAO 32881"},
        {"Wilson Evans Batten Catalogue", "WEB 18575"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.64985777),
        dec: Angle.Degrees(+54.87650630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13891"},
        {"Hipparcos Number", "HIP 10656"},
        {"Smithsonian Astrophysical Observation", "SAO 23125"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.29114329),
        dec: Angle.Degrees(+54.87852229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209636"},
        {"Hipparcos Number", "HIP 108879"},
        {"Celescope Catalog", "CEL 5427"},
        {"Geneva Identification System", "GEN# +1.00209636"},
        {"Smithsonian Astrophysical Observation", "SAO 34003"},
        {"Wilson Evans Batten Catalogue", "WEB 19585"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.83697723),
        dec: Angle.Degrees(+54.88005561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55600"},
        {"Hipparcos Number", "HIP 35214"},
        {"Smithsonian Astrophysical Observation", "SAO 26252"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.16258685),
        dec: Angle.Degrees(+54.88148559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124458"},
        {"Hipparcos Number", "HIP 69386"},
        {"Smithsonian Astrophysical Observation", "SAO 29039"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.05548480),
        dec: Angle.Degrees(+54.88321274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238159"},
        {"Hipparcos Number", "HIP 62220"},
        {"Smithsonian Astrophysical Observation", "SAO 28505"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.27978531),
        dec: Angle.Degrees(+54.88328155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170558"},
        {"Hipparcos Number", "HIP 90423"},
        {"Smithsonian Astrophysical Observation", "SAO 30978"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.74592414),
        dec: Angle.Degrees(+54.88518874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183318"},
        {"Hipparcos Number", "HIP 95545"},
        {"Smithsonian Astrophysical Observation", "SAO 31654"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.51499424),
        dec: Angle.Degrees(+54.88634632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10556"},
        {"Hipparcos Number", "HIP 8109"},
        {"Geneva Identification System", "GEN# +1.00010556"},
        {"Smithsonian Astrophysical Observation", "SAO 22567"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.05886914),
        dec: Angle.Degrees(+54.88648394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91909"},
        {"Hipparcos Number", "HIP 52040"},
        {"Smithsonian Astrophysical Observation", "SAO 27715"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.49856551),
        dec: Angle.Degrees(+54.88752093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232121"},
        {"Hipparcos Number", "HIP 871"},
        {"Smithsonian Astrophysical Observation", "SAO 21169"},
        {"Wilson Evans Batten Catalogue", "WEB 151"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.67528589),
        dec: Angle.Degrees(+54.89149475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97302"},
        {"Hipparcos Number", "HIP 54765"},
        {"Geneva Identification System", "GEN# +1.00097302"},
        {"Smithsonian Astrophysical Observation", "SAO 27952"},
        {"Wilson Evans Batten Catalogue", "WEB 9884"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.18520584),
        dec: Angle.Degrees(+54.89429192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2952"},
        {"Hipparcos Number", "HIP 2611"},
        {"Geneva Identification System", "GEN# +1.00002952"},
        {"Smithsonian Astrophysical Observation", "SAO 21512"},
        {"Wilson Evans Batten Catalogue", "WEB 478"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.29301467),
        dec: Angle.Degrees(+54.89508062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134382"},
        {"Hipparcos Number", "HIP 73994"},
        {"Smithsonian Astrophysical Observation", "SAO 29411"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.82272022),
        dec: Angle.Degrees(+54.89662894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173920"},
        {"Hipparcos Number", "HIP 91985"},
        {"Geneva Identification System", "GEN# +1.00173920"},
        {"Smithsonian Astrophysical Observation", "SAO 31151"},
        {"Wilson Evans Batten Catalogue", "WEB 15848"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.23079242),
        dec: Angle.Degrees(+54.89718881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75589",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9649 A"},
        {"Henry Draper", "HD 137972"},
        {"Hipparcos Number", "HIP 75589"},
        {"Smithsonian Astrophysical Observation", "SAO 29528"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.64537339),
        dec: Angle.Degrees(+54.89899317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75590",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9649 B"},
        {"Hipparcos Number", "HIP 75590"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.64987981),
        dec: Angle.Degrees(+54.90140195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30583"},
        {"Hipparcos Number", "HIP 22614"},
        {"Geneva Identification System", "GEN# +1.00030583"},
        {"Smithsonian Astrophysical Observation", "SAO 24877"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.98661849),
        dec: Angle.Degrees(+54.90263126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151187"},
        {"Hipparcos Number", "HIP 81835"},
        {"Wilson Evans Batten Catalogue", "WEB 13826"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.73280027),
        dec: Angle.Degrees(+54.90385987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232854"},
        {"Hipparcos Number", "HIP 18256"},
        {"Smithsonian Astrophysical Observation", "SAO 24284"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.57674414),
        dec: Angle.Degrees(+54.90434850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214693"},
        {"Hipparcos Number", "HIP 111817"},
        {"Smithsonian Astrophysical Observation", "SAO 34656"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.73415088),
        dec: Angle.Degrees(+54.90529618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234734"},
        {"Hipparcos Number", "HIP 92575"},
        {"Fundamental Katalog 5th Edition", "FK5 5661"},
        {"Smithsonian Astrophysical Observation", "SAO 31223"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.96469861),
        dec: Angle.Degrees(+54.90562940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8465"},
        {"Hipparcos Number", "HIP 6611"},
        {"Smithsonian Astrophysical Observation", "SAO 22258"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.22144388),
        dec: Angle.Degrees(+54.91172982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32016"},
        {"Hipparcos Number", "HIP 23509"},
        {"Geneva Identification System", "GEN# +1.00032016"},
        {"Smithsonian Astrophysical Observation", "SAO 24975"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.82264162),
        dec: Angle.Degrees(+54.91501560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41397"},
        {"Hipparcos Number", "HIP 29085"},
        {"Smithsonian Astrophysical Observation", "SAO 25579"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.03366327),
        dec: Angle.Degrees(+54.91520392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237757"},
        {"Hipparcos Number", "HIP 43544"},
        {"Smithsonian Astrophysical Observation", "SAO 27020"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.02564417),
        dec: Angle.Degrees(+54.91582209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151426"},
        {"Hipparcos Number", "HIP 81947"},
        {"Geneva Identification System", "GEN# +1.00151426"},
        {"Smithsonian Astrophysical Observation", "SAO 30072"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.08738392),
        dec: Angle.Degrees(+54.91732519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -283.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232822"},
        {"Hipparcos Number", "HIP 17285"},
        {"Geneva Identification System", "GEN# +1.00232822"},
        {"Smithsonian Astrophysical Observation", "SAO 24163"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.51025245),
        dec: Angle.Degrees(+54.92077089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236162"},
        {"Hipparcos Number", "HIP 116149"},
        {"Smithsonian Astrophysical Observation", "SAO 35521"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.99704896),
        dec: Angle.Degrees(+54.92083044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238244"},
        {"Hipparcos Number", "HIP 65960"},
        {"Smithsonian Astrophysical Observation", "SAO 28785"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.86129803),
        dec: Angle.Degrees(+54.92154301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 128.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35514",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5968 A"},
        {"Henry Draper", "HD 56385"},
        {"Hipparcos Number", "HIP 35514"},
        {"Smithsonian Astrophysical Observation", "SAO 26279"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.96369143),
        dec: Angle.Degrees(+54.92176715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6582"},
        {"Hipparcos Number", "HIP 5336"},
        {"Cincinnati Publication", "Ci 20 76"},
        {"Fundamental Katalog 5th Edition", "FK5 1030"},
        {"Geneva Identification System", "GEN# +1.00006582"},
        {"Smithsonian Astrophysical Observation", "SAO 22024"},
        {"Wilson Evans Batten Catalogue", "WEB 1137"},
    },
    visualMagnitude: 5.17,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.05383776),
        dec: Angle.Degrees(+54.92422766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3421.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1599.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11187"},
        {"Hipparcos Number", "HIP 8643"},
        {"Geneva Identification System", "GEN# +1.00011187"},
        {"Renson", "Renson 2770"},
        {"Smithsonian Astrophysical Observation", "SAO 22682"},
        {"Wilson Evans Batten Catalogue", "WEB 1827"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.86087626),
        dec: Angle.Degrees(+54.92470481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65378",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Mizar"},
        {"Aitken", "ADS 8891 AB"},
        {"Hipparcos Number", "HIP 65378"},
    },
    visualMagnitude: 2.23,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.98091604),
        dec: Angle.Degrees(+54.92541525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173189"},
        {"Hipparcos Number", "HIP 91611"},
        {"Geneva Identification System", "GEN# +1.00173189"},
        {"Smithsonian Astrophysical Observation", "SAO 31104"},
        {"Wilson Evans Batten Catalogue", "WEB 15754"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.25114778),
        dec: Angle.Degrees(+54.92617382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35516",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5968 B"},
        {"Henry Draper", "HD 56385B"},
        {"Hipparcos Number", "HIP 35516"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.96697984),
        dec: Angle.Degrees(+54.92679766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35571"},
        {"Hipparcos Number", "HIP 25650"},
        {"Smithsonian Astrophysical Observation", "SAO 25212"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.19510750),
        dec: Angle.Degrees(+54.92945306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194333"},
        {"Hipparcos Number", "HIP 100473"},
        {"Smithsonian Astrophysical Observation", "SAO 32512"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.62840152),
        dec: Angle.Degrees(+54.93221166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157615"},
        {"Hipparcos Number", "HIP 84912"},
        {"Geneva Identification System", "GEN# +1.00157615"},
        {"Smithsonian Astrophysical Observation", "SAO 30353"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.29808265),
        dec: Angle.Degrees(+54.94070763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7820",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1309 AB"},
        {"Henry Draper", "HD 10146"},
        {"Hipparcos Number", "HIP 7820"},
        {"Celescope Catalog", "CEL 155"},
        {"Smithsonian Astrophysical Observation", "SAO 22501"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.14646819),
        dec: Angle.Degrees(+54.94203001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132108"},
        {"Hipparcos Number", "HIP 73009"},
        {"Smithsonian Astrophysical Observation", "SAO 29337"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.81504140),
        dec: Angle.Degrees(+54.94368227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11215"},
        {"Hipparcos Number", "HIP 8675"},
        {"Renson", "Renson 2780"},
        {"Smithsonian Astrophysical Observation", "SAO 22684"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.91874859),
        dec: Angle.Degrees(+54.94389081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9366"},
        {"Hipparcos Number", "HIP 7253"},
        {"Fundamental Katalog 5th Edition", "FK5 4139"},
        {"Geneva Identification System", "GEN# +1.00009366"},
        {"Smithsonian Astrophysical Observation", "SAO 22391"},
        {"Wilson Evans Batten Catalogue", "WEB 1560"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.35978070),
        dec: Angle.Degrees(+54.94486941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130340"},
        {"Hipparcos Number", "HIP 72152"},
        {"Smithsonian Astrophysical Observation", "SAO 29267"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.37268727),
        dec: Angle.Degrees(+54.95144111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5468"},
        {"Hipparcos Number", "HIP 4466"},
        {"Smithsonian Astrophysical Observation", "SAO 21866"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.31008778),
        dec: Angle.Degrees(+54.95247914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43630",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7054 AB"},
        {"Henry Draper", "HD 75553"},
        {"Hipparcos Number", "HIP 43630"},
        {"Geneva Identification System", "GEN# +1.00075553"},
        {"Smithsonian Astrophysical Observation", "SAO 27027"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.28343041),
        dec: Angle.Degrees(+54.95295095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8546"},
        {"Hipparcos Number", "HIP 6667"},
        {"Smithsonian Astrophysical Observation", "SAO 22267"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.38822783),
        dec: Angle.Degrees(+54.95665498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3345"},
        {"Hipparcos Number", "HIP 2901"},
        {"Smithsonian Astrophysical Observation", "SAO 21562"},
        {"Wilson Evans Batten Catalogue", "WEB 523"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.19395809),
        dec: Angle.Degrees(+54.95739709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232412"},
        {"Hipparcos Number", "HIP 6045"},
        {"Smithsonian Astrophysical Observation", "SAO 22158"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.40651688),
        dec: Angle.Degrees(+54.95760646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185695"},
        {"Hipparcos Number", "HIP 96533"},
        {"Smithsonian Astrophysical Observation", "SAO 31831"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.38410519),
        dec: Angle.Degrees(+54.95786603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17209"},
        {"Hipparcos Number", "HIP 13056"},
        {"Smithsonian Astrophysical Observation", "SAO 23613"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.94912668),
        dec: Angle.Degrees(+54.95909451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140296"},
        {"Hipparcos Number", "HIP 76757"},
        {"Smithsonian Astrophysical Observation", "SAO 29617"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.09501188),
        dec: Angle.Degrees(+54.95968539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71658"},
        {"Hipparcos Number", "HIP 41779"},
        {"Smithsonian Astrophysical Observation", "SAO 26885"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.79093158),
        dec: Angle.Degrees(+54.95983221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112256"},
        {"Hipparcos Number", "HIP 63010"},
        {"Smithsonian Astrophysical Observation", "SAO 28559"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.66760673),
        dec: Angle.Degrees(+54.96110099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112396"},
        {"Hipparcos Number", "HIP 63096"},
        {"Celescope Catalog", "CEL 4173"},
        {"Geneva Identification System", "GEN# +1.00112396"},
        {"Smithsonian Astrophysical Observation", "SAO 28567"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.91270827),
        dec: Angle.Degrees(+54.96122153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8004"},
        {"Hipparcos Number", "HIP 6285"},
        {"Geneva Identification System", "GEN# +1.00008004"},
        {"Smithsonian Astrophysical Observation", "SAO 22200"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.15432320),
        dec: Angle.Degrees(+54.96255076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99472"},
        {"Hipparcos Number", "HIP 55883"},
        {"Smithsonian Astrophysical Observation", "SAO 28021"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.80718489),
        dec: Angle.Degrees(+54.96305162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26596"},
        {"Hipparcos Number", "HIP 19842"},
        {"Geneva Identification System", "GEN# +1.00026596"},
        {"Smithsonian Astrophysical Observation", "SAO 24497"},
        {"Wilson Evans Batten Catalogue", "WEB 3790"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.80748448),
        dec: Angle.Degrees(+54.96399655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16942"},
        {"Hipparcos Number", "HIP 12836"},
        {"Fundamental Katalog 5th Edition", "FK5 4251"},
        {"Smithsonian Astrophysical Observation", "SAO 23584"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.24881710),
        dec: Angle.Degrees(+54.96473604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185912"},
        {"Hipparcos Number", "HIP 96620"},
        {"Fundamental Katalog 5th Edition", "FK5 3571"},
        {"Geneva Identification System", "GEN# +1.00185912"},
        {"Smithsonian Astrophysical Observation", "SAO 31850"},
        {"Wilson Evans Batten Catalogue", "WEB 16952"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.67144862),
        dec: Angle.Degrees(+54.97339500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 163.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236122"},
        {"Hipparcos Number", "HIP 115737"},
        {"Smithsonian Astrophysical Observation", "SAO 35424"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.71445637),
        dec: Angle.Degrees(+54.97382064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21819"},
        {"Hipparcos Number", "HIP 16599"},
        {"Geneva Identification System", "GEN# +1.00021819"},
        {"Smithsonian Astrophysical Observation", "SAO 24099"},
        {"Wilson Evans Batten Catalogue", "WEB 3168"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.41292455),
        dec: Angle.Degrees(+54.97486087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4277"},
        {"Hipparcos Number", "HIP 3589"},
        {"Smithsonian Astrophysical Observation", "SAO 21682"},
        {"Wilson Evans Batten Catalogue", "WEB 635"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.46162953),
        dec: Angle.Degrees(+54.97801339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235539"},
        {"Hipparcos Number", "HIP 106377"},
        {"Smithsonian Astrophysical Observation", "SAO 33520"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.17182478),
        dec: Angle.Degrees(+54.97808221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78413"},
        {"Hipparcos Number", "HIP 45022"},
        {"Geneva Identification System", "GEN# +1.00078413"},
        {"Smithsonian Astrophysical Observation", "SAO 27149"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.55590357),
        dec: Angle.Degrees(+54.97872899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1278"},
        {"Hipparcos Number", "HIP 1381"},
        {"Smithsonian Astrophysical Observation", "SAO 21270"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.31607682),
        dec: Angle.Degrees(+54.98072550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232881"},
        {"Hipparcos Number", "HIP 19043"},
        {"Smithsonian Astrophysical Observation", "SAO 24393"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.19763696),
        dec: Angle.Degrees(+54.98127296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60443"},
    },
    visualMagnitude: 11.51,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.88254711),
        dec: Angle.Degrees(+54.98423842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -309.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238195"},
        {"Hipparcos Number", "HIP 64187"},
        {"Smithsonian Astrophysical Observation", "SAO 28649"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.32611693),
        dec: Angle.Degrees(+54.98428535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235258"},
        {"Hipparcos Number", "HIP 101171"},
        {"Smithsonian Astrophysical Observation", "SAO 32639"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.59802661),
        dec: Angle.Degrees(+54.98610517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47682",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47682"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.84086447),
        dec: Angle.Degrees(+54.98662719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23877",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3689 AB"},
        {"Henry Draper", "HD 32652"},
        {"Hipparcos Number", "HIP 23877"},
        {"Smithsonian Astrophysical Observation", "SAO 25033"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.96835498),
        dec: Angle.Degrees(+54.98668814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65477",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alcor"},
        {"Henry Draper", "HD 116842"},
        {"Hipparcos Number", "HIP 65477"},
        {"Celescope Catalog", "CEL 4258"},
        {"Geneva Identification System", "GEN# +1.00116842"},
        {"Smithsonian Astrophysical Observation", "SAO 28751"},
        {"Wilson Evans Batten Catalogue", "WEB 11557"},
    },
    visualMagnitude: 3.99,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.30589832),
        dec: Angle.Degrees(+54.98799884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232364"},
        {"Hipparcos Number", "HIP 5008"},
        {"Smithsonian Astrophysical Observation", "SAO 21969"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.02990635),
        dec: Angle.Degrees(+54.99164463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162524"},
        {"Hipparcos Number", "HIP 87145"},
        {"Smithsonian Astrophysical Observation", "SAO 30583"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.07175791),
        dec: Angle.Degrees(+54.99167823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2112"},
        {"Hipparcos Number", "HIP 2024"},
        {"Smithsonian Astrophysical Observation", "SAO 21387"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.42395970),
        dec: Angle.Degrees(+54.99421180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69766"},
        {"Hipparcos Number", "HIP 40930"},
        {"Smithsonian Astrophysical Observation", "SAO 26791"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.29174378),
        dec: Angle.Degrees(+54.99421812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28097"},
        {"Hipparcos Number", "HIP 20910"},
        {"Geneva Identification System", "GEN# +1.00028097"},
        {"Smithsonian Astrophysical Observation", "SAO 24640"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.22639948),
        dec: Angle.Degrees(+55.00052869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160155"},
        {"Hipparcos Number", "HIP 86058"},
        {"Smithsonian Astrophysical Observation", "SAO 30473"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.81781554),
        dec: Angle.Degrees(+55.00339173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201415"},
        {"Hipparcos Number", "HIP 104255"},
        {"Smithsonian Astrophysical Observation", "SAO 33151"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.82034236),
        dec: Angle.Degrees(+55.00374252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238135"},
        {"Hipparcos Number", "HIP 61274"},
        {"Smithsonian Astrophysical Observation", "SAO 28427"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.35583896),
        dec: Angle.Degrees(+55.00603185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131845"},
        {"Hipparcos Number", "HIP 72874"},
        {"Geneva Identification System", "GEN# +1.00131845"},
        {"Smithsonian Astrophysical Observation", "SAO 29326"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.42445482),
        dec: Angle.Degrees(+55.00994017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194737"},
        {"Hipparcos Number", "HIP 100684"},
        {"Smithsonian Astrophysical Observation", "SAO 32544"},
        {"Wilson Evans Batten Catalogue", "WEB 18194"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.19221972),
        dec: Angle.Degrees(+55.01124228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95001"},
        {"Hipparcos Number", "HIP 53680"},
        {"Geneva Identification System", "GEN# +1.00095001"},
        {"Smithsonian Astrophysical Observation", "SAO 27855"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.75161099),
        dec: Angle.Degrees(+55.01165397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89502"},
        {"Hipparcos Number", "HIP 50688"},
        {"Smithsonian Astrophysical Observation", "SAO 27613"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.26736504),
        dec: Angle.Degrees(+55.01381909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232901"},
        {"Hipparcos Number", "HIP 19485"},
        {"Smithsonian Astrophysical Observation", "SAO 24449"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.59657336),
        dec: Angle.Degrees(+55.01527903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214956"},
        {"Hipparcos Number", "HIP 111963"},
        {"Smithsonian Astrophysical Observation", "SAO 34690"},
        {"Wilson Evans Batten Catalogue", "WEB 19991"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.19697785),
        dec: Angle.Degrees(+55.01843190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232727"},
        {"Hipparcos Number", "HIP 13585"},
        {"Smithsonian Astrophysical Observation", "SAO 23693"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.74926647),
        dec: Angle.Degrees(+55.01965808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209218"},
        {"Hipparcos Number", "HIP 108607"},
        {"Geneva Identification System", "GEN# +1.00209218"},
        {"Smithsonian Astrophysical Observation", "SAO 33958"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.01945364),
        dec: Angle.Degrees(+55.01977493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189234"},
        {"Hipparcos Number", "HIP 98100"},
        {"Geneva Identification System", "GEN# +1.00189234"},
        {"Smithsonian Astrophysical Observation", "SAO 32125"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.04713381),
        dec: Angle.Degrees(+55.02354838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198819"},
        {"Hipparcos Number", "HIP 102897"},
        {"Smithsonian Astrophysical Observation", "SAO 32932"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.68407685),
        dec: Angle.Degrees(+55.02373399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28907"},
        {"Henry Draper 2", "HD 28907A"},
        {"Hipparcos Number", "HIP 21443"},
        {"Geneva Identification System", "GEN# +1.00028907"},
        {"Smithsonian Astrophysical Observation", "SAO 24710"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.07612542),
        dec: Angle.Degrees(+55.02658676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186635"},
        {"Hipparcos Number", "HIP 96989"},
        {"Smithsonian Astrophysical Observation", "SAO 31917"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.70557319),
        dec: Angle.Degrees(+55.02686950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95547"},
        {"Hipparcos Number", "HIP 53974"},
        {"Geneva Identification System", "GEN# +1.00095547"},
        {"Smithsonian Astrophysical Observation", "SAO 27879"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.62821258),
        dec: Angle.Degrees(+55.02833511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232358"},
        {"Hipparcos Number", "HIP 4955"},
        {"Smithsonian Astrophysical Observation", "SAO 21957"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.88917634),
        dec: Angle.Degrees(+55.02981759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11372",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11372"},
        {"Geneva Identification System", "GEN# +0.05400544"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.61945833),
        dec: Angle.Degrees(+55.03431951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208134"},
        {"Hipparcos Number", "HIP 107977"},
        {"Celescope Catalog", "CEL 5398"},
        {"Geneva Identification System", "GEN# +1.00208134"},
        {"Smithsonian Astrophysical Observation", "SAO 33828"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.12791230),
        dec: Angle.Degrees(+55.03985239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223684"},
        {"Hipparcos Number", "HIP 117651"},
        {"Smithsonian Astrophysical Observation", "SAO 35845"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.90489850),
        dec: Angle.Degrees(+55.04224703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30696"},
        {"Hipparcos Number", "HIP 22709"},
        {"Geneva Identification System", "GEN# +1.00030696"},
        {"Smithsonian Astrophysical Observation", "SAO 24893"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.25241776),
        dec: Angle.Degrees(+55.04492589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237561"},
        {"Hipparcos Number", "HIP 33236"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.72741893),
        dec: Angle.Degrees(+55.04519333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5126"},
        {"Hipparcos Number", "HIP 4227"},
        {"Smithsonian Astrophysical Observation", "SAO 21817"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.47938955),
        dec: Angle.Degrees(+55.04799897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214779"},
        {"Hipparcos Number", "HIP 111853"},
        {"Smithsonian Astrophysical Observation", "SAO 34662"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.85795135),
        dec: Angle.Degrees(+55.04877140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232171"},
        {"Hipparcos Number", "HIP 1811"},
        {"Smithsonian Astrophysical Observation", "SAO 21339"},
    },
    visualMagnitude: 9.74,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.74876131),
        dec: Angle.Degrees(+55.04925118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199067"},
        {"Hipparcos Number", "HIP 103024"},
        {"Celescope Catalog", "CEL 5191"},
        {"Geneva Identification System", "GEN# +1.00199067"},
        {"Smithsonian Astrophysical Observation", "SAO 32955"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.08734727),
        dec: Angle.Degrees(+55.05121306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34423"},
        {"Hipparcos Number", "HIP 24918"},
        {"Geneva Identification System", "GEN# +1.00034423"},
        {"Smithsonian Astrophysical Observation", "SAO 25132"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.09799610),
        dec: Angle.Degrees(+55.05165703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237729"},
        {"Hipparcos Number", "HIP 42126"},
        {"Smithsonian Astrophysical Observation", "SAO 26916"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.80890177),
        dec: Angle.Degrees(+55.05298798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235621"},
        {"Hipparcos Number", "HIP 107563"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.78156756),
        dec: Angle.Degrees(+55.05624417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156984"},
        {"Hipparcos Number", "HIP 84590"},
        {"Smithsonian Astrophysical Observation", "SAO 30326"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.37192095),
        dec: Angle.Degrees(+55.05638059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202970"},
        {"Hipparcos Number", "HIP 105081"},
        {"Smithsonian Astrophysical Observation", "SAO 33285"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.31177678),
        dec: Angle.Degrees(+55.05876712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236286"},
        {"Hipparcos Number", "HIP 281"},
        {"Smithsonian Astrophysical Observation", "SAO 21042"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.87618718),
        dec: Angle.Degrees(+55.05995058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43032"},
        {"Smithsonian Astrophysical Observation", "SAO 26989"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.52600818),
        dec: Angle.Degrees(+55.06269016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238260"},
        {"Hipparcos Number", "HIP 66532"},
        {"Smithsonian Astrophysical Observation", "SAO 28825"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.57531763),
        dec: Angle.Degrees(+55.06351864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23190"},
        {"Hipparcos Number", "HIP 17575"},
        {"Geneva Identification System", "GEN# +1.00023190"},
        {"Smithsonian Astrophysical Observation", "SAO 24195"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.46067731),
        dec: Angle.Degrees(+55.06387744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19030",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2957 AB"},
        {"Henry Draper", "HD 25362"},
        {"Hipparcos Number", "HIP 19030"},
        {"Geneva Identification System", "GEN# +1.00025362J"},
        {"Smithsonian Astrophysical Observation", "SAO 24391"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.15405780),
        dec: Angle.Degrees(+55.06656306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182715"},
        {"Hipparcos Number", "HIP 95268"},
        {"Smithsonian Astrophysical Observation", "SAO 31618"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.74041479),
        dec: Angle.Degrees(+55.06835605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237484"},
        {"Hipparcos Number", "HIP 30347"},
        {"Smithsonian Astrophysical Observation", "SAO 25694"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.74876147),
        dec: Angle.Degrees(+55.06971090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9839"},
        {"Hipparcos Number", "HIP 7563"},
        {"Smithsonian Astrophysical Observation", "SAO 22444"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.35440253),
        dec: Angle.Degrees(+55.07080294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215673"},
        {"Hipparcos Number", "HIP 112394"},
        {"Geneva Identification System", "GEN# +1.00215673"},
        {"Wilson Evans Batten Catalogue", "WEB 20049"},
    },
    visualMagnitude: 10.15,
    bvColour: 2.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.46338194),
        dec: Angle.Degrees(+55.07651797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78106"},
        {"Hipparcos Number", "HIP 44871"},
        {"Smithsonian Astrophysical Observation", "SAO 27134"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.14260617),
        dec: Angle.Degrees(+55.08488936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238143"},
        {"Hipparcos Number", "HIP 61686"},
        {"Smithsonian Astrophysical Observation", "SAO 28463"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.68259197),
        dec: Angle.Degrees(+55.08605497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13678"},
        {"Hipparcos Number", "HIP 10479"},
        {"Smithsonian Astrophysical Observation", "SAO 23085"},
        {"Wilson Evans Batten Catalogue", "WEB 2198"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.78207145),
        dec: Angle.Degrees(+55.08818955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219723"},
        {"Hipparcos Number", "HIP 115003"},
        {"Smithsonian Astrophysical Observation", "SAO 35298"},
    },
    visualMagnitude: 8.37,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.38047722),
        dec: Angle.Degrees(+55.08921385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235549"},
        {"Hipparcos Number", "HIP 106529"},
        {"Smithsonian Astrophysical Observation", "SAO 33543"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.64340045),
        dec: Angle.Degrees(+55.08924145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86589"},
        {"Hipparcos Number", "HIP 49087"},
        {"Smithsonian Astrophysical Observation", "SAO 27475"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.28179666),
        dec: Angle.Degrees(+55.09603534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47296",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47296"},
        {"Geneva Identification System", "GEN# +6.10060299"},
    },
    visualMagnitude: 12.15,
    bvColour: -0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.58478870),
        dec: Angle.Degrees(+55.09741519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210922"},
        {"Hipparcos Number", "HIP 109617"},
        {"Geneva Identification System", "GEN# +1.00210922"},
        {"Smithsonian Astrophysical Observation", "SAO 34164"},
        {"Wilson Evans Batten Catalogue", "WEB 19698"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.08829247),
        dec: Angle.Degrees(+55.09771354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235876"},
        {"Hipparcos Number", "HIP 111317"},
        {"Fundamental Katalog 5th Edition", "FK5 5988"},
        {"Geneva Identification System", "GEN# +1.00235876"},
        {"Smithsonian Astrophysical Observation", "SAO 34563"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.27400757),
        dec: Angle.Degrees(+55.09827124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238306"},
        {"Hipparcos Number", "HIP 68284"},
        {"Smithsonian Astrophysical Observation", "SAO 28954"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.67658191),
        dec: Angle.Degrees(+55.09899881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37282"},
        {"Hipparcos Number", "HIP 26710"},
        {"Geneva Identification System", "GEN# +1.00037282"},
        {"Smithsonian Astrophysical Observation", "SAO 25313"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.14609065),
        dec: Angle.Degrees(+55.09938282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165988"},
        {"Hipparcos Number", "HIP 88591"},
        {"Geneva Identification System", "GEN# +1.00165988"},
        {"Smithsonian Astrophysical Observation", "SAO 30740"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.33721782),
        dec: Angle.Degrees(+55.10543608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16727"},
        {"Hipparcos Number", "HIP 12692"},
        {"Celescope Catalog", "CEL 293"},
        {"Fundamental Katalog 5th Edition", "FK5 2188"},
        {"Geneva Identification System", "GEN# +1.00016727"},
        {"Renson", "Renson 4210"},
        {"Smithsonian Astrophysical Observation", "SAO 23555"},
        {"Wilson Evans Batten Catalogue", "WEB 2578"},
    },
    visualMagnitude: 5.76,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.76167775),
        dec: Angle.Degrees(+55.10607111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197308"},
        {"Hipparcos Number", "HIP 102027"},
        {"Celescope Catalog", "CEL 5142"},
        {"Geneva Identification System", "GEN# +1.00197308"},
        {"Smithsonian Astrophysical Observation", "SAO 32791"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.13703505),
        dec: Angle.Degrees(+55.10700274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237985"},
        {"Hipparcos Number", "HIP 55131"},
        {"Smithsonian Astrophysical Observation", "SAO 27975"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.30511955),
        dec: Angle.Degrees(+55.11021041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164526"},
        {"Hipparcos Number", "HIP 87984"},
        {"Geneva Identification System", "GEN# +1.00164526"},
        {"Smithsonian Astrophysical Observation", "SAO 30667"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.59015307),
        dec: Angle.Degrees(+55.11356902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56815"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.70113340),
        dec: Angle.Degrees(+55.11372049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224634"},
        {"Hipparcos Number", "HIP 118280"},
        {"Smithsonian Astrophysical Observation", "SAO 35960"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.87136251),
        dec: Angle.Degrees(+55.11852607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109011"},
        {"Hipparcos Number", "HIP 61100"},
        {"Geneva Identification System", "GEN# +1.00109011"},
        {"Smithsonian Astrophysical Observation", "SAO 28414"},
        {"Wilson Evans Batten Catalogue", "WEB 10876"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.82839037),
        dec: Angle.Degrees(+55.11884464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58361"},
        {"Hipparcos Number", "HIP 36297"},
        {"Smithsonian Astrophysical Observation", "SAO 26355"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.07276253),
        dec: Angle.Degrees(+55.12007603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41637",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41637"},
    },
    visualMagnitude: 11.97,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.36112516),
        dec: Angle.Degrees(+55.12410595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -328.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212689"},
        {"Hipparcos Number", "HIP 110647"},
        {"Smithsonian Astrophysical Observation", "SAO 34423"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.22878797),
        dec: Angle.Degrees(+55.12460479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216044"},
        {"Hipparcos Number", "HIP 112632"},
        {"Celescope Catalog", "CEL 5528"},
        {"Geneva Identification System", "GEN# +1.00216044"},
        {"Smithsonian Astrophysical Observation", "SAO 34843"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.18034787),
        dec: Angle.Degrees(+55.12605967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237840"},
        {"Hipparcos Number", "HIP 48150"},
        {"Smithsonian Astrophysical Observation", "SAO 27385"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.22899007),
        dec: Angle.Degrees(+55.12782245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238130"},
        {"Hipparcos Number", "HIP 61148"},
        {"Smithsonian Astrophysical Observation", "SAO 28417"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.96034078),
        dec: Angle.Degrees(+55.12898995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -279.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108605"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.01768093),
        dec: Angle.Degrees(+55.12899308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169509"},
        {"Hipparcos Number", "HIP 90000"},
        {"Smithsonian Astrophysical Observation", "SAO 30926"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.45205802),
        dec: Angle.Degrees(+55.12986545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152125"},
        {"Hipparcos Number", "HIP 82268"},
        {"Geneva Identification System", "GEN# +1.00152125"},
        {"Smithsonian Astrophysical Observation", "SAO 30108"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.14973162),
        dec: Angle.Degrees(+55.12988914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224031"},
        {"Hipparcos Number", "HIP 117874"},
        {"Smithsonian Astrophysical Observation", "SAO 35881"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.64355384),
        dec: Angle.Degrees(+55.13015185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192677"},
        {"Hipparcos Number", "HIP 99662"},
        {"Smithsonian Astrophysical Observation", "SAO 32377"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.36409013),
        dec: Angle.Degrees(+55.13135951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22283",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3433 A"},
        {"Henry Draper", "HD 233008"},
        {"Hipparcos Number", "HIP 22283"},
        {"Smithsonian Astrophysical Observation", "SAO 24828"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.96590878),
        dec: Angle.Degrees(+55.13400995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100755",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13857 AB"},
        {"Henry Draper", "HD 194907"},
        {"Hipparcos Number", "HIP 100755"},
        {"Smithsonian Astrophysical Observation", "SAO 32570"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.41959732),
        dec: Angle.Degrees(+55.13897703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96526"},
        {"Hipparcos Number", "HIP 54419"},
        {"Smithsonian Astrophysical Observation", "SAO 27920"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.04182619),
        dec: Angle.Degrees(+55.14500702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11241"},
        {"Hipparcos Number", "HIP 8704"},
        {"Celescope Catalog", "CEL 174"},
        {"Fundamental Katalog 5th Edition", "FK5 2122"},
        {"Geneva Identification System", "GEN# +1.00011241"},
        {"Smithsonian Astrophysical Observation", "SAO 22690"},
        {"Wilson Evans Batten Catalogue", "WEB 1835"},
    },
    visualMagnitude: 5.53,
    bvColour: -0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.99711412),
        dec: Angle.Degrees(+55.14740479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222472"},
        {"Hipparcos Number", "HIP 116828"},
        {"Smithsonian Astrophysical Observation", "SAO 35659"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.18028851),
        dec: Angle.Degrees(+55.14909108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50114"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.46466094),
        dec: Angle.Degrees(+55.14947798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6961"},
        {"Hipparcos Number", "HIP 5542"},
        {"Geneva Identification System", "GEN# +1.00006961"},
        {"Renson", "Renson 1773"},
        {"Smithsonian Astrophysical Observation", "SAO 22070"},
        {"Wilson Evans Batten Catalogue", "WEB 1235"},
    },
    visualMagnitude: 4.34,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.77471116),
        dec: Angle.Degrees(+55.14994765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 226.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235583"},
        {"Hipparcos Number", "HIP 106979"},
        {"Smithsonian Astrophysical Observation", "SAO 33647"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.00211397),
        dec: Angle.Degrees(+55.15208491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223110"},
        {"Hipparcos Number", "HIP 117259"},
        {"Geneva Identification System", "GEN# +1.00223110"},
        {"Smithsonian Astrophysical Observation", "SAO 35752"},
        {"Wilson Evans Batten Catalogue", "WEB 20661"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.64391794),
        dec: Angle.Degrees(+55.15229167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6656"},
        {"Hipparcos Number", "HIP 5333"},
        {"Geneva Identification System", "GEN# +1.00006656"},
        {"Smithsonian Astrophysical Observation", "SAO 22029"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.04889653),
        dec: Angle.Degrees(+55.15584278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215924"},
        {"Hipparcos Number", "HIP 112545"},
        {"Geneva Identification System", "GEN# +1.00215924"},
    },
    visualMagnitude: 8.34,
    bvColour: 2.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.93095859),
        dec: Angle.Degrees(+55.15842811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108346"},
        {"Hipparcos Number", "HIP 60712"},
        {"Geneva Identification System", "GEN# +1.00108346"},
        {"Renson", "Renson 31450"},
        {"Smithsonian Astrophysical Observation", "SAO 28388"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.63581798),
        dec: Angle.Degrees(+55.15942583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238744"},
        {"Hipparcos Number", "HIP 86781"},
        {"Smithsonian Astrophysical Observation", "SAO 30539"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.99236471),
        dec: Angle.Degrees(+55.15979845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189725"},
        {"Hipparcos Number", "HIP 98328"},
        {"Smithsonian Astrophysical Observation", "SAO 32161"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.66627875),
        dec: Angle.Degrees(+55.16391030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127761"},
        {"Hipparcos Number", "HIP 71007"},
        {"Geneva Identification System", "GEN# +1.00127761"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.83348435),
        dec: Angle.Degrees(+55.16587187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97210"},
        {"Hipparcos Number", "HIP 54709"},
        {"Smithsonian Astrophysical Observation", "SAO 27947"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.01638032),
        dec: Angle.Degrees(+55.16953861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180843"},
        {"Hipparcos Number", "HIP 94609"},
        {"Geneva Identification System", "GEN# +1.00180843"},
        {"Smithsonian Astrophysical Observation", "SAO 31517"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.79908469),
        dec: Angle.Degrees(+55.17072483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22298"},
        {"Hipparcos Number", "HIP 16941"},
        {"Geneva Identification System", "GEN# +1.00022298"},
        {"Smithsonian Astrophysical Observation", "SAO 24131"},
        {"Wilson Evans Batten Catalogue", "WEB 3223"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.50432789),
        dec: Angle.Degrees(+55.17086613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73352"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.85244503),
        dec: Angle.Degrees(+55.17158663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -188.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101604"},
        {"Hipparcos Number", "HIP 57045"},
        {"Geneva Identification System", "GEN# +1.00101604"},
        {"Smithsonian Astrophysical Observation", "SAO 28101"},
        {"Wilson Evans Batten Catalogue", "WEB 10267"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.43132179),
        dec: Angle.Degrees(+55.17199339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93133"},
        {"Hipparcos Number", "HIP 52684"},
        {"Geneva Identification System", "GEN# +1.00093133"},
        {"Smithsonian Astrophysical Observation", "SAO 27761"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.58886256),
        dec: Angle.Degrees(+55.17244547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85829",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10628 A"},
        {"Henry Draper", "HD 159560"},
        {"Hipparcos Number", "HIP 85829"},
        {"Fundamental Katalog 5th Edition", "FK5 657"},
        {"Geneva Identification System", "GEN# +1.00159560"},
        {"Renson", "Renson 44910"},
        {"Smithsonian Astrophysical Observation", "SAO 30450"},
        {"Wilson Evans Batten Catalogue", "WEB 14485"},
    },
    visualMagnitude: 4.86,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.06616249),
        dec: Angle.Degrees(+55.17280674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144246"},
        {"Hipparcos Number", "HIP 78548"},
        {"Smithsonian Astrophysical Observation", "SAO 29767"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.55002954),
        dec: Angle.Degrees(+55.17462663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205571"},
        {"Hipparcos Number", "HIP 106504"},
        {"Smithsonian Astrophysical Observation", "SAO 33538"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.57703810),
        dec: Angle.Degrees(+55.17588287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234835"},
        {"Hipparcos Number", "HIP 94406"},
        {"Smithsonian Astrophysical Observation", "SAO 31479"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.21677382),
        dec: Angle.Degrees(+55.17662904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85819",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10628 B"},
        {"Henry Draper", "HD 159541"},
        {"Hipparcos Number", "HIP 85819"},
        {"Fundamental Katalog 5th Edition", "FK5 655"},
        {"Geneva Identification System", "GEN# +1.00159541"},
        {"Renson", "Renson 44890"},
        {"Smithsonian Astrophysical Observation", "SAO 30447"},
        {"Wilson Evans Batten Catalogue", "WEB 14483"},
    },
    visualMagnitude: 4.89,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.04340826),
        dec: Angle.Degrees(+55.18411077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236115"},
        {"Hipparcos Number", "HIP 115543"},
        {"Smithsonian Astrophysical Observation", "SAO 35388"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.06653560),
        dec: Angle.Degrees(+55.18505610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21697"},
        {"Hipparcos Number", "HIP 16514"},
        {"Geneva Identification System", "GEN# +1.00021697"},
        {"Smithsonian Astrophysical Observation", "SAO 24085"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.15874364),
        dec: Angle.Degrees(+55.18532594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27265"},
        {"Hipparcos Number", "HIP 20327"},
        {"Smithsonian Astrophysical Observation", "SAO 24558"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.32107919),
        dec: Angle.Degrees(+55.18794638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18439"},
        {"Hipparcos Number", "HIP 13980"},
        {"Geneva Identification System", "GEN# +1.00018439"},
        {"Smithsonian Astrophysical Observation", "SAO 23753"},
        {"Wilson Evans Batten Catalogue", "WEB 2758"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.01694792),
        dec: Angle.Degrees(+55.18816872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53075"},
        {"Hipparcos Number", "HIP 34320"},
        {"Geneva Identification System", "GEN# +1.00053075"},
        {"Smithsonian Astrophysical Observation", "SAO 26153"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.72233634),
        dec: Angle.Degrees(+55.18971559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219612"},
        {"Hipparcos Number", "HIP 114911"},
        {"Geneva Identification System", "GEN# +1.00219612"},
        {"Smithsonian Astrophysical Observation", "SAO 35283"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.13277836),
        dec: Angle.Degrees(+55.19079271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80792"},
        {"Hipparcos Number", "HIP 46082"},
        {"Smithsonian Astrophysical Observation", "SAO 27235"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.96006559),
        dec: Angle.Degrees(+55.19343732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138338"},
        {"Hipparcos Number", "HIP 75788"},
        {"Fundamental Katalog 5th Edition", "FK5 3222"},
        {"Geneva Identification System", "GEN# +1.00138338"},
        {"Renson", "Renson 39380"},
        {"Smithsonian Astrophysical Observation", "SAO 29540"},
        {"Wilson Evans Batten Catalogue", "WEB 12901"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.23679161),
        dec: Angle.Degrees(+55.19484910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238253"},
        {"Hipparcos Number", "HIP 66130"},
        {"Smithsonian Astrophysical Observation", "SAO 28799"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.35259821),
        dec: Angle.Degrees(+55.19549125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238466"},
        {"Hipparcos Number", "HIP 75918"},
        {"Geneva Identification System", "GEN# +1.00238466"},
        {"Smithsonian Astrophysical Observation", "SAO 29550"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.59252383),
        dec: Angle.Degrees(+55.19797896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111243",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16032 AB"},
        {"Henry Draper", "HD 213719"},
        {"Hipparcos Number", "HIP 111243"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.07364978),
        dec: Angle.Degrees(+55.19936736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238338"},
        {"Hipparcos Number", "HIP 69873"},
        {"Smithsonian Astrophysical Observation", "SAO 29091"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.48218527),
        dec: Angle.Degrees(+55.20305760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69497"},
        {"Hipparcos Number", "HIP 40847"},
        {"Geneva Identification System", "GEN# +1.00069497"},
        {"Smithsonian Astrophysical Observation", "SAO 26779"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.02107828),
        dec: Angle.Degrees(+55.20381436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148330"},
        {"Hipparcos Number", "HIP 80375"},
        {"Fundamental Katalog 5th Edition", "FK5 614"},
        {"Geneva Identification System", "GEN# +1.00148330"},
        {"Renson", "Renson 41910"},
        {"Smithsonian Astrophysical Observation", "SAO 29931"},
        {"Wilson Evans Batten Catalogue", "WEB 13599"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.10552808),
        dec: Angle.Degrees(+55.20504560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77496"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.36444202),
        dec: Angle.Degrees(+55.20532938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60614"},
        {"Hipparcos Number", "HIP 37178"},
        {"Geneva Identification System", "GEN# +1.00060614"},
        {"Smithsonian Astrophysical Observation", "SAO 26436"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.58354819),
        dec: Angle.Degrees(+55.20565777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222887"},
        {"Hipparcos Number", "HIP 117103"},
        {"Smithsonian Astrophysical Observation", "SAO 35721"},
        {"Wilson Evans Batten Catalogue", "WEB 20642"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.09524919),
        dec: Angle.Degrees(+55.20641758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206843"},
        {"Hipparcos Number", "HIP 107228"},
        {"Geneva Identification System", "GEN# +1.00206843"},
        {"Smithsonian Astrophysical Observation", "SAO 33686"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.76451575),
        dec: Angle.Degrees(+55.20909390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 292.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63586"},
        {"Hipparcos Number", "HIP 38449"},
        {"Geneva Identification System", "GEN# +1.00063586"},
        {"Smithsonian Astrophysical Observation", "SAO 26543"},
        {"Wilson Evans Batten Catalogue", "WEB 7561"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.15188452),
        dec: Angle.Degrees(+55.20954589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107316",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15283 AB"},
        {"Henry Draper", "HD 235602"},
        {"Hipparcos Number", "HIP 107316"},
        {"Smithsonian Astrophysical Observation", "SAO 33706"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.05423275),
        dec: Angle.Degrees(+55.21049875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217554"},
        {"Hipparcos Number", "HIP 113614"},
        {"Smithsonian Astrophysical Observation", "SAO 35051"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.16837542),
        dec: Angle.Degrees(+55.21101455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232350"},
        {"Hipparcos Number", "HIP 4798"},
        {"Smithsonian Astrophysical Observation", "SAO 21928"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.39528042),
        dec: Angle.Degrees(+55.21288333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2887"},
        {"Hipparcos Number", "HIP 2562"},
        {"Renson", "Renson 700"},
        {"Smithsonian Astrophysical Observation", "SAO 21503"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.14033852),
        dec: Angle.Degrees(+55.21475694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3368"},
        {"Hipparcos Number", "HIP 2922"},
        {"Smithsonian Astrophysical Observation", "SAO 21569"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.25650821),
        dec: Angle.Degrees(+55.21726126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232541"},
        {"Hipparcos Number", "HIP 8570"},
        {"Smithsonian Astrophysical Observation", "SAO 22661"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.62869275),
        dec: Angle.Degrees(+55.21745646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200206"},
        {"Hipparcos Number", "HIP 103633"},
        {"Smithsonian Astrophysical Observation", "SAO 33050"},
        {"Wilson Evans Batten Catalogue", "WEB 18856"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.95679267),
        dec: Angle.Degrees(+55.21803298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17248",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17248"},
    },
    visualMagnitude: 11.34,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.40491007),
        dec: Angle.Degrees(+55.21884753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55882",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8164 AB"},
        {"Henry Draper", "HD 99489"},
        {"Hipparcos Number", "HIP 55882"},
        {"Smithsonian Astrophysical Observation", "SAO 28022"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.80701006),
        dec: Angle.Degrees(+55.21964018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3544",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 625 AB"},
        {"Henry Draper", "HD 4222"},
        {"Hipparcos Number", "HIP 3544"},
        {"Geneva Identification System", "GEN# +1.00004222J"},
        {"Renson", "Renson 1150"},
        {"Smithsonian Astrophysical Observation", "SAO 21677"},
        {"Wilson Evans Batten Catalogue", "WEB 626"},
    },
    visualMagnitude: 5.41,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.32168124),
        dec: Angle.Degrees(+55.22140870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133349"},
        {"Hipparcos Number", "HIP 73525"},
        {"Smithsonian Astrophysical Observation", "SAO 29384"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.42421869),
        dec: Angle.Degrees(+55.22313210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3410"},
        {"Hipparcos Number", "HIP 2955"},
        {"Geneva Identification System", "GEN# +1.00003410"},
        {"Smithsonian Astrophysical Observation", "SAO 21573"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.37998797),
        dec: Angle.Degrees(+55.22536577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235199"},
        {"Hipparcos Number", "HIP 100403"},
        {"Fundamental Katalog 5th Edition", "FK5 5793"},
        {"Smithsonian Astrophysical Observation", "SAO 32505"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.40984536),
        dec: Angle.Degrees(+55.22649092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20750"},
        {"Hipparcos Number", "HIP 15763"},
        {"Geneva Identification System", "GEN# +1.00020750"},
        {"Smithsonian Astrophysical Observation", "SAO 23991"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.77315027),
        dec: Angle.Degrees(+55.23015512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200857"},
        {"Hipparcos Number", "HIP 103966"},
        {"Geneva Identification System", "GEN# +1.00200857"},
        {"Smithsonian Astrophysical Observation", "SAO 33102"},
        {"Wilson Evans Batten Catalogue", "WEB 18936"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.97022622),
        dec: Angle.Degrees(+55.23030654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116634",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16886 AB"},
        {"Henry Draper", "HD 222186"},
        {"Hipparcos Number", "HIP 116634"},
        {"Renson", "Renson 60890"},
        {"Smithsonian Astrophysical Observation", "SAO 35629"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.54010028),
        dec: Angle.Degrees(+55.23185094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12401"},
        {"Hipparcos Number", "HIP 9582"},
        {"Geneva Identification System", "GEN# +1.00012401"},
        {"Smithsonian Astrophysical Observation", "SAO 22875"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.78899824),
        dec: Angle.Degrees(+55.23239813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212455"},
        {"Hipparcos Number", "HIP 110500"},
        {"Geneva Identification System", "GEN# +1.00212455"},
        {"Smithsonian Astrophysical Observation", "SAO 34382"},
        {"Wilson Evans Batten Catalogue", "WEB 19805"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.75655580),
        dec: Angle.Degrees(+55.23294452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71222",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9315 AB"},
        {"Henry Draper", "HD 128230"},
        {"Hipparcos Number", "HIP 71222"},
        {"Smithsonian Astrophysical Observation", "SAO 29198"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.46867361),
        dec: Angle.Degrees(+55.23598654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113797",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16474 A"},
        {"Henry Draper", "HD 217833"},
        {"Hipparcos Number", "HIP 113797"},
        {"Celescope Catalog", "CEL 5560"},
        {"Geneva Identification System", "GEN# +1.00217833A"},
        {"Renson", "Renson 60060"},
        {"Smithsonian Astrophysical Observation", "SAO 35092"},
    },
    visualMagnitude: 6.51,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.68282868),
        dec: Angle.Degrees(+55.23637455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172711"},
        {"Hipparcos Number", "HIP 91407"},
        {"Geneva Identification System", "GEN# +1.00172711"},
        {"Smithsonian Astrophysical Observation", "SAO 31083"},
        {"Wilson Evans Batten Catalogue", "WEB 15710"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.63342902),
        dec: Angle.Degrees(+55.24513135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237522"},
        {"Hipparcos Number", "HIP 31927"},
        {"Smithsonian Astrophysical Observation", "SAO 25865"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.08236996),
        dec: Angle.Degrees(+55.24576460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210072"},
        {"Hipparcos Number", "HIP 109130"},
        {"Geneva Identification System", "GEN# +1.00210072"},
        {"Smithsonian Astrophysical Observation", "SAO 34058"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.57365316),
        dec: Angle.Degrees(+55.24680703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141243"},
        {"Hipparcos Number", "HIP 77178"},
        {"Smithsonian Astrophysical Observation", "SAO 29648"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.37273879),
        dec: Angle.Degrees(+55.25089818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235825"},
        {"Hipparcos Number", "HIP 110525"},
        {"Geneva Identification System", "GEN# +1.00235825"},
        {"Smithsonian Astrophysical Observation", "SAO 34394"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.86970197),
        dec: Angle.Degrees(+55.25179973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48841"},
        {"Hipparcos Number", "HIP 32645"},
        {"Smithsonian Astrophysical Observation", "SAO 25966"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.15338414),
        dec: Angle.Degrees(+55.25226169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11275",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1829 A"},
        {"Henry Draper", "HD 14827"},
        {"Hipparcos Number", "HIP 11275"},
        {"Celescope Catalog", "CEL 268"},
        {"Geneva Identification System", "GEN# +1.00014827"},
        {"Smithsonian Astrophysical Observation", "SAO 23305"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.30500908),
        dec: Angle.Degrees(+55.25457089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67147"},
        {"Hipparcos Number", "HIP 39944"},
        {"Geneva Identification System", "GEN# +1.00067147"},
        {"Smithsonian Astrophysical Observation", "SAO 26696"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.37028742),
        dec: Angle.Degrees(+55.25591194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22854",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3508 A"},
        {"Henry Draper", "HD 30958"},
        {"Hipparcos Number", "HIP 22854"},
        {"Fundamental Katalog 5th Edition", "FK5 2367"},
        {"Geneva Identification System", "GEN# +1.00030958"},
        {"Smithsonian Astrophysical Observation", "SAO 24904"},
        {"Wilson Evans Batten Catalogue", "WEB 4428"},
    },
    visualMagnitude: 5.52,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.76309080),
        dec: Angle.Degrees(+55.25912955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38793"},
        {"Hipparcos Number", "HIP 27672"},
        {"Geneva Identification System", "GEN# +1.00038793"},
        {"Smithsonian Astrophysical Observation", "SAO 25416"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.87169515),
        dec: Angle.Degrees(+55.26139501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184423"},
        {"Hipparcos Number", "HIP 96028"},
        {"Smithsonian Astrophysical Observation", "SAO 31746"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.86809912),
        dec: Angle.Degrees(+55.26444546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 138.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236032"},
        {"Hipparcos Number", "HIP 113908"},
        {"Smithsonian Astrophysical Observation", "SAO 35113"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.01252764),
        dec: Angle.Degrees(+55.26553804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79796"},
        {"Geneva Identification System", "GEN# +0.05501823"},
        {"Wilson Evans Batten Catalogue", "WEB 13508"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.27210498),
        dec: Angle.Degrees(+55.27025957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -442.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165700"},
        {"Hipparcos Number", "HIP 88479"},
        {"Geneva Identification System", "GEN# +1.00165700"},
        {"Smithsonian Astrophysical Observation", "SAO 30724"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.00215233),
        dec: Angle.Degrees(+55.27348263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82052"},
        {"Hipparcos Number", "HIP 46726"},
        {"Smithsonian Astrophysical Observation", "SAO 27278"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.87151104),
        dec: Angle.Degrees(+55.27351910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201976"},
        {"Hipparcos Number", "HIP 104568"},
        {"Smithsonian Astrophysical Observation", "SAO 33193"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.74356989),
        dec: Angle.Degrees(+55.27355934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235121"},
        {"Hipparcos Number", "HIP 99387"},
        {"Smithsonian Astrophysical Observation", "SAO 32332"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.59278937),
        dec: Angle.Degrees(+55.27361226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237986"},
        {"Hipparcos Number", "HIP 55217"},
        {"Smithsonian Astrophysical Observation", "SAO 27979"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.61884585),
        dec: Angle.Degrees(+55.27517775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232407"},
        {"Hipparcos Number", "HIP 5934"},
        {"Smithsonian Astrophysical Observation", "SAO 22138"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.06984071),
        dec: Angle.Degrees(+55.27890904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8891"},
        {"Hipparcos Number", "HIP 6904"},
        {"Smithsonian Astrophysical Observation", "SAO 22314"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.22273794),
        dec: Angle.Degrees(+55.27898577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158083"},
        {"Hipparcos Number", "HIP 85140"},
        {"Smithsonian Astrophysical Observation", "SAO 30369"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.99097791),
        dec: Angle.Degrees(+55.27925499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35785",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6012 A"},
        {"Henry Draper", "HD 57103"},
        {"Hipparcos Number", "HIP 35785"},
        {"Fundamental Katalog 5th Edition", "FK5 280"},
        {"Geneva Identification System", "GEN# +1.00057103"},
        {"Smithsonian Astrophysical Observation", "SAO 26312"},
        {"Wilson Evans Batten Catalogue", "WEB 7132"},
    },
    visualMagnitude: 5.80,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.71692703),
        dec: Angle.Degrees(+55.28146955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211774"},
        {"Hipparcos Number", "HIP 110090"},
        {"Geneva Identification System", "GEN# +1.00211774"},
        {"Smithsonian Astrophysical Observation", "SAO 34286"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.51730141),
        dec: Angle.Degrees(+55.28147706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 973"},
        {"Hipparcos Number", "HIP 1139"},
        {"Smithsonian Astrophysical Observation", "SAO 21229"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.56007336),
        dec: Angle.Degrees(+55.28323532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35783",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6012 B"},
        {"Henry Draper", "HD 57102"},
        {"Hipparcos Number", "HIP 35783"},
        {"Geneva Identification System", "GEN# +1.00057102"},
        {"Smithsonian Astrophysical Observation", "SAO 26311"},
        {"Wilson Evans Batten Catalogue", "WEB 7131"},
    },
    visualMagnitude: 6.86,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.71188704),
        dec: Angle.Degrees(+55.28439308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15485"},
        {"Hipparcos Number", "HIP 11746"},
        {"Smithsonian Astrophysical Observation", "SAO 23401"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.89477506),
        dec: Angle.Degrees(+55.28745058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87898"},
        {"Hipparcos Number", "HIP 49775"},
        {"Smithsonian Astrophysical Observation", "SAO 27539"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.40993054),
        dec: Angle.Degrees(+55.28841867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109508"},
        {"Hipparcos Number", "HIP 61377"},
        {"Smithsonian Astrophysical Observation", "SAO 28431"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.67161946),
        dec: Angle.Degrees(+55.28872892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232341"},
        {"Hipparcos Number", "HIP 4679"},
        {"Smithsonian Astrophysical Observation", "SAO 21906"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.03463964),
        dec: Angle.Degrees(+55.29066293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197795"},
        {"Hipparcos Number", "HIP 102284"},
        {"Celescope Catalog", "CEL 5157"},
        {"Geneva Identification System", "GEN# +1.00197795"},
        {"Smithsonian Astrophysical Observation", "SAO 32834"},
        {"Wilson Evans Batten Catalogue", "WEB 18518"},
    },
    visualMagnitude: 6.96,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.87241735),
        dec: Angle.Degrees(+55.29182150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109316"},
        {"Hipparcos Number", "HIP 61267"},
        {"Smithsonian Astrophysical Observation", "SAO 28426"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.33599552),
        dec: Angle.Degrees(+55.29230679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101767"},
        {"Hipparcos Number", "HIP 57135"},
        {"Smithsonian Astrophysical Observation", "SAO 28107"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.71763406),
        dec: Angle.Degrees(+55.29313493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105630",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14945 AB"},
        {"Henry Draper", "HD 204000"},
        {"Hipparcos Number", "HIP 105630"},
        {"Smithsonian Astrophysical Observation", "SAO 33383"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.91717191),
        dec: Angle.Degrees(+55.29412113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232210"},
        {"Hipparcos Number", "HIP 2457"},
        {"Smithsonian Astrophysical Observation", "SAO 21475"},
        {"Wilson Evans Batten Catalogue", "WEB 448"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.81269789),
        dec: Angle.Degrees(+55.29803771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125260"},
        {"Hipparcos Number", "HIP 69748"},
        {"Geneva Identification System", "GEN# +1.00125260"},
        {"Smithsonian Astrophysical Observation", "SAO 29077"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.12702050),
        dec: Angle.Degrees(+55.29843944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238472"},
        {"Hipparcos Number", "HIP 76164"},
        {"Smithsonian Astrophysical Observation", "SAO 29570"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.34758288),
        dec: Angle.Degrees(+55.29975765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66660"},
        {"Hipparcos Number", "HIP 39747"},
        {"Geneva Identification System", "GEN# +1.00066660"},
        {"Smithsonian Astrophysical Observation", "SAO 26674"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.85572299),
        dec: Angle.Degrees(+55.30139450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101382"},
        {"Hipparcos Number", "HIP 56935"},
        {"Geneva Identification System", "GEN# +1.00101382"},
        {"Smithsonian Astrophysical Observation", "SAO 28092"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.07906058),
        dec: Angle.Degrees(+55.30262952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4321"},
        {"Hipparcos Number", "HIP 3611"},
        {"Geneva Identification System", "GEN# +1.00004321"},
        {"Smithsonian Astrophysical Observation", "SAO 21689"},
        {"Wilson Evans Batten Catalogue", "WEB 640"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.56267867),
        dec: Angle.Degrees(+55.30539128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39444"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.95277367),
        dec: Angle.Degrees(+55.30992290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238210"},
        {"Hipparcos Number", "HIP 64671"},
        {"Smithsonian Astrophysical Observation", "SAO 28692"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.83519811),
        dec: Angle.Degrees(+55.31314086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211057"},
        {"Hipparcos Number", "HIP 109701"},
        {"Celescope Catalog", "CEL 5455"},
        {"Geneva Identification System", "GEN# +1.00211057"},
        {"Smithsonian Astrophysical Observation", "SAO 34189"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.31217799),
        dec: Angle.Degrees(+55.31378529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151669"},
        {"Hipparcos Number", "HIP 82051"},
        {"Geneva Identification System", "GEN# +1.00151669"},
        {"Smithsonian Astrophysical Observation", "SAO 30081"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.40888917),
        dec: Angle.Degrees(+55.31403896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40438"},
        {"Hipparcos Number", "HIP 28589"},
        {"Smithsonian Astrophysical Observation", "SAO 25527"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.52325529),
        dec: Angle.Degrees(+55.31548990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10443",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1714 AB"},
        {"Henry Draper", "HD 13621"},
        {"Hipparcos Number", "HIP 10443"},
        {"Celescope Catalog", "CEL 226"},
        {"Geneva Identification System", "GEN# +1.00013621J"},
        {"Smithsonian Astrophysical Observation", "SAO 23065"},
        {"Wilson Evans Batten Catalogue", "WEB 2184"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.63738349),
        dec: Angle.Degrees(+55.31713859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101231",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13967 AB"},
        {"Henry Draper", "HD 235264"},
        {"Hipparcos Number", "HIP 101231"},
        {"Smithsonian Astrophysical Observation", "SAO 32648"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.79589146),
        dec: Angle.Degrees(+55.32086844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40062"},
        {"Hipparcos Number", "HIP 28385"},
        {"Geneva Identification System", "GEN# +1.00040062"},
        {"Renson", "Renson 10670"},
        {"Smithsonian Astrophysical Observation", "SAO 25504"},
        {"Wilson Evans Batten Catalogue", "WEB 5549"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.94095455),
        dec: Angle.Degrees(+55.32107237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75088",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9606 A"},
        {"Henry Draper", "HD 136883"},
        {"Hipparcos Number", "HIP 75088"},
        {"Geneva Identification System", "GEN# +1.00136883"},
        {"Smithsonian Astrophysical Observation", "SAO 29488"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.15876376),
        dec: Angle.Degrees(+55.32516733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69442",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9167 AB"},
        {"Henry Draper", "HD 124640"},
        {"Hipparcos Number", "HIP 69442"},
        {"Cincinnati Publication", "Ci 18 1869"},
        {"Smithsonian Astrophysical Observation", "SAO 29044"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.25422932),
        dec: Angle.Degrees(+55.32542196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -338.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15642"},
        {"Hipparcos Number", "HIP 11850"},
        {"Celescope Catalog", "CEL 285"},
        {"Geneva Identification System", "GEN# +1.00015642"},
        {"Smithsonian Astrophysical Observation", "SAO 23417"},
        {"Wilson Evans Batten Catalogue", "WEB 2452"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.23493410),
        dec: Angle.Degrees(+55.32752221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14332"},
        {"Hipparcos Number", "HIP 10934"},
        {"Smithsonian Astrophysical Observation", "SAO 23216"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.21199521),
        dec: Angle.Degrees(+55.32760684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37681"},
        {"Hipparcos Number", "HIP 26997"},
        {"Geneva Identification System", "GEN# +1.00037681"},
        {"Smithsonian Astrophysical Observation", "SAO 25341"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.90890138),
        dec: Angle.Degrees(+55.32898424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51610"},
        {"Hipparcos Number", "HIP 33824"},
        {"Geneva Identification System", "GEN# +1.00051610"},
        {"Smithsonian Astrophysical Observation", "SAO 26097"},
        {"Wilson Evans Batten Catalogue", "WEB 6790"},
    },
    visualMagnitude: 9.93,
    bvColour: 2.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.32504962),
        dec: Angle.Degrees(+55.33049396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32456"},
        {"Hipparcos Number", "HIP 23768"},
        {"Geneva Identification System", "GEN# +1.00032456"},
        {"Smithsonian Astrophysical Observation", "SAO 25009"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.63183414),
        dec: Angle.Degrees(+55.35354137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94000",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12104 AB"},
        {"Henry Draper", "HD 179142"},
        {"Hipparcos Number", "HIP 94000"},
        {"Smithsonian Astrophysical Observation", "SAO 31417"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.08415307),
        dec: Angle.Degrees(+55.33054448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232552"},
        {"Hipparcos Number", "HIP 8738"},
        {"Geneva Identification System", "GEN# +1.00232552"},
        {"Smithsonian Astrophysical Observation", "SAO 22699"},
        {"Wilson Evans Batten Catalogue", "WEB 1843"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.10872567),
        dec: Angle.Degrees(+55.33160008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8235",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1387 A"},
        {"Henry Draper", "HD 232522"},
        {"Hipparcos Number", "HIP 8235"},
        {"Celescope Catalog", "CEL 164"},
        {"Smithsonian Astrophysical Observation", "SAO 22602"},
        {"Wilson Evans Batten Catalogue", "WEB 1753"},
    },
    visualMagnitude: 8.70,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.50913628),
        dec: Angle.Degrees(+55.33192284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202000"},
        {"Hipparcos Number", "HIP 104573"},
        {"Celescope Catalog", "CEL 5264"},
        {"Geneva Identification System", "GEN# +1.00202000"},
        {"Smithsonian Astrophysical Observation", "SAO 33196"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.75740623),
        dec: Angle.Degrees(+55.33222751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148329"},
        {"Hipparcos Number", "HIP 80364"},
        {"Geneva Identification System", "GEN# +1.00148329"},
        {"Smithsonian Astrophysical Observation", "SAO 29930"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.07269019),
        dec: Angle.Degrees(+55.33276094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -323.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235618"},
        {"Hipparcos Number", "HIP 107538"},
        {"Geneva Identification System", "GEN# +1.00235618"},
        {"Smithsonian Astrophysical Observation", "SAO 33748"},
        {"Wilson Evans Batten Catalogue", "WEB 19411"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.71176202),
        dec: Angle.Degrees(+55.33534181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232296"},
        {"Hipparcos Number", "HIP 4138"},
        {"Smithsonian Astrophysical Observation", "SAO 21797"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.23254721),
        dec: Angle.Degrees(+55.33802439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19705"},
        {"Hipparcos Number", "HIP 14958"},
        {"Smithsonian Astrophysical Observation", "SAO 23878"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.20910648),
        dec: Angle.Degrees(+55.34025190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63684"},
    },
    visualMagnitude: 10.68,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.76199720),
        dec: Angle.Degrees(+55.34084817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35787",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6012 D"},
        {"Henry Draper", "HD 237611"},
        {"Hipparcos Number", "HIP 35787"},
        {"Smithsonian Astrophysical Observation", "SAO 26313"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.72447080),
        dec: Angle.Degrees(+55.34097394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102251"},
        {"Hipparcos Number", "HIP 57430"},
        {"Geneva Identification System", "GEN# +1.00102251"},
        {"Smithsonian Astrophysical Observation", "SAO 28135"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.60295203),
        dec: Angle.Degrees(+55.34155741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 629"},
        {"Hipparcos Number", "HIP 877"},
        {"Geneva Identification System", "GEN# +1.00000629"},
        {"Smithsonian Astrophysical Observation", "SAO 21172"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.69311023),
        dec: Angle.Degrees(+55.34282756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118214"},
        {"Hipparcos Number", "HIP 66198"},
        {"Geneva Identification System", "GEN# +1.00118214"},
        {"Renson", "Renson 34080"},
        {"Smithsonian Astrophysical Observation", "SAO 28803"},
        {"Wilson Evans Batten Catalogue", "WEB 11693"},
    },
    visualMagnitude: 5.60,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.53052101),
        dec: Angle.Degrees(+55.34844976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23837"},
        {"Hipparcos Number", "HIP 18002"},
        {"Geneva Identification System", "GEN# +1.00023837"},
        {"Smithsonian Astrophysical Observation", "SAO 24258"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.73148227),
        dec: Angle.Degrees(+55.34860936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204213"},
        {"Hipparcos Number", "HIP 105752"},
        {"Smithsonian Astrophysical Observation", "SAO 33414"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.28015868),
        dec: Angle.Degrees(+55.35151106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46101"},
        {"Hipparcos Number", "HIP 31359"},
        {"Smithsonian Astrophysical Observation", "SAO 25814"},
        {"Wilson Evans Batten Catalogue", "WEB 6274"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.63665152),
        dec: Angle.Degrees(+55.35302921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41953",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6858 A"},
        {"Henry Draper", "HD 72003"},
        {"Hipparcos Number", "HIP 41953"},
        {"Smithsonian Astrophysical Observation", "SAO 26899"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.27230499),
        dec: Angle.Degrees(+55.35490684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93991"},
        {"Hipparcos Number", "HIP 53119"},
        {"Geneva Identification System", "GEN# +1.00093991"},
        {"Renson", "Renson 27180"},
        {"Smithsonian Astrophysical Observation", "SAO 27802"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.00503011),
        dec: Angle.Degrees(+55.35512778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206537"},
        {"Hipparcos Number", "HIP 107049"},
        {"Smithsonian Astrophysical Observation", "SAO 33660"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.20628228),
        dec: Angle.Degrees(+55.35622141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41955",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6858 B"},
        {"Hipparcos Number", "HIP 41955"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.28310662),
        dec: Angle.Degrees(+55.35768325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46608"},
        {"Hipparcos Number", "HIP 31673"},
        {"Smithsonian Astrophysical Observation", "SAO 25843"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.41933504),
        dec: Angle.Degrees(+55.35923808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11174",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1820 A"},
        {"Henry Draper", "HD 14662"},
        {"Hipparcos Number", "HIP 11174"},
        {"Geneva Identification System", "GEN# +1.00014662J"},
        {"Smithsonian Astrophysical Observation", "SAO 23283"},
        {"Wilson Evans Batten Catalogue", "WEB 2346"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.96561124),
        dec: Angle.Degrees(+55.36486781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238819"},
        {"Hipparcos Number", "HIP 88915"},
        {"Smithsonian Astrophysical Observation", "SAO 30773"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.24936072),
        dec: Angle.Degrees(+55.36622438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204116"},
        {"Hipparcos Number", "HIP 105699"},
        {"Geneva Identification System", "GEN# +1.00204116"},
        {"Smithsonian Astrophysical Observation", "SAO 33401"},
        {"Wilson Evans Batten Catalogue", "WEB 19185"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.12641800),
        dec: Angle.Degrees(+55.36673913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124754"},
        {"Hipparcos Number", "HIP 69488"},
        {"Smithsonian Astrophysical Observation", "SAO 29049"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.40461586),
        dec: Angle.Degrees(+55.36983466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -241.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127205"},
        {"Hipparcos Number", "HIP 70754"},
        {"Smithsonian Astrophysical Observation", "SAO 29162"},
    },
    visualMagnitude: 9.49,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.04632462),
        dec: Angle.Degrees(+55.37131674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21465"},
        {"Hipparcos Number", "HIP 16307"},
        {"Geneva Identification System", "GEN# +1.00021465"},
        {"Smithsonian Astrophysical Observation", "SAO 24065"},
        {"Wilson Evans Batten Catalogue", "WEB 3111"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.55444526),
        dec: Angle.Degrees(+55.37504941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77370",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9793 AB"},
        {"Henry Draper", "HD 141675"},
        {"Hipparcos Number", "HIP 77370"},
        {"Geneva Identification System", "GEN# +1.00141675J"},
        {"Renson", "Renson 40240"},
        {"Smithsonian Astrophysical Observation", "SAO 29668"},
        {"Wilson Evans Batten Catalogue", "WEB 13103"},
    },
    visualMagnitude: 5.85,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.90797351),
        dec: Angle.Degrees(+55.37661523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78937"},
        {"Hipparcos Number", "HIP 45225"},
        {"Smithsonian Astrophysical Observation", "SAO 27171"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.24693984),
        dec: Angle.Degrees(+55.37836554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238695"},
        {"Hipparcos Number", "HIP 85404"},
        {"Smithsonian Astrophysical Observation", "SAO 30395"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.78819003),
        dec: Angle.Degrees(+55.37875594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14226"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.85887595),
        dec: Angle.Degrees(+55.38908727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77619"},
        {"Hipparcos Number", "HIP 44654"},
        {"Geneva Identification System", "GEN# +1.00077619"},
        {"Smithsonian Astrophysical Observation", "SAO 27116"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.48488543),
        dec: Angle.Degrees(+55.38976858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152105"},
        {"Hipparcos Number", "HIP 82255"},
        {"Smithsonian Astrophysical Observation", "SAO 30106"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.10571168),
        dec: Angle.Degrees(+55.38992496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85770"},
        {"Hipparcos Number", "HIP 48694"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.95297393),
        dec: Angle.Degrees(+55.39412597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235984"},
        {"Hipparcos Number", "HIP 112943"},
        {"Smithsonian Astrophysical Observation", "SAO 34905"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.11513785),
        dec: Angle.Degrees(+55.39502903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237707"},
        {"Hipparcos Number", "HIP 41330"},
        {"Smithsonian Astrophysical Observation", "SAO 26833"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.48517685),
        dec: Angle.Degrees(+55.39508010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232347"},
        {"Hipparcos Number", "HIP 4760"},
        {"Smithsonian Astrophysical Observation", "SAO 21922"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.29339423),
        dec: Angle.Degrees(+55.39593257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100097",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13692 AB"},
        {"Henry Draper", "HD 193592"},
        {"Hipparcos Number", "HIP 100097"},
        {"Celescope Catalog", "CEL 5022"},
        {"Geneva Identification System", "GEN# +1.00193592J"},
        {"Smithsonian Astrophysical Observation", "SAO 32455"},
        {"Wilson Evans Batten Catalogue", "WEB 18027"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.60315860),
        dec: Angle.Degrees(+55.39717050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179068"},
        {"Hipparcos Number", "HIP 93979"},
        {"Smithsonian Astrophysical Observation", "SAO 31408"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.02257720),
        dec: Angle.Degrees(+55.39801435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128000"},
        {"Hipparcos Number", "HIP 71111"},
        {"Geneva Identification System", "GEN# +1.00128000"},
        {"Smithsonian Astrophysical Observation", "SAO 29191"},
        {"Wilson Evans Batten Catalogue", "WEB 12299"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.12887396),
        dec: Angle.Degrees(+55.39804570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115872",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16778 AB"},
        {"Henry Draper", "HD 236134"},
        {"Hipparcos Number", "HIP 115872"},
        {"Smithsonian Astrophysical Observation", "SAO 35451"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.13672690),
        dec: Angle.Degrees(+55.40342209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14359"},
        {"Hipparcos Number", "HIP 10946"},
        {"Smithsonian Astrophysical Observation", "SAO 23220"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.24949686),
        dec: Angle.Degrees(+55.40798516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235993"},
        {"Hipparcos Number", "HIP 113104"},
        {"Smithsonian Astrophysical Observation", "SAO 34936"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.57269823),
        dec: Angle.Degrees(+55.40798652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151837"},
        {"Hipparcos Number", "HIP 82141"},
        {"Smithsonian Astrophysical Observation", "SAO 30095"},
        {"Wilson Evans Batten Catalogue", "WEB 13874"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.71510086),
        dec: Angle.Degrees(+55.40998401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237387"},
        {"Hipparcos Number", "HIP 25346"},
        {"Smithsonian Astrophysical Observation", "SAO 25186"},
    },
    visualMagnitude: 8.60,
    bvColour: 2.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.32205208),
        dec: Angle.Degrees(+55.41138969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207898"},
        {"Hipparcos Number", "HIP 107832"},
        {"Fundamental Katalog 5th Edition", "FK5 5928"},
        {"Geneva Identification System", "GEN# +1.00207898"},
        {"Smithsonian Astrophysical Observation", "SAO 33804"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.68495202),
        dec: Angle.Degrees(+55.41168256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238106"},
        {"Hipparcos Number", "HIP 60301"},
        {"Geneva Identification System", "GEN# +1.00238106"},
        {"Smithsonian Astrophysical Observation", "SAO 28352"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.47100642),
        dec: Angle.Degrees(+55.41238112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237287"},
        {"Hipparcos Number", "HIP 21433"},
        {"Cincinnati Publication", "Ci 20 296"},
        {"Geneva Identification System", "GEN# +0.05500900"},
        {"Geneva Identification System 2", "GEN# +1.00237287"},
        {"Smithsonian Astrophysical Observation", "SAO 24707"},
        {"Wilson Evans Batten Catalogue", "WEB 4113"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.02353319),
        dec: Angle.Degrees(+55.41298871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 547.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -303.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235319"},
        {"Hipparcos Number", "HIP 102048"},
        {"Smithsonian Astrophysical Observation", "SAO 32794"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.20681461),
        dec: Angle.Degrees(+55.41494658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54835",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8092 AB"},
        {"Henry Draper", "HD 97455"},
        {"Hipparcos Number", "HIP 54835"},
        {"Geneva Identification System", "GEN# +1.00097455J"},
        {"Smithsonian Astrophysical Observation", "SAO 27957"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.39459527),
        dec: Angle.Degrees(+55.41583977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175352"},
        {"Hipparcos Number", "HIP 92574"},
        {"Smithsonian Astrophysical Observation", "SAO 31224"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.96455923),
        dec: Angle.Degrees(+55.41810300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56330",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8207 A"},
        {"Henry Draper", "HD 100284"},
        {"Hipparcos Number", "HIP 56330"},
        {"Smithsonian Astrophysical Observation", "SAO 28051"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.22079039),
        dec: Angle.Degrees(+55.41853501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204754"},
        {"Hipparcos Number", "HIP 106052"},
        {"Celescope Catalog", "CEL 5322"},
        {"Geneva Identification System", "GEN# +1.00204754"},
        {"Smithsonian Astrophysical Observation", "SAO 33458"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.21967477),
        dec: Angle.Degrees(+55.41866782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53352"},
        {"Hipparcos Number", "HIP 34408"},
        {"Geneva Identification System", "GEN# +1.00053352"},
        {"Smithsonian Astrophysical Observation", "SAO 26167"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.00733447),
        dec: Angle.Degrees(+55.41997968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237354"},
        {"Hipparcos Number", "HIP 23922"},
        {"Cincinnati Publication", "Ci 18 657"},
        {"Geneva Identification System", "GEN# +1.00237354"},
        {"Smithsonian Astrophysical Observation", "SAO 25040"},
        {"Wilson Evans Batten Catalogue", "WEB 4667"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.11141063),
        dec: Angle.Degrees(+55.42097829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -381.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184170"},
        {"Hipparcos Number", "HIP 95899"},
        {"Smithsonian Astrophysical Observation", "SAO 31711"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.55097655),
        dec: Angle.Degrees(+55.42237628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 137.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238429"},
        {"Hipparcos Number", "HIP 74279"},
        {"Smithsonian Astrophysical Observation", "SAO 29434"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.70665618),
        dec: Angle.Degrees(+55.42239001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122545"},
        {"Hipparcos Number", "HIP 68463"},
        {"Geneva Identification System", "GEN# +1.00122545"},
        {"Smithsonian Astrophysical Observation", "SAO 28974"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.25581789),
        dec: Angle.Degrees(+55.42489480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125469"},
        {"Hipparcos Number", "HIP 69859"},
        {"Geneva Identification System", "GEN# +1.00125469"},
        {"Smithsonian Astrophysical Observation", "SAO 29090"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.44952719),
        dec: Angle.Degrees(+55.42537378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135596"},
        {"Hipparcos Number", "HIP 74522"},
        {"Smithsonian Astrophysical Observation", "SAO 29449"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.41716319),
        dec: Angle.Degrees(+55.42566406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219359"},
        {"Hipparcos Number", "HIP 114732"},
        {"Smithsonian Astrophysical Observation", "SAO 35254"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.62324818),
        dec: Angle.Degrees(+55.42703375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94862"},
        {"Hipparcos Number", "HIP 53600"},
        {"Geneva Identification System", "GEN# +1.00094862"},
        {"Smithsonian Astrophysical Observation", "SAO 27849"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.48966480),
        dec: Angle.Degrees(+55.42996182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123495"},
        {"Hipparcos Number", "HIP 68886"},
        {"Geneva Identification System", "GEN# +1.00123495"},
        {"Smithsonian Astrophysical Observation", "SAO 29008"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.56736941),
        dec: Angle.Degrees(+55.43059812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145223"},
        {"Hipparcos Number", "HIP 78942"},
        {"Smithsonian Astrophysical Observation", "SAO 29805"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.73886127),
        dec: Angle.Degrees(+55.43708508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237327"},
        {"Hipparcos Number", "HIP 22830"},
        {"Smithsonian Astrophysical Observation", "SAO 24901"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.68823861),
        dec: Angle.Degrees(+55.43721949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13714"},
        {"Cincinnati Publication", "Ci 20 192"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.14032913),
        dec: Angle.Degrees(+55.43835437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 733.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -452.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79246"},
        {"Hipparcos Number", "HIP 45402"},
        {"Geneva Identification System", "GEN# +1.00079246"},
        {"Smithsonian Astrophysical Observation", "SAO 27182"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.78571650),
        dec: Angle.Degrees(+55.44188240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13716"},
        {"Geneva Identification System", "GEN# +9.80174020"},
    },
    visualMagnitude: 10.99,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.14345641),
        dec: Angle.Degrees(+55.44266223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 802.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -443.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194719"},
        {"Hipparcos Number", "HIP 100667"},
        {"Smithsonian Astrophysical Observation", "SAO 32539"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.16141439),
        dec: Angle.Degrees(+55.44309651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238912"},
        {"Hipparcos Number", "HIP 91398"},
        {"Smithsonian Astrophysical Observation", "SAO 31082"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.60268254),
        dec: Angle.Degrees(+55.44500358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7694"},
        {"Hipparcos Number", "HIP 6064"},
        {"Geneva Identification System", "GEN# +1.00007694"},
        {"Smithsonian Astrophysical Observation", "SAO 22160"},
        {"Wilson Evans Batten Catalogue", "WEB 1367"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.45989827),
        dec: Angle.Degrees(+55.44539521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203378"},
        {"Hipparcos Number", "HIP 105303"},
        {"Smithsonian Astrophysical Observation", "SAO 33329"},
        {"Wilson Evans Batten Catalogue", "WEB 19124"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.92814636),
        dec: Angle.Degrees(+55.45005762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173580"},
        {"Hipparcos Number", "HIP 91784"},
        {"Smithsonian Astrophysical Observation", "SAO 31122"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.73458806),
        dec: Angle.Degrees(+55.45119351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16292",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2565 A"},
        {"Henry Draper", "HD 21447"},
        {"Hipparcos Number", "HIP 16292"},
        {"Geneva Identification System", "GEN# +1.00021447J"},
        {"Geneva Identification System 2", "GEN# +1.00021447A"},
        {"Smithsonian Astrophysical Observation", "SAO 24064"},
        {"Wilson Evans Batten Catalogue", "WEB 3107"},
    },
    visualMagnitude: 5.09,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.50095974),
        dec: Angle.Degrees(+55.45183695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144031"},
        {"Hipparcos Number", "HIP 78461"},
        {"Smithsonian Astrophysical Observation", "SAO 29755"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.26311849),
        dec: Angle.Degrees(+55.45341708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168637"},
        {"Hipparcos Number", "HIP 89631"},
        {"Geneva Identification System", "GEN# +1.00168637"},
        {"Smithsonian Astrophysical Observation", "SAO 30873"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.37284133),
        dec: Angle.Degrees(+55.45646001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9196",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9196"},
        {"Geneva Identification System", "GEN# +2.07440002"},
        {"New General Catalogue", "NGC 744 2"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.59523661),
        dec: Angle.Degrees(+55.45720338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15559"},
        {"Hipparcos Number", "HIP 11796"},
        {"Geneva Identification System", "GEN# +1.00015559"},
        {"Smithsonian Astrophysical Observation", "SAO 23407"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.04950363),
        dec: Angle.Degrees(+55.45820313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238368"},
        {"Hipparcos Number", "HIP 71147"},
        {"Smithsonian Astrophysical Observation", "SAO 29194"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.27236779),
        dec: Angle.Degrees(+55.45970052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28579"},
        {"Hipparcos Number", "HIP 21231"},
        {"Geneva Identification System", "GEN# +1.00028579"},
        {"Smithsonian Astrophysical Observation", "SAO 24680"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.31667011),
        dec: Angle.Degrees(+55.46237981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186532"},
        {"Hipparcos Number", "HIP 96919"},
        {"Geneva Identification System", "GEN# +1.00186532"},
        {"Smithsonian Astrophysical Observation", "SAO 31906"},
        {"Wilson Evans Batten Catalogue", "WEB 17008"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.51722804),
        dec: Angle.Degrees(+55.46331472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59176",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8434 A"},
        {"Henry Draper", "HD 105421"},
        {"Hipparcos Number", "HIP 59176"},
        {"Geneva Identification System", "GEN# +1.00105421"},
        {"Smithsonian Astrophysical Observation", "SAO 28253"},
        {"Wilson Evans Batten Catalogue", "WEB 10528"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.03022137),
        dec: Angle.Degrees(+55.46412330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59180",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8434 B"},
        {"Henry Draper", "HD 105422"},
        {"Hipparcos Number", "HIP 59180"},
        {"Geneva Identification System", "GEN# +1.00105422"},
        {"Smithsonian Astrophysical Observation", "SAO 28254"},
        {"Wilson Evans Batten Catalogue", "WEB 10530"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.04105803),
        dec: Angle.Degrees(+55.46493398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232462"},
        {"Hipparcos Number", "HIP 7246"},
        {"Smithsonian Astrophysical Observation", "SAO 22388"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.33845002),
        dec: Angle.Degrees(+55.46980515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130211"},
        {"Hipparcos Number", "HIP 72088"},
        {"Smithsonian Astrophysical Observation", "SAO 29264"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.20561647),
        dec: Angle.Degrees(+55.47318603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141472"},
        {"Hipparcos Number", "HIP 77272"},
        {"Geneva Identification System", "GEN# +1.00141472"},
        {"Smithsonian Astrophysical Observation", "SAO 29655"},
        {"Wilson Evans Batten Catalogue", "WEB 13091"},
    },
    visualMagnitude: 5.94,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.64534336),
        dec: Angle.Degrees(+55.47460243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9224"},
        {"Geneva Identification System", "GEN# +2.07440004"},
        {"New General Catalogue", "NGC 744 4"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.64354355),
        dec: Angle.Degrees(+55.47467767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156280"},
        {"Hipparcos Number", "HIP 84264"},
        {"Geneva Identification System", "GEN# +1.00156280"},
        {"Smithsonian Astrophysical Observation", "SAO 30302"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.37675560),
        dec: Angle.Degrees(+55.47505745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65218"},
        {"Hipparcos Number", "HIP 39160"},
        {"Smithsonian Astrophysical Observation", "SAO 26610"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.13640094),
        dec: Angle.Degrees(+55.47711181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109996"},
        {"Geneva Identification System", "GEN# +0.05402726"},
        {"Wilson Evans Batten Catalogue", "WEB 19747"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.18357422),
        dec: Angle.Degrees(+55.47717961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238077"},
        {"Hipparcos Number", "HIP 59323"},
        {"Smithsonian Astrophysical Observation", "SAO 28270"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.55057055),
        dec: Angle.Degrees(+55.48030994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12575",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2040 AB"},
        {"Henry Draper", "HD 16576"},
        {"Hipparcos Number", "HIP 12575"},
        {"Smithsonian Astrophysical Observation", "SAO 23537"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.42817894),
        dec: Angle.Degrees(+55.48157123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46092"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.98228927),
        dec: Angle.Degrees(+55.48181244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18727"},
        {"Geneva Identification System", "GEN# +0.05500838"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.17746344),
        dec: Angle.Degrees(+55.48421023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66083"},
        {"Hipparcos Number", "HIP 39539"},
        {"Geneva Identification System", "GEN# +1.00066083"},
        {"Smithsonian Astrophysical Observation", "SAO 26651"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.19916885),
        dec: Angle.Degrees(+55.48498187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237861"},
        {"Hipparcos Number", "HIP 49389"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.24384274),
        dec: Angle.Degrees(+55.48569494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13101"},
        {"Hipparcos Number", "HIP 10104"},
        {"Smithsonian Astrophysical Observation", "SAO 22985"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.48956618),
        dec: Angle.Degrees(+55.48736319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199908"},
        {"Hipparcos Number", "HIP 103471"},
        {"Geneva Identification System", "GEN# +1.00199908"},
        {"Smithsonian Astrophysical Observation", "SAO 33026"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.45242331),
        dec: Angle.Degrees(+55.48761843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87194"},
        {"Hipparcos Number", "HIP 49382"},
        {"Smithsonian Astrophysical Observation", "SAO 27506"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.22888399),
        dec: Angle.Degrees(+55.48790725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198895"},
        {"Hipparcos Number", "HIP 102926"},
        {"Geneva Identification System", "GEN# +1.00198895"},
        {"Smithsonian Astrophysical Observation", "SAO 32938"},
        {"Wilson Evans Batten Catalogue", "WEB 18672"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.79162043),
        dec: Angle.Degrees(+55.48875693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221711"},
        {"Hipparcos Number", "HIP 116324"},
        {"Celescope Catalog", "CEL 5631"},
        {"Geneva Identification System", "GEN# +1.00221711"},
        {"Smithsonian Astrophysical Observation", "SAO 35554"},
        {"Wilson Evans Batten Catalogue", "WEB 20556"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.53865036),
        dec: Angle.Degrees(+55.48879437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67561"},
        {"Hipparcos Number", "HIP 40094"},
        {"Geneva Identification System", "GEN# +1.00067561"},
        {"Smithsonian Astrophysical Observation", "SAO 26718"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.84106350),
        dec: Angle.Degrees(+55.48995050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18139"},
        {"Hipparcos Number", "HIP 13747"},
        {"Geneva Identification System", "GEN# +1.00018139"},
        {"Smithsonian Astrophysical Observation", "SAO 23719"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.24253349),
        dec: Angle.Degrees(+55.49030032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2152"},
        {"Hipparcos Number", "HIP 2063"},
        {"Geneva Identification System", "GEN# +1.00002152"},
        {"Smithsonian Astrophysical Observation", "SAO 21392"},
        {"Wilson Evans Batten Catalogue", "WEB 390"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.52651280),
        dec: Angle.Degrees(+55.49094765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222915"},
        {"Hipparcos Number", "HIP 117109"},
        {"Smithsonian Astrophysical Observation", "SAO 35724"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.12176723),
        dec: Angle.Degrees(+55.49106334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57837",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57837"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.91231664),
        dec: Angle.Degrees(+55.49167579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116497",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116497"},
        {"Cincinnati Publication", "Ci 20 1439"},
    },
    visualMagnitude: 11.72,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.10458328),
        dec: Angle.Degrees(+55.49567592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 491.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17429"},
        {"Hipparcos Number", "HIP 13211"},
        {"Smithsonian Astrophysical Observation", "SAO 23643"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.50137934),
        dec: Angle.Degrees(+55.49652107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46176"},
        {"Hipparcos Number", "HIP 31421"},
        {"Geneva Identification System", "GEN# +1.00046176"},
        {"Smithsonian Astrophysical Observation", "SAO 25817"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.76787829),
        dec: Angle.Degrees(+55.49898965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153449"},
        {"Hipparcos Number", "HIP 82916"},
        {"Smithsonian Astrophysical Observation", "SAO 30168"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.16404784),
        dec: Angle.Degrees(+55.50330393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18338"},
        {"Geneva Identification System", "GEN# +8.01550053"},
    },
    visualMagnitude: 11.83,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.81556069),
        dec: Angle.Degrees(+55.50506773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27246"},
        {"Hipparcos Number", "HIP 20314"},
        {"Smithsonian Astrophysical Observation", "SAO 24553"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.27981231),
        dec: Angle.Degrees(+55.50525461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115237",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16684 A"},
        {"Henry Draper", "HD 220087"},
        {"Hipparcos Number", "HIP 115237"},
        {"Smithsonian Astrophysical Observation", "SAO 35337"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.11778917),
        dec: Angle.Degrees(+55.50602602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150011"},
        {"Hipparcos Number", "HIP 81213"},
        {"Smithsonian Astrophysical Observation", "SAO 30008"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.83012201),
        dec: Angle.Degrees(+55.50940408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104917",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14798 AB"},
        {"Henry Draper", "HD 202642"},
        {"Hipparcos Number", "HIP 104917"},
        {"Smithsonian Astrophysical Observation", "SAO 33263"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.79068905),
        dec: Angle.Degrees(+55.50967560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238116"},
        {"Hipparcos Number", "HIP 60613"},
        {"Geneva Identification System", "GEN# +1.00238116"},
        {"Smithsonian Astrophysical Observation", "SAO 28378"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.34504440),
        dec: Angle.Degrees(+55.51039256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106576"},
        {"Hipparcos Number", "HIP 59757"},
        {"Geneva Identification System", "GEN# +1.00106576"},
        {"Smithsonian Astrophysical Observation", "SAO 28313"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.80945468),
        dec: Angle.Degrees(+55.51071516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28877"},
        {"Hipparcos Number", "HIP 21426"},
        {"Geneva Identification System", "GEN# +1.00028877"},
        {"Smithsonian Astrophysical Observation", "SAO 24705"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.00226806),
        dec: Angle.Degrees(+55.51221909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92074"},
        {"Hipparcos Number", "HIP 52137"},
        {"Geneva Identification System", "GEN# +1.00092074"},
        {"Smithsonian Astrophysical Observation", "SAO 27723"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.77426110),
        dec: Angle.Degrees(+55.51257358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34028"},
        {"Hipparcos Number", "HIP 24673"},
        {"Smithsonian Astrophysical Observation", "SAO 25115"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.39961576),
        dec: Angle.Degrees(+55.51684976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57856"},
        {"Hipparcos Number", "HIP 36095"},
        {"Smithsonian Astrophysical Observation", "SAO 26340"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.54568711),
        dec: Angle.Degrees(+55.51731639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238065"},
        {"Hipparcos Number", "HIP 58812"},
        {"Smithsonian Astrophysical Observation", "SAO 28231"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.93871987),
        dec: Angle.Degrees(+55.52031856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237397"},
        {"Hipparcos Number", "HIP 25899"},
        {"Smithsonian Astrophysical Observation", "SAO 25233"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.92758848),
        dec: Angle.Degrees(+55.52118006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144109"},
        {"Hipparcos Number", "HIP 78492"},
        {"Smithsonian Astrophysical Observation", "SAO 29760"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.35597341),
        dec: Angle.Degrees(+55.52124935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76385",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9720 AB"},
        {"Henry Draper", "HD 238482"},
        {"Hipparcos Number", "HIP 76385"},
        {"Geneva Identification System", "GEN# +1.00238482"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.02069668),
        dec: Angle.Degrees(+55.52208193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206822"},
        {"Hipparcos Number", "HIP 107213"},
        {"Smithsonian Astrophysical Observation", "SAO 33684"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.72515099),
        dec: Angle.Degrees(+55.52390875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238480"},
        {"Hipparcos Number", "HIP 76358"},
        {"Geneva Identification System", "GEN# +1.00238480"},
        {"Smithsonian Astrophysical Observation", "SAO 29586"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.92637581),
        dec: Angle.Degrees(+55.52551006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77599"},
        {"Hipparcos Number", "HIP 44638"},
        {"Geneva Identification System", "GEN# +1.00077599"},
        {"Smithsonian Astrophysical Observation", "SAO 27113"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.44205724),
        dec: Angle.Degrees(+55.52898563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40752"},
        {"Hipparcos Number", "HIP 28731"},
        {"Geneva Identification System", "GEN# +1.00040752"},
        {"Smithsonian Astrophysical Observation", "SAO 25543"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.02804423),
        dec: Angle.Degrees(+55.52965438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27232"},
        {"Hipparcos Number", "HIP 20306"},
        {"Geneva Identification System", "GEN# +1.00027232"},
        {"Smithsonian Astrophysical Observation", "SAO 24552"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.26301114),
        dec: Angle.Degrees(+55.53124931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238058"},
        {"Hipparcos Number", "HIP 58322"},
        {"Smithsonian Astrophysical Observation", "SAO 28204"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.39340961),
        dec: Angle.Degrees(+55.53138605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238753"},
        {"Hipparcos Number", "HIP 86952"},
        {"Smithsonian Astrophysical Observation", "SAO 30563"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.52543057),
        dec: Angle.Degrees(+55.53479734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11593",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1878 AB"},
        {"Henry Draper", "HD 15253"},
        {"Hipparcos Number", "HIP 11593"},
        {"Celescope Catalog", "CEL 279"},
        {"Geneva Identification System", "GEN# +1.00015253J"},
        {"Smithsonian Astrophysical Observation", "SAO 23369"},
        {"Wilson Evans Batten Catalogue", "WEB 2415"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.35385743),
        dec: Angle.Degrees(+55.53623241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20509"},
        {"Hipparcos Number", "HIP 15554"},
        {"Smithsonian Astrophysical Observation", "SAO 23960"},
        {"Wilson Evans Batten Catalogue", "WEB 2988"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.09342420),
        dec: Angle.Degrees(+55.53707723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235420"},
        {"Hipparcos Number", "HIP 103634"},
        {"Smithsonian Astrophysical Observation", "SAO 33051"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.95790598),
        dec: Angle.Degrees(+55.53742317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78009"},
        {"Smithsonian Astrophysical Observation", "SAO 29717"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.94013639),
        dec: Angle.Degrees(+55.53827428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29720"},
        {"Hipparcos Number", "HIP 22017"},
        {"Smithsonian Astrophysical Observation", "SAO 24789"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.00917060),
        dec: Angle.Degrees(+55.53843426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74150"},
        {"Hipparcos Number", "HIP 42919"},
        {"Geneva Identification System", "GEN# +1.00074150"},
        {"Smithsonian Astrophysical Observation", "SAO 26978"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.19888186),
        dec: Angle.Degrees(+55.53871746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173524"},
        {"Hipparcos Number", "HIP 91755"},
        {"Fundamental Katalog 5th Edition", "FK5 3491"},
        {"Geneva Identification System", "GEN# +1.00173524"},
        {"Renson", "Renson 48580"},
        {"Smithsonian Astrophysical Observation", "SAO 31119"},
        {"Wilson Evans Batten Catalogue", "WEB 15786"},
    },
    visualMagnitude: 5.03,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.65815094),
        dec: Angle.Degrees(+55.53940044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102569"},
        {"Hipparcos Number", "HIP 57602"},
        {"Geneva Identification System", "GEN# +1.00102569"},
        {"Smithsonian Astrophysical Observation", "SAO 28152"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.14668196),
        dec: Angle.Degrees(+55.53992532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23838",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3683 AB"},
        {"Henry Draper", "HD 32606"},
        {"Hipparcos Number", "HIP 23838"},
        {"Smithsonian Astrophysical Observation", "SAO 25029"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.87791322),
        dec: Angle.Degrees(+55.54010208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62452"},
        {"Hipparcos Number", "HIP 37973"},
        {"Smithsonian Astrophysical Observation", "SAO 26504"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.75171045),
        dec: Angle.Degrees(+55.54137242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154141"},
        {"Hipparcos Number", "HIP 83237"},
        {"Smithsonian Astrophysical Observation", "SAO 30198"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.16260308),
        dec: Angle.Degrees(+55.54148396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87912"},
        {"Hipparcos Number", "HIP 49786"},
        {"Geneva Identification System", "GEN# +1.00087912"},
        {"Smithsonian Astrophysical Observation", "SAO 27540"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.44225585),
        dec: Angle.Degrees(+55.54218462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193665"},
        {"Hipparcos Number", "HIP 100149"},
        {"Geneva Identification System", "GEN# +1.00193665"},
        {"Smithsonian Astrophysical Observation", "SAO 32466"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.72807893),
        dec: Angle.Degrees(+55.54545053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11696",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1901 A"},
        {"Henry Draper", "HD 15407"},
        {"Henry Draper 2", "HD 15407A"},
        {"Hipparcos Number", "HIP 11696"},
        {"Smithsonian Astrophysical Observation", "SAO 23389"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.71071769),
        dec: Angle.Degrees(+55.54863705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225095"},
        {"Hipparcos Number", "HIP 278"},
        {"Geneva Identification System", "GEN# +1.00225095"},
        {"Smithsonian Astrophysical Observation", "SAO 21040"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.86311931),
        dec: Angle.Degrees(+55.55090206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235807"},
        {"Hipparcos Number", "HIP 110362"},
        {"Geneva Identification System", "GEN# +1.00235807"},
        {"Smithsonian Astrophysical Observation", "SAO 34349"},
        {"Wilson Evans Batten Catalogue", "WEB 19792"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.29057726),
        dec: Angle.Degrees(+55.55107562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11692",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1901 B"},
        {"Henry Draper", "HD 15407B"},
        {"Hipparcos Number", "HIP 11692"},
    },
    visualMagnitude: 8.78,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)30, 48.3600),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)33, 07.200)
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
    primaryId: "HIP 71273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128386"},
        {"Hipparcos Number", "HIP 71273"},
        {"Geneva Identification System", "GEN# +1.00128386"},
        {"Smithsonian Astrophysical Observation", "SAO 29204"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.64864734),
        dec: Angle.Degrees(+55.55332430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124604"},
        {"Hipparcos Number", "HIP 69435"},
        {"Geneva Identification System", "GEN# +1.00124604"},
        {"Smithsonian Astrophysical Observation", "SAO 29043"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.24365472),
        dec: Angle.Degrees(+55.55625140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7810"},
        {"Hipparcos Number", "HIP 6153"},
        {"Smithsonian Astrophysical Observation", "SAO 22173"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.73798852),
        dec: Angle.Degrees(+55.55674934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21802"},
        {"Hipparcos Number", "HIP 16586"},
        {"Geneva Identification System", "GEN# +1.00021802"},
        {"Smithsonian Astrophysical Observation", "SAO 24096"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.37771528),
        dec: Angle.Degrees(+55.55931427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235643"},
        {"Hipparcos Number", "HIP 107910"},
        {"Smithsonian Astrophysical Observation", "SAO 33811"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.94747869),
        dec: Angle.Degrees(+55.56209159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 239439"},
        {"Hipparcos Number", "HIP 101287"},
        {"Smithsonian Astrophysical Observation", "SAO 32666"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.95018900),
        dec: Angle.Degrees(+55.56441388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89501"},
        {"Hipparcos Number", "HIP 50689"},
        {"Geneva Identification System", "GEN# +1.00089501"},
        {"Renson", "Renson 25710"},
        {"Smithsonian Astrophysical Observation", "SAO 27614"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.27361078),
        dec: Angle.Degrees(+55.56791950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198378"},
        {"Hipparcos Number", "HIP 102598"},
        {"Celescope Catalog", "CEL 5169"},
        {"Geneva Identification System", "GEN# +1.00198378"},
        {"Smithsonian Astrophysical Observation", "SAO 32894"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.88538995),
        dec: Angle.Degrees(+55.56961071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235560"},
        {"Hipparcos Number", "HIP 106706"},
        {"Smithsonian Astrophysical Observation", "SAO 33575"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.21915593),
        dec: Angle.Degrees(+55.57438244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31779"},
        {"Hipparcos Number", "HIP 23394"},
        {"Smithsonian Astrophysical Observation", "SAO 24958"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.43150258),
        dec: Angle.Degrees(+55.57507184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237859"},
        {"Hipparcos Number", "HIP 49191"},
        {"Geneva Identification System", "GEN# +1.00237859"},
        {"Smithsonian Astrophysical Observation", "SAO 27486"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.59624028),
        dec: Angle.Degrees(+55.57521549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106427"},
        {"Hipparcos Number", "HIP 59684"},
        {"Smithsonian Astrophysical Observation", "SAO 28306"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.59076835),
        dec: Angle.Degrees(+55.57656931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 299"},
        {"Hipparcos Number", "HIP 641"},
        {"Geneva Identification System", "GEN# +1.00000299"},
        {"Smithsonian Astrophysical Observation", "SAO 21114"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.96614972),
        dec: Angle.Degrees(+55.57701937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126470"},
        {"Hipparcos Number", "HIP 70366"},
        {"Geneva Identification System", "GEN# +1.00126470"},
        {"Smithsonian Astrophysical Observation", "SAO 29127"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.95497233),
        dec: Angle.Degrees(+55.57945924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33246"},
        {"Hipparcos Number", "HIP 24225"},
        {"Smithsonian Astrophysical Observation", "SAO 25068"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.01725785),
        dec: Angle.Degrees(+55.58021090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238469"},
        {"Hipparcos Number", "HIP 76096"},
        {"Geneva Identification System", "GEN# +1.00238469"},
        {"Smithsonian Astrophysical Observation", "SAO 29564"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.12304510),
        dec: Angle.Degrees(+55.58141963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11948"},
        {"Hipparcos Number", "HIP 9244"},
        {"Geneva Identification System", "GEN# +2.07440001"},
        {"Renson", "Renson 3060"},
        {"Smithsonian Astrophysical Observation", "SAO 22809"},
        {"New General Catalogue", "NGC 744 1"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.71319858),
        dec: Angle.Degrees(+55.58174814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100403"},
        {"Hipparcos Number", "HIP 56387"},
        {"Smithsonian Astrophysical Observation", "SAO 28055"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.39812825),
        dec: Angle.Degrees(+55.58219316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42349"},
        {"Hipparcos Number", "HIP 29538"},
        {"Geneva Identification System", "GEN# +1.00042349"},
        {"Smithsonian Astrophysical Observation", "SAO 25623"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.36492765),
        dec: Angle.Degrees(+55.58497858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38419"},
        {"Hipparcos Number", "HIP 27460"},
        {"Smithsonian Astrophysical Observation", "SAO 25389"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.22605886),
        dec: Angle.Degrees(+55.58613976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86661"},
        {"Hipparcos Number", "HIP 49130"},
        {"Cincinnati Publication", "Ci 18 1189"},
        {"Cincinnati Publication 2", "Ci 20 558"},
        {"Geneva Identification System", "GEN# +1.00086661"},
        {"Smithsonian Astrophysical Observation", "SAO 27476"},
        {"Wilson Evans Batten Catalogue", "WEB 9104"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.40998642),
        dec: Angle.Degrees(+55.58617210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -445.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212312"},
        {"Hipparcos Number", "HIP 110431"},
        {"Geneva Identification System", "GEN# +1.00212312"},
        {"Smithsonian Astrophysical Observation", "SAO 34363"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.51409492),
        dec: Angle.Degrees(+55.58729232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201033"},
        {"Hipparcos Number", "HIP 104051"},
        {"Geneva Identification System", "GEN# +1.00201033"},
        {"Renson", "Renson 56060"},
        {"Smithsonian Astrophysical Observation", "SAO 33117"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.20355166),
        dec: Angle.Degrees(+55.58786419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184312"},
        {"Hipparcos Number", "HIP 95959"},
        {"Smithsonian Astrophysical Observation", "SAO 31732"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.70925703),
        dec: Angle.Degrees(+55.58830537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112247",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Babcock's Star"},
        {"Henry Draper", "HD 215441"},
        {"Hipparcos Number", "HIP 112247"},
        {"Geneva Identification System", "GEN# +1.00215441"},
        {"Renson", "Renson 59530"},
        {"Smithsonian Astrophysical Observation", "SAO 34741"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.03125151),
        dec: Angle.Degrees(+55.58922817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156160"},
        {"Hipparcos Number", "HIP 84206"},
        {"Geneva Identification System", "GEN# +1.00156160"},
        {"Smithsonian Astrophysical Observation", "SAO 30294"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.19797639),
        dec: Angle.Degrees(+55.59000715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168953"},
        {"Hipparcos Number", "HIP 89775"},
        {"Smithsonian Astrophysical Observation", "SAO 30892"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.80493556),
        dec: Angle.Degrees(+55.59304793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13717"},
        {"Hipparcos Number", "HIP 10509"},
        {"Celescope Catalog", "CEL 230"},
        {"Geneva Identification System", "GEN# +1.00013717"},
        {"Smithsonian Astrophysical Observation", "SAO 23091"},
        {"Wilson Evans Batten Catalogue", "WEB 2203"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.86238245),
        dec: Angle.Degrees(+55.59509804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11408"},
        {"Hipparcos Number", "HIP 8847"},
        {"Geneva Identification System", "GEN# +1.00011408"},
        {"Renson", "Renson 2860"},
        {"Smithsonian Astrophysical Observation", "SAO 22716"},
        {"Wilson Evans Batten Catalogue", "WEB 1864"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.45193321),
        dec: Angle.Degrees(+55.59767097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115798",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16768 AB"},
        {"Henry Draper", "HD 236128"},
        {"Hipparcos Number", "HIP 115798"},
        {"Smithsonian Astrophysical Observation", "SAO 35438"},
    },
    visualMagnitude: 10.33,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.89430987),
        dec: Angle.Degrees(+55.59926193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232426"},
        {"Hipparcos Number", "HIP 6473"},
        {"Smithsonian Astrophysical Observation", "SAO 22229"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.81448582),
        dec: Angle.Degrees(+55.60063752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30144"},
        {"Hipparcos Number", "HIP 22300"},
        {"Geneva Identification System", "GEN# +1.00030144"},
        {"Smithsonian Astrophysical Observation", "SAO 24834"},
        {"Wilson Evans Batten Catalogue", "WEB 4299"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.02893035),
        dec: Angle.Degrees(+55.60284572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235509"},
        {"Hipparcos Number", "HIP 105687"},
        {"Smithsonian Astrophysical Observation", "SAO 33393"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.09102210),
        dec: Angle.Degrees(+55.60633958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45798"},
        {"Hipparcos Number", "HIP 31204"},
        {"Renson", "Renson 12210"},
        {"Smithsonian Astrophysical Observation", "SAO 25800"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.19343033),
        dec: Angle.Degrees(+55.60666123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137717"},
        {"Hipparcos Number", "HIP 75470"},
        {"Geneva Identification System", "GEN# +1.00137717"},
        {"Smithsonian Astrophysical Observation", "SAO 29519"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.26125782),
        dec: Angle.Degrees(+55.61090340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54319"},
        {"Hipparcos Number", "HIP 34737"},
        {"Geneva Identification System", "GEN# +1.00054319"},
        {"Smithsonian Astrophysical Observation", "SAO 26201"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.88136694),
        dec: Angle.Degrees(+55.61258110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17217"},
        {"Hipparcos Number", "HIP 13063"},
        {"Smithsonian Astrophysical Observation", "SAO 23614"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.98049616),
        dec: Angle.Degrees(+55.61361675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133109"},
        {"Hipparcos Number", "HIP 73436"},
        {"Geneva Identification System", "GEN# +1.00133109"},
        {"Smithsonian Astrophysical Observation", "SAO 29377"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.09910659),
        dec: Angle.Degrees(+55.61812645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193053"},
        {"Hipparcos Number", "HIP 99858"},
        {"Smithsonian Astrophysical Observation", "SAO 32402"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.89300009),
        dec: Angle.Degrees(+55.61914849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79190"},
        {"Hipparcos Number", "HIP 45377"},
        {"Smithsonian Astrophysical Observation", "SAO 27181"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.71512531),
        dec: Angle.Degrees(+55.62027021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12591"},
        {"Hipparcos Number", "HIP 9723"},
        {"Geneva Identification System", "GEN# +1.00012591"},
        {"Smithsonian Astrophysical Observation", "SAO 22907"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.26583931),
        dec: Angle.Degrees(+55.62236117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12323"},
        {"Hipparcos Number", "HIP 9523"},
        {"Celescope Catalog", "CEL 187"},
        {"Geneva Identification System", "GEN# +1.00012323"},
        {"Smithsonian Astrophysical Observation", "SAO 22862"},
        {"Wilson Evans Batten Catalogue", "WEB 1997"},
    },
    visualMagnitude: 8.94,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.62553546),
        dec: Angle.Degrees(+55.62400622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67911"},
        {"Hipparcos Number", "HIP 40230"},
        {"Geneva Identification System", "GEN# +1.00067911"},
        {"Renson", "Renson 18730"},
        {"Smithsonian Astrophysical Observation", "SAO 26726"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.24605164),
        dec: Angle.Degrees(+55.62533641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238925"},
        {"Hipparcos Number", "HIP 91735"},
        {"Smithsonian Astrophysical Observation", "SAO 31117"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.60331904),
        dec: Angle.Degrees(+55.62611794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238430"},
        {"Hipparcos Number", "HIP 74407"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.09998469),
        dec: Angle.Degrees(+55.62709806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 155.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102328"},
        {"Hipparcos Number", "HIP 57477"},
        {"Fundamental Katalog 5th Edition", "FK5 2941"},
        {"Geneva Identification System", "GEN# +1.00102328"},
        {"Smithsonian Astrophysical Observation", "SAO 28142"},
        {"Wilson Evans Batten Catalogue", "WEB 10321"},
    },
    visualMagnitude: 5.27,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.73170252),
        dec: Angle.Degrees(+55.62826771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190426"},
        {"Hipparcos Number", "HIP 98644"},
        {"Geneva Identification System", "GEN# +1.00190426"},
        {"Smithsonian Astrophysical Observation", "SAO 32222"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.54667279),
        dec: Angle.Degrees(+55.63198664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19245"},
        {"Hipparcos Number", "HIP 14581"},
        {"Smithsonian Astrophysical Observation", "SAO 23827"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.05723330),
        dec: Angle.Degrees(+55.63392229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119821"},
        {"Hipparcos Number", "HIP 67021"},
        {"Smithsonian Astrophysical Observation", "SAO 28871"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.02558355),
        dec: Angle.Degrees(+55.63497983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10085"},
        {"Hipparcos Number", "HIP 7763"},
        {"Smithsonian Astrophysical Observation", "SAO 22484"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.97985939),
        dec: Angle.Degrees(+55.63780853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33322"},
    },
    visualMagnitude: 10.23,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.96680453),
        dec: Angle.Degrees(+55.63861821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62257"},
        {"Hipparcos Number", "HIP 37898"},
        {"Geneva Identification System", "GEN# +1.00062257"},
        {"Renson", "Renson 17080"},
        {"Smithsonian Astrophysical Observation", "SAO 26496"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.50702739),
        dec: Angle.Degrees(+55.64242827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20748",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3207 AB"},
        {"Henry Draper", "HD 27856"},
        {"Hipparcos Number", "HIP 20748"},
        {"Geneva Identification System", "GEN# +1.00027856J"},
        {"Smithsonian Astrophysical Observation", "SAO 24614"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.69272702),
        dec: Angle.Degrees(+55.64372604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223329"},
        {"Hipparcos Number", "HIP 117419"},
        {"Smithsonian Astrophysical Observation", "SAO 35787"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.13239588),
        dec: Angle.Degrees(+55.64922728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237921"},
        {"Hipparcos Number", "HIP 52256"},
        {"Smithsonian Astrophysical Observation", "SAO 27729"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.15257334),
        dec: Angle.Degrees(+55.64964526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203883"},
        {"Hipparcos Number", "HIP 105572"},
        {"Smithsonian Astrophysical Observation", "SAO 33373"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.72789607),
        dec: Angle.Degrees(+55.65039403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29950"},
        {"Hipparcos Number", "HIP 22181"},
        {"Smithsonian Astrophysical Observation", "SAO 24808"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.58490656),
        dec: Angle.Degrees(+55.65512322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192982"},
        {"Hipparcos Number", "HIP 99818"},
        {"Smithsonian Astrophysical Observation", "SAO 32393"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.79570860),
        dec: Angle.Degrees(+55.65651178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39724"},
        {"Hipparcos Number", "HIP 28214"},
        {"Renson", "Renson 10630"},
        {"Smithsonian Astrophysical Observation", "SAO 25485"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.41903171),
        dec: Angle.Degrees(+55.65669566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87482"},
        {"Hipparcos Number", "HIP 49532"},
        {"Geneva Identification System", "GEN# +1.00087482"},
        {"Smithsonian Astrophysical Observation", "SAO 27520"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.71020439),
        dec: Angle.Degrees(+55.65766058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177249"},
        {"Hipparcos Number", "HIP 93340"},
        {"Geneva Identification System", "GEN# +1.00177249"},
        {"Smithsonian Astrophysical Observation", "SAO 31323"},
        {"Wilson Evans Batten Catalogue", "WEB 16184"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.18111302),
        dec: Angle.Degrees(+55.65831944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238263"},
        {"Hipparcos Number", "HIP 66584"},
        {"Geneva Identification System", "GEN# +1.00238263"},
        {"Smithsonian Astrophysical Observation", "SAO 28829"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.73774222),
        dec: Angle.Degrees(+55.65973622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83784"},
        {"Hipparcos Number", "HIP 47629"},
        {"Geneva Identification System", "GEN# +1.00083784"},
        {"Smithsonian Astrophysical Observation", "SAO 27354"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.67528575),
        dec: Angle.Degrees(+55.66588893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55972",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8173 AB"},
        {"Henry Draper", "HD 99620"},
        {"Hipparcos Number", "HIP 55972"},
        {"Geneva Identification System", "GEN# +1.00099620J"},
        {"Renson", "Renson 28670"},
        {"Smithsonian Astrophysical Observation", "SAO 28026"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.04782780),
        dec: Angle.Degrees(+55.66816082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73393"},
        {"Hipparcos Number", "HIP 42575"},
        {"Cincinnati Publication", "Ci 20 478"},
        {"Fundamental Katalog 5th Edition", "FK5 4779"},
        {"Geneva Identification System", "GEN# +1.00073393"},
        {"Smithsonian Astrophysical Observation", "SAO 26956"},
        {"Wilson Evans Batten Catalogue", "WEB 8215"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.17685995),
        dec: Angle.Degrees(+55.66863045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -264.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -370.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170850"},
        {"Hipparcos Number", "HIP 90527"},
        {"Geneva Identification System", "GEN# +1.00170850"},
        {"Smithsonian Astrophysical Observation", "SAO 30995"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.08040875),
        dec: Angle.Degrees(+55.67403117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120932"},
        {"Hipparcos Number", "HIP 67595"},
        {"Smithsonian Astrophysical Observation", "SAO 28906"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.76483656),
        dec: Angle.Degrees(+55.67497807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73837",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "PZT+55 5210"},
        {"Henry Draper", "HD 134023"},
        {"Hipparcos Number", "HIP 73837"},
        {"Geneva Identification System", "GEN# +1.00134023"},
        {"Smithsonian Astrophysical Observation", "SAO 29401"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.34918395),
        dec: Angle.Degrees(+55.67724491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49695"},
        {"Hipparcos Number", "HIP 33030"},
        {"Geneva Identification System", "GEN# +1.00049695"},
        {"Smithsonian Astrophysical Observation", "SAO 26013"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.22886620),
        dec: Angle.Degrees(+55.67988545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232252"},
        {"Hipparcos Number", "HIP 3279"},
        {"Smithsonian Astrophysical Observation", "SAO 21628"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.44561425),
        dec: Angle.Degrees(+55.68233412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 269.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163965"},
        {"Hipparcos Number", "HIP 87764"},
        {"Smithsonian Astrophysical Observation", "SAO 30646"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.92359103),
        dec: Angle.Degrees(+55.68373812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164727"},
        {"Hipparcos Number", "HIP 88086"},
        {"Smithsonian Astrophysical Observation", "SAO 30675"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.86029434),
        dec: Angle.Degrees(+55.68766235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151199"},
        {"Hipparcos Number", "HIP 81840"},
        {"Geneva Identification System", "GEN# +1.00151199"},
        {"Renson", "Renson 42760"},
        {"Smithsonian Astrophysical Observation", "SAO 30062"},
        {"Wilson Evans Batten Catalogue", "WEB 13827"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.74334035),
        dec: Angle.Degrees(+55.68992369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168480"},
        {"Hipparcos Number", "HIP 89575"},
        {"Geneva Identification System", "GEN# +1.00168480"},
        {"Smithsonian Astrophysical Observation", "SAO 30863"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.17806735),
        dec: Angle.Degrees(+55.69002456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137180"},
        {"Hipparcos Number", "HIP 75205"},
        {"Smithsonian Astrophysical Observation", "SAO 29500"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.53141202),
        dec: Angle.Degrees(+55.69036042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96904"},
        {"Hipparcos Number", "HIP 54584"},
        {"Geneva Identification System", "GEN# +1.00096904"},
        {"Smithsonian Astrophysical Observation", "SAO 27933"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.56022675),
        dec: Angle.Degrees(+55.69211200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201759"},
        {"Hipparcos Number", "HIP 104448"},
        {"Celescope Catalog", "CEL 5254"},
        {"Geneva Identification System", "GEN# +1.00201759"},
        {"Smithsonian Astrophysical Observation", "SAO 33174"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.37018551),
        dec: Angle.Degrees(+55.69270607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46335"},
        {"Hipparcos Number", "HIP 31527"},
        {"Geneva Identification System", "GEN# +1.00046335"},
        {"Smithsonian Astrophysical Observation", "SAO 25831"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.00949249),
        dec: Angle.Degrees(+55.69292998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45411"},
        {"Hipparcos Number", "HIP 31009"},
        {"Geneva Identification System", "GEN# +1.00045411"},
        {"Smithsonian Astrophysical Observation", "SAO 25770"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.61099294),
        dec: Angle.Degrees(+55.69651103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129267"},
        {"Hipparcos Number", "HIP 71676"},
        {"Geneva Identification System", "GEN# +1.00129267"},
        {"Smithsonian Astrophysical Observation", "SAO 29237"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.90423398),
        dec: Angle.Degrees(+55.70227979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2701"},
        {"Hipparcos Number", "HIP 2440"},
        {"Geneva Identification System", "GEN# +1.00002701"},
        {"Smithsonian Astrophysical Observation", "SAO 21471"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.76615099),
        dec: Angle.Degrees(+55.70282110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44649"},
        {"Hipparcos Number", "HIP 30629"},
        {"Geneva Identification System", "GEN# +1.00044649"},
        {"Smithsonian Astrophysical Observation", "SAO 25728"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.54252149),
        dec: Angle.Degrees(+55.70369393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32609",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5436 AB"},
        {"Hipparcos Number", "HIP 32609"},
        {"Geneva Identification System", "GEN# +1.00048767J"},
    },
    visualMagnitude: 5.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.05096806),
        dec: Angle.Degrees(+55.70444959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224355"},
        {"Hipparcos Number", "HIP 118077"},
        {"Celescope Catalog", "CEL 5720"},
        {"Geneva Identification System", "GEN# +1.00224355"},
        {"Smithsonian Astrophysical Observation", "SAO 35917"},
        {"Wilson Evans Batten Catalogue", "WEB 20760"},
    },
    visualMagnitude: 5.57,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.28539105),
        dec: Angle.Degrees(+55.70573518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106102"},
        {"Hipparcos Number", "HIP 59511"},
        {"Geneva Identification System", "GEN# +1.00106102"},
        {"Smithsonian Astrophysical Observation", "SAO 28298"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.07471896),
        dec: Angle.Degrees(+55.70590278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10899"},
        {"Hipparcos Number", "HIP 8406"},
        {"Smithsonian Astrophysical Observation", "SAO 22637"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.11400392),
        dec: Angle.Degrees(+55.70599930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39283"},
        {"Hipparcos Number", "HIP 27949"},
        {"Fundamental Katalog 5th Edition", "FK5 1157"},
        {"Geneva Identification System", "GEN# +1.00039283"},
        {"Smithsonian Astrophysical Observation", "SAO 25450"},
        {"Wilson Evans Batten Catalogue", "WEB 5475"},
    },
    visualMagnitude: 4.96,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.71160776),
        dec: Angle.Degrees(+55.70690490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3200"},
        {"Hipparcos Number", "HIP 2813"},
        {"Renson", "Renson 860"},
        {"Smithsonian Astrophysical Observation", "SAO 21547"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.94855068),
        dec: Angle.Degrees(+55.70722819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52628"},
        {"Hipparcos Number", "HIP 34174"},
        {"Renson", "Renson 14420"},
        {"Smithsonian Astrophysical Observation", "SAO 26137"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.31509170),
        dec: Angle.Degrees(+55.70799280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71"},
        {"Hipparcos Number", "HIP 472"},
        {"Smithsonian Astrophysical Observation", "SAO 21076"},
        {"Wilson Evans Batten Catalogue", "WEB 79"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.41549758),
        dec: Angle.Degrees(+55.70990230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108271"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.02226034),
        dec: Angle.Degrees(+55.71032181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108502"},
        {"Hipparcos Number", "HIP 60795"},
        {"Fundamental Katalog 5th Edition", "FK5 3000"},
        {"Geneva Identification System", "GEN# +1.00108502"},
        {"Smithsonian Astrophysical Observation", "SAO 28394"},
        {"Wilson Evans Batten Catalogue", "WEB 10817"},
    },
    visualMagnitude: 5.68,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.89635756),
        dec: Angle.Degrees(+55.71275225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1536"},
        {"Hipparcos Number", "HIP 1592"},
        {"Smithsonian Astrophysical Observation", "SAO 21305"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.97106258),
        dec: Angle.Degrees(+55.71424433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236920"},
        {"Hipparcos Number", "HIP 9305"},
        {"Fundamental Katalog 5th Edition", "FK5 4179"},
        {"Geneva Identification System", "GEN# +1.00236920"},
        {"Smithsonian Astrophysical Observation", "SAO 22816"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.89226782),
        dec: Angle.Degrees(+55.71474494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27108",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4303 AB"},
        {"Henry Draper", "HD 37880"},
        {"Hipparcos Number", "HIP 27108"},
        {"Geneva Identification System", "GEN# +1.00037880J"},
        {"Smithsonian Astrophysical Observation", "SAO 25351"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.23061889),
        dec: Angle.Degrees(+55.71534956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236270"},
        {"Hipparcos Number", "HIP 59"},
        {"Smithsonian Astrophysical Observation", "SAO 35984"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.17444749),
        dec: Angle.Degrees(+55.72246267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63765",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63765"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.04624681),
        dec: Angle.Degrees(+55.72360365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110463"},
        {"Hipparcos Number", "HIP 61946"},
        {"Geneva Identification System", "GEN# +1.00110463"},
        {"Smithsonian Astrophysical Observation", "SAO 28480"},
        {"Wilson Evans Batten Catalogue", "WEB 11015"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.43497984),
        dec: Angle.Degrees(+55.72468476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187728"},
        {"Hipparcos Number", "HIP 97464"},
        {"Geneva Identification System", "GEN# +1.00187728"},
        {"Smithsonian Astrophysical Observation", "SAO 32017"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.15092835),
        dec: Angle.Degrees(+55.72478157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237844"},
        {"Hipparcos Number", "HIP 48394"},
        {"Geneva Identification System", "GEN# +1.00237844"},
        {"Smithsonian Astrophysical Observation", "SAO 27406"},
    },
    visualMagnitude: 10.20,
    bvColour: -0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.99155013),
        dec: Angle.Degrees(+55.72567987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237143"},
        {"Hipparcos Number", "HIP 16138"},
        {"Geneva Identification System", "GEN# +1.00237143"},
        {"Smithsonian Astrophysical Observation", "SAO 24046"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.99001568),
        dec: Angle.Degrees(+55.72737277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119549"},
        {"Hipparcos Number", "HIP 66893"},
        {"Smithsonian Astrophysical Observation", "SAO 28858"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.62893481),
        dec: Angle.Degrees(+55.72767344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184399"},
        {"Henry Draper 2", "HD 184398"},
        {"Hipparcos Number", "HIP 96003"},
        {"Geneva Identification System", "GEN# +1.00184398"},
        {"Smithsonian Astrophysical Observation", "SAO 31741"},
        {"Wilson Evans Batten Catalogue", "WEB 16814"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.80649013),
        dec: Angle.Degrees(+55.73188011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238488"},
        {"Hipparcos Number", "HIP 76654"},
        {"Geneva Identification System", "GEN# +1.00238488"},
        {"Smithsonian Astrophysical Observation", "SAO 29608"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.80010572),
        dec: Angle.Degrees(+55.73194893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146385"},
        {"Hipparcos Number", "HIP 79481"},
        {"Geneva Identification System", "GEN# +1.00146385"},
        {"Smithsonian Astrophysical Observation", "SAO 29845"},
    },
    visualMagnitude: 9.88,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.30421118),
        dec: Angle.Degrees(+55.73216313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19537"},
        {"Hipparcos Number", "HIP 14796"},
        {"Geneva Identification System", "GEN# +1.00019537"},
        {"Smithsonian Astrophysical Observation", "SAO 23856"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.76871324),
        dec: Angle.Degrees(+55.73330666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182471"},
        {"Hipparcos Number", "HIP 95185"},
        {"Geneva Identification System", "GEN# +1.00182471"},
        {"Smithsonian Astrophysical Observation", "SAO 31608"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.45317732),
        dec: Angle.Degrees(+55.73853288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16900"},
        {"Hipparcos Number", "HIP 12816"},
        {"Geneva Identification System", "GEN# +1.00016900"},
        {"Renson", "Renson 4280"},
        {"Smithsonian Astrophysical Observation", "SAO 23579"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.19312518),
        dec: Angle.Degrees(+55.73990722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19021",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2955 AB"},
        {"Henry Draper", "HD 25337"},
        {"Hipparcos Number", "HIP 19021"},
        {"Geneva Identification System", "GEN# +1.00025337J"},
        {"Smithsonian Astrophysical Observation", "SAO 24389"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.12233947),
        dec: Angle.Degrees(+55.74065343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160520"},
        {"Hipparcos Number", "HIP 86224"},
        {"Smithsonian Astrophysical Observation", "SAO 30488"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.30948948),
        dec: Angle.Degrees(+55.74097189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131617"},
        {"Hipparcos Number", "HIP 72768"},
        {"Geneva Identification System", "GEN# +1.00131617"},
        {"Smithsonian Astrophysical Observation", "SAO 29317"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.13007131),
        dec: Angle.Degrees(+55.74516320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210262"},
        {"Hipparcos Number", "HIP 109225"},
        {"Geneva Identification System", "GEN# +1.00210262"},
        {"Smithsonian Astrophysical Observation", "SAO 34082"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.91327464),
        dec: Angle.Degrees(+55.74527635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81790"},
        {"Hipparcos Number", "HIP 46566"},
        {"Geneva Identification System", "GEN# +1.00081790"},
        {"Smithsonian Astrophysical Observation", "SAO 27271"},
        {"Wilson Evans Batten Catalogue", "WEB 8785"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.44945400),
        dec: Angle.Degrees(+55.74533554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5150"},
        {"Hipparcos Number", "HIP 4245"},
        {"Smithsonian Astrophysical Observation", "SAO 21822"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.53906047),
        dec: Angle.Degrees(+55.74752645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236150"},
        {"Hipparcos Number", "HIP 116070"},
        {"Smithsonian Astrophysical Observation", "SAO 35494"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.78201914),
        dec: Angle.Degrees(+55.74778208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37030"},
        {"Hipparcos Number", "HIP 26556"},
        {"Geneva Identification System", "GEN# +1.00037030"},
        {"Smithsonian Astrophysical Observation", "SAO 25294"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.70223325),
        dec: Angle.Degrees(+55.74791937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96747",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12781 AB"},
        {"Henry Draper", "HD 186197"},
        {"Hipparcos Number", "HIP 96747"},
        {"Geneva Identification System", "GEN# +1.00186197J"},
        {"Smithsonian Astrophysical Observation", "SAO 31877"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.01125285),
        dec: Angle.Degrees(+55.75405804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26460"},
        {"Hipparcos Number", "HIP 19742"},
        {"Smithsonian Astrophysical Observation", "SAO 24484"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.49440166),
        dec: Angle.Degrees(+55.75449800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224572"},
        {"Hipparcos Number", "HIP 118243"},
        {"Celescope Catalog", "CEL 5732"},
        {"Geneva Identification System", "GEN# +1.00224572"},
        {"Smithsonian Astrophysical Observation", "SAO 35947"},
        {"Wilson Evans Batten Catalogue", "WEB 20782"},
    },
    visualMagnitude: 4.88,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.75220729),
        dec: Angle.Degrees(+55.75494069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60294"},
        {"Hipparcos Number", "HIP 37046"},
        {"Geneva Identification System", "GEN# +1.00060294"},
        {"Smithsonian Astrophysical Observation", "SAO 26423"},
        {"Wilson Evans Batten Catalogue", "WEB 7351"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.19602820),
        dec: Angle.Degrees(+55.75515475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237163"},
        {"Hipparcos Number", "HIP 17106"},
        {"Geneva Identification System", "GEN# +1.00237163"},
        {"Smithsonian Astrophysical Observation", "SAO 24146"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.96794303),
        dec: Angle.Degrees(+55.75828458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210886"},
        {"Hipparcos Number", "HIP 109599"},
        {"Geneva Identification System", "GEN# +1.00210886"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.02379888),
        dec: Angle.Degrees(+55.75852779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 238250"},
        {"Hipparcos Number", "HIP 66084"},
        {"Smithsonian Astrophysical Observation", "SAO 28795"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.20022470),
        dec: Angle.Degrees(+55.75916876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32629"},
        {"Hipparcos Number", "HIP 23865"},
        {"Geneva Identification System", "GEN# +1.00032629"},
        {"Smithsonian Astrophysical Observation", "SAO 25032"},
        {"Wilson Evans Batten Catalogue", "WEB 4654"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.94232497),
        dec: Angle.Degrees(+55.75919312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86344",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10699 AB"},
        {"Henry Draper", "HD 160780"},
        {"Hipparcos Number", "HIP 86344"},
        {"Smithsonian Astrophysical Observation", "SAO 30494"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.65942173),
        dec: Angle.Degrees(+55.75964235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106762",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15154 AB"},
        {"Henry Draper", "HD 206054"},
        {"Hipparcos Number", "HIP 106762"},
        {"Smithsonian Astrophysical Observation", "SAO 33594"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.39457197),
        dec: Angle.Degrees(+55.76353343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12325"},
        {"Wilson Evans Batten Catalogue", "WEB 2527"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.67952447),
        dec: Angle.Degrees(+55.76651056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155343"},
        {"Hipparcos Number", "HIP 83819"},
        {"Geneva Identification System", "GEN# +1.00155343"},
        {"Smithsonian Astrophysical Observation", "SAO 30260"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.95180253),
        dec: Angle.Degrees(+55.76802744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221557"},
        {"Hipparcos Number", "HIP 116201"},
        {"Smithsonian Astrophysical Observation", "SAO 35528"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.15627060),
        dec: Angle.Degrees(+55.76906797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85459"},
        {"Hipparcos Number", "HIP 48515"},
        {"Smithsonian Astrophysical Observation", "SAO 27419"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.41318902),
        dec: Angle.Degrees(+55.76932227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87421"},
        {"Hipparcos Number", "HIP 49506"},
        {"Smithsonian Astrophysical Observation", "SAO 27518"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.61972678),
        dec: Angle.Degrees(+55.76947013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200309"},
        {"Hipparcos Number", "HIP 103674"},
        {"Smithsonian Astrophysical Observation", "SAO 33057"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.10570592),
        dec: Angle.Degrees(+55.77223243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17244"},
        {"Hipparcos Number", "HIP 13088"},
        {"Smithsonian Astrophysical Observation", "SAO 23620"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.06119982),
        dec: Angle.Degrees(+55.77340581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151650"},
        {"Hipparcos Number", "HIP 82048"},
        {"Geneva Identification System", "GEN# +1.00151650"},
        {"Smithsonian Astrophysical Observation", "SAO 30080"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.40199281),
        dec: Angle.Degrees(+55.77364519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237704"},
        {"Hipparcos Number", "HIP 41287"},
        {"Smithsonian Astrophysical Observation", "SAO 26828"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.35859289),
        dec: Angle.Degrees(+55.77427556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106763",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15154 C"},
        {"Henry Draper", "HD 206055"},
        {"Hipparcos Number", "HIP 106763"},
        {"Smithsonian Astrophysical Observation", "SAO 33597"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.39818559),
        dec: Angle.Degrees(+55.77485237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 237724"},
        {"Hipparcos Number", "HIP 41835"},
        {"Geneva Identification System", "GEN# +1.00237724"},
        {"Smithsonian Astrophysical Observation", "SAO 26888"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.92828081),
        dec: Angle.Degrees(+55.77647360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6299"},
        {"Hipparcos Number", "HIP 5067"},
        {"Smithsonian Astrophysical Observation", "SAO 21987"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.20540610),
        dec: Angle.Degrees(+55.77833922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10063"},
        {"Hipparcos Number", "HIP 7745"},
        {"Geneva Identification System", "GEN# +1.00010063"},
        {"Smithsonian Astrophysical Observation", "SAO 22481"},
        {"Wilson Evans Batten Catalogue", "WEB 1662"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.92628750),
        dec: Angle.Degrees(+55.78423713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174413"},
        {"Hipparcos Number", "HIP 92193"},
        {"Geneva Identification System", "GEN# +1.00174413"},
        {"Smithsonian Astrophysical Observation", "SAO 31173"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.83769117),
        dec: Angle.Degrees(+55.78466139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18442"},
        {"Geneva Identification System", "GEN# +8.01550054"},
    },
    visualMagnitude: 11.77,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.13810961),
        dec: Angle.Degrees(+55.78668101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
