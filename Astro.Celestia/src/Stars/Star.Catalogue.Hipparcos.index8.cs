using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_8() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210658"},
        {"Hipparcos Number", "HIP 109749"},
        {"Smithsonian Astrophysical Observation", "SAO 255177"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.46231447),
        dec: Angle.Degrees(-62.28075298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191630"},
        {"Hipparcos Number", "HIP 99758"},
        {"Smithsonian Astrophysical Observation", "SAO 254758"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.60750516),
        dec: Angle.Degrees(-62.27918456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169978"},
        {"Hipparcos Number", "HIP 90797"},
        {"Geneva Identification System", "GEN# +1.00169978"},
        {"Smithsonian Astrophysical Observation", "SAO 254273"},
        {"Wilson Evans Batten Catalogue", "WEB 15559"},
    },
    visualMagnitude: 4.63,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.84344394),
        dec: Angle.Degrees(-62.27819116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27827"},
        {"Hipparcos Number", "HIP 20192"},
        {"Smithsonian Astrophysical Observation", "SAO 248994"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.91437988),
        dec: Angle.Degrees(-62.27513711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15587"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.19298156),
        dec: Angle.Degrees(-62.27454937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 272.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92521"},
        {"Hipparcos Number", "HIP 52167"},
        {"Fundamental Katalog 5th Edition", "FK5 4948"},
        {"Geneva Identification System", "GEN# +1.00092521"},
        {"Smithsonian Astrophysical Observation", "SAO 251053"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.87475453),
        dec: Angle.Degrees(-62.27422980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82347"},
        {"Hipparcos Number", "HIP 46482"},
        {"Geneva Identification System", "GEN# +1.00082347"},
        {"Smithsonian Astrophysical Observation", "SAO 250590"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.19660989),
        dec: Angle.Degrees(-62.27320340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58774"},
        {"Hipparcos Number", "HIP 35806"},
        {"Geneva Identification System", "GEN# +1.00058774"},
        {"Smithsonian Astrophysical Observation", "SAO 249839"},
        {"Wilson Evans Batten Catalogue", "WEB 7137"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.77557960),
        dec: Angle.Degrees(-62.27172750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35854"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.88116577),
        dec: Angle.Degrees(-62.26852139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13538"},
        {"Hipparcos Number", "HIP 10100"},
        {"Geneva Identification System", "GEN# +1.00013538"},
        {"Smithsonian Astrophysical Observation", "SAO 248502"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.47361183),
        dec: Angle.Degrees(-62.26631783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130041"},
        {"Hipparcos Number", "HIP 72437"},
        {"Smithsonian Astrophysical Observation", "SAO 252898"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.18402578),
        dec: Angle.Degrees(-62.26215294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188411"},
        {"Hipparcos Number", "HIP 98338"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.69011235),
        dec: Angle.Degrees(-62.25846078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63809"},
    },
    visualMagnitude: 11.44,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.18384343),
        dec: Angle.Degrees(-62.25761448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -244.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205465"},
        {"Hipparcos Number", "HIP 106809"},
        {"Geneva Identification System", "GEN# +1.00205465"},
        {"Smithsonian Astrophysical Observation", "SAO 255041"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.49202391),
        dec: Angle.Degrees(-62.25429756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85497"},
        {"Hipparcos Number", "HIP 48217"},
        {"Celescope Catalog", "CEL 3387"},
        {"Smithsonian Astrophysical Observation", "SAO 250712"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.45839754),
        dec: Angle.Degrees(-62.25315102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194817"},
        {"Hipparcos Number", "HIP 101237"},
        {"Smithsonian Astrophysical Observation", "SAO 254805"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.80568941),
        dec: Angle.Degrees(-62.24898951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10916"},
        {"Smithsonian Astrophysical Observation", "SAO 248537"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.12936719),
        dec: Angle.Degrees(-62.24777825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5633"},
        {"Hipparcos Number", "HIP 4473"},
        {"Geneva Identification System", "GEN# +1.00005633"},
        {"Wilson Evans Batten Catalogue", "WEB 808"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.32691388),
        dec: Angle.Degrees(-62.24590709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1028.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47792",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47792"},
    },
    visualMagnitude: 10.40,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.15499053),
        dec: Angle.Degrees(-62.24549217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -271.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81453"},
        {"Hipparcos Number", "HIP 46008"},
        {"Geneva Identification System", "GEN# +1.00081453"},
        {"Smithsonian Astrophysical Observation", "SAO 250559"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.75012865),
        dec: Angle.Degrees(-62.24546502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125535"},
        {"Hipparcos Number", "HIP 70244"},
        {"Smithsonian Astrophysical Observation", "SAO 252722"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.58245918),
        dec: Angle.Degrees(-62.24544389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189425"},
        {"Hipparcos Number", "HIP 98769"},
        {"Smithsonian Astrophysical Observation", "SAO 254717"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.90961165),
        dec: Angle.Degrees(-62.24265373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106476"},
        {"Hipparcos Number", "HIP 59738"},
        {"Geneva Identification System", "GEN# +1.00106476"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.76368163),
        dec: Angle.Degrees(-62.24198087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149194"},
        {"Hipparcos Number", "HIP 81369"},
        {"Geneva Identification System", "GEN# +1.00149194"},
        {"Smithsonian Astrophysical Observation", "SAO 253625"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.26712255),
        dec: Angle.Degrees(-62.24022591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88103"},
        {"Hipparcos Number", "HIP 49602"},
        {"Smithsonian Astrophysical Observation", "SAO 250821"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.87172592),
        dec: Angle.Degrees(-62.23977220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204398"},
        {"Hipparcos Number", "HIP 106217"},
        {"Fundamental Katalog 5th Edition", "FK5 5901"},
        {"Smithsonian Astrophysical Observation", "SAO 255012"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.71153785),
        dec: Angle.Degrees(-62.23920919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158311"},
        {"Hipparcos Number", "HIP 85858"},
        {"Geneva Identification System", "GEN# +1.00158311"},
        {"Smithsonian Astrophysical Observation", "SAO 253955"},
        {"Wilson Evans Batten Catalogue", "WEB 14490"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.18332196),
        dec: Angle.Degrees(-62.23636897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87631"},
        {"Hipparcos Number", "HIP 49320"},
        {"Geneva Identification System", "GEN# +1.00087631"},
        {"Smithsonian Astrophysical Observation", "SAO 250800"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.00798315),
        dec: Angle.Degrees(-62.23566775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143755"},
        {"Hipparcos Number", "HIP 78861"},
        {"Smithsonian Astrophysical Observation", "SAO 253420"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.47159495),
        dec: Angle.Degrees(-62.23533121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103182"},
        {"Hipparcos Number", "HIP 57907"},
        {"Celescope Catalog", "CEL 4002"},
        {"Geneva Identification System", "GEN# +1.00103182"},
        {"Smithsonian Astrophysical Observation", "SAO 251623"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.16173754),
        dec: Angle.Degrees(-62.23521773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124167"},
        {"Hipparcos Number", "HIP 69530"},
        {"Smithsonian Astrophysical Observation", "SAO 252656"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.51039099),
        dec: Angle.Degrees(-62.23170864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35813"},
        {"Hipparcos Number", "HIP 25182"},
        {"Smithsonian Astrophysical Observation", "SAO 249261"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.80052376),
        dec: Angle.Degrees(-62.23102238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178906"},
        {"Hipparcos Number", "HIP 94542"},
        {"Smithsonian Astrophysical Observation", "SAO 254504"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.63140132),
        dec: Angle.Degrees(-62.22921238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11305"},
        {"Hipparcos Number", "HIP 8457"},
        {"Smithsonian Astrophysical Observation", "SAO 248441"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.26371054),
        dec: Angle.Degrees(-62.22890128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195552"},
        {"Hipparcos Number", "HIP 101599"},
        {"Smithsonian Astrophysical Observation", "SAO 254822"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.86676616),
        dec: Angle.Degrees(-62.22551726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117114"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.13897536),
        dec: Angle.Degrees(-62.22378526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 123.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88158"},
        {"Hipparcos Number", "HIP 49642"},
        {"Celescope Catalog", "CEL 3446"},
        {"Geneva Identification System", "GEN# +1.00088158"},
        {"Renson", "Renson 25240"},
        {"Smithsonian Astrophysical Observation", "SAO 250826"},
        {"Wilson Evans Batten Catalogue", "WEB 9157"},
    },
    visualMagnitude: 6.45,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.98598839),
        dec: Angle.Degrees(-62.22143545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93011"},
        {"Hipparcos Number", "HIP 52421"},
        {"Smithsonian Astrophysical Observation", "SAO 251082"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.75703094),
        dec: Angle.Degrees(-62.22112013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76919"},
        {"Hipparcos Number", "HIP 43864"},
        {"Smithsonian Astrophysical Observation", "SAO 250381"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.03469471),
        dec: Angle.Degrees(-62.22088458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110786"},
        {"Hipparcos Number", "HIP 62227"},
        {"Geneva Identification System", "GEN# +1.00110786J"},
        {"Smithsonian Astrophysical Observation", "SAO 252014"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.30873893),
        dec: Angle.Degrees(-62.21765658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107652"},
        {"Hipparcos Number", "HIP 60361"},
        {"Celescope Catalog", "CEL 4098"},
        {"Geneva Identification System", "GEN# +1.00107652"},
        {"Smithsonian Astrophysical Observation", "SAO 251871"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.65316250),
        dec: Angle.Degrees(-62.21598014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206841"},
        {"Hipparcos Number", "HIP 107561"},
        {"Geneva Identification System", "GEN# +1.00206841"},
        {"Smithsonian Astrophysical Observation", "SAO 255070"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.77588495),
        dec: Angle.Degrees(-62.21568395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110735"},
        {"Hipparcos Number", "HIP 62204"},
        {"Geneva Identification System", "GEN# +1.00110735"},
        {"Smithsonian Astrophysical Observation", "SAO 252013"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.23538660),
        dec: Angle.Degrees(-62.21424298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221236"},
        {"Hipparcos Number", "HIP 116049"},
        {"Smithsonian Astrophysical Observation", "SAO 255502"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.72419937),
        dec: Angle.Degrees(-62.20974994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129041"},
        {"Hipparcos Number", "HIP 71960"},
        {"Smithsonian Astrophysical Observation", "SAO 252857"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.76849839),
        dec: Angle.Degrees(-62.20725692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102567"},
        {"Hipparcos Number", "HIP 57569"},
        {"Geneva Identification System", "GEN# +1.00102567"},
        {"Smithsonian Astrophysical Observation", "SAO 251595"},
        {"Wilson Evans Batten Catalogue", "WEB 10338"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.00012254),
        dec: Angle.Degrees(-62.20692079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2121"},
        {"Hipparcos Number", "HIP 1973"},
        {"Geneva Identification System", "GEN# +1.00002121"},
        {"Smithsonian Astrophysical Observation", "SAO 248179"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.24095817),
        dec: Angle.Degrees(-62.20632579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17957"},
        {"Hipparcos Number", "HIP 13222"},
        {"Smithsonian Astrophysical Observation", "SAO 248659"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.55339218),
        dec: Angle.Degrees(-62.20628148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28759"},
        {"Hipparcos Number", "HIP 20843"},
        {"Smithsonian Astrophysical Observation", "SAO 249031"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.00360021),
        dec: Angle.Degrees(-62.19995321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101511"},
        {"Hipparcos Number", "HIP 56943"},
        {"Geneva Identification System", "GEN# +1.00101511"},
        {"Smithsonian Astrophysical Observation", "SAO 251530"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.11017820),
        dec: Angle.Degrees(-62.19826472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103336"},
        {"Hipparcos Number", "HIP 57996"},
        {"Celescope Catalog", "CEL 4007"},
        {"Geneva Identification System", "GEN# +1.00103336"},
        {"Smithsonian Astrophysical Observation", "SAO 251629"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.44451469),
        dec: Angle.Degrees(-62.19658677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103589"},
        {"Hipparcos Number", "HIP 58146"},
        {"Geneva Identification System", "GEN# +1.00103589"},
        {"Smithsonian Astrophysical Observation", "SAO 251644"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.87043370),
        dec: Angle.Degrees(-62.19640971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167854"},
        {"Hipparcos Number", "HIP 89950"},
        {"Geneva Identification System", "GEN# +1.00167854"},
        {"Smithsonian Astrophysical Observation", "SAO 254214"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.29482295),
        dec: Angle.Degrees(-62.19267009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27304"},
        {"Hipparcos Number", "HIP 19805"},
        {"Geneva Identification System", "GEN# +1.00027304"},
        {"Smithsonian Astrophysical Observation", "SAO 248973"},
        {"Wilson Evans Batten Catalogue", "WEB 3782"},
    },
    visualMagnitude: 5.45,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.70228830),
        dec: Angle.Degrees(-62.19204942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110830"},
        {"Hipparcos Number", "HIP 62270"},
        {"Geneva Identification System", "GEN# +1.00110830"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.41213315),
        dec: Angle.Degrees(-62.18959204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173948"},
        {"Hipparcos Number", "HIP 92609"},
        {"Fundamental Katalog 5th Edition", "FK5 704"},
        {"Geneva Identification System", "GEN# +1.00173948"},
        {"Smithsonian Astrophysical Observation", "SAO 254393"},
        {"Wilson Evans Batten Catalogue", "WEB 16019"},
    },
    visualMagnitude: 4.22,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.05431892),
        dec: Angle.Degrees(-62.18756062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86061"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.82731992),
        dec: Angle.Degrees(-55.58217095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181773"},
        {"Hipparcos Number", "HIP 95517"},
        {"Geneva Identification System", "GEN# +1.00181773"},
        {"Smithsonian Astrophysical Observation", "SAO 254568"},
        {"Wilson Evans Batten Catalogue", "WEB 16704"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.43043707),
        dec: Angle.Degrees(-62.18635244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135788"},
        {"Hipparcos Number", "HIP 75051"},
        {"Smithsonian Astrophysical Observation", "SAO 253114"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.03933426),
        dec: Angle.Degrees(-62.18604063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1910"},
        {"Geneva Identification System", "GEN# +6.20145165"},
    },
    visualMagnitude: 11.33,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.03694809),
        dec: Angle.Degrees(-62.18441260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19732"},
        {"Hipparcos Number", "HIP 14512"},
        {"Smithsonian Astrophysical Observation", "SAO 248735"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.85381204),
        dec: Angle.Degrees(-62.18391321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170734"},
        {"Hipparcos Number", "HIP 91111"},
        {"Smithsonian Astrophysical Observation", "SAO 254292"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.78059369),
        dec: Angle.Degrees(-62.18389161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192864"},
        {"Hipparcos Number", "HIP 100302"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.14525746),
        dec: Angle.Degrees(-62.17813929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28540"},
        {"Hipparcos Number", "HIP 20703"},
        {"Smithsonian Astrophysical Observation", "SAO 249023"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.52493538),
        dec: Angle.Degrees(-62.17650071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200037"},
        {"Hipparcos Number", "HIP 103965"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.96940533),
        dec: Angle.Degrees(-62.17631430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104631"},
        {"Hipparcos Number", "HIP 58748"},
        {"Celescope Catalog", "CEL 4042"},
        {"Geneva Identification System", "GEN# +1.00104631"},
        {"Smithsonian Astrophysical Observation", "SAO 251702"},
        {"Wilson Evans Batten Catalogue", "WEB 10471"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.73484017),
        dec: Angle.Degrees(-62.17528707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118924"},
        {"Hipparcos Number", "HIP 66814"},
        {"Geneva Identification System", "GEN# +1.00118924"},
        {"Smithsonian Astrophysical Observation", "SAO 252415"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.42792916),
        dec: Angle.Degrees(-62.17380800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -310.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195888"},
        {"Hipparcos Number", "HIP 101747"},
        {"Geneva Identification System", "GEN# +1.00195888"},
        {"Smithsonian Astrophysical Observation", "SAO 254833"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.32762520),
        dec: Angle.Degrees(-62.16784925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204385"},
        {"Hipparcos Number", "HIP 106213"},
        {"Geneva Identification System", "GEN# +1.00204385"},
        {"Smithsonian Astrophysical Observation", "SAO 255011"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.69890767),
        dec: Angle.Degrees(-62.16740825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22517"},
        {"Hipparcos Number", "HIP 16614"},
        {"Geneva Identification System", "GEN# +1.00022517"},
        {"Smithsonian Astrophysical Observation", "SAO 248838"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.45244723),
        dec: Angle.Degrees(-62.16729221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205613"},
        {"Hipparcos Number", "HIP 106889"},
        {"Smithsonian Astrophysical Observation", "SAO 255046"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.74452687),
        dec: Angle.Degrees(-62.16610751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191972"},
        {"Hipparcos Number", "HIP 99896"},
        {"Smithsonian Astrophysical Observation", "SAO 254761"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.02740012),
        dec: Angle.Degrees(-62.16577729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159774"},
        {"Hipparcos Number", "HIP 86505"},
        {"Fundamental Katalog 5th Edition", "FK5 5553"},
        {"Smithsonian Astrophysical Observation", "SAO 253994"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.16900859),
        dec: Angle.Degrees(-62.16236913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158245"},
        {"Hipparcos Number", "HIP 85830"},
        {"Smithsonian Astrophysical Observation", "SAO 253953"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.07034895),
        dec: Angle.Degrees(-62.16236409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6170"},
        {"Hipparcos Number", "HIP 4802"},
        {"Smithsonian Astrophysical Observation", "SAO 248306"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.41263249),
        dec: Angle.Degrees(-62.16231817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25705"},
        {"Hipparcos Number", "HIP 18744"},
        {"Geneva Identification System", "GEN# +1.00025705"},
        {"Smithsonian Astrophysical Observation", "SAO 248925"},
        {"Wilson Evans Batten Catalogue", "WEB 3608"},
    },
    visualMagnitude: 4.48,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.22418760),
        dec: Angle.Degrees(-62.15936923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163030"},
        {"Hipparcos Number", "HIP 87969"},
        {"Smithsonian Astrophysical Observation", "SAO 254092"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.54182661),
        dec: Angle.Degrees(-62.15847731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53026"},
        {"Hipparcos Number", "HIP 33638"},
        {"Smithsonian Astrophysical Observation", "SAO 249698"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.82241972),
        dec: Angle.Degrees(-62.15723770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87438"},
        {"Hipparcos Number", "HIP 49223"},
        {"Geneva Identification System", "GEN# +1.00087438"},
        {"Smithsonian Astrophysical Observation", "SAO 250789"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.70592901),
        dec: Angle.Degrees(-62.15667622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42540"},
        {"Hipparcos Number", "HIP 28991"},
        {"Fundamental Katalog 5th Edition", "FK5 2469"},
        {"Geneva Identification System", "GEN# +1.00042540"},
        {"Smithsonian Astrophysical Observation", "SAO 249451"},
        {"Wilson Evans Batten Catalogue", "WEB 5679"},
    },
    visualMagnitude: 5.04,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.76401174),
        dec: Angle.Degrees(-62.15441128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22629",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22629"},
        {"Geneva Identification System", "GEN# -0.06200394"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.03776533),
        dec: Angle.Degrees(-62.15340492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202565"},
        {"Hipparcos Number", "HIP 105276"},
        {"Smithsonian Astrophysical Observation", "SAO 254974"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.85449516),
        dec: Angle.Degrees(-62.15281426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16921"},
        {"Hipparcos Number", "HIP 12431"},
        {"Smithsonian Astrophysical Observation", "SAO 248620"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.00337463),
        dec: Angle.Degrees(-62.15256932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46190"},
        {"Hipparcos Number", "HIP 30760"},
        {"Geneva Identification System", "GEN# +1.00046190"},
        {"Smithsonian Astrophysical Observation", "SAO 249554"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.95256406),
        dec: Angle.Degrees(-62.14998693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150855"},
        {"Hipparcos Number", "HIP 82202"},
        {"Smithsonian Astrophysical Observation", "SAO 253698"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.90363224),
        dec: Angle.Degrees(-62.14961087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140507"},
        {"Hipparcos Number", "HIP 77346"},
        {"Smithsonian Astrophysical Observation", "SAO 253294"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.84561876),
        dec: Angle.Degrees(-62.14782385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177104"},
        {"Hipparcos Number", "HIP 93909"},
        {"Geneva Identification System", "GEN# +1.00177104"},
        {"Smithsonian Astrophysical Observation", "SAO 254466"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.83188574),
        dec: Angle.Degrees(-62.14725399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94260"},
        {"Hipparcos Number", "HIP 53065"},
        {"Geneva Identification System", "GEN# +1.00094260"},
        {"Smithsonian Astrophysical Observation", "SAO 251151"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.84910443),
        dec: Angle.Degrees(-62.14235550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153182"},
        {"Hipparcos Number", "HIP 83339"},
        {"Geneva Identification System", "GEN# +1.00153182"},
        {"Smithsonian Astrophysical Observation", "SAO 253772"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.47602329),
        dec: Angle.Degrees(-62.14044406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6608"},
        {"Hipparcos Number", "HIP 5129"},
        {"Smithsonian Astrophysical Observation", "SAO 248316"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.41648957),
        dec: Angle.Degrees(-62.13686892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224051"},
        {"Hipparcos Number", "HIP 117901"},
        {"Smithsonian Astrophysical Observation", "SAO 255599"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.72006059),
        dec: Angle.Degrees(-62.13441091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164040"},
        {"Hipparcos Number", "HIP 88441"},
        {"Geneva Identification System", "GEN# +1.00164040"},
        {"Smithsonian Astrophysical Observation", "SAO 254123"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.84703976),
        dec: Angle.Degrees(-62.13379659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67170"},
        {"Hipparcos Number", "HIP 39386"},
        {"Geneva Identification System", "GEN# +1.00067170"},
        {"Smithsonian Astrophysical Observation", "SAO 250091"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.78140930),
        dec: Angle.Degrees(-62.13283841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171652"},
        {"Hipparcos Number", "HIP 91553"},
        {"Geneva Identification System", "GEN# +1.00171652"},
        {"Smithsonian Astrophysical Observation", "SAO 254327"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.06679422),
        dec: Angle.Degrees(-62.12962327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148679"},
        {"Hipparcos Number", "HIP 81077"},
        {"Smithsonian Astrophysical Observation", "SAO 253601"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.39522044),
        dec: Angle.Degrees(-62.12151297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157320"},
        {"Hipparcos Number", "HIP 85370"},
        {"Smithsonian Astrophysical Observation", "SAO 253923"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.66742283),
        dec: Angle.Degrees(-62.12088839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86076"},
        {"Hipparcos Number", "HIP 48539"},
        {"Fundamental Katalog 5th Edition", "FK5 4880"},
        {"Smithsonian Astrophysical Observation", "SAO 250740"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.49291032),
        dec: Angle.Degrees(-62.11964445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174663"},
        {"Hipparcos Number", "HIP 92893"},
        {"Renson", "Renson 48920"},
        {"Smithsonian Astrophysical Observation", "SAO 254408"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.90211010),
        dec: Angle.Degrees(-62.11705154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124564"},
        {"Hipparcos Number", "HIP 69761"},
        {"Smithsonian Astrophysical Observation", "SAO 252682"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.15663351),
        dec: Angle.Degrees(-62.11645279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 308399"},
        {"Hipparcos Number", "HIP 55078"},
    },
    visualMagnitude: 11.07,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.14114246),
        dec: Angle.Degrees(-62.11552133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156140"},
        {"Hipparcos Number", "HIP 84799"},
        {"Smithsonian Astrophysical Observation", "SAO 253873"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.99202917),
        dec: Angle.Degrees(-62.11459659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206397"},
        {"Hipparcos Number", "HIP 107320"},
        {"Geneva Identification System", "GEN# +1.00206397"},
        {"Smithsonian Astrophysical Observation", "SAO 255061"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.06000962),
        dec: Angle.Degrees(-62.11416000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208680"},
        {"Hipparcos Number", "HIP 108610"},
        {"Geneva Identification System", "GEN# +1.00208680"},
        {"Smithsonian Astrophysical Observation", "SAO 255124"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.03100351),
        dec: Angle.Degrees(-62.11140031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113726"},
        {"Hipparcos Number", "HIP 63994"},
        {"Geneva Identification System", "GEN# +1.00113726"},
        {"Smithsonian Astrophysical Observation", "SAO 252153"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.70750987),
        dec: Angle.Degrees(-62.11113490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158730"},
        {"Hipparcos Number", "HIP 86043"},
        {"Smithsonian Astrophysical Observation", "SAO 253964"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.76306655),
        dec: Angle.Degrees(-62.11087567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7680"},
        {"Hipparcos Number", "HIP 5872"},
        {"Smithsonian Astrophysical Observation", "SAO 248343"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.84341157),
        dec: Angle.Degrees(-62.10890922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108594"},
        {"Geneva Identification System", "GEN# +6.20145098"},
    },
    visualMagnitude: 11.97,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.97373132),
        dec: Angle.Degrees(-62.10437818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135831"},
        {"Hipparcos Number", "HIP 75071"},
        {"Smithsonian Astrophysical Observation", "SAO 253117"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.11007753),
        dec: Angle.Degrees(-62.10430446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78507"},
        {"Hipparcos Number", "HIP 44629"},
        {"Celescope Catalog", "CEL 3183"},
        {"Geneva Identification System", "GEN# +1.00078507"},
        {"Smithsonian Astrophysical Observation", "SAO 250438"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.41264406),
        dec: Angle.Degrees(-62.10351495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120112"},
        {"Hipparcos Number", "HIP 67434"},
        {"Geneva Identification System", "GEN# +1.00120112"},
        {"Smithsonian Astrophysical Observation", "SAO 252461"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.30945723),
        dec: Angle.Degrees(-62.10325882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117000"},
        {"Hipparcos Number", "HIP 65760"},
        {"Geneva Identification System", "GEN# +1.00117000"},
        {"Smithsonian Astrophysical Observation", "SAO 252326"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.22886911),
        dec: Angle.Degrees(-62.10227434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120113"},
        {"Hipparcos Number", "HIP 67436"},
        {"Geneva Identification System", "GEN# +1.00120113"},
        {"Smithsonian Astrophysical Observation", "SAO 252462"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.31412411),
        dec: Angle.Degrees(-62.10039397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59575"},
    },
    visualMagnitude: 11.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.24864384),
        dec: Angle.Degrees(-62.09682622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89426"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.76098048),
        dec: Angle.Degrees(-62.09390753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25018"},
        {"Hipparcos Number", "HIP 18307"},
        {"Smithsonian Astrophysical Observation", "SAO 248905"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.70686839),
        dec: Angle.Degrees(-62.09168072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32793"},
        {"Hipparcos Number", "HIP 23383"},
        {"Geneva Identification System", "GEN# +1.00032793"},
        {"Smithsonian Astrophysical Observation", "SAO 249170"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.40450679),
        dec: Angle.Degrees(-62.09062867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 176.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213385"},
        {"Hipparcos Number", "HIP 111280"},
        {"Smithsonian Astrophysical Observation", "SAO 255245"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.14902373),
        dec: Angle.Degrees(-62.09035693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101570"},
        {"Hipparcos Number", "HIP 56986"},
        {"Geneva Identification System", "GEN# +1.00101570"},
        {"Smithsonian Astrophysical Observation", "SAO 251535"},
        {"Wilson Evans Batten Catalogue", "WEB 10257"},
    },
    visualMagnitude: 4.93,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.22355273),
        dec: Angle.Degrees(-62.09010401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114319"},
        {"Hipparcos Number", "HIP 64322"},
        {"Geneva Identification System", "GEN# +1.00114319"},
        {"Smithsonian Astrophysical Observation", "SAO 252180"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.74603187),
        dec: Angle.Degrees(-62.08768399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41450"},
        {"Geneva Identification System", "GEN# -0.06101024"},
        {"Smithsonian Astrophysical Observation", "SAO 250232"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.81948328),
        dec: Angle.Degrees(-62.08762602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138210"},
        {"Hipparcos Number", "HIP 76199"},
        {"Smithsonian Astrophysical Observation", "SAO 253213"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.47137358),
        dec: Angle.Degrees(-62.08295651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157992"},
        {"Hipparcos Number", "HIP 85694"},
        {"Smithsonian Astrophysical Observation", "SAO 253944"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.68465743),
        dec: Angle.Degrees(-62.08273460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3259"},
        {"Hipparcos Number", "HIP 2755"},
        {"Smithsonian Astrophysical Observation", "SAO 248218"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.79513293),
        dec: Angle.Degrees(-62.08142630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117297"},
        {"Hipparcos Number", "HIP 65925"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.72190959),
        dec: Angle.Degrees(-62.08106772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39755"},
        {"Hipparcos Number", "HIP 27568"},
        {"Geneva Identification System", "GEN# +1.00039755"},
        {"Smithsonian Astrophysical Observation", "SAO 249366"},
        {"Wilson Evans Batten Catalogue", "WEB 5412"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.57800669),
        dec: Angle.Degrees(-62.08011765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99000"},
        {"Hipparcos Number", "HIP 55557"},
        {"Smithsonian Astrophysical Observation", "SAO 251377"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.69763725),
        dec: Angle.Degrees(-62.07836434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29712"},
        {"Hipparcos Number", "HIP 21479"},
        {"Geneva Identification System", "GEN# +1.00029712"},
        {"Smithsonian Astrophysical Observation", "SAO 249066"},
        {"Wilson Evans Batten Catalogue", "WEB 4124"},
    },
    visualMagnitude: 5.59,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.19032350),
        dec: Angle.Degrees(-62.07698129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4532"},
        {"Hipparcos Number", "HIP 3626"},
        {"Smithsonian Astrophysical Observation", "SAO 248250"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.62382280),
        dec: Angle.Degrees(-62.07611360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108531"},
        {"Hipparcos Number", "HIP 60859"},
        {"Geneva Identification System", "GEN# +1.00108531"},
        {"Smithsonian Astrophysical Observation", "SAO 251923"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.10471981),
        dec: Angle.Degrees(-62.07567046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21114"},
        {"Hipparcos Number", "HIP 15622"},
        {"Smithsonian Astrophysical Observation", "SAO 248783"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.29755089),
        dec: Angle.Degrees(-62.07419265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90151"},
        {"Hipparcos Number", "HIP 50821"},
        {"Celescope Catalog", "CEL 3522"},
        {"Geneva Identification System", "GEN# +1.00090151"},
        {"Smithsonian Astrophysical Observation", "SAO 250936"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.65608450),
        dec: Angle.Degrees(-62.07303368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11449"},
        {"Hipparcos Number", "HIP 8577"},
        {"Smithsonian Astrophysical Observation", "SAO 248449"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.65360388),
        dec: Angle.Degrees(-62.07079302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119718"},
        {"Hipparcos Number", "HIP 67230"},
        {"Smithsonian Astrophysical Observation", "SAO 252443"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.64763520),
        dec: Angle.Degrees(-62.06932668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72541"},
        {"Hipparcos Number", "HIP 41698"},
        {"Smithsonian Astrophysical Observation", "SAO 250248"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.51691600),
        dec: Angle.Degrees(-62.06704028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19564"},
        {"Hipparcos Number", "HIP 14398"},
        {"Geneva Identification System", "GEN# +1.00019564"},
        {"Smithsonian Astrophysical Observation", "SAO 248730"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.43548518),
        dec: Angle.Degrees(-62.06600527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214916"},
        {"Hipparcos Number", "HIP 112157"},
        {"Smithsonian Astrophysical Observation", "SAO 255294"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.75004550),
        dec: Angle.Degrees(-62.06580366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66030"},
        {"Hipparcos Number", "HIP 38929"},
        {"Smithsonian Astrophysical Observation", "SAO 250039"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.48147205),
        dec: Angle.Degrees(-62.06502154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99805"},
        {"Hipparcos Number", "HIP 55978"},
        {"Geneva Identification System", "GEN# +1.00099805"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.07465525),
        dec: Angle.Degrees(-62.06322298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142493"},
        {"Hipparcos Number", "HIP 78231"},
        {"Smithsonian Astrophysical Observation", "SAO 253361"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.61805586),
        dec: Angle.Degrees(-62.06043881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115033"},
        {"Hipparcos Number", "HIP 64702"},
        {"Geneva Identification System", "GEN# +1.00115033"},
        {"Smithsonian Astrophysical Observation", "SAO 252229"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.91608442),
        dec: Angle.Degrees(-62.05989787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126672"},
        {"Hipparcos Number", "HIP 70856"},
        {"Smithsonian Astrophysical Observation", "SAO 252756"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.34135754),
        dec: Angle.Degrees(-62.05793721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 308162"},
        {"Hipparcos Number", "HIP 53912"},
        {"Geneva Identification System", "GEN# +1.00308162"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.47066857),
        dec: Angle.Degrees(-62.05428704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104994"},
        {"Hipparcos Number", "HIP 58954"},
        {"Geneva Identification System", "GEN# +1.00104994"},
    },
    visualMagnitude: 10.83,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.32802929),
        dec: Angle.Degrees(-62.05281813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207575"},
        {"Hipparcos Number", "HIP 107947"},
        {"Geneva Identification System", "GEN# +1.00207575"},
        {"Smithsonian Astrophysical Observation", "SAO 255093"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.04029234),
        dec: Angle.Degrees(-62.05214091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37630"},
        {"Hipparcos Number", "HIP 26266"},
        {"Geneva Identification System", "GEN# +1.00037630"},
        {"Smithsonian Astrophysical Observation", "SAO 249319"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.90632618),
        dec: Angle.Degrees(-62.05199036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92451",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92451"},
        {"Geneva Identification System", "GEN# +6.20145022"},
    },
    visualMagnitude: 10.74,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.61055290),
        dec: Angle.Degrees(-62.05117896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185473"},
        {"Hipparcos Number", "HIP 97010"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.75514904),
        dec: Angle.Degrees(-62.04873572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33700"},
        {"Hipparcos Number", "HIP 23886"},
        {"Smithsonian Astrophysical Observation", "SAO 249199"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.98358582),
        dec: Angle.Degrees(-62.04674560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85769"},
        {"Hipparcos Number", "HIP 48388"},
        {"Celescope Catalog", "CEL 3391"},
        {"Smithsonian Astrophysical Observation", "SAO 250729"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.95844520),
        dec: Angle.Degrees(-62.04551922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94613"},
        {"Hipparcos Number", "HIP 53300"},
        {"Geneva Identification System", "GEN# +1.00094613"},
        {"Smithsonian Astrophysical Observation", "SAO 251169"},
    },
    visualMagnitude: 7.75,
    bvColour: 2.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.52608883),
        dec: Angle.Degrees(-62.04245570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93989"},
        {"Hipparcos Number", "HIP 52946"},
        {"Smithsonian Astrophysical Observation", "SAO 251143"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.41055848),
        dec: Angle.Degrees(-62.04083033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34275"},
        {"Hipparcos Number", "HIP 24233"},
        {"Smithsonian Astrophysical Observation", "SAO 249216"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.04047017),
        dec: Angle.Degrees(-62.04006696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90067"},
        {"Hipparcos Number", "HIP 50759"},
        {"Geneva Identification System", "GEN# +1.00090067"},
        {"Smithsonian Astrophysical Observation", "SAO 250931"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.48044042),
        dec: Angle.Degrees(-62.03612321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161093"},
        {"Hipparcos Number", "HIP 87090"},
        {"Smithsonian Astrophysical Observation", "SAO 254036"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.92730407),
        dec: Angle.Degrees(-62.03275002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109866"},
        {"Hipparcos Number", "HIP 61700"},
        {"Smithsonian Astrophysical Observation", "SAO 251981"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.70825387),
        dec: Angle.Degrees(-62.03170551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115668"},
        {"Hipparcos Number", "HIP 65045"},
        {"Geneva Identification System", "GEN# +1.00115668"},
        {"Smithsonian Astrophysical Observation", "SAO 252267"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.99394952),
        dec: Angle.Degrees(-62.03119105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123779"},
        {"Hipparcos Number", "HIP 69358"},
        {"Geneva Identification System", "GEN# +1.00123779"},
        {"Smithsonian Astrophysical Observation", "SAO 252644"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.94998554),
        dec: Angle.Degrees(-62.02633954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93760"},
        {"Hipparcos Number", "HIP 52829"},
        {"Smithsonian Astrophysical Observation", "SAO 251129"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.02433823),
        dec: Angle.Degrees(-62.02580966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87472"},
        {"Hipparcos Number", "HIP 49236"},
        {"Celescope Catalog", "CEL 3432"},
        {"Smithsonian Astrophysical Observation", "SAO 250791"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.76626206),
        dec: Angle.Degrees(-62.02117495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90774"},
        {"Hipparcos Number", "HIP 51177"},
        {"Geneva Identification System", "GEN# +1.00090774"},
        {"Smithsonian Astrophysical Observation", "SAO 250961"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.79336573),
        dec: Angle.Degrees(-62.01866529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116119"},
        {"Hipparcos Number", "HIP 65294"},
        {"Geneva Identification System", "GEN# +1.00116119"},
        {"Smithsonian Astrophysical Observation", "SAO 252285"},
        {"Wilson Evans Batten Catalogue", "WEB 11523"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.73183270),
        dec: Angle.Degrees(-62.01222049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128037"},
        {"Hipparcos Number", "HIP 71492"},
        {"Geneva Identification System", "GEN# +1.00128037"},
        {"Smithsonian Astrophysical Observation", "SAO 252822"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.29987648),
        dec: Angle.Degrees(-62.01089132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171909"},
        {"Hipparcos Number", "HIP 91651"},
        {"Smithsonian Astrophysical Observation", "SAO 254335"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.35211728),
        dec: Angle.Degrees(-62.00984748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223285"},
        {"Hipparcos Number", "HIP 117406"},
        {"Smithsonian Astrophysical Observation", "SAO 255572"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.09906010),
        dec: Angle.Degrees(-62.00807105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22166"},
        {"Hipparcos Number", "HIP 16370"},
        {"Geneva Identification System", "GEN# +1.00022166"},
        {"Smithsonian Astrophysical Observation", "SAO 248821"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.71863957),
        dec: Angle.Degrees(-62.00798965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 307693"},
        {"Hipparcos Number", "HIP 51166"},
        {"Geneva Identification System", "GEN# +1.00307693"},
        {"Smithsonian Astrophysical Observation", "SAO 250959"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.76709306),
        dec: Angle.Degrees(-62.00581388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165499"},
        {"Hipparcos Number", "HIP 89042"},
        {"Geneva Identification System", "GEN# +1.00165499"},
        {"Smithsonian Astrophysical Observation", "SAO 254157"},
        {"Wilson Evans Batten Catalogue", "WEB 15114"},
    },
    visualMagnitude: 5.47,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.60941453),
        dec: Angle.Degrees(-62.00276787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 234.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104901B"},
        {"Hipparcos Number", "HIP 58910"},
        {"Smithsonian Astrophysical Observation", "SAO 251722"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.20343804),
        dec: Angle.Degrees(-62.00229235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219482"},
        {"Hipparcos Number", "HIP 114948"},
        {"Fundamental Katalog 5th Edition", "FK5 876"},
        {"Geneva Identification System", "GEN# +1.00219482"},
        {"Smithsonian Astrophysical Observation", "SAO 255446"},
        {"Wilson Evans Batten Catalogue", "WEB 20365"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.23945138),
        dec: Angle.Degrees(-62.00113447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75914"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.58815325),
        dec: Angle.Degrees(-61.99981895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36241",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36241"},
    },
    visualMagnitude: 11.08,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.94822066),
        dec: Angle.Degrees(-61.99920140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196967"},
        {"Hipparcos Number", "HIP 102317"},
        {"Smithsonian Astrophysical Observation", "SAO 254858"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.96563265),
        dec: Angle.Degrees(-61.99913234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41340"},
        {"Hipparcos Number", "HIP 28439"},
        {"Geneva Identification System", "GEN# +1.00041340"},
        {"Smithsonian Astrophysical Observation", "SAO 249413"},
        {"Wilson Evans Batten Catalogue", "WEB 5559"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.07940853),
        dec: Angle.Degrees(-61.99847785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104901"},
        {"Henry Draper 2", "HD 104901A"},
        {"Hipparcos Number", "HIP 58906"},
        {"Geneva Identification System", "GEN# +1.00104901A"},
        {"Smithsonian Astrophysical Observation", "SAO 251721"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.19576793),
        dec: Angle.Degrees(-61.99683380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126391"},
        {"Hipparcos Number", "HIP 70686"},
        {"Geneva Identification System", "GEN# +1.00126391"},
        {"Smithsonian Astrophysical Observation", "SAO 252750"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.87325462),
        dec: Angle.Degrees(-61.99665219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131146"},
        {"Hipparcos Number", "HIP 72967"},
        {"Geneva Identification System", "GEN# +1.00131146"},
        {"Smithsonian Astrophysical Observation", "SAO 252952"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.67938987),
        dec: Angle.Degrees(-61.99548987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152373"},
        {"Hipparcos Number", "HIP 82932"},
        {"Smithsonian Astrophysical Observation", "SAO 253745"},
    },
    visualMagnitude: 8.64,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.21809114),
        dec: Angle.Degrees(-61.99513583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10586"},
        {"Hipparcos Number", "HIP 7888"},
        {"Geneva Identification System", "GEN# +1.00010586"},
        {"Smithsonian Astrophysical Observation", "SAO 248419"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.36972380),
        dec: Angle.Degrees(-61.99496268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103181"},
        {"Hipparcos Number", "HIP 57909"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.16594007),
        dec: Angle.Degrees(-61.99439523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81038"},
        {"Hipparcos Number", "HIP 45817"},
        {"Celescope Catalog", "CEL 3272"},
        {"Geneva Identification System", "GEN# +1.00081038"},
        {"Smithsonian Astrophysical Observation", "SAO 250540"},
        {"Wilson Evans Batten Catalogue", "WEB 8688"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.13274912),
        dec: Angle.Degrees(-61.99306715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117491"},
        {"Hipparcos Number", "HIP 66030"},
        {"Smithsonian Astrophysical Observation", "SAO 252354"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.05943247),
        dec: Angle.Degrees(-61.99056907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104901C"},
        {"Hipparcos Number", "HIP 58909"},
        {"Geneva Identification System", "GEN# -0.06102934"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.20045315),
        dec: Angle.Degrees(-61.99027505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110163"},
        {"Hipparcos Number", "HIP 61885"},
        {"Geneva Identification System", "GEN# +1.00110163"},
        {"Smithsonian Astrophysical Observation", "SAO 251993"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.21509669),
        dec: Angle.Degrees(-61.99005735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217140"},
        {"Hipparcos Number", "HIP 113526"},
        {"Renson", "Renson 59940"},
        {"Smithsonian Astrophysical Observation", "SAO 255367"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.88603922),
        dec: Angle.Degrees(-61.98648166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27264"},
        {"Hipparcos Number", "HIP 19795"},
        {"Smithsonian Astrophysical Observation", "SAO 248970"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.64178075),
        dec: Angle.Degrees(-61.98479009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46549"},
        {"Hipparcos Number", "HIP 30956"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.46850805),
        dec: Angle.Degrees(-61.98465100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15578"},
        {"Hipparcos Number", "HIP 11456"},
        {"Geneva Identification System", "GEN# +1.00015578"},
        {"Smithsonian Astrophysical Observation", "SAO 248565"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.94528432),
        dec: Angle.Degrees(-61.98457979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213442"},
        {"Hipparcos Number", "HIP 111310"},
        {"Fundamental Katalog 5th Edition", "FK5 3803"},
        {"Geneva Identification System", "GEN# +1.00213442"},
        {"Smithsonian Astrophysical Observation", "SAO 255247"},
        {"Wilson Evans Batten Catalogue", "WEB 19912"},
    },
    visualMagnitude: 4.91,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.25005260),
        dec: Angle.Degrees(-61.98207300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210547"},
        {"Hipparcos Number", "HIP 109671"},
        {"Smithsonian Astrophysical Observation", "SAO 255171"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.25003336),
        dec: Angle.Degrees(-61.98135933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77764"},
        {"Geneva Identification System", "GEN# -0.06105327"},
        {"Smithsonian Astrophysical Observation", "SAO 253324"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.17433481),
        dec: Angle.Degrees(-61.97285651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115652"},
        {"Hipparcos Number", "HIP 65033"},
        {"Celescope Catalog", "CEL 4234"},
        {"Geneva Identification System", "GEN# +1.00115652"},
        {"Smithsonian Astrophysical Observation", "SAO 252265"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.96058163),
        dec: Angle.Degrees(-61.96905608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198535"},
        {"Hipparcos Number", "HIP 103156"},
        {"Smithsonian Astrophysical Observation", "SAO 254894"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.49647618),
        dec: Angle.Degrees(-61.96538149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84947"},
        {"Hipparcos Number", "HIP 47951"},
        {"Smithsonian Astrophysical Observation", "SAO 250690"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.57084608),
        dec: Angle.Degrees(-61.96330823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201453"},
        {"Hipparcos Number", "HIP 104702"},
        {"Smithsonian Astrophysical Observation", "SAO 254954"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.12969414),
        dec: Angle.Degrees(-61.96062096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121795"},
        {"Hipparcos Number", "HIP 68362"},
        {"Renson", "Renson 35010"},
        {"Smithsonian Astrophysical Observation", "SAO 252543"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.90376562),
        dec: Angle.Degrees(-61.96033956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105730",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105730"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.21788476),
        dec: Angle.Degrees(-61.95848477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25796"},
        {"Hipparcos Number", "HIP 18797"},
        {"Smithsonian Astrophysical Observation", "SAO 248929"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.41099291),
        dec: Angle.Degrees(-61.95840616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122179"},
        {"Hipparcos Number", "HIP 68564"},
        {"Geneva Identification System", "GEN# +1.00122179"},
        {"Smithsonian Astrophysical Observation", "SAO 252571"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.54534955),
        dec: Angle.Degrees(-61.95789283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84059"},
    },
    visualMagnitude: 9.81,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.78075245),
        dec: Angle.Degrees(-61.95422596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146038"},
        {"Hipparcos Number", "HIP 79847"},
        {"Smithsonian Astrophysical Observation", "SAO 253486"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.46475174),
        dec: Angle.Degrees(-61.95251546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58448"},
        {"Hipparcos Number", "HIP 35676"},
        {"Geneva Identification System", "GEN# +1.00058448"},
        {"Renson", "Renson 15970"},
        {"Smithsonian Astrophysical Observation", "SAO 249832"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.42132393),
        dec: Angle.Degrees(-61.95148186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35093"},
        {"Hipparcos Number", "HIP 24725"},
        {"Smithsonian Astrophysical Observation", "SAO 249240"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.54317470),
        dec: Angle.Degrees(-61.95079118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81830"},
        {"Hipparcos Number", "HIP 46225"},
        {"Celescope Catalog", "CEL 3292"},
        {"Geneva Identification System", "GEN# +1.00081830A"},
        {"Smithsonian Astrophysical Observation", "SAO 250575"},
        {"Wilson Evans Batten Catalogue", "WEB 8748"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.36407358),
        dec: Angle.Degrees(-61.95061204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158207"},
        {"Hipparcos Number", "HIP 85815"},
        {"Smithsonian Astrophysical Observation", "SAO 253952"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.02129202),
        dec: Angle.Degrees(-61.95054005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153468"},
        {"Hipparcos Number", "HIP 83483"},
        {"Smithsonian Astrophysical Observation", "SAO 253782"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.92828514),
        dec: Angle.Degrees(-61.95034074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178086"},
        {"Hipparcos Number", "HIP 94263"},
        {"Smithsonian Astrophysical Observation", "SAO 254487"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.80138501),
        dec: Angle.Degrees(-61.95015447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128697"},
        {"Hipparcos Number", "HIP 71780"},
        {"Renson", "Renson 36620"},
        {"Smithsonian Astrophysical Observation", "SAO 252843"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.24935739),
        dec: Angle.Degrees(-61.94923124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96919"},
        {"Hipparcos Number", "HIP 54461"},
        {"Celescope Catalog", "CEL 3824"},
        {"Fundamental Katalog 5th Edition", "FK5 2891"},
        {"Geneva Identification System", "GEN# +1.00096919"},
        {"Renson", "Renson 27980"},
        {"Smithsonian Astrophysical Observation", "SAO 251286"},
        {"Wilson Evans Batten Catalogue", "WEB 9833"},
    },
    visualMagnitude: 5.11,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.14169012),
        dec: Angle.Degrees(-61.94717969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50241"},
        {"Hipparcos Number", "HIP 32607"},
        {"Celescope Catalog", "CEL 1399"},
        {"Fundamental Katalog 5th Edition", "FK5 262"},
        {"Geneva Identification System", "GEN# +1.00050241"},
        {"Smithsonian Astrophysical Observation", "SAO 249647"},
        {"Wilson Evans Batten Catalogue", "WEB 6577"},
    },
    visualMagnitude: 3.24,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.04807134),
        dec: Angle.Degrees(-61.94197988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 242.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93484"},
        {"Hipparcos Number", "HIP 52670"},
        {"Celescope Catalog", "CEL 3694"},
        {"Geneva Identification System", "GEN# +1.00093484"},
        {"Smithsonian Astrophysical Observation", "SAO 251111"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.55276505),
        dec: Angle.Degrees(-61.94166891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14642"},
        {"Hipparcos Number", "HIP 10834"},
        {"Geneva Identification System", "GEN# +1.00014642"},
        {"Smithsonian Astrophysical Observation", "SAO 248531"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.85444372),
        dec: Angle.Degrees(-61.93851059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 156.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171989"},
        {"Hipparcos Number", "HIP 91679"},
        {"Smithsonian Astrophysical Observation", "SAO 254337"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.43382684),
        dec: Angle.Degrees(-61.93649771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10122"},
        {"Hipparcos Number", "HIP 7543"},
        {"Geneva Identification System", "GEN# +1.00010122"},
        {"Smithsonian Astrophysical Observation", "SAO 248409"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.29391767),
        dec: Angle.Degrees(-61.93528349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167300"},
        {"Hipparcos Number", "HIP 89733"},
        {"Geneva Identification System", "GEN# +1.00167300"},
        {"Smithsonian Astrophysical Observation", "SAO 254201"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.68556919),
        dec: Angle.Degrees(-61.93517223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102474"},
        {"Hipparcos Number", "HIP 57521"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.84147755),
        dec: Angle.Degrees(-61.93382668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130438"},
        {"Hipparcos Number", "HIP 72633"},
        {"Smithsonian Astrophysical Observation", "SAO 252915"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.75944640),
        dec: Angle.Degrees(-61.93256708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86675"},
        {"Hipparcos Number", "HIP 48849"},
        {"Celescope Catalog", "CEL 3419"},
        {"Geneva Identification System", "GEN# +1.00086675"},
        {"Smithsonian Astrophysical Observation", "SAO 250762"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.45570350),
        dec: Angle.Degrees(-61.93198271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87527"},
        {"Hipparcos Number", "HIP 49276"},
        {"Smithsonian Astrophysical Observation", "SAO 250794"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.87566193),
        dec: Angle.Degrees(-61.92965436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145020"},
        {"Hipparcos Number", "HIP 79411"},
        {"Smithsonian Astrophysical Observation", "SAO 253459"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.09258271),
        dec: Angle.Degrees(-61.92894089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161566"},
        {"Hipparcos Number", "HIP 87312"},
        {"Geneva Identification System", "GEN# +1.00161566"},
        {"Smithsonian Astrophysical Observation", "SAO 254050"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.60685868),
        dec: Angle.Degrees(-61.92467715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36660"},
        {"Hipparcos Number", "HIP 25693"},
        {"Smithsonian Astrophysical Observation", "SAO 249287"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.30756368),
        dec: Angle.Degrees(-61.92142663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 308172"},
        {"Hipparcos Number", "HIP 53997"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.69407097),
        dec: Angle.Degrees(-61.91656543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3221"},
        {"Hipparcos Number", "HIP 2729"},
        {"Geneva Identification System", "GEN# +1.00003221"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.71288230),
        dec: Angle.Degrees(-61.91601812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222925"},
        {"Hipparcos Number", "HIP 117168"},
        {"Geneva Identification System", "GEN# +1.00222925"},
        {"Renson", "Renson 61140"},
        {"Smithsonian Astrophysical Observation", "SAO 255561"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.32256440),
        dec: Angle.Degrees(-61.91165803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120841"},
        {"Hipparcos Number", "HIP 67849"},
        {"Geneva Identification System", "GEN# +2.53160118"},
        {"New General Catalogue", "NGC 5316 118"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.46504656),
        dec: Angle.Degrees(-61.91011348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36772"},
        {"Smithsonian Astrophysical Observation", "SAO 249879"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.44969153),
        dec: Angle.Degrees(-61.90935526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108904"},
        {"Hipparcos Number", "HIP 61087"},
        {"Geneva Identification System", "GEN# +1.00108904"},
        {"Smithsonian Astrophysical Observation", "SAO 251941"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.80285143),
        dec: Angle.Degrees(-61.90871118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192510"},
        {"Hipparcos Number", "HIP 100128"},
        {"Smithsonian Astrophysical Observation", "SAO 254770"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.68175191),
        dec: Angle.Degrees(-61.90660284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60488"},
        {"New General Catalogue", "NGC 4349 67"},
    },
    visualMagnitude: 11.53,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.01181898),
        dec: Angle.Degrees(-61.90629393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192572"},
        {"Hipparcos Number", "HIP 100157"},
        {"Smithsonian Astrophysical Observation", "SAO 254773"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.74545041),
        dec: Angle.Degrees(-61.90255580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106391"},
        {"Hipparcos Number", "HIP 59698"},
        {"Geneva Identification System", "GEN# +1.00106391"},
        {"Smithsonian Astrophysical Observation", "SAO 251805"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.63019641),
        dec: Angle.Degrees(-61.90180085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63086"},
        {"Hipparcos Number", "HIP 37621"},
        {"Geneva Identification System", "GEN# +1.00063086"},
        {"Smithsonian Astrophysical Observation", "SAO 249936"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.79813616),
        dec: Angle.Degrees(-61.90126093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37583",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37583"},
        {"Smithsonian Astrophysical Observation", "SAO 249933"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.69071784),
        dec: Angle.Degrees(-61.90002349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223740"},
        {"Hipparcos Number", "HIP 117721"},
        {"Smithsonian Astrophysical Observation", "SAO 255589"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.12428272),
        dec: Angle.Degrees(-61.89812579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106125"},
        {"Hipparcos Number", "HIP 59553"},
        {"Smithsonian Astrophysical Observation", "SAO 251792"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.20632510),
        dec: Angle.Degrees(-61.89786477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25581"},
        {"Hipparcos Number", "HIP 18677"},
        {"Smithsonian Astrophysical Observation", "SAO 248922"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.99719543),
        dec: Angle.Degrees(-61.89478514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119076"},
        {"Hipparcos Number", "HIP 66910"},
        {"Geneva Identification System", "GEN# +1.00119076J"},
        {"Smithsonian Astrophysical Observation", "SAO 252422"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.68547440),
        dec: Angle.Degrees(-61.89202466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114668"},
        {"Hipparcos Number", "HIP 64494"},
        {"Smithsonian Astrophysical Observation", "SAO 252203"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.29456332),
        dec: Angle.Degrees(-61.89200154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133738"},
        {"Hipparcos Number", "HIP 74147"},
        {"Geneva Identification System", "GEN# +1.00133738"},
        {"Smithsonian Astrophysical Observation", "SAO 253030"},
        {"Wilson Evans Batten Catalogue", "WEB 12666"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.26383628),
        dec: Angle.Degrees(-61.88756154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207964"},
        {"Hipparcos Number", "HIP 108195"},
        {"Geneva Identification System", "GEN# +1.00207964"},
        {"Smithsonian Astrophysical Observation", "SAO 255101"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.79724631),
        dec: Angle.Degrees(-61.88638824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88294"},
        {"Hipparcos Number", "HIP 49706"},
        {"Geneva Identification System", "GEN# +1.00088294A"},
        {"Smithsonian Astrophysical Observation", "SAO 250834"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.21791869),
        dec: Angle.Degrees(-61.88618352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87543"},
        {"Hipparcos Number", "HIP 49281"},
        {"Celescope Catalog", "CEL 3434"},
        {"Geneva Identification System", "GEN# +1.00087543J"},
        {"Smithsonian Astrophysical Observation", "SAO 250795"},
        {"Wilson Evans Batten Catalogue", "WEB 9119"},
    },
    visualMagnitude: 6.14,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.89224818),
        dec: Angle.Degrees(-61.88405008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67823"},
        {"New General Catalogue", "NGC 5316 76"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.39541894),
        dec: Angle.Degrees(-61.88316106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145706"},
        {"Hipparcos Number", "HIP 79705"},
        {"Smithsonian Astrophysical Observation", "SAO 253476"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.00041147),
        dec: Angle.Degrees(-61.88282480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199847"},
        {"Hipparcos Number", "HIP 103854"},
        {"Geneva Identification System", "GEN# +1.00199847"},
        {"Smithsonian Astrophysical Observation", "SAO 254923"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.66244551),
        dec: Angle.Degrees(-61.88032814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46792"},
        {"Hipparcos Number", "HIP 31068"},
        {"Geneva Identification System", "GEN# +1.00046792"},
        {"Smithsonian Astrophysical Observation", "SAO 249572"},
        {"Wilson Evans Batten Catalogue", "WEB 6186"},
    },
    visualMagnitude: 6.15,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.79437640),
        dec: Angle.Degrees(-61.87957075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76957"},
        {"Hipparcos Number", "HIP 43887"},
        {"Smithsonian Astrophysical Observation", "SAO 250385"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.10442853),
        dec: Angle.Degrees(-61.87822364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66750"},
        {"Hipparcos Number", "HIP 39216"},
        {"Smithsonian Astrophysical Observation", "SAO 250074"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.32661829),
        dec: Angle.Degrees(-61.87726829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132482"},
        {"Hipparcos Number", "HIP 73572"},
        {"Smithsonian Astrophysical Observation", "SAO 252995"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.55517372),
        dec: Angle.Degrees(-61.87721789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61644"},
        {"Hipparcos Number", "HIP 37012"},
        {"Smithsonian Astrophysical Observation", "SAO 249891"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.10525121),
        dec: Angle.Degrees(-61.87387756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131229"},
        {"Hipparcos Number", "HIP 72995"},
        {"Geneva Identification System", "GEN# +1.00131229"},
        {"Smithsonian Astrophysical Observation", "SAO 252957"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.77367595),
        dec: Angle.Degrees(-61.87384971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72374"},
        {"Hipparcos Number", "HIP 41620"},
        {"Geneva Identification System", "GEN# +1.00072374"},
        {"Smithsonian Astrophysical Observation", "SAO 250242"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.28106327),
        dec: Angle.Degrees(-61.87343162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209283"},
        {"Hipparcos Number", "HIP 108944"},
        {"Smithsonian Astrophysical Observation", "SAO 255137"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.07584548),
        dec: Angle.Degrees(-61.87264136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6870"},
        {"Hipparcos Number", "HIP 5321"},
        {"Geneva Identification System", "GEN# +1.00006870"},
        {"Smithsonian Astrophysical Observation", "SAO 248325"},
        {"Wilson Evans Batten Catalogue", "WEB 1147"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.01591273),
        dec: Angle.Degrees(-61.87158411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108610"},
        {"Hipparcos Number", "HIP 60905"},
        {"Celescope Catalog", "CEL 4112"},
        {"Geneva Identification System", "GEN# +1.00108610A"},
        {"Smithsonian Astrophysical Observation", "SAO 251928"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.22865079),
        dec: Angle.Degrees(-61.87090884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77405"},
        {"Hipparcos Number", "HIP 44131"},
        {"Geneva Identification System", "GEN# +1.00077405"},
        {"Smithsonian Astrophysical Observation", "SAO 250411"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.81789189),
        dec: Angle.Degrees(-61.87010902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66795",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66795"},
        {"Smithsonian Astrophysical Observation", "SAO 252413"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.35864624),
        dec: Angle.Degrees(-61.86795359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82519"},
        {"Hipparcos Number", "HIP 46584"},
        {"Smithsonian Astrophysical Observation", "SAO 250599"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.48843622),
        dec: Angle.Degrees(-61.86733452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127428"},
        {"Hipparcos Number", "HIP 71217"},
        {"Geneva Identification System", "GEN# +1.00127428"},
        {"Smithsonian Astrophysical Observation", "SAO 252788"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.46360721),
        dec: Angle.Degrees(-61.86488889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67906"},
        {"Geneva Identification System", "GEN# +2.53160101"},
        {"New General Catalogue", "NGC 5316 101"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.62606862),
        dec: Angle.Degrees(-61.86453891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149993"},
        {"Hipparcos Number", "HIP 81762"},
        {"Smithsonian Astrophysical Observation", "SAO 253661"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.50402067),
        dec: Angle.Degrees(-61.86406833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54524"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.34223428),
        dec: Angle.Degrees(-61.86230048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216867"},
        {"Hipparcos Number", "HIP 113372"},
        {"Smithsonian Astrophysical Observation", "SAO 255357"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.42011144),
        dec: Angle.Degrees(-61.86107800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219472"},
        {"Hipparcos Number", "HIP 114932"},
        {"Smithsonian Astrophysical Observation", "SAO 255444"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.20531140),
        dec: Angle.Degrees(-61.86089134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148597"},
        {"Hipparcos Number", "HIP 81031"},
        {"Smithsonian Astrophysical Observation", "SAO 253595"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.24759756),
        dec: Angle.Degrees(-61.85849250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38372"},
        {"Hipparcos Number", "HIP 26760"},
        {"Geneva Identification System", "GEN# +1.00038372"},
        {"Smithsonian Astrophysical Observation", "SAO 249332"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.27058958),
        dec: Angle.Degrees(-61.85783402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19781"},
        {"Hipparcos Number", "HIP 14549"},
        {"Geneva Identification System", "GEN# +1.00019781"},
        {"Smithsonian Astrophysical Observation", "SAO 248737"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.96064714),
        dec: Angle.Degrees(-61.85500194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104110"},
        {"Hipparcos Number", "HIP 58468"},
        {"Smithsonian Astrophysical Observation", "SAO 251669"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.85401842),
        dec: Angle.Degrees(-61.85054007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69262"},
        {"Hipparcos Number", "HIP 40203"},
        {"Smithsonian Astrophysical Observation", "SAO 250150"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.17231750),
        dec: Angle.Degrees(-61.84909347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206535"},
        {"Hipparcos Number", "HIP 107386"},
        {"Geneva Identification System", "GEN# +1.00206535"},
        {"Smithsonian Astrophysical Observation", "SAO 255062"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.25290112),
        dec: Angle.Degrees(-61.84866833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102997"},
        {"Hipparcos Number", "HIP 57808"},
        {"Celescope Catalog", "CEL 3994"},
        {"Geneva Identification System", "GEN# +1.00102997"},
        {"Smithsonian Astrophysical Observation", "SAO 251611"},
        {"Wilson Evans Batten Catalogue", "WEB 10373"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.80415702),
        dec: Angle.Degrees(-61.84615473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208217"},
        {"Hipparcos Number", "HIP 108340"},
        {"Geneva Identification System", "GEN# +1.00208217"},
        {"Renson", "Renson 57890"},
        {"Smithsonian Astrophysical Observation", "SAO 255107"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.23608423),
        dec: Angle.Degrees(-61.84610091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68766"},
        {"Hipparcos Number", "HIP 40014"},
        {"Smithsonian Astrophysical Observation", "SAO 250139"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.58267749),
        dec: Angle.Degrees(-61.84576157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109492"},
        {"Hipparcos Number", "HIP 61443"},
        {"Geneva Identification System", "GEN# +1.00109492"},
        {"Smithsonian Astrophysical Observation", "SAO 251962"},
        {"Wilson Evans Batten Catalogue", "WEB 10937"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.87410771),
        dec: Angle.Degrees(-61.84139792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -270.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42478"},
    },
    visualMagnitude: 12.08,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.90357964),
        dec: Angle.Degrees(-61.84121653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109517"},
        {"Hipparcos Number", "HIP 61479"},
        {"Celescope Catalog", "CEL 4126"},
        {"Geneva Identification System", "GEN# +1.00109517J"},
        {"Smithsonian Astrophysical Observation", "SAO 251967"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.95908938),
        dec: Angle.Degrees(-61.84090869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89921"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.23207386),
        dec: Angle.Degrees(-61.84082466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40201"},
        {"Hipparcos Number", "HIP 27822"},
        {"Smithsonian Astrophysical Observation", "SAO 249381"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.31134101),
        dec: Angle.Degrees(-61.83941700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8699"},
        {"Hipparcos Number", "HIP 6556"},
        {"Smithsonian Astrophysical Observation", "SAO 248377"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.06342421),
        dec: Angle.Degrees(-61.83728066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28132"},
        {"Hipparcos Number", "HIP 20420"},
        {"Smithsonian Astrophysical Observation", "SAO 249011"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.60690542),
        dec: Angle.Degrees(-61.83494848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114252"},
        {"Hipparcos Number", "HIP 64285"},
        {"Geneva Identification System", "GEN# +1.00114252"},
        {"Smithsonian Astrophysical Observation", "SAO 252176"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.62379977),
        dec: Angle.Degrees(-61.83289454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79188"},
        {"Hipparcos Number", "HIP 44971"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.41673677),
        dec: Angle.Degrees(-61.83265250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56025"},
        {"Hipparcos Number", "HIP 34717"},
        {"Geneva Identification System", "GEN# +1.00056025"},
        {"Smithsonian Astrophysical Observation", "SAO 249768"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.83512767),
        dec: Angle.Degrees(-61.82877806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47095"},
        {"Hipparcos Number", "HIP 31203"},
        {"Smithsonian Astrophysical Observation", "SAO 249583"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.19314473),
        dec: Angle.Degrees(-61.82794980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138979"},
        {"Hipparcos Number", "HIP 76613"},
        {"Smithsonian Astrophysical Observation", "SAO 253239"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.68434709),
        dec: Angle.Degrees(-61.82740376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80599"},
        {"Hipparcos Number", "HIP 45624"},
        {"Smithsonian Astrophysical Observation", "SAO 250527"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.49543897),
        dec: Angle.Degrees(-61.82703746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78445"},
        {"Hipparcos Number", "HIP 44608"},
        {"Smithsonian Astrophysical Observation", "SAO 250436"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.32918205),
        dec: Angle.Degrees(-61.82683679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94683"},
        {"Hipparcos Number", "HIP 53334"},
        {"Geneva Identification System", "GEN# +1.00094683J"},
        {"Smithsonian Astrophysical Observation", "SAO 251173"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.62332250),
        dec: Angle.Degrees(-61.82661289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101189"},
        {"Hipparcos Number", "HIP 56754"},
        {"Celescope Catalog", "CEL 3936"},
        {"Geneva Identification System", "GEN# +2.37660314"},
        {"Renson", "Renson 29150"},
        {"Smithsonian Astrophysical Observation", "SAO 251505"},
        {"Wilson Evans Batten Catalogue", "WEB 10209"},
        {"New General Catalogue", "NGC 3766 314"},
    },
    visualMagnitude: 5.15,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.53071631),
        dec: Angle.Degrees(-61.82655484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127632"},
        {"Hipparcos Number", "HIP 71307"},
        {"Smithsonian Astrophysical Observation", "SAO 252801"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.73253238),
        dec: Angle.Degrees(-61.82618382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21485"},
        {"Hipparcos Number", "HIP 15879"},
        {"Smithsonian Astrophysical Observation", "SAO 248796"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.13593584),
        dec: Angle.Degrees(-61.82543418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181091"},
        {"Hipparcos Number", "HIP 95265"},
        {"Smithsonian Astrophysical Observation", "SAO 254546"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.72867542),
        dec: Angle.Degrees(-61.82377662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36688"},
        {"Hipparcos Number", "HIP 25706"},
        {"Smithsonian Astrophysical Observation", "SAO 249290"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.34495580),
        dec: Angle.Degrees(-61.82345046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185142"},
        {"Hipparcos Number", "HIP 96870"},
        {"Geneva Identification System", "GEN# +1.00185142"},
        {"Smithsonian Astrophysical Observation", "SAO 254628"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.35393603),
        dec: Angle.Degrees(-61.82103586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174808"},
        {"Hipparcos Number", "HIP 92964"},
        {"Smithsonian Astrophysical Observation", "SAO 254412"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.09658934),
        dec: Angle.Degrees(-61.81922598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108804"},
        {"Hipparcos Number", "HIP 61033"},
        {"Geneva Identification System", "GEN# +1.00108804"},
        {"Smithsonian Astrophysical Observation", "SAO 251935"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.63074883),
        dec: Angle.Degrees(-61.81789827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186602"},
        {"Hipparcos Number", "HIP 97508"},
        {"Geneva Identification System", "GEN# +1.00186602J"},
        {"Smithsonian Astrophysical Observation", "SAO 254655"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.28019733),
        dec: Angle.Degrees(-61.81477592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179616"},
        {"Hipparcos Number", "HIP 94782"},
        {"Geneva Identification System", "GEN# +1.00179616"},
        {"Smithsonian Astrophysical Observation", "SAO 254517"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.28785321),
        dec: Angle.Degrees(-61.81416886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50035"},
        {"Hipparcos Number", "HIP 32521"},
        {"Geneva Identification System", "GEN# +1.00050035"},
        {"Smithsonian Astrophysical Observation", "SAO 249642"},
        {"Wilson Evans Batten Catalogue", "WEB 6560"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.79850227),
        dec: Angle.Degrees(-61.81304351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18638"},
        {"Hipparcos Number", "HIP 13745"},
        {"Smithsonian Astrophysical Observation", "SAO 248690"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.23894808),
        dec: Angle.Degrees(-61.81242808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132608"},
        {"Hipparcos Number", "HIP 73616"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.71591949),
        dec: Angle.Degrees(-61.81229068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199230"},
        {"Hipparcos Number", "HIP 103553"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.69787509),
        dec: Angle.Degrees(-61.81137500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220084"},
        {"Hipparcos Number", "HIP 115338"},
        {"Smithsonian Astrophysical Observation", "SAO 255466"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.42287588),
        dec: Angle.Degrees(-61.81081412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218924"},
        {"Hipparcos Number", "HIP 114582"},
        {"Smithsonian Astrophysical Observation", "SAO 255427"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.19132593),
        dec: Angle.Degrees(-61.80697621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167447"},
        {"Hipparcos Number", "HIP 89790"},
        {"Smithsonian Astrophysical Observation", "SAO 254207"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.86124557),
        dec: Angle.Degrees(-61.80531660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144323"},
        {"Hipparcos Number", "HIP 79112"},
        {"Smithsonian Astrophysical Observation", "SAO 253442"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.21241974),
        dec: Angle.Degrees(-61.80057149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69578"},
    },
    visualMagnitude: 12.10,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.62812474),
        dec: Angle.Degrees(-61.79940836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124237"},
        {"Hipparcos Number", "HIP 69582"},
        {"Geneva Identification System", "GEN# +1.00124237"},
        {"Smithsonian Astrophysical Observation", "SAO 252662"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.64037053),
        dec: Angle.Degrees(-61.79897380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82600"},
        {"Hipparcos Number", "HIP 46622"},
        {"Smithsonian Astrophysical Observation", "SAO 250602"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.59849896),
        dec: Angle.Degrees(-61.79485932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108530"},
        {"Hipparcos Number", "HIP 60861"},
        {"Geneva Identification System", "GEN# +1.00108530"},
        {"Smithsonian Astrophysical Observation", "SAO 251924"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.10712453),
        dec: Angle.Degrees(-61.79483117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92466"},
        {"Hipparcos Number", "HIP 52138"},
        {"Smithsonian Astrophysical Observation", "SAO 251045"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.77506257),
        dec: Angle.Degrees(-61.79270003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150085"},
        {"Hipparcos Number", "HIP 81814"},
        {"Geneva Identification System", "GEN# +1.00150085"},
        {"Smithsonian Astrophysical Observation", "SAO 253669"},
        {"Wilson Evans Batten Catalogue", "WEB 13822"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.66246583),
        dec: Angle.Degrees(-61.78500959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140450"},
        {"Hipparcos Number", "HIP 77305"},
        {"Smithsonian Astrophysical Observation", "SAO 253292"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.74298955),
        dec: Angle.Degrees(-61.78326925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -215.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159264"},
        {"Hipparcos Number", "HIP 86288"},
        {"Geneva Identification System", "GEN# +1.00159264"},
        {"Smithsonian Astrophysical Observation", "SAO 253985"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.47350925),
        dec: Angle.Degrees(-61.78073205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157064"},
        {"Hipparcos Number", "HIP 85243"},
        {"Geneva Identification System", "GEN# +1.00157064"},
        {"Smithsonian Astrophysical Observation", "SAO 253914"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.28244863),
        dec: Angle.Degrees(-61.78069798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139686"},
        {"Hipparcos Number", "HIP 76958"},
        {"Geneva Identification System", "GEN# +1.00139686"},
        {"Smithsonian Astrophysical Observation", "SAO 253261"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.71184191),
        dec: Angle.Degrees(-61.77716478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6793"},
        {"Hipparcos Number", "HIP 5268"},
        {"Fundamental Katalog 5th Edition", "FK5 39"},
        {"Geneva Identification System", "GEN# +1.00006793"},
        {"Smithsonian Astrophysical Observation", "SAO 248324"},
        {"Wilson Evans Batten Catalogue", "WEB 1114"},
    },
    visualMagnitude: 5.36,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.82738598),
        dec: Angle.Degrees(-61.77526197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90677"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.52260741),
        dec: Angle.Degrees(-61.77190662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41135"},
        {"Hipparcos Number", "HIP 28313"},
        {"Renson", "Renson 11000"},
        {"Smithsonian Astrophysical Observation", "SAO 249406"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.73852723),
        dec: Angle.Degrees(-61.77088461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15160"},
        {"Hipparcos Number", "HIP 11180"},
        {"Smithsonian Astrophysical Observation", "SAO 248550"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.98804729),
        dec: Angle.Degrees(-61.76854279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88624"},
        {"Hipparcos Number", "HIP 49894"},
        {"Geneva Identification System", "GEN# +1.00088624"},
        {"Smithsonian Astrophysical Observation", "SAO 250857"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.81113901),
        dec: Angle.Degrees(-61.76836754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108500"},
        {"Hipparcos Number", "HIP 60845"},
        {"Geneva Identification System", "GEN# +1.00108500J"},
        {"Smithsonian Astrophysical Observation", "SAO 251919"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.06995967),
        dec: Angle.Degrees(-61.76532283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78762"},
        {"Hipparcos Number", "HIP 44745"},
        {"Geneva Identification System", "GEN# +1.00078762"},
        {"Smithsonian Astrophysical Observation", "SAO 250445"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.77632153),
        dec: Angle.Degrees(-61.76430496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128861"},
        {"Hipparcos Number", "HIP 71858"},
        {"Smithsonian Astrophysical Observation", "SAO 252850"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.48001156),
        dec: Angle.Degrees(-61.76395715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157802"},
        {"Hipparcos Number", "HIP 85598"},
        {"Renson", "Renson 44370"},
        {"Smithsonian Astrophysical Observation", "SAO 253938"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.37074965),
        dec: Angle.Degrees(-61.76382806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158912"},
        {"Hipparcos Number", "HIP 86113"},
        {"Smithsonian Astrophysical Observation", "SAO 253971"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.97433862),
        dec: Angle.Degrees(-61.76216202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 134.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224377"},
        {"Hipparcos Number", "HIP 118105"},
        {"Geneva Identification System", "GEN# +1.00224377"},
        {"Smithsonian Astrophysical Observation", "SAO 255607"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.36430516),
        dec: Angle.Degrees(-61.76190411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87089"},
        {"Hipparcos Number", "HIP 49051"},
        {"Smithsonian Astrophysical Observation", "SAO 250776"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.14165597),
        dec: Angle.Degrees(-61.75870206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 308321"},
        {"Hipparcos Number", "HIP 54780"},
    },
    visualMagnitude: 11.45,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.22935346),
        dec: Angle.Degrees(-61.75716503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112252"},
        {"Hipparcos Number", "HIP 63140"},
        {"Geneva Identification System", "GEN# +1.00112252"},
        {"Renson", "Renson 32600"},
        {"Smithsonian Astrophysical Observation", "SAO 252096"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.06404668),
        dec: Angle.Degrees(-61.75497321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97485"},
        {"Hipparcos Number", "HIP 54715"},
        {"Geneva Identification System", "GEN# +1.00097485"},
        {"Smithsonian Astrophysical Observation", "SAO 251314"},
        {"Wilson Evans Batten Catalogue", "WEB 9879"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.04222668),
        dec: Angle.Degrees(-61.75487784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83390"},
        {"Hipparcos Number", "HIP 47068"},
        {"Smithsonian Astrophysical Observation", "SAO 250632"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.88313562),
        dec: Angle.Degrees(-61.75105875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42287"},
        {"Hipparcos Number", "HIP 28869"},
        {"Geneva Identification System", "GEN# +1.00042287"},
        {"Smithsonian Astrophysical Observation", "SAO 249444"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.42533520),
        dec: Angle.Degrees(-61.74860707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127596"},
        {"Hipparcos Number", "HIP 71281"},
        {"Smithsonian Astrophysical Observation", "SAO 252799"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.66600182),
        dec: Angle.Degrees(-61.74838280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132626"},
        {"Hipparcos Number", "HIP 73625"},
        {"Smithsonian Astrophysical Observation", "SAO 252998"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.75218516),
        dec: Angle.Degrees(-61.74533453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134468"},
        {"Hipparcos Number", "HIP 74470"},
        {"Geneva Identification System", "GEN# +1.00134468"},
        {"Smithsonian Astrophysical Observation", "SAO 253059"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.25428258),
        dec: Angle.Degrees(-61.74376411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152671"},
        {"Hipparcos Number", "HIP 83089"},
        {"Geneva Identification System", "GEN# +1.00152671"},
        {"Smithsonian Astrophysical Observation", "SAO 253755"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.67281524),
        dec: Angle.Degrees(-61.74145830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109475"},
        {"Hipparcos Number", "HIP 61444"},
        {"Geneva Identification System", "GEN# +1.00109475"},
        {"Smithsonian Astrophysical Observation", "SAO 251961"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.87443892),
        dec: Angle.Degrees(-61.74075882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127571"},
        {"Hipparcos Number", "HIP 71278"},
        {"Smithsonian Astrophysical Observation", "SAO 252798"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.66134372),
        dec: Angle.Degrees(-61.74072059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118453"},
        {"Hipparcos Number", "HIP 66559"},
        {"Smithsonian Astrophysical Observation", "SAO 252394"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.66796765),
        dec: Angle.Degrees(-61.73984216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66904"},
        {"Geneva Identification System", "GEN# -0.06103926"},
        {"Smithsonian Astrophysical Observation", "SAO 252421"},
        {"Wilson Evans Batten Catalogue", "WEB 11796"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.66906181),
        dec: Angle.Degrees(-61.73783096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80863"},
        {"Hipparcos Number", "HIP 45733"},
        {"Geneva Identification System", "GEN# +1.00080863"},
        {"Smithsonian Astrophysical Observation", "SAO 250536"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.84950666),
        dec: Angle.Degrees(-61.73730696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113844"},
        {"Hipparcos Number", "HIP 64049"},
        {"Geneva Identification System", "GEN# +1.00113844"},
        {"Smithsonian Astrophysical Observation", "SAO 252160"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.89949875),
        dec: Angle.Degrees(-61.73660474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204788"},
        {"Hipparcos Number", "HIP 106434"},
        {"Smithsonian Astrophysical Observation", "SAO 255023"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.36740113),
        dec: Angle.Degrees(-61.73235522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52176"},
        {"Hipparcos Number", "HIP 33346"},
        {"Smithsonian Astrophysical Observation", "SAO 249681"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.03230161),
        dec: Angle.Degrees(-61.73035966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222045"},
        {"Hipparcos Number", "HIP 116595"},
        {"Smithsonian Astrophysical Observation", "SAO 255527"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.42551398),
        dec: Angle.Degrees(-61.73027690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222780"},
        {"Hipparcos Number", "HIP 117055"},
        {"Smithsonian Astrophysical Observation", "SAO 255554"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.95678798),
        dec: Angle.Degrees(-61.72976940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156693"},
        {"Hipparcos Number", "HIP 85069"},
        {"Smithsonian Astrophysical Observation", "SAO 253894"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.77982578),
        dec: Angle.Degrees(-61.72919394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4764"},
        {"Hipparcos Number", "HIP 3791"},
        {"Smithsonian Astrophysical Observation", "SAO 248255"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.17991589),
        dec: Angle.Degrees(-61.72851830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136670"},
        {"Hipparcos Number", "HIP 75477"},
        {"Smithsonian Astrophysical Observation", "SAO 253151"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.28189652),
        dec: Angle.Degrees(-61.72567362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121809"},
        {"Hipparcos Number", "HIP 68365"},
        {"Smithsonian Astrophysical Observation", "SAO 252544"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.90918064),
        dec: Angle.Degrees(-61.72332810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144631"},
        {"Hipparcos Number", "HIP 79245"},
        {"Smithsonian Astrophysical Observation", "SAO 253447"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.59226556),
        dec: Angle.Degrees(-61.72084590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31703"},
        {"Hipparcos Number", "HIP 22780"},
        {"Smithsonian Astrophysical Observation", "SAO 249139"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.50341848),
        dec: Angle.Degrees(-61.71736600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90246"},
        {"Hipparcos Number", "HIP 50881"},
        {"Smithsonian Astrophysical Observation", "SAO 250941"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.84624560),
        dec: Angle.Degrees(-61.71706269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19743"},
        {"Hipparcos Number", "HIP 14533"},
        {"Geneva Identification System", "GEN# +1.00019743"},
        {"Smithsonian Astrophysical Observation", "SAO 248736"},
        {"Wilson Evans Batten Catalogue", "WEB 2824"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.91561745),
        dec: Angle.Degrees(-61.71606413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161475"},
        {"Hipparcos Number", "HIP 87264"},
        {"Smithsonian Astrophysical Observation", "SAO 254048"},
    },
    visualMagnitude: 6.41,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.47086372),
        dec: Angle.Degrees(-61.71465892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113422"},
        {"Hipparcos Number", "HIP 63802"},
        {"Geneva Identification System", "GEN# +1.00113422"},
        {"Smithsonian Astrophysical Observation", "SAO 252141"},
        {"Wilson Evans Batten Catalogue", "WEB 11285"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.15357581),
        dec: Angle.Degrees(-61.71027783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167060"},
        {"Hipparcos Number", "HIP 89650"},
        {"Smithsonian Astrophysical Observation", "SAO 254197"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.43347516),
        dec: Angle.Degrees(-61.70843004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25211"},
        {"Hipparcos Number", "HIP 18446"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.14724426),
        dec: Angle.Degrees(-61.70816148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91465"},
        {"Hipparcos Number", "HIP 51576"},
        {"Celescope Catalog", "CEL 3564"},
        {"Fundamental Katalog 5th Edition", "FK5 397"},
        {"Geneva Identification System", "GEN# +1.00091465"},
        {"Smithsonian Astrophysical Observation", "SAO 251006"},
        {"Wilson Evans Batten Catalogue", "WEB 9411"},
    },
    visualMagnitude: 3.30,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.00618250),
        dec: Angle.Degrees(-61.68536031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124314"},
        {"Hipparcos Number", "HIP 69628"},
        {"Geneva Identification System", "GEN# +1.00124314J"},
        {"Smithsonian Astrophysical Observation", "SAO 252665"},
        {"Wilson Evans Batten Catalogue", "WEB 12123"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.75671207),
        dec: Angle.Degrees(-61.70676822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21310",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21310"},
        {"Smithsonian Astrophysical Observation", "SAO 249058"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.63274995),
        dec: Angle.Degrees(-61.70301035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70544"},
        {"Hipparcos Number", "HIP 40758"},
        {"Smithsonian Astrophysical Observation", "SAO 250189"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.79676415),
        dec: Angle.Degrees(-61.70241226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177510"},
        {"Hipparcos Number", "HIP 94060"},
        {"Smithsonian Astrophysical Observation", "SAO 254474"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.23522233),
        dec: Angle.Degrees(-61.70221655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 306797"},
        {"Hipparcos Number", "HIP 56586"},
        {"Geneva Identification System", "GEN# +2.37660240"},
        {"New General Catalogue", "NGC 3766 240"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.02288547),
        dec: Angle.Degrees(-61.70168553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1657"},
        {"Hipparcos Number", "HIP 1633"},
        {"Smithsonian Astrophysical Observation", "SAO 248165"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.11822787),
        dec: Angle.Degrees(-61.70114427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88169"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.10897850),
        dec: Angle.Degrees(-61.70034403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -326.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74421"},
        {"Hipparcos Number", "HIP 42584"},
        {"Smithsonian Astrophysical Observation", "SAO 250301"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.18727742),
        dec: Angle.Degrees(-61.69938693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102416"},
        {"Hipparcos Number", "HIP 57476"},
        {"Smithsonian Astrophysical Observation", "SAO 251586"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.72854904),
        dec: Angle.Degrees(-61.69644429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 306798"},
        {"Hipparcos Number", "HIP 56592"},
        {"Geneva Identification System", "GEN# +2.37660239"},
        {"New General Catalogue", "NGC 3766 239"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.03907422),
        dec: Angle.Degrees(-61.69488380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60673"},
        {"Hipparcos Number", "HIP 36622"},
        {"Geneva Identification System", "GEN# +1.00060673"},
        {"Smithsonian Astrophysical Observation", "SAO 249875"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.96680665),
        dec: Angle.Degrees(-61.69222864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118261"},
        {"Hipparcos Number", "HIP 66438"},
        {"Geneva Identification System", "GEN# +1.00118261J"},
        {"Smithsonian Astrophysical Observation", "SAO 252387"},
        {"Wilson Evans Batten Catalogue", "WEB 11728"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.30083723),
        dec: Angle.Degrees(-61.69157197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62401"},
        {"Hipparcos Number", "HIP 37340"},
        {"Smithsonian Astrophysical Observation", "SAO 249915"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.97580436),
        dec: Angle.Degrees(-61.69043318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176666"},
        {"Hipparcos Number", "HIP 93745"},
        {"Geneva Identification System", "GEN# +1.00176666"},
        {"Smithsonian Astrophysical Observation", "SAO 254457"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.33654140),
        dec: Angle.Degrees(-61.69032811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74888"},
        {"Hipparcos Number", "HIP 42819"},
        {"Geneva Identification System", "GEN# +1.00074888"},
        {"Renson", "Renson 20950"},
        {"Smithsonian Astrophysical Observation", "SAO 250308"},
    },
    visualMagnitude: 6.85,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.87505420),
        dec: Angle.Degrees(-61.68864386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147018"},
        {"Hipparcos Number", "HIP 80250"},
        {"Geneva Identification System", "GEN# +1.00147018"},
        {"Smithsonian Astrophysical Observation", "SAO 253526"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.75152462),
        dec: Angle.Degrees(-61.68799543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -315.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215682"},
        {"Hipparcos Number", "HIP 112603"},
        {"Geneva Identification System", "GEN# +1.00215682"},
        {"Smithsonian Astrophysical Observation", "SAO 255321"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.08872969),
        dec: Angle.Degrees(-61.68435601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11732"},
        {"Hipparcos Number", "HIP 8800"},
        {"Smithsonian Astrophysical Observation", "SAO 248456"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.28296648),
        dec: Angle.Degrees(-61.68312231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137757"},
        {"Hipparcos Number", "HIP 75970"},
        {"Geneva Identification System", "GEN# +1.00137757"},
        {"Smithsonian Astrophysical Observation", "SAO 253191"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.72828848),
        dec: Angle.Degrees(-61.68247655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87761"},
        {"Hipparcos Number", "HIP 49405"},
        {"Smithsonian Astrophysical Observation", "SAO 250805"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.28426353),
        dec: Angle.Degrees(-61.68176458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80629"},
        {"Hipparcos Number", "HIP 45639"},
        {"Smithsonian Astrophysical Observation", "SAO 250528"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.54016894),
        dec: Angle.Degrees(-61.67888245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154555"},
        {"Hipparcos Number", "HIP 83984"},
        {"Fundamental Katalog 5th Edition", "FK5 3362"},
        {"Geneva Identification System", "GEN# +1.00154555"},
        {"Smithsonian Astrophysical Observation", "SAO 253818"},
        {"Wilson Evans Batten Catalogue", "WEB 14188"},
    },
    visualMagnitude: 6.37,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.52616256),
        dec: Angle.Degrees(-61.67544103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211728"},
        {"Hipparcos Number", "HIP 110334"},
        {"Smithsonian Astrophysical Observation", "SAO 255203"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.20784624),
        dec: Angle.Degrees(-61.67072313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32628"},
        {"Hipparcos Number", "HIP 23278"},
        {"Smithsonian Astrophysical Observation", "SAO 249162"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.13149352),
        dec: Angle.Degrees(-61.66561137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94559"},
        {"Hipparcos Number", "HIP 53270"},
        {"Celescope Catalog", "CEL 3758"},
        {"Geneva Identification System", "GEN# +1.00094559"},
        {"Smithsonian Astrophysical Observation", "SAO 251167"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.42314536),
        dec: Angle.Degrees(-61.66550822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100943"},
        {"Hipparcos Number", "HIP 56612"},
        {"Celescope Catalog", "CEL 3925"},
        {"Geneva Identification System", "GEN# +2.37660232"},
        {"Smithsonian Astrophysical Observation", "SAO 251480"},
        {"Wilson Evans Batten Catalogue", "WEB 10177"},
        {"New General Catalogue", "NGC 3766 232"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.11825115),
        dec: Angle.Degrees(-61.66514520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150596"},
        {"Hipparcos Number", "HIP 82079"},
        {"Smithsonian Astrophysical Observation", "SAO 253687"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.48738029),
        dec: Angle.Degrees(-61.66341362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206325"},
        {"Hipparcos Number", "HIP 107278"},
        {"Smithsonian Astrophysical Observation", "SAO 255058"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.94159216),
        dec: Angle.Degrees(-61.66276782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168983"},
        {"Hipparcos Number", "HIP 90387"},
        {"Geneva Identification System", "GEN# +1.00168983"},
        {"Renson", "Renson 47390"},
        {"Smithsonian Astrophysical Observation", "SAO 254245"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.64739790),
        dec: Angle.Degrees(-61.66038022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69658"},
        {"Hipparcos Number", "HIP 40360"},
        {"Smithsonian Astrophysical Observation", "SAO 250160"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.60569287),
        dec: Angle.Degrees(-61.65960754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88907"},
        {"Hipparcos Number", "HIP 50067"},
        {"Celescope Catalog", "CEL 3472"},
        {"Fundamental Katalog 5th Edition", "FK5 2822"},
        {"Geneva Identification System", "GEN# +1.00088907"},
        {"Smithsonian Astrophysical Observation", "SAO 250875"},
        {"Wilson Evans Batten Catalogue", "WEB 9205"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.33833120),
        dec: Angle.Degrees(-61.65883585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71228"},
    },
    visualMagnitude: 11.37,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)33, 47.4700),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)24, 28.100)
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
    primaryId: "HIP 116305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221594"},
        {"Hipparcos Number", "HIP 116305"},
        {"Smithsonian Astrophysical Observation", "SAO 255516"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.47562527),
        dec: Angle.Degrees(-61.65384148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120798"},
        {"Hipparcos Number", "HIP 67820"},
        {"Geneva Identification System", "GEN# +2.53160002"},
        {"Smithsonian Astrophysical Observation", "SAO 252503"},
        {"New General Catalogue", "NGC 5316 2"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.38798340),
        dec: Angle.Degrees(-61.65318240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124327"},
        {"Hipparcos Number", "HIP 69633"},
        {"Geneva Identification System", "GEN# +1.00124327"},
        {"Smithsonian Astrophysical Observation", "SAO 252667"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.77197394),
        dec: Angle.Degrees(-61.65311764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13823"},
        {"Hipparcos Number", "HIP 10284"},
        {"Smithsonian Astrophysical Observation", "SAO 248511"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.10934843),
        dec: Angle.Degrees(-61.65155351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99718"},
        {"Hipparcos Number", "HIP 55911"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.90448418),
        dec: Angle.Degrees(-61.65133718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81613"},
        {"Hipparcos Number", "HIP 46101"},
        {"Geneva Identification System", "GEN# +1.00081613"},
        {"Smithsonian Astrophysical Observation", "SAO 250563"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.02289906),
        dec: Angle.Degrees(-61.64878694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99279"},
        {"Hipparcos Number", "HIP 55691"},
        {"Cincinnati Publication", "Ci 20 634"},
        {"Geneva Identification System", "GEN# +1.00099279"},
        {"Smithsonian Astrophysical Observation", "SAO 251393"},
        {"Wilson Evans Batten Catalogue", "WEB 10010"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.17060162),
        dec: Angle.Degrees(-61.64775569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -510.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27980"},
        {"Hipparcos Number", "HIP 20317"},
        {"Smithsonian Astrophysical Observation", "SAO 249001"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.28488523),
        dec: Angle.Degrees(-61.64750752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92465"},
        {"Hipparcos Number", "HIP 52135"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.77379853),
        dec: Angle.Degrees(-61.64655364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76972"},
        {"Hipparcos Number", "HIP 43893"},
        {"Smithsonian Astrophysical Observation", "SAO 250387"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.12227950),
        dec: Angle.Degrees(-61.64631122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213775"},
        {"Hipparcos Number", "HIP 111498"},
        {"Geneva Identification System", "GEN# +1.00213775"},
        {"Smithsonian Astrophysical Observation", "SAO 255258"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.85653524),
        dec: Angle.Degrees(-61.64181140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152273"},
        {"Hipparcos Number", "HIP 82879"},
        {"Renson", "Renson 43100"},
        {"Smithsonian Astrophysical Observation", "SAO 253740"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.06965504),
        dec: Angle.Degrees(-61.64058358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209828"},
        {"Hipparcos Number", "HIP 109266"},
        {"Geneva Identification System", "GEN# +1.00209828"},
        {"Smithsonian Astrophysical Observation", "SAO 255152"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.05511183),
        dec: Angle.Degrees(-61.64000731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154374"},
        {"Hipparcos Number", "HIP 83910"},
        {"Smithsonian Astrophysical Observation", "SAO 253812"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.23618231),
        dec: Angle.Degrees(-61.63865193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98312"},
        {"Hipparcos Number", "HIP 55163"},
        {"Smithsonian Astrophysical Observation", "SAO 251345"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.40324601),
        dec: Angle.Degrees(-61.63538813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133699"},
        {"Hipparcos Number", "HIP 74110"},
        {"Geneva Identification System", "GEN# +1.00133699"},
        {"Smithsonian Astrophysical Observation", "SAO 253028"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.18847777),
        dec: Angle.Degrees(-61.63375393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156943"},
        {"Hipparcos Number", "HIP 85173"},
        {"Smithsonian Astrophysical Observation", "SAO 253907"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.09139672),
        dec: Angle.Degrees(-61.63364964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148291"},
        {"Hipparcos Number", "HIP 80874"},
        {"Fundamental Katalog 5th Edition", "FK5 3302"},
        {"Smithsonian Astrophysical Observation", "SAO 253582"},
        {"Wilson Evans Batten Catalogue", "WEB 13676"},
    },
    visualMagnitude: 5.19,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.70572277),
        dec: Angle.Degrees(-61.63348127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106707"},
        {"Hipparcos Number", "HIP 59853"},
        {"Smithsonian Astrophysical Observation", "SAO 251822"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.11427063),
        dec: Angle.Degrees(-61.63310221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183951"},
        {"Hipparcos Number", "HIP 96381"},
        {"Geneva Identification System", "GEN# +1.00183951"},
        {"Smithsonian Astrophysical Observation", "SAO 254602"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.94217746),
        dec: Angle.Degrees(-61.63086530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160920"},
        {"Hipparcos Number", "HIP 86989"},
        {"Smithsonian Astrophysical Observation", "SAO 254026"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.64708524),
        dec: Angle.Degrees(-61.62937099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120783"},
        {"Hipparcos Number", "HIP 67806"},
        {"Geneva Identification System", "GEN# +2.53160001"},
        {"Smithsonian Astrophysical Observation", "SAO 252500"},
        {"New General Catalogue", "NGC 5316 1"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.35977210),
        dec: Angle.Degrees(-61.62929849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107805"},
        {"Hipparcos Number", "HIP 60455"},
        {"Geneva Identification System", "GEN# +1.00107805"},
        {"Smithsonian Astrophysical Observation", "SAO 251878"},
        {"Wilson Evans Batten Catalogue", "WEB 10749"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.90709250),
        dec: Angle.Degrees(-61.62912370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132538"},
        {"Hipparcos Number", "HIP 73584"},
        {"Smithsonian Astrophysical Observation", "SAO 252996"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.62037099),
        dec: Angle.Degrees(-61.62748955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23672"},
        {"Hipparcos Number", "HIP 17394"},
        {"Geneva Identification System", "GEN# +1.00023672"},
        {"Smithsonian Astrophysical Observation", "SAO 248875"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.87738981),
        dec: Angle.Degrees(-61.62615177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147848"},
        {"Hipparcos Number", "HIP 80642"},
        {"Smithsonian Astrophysical Observation", "SAO 253557"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.98298654),
        dec: Angle.Degrees(-61.62589438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188096"},
        {"Hipparcos Number", "HIP 98173"},
        {"Geneva Identification System", "GEN# +1.00188096"},
        {"Smithsonian Astrophysical Observation", "SAO 254691"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.27288316),
        dec: Angle.Degrees(-61.62469142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117741"},
        {"Hipparcos Number", "HIP 66172"},
        {"Smithsonian Astrophysical Observation", "SAO 252369"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.45488497),
        dec: Angle.Degrees(-61.62419890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28421"},
        {"Hipparcos Number", "HIP 20627"},
        {"Smithsonian Astrophysical Observation", "SAO 249017"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.30273188),
        dec: Angle.Degrees(-61.62233505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138081"},
        {"Hipparcos Number", "HIP 76132"},
        {"Smithsonian Astrophysical Observation", "SAO 253204"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.23872055),
        dec: Angle.Degrees(-61.62183437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30295"},
        {"Hipparcos Number", "HIP 21889"},
        {"Geneva Identification System", "GEN# +1.00030295"},
        {"Smithsonian Astrophysical Observation", "SAO 249085"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.58316489),
        dec: Angle.Degrees(-61.62128500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 243.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119860"},
        {"Hipparcos Number", "HIP 67297"},
        {"Smithsonian Astrophysical Observation", "SAO 252451"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.87166821),
        dec: Angle.Degrees(-61.61855046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18134"},
        {"Hipparcos Number", "HIP 13359"},
        {"Geneva Identification System", "GEN# +1.00018134"},
        {"Smithsonian Astrophysical Observation", "SAO 248669"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.96997744),
        dec: Angle.Degrees(-61.61826140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185579"},
        {"Hipparcos Number", "HIP 97053"},
        {"Geneva Identification System", "GEN# +1.00185579"},
        {"Smithsonian Astrophysical Observation", "SAO 254635"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.86515447),
        dec: Angle.Degrees(-61.61820336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91307"},
        {"Hipparcos Number", "HIP 51488"},
        {"Smithsonian Astrophysical Observation", "SAO 250994"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.74265710),
        dec: Angle.Degrees(-61.61346648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56413"},
        {"Hipparcos Number", "HIP 34877"},
        {"Geneva Identification System", "GEN# +1.00056413"},
        {"Smithsonian Astrophysical Observation", "SAO 249783"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.24115710),
        dec: Angle.Degrees(-61.61307344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 306799"},
        {"Hipparcos Number", "HIP 56619"},
        {"Geneva Identification System", "GEN# +2.37660048"},
        {"Smithsonian Astrophysical Observation", "SAO 251483"},
        {"New General Catalogue", "NGC 3766 48"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.14520165),
        dec: Angle.Degrees(-61.60977639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46699"},
        {"Hipparcos Number", "HIP 31034"},
        {"Smithsonian Astrophysical Observation", "SAO 249570"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.68673300),
        dec: Angle.Degrees(-61.60839360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199152"},
        {"Hipparcos Number", "HIP 103499"},
        {"Smithsonian Astrophysical Observation", "SAO 254909"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.53669759),
        dec: Angle.Degrees(-61.60810095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 825"},
        {"Hipparcos Number", "HIP 994"},
        {"Geneva Identification System", "GEN# +1.00000825"},
        {"Smithsonian Astrophysical Observation", "SAO 248135"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.10531311),
        dec: Angle.Degrees(-61.60576322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60037"},
        {"Hipparcos Number", "HIP 36341"},
        {"Smithsonian Astrophysical Observation", "SAO 249862"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.19802220),
        dec: Angle.Degrees(-61.60521226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26754"},
        {"Hipparcos Number", "HIP 19467"},
        {"Geneva Identification System", "GEN# +1.00026754"},
        {"Smithsonian Astrophysical Observation", "SAO 248957"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.53078866),
        dec: Angle.Degrees(-61.59875505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99962"},
        {"Hipparcos Number", "HIP 56069"},
        {"Smithsonian Astrophysical Observation", "SAO 251424"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.36390047),
        dec: Angle.Degrees(-61.59618368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96673"},
        {"Hipparcos Number", "HIP 54348"},
        {"Geneva Identification System", "GEN# +1.00096673"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.78029349),
        dec: Angle.Degrees(-61.59492337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196517"},
        {"Hipparcos Number", "HIP 102070"},
        {"Smithsonian Astrophysical Observation", "SAO 254850"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.27815532),
        dec: Angle.Degrees(-61.59229206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129897"},
        {"Hipparcos Number", "HIP 72366"},
        {"Geneva Identification System", "GEN# +1.00129897"},
        {"Smithsonian Astrophysical Observation", "SAO 252888"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.95330898),
        dec: Angle.Degrees(-61.58853531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33456"},
        {"Hipparcos Number", "HIP 23749"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.56945703),
        dec: Angle.Degrees(-61.58687674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224538"},
        {"Hipparcos Number", "HIP 118228"},
        {"Geneva Identification System", "GEN# +1.00224538"},
        {"Smithsonian Astrophysical Observation", "SAO 255614"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.71525864),
        dec: Angle.Degrees(-61.58672023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117399"},
        {"Hipparcos Number", "HIP 65970"},
        {"Celescope Catalog", "CEL 4266"},
        {"Geneva Identification System", "GEN# +1.00117399"},
        {"Smithsonian Astrophysical Observation", "SAO 252342"},
        {"Wilson Evans Batten Catalogue", "WEB 11666"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.88923805),
        dec: Angle.Degrees(-61.58236000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7914"},
        {"Hipparcos Number", "HIP 6024"},
        {"Smithsonian Astrophysical Observation", "SAO 248351"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.34840550),
        dec: Angle.Degrees(-61.57902084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56556"},
        {"Geneva Identification System", "GEN# +2.37660327"},
        {"Smithsonian Astrophysical Observation", "SAO 251470"},
        {"New General Catalogue", "NGC 3766 327"},
    },
    visualMagnitude: 7.34,
    bvColour: 2.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.93734196),
        dec: Angle.Degrees(-61.57806355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91342"},
        {"Hipparcos Number", "HIP 51506"},
        {"Celescope Catalog", "CEL 3562"},
        {"Geneva Identification System", "GEN# +1.00091342"},
        {"Smithsonian Astrophysical Observation", "SAO 250995"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.77990901),
        dec: Angle.Degrees(-61.57634174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82500"},
        {"Hipparcos Number", "HIP 46579"},
        {"Geneva Identification System", "GEN# +1.00082500"},
        {"Smithsonian Astrophysical Observation", "SAO 250598"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.47923263),
        dec: Angle.Degrees(-61.57389270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182670"},
        {"Hipparcos Number", "HIP 95841"},
        {"Smithsonian Astrophysical Observation", "SAO 254588"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.38637213),
        dec: Angle.Degrees(-61.57328289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4877"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.67464489),
        dec: Angle.Degrees(-61.57150856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -181.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12311"},
        {"Hipparcos Number", "HIP 9236"},
        {"Fundamental Katalog 5th Edition", "FK5 72"},
        {"Geneva Identification System", "GEN# +1.00012311"},
        {"Smithsonian Astrophysical Observation", "SAO 248474"},
        {"Wilson Evans Batten Catalogue", "WEB 1941"},
    },
    visualMagnitude: 2.86,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.69113269),
        dec: Angle.Degrees(-61.56992444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 262.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90301"},
        {"Hipparcos Number", "HIP 50905"},
        {"Geneva Identification System", "GEN# +1.00090301"},
        {"Smithsonian Astrophysical Observation", "SAO 250943"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.92387839),
        dec: Angle.Degrees(-61.56942649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70444"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.15888875),
        dec: Angle.Degrees(-61.56901711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68422"},
        {"Hipparcos Number", "HIP 39885"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.20379698),
        dec: Angle.Degrees(-61.56880821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130737"},
        {"Hipparcos Number", "HIP 72777"},
        {"Smithsonian Astrophysical Observation", "SAO 252929"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.15204159),
        dec: Angle.Degrees(-61.56862420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130522"},
        {"Hipparcos Number", "HIP 72657"},
        {"Geneva Identification System", "GEN# +1.00130522"},
        {"Smithsonian Astrophysical Observation", "SAO 252917"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.84291505),
        dec: Angle.Degrees(-61.56829218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153284"},
        {"Hipparcos Number", "HIP 83363"},
        {"Geneva Identification System", "GEN# +1.00153284"},
        {"Smithsonian Astrophysical Observation", "SAO 253775"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.56822858),
        dec: Angle.Degrees(-61.56811462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125901"},
        {"Hipparcos Number", "HIP 70448"},
        {"Geneva Identification System", "GEN# +1.00125901"},
        {"Smithsonian Astrophysical Observation", "SAO 252734"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.16397704),
        dec: Angle.Degrees(-61.56690590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102632"},
        {"Hipparcos Number", "HIP 57610"},
        {"Geneva Identification System", "GEN# +1.00102632"},
        {"Smithsonian Astrophysical Observation", "SAO 251599"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.17288558),
        dec: Angle.Degrees(-61.56415624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144199"},
        {"Hipparcos Number", "HIP 79052"},
        {"Smithsonian Astrophysical Observation", "SAO 253436"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.03689737),
        dec: Angle.Degrees(-61.56386977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5160"},
        {"Hipparcos Number", "HIP 4092"},
        {"Smithsonian Astrophysical Observation", "SAO 248268"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.13272865),
        dec: Angle.Degrees(-61.56314406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77076"},
        {"Hipparcos Number", "HIP 43964"},
        {"Smithsonian Astrophysical Observation", "SAO 250392"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.30135605),
        dec: Angle.Degrees(-61.56310804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123058"},
        {"Hipparcos Number", "HIP 68994"},
        {"Geneva Identification System", "GEN# +1.00123058"},
        {"Smithsonian Astrophysical Observation", "SAO 252606"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.87240054),
        dec: Angle.Degrees(-61.56220436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104151",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104151"},
        {"Geneva Identification System", "GEN# -0.06206195"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.51225309),
        dec: Angle.Degrees(-61.56215086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100840"},
        {"Hipparcos Number", "HIP 56563"},
        {"Celescope Catalog", "CEL 3920"},
        {"Geneva Identification System", "GEN# +2.37660326"},
        {"Smithsonian Astrophysical Observation", "SAO 251471"},
        {"New General Catalogue", "NGC 3766 326"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.94633124),
        dec: Angle.Degrees(-61.56052782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149262"},
        {"Hipparcos Number", "HIP 81395"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.35044171),
        dec: Angle.Degrees(-61.55462806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214575"},
        {"Hipparcos Number", "HIP 111946"},
        {"Smithsonian Astrophysical Observation", "SAO 255280"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.13953154),
        dec: Angle.Degrees(-61.55375541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68250"},
        {"Hipparcos Number", "HIP 39803"},
        {"Geneva Identification System", "GEN# +1.00068250"},
        {"Renson", "Renson 18847"},
        {"Smithsonian Astrophysical Observation", "SAO 250118"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.00840115),
        dec: Angle.Degrees(-61.55328701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 306129"},
        {"Hipparcos Number", "HIP 54431"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.06889697),
        dec: Angle.Degrees(-61.55273850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90398"},
        {"Hipparcos Number", "HIP 50953"},
        {"Celescope Catalog", "CEL 3530"},
        {"Geneva Identification System", "GEN# +1.00090398"},
        {"Smithsonian Astrophysical Observation", "SAO 250945"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.09506880),
        dec: Angle.Degrees(-61.55188612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149261"},
        {"Hipparcos Number", "HIP 81394"},
        {"Smithsonian Astrophysical Observation", "SAO 253628"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.35021735),
        dec: Angle.Degrees(-61.55160508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53379"},
        {"Hipparcos Number", "HIP 33772"},
        {"Smithsonian Astrophysical Observation", "SAO 249707"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.20480099),
        dec: Angle.Degrees(-61.55080730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191507"},
        {"Hipparcos Number", "HIP 99683"},
        {"Renson", "Renson 53370"},
        {"Smithsonian Astrophysical Observation", "SAO 254753"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.42715266),
        dec: Angle.Degrees(-61.54997219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125465"},
        {"Hipparcos Number", "HIP 70203"},
        {"Geneva Identification System", "GEN# +1.00125465"},
        {"Wilson Evans Batten Catalogue", "WEB 12190"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.45229717),
        dec: Angle.Degrees(-61.54961080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88366"},
        {"Hipparcos Number", "HIP 49751"},
        {"Geneva Identification System", "GEN# +1.00088366"},
        {"Smithsonian Astrophysical Observation", "SAO 250840"},
        {"Wilson Evans Batten Catalogue", "WEB 9173"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.34169913),
        dec: Angle.Degrees(-61.54919750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48025"},
        {"Hipparcos Number", "HIP 31638"},
        {"Smithsonian Astrophysical Observation", "SAO 249602"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.31113818),
        dec: Angle.Degrees(-61.54700781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160400"},
        {"Hipparcos Number", "HIP 86760"},
        {"Smithsonian Astrophysical Observation", "SAO 254011"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.92526306),
        dec: Angle.Degrees(-61.54670434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114620"},
        {"Hipparcos Number", "HIP 64471"},
        {"Geneva Identification System", "GEN# +1.00114620"},
        {"Smithsonian Astrophysical Observation", "SAO 252199"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.20821719),
        dec: Angle.Degrees(-61.54508330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209705"},
        {"Hipparcos Number", "HIP 109203"},
        {"Smithsonian Astrophysical Observation", "SAO 255147"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.83334308),
        dec: Angle.Degrees(-61.54353505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22748"},
        {"Hipparcos Number", "HIP 16785"},
        {"Geneva Identification System", "GEN# +1.00022748"},
        {"Smithsonian Astrophysical Observation", "SAO 248850"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.00106477),
        dec: Angle.Degrees(-61.54261384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88695"},
        {"Hipparcos Number", "HIP 49945"},
        {"Celescope Catalog", "CEL 3462"},
        {"Geneva Identification System", "GEN# +1.00088695"},
        {"Smithsonian Astrophysical Observation", "SAO 250863"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.95779148),
        dec: Angle.Degrees(-61.54193793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37066"},
        {"Hipparcos Number", "HIP 25889"},
        {"Geneva Identification System", "GEN# +1.00037066"},
        {"Smithsonian Astrophysical Observation", "SAO 249302"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.90037533),
        dec: Angle.Degrees(-61.54115133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31498"},
        {"Hipparcos Number", "HIP 22655"},
        {"Smithsonian Astrophysical Observation", "SAO 249128"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.09774431),
        dec: Angle.Degrees(-61.53996923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107509"},
        {"Hipparcos Number", "HIP 60288"},
        {"Geneva Identification System", "GEN# +1.00107509"},
        {"Smithsonian Astrophysical Observation", "SAO 251865"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.43655369),
        dec: Angle.Degrees(-61.53862125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -249.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2270"},
        {"Hipparcos Number", "HIP 2061"},
        {"Smithsonian Astrophysical Observation", "SAO 248183"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.52491435),
        dec: Angle.Degrees(-61.53850820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118136",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118136"},
        {"Geneva Identification System", "GEN# -0.06206457"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.44779885),
        dec: Angle.Degrees(-61.53688515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196265"},
        {"Hipparcos Number", "HIP 101931"},
        {"Smithsonian Astrophysical Observation", "SAO 254841"},
    },
    visualMagnitude: 7.17,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.84001366),
        dec: Angle.Degrees(-61.53561604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67849"},
        {"Hipparcos Number", "HIP 39660"},
        {"Smithsonian Astrophysical Observation", "SAO 250110"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.57686941),
        dec: Angle.Degrees(-61.53443821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48189"},
        {"Hipparcos Number", "HIP 31711"},
        {"Geneva Identification System", "GEN# +1.00048189"},
        {"Smithsonian Astrophysical Observation", "SAO 249604"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.50176847),
        dec: Angle.Degrees(-61.53356388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16864"},
        {"Hipparcos Number", "HIP 12396"},
        {"Geneva Identification System", "GEN# +1.00016864"},
        {"Smithsonian Astrophysical Observation", "SAO 248615"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.90261210),
        dec: Angle.Degrees(-61.53311789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158551"},
        {"Hipparcos Number", "HIP 85948"},
        {"Smithsonian Astrophysical Observation", "SAO 253962"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.49386415),
        dec: Angle.Degrees(-61.53182440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195961"},
        {"Hipparcos Number", "HIP 101773"},
        {"Fundamental Katalog 5th Edition", "FK5 3647"},
        {"Geneva Identification System", "GEN# +1.00195961"},
        {"Renson", "Renson 54630"},
        {"Smithsonian Astrophysical Observation", "SAO 254835"},
        {"Wilson Evans Batten Catalogue", "WEB 18386"},
    },
    visualMagnitude: 4.86,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.39683225),
        dec: Angle.Degrees(-61.52974415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110640"},
        {"Hipparcos Number", "HIP 62154"},
        {"Geneva Identification System", "GEN# +1.00110640"},
        {"Smithsonian Astrophysical Observation", "SAO 252009"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.08027728),
        dec: Angle.Degrees(-61.52518328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66657"},
        {"Hipparcos Number", "HIP 39195"},
        {"Smithsonian Astrophysical Observation", "SAO 250072"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.25365905),
        dec: Angle.Degrees(-61.52425392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103146"},
        {"Hipparcos Number", "HIP 57895"},
        {"Celescope Catalog", "CEL 3999"},
        {"Geneva Identification System", "GEN# +1.00103146"},
        {"Smithsonian Astrophysical Observation", "SAO 251619"},
        {"Wilson Evans Batten Catalogue", "WEB 10379"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.11988441),
        dec: Angle.Degrees(-61.52414702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129405"},
        {"Hipparcos Number", "HIP 72103"},
        {"Geneva Identification System", "GEN# +1.00129405"},
        {"Smithsonian Astrophysical Observation", "SAO 252868"},
    },
    visualMagnitude: 6.97,
    bvColour: 2.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.24619929),
        dec: Angle.Degrees(-61.52165120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123505"},
        {"Hipparcos Number", "HIP 69201"},
        {"Cincinnati Publication", "Ci 20 833"},
        {"Geneva Identification System", "GEN# +1.00123505"},
        {"Smithsonian Astrophysical Observation", "SAO 252632"},
        {"Wilson Evans Batten Catalogue", "WEB 12076"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.51354194),
        dec: Angle.Degrees(-61.52020961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -460.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -644.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12937"},
        {"Hipparcos Number", "HIP 9687"},
        {"Smithsonian Astrophysical Observation", "SAO 248488"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.15353037),
        dec: Angle.Degrees(-61.52009426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141806"},
        {"Hipparcos Number", "HIP 77890"},
        {"Smithsonian Astrophysical Observation", "SAO 253337"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.60296022),
        dec: Angle.Degrees(-61.51827594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102152"},
        {"Hipparcos Number", "HIP 57316"},
        {"Geneva Identification System", "GEN# +1.00102152"},
        {"Smithsonian Astrophysical Observation", "SAO 251568"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.27373077),
        dec: Angle.Degrees(-61.51730492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63835",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63835"},
    },
    visualMagnitude: 12.18,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.24522234),
        dec: Angle.Degrees(-61.51669981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122811"},
        {"Hipparcos Number", "HIP 68865"},
        {"Geneva Identification System", "GEN# +1.00122811"},
        {"Renson", "Renson 35210"},
        {"Smithsonian Astrophysical Observation", "SAO 252595"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.52864204),
        dec: Angle.Degrees(-61.51443119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115667"},
        {"Hipparcos Number", "HIP 65034"},
        {"Geneva Identification System", "GEN# +1.00115667"},
        {"Smithsonian Astrophysical Observation", "SAO 252266"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.96131249),
        dec: Angle.Degrees(-61.51329269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -245.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1993"},
    },
    visualMagnitude: 11.26,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.31064783),
        dec: Angle.Degrees(-61.51327008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12878"},
        {"Smithsonian Astrophysical Observation", "SAO 232882"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.38572828),
        dec: Angle.Degrees(-55.54381783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123131"},
        {"Hipparcos Number", "HIP 69041"},
        {"Smithsonian Astrophysical Observation", "SAO 252611"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.98612857),
        dec: Angle.Degrees(-61.50893079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23618"},
        {"Hipparcos Number", "HIP 17370"},
        {"Smithsonian Astrophysical Observation", "SAO 248873"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.78807494),
        dec: Angle.Degrees(-61.50870769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176622"},
        {"Hipparcos Number", "HIP 93728"},
        {"Geneva Identification System", "GEN# +1.00176622"},
        {"Smithsonian Astrophysical Observation", "SAO 254456"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.26992755),
        dec: Angle.Degrees(-61.50759576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121195"},
        {"Hipparcos Number", "HIP 68041"},
        {"Geneva Identification System", "GEN# +1.00121195"},
        {"Smithsonian Astrophysical Observation", "SAO 252524"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.97457362),
        dec: Angle.Degrees(-61.50372187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43199"},
        {"Hipparcos Number", "HIP 29314"},
        {"Fundamental Katalog 5th Edition", "FK5 4563"},
        {"Geneva Identification System", "GEN# +1.00043199"},
        {"Smithsonian Astrophysical Observation", "SAO 249464"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.72030146),
        dec: Angle.Degrees(-61.49989345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168339"},
        {"Hipparcos Number", "HIP 90098"},
        {"Fundamental Katalog 5th Edition", "FK5 686"},
        {"Geneva Identification System", "GEN# +1.00168339"},
        {"Smithsonian Astrophysical Observation", "SAO 254226"},
        {"Wilson Evans Batten Catalogue", "WEB 15401"},
    },
    visualMagnitude: 4.35,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.80675239),
        dec: Angle.Degrees(-61.49390506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37953"},
        {"Hipparcos Number", "HIP 26483"},
        {"Smithsonian Astrophysical Observation", "SAO 249324"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.49100520),
        dec: Angle.Degrees(-61.49315784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108858"},
        {"Hipparcos Number", "HIP 61067"},
        {"Geneva Identification System", "GEN# +1.00108858"},
        {"Smithsonian Astrophysical Observation", "SAO 251939"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.73882295),
        dec: Angle.Degrees(-61.49305295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65056"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.03070283),
        dec: Angle.Degrees(-61.49294848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22793"},
        {"Hipparcos Number", "HIP 16807"},
        {"Smithsonian Astrophysical Observation", "SAO 248851"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.08560078),
        dec: Angle.Degrees(-61.49136986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187393"},
        {"Hipparcos Number", "HIP 97884"},
        {"Geneva Identification System", "GEN# +1.00187393"},
        {"Smithsonian Astrophysical Observation", "SAO 254677"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.36189885),
        dec: Angle.Degrees(-61.49005067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151005"},
        {"Hipparcos Number", "HIP 82262"},
        {"Smithsonian Astrophysical Observation", "SAO 253703"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.12677791),
        dec: Angle.Degrees(-61.48910917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73289"},
        {"Hipparcos Number", "HIP 42067"},
        {"Smithsonian Astrophysical Observation", "SAO 250272"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.61437515),
        dec: Angle.Degrees(-61.48830880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21132"},
        {"Hipparcos Number", "HIP 15644"},
        {"Geneva Identification System", "GEN# +1.00021132"},
        {"Smithsonian Astrophysical Observation", "SAO 248784"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.35134201),
        dec: Angle.Degrees(-61.48795964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218862"},
        {"Hipparcos Number", "HIP 114555"},
        {"Geneva Identification System", "GEN# +1.00218862"},
        {"Smithsonian Astrophysical Observation", "SAO 255424"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.06578296),
        dec: Angle.Degrees(-61.48728581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133869"},
        {"Hipparcos Number", "HIP 74195"},
        {"Smithsonian Astrophysical Observation", "SAO 253037"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.41723401),
        dec: Angle.Degrees(-61.48707737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121901"},
        {"Hipparcos Number", "HIP 68413"},
        {"Geneva Identification System", "GEN# +1.00121901"},
        {"Smithsonian Astrophysical Observation", "SAO 252552"},
        {"Wilson Evans Batten Catalogue", "WEB 11995"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.07279016),
        dec: Angle.Degrees(-61.48094266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88524"},
        {"Smithsonian Astrophysical Observation", "SAO 254128"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.16173797),
        dec: Angle.Degrees(-61.47984696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31878"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.95856952),
        dec: Angle.Degrees(-61.47838484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190221"},
        {"Hipparcos Number", "HIP 99123"},
        {"Smithsonian Astrophysical Observation", "SAO 254730"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.85144924),
        dec: Angle.Degrees(-61.47751768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157289"},
        {"Hipparcos Number", "HIP 85332"},
        {"Renson", "Renson 44210"},
        {"Smithsonian Astrophysical Observation", "SAO 253918"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.57710318),
        dec: Angle.Degrees(-61.47733107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194535"},
        {"Hipparcos Number", "HIP 101078"},
        {"Smithsonian Astrophysical Observation", "SAO 254799"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.35999858),
        dec: Angle.Degrees(-61.47649821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30865"},
        {"Hipparcos Number", "HIP 22249"},
        {"Smithsonian Astrophysical Observation", "SAO 249108"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.84028462),
        dec: Angle.Degrees(-61.47605718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43519"},
        {"Hipparcos Number", "HIP 29468"},
        {"Smithsonian Astrophysical Observation", "SAO 249475"},
    },
    visualMagnitude: 6.59,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.13416592),
        dec: Angle.Degrees(-61.47407691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43769"},
        {"Hipparcos Number", "HIP 29583"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.50494156),
        dec: Angle.Degrees(-61.47328297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114213"},
        {"Hipparcos Number", "HIP 64272"},
        {"Geneva Identification System", "GEN# +1.00114213"},
        {"Smithsonian Astrophysical Observation", "SAO 252175"},
        {"Wilson Evans Batten Catalogue", "WEB 11361"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.58906793),
        dec: Angle.Degrees(-61.47246651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143431"},
        {"Hipparcos Number", "HIP 78674"},
        {"Geneva Identification System", "GEN# +1.00143431"},
        {"Smithsonian Astrophysical Observation", "SAO 253404"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.91922740),
        dec: Angle.Degrees(-61.47085366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106943"},
        {"Hipparcos Number", "HIP 59982"},
        {"Celescope Catalog", "CEL 4088"},
        {"Geneva Identification System", "GEN# +1.00106943"},
        {"Smithsonian Astrophysical Observation", "SAO 251837"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.52818737),
        dec: Angle.Degrees(-61.46988256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70294"},
        {"Hipparcos Number", "HIP 40638"},
        {"Smithsonian Astrophysical Observation", "SAO 250179"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.43745080),
        dec: Angle.Degrees(-61.46667237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114603"},
        {"Hipparcos Number", "HIP 64455"},
        {"Geneva Identification System", "GEN# +1.00114603"},
        {"Smithsonian Astrophysical Observation", "SAO 252197"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.16854019),
        dec: Angle.Degrees(-61.46479177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207217"},
        {"Hipparcos Number", "HIP 107742"},
        {"Geneva Identification System", "GEN# +1.00207217"},
        {"Smithsonian Astrophysical Observation", "SAO 255078"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.38835717),
        dec: Angle.Degrees(-61.46357205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18525"},
        {"Hipparcos Number", "HIP 13649"},
        {"Fundamental Katalog 5th Edition", "FK5 4266"},
        {"Smithsonian Astrophysical Observation", "SAO 248687"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.93058286),
        dec: Angle.Degrees(-61.46286549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221739"},
        {"Hipparcos Number", "HIP 116395"},
        {"Geneva Identification System", "GEN# +1.00221739"},
        {"Smithsonian Astrophysical Observation", "SAO 255519"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.79010528),
        dec: Angle.Degrees(-61.46285452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172420"},
        {"Hipparcos Number", "HIP 91899"},
        {"Geneva Identification System", "GEN# +1.00172420"},
        {"Smithsonian Astrophysical Observation", "SAO 254356"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.02428364),
        dec: Angle.Degrees(-61.46270044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129708"},
        {"Henry Draper 2", "HD 129708B"},
        {"Hipparcos Number", "HIP 72264"},
        {"Geneva Identification System", "GEN# +1.00129708"},
        {"Smithsonian Astrophysical Observation", "SAO 252879"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.67494532),
        dec: Angle.Degrees(-61.46193219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15234"},
        {"Hipparcos Number", "HIP 11250"},
        {"Geneva Identification System", "GEN# +1.00015234"},
        {"Smithsonian Astrophysical Observation", "SAO 248554"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.20481507),
        dec: Angle.Degrees(-61.46054168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54868"},
        {"Hipparcos Number", "HIP 34298"},
        {"Smithsonian Astrophysical Observation", "SAO 249738"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.65089485),
        dec: Angle.Degrees(-61.45969602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108750"},
        {"Hipparcos Number", "HIP 60989"},
        {"Geneva Identification System", "GEN# +1.00108750"},
        {"Smithsonian Astrophysical Observation", "SAO 251933"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.51380599),
        dec: Angle.Degrees(-61.45597841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5979"},
        {"Hipparcos Number", "HIP 4678"},
        {"Smithsonian Astrophysical Observation", "SAO 248298"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.02922066),
        dec: Angle.Degrees(-61.45444880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210694"},
        {"Hipparcos Number", "HIP 109763"},
        {"Smithsonian Astrophysical Observation", "SAO 255178"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.48949673),
        dec: Angle.Degrees(-61.44873875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40645"},
        {"Hipparcos Number", "HIP 28077"},
        {"Geneva Identification System", "GEN# +1.00040645"},
        {"Smithsonian Astrophysical Observation", "SAO 249395"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.03022493),
        dec: Angle.Degrees(-61.44735501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69576"},
        {"Hipparcos Number", "HIP 40334"},
        {"Geneva Identification System", "GEN# +1.00069576"},
        {"Smithsonian Astrophysical Observation", "SAO 250157"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.53205031),
        dec: Angle.Degrees(-61.44221275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162806"},
        {"Hipparcos Number", "HIP 87864"},
        {"Geneva Identification System", "GEN# +1.00162806"},
        {"Smithsonian Astrophysical Observation", "SAO 254085"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.22936630),
        dec: Angle.Degrees(-61.44065445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179120"},
        {"Hipparcos Number", "HIP 94601"},
        {"Geneva Identification System", "GEN# +1.00179120"},
        {"Smithsonian Astrophysical Observation", "SAO 254506"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.77385074),
        dec: Angle.Degrees(-61.44052412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42363"},
        {"Hipparcos Number", "HIP 28912"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.54737867),
        dec: Angle.Degrees(-61.43860964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13400"},
        {"Hipparcos Number", "HIP 10001"},
        {"Smithsonian Astrophysical Observation", "SAO 248499"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.19730766),
        dec: Angle.Degrees(-61.43670314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 985"},
        {"Hipparcos Number", "HIP 1129"},
        {"Geneva Identification System", "GEN# +1.00000985"},
    },
    visualMagnitude: 10.11,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.51746832),
        dec: Angle.Degrees(-43.18875719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63685"},
        {"Hipparcos Number", "HIP 37930"},
        {"Geneva Identification System", "GEN# +1.00063685"},
        {"Smithsonian Astrophysical Observation", "SAO 249956"},
        {"Wilson Evans Batten Catalogue", "WEB 7486"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.59732576),
        dec: Angle.Degrees(-61.43084211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 283.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94346"},
        {"Hipparcos Number", "HIP 53121"},
        {"Celescope Catalog", "CEL 3745"},
        {"Geneva Identification System", "GEN# +1.00094346"},
        {"Smithsonian Astrophysical Observation", "SAO 251156"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.01032908),
        dec: Angle.Degrees(-61.42916751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220218"},
        {"Hipparcos Number", "HIP 115409"},
        {"Geneva Identification System", "GEN# +1.00220218"},
        {"Smithsonian Astrophysical Observation", "SAO 255473"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.67294588),
        dec: Angle.Degrees(-61.42535787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39809"},
        {"Hipparcos Number", "HIP 27623"},
        {"Smithsonian Astrophysical Observation", "SAO 249370"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.72470528),
        dec: Angle.Degrees(-61.42468877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155607"},
        {"Hipparcos Number", "HIP 84502"},
        {"Geneva Identification System", "GEN# +1.00155607"},
        {"Smithsonian Astrophysical Observation", "SAO 253853"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.13581675),
        dec: Angle.Degrees(-61.42351863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223713"},
        {"Hipparcos Number", "HIP 117702"},
        {"Cincinnati Publication", "Ci 20 1459"},
        {"Geneva Identification System", "GEN# +1.00223713"},
        {"Smithsonian Astrophysical Observation", "SAO 255588"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.05921353),
        dec: Angle.Degrees(-61.42316803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -815.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26701"},
        {"Hipparcos Number", "HIP 19426"},
        {"Smithsonian Astrophysical Observation", "SAO 248955"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.40725910),
        dec: Angle.Degrees(-61.42297286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35312"},
        {"Smithsonian Astrophysical Observation", "SAO 249811"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.41291737),
        dec: Angle.Degrees(-61.42260595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134060"},
        {"Hipparcos Number", "HIP 74273"},
        {"Geneva Identification System", "GEN# +1.00134060"},
        {"Smithsonian Astrophysical Observation", "SAO 253043"},
        {"Wilson Evans Batten Catalogue", "WEB 12682"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.68737266),
        dec: Angle.Degrees(-61.42229270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198065"},
        {"Hipparcos Number", "HIP 102906"},
        {"Smithsonian Astrophysical Observation", "SAO 254880"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.71612341),
        dec: Angle.Degrees(-61.42157403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66790",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66790"},
        {"Smithsonian Astrophysical Observation", "SAO 252412"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.33983940),
        dec: Angle.Degrees(-61.42037654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76234"},
        {"Hipparcos Number", "HIP 43508"},
        {"Smithsonian Astrophysical Observation", "SAO 250352"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.93361299),
        dec: Angle.Degrees(-61.41970925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198192"},
        {"Hipparcos Number", "HIP 102965"},
        {"Smithsonian Astrophysical Observation", "SAO 254885"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.91966823),
        dec: Angle.Degrees(-61.41544289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115703"},
        {"Hipparcos Number", "HIP 65059"},
        {"Smithsonian Astrophysical Observation", "SAO 252269"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.03627321),
        dec: Angle.Degrees(-61.41347700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60402"},
        {"Hipparcos Number", "HIP 36494"},
        {"Smithsonian Astrophysical Observation", "SAO 249867"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.62584631),
        dec: Angle.Degrees(-61.41298104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195771"},
        {"Hipparcos Number", "HIP 101669"},
        {"Smithsonian Astrophysical Observation", "SAO 254826"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.11739124),
        dec: Angle.Degrees(-61.41113585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206346"},
        {"Hipparcos Number", "HIP 107275"},
        {"Smithsonian Astrophysical Observation", "SAO 255057"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.93632482),
        dec: Angle.Degrees(-61.40401930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54612"},
        {"Hipparcos Number", "HIP 34194"},
        {"Smithsonian Astrophysical Observation", "SAO 249729"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.36648915),
        dec: Angle.Degrees(-61.40257259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104284"},
        {"Hipparcos Number", "HIP 58563"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.12419044),
        dec: Angle.Degrees(-61.40165835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37935",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37935"},
        {"Smithsonian Astrophysical Observation", "SAO 249957"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.61893462),
        dec: Angle.Degrees(-61.40065468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25422"},
        {"Hipparcos Number", "HIP 18597"},
        {"Fundamental Katalog 5th Edition", "FK5 1110"},
        {"Geneva Identification System", "GEN# +1.00025422"},
        {"Smithsonian Astrophysical Observation", "SAO 248918"},
        {"Wilson Evans Batten Catalogue", "WEB 3583"},
    },
    visualMagnitude: 4.56,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.68640623),
        dec: Angle.Degrees(-61.40015059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110639"},
        {"Hipparcos Number", "HIP 62149"},
        {"Geneva Identification System", "GEN# +1.00110639"},
        {"Smithsonian Astrophysical Observation", "SAO 252008"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.07120996),
        dec: Angle.Degrees(-61.39463660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189448"},
        {"Hipparcos Number", "HIP 98768"},
        {"Smithsonian Astrophysical Observation", "SAO 254718"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.90465591),
        dec: Angle.Degrees(-61.39444938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22366"},
        {"Hipparcos Number", "HIP 16522"},
        {"Geneva Identification System", "GEN# +1.00022366"},
        {"Smithsonian Astrophysical Observation", "SAO 248833"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.18002101),
        dec: Angle.Degrees(-61.39391855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11042"},
        {"Hipparcos Number", "HIP 8278"},
        {"Fundamental Katalog 5th Edition", "FK5 4161"},
        {"Geneva Identification System", "GEN# +1.00011042"},
        {"Smithsonian Astrophysical Observation", "SAO 248433"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.66416597),
        dec: Angle.Degrees(-61.39094956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125880"},
        {"Hipparcos Number", "HIP 70436"},
        {"Geneva Identification System", "GEN# +4.24020001"},
        {"Smithsonian Astrophysical Observation", "SAO 252732"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.13468177),
        dec: Angle.Degrees(-61.38941515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151066"},
        {"Hipparcos Number", "HIP 82296"},
        {"Smithsonian Astrophysical Observation", "SAO 253705"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.23370894),
        dec: Angle.Degrees(-61.38861664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 305913"},
        {"Hipparcos Number", "HIP 53880"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.35323466),
        dec: Angle.Degrees(-61.38630639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75443"},
        {"Geneva Identification System", "GEN# -0.06005770"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.19602142),
        dec: Angle.Degrees(-61.38542933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108313"},
        {"Hipparcos Number", "HIP 60752"},
        {"Smithsonian Astrophysical Observation", "SAO 251908"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.76085432),
        dec: Angle.Degrees(-61.38522843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29179"},
        {"Hipparcos Number", "HIP 21140"},
        {"Smithsonian Astrophysical Observation", "SAO 249047"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.97305824),
        dec: Angle.Degrees(-61.38453411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31575"},
        {"Hipparcos Number", "HIP 22705"},
        {"Smithsonian Astrophysical Observation", "SAO 249130"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.23998657),
        dec: Angle.Degrees(-61.38323220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56266"},
        {"Hipparcos Number", "HIP 34826"},
        {"Smithsonian Astrophysical Observation", "SAO 249778"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.12042867),
        dec: Angle.Degrees(-61.38163403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16756"},
        {"Hipparcos Number", "HIP 12310"},
        {"Smithsonian Astrophysical Observation", "SAO 248612"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.63490347),
        dec: Angle.Degrees(-61.38024654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20545"},
        {"Hipparcos Number", "HIP 15136"},
        {"Fundamental Katalog 5th Edition", "FK5 4299"},
        {"Smithsonian Astrophysical Observation", "SAO 248762"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.78198500),
        dec: Angle.Degrees(-61.37563871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115601"},
        {"Hipparcos Number", "HIP 65002"},
        {"Smithsonian Astrophysical Observation", "SAO 252260"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.85859063),
        dec: Angle.Degrees(-61.37140646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99619"},
        {"Hipparcos Number", "HIP 55863"},
        {"Geneva Identification System", "GEN# +1.00099619"},
        {"Smithsonian Astrophysical Observation", "SAO 251408"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.74861891),
        dec: Angle.Degrees(-61.36932645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99355"},
        {"Hipparcos Number", "HIP 55736"},
        {"Geneva Identification System", "GEN# +1.00099355"},
        {"Wilson Evans Batten Catalogue", "WEB 10017"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.30414092),
        dec: Angle.Degrees(-61.36916406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104255"},
        {"Henry Draper 2", "HD 104255A"},
        {"Hipparcos Number", "HIP 58544"},
        {"Geneva Identification System", "GEN# +1.00104255"},
        {"Smithsonian Astrophysical Observation", "SAO 251677"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.07540285),
        dec: Angle.Degrees(-61.36786460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119285"},
        {"Hipparcos Number", "HIP 67013"},
        {"Smithsonian Astrophysical Observation", "SAO 252429"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.00373754),
        dec: Angle.Degrees(-61.36647060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163637"},
        {"Hipparcos Number", "HIP 88251"},
        {"Smithsonian Astrophysical Observation", "SAO 254109"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.31088613),
        dec: Angle.Degrees(-61.36612795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4039"},
        {"Hipparcos Number", "HIP 3303"},
        {"Smithsonian Astrophysical Observation", "SAO 248236"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.52864680),
        dec: Angle.Degrees(-61.36479277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93207"},
        {"Hipparcos Number", "HIP 52534"},
        {"Smithsonian Astrophysical Observation", "SAO 251098"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.11210895),
        dec: Angle.Degrees(-61.36359024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141624"},
        {"Hipparcos Number", "HIP 77818"},
        {"Smithsonian Astrophysical Observation", "SAO 253329"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.34585108),
        dec: Angle.Degrees(-61.36349714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 126.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76188"},
        {"Hipparcos Number", "HIP 43487"},
        {"Geneva Identification System", "GEN# +1.00076188"},
        {"Smithsonian Astrophysical Observation", "SAO 250349"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.86660490),
        dec: Angle.Degrees(-61.36334742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -201.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 156.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85119"},
        {"Smithsonian Astrophysical Observation", "SAO 253902"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.94146144),
        dec: Angle.Degrees(-61.36247783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10738"},
        {"Hipparcos Number", "HIP 8030"},
        {"Smithsonian Astrophysical Observation", "SAO 248425"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.78264158),
        dec: Angle.Degrees(-61.36218357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82738"},
        {"Hipparcos Number", "HIP 46716"},
        {"Smithsonian Astrophysical Observation", "SAO 250609"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.84549932),
        dec: Angle.Degrees(-61.35850069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6607"},
        {"Hipparcos Number", "HIP 5126"},
        {"Smithsonian Astrophysical Observation", "SAO 248315"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.41237895),
        dec: Angle.Degrees(-61.35741066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25874"},
        {"Hipparcos Number", "HIP 18844"},
        {"Geneva Identification System", "GEN# +1.00025874A"},
        {"Smithsonian Astrophysical Observation", "SAO 248932"},
        {"Wilson Evans Batten Catalogue", "WEB 3628"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.61065476),
        dec: Angle.Degrees(-61.35720533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 337.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91270"},
        {"Hipparcos Number", "HIP 51461"},
        {"Geneva Identification System", "GEN# +1.00091270"},
        {"Smithsonian Astrophysical Observation", "SAO 250992"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.66351149),
        dec: Angle.Degrees(-61.35650693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123057"},
        {"Hipparcos Number", "HIP 68985"},
        {"Geneva Identification System", "GEN# +1.00123057"},
        {"Smithsonian Astrophysical Observation", "SAO 252604"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.85471329),
        dec: Angle.Degrees(-61.35459042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16905"},
        {"Hipparcos Number", "HIP 12436"},
        {"Geneva Identification System", "GEN# +1.00016905A"},
        {"Smithsonian Astrophysical Observation", "SAO 248619"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.01309801),
        dec: Angle.Degrees(-61.35379692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202457"},
        {"Hipparcos Number", "HIP 105214"},
        {"Cincinnati Publication", "Ci 20 1272"},
        {"Geneva Identification System", "GEN# +1.00202457"},
        {"Smithsonian Astrophysical Observation", "SAO 254970"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.68219340),
        dec: Angle.Degrees(-61.35172058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 469.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -445.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125852"},
        {"Hipparcos Number", "HIP 70423"},
        {"Geneva Identification System", "GEN# +4.24020016"},
        {"Smithsonian Astrophysical Observation", "SAO 252731"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.09818694),
        dec: Angle.Degrees(-61.34977464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119698"},
        {"Hipparcos Number", "HIP 67218"},
        {"Smithsonian Astrophysical Observation", "SAO 252440"},
    },
    visualMagnitude: 9.21,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.61805830),
        dec: Angle.Degrees(-61.34934487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71726"},
        {"Hipparcos Number", "HIP 41294"},
        {"Geneva Identification System", "GEN# +1.00071726"},
        {"Smithsonian Astrophysical Observation", "SAO 250221"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.37618792),
        dec: Angle.Degrees(-61.34864614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2883"},
        {"Hipparcos Number", "HIP 2488"},
        {"Renson", "Renson 690"},
        {"Smithsonian Astrophysical Observation", "SAO 248203"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.89435712),
        dec: Angle.Degrees(-61.34667079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81770"},
        {"Hipparcos Number", "HIP 46178"},
        {"Celescope Catalog", "CEL 3288"},
        {"Geneva Identification System", "GEN# +1.00081770"},
        {"Smithsonian Astrophysical Observation", "SAO 250569"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.24674625),
        dec: Angle.Degrees(-61.34663129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37810"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.28698999),
        dec: Angle.Degrees(-61.34539425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180023"},
        {"Hipparcos Number", "HIP 94895"},
        {"Smithsonian Astrophysical Observation", "SAO 254522"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.66428261),
        dec: Angle.Degrees(-61.34358765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134657"},
        {"Hipparcos Number", "HIP 74552"},
        {"Geneva Identification System", "GEN# +1.00134657J"},
        {"Smithsonian Astrophysical Observation", "SAO 253064"},
        {"Wilson Evans Batten Catalogue", "WEB 12720"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.49663305),
        dec: Angle.Degrees(-61.34292666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24333"},
        {"Hipparcos Number", "HIP 17823"},
        {"Geneva Identification System", "GEN# +1.00024333"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.20642931),
        dec: Angle.Degrees(-61.34213231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53143"},
        {"Hipparcos Number", "HIP 33690"},
        {"Geneva Identification System", "GEN# +1.00053143"},
        {"Smithsonian Astrophysical Observation", "SAO 249700"},
        {"Wilson Evans Batten Catalogue", "WEB 6770"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.99938315),
        dec: Angle.Degrees(-61.33682491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 264.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115779"},
        {"Hipparcos Number", "HIP 65118"},
        {"Geneva Identification System", "GEN# +1.00115779"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.16548269),
        dec: Angle.Degrees(-61.33657187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91269"},
        {"Hipparcos Number", "HIP 51453"},
        {"Celescope Catalog", "CEL 3558"},
        {"Geneva Identification System", "GEN# +1.00091269"},
        {"Smithsonian Astrophysical Observation", "SAO 250991"},
        {"Wilson Evans Batten Catalogue", "WEB 9394"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.64049507),
        dec: Angle.Degrees(-61.33649801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112295"},
        {"Hipparcos Number", "HIP 63167"},
        {"Geneva Identification System", "GEN# +1.00112295"},
        {"Smithsonian Astrophysical Observation", "SAO 252100"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.13757475),
        dec: Angle.Degrees(-61.33524530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120993"},
        {"Hipparcos Number", "HIP 67933"},
        {"Geneva Identification System", "GEN# +1.00120993"},
        {"Smithsonian Astrophysical Observation", "SAO 252515"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.68064026),
        dec: Angle.Degrees(-61.33446729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218861"},
        {"Hipparcos Number", "HIP 114557"},
        {"Geneva Identification System", "GEN# +1.00218861"},
        {"Smithsonian Astrophysical Observation", "SAO 255425"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.07151444),
        dec: Angle.Degrees(-61.33284714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89388"},
        {"Hipparcos Number", "HIP 50371"},
        {"Fundamental Katalog 5th Edition", "FK5 1264"},
        {"Geneva Identification System", "GEN# +1.00089388"},
        {"Smithsonian Astrophysical Observation", "SAO 250905"},
        {"Wilson Evans Batten Catalogue", "WEB 9246"},
    },
    visualMagnitude: 3.39,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.27085535),
        dec: Angle.Degrees(-61.33231977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113152"},
        {"Hipparcos Number", "HIP 63651"},
        {"Fundamental Katalog 5th Edition", "FK5 5150"},
        {"Geneva Identification System", "GEN# +1.00113152"},
        {"Smithsonian Astrophysical Observation", "SAO 252134"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.68266332),
        dec: Angle.Degrees(-61.33201754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44846"},
        {"Hipparcos Number", "HIP 30094"},
        {"Geneva Identification System", "GEN# +1.00044846"},
        {"Smithsonian Astrophysical Observation", "SAO 249513"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.99946660),
        dec: Angle.Degrees(-61.32978210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8463"},
        {"Hipparcos Number", "HIP 6412"},
        {"Fundamental Katalog 5th Edition", "FK5 4125"},
        {"Smithsonian Astrophysical Observation", "SAO 248372"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.58809848),
        dec: Angle.Degrees(-61.32946607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83944"},
        {"Hipparcos Number", "HIP 47391"},
        {"Celescope Catalog", "CEL 3356"},
        {"Geneva Identification System", "GEN# +1.00083944"},
        {"Smithsonian Astrophysical Observation", "SAO 250653"},
        {"Wilson Evans Batten Catalogue", "WEB 8898"},
    },
    visualMagnitude: 4.51,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.83767061),
        dec: Angle.Degrees(-61.32810523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44777"},
        {"Hipparcos Number", "HIP 30068"},
        {"Smithsonian Astrophysical Observation", "SAO 249507"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.92011599),
        dec: Angle.Degrees(-61.32582207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95324"},
        {"Henry Draper 2", "HD 95324A"},
        {"Hipparcos Number", "HIP 53701"},
        {"Celescope Catalog", "CEL 3770"},
        {"Geneva Identification System", "GEN# +1.00095324"},
        {"Smithsonian Astrophysical Observation", "SAO 251205"},
        {"Wilson Evans Batten Catalogue", "WEB 9728"},
    },
    visualMagnitude: 6.16,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.80852435),
        dec: Angle.Degrees(-61.32074411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150186"},
        {"Hipparcos Number", "HIP 81856"},
        {"Smithsonian Astrophysical Observation", "SAO 253675"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.77902138),
        dec: Angle.Degrees(-61.31814342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8257"},
        {"Hipparcos Number", "HIP 6274"},
        {"Smithsonian Astrophysical Observation", "SAO 248366"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.13247806),
        dec: Angle.Degrees(-61.31746584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101021"},
        {"Hipparcos Number", "HIP 56656"},
        {"Geneva Identification System", "GEN# +2.37660315"},
        {"Smithsonian Astrophysical Observation", "SAO 251486"},
        {"Wilson Evans Batten Catalogue", "WEB 10187"},
        {"New General Catalogue", "NGC 3766 315"},
    },
    visualMagnitude: 5.14,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.25334034),
        dec: Angle.Degrees(-61.28344643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -228.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68534"},
        {"Smithsonian Astrophysical Observation", "SAO 252561"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.44622197),
        dec: Angle.Degrees(-61.31272294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 859"},
        {"Hipparcos Number", "HIP 1017"},
        {"Geneva Identification System", "GEN# +1.00000859"},
        {"Smithsonian Astrophysical Observation", "SAO 248136"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.16599894),
        dec: Angle.Degrees(-61.31269282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80"},
        {"Hipparcos Number", "HIP 468"},
        {"Geneva Identification System", "GEN# +1.00000080"},
        {"Smithsonian Astrophysical Observation", "SAO 248116"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.39896188),
        dec: Angle.Degrees(-61.30989474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193530"},
        {"Hipparcos Number", "HIP 100602"},
        {"Geneva Identification System", "GEN# +1.00193530"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.00692538),
        dec: Angle.Degrees(-61.30825859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15638"},
        {"Hipparcos Number", "HIP 11503"},
        {"Smithsonian Astrophysical Observation", "SAO 248569"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.07930839),
        dec: Angle.Degrees(-61.30539750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68531",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68531"},
        {"Smithsonian Astrophysical Observation", "SAO 252559"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.43960967),
        dec: Angle.Degrees(-61.30397729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142921"},
        {"Hipparcos Number", "HIP 78425"},
        {"Geneva Identification System", "GEN# +1.00142921"},
        {"Smithsonian Astrophysical Observation", "SAO 253374"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.15632449),
        dec: Angle.Degrees(-61.30346183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -270.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25405"},
        {"Hipparcos Number", "HIP 18589"},
        {"Smithsonian Astrophysical Observation", "SAO 248917"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.66794010),
        dec: Angle.Degrees(-61.30215346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94037"},
        {"Hipparcos Number", "HIP 52967"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.49220471),
        dec: Angle.Degrees(-61.30195998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68456"},
        {"Hipparcos Number", "HIP 39903"},
        {"Fundamental Katalog 5th Edition", "FK5 2636"},
        {"Geneva Identification System", "GEN# +1.00068456"},
        {"Smithsonian Astrophysical Observation", "SAO 250131"},
        {"Wilson Evans Batten Catalogue", "WEB 7778"},
    },
    visualMagnitude: 4.74,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.25357658),
        dec: Angle.Degrees(-61.30170580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -297.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140097"},
        {"Hipparcos Number", "HIP 77149"},
        {"Geneva Identification System", "GEN# +1.00140097"},
        {"Smithsonian Astrophysical Observation", "SAO 253279"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.27344921),
        dec: Angle.Degrees(-61.29767370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220165"},
        {"Hipparcos Number", "HIP 115378"},
        {"Smithsonian Astrophysical Observation", "SAO 255470"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.58924366),
        dec: Angle.Degrees(-61.29760029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1818"},
        {"Hipparcos Number", "HIP 1751"},
        {"Smithsonian Astrophysical Observation", "SAO 248171"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.54151318),
        dec: Angle.Degrees(-61.29744207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210304"},
        {"Hipparcos Number", "HIP 109541"},
        {"Smithsonian Astrophysical Observation", "SAO 255167"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.84028926),
        dec: Angle.Degrees(-61.29171265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32210"},
        {"Hipparcos Number", "HIP 23046"},
        {"Geneva Identification System", "GEN# +1.00032210"},
        {"Smithsonian Astrophysical Observation", "SAO 249155"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.37261097),
        dec: Angle.Degrees(-61.28856520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 140.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100826"},
        {"Hipparcos Number", "HIP 56550"},
        {"Celescope Catalog", "CEL 3919"},
        {"Geneva Identification System", "GEN# +2.37660334"},
        {"Smithsonian Astrophysical Observation", "SAO 251469"},
        {"Wilson Evans Batten Catalogue", "WEB 10165"},
        {"New General Catalogue", "NGC 3766 334"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.92643343),
        dec: Angle.Degrees(-61.28787407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169080"},
        {"Hipparcos Number", "HIP 90407"},
        {"Smithsonian Astrophysical Observation", "SAO 254246"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.70277226),
        dec: Angle.Degrees(-61.28339619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42149"},
        {"Hipparcos Number", "HIP 28825"},
        {"Smithsonian Astrophysical Observation", "SAO 249441"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.26737285),
        dec: Angle.Degrees(-61.28235221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99313"},
        {"Hipparcos Number", "HIP 55706"},
        {"Geneva Identification System", "GEN# +1.00099313"},
        {"Smithsonian Astrophysical Observation", "SAO 251395"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.22656527),
        dec: Angle.Degrees(-61.28079237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103285"},
        {"Hipparcos Number", "HIP 57973"},
        {"Geneva Identification System", "GEN# +1.00103285"},
        {"Smithsonian Astrophysical Observation", "SAO 251626"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.37126864),
        dec: Angle.Degrees(-61.28056227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79864"},
        {"Hipparcos Number", "HIP 45296"},
        {"Celescope Catalog", "CEL 3236"},
        {"Geneva Identification System", "GEN# +1.00079864"},
        {"Smithsonian Astrophysical Observation", "SAO 250494"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.46641606),
        dec: Angle.Degrees(-61.27980051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100198"},
        {"Hipparcos Number", "HIP 56201"},
        {"Geneva Identification System", "GEN# +1.00100198"},
        {"Smithsonian Astrophysical Observation", "SAO 251437"},
        {"Wilson Evans Batten Catalogue", "WEB 10097"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.81271949),
        dec: Angle.Degrees(-61.27846788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105841"},
        {"Hipparcos Number", "HIP 59396"},
        {"Geneva Identification System", "GEN# +1.00105841"},
        {"Smithsonian Astrophysical Observation", "SAO 251778"},
        {"Wilson Evans Batten Catalogue", "WEB 10562"},
    },
    visualMagnitude: 6.08,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.77186283),
        dec: Angle.Degrees(-61.27738011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138153"},
        {"Hipparcos Number", "HIP 76170"},
        {"Smithsonian Astrophysical Observation", "SAO 253207"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.36293869),
        dec: Angle.Degrees(-61.27330600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125158"},
        {"Hipparcos Number", "HIP 70035"},
        {"Geneva Identification System", "GEN# +1.00125158"},
        {"Renson", "Renson 35750"},
        {"Smithsonian Astrophysical Observation", "SAO 252703"},
        {"Wilson Evans Batten Catalogue", "WEB 12180"},
    },
    visualMagnitude: 5.22,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.96543244),
        dec: Angle.Degrees(-61.27275714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 305903"},
        {"Hipparcos Number", "HIP 53854"},
    },
    visualMagnitude: 11.17,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.26115532),
        dec: Angle.Degrees(-61.27244035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17398",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17398"},
    },
    visualMagnitude: 10.61,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.91309855),
        dec: Angle.Degrees(-61.27013079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 133.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94144"},
        {"Hipparcos Number", "HIP 53007"},
        {"Celescope Catalog", "CEL 3735"},
        {"Geneva Identification System", "GEN# +1.00094144"},
        {"Smithsonian Astrophysical Observation", "SAO 251148"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.66683684),
        dec: Angle.Degrees(-61.26955684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77157"},
        {"Hipparcos Number", "HIP 44012"},
        {"Smithsonian Astrophysical Observation", "SAO 250398"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.43404566),
        dec: Angle.Degrees(-61.26906048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145527"},
        {"Henry Draper 2", "HD 145528"},
        {"Hipparcos Number", "HIP 79637"},
        {"Smithsonian Astrophysical Observation", "SAO 253473"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.77714141),
        dec: Angle.Degrees(-61.26773226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131424"},
        {"Hipparcos Number", "HIP 73091"},
        {"Geneva Identification System", "GEN# +1.00131424"},
        {"Smithsonian Astrophysical Observation", "SAO 252961"},
        {"Wilson Evans Batten Catalogue", "WEB 12529"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.06498841),
        dec: Angle.Degrees(-61.26742503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123553"},
        {"Hipparcos Number", "HIP 69233"},
        {"Geneva Identification System", "GEN# +1.00123553"},
        {"Smithsonian Astrophysical Observation", "SAO 252635"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.61745860),
        dec: Angle.Degrees(-61.26614972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176195"},
        {"Hipparcos Number", "HIP 93529"},
        {"Smithsonian Astrophysical Observation", "SAO 254448"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.73836839),
        dec: Angle.Degrees(-61.26606569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90219"},
        {"Hipparcos Number", "HIP 50855"},
        {"Geneva Identification System", "GEN# +1.00090219"},
        {"Smithsonian Astrophysical Observation", "SAO 250939"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.77168802),
        dec: Angle.Degrees(-61.26569125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46587"},
        {"Hipparcos Number", "HIP 30983"},
        {"Geneva Identification System", "GEN# +1.00046587"},
        {"Smithsonian Astrophysical Observation", "SAO 249564"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.53763681),
        dec: Angle.Degrees(-61.26522944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105256"},
        {"Hipparcos Number", "HIP 59101"},
        {"Geneva Identification System", "GEN# +2.41030010"},
        {"Smithsonian Astrophysical Observation", "SAO 251746"},
        {"New General Catalogue", "NGC 4103 10"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.79714499),
        dec: Angle.Degrees(-61.26444036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36531"},
        {"Hipparcos Number", "HIP 25611"},
        {"Smithsonian Astrophysical Observation", "SAO 249283"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.07719142),
        dec: Angle.Degrees(-61.26195908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80794",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80794"},
    },
    visualMagnitude: 10.91,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.44698622),
        dec: Angle.Degrees(-61.26189824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 238.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54948",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NGC 3603YC"},
        {"Common Name 2", "NGC 3603 YC"},
        {"Common Name 3", "NGC 3603 Young Cluster"},
        {"Henry Draper", "HD 97950"},
        {"Hipparcos Number", "HIP 54948"},
        {"Geneva Identification System", "GEN# +1.00097950J"},
        {"New General Catalogue", "NGC 3603 70"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)15, 07.3500),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)15, 37.500)
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
    primaryId: "HIP 80796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80796"},
    },
    visualMagnitude: 11.03,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)29, 48.7800),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)15, 35.700)
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
    primaryId: "HIP 16092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21765"},
        {"Hipparcos Number", "HIP 16092"},
        {"Geneva Identification System", "GEN# +1.00021765"},
        {"Smithsonian Astrophysical Observation", "SAO 248810"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.81963581),
        dec: Angle.Degrees(-61.25926579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1323"},
        {"Hipparcos Number", "HIP 1375"},
        {"Geneva Identification System", "GEN# +1.00001323"},
        {"Smithsonian Astrophysical Observation", "SAO 248151"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.29986372),
        dec: Angle.Degrees(-61.25834136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59026"},
        {"Wilson Evans Batten Catalogue", "WEB 10513"},
        {"New General Catalogue", "NGC 4103 1"},
    },
    visualMagnitude: 9.57,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.53206482),
        dec: Angle.Degrees(-61.25689820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201394"},
        {"Hipparcos Number", "HIP 104666"},
        {"Smithsonian Astrophysical Observation", "SAO 254953"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.01338291),
        dec: Angle.Degrees(-61.25549975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84163"},
        {"Hipparcos Number", "HIP 47487"},
        {"Smithsonian Astrophysical Observation", "SAO 250662"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.20281437),
        dec: Angle.Degrees(-61.25401335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115099",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115099"},
    },
    visualMagnitude: 11.25,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.69282144),
        dec: Angle.Degrees(-61.25365919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60290"},
        {"Hipparcos Number", "HIP 36440"},
        {"Geneva Identification System", "GEN# +1.00060290"},
        {"Smithsonian Astrophysical Observation", "SAO 249866"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.48652652),
        dec: Angle.Degrees(-61.24940396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9499"},
        {"Hipparcos Number", "HIP 7114"},
        {"Geneva Identification System", "GEN# +1.00009499"},
        {"Smithsonian Astrophysical Observation", "SAO 248395"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.90592526),
        dec: Angle.Degrees(-61.24933683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311979"},
        {"Hipparcos Number", "HIP 62840"},
        {"Geneva Identification System", "GEN# +1.00311979"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.15899475),
        dec: Angle.Degrees(-61.24857074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88663"},
        {"Hipparcos Number", "HIP 49919"},
        {"Smithsonian Astrophysical Observation", "SAO 250859"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.88559179),
        dec: Angle.Degrees(-61.23980573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124298"},
        {"Hipparcos Number", "HIP 69617"},
        {"Geneva Identification System", "GEN# +1.00124298"},
        {"Smithsonian Astrophysical Observation", "SAO 252664"},
        {"Wilson Evans Batten Catalogue", "WEB 12120"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.73672686),
        dec: Angle.Degrees(-61.23843976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28413"},
        {"Hipparcos Number", "HIP 20619"},
        {"Geneva Identification System", "GEN# +1.00028413"},
        {"Smithsonian Astrophysical Observation", "SAO 249016"},
        {"Wilson Evans Batten Catalogue", "WEB 3951"},
    },
    visualMagnitude: 5.94,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.27233379),
        dec: Angle.Degrees(-61.23824628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165938"},
        {"Hipparcos Number", "HIP 89217"},
        {"Geneva Identification System", "GEN# +1.00165938"},
        {"Smithsonian Astrophysical Observation", "SAO 254170"},
        {"Wilson Evans Batten Catalogue", "WEB 15161"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.10244805),
        dec: Angle.Degrees(-61.23535820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82834"},
        {"Hipparcos Number", "HIP 46786"},
        {"Celescope Catalog", "CEL 3317"},
        {"Geneva Identification System", "GEN# +1.00082834J"},
        {"Smithsonian Astrophysical Observation", "SAO 250612"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.01285432),
        dec: Angle.Degrees(-61.23489778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131757"},
        {"Hipparcos Number", "HIP 73247"},
        {"Smithsonian Astrophysical Observation", "SAO 252975"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.55072377),
        dec: Angle.Degrees(-61.23445910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39062"},
        {"Hipparcos Number", "HIP 27206"},
        {"Geneva Identification System", "GEN# +1.00039062"},
        {"Smithsonian Astrophysical Observation", "SAO 249350"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.50480045),
        dec: Angle.Degrees(-61.22989598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98818"},
        {"Hipparcos Number", "HIP 55466"},
        {"Geneva Identification System", "GEN# +1.00098818"},
        {"Smithsonian Astrophysical Observation", "SAO 251368"},
        {"Wilson Evans Batten Catalogue", "WEB 9977"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.39071687),
        dec: Angle.Degrees(-61.22631660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170915"},
        {"Hipparcos Number", "HIP 91154"},
        {"Geneva Identification System", "GEN# +6.20145016"},
        {"Smithsonian Astrophysical Observation", "SAO 254300"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.95778181),
        dec: Angle.Degrees(-61.22586921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -425.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67"},
        {"Hipparcos Number", "HIP 459"},
        {"Geneva Identification System", "GEN# +1.00000067"},
        {"Smithsonian Astrophysical Observation", "SAO 248115"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.36813317),
        dec: Angle.Degrees(-61.22566452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49035"},
        {"Hipparcos Number", "HIP 32103"},
        {"Geneva Identification System", "GEN# +1.00049035"},
        {"Smithsonian Astrophysical Observation", "SAO 249626"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.59734896),
        dec: Angle.Degrees(-61.22530867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 140.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79836"},
        {"Hipparcos Number", "HIP 45273"},
        {"Smithsonian Astrophysical Observation", "SAO 250491"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.40802397),
        dec: Angle.Degrees(-61.22500659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49518"},
        {"Hipparcos Number", "HIP 32309"},
        {"Fundamental Katalog 5th Edition", "FK5 4613"},
        {"Smithsonian Astrophysical Observation", "SAO 249636"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.18425053),
        dec: Angle.Degrees(-61.22424879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111037"},
        {"Hipparcos Number", "HIP 62391"},
        {"Geneva Identification System", "GEN# +1.00111037"},
        {"Smithsonian Astrophysical Observation", "SAO 252029"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.79833363),
        dec: Angle.Degrees(-61.22346838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139833"},
        {"Hipparcos Number", "HIP 77024"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.89238092),
        dec: Angle.Degrees(-61.22344744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64383"},
        {"Hipparcos Number", "HIP 38240"},
        {"Smithsonian Astrophysical Observation", "SAO 249977"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.51015350),
        dec: Angle.Degrees(-61.22263717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9264"},
        {"Hipparcos Number", "HIP 6963"},
        {"Renson", "Renson 2230"},
        {"Smithsonian Astrophysical Observation", "SAO 248389"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.41188328),
        dec: Angle.Degrees(-61.22207270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83659"},
        {"Hipparcos Number", "HIP 47241"},
        {"Smithsonian Astrophysical Observation", "SAO 250642"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.42734005),
        dec: Angle.Degrees(-61.22141606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30206"},
        {"Henry Draper 2", "HD 30206A"},
        {"Hipparcos Number", "HIP 21841"},
        {"Smithsonian Astrophysical Observation", "SAO 249080"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.43838794),
        dec: Angle.Degrees(-61.21773809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10965"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.31158912),
        dec: Angle.Degrees(-61.21738479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121253"},
        {"Hipparcos Number", "HIP 68071"},
        {"Smithsonian Astrophysical Observation", "SAO 252527"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.05979032),
        dec: Angle.Degrees(-61.21641342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 312137"},
        {"Hipparcos Number", "HIP 62919"},
        {"Geneva Identification System", "GEN# +1.00312137"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.42235598),
        dec: Angle.Degrees(-61.21586052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118609"},
        {"Hipparcos Number", "HIP 66633"},
        {"Smithsonian Astrophysical Observation", "SAO 252397"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.87173522),
        dec: Angle.Degrees(-61.21416217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208578"},
        {"Hipparcos Number", "HIP 108534"},
        {"Smithsonian Astrophysical Observation", "SAO 255118"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.80918062),
        dec: Angle.Degrees(-61.21402991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27367"},
        {"Hipparcos Number", "HIP 19858"},
        {"Smithsonian Astrophysical Observation", "SAO 248974"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.86837277),
        dec: Angle.Degrees(-61.21150134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108216",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108216"},
        {"Geneva Identification System", "GEN# -0.06106596"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.85220874),
        dec: Angle.Degrees(-61.20960592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 264.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167259"},
        {"Hipparcos Number", "HIP 89695"},
        {"Geneva Identification System", "GEN# +1.00167259"},
        {"Smithsonian Astrophysical Observation", "SAO 254199"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.57786998),
        dec: Angle.Degrees(-61.20852421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170226"},
        {"Hipparcos Number", "HIP 90876"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.06200425),
        dec: Angle.Degrees(-61.20745930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65782",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65782"},
        {"Celescope Catalog", "CEL 4260"},
        {"Geneva Identification System", "GEN# +4.21160020"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.28193438),
        dec: Angle.Degrees(-61.20397189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65786"},
        {"Geneva Identification System", "GEN# +4.21160021"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.29539471),
        dec: Angle.Degrees(-61.20032550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43124"},
        {"Smithsonian Astrophysical Observation", "SAO 250326"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.75113700),
        dec: Angle.Degrees(-61.19870506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65818"},
        {"Geneva Identification System", "GEN# +4.21160014"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.39288085),
        dec: Angle.Degrees(-61.19336110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81544"},
        {"Hipparcos Number", "HIP 46063"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.89588610),
        dec: Angle.Degrees(-61.19334217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41748"},
        {"Hipparcos Number", "HIP 28648"},
        {"Smithsonian Astrophysical Observation", "SAO 249430"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.73979951),
        dec: Angle.Degrees(-61.19324288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218040"},
        {"Hipparcos Number", "HIP 114049"},
        {"Smithsonian Astrophysical Observation", "SAO 255402"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.45577463),
        dec: Angle.Degrees(-61.19262808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88293"},
        {"Hipparcos Number", "HIP 49711"},
        {"Geneva Identification System", "GEN# +1.00088293"},
        {"Smithsonian Astrophysical Observation", "SAO 250835"},
        {"Wilson Evans Batten Catalogue", "WEB 9166"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.23035277),
        dec: Angle.Degrees(-61.19249684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21901"},
        {"Hipparcos Number", "HIP 16194"},
        {"Geneva Identification System", "GEN# +1.00021901"},
        {"Smithsonian Astrophysical Observation", "SAO 248815"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.16145666),
        dec: Angle.Degrees(-61.18953791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105194"},
        {"Hipparcos Number", "HIP 59069"},
        {"Geneva Identification System", "GEN# +2.41030008"},
        {"Smithsonian Astrophysical Observation", "SAO 251741"},
        {"New General Catalogue", "NGC 4103 8"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.70118380),
        dec: Angle.Degrees(-61.18823890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69196"},
        {"Hipparcos Number", "HIP 40182"},
        {"Geneva Identification System", "GEN# +1.00069196"},
        {"Smithsonian Astrophysical Observation", "SAO 250148"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.11757664),
        dec: Angle.Degrees(-61.18779860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203423"},
        {"Hipparcos Number", "HIP 105708"},
        {"Smithsonian Astrophysical Observation", "SAO 254996"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.15928003),
        dec: Angle.Degrees(-61.18727911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220818"},
        {"Hipparcos Number", "HIP 115792"},
        {"Geneva Identification System", "GEN# +1.00220818"},
        {"Smithsonian Astrophysical Observation", "SAO 255490"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.87180839),
        dec: Angle.Degrees(-61.18716775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101466"},
        {"Hipparcos Number", "HIP 56917"},
        {"Smithsonian Astrophysical Observation", "SAO 251526"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.02866217),
        dec: Angle.Degrees(-61.18573426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155540"},
        {"Hipparcos Number", "HIP 84472"},
        {"Smithsonian Astrophysical Observation", "SAO 253851"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.03974437),
        dec: Angle.Degrees(-61.18555443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139189"},
        {"Hipparcos Number", "HIP 76713"},
        {"Geneva Identification System", "GEN# +1.00139189"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.97478215),
        dec: Angle.Degrees(-61.18275026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -248.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104971"},
        {"Hipparcos Number", "HIP 58942"},
        {"Geneva Identification System", "GEN# +1.00104971"},
        {"Smithsonian Astrophysical Observation", "SAO 251727"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.28594082),
        dec: Angle.Degrees(-61.17952881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102350"},
        {"Hipparcos Number", "HIP 57439"},
        {"Fundamental Katalog 5th Edition", "FK5 443"},
        {"Geneva Identification System", "GEN# +1.00102350"},
        {"Smithsonian Astrophysical Observation", "SAO 251579"},
        {"Wilson Evans Batten Catalogue", "WEB 10318"},
    },
    visualMagnitude: 4.11,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.62853753),
        dec: Angle.Degrees(-61.17835907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41853"},
        {"Smithsonian Astrophysical Observation", "SAO 250261"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.00518021),
        dec: Angle.Degrees(-61.17808311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174042"},
        {"Hipparcos Number", "HIP 92627"},
        {"Smithsonian Astrophysical Observation", "SAO 254396"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.10565816),
        dec: Angle.Degrees(-61.17619058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37501"},
        {"Hipparcos Number", "HIP 26190"},
        {"Geneva Identification System", "GEN# +1.00037501"},
        {"Smithsonian Astrophysical Observation", "SAO 249314"},
        {"Wilson Evans Batten Catalogue", "WEB 5109"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.73934029),
        dec: Angle.Degrees(-61.17598319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24176"},
        {"Hipparcos Number", "HIP 17703"},
        {"Smithsonian Astrophysical Observation", "SAO 248887"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.87107909),
        dec: Angle.Degrees(-61.17476025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47567"},
        {"Hipparcos Number", "HIP 31430"},
        {"Geneva Identification System", "GEN# +1.00047567"},
        {"Smithsonian Astrophysical Observation", "SAO 249594"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.78844819),
        dec: Angle.Degrees(-61.17330904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93010B"},
        {"Hipparcos Number", "HIP 52437"},
        {"Smithsonian Astrophysical Observation", "SAO 251086"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.79005432),
        dec: Angle.Degrees(-61.17196435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187653"},
        {"Hipparcos Number", "HIP 97971"},
        {"Fundamental Katalog 5th Edition", "FK5 1518"},
        {"Geneva Identification System", "GEN# +1.00187653"},
        {"Smithsonian Astrophysical Observation", "SAO 254683"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.66854596),
        dec: Angle.Degrees(-61.17081500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65578"},
        {"Hipparcos Number", "HIP 38739"},
        {"Geneva Identification System", "GEN# +2.25160116"},
        {"Smithsonian Astrophysical Observation", "SAO 250015"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.96093209),
        dec: Angle.Degrees(-61.16922569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93010"},
        {"Hipparcos Number", "HIP 52436"},
        {"Celescope Catalog", "CEL 3666"},
        {"Geneva Identification System", "GEN# +1.00093010A"},
        {"Smithsonian Astrophysical Observation", "SAO 251085"},
        {"Wilson Evans Batten Catalogue", "WEB 9549"},
    },
    visualMagnitude: 6.62,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.78934854),
        dec: Angle.Degrees(-61.16854085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35358"},
        {"Hipparcos Number", "HIP 24893"},
        {"Smithsonian Astrophysical Observation", "SAO 249250"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.03541452),
        dec: Angle.Degrees(-61.16813538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38004"},
        {"Hipparcos Number", "HIP 26523"},
        {"Smithsonian Astrophysical Observation", "SAO 249327"},
    },
    visualMagnitude: 8.08,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.61035548),
        dec: Angle.Degrees(-61.16707732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52380",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52380"},
        {"Wilson Evans Batten Catalogue", "WEB 9534"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.59600084),
        dec: Angle.Degrees(-61.16592355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64141"},
        {"Hipparcos Number", "HIP 38127"},
        {"Geneva Identification System", "GEN# +1.00064141"},
        {"Smithsonian Astrophysical Observation", "SAO 249971"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.19879831),
        dec: Angle.Degrees(-61.16277661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103052"},
        {"Hipparcos Number", "HIP 57843"},
        {"Smithsonian Astrophysical Observation", "SAO 251615"},
    },
    visualMagnitude: 8.17,
    bvColour: 2.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.92892967),
        dec: Angle.Degrees(-61.15844290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149668"},
        {"Hipparcos Number", "HIP 81604"},
        {"Smithsonian Astrophysical Observation", "SAO 253643"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.98509505),
        dec: Angle.Degrees(-61.15782607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143639"},
        {"Hipparcos Number", "HIP 78799"},
        {"Smithsonian Astrophysical Observation", "SAO 253416"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.29757770),
        dec: Angle.Degrees(-61.15416972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181651"},
        {"Hipparcos Number", "HIP 95449"},
        {"Smithsonian Astrophysical Observation", "SAO 254565"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.24709578),
        dec: Angle.Degrees(-61.15377005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6685"},
        {"Hipparcos Number", "HIP 5192"},
        {"Smithsonian Astrophysical Observation", "SAO 248320"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.60995842),
        dec: Angle.Degrees(-61.15367860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92490"},
        {"Hipparcos Number", "HIP 52157"},
        {"Geneva Identification System", "GEN# +1.00092490"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.83473638),
        dec: Angle.Degrees(-61.15244919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19801"},
        {"Hipparcos Number", "HIP 14571"},
        {"Smithsonian Astrophysical Observation", "SAO 248740"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.03435765),
        dec: Angle.Degrees(-61.14993003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110477"},
        {"Hipparcos Number", "HIP 62043"},
        {"Geneva Identification System", "GEN# +1.00110477"},
        {"Smithsonian Astrophysical Observation", "SAO 252005"},
        {"Wilson Evans Batten Catalogue", "WEB 11030"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.76492977),
        dec: Angle.Degrees(-61.14876901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -181.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3093"},
        {"Hipparcos Number", "HIP 2646"},
        {"Smithsonian Astrophysical Observation", "SAO 248212"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.38531173),
        dec: Angle.Degrees(-61.14724805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208154"},
        {"Hipparcos Number", "HIP 108312"},
        {"Smithsonian Astrophysical Observation", "SAO 255106"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.14230503),
        dec: Angle.Degrees(-61.14601133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57919"},
        {"Hipparcos Number", "HIP 35497"},
        {"Smithsonian Astrophysical Observation", "SAO 249822"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.88465610),
        dec: Angle.Degrees(-61.14499827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13619"},
        {"Hipparcos Number", "HIP 10163"},
        {"Smithsonian Astrophysical Observation", "SAO 248507"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.67035763),
        dec: Angle.Degrees(-61.14396067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93844"},
        {"Hipparcos Number", "HIP 52861"},
        {"Celescope Catalog", "CEL 3722"},
        {"Geneva Identification System", "GEN# +1.00093844"},
        {"Smithsonian Astrophysical Observation", "SAO 251134"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.16236042),
        dec: Angle.Degrees(-61.14375263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53327"},
        {"Hipparcos Number", "HIP 33761"},
        {"Smithsonian Astrophysical Observation", "SAO 249706"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.17999781),
        dec: Angle.Degrees(-61.14184835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139371"},
        {"Hipparcos Number", "HIP 76807"},
        {"Smithsonian Astrophysical Observation", "SAO 253252"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.23845969),
        dec: Angle.Degrees(-61.14103811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101629"},
        {"Hipparcos Number", "HIP 57004"},
        {"Smithsonian Astrophysical Observation", "SAO 251540"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.29394546),
        dec: Angle.Degrees(-61.14099770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222856"},
        {"Hipparcos Number", "HIP 117108"},
        {"Smithsonian Astrophysical Observation", "SAO 255559"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.12158732),
        dec: Angle.Degrees(-61.13991939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107097"},
        {"Hipparcos Number", "HIP 60078"},
        {"Celescope Catalog", "CEL 4090"},
        {"Geneva Identification System", "GEN# +1.00107097"},
        {"Smithsonian Astrophysical Observation", "SAO 251844"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.79794201),
        dec: Angle.Degrees(-61.13633136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223470"},
        {"Hipparcos Number", "HIP 117520"},
        {"Smithsonian Astrophysical Observation", "SAO 255580"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.49247424),
        dec: Angle.Degrees(-61.13536329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204533"},
        {"Hipparcos Number", "HIP 106300"},
        {"Smithsonian Astrophysical Observation", "SAO 255015"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.94751703),
        dec: Angle.Degrees(-61.13472834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83488"},
        {"Hipparcos Number", "HIP 47137"},
        {"Celescope Catalog", "CEL 3341"},
        {"Geneva Identification System", "GEN# +1.00083488"},
        {"Smithsonian Astrophysical Observation", "SAO 250637"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.08153591),
        dec: Angle.Degrees(-61.13262081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202968"},
        {"Hipparcos Number", "HIP 105479"},
        {"Smithsonian Astrophysical Observation", "SAO 254986"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.46041017),
        dec: Angle.Degrees(-61.13131712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106590"},
        {"Hipparcos Number", "HIP 59799"},
        {"Geneva Identification System", "GEN# +1.00106590"},
        {"Smithsonian Astrophysical Observation", "SAO 251816"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.93863018),
        dec: Angle.Degrees(-61.12992780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151065"},
        {"Hipparcos Number", "HIP 82290"},
        {"Smithsonian Astrophysical Observation", "SAO 253704"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.21646996),
        dec: Angle.Degrees(-61.12943642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133557"},
        {"Hipparcos Number", "HIP 74044"},
        {"Geneva Identification System", "GEN# +1.00133557"},
        {"Smithsonian Astrophysical Observation", "SAO 253025"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.98396597),
        dec: Angle.Degrees(-61.12865899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213671"},
        {"Hipparcos Number", "HIP 111453"},
        {"Smithsonian Astrophysical Observation", "SAO 255256"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.67479987),
        dec: Angle.Degrees(-61.12496164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103859"},
        {"Hipparcos Number", "HIP 58307"},
        {"Smithsonian Astrophysical Observation", "SAO 251657"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.35805592),
        dec: Angle.Degrees(-61.12342794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135241"},
        {"Hipparcos Number", "HIP 74784"},
        {"Geneva Identification System", "GEN# +1.00135241"},
        {"Smithsonian Astrophysical Observation", "SAO 253085"},
    },
    visualMagnitude: 8.12,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.24960543),
        dec: Angle.Degrees(-61.12058953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114489"},
        {"Hipparcos Number", "HIP 64398"},
        {"Geneva Identification System", "GEN# +1.00114489"},
        {"Smithsonian Astrophysical Observation", "SAO 252189"},
        {"Wilson Evans Batten Catalogue", "WEB 11379"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.98151003),
        dec: Angle.Degrees(-61.11732927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99556"},
        {"Hipparcos Number", "HIP 55831"},
        {"Geneva Identification System", "GEN# +1.00099556"},
        {"Smithsonian Astrophysical Observation", "SAO 251406"},
        {"Wilson Evans Batten Catalogue", "WEB 10036"},
    },
    visualMagnitude: 5.22,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.64764356),
        dec: Angle.Degrees(-61.11517130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176225"},
        {"Hipparcos Number", "HIP 93545"},
        {"Geneva Identification System", "GEN# +1.00176225"},
        {"Smithsonian Astrophysical Observation", "SAO 254449"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.78845622),
        dec: Angle.Degrees(-61.11448501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89683"},
        {"Hipparcos Number", "HIP 50531"},
        {"Celescope Catalog", "CEL 3502"},
        {"Smithsonian Astrophysical Observation", "SAO 250919"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.81217056),
        dec: Angle.Degrees(-61.10808772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32384"},
        {"Hipparcos Number", "HIP 23157"},
        {"Geneva Identification System", "GEN# +1.00032384"},
        {"Smithsonian Astrophysical Observation", "SAO 249158"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.72903582),
        dec: Angle.Degrees(-61.10636431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142698"},
        {"Hipparcos Number", "HIP 78312"},
        {"Smithsonian Astrophysical Observation", "SAO 253366"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.85233743),
        dec: Angle.Degrees(-61.10539480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65663"},
        {"Hipparcos Number", "HIP 38779"},
        {"Geneva Identification System", "GEN# +2.25160120"},
        {"Smithsonian Astrophysical Observation", "SAO 250018"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.06573292),
        dec: Angle.Degrees(-61.09946520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104722"},
        {"Hipparcos Number", "HIP 58794"},
        {"Geneva Identification System", "GEN# +1.00104722"},
        {"Smithsonian Astrophysical Observation", "SAO 251711"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.88606532),
        dec: Angle.Degrees(-61.09829817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13570"},
        {"Hipparcos Number", "HIP 10127"},
        {"Smithsonian Astrophysical Observation", "SAO 248505"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.56443468),
        dec: Angle.Degrees(-61.09697673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160909"},
        {"Hipparcos Number", "HIP 86972"},
        {"Smithsonian Astrophysical Observation", "SAO 254024"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.61059780),
        dec: Angle.Degrees(-61.09521889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172630"},
        {"Hipparcos Number", "HIP 92008"},
        {"Geneva Identification System", "GEN# +1.00172630"},
        {"Smithsonian Astrophysical Observation", "SAO 254359"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.29791008),
        dec: Angle.Degrees(-61.09513879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 304622"},
        {"Hipparcos Number", "HIP 45120"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.87372720),
        dec: Angle.Degrees(-61.09489059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 136.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81404"},
        {"Hipparcos Number", "HIP 45997"},
        {"Geneva Identification System", "GEN# +1.00081404"},
        {"Smithsonian Astrophysical Observation", "SAO 250558"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.71106444),
        dec: Angle.Degrees(-61.09301822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72287"},
        {"Hipparcos Number", "HIP 41591"},
        {"Smithsonian Astrophysical Observation", "SAO 250240"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.18594729),
        dec: Angle.Degrees(-61.09264340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30253"},
        {"Hipparcos Number", "HIP 21867"},
        {"Smithsonian Astrophysical Observation", "SAO 249081"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.52390594),
        dec: Angle.Degrees(-61.09250783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17452"},
        {"Hipparcos Number", "HIP 12854"},
        {"Smithsonian Astrophysical Observation", "SAO 248641"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.31616349),
        dec: Angle.Degrees(-61.08968347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83944"},
    },
    visualMagnitude: 12.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.37626919),
        dec: Angle.Degrees(-61.08949381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85407",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85407"},
    },
    visualMagnitude: 11.24,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.79764538),
        dec: Angle.Degrees(-61.08802556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87987"},
        {"Hipparcos Number", "HIP 49525"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.68227190),
        dec: Angle.Degrees(-61.08689140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98194"},
        {"Hipparcos Number", "HIP 55098"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.21216488),
        dec: Angle.Degrees(-61.08555370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61267"},
        {"Hipparcos Number", "HIP 36861"},
        {"Smithsonian Astrophysical Observation", "SAO 249884"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.67650450),
        dec: Angle.Degrees(-61.08282611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9196"},
        {"Hipparcos Number", "HIP 6910"},
        {"Smithsonian Astrophysical Observation", "SAO 248388"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.25276863),
        dec: Angle.Degrees(-61.08270708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7459"},
        {"Geneva Identification System", "GEN# -0.06100122"},
        {"Wilson Evans Batten Catalogue", "WEB 1599"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.02476974),
        dec: Angle.Degrees(-61.08266183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -675.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125206"},
        {"Hipparcos Number", "HIP 70052"},
        {"Geneva Identification System", "GEN# +1.00125206"},
        {"Smithsonian Astrophysical Observation", "SAO 252705"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.03769245),
        dec: Angle.Degrees(-61.08183444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213849"},
        {"Hipparcos Number", "HIP 111547"},
        {"Smithsonian Astrophysical Observation", "SAO 255260"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.96994841),
        dec: Angle.Degrees(-61.07944739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25728"},
        {"Hipparcos Number", "HIP 18772"},
        {"Geneva Identification System", "GEN# +1.00025728"},
        {"Smithsonian Astrophysical Observation", "SAO 248927"},
        {"Wilson Evans Batten Catalogue", "WEB 3615"},
    },
    visualMagnitude: 4.97,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.32529605),
        dec: Angle.Degrees(-61.07905148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100137"},
        {"Hipparcos Number", "HIP 56162"},
        {"Smithsonian Astrophysical Observation", "SAO 251432"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.69239318),
        dec: Angle.Degrees(-61.07840357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34476"},
        {"Hipparcos Number", "HIP 24359"},
        {"Smithsonian Astrophysical Observation", "SAO 249220"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.39940083),
        dec: Angle.Degrees(-61.07831373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39827"},
        {"Smithsonian Astrophysical Observation", "SAO 250121"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.05971011),
        dec: Angle.Degrees(-61.07751451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 190.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68279"},
        {"Hipparcos Number", "HIP 39825"},
        {"Geneva Identification System", "GEN# +1.00068279"},
        {"Smithsonian Astrophysical Observation", "SAO 250120"},
        {"Wilson Evans Batten Catalogue", "WEB 7765"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.05380915),
        dec: Angle.Degrees(-61.07722334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5220"},
        {"Hipparcos Number", "HIP 4149"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.25267793),
        dec: Angle.Degrees(-61.07700191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112027"},
        {"Hipparcos Number", "HIP 62982"},
        {"Geneva Identification System", "GEN# +1.00112027"},
        {"Smithsonian Astrophysical Observation", "SAO 252084"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.57480208),
        dec: Angle.Degrees(-61.07684672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131217"},
        {"Hipparcos Number", "HIP 72989"},
        {"Smithsonian Astrophysical Observation", "SAO 252955"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.73727510),
        dec: Angle.Degrees(-61.07583210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106169"},
        {"Hipparcos Number", "HIP 59583"},
        {"Geneva Identification System", "GEN# +1.00106169"},
        {"Smithsonian Astrophysical Observation", "SAO 251794"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.28104305),
        dec: Angle.Degrees(-61.07414731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89991"},
        {"Hipparcos Number", "HIP 50722"},
        {"Geneva Identification System", "GEN# +1.00089991"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.34576200),
        dec: Angle.Degrees(-61.07410341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98927"},
        {"Hipparcos Number", "HIP 55524"},
        {"Celescope Catalog", "CEL 3886"},
        {"Geneva Identification System", "GEN# +1.00098927"},
        {"Smithsonian Astrophysical Observation", "SAO 251374"},
        {"Wilson Evans Batten Catalogue", "WEB 9982"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.58221220),
        dec: Angle.Degrees(-61.07347513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200889"},
        {"Hipparcos Number", "HIP 104402"},
        {"Smithsonian Astrophysical Observation", "SAO 254945"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.25606734),
        dec: Angle.Degrees(-61.07215848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56737"},
        {"Hipparcos Number", "HIP 34992"},
        {"Fundamental Katalog 5th Edition", "FK5 2560"},
        {"Geneva Identification System", "GEN# +1.00056737"},
        {"Smithsonian Astrophysical Observation", "SAO 249792"},
        {"Wilson Evans Batten Catalogue", "WEB 6998"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.59433895),
        dec: Angle.Degrees(-61.06983016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111303"},
        {"Hipparcos Number", "HIP 62564"},
        {"Geneva Identification System", "GEN# +1.00111303"},
        {"Smithsonian Astrophysical Observation", "SAO 252039"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.28000689),
        dec: Angle.Degrees(-61.06673570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116875"},
        {"Hipparcos Number", "HIP 65681"},
        {"Celescope Catalog", "CEL 4259"},
        {"Geneva Identification System", "GEN# +1.00116875"},
        {"Geneva Identification System 2", "GEN# +4.21160080"},
        {"Smithsonian Astrophysical Observation", "SAO 252317"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.00629611),
        dec: Angle.Degrees(-61.06250036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16347"},
        {"Hipparcos Number", "HIP 12007"},
        {"Smithsonian Astrophysical Observation", "SAO 248602"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.69788217),
        dec: Angle.Degrees(-61.06222457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222617"},
        {"Hipparcos Number", "HIP 116955"},
        {"Smithsonian Astrophysical Observation", "SAO 255548"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.60697888),
        dec: Angle.Degrees(-61.06181622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186837"},
        {"Hipparcos Number", "HIP 97611"},
        {"Geneva Identification System", "GEN# +1.00186837"},
        {"Smithsonian Astrophysical Observation", "SAO 254666"},
        {"Wilson Evans Batten Catalogue", "WEB 17164"},
    },
    visualMagnitude: 6.21,
    bvColour: -0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.59063450),
        dec: Angle.Degrees(-61.06113281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18964"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.95378008),
        dec: Angle.Degrees(-61.05627042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 151.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54171",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54171"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)04, 53.0100),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)03, 22.300)
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
    primaryId: "HIP 112794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216012"},
        {"Hipparcos Number", "HIP 112794"},
        {"Smithsonian Astrophysical Observation", "SAO 255331"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.62205968),
        dec: Angle.Degrees(-61.05562235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112497"},
        {"Hipparcos Number", "HIP 63277"},
        {"Geneva Identification System", "GEN# +1.00112497"},
        {"Smithsonian Astrophysical Observation", "SAO 252111"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.50408662),
        dec: Angle.Degrees(-61.05531861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65094"},
        {"Hipparcos Number", "HIP 38536"},
        {"Smithsonian Astrophysical Observation", "SAO 249995"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.37185944),
        dec: Angle.Degrees(-61.05451377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100929"},
        {"Hipparcos Number", "HIP 56606"},
        {"Celescope Catalog", "CEL 3924"},
        {"Geneva Identification System", "GEN# +1.00100929"},
        {"Smithsonian Astrophysical Observation", "SAO 251479"},
        {"Wilson Evans Batten Catalogue", "WEB 10176"},
    },
    visualMagnitude: 5.84,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.09325391),
        dec: Angle.Degrees(-61.05243721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96264"},
        {"Hipparcos Number", "HIP 54175"},
        {"Celescope Catalog", "CEL 3796"},
        {"Smithsonian Astrophysical Observation", "SAO 251253"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.23128910),
        dec: Angle.Degrees(-61.05161185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3426"},
        {"Hipparcos Number", "HIP 2881"},
        {"Smithsonian Astrophysical Observation", "SAO 248223"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.12614470),
        dec: Angle.Degrees(-61.04759460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19387"},
        {"Hipparcos Number", "HIP 14283"},
        {"Geneva Identification System", "GEN# +1.00019387"},
        {"Smithsonian Astrophysical Observation", "SAO 248722"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.03418322),
        dec: Angle.Degrees(-61.04637888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102399"},
        {"Hipparcos Number", "HIP 57474"},
        {"Celescope Catalog", "CEL 3979"},
        {"Geneva Identification System", "GEN# +1.00102399"},
        {"Smithsonian Astrophysical Observation", "SAO 251585"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.71859455),
        dec: Angle.Degrees(-61.04112274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20786"},
        {"Hipparcos Number", "HIP 15347"},
        {"Smithsonian Astrophysical Observation", "SAO 248772"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.47097801),
        dec: Angle.Degrees(-61.04093584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84793"},
        {"Hipparcos Number", "HIP 47864"},
        {"Smithsonian Astrophysical Observation", "SAO 250684"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.33025998),
        dec: Angle.Degrees(-61.03898652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217060"},
        {"Hipparcos Number", "HIP 113479"},
        {"Smithsonian Astrophysical Observation", "SAO 255361"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.72560452),
        dec: Angle.Degrees(-61.03744379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125464"},
        {"Hipparcos Number", "HIP 70206"},
        {"Geneva Identification System", "GEN# +1.00125464"},
        {"Smithsonian Astrophysical Observation", "SAO 252719"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.46203180),
        dec: Angle.Degrees(-61.03658623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1860"},
        {"Hipparcos Number", "HIP 1777"},
        {"Smithsonian Astrophysical Observation", "SAO 248174"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.64202547),
        dec: Angle.Degrees(-61.03487546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3856"},
    },
    visualMagnitude: 13.26,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)49, 32.4600),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)01, 47.600)
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
    primaryId: "HIP 59769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106521"},
        {"Hipparcos Number", "HIP 59769"},
        {"Geneva Identification System", "GEN# +1.00106521"},
        {"Smithsonian Astrophysical Observation", "SAO 251812"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.83879962),
        dec: Angle.Degrees(-61.02983925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 306387"},
        {"Henry Draper 2", "HD 306387A"},
        {"Hipparcos Number", "HIP 55499"},
        {"Geneva Identification System", "GEN# +1.00306387"},
        {"Wilson Evans Batten Catalogue", "WEB 9981"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.49488452),
        dec: Angle.Degrees(-61.02938690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120861"},
        {"Hipparcos Number", "HIP 67844"},
        {"Geneva Identification System", "GEN# +1.00120861J"},
        {"Smithsonian Astrophysical Observation", "SAO 252506"},
        {"Wilson Evans Batten Catalogue", "WEB 11926"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.45813451),
        dec: Angle.Degrees(-61.02697181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78191"},
        {"Hipparcos Number", "HIP 44507"},
        {"Smithsonian Astrophysical Observation", "SAO 250427"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.00991467),
        dec: Angle.Degrees(-61.02059292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168759"},
        {"Hipparcos Number", "HIP 90280"},
        {"Smithsonian Astrophysical Observation", "SAO 254236"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.31215686),
        dec: Angle.Degrees(-61.01878886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10840"},
        {"Hipparcos Number", "HIP 8132"},
        {"Geneva Identification System", "GEN# +1.00010840"},
        {"Renson", "Renson 2700"},
        {"Smithsonian Astrophysical Observation", "SAO 248427"},
    },
    visualMagnitude: 6.79,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.13724307),
        dec: Angle.Degrees(-61.01869036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110390"},
        {"Hipparcos Number", "HIP 62002"},
        {"Celescope Catalog", "CEL 4143"},
        {"Geneva Identification System", "GEN# +1.00110390"},
        {"Smithsonian Astrophysical Observation", "SAO 252000"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.61353668),
        dec: Angle.Degrees(-61.01847940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103213"},
        {"Hipparcos Number", "HIP 57934"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.22525551),
        dec: Angle.Degrees(-61.01773683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220358"},
        {"Hipparcos Number", "HIP 115488"},
        {"Smithsonian Astrophysical Observation", "SAO 255480"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.91719468),
        dec: Angle.Degrees(-61.01729614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112536"},
        {"Hipparcos Number", "HIP 63299"},
        {"Geneva Identification System", "GEN# +1.00112536"},
        {"Smithsonian Astrophysical Observation", "SAO 252112"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.58023093),
        dec: Angle.Degrees(-61.01729230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22382"},
        {"Hipparcos Number", "HIP 16531"},
        {"Fundamental Katalog 5th Edition", "FK5 2256"},
        {"Geneva Identification System", "GEN# +1.00022382"},
        {"Smithsonian Astrophysical Observation", "SAO 248834"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.21443520),
        dec: Angle.Degrees(-61.01698766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11400"},
        {"Hipparcos Number", "HIP 8546"},
        {"Smithsonian Astrophysical Observation", "SAO 248446"},
    },
    visualMagnitude: 9.84,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.55783030),
        dec: Angle.Degrees(-61.01396919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 305394"},
        {"Hipparcos Number", "HIP 51909"},
        {"Geneva Identification System", "GEN# +1.00305394"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.07429536),
        dec: Angle.Degrees(-61.01257600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115361"},
        {"Hipparcos Number", "HIP 64877"},
        {"Geneva Identification System", "GEN# +1.00115361"},
        {"Smithsonian Astrophysical Observation", "SAO 252249"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.48109072),
        dec: Angle.Degrees(-61.01074512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7528"},
        {"Hipparcos Number", "HIP 5766"},
        {"Geneva Identification System", "GEN# +1.00007528"},
        {"Smithsonian Astrophysical Observation", "SAO 248338"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.51428669),
        dec: Angle.Degrees(-61.00935446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46437"},
        {"Hipparcos Number", "HIP 30916"},
        {"Geneva Identification System", "GEN# +1.00046437"},
        {"Smithsonian Astrophysical Observation", "SAO 249561"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.32906876),
        dec: Angle.Degrees(-61.00607614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219631"},
        {"Hipparcos Number", "HIP 115043"},
        {"Geneva Identification System", "GEN# +1.00219631"},
        {"Smithsonian Astrophysical Observation", "SAO 255453"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.50305863),
        dec: Angle.Degrees(-61.00344429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8476"},
        {"Hipparcos Number", "HIP 6424"},
        {"Smithsonian Astrophysical Observation", "SAO 248373"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.61515816),
        dec: Angle.Degrees(-61.00315421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205169"},
        {"Hipparcos Number", "HIP 106638"},
        {"Smithsonian Astrophysical Observation", "SAO 255032"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.99533065),
        dec: Angle.Degrees(-61.00270386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 312242"},
        {"Hipparcos Number", "HIP 63273"},
        {"Celescope Catalog", "CEL 4181"},
        {"Geneva Identification System", "GEN# +1.00312242"},
        {"Smithsonian Astrophysical Observation", "SAO 252110"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.49390759),
        dec: Angle.Degrees(-60.99915567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10472"},
        {"Hipparcos Number", "HIP 7805"},
        {"Geneva Identification System", "GEN# +1.00010472"},
        {"Smithsonian Astrophysical Observation", "SAO 248416"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.09996775),
        dec: Angle.Degrees(-60.99903796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219621"},
        {"Hipparcos Number", "HIP 115034"},
        {"Geneva Identification System", "GEN# +1.00219621"},
        {"Smithsonian Astrophysical Observation", "SAO 255452"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.47702065),
        dec: Angle.Degrees(-60.99813699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183121"},
        {"Hipparcos Number", "HIP 96040"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.92281331),
        dec: Angle.Degrees(-60.99472205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59532"},
        {"Hipparcos Number", "HIP 36133"},
        {"Smithsonian Astrophysical Observation", "SAO 249853"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.64712750),
        dec: Angle.Degrees(-60.99439421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149485"},
        {"Hipparcos Number", "HIP 81507"},
        {"Geneva Identification System", "GEN# +1.00149485"},
        {"Smithsonian Astrophysical Observation", "SAO 253638"},
    },
    visualMagnitude: 6.16,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.71961792),
        dec: Angle.Degrees(-60.99031813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108773"},
        {"Hipparcos Number", "HIP 61019"},
        {"Geneva Identification System", "GEN# +1.00108773"},
        {"Smithsonian Astrophysical Observation", "SAO 251934"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.58142239),
        dec: Angle.Degrees(-60.98989150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116087"},
        {"Hipparcos Number", "HIP 65271"},
        {"Celescope Catalog", "CEL 4245"},
        {"Fundamental Katalog 5th Edition", "FK5 1347"},
        {"Geneva Identification System", "GEN# +1.00116087"},
        {"Smithsonian Astrophysical Observation", "SAO 252284"},
        {"Wilson Evans Batten Catalogue", "WEB 11519"},
    },
    visualMagnitude: 4.52,
    bvColour: -0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.65824899),
        dec: Angle.Degrees(-60.98835608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118968"},
        {"Hipparcos Number", "HIP 66838"},
        {"Smithsonian Astrophysical Observation", "SAO 252416"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.47825536),
        dec: Angle.Degrees(-60.98763913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91767"},
        {"Hipparcos Number", "HIP 51732"},
        {"Geneva Identification System", "GEN# +1.00091767"},
        {"Smithsonian Astrophysical Observation", "SAO 251014"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.55300893),
        dec: Angle.Degrees(-60.98762873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202327"},
        {"Hipparcos Number", "HIP 105127"},
        {"Smithsonian Astrophysical Observation", "SAO 254965"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.42537936),
        dec: Angle.Degrees(-60.98593387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118571"},
        {"Hipparcos Number", "HIP 66614"},
        {"Celescope Catalog", "CEL 4273"},
        {"Geneva Identification System", "GEN# +1.00118571"},
        {"Smithsonian Astrophysical Observation", "SAO 252396"},
        {"Wilson Evans Batten Catalogue", "WEB 11752"},
    },
    visualMagnitude: 8.80,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.81533932),
        dec: Angle.Degrees(-60.98388477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13242"},
        {"Hipparcos Number", "HIP 9885"},
        {"Geneva Identification System", "GEN# +1.00013242"},
        {"Smithsonian Astrophysical Observation", "SAO 248495"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.79745582),
        dec: Angle.Degrees(-60.98339670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101119"},
        {"Hipparcos Number", "HIP 56711"},
        {"Celescope Catalog", "CEL 3931"},
        {"Geneva Identification System", "GEN# +1.00101119"},
        {"Smithsonian Astrophysical Observation", "SAO 251498"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.40801853),
        dec: Angle.Degrees(-60.98315200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16241"},
        {"Hipparcos Number", "HIP 11919"},
        {"Geneva Identification System", "GEN# +1.00016241"},
        {"Smithsonian Astrophysical Observation", "SAO 248598"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.46349183),
        dec: Angle.Degrees(-60.98273933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87192"},
        {"Hipparcos Number", "HIP 49101"},
        {"Smithsonian Astrophysical Observation", "SAO 250779"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.31995555),
        dec: Angle.Degrees(-60.98208879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110829"},
        {"Hipparcos Number", "HIP 62268"},
        {"Geneva Identification System", "GEN# +1.00110829A"},
        {"Smithsonian Astrophysical Observation", "SAO 252016"},
        {"Wilson Evans Batten Catalogue", "WEB 11060"},
    },
    visualMagnitude: 4.69,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.40798434),
        dec: Angle.Degrees(-60.98116057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 305996"},
        {"Hipparcos Number", "HIP 54101"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.05617110),
        dec: Angle.Degrees(-60.97993249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224149"},
        {"Hipparcos Number", "HIP 117968"},
        {"Smithsonian Astrophysical Observation", "SAO 255601"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.91849695),
        dec: Angle.Degrees(-60.97965826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97152"},
        {"Hipparcos Number", "HIP 54574"},
        {"Celescope Catalog", "CEL 3829"},
        {"Geneva Identification System", "GEN# +1.00097152"},
        {"Smithsonian Astrophysical Observation", "SAO 251296"},
        {"Wilson Evans Batten Catalogue", "WEB 9849"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.51703134),
        dec: Angle.Degrees(-60.97915858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80727"},
        {"Hipparcos Number", "HIP 45677"},
        {"Geneva Identification System", "GEN# +1.00080727"},
        {"Smithsonian Astrophysical Observation", "SAO 250533"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.67725539),
        dec: Angle.Degrees(-60.97801963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107345",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107345"},
        {"Geneva Identification System", "GEN# +6.20145086"},
    },
    visualMagnitude: 11.72,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.12530288),
        dec: Angle.Degrees(-60.97724408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126358"},
        {"Hipparcos Number", "HIP 70673"},
        {"Geneva Identification System", "GEN# +1.00126358"},
        {"Smithsonian Astrophysical Observation", "SAO 252749"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.82654901),
        dec: Angle.Degrees(-60.97378359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104933"},
        {"Hipparcos Number", "HIP 58921"},
        {"Geneva Identification System", "GEN# +1.00104933"},
        {"Smithsonian Astrophysical Observation", "SAO 251723"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.23852543),
        dec: Angle.Degrees(-60.96823848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85567"},
        {"Hipparcos Number", "HIP 48269"},
        {"Geneva Identification System", "GEN# +1.00085567"},
        {"Smithsonian Astrophysical Observation", "SAO 250716"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.61894987),
        dec: Angle.Degrees(-60.96750198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56319"},
        {"Hipparcos Number", "HIP 34850"},
        {"Smithsonian Astrophysical Observation", "SAO 249779"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.18485869),
        dec: Angle.Degrees(-60.96708975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64653"},
        {"Geneva Identification System", "GEN# -0.06004551"},
        {"Smithsonian Astrophysical Observation", "SAO 252226"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.79171005),
        dec: Angle.Degrees(-60.96686938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9962"},
        {"Hipparcos Number", "HIP 7433"},
        {"Smithsonian Astrophysical Observation", "SAO 248407"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.93476929),
        dec: Angle.Degrees(-60.96658281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22999"},
        {"Hipparcos Number", "HIP 16963"},
        {"Smithsonian Astrophysical Observation", "SAO 248857"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.55642207),
        dec: Angle.Degrees(-60.96572745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174365"},
        {"Hipparcos Number", "HIP 92744"},
        {"Smithsonian Astrophysical Observation", "SAO 254405"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.49512565),
        dec: Angle.Degrees(-60.96488717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77615"},
        {"Hipparcos Number", "HIP 44256"},
        {"Geneva Identification System", "GEN# +1.00077615"},
        {"Smithsonian Astrophysical Observation", "SAO 250417"},
    },
    visualMagnitude: 5.80,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.19061260),
        dec: Angle.Degrees(-60.96384715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58999",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58999"},
    },
    visualMagnitude: 12.41,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)05, 49.9400),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)57, 35.100)
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
    primaryId: "HIP 74778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135240"},
        {"Hipparcos Number", "HIP 74778"},
        {"Geneva Identification System", "GEN# +1.00135240A"},
        {"Smithsonian Astrophysical Observation", "SAO 253084"},
        {"Wilson Evans Batten Catalogue", "WEB 12756"},
    },
    visualMagnitude: 5.04,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.23707633),
        dec: Angle.Degrees(-60.95724479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152388"},
        {"Hipparcos Number", "HIP 82930"},
        {"Geneva Identification System", "GEN# +1.00152388"},
        {"Smithsonian Astrophysical Observation", "SAO 253747"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.21734440),
        dec: Angle.Degrees(-60.95695461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155624"},
        {"Hipparcos Number", "HIP 84519"},
        {"Smithsonian Astrophysical Observation", "SAO 253854"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.16215021),
        dec: Angle.Degrees(-60.95626684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200592"},
        {"Hipparcos Number", "HIP 104231"},
        {"Smithsonian Astrophysical Observation", "SAO 254938"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.77960536),
        dec: Angle.Degrees(-60.95289278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27463"},
        {"Hipparcos Number", "HIP 19917"},
        {"Geneva Identification System", "GEN# +1.00027463"},
        {"Renson", "Renson 7050"},
        {"Smithsonian Astrophysical Observation", "SAO 248977"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.08717814),
        dec: Angle.Degrees(-60.94854291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156871"},
        {"Hipparcos Number", "HIP 85131"},
        {"Smithsonian Astrophysical Observation", "SAO 253904"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.97407797),
        dec: Angle.Degrees(-60.94426143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181793"},
        {"Hipparcos Number", "HIP 95502"},
        {"Renson", "Renson 50320"},
        {"Smithsonian Astrophysical Observation", "SAO 254567"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.37356762),
        dec: Angle.Degrees(-60.94098356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159493"},
        {"Hipparcos Number", "HIP 86378"},
        {"Renson", "Renson 44870"},
        {"Smithsonian Astrophysical Observation", "SAO 253987"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.76661974),
        dec: Angle.Degrees(-60.94016046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94777"},
        {"Hipparcos Number", "HIP 53397"},
        {"Geneva Identification System", "GEN# +1.00094777"},
        {"Wilson Evans Batten Catalogue", "WEB 9692"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.82806003),
        dec: Angle.Degrees(-60.93999171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184101"},
        {"Hipparcos Number", "HIP 96445"},
        {"Smithsonian Astrophysical Observation", "SAO 254608"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.12729939),
        dec: Angle.Degrees(-60.93998465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113991"},
        {"Hipparcos Number", "HIP 64121"},
        {"Geneva Identification System", "GEN# +1.00113991"},
        {"Smithsonian Astrophysical Observation", "SAO 252167"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.12979534),
        dec: Angle.Degrees(-60.93346122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88177"},
        {"Hipparcos Number", "HIP 49648"},
        {"Smithsonian Astrophysical Observation", "SAO 250827"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.02334777),
        dec: Angle.Degrees(-60.93323209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202473"},
        {"Hipparcos Number", "HIP 105207"},
        {"Smithsonian Astrophysical Observation", "SAO 254971"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.66832160),
        dec: Angle.Degrees(-60.93281048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108567"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.88377294),
        dec: Angle.Degrees(-60.93274382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130551"},
        {"Hipparcos Number", "HIP 72673"},
        {"Geneva Identification System", "GEN# +1.00130551"},
        {"Smithsonian Astrophysical Observation", "SAO 252918"},
        {"Wilson Evans Batten Catalogue", "WEB 12491"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.88190611),
        dec: Angle.Degrees(-60.93106487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64456",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64456"},
        {"Geneva Identification System", "GEN# -0.06004519"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.18023136),
        dec: Angle.Degrees(-60.93079769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98210"},
        {"Hipparcos Number", "HIP 55114"},
        {"Celescope Catalog", "CEL 3871"},
        {"Geneva Identification System", "GEN# +1.00098210"},
        {"Wilson Evans Batten Catalogue", "WEB 9937"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.26375850),
        dec: Angle.Degrees(-60.92808278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6030"},
        {"Smithsonian Astrophysical Observation", "SAO 248352"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.36708502),
        dec: Angle.Degrees(-60.92703010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65950"},
        {"Hipparcos Number", "HIP 38906"},
        {"Geneva Identification System", "GEN# +2.25160126"},
        {"Renson", "Renson 18110"},
        {"Smithsonian Astrophysical Observation", "SAO 250036"},
        {"Wilson Evans Batten Catalogue", "WEB 7626"},
        {"New General Catalogue", "NGC 2516B"},
    },
    visualMagnitude: 6.86,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.43843756),
        dec: Angle.Degrees(-60.92649019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150170"},
        {"Hipparcos Number", "HIP 81836"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.73674039),
        dec: Angle.Degrees(-60.92618971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188033"},
        {"Hipparcos Number", "HIP 98133"},
        {"Smithsonian Astrophysical Observation", "SAO 254689"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.16017688),
        dec: Angle.Degrees(-60.92537440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120412"},
    },
    visualMagnitude: null,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)23, 33.7100),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)55, 29.000)
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
    primaryId: "HIP 97591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186784"},
        {"Hipparcos Number", "HIP 97591"},
        {"Geneva Identification System", "GEN# +1.00186784"},
        {"Smithsonian Astrophysical Observation", "SAO 254664"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.54031789),
        dec: Angle.Degrees(-60.92377915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81697"},
        {"Hipparcos Number", "HIP 46151"},
        {"Geneva Identification System", "GEN# +1.00081697"},
        {"Smithsonian Astrophysical Observation", "SAO 250568"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.17748901),
        dec: Angle.Degrees(-60.92247501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192234"},
        {"Hipparcos Number", "HIP 99993"},
        {"Smithsonian Astrophysical Observation", "SAO 254765"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.28817293),
        dec: Angle.Degrees(-60.92025452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79699"},
        {"Hipparcos Number", "HIP 45214"},
        {"Celescope Catalog", "CEL 3227"},
        {"Geneva Identification System", "GEN# +1.00079699J"},
        {"Smithsonian Astrophysical Observation", "SAO 250485"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.21097157),
        dec: Angle.Degrees(-60.91681495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37458",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37458"},
    },
    visualMagnitude: 12.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.33305229),
        dec: Angle.Degrees(-60.91650418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106997"},
        {"Hipparcos Number", "HIP 60017"},
        {"Geneva Identification System", "GEN# +1.00106997"},
        {"Smithsonian Astrophysical Observation", "SAO 251842"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.62407558),
        dec: Angle.Degrees(-60.91453334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15742"},
        {"Hipparcos Number", "HIP 11581"},
        {"Smithsonian Astrophysical Observation", "SAO 248575"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.31104642),
        dec: Angle.Degrees(-60.91375123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110151"},
        {"Hipparcos Number", "HIP 61861"},
        {"Geneva Identification System", "GEN# +1.00110151"},
        {"Smithsonian Astrophysical Observation", "SAO 251991"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.17455899),
        dec: Angle.Degrees(-60.91311315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1591"},
        {"Hipparcos Number", "HIP 1582"},
        {"Geneva Identification System", "GEN# +1.00001591"},
        {"Smithsonian Astrophysical Observation", "SAO 248162"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.95319310),
        dec: Angle.Degrees(-60.91218601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92554"},
        {"Hipparcos Number", "HIP 52191"},
        {"Geneva Identification System", "GEN# +1.00092554"},
        {"Wilson Evans Batten Catalogue", "WEB 9511"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.94022622),
        dec: Angle.Degrees(-60.91100094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95950"},
        {"Hipparcos Number", "HIP 54021"},
        {"Geneva Identification System", "GEN# +1.00095950"},
        {"Smithsonian Astrophysical Observation", "SAO 251235"},
    },
    visualMagnitude: 6.67,
    bvColour: 2.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.77568030),
        dec: Angle.Degrees(-60.91073438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17535",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17535"},
    },
    visualMagnitude: 10.88,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.31628821),
        dec: Angle.Degrees(-60.90998511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 163.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67277"},
        {"Hipparcos Number", "HIP 39438"},
        {"Smithsonian Astrophysical Observation", "SAO 250094"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.92353475),
        dec: Angle.Degrees(-60.90758287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25054"},
        {"Hipparcos Number", "HIP 18352"},
        {"Geneva Identification System", "GEN# +1.00025054"},
        {"Smithsonian Astrophysical Observation", "SAO 248907"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.84742812),
        dec: Angle.Degrees(-60.90724407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81314"},
        {"Smithsonian Astrophysical Observation", "SAO 253620"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.11474359),
        dec: Angle.Degrees(-60.90701103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131376"},
        {"Hipparcos Number", "HIP 73067"},
        {"Smithsonian Astrophysical Observation", "SAO 252960"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.99212787),
        dec: Angle.Degrees(-60.90592227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107980"},
        {"Henry Draper 2", "HD 107979"},
        {"Hipparcos Number", "HIP 60546"},
        {"Geneva Identification System", "GEN# +1.00107979J"},
        {"Smithsonian Astrophysical Observation", "SAO 251884"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.17675328),
        dec: Angle.Degrees(-60.90412183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135160"},
        {"Hipparcos Number", "HIP 74750"},
        {"Geneva Identification System", "GEN# +1.00135160J"},
        {"Smithsonian Astrophysical Observation", "SAO 253082"},
        {"Wilson Evans Batten Catalogue", "WEB 12751"},
    },
    visualMagnitude: 5.74,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.15289366),
        dec: Angle.Degrees(-60.90398660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148638"},
        {"Hipparcos Number", "HIP 81039"},
        {"Geneva Identification System", "GEN# +1.00148638"},
        {"Smithsonian Astrophysical Observation", "SAO 253597"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.27154803),
        dec: Angle.Degrees(-60.90351415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101104"},
        {"Hipparcos Number", "HIP 56702"},
        {"Smithsonian Astrophysical Observation", "SAO 251497"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.39223932),
        dec: Angle.Degrees(-60.90324953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148628"},
        {"Hipparcos Number", "HIP 81037"},
        {"Geneva Identification System", "GEN# +1.00148628"},
        {"Smithsonian Astrophysical Observation", "SAO 253596"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.25860223),
        dec: Angle.Degrees(-60.90300758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124909"},
        {"Hipparcos Number", "HIP 69910"},
        {"Geneva Identification System", "GEN# +1.00124909"},
        {"Smithsonian Astrophysical Observation", "SAO 252695"},
        {"Wilson Evans Batten Catalogue", "WEB 12160"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.61196770),
        dec: Angle.Degrees(-60.89837095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18026"},
        {"Hipparcos Number", "HIP 13289"},
        {"Smithsonian Astrophysical Observation", "SAO 248661"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.76447630),
        dec: Angle.Degrees(-60.89706699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173895"},
        {"Hipparcos Number", "HIP 92547"},
        {"Smithsonian Astrophysical Observation", "SAO 254390"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.89500595),
        dec: Angle.Degrees(-60.89570744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91024"},
        {"Hipparcos Number", "HIP 51310"},
        {"Geneva Identification System", "GEN# +1.00091024"},
        {"Smithsonian Astrophysical Observation", "SAO 250973"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.20528360),
        dec: Angle.Degrees(-60.89468887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100942"},
        {"Hipparcos Number", "HIP 56617"},
        {"Smithsonian Astrophysical Observation", "SAO 251482"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.14194413),
        dec: Angle.Degrees(-60.89459773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100773"},
        {"Hipparcos Number", "HIP 56519"},
        {"Geneva Identification System", "GEN# +1.00100773"},
        {"Smithsonian Astrophysical Observation", "SAO 251466"},
        {"Wilson Evans Batten Catalogue", "WEB 10159"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.80806521),
        dec: Angle.Degrees(-60.89450490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -183.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41395"},
        {"Hipparcos Number", "HIP 28480"},
        {"Smithsonian Astrophysical Observation", "SAO 249418"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.19763745),
        dec: Angle.Degrees(-60.89267533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37512"},
        {"Hipparcos Number", "HIP 26205"},
        {"Smithsonian Astrophysical Observation", "SAO 249315"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.77541278),
        dec: Angle.Degrees(-60.89172391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5642"},
        {"Geneva Identification System", "GEN# +6.00003186"},
    },
    visualMagnitude: 11.22,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.12063822),
        dec: Angle.Degrees(-60.89013565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136057"},
        {"Hipparcos Number", "HIP 75149"},
        {"Smithsonian Astrophysical Observation", "SAO 253123"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.37422253),
        dec: Angle.Degrees(-60.88977642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125241"},
        {"Hipparcos Number", "HIP 70074"},
        {"Geneva Identification System", "GEN# +1.00125241"},
        {"Smithsonian Astrophysical Observation", "SAO 252707"},
        {"Wilson Evans Batten Catalogue", "WEB 12184"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.09496914),
        dec: Angle.Degrees(-60.88950758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145883"},
        {"Hipparcos Number", "HIP 79778"},
        {"Smithsonian Astrophysical Observation", "SAO 253484"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.22148003),
        dec: Angle.Degrees(-60.88845931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77690"},
        {"Hipparcos Number", "HIP 44292"},
        {"Smithsonian Astrophysical Observation", "SAO 250419"},
    },
    visualMagnitude: 8.77,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.30476375),
        dec: Angle.Degrees(-60.88845366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15484",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15484"},
        {"Geneva Identification System", "GEN# -0.03801098"},
    },
    visualMagnitude: 10.38,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.89757936),
        dec: Angle.Degrees(-38.18496213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112471"},
        {"Hipparcos Number", "HIP 63258"},
        {"Celescope Catalog", "CEL 4177"},
        {"Geneva Identification System", "GEN# +1.00112471"},
        {"Smithsonian Astrophysical Observation", "SAO 252108"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.43723939),
        dec: Angle.Degrees(-60.88766364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107978"},
        {"Hipparcos Number", "HIP 60552"},
        {"Geneva Identification System", "GEN# +1.00107978"},
        {"Smithsonian Astrophysical Observation", "SAO 251887"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.19331342),
        dec: Angle.Degrees(-60.88716377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108939"},
        {"Hipparcos Number", "HIP 61115"},
        {"Celescope Catalog", "CEL 4117"},
        {"Geneva Identification System", "GEN# +1.00108939"},
        {"Smithsonian Astrophysical Observation", "SAO 251942"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.88033577),
        dec: Angle.Degrees(-60.88506146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111873"},
        {"Hipparcos Number", "HIP 62871"},
        {"Geneva Identification System", "GEN# +1.00111873"},
        {"Smithsonian Astrophysical Observation", "SAO 252067"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.28696676),
        dec: Angle.Degrees(-60.88151729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 312251"},
        {"Hipparcos Number", "HIP 63693"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.79453772),
        dec: Angle.Degrees(-60.87746457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12633"},
        {"Hipparcos Number", "HIP 9456"},
        {"Smithsonian Astrophysical Observation", "SAO 248480"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.40578807),
        dec: Angle.Degrees(-60.87715307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218243"},
        {"Hipparcos Number", "HIP 114175"},
        {"Geneva Identification System", "GEN# +1.00218243"},
        {"Smithsonian Astrophysical Observation", "SAO 255406"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.82881933),
        dec: Angle.Degrees(-60.87633665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27531"},
        {"Hipparcos Number", "HIP 19980"},
        {"Smithsonian Astrophysical Observation", "SAO 248980"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.27689134),
        dec: Angle.Degrees(-60.87574658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8525"},
        {"Hipparcos Number", "HIP 6449"},
        {"Smithsonian Astrophysical Observation", "SAO 248374"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.71356848),
        dec: Angle.Degrees(-60.87389705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123589"},
        {"Hipparcos Number", "HIP 69244"},
        {"Smithsonian Astrophysical Observation", "SAO 252637"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.63455422),
        dec: Angle.Degrees(-60.87282763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70940"},
    },
    visualMagnitude: 10.15,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.64914961),
        dec: Angle.Degrees(-60.87166556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153665"},
        {"Hipparcos Number", "HIP 83557"},
        {"Smithsonian Astrophysical Observation", "SAO 253788"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.14273503),
        dec: Angle.Degrees(-60.87076940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110451",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110451"},
    },
    visualMagnitude: 11.44,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.57928286),
        dec: Angle.Degrees(-60.87068551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221668"},
        {"Hipparcos Number", "HIP 116347"},
        {"Smithsonian Astrophysical Observation", "SAO 255518"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.63659371),
        dec: Angle.Degrees(-60.86841754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38615"},
        {"Hipparcos Number", "HIP 26945"},
        {"Smithsonian Astrophysical Observation", "SAO 249338"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.75839717),
        dec: Angle.Degrees(-60.86829633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12785"},
    },
    visualMagnitude: 11.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.08443337),
        dec: Angle.Degrees(-60.86511522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126905"},
        {"Hipparcos Number", "HIP 70939"},
        {"Geneva Identification System", "GEN# +1.00126905"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.64762336),
        dec: Angle.Degrees(-60.86509411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53191"},
        {"Hipparcos Number", "HIP 33717"},
        {"Celescope Catalog", "CEL 1517"},
        {"Smithsonian Astrophysical Observation", "SAO 249701"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.06969877),
        dec: Angle.Degrees(-60.86277565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31644"},
        {"Hipparcos Number", "HIP 22759"},
        {"Smithsonian Astrophysical Observation", "SAO 249136"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.43494187),
        dec: Angle.Degrees(-60.86133255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11995"},
        {"Hipparcos Number", "HIP 8983"},
        {"Geneva Identification System", "GEN# +1.00011995"},
        {"Smithsonian Astrophysical Observation", "SAO 248464"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.94360840),
        dec: Angle.Degrees(-60.86113745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6107"},
        {"Hipparcos Number", "HIP 4772"},
        {"Geneva Identification System", "GEN# +1.00006107"},
        {"Smithsonian Astrophysical Observation", "SAO 248301"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.32893461),
        dec: Angle.Degrees(-60.86038649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66066"},
        {"Hipparcos Number", "HIP 38966"},
        {"Smithsonian Astrophysical Observation", "SAO 250047"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.59296341),
        dec: Angle.Degrees(-60.85774590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64289"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.63664471),
        dec: Angle.Degrees(-60.85663024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33455"},
        {"Hipparcos Number", "HIP 23763"},
        {"Smithsonian Astrophysical Observation", "SAO 249189"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.61383105),
        dec: Angle.Degrees(-60.85381697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100335"},
        {"Hipparcos Number", "HIP 56281"},
        {"Geneva Identification System", "GEN# +1.00100335"},
        {"Smithsonian Astrophysical Observation", "SAO 251449"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.07005219),
        dec: Angle.Degrees(-60.85336909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99842"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.84102928),
        dec: Angle.Degrees(-60.85257249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114251"},
        {"Hipparcos Number", "HIP 64286"},
        {"Geneva Identification System", "GEN# +1.00114251"},
        {"Smithsonian Astrophysical Observation", "SAO 252177"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.62662623),
        dec: Angle.Degrees(-60.85205963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197654"},
        {"Hipparcos Number", "HIP 102645"},
        {"Smithsonian Astrophysical Observation", "SAO 254869"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.99449856),
        dec: Angle.Degrees(-60.85187565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118640"},
        {"Hipparcos Number", "HIP 66644"},
        {"Smithsonian Astrophysical Observation", "SAO 252399"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.91865397),
        dec: Angle.Degrees(-60.85161857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52447"},
        {"Hipparcos Number", "HIP 33468"},
        {"Geneva Identification System", "GEN# +1.00052447"},
        {"Smithsonian Astrophysical Observation", "SAO 249689"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.35986344),
        dec: Angle.Degrees(-60.85149777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106203"},
        {"Hipparcos Number", "HIP 59601"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.33615662),
        dec: Angle.Degrees(-60.85073199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31070",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31070"},
    },
    visualMagnitude: 12.36,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.79947777),
        dec: Angle.Degrees(-37.97503997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102088"},
        {"Hipparcos Number", "HIP 57270"},
        {"Smithsonian Astrophysical Observation", "SAO 251565"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.16269322),
        dec: Angle.Degrees(-60.85058694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180211"},
        {"Hipparcos Number", "HIP 94957"},
        {"Geneva Identification System", "GEN# +1.00180211"},
        {"Smithsonian Astrophysical Observation", "SAO 254529"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.84558716),
        dec: Angle.Degrees(-60.85002153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126808"},
        {"Hipparcos Number", "HIP 70911"},
        {"Geneva Identification System", "GEN# +2.56170283"},
        {"New General Catalogue", "NGC 5617 283"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.51507509),
        dec: Angle.Degrees(-60.84962954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178631"},
        {"Hipparcos Number", "HIP 94424"},
        {"Smithsonian Astrophysical Observation", "SAO 254495"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.27896399),
        dec: Angle.Degrees(-60.84931902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209257"},
        {"Hipparcos Number", "HIP 108926"},
        {"Smithsonian Astrophysical Observation", "SAO 255136"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.99079576),
        dec: Angle.Degrees(-60.84754064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105437"},
        {"Hipparcos Number", "HIP 59200"},
        {"Geneva Identification System", "GEN# +1.00105437"},
        {"Smithsonian Astrophysical Observation", "SAO 251757"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.10307095),
        dec: Angle.Degrees(-60.84712841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30131"},
        {"Hipparcos Number", "HIP 21802"},
        {"Geneva Identification System", "GEN# +1.00030131"},
        {"Smithsonian Astrophysical Observation", "SAO 249078"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.26114719),
        dec: Angle.Degrees(-60.84586814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221658"},
        {"Hipparcos Number", "HIP 116345"},
        {"Smithsonian Astrophysical Observation", "SAO 255517"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.62333357),
        dec: Angle.Degrees(-60.84584740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52904"},
        {"Hipparcos Number", "HIP 33622"},
        {"Smithsonian Astrophysical Observation", "SAO 249695"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.78045079),
        dec: Angle.Degrees(-60.84201733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19338"},
        {"Hipparcos Number", "HIP 14256"},
        {"Smithsonian Astrophysical Observation", "SAO 248718"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.95682259),
        dec: Angle.Degrees(-60.84083739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71681",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Toliman"},
        {"Henry Draper", "HD 128621"},
        {"Hipparcos Number", "HIP 71681"},
        {"Geneva Identification System", "GEN# +1.00128621"},
    },
    visualMagnitude: 1.35,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.91412833),
        dec: Angle.Degrees(-60.83947139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3600.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 952.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110925"},
        {"Hipparcos Number", "HIP 62324"},
        {"Geneva Identification System", "GEN# +1.00110925J"},
        {"Smithsonian Astrophysical Observation", "SAO 252021"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.58277381),
        dec: Angle.Degrees(-60.83874844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58941"},
        {"Hipparcos Number", "HIP 35889"},
        {"Smithsonian Astrophysical Observation", "SAO 249844"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.98274686),
        dec: Angle.Degrees(-60.83804588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16389"},
        {"Hipparcos Number", "HIP 12047"},
        {"Smithsonian Astrophysical Observation", "SAO 248605"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.82310235),
        dec: Angle.Degrees(-60.83693305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221967"},
        {"Hipparcos Number", "HIP 116536"},
        {"Geneva Identification System", "GEN# +1.00221967"},
        {"Smithsonian Astrophysical Observation", "SAO 255525"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.26308019),
        dec: Angle.Degrees(-60.83562767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71683",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Rigel Kentaurus"},
        {"Common Name 2", "Rigil Kentaurus"},
        {"Henry Draper", "HD 128620"},
        {"Hipparcos Number", "HIP 71683"},
        {"Geneva Identification System", "GEN# +1.00128620A"},
        {"Wilson Evans Batten Catalogue", "WEB 12354"},
    },
    visualMagnitude: -0.01,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.92041034),
        dec: Angle.Degrees(-60.83514707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3678.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 481.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207045"},
        {"Hipparcos Number", "HIP 107659"},
        {"Smithsonian Astrophysical Observation", "SAO 255075"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.10370908),
        dec: Angle.Degrees(-60.83467332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90579"},
        {"Hipparcos Number", "HIP 51048"},
        {"Celescope Catalog", "CEL 3537"},
        {"Smithsonian Astrophysical Observation", "SAO 250950"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.43983842),
        dec: Angle.Degrees(-60.83257981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1495"},
        {"Hipparcos Number", "HIP 1504"},
        {"Smithsonian Astrophysical Observation", "SAO 248161"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.68438020),
        dec: Angle.Degrees(-60.83070821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81175"},
        {"Hipparcos Number", "HIP 45905"},
        {"Celescope Catalog", "CEL 3274"},
        {"Smithsonian Astrophysical Observation", "SAO 250551"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.39303707),
        dec: Angle.Degrees(-60.83051735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196225"},
        {"Hipparcos Number", "HIP 101901"},
        {"Smithsonian Astrophysical Observation", "SAO 254840"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.75509647),
        dec: Angle.Degrees(-60.82647412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125052"},
        {"Hipparcos Number", "HIP 69982"},
        {"Geneva Identification System", "GEN# +1.00125052"},
        {"Smithsonian Astrophysical Observation", "SAO 252700"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.80008354),
        dec: Angle.Degrees(-60.82601127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217192"},
        {"Hipparcos Number", "HIP 113554"},
        {"Geneva Identification System", "GEN# +1.00217192"},
        {"Smithsonian Astrophysical Observation", "SAO 255373"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.98479093),
        dec: Angle.Degrees(-60.82561693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66194"},
        {"Hipparcos Number", "HIP 38994"},
        {"Geneva Identification System", "GEN# +2.25160134"},
        {"Smithsonian Astrophysical Observation", "SAO 250055"},
        {"Wilson Evans Batten Catalogue", "WEB 7647"},
        {"New General Catalogue", "NGC 2516A"},
    },
    visualMagnitude: 5.77,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.71065387),
        dec: Angle.Degrees(-60.82448838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137965"},
        {"Hipparcos Number", "HIP 76070"},
        {"Smithsonian Astrophysical Observation", "SAO 253200"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.04201746),
        dec: Angle.Degrees(-60.82403335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178795"},
        {"Hipparcos Number", "HIP 94469"},
        {"Geneva Identification System", "GEN# +1.00178795"},
        {"Smithsonian Astrophysical Observation", "SAO 254499"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.40903777),
        dec: Angle.Degrees(-60.82141424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161987"},
        {"Hipparcos Number", "HIP 87488"},
        {"Smithsonian Astrophysical Observation", "SAO 254062"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.13805805),
        dec: Angle.Degrees(-60.82049332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151710"},
        {"Hipparcos Number", "HIP 82577"},
        {"Smithsonian Astrophysical Observation", "SAO 253724"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.21434563),
        dec: Angle.Degrees(-60.81731634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213501"},
        {"Hipparcos Number", "HIP 111330"},
        {"Smithsonian Astrophysical Observation", "SAO 255251"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.33583518),
        dec: Angle.Degrees(-60.81720362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126842"},
        {"Hipparcos Number", "HIP 70925"},
        {"Geneva Identification System", "GEN# +2.56170319"},
        {"Smithsonian Astrophysical Observation", "SAO 252765"},
        {"New General Catalogue", "NGC 5617 319"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.56269909),
        dec: Angle.Degrees(-60.81646187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115920"},
        {"Hipparcos Number", "HIP 65186"},
        {"Geneva Identification System", "GEN# +1.00115920"},
        {"Smithsonian Astrophysical Observation", "SAO 252280"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.38311468),
        dec: Angle.Degrees(-60.80884785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138276"},
        {"Hipparcos Number", "HIP 76223"},
        {"Smithsonian Astrophysical Observation", "SAO 253215"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.56045901),
        dec: Angle.Degrees(-60.80783982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199759"},
        {"Hipparcos Number", "HIP 103797"},
        {"Smithsonian Astrophysical Observation", "SAO 254921"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.49263332),
        dec: Angle.Degrees(-60.80739280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92599"},
        {"Hipparcos Number", "HIP 52211"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.00652983),
        dec: Angle.Degrees(-60.80377231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104171"},
        {"Hipparcos Number", "HIP 58488"},
        {"Geneva Identification System", "GEN# +1.00104171"},
        {"Smithsonian Astrophysical Observation", "SAO 251672"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.92029726),
        dec: Angle.Degrees(-60.80306275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21313"},
        {"Smithsonian Astrophysical Observation", "SAO 249057"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.63974842),
        dec: Angle.Degrees(-60.80275008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211524"},
        {"Hipparcos Number", "HIP 110211"},
        {"Geneva Identification System", "GEN# +1.00211524"},
        {"Smithsonian Astrophysical Observation", "SAO 255195"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.86994857),
        dec: Angle.Degrees(-60.79937707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
