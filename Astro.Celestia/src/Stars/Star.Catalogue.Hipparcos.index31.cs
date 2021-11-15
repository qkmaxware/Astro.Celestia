using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_31() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45905"},
        {"Hipparcos Number", "HIP 30834"},
        {"Smithsonian Astrophysical Observation", "SAO 196862"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.15166759),
        dec: Angle.Degrees(-35.26216486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150020"},
        {"Hipparcos Number", "HIP 81603"},
        {"Smithsonian Astrophysical Observation", "SAO 207895"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.97317458),
        dec: Angle.Degrees(-35.26057361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59416"},
        {"Hipparcos Number", "HIP 36305"},
        {"Smithsonian Astrophysical Observation", "SAO 198029"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.09683702),
        dec: Angle.Degrees(-35.26010717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60221"},
        {"Hipparcos Number", "HIP 36628"},
        {"Smithsonian Astrophysical Observation", "SAO 198100"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.99086095),
        dec: Angle.Degrees(-35.25898437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46349"},
        {"Henry Draper 2", "HD 46350"},
        {"Hipparcos Number", "HIP 31072"},
        {"Geneva Identification System", "GEN# +1.00046349"},
        {"Smithsonian Astrophysical Observation", "SAO 196897"},
    },
    visualMagnitude: 5.82,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.80457202),
        dec: Angle.Degrees(-35.25886111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114497",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114497"},
        {"Smithsonian Astrophysical Observation", "SAO 214370"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.84381244),
        dec: Angle.Degrees(-35.25843244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55347",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55347"},
        {"Smithsonian Astrophysical Observation", "SAO 202329"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.01299188),
        dec: Angle.Degrees(-35.25661374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220980"},
        {"Hipparcos Number", "HIP 115866"},
        {"Smithsonian Astrophysical Observation", "SAO 214569"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.12555412),
        dec: Angle.Degrees(-35.25601442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43033"},
        {"Hipparcos Number", "HIP 29462"},
        {"Smithsonian Astrophysical Observation", "SAO 196584"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.11416865),
        dec: Angle.Degrees(-35.25593992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149447"},
        {"Hipparcos Number", "HIP 81304"},
        {"Geneva Identification System", "GEN# +1.00149447"},
        {"Smithsonian Astrophysical Observation", "SAO 207814"},
        {"Wilson Evans Batten Catalogue", "WEB 13742"},
    },
    visualMagnitude: 4.18,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.09358718),
        dec: Angle.Degrees(-35.25535553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88886"},
        {"Hipparcos Number", "HIP 50168"},
        {"Smithsonian Astrophysical Observation", "SAO 201201"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.60697849),
        dec: Angle.Degrees(-35.25513146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126653"},
        {"Hipparcos Number", "HIP 70713"},
        {"Geneva Identification System", "GEN# +1.00126653"},
        {"Smithsonian Astrophysical Observation", "SAO 205580"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.93883451),
        dec: Angle.Degrees(-35.25382834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186085"},
        {"Hipparcos Number", "HIP 97088"},
        {"Geneva Identification System", "GEN# +1.00186085"},
        {"Smithsonian Astrophysical Observation", "SAO 211509"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.96883462),
        dec: Angle.Degrees(-35.25292711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105265"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.83516523),
        dec: Angle.Degrees(-35.24867478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24849"},
        {"Hipparcos Number", "HIP 18379"},
        {"Smithsonian Astrophysical Observation", "SAO 194632"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.92258593),
        dec: Angle.Degrees(-35.24823651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101940"},
        {"Hipparcos Number", "HIP 57207"},
        {"Smithsonian Astrophysical Observation", "SAO 202752"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.95764774),
        dec: Angle.Degrees(-35.24799965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56237"},
        {"Hipparcos Number", "HIP 35030"},
        {"Celescope Catalog", "CEL 1711"},
        {"Geneva Identification System", "GEN# +1.00056237"},
        {"Smithsonian Astrophysical Observation", "SAO 197743"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.69271817),
        dec: Angle.Degrees(-35.24769448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81307"},
        {"Hipparcos Number", "HIP 46081"},
        {"Geneva Identification System", "GEN# +1.00081307"},
        {"Smithsonian Astrophysical Observation", "SAO 200322"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.95738399),
        dec: Angle.Degrees(-35.24750626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38057"},
        {"Hipparcos Number", "HIP 26780"},
        {"Smithsonian Astrophysical Observation", "SAO 196087"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.33574575),
        dec: Angle.Degrees(-35.24703344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55198"},
    },
    visualMagnitude: 12.19,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.52927503),
        dec: Angle.Degrees(-35.24483426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63786"},
        {"Hipparcos Number", "HIP 38167"},
        {"Celescope Catalog", "CEL 2049"},
        {"Geneva Identification System", "GEN# +1.00063786"},
        {"Smithsonian Astrophysical Observation", "SAO 198480"},
    },
    visualMagnitude: 5.94,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.31105571),
        dec: Angle.Degrees(-35.24330796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140127"},
        {"Hipparcos Number", "HIP 76997"},
        {"Smithsonian Astrophysical Observation", "SAO 206901"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.82173142),
        dec: Angle.Degrees(-35.24323236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76125"},
        {"Hipparcos Number", "HIP 43621"},
        {"Smithsonian Astrophysical Observation", "SAO 199743"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.27052855),
        dec: Angle.Degrees(-35.24114557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167342"},
        {"Hipparcos Number", "HIP 89539"},
        {"Smithsonian Astrophysical Observation", "SAO 209932"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.05519145),
        dec: Angle.Degrees(-35.24089996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184753"},
        {"Hipparcos Number", "HIP 96527"},
        {"Geneva Identification System", "GEN# +1.00184753"},
        {"Smithsonian Astrophysical Observation", "SAO 211418"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.36371835),
        dec: Angle.Degrees(-35.24029939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131795"},
        {"Hipparcos Number", "HIP 73123"},
        {"Geneva Identification System", "GEN# +1.00131795"},
        {"Smithsonian Astrophysical Observation", "SAO 206115"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.17424479),
        dec: Angle.Degrees(-35.23986716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97702"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.83882282),
        dec: Angle.Degrees(-35.23938520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118233"},
        {"Smithsonian Astrophysical Observation", "SAO 214894"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.73086844),
        dec: Angle.Degrees(-35.23667456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105748"},
        {"Hipparcos Number", "HIP 59338"},
        {"Geneva Identification System", "GEN# +1.00105748"},
        {"Smithsonian Astrophysical Observation", "SAO 203191"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.58673255),
        dec: Angle.Degrees(-35.23529119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101348"},
        {"Hipparcos Number", "HIP 56876"},
        {"Geneva Identification System", "GEN# +1.00101348"},
        {"Smithsonian Astrophysical Observation", "SAO 202677"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.90313159),
        dec: Angle.Degrees(-35.23264878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -226.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102540"},
        {"Hipparcos Number", "HIP 57574"},
        {"Geneva Identification System", "GEN# +1.00102540"},
        {"Smithsonian Astrophysical Observation", "SAO 202824"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.01658968),
        dec: Angle.Degrees(-35.22514130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42136"},
        {"Hipparcos Number", "HIP 29029"},
        {"Smithsonian Astrophysical Observation", "SAO 196511"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.87150705),
        dec: Angle.Degrees(-35.22463398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125327"},
        {"Hipparcos Number", "HIP 70018"},
        {"Smithsonian Astrophysical Observation", "SAO 205433"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.89961387),
        dec: Angle.Degrees(-35.22457995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156201"},
        {"Hipparcos Number", "HIP 84612"},
        {"Geneva Identification System", "GEN# +1.00156201"},
        {"Smithsonian Astrophysical Observation", "SAO 208643"},
        {"Wilson Evans Batten Catalogue", "WEB 14287"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.43964442),
        dec: Angle.Degrees(-35.22416902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33330"},
        {"Hipparcos Number", "HIP 23890"},
        {"Smithsonian Astrophysical Observation", "SAO 195579"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.00578512),
        dec: Angle.Degrees(-35.22337183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161561"},
        {"Hipparcos Number", "HIP 87085"},
        {"Smithsonian Astrophysical Observation", "SAO 209261"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.92416822),
        dec: Angle.Degrees(-35.22217561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116903"},
        {"Smithsonian Astrophysical Observation", "SAO 214716"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.44379087),
        dec: Angle.Degrees(-35.21720107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190081"},
        {"Hipparcos Number", "HIP 98864"},
        {"Smithsonian Astrophysical Observation", "SAO 211785"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.15234500),
        dec: Angle.Degrees(-35.21403970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10119"},
        {"Hipparcos Number", "HIP 7630"},
        {"Smithsonian Astrophysical Observation", "SAO 193222"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.57544738),
        dec: Angle.Degrees(-35.21334238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67736"},
        {"Hipparcos Number", "HIP 39801"},
        {"Geneva Identification System", "GEN# +1.00067736"},
        {"Renson", "Renson 18680"},
        {"Smithsonian Astrophysical Observation", "SAO 198833"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.00139068),
        dec: Angle.Degrees(-35.21104388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113653"},
        {"Hipparcos Number", "HIP 63890"},
        {"Smithsonian Astrophysical Observation", "SAO 204114"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.40388613),
        dec: Angle.Degrees(-35.20993586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69066"},
        {"Hipparcos Number", "HIP 40307"},
        {"Geneva Identification System", "GEN# +1.00069066"},
        {"Smithsonian Astrophysical Observation", "SAO 198967"},
        {"Wilson Evans Batten Catalogue", "WEB 7860"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.46141519),
        dec: Angle.Degrees(-35.20823749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219368"},
        {"Hipparcos Number", "HIP 114821"},
        {"Fundamental Katalog 5th Edition", "FK5 6054"},
        {"Geneva Identification System", "GEN# +1.00219368"},
        {"Smithsonian Astrophysical Observation", "SAO 214408"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.89001088),
        dec: Angle.Degrees(-35.20651952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10370",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10370"},
    },
    visualMagnitude: 11.83,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.40641338),
        dec: Angle.Degrees(-35.20574863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -381.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7311"},
        {"Hipparcos Number", "HIP 5665"},
        {"Fundamental Katalog 5th Edition", "FK5 2080"},
        {"Smithsonian Astrophysical Observation", "SAO 192981"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.19462479),
        dec: Angle.Degrees(-35.20552645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25167"},
        {"Hipparcos Number", "HIP 18579"},
        {"Smithsonian Astrophysical Observation", "SAO 194667"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.64900780),
        dec: Angle.Degrees(-35.20491270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22826"},
        {"Hipparcos Number", "HIP 17002"},
        {"Fundamental Katalog 5th Edition", "FK5 4328"},
        {"Geneva Identification System", "GEN# +1.00022826"},
        {"Smithsonian Astrophysical Observation", "SAO 194426"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.67580732),
        dec: Angle.Degrees(-35.20429862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98405"},
        {"Hipparcos Number", "HIP 55252"},
        {"Geneva Identification System", "GEN# +1.00098405"},
        {"Smithsonian Astrophysical Observation", "SAO 202315"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.73884492),
        dec: Angle.Degrees(-35.20187781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163251"},
        {"Hipparcos Number", "HIP 87844"},
        {"Smithsonian Astrophysical Observation", "SAO 209500"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.19314537),
        dec: Angle.Degrees(-35.20144672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207291"},
        {"Hipparcos Number", "HIP 107676"},
        {"Smithsonian Astrophysical Observation", "SAO 213302"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.17828397),
        dec: Angle.Degrees(-35.20110658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154547"},
        {"Hipparcos Number", "HIP 83801"},
        {"Smithsonian Astrophysical Observation", "SAO 208437"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.89293315),
        dec: Angle.Degrees(-35.20073609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7783"},
        {"Geneva Identification System", "GEN# -0.03500583"},
        {"Smithsonian Astrophysical Observation", "SAO 193239"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.04188043),
        dec: Angle.Degrees(-35.19971302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 302.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26479",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26479"},
        {"Smithsonian Astrophysical Observation", "SAO 196035"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.48022584),
        dec: Angle.Degrees(-35.19937094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157204"},
        {"Hipparcos Number", "HIP 85088"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.85710496),
        dec: Angle.Degrees(-35.19933639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99729"},
        {"Hipparcos Number", "HIP 55964"},
        {"Renson", "Renson 28690"},
        {"Smithsonian Astrophysical Observation", "SAO 202482"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.02499868),
        dec: Angle.Degrees(-35.19890977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192486"},
        {"Hipparcos Number", "HIP 99926"},
        {"Fundamental Katalog 5th Edition", "FK5 5787"},
        {"Geneva Identification System", "GEN# +1.00192486"},
        {"Smithsonian Astrophysical Observation", "SAO 211950"},
        {"Wilson Evans Batten Catalogue", "WEB 17971"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.11019928),
        dec: Angle.Degrees(-35.19859739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94891"},
        {"Smithsonian Astrophysical Observation", "SAO 211154"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.65894189),
        dec: Angle.Degrees(-35.19597921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103822"},
        {"Hipparcos Number", "HIP 58288"},
        {"Smithsonian Astrophysical Observation", "SAO 202977"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.31382813),
        dec: Angle.Degrees(-35.19330010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129685"},
        {"Hipparcos Number", "HIP 72104"},
        {"Geneva Identification System", "GEN# +1.00129685"},
        {"Smithsonian Astrophysical Observation", "SAO 205899"},
        {"Wilson Evans Batten Catalogue", "WEB 12403"},
    },
    visualMagnitude: 4.92,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.24664628),
        dec: Angle.Degrees(-35.19182069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31871"},
        {"Hipparcos Number", "HIP 23065"},
        {"Geneva Identification System", "GEN# +1.00031871"},
        {"Smithsonian Astrophysical Observation", "SAO 195437"},
        {"Wilson Evans Batten Catalogue", "WEB 4477"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.44695838),
        dec: Angle.Degrees(-35.18987553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187386"},
        {"Hipparcos Number", "HIP 97685"},
        {"Geneva Identification System", "GEN# +1.00187386"},
        {"Smithsonian Astrophysical Observation", "SAO 211601"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.79329855),
        dec: Angle.Degrees(-35.18815455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188766"},
        {"Hipparcos Number", "HIP 98282"},
        {"Geneva Identification System", "GEN# +1.00188766"},
        {"Smithsonian Astrophysical Observation", "SAO 211695"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.54183983),
        dec: Angle.Degrees(-35.18800793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59242",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59242"},
    },
    visualMagnitude: 11.03,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.28242194),
        dec: Angle.Degrees(-35.18722572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211258"},
        {"Hipparcos Number", "HIP 109978"},
        {"Geneva Identification System", "GEN# +1.00211258"},
        {"Smithsonian Astrophysical Observation", "SAO 213688"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.12630078),
        dec: Angle.Degrees(-35.18681056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108114"},
        {"Hipparcos Number", "HIP 60610"},
        {"Geneva Identification System", "GEN# +1.00108114"},
        {"Smithsonian Astrophysical Observation", "SAO 203450"},
        {"Wilson Evans Batten Catalogue", "WEB 10782"},
    },
    visualMagnitude: 5.71,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.34068272),
        dec: Angle.Degrees(-35.18640097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136346"},
        {"Hipparcos Number", "HIP 75145"},
        {"Geneva Identification System", "GEN# +1.00136346"},
        {"Smithsonian Astrophysical Observation", "SAO 206541"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.35444601),
        dec: Angle.Degrees(-35.18614482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57301"},
        {"Hipparcos Number", "HIP 35447"},
        {"Celescope Catalog", "CEL 1777"},
        {"Geneva Identification System", "GEN# +1.00057301"},
        {"Smithsonian Astrophysical Observation", "SAO 197840"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.77727543),
        dec: Angle.Degrees(-35.18425166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180181"},
        {"Hipparcos Number", "HIP 94764"},
        {"Smithsonian Astrophysical Observation", "SAO 211124"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.24101330),
        dec: Angle.Degrees(-35.18417828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199918"},
        {"Hipparcos Number", "HIP 103735"},
        {"Geneva Identification System", "GEN# +1.00199918"},
        {"Smithsonian Astrophysical Observation", "SAO 212635"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.30620944),
        dec: Angle.Degrees(-35.18395422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122493"},
        {"Hipparcos Number", "HIP 68631"},
        {"Smithsonian Astrophysical Observation", "SAO 205120"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.72299463),
        dec: Angle.Degrees(-35.18302484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209566"},
        {"Hipparcos Number", "HIP 109012"},
        {"Geneva Identification System", "GEN# +1.00209566"},
        {"Smithsonian Astrophysical Observation", "SAO 213530"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.27297028),
        dec: Angle.Degrees(-35.18127667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 324.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83860"},
        {"Hipparcos Number", "HIP 47449"},
        {"Smithsonian Astrophysical Observation", "SAO 200615"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.05149438),
        dec: Angle.Degrees(-35.18073528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87782"},
        {"Hipparcos Number", "HIP 49513"},
        {"Geneva Identification System", "GEN# +1.00087782J"},
        {"Smithsonian Astrophysical Observation", "SAO 201057"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.63918379),
        dec: Angle.Degrees(-35.18012291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205462"},
        {"Hipparcos Number", "HIP 106671"},
        {"Smithsonian Astrophysical Observation", "SAO 213128"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.08403377),
        dec: Angle.Degrees(-35.17936958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58961"},
        {"Hipparcos Number", "HIP 36115"},
        {"Smithsonian Astrophysical Observation", "SAO 197996"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.59232865),
        dec: Angle.Degrees(-35.17675194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143844"},
        {"Hipparcos Number", "HIP 78711"},
        {"Smithsonian Astrophysical Observation", "SAO 207287"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.02973107),
        dec: Angle.Degrees(-35.17675036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186713"},
        {"Hipparcos Number", "HIP 97378"},
        {"Smithsonian Astrophysical Observation", "SAO 211553"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.86743266),
        dec: Angle.Degrees(-35.17660306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147652"},
        {"Hipparcos Number", "HIP 80391"},
        {"Fundamental Katalog 5th Edition", "FK5 5446"},
        {"Geneva Identification System", "GEN# +1.00147652"},
        {"Smithsonian Astrophysical Observation", "SAO 207639"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.13308062),
        dec: Angle.Degrees(-35.17522681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214623"},
        {"Hipparcos Number", "HIP 111897"},
        {"Smithsonian Astrophysical Observation", "SAO 213995"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.99219297),
        dec: Angle.Degrees(-35.17469918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13894"},
        {"Hipparcos Number", "HIP 10441"},
        {"Smithsonian Astrophysical Observation", "SAO 193594"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.63386908),
        dec: Angle.Degrees(-35.17372546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129456"},
        {"Hipparcos Number", "HIP 72010"},
        {"Fundamental Katalog 5th Edition", "FK5 544"},
        {"Geneva Identification System", "GEN# +1.00129456"},
        {"Smithsonian Astrophysical Observation", "SAO 205871"},
        {"Wilson Evans Batten Catalogue", "WEB 12395"},
    },
    visualMagnitude: 4.06,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.91451458),
        dec: Angle.Degrees(-35.17322549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119832"},
        {"Hipparcos Number", "HIP 67191"},
        {"Smithsonian Astrophysical Observation", "SAO 204821"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.54484067),
        dec: Angle.Degrees(-35.17272977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47229"},
        {"Hipparcos Number", "HIP 31521"},
        {"Smithsonian Astrophysical Observation", "SAO 196988"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.99805704),
        dec: Angle.Degrees(-35.17180289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100624"},
        {"Hipparcos Number", "HIP 56456"},
        {"Geneva Identification System", "GEN# +1.00100624"},
        {"Smithsonian Astrophysical Observation", "SAO 202585"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.63715034),
        dec: Angle.Degrees(-35.16990743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3060"},
        {"Hipparcos Number", "HIP 2652"},
        {"Geneva Identification System", "GEN# +1.00003060"},
        {"Smithsonian Astrophysical Observation", "SAO 192607"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.40444824),
        dec: Angle.Degrees(-35.16748410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71856"},
        {"Hipparcos Number", "HIP 41546"},
        {"Geneva Identification System", "GEN# +1.00071856"},
        {"Smithsonian Astrophysical Observation", "SAO 199268"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.08045340),
        dec: Angle.Degrees(-35.16719542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20695"},
        {"Hipparcos Number", "HIP 15409"},
        {"Smithsonian Astrophysical Observation", "SAO 194225"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.66861509),
        dec: Angle.Degrees(-35.16716409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29758"},
        {"Hipparcos Number", "HIP 21717"},
        {"Smithsonian Astrophysical Observation", "SAO 195207"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.94644311),
        dec: Angle.Degrees(-35.16659490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197482"},
        {"Hipparcos Number", "HIP 102412"},
        {"Smithsonian Astrophysical Observation", "SAO 212401"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.29888947),
        dec: Angle.Degrees(-35.16635195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56458",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56458"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.64067157),
        dec: Angle.Degrees(-35.16552050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209607"},
        {"Hipparcos Number", "HIP 109041"},
        {"Smithsonian Astrophysical Observation", "SAO 213534"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.34025181),
        dec: Angle.Degrees(-35.16386621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109901"},
        {"Hipparcos Number", "HIP 61679"},
        {"Smithsonian Astrophysical Observation", "SAO 203657"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.66316208),
        dec: Angle.Degrees(-35.16366159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62478"},
        {"Hipparcos Number", "HIP 37578"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.67439965),
        dec: Angle.Degrees(-35.16147688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213713"},
        {"Hipparcos Number", "HIP 111393"},
        {"Geneva Identification System", "GEN# +1.00213713"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.50714005),
        dec: Angle.Degrees(-35.15978486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172196"},
        {"Hipparcos Number", "HIP 91558"},
        {"Geneva Identification System", "GEN# +1.00172196"},
        {"Smithsonian Astrophysical Observation", "SAO 210430"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.07609609),
        dec: Angle.Degrees(-35.15891134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179830"},
        {"Hipparcos Number", "HIP 94640"},
        {"Smithsonian Astrophysical Observation", "SAO 211092"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.86368274),
        dec: Angle.Degrees(-35.15869623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167981"},
        {"Hipparcos Number", "HIP 89766"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.77324541),
        dec: Angle.Degrees(-35.15683286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172577"},
        {"Hipparcos Number", "HIP 91746"},
        {"Smithsonian Astrophysical Observation", "SAO 210482"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.62815379),
        dec: Angle.Degrees(-35.15516584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197823"},
        {"Hipparcos Number", "HIP 102580"},
        {"Geneva Identification System", "GEN# +1.00197823"},
        {"Smithsonian Astrophysical Observation", "SAO 212430"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.81879371),
        dec: Angle.Degrees(-35.15389062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35578"},
        {"Hipparcos Number", "HIP 25265"},
        {"Smithsonian Astrophysical Observation", "SAO 195818"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.05265542),
        dec: Angle.Degrees(-35.15177134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174497"},
        {"Hipparcos Number", "HIP 92611"},
        {"Smithsonian Astrophysical Observation", "SAO 210652"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.05825051),
        dec: Angle.Degrees(-35.15153010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66402"},
        {"Hipparcos Number", "HIP 39289"},
        {"Smithsonian Astrophysical Observation", "SAO 198723"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.50910382),
        dec: Angle.Degrees(-35.15130243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87559"},
        {"Hipparcos Number", "HIP 49384"},
        {"Smithsonian Astrophysical Observation", "SAO 201027"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.23186628),
        dec: Angle.Degrees(-35.15101181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1155"},
        {"Hipparcos Number", "HIP 1254"},
        {"Smithsonian Astrophysical Observation", "SAO 192428"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.93174463),
        dec: Angle.Degrees(-35.15025123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176576"},
        {"Hipparcos Number", "HIP 93493"},
        {"Geneva Identification System", "GEN# +1.00176576"},
        {"Smithsonian Astrophysical Observation", "SAO 210847"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.60668513),
        dec: Angle.Degrees(-35.14851776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169102"},
        {"Hipparcos Number", "HIP 90224"},
        {"Smithsonian Astrophysical Observation", "SAO 210103"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.13852321),
        dec: Angle.Degrees(-35.14823300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181740"},
        {"Hipparcos Number", "HIP 95276"},
        {"Smithsonian Astrophysical Observation", "SAO 211220"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.76327665),
        dec: Angle.Degrees(-35.14753746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95300"},
        {"Hipparcos Number", "HIP 53741"},
        {"Geneva Identification System", "GEN# +1.00095300"},
        {"Smithsonian Astrophysical Observation", "SAO 201991"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.94586189),
        dec: Angle.Degrees(-35.14314364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110106",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110106"},
    },
    visualMagnitude: 11.20,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.55445139),
        dec: Angle.Degrees(-03.17220379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 216.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50292"},
        {"Hipparcos Number", "HIP 32863"},
        {"Smithsonian Astrophysical Observation", "SAO 197279"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.73653352),
        dec: Angle.Degrees(-35.14197179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43785"},
        {"Hipparcos Number", "HIP 29807"},
        {"Fundamental Katalog 5th Edition", "FK5 238"},
        {"Geneva Identification System", "GEN# +1.00043785"},
        {"Smithsonian Astrophysical Observation", "SAO 196643"},
        {"Wilson Evans Batten Catalogue", "WEB 5890"},
    },
    visualMagnitude: 4.37,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.13806399),
        dec: Angle.Degrees(-35.14073157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36874"},
        {"Hipparcos Number", "HIP 26019"},
        {"Geneva Identification System", "GEN# +1.00036874"},
        {"Smithsonian Astrophysical Observation", "SAO 195952"},
        {"Wilson Evans Batten Catalogue", "WEB 5064"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.28048500),
        dec: Angle.Degrees(-35.13930773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18989"},
        {"Hipparcos Number", "HIP 14119"},
        {"Smithsonian Astrophysical Observation", "SAO 194047"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.52477971),
        dec: Angle.Degrees(-35.13928388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213600"},
        {"Hipparcos Number", "HIP 111326"},
        {"Smithsonian Astrophysical Observation", "SAO 213903"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.32134755),
        dec: Angle.Degrees(-35.13864602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47852"},
        {"Hipparcos Number", "HIP 31809"},
        {"Geneva Identification System", "GEN# +1.00047852"},
        {"Smithsonian Astrophysical Observation", "SAO 197042"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.75729574),
        dec: Angle.Degrees(-35.13651058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 739"},
        {"Hipparcos Number", "HIP 950"},
        {"Fundamental Katalog 5th Edition", "FK5 6"},
        {"Geneva Identification System", "GEN# +1.00000739"},
        {"Smithsonian Astrophysical Observation", "SAO 192388"},
        {"Wilson Evans Batten Catalogue", "WEB 169"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.93286698),
        dec: Angle.Degrees(-35.13339606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182890"},
        {"Hipparcos Number", "HIP 95731"},
        {"Fundamental Katalog 5th Edition", "FK5 5713"},
        {"Geneva Identification System", "GEN# +1.00182890"},
        {"Smithsonian Astrophysical Observation", "SAO 211287"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.08501431),
        dec: Angle.Degrees(-35.13336989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127893"},
        {"Hipparcos Number", "HIP 71300"},
        {"Geneva Identification System", "GEN# +1.00127893"},
        {"Smithsonian Astrophysical Observation", "SAO 205717"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.72264854),
        dec: Angle.Degrees(-35.13336099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201851"},
        {"Hipparcos Number", "HIP 104744"},
        {"Geneva Identification System", "GEN# +1.00201851"},
        {"Smithsonian Astrophysical Observation", "SAO 212797"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.30741949),
        dec: Angle.Degrees(-35.13334346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182928"},
        {"Hipparcos Number", "HIP 95753"},
        {"Geneva Identification System", "GEN# +1.00182928"},
        {"Smithsonian Astrophysical Observation", "SAO 211289"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.13343963),
        dec: Angle.Degrees(-35.13297861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62874"},
        {"Hipparcos Number", "HIP 37757"},
        {"Smithsonian Astrophysical Observation", "SAO 198377"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.15150533),
        dec: Angle.Degrees(-35.13211558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64354"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)11, 28.5900),
        dec: Angle.DegreesMinutesSeconds((int)-35, (int)07, 52.000)
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
    primaryId: "HIP 113961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217960"},
        {"Hipparcos Number", "HIP 113961"},
        {"Smithsonian Astrophysical Observation", "SAO 214291"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.17172576),
        dec: Angle.Degrees(-35.13034984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114509"},
        {"Hipparcos Number", "HIP 64362"},
        {"Smithsonian Astrophysical Observation", "SAO 204212"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.87678604),
        dec: Angle.Degrees(-35.12990835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76"},
        {"Hipparcos Number", "HIP 463"},
        {"Smithsonian Astrophysical Observation", "SAO 192353"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.38325838),
        dec: Angle.Degrees(-35.12972759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155633"},
        {"Hipparcos Number", "HIP 84320"},
        {"Geneva Identification System", "GEN# +1.00155633"},
        {"Smithsonian Astrophysical Observation", "SAO 208568"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.57139247),
        dec: Angle.Degrees(-35.12950812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193850"},
        {"Hipparcos Number", "HIP 100575"},
        {"Smithsonian Astrophysical Observation", "SAO 212074"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.93601930),
        dec: Angle.Degrees(-35.12932321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7398",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7398"},
    },
    visualMagnitude: 12.08,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.84848266),
        dec: Angle.Degrees(-35.12843780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91249"},
        {"Hipparcos Number", "HIP 51530"},
        {"Smithsonian Astrophysical Observation", "SAO 201471"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.87576825),
        dec: Angle.Degrees(-35.12817245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44624"},
        {"Hipparcos Number", "HIP 30194"},
        {"Smithsonian Astrophysical Observation", "SAO 196718"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.28949313),
        dec: Angle.Degrees(-35.12455793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84976"},
        {"Hipparcos Number", "HIP 48069"},
        {"Smithsonian Astrophysical Observation", "SAO 200747"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.99073722),
        dec: Angle.Degrees(-35.12406448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110668"},
        {"Hipparcos Number", "HIP 62127"},
        {"Geneva Identification System", "GEN# +1.00110668"},
        {"Smithsonian Astrophysical Observation", "SAO 203757"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.99341141),
        dec: Angle.Degrees(-35.12280325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49053"},
        {"Hipparcos Number", "HIP 32334"},
        {"Celescope Catalog", "CEL 1370"},
        {"Geneva Identification System", "GEN# +1.00049053"},
        {"Smithsonian Astrophysical Observation", "SAO 197164"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.24116423),
        dec: Angle.Degrees(-35.12170279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175047"},
        {"Hipparcos Number", "HIP 92841"},
        {"Geneva Identification System", "GEN# +1.00175047"},
        {"Smithsonian Astrophysical Observation", "SAO 210708"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.75232999),
        dec: Angle.Degrees(-35.12112545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41492"},
        {"Hipparcos Number", "HIP 28719"},
        {"Geneva Identification System", "GEN# +1.00041492"},
        {"Smithsonian Astrophysical Observation", "SAO 196457"},
        {"Wilson Evans Batten Catalogue", "WEB 5619"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.99696793),
        dec: Angle.Degrees(-35.11826984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13992"},
        {"Hipparcos Number", "HIP 10483"},
        {"Geneva Identification System", "GEN# +1.00013992"},
        {"Smithsonian Astrophysical Observation", "SAO 193600"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.79655810),
        dec: Angle.Degrees(-35.11776335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 191.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113207"},
        {"Hipparcos Number", "HIP 63635"},
        {"Smithsonian Astrophysical Observation", "SAO 204063"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.63396349),
        dec: Angle.Degrees(-35.11511015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94771"},
        {"Hipparcos Number", "HIP 53437"},
        {"Geneva Identification System", "GEN# +1.00094771"},
        {"Smithsonian Astrophysical Observation", "SAO 201911"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.97489355),
        dec: Angle.Degrees(-35.11424889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71801"},
        {"Hipparcos Number", "HIP 41515"},
        {"Celescope Catalog", "CEL 2538"},
        {"Geneva Identification System", "GEN# +1.00071801J"},
        {"Smithsonian Astrophysical Observation", "SAO 199260"},
        {"Wilson Evans Batten Catalogue", "WEB 8020"},
    },
    visualMagnitude: 5.75,
    bvColour: -0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.99760675),
        dec: Angle.Degrees(-35.11378822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113678"},
        {"Hipparcos Number", "HIP 63908"},
        {"Smithsonian Astrophysical Observation", "SAO 204117"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.44653043),
        dec: Angle.Degrees(-35.11185345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172300"},
        {"Hipparcos Number", "HIP 91607"},
        {"Smithsonian Astrophysical Observation", "SAO 210445"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.23595676),
        dec: Angle.Degrees(-35.11149933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14589"},
        {"Hipparcos Number", "HIP 10914"},
        {"Smithsonian Astrophysical Observation", "SAO 193650"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.12682627),
        dec: Angle.Degrees(-35.11096958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12094"},
        {"Hipparcos Number", "HIP 9157"},
        {"Smithsonian Astrophysical Observation", "SAO 193411"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.48404936),
        dec: Angle.Degrees(-35.10997576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53776"},
        {"Geneva Identification System", "GEN# -0.03407135"},
    },
    visualMagnitude: 11.22,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.01122942),
        dec: Angle.Degrees(-35.10961152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165120"},
        {"Hipparcos Number", "HIP 88655"},
        {"Smithsonian Astrophysical Observation", "SAO 209697"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.50092750),
        dec: Angle.Degrees(-35.10859113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63944"},
        {"Hipparcos Number", "HIP 38237"},
        {"Fundamental Katalog 5th Edition", "FK5 4706"},
        {"Geneva Identification System", "GEN# +1.00063944"},
        {"Smithsonian Astrophysical Observation", "SAO 198496"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.49997463),
        dec: Angle.Degrees(-35.10775658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30876"},
        {"Hipparcos Number", "HIP 22451"},
        {"Geneva Identification System", "GEN# +1.00030876"},
        {"Smithsonian Astrophysical Observation", "SAO 195332"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.46812665),
        dec: Angle.Degrees(-35.10735332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221275"},
        {"Hipparcos Number", "HIP 116050"},
        {"Geneva Identification System", "GEN# +1.00221275"},
        {"Smithsonian Astrophysical Observation", "SAO 214594"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.72584633),
        dec: Angle.Degrees(-35.10649297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38254"},
        {"Hipparcos Number", "HIP 26920"},
        {"Geneva Identification System", "GEN# +1.00038254"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.71171649),
        dec: Angle.Degrees(-35.10242633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140475"},
        {"Hipparcos Number", "HIP 77150"},
        {"Smithsonian Astrophysical Observation", "SAO 206931"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.27656675),
        dec: Angle.Degrees(-35.10185398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109748"},
        {"Hipparcos Number", "HIP 61593"},
        {"Smithsonian Astrophysical Observation", "SAO 203639"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.31241345),
        dec: Angle.Degrees(-35.10160891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208853"},
        {"Hipparcos Number", "HIP 108592"},
        {"Geneva Identification System", "GEN# +1.00208853"},
        {"Smithsonian Astrophysical Observation", "SAO 213461"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.97028566),
        dec: Angle.Degrees(-35.09976591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149415"},
        {"Hipparcos Number", "HIP 81280"},
        {"Smithsonian Astrophysical Observation", "SAO 207808"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.02101183),
        dec: Angle.Degrees(-35.09834214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217469"},
        {"Hipparcos Number", "HIP 113670"},
        {"Smithsonian Astrophysical Observation", "SAO 214253"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.33820122),
        dec: Angle.Degrees(-35.09544562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18794"},
        {"Hipparcos Number", "HIP 14012"},
        {"Smithsonian Astrophysical Observation", "SAO 194028"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.09251755),
        dec: Angle.Degrees(-35.09452443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 319801"},
        {"Hipparcos Number", "HIP 85438"},
        {"Smithsonian Astrophysical Observation", "SAO 208837"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.89850407),
        dec: Angle.Degrees(-35.09334922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130656"},
        {"Hipparcos Number", "HIP 72584"},
        {"Smithsonian Astrophysical Observation", "SAO 205996"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.62737371),
        dec: Angle.Degrees(-35.09329899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 466"},
        {"Hipparcos Number", "HIP 732"},
        {"Geneva Identification System", "GEN# +1.00000466"},
        {"Smithsonian Astrophysical Observation", "SAO 192372"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.26106347),
        dec: Angle.Degrees(-35.09184956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186131"},
        {"Hipparcos Number", "HIP 97109"},
        {"Smithsonian Astrophysical Observation", "SAO 211513"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.02563251),
        dec: Angle.Degrees(-35.08817340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4236"},
        {"Hipparcos Number", "HIP 3485"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.12425480),
        dec: Angle.Degrees(-35.08566299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39996"},
        {"Hipparcos Number", "HIP 27925"},
        {"Geneva Identification System", "GEN# +1.00039996"},
        {"Smithsonian Astrophysical Observation", "SAO 196301"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.63608208),
        dec: Angle.Degrees(-35.08508655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221750"},
        {"Hipparcos Number", "HIP 116375"},
        {"Fundamental Katalog 5th Edition", "FK5 6085"},
        {"Smithsonian Astrophysical Observation", "SAO 214634"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.72633471),
        dec: Angle.Degrees(-35.08490334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30787"},
        {"Hipparcos Number", "HIP 22387"},
        {"Geneva Identification System", "GEN# +1.00030787"},
        {"Smithsonian Astrophysical Observation", "SAO 195322"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.28920323),
        dec: Angle.Degrees(-35.08369963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111771"},
        {"Hipparcos Number", "HIP 62785"},
        {"Smithsonian Astrophysical Observation", "SAO 203884"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.98669499),
        dec: Angle.Degrees(-35.08241794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42387"},
        {"Smithsonian Astrophysical Observation", "SAO 199459"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.65074039),
        dec: Angle.Degrees(-35.08099154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154205"},
        {"Hipparcos Number", "HIP 83625"},
        {"Geneva Identification System", "GEN# +1.00154205"},
        {"Smithsonian Astrophysical Observation", "SAO 208387"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.36050949),
        dec: Angle.Degrees(-35.07942965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204728"},
        {"Hipparcos Number", "HIP 106287"},
        {"Geneva Identification System", "GEN# +1.00204728"},
        {"Smithsonian Astrophysical Observation", "SAO 213067"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.91322581),
        dec: Angle.Degrees(-35.07748127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83516"},
        {"Hipparcos Number", "HIP 47269"},
        {"Fundamental Katalog 5th Edition", "FK5 4854"},
        {"Geneva Identification System", "GEN# +1.00083516"},
        {"Smithsonian Astrophysical Observation", "SAO 200582"},
        {"Wilson Evans Batten Catalogue", "WEB 8887"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.51055512),
        dec: Angle.Degrees(-35.07648251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116711"},
        {"Hipparcos Number", "HIP 65528"},
        {"Smithsonian Astrophysical Observation", "SAO 204462"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.49188271),
        dec: Angle.Degrees(-35.07582409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57483"},
        {"Hipparcos Number", "HIP 35528"},
        {"Smithsonian Astrophysical Observation", "SAO 197860"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.98784064),
        dec: Angle.Degrees(-35.07296928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209496"},
        {"Hipparcos Number", "HIP 108967"},
        {"Smithsonian Astrophysical Observation", "SAO 213520"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.13741444),
        dec: Angle.Degrees(-35.07290738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162144"},
        {"Hipparcos Number", "HIP 87360"},
        {"Geneva Identification System", "GEN# +2.64750131"},
        {"Smithsonian Astrophysical Observation", "SAO 209345"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.75884523),
        dec: Angle.Degrees(-35.07053327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120826"},
        {"Hipparcos Number", "HIP 67738"},
        {"Geneva Identification System", "GEN# +1.00120826"},
        {"Smithsonian Astrophysical Observation", "SAO 204933"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.13877718),
        dec: Angle.Degrees(-35.07037541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26025"},
        {"Hipparcos Number", "HIP 19118"},
        {"Smithsonian Astrophysical Observation", "SAO 194759"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.47744028),
        dec: Angle.Degrees(-35.06965196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11536"},
        {"Hipparcos Number", "HIP 8752"},
        {"Smithsonian Astrophysical Observation", "SAO 193355"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.14620137),
        dec: Angle.Degrees(-35.06885878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163602"},
        {"Hipparcos Number", "HIP 87993"},
        {"Smithsonian Astrophysical Observation", "SAO 209532"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.60760035),
        dec: Angle.Degrees(-35.06665874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103266"},
        {"Hipparcos Number", "HIP 57971"},
        {"Fundamental Katalog 5th Edition", "FK5 2949"},
        {"Geneva Identification System", "GEN# +1.00103266"},
        {"Smithsonian Astrophysical Observation", "SAO 202910"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.36194168),
        dec: Angle.Degrees(-35.06657261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40816"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.95766899),
        dec: Angle.Degrees(-35.06535082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118465"},
        {"Hipparcos Number", "HIP 66486"},
        {"Geneva Identification System", "GEN# +1.00118465"},
        {"Smithsonian Astrophysical Observation", "SAO 204673"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.45063684),
        dec: Angle.Degrees(-35.06478118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45383"},
        {"Hipparcos Number", "HIP 30566"},
        {"Geneva Identification System", "GEN# +1.00045383"},
        {"Smithsonian Astrophysical Observation", "SAO 196805"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.37502195),
        dec: Angle.Degrees(-35.06404110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202117"},
        {"Hipparcos Number", "HIP 104891"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.70953161),
        dec: Angle.Degrees(-35.06328858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37377"},
        {"Hipparcos Number", "HIP 26348"},
        {"Smithsonian Astrophysical Observation", "SAO 196012"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.15139805),
        dec: Angle.Degrees(-35.06134724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208590"},
        {"Hipparcos Number", "HIP 108442"},
        {"Smithsonian Astrophysical Observation", "SAO 213440"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.50947284),
        dec: Angle.Degrees(-35.05770319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161741"},
        {"Hipparcos Number", "HIP 87191"},
        {"Geneva Identification System", "GEN# +1.00161741"},
        {"Smithsonian Astrophysical Observation", "SAO 209291"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.19832703),
        dec: Angle.Degrees(-35.05711828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200834"},
        {"Hipparcos Number", "HIP 104227"},
        {"Smithsonian Astrophysical Observation", "SAO 212720"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.75126233),
        dec: Angle.Degrees(-35.05710083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65833",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65833"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.42785152),
        dec: Angle.Degrees(-35.05685296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114386"},
        {"Hipparcos Number", "HIP 64295"},
        {"Smithsonian Astrophysical Observation", "SAO 204193"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.66634006),
        dec: Angle.Degrees(-35.05399258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -325.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134391"},
        {"Hipparcos Number", "HIP 74269"},
        {"Smithsonian Astrophysical Observation", "SAO 206363"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.67415230),
        dec: Angle.Degrees(-35.05209345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167847"},
        {"Hipparcos Number", "HIP 89710"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.63445792),
        dec: Angle.Degrees(-35.05012343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47025"},
        {"Hipparcos Number", "HIP 31410"},
        {"Geneva Identification System", "GEN# +1.00047025"},
        {"Smithsonian Astrophysical Observation", "SAO 196970"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.75092972),
        dec: Angle.Degrees(-35.04929345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118434"},
        {"Hipparcos Number", "HIP 66463"},
        {"Geneva Identification System", "GEN# +1.00118434"},
        {"Smithsonian Astrophysical Observation", "SAO 204667"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.39310027),
        dec: Angle.Degrees(-35.04889719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163139"},
        {"Hipparcos Number", "HIP 87798"},
        {"Smithsonian Astrophysical Observation", "SAO 209486"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.03281261),
        dec: Angle.Degrees(-35.04889014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141536"},
        {"Hipparcos Number", "HIP 77631"},
        {"Smithsonian Astrophysical Observation", "SAO 207039"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.73488839),
        dec: Angle.Degrees(-35.04772994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213490"},
        {"Hipparcos Number", "HIP 111256"},
        {"Smithsonian Astrophysical Observation", "SAO 213893"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.10146515),
        dec: Angle.Degrees(-35.04763913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168558"},
        {"Hipparcos Number", "HIP 90006"},
        {"Smithsonian Astrophysical Observation", "SAO 210040"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.46180391),
        dec: Angle.Degrees(-35.04721641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77921"},
        {"Hipparcos Number", "HIP 44517"},
        {"Smithsonian Astrophysical Observation", "SAO 199947"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.05471676),
        dec: Angle.Degrees(-35.04429812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41150"},
        {"Hipparcos Number", "HIP 28557"},
        {"Smithsonian Astrophysical Observation", "SAO 196422"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.41591866),
        dec: Angle.Degrees(-35.04378433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44776"},
        {"Hipparcos Number", "HIP 30274"},
        {"Smithsonian Astrophysical Observation", "SAO 196736"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.51817975),
        dec: Angle.Degrees(-35.04353683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7051"},
        {"Hipparcos Number", "HIP 5491"},
        {"Geneva Identification System", "GEN# +1.00007051"},
        {"Smithsonian Astrophysical Observation", "SAO 192962"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.57358418),
        dec: Angle.Degrees(-35.04349872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54202"},
        {"Hipparcos Number", "HIP 34282"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.61464563),
        dec: Angle.Degrees(-35.04279942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18073"},
        {"Hipparcos Number", "HIP 13444"},
        {"Smithsonian Astrophysical Observation", "SAO 193962"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.28725344),
        dec: Angle.Degrees(-35.04126989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192527"},
        {"Hipparcos Number", "HIP 99940"},
        {"Geneva Identification System", "GEN# +1.00192527"},
        {"Smithsonian Astrophysical Observation", "SAO 211955"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.16030586),
        dec: Angle.Degrees(-35.04113182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42337"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.47601880),
        dec: Angle.Degrees(-35.04080153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217257"},
        {"Hipparcos Number", "HIP 113549"},
        {"Smithsonian Astrophysical Observation", "SAO 214227"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.96356833),
        dec: Angle.Degrees(-35.04057363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171228"},
        {"Hipparcos Number", "HIP 91104"},
        {"Smithsonian Astrophysical Observation", "SAO 210336"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.75555612),
        dec: Angle.Degrees(-35.04014127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45424"},
        {"Hipparcos Number", "HIP 30577"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.40769818),
        dec: Angle.Degrees(-35.03911651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167148"},
        {"Hipparcos Number", "HIP 89461"},
        {"Smithsonian Astrophysical Observation", "SAO 209914"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.86216069),
        dec: Angle.Degrees(-35.03804311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178180"},
        {"Hipparcos Number", "HIP 94065"},
        {"Smithsonian Astrophysical Observation", "SAO 210983"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.24498782),
        dec: Angle.Degrees(-35.03522734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85247"},
        {"Hipparcos Number", "HIP 48201"},
        {"Smithsonian Astrophysical Observation", "SAO 200779"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.39874543),
        dec: Angle.Degrees(-35.02850783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33098"},
        {"Hipparcos Number", "HIP 23756"},
        {"Geneva Identification System", "GEN# +1.00033098"},
        {"Smithsonian Astrophysical Observation", "SAO 195562"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.59407152),
        dec: Angle.Degrees(-35.02699041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166326"},
        {"Hipparcos Number", "HIP 89146"},
        {"Smithsonian Astrophysical Observation", "SAO 209832"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.91978298),
        dec: Angle.Degrees(-35.02539302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16715"},
        {"Hipparcos Number", "HIP 12409"},
        {"Fundamental Katalog 5th Edition", "FK5 4247"},
        {"Smithsonian Astrophysical Observation", "SAO 193844"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.94556079),
        dec: Angle.Degrees(-35.02432714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198803"},
        {"Hipparcos Number", "HIP 103157"},
        {"Smithsonian Astrophysical Observation", "SAO 212527"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.49722873),
        dec: Angle.Degrees(-35.02358274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90937"},
        {"Hipparcos Number", "HIP 51349"},
        {"Smithsonian Astrophysical Observation", "SAO 201439"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.32984631),
        dec: Angle.Degrees(-35.02255242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85100"},
        {"Hipparcos Number", "HIP 48131"},
        {"Geneva Identification System", "GEN# +1.00085100"},
        {"Smithsonian Astrophysical Observation", "SAO 200758"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.18857284),
        dec: Angle.Degrees(-35.02021459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204031"},
        {"Hipparcos Number", "HIP 105900"},
        {"Smithsonian Astrophysical Observation", "SAO 213004"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.71926692),
        dec: Angle.Degrees(-35.01908887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162515"},
        {"Hipparcos Number", "HIP 87529"},
        {"Geneva Identification System", "GEN# +2.64750042"},
        {"Smithsonian Astrophysical Observation", "SAO 209401"},
        {"Wilson Evans Batten Catalogue", "WEB 14762"},
        {"New General Catalogue", "NGC 6475 42"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.23237047),
        dec: Angle.Degrees(-35.01887942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29793"},
        {"Hipparcos Number", "HIP 21746"},
        {"Smithsonian Astrophysical Observation", "SAO 195215"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.03295618),
        dec: Angle.Degrees(-35.01874361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126783"},
        {"Hipparcos Number", "HIP 70789"},
        {"Smithsonian Astrophysical Observation", "SAO 205597"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.14494234),
        dec: Angle.Degrees(-35.01460371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88050"},
        {"Hipparcos Number", "HIP 49670"},
        {"Smithsonian Astrophysical Observation", "SAO 201090"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.09605527),
        dec: Angle.Degrees(-35.01369277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106550"},
        {"Hipparcos Number", "HIP 59773"},
        {"Renson", "Renson 30830"},
        {"Smithsonian Astrophysical Observation", "SAO 203283"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.85263013),
        dec: Angle.Degrees(-35.01326352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60603"},
        {"Hipparcos Number", "HIP 36782"},
        {"Geneva Identification System", "GEN# +1.00060603"},
        {"Smithsonian Astrophysical Observation", "SAO 198132"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.47889558),
        dec: Angle.Degrees(-35.01176622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208232"},
        {"Hipparcos Number", "HIP 108242"},
        {"Smithsonian Astrophysical Observation", "SAO 213402"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.92542323),
        dec: Angle.Degrees(-35.01070203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40662"},
        {"Hipparcos Number", "HIP 28290"},
        {"Smithsonian Astrophysical Observation", "SAO 196371"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.66942284),
        dec: Angle.Degrees(-35.01014335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81919"},
        {"Hipparcos Number", "HIP 46396"},
        {"Geneva Identification System", "GEN# +1.00081919"},
        {"Smithsonian Astrophysical Observation", "SAO 200392"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.91009442),
        dec: Angle.Degrees(-35.00735972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202174"},
        {"Hipparcos Number", "HIP 104916"},
        {"Smithsonian Astrophysical Observation", "SAO 212831"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.78769410),
        dec: Angle.Degrees(-35.00685597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205906"},
        {"Hipparcos Number", "HIP 106928"},
        {"Smithsonian Astrophysical Observation", "SAO 213171"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.83050881),
        dec: Angle.Degrees(-35.00433122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20749"},
        {"Hipparcos Number", "HIP 15452"},
        {"Geneva Identification System", "GEN# +1.00020749"},
        {"Smithsonian Astrophysical Observation", "SAO 194229"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.82391390),
        dec: Angle.Degrees(-35.00417261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92906"},
        {"Hipparcos Number", "HIP 52435"},
        {"Geneva Identification System", "GEN# +1.00092906"},
        {"Smithsonian Astrophysical Observation", "SAO 201669"},
        {"Wilson Evans Batten Catalogue", "WEB 9548"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.78881702),
        dec: Angle.Degrees(-35.00403600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5815"},
        {"Smithsonian Astrophysical Observation", "SAO 193004"},
    },
    visualMagnitude: 10.62,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.66585670),
        dec: Angle.Degrees(-35.00386167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158775"},
        {"Hipparcos Number", "HIP 85851"},
        {"Geneva Identification System", "GEN# +1.00158775"},
        {"Smithsonian Astrophysical Observation", "SAO 208939"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.15973705),
        dec: Angle.Degrees(-35.00280926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26218"},
        {"Hipparcos Number", "HIP 19252"},
        {"Smithsonian Astrophysical Observation", "SAO 194777"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.87612445),
        dec: Angle.Degrees(-35.00109391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3074"},
        {"Hipparcos Number", "HIP 2663"},
        {"Cincinnati Publication", "Ci 20 35"},
        {"Geneva Identification System", "GEN# +1.00003074J"},
        {"Smithsonian Astrophysical Observation", "SAO 192609"},
        {"Wilson Evans Batten Catalogue", "WEB 486"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.43270424),
        dec: Angle.Degrees(-35.00082229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -516.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46272"},
        {"Hipparcos Number", "HIP 31047"},
        {"Geneva Identification System", "GEN# +1.00046272"},
        {"Smithsonian Astrophysical Observation", "SAO 196890"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.71508004),
        dec: Angle.Degrees(-35.00047974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32326"},
        {"Hipparcos Number", "HIP 23314"},
        {"Geneva Identification System", "GEN# +1.00032326"},
        {"Smithsonian Astrophysical Observation", "SAO 195484"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.20662611),
        dec: Angle.Degrees(-35.00045759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75405"},
        {"Smithsonian Astrophysical Observation", "SAO 206593"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.11273931),
        dec: Angle.Degrees(-34.99959217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26083"},
        {"Smithsonian Astrophysical Observation", "SAO 195965"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.44267632),
        dec: Angle.Degrees(-34.99923304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216987"},
        {"Hipparcos Number", "HIP 113389"},
        {"Smithsonian Astrophysical Observation", "SAO 214207"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.46149313),
        dec: Angle.Degrees(-34.99848952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224664"},
        {"Hipparcos Number", "HIP 118299"},
        {"Smithsonian Astrophysical Observation", "SAO 214902"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.92539379),
        dec: Angle.Degrees(-34.99804200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44979"},
        {"Hipparcos Number", "HIP 30372"},
        {"Celescope Catalog", "CEL 1218"},
        {"Geneva Identification System", "GEN# +1.00044979"},
        {"Renson", "Renson 11940"},
        {"Smithsonian Astrophysical Observation", "SAO 196761"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.80436088),
        dec: Angle.Degrees(-34.99682001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210067"},
        {"Hipparcos Number", "HIP 109294"},
        {"Smithsonian Astrophysical Observation", "SAO 213579"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.11509554),
        dec: Angle.Degrees(-34.99278022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8390"},
        {"Hipparcos Number", "HIP 6433"},
        {"Geneva Identification System", "GEN# +1.00008390"},
        {"Smithsonian Astrophysical Observation", "SAO 193078"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.65657187),
        dec: Angle.Degrees(-34.99183207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156384"},
        {"Hipparcos Number", "HIP 84709"},
        {"Cincinnati Publication", "Ci 20 1030"},
        {"Geneva Identification System", "GEN# +1.00156384"},
        {"Smithsonian Astrophysical Observation", "SAO 208670"},
        {"Wilson Evans Batten Catalogue", "WEB 14302"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.73483426),
        dec: Angle.Degrees(-34.98957161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1149.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213541"},
        {"Hipparcos Number", "HIP 111299"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.20107635),
        dec: Angle.Degrees(-34.98746609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215966"},
        {"Hipparcos Number", "HIP 112708"},
        {"Fundamental Katalog 5th Edition", "FK5 6013"},
        {"Geneva Identification System", "GEN# +1.00215966"},
        {"Renson", "Renson 59650"},
        {"Smithsonian Astrophysical Observation", "SAO 214112"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.36827786),
        dec: Angle.Degrees(-34.98433421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59989"},
        {"Hipparcos Number", "HIP 36544"},
        {"Smithsonian Astrophysical Observation", "SAO 198072"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.75845768),
        dec: Angle.Degrees(-34.98419055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147938"},
        {"Hipparcos Number", "HIP 80511"},
        {"Smithsonian Astrophysical Observation", "SAO 207662"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.53645975),
        dec: Angle.Degrees(-34.98323972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181321"},
        {"Hipparcos Number", "HIP 95149"},
        {"Geneva Identification System", "GEN# +1.00181321"},
        {"Smithsonian Astrophysical Observation", "SAO 211206"},
        {"Wilson Evans Batten Catalogue", "WEB 16617"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.37374869),
        dec: Angle.Degrees(-34.98322276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101358"},
        {"Hipparcos Number", "HIP 56888"},
        {"Smithsonian Astrophysical Observation", "SAO 202681"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.93947134),
        dec: Angle.Degrees(-34.98201343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98979"},
        {"Hipparcos Number", "HIP 55585"},
        {"Smithsonian Astrophysical Observation", "SAO 202390"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.79115979),
        dec: Angle.Degrees(-34.98185834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222954"},
        {"Hipparcos Number", "HIP 117180"},
        {"Smithsonian Astrophysical Observation", "SAO 214755"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.35861842),
        dec: Angle.Degrees(-34.98118799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97736"},
        {"Hipparcos Number", "HIP 54893"},
        {"Smithsonian Astrophysical Observation", "SAO 202228"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.59772290),
        dec: Angle.Degrees(-34.98101466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61516"},
        {"Hipparcos Number", "HIP 37167"},
        {"Smithsonian Astrophysical Observation", "SAO 198221"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.56494447),
        dec: Angle.Degrees(-34.98037396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91586"},
        {"Hipparcos Number", "HIP 51709"},
        {"Smithsonian Astrophysical Observation", "SAO 201517"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.48232896),
        dec: Angle.Degrees(-34.97859858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108340"},
        {"Hipparcos Number", "HIP 60755"},
        {"Smithsonian Astrophysical Observation", "SAO 203483"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.76505392),
        dec: Angle.Degrees(-34.97292671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37550"},
        {"Hipparcos Number", "HIP 26459"},
        {"Smithsonian Astrophysical Observation", "SAO 196031"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.43468378),
        dec: Angle.Degrees(-34.97165443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160411"},
        {"Hipparcos Number", "HIP 86551"},
        {"Geneva Identification System", "GEN# +1.00160411"},
        {"Smithsonian Astrophysical Observation", "SAO 209138"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.31519574),
        dec: Angle.Degrees(-34.96910525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102423"},
        {"Smithsonian Astrophysical Observation", "SAO 212404"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.32331787),
        dec: Angle.Degrees(-34.96901284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61330"},
        {"Hipparcos Number", "HIP 37096"},
        {"Celescope Catalog", "CEL 1955"},
        {"Fundamental Katalog 5th Edition", "FK5 290"},
        {"Geneva Identification System", "GEN# +1.00061330"},
        {"Smithsonian Astrophysical Observation", "SAO 198195"},
        {"Wilson Evans Batten Catalogue", "WEB 7356"},
    },
    visualMagnitude: 4.53,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.34216663),
        dec: Angle.Degrees(-34.96857044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71076"},
        {"Hipparcos Number", "HIP 41173"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.02446884),
        dec: Angle.Degrees(-34.96783292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134685"},
        {"Hipparcos Number", "HIP 74399"},
        {"Geneva Identification System", "GEN# +1.00134685"},
        {"Smithsonian Astrophysical Observation", "SAO 206406"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.08142173),
        dec: Angle.Degrees(-34.96765222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203655"},
        {"Hipparcos Number", "HIP 105711"},
        {"Smithsonian Astrophysical Observation", "SAO 212975"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.16575460),
        dec: Angle.Degrees(-34.96748613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22099"},
        {"Hipparcos Number", "HIP 16493"},
        {"Smithsonian Astrophysical Observation", "SAO 194365"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.09384108),
        dec: Angle.Degrees(-34.96728064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181951"},
        {"Hipparcos Number", "HIP 95345"},
        {"Smithsonian Astrophysical Observation", "SAO 211229"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.95894716),
        dec: Angle.Degrees(-34.96698077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5338"},
        {"Smithsonian Astrophysical Observation", "SAO 129139"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.06021493),
        dec: Angle.Degrees(-03.00841171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110239"},
        {"Hipparcos Number", "HIP 61897"},
        {"Smithsonian Astrophysical Observation", "SAO 203707"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.26004043),
        dec: Angle.Degrees(-34.96408105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94542"},
        {"Hipparcos Number", "HIP 53314"},
        {"Smithsonian Astrophysical Observation", "SAO 201879"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.57095752),
        dec: Angle.Degrees(-34.96380391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116442"},
        {"Smithsonian Astrophysical Observation", "SAO 214640"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.92942429),
        dec: Angle.Degrees(-34.96120197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95489"},
        {"Hipparcos Number", "HIP 53844"},
        {"Smithsonian Astrophysical Observation", "SAO 202003"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.22446477),
        dec: Angle.Degrees(-34.96060971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70870"},
        {"Hipparcos Number", "HIP 41099"},
        {"Geneva Identification System", "GEN# +1.00070870"},
        {"Smithsonian Astrophysical Observation", "SAO 199158"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.76561637),
        dec: Angle.Degrees(-34.95816170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 149.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26714"},
        {"Hipparcos Number", "HIP 19612"},
        {"Smithsonian Astrophysical Observation", "SAO 194825"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.04201831),
        dec: Angle.Degrees(-34.95642374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121850"},
        {"Hipparcos Number", "HIP 68283"},
        {"Fundamental Katalog 5th Edition", "FK5 5236"},
        {"Smithsonian Astrophysical Observation", "SAO 205056"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.67435997),
        dec: Angle.Degrees(-34.95443727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174335"},
        {"Hipparcos Number", "HIP 92540"},
        {"Geneva Identification System", "GEN# +1.00174335"},
        {"Smithsonian Astrophysical Observation", "SAO 210639"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.87263789),
        dec: Angle.Degrees(-34.95382152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58360",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58360"},
    },
    visualMagnitude: 12.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.50467312),
        dec: Angle.Degrees(-34.95356934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43575"},
        {"Hipparcos Number", "HIP 29697"},
        {"Smithsonian Astrophysical Observation", "SAO 196630"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.84592118),
        dec: Angle.Degrees(-34.95143505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147455"},
        {"Hipparcos Number", "HIP 80299"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.88756672),
        dec: Angle.Degrees(-34.94999059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123344"},
        {"Hipparcos Number", "HIP 69021"},
        {"Geneva Identification System", "GEN# +1.00123344"},
        {"Smithsonian Astrophysical Observation", "SAO 205209"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.94761160),
        dec: Angle.Degrees(-34.94945264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172299"},
        {"Hipparcos Number", "HIP 91603"},
        {"Geneva Identification System", "GEN# +1.00172299"},
        {"Smithsonian Astrophysical Observation", "SAO 210442"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.22106929),
        dec: Angle.Degrees(-34.94864626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75760",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75760"},
    },
    visualMagnitude: 10.79,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.15772982),
        dec: Angle.Degrees(-34.94797906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115584",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115584"},
    },
    visualMagnitude: 11.56,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.19105404),
        dec: Angle.Degrees(-34.94649812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205045"},
        {"Hipparcos Number", "HIP 106452"},
        {"Geneva Identification System", "GEN# +1.00205045"},
        {"Smithsonian Astrophysical Observation", "SAO 213087"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.41182206),
        dec: Angle.Degrees(-34.94592213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147957"},
        {"Hipparcos Number", "HIP 80518"},
        {"Smithsonian Astrophysical Observation", "SAO 207663"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.55537415),
        dec: Angle.Degrees(-34.94573175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65721"},
        {"Hipparcos Number", "HIP 38980"},
        {"Cincinnati Publication", "Ci 20 450"},
        {"Geneva Identification System", "GEN# +1.00065721"},
        {"Smithsonian Astrophysical Observation", "SAO 198656"},
        {"Wilson Evans Batten Catalogue", "WEB 7644"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.65484316),
        dec: Angle.Degrees(-34.94528576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -361.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 208.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54580"},
        {"Hipparcos Number", "HIP 34390"},
        {"Smithsonian Astrophysical Observation", "SAO 197608"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.96071797),
        dec: Angle.Degrees(-34.94379856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190646"},
        {"Hipparcos Number", "HIP 99110"},
        {"Geneva Identification System", "GEN# +1.00190646"},
        {"Smithsonian Astrophysical Observation", "SAO 211820"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.82301974),
        dec: Angle.Degrees(-34.94175089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115094"},
        {"Geneva Identification System", "GEN# -0.03515733"},
        {"Smithsonian Astrophysical Observation", "SAO 214443"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.67973174),
        dec: Angle.Degrees(-34.94024209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210492"},
        {"Hipparcos Number", "HIP 109549"},
        {"Geneva Identification System", "GEN# +1.00210492"},
        {"Smithsonian Astrophysical Observation", "SAO 213622"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.85742276),
        dec: Angle.Degrees(-34.93980789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155891"},
        {"Hipparcos Number", "HIP 84438"},
        {"Smithsonian Astrophysical Observation", "SAO 208600"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.94571651),
        dec: Angle.Degrees(-34.93905445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64571"},
        {"Hipparcos Number", "HIP 38512"},
        {"Geneva Identification System", "GEN# +1.00064571"},
        {"Smithsonian Astrophysical Observation", "SAO 198559"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.30677306),
        dec: Angle.Degrees(-34.93854086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95921"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.62134404),
        dec: Angle.Degrees(-34.93739597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49833"},
        {"Hipparcos Number", "HIP 32668"},
        {"Celescope Catalog", "CEL 1394"},
        {"Geneva Identification System", "GEN# +1.00049833"},
        {"Smithsonian Astrophysical Observation", "SAO 197239"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.20516526),
        dec: Angle.Degrees(-34.93682492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105175"},
        {"Smithsonian Astrophysical Observation", "SAO 212882"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.59436480),
        dec: Angle.Degrees(-34.93647224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39039"},
        {"Hipparcos Number", "HIP 27420"},
        {"Geneva Identification System", "GEN# +1.00039039"},
        {"Smithsonian Astrophysical Observation", "SAO 196190"},
        {"Wilson Evans Batten Catalogue", "WEB 5386"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.09072440),
        dec: Angle.Degrees(-34.93644008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1682"},
        {"Hipparcos Number", "HIP 1675"},
        {"Geneva Identification System", "GEN# +1.00001682"},
        {"Smithsonian Astrophysical Observation", "SAO 192475"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.24261495),
        dec: Angle.Degrees(-34.93470321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19828"},
        {"Hipparcos Number", "HIP 14723"},
        {"Smithsonian Astrophysical Observation", "SAO 194127"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.54594541),
        dec: Angle.Degrees(-34.93036972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65533"},
        {"Hipparcos Number", "HIP 38913"},
        {"Smithsonian Astrophysical Observation", "SAO 198639"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.45373717),
        dec: Angle.Degrees(-34.92836390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52673"},
        {"Hipparcos Number", "HIP 33747"},
        {"Smithsonian Astrophysical Observation", "SAO 197470"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.15383903),
        dec: Angle.Degrees(-34.92750830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98125"},
        {"Hipparcos Number", "HIP 55105"},
        {"Smithsonian Astrophysical Observation", "SAO 202278"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.23998740),
        dec: Angle.Degrees(-34.92733740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34435"},
        {"Hipparcos Number", "HIP 24532"},
        {"Geneva Identification System", "GEN# +1.00034435"},
        {"Renson", "Renson 8770"},
        {"Smithsonian Astrophysical Observation", "SAO 195694"},
        {"Wilson Evans Batten Catalogue", "WEB 4752"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.94609951),
        dec: Angle.Degrees(-34.92675247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136164"},
        {"Hipparcos Number", "HIP 75056"},
        {"Geneva Identification System", "GEN# +1.00136164"},
        {"Smithsonian Astrophysical Observation", "SAO 206531"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.05587378),
        dec: Angle.Degrees(-34.92537423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147387"},
        {"Hipparcos Number", "HIP 80277"},
        {"Geneva Identification System", "GEN# +1.00147387"},
        {"Smithsonian Astrophysical Observation", "SAO 207614"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.79746891),
        dec: Angle.Degrees(-34.92483132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131400"},
        {"Hipparcos Number", "HIP 72948"},
        {"Geneva Identification System", "GEN# +1.00131400"},
        {"Smithsonian Astrophysical Observation", "SAO 206074"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.62671566),
        dec: Angle.Degrees(-34.91972275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190287"},
        {"Hipparcos Number", "HIP 98974"},
        {"Geneva Identification System", "GEN# +1.00190287"},
        {"Smithsonian Astrophysical Observation", "SAO 211801"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.40954765),
        dec: Angle.Degrees(-34.91958089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1856"},
        {"Smithsonian Astrophysical Observation", "SAO 192499"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.86305565),
        dec: Angle.Degrees(-34.91914572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59527"},
        {"Hipparcos Number", "HIP 36355"},
        {"Celescope Catalog", "CEL 1884"},
        {"Geneva Identification System", "GEN# +1.00059527"},
        {"Smithsonian Astrophysical Observation", "SAO 198041"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.23620137),
        dec: Angle.Degrees(-34.91839048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4708"},
        {"Hipparcos Number", "HIP 3803"},
        {"Smithsonian Astrophysical Observation", "SAO 192758"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.21005240),
        dec: Angle.Degrees(-34.91545627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146545"},
        {"Hipparcos Number", "HIP 79874"},
        {"Smithsonian Astrophysical Observation", "SAO 207525"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.55893252),
        dec: Angle.Degrees(-34.91471965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51887"},
        {"Geneva Identification System", "GEN# -0.03406837"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.02078376),
        dec: Angle.Degrees(-34.91411660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38881",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38881"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.34835636),
        dec: Angle.Degrees(-34.91370340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 198.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17393"},
        {"Hipparcos Number", "HIP 12934"},
        {"Smithsonian Astrophysical Observation", "SAO 193904"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.58559504),
        dec: Angle.Degrees(-34.91015771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110692",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110692"},
        {"Geneva Identification System", "GEN# -0.03515313"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.40219687),
        dec: Angle.Degrees(-34.90950883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83760",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83760"},
        {"Smithsonian Astrophysical Observation", "SAO 208427"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.77519031),
        dec: Angle.Degrees(-34.90929395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159193"},
        {"Hipparcos Number", "HIP 86025"},
        {"Geneva Identification System", "GEN# +1.00159193"},
        {"Smithsonian Astrophysical Observation", "SAO 208978"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.70297862),
        dec: Angle.Degrees(-34.90897789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222246"},
        {"Hipparcos Number", "HIP 116711"},
        {"Smithsonian Astrophysical Observation", "SAO 214686"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.78902550),
        dec: Angle.Degrees(-34.90806046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107741"},
        {"Smithsonian Astrophysical Observation", "SAO 213317"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.38578465),
        dec: Angle.Degrees(-34.90763432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85963"},
        {"Hipparcos Number", "HIP 48587"},
        {"Smithsonian Astrophysical Observation", "SAO 200855"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.63541197),
        dec: Angle.Degrees(-34.90695954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191756"},
        {"Hipparcos Number", "HIP 99605"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.20775894),
        dec: Angle.Degrees(-34.90639880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31093"},
        {"Hipparcos Number", "HIP 22573"},
        {"Fundamental Katalog 5th Edition", "FK5 2364"},
        {"Geneva Identification System", "GEN# +1.00031093J"},
        {"Smithsonian Astrophysical Observation", "SAO 195357"},
        {"Wilson Evans Batten Catalogue", "WEB 4365"},
    },
    visualMagnitude: 5.82,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.86749463),
        dec: Angle.Degrees(-34.90623200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23114"},
        {"Hipparcos Number", "HIP 17210"},
        {"Smithsonian Astrophysical Observation", "SAO 194454"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.29759960),
        dec: Angle.Degrees(-34.90615856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128120"},
        {"Hipparcos Number", "HIP 71405"},
        {"Smithsonian Astrophysical Observation", "SAO 205738"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.02775378),
        dec: Angle.Degrees(-34.90602556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94138",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94138"},
        {"Smithsonian Astrophysical Observation", "SAO 211000"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.44031005),
        dec: Angle.Degrees(-34.90566291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1089"},
        {"Hipparcos Number", "HIP 1195"},
        {"Geneva Identification System", "GEN# +1.00001089"},
        {"Smithsonian Astrophysical Observation", "SAO 192418"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.74253202),
        dec: Angle.Degrees(-34.90419374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81985"},
        {"Hipparcos Number", "HIP 46438"},
        {"Smithsonian Astrophysical Observation", "SAO 200398"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.06083058),
        dec: Angle.Degrees(-34.90412029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178789"},
        {"Hipparcos Number", "HIP 94281"},
        {"Smithsonian Astrophysical Observation", "SAO 211024"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.84948560),
        dec: Angle.Degrees(-34.90399967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33770"},
        {"Hipparcos Number", "HIP 24131"},
        {"Smithsonian Astrophysical Observation", "SAO 195625"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.74552949),
        dec: Angle.Degrees(-34.90379609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121596"},
        {"Hipparcos Number", "HIP 68151"},
        {"Smithsonian Astrophysical Observation", "SAO 205020"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.28519098),
        dec: Angle.Degrees(-34.90378051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212283"},
        {"Hipparcos Number", "HIP 110555"},
        {"Smithsonian Astrophysical Observation", "SAO 213783"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.93880826),
        dec: Angle.Degrees(-34.90358547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204082"},
        {"Hipparcos Number", "HIP 105930"},
        {"Smithsonian Astrophysical Observation", "SAO 213010"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.81605051),
        dec: Angle.Degrees(-34.90286243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99606",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99606"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.20903772),
        dec: Angle.Degrees(-34.90207420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129638"},
        {"Hipparcos Number", "HIP 72075"},
        {"Smithsonian Astrophysical Observation", "SAO 205893"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.15210983),
        dec: Angle.Degrees(-34.90107001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176859"},
        {"Hipparcos Number", "HIP 93593"},
        {"Smithsonian Astrophysical Observation", "SAO 210864"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.91064336),
        dec: Angle.Degrees(-34.90075003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123110"},
        {"Hipparcos Number", "HIP 68915"},
        {"Smithsonian Astrophysical Observation", "SAO 205184"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.62520290),
        dec: Angle.Degrees(-34.89870124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27814"},
        {"Hipparcos Number", "HIP 20398"},
        {"Smithsonian Astrophysical Observation", "SAO 194958"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.50971568),
        dec: Angle.Degrees(-34.89735150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160393"},
        {"Hipparcos Number", "HIP 86535"},
        {"Smithsonian Astrophysical Observation", "SAO 209133"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.26956471),
        dec: Angle.Degrees(-34.89591145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162587"},
        {"Hipparcos Number", "HIP 87569"},
        {"Geneva Identification System", "GEN# +2.64750058"},
        {"Smithsonian Astrophysical Observation", "SAO 209416"},
        {"Wilson Evans Batten Catalogue", "WEB 14772"},
        {"New General Catalogue", "NGC 6475 58"},
    },
    visualMagnitude: 5.58,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.34779437),
        dec: Angle.Degrees(-34.89510976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34642"},
        {"Hipparcos Number", "HIP 24659"},
        {"Fundamental Katalog 5th Edition", "FK5 197"},
        {"Geneva Identification System", "GEN# +1.00034642"},
        {"Smithsonian Astrophysical Observation", "SAO 195721"},
        {"Wilson Evans Batten Catalogue", "WEB 4773"},
    },
    visualMagnitude: 4.81,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.37093064),
        dec: Angle.Degrees(-34.89438961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -336.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70530"},
        {"Hipparcos Number", "HIP 40924"},
        {"Celescope Catalog", "CEL 2405"},
        {"Geneva Identification System", "GEN# +1.00070530"},
        {"Smithsonian Astrophysical Observation", "SAO 199113"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.28066328),
        dec: Angle.Degrees(-34.89408625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147683"},
        {"Hipparcos Number", "HIP 80405"},
        {"Geneva Identification System", "GEN# +1.00147683"},
        {"Smithsonian Astrophysical Observation", "SAO 207641"},
        {"Wilson Evans Batten Catalogue", "WEB 13602"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.18216993),
        dec: Angle.Degrees(-34.89371345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27315"},
        {"Hipparcos Number", "HIP 19999"},
        {"Smithsonian Astrophysical Observation", "SAO 194893"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.33169021),
        dec: Angle.Degrees(-34.89282259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31860"},
        {"Hipparcos Number", "HIP 23061"},
        {"Smithsonian Astrophysical Observation", "SAO 195436"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.44343504),
        dec: Angle.Degrees(-34.89229240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59301"},
        {"Hipparcos Number", "HIP 36255"},
        {"Smithsonian Astrophysical Observation", "SAO 198023"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.98133657),
        dec: Angle.Degrees(-34.89055358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139883"},
        {"Hipparcos Number", "HIP 76875"},
        {"Geneva Identification System", "GEN# +1.00139883"},
        {"Smithsonian Astrophysical Observation", "SAO 206877"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.47180641),
        dec: Angle.Degrees(-34.88879090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2545"},
        {"Hipparcos Number", "HIP 2269"},
        {"Geneva Identification System", "GEN# +1.00002545"},
        {"Smithsonian Astrophysical Observation", "SAO 192555"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.23512268),
        dec: Angle.Degrees(-34.88711142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103150"},
        {"Cincinnati Publication", "Ci 20 1236"},
        {"Geneva Identification System", "GEN# -0.00305059"},
    },
    visualMagnitude: 11.10,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.48889785),
        dec: Angle.Degrees(-02.76502468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -615.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -371.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161330"},
        {"Hipparcos Number", "HIP 86976"},
        {"Geneva Identification System", "GEN# +1.00161330"},
        {"Smithsonian Astrophysical Observation", "SAO 209237"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.61789624),
        dec: Angle.Degrees(-34.88556298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192925"},
        {"Hipparcos Number", "HIP 100134"},
        {"Smithsonian Astrophysical Observation", "SAO 211989"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.69179701),
        dec: Angle.Degrees(-34.88307157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123603"},
        {"Hipparcos Number", "HIP 69157"},
        {"Geneva Identification System", "GEN# +1.00123603"},
        {"Smithsonian Astrophysical Observation", "SAO 205242"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.35421031),
        dec: Angle.Degrees(-34.88278792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87639"},
        {"Hipparcos Number", "HIP 49428"},
        {"Smithsonian Astrophysical Observation", "SAO 201039"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.36060515),
        dec: Angle.Degrees(-34.88266868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20049"},
        {"Hipparcos Number", "HIP 14889"},
        {"Smithsonian Astrophysical Observation", "SAO 194150"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.04464802),
        dec: Angle.Degrees(-34.88259940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54479",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54479"},
        {"Smithsonian Astrophysical Observation", "SAO 202128"},
    },
    visualMagnitude: 9.07,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.18903724),
        dec: Angle.Degrees(-34.88173516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109524"},
        {"Hipparcos Number", "HIP 61451"},
        {"Geneva Identification System", "GEN# +1.00109524A"},
        {"Smithsonian Astrophysical Observation", "SAO 203614"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.89047766),
        dec: Angle.Degrees(-34.88159197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -227.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198925"},
        {"Hipparcos Number", "HIP 103220"},
        {"Smithsonian Astrophysical Observation", "SAO 212536"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.68585056),
        dec: Angle.Degrees(-34.88003004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149935"},
        {"Hipparcos Number", "HIP 81545"},
        {"Smithsonian Astrophysical Observation", "SAO 207883"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.82490985),
        dec: Angle.Degrees(-34.87817092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96381"},
        {"Hipparcos Number", "HIP 54280"},
        {"Smithsonian Astrophysical Observation", "SAO 202088"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.55907355),
        dec: Angle.Degrees(-34.87756779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95198"},
        {"Hipparcos Number", "HIP 53684"},
        {"Renson", "Renson 27420"},
        {"Smithsonian Astrophysical Observation", "SAO 201972"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.76777409),
        dec: Angle.Degrees(-34.87610772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81153"},
        {"Hipparcos Number", "HIP 46001"},
        {"Smithsonian Astrophysical Observation", "SAO 200303"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.72932614),
        dec: Angle.Degrees(-34.87395270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165955"},
        {"Hipparcos Number", "HIP 89007"},
        {"Geneva Identification System", "GEN# +1.00165955J"},
        {"Smithsonian Astrophysical Observation", "SAO 209789"},
    },
    visualMagnitude: 9.19,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.49144536),
        dec: Angle.Degrees(-34.86869696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29483",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29483"},
    },
    visualMagnitude: 13.20,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.17636292),
        dec: Angle.Degrees(-34.86796941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151455"},
        {"Hipparcos Number", "HIP 82300"},
        {"Smithsonian Astrophysical Observation", "SAO 208060"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.24137165),
        dec: Angle.Degrees(-34.86690515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4112"},
        {"Hipparcos Number", "HIP 3400"},
        {"Geneva Identification System", "GEN# +1.00004112"},
        {"Smithsonian Astrophysical Observation", "SAO 192695"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.82579595),
        dec: Angle.Degrees(-34.86657399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218306"},
        {"Hipparcos Number", "HIP 114173"},
        {"Smithsonian Astrophysical Observation", "SAO 214320"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.82459216),
        dec: Angle.Degrees(-34.86565791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207893"},
        {"Hipparcos Number", "HIP 108032"},
        {"Geneva Identification System", "GEN# +1.00207893"},
        {"Smithsonian Astrophysical Observation", "SAO 213363"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.28922204),
        dec: Angle.Degrees(-34.86564785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28197"},
        {"Hipparcos Number", "HIP 20649"},
        {"Smithsonian Astrophysical Observation", "SAO 195002"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.37193786),
        dec: Angle.Degrees(-34.86349686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102960",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102960"},
        {"Smithsonian Astrophysical Observation", "SAO 212494"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.90350832),
        dec: Angle.Degrees(-34.86104826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 656"},
        {"Hipparcos Number", "HIP 881"},
        {"Smithsonian Astrophysical Observation", "SAO 192382"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.69516827),
        dec: Angle.Degrees(-34.86071198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69726"},
        {"Hipparcos Number", "HIP 40563"},
        {"Smithsonian Astrophysical Observation", "SAO 199033"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.22960314),
        dec: Angle.Degrees(-34.85957308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203754"},
        {"Hipparcos Number", "HIP 105764"},
        {"Geneva Identification System", "GEN# +1.00203754"},
        {"Smithsonian Astrophysical Observation", "SAO 212982"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.31561153),
        dec: Angle.Degrees(-34.85655794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117192"},
        {"Hipparcos Number", "HIP 65806"},
        {"Smithsonian Astrophysical Observation", "SAO 204516"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.33742126),
        dec: Angle.Degrees(-34.85452814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11565"},
        {"Hipparcos Number", "HIP 8769"},
        {"Geneva Identification System", "GEN# +1.00011565"},
        {"Smithsonian Astrophysical Observation", "SAO 193358"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.20383032),
        dec: Angle.Degrees(-34.85271660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157642"},
        {"Hipparcos Number", "HIP 85305"},
        {"Smithsonian Astrophysical Observation", "SAO 208803"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.47753963),
        dec: Angle.Degrees(-34.85128659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201606"},
        {"Hipparcos Number", "HIP 104631"},
        {"Smithsonian Astrophysical Observation", "SAO 212779"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.91800802),
        dec: Angle.Degrees(-34.85011943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25357"},
        {"Hipparcos Number", "HIP 18707"},
        {"Geneva Identification System", "GEN# +1.00025357"},
        {"Smithsonian Astrophysical Observation", "SAO 194684"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.11298584),
        dec: Angle.Degrees(-34.85009348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 192.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75583"},
        {"Hipparcos Number", "HIP 43331"},
        {"Smithsonian Astrophysical Observation", "SAO 199673"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.41939661),
        dec: Angle.Degrees(-34.84994193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30094"},
        {"Hipparcos Number", "HIP 21956"},
        {"Smithsonian Astrophysical Observation", "SAO 195251"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.78079921),
        dec: Angle.Degrees(-34.84765292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35737"},
        {"Hipparcos Number", "HIP 25350"},
        {"Fundamental Katalog 5th Edition", "FK5 4498"},
        {"Geneva Identification System", "GEN# +1.00035737"},
        {"Smithsonian Astrophysical Observation", "SAO 195835"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.32959511),
        dec: Angle.Degrees(-34.84745716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49969",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49969"},
        {"Geneva Identification System", "GEN# +9.80053028"},
        {"Geneva Identification System 2", "GEN# +6.10010381"},
    },
    visualMagnitude: 10.64,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.01828324),
        dec: Angle.Degrees(-02.68327061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 521.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -601.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115771"},
        {"Hipparcos Number", "HIP 65032"},
        {"Smithsonian Astrophysical Observation", "SAO 204360"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.95054121),
        dec: Angle.Degrees(-34.84673015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64876"},
        {"Hipparcos Number", "HIP 38635"},
        {"Geneva Identification System", "GEN# +1.00064876"},
        {"Smithsonian Astrophysical Observation", "SAO 198579"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.66636484),
        dec: Angle.Degrees(-34.84668366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107438"},
        {"Smithsonian Astrophysical Observation", "SAO 213265"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.41028518),
        dec: Angle.Degrees(-34.84645649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171630"},
        {"Hipparcos Number", "HIP 91305"},
        {"Geneva Identification System", "GEN# +1.00171630"},
        {"Smithsonian Astrophysical Observation", "SAO 210372"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.36755276),
        dec: Angle.Degrees(-34.84535346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20378"},
        {"Hipparcos Number", "HIP 15163"},
        {"Smithsonian Astrophysical Observation", "SAO 194187"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.86631531),
        dec: Angle.Degrees(-34.84365557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31561"},
        {"Hipparcos Number", "HIP 22884"},
        {"Smithsonian Astrophysical Observation", "SAO 195403"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.83827884),
        dec: Angle.Degrees(-34.84362702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85995"},
        {"Hipparcos Number", "HIP 48608"},
        {"Smithsonian Astrophysical Observation", "SAO 200860"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.69530308),
        dec: Angle.Degrees(-34.84337524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44899"},
        {"Geneva Identification System", "GEN# -0.03405622"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.21640250),
        dec: Angle.Degrees(-34.84210835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 240.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112387"},
        {"Hipparcos Number", "HIP 63180"},
        {"Smithsonian Astrophysical Observation", "SAO 203957"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.16220258),
        dec: Angle.Degrees(-34.83983926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14744"},
        {"Hipparcos Number", "HIP 10989"},
        {"Geneva Identification System", "GEN# +1.00014744"},
        {"Smithsonian Astrophysical Observation", "SAO 193661"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.40708321),
        dec: Angle.Degrees(-34.83702058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63471",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63471"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.08757434),
        dec: Angle.Degrees(-34.83656845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -160.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 189.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10532"},
        {"Hipparcos Number", "HIP 7932"},
        {"Geneva Identification System", "GEN# +1.00010532"},
        {"Smithsonian Astrophysical Observation", "SAO 193259"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.49373233),
        dec: Angle.Degrees(-34.83619792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47017"},
        {"Hipparcos Number", "HIP 31397"},
        {"Geneva Identification System", "GEN# +1.00047017"},
        {"Smithsonian Astrophysical Observation", "SAO 196966"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.72500400),
        dec: Angle.Degrees(-34.83617082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175798"},
        {"Hipparcos Number", "HIP 93147"},
        {"Smithsonian Astrophysical Observation", "SAO 210772"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.61491053),
        dec: Angle.Degrees(-34.83523948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108656"},
        {"Hipparcos Number", "HIP 60922"},
        {"Smithsonian Astrophysical Observation", "SAO 203517"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.28411333),
        dec: Angle.Degrees(-34.83436187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54579"},
        {"Hipparcos Number", "HIP 34396"},
        {"Geneva Identification System", "GEN# +1.00054579"},
        {"Smithsonian Astrophysical Observation", "SAO 197613"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.97106857),
        dec: Angle.Degrees(-34.83375919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 148.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16949"},
        {"Hipparcos Number", "HIP 12602"},
        {"Smithsonian Astrophysical Observation", "SAO 193870"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.50682349),
        dec: Angle.Degrees(-34.83294519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22347"},
        {"Hipparcos Number", "HIP 16666"},
        {"Geneva Identification System", "GEN# +1.00022347"},
        {"Smithsonian Astrophysical Observation", "SAO 194380"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.62439947),
        dec: Angle.Degrees(-34.83229352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162725"},
        {"Hipparcos Number", "HIP 87624"},
        {"Geneva Identification System", "GEN# +2.64750088"},
        {"Renson", "Renson 45990"},
        {"Smithsonian Astrophysical Observation", "SAO 209430"},
        {"Wilson Evans Batten Catalogue", "WEB 14787"},
        {"New General Catalogue", "NGC 6475 88"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.49222234),
        dec: Angle.Degrees(-34.83104228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2131"},
        {"Hipparcos Number", "HIP 2011"},
        {"Geneva Identification System", "GEN# +1.00002131"},
        {"Smithsonian Astrophysical Observation", "SAO 192514"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.35955408),
        dec: Angle.Degrees(-34.83038608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 252.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1216"},
        {"Hipparcos Number", "HIP 1305"},
        {"Smithsonian Astrophysical Observation", "SAO 192433"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.09772322),
        dec: Angle.Degrees(-34.82930410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160666"},
        {"Hipparcos Number", "HIP 86682"},
        {"Smithsonian Astrophysical Observation", "SAO 209169"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.66562651),
        dec: Angle.Degrees(-34.82877367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141759"},
        {"Hipparcos Number", "HIP 77713"},
        {"Smithsonian Astrophysical Observation", "SAO 207060"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.99901170),
        dec: Angle.Degrees(-34.82814068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215678"},
        {"Hipparcos Number", "HIP 112517"},
        {"Smithsonian Astrophysical Observation", "SAO 214083"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.86767256),
        dec: Angle.Degrees(-34.82595023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86347"},
        {"Hipparcos Number", "HIP 48781"},
        {"Smithsonian Astrophysical Observation", "SAO 200893"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.24489452),
        dec: Angle.Degrees(-34.82565901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76299"},
        {"Hipparcos Number", "HIP 43705"},
        {"Smithsonian Astrophysical Observation", "SAO 199762"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.50997856),
        dec: Angle.Degrees(-34.82491118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132197"},
        {"Hipparcos Number", "HIP 73319"},
        {"Smithsonian Astrophysical Observation", "SAO 206163"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.73640659),
        dec: Angle.Degrees(-34.82442075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146368"},
        {"Hipparcos Number", "HIP 79818"},
        {"Smithsonian Astrophysical Observation", "SAO 207517"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.36221733),
        dec: Angle.Degrees(-34.81944554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7971"},
        {"Hipparcos Number", "HIP 6122"},
        {"Geneva Identification System", "GEN# +1.00007971"},
        {"Smithsonian Astrophysical Observation", "SAO 193044"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.65136010),
        dec: Angle.Degrees(-34.81888797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29230"},
        {"Hipparcos Number", "HIP 21336"},
        {"Smithsonian Astrophysical Observation", "SAO 195138"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.68243715),
        dec: Angle.Degrees(-34.81868310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97327"},
        {"Hipparcos Number", "HIP 54693"},
        {"Smithsonian Astrophysical Observation", "SAO 202189"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.95442052),
        dec: Angle.Degrees(-34.81819963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42698"},
        {"Hipparcos Number", "HIP 29292"},
        {"Geneva Identification System", "GEN# +1.00042698"},
        {"Smithsonian Astrophysical Observation", "SAO 196559"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.63300343),
        dec: Angle.Degrees(-34.81686102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55838"},
        {"Hipparcos Number", "HIP 34896"},
        {"Smithsonian Astrophysical Observation", "SAO 197709"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.29988244),
        dec: Angle.Degrees(-34.81678782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128085"},
        {"Hipparcos Number", "HIP 71384"},
        {"Smithsonian Astrophysical Observation", "SAO 205732"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.96141802),
        dec: Angle.Degrees(-34.81657915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171119"},
        {"Hipparcos Number", "HIP 91054"},
        {"Smithsonian Astrophysical Observation", "SAO 210321"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.61360814),
        dec: Angle.Degrees(-34.81575363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200143"},
        {"Hipparcos Number", "HIP 103860"},
        {"Smithsonian Astrophysical Observation", "SAO 212657"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.67141547),
        dec: Angle.Degrees(-34.81245074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201449"},
        {"Hipparcos Number", "HIP 104544"},
        {"Smithsonian Astrophysical Observation", "SAO 212770"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.65332621),
        dec: Angle.Degrees(-34.81183812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102148"},
        {"Hipparcos Number", "HIP 57332"},
        {"Geneva Identification System", "GEN# +1.00102148"},
        {"Smithsonian Astrophysical Observation", "SAO 202770"},
        {"Wilson Evans Batten Catalogue", "WEB 10304"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.32701021),
        dec: Angle.Degrees(-34.81013009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179808"},
        {"Hipparcos Number", "HIP 94621"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.82568190),
        dec: Angle.Degrees(-34.80937235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104772"},
        {"Hipparcos Number", "HIP 58822"},
        {"Smithsonian Astrophysical Observation", "SAO 203089"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.96892105),
        dec: Angle.Degrees(-34.80850451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88410"},
        {"Hipparcos Number", "HIP 49855"},
        {"Smithsonian Astrophysical Observation", "SAO 201131"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.71589225),
        dec: Angle.Degrees(-34.80832745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155666"},
        {"Hipparcos Number", "HIP 84337"},
        {"Geneva Identification System", "GEN# +1.00155666"},
        {"Smithsonian Astrophysical Observation", "SAO 208572"},
    },
    visualMagnitude: 8.44,
    bvColour: 2.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.62803388),
        dec: Angle.Degrees(-34.80750237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20623",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20623"},
    },
    visualMagnitude: 12.39,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.27921415),
        dec: Angle.Degrees(-34.80334433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 278.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135369"},
        {"Hipparcos Number", "HIP 74686"},
        {"Geneva Identification System", "GEN# +1.00135369"},
        {"Smithsonian Astrophysical Observation", "SAO 206464"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.95131205),
        dec: Angle.Degrees(-34.80329018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212421"},
        {"Hipparcos Number", "HIP 110639"},
        {"Smithsonian Astrophysical Observation", "SAO 213800"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.18857371),
        dec: Angle.Degrees(-34.80195029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108783"},
        {"Hipparcos Number", "HIP 60996"},
        {"Smithsonian Astrophysical Observation", "SAO 203535"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.52160407),
        dec: Angle.Degrees(-34.80113544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78147"},
        {"Hipparcos Number", "HIP 44621"},
        {"Smithsonian Astrophysical Observation", "SAO 199962"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.39032331),
        dec: Angle.Degrees(-34.79978430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162374"},
        {"Hipparcos Number", "HIP 87460"},
        {"Geneva Identification System", "GEN# +2.64750026"},
        {"Renson", "Renson 45840"},
        {"Smithsonian Astrophysical Observation", "SAO 209383"},
        {"Wilson Evans Batten Catalogue", "WEB 14751"},
        {"New General Catalogue", "NGC 6475 26"},
    },
    visualMagnitude: 5.88,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.05691299),
        dec: Angle.Degrees(-34.79918358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4098",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4098"},
        {"Smithsonian Astrophysical Observation", "SAO 192791"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.15430352),
        dec: Angle.Degrees(-34.79835279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24329"},
        {"Hipparcos Number", "HIP 17997"},
        {"Smithsonian Astrophysical Observation", "SAO 194574"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.71253328),
        dec: Angle.Degrees(-34.79816841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157338"},
        {"Hipparcos Number", "HIP 85158"},
        {"Geneva Identification System", "GEN# +1.00157338"},
        {"Smithsonian Astrophysical Observation", "SAO 208769"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.03643197),
        dec: Angle.Degrees(-34.79800329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6594"},
        {"Hipparcos Number", "HIP 5183"},
        {"Geneva Identification System", "GEN# +1.00006594"},
        {"Smithsonian Astrophysical Observation", "SAO 192922"},
        {"Wilson Evans Batten Catalogue", "WEB 1083"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.57282438),
        dec: Angle.Degrees(-34.79770825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7203"},
        {"Hipparcos Number", "HIP 5600"},
        {"Geneva Identification System", "GEN# +1.00007203"},
        {"Smithsonian Astrophysical Observation", "SAO 192972"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.95707024),
        dec: Angle.Degrees(-34.79698490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159764"},
        {"Hipparcos Number", "HIP 86293"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.48132654),
        dec: Angle.Degrees(-34.79646708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22285"},
        {"Hipparcos Number", "HIP 16631"},
        {"Geneva Identification System", "GEN# +1.00022285"},
        {"Smithsonian Astrophysical Observation", "SAO 194378"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.49575223),
        dec: Angle.Degrees(-34.79632556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128667"},
        {"Hipparcos Number", "HIP 71642"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.81487960),
        dec: Angle.Degrees(-34.79630882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 427"},
        {"Hipparcos Number", "HIP 706"},
        {"Geneva Identification System", "GEN# +1.00000427"},
        {"Smithsonian Astrophysical Observation", "SAO 192369"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.19243127),
        dec: Angle.Degrees(-34.79438791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93366"},
        {"Hipparcos Number", "HIP 52672"},
        {"Smithsonian Astrophysical Observation", "SAO 201728"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.55707114),
        dec: Angle.Degrees(-34.79426049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120306"},
        {"Hipparcos Number", "HIP 67451"},
        {"Smithsonian Astrophysical Observation", "SAO 204874"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.34875480),
        dec: Angle.Degrees(-34.79255953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69122"},
        {"Hipparcos Number", "HIP 40340"},
        {"Geneva Identification System", "GEN# +1.00069122"},
        {"Smithsonian Astrophysical Observation", "SAO 198974"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.54547639),
        dec: Angle.Degrees(-34.79161673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111433"},
        {"Hipparcos Number", "HIP 62591"},
        {"Geneva Identification System", "GEN# +1.00111433"},
        {"Smithsonian Astrophysical Observation", "SAO 203842"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.38542181),
        dec: Angle.Degrees(-34.79116692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88463"},
        {"Hipparcos Number", "HIP 49911"},
        {"Geneva Identification System", "GEN# +1.00088463"},
        {"Smithsonian Astrophysical Observation", "SAO 201144"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.85206697),
        dec: Angle.Degrees(-34.79100352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130131"},
        {"Hipparcos Number", "HIP 72334"},
        {"Smithsonian Astrophysical Observation", "SAO 205944"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.87272672),
        dec: Angle.Degrees(-34.79050347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22560"},
        {"Hipparcos Number", "HIP 16829"},
        {"Smithsonian Astrophysical Observation", "SAO 194397"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.12714588),
        dec: Angle.Degrees(-34.78953806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18821"},
        {"Hipparcos Number", "HIP 14022"},
        {"Smithsonian Astrophysical Observation", "SAO 194030"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.14394045),
        dec: Angle.Degrees(-34.78948950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50697",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50697"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.28797094),
        dec: Angle.Degrees(-34.78855720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17494"},
        {"Hipparcos Number", "HIP 13013"},
        {"Smithsonian Astrophysical Observation", "SAO 193914"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.81901664),
        dec: Angle.Degrees(-34.78746209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125745"},
        {"Hipparcos Number", "HIP 70243"},
        {"Celescope Catalog", "CEL 4316"},
        {"Fundamental Katalog 5th Edition", "FK5 3137"},
        {"Geneva Identification System", "GEN# +1.00125745"},
        {"Smithsonian Astrophysical Observation", "SAO 205485"},
        {"Wilson Evans Batten Catalogue", "WEB 12196"},
    },
    visualMagnitude: 5.57,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.58223947),
        dec: Angle.Degrees(-34.78679152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100782"},
        {"Hipparcos Number", "HIP 56567"},
        {"Smithsonian Astrophysical Observation", "SAO 202609"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.95175745),
        dec: Angle.Degrees(-34.78632522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35592",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35592"},
    },
    visualMagnitude: 11.09,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.17400745),
        dec: Angle.Degrees(-34.78610019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139450"},
        {"Hipparcos Number", "HIP 76675"},
        {"Geneva Identification System", "GEN# +1.00139450"},
        {"Smithsonian Astrophysical Observation", "SAO 206837"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.85550184),
        dec: Angle.Degrees(-34.78000934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107541"},
        {"Hipparcos Number", "HIP 60292"},
        {"Geneva Identification System", "GEN# +1.00107541"},
        {"Smithsonian Astrophysical Observation", "SAO 203387"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.45041034),
        dec: Angle.Degrees(-34.77997450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119102"},
        {"Hipparcos Number", "HIP 66835"},
        {"Smithsonian Astrophysical Observation", "SAO 204742"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.46520922),
        dec: Angle.Degrees(-34.77942308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114336"},
        {"Hipparcos Number", "HIP 64270"},
        {"Smithsonian Astrophysical Observation", "SAO 204188"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.58751554),
        dec: Angle.Degrees(-34.77919096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209326"},
        {"Hipparcos Number", "HIP 108872"},
        {"Smithsonian Astrophysical Observation", "SAO 213499"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.82244375),
        dec: Angle.Degrees(-34.77918183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15063"},
        {"Hipparcos Number", "HIP 11238"},
        {"Smithsonian Astrophysical Observation", "SAO 193691"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.16556526),
        dec: Angle.Degrees(-34.77825441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53952"},
        {"Hipparcos Number", "HIP 34200"},
        {"Geneva Identification System", "GEN# +1.00053952J"},
        {"Smithsonian Astrophysical Observation", "SAO 197557"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.38353593),
        dec: Angle.Degrees(-34.77779761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193301"},
        {"Hipparcos Number", "HIP 100327"},
        {"Smithsonian Astrophysical Observation", "SAO 212022"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.20007483),
        dec: Angle.Degrees(-34.77662453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25921"},
    },
    visualMagnitude: 11.65,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.97180472),
        dec: Angle.Degrees(-34.77589820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168212"},
        {"Hipparcos Number", "HIP 89852"},
        {"Smithsonian Astrophysical Observation", "SAO 210002"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.03754615),
        dec: Angle.Degrees(-34.77466267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104269"},
        {"Hipparcos Number", "HIP 58553"},
        {"Smithsonian Astrophysical Observation", "SAO 203032"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.10253138),
        dec: Angle.Degrees(-34.77437967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215863"},
        {"Hipparcos Number", "HIP 112631"},
        {"Smithsonian Astrophysical Observation", "SAO 214099"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.17013081),
        dec: Angle.Degrees(-34.77310166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160940"},
        {"Hipparcos Number", "HIP 86802"},
        {"Geneva Identification System", "GEN# +1.00160940"},
        {"Smithsonian Astrophysical Observation", "SAO 209204"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.06313601),
        dec: Angle.Degrees(-34.77125559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126977"},
        {"Hipparcos Number", "HIP 70883"},
        {"Smithsonian Astrophysical Observation", "SAO 205612"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.43765445),
        dec: Angle.Degrees(-34.76881982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3109"},
        {"Hipparcos Number", "HIP 2687"},
        {"Geneva Identification System", "GEN# +1.00003109"},
        {"Smithsonian Astrophysical Observation", "SAO 192615"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.53342272),
        dec: Angle.Degrees(-34.76491599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 321369"},
        {"Hipparcos Number", "HIP 88918"},
        {"Smithsonian Astrophysical Observation", "SAO 209768"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.25757474),
        dec: Angle.Degrees(-34.76176513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211367"},
        {"Hipparcos Number", "HIP 110031"},
        {"Smithsonian Astrophysical Observation", "SAO 213696"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.29169392),
        dec: Angle.Degrees(-34.76075049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210851"},
        {"Hipparcos Number", "HIP 109755"},
        {"Geneva Identification System", "GEN# +1.00210851"},
        {"Smithsonian Astrophysical Observation", "SAO 213651"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.47076623),
        dec: Angle.Degrees(-34.75981743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12276"},
        {"Hipparcos Number", "HIP 9317"},
        {"Smithsonian Astrophysical Observation", "SAO 193435"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.92034512),
        dec: Angle.Degrees(-34.75917628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28143"},
        {"Hipparcos Number", "HIP 20613"},
        {"Geneva Identification System", "GEN# +1.00028143"},
        {"Smithsonian Astrophysical Observation", "SAO 194996"},
        {"Wilson Evans Batten Catalogue", "WEB 3949"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.23521947),
        dec: Angle.Degrees(-34.75719492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28013"},
        {"Hipparcos Number", "HIP 20524"},
        {"Geneva Identification System", "GEN# +1.00028013"},
        {"Smithsonian Astrophysical Observation", "SAO 194982"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.97248467),
        dec: Angle.Degrees(-34.75591117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -344.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67334"},
        {"Hipparcos Number", "HIP 39640"},
        {"Celescope Catalog", "CEL 2161"},
        {"Geneva Identification System", "GEN# +1.00067334"},
        {"Smithsonian Astrophysical Observation", "SAO 198797"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.51349333),
        dec: Angle.Degrees(-34.75506031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154855"},
        {"Hipparcos Number", "HIP 83935"},
        {"Smithsonian Astrophysical Observation", "SAO 208476"},
    },
    visualMagnitude: 8.03,
    bvColour: 2.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.34481574),
        dec: Angle.Degrees(-34.75461250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64443"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.12665542),
        dec: Angle.Degrees(-34.75396543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -244.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -274.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13065"},
        {"Hipparcos Number", "HIP 9871"},
        {"Smithsonian Astrophysical Observation", "SAO 193513"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.74881206),
        dec: Angle.Degrees(-34.75376051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102288"},
        {"Hipparcos Number", "HIP 57423"},
        {"Smithsonian Astrophysical Observation", "SAO 202790"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.59205189),
        dec: Angle.Degrees(-34.75345663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162724"},
        {"Hipparcos Number", "HIP 87616"},
        {"Geneva Identification System", "GEN# +2.64750086"},
        {"Smithsonian Astrophysical Observation", "SAO 209428"},
        {"Wilson Evans Batten Catalogue", "WEB 14786"},
        {"New General Catalogue", "NGC 6475 86"},
    },
    visualMagnitude: 6.00,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.47821519),
        dec: Angle.Degrees(-34.75270986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124976"},
        {"Hipparcos Number", "HIP 69832"},
        {"Geneva Identification System", "GEN# +1.00124976"},
        {"Smithsonian Astrophysical Observation", "SAO 205393"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.37769473),
        dec: Angle.Degrees(-34.75131830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217792"},
        {"Hipparcos Number", "HIP 113860"},
        {"Fundamental Katalog 5th Edition", "FK5 1601"},
        {"Geneva Identification System", "GEN# +1.00217792"},
        {"Renson", "Renson 60045"},
        {"Smithsonian Astrophysical Observation", "SAO 214275"},
        {"Wilson Evans Batten Catalogue", "WEB 20226"},
    },
    visualMagnitude: 5.12,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.87401266),
        dec: Angle.Degrees(-34.74961718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197949"},
        {"Hipparcos Number", "HIP 102649"},
        {"Fundamental Katalog 5th Edition", "FK5 5834"},
        {"Smithsonian Astrophysical Observation", "SAO 212446"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.02223747),
        dec: Angle.Degrees(-34.74957897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173902"},
        {"Hipparcos Number", "HIP 92350"},
        {"Geneva Identification System", "GEN# +1.00173902"},
        {"Smithsonian Astrophysical Observation", "SAO 210600"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.32142465),
        dec: Angle.Degrees(-34.74889489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114692"},
        {"Hipparcos Number", "HIP 64444"},
        {"Geneva Identification System", "GEN# +1.00114692"},
        {"Smithsonian Astrophysical Observation", "SAO 204235"},
        {"Wilson Evans Batten Catalogue", "WEB 11390"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.13361096),
        dec: Angle.Degrees(-34.74738803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -250.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -270.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136762"},
        {"Hipparcos Number", "HIP 75332"},
        {"Geneva Identification System", "GEN# +1.00136762"},
        {"Smithsonian Astrophysical Observation", "SAO 206584"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.88689855),
        dec: Angle.Degrees(-34.74529109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101431"},
        {"Hipparcos Number", "HIP 56922"},
        {"Fundamental Katalog 5th Edition", "FK5 439"},
        {"Geneva Identification System", "GEN# +1.00101431"},
        {"Smithsonian Astrophysical Observation", "SAO 202695"},
        {"Wilson Evans Batten Catalogue", "WEB 10249"},
    },
    visualMagnitude: 4.70,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.05341839),
        dec: Angle.Degrees(-34.74465530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225061"},
        {"Hipparcos Number", "HIP 242"},
        {"Geneva Identification System", "GEN# +1.00225061"},
        {"Smithsonian Astrophysical Observation", "SAO 192337"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.75216595),
        dec: Angle.Degrees(-34.74405055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168495"},
        {"Hipparcos Number", "HIP 89970"},
        {"Smithsonian Astrophysical Observation", "SAO 210029"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.35772566),
        dec: Angle.Degrees(-34.74348076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136447"},
        {"Hipparcos Number", "HIP 75186"},
        {"Smithsonian Astrophysical Observation", "SAO 206554"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.47020286),
        dec: Angle.Degrees(-34.74183547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97104"},
    },
    visualMagnitude: 11.19,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.01790006),
        dec: Angle.Degrees(-34.74018065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50900"},
        {"Hipparcos Number", "HIP 33102"},
        {"Geneva Identification System", "GEN# +1.00050900"},
        {"Smithsonian Astrophysical Observation", "SAO 197326"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.41307562),
        dec: Angle.Degrees(-34.73842745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98221"},
        {"Hipparcos Number", "HIP 55164"},
        {"Geneva Identification System", "GEN# +1.00098221"},
        {"Smithsonian Astrophysical Observation", "SAO 202289"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.41201062),
        dec: Angle.Degrees(-34.73730711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196256"},
        {"Hipparcos Number", "HIP 101752"},
        {"Smithsonian Astrophysical Observation", "SAO 212288"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.33990689),
        dec: Angle.Degrees(-34.73560203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25840"},
        {"Hipparcos Number", "HIP 19019"},
        {"Smithsonian Astrophysical Observation", "SAO 194734"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.11435723),
        dec: Angle.Degrees(-34.73535584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109339"},
        {"Hipparcos Number", "HIP 61344"},
        {"Smithsonian Astrophysical Observation", "SAO 203594"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.53958176),
        dec: Angle.Degrees(-34.73504409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74416"},
        {"Hipparcos Number", "HIP 42756"},
        {"Smithsonian Astrophysical Observation", "SAO 199532"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.69998710),
        dec: Angle.Degrees(-34.73406803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130161"},
        {"Hipparcos Number", "HIP 72350"},
        {"Geneva Identification System", "GEN# +1.00130161"},
        {"Smithsonian Astrophysical Observation", "SAO 205947"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.91922553),
        dec: Angle.Degrees(-34.73349082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27703"},
        {"Hipparcos Number", "HIP 20289"},
        {"Geneva Identification System", "GEN# +1.00027703"},
        {"Smithsonian Astrophysical Observation", "SAO 194943"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.22585784),
        dec: Angle.Degrees(-34.73235007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24626"},
        {"Hipparcos Number", "HIP 18213"},
        {"Fundamental Katalog 5th Edition", "FK5 2278"},
        {"Geneva Identification System", "GEN# +1.00024626"},
        {"Smithsonian Astrophysical Observation", "SAO 194608"},
        {"Wilson Evans Batten Catalogue", "WEB 3513"},
    },
    visualMagnitude: 5.11,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.41218403),
        dec: Angle.Degrees(-34.73229529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71913"},
        {"Hipparcos Number", "HIP 41586"},
        {"Celescope Catalog", "CEL 2548"},
        {"Geneva Identification System", "GEN# +1.00071913"},
        {"Smithsonian Astrophysical Observation", "SAO 199276"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.17920161),
        dec: Angle.Degrees(-34.73162569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162586"},
        {"Hipparcos Number", "HIP 87567"},
        {"Geneva Identification System", "GEN# +2.64750056"},
        {"Smithsonian Astrophysical Observation", "SAO 209411"},
        {"Wilson Evans Batten Catalogue", "WEB 14769"},
        {"New General Catalogue", "NGC 6475 56"},
    },
    visualMagnitude: 6.14,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.33157778),
        dec: Angle.Degrees(-34.73079237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164887"},
        {"Hipparcos Number", "HIP 88542"},
        {"Smithsonian Astrophysical Observation", "SAO 209672"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.20266064),
        dec: Angle.Degrees(-34.72959201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162780"},
        {"Hipparcos Number", "HIP 87656"},
        {"Geneva Identification System", "GEN# +2.64750104"},
        {"Renson", "Renson 46020"},
        {"Smithsonian Astrophysical Observation", "SAO 209436"},
        {"Wilson Evans Batten Catalogue", "WEB 14792"},
        {"New General Catalogue", "NGC 6475 104"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.55990674),
        dec: Angle.Degrees(-34.72763427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219582"},
        {"Hipparcos Number", "HIP 114966"},
        {"Geneva Identification System", "GEN# +1.00219582"},
        {"Smithsonian Astrophysical Observation", "SAO 214430"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.28052852),
        dec: Angle.Degrees(-34.72626050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41935"},
        {"Hipparcos Number", "HIP 28934"},
        {"Geneva Identification System", "GEN# +1.00041935"},
        {"Smithsonian Astrophysical Observation", "SAO 196498"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.60264920),
        dec: Angle.Degrees(-34.72324606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37376"},
        {"Hipparcos Number", "HIP 26343"},
        {"Smithsonian Astrophysical Observation", "SAO 196011"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.14629873),
        dec: Angle.Degrees(-34.72262800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60097"},
        {"Hipparcos Number", "HIP 36588"},
        {"Smithsonian Astrophysical Observation", "SAO 198088"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.87639337),
        dec: Angle.Degrees(-34.72093134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29861"},
    },
    visualMagnitude: 12.38,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.32266880),
        dec: Angle.Degrees(-34.71808321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51485"},
        {"Hipparcos Number", "HIP 33342"},
        {"Geneva Identification System", "GEN# +1.00051485"},
        {"Smithsonian Astrophysical Observation", "SAO 197377"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.01284065),
        dec: Angle.Degrees(-34.71708438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193995"},
        {"Hipparcos Number", "HIP 100649"},
        {"Geneva Identification System", "GEN# +1.00193995"},
        {"Smithsonian Astrophysical Observation", "SAO 212088"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.12733188),
        dec: Angle.Degrees(-34.71594014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196700"},
        {"Hipparcos Number", "HIP 101996"},
        {"Smithsonian Astrophysical Observation", "SAO 212329"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.04712120),
        dec: Angle.Degrees(-34.71581046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38768",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38768"},
        {"Smithsonian Astrophysical Observation", "SAO 198608"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.04137358),
        dec: Angle.Degrees(-34.71050144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140008"},
        {"Hipparcos Number", "HIP 76945"},
        {"Geneva Identification System", "GEN# +1.00140008"},
        {"Smithsonian Astrophysical Observation", "SAO 206889"},
        {"Wilson Evans Batten Catalogue", "WEB 13049"},
    },
    visualMagnitude: 4.75,
    bvColour: -0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.67098805),
        dec: Angle.Degrees(-34.71033325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107296",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107296"},
        {"Smithsonian Astrophysical Observation", "SAO 213241"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.99154292),
        dec: Angle.Degrees(-34.71008701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103567"},
        {"Smithsonian Astrophysical Observation", "SAO 212592"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.76471311),
        dec: Angle.Degrees(-34.70986708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190706"},
        {"Hipparcos Number", "HIP 99132"},
        {"Geneva Identification System", "GEN# +1.00190706"},
        {"Smithsonian Astrophysical Observation", "SAO 211824"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.88349311),
        dec: Angle.Degrees(-34.70806374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164034"},
        {"Hipparcos Number", "HIP 88206"},
        {"Smithsonian Astrophysical Observation", "SAO 209588"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.19177367),
        dec: Angle.Degrees(-34.70757804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90850"},
    },
    visualMagnitude: 10.91,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.00575417),
        dec: Angle.Degrees(-34.70619753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64379"},
        {"Hipparcos Number", "HIP 38423"},
        {"Celescope Catalog", "CEL 2068"},
        {"Geneva Identification System", "GEN# +1.00064379"},
        {"Smithsonian Astrophysical Observation", "SAO 198540"},
        {"Wilson Evans Batten Catalogue", "WEB 7557"},
    },
    visualMagnitude: 5.01,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.06584635),
        dec: Angle.Degrees(-34.70602121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 238.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171450"},
        {"Hipparcos Number", "HIP 91216"},
        {"Smithsonian Astrophysical Observation", "SAO 210363"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.11406579),
        dec: Angle.Degrees(-34.70495075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105686"},
        {"Hipparcos Number", "HIP 59307"},
        {"Geneva Identification System", "GEN# +1.00105686"},
        {"Smithsonian Astrophysical Observation", "SAO 203183"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.51075478),
        dec: Angle.Degrees(-34.70473605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53911"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.46647431),
        dec: Angle.Degrees(-34.70469788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148703"},
        {"Hipparcos Number", "HIP 80911"},
        {"Fundamental Katalog 5th Edition", "FK5 1431"},
        {"Geneva Identification System", "GEN# +1.00148703"},
        {"Smithsonian Astrophysical Observation", "SAO 207732"},
        {"Wilson Evans Batten Catalogue", "WEB 13685"},
    },
    visualMagnitude: 4.24,
    bvColour: -0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.84558957),
        dec: Angle.Degrees(-34.70432087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15232"},
        {"Hipparcos Number", "HIP 11362"},
        {"Smithsonian Astrophysical Observation", "SAO 193706"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.56949548),
        dec: Angle.Degrees(-34.70105290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90548"},
        {"Hipparcos Number", "HIP 51112"},
        {"Smithsonian Astrophysical Observation", "SAO 201393"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.64447630),
        dec: Angle.Degrees(-34.70082201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35046"},
        {"Hipparcos Number", "HIP 24909"},
        {"Geneva Identification System", "GEN# +1.00035046"},
        {"Smithsonian Astrophysical Observation", "SAO 195763"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.08627558),
        dec: Angle.Degrees(-34.69885053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127587"},
        {"Hipparcos Number", "HIP 71151"},
        {"Smithsonian Astrophysical Observation", "SAO 205677"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.28513245),
        dec: Angle.Degrees(-34.69853500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189118"},
        {"Hipparcos Number", "HIP 98421"},
        {"Geneva Identification System", "GEN# +1.00189118"},
        {"Renson", "Renson 52320"},
        {"Smithsonian Astrophysical Observation", "SAO 211717"},
        {"Wilson Evans Batten Catalogue", "WEB 17372"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.96366659),
        dec: Angle.Degrees(-34.69763103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74415"},
        {"Hipparcos Number", "HIP 42751"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.69176846),
        dec: Angle.Degrees(-34.69750349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222434"},
        {"Hipparcos Number", "HIP 116825"},
        {"Geneva Identification System", "GEN# +1.00222434"},
        {"Smithsonian Astrophysical Observation", "SAO 214702"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.17295897),
        dec: Angle.Degrees(-34.69615552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157486"},
        {"Hipparcos Number", "HIP 85237"},
        {"Geneva Identification System", "GEN# +1.00157486"},
        {"Renson", "Renson 44230"},
        {"Smithsonian Astrophysical Observation", "SAO 208786"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.26111805),
        dec: Angle.Degrees(-34.69600968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66308"},
        {"Hipparcos Number", "HIP 39254"},
        {"Geneva Identification System", "GEN# +1.00066308"},
        {"Smithsonian Astrophysical Observation", "SAO 198712"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.41520173),
        dec: Angle.Degrees(-34.69482777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220111"},
        {"Hipparcos Number", "HIP 115319"},
        {"Smithsonian Astrophysical Observation", "SAO 214485"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.34927655),
        dec: Angle.Degrees(-34.69362433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52784"},
        {"Geneva Identification System", "GEN# -0.03406982"},
    },
    visualMagnitude: 11.32,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.87322754),
        dec: Angle.Degrees(-34.69237325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -282.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192014"},
        {"Hipparcos Number", "HIP 99712"},
        {"Smithsonian Astrophysical Observation", "SAO 211922"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.50083387),
        dec: Angle.Degrees(-34.69191142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223666"},
        {"Hipparcos Number", "HIP 117655"},
        {"Fundamental Katalog 5th Edition", "FK5 3917"},
        {"Geneva Identification System", "GEN# +1.00223666"},
        {"Smithsonian Astrophysical Observation", "SAO 214824"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.91386321),
        dec: Angle.Degrees(-34.69152741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37549"},
        {"Hipparcos Number", "HIP 26466"},
        {"Smithsonian Astrophysical Observation", "SAO 196033"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.45035929),
        dec: Angle.Degrees(-34.68968252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167846"},
        {"Hipparcos Number", "HIP 89708"},
        {"Geneva Identification System", "GEN# +1.00167846"},
        {"Smithsonian Astrophysical Observation", "SAO 209978"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.62696238),
        dec: Angle.Degrees(-34.68610282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114919"},
        {"Hipparcos Number", "HIP 64576"},
        {"Smithsonian Astrophysical Observation", "SAO 204265"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.54505279),
        dec: Angle.Degrees(-34.68537550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140784"},
        {"Hipparcos Number", "HIP 77286"},
        {"Geneva Identification System", "GEN# +1.00140784J"},
        {"Smithsonian Astrophysical Observation", "SAO 206962"},
        {"Wilson Evans Batten Catalogue", "WEB 13093"},
    },
    visualMagnitude: 5.61,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.68429408),
        dec: Angle.Degrees(-34.68238898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127254"},
        {"Hipparcos Number", "HIP 70993"},
        {"Geneva Identification System", "GEN# +1.00127254"},
        {"Smithsonian Astrophysical Observation", "SAO 205639"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.80455777),
        dec: Angle.Degrees(-34.68109124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205695"},
        {"Hipparcos Number", "HIP 106813"},
        {"Smithsonian Astrophysical Observation", "SAO 213150"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.49750685),
        dec: Angle.Degrees(-34.67898174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125509"},
        {"Hipparcos Number", "HIP 70097"},
        {"Celescope Catalog", "CEL 4315"},
        {"Geneva Identification System", "GEN# +1.00125509"},
        {"Smithsonian Astrophysical Observation", "SAO 205456"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.15571216),
        dec: Angle.Degrees(-34.67787675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6340"},
        {"Hipparcos Number", "HIP 4993"},
        {"Geneva Identification System", "GEN# +1.00006340"},
        {"Smithsonian Astrophysical Observation", "SAO 192900"},
        {"Wilson Evans Batten Catalogue", "WEB 1010"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.99936494),
        dec: Angle.Degrees(-34.67673632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126370"},
        {"Hipparcos Number", "HIP 70555"},
        {"Smithsonian Astrophysical Observation", "SAO 205548"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.48956343),
        dec: Angle.Degrees(-34.67551407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213770"},
        {"Hipparcos Number", "HIP 111425"},
        {"Geneva Identification System", "GEN# +1.00213770"},
        {"Smithsonian Astrophysical Observation", "SAO 213924"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.61280849),
        dec: Angle.Degrees(-34.67525415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105434"},
        {"Hipparcos Number", "HIP 59192"},
        {"Smithsonian Astrophysical Observation", "SAO 203162"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.08113114),
        dec: Angle.Degrees(-34.67495161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188181"},
        {"Hipparcos Number", "HIP 98042"},
        {"Smithsonian Astrophysical Observation", "SAO 211654"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.83751472),
        dec: Angle.Degrees(-34.67447153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5004"},
        {"Geneva Identification System", "GEN# +9.80269087"},
        {"Geneva Identification System 2", "GEN# -0.03500360"},
        {"Smithsonian Astrophysical Observation", "SAO 192901"},
        {"Wilson Evans Batten Catalogue", "WEB 1017"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.02363166),
        dec: Angle.Degrees(-34.67406283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 646.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -266.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116374"},
        {"Cincinnati Publication", "Ci 20 1434"},
        {"Geneva Identification System", "GEN# -0.03515842"},
        {"Smithsonian Astrophysical Observation", "SAO 214633"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.71726620),
        dec: Angle.Degrees(-34.66964020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 458.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38170"},
        {"Hipparcos Number", "HIP 26868"},
        {"Geneva Identification System", "GEN# +1.00038170"},
        {"Renson", "Renson 10256"},
        {"Smithsonian Astrophysical Observation", "SAO 196098"},
        {"Wilson Evans Batten Catalogue", "WEB 5296"},
    },
    visualMagnitude: 5.29,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.56329561),
        dec: Angle.Degrees(-34.66793677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98048"},
        {"Hipparcos Number", "HIP 55063"},
        {"Smithsonian Astrophysical Observation", "SAO 202266"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.08262841),
        dec: Angle.Degrees(-34.66789500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190268"},
        {"Hipparcos Number", "HIP 98951"},
        {"Smithsonian Astrophysical Observation", "SAO 211796"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.35770641),
        dec: Angle.Degrees(-34.66680979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5531"},
        {"Hipparcos Number", "HIP 4434"},
        {"Geneva Identification System", "GEN# +1.00005531"},
        {"Smithsonian Astrophysical Observation", "SAO 192829"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.18668031),
        dec: Angle.Degrees(-34.66567965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149335"},
        {"Hipparcos Number", "HIP 81233"},
        {"Geneva Identification System", "GEN# +1.00149335"},
        {"Smithsonian Astrophysical Observation", "SAO 207799"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.87029086),
        dec: Angle.Degrees(-34.66554095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8381"},
        {"Hipparcos Number", "HIP 6426"},
        {"Geneva Identification System", "GEN# +1.00008381"},
        {"Smithsonian Astrophysical Observation", "SAO 193076"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.61675983),
        dec: Angle.Degrees(-34.66463761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187210"},
        {"Hipparcos Number", "HIP 97604"},
        {"Smithsonian Astrophysical Observation", "SAO 211589"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.57045494),
        dec: Angle.Degrees(-34.66391811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7817"},
        {"Hipparcos Number", "HIP 6011"},
        {"Geneva Identification System", "GEN# +1.00007817"},
        {"Smithsonian Astrophysical Observation", "SAO 193027"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.32454584),
        dec: Angle.Degrees(-34.66377733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198697"},
        {"Hipparcos Number", "HIP 103091"},
        {"Geneva Identification System", "GEN# +1.00198697"},
        {"Smithsonian Astrophysical Observation", "SAO 212519"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.32309758),
        dec: Angle.Degrees(-34.66217505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139542"},
        {"Hipparcos Number", "HIP 76712"},
        {"Smithsonian Astrophysical Observation", "SAO 206846"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.97099226),
        dec: Angle.Degrees(-34.65665517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145537"},
        {"Hipparcos Number", "HIP 79458"},
        {"Geneva Identification System", "GEN# +1.00145537"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.22713952),
        dec: Angle.Degrees(-34.65566103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84651"},
        {"Hipparcos Number", "HIP 47907"},
        {"Smithsonian Astrophysical Observation", "SAO 200706"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.45178335),
        dec: Angle.Degrees(-34.65390725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 132"},
        {"Smithsonian Astrophysical Observation", "SAO 214929"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.42200516),
        dec: Angle.Degrees(-34.65350786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19546"},
        {"Hipparcos Number", "HIP 14523"},
        {"Smithsonian Astrophysical Observation", "SAO 194099"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.88685898),
        dec: Angle.Degrees(-34.65334349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217305"},
        {"Hipparcos Number", "HIP 113573"},
        {"Geneva Identification System", "GEN# +1.00217305"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.05978489),
        dec: Angle.Degrees(-34.65265692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104471"},
        {"Hipparcos Number", "HIP 58669"},
        {"Geneva Identification System", "GEN# +1.00104471J"},
        {"Smithsonian Astrophysical Observation", "SAO 203046"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.44261302),
        dec: Angle.Degrees(-34.65034316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15975"},
        {"Hipparcos Number", "HIP 11867"},
        {"Fundamental Katalog 5th Edition", "FK5 88"},
        {"Geneva Identification System", "GEN# +1.00015975"},
        {"Smithsonian Astrophysical Observation", "SAO 193763"},
        {"Wilson Evans Batten Catalogue", "WEB 2456"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.27932880),
        dec: Angle.Degrees(-34.64992327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22661"},
        {"Hipparcos Number", "HIP 16892"},
        {"Geneva Identification System", "GEN# +1.00022661"},
        {"Smithsonian Astrophysical Observation", "SAO 194410"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.33877427),
        dec: Angle.Degrees(-34.64968229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72771"},
        {"Hipparcos Number", "HIP 41980"},
        {"Celescope Catalog", "CEL 2640"},
        {"Geneva Identification System", "GEN# +1.00072771"},
        {"Smithsonian Astrophysical Observation", "SAO 199362"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.35027283),
        dec: Angle.Degrees(-34.64871083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100910"},
        {"Hipparcos Number", "HIP 56623"},
        {"Geneva Identification System", "GEN# +1.00100910"},
        {"Smithsonian Astrophysical Observation", "SAO 202625"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.15673826),
        dec: Angle.Degrees(-34.64676822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -215.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 121.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159683"},
        {"Hipparcos Number", "HIP 86256"},
        {"Smithsonian Astrophysical Observation", "SAO 209042"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.38450787),
        dec: Angle.Degrees(-34.64616260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208181"},
        {"Hipparcos Number", "HIP 108206"},
        {"Smithsonian Astrophysical Observation", "SAO 213396"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.83439096),
        dec: Angle.Degrees(-34.64545122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175163"},
        {"Hipparcos Number", "HIP 92892"},
        {"Smithsonian Astrophysical Observation", "SAO 210719"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.89995301),
        dec: Angle.Degrees(-34.64459283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21034"},
        {"Hipparcos Number", "HIP 15718"},
        {"Smithsonian Astrophysical Observation", "SAO 194263"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.60962226),
        dec: Angle.Degrees(-34.64087234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118105"},
        {"Hipparcos Number", "HIP 66304"},
        {"Smithsonian Astrophysical Observation", "SAO 204626"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.83375709),
        dec: Angle.Degrees(-34.64065225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117433"},
        {"Smithsonian Astrophysical Observation", "SAO 214787"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.17081979),
        dec: Angle.Degrees(-34.64008729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42165"},
        {"Hipparcos Number", "HIP 29047"},
        {"Smithsonian Astrophysical Observation", "SAO 196516"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.92296022),
        dec: Angle.Degrees(-34.63995286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5825"},
        {"Hipparcos Number", "HIP 4628"},
        {"Geneva Identification System", "GEN# +1.00005825"},
        {"Smithsonian Astrophysical Observation", "SAO 192850"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.85601657),
        dec: Angle.Degrees(-34.63633106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37812"},
        {"Hipparcos Number", "HIP 26636"},
        {"Smithsonian Astrophysical Observation", "SAO 196060"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.92494632),
        dec: Angle.Degrees(-34.63592547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216290"},
        {"Hipparcos Number", "HIP 112925"},
        {"Renson", "Renson 59770"},
        {"Smithsonian Astrophysical Observation", "SAO 214147"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.04473732),
        dec: Angle.Degrees(-34.63416736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72688"},
        {"Hipparcos Number", "HIP 41939"},
        {"Geneva Identification System", "GEN# +1.00072688"},
        {"Smithsonian Astrophysical Observation", "SAO 199353"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.24380764),
        dec: Angle.Degrees(-34.63404652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139449"},
        {"Hipparcos Number", "HIP 76680"},
        {"Geneva Identification System", "GEN# +1.00139449"},
        {"Smithsonian Astrophysical Observation", "SAO 206839"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.86435580),
        dec: Angle.Degrees(-34.63276004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97721"},
        {"Hipparcos Number", "HIP 54881"},
        {"Smithsonian Astrophysical Observation", "SAO 202225"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.56060598),
        dec: Angle.Degrees(-34.63233933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131751"},
        {"Hipparcos Number", "HIP 73108"},
        {"Geneva Identification System", "GEN# +1.00131751J"},
        {"Smithsonian Astrophysical Observation", "SAO 206111"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.12825072),
        dec: Angle.Degrees(-34.63173460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86953"},
        {"Hipparcos Number", "HIP 49089"},
        {"Smithsonian Astrophysical Observation", "SAO 200961"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.29225487),
        dec: Angle.Degrees(-34.63017078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200750"},
        {"Hipparcos Number", "HIP 104173"},
        {"Smithsonian Astrophysical Observation", "SAO 212715"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.59958540),
        dec: Angle.Degrees(-34.62877351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32365"},
        {"Smithsonian Astrophysical Observation", "SAO 197174"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.34450561),
        dec: Angle.Degrees(-34.62811831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143462"},
        {"Hipparcos Number", "HIP 78518"},
        {"Smithsonian Astrophysical Observation", "SAO 207243"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.44721004),
        dec: Angle.Degrees(-34.62721845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208147"},
        {"Hipparcos Number", "HIP 108188"},
        {"Geneva Identification System", "GEN# +1.00208147"},
        {"Smithsonian Astrophysical Observation", "SAO 213390"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.78370391),
        dec: Angle.Degrees(-34.62623322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146497"},
        {"Hipparcos Number", "HIP 79855"},
        {"Smithsonian Astrophysical Observation", "SAO 207522"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.50993163),
        dec: Angle.Degrees(-34.62479919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75112"},
        {"Hipparcos Number", "HIP 43114"},
        {"Celescope Catalog", "CEL 2893"},
        {"Geneva Identification System", "GEN# +1.00075112"},
        {"Smithsonian Astrophysical Observation", "SAO 199607"},
    },
    visualMagnitude: 6.33,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.70520725),
        dec: Angle.Degrees(-34.62295882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162576"},
        {"Hipparcos Number", "HIP 87560"},
        {"Geneva Identification System", "GEN# +2.64750055"},
        {"Renson", "Renson 45860"},
        {"Smithsonian Astrophysical Observation", "SAO 209409"},
        {"New General Catalogue", "NGC 6475 55"},
    },
    visualMagnitude: 6.96,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.31657043),
        dec: Angle.Degrees(-34.62083536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124221"},
        {"Hipparcos Number", "HIP 69443"},
        {"Smithsonian Astrophysical Observation", "SAO 205312"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.25756387),
        dec: Angle.Degrees(-34.62074523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89528"},
        {"Hipparcos Number", "HIP 50525"},
        {"Smithsonian Astrophysical Observation", "SAO 201275"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.79505945),
        dec: Angle.Degrees(-34.61655191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186875"},
        {"Hipparcos Number", "HIP 97443"},
        {"Smithsonian Astrophysical Observation", "SAO 211565"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.08335622),
        dec: Angle.Degrees(-34.61638148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36038"},
        {"Hipparcos Number", "HIP 25504"},
        {"Geneva Identification System", "GEN# +1.00036038"},
        {"Smithsonian Astrophysical Observation", "SAO 195868"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.81098460),
        dec: Angle.Degrees(-34.61435206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150909"},
        {"Hipparcos Number", "HIP 82033"},
        {"Smithsonian Astrophysical Observation", "SAO 207996"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.36468118),
        dec: Angle.Degrees(-34.61381806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129031"},
        {"Hipparcos Number", "HIP 71804"},
        {"Smithsonian Astrophysical Observation", "SAO 205829"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.32092108),
        dec: Angle.Degrees(-34.61294038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158021"},
        {"Hipparcos Number", "HIP 85488"},
        {"Smithsonian Astrophysical Observation", "SAO 208851"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.06307656),
        dec: Angle.Degrees(-34.61094737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12144"},
    },
    visualMagnitude: 11.95,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.13553275),
        dec: Angle.Degrees(-34.60783053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 309.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -397.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63480"},
        {"Smithsonian Astrophysical Observation", "SAO 204024"},
    },
    visualMagnitude: 10.60,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.10766961),
        dec: Angle.Degrees(-34.60693447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220415"},
        {"Hipparcos Number", "HIP 115497"},
        {"Smithsonian Astrophysical Observation", "SAO 214514"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.94127369),
        dec: Angle.Degrees(-34.60371589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75199"},
        {"Hipparcos Number", "HIP 43156"},
        {"Smithsonian Astrophysical Observation", "SAO 199619"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.84947119),
        dec: Angle.Degrees(-34.60038754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115311"},
        {"Hipparcos Number", "HIP 64804"},
        {"Geneva Identification System", "GEN# +1.00115311J"},
        {"Smithsonian Astrophysical Observation", "SAO 204311"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.22345516),
        dec: Angle.Degrees(-34.59839183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73475",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73475"},
    },
    visualMagnitude: 11.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.25203427),
        dec: Angle.Degrees(-34.59771665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121187"},
        {"Hipparcos Number", "HIP 67918"},
        {"Geneva Identification System", "GEN# +1.00121187"},
        {"Smithsonian Astrophysical Observation", "SAO 204977"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.66014266),
        dec: Angle.Degrees(-34.59734987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71572"},
        {"Hipparcos Number", "HIP 41410"},
        {"Smithsonian Astrophysical Observation", "SAO 199234"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.70325532),
        dec: Angle.Degrees(-34.59726940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167147"},
        {"Hipparcos Number", "HIP 89463"},
        {"Smithsonian Astrophysical Observation", "SAO 209916"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.86383196),
        dec: Angle.Degrees(-34.59450262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202931"},
        {"Hipparcos Number", "HIP 105330"},
        {"Geneva Identification System", "GEN# +1.00202931"},
        {"Smithsonian Astrophysical Observation", "SAO 212909"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.02735374),
        dec: Angle.Degrees(-34.59368286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66793"},
        {"Hipparcos Number", "HIP 39441"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.94339185),
        dec: Angle.Degrees(-34.59220730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10433"},
        {"Hipparcos Number", "HIP 7857"},
        {"Geneva Identification System", "GEN# +1.00010433"},
        {"Smithsonian Astrophysical Observation", "SAO 193252"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.26297303),
        dec: Angle.Degrees(-34.59130730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70235"},
        {"Hipparcos Number", "HIP 40787"},
        {"Celescope Catalog", "CEL 2369"},
        {"Geneva Identification System", "GEN# +1.00070235"},
        {"Renson", "Renson 19380"},
        {"Smithsonian Astrophysical Observation", "SAO 199084"},
    },
    visualMagnitude: 6.44,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.87299244),
        dec: Angle.Degrees(-34.59014713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153005"},
        {"Hipparcos Number", "HIP 83067"},
        {"Smithsonian Astrophysical Observation", "SAO 208249"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.60080579),
        dec: Angle.Degrees(-34.58968511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34206"},
        {"Hipparcos Number", "HIP 24407"},
        {"Smithsonian Astrophysical Observation", "SAO 195675"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.54235646),
        dec: Angle.Degrees(-34.58812451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 320448"},
        {"Hipparcos Number", "HIP 86947"},
        {"Smithsonian Astrophysical Observation", "SAO 209230"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.50364333),
        dec: Angle.Degrees(-34.58571035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193194"},
        {"Hipparcos Number", "HIP 100266"},
        {"Smithsonian Astrophysical Observation", "SAO 212015"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.06028459),
        dec: Angle.Degrees(-34.58516243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161649"},
        {"Hipparcos Number", "HIP 87134"},
        {"Geneva Identification System", "GEN# +1.00161649"},
        {"Smithsonian Astrophysical Observation", "SAO 209269"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.04689060),
        dec: Angle.Degrees(-34.58193950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115816"},
        {"Hipparcos Number", "HIP 65054"},
        {"Smithsonian Astrophysical Observation", "SAO 204363"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.02112123),
        dec: Angle.Degrees(-34.57948473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68860"},
        {"Hipparcos Number", "HIP 40233"},
        {"Geneva Identification System", "GEN# +1.00068860"},
        {"Smithsonian Astrophysical Observation", "SAO 198944"},
        {"Wilson Evans Batten Catalogue", "WEB 7847"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.26757614),
        dec: Angle.Degrees(-34.57853383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16417"},
        {"Hipparcos Number", "HIP 12186"},
        {"Geneva Identification System", "GEN# +1.00016417"},
        {"Smithsonian Astrophysical Observation", "SAO 193811"},
        {"Wilson Evans Batten Catalogue", "WEB 2504"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.24425358),
        dec: Angle.Degrees(-34.57734519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -259.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135619"},
        {"Hipparcos Number", "HIP 74797"},
        {"Smithsonian Astrophysical Observation", "SAO 206484"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.29467562),
        dec: Angle.Degrees(-34.57701976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206009"},
        {"Hipparcos Number", "HIP 106989"},
        {"Smithsonian Astrophysical Observation", "SAO 213188"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.02642926),
        dec: Angle.Degrees(-34.57465198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173284"},
        {"Hipparcos Number", "HIP 92070"},
        {"Smithsonian Astrophysical Observation", "SAO 210543"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.48237466),
        dec: Angle.Degrees(-34.57460247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153889"},
        {"Hipparcos Number", "HIP 83472"},
        {"Smithsonian Astrophysical Observation", "SAO 208352"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.89937681),
        dec: Angle.Degrees(-34.57396872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57915"},
        {"Hipparcos Number", "HIP 35691"},
        {"Smithsonian Astrophysical Observation", "SAO 197895"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.46377505),
        dec: Angle.Degrees(-34.57200455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15109"},
        {"Hipparcos Number", "HIP 11267"},
        {"Smithsonian Astrophysical Observation", "SAO 193697"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.27212786),
        dec: Angle.Degrees(-34.56953060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148336"},
        {"Hipparcos Number", "HIP 80716"},
        {"Smithsonian Astrophysical Observation", "SAO 207697"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.20129708),
        dec: Angle.Degrees(-34.56810043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219058"},
        {"Hipparcos Number", "HIP 114621"},
        {"Smithsonian Astrophysical Observation", "SAO 214388"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.30642299),
        dec: Angle.Degrees(-34.56735051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77341"},
        {"Hipparcos Number", "HIP 44261"},
        {"Smithsonian Astrophysical Observation", "SAO 199882"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.20420225),
        dec: Angle.Degrees(-34.56702635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211521"},
        {"Hipparcos Number", "HIP 110110"},
        {"Smithsonian Astrophysical Observation", "SAO 213714"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.57394249),
        dec: Angle.Degrees(-34.56672702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19876"},
        {"Hipparcos Number", "HIP 14760"},
        {"Smithsonian Astrophysical Observation", "SAO 194132"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.65233924),
        dec: Angle.Degrees(-34.56671503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39332"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.61454052),
        dec: Angle.Degrees(-34.56655314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1899"},
        {"Hipparcos Number", "HIP 1827"},
        {"Smithsonian Astrophysical Observation", "SAO 192494"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.78394752),
        dec: Angle.Degrees(-34.56513359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216593"},
        {"Hipparcos Number", "HIP 113130"},
        {"Smithsonian Astrophysical Observation", "SAO 214176"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.64655608),
        dec: Angle.Degrees(-34.56432807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94853"},
        {"Hipparcos Number", "HIP 53487"},
        {"Geneva Identification System", "GEN# +1.00094853"},
        {"Smithsonian Astrophysical Observation", "SAO 201922"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.13008398),
        dec: Angle.Degrees(-34.56402545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147401"},
        {"Hipparcos Number", "HIP 80278"},
        {"Smithsonian Astrophysical Observation", "SAO 207615"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.80248617),
        dec: Angle.Degrees(-34.56382174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68788"},
        {"Smithsonian Astrophysical Observation", "SAO 205146"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.20068692),
        dec: Angle.Degrees(-34.56311636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188550"},
        {"Hipparcos Number", "HIP 98184"},
        {"Smithsonian Astrophysical Observation", "SAO 211680"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.28612782),
        dec: Angle.Degrees(-34.56205423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198504"},
        {"Hipparcos Number", "HIP 102979"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.95698464),
        dec: Angle.Degrees(-34.56106803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39191"},
        {"Hipparcos Number", "HIP 27489"},
        {"Smithsonian Astrophysical Observation", "SAO 196209"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.31382890),
        dec: Angle.Degrees(-34.56075568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39718"},
        {"Hipparcos Number", "HIP 27788"},
        {"Geneva Identification System", "GEN# +1.00039718"},
        {"Smithsonian Astrophysical Observation", "SAO 196270"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.20497939),
        dec: Angle.Degrees(-34.56046656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157693"},
        {"Hipparcos Number", "HIP 85322"},
        {"Geneva Identification System", "GEN# +1.00157693"},
        {"Smithsonian Astrophysical Observation", "SAO 208811"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.54055411),
        dec: Angle.Degrees(-34.55738301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210050"},
        {"Hipparcos Number", "HIP 109282"},
        {"Smithsonian Astrophysical Observation", "SAO 213575"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.08066988),
        dec: Angle.Degrees(-34.55584789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61305"},
    },
    visualMagnitude: 11.62,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.40456120),
        dec: Angle.Degrees(-34.55502132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39295"},
        {"Hipparcos Number", "HIP 27551"},
        {"Smithsonian Astrophysical Observation", "SAO 196221"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.51302434),
        dec: Angle.Degrees(-34.55366409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214064"},
        {"Hipparcos Number", "HIP 111579"},
        {"Smithsonian Astrophysical Observation", "SAO 213946"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.07419674),
        dec: Angle.Degrees(-34.55178074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208871"},
        {"Hipparcos Number", "HIP 108593"},
        {"Smithsonian Astrophysical Observation", "SAO 213462"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.97163759),
        dec: Angle.Degrees(-34.55057903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202843"},
        {"Hipparcos Number", "HIP 105293"},
        {"Smithsonian Astrophysical Observation", "SAO 212903"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.90790573),
        dec: Angle.Degrees(-34.54967626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22985"},
        {"Hipparcos Number", "HIP 17124"},
        {"Geneva Identification System", "GEN# +1.00022985"},
        {"Smithsonian Astrophysical Observation", "SAO 194440"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.01227897),
        dec: Angle.Degrees(-34.54946981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173860"},
        {"Hipparcos Number", "HIP 92327"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.25947607),
        dec: Angle.Degrees(-34.54896075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95641"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.81606699),
        dec: Angle.Degrees(-34.54681590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66583"},
        {"Hipparcos Number", "HIP 39365"},
        {"Smithsonian Astrophysical Observation", "SAO 198738"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.71066553),
        dec: Angle.Degrees(-34.54575106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171696"},
        {"Hipparcos Number", "HIP 91334"},
        {"Smithsonian Astrophysical Observation", "SAO 210378"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.43130889),
        dec: Angle.Degrees(-34.54512049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18260"},
        {"Hipparcos Number", "HIP 13577"},
        {"Smithsonian Astrophysical Observation", "SAO 193982"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.72227073),
        dec: Angle.Degrees(-34.54443203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182025"},
        {"Hipparcos Number", "HIP 95374"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.03610554),
        dec: Angle.Degrees(-34.54398256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127648"},
        {"Hipparcos Number", "HIP 71178"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.35750597),
        dec: Angle.Degrees(-34.54372297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105601"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.83629536),
        dec: Angle.Degrees(-34.54288947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162888"},
        {"Hipparcos Number", "HIP 87698"},
        {"Geneva Identification System", "GEN# +2.64750121"},
        {"Smithsonian Astrophysical Observation", "SAO 209451"},
        {"New General Catalogue", "NGC 6475 121"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.69950915),
        dec: Angle.Degrees(-34.54215414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122523"},
        {"Hipparcos Number", "HIP 68646"},
        {"Geneva Identification System", "GEN# +1.00122523"},
        {"Smithsonian Astrophysical Observation", "SAO 205124"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.77716442),
        dec: Angle.Degrees(-34.54073410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194366"},
        {"Hipparcos Number", "HIP 100815"},
        {"Smithsonian Astrophysical Observation", "SAO 212118"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.61223346),
        dec: Angle.Degrees(-34.54067167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133435"},
        {"Hipparcos Number", "HIP 73851"},
        {"Smithsonian Astrophysical Observation", "SAO 206282"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.39928063),
        dec: Angle.Degrees(-34.54031231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158394"},
        {"Henry Draper 2", "HD 158395"},
        {"Hipparcos Number", "HIP 85676"},
        {"Geneva Identification System", "GEN# +1.00158394"},
        {"Smithsonian Astrophysical Observation", "SAO 208893"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.62774007),
        dec: Angle.Degrees(-34.53902338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13723"},
        {"Hipparcos Number", "HIP 10315"},
        {"Smithsonian Astrophysical Observation", "SAO 193574"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.21636864),
        dec: Angle.Degrees(-34.53865568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16492"},
        {"Hipparcos Number", "HIP 12251"},
        {"Smithsonian Astrophysical Observation", "SAO 193824"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.43562481),
        dec: Angle.Degrees(-34.53825402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94152"},
        {"Hipparcos Number", "HIP 53078"},
        {"Smithsonian Astrophysical Observation", "SAO 201833"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.88771391),
        dec: Angle.Degrees(-34.53772164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124904"},
        {"Hipparcos Number", "HIP 69791"},
        {"Smithsonian Astrophysical Observation", "SAO 205385"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.26419643),
        dec: Angle.Degrees(-34.53666569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108885"},
        {"Hipparcos Number", "HIP 61052"},
        {"Smithsonian Astrophysical Observation", "SAO 203547"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.70558808),
        dec: Angle.Degrees(-34.53660985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78201"},
        {"Hipparcos Number", "HIP 44649"},
        {"Geneva Identification System", "GEN# +1.00078201"},
        {"Renson", "Renson 22150"},
        {"Smithsonian Astrophysical Observation", "SAO 199967"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.46864085),
        dec: Angle.Degrees(-34.53463890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206063"},
        {"Hipparcos Number", "HIP 107019"},
        {"Smithsonian Astrophysical Observation", "SAO 213190"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.11392221),
        dec: Angle.Degrees(-34.53457113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3886"},
        {"Hipparcos Number", "HIP 3239"},
        {"Smithsonian Astrophysical Observation", "SAO 192678"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.30270495),
        dec: Angle.Degrees(-34.53423048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57149",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57149"},
        {"Geneva Identification System", "GEN# -0.03307915"},
        {"Smithsonian Astrophysical Observation", "SAO 202738"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.80585580),
        dec: Angle.Degrees(-34.53393608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191132"},
        {"Hipparcos Number", "HIP 99326"},
        {"Smithsonian Astrophysical Observation", "SAO 211866"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.40562780),
        dec: Angle.Degrees(-34.53276549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80482"},
        {"Hipparcos Number", "HIP 45707"},
        {"Smithsonian Astrophysical Observation", "SAO 200229"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.77067632),
        dec: Angle.Degrees(-34.52886672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74398"},
        {"Hipparcos Number", "HIP 42741"},
        {"Geneva Identification System", "GEN# +1.00074398"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.66321411),
        dec: Angle.Degrees(-34.52754039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181842"},
        {"Hipparcos Number", "HIP 95313"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.87381696),
        dec: Angle.Degrees(-34.52675754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180336"},
        {"Hipparcos Number", "HIP 94818"},
        {"Geneva Identification System", "GEN# +1.00180336"},
        {"Smithsonian Astrophysical Observation", "SAO 211134"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.40269235),
        dec: Angle.Degrees(-34.52670118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122722"},
        {"Hipparcos Number", "HIP 68742"},
        {"Smithsonian Astrophysical Observation", "SAO 205141"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.06654019),
        dec: Angle.Degrees(-34.52133243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212025"},
        {"Hipparcos Number", "HIP 110419"},
        {"Smithsonian Astrophysical Observation", "SAO 213765"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.48999279),
        dec: Angle.Degrees(-34.52026532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206131"},
        {"Hipparcos Number", "HIP 107054"},
        {"Smithsonian Astrophysical Observation", "SAO 213196"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.23186341),
        dec: Angle.Degrees(-34.52021023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78441"},
        {"Hipparcos Number", "HIP 44751"},
        {"Smithsonian Astrophysical Observation", "SAO 199993"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.80037631),
        dec: Angle.Degrees(-34.51971500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180420"},
        {"Hipparcos Number", "HIP 94844"},
        {"Geneva Identification System", "GEN# +1.00180420"},
        {"Smithsonian Astrophysical Observation", "SAO 211141"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.48226841),
        dec: Angle.Degrees(-34.51947638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102355",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102355"},
        {"Smithsonian Astrophysical Observation", "SAO 212393"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.08806206),
        dec: Angle.Degrees(-34.51891164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58287"},
        {"Hipparcos Number", "HIP 35856"},
        {"Smithsonian Astrophysical Observation", "SAO 197940"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.88405886),
        dec: Angle.Degrees(-34.51789344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115126"},
        {"Hipparcos Number", "HIP 64695"},
        {"Smithsonian Astrophysical Observation", "SAO 204295"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.90042958),
        dec: Angle.Degrees(-34.51763091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211863"},
        {"Hipparcos Number", "HIP 110325"},
        {"Fundamental Katalog 5th Edition", "FK5 3785"},
        {"Geneva Identification System", "GEN# +1.00211863"},
        {"Smithsonian Astrophysical Observation", "SAO 213751"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.18565504),
        dec: Angle.Degrees(-34.51649695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94483"},
        {"Hipparcos Number", "HIP 53292"},
        {"Geneva Identification System", "GEN# +1.00094483"},
        {"Smithsonian Astrophysical Observation", "SAO 201872"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.48779158),
        dec: Angle.Degrees(-34.51642622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144666"},
        {"Hipparcos Number", "HIP 79065"},
        {"Smithsonian Astrophysical Observation", "SAO 207366"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.09925324),
        dec: Angle.Degrees(-34.51593584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36329"},
        {"Hipparcos Number", "HIP 25709"},
        {"Geneva Identification System", "GEN# +1.00036329"},
        {"Smithsonian Astrophysical Observation", "SAO 195904"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.35035119),
        dec: Angle.Degrees(-34.51543432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154471"},
        {"Hipparcos Number", "HIP 83766"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.79387564),
        dec: Angle.Degrees(-34.51517319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190905"},
        {"Hipparcos Number", "HIP 99220"},
        {"Geneva Identification System", "GEN# +1.00190905"},
        {"Smithsonian Astrophysical Observation", "SAO 211846"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.12735107),
        dec: Angle.Degrees(-34.51334962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89660"},
        {"Hipparcos Number", "HIP 50592"},
        {"Smithsonian Astrophysical Observation", "SAO 201290"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.02882010),
        dec: Angle.Degrees(-34.51299056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41182"},
        {"Hipparcos Number", "HIP 28580"},
        {"Smithsonian Astrophysical Observation", "SAO 196427"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.49078822),
        dec: Angle.Degrees(-34.51248901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44748"},
        {"Hipparcos Number", "HIP 30261"},
        {"Geneva Identification System", "GEN# +1.00044748"},
        {"Smithsonian Astrophysical Observation", "SAO 196734"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.48857391),
        dec: Angle.Degrees(-34.51232174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69760"},
        {"Hipparcos Number", "HIP 40577"},
        {"Celescope Catalog", "CEL 2311"},
        {"Geneva Identification System", "GEN# +1.00069760J"},
        {"Smithsonian Astrophysical Observation", "SAO 199036"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.27588661),
        dec: Angle.Degrees(-34.49725103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221620"},
        {"Hipparcos Number", "HIP 116300"},
        {"Smithsonian Astrophysical Observation", "SAO 214626"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.46592593),
        dec: Angle.Degrees(-34.51214018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25096"},
        {"Hipparcos Number", "HIP 18537"},
        {"Smithsonian Astrophysical Observation", "SAO 194652"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.47995899),
        dec: Angle.Degrees(-34.51086835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48305"},
        {"Hipparcos Number", "HIP 32002"},
        {"Smithsonian Astrophysical Observation", "SAO 197086"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.29562315),
        dec: Angle.Degrees(-34.51057677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196255"},
        {"Hipparcos Number", "HIP 101745"},
        {"Smithsonian Astrophysical Observation", "SAO 212287"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.32438281),
        dec: Angle.Degrees(-34.51046632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16690"},
        {"Hipparcos Number", "HIP 12393"},
        {"Smithsonian Astrophysical Observation", "SAO 193841"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.89677364),
        dec: Angle.Degrees(-34.51028028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184419"},
        {"Hipparcos Number", "HIP 96382"},
        {"Smithsonian Astrophysical Observation", "SAO 211391"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.94523961),
        dec: Angle.Degrees(-34.51017309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39989"},
        {"Geneva Identification System", "GEN# -0.03404419"},
        {"Smithsonian Astrophysical Observation", "SAO 198869"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.49775701),
        dec: Angle.Degrees(-34.50595067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106865"},
        {"Hipparcos Number", "HIP 59921"},
        {"Smithsonian Astrophysical Observation", "SAO 203311"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.37350578),
        dec: Angle.Degrees(-34.50506510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7038"},
        {"Hipparcos Number", "HIP 5487"},
        {"Geneva Identification System", "GEN# +1.00007038"},
        {"Smithsonian Astrophysical Observation", "SAO 192961"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.56422781),
        dec: Angle.Degrees(-34.50295196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56128"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.57884519),
        dec: Angle.Degrees(-34.50052837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -394.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46414"},
        {"Hipparcos Number", "HIP 31113"},
        {"Smithsonian Astrophysical Observation", "SAO 196908"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.93066396),
        dec: Angle.Degrees(-34.50039127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101594"},
        {"Hipparcos Number", "HIP 57012"},
        {"Smithsonian Astrophysical Observation", "SAO 202713"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.32832441),
        dec: Angle.Degrees(-34.49969595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108769"},
        {"Hipparcos Number", "HIP 60990"},
        {"Geneva Identification System", "GEN# +1.00108769"},
        {"Smithsonian Astrophysical Observation", "SAO 203531"},
        {"Wilson Evans Batten Catalogue", "WEB 10856"},
    },
    visualMagnitude: 9.05,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.51459054),
        dec: Angle.Degrees(-34.49892566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9413"},
        {"Hipparcos Number", "HIP 7137"},
        {"Smithsonian Astrophysical Observation", "SAO 193166"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.99270402),
        dec: Angle.Degrees(-34.49889621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26487"},
        {"Hipparcos Number", "HIP 19463"},
        {"Smithsonian Astrophysical Observation", "SAO 194806"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.51410767),
        dec: Angle.Degrees(-34.49772940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1105"},
        {"Hipparcos Number", "HIP 1218"},
        {"Geneva Identification System", "GEN# +1.00001105"},
        {"Smithsonian Astrophysical Observation", "SAO 192422"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.80292338),
        dec: Angle.Degrees(-34.49528339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195348"},
        {"Hipparcos Number", "HIP 101296"},
        {"Smithsonian Astrophysical Observation", "SAO 212204"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.97618799),
        dec: Angle.Degrees(-34.49523404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36856"},
        {"Hipparcos Number", "HIP 26014"},
        {"Smithsonian Astrophysical Observation", "SAO 195951"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.27085281),
        dec: Angle.Degrees(-34.49379028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51198"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.86183254),
        dec: Angle.Degrees(-34.49063669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8040"},
        {"Hipparcos Number", "HIP 6182"},
        {"Smithsonian Astrophysical Observation", "SAO 193050"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.82745223),
        dec: Angle.Degrees(-34.49061987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201850"},
        {"Hipparcos Number", "HIP 104746"},
        {"Smithsonian Astrophysical Observation", "SAO 212798"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.31096829),
        dec: Angle.Degrees(-34.49056146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4857"},
        {"Hipparcos Number", "HIP 3920"},
        {"Geneva Identification System", "GEN# +1.00004857"},
        {"Smithsonian Astrophysical Observation", "SAO 192769"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.57984369),
        dec: Angle.Degrees(-34.48984684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178272"},
        {"Hipparcos Number", "HIP 94101"},
        {"Smithsonian Astrophysical Observation", "SAO 210989"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.34052656),
        dec: Angle.Degrees(-34.48973519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215119"},
        {"Hipparcos Number", "HIP 112196"},
        {"Smithsonian Astrophysical Observation", "SAO 214044"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.85687924),
        dec: Angle.Degrees(-34.48903772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212035"},
        {"Hipparcos Number", "HIP 110433"},
        {"Geneva Identification System", "GEN# +1.00212035"},
        {"Smithsonian Astrophysical Observation", "SAO 213767"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.51906256),
        dec: Angle.Degrees(-34.48897317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18083"},
        {"Hipparcos Number", "HIP 13455"},
        {"Geneva Identification System", "GEN# +1.00018083"},
        {"Smithsonian Astrophysical Observation", "SAO 193963"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.31887781),
        dec: Angle.Degrees(-34.48881011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92268"},
        {"Hipparcos Number", "HIP 52101"},
        {"Smithsonian Astrophysical Observation", "SAO 201587"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.68478816),
        dec: Angle.Degrees(-34.48654282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35045"},
        {"Hipparcos Number", "HIP 24903"},
        {"Smithsonian Astrophysical Observation", "SAO 195760"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.06843767),
        dec: Angle.Degrees(-34.48637119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42164"},
        {"Hipparcos Number", "HIP 29045"},
        {"Smithsonian Astrophysical Observation", "SAO 196515"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.92049354),
        dec: Angle.Degrees(-34.48625548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94034"},
        {"Hipparcos Number", "HIP 53011"},
        {"Geneva Identification System", "GEN# +1.00094034"},
        {"Smithsonian Astrophysical Observation", "SAO 201818"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.68458026),
        dec: Angle.Degrees(-34.48624966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187992"},
        {"Hipparcos Number", "HIP 97946"},
        {"Smithsonian Astrophysical Observation", "SAO 211641"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.57865415),
        dec: Angle.Degrees(-34.48565322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67114"},
        {"Smithsonian Astrophysical Observation", "SAO 204802"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.33660801),
        dec: Angle.Degrees(-34.48519262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25535"},
        {"Hipparcos Number", "HIP 18824"},
        {"Geneva Identification System", "GEN# +1.00025535J"},
        {"Smithsonian Astrophysical Observation", "SAO 194709"},
        {"Wilson Evans Batten Catalogue", "WEB 3622"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.51325842),
        dec: Angle.Degrees(-34.48212185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 377.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128466"},
        {"Hipparcos Number", "HIP 71542"},
        {"Smithsonian Astrophysical Observation", "SAO 205779"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.49067904),
        dec: Angle.Degrees(-34.48174078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158359"},
        {"Hipparcos Number", "HIP 85660"},
        {"Smithsonian Astrophysical Observation", "SAO 208890"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.58278530),
        dec: Angle.Degrees(-34.48047709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130924"},
        {"Hipparcos Number", "HIP 72705"},
        {"Smithsonian Astrophysical Observation", "SAO 206020"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.97999822),
        dec: Angle.Degrees(-34.48029672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193462"},
        {"Hipparcos Number", "HIP 100401"},
        {"Geneva Identification System", "GEN# +1.00193462"},
        {"Smithsonian Astrophysical Observation", "SAO 212036"},
        {"Wilson Evans Batten Catalogue", "WEB 18121"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.40611129),
        dec: Angle.Degrees(-34.47764129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37117"},
        {"Hipparcos Number", "HIP 26158"},
        {"Smithsonian Astrophysical Observation", "SAO 195977"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.64766831),
        dec: Angle.Degrees(-34.47713496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10329"},
        {"Hipparcos Number", "HIP 7792"},
        {"Geneva Identification System", "GEN# +1.00010329"},
        {"Smithsonian Astrophysical Observation", "SAO 193242"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.07047794),
        dec: Angle.Degrees(-34.47651043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40540"},
        {"Hipparcos Number", "HIP 28230"},
        {"Renson", "Renson 10830"},
        {"Smithsonian Astrophysical Observation", "SAO 196357"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.46912977),
        dec: Angle.Degrees(-34.47606994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8894"},
    },
    visualMagnitude: 11.98,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.62466173),
        dec: Angle.Degrees(-34.47403062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105133"},
        {"Hipparcos Number", "HIP 59042"},
        {"Smithsonian Astrophysical Observation", "SAO 203127"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.57150631),
        dec: Angle.Degrees(-34.47233347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176047"},
        {"Hipparcos Number", "HIP 93255"},
        {"Geneva Identification System", "GEN# +1.00176047"},
        {"Smithsonian Astrophysical Observation", "SAO 210794"},
        {"Wilson Evans Batten Catalogue", "WEB 16168"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.93590863),
        dec: Angle.Degrees(-34.47088938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38986"},
        {"Hipparcos Number", "HIP 27387"},
        {"Smithsonian Astrophysical Observation", "SAO 196184"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.00378390),
        dec: Angle.Degrees(-34.47020336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43799"},
        {"Smithsonian Astrophysical Observation", "SAO 199785"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.80393157),
        dec: Angle.Degrees(-34.46991688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13758"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.27488727),
        dec: Angle.Degrees(-02.41894325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 278.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14846"},
        {"Smithsonian Astrophysical Observation", "SAO 194144"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.92947916),
        dec: Angle.Degrees(-34.46817796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118319"},
        {"Hipparcos Number", "HIP 66405"},
        {"Geneva Identification System", "GEN# +1.00118319"},
        {"Smithsonian Astrophysical Observation", "SAO 204653"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.21073820),
        dec: Angle.Degrees(-34.46775455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162817"},
        {"Hipparcos Number", "HIP 87671"},
        {"Geneva Identification System", "GEN# +2.64750110"},
        {"Renson", "Renson 46060"},
        {"Smithsonian Astrophysical Observation", "SAO 209446"},
        {"Wilson Evans Batten Catalogue", "WEB 14798"},
        {"New General Catalogue", "NGC 6475 110"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.61300345),
        dec: Angle.Degrees(-34.46671107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172513"},
        {"Hipparcos Number", "HIP 91700"},
        {"Geneva Identification System", "GEN# +1.00172513"},
        {"Smithsonian Astrophysical Observation", "SAO 210475"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.50983701),
        dec: Angle.Degrees(-34.46617765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210525"},
        {"Hipparcos Number", "HIP 109561"},
        {"Smithsonian Astrophysical Observation", "SAO 213625"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.90834542),
        dec: Angle.Degrees(-34.46506518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118972"},
        {"Hipparcos Number", "HIP 66765"},
        {"Geneva Identification System", "GEN# +1.00118972"},
        {"Smithsonian Astrophysical Observation", "SAO 204725"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.26677306),
        dec: Angle.Degrees(-34.46375217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 205.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59892"},
    },
    visualMagnitude: 11.45,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.26073574),
        dec: Angle.Degrees(-34.46181624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150385"},
        {"Hipparcos Number", "HIP 81772"},
        {"Smithsonian Astrophysical Observation", "SAO 207938"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.53556610),
        dec: Angle.Degrees(-34.46180865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73267"},
        {"Hipparcos Number", "HIP 42202"},
        {"Geneva Identification System", "GEN# +1.00073267"},
        {"Smithsonian Astrophysical Observation", "SAO 199418"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.07438098),
        dec: Angle.Degrees(-34.46027752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 733"},
        {"Hipparcos Number", "HIP 928"},
        {"Geneva Identification System", "GEN# +1.00000733"},
        {"Smithsonian Astrophysical Observation", "SAO 192387"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.88140032),
        dec: Angle.Degrees(-34.46009170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11231"},
        {"Hipparcos Number", "HIP 8501"},
        {"Geneva Identification System", "GEN# +1.00011231"},
        {"Smithsonian Astrophysical Observation", "SAO 193323"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.40795350),
        dec: Angle.Degrees(-34.45914990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70395"},
        {"Hipparcos Number", "HIP 40873"},
        {"Geneva Identification System", "GEN# +1.00070395"},
        {"Smithsonian Astrophysical Observation", "SAO 199101"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.09814965),
        dec: Angle.Degrees(-34.45487989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44915"},
        {"Hipparcos Number", "HIP 30335"},
        {"Smithsonian Astrophysical Observation", "SAO 196751"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.71324086),
        dec: Angle.Degrees(-34.45284081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223517"},
        {"Hipparcos Number", "HIP 117538"},
        {"Smithsonian Astrophysical Observation", "SAO 214803"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.55309650),
        dec: Angle.Degrees(-34.45170451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120323"},
        {"Hipparcos Number", "HIP 67457"},
        {"Geneva Identification System", "GEN# +1.00120323"},
        {"Smithsonian Astrophysical Observation", "SAO 204875"},
        {"Wilson Evans Batten Catalogue", "WEB 11862"},
    },
    visualMagnitude: 4.19,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.36146356),
        dec: Angle.Degrees(-34.45063035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6366"},
        {"Hipparcos Number", "HIP 5010"},
        {"Geneva Identification System", "GEN# +1.00006366"},
        {"Smithsonian Astrophysical Observation", "SAO 192902"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.03718361),
        dec: Angle.Degrees(-34.45047390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117100"},
    },
    visualMagnitude: 10.96,
    bvColour: -0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.09176480),
        dec: Angle.Degrees(-34.45009222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53408"},
        {"Smithsonian Astrophysical Observation", "SAO 201902"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.86017953),
        dec: Angle.Degrees(-34.44715802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131501"},
        {"Hipparcos Number", "HIP 72991"},
        {"Smithsonian Astrophysical Observation", "SAO 206086"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.74307074),
        dec: Angle.Degrees(-34.44543751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167870"},
        {"Hipparcos Number", "HIP 89717"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.64328542),
        dec: Angle.Degrees(-34.44511910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214195"},
        {"Hipparcos Number", "HIP 111662"},
        {"Smithsonian Astrophysical Observation", "SAO 213958"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.30761149),
        dec: Angle.Degrees(-34.44143509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149061"},
        {"Hipparcos Number", "HIP 81092"},
        {"Geneva Identification System", "GEN# +1.00149061"},
        {"Renson", "Renson 42130"},
        {"Smithsonian Astrophysical Observation", "SAO 207771"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.45181042),
        dec: Angle.Degrees(-34.44062644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12275"},
        {"Hipparcos Number", "HIP 9315"},
        {"Geneva Identification System", "GEN# +1.00012275"},
        {"Smithsonian Astrophysical Observation", "SAO 193434"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.91409134),
        dec: Angle.Degrees(-34.44018820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54414"},
        {"Hipparcos Number", "HIP 34353"},
        {"Smithsonian Astrophysical Observation", "SAO 197595"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.82559913),
        dec: Angle.Degrees(-34.43878231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116521"},
        {"Hipparcos Number", "HIP 65436"},
        {"Smithsonian Astrophysical Observation", "SAO 204436"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.16851631),
        dec: Angle.Degrees(-34.43600242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179136"},
        {"Hipparcos Number", "HIP 94403"},
        {"Geneva Identification System", "GEN# +1.00179136"},
        {"Smithsonian Astrophysical Observation", "SAO 211048"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.20166145),
        dec: Angle.Degrees(-34.43546347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142602"},
        {"Hipparcos Number", "HIP 78093"},
        {"Smithsonian Astrophysical Observation", "SAO 207141"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.17628337),
        dec: Angle.Degrees(-34.43155195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157515"},
        {"Hipparcos Number", "HIP 85250"},
        {"Smithsonian Astrophysical Observation", "SAO 208789"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.30607643),
        dec: Angle.Degrees(-34.42982827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78095"},
        {"Smithsonian Astrophysical Observation", "SAO 207142"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.18107921),
        dec: Angle.Degrees(-34.42639023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39320"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.59250627),
        dec: Angle.Degrees(-34.42504485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61073"},
        {"Hipparcos Number", "HIP 36971"},
        {"Renson", "Renson 16700"},
    },
    visualMagnitude: 9.16,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.99842041),
        dec: Angle.Degrees(-34.42438990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4578"},
        {"Smithsonian Astrophysical Observation", "SAO 192845"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.65556831),
        dec: Angle.Degrees(-34.42408335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46430"},
        {"Smithsonian Astrophysical Observation", "SAO 200395"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.02944405),
        dec: Angle.Degrees(-34.42146375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37039"},
        {"Geneva Identification System", "GEN# -0.03403746"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.17516323),
        dec: Angle.Degrees(-34.42133289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23214"},
        {"Hipparcos Number", "HIP 17295"},
        {"Geneva Identification System", "GEN# +1.00023214"},
        {"Smithsonian Astrophysical Observation", "SAO 194466"},
        {"Wilson Evans Batten Catalogue", "WEB 3268"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.53815382),
        dec: Angle.Degrees(-34.42110089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12395"},
        {"Hipparcos Number", "HIP 9397"},
        {"Smithsonian Astrophysical Observation", "SAO 193452"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.19603860),
        dec: Angle.Degrees(-34.42081513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70326"},
        {"Hipparcos Number", "HIP 40831"},
        {"Celescope Catalog", "CEL 2380"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.99996216),
        dec: Angle.Degrees(-34.42070265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75818"},
        {"Hipparcos Number", "HIP 43459"},
        {"Smithsonian Astrophysical Observation", "SAO 199702"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.77096445),
        dec: Angle.Degrees(-34.42023451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103332"},
        {"Hipparcos Number", "HIP 58000"},
        {"Smithsonian Astrophysical Observation", "SAO 202917"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.45617502),
        dec: Angle.Degrees(-34.41944884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89609"},
        {"Hipparcos Number", "HIP 50566"},
        {"Smithsonian Astrophysical Observation", "SAO 201287"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.93945095),
        dec: Angle.Degrees(-34.41900976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124739"},
        {"Hipparcos Number", "HIP 69707"},
        {"Geneva Identification System", "GEN# +1.00124739"},
        {"Smithsonian Astrophysical Observation", "SAO 205368"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.02291618),
        dec: Angle.Degrees(-34.41884827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162391"},
        {"Hipparcos Number", "HIP 87472"},
        {"Geneva Identification System", "GEN# +2.64750134"},
        {"Smithsonian Astrophysical Observation", "SAO 209390"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.08233216),
        dec: Angle.Degrees(-34.41683044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35567"},
        {"Hipparcos Number", "HIP 25259"},
        {"Smithsonian Astrophysical Observation", "SAO 195816"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.03401964),
        dec: Angle.Degrees(-34.41549878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89283"},
        {"Hipparcos Number", "HIP 50393"},
        {"Smithsonian Astrophysical Observation", "SAO 201250"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.34759160),
        dec: Angle.Degrees(-34.41536349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225189"},
        {"Hipparcos Number", "HIP 332"},
        {"Fundamental Katalog 5th Edition", "FK5 4008"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.06083408),
        dec: Angle.Degrees(-34.41465369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33728"},
        {"Hipparcos Number", "HIP 24107"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.67588220),
        dec: Angle.Degrees(-34.41195202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139521"},
        {"Hipparcos Number", "HIP 76705"},
        {"Fundamental Katalog 5th Edition", "FK5 3237"},
        {"Geneva Identification System", "GEN# +1.00139521"},
        {"Smithsonian Astrophysical Observation", "SAO 206843"},
        {"Wilson Evans Batten Catalogue", "WEB 13019"},
    },
    visualMagnitude: 4.66,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.94156188),
        dec: Angle.Degrees(-34.41189273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194747"},
        {"Hipparcos Number", "HIP 100991"},
        {"Smithsonian Astrophysical Observation", "SAO 212155"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.13654279),
        dec: Angle.Degrees(-34.40970624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125250"},
        {"Hipparcos Number", "HIP 69968"},
        {"Smithsonian Astrophysical Observation", "SAO 205425"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.76351615),
        dec: Angle.Degrees(-34.40885434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76952"},
        {"Hipparcos Number", "HIP 44049"},
        {"Smithsonian Astrophysical Observation", "SAO 199836"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.56224921),
        dec: Angle.Degrees(-34.40875423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156327"},
        {"Hipparcos Number", "HIP 84655"},
        {"Geneva Identification System", "GEN# +1.00156327J"},
        {"Smithsonian Astrophysical Observation", "SAO 208655"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.59609225),
        dec: Angle.Degrees(-34.40849679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109149",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109149"},
        {"Geneva Identification System", "GEN# -0.03515144"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.64532357),
        dec: Angle.Degrees(-34.40845182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19200"},
        {"Hipparcos Number", "HIP 14291"},
        {"Smithsonian Astrophysical Observation", "SAO 194066"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.06128736),
        dec: Angle.Degrees(-34.40823126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218666"},
        {"Hipparcos Number", "HIP 114401"},
        {"Smithsonian Astrophysical Observation", "SAO 214354"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.53298314),
        dec: Angle.Degrees(-34.40787154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125888"},
        {"Hipparcos Number", "HIP 70318"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.80147993),
        dec: Angle.Degrees(-34.40715385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97507"},
        {"Hipparcos Number", "HIP 54779"},
        {"Geneva Identification System", "GEN# +1.00097507"},
        {"Smithsonian Astrophysical Observation", "SAO 202209"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.22434415),
        dec: Angle.Degrees(-34.40663709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 293.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10762"},
        {"Hipparcos Number", "HIP 8135"},
        {"Fundamental Katalog 5th Edition", "FK5 4156"},
        {"Smithsonian Astrophysical Observation", "SAO 193280"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.15323883),
        dec: Angle.Degrees(-34.40602089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152936"},
        {"Hipparcos Number", "HIP 83022"},
        {"Geneva Identification System", "GEN# +1.00152936"},
        {"Smithsonian Astrophysical Observation", "SAO 208240"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.47419048),
        dec: Angle.Degrees(-34.40579921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96843"},
        {"Hipparcos Number", "HIP 54482"},
        {"Geneva Identification System", "GEN# +1.00096843"},
        {"Smithsonian Astrophysical Observation", "SAO 202129"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.19512090),
        dec: Angle.Degrees(-34.40474314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149273"},
        {"Hipparcos Number", "HIP 81200"},
        {"Geneva Identification System", "GEN# +1.00149273"},
        {"Smithsonian Astrophysical Observation", "SAO 207791"},
        {"Wilson Evans Batten Catalogue", "WEB 13726"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.78531748),
        dec: Angle.Degrees(-34.40468880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77882",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77882"},
        {"Smithsonian Astrophysical Observation", "SAO 207098"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.56760745),
        dec: Angle.Degrees(-34.40078815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183878"},
        {"Hipparcos Number", "HIP 96155"},
        {"Smithsonian Astrophysical Observation", "SAO 211353"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.26836411),
        dec: Angle.Degrees(-34.39979646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209703"},
        {"Hipparcos Number", "HIP 109100"},
        {"Smithsonian Astrophysical Observation", "SAO 213542"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.50505253),
        dec: Angle.Degrees(-34.39968932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90712"},
        {"Hipparcos Number", "HIP 51228"},
        {"Geneva Identification System", "GEN# +1.00090712"},
        {"Smithsonian Astrophysical Observation", "SAO 201414"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.94942668),
        dec: Angle.Degrees(-34.39938622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56753"},
        {"Hipparcos Number", "HIP 35233"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.22381921),
        dec: Angle.Degrees(-34.39795020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71269"},
        {"Hipparcos Number", "HIP 41271"},
        {"Celescope Catalog", "CEL 2484"},
        {"Smithsonian Astrophysical Observation", "SAO 199199"},
    },
    visualMagnitude: 8.94,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.30300590),
        dec: Angle.Degrees(-34.39754872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44323"},
        {"Hipparcos Number", "HIP 30069"},
        {"Celescope Catalog", "CEL 1185"},
        {"Geneva Identification System", "GEN# +1.00044323"},
        {"Smithsonian Astrophysical Observation", "SAO 196686"},
        {"Wilson Evans Batten Catalogue", "WEB 5979"},
    },
    visualMagnitude: 5.76,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.92063879),
        dec: Angle.Degrees(-34.39659537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189028"},
        {"Hipparcos Number", "HIP 98388"},
        {"Smithsonian Astrophysical Observation", "SAO 211711"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.85380225),
        dec: Angle.Degrees(-34.39336752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51702"},
        {"Hipparcos Number", "HIP 33417"},
        {"Smithsonian Astrophysical Observation", "SAO 197393"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.24327137),
        dec: Angle.Degrees(-34.39317065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55397"},
        {"Hipparcos Number", "HIP 34708"},
        {"Celescope Catalog", "CEL 1654"},
        {"Geneva Identification System", "GEN# +1.00055397"},
        {"Smithsonian Astrophysical Observation", "SAO 197670"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.82124666),
        dec: Angle.Degrees(-34.38940679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117927"},
        {"Hipparcos Number", "HIP 66211"},
        {"Smithsonian Astrophysical Observation", "SAO 204603"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.56387980),
        dec: Angle.Degrees(-34.38756633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27067"},
        {"Hipparcos Number", "HIP 19846"},
        {"Smithsonian Astrophysical Observation", "SAO 194869"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.81510763),
        dec: Angle.Degrees(-34.38617811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90185",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Kaus Australis"},
        {"Henry Draper", "HD 169022"},
        {"Hipparcos Number", "HIP 90185"},
        {"Fundamental Katalog 5th Edition", "FK5 689"},
        {"Geneva Identification System", "GEN# +1.00169022"},
        {"Smithsonian Astrophysical Observation", "SAO 210091"},
        {"Wilson Evans Batten Catalogue", "WEB 15421"},
    },
    visualMagnitude: 1.79,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.04310967),
        dec: Angle.Degrees(-34.38431460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213846"},
        {"Hipparcos Number", "HIP 111464"},
        {"Smithsonian Astrophysical Observation", "SAO 213928"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.74381149),
        dec: Angle.Degrees(-34.38424557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89354"},
        {"Hipparcos Number", "HIP 50442"},
        {"Smithsonian Astrophysical Observation", "SAO 201258"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.48667607),
        dec: Angle.Degrees(-34.38321345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209172"},
        {"Hipparcos Number", "HIP 108771"},
        {"Smithsonian Astrophysical Observation", "SAO 213490"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.51850779),
        dec: Angle.Degrees(-34.38288631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129683"},
        {"Hipparcos Number", "HIP 72099"},
        {"Smithsonian Astrophysical Observation", "SAO 205898"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.23703712),
        dec: Angle.Degrees(-34.38155137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45843"},
        {"Hipparcos Number", "HIP 30802"},
        {"Smithsonian Astrophysical Observation", "SAO 196859"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.07566682),
        dec: Angle.Degrees(-34.38066060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172389"},
        {"Hipparcos Number", "HIP 91646"},
        {"Smithsonian Astrophysical Observation", "SAO 210462"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.33669307),
        dec: Angle.Degrees(-34.37951734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65354"},
        {"Hipparcos Number", "HIP 38851"},
        {"Smithsonian Astrophysical Observation", "SAO 198622"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.26260924),
        dec: Angle.Degrees(-34.37844543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45345"},
        {"Hipparcos Number", "HIP 30544"},
        {"Geneva Identification System", "GEN# +1.00045345"},
        {"Smithsonian Astrophysical Observation", "SAO 196801"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.31808972),
        dec: Angle.Degrees(-34.37838821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176383"},
        {"Hipparcos Number", "HIP 93412"},
        {"Geneva Identification System", "GEN# +1.00176383"},
        {"Smithsonian Astrophysical Observation", "SAO 210825"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.36943254),
        dec: Angle.Degrees(-34.37642951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42615",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42615"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.27724996),
        dec: Angle.Degrees(-34.37567858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20143"},
        {"Hipparcos Number", "HIP 14982"},
        {"Smithsonian Astrophysical Observation", "SAO 194165"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.28323122),
        dec: Angle.Degrees(-34.37563691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110072"},
        {"Hipparcos Number", "HIP 61785"},
        {"Renson", "Renson 31970"},
        {"Smithsonian Astrophysical Observation", "SAO 203680"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.95924215),
        dec: Angle.Degrees(-34.37469067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118239"},
        {"Hipparcos Number", "HIP 66356"},
        {"Smithsonian Astrophysical Observation", "SAO 204638"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.02353536),
        dec: Angle.Degrees(-34.37397417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114044"},
        {"Geneva Identification System", "GEN# -0.03515652"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.43160601),
        dec: Angle.Degrees(-34.37092508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6197"},
        {"Hipparcos Number", "HIP 4867"},
        {"Geneva Identification System", "GEN# +1.00006197"},
        {"Smithsonian Astrophysical Observation", "SAO 192886"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.64557911),
        dec: Angle.Degrees(-34.37004818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134575"},
        {"Hipparcos Number", "HIP 74358"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.94100347),
        dec: Angle.Degrees(-34.36996375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155320"},
        {"Hipparcos Number", "HIP 84162"},
        {"Geneva Identification System", "GEN# +1.00155320"},
        {"Smithsonian Astrophysical Observation", "SAO 208527"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.08641805),
        dec: Angle.Degrees(-34.36957101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95197"},
        {"Hipparcos Number", "HIP 53689"},
        {"Smithsonian Astrophysical Observation", "SAO 201973"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.77671843),
        dec: Angle.Degrees(-34.36804166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116831"},
        {"Smithsonian Astrophysical Observation", "SAO 214703"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.19291844),
        dec: Angle.Degrees(-34.36766799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174172"},
        {"Hipparcos Number", "HIP 92465"},
        {"Smithsonian Astrophysical Observation", "SAO 210623"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.66052529),
        dec: Angle.Degrees(-34.36754946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83078"},
        {"Hipparcos Number", "HIP 47020"},
        {"Smithsonian Astrophysical Observation", "SAO 200525"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.73831070),
        dec: Angle.Degrees(-34.36739679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50235"},
        {"Hipparcos Number", "HIP 32855"},
        {"Geneva Identification System", "GEN# +1.00050235"},
        {"Smithsonian Astrophysical Observation", "SAO 197277"},
        {"Wilson Evans Batten Catalogue", "WEB 6613"},
    },
    visualMagnitude: 4.99,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.71812209),
        dec: Angle.Degrees(-34.36732059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71285"},
        {"Hipparcos Number", "HIP 41278"},
        {"Geneva Identification System", "GEN# +1.00071285"},
        {"Smithsonian Astrophysical Observation", "SAO 199201"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.32384376),
        dec: Angle.Degrees(-34.36694746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217685"},
        {"Hipparcos Number", "HIP 113813"},
        {"Smithsonian Astrophysical Observation", "SAO 214264"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.71985704),
        dec: Angle.Degrees(-34.36559416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 319680"},
        {"Hipparcos Number", "HIP 84908"},
        {"Smithsonian Astrophysical Observation", "SAO 208713"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.28565106),
        dec: Angle.Degrees(-34.36378398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61799"},
        {"Hipparcos Number", "HIP 37320"},
        {"Smithsonian Astrophysical Observation", "SAO 198262"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.92637832),
        dec: Angle.Degrees(-34.36224174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156866"},
        {"Hipparcos Number", "HIP 84929"},
        {"Smithsonian Astrophysical Observation", "SAO 208718"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.34938754),
        dec: Angle.Degrees(-34.36114409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48558"},
        {"Hipparcos Number", "HIP 32118"},
        {"Smithsonian Astrophysical Observation", "SAO 197112"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.63389735),
        dec: Angle.Degrees(-34.36110822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138491"},
        {"Hipparcos Number", "HIP 76174"},
        {"Fundamental Katalog 5th Edition", "FK5 5376"},
        {"Smithsonian Astrophysical Observation", "SAO 206754"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.38523393),
        dec: Angle.Degrees(-34.35956424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40705"},
        {"Hipparcos Number", "HIP 28311"},
        {"Smithsonian Astrophysical Observation", "SAO 196375"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.73549157),
        dec: Angle.Degrees(-34.35927932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132763"},
        {"Hipparcos Number", "HIP 73559"},
        {"Geneva Identification System", "GEN# +1.00132763"},
        {"Renson", "Renson 37670"},
        {"Smithsonian Astrophysical Observation", "SAO 206223"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.49208900),
        dec: Angle.Degrees(-34.35881656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24474"},
        {"Hipparcos Number", "HIP 18112"},
        {"Geneva Identification System", "GEN# +1.00024474"},
        {"Smithsonian Astrophysical Observation", "SAO 194594"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.08591724),
        dec: Angle.Degrees(-34.35831679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 140.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118894"},
        {"Hipparcos Number", "HIP 66714"},
        {"Geneva Identification System", "GEN# +1.00118894"},
        {"Smithsonian Astrophysical Observation", "SAO 204720"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.12769900),
        dec: Angle.Degrees(-34.35819546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70072"},
    },
    visualMagnitude: 11.04,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.08675920),
        dec: Angle.Degrees(-34.35809820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214255"},
        {"Hipparcos Number", "HIP 111687"},
        {"Smithsonian Astrophysical Observation", "SAO 213964"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.38261865),
        dec: Angle.Degrees(-34.35746759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191728"},
        {"Hipparcos Number", "HIP 99591"},
        {"Geneva Identification System", "GEN# +1.00191728"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.16760220),
        dec: Angle.Degrees(-34.35657738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79843"},
        {"Hipparcos Number", "HIP 45426"},
        {"Geneva Identification System", "GEN# +1.00079843"},
        {"Smithsonian Astrophysical Observation", "SAO 200156"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.86211044),
        dec: Angle.Degrees(-34.35644557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37827"},
        {"Geneva Identification System", "GEN# -0.03403870"},
        {"Smithsonian Astrophysical Observation", "SAO 198397"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.33555975),
        dec: Angle.Degrees(-34.35640741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21763"},
        {"Hipparcos Number", "HIP 16236"},
        {"Smithsonian Astrophysical Observation", "SAO 194329"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.31246152),
        dec: Angle.Degrees(-34.35286918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155854"},
        {"Hipparcos Number", "HIP 84429"},
        {"Geneva Identification System", "GEN# +1.00155854"},
        {"Smithsonian Astrophysical Observation", "SAO 208598"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.91582003),
        dec: Angle.Degrees(-34.35225164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221981"},
        {"Hipparcos Number", "HIP 116526"},
        {"Smithsonian Astrophysical Observation", "SAO 214656"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.23333312),
        dec: Angle.Degrees(-34.35153907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149873"},
        {"Hipparcos Number", "HIP 81504"},
        {"Smithsonian Astrophysical Observation", "SAO 207875"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.70986072),
        dec: Angle.Degrees(-34.34942773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114134"},
        {"Hipparcos Number", "HIP 64160"},
        {"Smithsonian Astrophysical Observation", "SAO 204167"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.25108513),
        dec: Angle.Degrees(-34.34801670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35165"},
        {"Hipparcos Number", "HIP 25007"},
        {"Geneva Identification System", "GEN# +1.00035165J"},
        {"Smithsonian Astrophysical Observation", "SAO 195770"},
        {"Wilson Evans Batten Catalogue", "WEB 4845"},
    },
    visualMagnitude: 6.05,
    bvColour: -0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.32025164),
        dec: Angle.Degrees(-34.34506641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147285"},
        {"Hipparcos Number", "HIP 80207"},
        {"Smithsonian Astrophysical Observation", "SAO 207598"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.60987717),
        dec: Angle.Degrees(-34.34463170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204900"},
        {"Hipparcos Number", "HIP 106369"},
        {"Smithsonian Astrophysical Observation", "SAO 213081"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.15725924),
        dec: Angle.Degrees(-34.34369154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23272"},
        {"Smithsonian Astrophysical Observation", "SAO 195480"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.10474785),
        dec: Angle.Degrees(-34.34307885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188580"},
        {"Hipparcos Number", "HIP 98189"},
        {"Smithsonian Astrophysical Observation", "SAO 211681"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.30019341),
        dec: Angle.Degrees(-34.34154354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80908"},
        {"Hipparcos Number", "HIP 45903"},
        {"Smithsonian Astrophysical Observation", "SAO 200275"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.37779773),
        dec: Angle.Degrees(-34.33657979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92059"},
    },
    visualMagnitude: 13.16,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.45055298),
        dec: Angle.Degrees(-34.33435096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88524"},
        {"Hipparcos Number", "HIP 49943"},
        {"Geneva Identification System", "GEN# +1.00088524"},
        {"Smithsonian Astrophysical Observation", "SAO 201152"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.95356729),
        dec: Angle.Degrees(-34.33392415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148672"},
        {"Hipparcos Number", "HIP 80895"},
        {"Geneva Identification System", "GEN# +1.00148672"},
        {"Smithsonian Astrophysical Observation", "SAO 207731"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.79483061),
        dec: Angle.Degrees(-34.33279982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63099"},
        {"Hipparcos Number", "HIP 37876"},
        {"Geneva Identification System", "GEN# +1.00063099"},
        {"Wilson Evans Batten Catalogue", "WEB 7477"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.46000285),
        dec: Angle.Degrees(-34.33014732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4508"},
        {"Hipparcos Number", "HIP 3660"},
        {"Smithsonian Astrophysical Observation", "SAO 192734"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.71469382),
        dec: Angle.Degrees(-34.32996532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205294"},
        {"Hipparcos Number", "HIP 106586"},
        {"Geneva Identification System", "GEN# +1.00205294"},
        {"Smithsonian Astrophysical Observation", "SAO 213115"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.80694698),
        dec: Angle.Degrees(-34.32943884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22756"},
        {"Hipparcos Number", "HIP 16967"},
        {"Smithsonian Astrophysical Observation", "SAO 194419"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.56504351),
        dec: Angle.Degrees(-34.32921744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9674"},
        {"Hipparcos Number", "HIP 7319"},
        {"Smithsonian Astrophysical Observation", "SAO 193184"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.56466510),
        dec: Angle.Degrees(-34.32360731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81604"},
        {"Hipparcos Number", "HIP 46245"},
        {"Smithsonian Astrophysical Observation", "SAO 200354"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.42313412),
        dec: Angle.Degrees(-34.32240463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18195"},
        {"Smithsonian Astrophysical Observation", "SAO 194605"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.38375387),
        dec: Angle.Degrees(-34.31970370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120825"},
        {"Hipparcos Number", "HIP 67737"},
        {"Smithsonian Astrophysical Observation", "SAO 204934"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.13788715),
        dec: Angle.Degrees(-34.31942949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 321452"},
        {"Hipparcos Number", "HIP 89326"},
        {"Wilson Evans Batten Catalogue", "WEB 15185"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.39745259),
        dec: Angle.Degrees(-34.31712504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43123"},
    },
    visualMagnitude: 9.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.75064050),
        dec: Angle.Degrees(-34.31643884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59100"},
        {"Hipparcos Number", "HIP 36160"},
        {"Geneva Identification System", "GEN# +1.00059100"},
        {"Smithsonian Astrophysical Observation", "SAO 198003"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.74104576),
        dec: Angle.Degrees(-34.31574864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -313.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165210"},
        {"Hipparcos Number", "HIP 88691"},
        {"Smithsonian Astrophysical Observation", "SAO 209711"},
    },
    visualMagnitude: 7.99,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.58624903),
        dec: Angle.Degrees(-34.31509453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175347"},
        {"Hipparcos Number", "HIP 92956"},
        {"Smithsonian Astrophysical Observation", "SAO 210731"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.07754658),
        dec: Angle.Degrees(-34.31374220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6855"},
        {"Hipparcos Number", "HIP 5371"},
        {"Geneva Identification System", "GEN# +1.00006855"},
        {"Smithsonian Astrophysical Observation", "SAO 192948"},
        {"Wilson Evans Batten Catalogue", "WEB 1167"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.17177998),
        dec: Angle.Degrees(-34.31366133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67099"},
        {"Hipparcos Number", "HIP 39561"},
        {"Smithsonian Astrophysical Observation", "SAO 198775"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.25892771),
        dec: Angle.Degrees(-34.31249389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59099"},
        {"Hipparcos Number", "HIP 36165"},
        {"Geneva Identification System", "GEN# +1.00059099"},
        {"Smithsonian Astrophysical Observation", "SAO 198005"},
        {"Wilson Evans Batten Catalogue", "WEB 7203"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.74537148),
        dec: Angle.Degrees(-34.31242119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -293.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42054"},
        {"Hipparcos Number", "HIP 28992"},
        {"Geneva Identification System", "GEN# +1.00042054"},
        {"Smithsonian Astrophysical Observation", "SAO 196503"},
        {"Wilson Evans Batten Catalogue", "WEB 5678"},
    },
    visualMagnitude: 5.82,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.76528547),
        dec: Angle.Degrees(-34.31202171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23319",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23319"},
        {"Smithsonian Astrophysical Observation", "SAO 131691"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.22592525),
        dec: Angle.Degrees(-02.41858073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30786"},
        {"Hipparcos Number", "HIP 22391"},
        {"Geneva Identification System", "GEN# +1.00030786"},
        {"Smithsonian Astrophysical Observation", "SAO 195323"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.29896986),
        dec: Angle.Degrees(-34.31176992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161575"},
        {"Hipparcos Number", "HIP 87102"},
        {"Renson", "Renson 45540"},
        {"Smithsonian Astrophysical Observation", "SAO 209263"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.94812112),
        dec: Angle.Degrees(-34.31066866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194183"},
        {"Hipparcos Number", "HIP 100742"},
        {"Smithsonian Astrophysical Observation", "SAO 212107"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.37231337),
        dec: Angle.Degrees(-34.30996845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223245"},
        {"Hipparcos Number", "HIP 117372"},
        {"Smithsonian Astrophysical Observation", "SAO 214780"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.98375296),
        dec: Angle.Degrees(-34.30852724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145596"},
        {"Hipparcos Number", "HIP 79479"},
        {"Fundamental Katalog 5th Edition", "FK5 5427"},
        {"Smithsonian Astrophysical Observation", "SAO 207462"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.30126353),
        dec: Angle.Degrees(-34.30687853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111473"},
        {"Hipparcos Number", "HIP 62623"},
        {"Smithsonian Astrophysical Observation", "SAO 203849"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.47756687),
        dec: Angle.Degrees(-34.30672022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118448"},
        {"Hipparcos Number", "HIP 66471"},
        {"Smithsonian Astrophysical Observation", "SAO 204669"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.41202991),
        dec: Angle.Degrees(-34.30637614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108371"},
        {"Geneva Identification System", "GEN# -0.03415340"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.32163137),
        dec: Angle.Degrees(-34.30586840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174196"},
        {"Hipparcos Number", "HIP 92476"},
        {"Smithsonian Astrophysical Observation", "SAO 210625"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.69507175),
        dec: Angle.Degrees(-34.30509357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36888"},
        {"Hipparcos Number", "HIP 26035"},
        {"Geneva Identification System", "GEN# +1.00036888"},
        {"Smithsonian Astrophysical Observation", "SAO 195955"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.31749681),
        dec: Angle.Degrees(-34.30399437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212764"},
        {"Hipparcos Number", "HIP 110837"},
        {"Smithsonian Astrophysical Observation", "SAO 213826"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.82753235),
        dec: Angle.Degrees(-34.30397972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75498"},
        {"Hipparcos Number", "HIP 43294"},
        {"Smithsonian Astrophysical Observation", "SAO 199663"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.29195502),
        dec: Angle.Degrees(-34.30380891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83848"},
        {"Hipparcos Number", "HIP 47448"},
        {"Smithsonian Astrophysical Observation", "SAO 200612"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.04766473),
        dec: Angle.Degrees(-34.30338995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178298"},
        {"Hipparcos Number", "HIP 94113"},
        {"Smithsonian Astrophysical Observation", "SAO 210993"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.36553732),
        dec: Angle.Degrees(-34.30082787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220456"},
        {"Hipparcos Number", "HIP 115519"},
        {"Smithsonian Astrophysical Observation", "SAO 214518"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.01387797),
        dec: Angle.Degrees(-34.30016030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 243.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196984"},
        {"Hipparcos Number", "HIP 102142"},
        {"Geneva Identification System", "GEN# +1.00196984"},
        {"Smithsonian Astrophysical Observation", "SAO 212354"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.46414773),
        dec: Angle.Degrees(-34.29805340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110504"},
        {"Hipparcos Number", "HIP 62037"},
        {"Smithsonian Astrophysical Observation", "SAO 203741"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.73935911),
        dec: Angle.Degrees(-34.29592954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31701"},
        {"Smithsonian Astrophysical Observation", "SAO 197026"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.47318103),
        dec: Angle.Degrees(-34.29576898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11175"},
        {"Hipparcos Number", "HIP 8464"},
        {"Smithsonian Astrophysical Observation", "SAO 193318"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.28907678),
        dec: Angle.Degrees(-34.29478133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2383"},
        {"Hipparcos Number", "HIP 2175"},
        {"Geneva Identification System", "GEN# +1.00002383"},
        {"Smithsonian Astrophysical Observation", "SAO 192536"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.86558598),
        dec: Angle.Degrees(-34.29415461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28091"},
        {"Hipparcos Number", "HIP 20594"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.16422402),
        dec: Angle.Degrees(-34.29324075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 221.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11582"},
        {"Hipparcos Number", "HIP 8786"},
        {"Geneva Identification System", "GEN# +1.00011582"},
        {"Smithsonian Astrophysical Observation", "SAO 193362"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.25094979),
        dec: Angle.Degrees(-34.29292732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82396",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Larawag"},
        {"Henry Draper", "HD 151680"},
        {"Hipparcos Number", "HIP 82396"},
        {"Cincinnati Publication", "Ci 20 1011"},
        {"Fundamental Katalog 5th Edition", "FK5 628"},
        {"Geneva Identification System", "GEN# +1.00151680"},
        {"Smithsonian Astrophysical Observation", "SAO 208078"},
        {"Wilson Evans Batten Catalogue", "WEB 13910"},
    },
    visualMagnitude: 2.29,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.54268738),
        dec: Angle.Degrees(-34.29260982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -611.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -255.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77157"},
        {"Geneva Identification System", "GEN# -0.03310685"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.30366043),
        dec: Angle.Degrees(-34.29179015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116549"},
        {"Hipparcos Number", "HIP 65446"},
        {"Smithsonian Astrophysical Observation", "SAO 204439"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.20046602),
        dec: Angle.Degrees(-34.28995855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166861"},
        {"Hipparcos Number", "HIP 89357"},
        {"Smithsonian Astrophysical Observation", "SAO 209885"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.51000379),
        dec: Angle.Degrees(-34.28919544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214365"},
        {"Hipparcos Number", "HIP 111744"},
        {"Smithsonian Astrophysical Observation", "SAO 213971"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.53920200),
        dec: Angle.Degrees(-34.28851813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163109"},
        {"Hipparcos Number", "HIP 87785"},
        {"Geneva Identification System", "GEN# +1.00163109"},
        {"Smithsonian Astrophysical Observation", "SAO 209482"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.98410835),
        dec: Angle.Degrees(-34.28661357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99169"},
        {"Hipparcos Number", "HIP 55679"},
        {"Smithsonian Astrophysical Observation", "SAO 202407"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.12936644),
        dec: Angle.Degrees(-34.28617067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224502"},
        {"Hipparcos Number", "HIP 118195"},
        {"Smithsonian Astrophysical Observation", "SAO 214890"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.62186898),
        dec: Angle.Degrees(-34.28589125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3417"},
        {"Hipparcos Number", "HIP 2911"},
        {"Geneva Identification System", "GEN# +1.00003417"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.21767889),
        dec: Angle.Degrees(-34.28061153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158741"},
        {"Hipparcos Number", "HIP 85839"},
        {"Geneva Identification System", "GEN# +1.00158741"},
        {"Smithsonian Astrophysical Observation", "SAO 208935"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.10264642),
        dec: Angle.Degrees(-34.27932379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214941"},
        {"Hipparcos Number", "HIP 112091"},
        {"Geneva Identification System", "GEN# +1.00214941"},
        {"Smithsonian Astrophysical Observation", "SAO 214022"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.56191610),
        dec: Angle.Degrees(-34.27741817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50291"},
        {"Hipparcos Number", "HIP 32880"},
        {"Fundamental Katalog 5th Edition", "FK5 4625"},
        {"Smithsonian Astrophysical Observation", "SAO 197282"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.77377116),
        dec: Angle.Degrees(-34.27662992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51568"},
    },
    visualMagnitude: 11.22,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.99698261),
        dec: Angle.Degrees(-34.27585660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -371.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181037"},
        {"Hipparcos Number", "HIP 95043"},
        {"Smithsonian Astrophysical Observation", "SAO 211186"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.08026169),
        dec: Angle.Degrees(-34.26958413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179884"},
        {"Hipparcos Number", "HIP 94661"},
        {"Smithsonian Astrophysical Observation", "SAO 211099"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.93829482),
        dec: Angle.Degrees(-34.26911774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76564"},
        {"Hipparcos Number", "HIP 43842"},
        {"Geneva Identification System", "GEN# +1.00076564"},
        {"Smithsonian Astrophysical Observation", "SAO 199799"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.94954815),
        dec: Angle.Degrees(-34.26899868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170237"},
        {"Hipparcos Number", "HIP 90646"},
        {"Smithsonian Astrophysical Observation", "SAO 210229"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.43721276),
        dec: Angle.Degrees(-34.26873811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53548"},
        {"Hipparcos Number", "HIP 34062"},
        {"Smithsonian Astrophysical Observation", "SAO 197529"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.98353059),
        dec: Angle.Degrees(-34.26712783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78593"},
        {"Hipparcos Number", "HIP 44836"},
        {"Fundamental Katalog 5th Edition", "FK5 4812"},
        {"Smithsonian Astrophysical Observation", "SAO 200011"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.03308369),
        dec: Angle.Degrees(-34.26267781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72047"},
        {"Hipparcos Number", "HIP 41646"},
        {"Smithsonian Astrophysical Observation", "SAO 199286"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.37878426),
        dec: Angle.Degrees(-34.26229819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93047"},
        {"Hipparcos Number", "HIP 52511"},
        {"Smithsonian Astrophysical Observation", "SAO 201691"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.05165082),
        dec: Angle.Degrees(-34.25786540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101505"},
        {"Hipparcos Number", "HIP 56971"},
        {"Smithsonian Astrophysical Observation", "SAO 202701"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.17830262),
        dec: Angle.Degrees(-34.25743526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184797"},
        {"Hipparcos Number", "HIP 96531"},
        {"Smithsonian Astrophysical Observation", "SAO 211421"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.38070878),
        dec: Angle.Degrees(-34.25691188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40249"},
        {"Hipparcos Number", "HIP 28074"},
        {"Smithsonian Astrophysical Observation", "SAO 196327"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.02887845),
        dec: Angle.Degrees(-34.25515967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29592",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29592"},
        {"Smithsonian Astrophysical Observation", "SAO 196615"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.54961051),
        dec: Angle.Degrees(-34.25497809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125616"},
        {"Hipparcos Number", "HIP 70160"},
        {"Geneva Identification System", "GEN# +1.00125616"},
        {"Smithsonian Astrophysical Observation", "SAO 205470"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.32836545),
        dec: Angle.Degrees(-34.25362837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163354"},
        {"Hipparcos Number", "HIP 87885"},
        {"Smithsonian Astrophysical Observation", "SAO 209511"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.29163381),
        dec: Angle.Degrees(-34.25080103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175026"},
        {"Hipparcos Number", "HIP 92828"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.71550038),
        dec: Angle.Degrees(-34.25054377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113398"},
        {"Hipparcos Number", "HIP 63737"},
        {"Geneva Identification System", "GEN# +1.00113398"},
        {"Smithsonian Astrophysical Observation", "SAO 204086"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.94119658),
        dec: Angle.Degrees(-34.25030168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131812"},
        {"Hipparcos Number", "HIP 73140"},
        {"Smithsonian Astrophysical Observation", "SAO 206116"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.20379868),
        dec: Angle.Degrees(-34.24648429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49302"},
        {"Hipparcos Number", "HIP 32436"},
        {"Smithsonian Astrophysical Observation", "SAO 197193"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.55678731),
        dec: Angle.Degrees(-34.24287588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31142"},
        {"Hipparcos Number", "HIP 22611"},
        {"Geneva Identification System", "GEN# +1.00031142"},
        {"Smithsonian Astrophysical Observation", "SAO 195364"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.97578330),
        dec: Angle.Degrees(-34.23868080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148847"},
        {"Hipparcos Number", "HIP 80987"},
        {"Smithsonian Astrophysical Observation", "SAO 207748"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.09620863),
        dec: Angle.Degrees(-34.23824387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119359"},
        {"Hipparcos Number", "HIP 66968"},
        {"Geneva Identification System", "GEN# +1.00119359"},
        {"Smithsonian Astrophysical Observation", "SAO 204773"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.88229285),
        dec: Angle.Degrees(-34.23800481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17476"},
        {"Hipparcos Number", "HIP 13006"},
        {"Smithsonian Astrophysical Observation", "SAO 193913"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.79501243),
        dec: Angle.Degrees(-34.23680206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11116"},
        {"Hipparcos Number", "HIP 8427"},
        {"Smithsonian Astrophysical Observation", "SAO 193310"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.16445565),
        dec: Angle.Degrees(-34.23634543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76294"},
        {"Smithsonian Astrophysical Observation", "SAO 206780"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.77967346),
        dec: Angle.Degrees(-34.23595452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75671"},
        {"Hipparcos Number", "HIP 43377"},
        {"Smithsonian Astrophysical Observation", "SAO 199683"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.53757628),
        dec: Angle.Degrees(-34.22972172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143443"},
        {"Hipparcos Number", "HIP 78507"},
        {"Smithsonian Astrophysical Observation", "SAO 207240"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.40489109),
        dec: Angle.Degrees(-34.22891666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215853"},
        {"Hipparcos Number", "HIP 112629"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.16793802),
        dec: Angle.Degrees(-34.22871216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101184"},
        {"Hipparcos Number", "HIP 56783"},
        {"Geneva Identification System", "GEN# +1.00101184"},
        {"Smithsonian Astrophysical Observation", "SAO 202659"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.62776234),
        dec: Angle.Degrees(-34.22577204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121614"},
        {"Hipparcos Number", "HIP 68153"},
        {"Smithsonian Astrophysical Observation", "SAO 205022"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.29126410),
        dec: Angle.Degrees(-34.22341437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51042"},
        {"Hipparcos Number", "HIP 33170"},
        {"Celescope Catalog", "CEL 1429"},
        {"Geneva Identification System", "GEN# +1.00051042J"},
        {"Smithsonian Astrophysical Observation", "SAO 197334"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.56170732),
        dec: Angle.Degrees(-34.22288574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31130"},
        {"Hipparcos Number", "HIP 22604"},
        {"Geneva Identification System", "GEN# +1.00031130"},
        {"Smithsonian Astrophysical Observation", "SAO 195361"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.94959392),
        dec: Angle.Degrees(-34.22146320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46525"},
        {"Hipparcos Number", "HIP 31171"},
        {"Smithsonian Astrophysical Observation", "SAO 196916"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.10543158),
        dec: Angle.Degrees(-34.21999563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30062"},
        {"Hipparcos Number", "HIP 21922"},
        {"Smithsonian Astrophysical Observation", "SAO 195247"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.71457756),
        dec: Angle.Degrees(-34.21663766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86450"},
        {"Hipparcos Number", "HIP 48846"},
        {"Smithsonian Astrophysical Observation", "SAO 200910"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.45129580),
        dec: Angle.Degrees(-34.21559792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100606"},
        {"Hipparcos Number", "HIP 56449"},
        {"Smithsonian Astrophysical Observation", "SAO 202581"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.60922824),
        dec: Angle.Degrees(-34.21523642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175797"},
        {"Hipparcos Number", "HIP 93149"},
        {"Smithsonian Astrophysical Observation", "SAO 210776"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.61584692),
        dec: Angle.Degrees(-34.21465091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211349"},
        {"Hipparcos Number", "HIP 110022"},
        {"Geneva Identification System", "GEN# +1.00211349"},
        {"Smithsonian Astrophysical Observation", "SAO 213694"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.26712419),
        dec: Angle.Degrees(-34.21450995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48166"},
        {"Hipparcos Number", "HIP 31948"},
        {"Renson", "Renson 12930"},
        {"Smithsonian Astrophysical Observation", "SAO 197076"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.14002188),
        dec: Angle.Degrees(-34.21243027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218337"},
        {"Hipparcos Number", "HIP 114184"},
        {"Geneva Identification System", "GEN# +1.00218337"},
        {"Smithsonian Astrophysical Observation", "SAO 214323"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.85738439),
        dec: Angle.Degrees(-34.20971613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104983"},
        {"Hipparcos Number", "HIP 58946"},
        {"Fundamental Katalog 5th Edition", "FK5 5065"},
        {"Smithsonian Astrophysical Observation", "SAO 203112"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.29983049),
        dec: Angle.Degrees(-34.20898927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30966"},
        {"Hipparcos Number", "HIP 22507"},
        {"Geneva Identification System", "GEN# +1.00030966"},
        {"Smithsonian Astrophysical Observation", "SAO 195341"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.64773847),
        dec: Angle.Degrees(-34.20719774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30145"},
        {"Smithsonian Astrophysical Observation", "SAO 196708"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.15380551),
        dec: Angle.Degrees(-34.20674240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35676"},
        {"Hipparcos Number", "HIP 25321"},
        {"Geneva Identification System", "GEN# +1.00035676"},
        {"Smithsonian Astrophysical Observation", "SAO 195830"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.24153995),
        dec: Angle.Degrees(-34.20656512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 181.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13005"},
        {"Hipparcos Number", "HIP 9835"},
        {"Smithsonian Astrophysical Observation", "SAO 193508"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.64118281),
        dec: Angle.Degrees(-34.20534475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6627"},
        {"Smithsonian Astrophysical Observation", "SAO 193105"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.26022515),
        dec: Angle.Degrees(-34.20501367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196682"},
        {"Hipparcos Number", "HIP 101987"},
        {"Smithsonian Astrophysical Observation", "SAO 212326"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.02590838),
        dec: Angle.Degrees(-34.20393720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16917"},
        {"Hipparcos Number", "HIP 12581"},
        {"Smithsonian Astrophysical Observation", "SAO 193865"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.44457731),
        dec: Angle.Degrees(-34.20305563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77752"},
        {"Hipparcos Number", "HIP 44448"},
        {"Smithsonian Astrophysical Observation", "SAO 199927"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.83364093),
        dec: Angle.Degrees(-34.20107180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177473"},
        {"Hipparcos Number", "HIP 93823"},
        {"Smithsonian Astrophysical Observation", "SAO 210930"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.60014663),
        dec: Angle.Degrees(-34.20029621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184839"},
        {"Hipparcos Number", "HIP 96554"},
        {"Smithsonian Astrophysical Observation", "SAO 211424"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.44228229),
        dec: Angle.Degrees(-34.19964363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55935"},
        {"Hipparcos Number", "HIP 34928"},
        {"Smithsonian Astrophysical Observation", "SAO 197717"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.41405932),
        dec: Angle.Degrees(-34.19917934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200998"},
        {"Hipparcos Number", "HIP 104306"},
        {"Smithsonian Astrophysical Observation", "SAO 212733"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.95535998),
        dec: Angle.Degrees(-34.19849969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180204"},
        {"Hipparcos Number", "HIP 94777"},
        {"Smithsonian Astrophysical Observation", "SAO 211125"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.27206225),
        dec: Angle.Degrees(-34.19845711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140463"},
        {"Hipparcos Number", "HIP 77135"},
        {"Smithsonian Astrophysical Observation", "SAO 206930"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.24043595),
        dec: Angle.Degrees(-34.19819473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183997"},
        {"Hipparcos Number", "HIP 96199"},
        {"Fundamental Katalog 5th Edition", "FK5 3559"},
        {"Geneva Identification System", "GEN# +1.00183997"},
        {"Smithsonian Astrophysical Observation", "SAO 211361"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.42583865),
        dec: Angle.Degrees(-34.19764015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11535"},
        {"Hipparcos Number", "HIP 8748"},
        {"Geneva Identification System", "GEN# +1.00011535"},
        {"Smithsonian Astrophysical Observation", "SAO 193353"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.14394383),
        dec: Angle.Degrees(-34.19414588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72955"},
        {"Hipparcos Number", "HIP 42065"},
        {"Smithsonian Astrophysical Observation", "SAO 199386"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.61078262),
        dec: Angle.Degrees(-34.19363760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222524"},
        {"Hipparcos Number", "HIP 116885"},
        {"Smithsonian Astrophysical Observation", "SAO 214712"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.37543843),
        dec: Angle.Degrees(-34.19288348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18660"},
        {"Hipparcos Number", "HIP 13904"},
        {"Smithsonian Astrophysical Observation", "SAO 194018"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.75560790),
        dec: Angle.Degrees(-34.18905120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27377"},
        {"Hipparcos Number", "HIP 20036"},
        {"Geneva Identification System", "GEN# +1.00027377"},
        {"Smithsonian Astrophysical Observation", "SAO 194901"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.46134975),
        dec: Angle.Degrees(-34.18655204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167869"},
        {"Hipparcos Number", "HIP 89723"},
        {"Smithsonian Astrophysical Observation", "SAO 209981"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.66218564),
        dec: Angle.Degrees(-34.18459474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42519"},
        {"Hipparcos Number", "HIP 29214"},
        {"Smithsonian Astrophysical Observation", "SAO 196541"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.40854614),
        dec: Angle.Degrees(-34.18020151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19253"},
        {"Hipparcos Number", "HIP 14322"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.18053714),
        dec: Angle.Degrees(-34.18013974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137614"},
        {"Hipparcos Number", "HIP 75723"},
        {"Smithsonian Astrophysical Observation", "SAO 206676"},
    },
    visualMagnitude: 9.63,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.05133394),
        dec: Angle.Degrees(-34.17943367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63077"},
        {"Hipparcos Number", "HIP 37853"},
        {"Cincinnati Publication", "Ci 20 438"},
        {"Geneva Identification System", "GEN# +1.00063077A"},
        {"Smithsonian Astrophysical Observation", "SAO 198404"},
        {"Wilson Evans Batten Catalogue", "WEB 7475"},
    },
    visualMagnitude: 5.36,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.39657467),
        dec: Angle.Degrees(-34.17655092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -220.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1722.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87099"},
        {"Hipparcos Number", "HIP 49165"},
        {"Geneva Identification System", "GEN# +1.00087099"},
        {"Smithsonian Astrophysical Observation", "SAO 200982"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.50193241),
        dec: Angle.Degrees(-34.17361581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1432"},
        {"Hipparcos Number", "HIP 1467"},
        {"Geneva Identification System", "GEN# +1.00001432"},
        {"Smithsonian Astrophysical Observation", "SAO 192452"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.57634577),
        dec: Angle.Degrees(-34.17327560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112947"},
        {"Hipparcos Number", "HIP 63495"},
        {"Geneva Identification System", "GEN# +1.00112947"},
        {"Smithsonian Astrophysical Observation", "SAO 204031"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.15912630),
        dec: Angle.Degrees(-34.17246031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59594"},
        {"Hipparcos Number", "HIP 36381"},
        {"Smithsonian Astrophysical Observation", "SAO 198048"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.32148279),
        dec: Angle.Degrees(-34.17142320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2980"},
        {"Hipparcos Number", "HIP 2588"},
        {"Geneva Identification System", "GEN# +1.00002980"},
        {"Smithsonian Astrophysical Observation", "SAO 192600"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.21973110),
        dec: Angle.Degrees(-34.17007744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1750"},
        {"Hipparcos Number", "HIP 1710"},
        {"Geneva Identification System", "GEN# +1.00001750"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.38365191),
        dec: Angle.Degrees(-34.16969228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32206"},
        {"Hipparcos Number", "HIP 23238"},
        {"Smithsonian Astrophysical Observation", "SAO 195469"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.00518364),
        dec: Angle.Degrees(-34.16688659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172016"},
        {"Hipparcos Number", "HIP 91466"},
        {"Smithsonian Astrophysical Observation", "SAO 210408"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.82448412),
        dec: Angle.Degrees(-34.16628178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10303",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1703 B"},
        {"Henry Draper", "HD 13612B"},
        {"Hipparcos Number", "HIP 10303"},
        {"Geneva Identification System", "GEN# +1.00013612B"},
        {"Smithsonian Astrophysical Observation", "SAO 129751"},
        {"Wilson Evans Batten Catalogue", "WEB 2151"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.19343881),
        dec: Angle.Degrees(-02.39616794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 364.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215669"},
        {"Hipparcos Number", "HIP 112501"},
        {"Geneva Identification System", "GEN# +1.00215669"},
        {"Smithsonian Astrophysical Observation", "SAO 214081"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.83002439),
        dec: Angle.Degrees(-34.16178732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8851"},
        {"Hipparcos Number", "HIP 6739"},
        {"Smithsonian Astrophysical Observation", "SAO 193119"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.68952264),
        dec: Angle.Degrees(-34.16118456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196254"},
        {"Hipparcos Number", "HIP 101739"},
        {"Geneva Identification System", "GEN# +1.00196254"},
        {"Smithsonian Astrophysical Observation", "SAO 212286"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.31633112),
        dec: Angle.Degrees(-34.15814952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38757"},
        {"Smithsonian Astrophysical Observation", "SAO 198607"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.01392776),
        dec: Angle.Degrees(-34.15630449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129546"},
        {"Hipparcos Number", "HIP 72038"},
        {"Geneva Identification System", "GEN# +1.00129546"},
        {"Smithsonian Astrophysical Observation", "SAO 205882"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.03702462),
        dec: Angle.Degrees(-34.15475251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7110"},
        {"Smithsonian Astrophysical Observation", "SAO 193162"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.89719056),
        dec: Angle.Degrees(-34.15026284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113482"},
        {"Hipparcos Number", "HIP 63792"},
        {"Smithsonian Astrophysical Observation", "SAO 204097"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.11886969),
        dec: Angle.Degrees(-34.14993197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7676"},
        {"Hipparcos Number", "HIP 5916"},
        {"Fundamental Katalog 5th Edition", "FK5 4112"},
        {"Geneva Identification System", "GEN# +1.00007676"},
        {"Renson", "Renson 1880"},
        {"Smithsonian Astrophysical Observation", "SAO 193014"},
        {"Wilson Evans Batten Catalogue", "WEB 1344"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.02835218),
        dec: Angle.Degrees(-34.14879320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44506"},
        {"Hipparcos Number", "HIP 30143"},
        {"Celescope Catalog", "CEL 1193"},
        {"Geneva Identification System", "GEN# +1.00044506"},
        {"Smithsonian Astrophysical Observation", "SAO 196707"},
        {"Wilson Evans Batten Catalogue", "WEB 5996"},
    },
    visualMagnitude: 5.55,
    bvColour: -0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.15099685),
        dec: Angle.Degrees(-34.14419295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53891"},
        {"Hipparcos Number", "HIP 34179"},
        {"Smithsonian Astrophysical Observation", "SAO 197550"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.32082147),
        dec: Angle.Degrees(-34.14347053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76437"},
        {"Hipparcos Number", "HIP 43781"},
        {"Smithsonian Astrophysical Observation", "SAO 199780"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.75688959),
        dec: Angle.Degrees(-34.14304710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131399"},
        {"Hipparcos Number", "HIP 72940"},
        {"Smithsonian Astrophysical Observation", "SAO 206071"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.60554231),
        dec: Angle.Degrees(-34.14271249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59026"},
        {"Hipparcos Number", "HIP 36143"},
        {"Celescope Catalog", "CEL 1858"},
        {"Geneva Identification System", "GEN# +1.00059026"},
        {"Smithsonian Astrophysical Observation", "SAO 198000"},
        {"Wilson Evans Batten Catalogue", "WEB 7198"},
    },
    visualMagnitude: 5.90,
    bvColour: -0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.67696453),
        dec: Angle.Degrees(-34.14070792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55828"},
        {"Smithsonian Astrophysical Observation", "SAO 202450"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.62763208),
        dec: Angle.Degrees(-34.14027854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
