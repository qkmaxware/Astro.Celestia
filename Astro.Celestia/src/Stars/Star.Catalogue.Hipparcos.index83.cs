using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_83() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5153"},
        {"Hipparcos Number", "HIP 4198"},
        {"Geneva Identification System", "GEN# +1.00005153"},
        {"Smithsonian Astrophysical Observation", "SAO 74344"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.40405850),
        dec: Angle.Degrees(+24.93290758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110894"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.00783709),
        dec: Angle.Degrees(+24.93774962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 284.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98636",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13277 AB"},
        {"Henry Draper", "HD 190004"},
        {"Hipparcos Number", "HIP 98636"},
        {"Geneva Identification System", "GEN# +1.00190004"},
        {"Smithsonian Astrophysical Observation", "SAO 88098"},
        {"Wilson Evans Batten Catalogue", "WEB 17446"},
    },
    visualMagnitude: 5.23,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.50572521),
        dec: Angle.Degrees(+24.93787365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104784"},
        {"Hipparcos Number", "HIP 58833"},
        {"Geneva Identification System", "GEN# +1.00104784"},
        {"Smithsonian Astrophysical Observation", "SAO 82120"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.00940309),
        dec: Angle.Degrees(+24.93885136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220317"},
        {"Hipparcos Number", "HIP 115410"},
        {"Renson", "Renson 60460"},
        {"Smithsonian Astrophysical Observation", "SAO 91221"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.67321168),
        dec: Angle.Degrees(+24.93889832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128369"},
        {"Hipparcos Number", "HIP 71387"},
        {"Geneva Identification System", "GEN# +1.00128369"},
        {"Smithsonian Astrophysical Observation", "SAO 83424"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.96873599),
        dec: Angle.Degrees(+24.93906987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133923"},
        {"Hipparcos Number", "HIP 73911"},
        {"Smithsonian Astrophysical Observation", "SAO 83661"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.57284303),
        dec: Angle.Degrees(+24.93911066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220170"},
        {"Hipparcos Number", "HIP 115326"},
        {"Smithsonian Astrophysical Observation", "SAO 91201"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.38403003),
        dec: Angle.Degrees(+24.94577056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25462"},
        {"Hipparcos Number", "HIP 18943"},
        {"Smithsonian Astrophysical Observation", "SAO 76415"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.90539675),
        dec: Angle.Degrees(+24.94631190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99915"},
        {"Hipparcos Number", "HIP 56091"},
        {"Geneva Identification System", "GEN# +1.00099915"},
        {"Smithsonian Astrophysical Observation", "SAO 81853"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.46704378),
        dec: Angle.Degrees(+24.94734931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90443"},
        {"Hipparcos Number", "HIP 51152"},
        {"Smithsonian Astrophysical Observation", "SAO 81346"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.73556104),
        dec: Angle.Degrees(+24.94754291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341191"},
        {"Hipparcos Number", "HIP 102745"},
        {"Geneva Identification System", "GEN# +1.00341191"},
        {"Smithsonian Astrophysical Observation", "SAO 89166"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.28063626),
        dec: Angle.Degrees(+24.94888642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -213.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210762"},
        {"Hipparcos Number", "HIP 109602"},
        {"Geneva Identification System", "GEN# +1.00210762"},
        {"Smithsonian Astrophysical Observation", "SAO 90317"},
        {"Wilson Evans Batten Catalogue", "WEB 19693"},
    },
    visualMagnitude: 5.97,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.03369809),
        dec: Angle.Degrees(+24.95063700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112572"},
        {"Hipparcos Number", "HIP 63237"},
        {"Geneva Identification System", "GEN# +1.00112572J"},
        {"Smithsonian Astrophysical Observation", "SAO 82580"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.36663746),
        dec: Angle.Degrees(+24.95163204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284023"},
        {"Hipparcos Number", "HIP 23032"},
        {"Smithsonian Astrophysical Observation", "SAO 76856"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.28883428),
        dec: Angle.Degrees(+24.95274902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220694"},
        {"Hipparcos Number", "HIP 115646"},
        {"Smithsonian Astrophysical Observation", "SAO 91256"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.41434734),
        dec: Angle.Degrees(+24.95377090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1703"},
    },
    visualMagnitude: 11.58,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.35664452),
        dec: Angle.Degrees(+32.77970514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60298"},
        {"Hipparcos Number", "HIP 36874"},
        {"Cincinnati Publication", "Ci 18 906"},
        {"Geneva Identification System", "GEN# +1.00060298"},
        {"Smithsonian Astrophysical Observation", "SAO 79521"},
        {"Wilson Evans Batten Catalogue", "WEB 7323"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.70969349),
        dec: Angle.Degrees(+24.95532849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -352.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110326",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15851 A"},
        {"Henry Draper", "HD 212005"},
        {"Hipparcos Number", "HIP 110326"},
        {"Smithsonian Astrophysical Observation", "SAO 90436"},
        {"Wilson Evans Batten Catalogue", "WEB 19787"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.18644329),
        dec: Angle.Degrees(+24.95686503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252046"},
        {"Hipparcos Number", "HIP 29091"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.04965265),
        dec: Angle.Degrees(+24.95727641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33422",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5608 AB"},
        {"Henry Draper", "HD 51127"},
        {"Hipparcos Number", "HIP 33422"},
        {"Smithsonian Astrophysical Observation", "SAO 78898"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.25525437),
        dec: Angle.Degrees(+24.95774734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136643"},
        {"Hipparcos Number", "HIP 75125"},
        {"Geneva Identification System", "GEN# +1.00136643"},
        {"Smithsonian Astrophysical Observation", "SAO 83778"},
        {"Wilson Evans Batten Catalogue", "WEB 12815"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.27873641),
        dec: Angle.Degrees(+24.95806599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70658",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70658"},
    },
    visualMagnitude: 11.51,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.77964214),
        dec: Angle.Degrees(+24.95944614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25253",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3981 AB"},
        {"Henry Draper", "HD 35187"},
        {"Hipparcos Number", "HIP 25253"},
        {"Geneva Identification System", "GEN# +1.00035187"},
        {"Smithsonian Astrophysical Observation", "SAO 77144"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.00486031),
        dec: Angle.Degrees(+24.96050386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97461",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12964 AB"},
        {"Henry Draper", "HD 187343"},
        {"Hipparcos Number", "HIP 97461"},
        {"Geneva Identification System", "GEN# +1.00187343J"},
        {"Smithsonian Astrophysical Observation", "SAO 87748"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.14291080),
        dec: Angle.Degrees(+24.96219417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140646"},
        {"Hipparcos Number", "HIP 77040"},
        {"Smithsonian Astrophysical Observation", "SAO 83969"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.97321066),
        dec: Angle.Degrees(+24.96267479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111369"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.43063660),
        dec: Angle.Degrees(+24.96320580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 153.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241953"},
        {"Hipparcos Number", "HIP 24489"},
        {"Smithsonian Astrophysical Observation", "SAO 77052"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.81554330),
        dec: Angle.Degrees(+24.96343290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61602"},
        {"Hipparcos Number", "HIP 37434"},
        {"Geneva Identification System", "GEN# +1.00061602"},
        {"Smithsonian Astrophysical Observation", "SAO 79610"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.26315002),
        dec: Angle.Degrees(+24.96522816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166280"},
        {"Hipparcos Number", "HIP 88900"},
        {"Smithsonian Astrophysical Observation", "SAO 85773"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.22068450),
        dec: Angle.Degrees(+24.96664299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33011",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5535 ABC"},
        {"Aitken 2", "ADS 5535"},
        {"Aitken 3", "ADS 5535 AB"},
        {"Henry Draper", "HD 50106"},
        {"Hipparcos Number", "HIP 33011"},
        {"Smithsonian Astrophysical Observation", "SAO 78823"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.18782326),
        dec: Angle.Degrees(+24.96858603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257182"},
        {"Hipparcos Number", "HIP 30682"},
        {"Smithsonian Astrophysical Observation", "SAO 78374"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.71657674),
        dec: Angle.Degrees(+24.97090409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80092"},
        {"Smithsonian Astrophysical Observation", "SAO 84313"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.21513917),
        dec: Angle.Degrees(+24.97192179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32387"},
        {"Hipparcos Number", "HIP 23550"},
        {"Geneva Identification System", "GEN# +1.00032387"},
        {"Smithsonian Astrophysical Observation", "SAO 76929"},
        {"Wilson Evans Batten Catalogue", "WEB 4588"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.96618918),
        dec: Angle.Degrees(+24.97310238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6647"},
        {"Hipparcos Number", "HIP 5277"},
        {"Smithsonian Astrophysical Observation", "SAO 74500"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.87243588),
        dec: Angle.Degrees(+24.97384954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338238"},
        {"Hipparcos Number", "HIP 95011"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.99366836),
        dec: Angle.Degrees(+24.97632134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39297",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39297"},
        {"Smithsonian Astrophysical Observation", "SAO 79874"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.52244525),
        dec: Angle.Degrees(+24.97651976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339128"},
        {"Hipparcos Number", "HIP 97696"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.82315678),
        dec: Angle.Degrees(+24.97665829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72023"},
        {"Hipparcos Number", "HIP 41812"},
        {"Smithsonian Astrophysical Observation", "SAO 80228"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.87165547),
        dec: Angle.Degrees(+24.98117693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258767"},
        {"Hipparcos Number", "HIP 31114"},
        {"Smithsonian Astrophysical Observation", "SAO 78464"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.93308297),
        dec: Angle.Degrees(+24.98218433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155839"},
        {"Hipparcos Number", "HIP 84237"},
        {"Smithsonian Astrophysical Observation", "SAO 84926"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.28458781),
        dec: Angle.Degrees(+24.98561205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15030"},
        {"Smithsonian Astrophysical Observation", "SAO 75803"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.42250382),
        dec: Angle.Degrees(+24.98706373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23712"},
        {"Hipparcos Number", "HIP 17759"},
        {"Geneva Identification System", "GEN# +5.20221705"},
        {"Smithsonian Astrophysical Observation", "SAO 76206"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.02732709),
        dec: Angle.Degrees(+24.98848495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86433"},
        {"Fundamental Katalog 5th Edition", "FK5 5551"},
        {"Smithsonian Astrophysical Observation", "SAO 85293"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.90696715),
        dec: Angle.Degrees(+24.98938786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87565",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10871 AB"},
        {"Henry Draper", "HD 163077"},
        {"Hipparcos Number", "HIP 87565"},
        {"Geneva Identification System", "GEN# +1.00163077"},
        {"Smithsonian Astrophysical Observation", "SAO 85508"},
        {"Wilson Evans Batten Catalogue", "WEB 14770"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.32767307),
        dec: Angle.Degrees(+24.99149983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244516"},
        {"Hipparcos Number", "HIP 25929"},
        {"Geneva Identification System", "GEN# +5.20250155"},
        {"Smithsonian Astrophysical Observation", "SAO 77231"},
        {"Wilson Evans Batten Catalogue", "WEB 5043"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.00134717),
        dec: Angle.Degrees(+24.99161852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245710"},
        {"Hipparcos Number", "HIP 26525"},
        {"Smithsonian Astrophysical Observation", "SAO 77345"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.61849118),
        dec: Angle.Degrees(+24.99209974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187982"},
        {"Henry Draper 2", "HD 187983"},
        {"Hipparcos Number", "HIP 97765"},
        {"Fundamental Katalog 5th Edition", "FK5 3587"},
        {"Geneva Identification System", "GEN# +1.00187982"},
        {"Geneva Identification System 2", "GEN# +1.00187983"},
        {"Smithsonian Astrophysical Observation", "SAO 87840"},
        {"Wilson Evans Batten Catalogue", "WEB 17195"},
    },
    visualMagnitude: 5.54,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.00664208),
        dec: Angle.Degrees(+24.99217156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162901"},
        {"Hipparcos Number", "HIP 87477"},
        {"Smithsonian Astrophysical Observation", "SAO 85491"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.09972096),
        dec: Angle.Degrees(+24.99267123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164923"},
        {"Hipparcos Number", "HIP 88344"},
        {"Fundamental Katalog 5th Edition", "FK5 5587"},
        {"Geneva Identification System", "GEN# +1.00164923"},
        {"Smithsonian Astrophysical Observation", "SAO 85677"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.62210651),
        dec: Angle.Degrees(+24.99347786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183400"},
        {"Hipparcos Number", "HIP 95744"},
        {"Smithsonian Astrophysical Observation", "SAO 87256"},
        {"Wilson Evans Batten Catalogue", "WEB 16753"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.10913964),
        dec: Angle.Degrees(+24.99542948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107513"},
        {"Hipparcos Number", "HIP 60266"},
        {"Geneva Identification System", "GEN# +5.21110082"},
        {"Renson", "Renson 31150"},
        {"Smithsonian Astrophysical Observation", "SAO 82262"},
        {"Wilson Evans Batten Catalogue", "WEB 10718"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.36144485),
        dec: Angle.Degrees(+24.99705063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74891"},
        {"Geneva Identification System", "GEN# +0.02502894"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.58031015),
        dec: Angle.Degrees(+24.99720474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121844"},
        {"Hipparcos Number", "HIP 68180"},
        {"Geneva Identification System", "GEN# +1.00121844"},
        {"Smithsonian Astrophysical Observation", "SAO 83096"},
        {"Wilson Evans Batten Catalogue", "WEB 11959"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.37024139),
        dec: Angle.Degrees(+24.99852422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76277",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9703 A"},
        {"Henry Draper", "HD 139007"},
        {"Hipparcos Number", "HIP 76277"},
        {"Geneva Identification System", "GEN# +1.00139007"},
        {"Smithsonian Astrophysical Observation", "SAO 83895"},
        {"Wilson Evans Batten Catalogue", "WEB 12951"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.70569975),
        dec: Angle.Degrees(+24.99938756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57160"},
        {"Hipparcos Number", "HIP 35617"},
        {"Wilson Evans Batten Catalogue", "WEB 7097"},
    },
    visualMagnitude: 8.40,
    bvColour: 2.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.24587269),
        dec: Angle.Degrees(+24.99948754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211703"},
        {"Hipparcos Number", "HIP 110137"},
        {"Renson", "Renson 58760"},
        {"Smithsonian Astrophysical Observation", "SAO 90407"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.64571799),
        dec: Angle.Degrees(+25.00015414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71978"},
        {"Smithsonian Astrophysical Observation", "SAO 83484"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.82554055),
        dec: Angle.Degrees(+25.00107011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283550"},
        {"Hipparcos Number", "HIP 20091"},
        {"Fundamental Katalog 5th Edition", "FK5 4396"},
        {"Smithsonian Astrophysical Observation", "SAO 76542"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.61597127),
        dec: Angle.Degrees(+25.00391743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86851"},
        {"Smithsonian Astrophysical Observation", "SAO 85374"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.18420213),
        dec: Angle.Degrees(+25.00527668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7301"},
        {"Hipparcos Number", "HIP 5718"},
        {"Smithsonian Astrophysical Observation", "SAO 74568"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.38817869),
        dec: Angle.Degrees(+25.00595160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105510"},
        {"Smithsonian Astrophysical Observation", "SAO 89653"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.54965964),
        dec: Angle.Degrees(+25.00657131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44211"},
        {"Hipparcos Number", "HIP 30234"},
        {"Smithsonian Astrophysical Observation", "SAO 78268"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.41243090),
        dec: Angle.Degrees(+25.00705579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133124"},
        {"Hipparcos Number", "HIP 73568"},
        {"Fundamental Katalog 5th Edition", "FK5 3185"},
        {"Geneva Identification System", "GEN# +1.00133124"},
        {"Smithsonian Astrophysical Observation", "SAO 83624"},
        {"Wilson Evans Batten Catalogue", "WEB 12584"},
    },
    visualMagnitude: 4.80,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.52713391),
        dec: Angle.Degrees(+25.00825646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172541"},
        {"Hipparcos Number", "HIP 91520"},
        {"Smithsonian Astrophysical Observation", "SAO 86298"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.95742258),
        dec: Angle.Degrees(+25.00869271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50928"},
        {"Hipparcos Number", "HIP 33360"},
        {"Smithsonian Astrophysical Observation", "SAO 78885"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.07812634),
        dec: Angle.Degrees(+25.00875135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65648"},
        {"Geneva Identification System", "GEN# +0.02502638"},
        {"Smithsonian Astrophysical Observation", "SAO 82851"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.88943008),
        dec: Angle.Degrees(+25.00912121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187299"},
        {"Hipparcos Number", "HIP 97446"},
        {"Geneva Identification System", "GEN# +1.00187299"},
        {"Smithsonian Astrophysical Observation", "SAO 87740"},
        {"Wilson Evans Batten Catalogue", "WEB 17125"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.08996371),
        dec: Angle.Degrees(+25.00956804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164095"},
        {"Hipparcos Number", "HIP 88013"},
        {"Smithsonian Astrophysical Observation", "SAO 85601"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.66370962),
        dec: Angle.Degrees(+25.01053143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55458"},
        {"Hipparcos Number", "HIP 34950"},
        {"Cincinnati Publication", "Ci 20 414"},
        {"Cincinnati Publication 2", "Ci 18 867"},
        {"Geneva Identification System", "GEN# +1.00055458"},
        {"Smithsonian Astrophysical Observation", "SAO 79187"},
        {"Wilson Evans Batten Catalogue", "WEB 6988"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.47238707),
        dec: Angle.Degrees(+25.01159218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -408.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79373"},
        {"Hipparcos Number", "HIP 45349"},
        {"Geneva Identification System", "GEN# +1.00079373"},
        {"Smithsonian Astrophysical Observation", "SAO 80709"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.61606647),
        dec: Angle.Degrees(+25.01163951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35574"},
        {"Hipparcos Number", "HIP 25463"},
        {"Geneva Identification System", "GEN# +1.00035574"},
        {"Smithsonian Astrophysical Observation", "SAO 77173"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.68238602),
        dec: Angle.Degrees(+25.01169297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56796"},
        {"Geneva Identification System", "GEN# +0.02502399"},
        {"Renson", "Renson 29160"},
    },
    visualMagnitude: 11.67,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.65642026),
        dec: Angle.Degrees(+25.01205659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180124"},
        {"Hipparcos Number", "HIP 94526"},
        {"Geneva Identification System", "GEN# +1.00180124"},
        {"Smithsonian Astrophysical Observation", "SAO 86969"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.58017036),
        dec: Angle.Degrees(+25.01322605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186533"},
        {"Hipparcos Number", "HIP 97110"},
        {"Smithsonian Astrophysical Observation", "SAO 87645"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.02836582),
        dec: Angle.Degrees(+25.01469031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15951"},
        {"Hipparcos Number", "HIP 11982"},
        {"Smithsonian Astrophysical Observation", "SAO 75449"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.63960166),
        dec: Angle.Degrees(+25.01582613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34670"},
        {"Hipparcos Number", "HIP 24897"},
        {"Smithsonian Astrophysical Observation", "SAO 77112"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.04516303),
        dec: Angle.Degrees(+25.01604296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210120"},
        {"Hipparcos Number", "HIP 109224"},
        {"Smithsonian Astrophysical Observation", "SAO 90249"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.91242384),
        dec: Angle.Degrees(+25.01618488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335871"},
        {"Hipparcos Number", "HIP 89613"},
        {"Smithsonian Astrophysical Observation", "SAO 85893"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.31263251),
        dec: Angle.Degrees(+25.01626244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114972"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.29077864),
        dec: Angle.Degrees(+25.01696238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156563"},
        {"Hipparcos Number", "HIP 84579"},
        {"Geneva Identification System", "GEN# +1.00156563"},
        {"Smithsonian Astrophysical Observation", "SAO 84980"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.33959454),
        dec: Angle.Degrees(+25.02299982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6929"},
        {"Smithsonian Astrophysical Observation", "SAO 74745"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.32053193),
        dec: Angle.Degrees(+25.02428136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176939"},
        {"Hipparcos Number", "HIP 93419"},
        {"Smithsonian Astrophysical Observation", "SAO 86714"},
        {"Wilson Evans Batten Catalogue", "WEB 16213"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.39543418),
        dec: Angle.Degrees(+25.02593227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67733",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67733"},
        {"Geneva Identification System", "GEN# +0.02502693"},
        {"Smithsonian Astrophysical Observation", "SAO 83043"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.12953566),
        dec: Angle.Degrees(+25.02750244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179962"},
        {"Hipparcos Number", "HIP 94467"},
        {"Smithsonian Astrophysical Observation", "SAO 86953"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.40553873),
        dec: Angle.Degrees(+25.02764311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99518"},
        {"Hipparcos Number", "HIP 55873"},
        {"Geneva Identification System", "GEN# +1.00099518"},
        {"Smithsonian Astrophysical Observation", "SAO 81833"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.78764329),
        dec: Angle.Degrees(+25.02782457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58779"},
        {"Hipparcos Number", "HIP 36268"},
        {"Geneva Identification System", "GEN# +1.00058779"},
        {"Smithsonian Astrophysical Observation", "SAO 79407"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.01276414),
        dec: Angle.Degrees(+25.02800091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61012"},
        {"Geneva Identification System", "GEN# +5.21110221"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.55877025),
        dec: Angle.Degrees(+25.02836731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100843"},
        {"Hipparcos Number", "HIP 56613"},
        {"Geneva Identification System", "GEN# +1.00100843"},
        {"Smithsonian Astrophysical Observation", "SAO 81896"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.11881016),
        dec: Angle.Degrees(+25.02980337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28580"},
        {"Hipparcos Number", "HIP 21103"},
        {"Geneva Identification System", "GEN# +1.00028580"},
        {"Smithsonian Astrophysical Observation", "SAO 76637"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.81879223),
        dec: Angle.Degrees(+25.03061256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107469"},
        {"Hipparcos Number", "HIP 60230"},
        {"Cincinnati Publication", "Ci 18 1548"},
        {"Geneva Identification System", "GEN# +5.21110081"},
        {"Smithsonian Astrophysical Observation", "SAO 82260"},
        {"Wilson Evans Batten Catalogue", "WEB 10713"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.26473417),
        dec: Angle.Degrees(+25.03131529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -226.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 140.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10775"},
        {"Hipparcos Number", "HIP 8215"},
        {"Smithsonian Astrophysical Observation", "SAO 74914"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.45705026),
        dec: Angle.Degrees(+25.03330225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108576"},
        {"Hipparcos Number", "HIP 60840"},
        {"Geneva Identification System", "GEN# +5.21110143"},
        {"Smithsonian Astrophysical Observation", "SAO 82325"},
        {"Wilson Evans Batten Catalogue", "WEB 10826"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.05787925),
        dec: Angle.Degrees(+25.03355091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65602"},
        {"Hipparcos Number", "HIP 39148"},
        {"Smithsonian Astrophysical Observation", "SAO 79855"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.10900322),
        dec: Angle.Degrees(+25.03406154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120917"},
        {"Hipparcos Number", "HIP 67679"},
        {"Geneva Identification System", "GEN# +1.00120917"},
        {"Smithsonian Astrophysical Observation", "SAO 83040"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.97549577),
        dec: Angle.Degrees(+25.03652680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154049"},
        {"Hipparcos Number", "HIP 83347"},
        {"Smithsonian Astrophysical Observation", "SAO 84774"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.50908799),
        dec: Angle.Degrees(+25.03783106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64007"},
        {"Smithsonian Astrophysical Observation", "SAO 82657"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.73662414),
        dec: Angle.Degrees(+25.03836069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42724",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42724"},
        {"Smithsonian Astrophysical Observation", "SAO 80371"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.60491080),
        dec: Angle.Degrees(+25.04133313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44501"},
        {"Smithsonian Astrophysical Observation", "SAO 80606"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.99787683),
        dec: Angle.Degrees(+25.04139188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42703"},
    },
    visualMagnitude: 10.97,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.54187465),
        dec: Angle.Degrees(+25.04157567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2302"},
        {"Hipparcos Number", "HIP 2135"},
        {"Fundamental Katalog 5th Edition", "FK5 2024"},
        {"Geneva Identification System", "GEN# +1.00002302"},
        {"Smithsonian Astrophysical Observation", "SAO 73997"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.76878613),
        dec: Angle.Degrees(+25.04210825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13872"},
        {"Hipparcos Number", "HIP 10535"},
        {"Fundamental Katalog 5th Edition", "FK5 1059"},
        {"Geneva Identification System", "GEN# +1.00013872"},
        {"Smithsonian Astrophysical Observation", "SAO 75238"},
        {"Wilson Evans Batten Catalogue", "WEB 2211"},
    },
    visualMagnitude: 5.57,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.92847664),
        dec: Angle.Degrees(+25.04325530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174369"},
        {"Hipparcos Number", "HIP 92346"},
        {"Geneva Identification System", "GEN# +1.00174369"},
        {"Smithsonian Astrophysical Observation", "SAO 86462"},
        {"Wilson Evans Batten Catalogue", "WEB 15944"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.30954988),
        dec: Angle.Degrees(+25.04658260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82175"},
        {"Hipparcos Number", "HIP 46689"},
        {"Smithsonian Astrophysical Observation", "SAO 80873"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.77564462),
        dec: Angle.Degrees(+25.04721958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132524"},
        {"Hipparcos Number", "HIP 73303"},
        {"Geneva Identification System", "GEN# +1.00132524"},
        {"Smithsonian Astrophysical Observation", "SAO 83604"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.70681459),
        dec: Angle.Degrees(+25.04799056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32942",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5515 AB"},
        {"Henry Draper", "HD 265025"},
        {"Hipparcos Number", "HIP 32942"},
        {"Smithsonian Astrophysical Observation", "SAO 78807"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.93142156),
        dec: Angle.Degrees(+25.04818079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44780"},
        {"Hipparcos Number", "HIP 30501"},
        {"Fundamental Katalog 5th Edition", "FK5 2488"},
        {"Geneva Identification System", "GEN# +1.00044780"},
        {"Smithsonian Astrophysical Observation", "SAO 78331"},
        {"Wilson Evans Batten Catalogue", "WEB 6072"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.18227627),
        dec: Angle.Degrees(+25.04871782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191704"},
        {"Hipparcos Number", "HIP 99394"},
        {"Smithsonian Astrophysical Observation", "SAO 88291"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.61681923),
        dec: Angle.Degrees(+25.04904701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203560"},
        {"Hipparcos Number", "HIP 105528"},
        {"Smithsonian Astrophysical Observation", "SAO 89657"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.60020029),
        dec: Angle.Degrees(+25.05006112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23088",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3547 A"},
        {"Henry Draper", "HD 31592"},
        {"Hipparcos Number", "HIP 23088"},
        {"Fundamental Katalog 5th Edition", "FK5 2374"},
        {"Geneva Identification System", "GEN# +1.00031592"},
        {"Renson", "Renson 8066"},
        {"Smithsonian Astrophysical Observation", "SAO 76862"},
        {"Wilson Evans Batten Catalogue", "WEB 4481"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.53906826),
        dec: Angle.Degrees(+25.05052129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57727"},
        {"Hipparcos Number", "HIP 35846"},
        {"Geneva Identification System", "GEN# +1.00057727"},
        {"Smithsonian Astrophysical Observation", "SAO 79352"},
        {"Wilson Evans Batten Catalogue", "WEB 7141"},
    },
    visualMagnitude: 5.04,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.86897550),
        dec: Angle.Degrees(+25.05060041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98155"},
        {"Hipparcos Number", "HIP 55171"},
        {"Smithsonian Astrophysical Observation", "SAO 81757"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.44059910),
        dec: Angle.Degrees(+25.05138317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12202"},
        {"Hipparcos Number", "HIP 9371"},
        {"Smithsonian Astrophysical Observation", "SAO 75080"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.10266584),
        dec: Angle.Degrees(+25.05209487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283813"},
        {"Hipparcos Number", "HIP 21759"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.08757376),
        dec: Angle.Degrees(+25.05222941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340279"},
        {"Hipparcos Number", "HIP 100682"},
        {"Geneva Identification System", "GEN# +9.80186026"},
        {"Wilson Evans Batten Catalogue", "WEB 18195"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.18898008),
        dec: Angle.Degrees(+25.05256530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182899"},
        {"Hipparcos Number", "HIP 95536"},
        {"Geneva Identification System", "GEN# +1.00182899"},
        {"Smithsonian Astrophysical Observation", "SAO 87200"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.49148813),
        dec: Angle.Degrees(+25.05299634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110570"},
        {"Smithsonian Astrophysical Observation", "SAO 90473"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.99117119),
        dec: Angle.Degrees(+25.05370882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48759",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7586 AB"},
        {"Henry Draper", "HD 86079"},
        {"Hipparcos Number", "HIP 48759"},
        {"Smithsonian Astrophysical Observation", "SAO 81095"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.18666204),
        dec: Angle.Degrees(+25.05397607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106947"},
        {"Hipparcos Number", "HIP 59952"},
        {"Geneva Identification System", "GEN# +5.21110048"},
        {"Smithsonian Astrophysical Observation", "SAO 82221"},
        {"Wilson Evans Batten Catalogue", "WEB 10653"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.44860644),
        dec: Angle.Degrees(+25.05440722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207994"},
        {"Hipparcos Number", "HIP 107987"},
        {"Geneva Identification System", "GEN# +1.00207994"},
        {"Smithsonian Astrophysical Observation", "SAO 90067"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.15996373),
        dec: Angle.Degrees(+25.05501768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13913"},
        {"Hipparcos Number", "HIP 10576"},
        {"Smithsonian Astrophysical Observation", "SAO 75245"},
        {"Wilson Evans Batten Catalogue", "WEB 2222"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.02955909),
        dec: Angle.Degrees(+25.05661499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168957"},
        {"Hipparcos Number", "HIP 89975"},
        {"Geneva Identification System", "GEN# +1.00168957"},
        {"Smithsonian Astrophysical Observation", "SAO 85964"},
        {"Wilson Evans Batten Catalogue", "WEB 15370"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.36569554),
        dec: Angle.Degrees(+25.05676485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108743"},
        {"Smithsonian Astrophysical Observation", "SAO 90178"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.42689833),
        dec: Angle.Degrees(+25.05866256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107159"},
        {"Hipparcos Number", "HIP 60083"},
        {"Geneva Identification System", "GEN# +5.21110061"},
        {"Smithsonian Astrophysical Observation", "SAO 82238"},
        {"Wilson Evans Batten Catalogue", "WEB 10678"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.81635622),
        dec: Angle.Degrees(+25.06028469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28170"},
        {"Hipparcos Number", "HIP 20812"},
        {"Smithsonian Astrophysical Observation", "SAO 76615"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.89186737),
        dec: Angle.Degrees(+25.06160232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242355"},
        {"Hipparcos Number", "HIP 24705"},
        {"Smithsonian Astrophysical Observation", "SAO 77088"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.49225437),
        dec: Angle.Degrees(+25.06481808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340611"},
        {"Hipparcos Number", "HIP 101516"},
        {"Cincinnati Publication", "Ci 20 1215"},
        {"Geneva Identification System", "GEN# +9.80186031"},
        {"Geneva Identification System 2", "GEN# +1.00340611"},
        {"Geneva Identification System 3", "GEN# +6.10010794"},
        {"Wilson Evans Batten Catalogue", "WEB 18346"},
    },
    visualMagnitude: 11.53,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.59226795),
        dec: Angle.Degrees(+25.06518962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -404.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -564.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137202"},
        {"Hipparcos Number", "HIP 75357"},
        {"Smithsonian Astrophysical Observation", "SAO 83802"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.99430742),
        dec: Angle.Degrees(+25.06653216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61602",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 32"},
        {"Hipparcos Number", "HIP 61602"},
        {"Geneva Identification System", "GEN# +0.02502534"},
        {"Wilson Evans Batten Catalogue", "WEB 10958"},
    },
    visualMagnitude: 10.53,
    bvColour: -0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.34797953),
        dec: Angle.Degrees(+25.06669668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171125"},
        {"Hipparcos Number", "HIP 90855"},
        {"Smithsonian Astrophysical Observation", "SAO 86164"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.01152771),
        dec: Angle.Degrees(+25.06715134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218563"},
        {"Hipparcos Number", "HIP 114289"},
        {"Smithsonian Astrophysical Observation", "SAO 91040"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.21278371),
        dec: Angle.Degrees(+25.06872612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145459"},
        {"Hipparcos Number", "HIP 79233"},
        {"Geneva Identification System", "GEN# +1.00145459"},
        {"Wilson Evans Batten Catalogue", "WEB 13395"},
    },
    visualMagnitude: 11.43,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.56046753),
        dec: Angle.Degrees(+25.07065651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195072"},
        {"Hipparcos Number", "HIP 100972"},
        {"Smithsonian Astrophysical Observation", "SAO 88718"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.09055271),
        dec: Angle.Degrees(+25.07221839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39416"},
        {"Hipparcos Number", "HIP 27847"},
        {"Geneva Identification System", "GEN# +1.00039416"},
        {"Smithsonian Astrophysical Observation", "SAO 77683"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.37633906),
        dec: Angle.Degrees(+25.07342381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195233"},
        {"Hipparcos Number", "HIP 101074"},
        {"Smithsonian Astrophysical Observation", "SAO 88747"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.34175074),
        dec: Angle.Degrees(+25.07423030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175011"},
        {"Hipparcos Number", "HIP 92636"},
        {"Smithsonian Astrophysical Observation", "SAO 86531"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.11978543),
        dec: Angle.Degrees(+25.07586819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37191"},
        {"Smithsonian Astrophysical Observation", "SAO 79568"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.60984196),
        dec: Angle.Degrees(+25.07604204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66452"},
        {"Geneva Identification System", "GEN# +0.02502655"},
        {"Smithsonian Astrophysical Observation", "SAO 82910"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.34442063),
        dec: Angle.Degrees(+25.07609524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17472"},
        {"Hipparcos Number", "HIP 13120"},
        {"Geneva Identification System", "GEN# +1.00017472"},
        {"Smithsonian Astrophysical Observation", "SAO 75587"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.18971928),
        dec: Angle.Degrees(+25.07686323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91950"},
        {"Hipparcos Number", "HIP 51993"},
        {"Geneva Identification System", "GEN# +1.00091950"},
        {"Smithsonian Astrophysical Observation", "SAO 81439"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.33588870),
        dec: Angle.Degrees(+25.08032239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -160.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23155"},
        {"Hipparcos Number", "HIP 17403"},
        {"Celescope Catalog", "CEL 309"},
        {"Geneva Identification System", "GEN# +5.20220153"},
        {"Smithsonian Astrophysical Observation", "SAO 76102"},
        {"Wilson Evans Batten Catalogue", "WEB 3287"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.92992873),
        dec: Angle.Degrees(+25.08083909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 255819"},
        {"Hipparcos Number", "HIP 30289"},
        {"Smithsonian Astrophysical Observation", "SAO 78280"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.57533391),
        dec: Angle.Degrees(+25.08289016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141176"},
        {"Hipparcos Number", "HIP 77291"},
        {"Smithsonian Astrophysical Observation", "SAO 83998"},
        {"Wilson Evans Batten Catalogue", "WEB 13098"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.70905304),
        dec: Angle.Degrees(+25.08520758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62430"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.91777921),
        dec: Angle.Degrees(+25.08758704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132005"},
        {"Hipparcos Number", "HIP 73080"},
        {"Geneva Identification System", "GEN# +1.00132005"},
        {"Smithsonian Astrophysical Observation", "SAO 83587"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.03905771),
        dec: Angle.Degrees(+25.08761251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65856"},
        {"Hipparcos Number", "HIP 39263"},
        {"Geneva Identification System", "GEN# +1.00065856"},
        {"Smithsonian Astrophysical Observation", "SAO 79869"},
        {"Wilson Evans Batten Catalogue", "WEB 7695"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.43238778),
        dec: Angle.Degrees(+25.08943685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127386"},
        {"Hipparcos Number", "HIP 70935"},
        {"Geneva Identification System", "GEN# +1.00127386"},
        {"Smithsonian Astrophysical Observation", "SAO 83385"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.61831178),
        dec: Angle.Degrees(+25.08990499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338751"},
        {"Hipparcos Number", "HIP 96756"},
        {"Geneva Identification System", "GEN# +1.00338751"},
        {"Smithsonian Astrophysical Observation", "SAO 87532"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.02306697),
        dec: Angle.Degrees(+25.09150740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68974",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9113 AB"},
        {"Hipparcos Number", "HIP 68974"},
        {"Smithsonian Astrophysical Observation", "SAO 83176"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.81668496),
        dec: Angle.Degrees(+25.09155163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123999"},
        {"Hipparcos Number", "HIP 69226"},
        {"Fundamental Katalog 5th Edition", "FK5 522"},
        {"Geneva Identification System", "GEN# +1.00123999"},
        {"Smithsonian Astrophysical Observation", "SAO 83203"},
        {"Wilson Evans Batten Catalogue", "WEB 12081"},
    },
    visualMagnitude: 4.82,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.59978522),
        dec: Angle.Degrees(+25.09182293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52765"},
        {"Hipparcos Number", "HIP 34021"},
        {"Smithsonian Astrophysical Observation", "SAO 79014"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.88487915),
        dec: Angle.Degrees(+25.09370784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9225",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9225"},
        {"Smithsonian Astrophysical Observation", "SAO 75064"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.64482457),
        dec: Angle.Degrees(+25.09409374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87401"},
        {"Smithsonian Astrophysical Observation", "SAO 85479"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.91708955),
        dec: Angle.Degrees(+25.09638959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7695"},
        {"Smithsonian Astrophysical Observation", "SAO 74851"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.76695099),
        dec: Angle.Degrees(+25.09642937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5751"},
        {"Hipparcos Number", "HIP 4620"},
        {"Smithsonian Astrophysical Observation", "SAO 74417"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.83682411),
        dec: Angle.Degrees(+25.09782426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137853"},
        {"Hipparcos Number", "HIP 75674"},
        {"Fundamental Katalog 5th Edition", "FK5 3219"},
        {"Geneva Identification System", "GEN# +1.00137853"},
        {"Smithsonian Astrophysical Observation", "SAO 83830"},
        {"Wilson Evans Batten Catalogue", "WEB 12883"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.91195681),
        dec: Angle.Degrees(+25.10165712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3204"},
        {"Hipparcos Number", "HIP 2774"},
        {"Geneva Identification System", "GEN# +1.00003204"},
        {"Smithsonian Astrophysical Observation", "SAO 74121"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.85306346),
        dec: Angle.Degrees(+25.10385145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213787"},
        {"Hipparcos Number", "HIP 111366"},
        {"Smithsonian Astrophysical Observation", "SAO 90598"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.42499892),
        dec: Angle.Degrees(+25.10388633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97523"},
        {"Hipparcos Number", "HIP 54845"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.42201129),
        dec: Angle.Degrees(+25.10423281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58807",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8404 AB"},
        {"Henry Draper", "HD 104742"},
        {"Hipparcos Number", "HIP 58807"},
        {"Smithsonian Astrophysical Observation", "SAO 82119"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.93457995),
        dec: Angle.Degrees(+25.10599545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85428"},
        {"Hipparcos Number", "HIP 48417"},
        {"Smithsonian Astrophysical Observation", "SAO 81058"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.06119184),
        dec: Angle.Degrees(+25.10825180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134335"},
        {"Hipparcos Number", "HIP 74096"},
        {"Geneva Identification System", "GEN# +1.00134335"},
        {"Smithsonian Astrophysical Observation", "SAO 83685"},
        {"Wilson Evans Batten Catalogue", "WEB 12658"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.14818718),
        dec: Angle.Degrees(+25.10863675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9814",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1654 AB"},
        {"Henry Draper", "HD 12824"},
        {"Hipparcos Number", "HIP 9814"},
        {"Smithsonian Astrophysical Observation", "SAO 75140"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.56230681),
        dec: Angle.Degrees(+25.10882838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63646"},
        {"Hipparcos Number", "HIP 38312"},
        {"Geneva Identification System", "GEN# +1.00063646"},
        {"Smithsonian Astrophysical Observation", "SAO 79741"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.74012616),
        dec: Angle.Degrees(+25.11065742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102161"},
        {"Hipparcos Number", "HIP 57351"},
        {"Geneva Identification System", "GEN# +1.00102161"},
        {"Smithsonian Astrophysical Observation", "SAO 81974"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.38140396),
        dec: Angle.Degrees(+25.11109799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4216",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4216"},
        {"Smithsonian Astrophysical Observation", "SAO 74347"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.45225442),
        dec: Angle.Degrees(+25.11656891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183864"},
        {"Hipparcos Number", "HIP 95935"},
        {"Geneva Identification System", "GEN# +1.00183864J"},
        {"Smithsonian Astrophysical Observation", "SAO 87296"},
        {"Wilson Evans Batten Catalogue", "WEB 16800"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.65558327),
        dec: Angle.Degrees(+25.12082800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91366"},
        {"Hipparcos Number", "HIP 51663"},
        {"Smithsonian Astrophysical Observation", "SAO 81409"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.32029878),
        dec: Angle.Degrees(+25.12482912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18737"},
        {"Hipparcos Number", "HIP 14080"},
        {"Smithsonian Astrophysical Observation", "SAO 75685"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.36691094),
        dec: Angle.Degrees(+25.12653878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97231",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 48"},
        {"Henry Draper", "HD 338926"},
        {"Hipparcos Number", "HIP 97231"},
        {"Geneva Identification System", "GEN# +1.00338926"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.41933465),
        dec: Angle.Degrees(+25.12668604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64997"},
        {"Geneva Identification System", "GEN# +0.02502620"},
        {"Smithsonian Astrophysical Observation", "SAO 82778"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.84373139),
        dec: Angle.Degrees(+25.12930002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32246",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Mebsuta"},
        {"Aitken", "ADS 5381 A"},
        {"Henry Draper", "HD 48329"},
        {"Hipparcos Number", "HIP 32246"},
        {"Fundamental Katalog 5th Edition", "FK5 254"},
        {"Geneva Identification System", "GEN# +1.00048329A"},
        {"Smithsonian Astrophysical Observation", "SAO 78682"},
        {"Wilson Evans Batten Catalogue", "WEB 6500"},
    },
    visualMagnitude: 3.06,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.98304088),
        dec: Angle.Degrees(+25.13115531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163529"},
        {"Hipparcos Number", "HIP 87759"},
        {"Smithsonian Astrophysical Observation", "SAO 85548"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.90060461),
        dec: Angle.Degrees(+25.13177417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224002"},
        {"Hipparcos Number", "HIP 117856"},
        {"Renson", "Renson 61400"},
        {"Smithsonian Astrophysical Observation", "SAO 91567"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.57895590),
        dec: Angle.Degrees(+25.13347696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97052"},
        {"Hipparcos Number", "HIP 54615"},
        {"Smithsonian Astrophysical Observation", "SAO 81705"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.65910176),
        dec: Angle.Degrees(+25.13366681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186998"},
        {"Hipparcos Number", "HIP 97319"},
        {"Geneva Identification System", "GEN# +1.00186998"},
        {"Smithsonian Astrophysical Observation", "SAO 87706"},
        {"Wilson Evans Batten Catalogue", "WEB 17102"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.66456764),
        dec: Angle.Degrees(+25.13384038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31867"},
        {"Hipparcos Number", "HIP 23259"},
        {"Geneva Identification System", "GEN# +1.00031867"},
        {"Smithsonian Astrophysical Observation", "SAO 76883"},
        {"Wilson Evans Batten Catalogue", "WEB 4521"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.07284182),
        dec: Angle.Degrees(+25.13642994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103913"},
        {"Hipparcos Number", "HIP 58364"},
        {"Geneva Identification System", "GEN# +1.00103913"},
        {"Smithsonian Astrophysical Observation", "SAO 82077"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.51779056),
        dec: Angle.Degrees(+25.13783722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81871",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10174 AB"},
        {"Henry Draper", "HD 150945"},
        {"Hipparcos Number", "HIP 81871"},
        {"Smithsonian Astrophysical Observation", "SAO 84561"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.83518000),
        dec: Angle.Degrees(+25.14135656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224427"},
        {"Hipparcos Number", "HIP 118131"},
        {"Fundamental Katalog 5th Edition", "FK5 1629"},
        {"Geneva Identification System", "GEN# +1.00224427"},
        {"Smithsonian Astrophysical Observation", "SAO 91611"},
        {"Wilson Evans Batten Catalogue", "WEB 20770"},
    },
    visualMagnitude: 4.63,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.43979002),
        dec: Angle.Degrees(+25.14147936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33366"},
        {"Hipparcos Number", "HIP 24113"},
        {"Cincinnati Publication", "Ci 18 666"},
        {"Geneva Identification System", "GEN# +1.00033366"},
        {"Smithsonian Astrophysical Observation", "SAO 77009"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.68567136),
        dec: Angle.Degrees(+25.14196943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112032"},
        {"Hipparcos Number", "HIP 62884"},
        {"Smithsonian Astrophysical Observation", "SAO 82549"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.31791635),
        dec: Angle.Degrees(+25.14389322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224168"},
        {"Hipparcos Number", "HIP 117972"},
        {"Smithsonian Astrophysical Observation", "SAO 91584"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.92244261),
        dec: Angle.Degrees(+25.14434636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 217.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336846"},
        {"Hipparcos Number", "HIP 91848"},
        {"Smithsonian Astrophysical Observation", "SAO 86372"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.88272527),
        dec: Angle.Degrees(+25.14442791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12772"},
        {"Hipparcos Number", "HIP 9780"},
        {"Geneva Identification System", "GEN# +1.00012772"},
        {"Smithsonian Astrophysical Observation", "SAO 75136"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.44402154),
        dec: Angle.Degrees(+25.14491501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25695",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4068 AB"},
        {"Henry Draper", "HD 35943"},
        {"Hipparcos Number", "HIP 25695"},
        {"Geneva Identification System", "GEN# +1.00035943"},
    },
    visualMagnitude: 5.47,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.31871986),
        dec: Angle.Degrees(+25.15030596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92730"},
        {"Hipparcos Number", "HIP 52412"},
        {"Smithsonian Astrophysical Observation", "SAO 81483"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.71659385),
        dec: Angle.Degrees(+25.15062583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130766"},
        {"Hipparcos Number", "HIP 72480"},
        {"Geneva Identification System", "GEN# +1.00130766"},
        {"Smithsonian Astrophysical Observation", "SAO 83546"},
        {"Wilson Evans Batten Catalogue", "WEB 12456"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.31183890),
        dec: Angle.Degrees(+25.15092163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41136",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41136"},
        {"Cincinnati Publication", "Ci 18 985"},
        {"Geneva Identification System", "GEN# +9.80040020"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.88851058),
        dec: Angle.Degrees(+25.15136039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -222.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209937"},
        {"Hipparcos Number", "HIP 109137"},
        {"Smithsonian Astrophysical Observation", "SAO 90228"},
    },
    visualMagnitude: 7.29,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.60246062),
        dec: Angle.Degrees(+25.15140691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22613"},
        {"Hipparcos Number", "HIP 17037"},
        {"Smithsonian Astrophysical Observation", "SAO 76047"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.78086526),
        dec: Angle.Degrees(+25.15682439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71574"},
        {"Smithsonian Astrophysical Observation", "SAO 83446"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.56504145),
        dec: Angle.Degrees(+25.15704251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8117"},
        {"Hipparcos Number", "HIP 6308"},
        {"Fundamental Katalog 5th Edition", "FK5 4124"},
        {"Geneva Identification System", "GEN# +1.00008117"},
        {"Smithsonian Astrophysical Observation", "SAO 74646"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.26498132),
        dec: Angle.Degrees(+25.15863283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75682"},
        {"Hipparcos Number", "HIP 43554"},
        {"Smithsonian Astrophysical Observation", "SAO 80471"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.05280834),
        dec: Angle.Degrees(+25.15903046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179369"},
        {"Hipparcos Number", "HIP 94270"},
        {"Smithsonian Astrophysical Observation", "SAO 86906"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.81995807),
        dec: Angle.Degrees(+25.15926657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15027"},
        {"Hipparcos Number", "HIP 11336"},
        {"Smithsonian Astrophysical Observation", "SAO 75360"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.46706948),
        dec: Angle.Degrees(+25.15963376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24118"},
        {"Hipparcos Number", "HIP 18046"},
        {"Celescope Catalog", "CEL 371"},
        {"Geneva Identification System", "GEN# +5.20223010"},
        {"Smithsonian Astrophysical Observation", "SAO 76272"},
        {"Wilson Evans Batten Catalogue", "WEB 3478"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.85541671),
        dec: Angle.Degrees(+25.16295722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170951"},
        {"Hipparcos Number", "HIP 90770"},
        {"Smithsonian Astrophysical Observation", "SAO 86150"},
        {"Wilson Evans Batten Catalogue", "WEB 15554"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.79023908),
        dec: Angle.Degrees(+25.16327512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24213"},
        {"Hipparcos Number", "HIP 18106"},
        {"Geneva Identification System", "GEN# +5.20223222"},
        {"Smithsonian Astrophysical Observation", "SAO 76286"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.04781699),
        dec: Angle.Degrees(+25.16347704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80536"},
        {"Hipparcos Number", "HIP 45869"},
        {"Geneva Identification System", "GEN# +1.00080536"},
        {"Smithsonian Astrophysical Observation", "SAO 80776"},
        {"Wilson Evans Batten Catalogue", "WEB 8698"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.29402018),
        dec: Angle.Degrees(+25.16356945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186930"},
        {"Hipparcos Number", "HIP 97276"},
        {"Geneva Identification System", "GEN# +1.00186930"},
        {"Smithsonian Astrophysical Observation", "SAO 87692"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.55684458),
        dec: Angle.Degrees(+25.16704392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220933"},
        {"Hipparcos Number", "HIP 115806"},
        {"Geneva Identification System", "GEN# +1.00220933"},
        {"Renson", "Renson 60570"},
        {"Smithsonian Astrophysical Observation", "SAO 91278"},
        {"Wilson Evans Batten Catalogue", "WEB 20491"},
    },
    visualMagnitude: 5.99,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.91820403),
        dec: Angle.Degrees(+25.16736870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9939"},
        {"Hipparcos Number", "HIP 7564"},
        {"Cincinnati Publication", "Ci 18 218"},
        {"Geneva Identification System", "GEN# +1.00009939"},
        {"Smithsonian Astrophysical Observation", "SAO 74830"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.35512689),
        dec: Angle.Degrees(+25.16827394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -211.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217937"},
        {"Hipparcos Number", "HIP 113893"},
        {"Smithsonian Astrophysical Observation", "SAO 90984"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.98083226),
        dec: Angle.Degrees(+25.16849723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3378"},
        {"Hipparcos Number", "HIP 2908"},
        {"Geneva Identification System", "GEN# +1.00003378"},
        {"Smithsonian Astrophysical Observation", "SAO 74145"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.20732762),
        dec: Angle.Degrees(+25.16941034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60343",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60343"},
        {"Cincinnati Publication", "Ci 20 698"},
        {"Geneva Identification System", "GEN# +9.80059014"},
    },
    visualMagnitude: 11.35,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.59049959),
        dec: Angle.Degrees(+25.17045531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -692.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24905",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3911 A"},
        {"Henry Draper", "HD 34682"},
        {"Hipparcos Number", "HIP 24905"},
        {"Geneva Identification System", "GEN# +1.00034682"},
        {"Smithsonian Astrophysical Observation", "SAO 77113"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.07494470),
        dec: Angle.Degrees(+25.17110487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249590"},
        {"Hipparcos Number", "HIP 28220"},
        {"Geneva Identification System", "GEN# +1.00249590"},
        {"Smithsonian Astrophysical Observation", "SAO 77772"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.44249116),
        dec: Angle.Degrees(+25.17208442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3490"},
        {"Hipparcos Number", "HIP 2990"},
        {"Smithsonian Astrophysical Observation", "SAO 74159"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.50443624),
        dec: Angle.Degrees(+25.17412826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184928"},
        {"Hipparcos Number", "HIP 96383"},
        {"Smithsonian Astrophysical Observation", "SAO 87417"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.94677794),
        dec: Angle.Degrees(+25.17441553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48107",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48107"},
        {"Smithsonian Astrophysical Observation", "SAO 81020"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.12855628),
        dec: Angle.Degrees(+25.17499360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166094"},
        {"Hipparcos Number", "HIP 88842"},
        {"Smithsonian Astrophysical Observation", "SAO 85764"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.03385995),
        dec: Angle.Degrees(+25.17511613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197831"},
        {"Hipparcos Number", "HIP 102420"},
        {"Smithsonian Astrophysical Observation", "SAO 89091"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.31415707),
        dec: Angle.Degrees(+25.17528387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76531",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76531"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.44865617),
        dec: Angle.Degrees(+25.17541176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189614"},
        {"Hipparcos Number", "HIP 98436"},
        {"Smithsonian Astrophysical Observation", "SAO 88040"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.00810078),
        dec: Angle.Degrees(+25.17566954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61316",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61316"},
        {"Geneva Identification System", "GEN# +0.02502524"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.43087056),
        dec: Angle.Degrees(+25.17582143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142929"},
        {"Hipparcos Number", "HIP 78069"},
        {"Geneva Identification System", "GEN# +1.00142929"},
        {"Smithsonian Astrophysical Observation", "SAO 84089"},
        {"Wilson Evans Batten Catalogue", "WEB 13204"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.10334431),
        dec: Angle.Degrees(+25.17594935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104329"},
        {"Geneva Identification System", "GEN# +0.02404329"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.00797917),
        dec: Angle.Degrees(+25.17662957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41221"},
        {"Hipparcos Number", "HIP 28791"},
        {"Smithsonian Astrophysical Observation", "SAO 77925"},
        {"Wilson Evans Batten Catalogue", "WEB 5630"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.17629687),
        dec: Angle.Degrees(+25.17878826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206829"},
        {"Hipparcos Number", "HIP 107311"},
        {"Smithsonian Astrophysical Observation", "SAO 89937"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.03587750),
        dec: Angle.Degrees(+25.17882532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194451"},
        {"Hipparcos Number", "HIP 100686"},
        {"Smithsonian Astrophysical Observation", "SAO 88641"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.19447753),
        dec: Angle.Degrees(+25.17946413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68140"},
        {"Hipparcos Number", "HIP 40157"},
        {"Geneva Identification System", "GEN# +1.00068140"},
        {"Smithsonian Astrophysical Observation", "SAO 80006"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.01805387),
        dec: Angle.Degrees(+25.18035094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120380"},
        {"Hipparcos Number", "HIP 67383"},
        {"Geneva Identification System", "GEN# +1.00120380"},
        {"Smithsonian Astrophysical Observation", "SAO 83002"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.15792995),
        dec: Angle.Degrees(+25.18060843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80272"},
        {"Hipparcos Number", "HIP 45739"},
        {"Geneva Identification System", "GEN# +1.00080272"},
        {"Smithsonian Astrophysical Observation", "SAO 80760"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.87523723),
        dec: Angle.Degrees(+25.18257463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80956"},
        {"Hipparcos Number", "HIP 46058"},
        {"Geneva Identification System", "GEN# +1.00080956"},
        {"Smithsonian Astrophysical Observation", "SAO 80797"},
        {"Wilson Evans Batten Catalogue", "WEB 8724"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.88272405),
        dec: Angle.Degrees(+25.18283840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28697"},
        {"Hipparcos Number", "HIP 21174"},
        {"Geneva Identification System", "GEN# +1.00028697"},
        {"Smithsonian Astrophysical Observation", "SAO 76646"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.09083732),
        dec: Angle.Degrees(+25.18555936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341423"},
        {"Hipparcos Number", "HIP 103761"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.39597466),
        dec: Angle.Degrees(+25.18609675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82015"},
        {"Smithsonian Astrophysical Observation", "SAO 84578"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.31266679),
        dec: Angle.Degrees(+25.18760364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17471"},
        {"Hipparcos Number", "HIP 13121"},
        {"Geneva Identification System", "GEN# +1.00017471"},
        {"Renson", "Renson 4380"},
        {"Smithsonian Astrophysical Observation", "SAO 75588"},
        {"Wilson Evans Batten Catalogue", "WEB 2643"},
    },
    visualMagnitude: 5.89,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.19112221),
        dec: Angle.Degrees(+25.18807322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44050"},
        {"Hipparcos Number", "HIP 30144"},
        {"Smithsonian Astrophysical Observation", "SAO 78251"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.15150448),
        dec: Angle.Degrees(+25.18902612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338313"},
        {"Hipparcos Number", "HIP 95526"},
        {"Smithsonian Astrophysical Observation", "SAO 87197"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.46307208),
        dec: Angle.Degrees(+25.18946802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336277"},
        {"Hipparcos Number", "HIP 90699"},
        {"Smithsonian Astrophysical Observation", "SAO 86136"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.57265214),
        dec: Angle.Degrees(+25.19091670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148555"},
        {"Hipparcos Number", "HIP 80646"},
        {"Geneva Identification System", "GEN# +1.00148555"},
        {"Smithsonian Astrophysical Observation", "SAO 84394"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.98832398),
        dec: Angle.Degrees(+25.19382128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283421"},
        {"Hipparcos Number", "HIP 19468"},
        {"Smithsonian Astrophysical Observation", "SAO 76482"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.53835344),
        dec: Angle.Degrees(+25.19554360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202070"},
        {"Hipparcos Number", "HIP 104727"},
        {"Geneva Identification System", "GEN# +1.00202070"},
        {"Smithsonian Astrophysical Observation", "SAO 89531"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.22225490),
        dec: Angle.Degrees(+25.19780963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 559"},
        {"Hipparcos Number", "HIP 824"},
        {"Smithsonian Astrophysical Observation", "SAO 73783"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.52286733),
        dec: Angle.Degrees(+25.19788575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17803"},
        {"Hipparcos Number", "HIP 13382"},
        {"Smithsonian Astrophysical Observation", "SAO 75612"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.05198711),
        dec: Angle.Degrees(+25.19839234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12548"},
        {"Hipparcos Number", "HIP 9609"},
        {"Smithsonian Astrophysical Observation", "SAO 75113"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.88671721),
        dec: Angle.Degrees(+25.20050776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59752",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59752"},
    },
    visualMagnitude: 11.34,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.80339721),
        dec: Angle.Degrees(+25.20107593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96094"},
        {"Hipparcos Number", "HIP 54196"},
        {"Cincinnati Publication", "Ci 20 605"},
        {"Geneva Identification System", "GEN# +1.00096094"},
        {"Smithsonian Astrophysical Observation", "SAO 81657"},
        {"Wilson Evans Batten Catalogue", "WEB 9793"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.31555535),
        dec: Angle.Degrees(+25.20205348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -400.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64382",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64382"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.93314027),
        dec: Angle.Degrees(+25.20394196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135946"},
        {"Hipparcos Number", "HIP 74799"},
        {"Smithsonian Astrophysical Observation", "SAO 83748"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.29619788),
        dec: Angle.Degrees(+25.20550277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121344"},
        {"Hipparcos Number", "HIP 67901"},
        {"Geneva Identification System", "GEN# +1.00121344"},
        {"Smithsonian Astrophysical Observation", "SAO 83071"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.60586121),
        dec: Angle.Degrees(+25.20600483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254229"},
        {"Hipparcos Number", "HIP 29810"},
        {"Cincinnati Publication", "Ci 20 383"},
        {"Cincinnati Publication 2", "Ci 18 783"},
        {"Smithsonian Astrophysical Observation", "SAO 78171"},
        {"Wilson Evans Batten Catalogue", "WEB 5893"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.16484097),
        dec: Angle.Degrees(+25.20707803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -418.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45665"},
        {"Smithsonian Astrophysical Observation", "SAO 80752"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.62450238),
        dec: Angle.Degrees(+25.20906348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214882"},
        {"Hipparcos Number", "HIP 111987"},
        {"Geneva Identification System", "GEN# +1.00214882"},
        {"Smithsonian Astrophysical Observation", "SAO 90700"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.25034871),
        dec: Angle.Degrees(+25.21029638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163771"},
        {"Hipparcos Number", "HIP 87862"},
        {"Smithsonian Astrophysical Observation", "SAO 85568"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.22756183),
        dec: Angle.Degrees(+25.21132389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38630",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6448 AB"},
        {"Hipparcos Number", "HIP 38630"},
        {"Smithsonian Astrophysical Observation", "SAO 79787"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.65302768),
        dec: Angle.Degrees(+25.21340306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24996"},
        {"Hipparcos Number", "HIP 18629"},
        {"Smithsonian Astrophysical Observation", "SAO 76369"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.80839968),
        dec: Angle.Degrees(+25.21595240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205026"},
        {"Hipparcos Number", "HIP 106309"},
        {"Smithsonian Astrophysical Observation", "SAO 89783"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.96373936),
        dec: Angle.Degrees(+25.21811532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74757"},
        {"Smithsonian Astrophysical Observation", "SAO 83743"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.18039614),
        dec: Angle.Degrees(+25.21819812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29459"},
        {"Hipparcos Number", "HIP 21689"},
        {"Fundamental Katalog 5th Edition", "FK5 2343"},
        {"Geneva Identification System", "GEN# +1.00029459"},
        {"Smithsonian Astrophysical Observation", "SAO 76689"},
        {"Wilson Evans Batten Catalogue", "WEB 4169"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.84640616),
        dec: Angle.Degrees(+25.21830270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57240",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8285 A"},
        {"Henry Draper", "HD 101980"},
        {"Hipparcos Number", "HIP 57240"},
        {"Fundamental Katalog 5th Edition", "FK5 2940"},
        {"Geneva Identification System", "GEN# +1.00101980A"},
        {"Smithsonian Astrophysical Observation", "SAO 81960"},
        {"Wilson Evans Batten Catalogue", "WEB 10295"},
    },
    visualMagnitude: 6.02,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.05488261),
        dec: Angle.Degrees(+25.21830378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9534"},
        {"Hipparcos Number", "HIP 7292"},
        {"Smithsonian Astrophysical Observation", "SAO 74797"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.48233101),
        dec: Angle.Degrees(+25.21835523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87007"},
        {"Smithsonian Astrophysical Observation", "SAO 85403"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.67622433),
        dec: Angle.Degrees(+25.22102703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80601"},
        {"Smithsonian Astrophysical Observation", "SAO 84386"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.85495199),
        dec: Angle.Degrees(+25.22127870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115350",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115350"},
        {"Smithsonian Astrophysical Observation", "SAO 91207"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.46413151),
        dec: Angle.Degrees(+25.22168763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53861"},
        {"Smithsonian Astrophysical Observation", "SAO 81626"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.28229142),
        dec: Angle.Degrees(+25.22204447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148205"},
        {"Hipparcos Number", "HIP 80471"},
        {"Smithsonian Astrophysical Observation", "SAO 84368"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.38902105),
        dec: Angle.Degrees(+25.22229057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81210"},
        {"Hipparcos Number", "HIP 46180"},
        {"Smithsonian Astrophysical Observation", "SAO 80810"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.24963909),
        dec: Angle.Degrees(+25.22490354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338483"},
        {"Hipparcos Number", "HIP 95854"},
        {"Smithsonian Astrophysical Observation", "SAO 87276"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.42873719),
        dec: Angle.Degrees(+25.22805331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39047"},
        {"Hipparcos Number", "HIP 27640"},
        {"Smithsonian Astrophysical Observation", "SAO 77630"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.76066264),
        dec: Angle.Degrees(+25.22884106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59335"},
        {"Geneva Identification System", "GEN# +5.21110008"},
        {"Smithsonian Astrophysical Observation", "SAO 82163"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.57329964),
        dec: Angle.Degrees(+25.22908337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87287"},
        {"Hipparcos Number", "HIP 49353"},
        {"Smithsonian Astrophysical Observation", "SAO 81164"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.12317893),
        dec: Angle.Degrees(+25.23030781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199277"},
        {"Hipparcos Number", "HIP 103281"},
        {"Geneva Identification System", "GEN# +1.00199277"},
        {"Smithsonian Astrophysical Observation", "SAO 89282"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.85954661),
        dec: Angle.Degrees(+25.23061882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35666",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6008 AB"},
        {"Henry Draper", "HD 57289"},
        {"Hipparcos Number", "HIP 35666"},
        {"Smithsonian Astrophysical Observation", "SAO 79317"},
    },
    visualMagnitude: 8.89,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.38699189),
        dec: Angle.Degrees(+25.23184298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43502"},
        {"Smithsonian Astrophysical Observation", "SAO 80463"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.91154865),
        dec: Angle.Degrees(+25.23313301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33645",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5647 AB"},
        {"Henry Draper", "HD 51690"},
        {"Hipparcos Number", "HIP 33645"},
        {"Smithsonian Astrophysical Observation", "SAO 78944"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.83812441),
        dec: Angle.Degrees(+25.23338541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72503"},
        {"Hipparcos Number", "HIP 42035"},
        {"Geneva Identification System", "GEN# +1.00072503"},
        {"Smithsonian Astrophysical Observation", "SAO 80252"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.52737641),
        dec: Angle.Degrees(+25.23346397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98264"},
        {"Hipparcos Number", "HIP 55212"},
        {"Smithsonian Astrophysical Observation", "SAO 81765"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.59767881),
        dec: Angle.Degrees(+25.23509909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11670",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1904 A"},
        {"Henry Draper", "HD 15524"},
        {"Hipparcos Number", "HIP 11670"},
        {"Fundamental Katalog 5th Edition", "FK5 2171"},
        {"Geneva Identification System", "GEN# +1.00015524"},
        {"Smithsonian Astrophysical Observation", "SAO 75407"},
        {"Wilson Evans Batten Catalogue", "WEB 2428"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.63464227),
        dec: Angle.Degrees(+25.23521368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33646",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5647 C"},
        {"Henry Draper", "HD 51689"},
        {"Hipparcos Number", "HIP 33646"},
        {"Geneva Identification System", "GEN# +1.00051689"},
        {"Smithsonian Astrophysical Observation", "SAO 78945"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.84442439),
        dec: Angle.Degrees(+25.23574417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78759"},
        {"Smithsonian Astrophysical Observation", "SAO 84182"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.20180948),
        dec: Angle.Degrees(+25.23685718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67567"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.68522854),
        dec: Angle.Degrees(+25.23819665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180938"},
        {"Hipparcos Number", "HIP 94810"},
        {"Smithsonian Astrophysical Observation", "SAO 87032"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.37909780),
        dec: Angle.Degrees(+25.23829001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68342"},
        {"Cincinnati Publication", "Ci 20 826"},
    },
    visualMagnitude: 10.75,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.84119967),
        dec: Angle.Degrees(+25.24003341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -529.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79510"},
        {"Smithsonian Astrophysical Observation", "SAO 84256"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.36947316),
        dec: Angle.Degrees(+25.24135938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192287"},
        {"Hipparcos Number", "HIP 99638"},
        {"Geneva Identification System", "GEN# +1.00192287"},
        {"Smithsonian Astrophysical Observation", "SAO 88368"},
        {"Wilson Evans Batten Catalogue", "WEB 17856"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.32333131),
        dec: Angle.Degrees(+25.24154597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136863"},
        {"Hipparcos Number", "HIP 75216"},
        {"Renson", "Renson 38880"},
        {"Smithsonian Astrophysical Observation", "SAO 83792"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.55560216),
        dec: Angle.Degrees(+25.24414403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78760",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78760"},
        {"Smithsonian Astrophysical Observation", "SAO 84183"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.20295822),
        dec: Angle.Degrees(+25.24445389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87750"},
        {"Smithsonian Astrophysical Observation", "SAO 85544"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.85683594),
        dec: Angle.Degrees(+25.24453254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18594"},
        {"Hipparcos Number", "HIP 13994"},
        {"Fundamental Katalog 5th Edition", "FK5 4274"},
        {"Smithsonian Astrophysical Observation", "SAO 75679"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.04570853),
        dec: Angle.Degrees(+25.24579582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28773"},
    },
    visualMagnitude: 11.17,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.13650175),
        dec: Angle.Degrees(+25.24603838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46405"},
        {"Smithsonian Astrophysical Observation", "SAO 80839"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.95063424),
        dec: Angle.Degrees(+25.24668136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78585"},
        {"Hipparcos Number", "HIP 44995"},
        {"Wilson Evans Batten Catalogue", "WEB 8594"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.46927359),
        dec: Angle.Degrees(+25.24829290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93157",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11895 AB"},
        {"Henry Draper", "HD 176284"},
        {"Hipparcos Number", "HIP 93157"},
        {"Smithsonian Astrophysical Observation", "SAO 86648"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.63141075),
        dec: Angle.Degrees(+25.24868383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340497"},
        {"Hipparcos Number", "HIP 101126"},
        {"Smithsonian Astrophysical Observation", "SAO 88765"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.48092502),
        dec: Angle.Degrees(+25.24879567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155675"},
        {"Hipparcos Number", "HIP 84138"},
        {"Geneva Identification System", "GEN# +1.00155675"},
        {"Smithsonian Astrophysical Observation", "SAO 84913"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.02744680),
        dec: Angle.Degrees(+25.24895357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15332"},
        {"Geneva Identification System", "GEN# +9.80037032"},
    },
    visualMagnitude: 11.84,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.43638216),
        dec: Angle.Degrees(+25.25264566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 784.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -364.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144287"},
        {"Hipparcos Number", "HIP 78709"},
        {"Cincinnati Publication", "Ci 20 963"},
        {"Geneva Identification System", "GEN# +1.00144287"},
        {"Smithsonian Astrophysical Observation", "SAO 84179"},
        {"Wilson Evans Batten Catalogue", "WEB 13306"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.01678536),
        dec: Angle.Degrees(+25.25315003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -488.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 696.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79235"},
        {"Hipparcos Number", "HIP 45278"},
        {"Geneva Identification System", "GEN# +1.00079235"},
        {"Smithsonian Astrophysical Observation", "SAO 80703"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.42483133),
        dec: Angle.Degrees(+25.25443456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14376",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2336 AB"},
        {"Henry Draper", "HD 19134"},
        {"Hipparcos Number", "HIP 14376"},
        {"Smithsonian Astrophysical Observation", "SAO 75723"},
        {"Wilson Evans Batten Catalogue", "WEB 2807"},
    },
    visualMagnitude: 5.45,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.36119708),
        dec: Angle.Degrees(+25.25519906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16407",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2583 AB"},
        {"Henry Draper", "HD 21744"},
        {"Hipparcos Number", "HIP 16407"},
        {"Fundamental Katalog 5th Edition", "FK5 4319"},
        {"Smithsonian Astrophysical Observation", "SAO 75968"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.81640521),
        dec: Angle.Degrees(+25.25557838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134713"},
        {"Hipparcos Number", "HIP 74256"},
        {"Smithsonian Astrophysical Observation", "SAO 83703"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.63562691),
        dec: Angle.Degrees(+25.25561808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116676",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116676"},
        {"Smithsonian Astrophysical Observation", "SAO 91395"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.67426368),
        dec: Angle.Degrees(+25.26015123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185621"},
        {"Hipparcos Number", "HIP 96649"},
        {"Smithsonian Astrophysical Observation", "SAO 87504"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.75116381),
        dec: Angle.Degrees(+25.26194276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54293"},
        {"Hipparcos Number", "HIP 34532"},
        {"Smithsonian Astrophysical Observation", "SAO 79114"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.33016598),
        dec: Angle.Degrees(+25.26195650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37602"},
        {"Hipparcos Number", "HIP 26732"},
        {"Smithsonian Astrophysical Observation", "SAO 77385"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.19472202),
        dec: Angle.Degrees(+25.26472249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42275"},
        {"Smithsonian Astrophysical Observation", "SAO 80291"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.29993464),
        dec: Angle.Degrees(+25.26558059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172289"},
        {"Hipparcos Number", "HIP 91401"},
        {"Geneva Identification System", "GEN# +1.00172289"},
        {"Smithsonian Astrophysical Observation", "SAO 86270"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.60922116),
        dec: Angle.Degrees(+25.26767597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338831"},
        {"Hipparcos Number", "HIP 97072"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.91534487),
        dec: Angle.Degrees(+25.26923736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197752"},
        {"Hipparcos Number", "HIP 102388"},
        {"Fundamental Katalog 5th Edition", "FK5 3657"},
        {"Geneva Identification System", "GEN# +1.00197752"},
        {"Smithsonian Astrophysical Observation", "SAO 89084"},
        {"Wilson Evans Batten Catalogue", "WEB 18536"},
    },
    visualMagnitude: 4.92,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.21884679),
        dec: Angle.Degrees(+25.27104823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94833"},
        {"Hipparcos Number", "HIP 53538"},
        {"Geneva Identification System", "GEN# +1.00094833"},
        {"Smithsonian Astrophysical Observation", "SAO 81594"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.29403112),
        dec: Angle.Degrees(+25.27210058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9033"},
        {"Hipparcos Number", "HIP 6939"},
        {"Smithsonian Astrophysical Observation", "SAO 74747"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.34788618),
        dec: Angle.Degrees(+25.27534104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31252"},
        {"Hipparcos Number", "HIP 22877"},
        {"Smithsonian Astrophysical Observation", "SAO 76835"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.81832952),
        dec: Angle.Degrees(+25.27718034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76388"},
        {"Smithsonian Astrophysical Observation", "SAO 83904"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.02686078),
        dec: Angle.Degrees(+25.27961657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 471"},
        {"Hipparcos Number", "HIP 754"},
        {"Cincinnati Publication", "Ci 18 11"},
        {"Geneva Identification System", "GEN# +1.00000471"},
        {"Smithsonian Astrophysical Observation", "SAO 73776"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.31514306),
        dec: Angle.Degrees(+25.28231728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24768"},
        {"Hipparcos Number", "HIP 18491"},
        {"Geneva Identification System", "GEN# +1.00024768"},
        {"Smithsonian Astrophysical Observation", "SAO 76345"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.29926252),
        dec: Angle.Degrees(+25.28281126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119665"},
        {"Hipparcos Number", "HIP 67025"},
        {"Geneva Identification System", "GEN# +1.00119665"},
        {"Smithsonian Astrophysical Observation", "SAO 82974"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.04017966),
        dec: Angle.Degrees(+25.28407527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137181"},
        {"Hipparcos Number", "HIP 75350"},
        {"Geneva Identification System", "GEN# +1.00137181"},
        {"Smithsonian Astrophysical Observation", "SAO 83800"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.96591303),
        dec: Angle.Degrees(+25.28508433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221811"},
        {"Hipparcos Number", "HIP 116401"},
        {"Smithsonian Astrophysical Observation", "SAO 91360"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.80935496),
        dec: Angle.Degrees(+25.28560591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167192"},
        {"Hipparcos Number", "HIP 89280"},
        {"Geneva Identification System", "GEN# +1.00167192"},
        {"Smithsonian Astrophysical Observation", "SAO 85833"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.27417194),
        dec: Angle.Degrees(+25.28946033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95188"},
        {"Hipparcos Number", "HIP 53747"},
        {"Geneva Identification System", "GEN# +1.00095188"},
        {"Smithsonian Astrophysical Observation", "SAO 81610"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.95151461),
        dec: Angle.Degrees(+25.28985067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162485"},
        {"Hipparcos Number", "HIP 87297"},
        {"Smithsonian Astrophysical Observation", "SAO 85459"},
        {"Wilson Evans Batten Catalogue", "WEB 14727"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.56248725),
        dec: Angle.Degrees(+25.29096756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86946"},
        {"Hipparcos Number", "HIP 49188"},
        {"Smithsonian Astrophysical Observation", "SAO 81151"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.59004212),
        dec: Angle.Degrees(+25.29206730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6009"},
        {"Hipparcos Number", "HIP 4809"},
        {"Geneva Identification System", "GEN# +1.00006009"},
        {"Smithsonian Astrophysical Observation", "SAO 74439"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.43122439),
        dec: Angle.Degrees(+25.29224974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79318"},
        {"Hipparcos Number", "HIP 45316"},
        {"Smithsonian Astrophysical Observation", "SAO 80707"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.53792554),
        dec: Angle.Degrees(+25.29227359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5515"},
        {"Hipparcos Number", "HIP 4471"},
        {"Smithsonian Astrophysical Observation", "SAO 74390"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.32547081),
        dec: Angle.Degrees(+25.29256908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18623",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18623"},
        {"Geneva Identification System", "GEN# +5.20258043"},
    },
    visualMagnitude: 12.26,
    bvColour: 2.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.77491660),
        dec: Angle.Degrees(+25.29265062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 187.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17434"},
        {"Hipparcos Number", "HIP 13109"},
        {"Smithsonian Astrophysical Observation", "SAO 75584"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.13907215),
        dec: Angle.Degrees(+25.29616548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89000"},
        {"Hipparcos Number", "HIP 50321"},
        {"Geneva Identification System", "GEN# +1.00089000"},
        {"Smithsonian Astrophysical Observation", "SAO 81261"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.14237098),
        dec: Angle.Degrees(+25.29666226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82313"},
        {"Smithsonian Astrophysical Observation", "SAO 84622"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.27291294),
        dec: Angle.Degrees(+25.29708530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340966"},
        {"Hipparcos Number", "HIP 102185"},
        {"Smithsonian Astrophysical Observation", "SAO 89027"},
    },
    visualMagnitude: 9.20,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.57353776),
        dec: Angle.Degrees(+25.29864350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47749"},
        {"Smithsonian Astrophysical Observation", "SAO 80991"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.01974938),
        dec: Angle.Degrees(+25.29935551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35381",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35381"},
        {"Smithsonian Astrophysical Observation", "SAO 79266"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.62861985),
        dec: Angle.Degrees(+25.29950904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223592"},
        {"Hipparcos Number", "HIP 117578"},
        {"Geneva Identification System", "GEN# +1.00223592"},
        {"Smithsonian Astrophysical Observation", "SAO 91533"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.67373727),
        dec: Angle.Degrees(+25.29995756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58966",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58966"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.36162412),
        dec: Angle.Degrees(+25.30138644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56860",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8255 A"},
        {"Henry Draper", "HD 101289"},
        {"Hipparcos Number", "HIP 56860"},
        {"Geneva Identification System", "GEN# +1.00101289"},
        {"Smithsonian Astrophysical Observation", "SAO 81924"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.86917617),
        dec: Angle.Degrees(+25.30161534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7997"},
        {"Smithsonian Astrophysical Observation", "SAO 74885"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.67939309),
        dec: Angle.Degrees(+25.30292821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99957"},
        {"Hipparcos Number", "HIP 56111"},
        {"Geneva Identification System", "GEN# +1.00099957"},
        {"Smithsonian Astrophysical Observation", "SAO 81855"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.53095629),
        dec: Angle.Degrees(+25.30349707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142053"},
        {"Hipparcos Number", "HIP 77676"},
        {"Geneva Identification System", "GEN# +1.00142053"},
        {"Smithsonian Astrophysical Observation", "SAO 84040"},
        {"Wilson Evans Batten Catalogue", "WEB 13145"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.87228158),
        dec: Angle.Degrees(+25.30417366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209045"},
        {"Hipparcos Number", "HIP 108596"},
        {"Smithsonian Astrophysical Observation", "SAO 90156"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.97840276),
        dec: Angle.Degrees(+25.30439540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69926",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69926"},
        {"Geneva Identification System", "GEN# +0.02502757"},
        {"Smithsonian Astrophysical Observation", "SAO 83287"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.65471771),
        dec: Angle.Degrees(+25.30531146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50186"},
        {"Hipparcos Number", "HIP 33054"},
        {"Geneva Identification System", "GEN# +1.00050186"},
        {"Renson", "Renson 13710"},
        {"Smithsonian Astrophysical Observation", "SAO 78827"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.27563784),
        dec: Angle.Degrees(+25.31158203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86403"},
        {"Smithsonian Astrophysical Observation", "SAO 85288"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.82706467),
        dec: Angle.Degrees(+25.31215308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105660",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14943 A"},
        {"Henry Draper", "HD 203858"},
        {"Hipparcos Number", "HIP 105660"},
        {"Smithsonian Astrophysical Observation", "SAO 89680"},
        {"Wilson Evans Batten Catalogue", "WEB 19177"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.03093362),
        dec: Angle.Degrees(+25.31240151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40234"},
        {"Smithsonian Astrophysical Observation", "SAO 80017"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.26857279),
        dec: Angle.Degrees(+25.31459870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45578"},
        {"Hipparcos Number", "HIP 30917"},
        {"Geneva Identification System", "GEN# +1.00045578"},
        {"Smithsonian Astrophysical Observation", "SAO 78429"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.33573048),
        dec: Angle.Degrees(+25.31688787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178850"},
        {"Hipparcos Number", "HIP 94085"},
        {"Geneva Identification System", "GEN# +1.00178850"},
        {"Smithsonian Astrophysical Observation", "SAO 86871"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.29960719),
        dec: Angle.Degrees(+25.31783098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138075"},
        {"Hipparcos Number", "HIP 75785"},
        {"Smithsonian Astrophysical Observation", "SAO 83845"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.22527828),
        dec: Angle.Degrees(+25.31861715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89122",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11144 AB"},
        {"Henry Draper", "HD 166822"},
        {"Hipparcos Number", "HIP 89122"},
        {"Smithsonian Astrophysical Observation", "SAO 85806"},
        {"Wilson Evans Batten Catalogue", "WEB 15133"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.83744221),
        dec: Angle.Degrees(+25.32183019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132256"},
        {"Hipparcos Number", "HIP 73178"},
        {"Geneva Identification System", "GEN# +1.00132256"},
        {"Smithsonian Astrophysical Observation", "SAO 83597"},
        {"Wilson Evans Batten Catalogue", "WEB 12543"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.34687868),
        dec: Angle.Degrees(+25.32359952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47705"},
        {"Hipparcos Number", "HIP 31982"},
        {"Smithsonian Astrophysical Observation", "SAO 78629"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.24989692),
        dec: Angle.Degrees(+25.32372492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267182"},
        {"Hipparcos Number", "HIP 33600"},
        {"Smithsonian Astrophysical Observation", "SAO 78931"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.71696703),
        dec: Angle.Degrees(+25.32423420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104589"},
        {"Hipparcos Number", "HIP 58729"},
        {"Geneva Identification System", "GEN# +1.00104589"},
        {"Smithsonian Astrophysical Observation", "SAO 82114"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.69378588),
        dec: Angle.Degrees(+25.32623029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114492"},
    },
    visualMagnitude: 10.33,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.81967642),
        dec: Angle.Degrees(+25.32788371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22805"},
        {"Hipparcos Number", "HIP 17181"},
        {"Fundamental Katalog 5th Edition", "FK5 1103"},
        {"Geneva Identification System", "GEN# +1.00022805"},
        {"Smithsonian Astrophysical Observation", "SAO 76073"},
        {"Wilson Evans Batten Catalogue", "WEB 3253"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.19293082),
        dec: Angle.Degrees(+25.32952639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39847"},
        {"Hipparcos Number", "HIP 28084"},
        {"Smithsonian Astrophysical Observation", "SAO 77736"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.05368539),
        dec: Angle.Degrees(+25.32990186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68749"},
    },
    visualMagnitude: 11.57,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.08392900),
        dec: Angle.Degrees(+25.33013506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168362"},
        {"Hipparcos Number", "HIP 89696"},
        {"Smithsonian Astrophysical Observation", "SAO 85909"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.58104479),
        dec: Angle.Degrees(+25.33013782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5957"},
        {"Cincinnati Publication", "Ci 20 90"},
        {"Wilson Evans Batten Catalogue", "WEB 1356"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.16283929),
        dec: Angle.Degrees(+25.33172767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 428.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36112"},
        {"Hipparcos Number", "HIP 25793"},
        {"Geneva Identification System", "GEN# +1.00036112"},
        {"Smithsonian Astrophysical Observation", "SAO 77217"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.61469255),
        dec: Angle.Degrees(+25.33258624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107314"},
        {"Cincinnati Publication", "Ci 20 1306"},
        {"Cincinnati Publication 2", "Ci 18 2823"},
        {"Geneva Identification System", "GEN# +0.02404460"},
        {"Smithsonian Astrophysical Observation", "SAO 89941"},
        {"Wilson Evans Batten Catalogue", "WEB 19380"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.04258857),
        dec: Angle.Degrees(+25.33288382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -359.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -506.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17607"},
        {"Hipparcos Number", "HIP 13224"},
        {"Geneva Identification System", "GEN# +1.00017607"},
        {"Smithsonian Astrophysical Observation", "SAO 75597"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.55774432),
        dec: Angle.Degrees(+25.33366853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43095"},
        {"Hipparcos Number", "HIP 29702"},
        {"Smithsonian Astrophysical Observation", "SAO 78146"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.85314460),
        dec: Angle.Degrees(+25.33370384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83753"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.76496276),
        dec: Angle.Degrees(+25.33590750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70030"},
        {"Hipparcos Number", "HIP 40890"},
        {"Geneva Identification System", "GEN# +1.00070030"},
        {"Smithsonian Astrophysical Observation", "SAO 80114"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.17084087),
        dec: Angle.Degrees(+25.33629615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57815"},
        {"Smithsonian Astrophysical Observation", "SAO 82016"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.83758356),
        dec: Angle.Degrees(+25.33649553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126141"},
        {"Hipparcos Number", "HIP 70310"},
        {"Fundamental Katalog 5th Edition", "FK5 3139"},
        {"Geneva Identification System", "GEN# +1.00126141"},
        {"Smithsonian Astrophysical Observation", "SAO 83321"},
        {"Wilson Evans Batten Catalogue", "WEB 12207"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.77884593),
        dec: Angle.Degrees(+25.33801798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1672"},
        {"Hipparcos Number", "HIP 1689"},
        {"Smithsonian Astrophysical Observation", "SAO 73911"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.29166695),
        dec: Angle.Degrees(+25.33831113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153373"},
        {"Hipparcos Number", "HIP 83049"},
        {"Smithsonian Astrophysical Observation", "SAO 84729"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.55085965),
        dec: Angle.Degrees(+25.33852039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118005",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17105 AB"},
        {"Henry Draper", "HD 224217"},
        {"Hipparcos Number", "HIP 118005"},
        {"Smithsonian Astrophysical Observation", "SAO 91589"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.03171013),
        dec: Angle.Degrees(+25.34066635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210515"},
        {"Hipparcos Number", "HIP 109447"},
        {"Smithsonian Astrophysical Observation", "SAO 90284"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.59256424),
        dec: Angle.Degrees(+25.34423698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210027"},
        {"Hipparcos Number", "HIP 109176"},
        {"Fundamental Katalog 5th Edition", "FK5 831"},
        {"Geneva Identification System", "GEN# +1.00210027"},
        {"Smithsonian Astrophysical Observation", "SAO 90238"},
        {"Wilson Evans Batten Catalogue", "WEB 19626"},
    },
    visualMagnitude: 3.77,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.75197729),
        dec: Angle.Degrees(+25.34504610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 296.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28332"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.80299798),
        dec: Angle.Degrees(+25.34511333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223415"},
        {"Hipparcos Number", "HIP 117480"},
        {"Smithsonian Astrophysical Observation", "SAO 91515"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.32822846),
        dec: Angle.Degrees(+25.34616554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205836"},
        {"Hipparcos Number", "HIP 106746"},
        {"Smithsonian Astrophysical Observation", "SAO 89852"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.35348030),
        dec: Angle.Degrees(+25.34672183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75911"},
        {"Smithsonian Astrophysical Observation", "SAO 83856"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.58079690),
        dec: Angle.Degrees(+25.34681084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56546"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.91468592),
        dec: Angle.Degrees(+25.34818415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336044"},
        {"Hipparcos Number", "HIP 90068"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.70427698),
        dec: Angle.Degrees(+25.35130225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195713"},
        {"Hipparcos Number", "HIP 101310"},
        {"Smithsonian Astrophysical Observation", "SAO 88812"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.02346345),
        dec: Angle.Degrees(+25.35205154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184590"},
        {"Hipparcos Number", "HIP 96245"},
        {"Fundamental Katalog 5th Edition", "FK5 5722"},
        {"Geneva Identification System", "GEN# +1.00184590"},
        {"Smithsonian Astrophysical Observation", "SAO 87367"},
        {"Wilson Evans Batten Catalogue", "WEB 16867"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.55873233),
        dec: Angle.Degrees(+25.35256570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153287"},
        {"Hipparcos Number", "HIP 82987"},
        {"Geneva Identification System", "GEN# +1.00153287"},
        {"Smithsonian Astrophysical Observation", "SAO 84720"},
        {"Wilson Evans Batten Catalogue", "WEB 14031"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.37933698),
        dec: Angle.Degrees(+25.35280257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78671"},
        {"Smithsonian Astrophysical Observation", "SAO 84175"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.90876714),
        dec: Angle.Degrees(+25.35282798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43028",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6981 AB"},
        {"Henry Draper", "HD 74670"},
        {"Hipparcos Number", "HIP 43028"},
        {"Smithsonian Astrophysical Observation", "SAO 80407"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.51596247),
        dec: Angle.Degrees(+25.35313859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242052"},
        {"Hipparcos Number", "HIP 24550"},
        {"Smithsonian Astrophysical Observation", "SAO 77062"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.99553500),
        dec: Angle.Degrees(+25.35897181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80581"},
        {"Hipparcos Number", "HIP 45897"},
        {"Smithsonian Astrophysical Observation", "SAO 80780"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.36351038),
        dec: Angle.Degrees(+25.35898810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88421",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11013 B"},
        {"Hipparcos Number", "HIP 88421"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.79813199),
        dec: Angle.Degrees(+25.35943082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283420"},
        {"Hipparcos Number", "HIP 19496"},
        {"Smithsonian Astrophysical Observation", "SAO 76484"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.64946373),
        dec: Angle.Degrees(+25.36255903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26947",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4289 AB"},
        {"Henry Draper", "HD 37924"},
        {"Hipparcos Number", "HIP 26947"},
        {"Geneva Identification System", "GEN# +1.00037924J"},
        {"Smithsonian Astrophysical Observation", "SAO 77441"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.76327451),
        dec: Angle.Degrees(+25.36328454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48008"},
        {"Hipparcos Number", "HIP 32095"},
        {"Geneva Identification System", "GEN# +1.00048008"},
        {"Smithsonian Astrophysical Observation", "SAO 78655"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.57456468),
        dec: Angle.Degrees(+25.36373747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52472"},
        {"Hipparcos Number", "HIP 33921"},
        {"Smithsonian Astrophysical Observation", "SAO 78995"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.58529476),
        dec: Angle.Degrees(+25.36455159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88424",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11013 A"},
        {"Henry Draper", "HD 335569"},
        {"Hipparcos Number", "HIP 88424"},
        {"Smithsonian Astrophysical Observation", "SAO 85686"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.80100747),
        dec: Angle.Degrees(+25.36541191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22747",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3501 AB"},
        {"Henry Draper", "HD 31033"},
        {"Hipparcos Number", "HIP 22747"},
        {"Smithsonian Astrophysical Observation", "SAO 76811"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.40186472),
        dec: Angle.Degrees(+25.36636375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83341"},
        {"Hipparcos Number", "HIP 47298"},
        {"Geneva Identification System", "GEN# +1.00083341"},
        {"Smithsonian Astrophysical Observation", "SAO 80940"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.58884579),
        dec: Angle.Degrees(+25.36661601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171798"},
        {"Hipparcos Number", "HIP 91150"},
        {"Smithsonian Astrophysical Observation", "SAO 86225"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.94044354),
        dec: Angle.Degrees(+25.36692841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114479",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114479"},
        {"Smithsonian Astrophysical Observation", "SAO 91066"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.77159555),
        dec: Angle.Degrees(+25.36700876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83469"},
        {"Hipparcos Number", "HIP 47382"},
        {"Geneva Identification System", "GEN# +1.00083469"},
        {"Smithsonian Astrophysical Observation", "SAO 80954"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.80338812),
        dec: Angle.Degrees(+25.36733763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19503"},
        {"Hipparcos Number", "HIP 14621"},
        {"Smithsonian Astrophysical Observation", "SAO 75752"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.21267933),
        dec: Angle.Degrees(+25.36857053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181047"},
        {"Hipparcos Number", "HIP 94842"},
        {"Cincinnati Publication", "Ci 18 2518"},
        {"Geneva Identification System", "GEN# +1.00181047"},
        {"Smithsonian Astrophysical Observation", "SAO 87044"},
        {"Wilson Evans Batten Catalogue", "WEB 16554"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.47330683),
        dec: Angle.Degrees(+25.36916243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 232.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89024"},
        {"Hipparcos Number", "HIP 50336"},
        {"Geneva Identification System", "GEN# +1.00089024"},
        {"Smithsonian Astrophysical Observation", "SAO 81264"},
        {"Wilson Evans Batten Catalogue", "WEB 9241"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.17433140),
        dec: Angle.Degrees(+25.37069774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339710"},
        {"Hipparcos Number", "HIP 99292"},
        {"Smithsonian Astrophysical Observation", "SAO 88258"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.33861653),
        dec: Angle.Degrees(+25.37309081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111878"},
        {"Hipparcos Number", "HIP 62805"},
        {"Geneva Identification System", "GEN# +1.00111878"},
        {"Smithsonian Astrophysical Observation", "SAO 82543"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.04843116),
        dec: Angle.Degrees(+25.37351429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178593"},
        {"Hipparcos Number", "HIP 93995"},
        {"Geneva Identification System", "GEN# +1.00178593"},
        {"Smithsonian Astrophysical Observation", "SAO 86853"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.06869188),
        dec: Angle.Degrees(+25.37493078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50692"},
        {"Hipparcos Number", "HIP 33277"},
        {"Geneva Identification System", "GEN# +1.00050692"},
        {"Smithsonian Astrophysical Observation", "SAO 78866"},
        {"Wilson Evans Batten Catalogue", "WEB 6692"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.82787799),
        dec: Angle.Degrees(+25.37563643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175204"},
        {"Hipparcos Number", "HIP 92701"},
        {"Geneva Identification System", "GEN# +1.00175204J"},
        {"Smithsonian Astrophysical Observation", "SAO 86543"},
        {"Wilson Evans Batten Catalogue", "WEB 16034"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.33440286),
        dec: Angle.Degrees(+25.37583565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105371"},
        {"Hipparcos Number", "HIP 59165"},
        {"Geneva Identification System", "GEN# +5.21110001"},
        {"Smithsonian Astrophysical Observation", "SAO 82145"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.00266968),
        dec: Angle.Degrees(+25.37715620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340730"},
        {"Hipparcos Number", "HIP 101618"},
        {"Cincinnati Publication", "Ci 18 2671"},
        {"Geneva Identification System", "GEN# +1.00340730"},
        {"Smithsonian Astrophysical Observation", "SAO 88878"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.92255679),
        dec: Angle.Degrees(+25.37802730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -249.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166914"},
        {"Hipparcos Number", "HIP 89157"},
        {"Geneva Identification System", "GEN# +1.00166914"},
        {"Smithsonian Astrophysical Observation", "SAO 85816"},
        {"Wilson Evans Batten Catalogue", "WEB 15145"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.94020438),
        dec: Angle.Degrees(+25.37813554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13610"},
        {"Hipparcos Number", "HIP 10351"},
        {"Geneva Identification System", "GEN# +1.00013610"},
        {"Smithsonian Astrophysical Observation", "SAO 75210"},
        {"Wilson Evans Batten Catalogue", "WEB 2166"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.34102441),
        dec: Angle.Degrees(+25.37928251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58589"},
        {"Smithsonian Astrophysical Observation", "SAO 82098"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.21753610),
        dec: Angle.Degrees(+25.38197727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337487"},
        {"Hipparcos Number", "HIP 93484"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.58079897),
        dec: Angle.Degrees(+25.38386621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187193"},
        {"Hipparcos Number", "HIP 97402"},
        {"Geneva Identification System", "GEN# +1.00187193"},
        {"Smithsonian Astrophysical Observation", "SAO 87729"},
        {"Wilson Evans Batten Catalogue", "WEB 17116"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.95207186),
        dec: Angle.Degrees(+25.38411181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23664"},
        {"Hipparcos Number", "HIP 17729"},
        {"Celescope Catalog", "CEL 346"},
        {"Geneva Identification System", "GEN# +5.20223320"},
        {"Smithsonian Astrophysical Observation", "SAO 76204"},
        {"Wilson Evans Batten Catalogue", "WEB 3389"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.94509494),
        dec: Angle.Degrees(+25.38580834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64037",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64037"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.86398398),
        dec: Angle.Degrees(+25.38635850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65714"},
        {"Hipparcos Number", "HIP 39191"},
        {"Fundamental Katalog 5th Edition", "FK5 1211"},
        {"Geneva Identification System", "GEN# +1.00065714"},
        {"Smithsonian Astrophysical Observation", "SAO 79861"},
        {"Wilson Evans Batten Catalogue", "WEB 7685"},
    },
    visualMagnitude: 5.87,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.23275932),
        dec: Angle.Degrees(+25.39282019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156562"},
        {"Hipparcos Number", "HIP 84574"},
        {"Geneva Identification System", "GEN# +1.00156562"},
        {"Smithsonian Astrophysical Observation", "SAO 84979"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.33542753),
        dec: Angle.Degrees(+25.39565305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43889"},
        {"Smithsonian Astrophysical Observation", "SAO 80521"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.10895015),
        dec: Angle.Degrees(+25.39757947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23430"},
        {"Hipparcos Number", "HIP 17583"},
        {"Celescope Catalog", "CEL 327"},
        {"Geneva Identification System", "GEN# +5.20223318"},
        {"Smithsonian Astrophysical Observation", "SAO 76161"},
        {"Wilson Evans Batten Catalogue", "WEB 3345"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.49636093),
        dec: Angle.Degrees(+25.39870238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116386"},
        {"Geneva Identification System", "GEN# +9.80068029"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.75775043),
        dec: Angle.Degrees(+25.39901334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 270.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22308"},
        {"Hipparcos Number", "HIP 16805"},
        {"Geneva Identification System", "GEN# +1.00022308"},
        {"Smithsonian Astrophysical Observation", "SAO 76020"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.08190709),
        dec: Angle.Degrees(+25.39901643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283341"},
        {"Hipparcos Number", "HIP 18996"},
        {"Smithsonian Astrophysical Observation", "SAO 76422"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.04983547),
        dec: Angle.Degrees(+25.39919327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152342"},
        {"Hipparcos Number", "HIP 82506"},
        {"Geneva Identification System", "GEN# +1.00152342"},
        {"Smithsonian Astrophysical Observation", "SAO 84654"},
        {"Wilson Evans Batten Catalogue", "WEB 13929"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.94371609),
        dec: Angle.Degrees(+25.40018608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36765",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36765"},
        {"Smithsonian Astrophysical Observation", "SAO 79501"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.42726058),
        dec: Angle.Degrees(+25.40049076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220846"},
        {"Hipparcos Number", "HIP 115741"},
        {"Geneva Identification System", "GEN# +1.00220846"},
        {"Renson", "Renson 60540"},
        {"Smithsonian Astrophysical Observation", "SAO 91271"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.73275097),
        dec: Angle.Degrees(+25.40268112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76752"},
        {"Hipparcos Number", "HIP 44089"},
        {"Geneva Identification System", "GEN# +1.00076752"},
        {"Smithsonian Astrophysical Observation", "SAO 80548"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.70792674),
        dec: Angle.Degrees(+25.40531254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84624",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84624"},
        {"Smithsonian Astrophysical Observation", "SAO 84989"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.49857960),
        dec: Angle.Degrees(+25.40536845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85053"},
        {"Hipparcos Number", "HIP 48227"},
        {"Smithsonian Astrophysical Observation", "SAO 81038"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.49251751),
        dec: Angle.Degrees(+25.40896583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283660"},
        {"Hipparcos Number", "HIP 20604"},
    },
    visualMagnitude: 11.15,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.19628178),
        dec: Angle.Degrees(+25.40947280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12661"},
        {"Hipparcos Number", "HIP 9683"},
        {"Geneva Identification System", "GEN# +1.00012661"},
        {"Smithsonian Astrophysical Observation", "SAO 75125"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.14315629),
        dec: Angle.Degrees(+25.41473128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44674"},
        {"Hipparcos Number", "HIP 30452"},
        {"Geneva Identification System", "GEN# +1.00044674"},
        {"Smithsonian Astrophysical Observation", "SAO 78322"},
        {"Wilson Evans Batten Catalogue", "WEB 6063"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.01621400),
        dec: Angle.Degrees(+25.41700600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80275"},
        {"Smithsonian Astrophysical Observation", "SAO 84339"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.79171334),
        dec: Angle.Degrees(+25.41964307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268469"},
        {"Hipparcos Number", "HIP 34061"},
        {"Smithsonian Astrophysical Observation", "SAO 79025"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.97756788),
        dec: Angle.Degrees(+25.41968515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78887"},
        {"Hipparcos Number", "HIP 45105"},
        {"Smithsonian Astrophysical Observation", "SAO 80681"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.84111615),
        dec: Angle.Degrees(+25.41996974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100993"},
        {"Hipparcos Number", "HIP 56690"},
        {"Geneva Identification System", "GEN# +1.00100993"},
        {"Smithsonian Astrophysical Observation", "SAO 81906"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.35972422),
        dec: Angle.Degrees(+25.42021807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208201"},
        {"Hipparcos Number", "HIP 108099"},
        {"Smithsonian Astrophysical Observation", "SAO 90086"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.53718822),
        dec: Angle.Degrees(+25.42146649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109627"},
        {"Hipparcos Number", "HIP 61500"},
        {"Geneva Identification System", "GEN# +5.21110194"},
        {"Smithsonian Astrophysical Observation", "SAO 82398"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.00795126),
        dec: Angle.Degrees(+25.42371422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161002"},
        {"Hipparcos Number", "HIP 86637"},
        {"Geneva Identification System", "GEN# +1.00161002"},
        {"Smithsonian Astrophysical Observation", "SAO 85335"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.53632739),
        dec: Angle.Degrees(+25.42504610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52403"},
        {"Hipparcos Number", "HIP 33893"},
        {"Geneva Identification System", "GEN# +1.00052403"},
        {"Smithsonian Astrophysical Observation", "SAO 78990"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.53005467),
        dec: Angle.Degrees(+25.42560095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13466"},
        {"Hipparcos Number", "HIP 10269"},
        {"Smithsonian Astrophysical Observation", "SAO 75197"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.05322147),
        dec: Angle.Degrees(+25.42611794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85065",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85065"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.77207686),
        dec: Angle.Degrees(+25.42640507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72621"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.71890676),
        dec: Angle.Degrees(+25.42698536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150173"},
        {"Hipparcos Number", "HIP 81460"},
        {"Smithsonian Astrophysical Observation", "SAO 84497"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.57076246),
        dec: Angle.Degrees(+25.42701083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81777",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81777"},
        {"Geneva Identification System", "GEN# +0.02503118"},
        {"Smithsonian Astrophysical Observation", "SAO 84548"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.54479610),
        dec: Angle.Degrees(+25.42710279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73662"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.86367822),
        dec: Angle.Degrees(+25.42717985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66491",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66491"},
        {"Geneva Identification System", "GEN# +0.02602477"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.46045458),
        dec: Angle.Degrees(+25.42785217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84772"},
        {"Smithsonian Astrophysical Observation", "SAO 85009"},
    },
    visualMagnitude: 10.87,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.91679448),
        dec: Angle.Degrees(+25.43208280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219991"},
        {"Hipparcos Number", "HIP 115212"},
        {"Smithsonian Astrophysical Observation", "SAO 91178"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.03693452),
        dec: Angle.Degrees(+25.43333294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150799"},
        {"Hipparcos Number", "HIP 81781"},
        {"Geneva Identification System", "GEN# +1.00150799"},
        {"Smithsonian Astrophysical Observation", "SAO 84549"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.55895327),
        dec: Angle.Degrees(+25.43363305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 169.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202573"},
        {"Hipparcos Number", "HIP 105000"},
        {"Fundamental Katalog 5th Edition", "FK5 5877"},
        {"Geneva Identification System", "GEN# +1.00202573"},
        {"Smithsonian Astrophysical Observation", "SAO 89570"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.98839702),
        dec: Angle.Degrees(+25.43392748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143455"},
        {"Hipparcos Number", "HIP 78319"},
        {"Geneva Identification System", "GEN# +1.00143455"},
        {"Smithsonian Astrophysical Observation", "SAO 84128"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.87097213),
        dec: Angle.Degrees(+25.43479445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38010"},
        {"Hipparcos Number", "HIP 26998"},
        {"Geneva Identification System", "GEN# +1.00038010"},
        {"Smithsonian Astrophysical Observation", "SAO 77459"},
        {"Wilson Evans Batten Catalogue", "WEB 5318"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.91275218),
        dec: Angle.Degrees(+25.43955233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8791"},
        {"Hipparcos Number", "HIP 6773"},
        {"Geneva Identification System", "GEN# +1.00008791"},
        {"Smithsonian Astrophysical Observation", "SAO 74730"},
        {"Wilson Evans Batten Catalogue", "WEB 1478"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.77320159),
        dec: Angle.Degrees(+25.43979148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79200"},
        {"Hipparcos Number", "HIP 45260"},
        {"Smithsonian Astrophysical Observation", "SAO 80696"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.35950183),
        dec: Angle.Degrees(+25.43995124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57890"},
        {"Smithsonian Astrophysical Observation", "SAO 82019"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.09893862),
        dec: Angle.Degrees(+25.44174293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69392"},
        {"Hipparcos Number", "HIP 40640"},
        {"Smithsonian Astrophysical Observation", "SAO 80072"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.44415403),
        dec: Angle.Degrees(+25.44219886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123822"},
        {"Hipparcos Number", "HIP 69147"},
        {"Geneva Identification System", "GEN# +1.00123822"},
        {"Smithsonian Astrophysical Observation", "SAO 83195"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.33316120),
        dec: Angle.Degrees(+25.44255371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41139"},
        {"Hipparcos Number", "HIP 28742"},
        {"Smithsonian Astrophysical Observation", "SAO 77918"},
        {"Wilson Evans Batten Catalogue", "WEB 5623"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.05028640),
        dec: Angle.Degrees(+25.44404851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134694"},
        {"Hipparcos Number", "HIP 74249"},
        {"Geneva Identification System", "GEN# +1.00134694"},
        {"Smithsonian Astrophysical Observation", "SAO 83699"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.60710241),
        dec: Angle.Degrees(+25.44479760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204627"},
        {"Hipparcos Number", "HIP 106080"},
        {"Cincinnati Publication", "Ci 18 2791"},
        {"Geneva Identification System", "GEN# +1.00204627"},
        {"Smithsonian Astrophysical Observation", "SAO 89741"},
        {"Wilson Evans Batten Catalogue", "WEB 19227"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.31331115),
        dec: Angle.Degrees(+25.44502827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212073"},
        {"Hipparcos Number", "HIP 110367"},
        {"Smithsonian Astrophysical Observation", "SAO 90438"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.31175495),
        dec: Angle.Degrees(+25.44639356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3053"},
        {"Hipparcos Number", "HIP 2672"},
        {"Geneva Identification System", "GEN# +1.00003053"},
        {"Smithsonian Astrophysical Observation", "SAO 74101"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.46753416),
        dec: Angle.Degrees(+25.44805100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36483",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6130 AB"},
        {"Henry Draper", "HD 59332"},
        {"Hipparcos Number", "HIP 36483"},
        {"Smithsonian Astrophysical Observation", "SAO 79444"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.60119151),
        dec: Angle.Degrees(+25.44864034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56164",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56164"},
        {"Smithsonian Astrophysical Observation", "SAO 81861"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.69555330),
        dec: Angle.Degrees(+25.45158670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41727"},
        {"Hipparcos Number", "HIP 29075"},
        {"Geneva Identification System", "GEN# +1.00041727"},
        {"Smithsonian Astrophysical Observation", "SAO 78002"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.99748101),
        dec: Angle.Degrees(+25.45635452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219211"},
        {"Hipparcos Number", "HIP 114688"},
        {"Geneva Identification System", "GEN# +1.00219211"},
        {"Smithsonian Astrophysical Observation", "SAO 91108"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.49902901),
        dec: Angle.Degrees(+25.45645432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62794",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62794"},
        {"Geneva Identification System", "GEN# +0.02602401"},
        {"Smithsonian Astrophysical Observation", "SAO 82541"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.00942044),
        dec: Angle.Degrees(+25.45671376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6953"},
        {"Hipparcos Number", "HIP 5494"},
        {"Geneva Identification System", "GEN# +1.00006953"},
        {"Smithsonian Astrophysical Observation", "SAO 74530"},
        {"Wilson Evans Batten Catalogue", "WEB 1213"},
    },
    visualMagnitude: 5.81,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.58103932),
        dec: Angle.Degrees(+25.45803989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106321"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.01565578),
        dec: Angle.Degrees(+25.45816371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190886"},
        {"Hipparcos Number", "HIP 99023"},
        {"Geneva Identification System", "GEN# +1.00190886"},
        {"Renson", "Renson 53080"},
        {"Smithsonian Astrophysical Observation", "SAO 88196"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.54706052),
        dec: Angle.Degrees(+25.45838986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77504",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9799 A"},
        {"Henry Draper", "HD 141690"},
        {"Hipparcos Number", "HIP 77504"},
        {"Geneva Identification System", "GEN# +1.00141690A"},
        {"Smithsonian Astrophysical Observation", "SAO 84018"},
        {"Wilson Evans Batten Catalogue", "WEB 13124"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.38731753),
        dec: Angle.Degrees(+25.46019353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133641"},
        {"Hipparcos Number", "HIP 73768"},
        {"Geneva Identification System", "GEN# +1.00133641"},
        {"Smithsonian Astrophysical Observation", "SAO 83649"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.18829445),
        dec: Angle.Degrees(+25.46043918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98154"},
        {"Hipparcos Number", "HIP 55166"},
        {"Geneva Identification System", "GEN# +1.00098154"},
        {"Smithsonian Astrophysical Observation", "SAO 81755"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.42065963),
        dec: Angle.Degrees(+25.46046802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7273"},
        {"Hipparcos Number", "HIP 5701"},
        {"Smithsonian Astrophysical Observation", "SAO 74563"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.33927556),
        dec: Angle.Degrees(+25.46079553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 417"},
        {"Hipparcos Number", "HIP 716"},
        {"Geneva Identification System", "GEN# +1.00000417"},
        {"Smithsonian Astrophysical Observation", "SAO 73769"},
        {"Wilson Evans Batten Catalogue", "WEB 121"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.21695394),
        dec: Angle.Degrees(+25.46285169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77503",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9799 B"},
        {"Henry Draper", "HD 141690B"},
        {"Hipparcos Number", "HIP 77503"},
        {"Geneva Identification System", "GEN# +1.14169020"},
        {"Wilson Evans Batten Catalogue", "WEB 13121"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.38699513),
        dec: Angle.Degrees(+25.46403614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 253870"},
        {"Hipparcos Number", "HIP 29680"},
        {"Smithsonian Astrophysical Observation", "SAO 78140"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.78694136),
        dec: Angle.Degrees(+25.46502509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190676"},
        {"Hipparcos Number", "HIP 98929"},
        {"Smithsonian Astrophysical Observation", "SAO 88170"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.30675260),
        dec: Angle.Degrees(+25.46516558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18507"},
        {"Hipparcos Number", "HIP 13915"},
        {"Smithsonian Astrophysical Observation", "SAO 75672"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.81439868),
        dec: Angle.Degrees(+25.46593323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173190"},
        {"Hipparcos Number", "HIP 91799"},
        {"Geneva Identification System", "GEN# +1.00173190"},
        {"Smithsonian Astrophysical Observation", "SAO 86356"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.77216921),
        dec: Angle.Degrees(+25.46702336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220899"},
        {"Hipparcos Number", "HIP 115787"},
        {"Geneva Identification System", "GEN# +1.00220899"},
        {"Smithsonian Astrophysical Observation", "SAO 91275"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.85554636),
        dec: Angle.Degrees(+25.46789713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218356"},
        {"Hipparcos Number", "HIP 114155"},
        {"Fundamental Katalog 5th Edition", "FK5 3848"},
        {"Geneva Identification System", "GEN# +1.00218356"},
        {"Smithsonian Astrophysical Observation", "SAO 91019"},
        {"Wilson Evans Batten Catalogue", "WEB 20271"},
    },
    visualMagnitude: 4.76,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.77807997),
        dec: Angle.Degrees(+25.46833959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47960"},
        {"Hipparcos Number", "HIP 32086"},
        {"Geneva Identification System", "GEN# +1.00047960"},
        {"Smithsonian Astrophysical Observation", "SAO 78653"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.54983241),
        dec: Angle.Degrees(+25.46856272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216218"},
        {"Hipparcos Number", "HIP 112809"},
        {"Smithsonian Astrophysical Observation", "SAO 90824"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.68548979),
        dec: Angle.Degrees(+25.47138667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222994"},
        {"Hipparcos Number", "HIP 117185"},
        {"Smithsonian Astrophysical Observation", "SAO 91468"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.39605239),
        dec: Angle.Degrees(+25.47193678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15756"},
        {"Hipparcos Number", "HIP 11822"},
        {"Smithsonian Astrophysical Observation", "SAO 75433"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.12650815),
        dec: Angle.Degrees(+25.47259321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43111"},
        {"Smithsonian Astrophysical Observation", "SAO 80418"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.70404045),
        dec: Angle.Degrees(+25.47361368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69622",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69622"},
        {"Geneva Identification System", "GEN# +0.02602544"},
        {"Smithsonian Astrophysical Observation", "SAO 83250"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.74812203),
        dec: Angle.Degrees(+25.47467108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247332"},
        {"Hipparcos Number", "HIP 27236"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.58494491),
        dec: Angle.Degrees(+25.47643305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149474"},
        {"Hipparcos Number", "HIP 81119"},
        {"Smithsonian Astrophysical Observation", "SAO 84456"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.51771735),
        dec: Angle.Degrees(+25.47678544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338218"},
        {"Hipparcos Number", "HIP 95186"},
        {"Geneva Identification System", "GEN# +1.00338218"},
        {"Smithsonian Astrophysical Observation", "SAO 87118"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.45769452),
        dec: Angle.Degrees(+25.47740800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196332"},
        {"Hipparcos Number", "HIP 101627"},
        {"Smithsonian Astrophysical Observation", "SAO 88880"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.97467815),
        dec: Angle.Degrees(+25.47871834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203032"},
        {"Hipparcos Number", "HIP 105247"},
        {"Geneva Identification System", "GEN# +1.00203032"},
        {"Smithsonian Astrophysical Observation", "SAO 89612"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.76598153),
        dec: Angle.Degrees(+25.48003309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210789"},
        {"Hipparcos Number", "HIP 109621"},
        {"Smithsonian Astrophysical Observation", "SAO 90320"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.09578453),
        dec: Angle.Degrees(+25.48348156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55501"},
        {"Smithsonian Astrophysical Observation", "SAO 81790"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.49621036),
        dec: Angle.Degrees(+25.48395941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55601"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.85074902),
        dec: Angle.Degrees(+25.48420256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49500"},
        {"Hipparcos Number", "HIP 32743"},
        {"Geneva Identification System", "GEN# +1.00049500"},
        {"Smithsonian Astrophysical Observation", "SAO 78778"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.43012659),
        dec: Angle.Degrees(+25.48445522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14918"},
        {"Hipparcos Number", "HIP 11265"},
        {"Geneva Identification System", "GEN# +1.00014918J"},
        {"Smithsonian Astrophysical Observation", "SAO 75348"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.25789539),
        dec: Angle.Degrees(+25.48691599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145458"},
        {"Hipparcos Number", "HIP 79225"},
        {"Geneva Identification System", "GEN# +1.00145458"},
        {"Smithsonian Astrophysical Observation", "SAO 84224"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.52698835),
        dec: Angle.Degrees(+25.48776330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40695"},
        {"Hipparcos Number", "HIP 28548"},
        {"Geneva Identification System", "GEN# +1.00040695"},
        {"Smithsonian Astrophysical Observation", "SAO 77854"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.39564292),
        dec: Angle.Degrees(+25.48824680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5197"},
        {"Hipparcos Number", "HIP 4235"},
        {"Smithsonian Astrophysical Observation", "SAO 74349"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.50140933),
        dec: Angle.Degrees(+25.48825331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194780"},
        {"Hipparcos Number", "HIP 100832"},
        {"Geneva Identification System", "GEN# +1.00194780"},
        {"Smithsonian Astrophysical Observation", "SAO 88681"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.68077994),
        dec: Angle.Degrees(+25.48838307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189040"},
        {"Hipparcos Number", "HIP 98188"},
        {"Geneva Identification System", "GEN# +1.00189040"},
        {"Smithsonian Astrophysical Observation", "SAO 87972"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.29904566),
        dec: Angle.Degrees(+25.48881259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171232"},
        {"Hipparcos Number", "HIP 90906"},
        {"Geneva Identification System", "GEN# +1.00171232"},
        {"Smithsonian Astrophysical Observation", "SAO 86172"},
        {"Wilson Evans Batten Catalogue", "WEB 15591"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.14972471),
        dec: Angle.Degrees(+25.48943759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103614"},
        {"Hipparcos Number", "HIP 58189"},
        {"Geneva Identification System", "GEN# +1.00103614"},
        {"Smithsonian Astrophysical Observation", "SAO 82057"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.00447958),
        dec: Angle.Degrees(+25.48954576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164728"},
        {"Hipparcos Number", "HIP 88275"},
        {"Geneva Identification System", "GEN# +1.00164728"},
        {"Smithsonian Astrophysical Observation", "SAO 85651"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.39257462),
        dec: Angle.Degrees(+25.48961895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94480"},
        {"Hipparcos Number", "HIP 53355"},
        {"Geneva Identification System", "GEN# +1.00094480"},
        {"Renson", "Renson 27280"},
        {"Smithsonian Astrophysical Observation", "SAO 81576"},
        {"Wilson Evans Batten Catalogue", "WEB 9687"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.67584742),
        dec: Angle.Degrees(+25.49072336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66800"},
        {"Hipparcos Number", "HIP 39648"},
        {"Smithsonian Astrophysical Observation", "SAO 79936"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.53053984),
        dec: Angle.Degrees(+25.49387054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43383"},
        {"Hipparcos Number", "HIP 29833"},
        {"Geneva Identification System", "GEN# +1.00043383"},
        {"Smithsonian Astrophysical Observation", "SAO 78173"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.22990298),
        dec: Angle.Degrees(+25.49554645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110111"},
        {"Smithsonian Astrophysical Observation", "SAO 90403"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.57430186),
        dec: Angle.Degrees(+25.49557034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220582"},
        {"Hipparcos Number", "HIP 115583"},
        {"Geneva Identification System", "GEN# +1.00220582"},
        {"Smithsonian Astrophysical Observation", "SAO 91245"},
        {"Wilson Evans Batten Catalogue", "WEB 20459"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.18910052),
        dec: Angle.Degrees(+25.49638984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183034"},
        {"Hipparcos Number", "HIP 95593"},
        {"Smithsonian Astrophysical Observation", "SAO 87212"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.64903291),
        dec: Angle.Degrees(+25.49675298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69962"},
        {"Hipparcos Number", "HIP 40860"},
        {"Geneva Identification System", "GEN# +1.00069962"},
        {"Smithsonian Astrophysical Observation", "SAO 80109"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.07304635),
        dec: Angle.Degrees(+25.49684386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62192"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.20235559),
        dec: Angle.Degrees(+25.49781365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206027"},
        {"Hipparcos Number", "HIP 106872"},
        {"Geneva Identification System", "GEN# +1.00206027"},
        {"Smithsonian Astrophysical Observation", "SAO 89870"},
        {"Wilson Evans Batten Catalogue", "WEB 19316"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.68818128),
        dec: Angle.Degrees(+25.49881799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94747"},
        {"Hipparcos Number", "HIP 53492"},
        {"Geneva Identification System", "GEN# +1.00094747"},
        {"Smithsonian Astrophysical Observation", "SAO 81591"},
        {"Wilson Evans Batten Catalogue", "WEB 9710"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.14351153),
        dec: Angle.Degrees(+25.50026291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337890"},
        {"Hipparcos Number", "HIP 94179"},
        {"Smithsonian Astrophysical Observation", "SAO 86888"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.58870795),
        dec: Angle.Degrees(+25.50414367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154084"},
        {"Hipparcos Number", "HIP 83367"},
        {"Fundamental Katalog 5th Edition", "FK5 3356"},
        {"Geneva Identification System", "GEN# +1.00154084"},
        {"Smithsonian Astrophysical Observation", "SAO 84776"},
        {"Wilson Evans Batten Catalogue", "WEB 14089"},
    },
    visualMagnitude: 5.76,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.57775223),
        dec: Angle.Degrees(+25.50537839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187504"},
        {"Hipparcos Number", "HIP 97532"},
        {"Geneva Identification System", "GEN# +1.00187504"},
        {"Smithsonian Astrophysical Observation", "SAO 87770"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.34323698),
        dec: Angle.Degrees(+25.50589844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154635"},
        {"Hipparcos Number", "HIP 83643"},
        {"Geneva Identification System", "GEN# +1.00154635"},
        {"Smithsonian Astrophysical Observation", "SAO 84826"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.42455336),
        dec: Angle.Degrees(+25.50700043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67767"},
        {"Hipparcos Number", "HIP 40023"},
        {"Fundamental Katalog 5th Edition", "FK5 2633"},
        {"Geneva Identification System", "GEN# +1.00067767"},
        {"Smithsonian Astrophysical Observation", "SAO 79995"},
        {"Wilson Evans Batten Catalogue", "WEB 7806"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.61344988),
        dec: Angle.Degrees(+25.50817993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -348.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75883",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9675 AB"},
        {"Henry Draper", "HD 138232"},
        {"Hipparcos Number", "HIP 75883"},
        {"Smithsonian Astrophysical Observation", "SAO 83852"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.49363817),
        dec: Angle.Degrees(+25.50860898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111813"},
        {"Hipparcos Number", "HIP 62758"},
        {"Geneva Identification System", "GEN# +1.00111813"},
        {"Smithsonian Astrophysical Observation", "SAO 82536"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.91041943),
        dec: Angle.Degrees(+25.50892211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193221"},
        {"Hipparcos Number", "HIP 100083"},
        {"Geneva Identification System", "GEN# +1.00193221"},
        {"Smithsonian Astrophysical Observation", "SAO 88488"},
        {"Wilson Evans Batten Catalogue", "WEB 18022"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.55984735),
        dec: Angle.Degrees(+25.50960082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61504"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.02358232),
        dec: Angle.Degrees(+25.50994237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42052"},
        {"Smithsonian Astrophysical Observation", "SAO 80255"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.57705657),
        dec: Angle.Degrees(+25.51042399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45023"},
        {"Hipparcos Number", "HIP 30622"},
        {"Geneva Identification System", "GEN# +1.00045023"},
        {"Smithsonian Astrophysical Observation", "SAO 78362"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.52878082),
        dec: Angle.Degrees(+25.51123097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14333"},
        {"Hipparcos Number", "HIP 10845"},
        {"Geneva Identification System", "GEN# +1.00014333"},
        {"Smithsonian Astrophysical Observation", "SAO 75284"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.89557615),
        dec: Angle.Degrees(+25.51253997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81553",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81553"},
        {"Smithsonian Astrophysical Observation", "SAO 84518"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.83681426),
        dec: Angle.Degrees(+25.51265667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41939"},
        {"Hipparcos Number", "HIP 29158"},
        {"Geneva Identification System", "GEN# +1.00041939"},
        {"Smithsonian Astrophysical Observation", "SAO 78035"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.25973380),
        dec: Angle.Degrees(+25.51273197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37709"},
        {"Hipparcos Number", "HIP 26818"},
        {"Geneva Identification System", "GEN# +1.00037709"},
        {"Smithsonian Astrophysical Observation", "SAO 77399"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.41248281),
        dec: Angle.Degrees(+25.51355580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99581"},
        {"Hipparcos Number", "HIP 55904"},
        {"Smithsonian Astrophysical Observation", "SAO 81836"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.88366140),
        dec: Angle.Degrees(+25.51401059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19943"},
        {"Hipparcos Number", "HIP 14984"},
        {"Fundamental Katalog 5th Edition", "FK5 4295"},
        {"Smithsonian Astrophysical Observation", "SAO 75798"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.28646084),
        dec: Angle.Degrees(+25.51510880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148618"},
        {"Hipparcos Number", "HIP 80681"},
        {"Smithsonian Astrophysical Observation", "SAO 84399"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.08249671),
        dec: Angle.Degrees(+25.51544339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338738"},
        {"Hipparcos Number", "HIP 96730"},
        {"Smithsonian Astrophysical Observation", "SAO 87524"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.95824482),
        dec: Angle.Degrees(+25.51548165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49719",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7657 AB"},
        {"Henry Draper", "HD 87956"},
        {"Hipparcos Number", "HIP 49719"},
        {"Smithsonian Astrophysical Observation", "SAO 81205"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.26989192),
        dec: Angle.Degrees(+25.51769990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283545"},
        {"Hipparcos Number", "HIP 19902"},
        {"Smithsonian Astrophysical Observation", "SAO 76528"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.04228650),
        dec: Angle.Degrees(+25.51797045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99393",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13458 AB"},
        {"Henry Draper", "HD 339706"},
        {"Hipparcos Number", "HIP 99393"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.61313909),
        dec: Angle.Degrees(+25.51941992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339814"},
        {"Hipparcos Number", "HIP 99635"},
        {"Geneva Identification System", "GEN# +2.68820006"},
        {"Smithsonian Astrophysical Observation", "SAO 88367"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.31539886),
        dec: Angle.Degrees(+25.52129513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103543"},
        {"Hipparcos Number", "HIP 58135"},
        {"Fundamental Katalog 5th Edition", "FK5 2952"},
        {"Geneva Identification System", "GEN# +1.00103543"},
        {"Smithsonian Astrophysical Observation", "SAO 82051"},
        {"Wilson Evans Batten Catalogue", "WEB 10409"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.85228529),
        dec: Angle.Degrees(+25.52224731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29454"},
    },
    visualMagnitude: 10.42,
    bvColour: 2.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.09119419),
        dec: Angle.Degrees(+25.52390819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12781",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12781"},
        {"Cincinnati Publication", "Ci 20 180"},
        {"Geneva Identification System", "GEN# +6.10010109"},
        {"Geneva Identification System 2", "GEN# +9.80036031"},
        {"Wilson Evans Batten Catalogue", "WEB 2599"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.06229453),
        dec: Angle.Degrees(+25.52424901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 864.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -367.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206674"},
        {"Hipparcos Number", "HIP 107237"},
        {"Geneva Identification System", "GEN# +1.00206674"},
        {"Smithsonian Astrophysical Observation", "SAO 89923"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.78859503),
        dec: Angle.Degrees(+25.52514693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 573"},
        {"Hipparcos Number", "HIP 835"},
        {"Geneva Identification System", "GEN# +1.00000573"},
        {"Renson", "Renson 80"},
        {"Smithsonian Astrophysical Observation", "SAO 73784"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.55428058),
        dec: Angle.Degrees(+25.52675303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89847",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11267 AB"},
        {"Henry Draper", "HD 168695"},
        {"Hipparcos Number", "HIP 89847"},
        {"Geneva Identification System", "GEN# +1.00168695J"},
        {"Smithsonian Astrophysical Observation", "SAO 85935"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.02849900),
        dec: Angle.Degrees(+25.53136551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283139"},
        {"Hipparcos Number", "HIP 18273"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.63896057),
        dec: Angle.Degrees(+25.53246317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4551"},
        {"Hipparcos Number", "HIP 3713"},
        {"Geneva Identification System", "GEN# +1.00004551"},
        {"Smithsonian Astrophysical Observation", "SAO 74277"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.92105630),
        dec: Angle.Degrees(+25.53447685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150431"},
        {"Hipparcos Number", "HIP 81607"},
        {"Geneva Identification System", "GEN# +1.00150431"},
        {"Smithsonian Astrophysical Observation", "SAO 84527"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.00274000),
        dec: Angle.Degrees(+25.53527489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191615"},
        {"Hipparcos Number", "HIP 99353"},
        {"Geneva Identification System", "GEN# +1.00191615"},
        {"Smithsonian Astrophysical Observation", "SAO 88279"},
        {"Wilson Evans Batten Catalogue", "WEB 17730"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.48910416),
        dec: Angle.Degrees(+25.53646790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57265"},
        {"Geneva Identification System", "GEN# +0.02602251"},
        {"Wilson Evans Batten Catalogue", "WEB 10299"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.15016940),
        dec: Angle.Degrees(+25.53669024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -519.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96418"},
        {"Hipparcos Number", "HIP 54347"},
        {"Geneva Identification System", "GEN# +1.00096418"},
        {"Smithsonian Astrophysical Observation", "SAO 81674"},
        {"Wilson Evans Batten Catalogue", "WEB 9814"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.77044383),
        dec: Angle.Degrees(+25.53716248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157087"},
        {"Hipparcos Number", "HIP 84821"},
        {"Geneva Identification System", "GEN# +1.00157087"},
        {"Renson", "Renson 44174"},
        {"Smithsonian Astrophysical Observation", "SAO 85016"},
        {"Wilson Evans Batten Catalogue", "WEB 14320"},
    },
    visualMagnitude: 5.36,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.04094409),
        dec: Angle.Degrees(+25.53764398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67074",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67074"},
        {"Geneva Identification System", "GEN# +0.02602490"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.20832336),
        dec: Angle.Degrees(+25.53813394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12131"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.06225903),
        dec: Angle.Degrees(+25.53855351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173869"},
        {"Hipparcos Number", "HIP 92127"},
        {"Geneva Identification System", "GEN# +1.00173869"},
        {"Smithsonian Astrophysical Observation", "SAO 86425"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.65310899),
        dec: Angle.Degrees(+25.53896772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210210"},
        {"Hipparcos Number", "HIP 109276"},
        {"Geneva Identification System", "GEN# +1.00210210"},
        {"Smithsonian Astrophysical Observation", "SAO 90259"},
        {"Wilson Evans Batten Catalogue", "WEB 19637"},
    },
    visualMagnitude: 6.08,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.07190211),
        dec: Angle.Degrees(+25.54361178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184978"},
        {"Hipparcos Number", "HIP 96405"},
        {"Geneva Identification System", "GEN# +1.00184978"},
        {"Smithsonian Astrophysical Observation", "SAO 87423"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.00660937),
        dec: Angle.Degrees(+25.54644222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151699"},
        {"Hipparcos Number", "HIP 82235"},
        {"Geneva Identification System", "GEN# +1.00151699"},
        {"Smithsonian Astrophysical Observation", "SAO 84614"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.01884772),
        dec: Angle.Degrees(+25.54732970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116515"},
        {"Hipparcos Number", "HIP 65366"},
        {"Geneva Identification System", "GEN# +1.00116515"},
        {"Smithsonian Astrophysical Observation", "SAO 82819"},
        {"Wilson Evans Batten Catalogue", "WEB 11535"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.94490200),
        dec: Angle.Degrees(+25.54789394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116753"},
        {"Hipparcos Number", "HIP 65495"},
        {"Geneva Identification System", "GEN# +1.00116753"},
        {"Smithsonian Astrophysical Observation", "SAO 82827"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.35163177),
        dec: Angle.Degrees(+25.54858558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103943"},
        {"Smithsonian Astrophysical Observation", "SAO 89416"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.90836469),
        dec: Angle.Degrees(+25.54952353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 165.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126030"},
        {"Hipparcos Number", "HIP 70259"},
        {"Geneva Identification System", "GEN# +1.00126030"},
        {"Smithsonian Astrophysical Observation", "SAO 83315"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.63489430),
        dec: Angle.Degrees(+25.55006675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196772"},
        {"Hipparcos Number", "HIP 101883"},
        {"Geneva Identification System", "GEN# +1.00196772"},
        {"Smithsonian Astrophysical Observation", "SAO 88952"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.68463564),
        dec: Angle.Degrees(+25.55067939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1110"},
        {"Smithsonian Astrophysical Observation", "SAO 73826"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.45645166),
        dec: Angle.Degrees(+25.55196062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19381"},
        {"Hipparcos Number", "HIP 14548"},
        {"Geneva Identification System", "GEN# +1.00019381"},
        {"Smithsonian Astrophysical Observation", "SAO 75743"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.96050549),
        dec: Angle.Degrees(+25.55218727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39835",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6607 A"},
        {"Henry Draper", "HD 67321"},
        {"Hipparcos Number", "HIP 39835"},
        {"Geneva Identification System", "GEN# +1.00067321J"},
        {"Smithsonian Astrophysical Observation", "SAO 79971"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.08383498),
        dec: Angle.Degrees(+25.55290550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75124"},
    },
    visualMagnitude: 10.91,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.27020832),
        dec: Angle.Degrees(+25.55866102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67613"},
        {"Hipparcos Number", "HIP 39969"},
        {"Smithsonian Astrophysical Observation", "SAO 79987"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.42648562),
        dec: Angle.Degrees(+25.55909675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108102"},
        {"Hipparcos Number", "HIP 60582"},
        {"Geneva Identification System", "GEN# +5.21110111"},
        {"Smithsonian Astrophysical Observation", "SAO 82295"},
        {"Wilson Evans Batten Catalogue", "WEB 10771"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.25943505),
        dec: Angle.Degrees(+25.56068217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166842"},
        {"Hipparcos Number", "HIP 89139"},
        {"Geneva Identification System", "GEN# +1.00166842"},
        {"Smithsonian Astrophysical Observation", "SAO 85811"},
        {"Wilson Evans Batten Catalogue", "WEB 15138"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.88326581),
        dec: Angle.Degrees(+25.56115712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85845",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85845"},
        {"Smithsonian Astrophysical Observation", "SAO 85192"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.13956125),
        dec: Angle.Degrees(+25.56128874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94204"},
        {"Hipparcos Number", "HIP 53184"},
        {"Geneva Identification System", "GEN# +1.00094204"},
        {"Smithsonian Astrophysical Observation", "SAO 81560"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.18294498),
        dec: Angle.Degrees(+25.56136657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207134"},
        {"Hipparcos Number", "HIP 107502"},
        {"Geneva Identification System", "GEN# +1.00207134"},
        {"Smithsonian Astrophysical Observation", "SAO 89976"},
        {"Wilson Evans Batten Catalogue", "WEB 19404"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.59934972),
        dec: Angle.Degrees(+25.56337264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72920"},
        {"Geneva Identification System", "GEN# +0.02602621"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.54507702),
        dec: Angle.Degrees(+25.56429264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -288.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36907"},
        {"Smithsonian Astrophysical Observation", "SAO 79529"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.81965665),
        dec: Angle.Degrees(+25.56539823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336039"},
        {"Hipparcos Number", "HIP 90129"},
        {"Smithsonian Astrophysical Observation", "SAO 86002"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.89357284),
        dec: Angle.Degrees(+25.56638198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52305"},
        {"Hipparcos Number", "HIP 33855"},
        {"Geneva Identification System", "GEN# +1.00052305"},
        {"Smithsonian Astrophysical Observation", "SAO 78984"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.42495666),
        dec: Angle.Degrees(+25.56721651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136655"},
        {"Hipparcos Number", "HIP 75132"},
        {"Cincinnati Publication", "Ci 18 2051"},
        {"Geneva Identification System", "GEN# +1.00136655"},
        {"Smithsonian Astrophysical Observation", "SAO 83780"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.28919403),
        dec: Angle.Degrees(+25.56743110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90009"},
        {"Hipparcos Number", "HIP 50915"},
        {"Geneva Identification System", "GEN# +1.00090009"},
        {"Smithsonian Astrophysical Observation", "SAO 81329"},
        {"Wilson Evans Batten Catalogue", "WEB 9314"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.95635279),
        dec: Angle.Degrees(+25.56831134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38524"},
        {"Hipparcos Number", "HIP 27353"},
        {"Geneva Identification System", "GEN# +1.00038524"},
        {"Smithsonian Astrophysical Observation", "SAO 77560"},
        {"Wilson Evans Batten Catalogue", "WEB 5375"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.89443423),
        dec: Angle.Degrees(+25.56864035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143313"},
        {"Hipparcos Number", "HIP 78259"},
        {"Geneva Identification System", "GEN# +1.00143313"},
        {"Smithsonian Astrophysical Observation", "SAO 84114"},
        {"Wilson Evans Batten Catalogue", "WEB 13234"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.68331501),
        dec: Angle.Degrees(+25.56984827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111803"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.68891890),
        dec: Angle.Degrees(+25.57032472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 226.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106946"},
        {"Hipparcos Number", "HIP 59957"},
        {"Geneva Identification System", "GEN# +5.21110049"},
        {"Smithsonian Astrophysical Observation", "SAO 82222"},
        {"Wilson Evans Batten Catalogue", "WEB 10652"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.46214019),
        dec: Angle.Degrees(+25.57136706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85150"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.01122738),
        dec: Angle.Degrees(+25.57312332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51260",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51260"},
        {"Smithsonian Astrophysical Observation", "SAO 81366"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.06251504),
        dec: Angle.Degrees(+25.57321815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95163",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12352 A"},
        {"Henry Draper", "HD 181987"},
        {"Hipparcos Number", "HIP 95163"},
        {"Geneva Identification System", "GEN# +1.00181987A"},
        {"Smithsonian Astrophysical Observation", "SAO 87113"},
        {"Wilson Evans Batten Catalogue", "WEB 16627"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.41294973),
        dec: Angle.Degrees(+25.57485138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252804"},
        {"Hipparcos Number", "HIP 29338"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.77750655),
        dec: Angle.Degrees(+25.57555892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131847"},
        {"Hipparcos Number", "HIP 73002"},
        {"Smithsonian Astrophysical Observation", "SAO 83580"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.78954131),
        dec: Angle.Degrees(+25.57643066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2315"},
        {"Hipparcos Number", "HIP 2152"},
        {"Geneva Identification System", "GEN# +1.00002315"},
        {"Smithsonian Astrophysical Observation", "SAO 74001"},
        {"Wilson Evans Batten Catalogue", "WEB 399"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.80238880),
        dec: Angle.Degrees(+25.57858149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117332",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17005 A"},
        {"Henry Draper", "HD 223211"},
        {"Hipparcos Number", "HIP 117332"},
        {"Geneva Identification System", "GEN# +1.00223211"},
        {"Smithsonian Astrophysical Observation", "SAO 91490"},
        {"Wilson Evans Batten Catalogue", "WEB 20672"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.87239758),
        dec: Angle.Degrees(+25.57957347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17954",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2799"},
        {"Henry Draper", "HD 23985"},
        {"Hipparcos Number", "HIP 17954"},
        {"Celescope Catalog", "CEL 368"},
        {"Geneva Identification System", "GEN# +1.00023985J"},
        {"Smithsonian Astrophysical Observation", "SAO 76256"},
        {"Wilson Evans Batten Catalogue", "WEB 3455"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.57881165),
        dec: Angle.Degrees(+25.57964862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99474"},
        {"Hipparcos Number", "HIP 55856"},
        {"Smithsonian Astrophysical Observation", "SAO 81830"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.71625068),
        dec: Angle.Degrees(+25.58018972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60525",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8539 AB"},
        {"Henry Draper", "HD 108007"},
        {"Hipparcos Number", "HIP 60525"},
        {"Geneva Identification System", "GEN# +5.21110109"},
        {"Smithsonian Astrophysical Observation", "SAO 82293"},
        {"Wilson Evans Batten Catalogue", "WEB 10762"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.11170180),
        dec: Angle.Degrees(+25.58242997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207071"},
        {"Hipparcos Number", "HIP 107462"},
        {"Geneva Identification System", "GEN# +1.00207071"},
        {"Smithsonian Astrophysical Observation", "SAO 89971"},
    },
    visualMagnitude: 6.57,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.48522747),
        dec: Angle.Degrees(+25.58343333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116165"},
        {"Smithsonian Astrophysical Observation", "SAO 91327"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.05467771),
        dec: Angle.Degrees(+25.58465208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4831"},
        {"Hipparcos Number", "HIP 3946"},
        {"Geneva Identification System", "GEN# +1.00004831"},
        {"Smithsonian Astrophysical Observation", "SAO 74305"},
        {"Wilson Evans Batten Catalogue", "WEB 702"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.66077369),
        dec: Angle.Degrees(+25.58496238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20327"},
        {"Hipparcos Number", "HIP 15273"},
        {"Geneva Identification System", "GEN# +1.00020327"},
        {"Smithsonian Astrophysical Observation", "SAO 75836"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.25629180),
        dec: Angle.Degrees(+25.58676597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36995"},
        {"Hipparcos Number", "HIP 26330"},
        {"Smithsonian Astrophysical Observation", "SAO 77306"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.11835929),
        dec: Angle.Degrees(+25.58787152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83935"},
        {"Hipparcos Number", "HIP 47602"},
        {"Geneva Identification System", "GEN# +1.00083935"},
        {"Smithsonian Astrophysical Observation", "SAO 80978"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.58845739),
        dec: Angle.Degrees(+25.59017276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340720"},
        {"Henry Draper 2", "HD 340719"},
        {"Hipparcos Number", "HIP 101850"},
        {"Smithsonian Astrophysical Observation", "SAO 88939"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.58766468),
        dec: Angle.Degrees(+25.59071284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19485"},
        {"Hipparcos Number", "HIP 14610"},
        {"Geneva Identification System", "GEN# +1.00019485"},
        {"Smithsonian Astrophysical Observation", "SAO 75751"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.16952474),
        dec: Angle.Degrees(+25.59189855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99824",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13589 AB"},
        {"Henry Draper", "HD 192685"},
        {"Hipparcos Number", "HIP 99824"},
        {"Geneva Identification System", "GEN# +1.00192685J"},
        {"Smithsonian Astrophysical Observation", "SAO 88410"},
        {"Wilson Evans Batten Catalogue", "WEB 17942"},
    },
    visualMagnitude: 4.79,
    bvColour: -0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.81621226),
        dec: Angle.Degrees(+25.59196924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193239"},
        {"Hipparcos Number", "HIP 100093"},
        {"Geneva Identification System", "GEN# +1.00193239"},
        {"Smithsonian Astrophysical Observation", "SAO 88493"},
    },
    visualMagnitude: 8.19,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.58928492),
        dec: Angle.Degrees(+25.61836335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39435"},
        {"Hipparcos Number", "HIP 27858"},
        {"Geneva Identification System", "GEN# +1.00039435"},
        {"Smithsonian Astrophysical Observation", "SAO 77687"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.40896744),
        dec: Angle.Degrees(+25.59310697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170327"},
        {"Hipparcos Number", "HIP 90480"},
        {"Geneva Identification System", "GEN# +1.00170327"},
        {"Smithsonian Astrophysical Observation", "SAO 86084"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.93707178),
        dec: Angle.Degrees(+25.59387587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207675"},
        {"Hipparcos Number", "HIP 107796"},
        {"Geneva Identification System", "GEN# +1.00207675"},
        {"Smithsonian Astrophysical Observation", "SAO 90044"},
        {"Wilson Evans Batten Catalogue", "WEB 19439"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.55167678),
        dec: Angle.Degrees(+25.59613016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184151"},
        {"Hipparcos Number", "HIP 96081"},
        {"Geneva Identification System", "GEN# +1.00184151"},
        {"Smithsonian Astrophysical Observation", "SAO 87323"},
        {"Wilson Evans Batten Catalogue", "WEB 16829"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.02260068),
        dec: Angle.Degrees(+25.59622539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13649"},
        {"Hipparcos Number", "HIP 10378"},
        {"Geneva Identification System", "GEN# +1.00013649"},
        {"Smithsonian Astrophysical Observation", "SAO 75214"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.42249724),
        dec: Angle.Degrees(+25.59631221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63549"},
        {"Smithsonian Astrophysical Observation", "SAO 82611"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.33355886),
        dec: Angle.Degrees(+25.60082027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102278",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14208 AB"},
        {"Henry Draper", "HD 197515"},
        {"Hipparcos Number", "HIP 102278"},
        {"Smithsonian Astrophysical Observation", "SAO 89051"},
        {"Wilson Evans Batten Catalogue", "WEB 18511"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.85578667),
        dec: Angle.Degrees(+25.60230106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181963"},
        {"Hipparcos Number", "HIP 95147"},
        {"Geneva Identification System", "GEN# +1.00181963"},
        {"Smithsonian Astrophysical Observation", "SAO 87111"},
        {"Wilson Evans Batten Catalogue", "WEB 16618"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.36618728),
        dec: Angle.Degrees(+25.60397329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85565",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85565"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.30003944),
        dec: Angle.Degrees(+25.60660641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44030"},
        {"Hipparcos Number", "HIP 30142"},
        {"Geneva Identification System", "GEN# +1.00044030"},
        {"Smithsonian Astrophysical Observation", "SAO 78250"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.14716066),
        dec: Angle.Degrees(+25.60825596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93242"},
        {"Hipparcos Number", "HIP 52681"},
        {"Smithsonian Astrophysical Observation", "SAO 81508"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.57522882),
        dec: Angle.Degrees(+25.61298369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16683"},
        {"Hipparcos Number", "HIP 12524"},
        {"Geneva Identification System", "GEN# +1.00016683"},
        {"Smithsonian Astrophysical Observation", "SAO 75518"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.29477945),
        dec: Angle.Degrees(+25.61453761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15512"},
        {"Smithsonian Astrophysical Observation", "SAO 75864"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.98101972),
        dec: Angle.Degrees(+25.61493310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 479",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 479"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.43020191),
        dec: Angle.Degrees(+25.61517178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159948"},
        {"Hipparcos Number", "HIP 86160"},
        {"Geneva Identification System", "GEN# +1.00159948"},
        {"Smithsonian Astrophysical Observation", "SAO 85240"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.10286807),
        dec: Angle.Degrees(+25.61632374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196034"},
        {"Hipparcos Number", "HIP 101485"},
        {"Geneva Identification System", "GEN# +1.00196034"},
        {"Smithsonian Astrophysical Observation", "SAO 88844"},
        {"Wilson Evans Batten Catalogue", "WEB 18339"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.49180405),
        dec: Angle.Degrees(+25.61662191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17245"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.40064489),
        dec: Angle.Degrees(+25.61943275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74545"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.47943322),
        dec: Angle.Degrees(+25.62033367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45485"},
        {"Hipparcos Number", "HIP 30857"},
        {"Geneva Identification System", "GEN# +1.00045485"},
        {"Smithsonian Astrophysical Observation", "SAO 78415"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.18761556),
        dec: Angle.Degrees(+25.62092182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85321"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.53248545),
        dec: Angle.Degrees(+25.62201516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162211"},
        {"Hipparcos Number", "HIP 87194"},
        {"Fundamental Katalog 5th Edition", "FK5 3415"},
        {"Geneva Identification System", "GEN# +1.00162211"},
        {"Smithsonian Astrophysical Observation", "SAO 85437"},
        {"Wilson Evans Batten Catalogue", "WEB 14712"},
    },
    visualMagnitude: 5.09,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.20478791),
        dec: Angle.Degrees(+25.62296216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136901"},
        {"Hipparcos Number", "HIP 75233"},
        {"Geneva Identification System", "GEN# +1.00136901"},
        {"Smithsonian Astrophysical Observation", "SAO 83795"},
        {"Wilson Evans Batten Catalogue", "WEB 12833"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.60548086),
        dec: Angle.Degrees(+25.62416842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84815"},
        {"Smithsonian Astrophysical Observation", "SAO 85015"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.01334589),
        dec: Angle.Degrees(+25.62500720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138005"},
        {"Hipparcos Number", "HIP 75750"},
        {"Smithsonian Astrophysical Observation", "SAO 83840"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.12377719),
        dec: Angle.Degrees(+25.62557546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78251"},
        {"Hipparcos Number", "HIP 44806"},
        {"Fundamental Katalog 5th Edition", "FK5 4811"},
        {"Geneva Identification System", "GEN# +1.00078251"},
        {"Smithsonian Astrophysical Observation", "SAO 80649"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.97177555),
        dec: Angle.Degrees(+25.62631481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20430",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3161 A"},
        {"Henry Draper", "HD 27638"},
        {"Hipparcos Number", "HIP 20430"},
        {"Geneva Identification System", "GEN# +1.00027638A"},
        {"Smithsonian Astrophysical Observation", "SAO 76573"},
        {"Wilson Evans Batten Catalogue", "WEB 3904"},
    },
    visualMagnitude: 5.38,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.64554350),
        dec: Angle.Degrees(+25.62935771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193737"},
        {"Hipparcos Number", "HIP 100350"},
        {"Smithsonian Astrophysical Observation", "SAO 88560"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.27641073),
        dec: Angle.Degrees(+25.62992815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83315"},
        {"Smithsonian Astrophysical Observation", "SAO 84769"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.40479008),
        dec: Angle.Degrees(+25.63254712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139550"},
        {"Hipparcos Number", "HIP 76539"},
        {"Geneva Identification System", "GEN# +1.00139550"},
        {"Smithsonian Astrophysical Observation", "SAO 83918"},
        {"Wilson Evans Batten Catalogue", "WEB 12990"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.47512732),
        dec: Angle.Degrees(+25.63555738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109211",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15650 AB"},
        {"Henry Draper", "HD 210103"},
        {"Hipparcos Number", "HIP 109211"},
        {"Smithsonian Astrophysical Observation", "SAO 90246"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.87148674),
        dec: Angle.Degrees(+25.63649016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12744",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2082 A"},
        {"Henry Draper", "HD 16955"},
        {"Henry Draper 2", "HD 16955A"},
        {"Hipparcos Number", "HIP 12744"},
        {"Geneva Identification System", "GEN# +1.00016955"},
        {"Smithsonian Astrophysical Observation", "SAO 75539"},
        {"Wilson Evans Batten Catalogue", "WEB 2592"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.96353093),
        dec: Angle.Degrees(+25.63833202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154183"},
        {"Hipparcos Number", "HIP 83412"},
        {"Geneva Identification System", "GEN# +1.00154183"},
        {"Smithsonian Astrophysical Observation", "SAO 84788"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.73014474),
        dec: Angle.Degrees(+25.63913197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93876"},
        {"Hipparcos Number", "HIP 52998"},
        {"Geneva Identification System", "GEN# +1.00093876"},
        {"Smithsonian Astrophysical Observation", "SAO 81546"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.62316287),
        dec: Angle.Degrees(+25.64009300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135679"},
        {"Hipparcos Number", "HIP 74678"},
        {"Geneva Identification System", "GEN# +1.00135679"},
        {"Renson", "Renson 38520"},
        {"Smithsonian Astrophysical Observation", "SAO 83733"},
        {"Wilson Evans Batten Catalogue", "WEB 12742"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.92270378),
        dec: Angle.Degrees(+25.64254249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217337"},
        {"Hipparcos Number", "HIP 113542"},
        {"Geneva Identification System", "GEN# +1.00217337"},
        {"Smithsonian Astrophysical Observation", "SAO 90927"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.94170587),
        dec: Angle.Degrees(+25.64387235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163381"},
        {"Hipparcos Number", "HIP 87705"},
        {"Geneva Identification System", "GEN# +1.00163381"},
        {"Smithsonian Astrophysical Observation", "SAO 85537"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.71896261),
        dec: Angle.Degrees(+25.64447211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141732"},
        {"Hipparcos Number", "HIP 77522"},
        {"Geneva Identification System", "GEN# +1.00141732"},
        {"Smithsonian Astrophysical Observation", "SAO 84023"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.42930745),
        dec: Angle.Degrees(+25.64479477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107354",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15281 AB"},
        {"Henry Draper", "HD 206901"},
        {"Hipparcos Number", "HIP 107354"},
        {"Geneva Identification System", "GEN# +1.00206901"},
        {"Smithsonian Astrophysical Observation", "SAO 89949"},
        {"Wilson Evans Batten Catalogue", "WEB 19389"},
    },
    visualMagnitude: 4.14,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.16126755),
        dec: Angle.Degrees(+25.64500284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199155"},
        {"Hipparcos Number", "HIP 103198"},
        {"Smithsonian Astrophysical Observation", "SAO 89268"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.63038290),
        dec: Angle.Degrees(+25.64640675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61834"},
        {"Geneva Identification System", "GEN# +0.02602378"},
        {"Smithsonian Astrophysical Observation", "SAO 82434"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.07283669),
        dec: Angle.Degrees(+25.64664190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100088",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13666 A"},
        {"Henry Draper", "HD 193220"},
        {"Hipparcos Number", "HIP 100088"},
        {"Geneva Identification System", "GEN# +1.00193220"},
        {"Smithsonian Astrophysical Observation", "SAO 88490"},
        {"Wilson Evans Batten Catalogue", "WEB 18024"},
    },
    visualMagnitude: 6.98,
    bvColour: -0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.57106382),
        dec: Angle.Degrees(+25.64824351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15187"},
        {"Hipparcos Number", "HIP 11431"},
        {"Smithsonian Astrophysical Observation", "SAO 75373"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.86285741),
        dec: Angle.Degrees(+25.64950570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17190"},
        {"Hipparcos Number", "HIP 12926"},
        {"Cincinnati Publication", "Ci 18 353"},
        {"Geneva Identification System", "GEN# +1.00017190"},
        {"Smithsonian Astrophysical Observation", "SAO 75559"},
        {"Wilson Evans Batten Catalogue", "WEB 2620"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.56271915),
        dec: Angle.Degrees(+25.65026311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 238.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38750"},
        {"Hipparcos Number", "HIP 27478"},
        {"Geneva Identification System", "GEN# +1.00038750"},
        {"Smithsonian Astrophysical Observation", "SAO 77593"},
        {"Wilson Evans Batten Catalogue", "WEB 5396"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.27886499),
        dec: Angle.Degrees(+25.65058712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69737"},
        {"Geneva Identification System", "GEN# +0.02602546"},
        {"Smithsonian Astrophysical Observation", "SAO 83258"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.10910170),
        dec: Angle.Degrees(+25.65254286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99581",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13518 A"},
        {"Henry Draper", "HD 192144"},
        {"Hipparcos Number", "HIP 99581"},
        {"Geneva Identification System", "GEN# +1.00192144"},
        {"Smithsonian Astrophysical Observation", "SAO 88353"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.13855161),
        dec: Angle.Degrees(+25.65314027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 121.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223323"},
        {"Hipparcos Number", "HIP 117415"},
        {"Geneva Identification System", "GEN# +1.00223323"},
        {"Smithsonian Astrophysical Observation", "SAO 91500"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.13141296),
        dec: Angle.Degrees(+25.65389603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100086",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13666 C"},
        {"Hipparcos Number", "HIP 100086"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)18, 16.9300),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)39, 15.200)
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
    primaryId: "HIP 108966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209665"},
        {"Hipparcos Number", "HIP 108966"},
        {"Geneva Identification System", "GEN# +1.00209665"},
        {"Smithsonian Astrophysical Observation", "SAO 90206"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.13663701),
        dec: Angle.Degrees(+25.65854870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20663"},
        {"Hipparcos Number", "HIP 15557"},
        {"Geneva Identification System", "GEN# +1.00020663"},
        {"Smithsonian Astrophysical Observation", "SAO 75875"},
        {"Wilson Evans Batten Catalogue", "WEB 2989"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.10652697),
        dec: Angle.Degrees(+25.66296628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49951"},
        {"Hipparcos Number", "HIP 32964"},
        {"Fundamental Katalog 5th Edition", "FK5 4627"},
        {"Geneva Identification System", "GEN# +1.00049951"},
        {"Smithsonian Astrophysical Observation", "SAO 78813"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.99252755),
        dec: Angle.Degrees(+25.66297957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220734"},
        {"Hipparcos Number", "HIP 115672"},
        {"Geneva Identification System", "GEN# +1.00220734"},
        {"Smithsonian Astrophysical Observation", "SAO 91261"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.52749178),
        dec: Angle.Degrees(+25.66675875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85615"},
        {"Hipparcos Number", "HIP 48511"},
        {"Geneva Identification System", "GEN# +1.00085615"},
        {"Smithsonian Astrophysical Observation", "SAO 81069"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.40389329),
        dec: Angle.Degrees(+25.66747205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201052"},
        {"Hipparcos Number", "HIP 104184"},
        {"Smithsonian Astrophysical Observation", "SAO 89460"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.62362946),
        dec: Angle.Degrees(+25.66876059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57182"},
        {"Hipparcos Number", "HIP 35624"},
        {"Smithsonian Astrophysical Observation", "SAO 79307"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.26379627),
        dec: Angle.Degrees(+25.66883662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198379"},
        {"Hipparcos Number", "HIP 102740"},
        {"Geneva Identification System", "GEN# +1.00198379"},
        {"Smithsonian Astrophysical Observation", "SAO 89165"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.27098494),
        dec: Angle.Degrees(+25.67026772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219418"},
        {"Hipparcos Number", "HIP 114809"},
        {"Geneva Identification System", "GEN# +1.00219418"},
        {"Smithsonian Astrophysical Observation", "SAO 91126"},
        {"Wilson Evans Batten Catalogue", "WEB 20350"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.84599130),
        dec: Angle.Degrees(+25.67221089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92603"},
        {"Hipparcos Number", "HIP 52348"},
        {"Smithsonian Astrophysical Observation", "SAO 81478"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.47633147),
        dec: Angle.Degrees(+25.67227506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198366"},
        {"Hipparcos Number", "HIP 102728"},
        {"Geneva Identification System", "GEN# +1.00198366"},
        {"Smithsonian Astrophysical Observation", "SAO 89161"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.24876293),
        dec: Angle.Degrees(+25.67240643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70456",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70456"},
        {"Smithsonian Astrophysical Observation", "SAO 83337"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.19052676),
        dec: Angle.Degrees(+25.67445224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111842"},
        {"Hipparcos Number", "HIP 62778"},
        {"Geneva Identification System", "GEN# +1.00111842"},
        {"Smithsonian Astrophysical Observation", "SAO 82539"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.97517638),
        dec: Angle.Degrees(+25.67483232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50632"},
        {"Smithsonian Astrophysical Observation", "SAO 81303"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.12554056),
        dec: Angle.Degrees(+25.67825694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 261036"},
        {"Hipparcos Number", "HIP 31797"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.72202873),
        dec: Angle.Degrees(+25.67907557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121231"},
        {"Hipparcos Number", "HIP 67829"},
        {"Geneva Identification System", "GEN# +1.00121231"},
        {"Smithsonian Astrophysical Observation", "SAO 83065"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.41841092),
        dec: Angle.Degrees(+25.68007774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110680"},
        {"Hipparcos Number", "HIP 62102"},
        {"Geneva Identification System", "GEN# +1.00110680"},
        {"Smithsonian Astrophysical Observation", "SAO 82461"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.90782261),
        dec: Angle.Degrees(+25.68010568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189865"},
        {"Hipparcos Number", "HIP 98567"},
        {"Smithsonian Astrophysical Observation", "SAO 88076"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.31805620),
        dec: Angle.Degrees(+25.68023271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64592",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64592"},
        {"Smithsonian Astrophysical Observation", "SAO 82733"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.59248466),
        dec: Angle.Degrees(+25.68095560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108238"},
        {"Hipparcos Number", "HIP 60664"},
        {"Geneva Identification System", "GEN# +5.21110119"},
        {"Smithsonian Astrophysical Observation", "SAO 82305"},
        {"Wilson Evans Batten Catalogue", "WEB 10790"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.49898826),
        dec: Angle.Degrees(+25.68170579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8874"},
        {"Hipparcos Number", "HIP 6830"},
        {"Geneva Identification System", "GEN# +1.00008874"},
        {"Smithsonian Astrophysical Observation", "SAO 74737"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.97657889),
        dec: Angle.Degrees(+25.68198787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65508",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8899 AB"},
        {"Hipparcos Number", "HIP 65508"},
        {"Smithsonian Astrophysical Observation", "SAO 82828"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.41406339),
        dec: Angle.Degrees(+25.68220904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1695"},
        {"Smithsonian Astrophysical Observation", "SAO 73915"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.32332138),
        dec: Angle.Degrees(+25.68293230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24368"},
        {"Hipparcos Number", "HIP 18201"},
        {"Geneva Identification System", "GEN# +5.20223330"},
        {"Renson", "Renson 6290"},
        {"Smithsonian Astrophysical Observation", "SAO 76305"},
        {"Wilson Evans Batten Catalogue", "WEB 3512"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.39360035),
        dec: Angle.Degrees(+25.68296603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335623"},
        {"Hipparcos Number", "HIP 88651"},
        {"Geneva Identification System", "GEN# +1.00335623"},
        {"Smithsonian Astrophysical Observation", "SAO 85726"},
        {"Wilson Evans Batten Catalogue", "WEB 15020"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.49509322),
        dec: Angle.Degrees(+25.68332791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191010"},
        {"Hipparcos Number", "HIP 99067"},
        {"Geneva Identification System", "GEN# +1.00191010"},
        {"Smithsonian Astrophysical Observation", "SAO 88209"},
        {"Wilson Evans Batten Catalogue", "WEB 17616"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.69100803),
        dec: Angle.Degrees(+25.68521945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4860"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.62548104),
        dec: Angle.Degrees(+25.68645843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189493"},
        {"Hipparcos Number", "HIP 98392"},
        {"Geneva Identification System", "GEN# +1.00189493"},
        {"Smithsonian Astrophysical Observation", "SAO 88027"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.86081805),
        dec: Angle.Degrees(+25.68772884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53452"},
        {"Smithsonian Astrophysical Observation", "SAO 81586"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.01742613),
        dec: Angle.Degrees(+25.68829506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149380"},
        {"Hipparcos Number", "HIP 81061"},
        {"Geneva Identification System", "GEN# +1.00149380"},
        {"Smithsonian Astrophysical Observation", "SAO 84451"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.33765667),
        dec: Angle.Degrees(+25.68988812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 235.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95059"},
        {"Hipparcos Number", "HIP 53664"},
        {"Smithsonian Astrophysical Observation", "SAO 81606"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.69201509),
        dec: Angle.Degrees(+25.69073971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136274"},
        {"Hipparcos Number", "HIP 74954"},
        {"Cincinnati Publication", "Ci 20 925"},
        {"Geneva Identification System", "GEN# +1.00136274"},
        {"Smithsonian Astrophysical Observation", "SAO 83761"},
        {"Wilson Evans Batten Catalogue", "WEB 12788"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.74756561),
        dec: Angle.Degrees(+25.69201214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -554.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175718"},
        {"Hipparcos Number", "HIP 92896"},
        {"Geneva Identification System", "GEN# +1.00175718"},
        {"Smithsonian Astrophysical Observation", "SAO 86589"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.92225883),
        dec: Angle.Degrees(+25.69504260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114989"},
        {"Hipparcos Number", "HIP 64551"},
        {"Geneva Identification System", "GEN# +1.00114989"},
        {"Smithsonian Astrophysical Observation", "SAO 82730"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.47061542),
        dec: Angle.Degrees(+25.69837213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92456"},
        {"Hipparcos Number", "HIP 52270"},
        {"Geneva Identification System", "GEN# +1.00092456"},
        {"Smithsonian Astrophysical Observation", "SAO 81467"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.20816177),
        dec: Angle.Degrees(+25.70014451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120064"},
        {"Hipparcos Number", "HIP 67239"},
        {"Fundamental Katalog 5th Edition", "FK5 1358"},
        {"Geneva Identification System", "GEN# +1.00120064"},
        {"Smithsonian Astrophysical Observation", "SAO 82993"},
        {"Wilson Evans Batten Catalogue", "WEB 11831"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.68056228),
        dec: Angle.Degrees(+25.70238073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 263747"},
        {"Hipparcos Number", "HIP 32559"},
        {"Smithsonian Astrophysical Observation", "SAO 78747"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.90899766),
        dec: Angle.Degrees(+25.70245686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72461"},
        {"Geneva Identification System", "GEN# +0.02602606"},
        {"Smithsonian Astrophysical Observation", "SAO 83543"},
        {"Wilson Evans Batten Catalogue", "WEB 12452"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.25984524),
        dec: Angle.Degrees(+25.70338734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -346.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126327"},
        {"Hipparcos Number", "HIP 70401"},
        {"Smithsonian Astrophysical Observation", "SAO 83331"},
        {"Wilson Evans Batten Catalogue", "WEB 12219"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.04838723),
        dec: Angle.Degrees(+25.70384317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9859",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1658 A"},
        {"Henry Draper", "HD 12885"},
        {"Hipparcos Number", "HIP 9859"},
        {"Geneva Identification System", "GEN# +1.00012885"},
        {"Smithsonian Astrophysical Observation", "SAO 75149"},
        {"Wilson Evans Batten Catalogue", "WEB 2069"},
    },
    visualMagnitude: 6.01,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.70509566),
        dec: Angle.Degrees(+25.70458883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171849"},
        {"Hipparcos Number", "HIP 91168"},
        {"Geneva Identification System", "GEN# +1.00171849"},
        {"Smithsonian Astrophysical Observation", "SAO 86231"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.99054063),
        dec: Angle.Degrees(+25.70521135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283654"},
        {"Hipparcos Number", "HIP 20777"},
    },
    visualMagnitude: 11.96,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.76160828),
        dec: Angle.Degrees(+25.70626582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182781"},
        {"Hipparcos Number", "HIP 95476"},
        {"Geneva Identification System", "GEN# +1.00182781"},
        {"Smithsonian Astrophysical Observation", "SAO 87187"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.31804271),
        dec: Angle.Degrees(+25.70759256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207498"},
        {"Hipparcos Number", "HIP 107694"},
        {"Geneva Identification System", "GEN# +1.00207498"},
        {"Smithsonian Astrophysical Observation", "SAO 90023"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.23073148),
        dec: Angle.Degrees(+25.70982907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97658"},
        {"Hipparcos Number", "HIP 54906"},
        {"Geneva Identification System", "GEN# +1.00097658"},
        {"Smithsonian Astrophysical Observation", "SAO 81730"},
        {"Wilson Evans Batten Catalogue", "WEB 9909"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.63846191),
        dec: Angle.Degrees(+25.71026742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65734",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65734"},
        {"Smithsonian Astrophysical Observation", "SAO 82856"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.11706210),
        dec: Angle.Degrees(+25.71108616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5236"},
        {"Hipparcos Number", "HIP 4262"},
        {"Fundamental Katalog 5th Edition", "FK5 4077"},
        {"Geneva Identification System", "GEN# +1.00005236"},
        {"Smithsonian Astrophysical Observation", "SAO 74355"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.59945731),
        dec: Angle.Degrees(+25.71480359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104406"},
        {"Hipparcos Number", "HIP 58628"},
        {"Geneva Identification System", "GEN# +1.00104406"},
        {"Smithsonian Astrophysical Observation", "SAO 82105"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.34826844),
        dec: Angle.Degrees(+25.71640032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68917"},
        {"Smithsonian Astrophysical Observation", "SAO 83167"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.63621112),
        dec: Angle.Degrees(+25.71766243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75646"},
        {"Hipparcos Number", "HIP 43535"},
        {"Smithsonian Astrophysical Observation", "SAO 80467"},
        {"Wilson Evans Batten Catalogue", "WEB 8390"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.00189762),
        dec: Angle.Degrees(+25.71873093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114944"},
        {"Smithsonian Astrophysical Observation", "SAO 91141"},
        {"Wilson Evans Batten Catalogue", "WEB 20366"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.22248101),
        dec: Angle.Degrees(+25.71946859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104162"},
        {"Smithsonian Astrophysical Observation", "SAO 89456"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.56287372),
        dec: Angle.Degrees(+25.72005140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107468"},
        {"Hipparcos Number", "HIP 60233"},
        {"Geneva Identification System", "GEN# +5.21110080"},
        {"Smithsonian Astrophysical Observation", "SAO 82261"},
        {"Wilson Evans Batten Catalogue", "WEB 10712"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.27008928),
        dec: Angle.Degrees(+25.72005813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21786"},
        {"Hipparcos Number", "HIP 16429"},
        {"Smithsonian Astrophysical Observation", "SAO 75974"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.88201617),
        dec: Angle.Degrees(+25.72159496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25835"},
        {"Hipparcos Number", "HIP 19182"},
        {"Geneva Identification System", "GEN# +1.00025835"},
        {"Smithsonian Astrophysical Observation", "SAO 76460"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.67258772),
        dec: Angle.Degrees(+25.72214667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211884"},
        {"Hipparcos Number", "HIP 110247"},
        {"Geneva Identification System", "GEN# +1.00211884"},
        {"Smithsonian Astrophysical Observation", "SAO 90423"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.97492349),
        dec: Angle.Degrees(+25.72404229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146510"},
        {"Hipparcos Number", "HIP 79683"},
        {"Smithsonian Astrophysical Observation", "SAO 84266"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.93711365),
        dec: Angle.Degrees(+25.72462429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41447"},
        {"Smithsonian Astrophysical Observation", "SAO 80193"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.81301411),
        dec: Angle.Degrees(+25.72527821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57863"},
        {"Smithsonian Astrophysical Observation", "SAO 82017"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.01755645),
        dec: Angle.Degrees(+25.72541367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29246"},
        {"Hipparcos Number", "HIP 21532"},
        {"Geneva Identification System", "GEN# +1.00029246"},
        {"Smithsonian Astrophysical Observation", "SAO 76676"},
        {"Wilson Evans Batten Catalogue", "WEB 4134"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.35240497),
        dec: Angle.Degrees(+25.72744470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159224"},
        {"Hipparcos Number", "HIP 85842"},
        {"Geneva Identification System", "GEN# +1.00159224"},
        {"Smithsonian Astrophysical Observation", "SAO 85190"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.11998231),
        dec: Angle.Degrees(+25.72772669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43532",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43532"},
        {"Geneva Identification System", "GEN# +0.02601854"},
        {"Smithsonian Astrophysical Observation", "SAO 80466"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.99099316),
        dec: Angle.Degrees(+25.72794723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34567",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5827 A"},
        {"Henry Draper", "HD 54371"},
        {"Hipparcos Number", "HIP 34567"},
        {"Geneva Identification System", "GEN# +1.00054371"},
        {"Smithsonian Astrophysical Observation", "SAO 79121"},
        {"Wilson Evans Batten Catalogue", "WEB 6917"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.39779027),
        dec: Angle.Degrees(+25.72907423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338002"},
        {"Hipparcos Number", "HIP 94655"},
        {"Smithsonian Astrophysical Observation", "SAO 86997"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.91159682),
        dec: Angle.Degrees(+25.72940962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24367"},
        {"Hipparcos Number", "HIP 18194"},
        {"Geneva Identification System", "GEN# +1.00024367"},
        {"Smithsonian Astrophysical Observation", "SAO 76303"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.38339783),
        dec: Angle.Degrees(+25.72997146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96393"},
        {"Hipparcos Number", "HIP 54341"},
        {"Geneva Identification System", "GEN# +1.00096393"},
        {"Smithsonian Astrophysical Observation", "SAO 81673"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.74126279),
        dec: Angle.Degrees(+25.73054288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82780",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10259 A"},
        {"Henry Draper", "HD 152863"},
        {"Hipparcos Number", "HIP 82780"},
        {"Geneva Identification System", "GEN# +1.00152863A"},
        {"Smithsonian Astrophysical Observation", "SAO 84692"},
        {"Wilson Evans Batten Catalogue", "WEB 13993"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.75895431),
        dec: Angle.Degrees(+25.73072818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38260"},
        {"Hipparcos Number", "HIP 27173"},
        {"Smithsonian Astrophysical Observation", "SAO 77512"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.38749028),
        dec: Angle.Degrees(+25.73140220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34582",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5827 C"},
        {"Henry Draper", "HD 54403"},
        {"Hipparcos Number", "HIP 34582"},
        {"Geneva Identification System", "GEN# +1.00054403"},
        {"Smithsonian Astrophysical Observation", "SAO 79124"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.43422346),
        dec: Angle.Degrees(+25.73491222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37064"},
        {"Smithsonian Astrophysical Observation", "SAO 79545"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.24864682),
        dec: Angle.Degrees(+25.73569512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70403"},
        {"Hipparcos Number", "HIP 41059"},
        {"Smithsonian Astrophysical Observation", "SAO 80137"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.68146017),
        dec: Angle.Degrees(+25.73735205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105964"},
        {"Hipparcos Number", "HIP 59446"},
        {"Geneva Identification System", "GEN# +5.21110015"},
        {"Smithsonian Astrophysical Observation", "SAO 82175"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.89563471),
        dec: Angle.Degrees(+25.73772263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112299"},
        {"Hipparcos Number", "HIP 63075"},
        {"Geneva Identification System", "GEN# +1.00112299"},
        {"Smithsonian Astrophysical Observation", "SAO 82569"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.86768588),
        dec: Angle.Degrees(+25.73835560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71987"},
        {"Hipparcos Number", "HIP 41791"},
        {"Geneva Identification System", "GEN# +1.00071987"},
        {"Smithsonian Astrophysical Observation", "SAO 80225"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.81616950),
        dec: Angle.Degrees(+25.74046741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67725",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9041 AB"},
        {"Hipparcos Number", "HIP 67725"},
    },
    visualMagnitude: 9.64,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.11269295),
        dec: Angle.Degrees(+25.74073061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248753"},
        {"Hipparcos Number", "HIP 27850"},
        {"Geneva Identification System", "GEN# +1.00248753"},
        {"Smithsonian Astrophysical Observation", "SAO 77682"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.37959440),
        dec: Angle.Degrees(+25.74224808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51094"},
        {"Fundamental Katalog 5th Edition", "FK5 4927"},
        {"Smithsonian Astrophysical Observation", "SAO 81340"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.58928620),
        dec: Angle.Degrees(+25.74336739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83043"},
        {"Cincinnati Publication", "Ci 20 1014"},
        {"Geneva Identification System", "GEN# +0.02503173"},
        {"Wilson Evans Batten Catalogue", "WEB 14039"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.53718424),
        dec: Angle.Degrees(+25.74539445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -507.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7874",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1326 A"},
        {"Henry Draper", "HD 10308"},
        {"Hipparcos Number", "HIP 7874"},
        {"Fundamental Katalog 5th Edition", "FK5 2115"},
        {"Geneva Identification System", "GEN# +1.00010308"},
        {"Smithsonian Astrophysical Observation", "SAO 74870"},
        {"Wilson Evans Batten Catalogue", "WEB 1680"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.32624343),
        dec: Angle.Degrees(+25.74581125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11120"},
        {"Hipparcos Number", "HIP 8522"},
        {"Smithsonian Astrophysical Observation", "SAO 74958"},
        {"Wilson Evans Batten Catalogue", "WEB 1812"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.47954876),
        dec: Angle.Degrees(+25.74632268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139749"},
        {"Hipparcos Number", "HIP 76639"},
        {"Geneva Identification System", "GEN# +1.00139749J"},
        {"Smithsonian Astrophysical Observation", "SAO 83928"},
        {"Wilson Evans Batten Catalogue", "WEB 13011"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.76084007),
        dec: Angle.Degrees(+25.74638397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55156"},
        {"Hipparcos Number", "HIP 34861"},
        {"Geneva Identification System", "GEN# +1.00055156"},
        {"Smithsonian Astrophysical Observation", "SAO 79172"},
        {"Wilson Evans Batten Catalogue", "WEB 6967"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.20574520),
        dec: Angle.Degrees(+25.74870585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109907"},
        {"Smithsonian Astrophysical Observation", "SAO 90362"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.90154980),
        dec: Angle.Degrees(+25.74900792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27887"},
        {"Hipparcos Number", "HIP 20626"},
        {"Geneva Identification System", "GEN# +1.00027887"},
        {"Smithsonian Astrophysical Observation", "SAO 76599"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.29494607),
        dec: Angle.Degrees(+25.74923944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161817"},
        {"Hipparcos Number", "HIP 87001"},
        {"Geneva Identification System", "GEN# +1.00161817"},
        {"Smithsonian Astrophysical Observation", "SAO 85402"},
        {"Wilson Evans Batten Catalogue", "WEB 14679"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.66939022),
        dec: Angle.Degrees(+25.74925639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134659"},
        {"Hipparcos Number", "HIP 74241"},
        {"Geneva Identification System", "GEN# +1.00134659"},
        {"Smithsonian Astrophysical Observation", "SAO 83697"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.58223909),
        dec: Angle.Degrees(+25.74975629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340139"},
        {"Hipparcos Number", "HIP 100415"},
        {"Smithsonian Astrophysical Observation", "SAO 88571"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.42880133),
        dec: Angle.Degrees(+25.75076787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76343",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76343"},
        {"Wilson Evans Batten Catalogue", "WEB 12960"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.90242250),
        dec: Angle.Degrees(+25.75282860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135906"},
        {"Hipparcos Number", "HIP 74773"},
        {"Smithsonian Astrophysical Observation", "SAO 83744"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.22442378),
        dec: Angle.Degrees(+25.75412237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341363"},
        {"Hipparcos Number", "HIP 103432"},
        {"Smithsonian Astrophysical Observation", "SAO 89315"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.33146915),
        dec: Angle.Degrees(+25.75497476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283048"},
        {"Hipparcos Number", "HIP 18175"},
        {"Geneva Identification System", "GEN# +1.00283048"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.30713115),
        dec: Angle.Degrees(+25.75611041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80819"},
        {"Hipparcos Number", "HIP 45984"},
        {"Geneva Identification System", "GEN# +1.00080819"},
        {"Smithsonian Astrophysical Observation", "SAO 80791"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.66941183),
        dec: Angle.Degrees(+25.75826669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180008"},
        {"Hipparcos Number", "HIP 94485"},
        {"Geneva Identification System", "GEN# +1.00180008"},
        {"Smithsonian Astrophysical Observation", "SAO 86960"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.47245312),
        dec: Angle.Degrees(+25.75881459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58102"},
        {"Geneva Identification System", "GEN# +0.02602268"},
        {"Smithsonian Astrophysical Observation", "SAO 82049"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.74912024),
        dec: Angle.Degrees(+25.75955861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35480"},
        {"Hipparcos Number", "HIP 25400"},
        {"Geneva Identification System", "GEN# +1.00035480"},
        {"Smithsonian Astrophysical Observation", "SAO 77163"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.50681426),
        dec: Angle.Degrees(+25.75977978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106691"},
        {"Hipparcos Number", "HIP 59833"},
        {"Geneva Identification System", "GEN# +5.21110036"},
        {"Smithsonian Astrophysical Observation", "SAO 82209"},
        {"Wilson Evans Batten Catalogue", "WEB 10631"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.03491194),
        dec: Angle.Degrees(+25.76039686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49736"},
        {"Hipparcos Number", "HIP 32874"},
        {"Geneva Identification System", "GEN# +1.00049736"},
        {"Smithsonian Astrophysical Observation", "SAO 78795"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.75175913),
        dec: Angle.Degrees(+25.76084062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93215"},
        {"Hipparcos Number", "HIP 52667"},
        {"Geneva Identification System", "GEN# +1.00093215"},
        {"Smithsonian Astrophysical Observation", "SAO 81506"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.53833485),
        dec: Angle.Degrees(+25.76104281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50132"},
        {"Hipparcos Number", "HIP 33027"},
        {"Geneva Identification System", "GEN# +1.00050132"},
        {"Smithsonian Astrophysical Observation", "SAO 78824"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.22619601),
        dec: Angle.Degrees(+25.76438040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10815"},
        {"Smithsonian Astrophysical Observation", "SAO 75280"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.80235593),
        dec: Angle.Degrees(+25.76453184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241090"},
        {"Hipparcos Number", "HIP 24011"},
        {"Smithsonian Astrophysical Observation", "SAO 76992"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.42743919),
        dec: Angle.Degrees(+25.76547853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107399"},
        {"Hipparcos Number", "HIP 60206"},
        {"Geneva Identification System", "GEN# +5.21110076"},
        {"Smithsonian Astrophysical Observation", "SAO 82256"},
        {"Wilson Evans Batten Catalogue", "WEB 10706"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.18990832),
        dec: Angle.Degrees(+25.76588157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170738"},
        {"Hipparcos Number", "HIP 90666"},
        {"Geneva Identification System", "GEN# +1.00170738"},
        {"Smithsonian Astrophysical Observation", "SAO 86131"},
        {"Wilson Evans Batten Catalogue", "WEB 15529"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.49272195),
        dec: Angle.Degrees(+25.76629261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92824"},
        {"Hipparcos Number", "HIP 52456"},
        {"Geneva Identification System", "GEN# +1.00092824"},
        {"Smithsonian Astrophysical Observation", "SAO 81489"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.85292357),
        dec: Angle.Degrees(+25.76660439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92181"},
        {"Hipparcos Number", "HIP 52128"},
        {"Smithsonian Astrophysical Observation", "SAO 81451"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.74851543),
        dec: Angle.Degrees(+25.76729522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115453",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115453"},
        {"Smithsonian Astrophysical Observation", "SAO 91226"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.79959262),
        dec: Angle.Degrees(+25.76799217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7561"},
        {"Hipparcos Number", "HIP 5914"},
        {"Geneva Identification System", "GEN# +1.00007561"},
        {"Smithsonian Astrophysical Observation", "SAO 74593"},
        {"Wilson Evans Batten Catalogue", "WEB 1343"},
    },
    visualMagnitude: 6.76,
    bvColour: 2.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.02097333),
        dec: Angle.Degrees(+25.76936042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32333"},
        {"Hipparcos Number", "HIP 23523"},
        {"Geneva Identification System", "GEN# +1.00032333"},
        {"Smithsonian Astrophysical Observation", "SAO 76924"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.85673513),
        dec: Angle.Degrees(+25.76956377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105102"},
        {"Hipparcos Number", "HIP 59022"},
        {"Geneva Identification System", "GEN# +1.00105102"},
        {"Smithsonian Astrophysical Observation", "SAO 82137"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.52385759),
        dec: Angle.Degrees(+25.77043464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198483"},
        {"Hipparcos Number", "HIP 102815"},
        {"Geneva Identification System", "GEN# +1.00198483"},
        {"Smithsonian Astrophysical Observation", "SAO 89176"},
        {"Wilson Evans Batten Catalogue", "WEB 18648"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.44335042),
        dec: Angle.Degrees(+25.77090371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136231"},
        {"Hipparcos Number", "HIP 74933"},
        {"Geneva Identification System", "GEN# +1.00136231"},
        {"Smithsonian Astrophysical Observation", "SAO 83758"},
        {"Wilson Evans Batten Catalogue", "WEB 12782"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.67988429),
        dec: Angle.Degrees(+25.77177369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186486"},
        {"Hipparcos Number", "HIP 97077"},
        {"Fundamental Katalog 5th Edition", "FK5 1515"},
        {"Geneva Identification System", "GEN# +1.00186486"},
        {"Smithsonian Astrophysical Observation", "SAO 87633"},
        {"Wilson Evans Batten Catalogue", "WEB 17037"},
    },
    visualMagnitude: 5.50,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.92882357),
        dec: Angle.Degrees(+25.77187257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211732"},
        {"Hipparcos Number", "HIP 110152"},
        {"Geneva Identification System", "GEN# +1.00211732"},
        {"Smithsonian Astrophysical Observation", "SAO 90409"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.68768750),
        dec: Angle.Degrees(+25.77406936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95804"},
        {"Hipparcos Number", "HIP 54063"},
        {"Geneva Identification System", "GEN# +1.00095804"},
        {"Smithsonian Astrophysical Observation", "SAO 81648"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.93704320),
        dec: Angle.Degrees(+25.77461739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11547"},
        {"Hipparcos Number", "HIP 8857"},
        {"Geneva Identification System", "GEN# +1.00011547"},
        {"Smithsonian Astrophysical Observation", "SAO 75004"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.48214934),
        dec: Angle.Degrees(+25.77633044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40280"},
        {"Hipparcos Number", "HIP 28301"},
        {"Geneva Identification System", "GEN# +1.00040280"},
        {"Smithsonian Astrophysical Observation", "SAO 77800"},
        {"Wilson Evans Batten Catalogue", "WEB 5533"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.72051574),
        dec: Angle.Degrees(+25.77706236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57590",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57590"},
    },
    visualMagnitude: 11.14,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.10435553),
        dec: Angle.Degrees(+25.77772980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5007"},
        {"Hipparcos Number", "HIP 4083"},
        {"Geneva Identification System", "GEN# +1.00005007"},
        {"Smithsonian Astrophysical Observation", "SAO 74332"},
        {"Wilson Evans Batten Catalogue", "WEB 730"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.09660330),
        dec: Angle.Degrees(+25.78062644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223790"},
        {"Hipparcos Number", "HIP 117731"},
        {"Smithsonian Astrophysical Observation", "SAO 91551"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.15814052),
        dec: Angle.Degrees(+25.78154886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13871"},
        {"Hipparcos Number", "HIP 10540"},
        {"Geneva Identification System", "GEN# +5.20250157"},
        {"Smithsonian Astrophysical Observation", "SAO 75239"},
        {"Wilson Evans Batten Catalogue", "WEB 2213"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.94139916),
        dec: Angle.Degrees(+25.78309877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62285"},
        {"Hipparcos Number", "HIP 37704"},
        {"Geneva Identification System", "GEN# +1.00062285"},
        {"Smithsonian Astrophysical Observation", "SAO 79650"},
        {"Wilson Evans Batten Catalogue", "WEB 7453"},
    },
    visualMagnitude: 5.30,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.02884762),
        dec: Angle.Degrees(+25.78421056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112204"},
        {"Smithsonian Astrophysical Observation", "SAO 90739"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.87587763),
        dec: Angle.Degrees(+25.78443496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82662"},
        {"Smithsonian Astrophysical Observation", "SAO 84676"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.47590201),
        dec: Angle.Degrees(+25.78458074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101416"},
        {"Hipparcos Number", "HIP 56928"},
        {"Geneva Identification System", "GEN# +1.00101416"},
        {"Smithsonian Astrophysical Observation", "SAO 81937"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.06744034),
        dec: Angle.Degrees(+25.78486027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177674"},
        {"Hipparcos Number", "HIP 93686"},
        {"Geneva Identification System", "GEN# +1.00177674"},
        {"Smithsonian Astrophysical Observation", "SAO 86777"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.17928498),
        dec: Angle.Degrees(+25.78678178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142419"},
        {"Hipparcos Number", "HIP 77841"},
        {"Smithsonian Astrophysical Observation", "SAO 84062"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.41217057),
        dec: Angle.Degrees(+25.78755930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113698"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.41325114),
        dec: Angle.Degrees(+25.78835243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 219.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116827"},
        {"Smithsonian Astrophysical Observation", "SAO 91417"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.17892020),
        dec: Angle.Degrees(+25.78839523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197038"},
        {"Hipparcos Number", "HIP 102012"},
        {"Geneva Identification System", "GEN# +1.00197038"},
        {"Smithsonian Astrophysical Observation", "SAO 88988"},
    },
    visualMagnitude: 8.18,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.07693553),
        dec: Angle.Degrees(+25.78914347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9197",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1570 AB"},
        {"Hipparcos Number", "HIP 9197"},
        {"Smithsonian Astrophysical Observation", "SAO 75058"},
        {"Wilson Evans Batten Catalogue", "WEB 1934"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.59884611),
        dec: Angle.Degrees(+25.78990382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75710"},
        {"Geneva Identification System", "GEN# +6.20030744"},
    },
    visualMagnitude: 11.07,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.00521505),
        dec: Angle.Degrees(+25.79011020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190470"},
        {"Hipparcos Number", "HIP 98828"},
        {"Geneva Identification System", "GEN# +1.00190470"},
        {"Smithsonian Astrophysical Observation", "SAO 88147"},
        {"Wilson Evans Batten Catalogue", "WEB 17526"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.04206099),
        dec: Angle.Degrees(+25.79032448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109718"},
        {"Hipparcos Number", "HIP 61546"},
        {"Smithsonian Astrophysical Observation", "SAO 82399"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.16546469),
        dec: Angle.Degrees(+25.79175028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167782"},
        {"Hipparcos Number", "HIP 89492"},
        {"Geneva Identification System", "GEN# +1.00167782"},
        {"Smithsonian Astrophysical Observation", "SAO 85872"},
        {"Wilson Evans Batten Catalogue", "WEB 15233"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.94115830),
        dec: Angle.Degrees(+25.79430125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248530"},
        {"Hipparcos Number", "HIP 27742"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.09295797),
        dec: Angle.Degrees(+25.79570606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338005"},
        {"Hipparcos Number", "HIP 94571"},
        {"Smithsonian Astrophysical Observation", "SAO 86978"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.70200694),
        dec: Angle.Degrees(+25.79613867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10682"},
        {"Hipparcos Number", "HIP 8151"},
        {"Geneva Identification System", "GEN# +1.00010682"},
        {"Smithsonian Astrophysical Observation", "SAO 74898"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.19868051),
        dec: Angle.Degrees(+25.79669722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113447"},
        {"Hipparcos Number", "HIP 63721"},
        {"Geneva Identification System", "GEN# +1.00113447"},
        {"Smithsonian Astrophysical Observation", "SAO 82628"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.86946290),
        dec: Angle.Degrees(+25.79712404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73467"},
        {"Smithsonian Astrophysical Observation", "SAO 83618"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.22874491),
        dec: Angle.Degrees(+25.79788120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63716"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.86114538),
        dec: Angle.Degrees(+25.79844452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82054",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82054"},
        {"Smithsonian Astrophysical Observation", "SAO 84584"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.41343139),
        dec: Angle.Degrees(+25.79910988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23777"},
        {"Hipparcos Number", "HIP 17812"},
        {"Fundamental Katalog 5th Edition", "FK5 4346"},
        {"Geneva Identification System", "GEN# +1.00023777"},
        {"Smithsonian Astrophysical Observation", "SAO 76220"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.17455013),
        dec: Angle.Degrees(+25.80075493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161073"},
        {"Hipparcos Number", "HIP 86668"},
        {"Smithsonian Astrophysical Observation", "SAO 85345"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.62115411),
        dec: Angle.Degrees(+25.80095953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100973"},
        {"Hipparcos Number", "HIP 56687"},
        {"Geneva Identification System", "GEN# +1.00100973"},
        {"Smithsonian Astrophysical Observation", "SAO 81905"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.35305822),
        dec: Angle.Degrees(+25.80267585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215690"},
        {"Hipparcos Number", "HIP 112453"},
        {"Geneva Identification System", "GEN# +1.00215690"},
        {"Smithsonian Astrophysical Observation", "SAO 90778"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.68741674),
        dec: Angle.Degrees(+25.80339345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101300",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13964 AB"},
        {"Henry Draper", "HD 195693"},
        {"Henry Draper 2", "HD 195692"},
        {"Hipparcos Number", "HIP 101300"},
        {"Geneva Identification System", "GEN# +1.00195692J"},
        {"Renson", "Renson 54520"},
        {"Smithsonian Astrophysical Observation", "SAO 88808"},
        {"Wilson Evans Batten Catalogue", "WEB 18305"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.99244679),
        dec: Angle.Degrees(+25.80502621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184538"},
        {"Hipparcos Number", "HIP 96225"},
        {"Geneva Identification System", "GEN# +1.00184538"},
        {"Smithsonian Astrophysical Observation", "SAO 87365"},
        {"Wilson Evans Batten Catalogue", "WEB 16863"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.50943565),
        dec: Angle.Degrees(+25.80590876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30380"},
        {"Hipparcos Number", "HIP 22298"},
        {"Smithsonian Astrophysical Observation", "SAO 76760"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.02692677),
        dec: Angle.Degrees(+25.80718282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284012"},
        {"Hipparcos Number", "HIP 23201"},
        {"Geneva Identification System", "GEN# +1.00284012"},
        {"Smithsonian Astrophysical Observation", "SAO 76874"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.89844180),
        dec: Angle.Degrees(+25.80749962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156775"},
        {"Hipparcos Number", "HIP 84663"},
        {"Smithsonian Astrophysical Observation", "SAO 84996"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.62458236),
        dec: Angle.Degrees(+25.80783907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129152"},
        {"Hipparcos Number", "HIP 71728"},
        {"Smithsonian Astrophysical Observation", "SAO 83460"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.08241018),
        dec: Angle.Degrees(+25.80952463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221133"},
        {"Hipparcos Number", "HIP 115934"},
        {"Smithsonian Astrophysical Observation", "SAO 91298"},
        {"Wilson Evans Batten Catalogue", "WEB 20504"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.33749279),
        dec: Angle.Degrees(+25.81208936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184942"},
        {"Hipparcos Number", "HIP 96386"},
        {"Smithsonian Astrophysical Observation", "SAO 87418"},
        {"Wilson Evans Batten Catalogue", "WEB 16904"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.94964763),
        dec: Angle.Degrees(+25.81394473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14088"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.41007039),
        dec: Angle.Degrees(+25.81404575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109499"},
        {"Smithsonian Astrophysical Observation", "SAO 90295"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.72911183),
        dec: Angle.Degrees(+25.81421370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203503"},
        {"Hipparcos Number", "HIP 105484"},
        {"Geneva Identification System", "GEN# +1.00203503"},
        {"Smithsonian Astrophysical Observation", "SAO 89650"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.47788828),
        dec: Angle.Degrees(+25.81530774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122080"},
        {"Hipparcos Number", "HIP 68316"},
        {"Geneva Identification System", "GEN# +1.00122080J"},
        {"Smithsonian Astrophysical Observation", "SAO 83108"},
        {"Wilson Evans Batten Catalogue", "WEB 11984"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.77184933),
        dec: Angle.Degrees(+25.81601130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123033"},
        {"Hipparcos Number", "HIP 68785"},
        {"Geneva Identification System", "GEN# +1.00123033A"},
        {"Smithsonian Astrophysical Observation", "SAO 83152"},
        {"Wilson Evans Batten Catalogue", "WEB 12032"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.19141977),
        dec: Angle.Degrees(+25.81801332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197489"},
        {"Hipparcos Number", "HIP 102271"},
        {"Geneva Identification System", "GEN# +1.00197489"},
        {"Smithsonian Astrophysical Observation", "SAO 89048"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.83330654),
        dec: Angle.Degrees(+25.82477410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177347"},
        {"Hipparcos Number", "HIP 93553"},
        {"Fundamental Katalog 5th Edition", "FK5 5677"},
        {"Geneva Identification System", "GEN# +1.00177347"},
        {"Smithsonian Astrophysical Observation", "SAO 86743"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.82446474),
        dec: Angle.Degrees(+25.82612145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113962"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.18709213),
        dec: Angle.Degrees(+25.82703129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27405"},
        {"Hipparcos Number", "HIP 20258"},
        {"Geneva Identification System", "GEN# +1.00027405"},
        {"Smithsonian Astrophysical Observation", "SAO 76559"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.12656589),
        dec: Angle.Degrees(+25.82747458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7352"},
        {"Hipparcos Number", "HIP 5777"},
        {"Geneva Identification System", "GEN# +1.00007352"},
        {"Smithsonian Astrophysical Observation", "SAO 74578"},
        {"Wilson Evans Batten Catalogue", "WEB 1317"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.52981002),
        dec: Angle.Degrees(+25.82779222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36793"},
        {"Hipparcos Number", "HIP 26225"},
        {"Geneva Identification System", "GEN# +1.00036793"},
        {"Smithsonian Astrophysical Observation", "SAO 77281"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.82179339),
        dec: Angle.Degrees(+25.82898506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12868"},
        {"Hipparcos Number", "HIP 9851"},
        {"Geneva Identification System", "GEN# +1.00012868"},
        {"Smithsonian Astrophysical Observation", "SAO 75147"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.67734371),
        dec: Angle.Degrees(+25.83086010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2973",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2973"},
        {"Geneva Identification System", "GEN# +0.02500090"},
        {"Smithsonian Astrophysical Observation", "SAO 74158"},
        {"Wilson Evans Batten Catalogue", "WEB 537"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.46300436),
        dec: Angle.Degrees(+25.83196547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50271"},
        {"Smithsonian Astrophysical Observation", "SAO 81256"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.96954518),
        dec: Angle.Degrees(+25.83366624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78514"},
        {"Hipparcos Number", "HIP 44948"},
        {"Smithsonian Astrophysical Observation", "SAO 80664"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.34239041),
        dec: Angle.Degrees(+25.83529791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177744"},
        {"Hipparcos Number", "HIP 93726"},
        {"Geneva Identification System", "GEN# +1.00177744"},
        {"Smithsonian Astrophysical Observation", "SAO 86787"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.26322032),
        dec: Angle.Degrees(+25.83806906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341163"},
        {"Hipparcos Number", "HIP 102899"},
        {"Smithsonian Astrophysical Observation", "SAO 89202"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.69226934),
        dec: Angle.Degrees(+25.84010339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149067"},
        {"Hipparcos Number", "HIP 80917"},
        {"Smithsonian Astrophysical Observation", "SAO 84425"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.85377468),
        dec: Angle.Degrees(+25.84163237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214397"},
        {"Hipparcos Number", "HIP 111678"},
        {"Smithsonian Astrophysical Observation", "SAO 90654"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.35914735),
        dec: Angle.Degrees(+25.84173384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23488"},
        {"Hipparcos Number", "HIP 17625"},
        {"Geneva Identification System", "GEN# +5.20223319"},
        {"Smithsonian Astrophysical Observation", "SAO 76174"},
        {"Wilson Evans Batten Catalogue", "WEB 3357"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.64506816),
        dec: Angle.Degrees(+25.84397069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202475"},
        {"Hipparcos Number", "HIP 104935"},
        {"Smithsonian Astrophysical Observation", "SAO 89566"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.84394379),
        dec: Angle.Degrees(+25.84453774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67690"},
        {"Hipparcos Number", "HIP 40007"},
        {"Geneva Identification System", "GEN# +1.00067690"},
        {"Smithsonian Astrophysical Observation", "SAO 79991"},
        {"Wilson Evans Batten Catalogue", "WEB 7801"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.55464962),
        dec: Angle.Degrees(+25.84455571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224771"},
        {"Hipparcos Number", "HIP 42"},
        {"Geneva Identification System", "GEN# +1.00224771"},
        {"Smithsonian Astrophysical Observation", "SAO 91650"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.12538666),
        dec: Angle.Degrees(+25.84478059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123877"},
        {"Hipparcos Number", "HIP 69183"},
        {"Geneva Identification System", "GEN# +1.00123877"},
        {"Smithsonian Astrophysical Observation", "SAO 83199"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.42484119),
        dec: Angle.Degrees(+25.84598487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60351",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8530 A"},
        {"Henry Draper", "HD 107700"},
        {"Hipparcos Number", "HIP 60351"},
        {"Fundamental Katalog 5th Edition", "FK5 1318"},
        {"Geneva Identification System", "GEN# +5.21110091"},
        {"Smithsonian Astrophysical Observation", "SAO 82273"},
        {"Wilson Evans Batten Catalogue", "WEB 10733"},
    },
    visualMagnitude: 4.78,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.62632982),
        dec: Angle.Degrees(+25.84618178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180990"},
        {"Hipparcos Number", "HIP 94828"},
        {"Geneva Identification System", "GEN# +1.00180990"},
        {"Smithsonian Astrophysical Observation", "SAO 87039"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.43329872),
        dec: Angle.Degrees(+25.85112787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107935"},
        {"Hipparcos Number", "HIP 60490"},
        {"Geneva Identification System", "GEN# +5.21110104"},
        {"Renson", "Renson 31290"},
        {"Smithsonian Astrophysical Observation", "SAO 82288"},
        {"Wilson Evans Batten Catalogue", "WEB 10758"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.01445582),
        dec: Angle.Degrees(+25.85125433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11245"},
        {"Hipparcos Number", "HIP 8600"},
        {"Geneva Identification System", "GEN# +1.00011245"},
        {"Smithsonian Astrophysical Observation", "SAO 74979"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.74380390),
        dec: Angle.Degrees(+25.85133175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107793"},
        {"Hipparcos Number", "HIP 60406"},
        {"Geneva Identification System", "GEN# +5.21110097"},
        {"Smithsonian Astrophysical Observation", "SAO 82280"},
        {"Wilson Evans Batten Catalogue", "WEB 10741"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.78502888),
        dec: Angle.Degrees(+25.85139615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127093"},
        {"Hipparcos Number", "HIP 70800"},
        {"Geneva Identification System", "GEN# +1.00127093"},
        {"Smithsonian Astrophysical Observation", "SAO 83375"},
        {"Wilson Evans Batten Catalogue", "WEB 12267"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.19175546),
        dec: Angle.Degrees(+25.85391099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150889"},
        {"Hipparcos Number", "HIP 81834"},
        {"Smithsonian Astrophysical Observation", "SAO 84555"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.72943761),
        dec: Angle.Degrees(+25.85496950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77313"},
        {"Hipparcos Number", "HIP 44391"},
        {"Smithsonian Astrophysical Observation", "SAO 80592"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.63695228),
        dec: Angle.Degrees(+25.85547927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97795",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97795"},
    },
    visualMagnitude: 9.60,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.08831658),
        dec: Angle.Degrees(+25.85721051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114807"},
        {"Smithsonian Astrophysical Observation", "SAO 91125"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.84365000),
        dec: Angle.Degrees(+25.86078669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89055"},
        {"Hipparcos Number", "HIP 50355"},
        {"Cincinnati Publication", "Ci 18 1234"},
        {"Geneva Identification System", "GEN# +1.00089055"},
        {"Smithsonian Astrophysical Observation", "SAO 81267"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.23559837),
        dec: Angle.Degrees(+25.86143277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -296.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97792",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13050 AB"},
        {"Henry Draper", "HD 188060"},
        {"Hipparcos Number", "HIP 97792"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.08092014),
        dec: Angle.Degrees(+25.86289880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141270"},
        {"Hipparcos Number", "HIP 77341"},
        {"Smithsonian Astrophysical Observation", "SAO 84002"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.84222203),
        dec: Angle.Degrees(+25.86545698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19133"},
        {"Hipparcos Number", "HIP 14379"},
        {"Geneva Identification System", "GEN# +1.00019133"},
        {"Smithsonian Astrophysical Observation", "SAO 75724"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.37843614),
        dec: Angle.Degrees(+25.86887941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105981"},
        {"Hipparcos Number", "HIP 59468"},
        {"Fundamental Katalog 5th Edition", "FK5 2976"},
        {"Geneva Identification System", "GEN# +5.21110016"},
        {"Smithsonian Astrophysical Observation", "SAO 82178"},
        {"Wilson Evans Batten Catalogue", "WEB 10573"},
    },
    visualMagnitude: 5.66,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.96333771),
        dec: Angle.Degrees(+25.87035539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109030"},
        {"Hipparcos Number", "HIP 61119"},
        {"Geneva Identification System", "GEN# +5.21110166"},
        {"Renson", "Renson 31650"},
        {"Smithsonian Astrophysical Observation", "SAO 82354"},
        {"Wilson Evans Batten Catalogue", "WEB 10881"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.89039927),
        dec: Angle.Degrees(+25.87039890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21168"},
        {"Hipparcos Number", "HIP 15980"},
        {"Smithsonian Astrophysical Observation", "SAO 75926"},
        {"Wilson Evans Batten Catalogue", "WEB 3053"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.44974820),
        dec: Angle.Degrees(+25.87108409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2077"},
        {"Renson", "Renson 530"},
        {"Smithsonian Astrophysical Observation", "SAO 73984"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.55695729),
        dec: Angle.Degrees(+25.87235569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192893"},
        {"Hipparcos Number", "HIP 99928"},
        {"Geneva Identification System", "GEN# +1.00192893"},
        {"Renson", "Renson 53830"},
        {"Smithsonian Astrophysical Observation", "SAO 88439"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.11471910),
        dec: Angle.Degrees(+25.87371017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156547"},
        {"Hipparcos Number", "HIP 84561"},
        {"Smithsonian Astrophysical Observation", "SAO 84977"},
        {"Wilson Evans Batten Catalogue", "WEB 14277"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.29504722),
        dec: Angle.Degrees(+25.87381065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99862"},
        {"Hipparcos Number", "HIP 56062"},
        {"Smithsonian Astrophysical Observation", "SAO 81846"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.35134942),
        dec: Angle.Degrees(+25.87421796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105776"},
        {"Smithsonian Astrophysical Observation", "SAO 89696"},
    },
    visualMagnitude: 9.99,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.34359831),
        dec: Angle.Degrees(+25.87454890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195968"},
        {"Hipparcos Number", "HIP 101447"},
        {"Smithsonian Astrophysical Observation", "SAO 88840"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.40691593),
        dec: Angle.Degrees(+25.87736789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26081"},
        {"Hipparcos Number", "HIP 19341"},
        {"Geneva Identification System", "GEN# +1.00026081"},
        {"Smithsonian Astrophysical Observation", "SAO 76472"},
        {"Wilson Evans Batten Catalogue", "WEB 3715"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.16259315),
        dec: Angle.Degrees(+25.87777382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118458"},
        {"Hipparcos Number", "HIP 66389"},
        {"Geneva Identification System", "GEN# +1.00118458"},
        {"Smithsonian Astrophysical Observation", "SAO 82900"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.17984929),
        dec: Angle.Degrees(+25.87785812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117295"},
        {"Smithsonian Astrophysical Observation", "SAO 91484"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.74815976),
        dec: Angle.Degrees(+25.87886110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117912"},
        {"Hipparcos Number", "HIP 66112"},
        {"Geneva Identification System", "GEN# +1.00117912"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.28505272),
        dec: Angle.Degrees(+25.88004079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35070",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5918 AB"},
        {"Henry Draper", "HD 55726"},
        {"Hipparcos Number", "HIP 35070"},
        {"Smithsonian Astrophysical Observation", "SAO 79206"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.78320019),
        dec: Angle.Degrees(+25.88037550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203977"},
        {"Hipparcos Number", "HIP 105724"},
        {"Geneva Identification System", "GEN# +1.00203977"},
        {"Smithsonian Astrophysical Observation", "SAO 89687"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.20039027),
        dec: Angle.Degrees(+25.88046455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172500"},
        {"Hipparcos Number", "HIP 91496"},
        {"Geneva Identification System", "GEN# +1.00172500"},
        {"Smithsonian Astrophysical Observation", "SAO 86294"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.89748681),
        dec: Angle.Degrees(+25.88248432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196362"},
        {"Hipparcos Number", "HIP 101641"},
        {"Geneva Identification System", "GEN# +1.00196362"},
        {"Renson", "Renson 54730"},
        {"Smithsonian Astrophysical Observation", "SAO 88884"},
        {"Wilson Evans Batten Catalogue", "WEB 18361"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.03467615),
        dec: Angle.Degrees(+25.88261861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45800"},
        {"Hipparcos Number", "HIP 31031"},
        {"Smithsonian Astrophysical Observation", "SAO 78451"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.66723123),
        dec: Angle.Degrees(+25.88432333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244986"},
        {"Hipparcos Number", "HIP 26177"},
        {"Smithsonian Astrophysical Observation", "SAO 77271"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.71285062),
        dec: Angle.Degrees(+25.88433894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28640",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4619 AB"},
        {"Henry Draper", "HD 40895"},
        {"Hipparcos Number", "HIP 28640"},
        {"Smithsonian Astrophysical Observation", "SAO 77880"},
        {"Wilson Evans Batten Catalogue", "WEB 5600"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.71908656),
        dec: Angle.Degrees(+25.88447970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199236"},
        {"Hipparcos Number", "HIP 103252"},
        {"Geneva Identification System", "GEN# +1.00199236"},
        {"Smithsonian Astrophysical Observation", "SAO 89277"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.76592893),
        dec: Angle.Degrees(+25.88467919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283707"},
        {"Hipparcos Number", "HIP 21134"},
        {"Smithsonian Astrophysical Observation", "SAO 76642"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.95683094),
        dec: Angle.Degrees(+25.88531159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116929"},
        {"Smithsonian Astrophysical Observation", "SAO 91426"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.51485417),
        dec: Angle.Degrees(+25.88559156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224709"},
        {"Hipparcos Number", "HIP 8"},
        {"Wilson Evans Batten Catalogue", "WEB 1"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.02729160),
        dec: Angle.Degrees(+25.88647445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147368"},
        {"Hipparcos Number", "HIP 80077"},
        {"Geneva Identification System", "GEN# +1.00147368"},
        {"Smithsonian Astrophysical Observation", "SAO 84310"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.15247748),
        dec: Angle.Degrees(+25.88695104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61645"},
        {"Hipparcos Number", "HIP 37452"},
        {"Geneva Identification System", "GEN# +1.00061645"},
        {"Smithsonian Astrophysical Observation", "SAO 79612"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.32259621),
        dec: Angle.Degrees(+25.88877603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44387"},
        {"Smithsonian Astrophysical Observation", "SAO 80591"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.62801462),
        dec: Angle.Degrees(+25.88986251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112313"},
        {"Hipparcos Number", "HIP 63087"},
        {"Geneva Identification System", "GEN# +1.00112313"},
        {"Smithsonian Astrophysical Observation", "SAO 82570"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.89067643),
        dec: Angle.Degrees(+25.89183204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107798",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107798"},
        {"Smithsonian Astrophysical Observation", "SAO 90045"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.55506488),
        dec: Angle.Degrees(+25.89375244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49735"},
        {"Hipparcos Number", "HIP 32873"},
        {"Smithsonian Astrophysical Observation", "SAO 78794"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.75091013),
        dec: Angle.Degrees(+25.89507304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254695"},
        {"Hipparcos Number", "HIP 29967"},
        {"Smithsonian Astrophysical Observation", "SAO 78199"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.62446275),
        dec: Angle.Degrees(+25.89520601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59319",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59319"},
        {"Geneva Identification System", "GEN# +5.21110007"},
        {"Smithsonian Astrophysical Observation", "SAO 82161"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.53527139),
        dec: Angle.Degrees(+25.89538373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147025"},
        {"Hipparcos Number", "HIP 79889"},
        {"Fundamental Katalog 5th Edition", "FK5 3290"},
        {"Geneva Identification System", "GEN# +1.00147025"},
        {"Smithsonian Astrophysical Observation", "SAO 84295"},
        {"Wilson Evans Batten Catalogue", "WEB 13525"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.59857989),
        dec: Angle.Degrees(+25.89668417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37438"},
        {"Hipparcos Number", "HIP 26640"},
        {"Fundamental Katalog 5th Edition", "FK5 2424"},
        {"Geneva Identification System", "GEN# +1.00037438"},
        {"Smithsonian Astrophysical Observation", "SAO 77360"},
        {"Wilson Evans Batten Catalogue", "WEB 5254"},
    },
    visualMagnitude: 5.18,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.93413604),
        dec: Angle.Degrees(+25.89714891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76005"},
        {"Smithsonian Astrophysical Observation", "SAO 83864"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.83412374),
        dec: Angle.Degrees(+25.89762450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60891",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8568 B"},
        {"Henry Draper", "HD 108651"},
        {"Hipparcos Number", "HIP 60891"},
        {"Geneva Identification System", "GEN# +5.21110145"},
        {"Renson", "Renson 31540"},
        {"Smithsonian Astrophysical Observation", "SAO 82328"},
        {"Wilson Evans Batten Catalogue", "WEB 10836"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.18574311),
        dec: Angle.Degrees(+25.89936158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106569"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.73129539),
        dec: Angle.Degrees(+25.90061376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73999",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73999"},
        {"Smithsonian Astrophysical Observation", "SAO 83672"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.83098755),
        dec: Angle.Degrees(+25.90168343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338734"},
        {"Hipparcos Number", "HIP 96920"},
        {"Geneva Identification System", "GEN# +1.00338734"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.52121866),
        dec: Angle.Degrees(+25.90211562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64274",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64274"},
        {"Smithsonian Astrophysical Observation", "SAO 82688"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.59104494),
        dec: Angle.Degrees(+25.90308788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7600",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1274 AB"},
        {"Henry Draper", "HD 9984"},
        {"Hipparcos Number", "HIP 7600"},
        {"Geneva Identification System", "GEN# +1.00009984J"},
        {"Smithsonian Astrophysical Observation", "SAO 74836"},
        {"Wilson Evans Batten Catalogue", "WEB 1625"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.47891388),
        dec: Angle.Degrees(+25.90403730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5345",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5345"},
        {"Smithsonian Astrophysical Observation", "SAO 74512"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.09243007),
        dec: Angle.Degrees(+25.90819286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335509"},
        {"Hipparcos Number", "HIP 88191"},
        {"Smithsonian Astrophysical Observation", "SAO 85629"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.15693353),
        dec: Angle.Degrees(+25.90850450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338909"},
        {"Hipparcos Number", "HIP 97198"},
        {"Smithsonian Astrophysical Observation", "SAO 87668"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.31817503),
        dec: Angle.Degrees(+25.90929612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62033",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8640 AB"},
        {"Henry Draper", "HD 110571"},
        {"Hipparcos Number", "HIP 62033"},
        {"Geneva Identification System", "GEN# +1.00110571J"},
        {"Smithsonian Astrophysical Observation", "SAO 82452"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.73114167),
        dec: Angle.Degrees(+25.90972704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215882"},
        {"Hipparcos Number", "HIP 112588"},
        {"Smithsonian Astrophysical Observation", "SAO 90796"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.04172210),
        dec: Angle.Degrees(+25.91010140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108486"},
        {"Hipparcos Number", "HIP 60797"},
        {"Geneva Identification System", "GEN# +5.21110139"},
        {"Renson", "Renson 31510"},
        {"Smithsonian Astrophysical Observation", "SAO 82321"},
        {"Wilson Evans Batten Catalogue", "WEB 10816"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.90988107),
        dec: Angle.Degrees(+25.91212798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60904",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "** STFA 21"},
        {"Aitken", "ADS 8568 A"},
        {"Henry Draper", "HD 108662"},
        {"Hipparcos Number", "HIP 60904"},
        {"Geneva Identification System", "GEN# +5.21110146"},
        {"Renson", "Renson 31550"},
        {"Smithsonian Astrophysical Observation", "SAO 82330"},
        {"Wilson Evans Batten Catalogue", "WEB 10838"},
    },
    visualMagnitude: 5.29,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.22799077),
        dec: Angle.Degrees(+25.91288804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83821"},
        {"Hipparcos Number", "HIP 47550"},
        {"Geneva Identification System", "GEN# +1.00083821"},
        {"Smithsonian Astrophysical Observation", "SAO 80970"},
        {"Wilson Evans Batten Catalogue", "WEB 8918"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.41040299),
        dec: Angle.Degrees(+25.91295540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336499"},
        {"Hipparcos Number", "HIP 91165"},
        {"Smithsonian Astrophysical Observation", "SAO 86229"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.97867428),
        dec: Angle.Degrees(+25.91377926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51688"},
        {"Hipparcos Number", "HIP 33650"},
        {"Geneva Identification System", "GEN# +1.00051688"},
        {"Renson", "Renson 14230"},
        {"Smithsonian Astrophysical Observation", "SAO 78947"},
        {"Wilson Evans Batten Catalogue", "WEB 6762"},
    },
    visualMagnitude: 6.40,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.86639602),
        dec: Angle.Degrees(+25.91418673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9172"},
        {"Hipparcos Number", "HIP 7034"},
        {"Geneva Identification System", "GEN# +1.00009172"},
        {"Smithsonian Astrophysical Observation", "SAO 74763"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.66314837),
        dec: Angle.Degrees(+25.91482241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92108"},
        {"Hipparcos Number", "HIP 52077"},
        {"Smithsonian Astrophysical Observation", "SAO 81449"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.61858565),
        dec: Angle.Degrees(+25.91505330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338910"},
        {"Hipparcos Number", "HIP 97211"},
        {"Smithsonian Astrophysical Observation", "SAO 87676"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.36006649),
        dec: Angle.Degrees(+25.91562613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194403"},
        {"Hipparcos Number", "HIP 100661"},
        {"Smithsonian Astrophysical Observation", "SAO 88637"},
        {"Wilson Evans Batten Catalogue", "WEB 18192"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.15159800),
        dec: Angle.Degrees(+25.91651296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33897"},
        {"Hipparcos Number", "HIP 24431"},
        {"Smithsonian Astrophysical Observation", "SAO 77046"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.62974551),
        dec: Angle.Degrees(+25.91733280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81058"},
        {"Hipparcos Number", "HIP 46105"},
        {"Smithsonian Astrophysical Observation", "SAO 80801"},
        {"Wilson Evans Batten Catalogue", "WEB 8730"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.03324698),
        dec: Angle.Degrees(+25.91844961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10844"},
        {"Hipparcos Number", "HIP 8285"},
        {"Geneva Identification System", "GEN# +1.00010844"},
        {"Smithsonian Astrophysical Observation", "SAO 74924"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.68737759),
        dec: Angle.Degrees(+25.91849646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115389",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16707 A"},
        {"Henry Draper", "HD 220288"},
        {"Hipparcos Number", "HIP 115389"},
        {"Geneva Identification System", "GEN# +1.00220288"},
        {"Smithsonian Astrophysical Observation", "SAO 91217"},
        {"Wilson Evans Batten Catalogue", "WEB 20433"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.61907358),
        dec: Angle.Degrees(+25.91850998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121648"},
        {"Hipparcos Number", "HIP 68064"},
        {"Geneva Identification System", "GEN# +1.00121648"},
        {"Smithsonian Astrophysical Observation", "SAO 83080"},
        {"Wilson Evans Batten Catalogue", "WEB 11948"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.03991801),
        dec: Angle.Degrees(+25.91872391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200511"},
        {"Hipparcos Number", "HIP 103901"},
        {"Geneva Identification System", "GEN# +1.00200511"},
        {"Smithsonian Astrophysical Observation", "SAO 89408"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.79014269),
        dec: Angle.Degrees(+25.91995026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143454"},
        {"Hipparcos Number", "HIP 78322"},
        {"Geneva Identification System", "GEN# +1.00143454"},
        {"Smithsonian Astrophysical Observation", "SAO 84129"},
        {"Wilson Evans Batten Catalogue", "WEB 13243"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.87568752),
        dec: Angle.Degrees(+25.92014087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12638"},
        {"Hipparcos Number", "HIP 9669"},
        {"Geneva Identification System", "GEN# +1.00012638"},
        {"Smithsonian Astrophysical Observation", "SAO 75122"},
        {"Wilson Evans Batten Catalogue", "WEB 2029"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.08806084),
        dec: Angle.Degrees(+25.92016125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177830"},
        {"Hipparcos Number", "HIP 93746"},
        {"Geneva Identification System", "GEN# +1.00177830"},
        {"Smithsonian Astrophysical Observation", "SAO 86791"},
        {"Wilson Evans Batten Catalogue", "WEB 16293"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.33666621),
        dec: Angle.Degrees(+25.92078674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115350"},
        {"Hipparcos Number", "HIP 64759"},
        {"Geneva Identification System", "GEN# +1.00115350"},
        {"Smithsonian Astrophysical Observation", "SAO 82745"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.07744148),
        dec: Angle.Degrees(+25.92083380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204540"},
        {"Hipparcos Number", "HIP 106036"},
        {"Geneva Identification System", "GEN# +1.00204540"},
        {"Smithsonian Astrophysical Observation", "SAO 89735"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.17608970),
        dec: Angle.Degrees(+25.92138008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25355"},
        {"Hipparcos Number", "HIP 18868"},
        {"Smithsonian Astrophysical Observation", "SAO 76407"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.67421882),
        dec: Angle.Degrees(+25.92146767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112706"},
        {"Hipparcos Number", "HIP 63310"},
        {"Geneva Identification System", "GEN# +1.00112706"},
        {"Smithsonian Astrophysical Observation", "SAO 82587"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.61722025),
        dec: Angle.Degrees(+25.92226332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283247"},
        {"Hipparcos Number", "HIP 18815"},
        {"Smithsonian Astrophysical Observation", "SAO 76400"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.48083231),
        dec: Angle.Degrees(+25.92369675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70316"},
        {"Hipparcos Number", "HIP 41014"},
        {"Geneva Identification System", "GEN# +1.00070316"},
        {"Smithsonian Astrophysical Observation", "SAO 80132"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.55304673),
        dec: Angle.Degrees(+25.92371621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178618"},
        {"Hipparcos Number", "HIP 93997"},
        {"Smithsonian Astrophysical Observation", "SAO 86854"},
    },
    visualMagnitude: 8.60,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.07253946),
        dec: Angle.Degrees(+25.92371968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8430"},
        {"Hipparcos Number", "HIP 6529"},
        {"Geneva Identification System", "GEN# +1.00008430"},
        {"Smithsonian Astrophysical Observation", "SAO 74689"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.96646789),
        dec: Angle.Degrees(+25.92501399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208057"},
        {"Hipparcos Number", "HIP 108022"},
        {"Fundamental Katalog 5th Edition", "FK5 823"},
        {"Geneva Identification System", "GEN# +1.00208057"},
        {"Smithsonian Astrophysical Observation", "SAO 90075"},
        {"Wilson Evans Batten Catalogue", "WEB 19474"},
    },
    visualMagnitude: 5.09,
    bvColour: -0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.26567758),
        dec: Angle.Degrees(+25.92513878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76766"},
        {"Hipparcos Number", "HIP 44100"},
        {"Geneva Identification System", "GEN# +1.00076766"},
        {"Smithsonian Astrophysical Observation", "SAO 80550"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.73476105),
        dec: Angle.Degrees(+25.92572896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118971"},
        {"Hipparcos Number", "HIP 66667"},
        {"Geneva Identification System", "GEN# +1.00118971"},
        {"Smithsonian Astrophysical Observation", "SAO 82934"},
        {"Wilson Evans Batten Catalogue", "WEB 11759"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.00228592),
        dec: Angle.Degrees(+25.92658291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101642"},
        {"Hipparcos Number", "HIP 57061"},
        {"Geneva Identification System", "GEN# +1.00101642"},
        {"Smithsonian Astrophysical Observation", "SAO 81946"},
        {"Wilson Evans Batten Catalogue", "WEB 10273"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.46630487),
        dec: Angle.Degrees(+25.92659736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212734"},
        {"Hipparcos Number", "HIP 110733"},
        {"Fundamental Katalog 5th Edition", "FK5 5977"},
        {"Geneva Identification System", "GEN# +1.00212734"},
        {"Smithsonian Astrophysical Observation", "SAO 90501"},
        {"Wilson Evans Batten Catalogue", "WEB 19841"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.51785847),
        dec: Angle.Degrees(+25.92765840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59066",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59066"},
        {"Smithsonian Astrophysical Observation", "SAO 82139"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.69368988),
        dec: Angle.Degrees(+25.93085102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208379"},
        {"Hipparcos Number", "HIP 108221"},
        {"Smithsonian Astrophysical Observation", "SAO 90099"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.86434099),
        dec: Angle.Degrees(+25.93275820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207121"},
        {"Hipparcos Number", "HIP 107489"},
        {"Smithsonian Astrophysical Observation", "SAO 89974"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.57004065),
        dec: Angle.Degrees(+25.93469966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9621",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1631 AB"},
        {"Henry Draper", "HD 12558"},
        {"Hipparcos Number", "HIP 9621"},
        {"Geneva Identification System", "GEN# +1.00012558J"},
        {"Smithsonian Astrophysical Observation", "SAO 75114"},
        {"Wilson Evans Batten Catalogue", "WEB 2019"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.91359346),
        dec: Angle.Degrees(+25.93544879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31782"},
        {"Hipparcos Number", "HIP 23204"},
        {"Geneva Identification System", "GEN# +1.00031782"},
        {"Smithsonian Astrophysical Observation", "SAO 76876"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.90287481),
        dec: Angle.Degrees(+25.93606430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283807"},
        {"Hipparcos Number", "HIP 22060"},
        {"Geneva Identification System", "GEN# +1.00283807"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.17471085),
        dec: Angle.Degrees(+25.93606535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112611"},
        {"Hipparcos Number", "HIP 63259"},
        {"Geneva Identification System", "GEN# +1.00112611"},
        {"Smithsonian Astrophysical Observation", "SAO 82584"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.43747006),
        dec: Angle.Degrees(+25.93624794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13363"},
        {"Hipparcos Number", "HIP 10203"},
        {"Geneva Identification System", "GEN# +1.00013363"},
        {"Smithsonian Astrophysical Observation", "SAO 75188"},
        {"Wilson Evans Batten Catalogue", "WEB 2129"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.80025110),
        dec: Angle.Degrees(+25.93695537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72982"},
        {"Hipparcos Number", "HIP 42243"},
        {"Smithsonian Astrophysical Observation", "SAO 80283"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.17814814),
        dec: Angle.Degrees(+25.93730042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13174"},
        {"Hipparcos Number", "HIP 10053"},
        {"Geneva Identification System", "GEN# +1.00013174A"},
        {"Smithsonian Astrophysical Observation", "SAO 75171"},
        {"Wilson Evans Batten Catalogue", "WEB 2106"},
    },
    visualMagnitude: 4.98,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.35535861),
        dec: Angle.Degrees(+25.93997268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36994"},
        {"Hipparcos Number", "HIP 26332"},
        {"Geneva Identification System", "GEN# +1.00036994"},
        {"Smithsonian Astrophysical Observation", "SAO 77310"},
        {"Wilson Evans Batten Catalogue", "WEB 5187"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.12573514),
        dec: Angle.Degrees(+25.94010120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340377"},
        {"Hipparcos Number", "HIP 101030"},
        {"Geneva Identification System", "GEN# +1.00340377"},
        {"Smithsonian Astrophysical Observation", "SAO 88732"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.22330316),
        dec: Angle.Degrees(+25.94075888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210925"},
        {"Hipparcos Number", "HIP 109696"},
        {"Geneva Identification System", "GEN# +1.00210925"},
        {"Smithsonian Astrophysical Observation", "SAO 90327"},
        {"Wilson Evans Batten Catalogue", "WEB 19706"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.29796647),
        dec: Angle.Degrees(+25.94092472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213291"},
        {"Hipparcos Number", "HIP 111067"},
        {"Smithsonian Astrophysical Observation", "SAO 90553"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.50743407),
        dec: Angle.Degrees(+25.94095808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56649"},
        {"Hipparcos Number", "HIP 35435"},
        {"Geneva Identification System", "GEN# +1.00056649"},
        {"Smithsonian Astrophysical Observation", "SAO 79277"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.72875176),
        dec: Angle.Degrees(+25.94145002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69762"},
        {"Geneva Identification System", "GEN# +0.02602547"},
        {"Smithsonian Astrophysical Observation", "SAO 83265"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.15896318),
        dec: Angle.Degrees(+25.94731988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130269"},
        {"Hipparcos Number", "HIP 72244"},
        {"Smithsonian Astrophysical Observation", "SAO 83513"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.61370741),
        dec: Angle.Degrees(+25.94854969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15958"},
        {"Smithsonian Astrophysical Observation", "SAO 75924"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.35523842),
        dec: Angle.Degrees(+25.95221822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40111"},
        {"Hipparcos Number", "HIP 28237"},
        {"Geneva Identification System", "GEN# +1.00040111"},
        {"Smithsonian Astrophysical Observation", "SAO 77775"},
        {"Wilson Evans Batten Catalogue", "WEB 5525"},
    },
    visualMagnitude: 4.81,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.49857371),
        dec: Angle.Degrees(+25.95391597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58363"},
        {"Hipparcos Number", "HIP 36110"},
        {"Smithsonian Astrophysical Observation", "SAO 79382"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.57627684),
        dec: Angle.Degrees(+25.95454386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224128"},
        {"Hipparcos Number", "HIP 117939"},
        {"Smithsonian Astrophysical Observation", "SAO 91582"},
        {"Wilson Evans Batten Catalogue", "WEB 20741"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.84590611),
        dec: Angle.Degrees(+25.95501866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241286"},
        {"Hipparcos Number", "HIP 24136"},
        {"Smithsonian Astrophysical Observation", "SAO 77014"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.75752048),
        dec: Angle.Degrees(+25.95842408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 266413"},
        {"Hipparcos Number", "HIP 33356"},
        {"Smithsonian Astrophysical Observation", "SAO 78882"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.06622190),
        dec: Angle.Degrees(+25.95983704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86122"},
        {"Smithsonian Astrophysical Observation", "SAO 85235"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.01660353),
        dec: Angle.Degrees(+25.96093183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339108"},
        {"Hipparcos Number", "HIP 97797"},
        {"Smithsonian Astrophysical Observation", "SAO 87854"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.09367239),
        dec: Angle.Degrees(+25.96245182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66762"},
        {"Smithsonian Astrophysical Observation", "SAO 82947"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.25842361),
        dec: Angle.Degrees(+25.96630997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109214"},
        {"Hipparcos Number", "HIP 61244"},
        {"Geneva Identification System", "GEN# +1.00109214"},
        {"Geneva Identification System 2", "GEN# +5.21110180"},
        {"Smithsonian Astrophysical Observation", "SAO 82374"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.25467094),
        dec: Angle.Degrees(+25.96658166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41829"},
        {"Hipparcos Number", "HIP 29123"},
        {"Smithsonian Astrophysical Observation", "SAO 78016"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.11783593),
        dec: Angle.Degrees(+25.96673768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113055"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.43262817),
        dec: Angle.Degrees(+25.96681405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57373"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.43470402),
        dec: Angle.Degrees(+25.96822580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66767"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.27243713),
        dec: Angle.Degrees(+25.96878835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157294"},
        {"Hipparcos Number", "HIP 84926"},
        {"Smithsonian Astrophysical Observation", "SAO 85025"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.33696731),
        dec: Angle.Degrees(+25.97147120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213762"},
        {"Hipparcos Number", "HIP 111345"},
        {"Smithsonian Astrophysical Observation", "SAO 90595"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.35931690),
        dec: Angle.Degrees(+25.97404103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13015"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.83518702),
        dec: Angle.Degrees(+25.97788145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185528"},
        {"Hipparcos Number", "HIP 96612"},
        {"Geneva Identification System", "GEN# +1.00185528"},
        {"Smithsonian Astrophysical Observation", "SAO 87493"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.62578107),
        dec: Angle.Degrees(+25.97873206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283929"},
        {"Hipparcos Number", "HIP 22584"},
        {"Geneva Identification System", "GEN# +1.00283929"},
        {"Smithsonian Astrophysical Observation", "SAO 76790"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.90437987),
        dec: Angle.Degrees(+25.98100666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43773"},
        {"Hipparcos Number", "HIP 30035"},
        {"Smithsonian Astrophysical Observation", "SAO 78215"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.80621913),
        dec: Angle.Degrees(+25.98228718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129429"},
        {"Hipparcos Number", "HIP 71851"},
        {"Geneva Identification System", "GEN# +1.00129429"},
        {"Smithsonian Astrophysical Observation", "SAO 83473"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.45266829),
        dec: Angle.Degrees(+25.98362435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19583",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3046 AB"},
        {"Henry Draper", "HD 26423"},
        {"Hipparcos Number", "HIP 19583"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.95393296),
        dec: Angle.Degrees(+25.98383684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80641",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10070 AB"},
        {"Henry Draper", "HD 148554"},
        {"Hipparcos Number", "HIP 80641"},
        {"Smithsonian Astrophysical Observation", "SAO 84393"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.97770018),
        dec: Angle.Degrees(+25.98431559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189435"},
        {"Hipparcos Number", "HIP 98362"},
        {"Smithsonian Astrophysical Observation", "SAO 88014"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.76515930),
        dec: Angle.Degrees(+25.98844877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37848",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6340 AB"},
        {"Henry Draper", "HD 62567"},
        {"Hipparcos Number", "HIP 37848"},
        {"Geneva Identification System", "GEN# +1.00062567J"},
        {"Smithsonian Astrophysical Observation", "SAO 79672"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.38387680),
        dec: Angle.Degrees(+25.98868808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105863"},
        {"Hipparcos Number", "HIP 59399"},
        {"Smithsonian Astrophysical Observation", "SAO 82169"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.78079097),
        dec: Angle.Degrees(+25.99019713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70045"},
        {"Geneva Identification System", "GEN# +0.02602553"},
        {"Smithsonian Astrophysical Observation", "SAO 83292"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.00407254),
        dec: Angle.Degrees(+25.99036831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22403"},
        {"Hipparcos Number", "HIP 16879"},
        {"Geneva Identification System", "GEN# +1.00022403"},
        {"Smithsonian Astrophysical Observation", "SAO 76031"},
        {"Wilson Evans Batten Catalogue", "WEB 3208"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.29534916),
        dec: Angle.Degrees(+25.99175641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 237.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -271.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29647"},
        {"Hipparcos Number", "HIP 21813"},
        {"Geneva Identification System", "GEN# +1.00029647"},
        {"Smithsonian Astrophysical Observation", "SAO 76704"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.28349004),
        dec: Angle.Degrees(+25.99278818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82192"},
        {"Hipparcos Number", "HIP 46702"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.80818870),
        dec: Angle.Degrees(+25.99512335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169386"},
        {"Hipparcos Number", "HIP 90116"},
        {"Smithsonian Astrophysical Observation", "SAO 85997"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.84707096),
        dec: Angle.Degrees(+25.99685636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145404"},
        {"Hipparcos Number", "HIP 79193"},
        {"Geneva Identification System", "GEN# +1.00145404"},
        {"Smithsonian Astrophysical Observation", "SAO 84221"},
        {"Wilson Evans Batten Catalogue", "WEB 13390"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.45031412),
        dec: Angle.Degrees(+25.99808616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116232"},
        {"Hipparcos Number", "HIP 65217"},
        {"Geneva Identification System", "GEN# +1.00116232"},
        {"Smithsonian Astrophysical Observation", "SAO 82799"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.48671470),
        dec: Angle.Degrees(+25.99814394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44452"},
        {"Hipparcos Number", "HIP 30346"},
        {"Smithsonian Astrophysical Observation", "SAO 78296"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.74766130),
        dec: Angle.Degrees(+25.99842729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223869"},
        {"Hipparcos Number", "HIP 117778"},
        {"Smithsonian Astrophysical Observation", "SAO 91557"},
        {"Wilson Evans Batten Catalogue", "WEB 20726"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.28026553),
        dec: Angle.Degrees(+25.99879308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85976"},
        {"Hipparcos Number", "HIP 48709"},
        {"Smithsonian Astrophysical Observation", "SAO 81090"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.02375341),
        dec: Angle.Degrees(+25.99936722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176006"},
        {"Hipparcos Number", "HIP 93023"},
        {"Smithsonian Astrophysical Observation", "SAO 86617"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.26234605),
        dec: Angle.Degrees(+25.99948221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107326"},
        {"Hipparcos Number", "HIP 60168"},
        {"Cincinnati Publication", "Ci 18 1545"},
        {"Geneva Identification System", "GEN# +5.21110070"},
        {"Smithsonian Astrophysical Observation", "SAO 82249"},
        {"Wilson Evans Batten Catalogue", "WEB 10697"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.07434995),
        dec: Angle.Degrees(+26.00182892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183774"},
        {"Hipparcos Number", "HIP 95885"},
        {"Smithsonian Astrophysical Observation", "SAO 87281"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.50926999),
        dec: Angle.Degrees(+26.00231761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106994"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.03769580),
        dec: Angle.Degrees(+26.00259944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100754"},
        {"Hipparcos Number", "HIP 56554"},
        {"Geneva Identification System", "GEN# +1.00100754"},
        {"Smithsonian Astrophysical Observation", "SAO 81888"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.93429798),
        dec: Angle.Degrees(+26.00313369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110557",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110557"},
        {"Smithsonian Astrophysical Observation", "SAO 90468"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.94494085),
        dec: Angle.Degrees(+26.00336167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83632"},
        {"Hipparcos Number", "HIP 47466"},
        {"Geneva Identification System", "GEN# +1.00083632"},
        {"Smithsonian Astrophysical Observation", "SAO 80962"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.14204320),
        dec: Angle.Degrees(+26.00399943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55705"},
        {"Hipparcos Number", "HIP 35066"},
        {"Smithsonian Astrophysical Observation", "SAO 79205"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.76458303),
        dec: Angle.Degrees(+26.00467070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215974"},
        {"Hipparcos Number", "HIP 112636"},
        {"Geneva Identification System", "GEN# +1.00215974"},
        {"Smithsonian Astrophysical Observation", "SAO 90802"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.18615107),
        dec: Angle.Degrees(+26.00523405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 149",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 149"},
        {"Cincinnati Publication", "Ci 20 1472"},
        {"Geneva Identification System", "GEN# +6.00117087"},
    },
    visualMagnitude: 11.26,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.47868501),
        dec: Angle.Degrees(+26.00557721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -309.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -628.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85504"},
        {"Smithsonian Astrophysical Observation", "SAO 85125"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.10704850),
        dec: Angle.Degrees(+26.00648894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48455",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Rasalas"},
        {"Henry Draper", "HD 85503"},
        {"Hipparcos Number", "HIP 48455"},
        {"Fundamental Katalog 5th Edition", "FK5 371"},
        {"Geneva Identification System", "GEN# +1.00085503"},
        {"Smithsonian Astrophysical Observation", "SAO 81064"},
        {"Wilson Evans Batten Catalogue", "WEB 9034"},
    },
    visualMagnitude: 3.88,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.19149028),
        dec: Angle.Degrees(+26.00708498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -216.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107131"},
        {"Hipparcos Number", "HIP 60066"},
        {"Geneva Identification System", "GEN# +5.21110060"},
        {"Renson", "Renson 31000"},
        {"Smithsonian Astrophysical Observation", "SAO 82237"},
        {"Wilson Evans Batten Catalogue", "WEB 10674"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.75846987),
        dec: Angle.Degrees(+26.00837126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142762"},
        {"Hipparcos Number", "HIP 77965"},
        {"Smithsonian Astrophysical Observation", "SAO 84077"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.83801856),
        dec: Angle.Degrees(+26.00887788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81161"},
        {"Smithsonian Astrophysical Observation", "SAO 84460"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.64618726),
        dec: Angle.Degrees(+26.00908567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218153"},
        {"Hipparcos Number", "HIP 114025"},
        {"Geneva Identification System", "GEN# +1.00218153"},
        {"Smithsonian Astrophysical Observation", "SAO 91000"},
        {"Wilson Evans Batten Catalogue", "WEB 20249"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.37182491),
        dec: Angle.Degrees(+26.00930048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178539"},
        {"Hipparcos Number", "HIP 93973"},
        {"Smithsonian Astrophysical Observation", "SAO 86850"},
        {"Wilson Evans Batten Catalogue", "WEB 16352"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.00734290),
        dec: Angle.Degrees(+26.01205468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35065",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35065"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.76353887),
        dec: Angle.Degrees(+26.01213410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79970"},
        {"Hipparcos Number", "HIP 45612"},
        {"Smithsonian Astrophysical Observation", "SAO 80746"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.46153135),
        dec: Angle.Degrees(+26.01258325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80547"},
        {"Hipparcos Number", "HIP 45873"},
        {"Geneva Identification System", "GEN# +1.00080547"},
        {"Smithsonian Astrophysical Observation", "SAO 80778"},
        {"Wilson Evans Batten Catalogue", "WEB 8699"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.31279878),
        dec: Angle.Degrees(+26.01316912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338466"},
        {"Hipparcos Number", "HIP 95851"},
        {"Geneva Identification System", "GEN# +1.00338466"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.41943501),
        dec: Angle.Degrees(+26.01333819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185416"},
        {"Hipparcos Number", "HIP 96574"},
        {"Geneva Identification System", "GEN# +1.00185416"},
        {"Smithsonian Astrophysical Observation", "SAO 87487"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.48920331),
        dec: Angle.Degrees(+26.01666058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147217"},
        {"Hipparcos Number", "HIP 79985"},
        {"Smithsonian Astrophysical Observation", "SAO 84302"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.89982705),
        dec: Angle.Degrees(+26.01704818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71923"},
        {"Hipparcos Number", "HIP 41760"},
        {"Smithsonian Astrophysical Observation", "SAO 80222"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.73342856),
        dec: Angle.Degrees(+26.02280623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65196"},
        {"Hipparcos Number", "HIP 38985"},
        {"Smithsonian Astrophysical Observation", "SAO 79829"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.66415867),
        dec: Angle.Degrees(+26.02349945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62857"},
        {"Hipparcos Number", "HIP 37971"},
        {"Smithsonian Astrophysical Observation", "SAO 79685"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.74382226),
        dec: Angle.Degrees(+26.02483304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174984"},
        {"Hipparcos Number", "HIP 92612"},
        {"Geneva Identification System", "GEN# +1.00174984"},
        {"Smithsonian Astrophysical Observation", "SAO 86526"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.06219484),
        dec: Angle.Degrees(+26.02637643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42891"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.11318320),
        dec: Angle.Degrees(+26.02820581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2890"},
        {"Hipparcos Number", "HIP 2546"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.09472020),
        dec: Angle.Degrees(+26.02943021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4602",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4602"},
    },
    visualMagnitude: 11.36,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.74748495),
        dec: Angle.Degrees(+26.03035041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97126"},
        {"Hipparcos Number", "HIP 54648"},
        {"Smithsonian Astrophysical Observation", "SAO 81710"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.78169314),
        dec: Angle.Degrees(+26.03091438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338907"},
        {"Hipparcos Number", "HIP 97220"},
        {"Smithsonian Astrophysical Observation", "SAO 87677"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.37759115),
        dec: Angle.Degrees(+26.03109746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79917"},
        {"Smithsonian Astrophysical Observation", "SAO 84297"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.68319210),
        dec: Angle.Degrees(+26.03150611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244252"},
        {"Hipparcos Number", "HIP 25792"},
        {"Smithsonian Astrophysical Observation", "SAO 77216"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.61308558),
        dec: Angle.Degrees(+26.03204067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149142"},
        {"Hipparcos Number", "HIP 80960"},
        {"Geneva Identification System", "GEN# +1.00149142"},
        {"Smithsonian Astrophysical Observation", "SAO 84432"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.97637120),
        dec: Angle.Degrees(+26.03206767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210748"},
        {"Hipparcos Number", "HIP 109589"},
        {"Smithsonian Astrophysical Observation", "SAO 90316"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.99852231),
        dec: Angle.Degrees(+26.03365176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151938"},
        {"Hipparcos Number", "HIP 82346"},
        {"Smithsonian Astrophysical Observation", "SAO 84625"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.38319405),
        dec: Angle.Degrees(+26.03489507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30168"},
        {"Hipparcos Number", "HIP 22172"},
        {"Geneva Identification System", "GEN# +1.00030168"},
        {"Smithsonian Astrophysical Observation", "SAO 76740"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.55025491),
        dec: Angle.Degrees(+26.03559017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
