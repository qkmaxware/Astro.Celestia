using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_79() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17009"},
        {"Smithsonian Astrophysical Observation", "SAO 76044"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.70444357),
        dec: Angle.Degrees(+20.39248305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133769"},
        {"Hipparcos Number", "HIP 73858"},
        {"Geneva Identification System", "GEN# +1.00133769"},
        {"Smithsonian Astrophysical Observation", "SAO 83654"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.41825875),
        dec: Angle.Degrees(+20.39315391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74587"},
        {"Hipparcos Number", "HIP 42966"},
        {"Smithsonian Astrophysical Observation", "SAO 80401"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.36782543),
        dec: Angle.Degrees(+20.39542252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136902"},
        {"Hipparcos Number", "HIP 75249"},
        {"Smithsonian Astrophysical Observation", "SAO 83796"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.64692573),
        dec: Angle.Degrees(+20.39692820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208122"},
        {"Hipparcos Number", "HIP 108063"},
        {"Smithsonian Astrophysical Observation", "SAO 90079"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.41247740),
        dec: Angle.Degrees(+20.39859545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84458",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84458"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.99669466),
        dec: Angle.Degrees(+20.40063368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186931"},
        {"Hipparcos Number", "HIP 97300"},
        {"Smithsonian Astrophysical Observation", "SAO 87697"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.62222467),
        dec: Angle.Degrees(+20.40093962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199266"},
        {"Hipparcos Number", "HIP 103288"},
        {"Smithsonian Astrophysical Observation", "SAO 89284"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.88801164),
        dec: Angle.Degrees(+20.40110775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130703"},
        {"Hipparcos Number", "HIP 72475"},
        {"Smithsonian Astrophysical Observation", "SAO 83544"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.28911214),
        dec: Angle.Degrees(+20.40130797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 352938"},
        {"Hipparcos Number", "HIP 102639"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.96841917),
        dec: Angle.Degrees(+20.40322361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89471"},
        {"Hipparcos Number", "HIP 50579"},
        {"Smithsonian Astrophysical Observation", "SAO 81296"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.97484324),
        dec: Angle.Degrees(+20.40424754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171233"},
        {"Hipparcos Number", "HIP 90925"},
        {"Smithsonian Astrophysical Observation", "SAO 86176"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.21150966),
        dec: Angle.Degrees(+20.40521916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64836"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.37024898),
        dec: Angle.Degrees(+20.40556676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101607"},
        {"Hipparcos Number", "HIP 57036"},
        {"Geneva Identification System", "GEN# +1.00101607"},
        {"Smithsonian Astrophysical Observation", "SAO 81945"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.41471811),
        dec: Angle.Degrees(+20.40584883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248330"},
        {"Hipparcos Number", "HIP 27638"},
        {"Smithsonian Astrophysical Observation", "SAO 77633"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.76015360),
        dec: Angle.Degrees(+20.40638266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41979"},
        {"Geneva Identification System", "GEN# +6.10070927"},
        {"Renson", "Renson 20050"},
    },
    visualMagnitude: 11.45,
    bvColour: -0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.33470139),
        dec: Angle.Degrees(+20.40691619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103110"},
        {"Hipparcos Number", "HIP 57898"},
        {"Geneva Identification System", "GEN# +1.00103110"},
        {"Smithsonian Astrophysical Observation", "SAO 82020"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.12911986),
        dec: Angle.Degrees(+20.40991792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96171",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12594 A"},
        {"Henry Draper", "HD 184360"},
        {"Henry Draper 2", "HD 184360A"},
        {"Hipparcos Number", "HIP 96171"},
        {"Geneva Identification System", "GEN# +1.00184360A"},
        {"Renson", "Renson 50860"},
        {"Smithsonian Astrophysical Observation", "SAO 87342"},
        {"Wilson Evans Batten Catalogue", "WEB 16851"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.32104699),
        dec: Angle.Degrees(+20.41401959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224626"},
        {"Hipparcos Number", "HIP 118275"},
        {"Geneva Identification System", "GEN# +1.00224626"},
        {"Smithsonian Astrophysical Observation", "SAO 91637"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.86260378),
        dec: Angle.Degrees(+20.41402701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7511"},
        {"Hipparcos Number", "HIP 5878"},
        {"Smithsonian Astrophysical Observation", "SAO 74591"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.86787059),
        dec: Angle.Degrees(+20.41460568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117182",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16970 AB"},
        {"Henry Draper", "HD 222978"},
        {"Hipparcos Number", "HIP 117182"},
        {"Smithsonian Astrophysical Observation", "SAO 91467"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.37212819),
        dec: Angle.Degrees(+20.41546633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114959"},
        {"Hipparcos Number", "HIP 64541"},
        {"Geneva Identification System", "GEN# +1.00114959"},
        {"Smithsonian Astrophysical Observation", "SAO 82729"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.43026779),
        dec: Angle.Degrees(+20.41627977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104154"},
        {"Smithsonian Astrophysical Observation", "SAO 89454"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.52212593),
        dec: Angle.Degrees(+20.41650927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32977"},
        {"Hipparcos Number", "HIP 23871"},
        {"Fundamental Katalog 5th Edition", "FK5 2383"},
        {"Geneva Identification System", "GEN# +1.00032977"},
        {"Smithsonian Astrophysical Observation", "SAO 76971"},
        {"Wilson Evans Batten Catalogue", "WEB 4655"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.95178565),
        dec: Angle.Degrees(+20.41845485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142899"},
        {"Hipparcos Number", "HIP 78067"},
        {"Geneva Identification System", "GEN# +1.00142899"},
        {"Smithsonian Astrophysical Observation", "SAO 84085"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.09497046),
        dec: Angle.Degrees(+20.41871357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99208"},
        {"Hipparcos Number", "HIP 55728"},
        {"Geneva Identification System", "GEN# +1.00099208"},
        {"Smithsonian Astrophysical Observation", "SAO 81812"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.27593162),
        dec: Angle.Degrees(+20.41933569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59977",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59977"},
        {"Smithsonian Astrophysical Observation", "SAO 82224"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.50424689),
        dec: Angle.Degrees(+20.42092386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45851"},
        {"Hipparcos Number", "HIP 31033"},
        {"Smithsonian Astrophysical Observation", "SAO 78453"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.66969699),
        dec: Angle.Degrees(+20.42150667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74214"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.48740716),
        dec: Angle.Degrees(+20.42384604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 350480"},
        {"Hipparcos Number", "HIP 97500"},
        {"Smithsonian Astrophysical Observation", "SAO 87757"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.26114836),
        dec: Angle.Degrees(+20.42519507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178330"},
        {"Hipparcos Number", "HIP 93916"},
        {"Cincinnati Publication", "Ci 18 2494"},
        {"Smithsonian Astrophysical Observation", "SAO 86832"},
        {"Wilson Evans Batten Catalogue", "WEB 16344"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.84933437),
        dec: Angle.Degrees(+20.42567868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78982"},
        {"Hipparcos Number", "HIP 45131"},
        {"Smithsonian Astrophysical Observation", "SAO 80684"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.93850224),
        dec: Angle.Degrees(+20.42745313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63673"},
        {"Hipparcos Number", "HIP 38308"},
        {"Smithsonian Astrophysical Observation", "SAO 79743"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.73293515),
        dec: Angle.Degrees(+20.42819926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37438"},
        {"Wilson Evans Batten Catalogue", "WEB 7404"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.28552259),
        dec: Angle.Degrees(+20.42900235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81322"},
        {"Smithsonian Astrophysical Observation", "SAO 84482"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.13818542),
        dec: Angle.Degrees(+20.42942382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71680"},
        {"Hipparcos Number", "HIP 41638"},
        {"Smithsonian Astrophysical Observation", "SAO 80208"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.36374592),
        dec: Angle.Degrees(+20.42971757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9186"},
        {"Smithsonian Astrophysical Observation", "SAO 75057"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.56825902),
        dec: Angle.Degrees(+20.43253174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116000"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.55184759),
        dec: Angle.Degrees(+20.43309345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71366",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71366"},
        {"Smithsonian Astrophysical Observation", "SAO 83422"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.93127828),
        dec: Angle.Degrees(+20.43351826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90471"},
        {"Hipparcos Number", "HIP 51155"},
        {"Geneva Identification System", "GEN# +1.00090471"},
        {"Smithsonian Astrophysical Observation", "SAO 81349"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.74353928),
        dec: Angle.Degrees(+20.43372892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3029"},
        {"Hipparcos Number", "HIP 2658"},
        {"Geneva Identification System", "GEN# +1.00003029"},
        {"Smithsonian Astrophysical Observation", "SAO 74098"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.41470747),
        dec: Angle.Degrees(+20.43379777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116965"},
        {"Smithsonian Astrophysical Observation", "SAO 91436"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.64925194),
        dec: Angle.Degrees(+20.43476383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109283"},
        {"Hipparcos Number", "HIP 61279"},
        {"Geneva Identification System", "GEN# +1.00109283"},
        {"Smithsonian Astrophysical Observation", "SAO 82376"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.36497734),
        dec: Angle.Degrees(+20.43497387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55197"},
        {"Smithsonian Astrophysical Observation", "SAO 81761"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.52722979),
        dec: Angle.Degrees(+20.43619228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245199"},
        {"Hipparcos Number", "HIP 26281"},
        {"Smithsonian Astrophysical Observation", "SAO 77296"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.94015277),
        dec: Angle.Degrees(+20.43783236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15844"},
        {"Hipparcos Number", "HIP 11897"},
        {"Geneva Identification System", "GEN# +1.00015844"},
        {"Smithsonian Astrophysical Observation", "SAO 75439"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.37262231),
        dec: Angle.Degrees(+20.43791971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123556"},
        {"Hipparcos Number", "HIP 69039"},
        {"Smithsonian Astrophysical Observation", "SAO 83184"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.98247461),
        dec: Angle.Degrees(+20.43876724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73610",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73610"},
        {"Smithsonian Astrophysical Observation", "SAO 83629"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.68850480),
        dec: Angle.Degrees(+20.44102994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72292"},
        {"Hipparcos Number", "HIP 41909"},
        {"Fundamental Katalog 5th Edition", "FK5 321"},
        {"Geneva Identification System", "GEN# +1.00072292"},
        {"Smithsonian Astrophysical Observation", "SAO 80243"},
        {"Wilson Evans Batten Catalogue", "WEB 8065"},
    },
    visualMagnitude: 5.33,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.17718645),
        dec: Angle.Degrees(+20.44127049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56508",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Formosa"},
        {"Henry Draper", "HD 100655"},
        {"Hipparcos Number", "HIP 56508"},
        {"Geneva Identification System", "GEN# +1.00100655"},
        {"Smithsonian Astrophysical Observation", "SAO 81886"},
        {"Wilson Evans Batten Catalogue", "WEB 10155"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.76579331),
        dec: Angle.Degrees(+20.44154823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54690"},
        {"Hipparcos Number", "HIP 34653"},
        {"Geneva Identification System", "GEN# +1.00054690"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.65543473),
        dec: Angle.Degrees(+20.44171814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -280.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35944"},
        {"Hipparcos Number", "HIP 25668"},
        {"Smithsonian Astrophysical Observation", "SAO 77196"},
        {"Wilson Evans Batten Catalogue", "WEB 4982"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.24171104),
        dec: Angle.Degrees(+20.44189213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43561"},
        {"Hipparcos Number", "HIP 29897"},
        {"Geneva Identification System", "GEN# +1.00043561"},
        {"Renson", "Renson 11570"},
        {"Smithsonian Astrophysical Observation", "SAO 78189"},
        {"Wilson Evans Batten Catalogue", "WEB 5919"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.42739962),
        dec: Angle.Degrees(+20.44191600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219292"},
        {"Hipparcos Number", "HIP 114734"},
        {"Smithsonian Astrophysical Observation", "SAO 91112"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.62714422),
        dec: Angle.Degrees(+20.44226965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168155"},
        {"Hipparcos Number", "HIP 89644"},
        {"Smithsonian Astrophysical Observation", "SAO 85899"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.41234221),
        dec: Angle.Degrees(+20.44296909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35699",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6016 A"},
        {"Henry Draper", "HD 57423"},
        {"Hipparcos Number", "HIP 35699"},
        {"Geneva Identification System", "GEN# +1.00057423"},
        {"Smithsonian Astrophysical Observation", "SAO 79328"},
        {"Wilson Evans Batten Catalogue", "WEB 7111"},
    },
    visualMagnitude: 5.09,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.48708081),
        dec: Angle.Degrees(+20.44371648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39006"},
        {"Hipparcos Number", "HIP 27585"},
        {"Smithsonian Astrophysical Observation", "SAO 77618"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.62366763),
        dec: Angle.Degrees(+20.44419294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51749"},
        {"Hipparcos Number", "HIP 33647"},
        {"Fundamental Katalog 5th Edition", "FK5 4631"},
        {"Geneva Identification System", "GEN# +1.00051749"},
        {"Smithsonian Astrophysical Observation", "SAO 78950"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.84523905),
        dec: Angle.Degrees(+20.44490733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 351960"},
        {"Hipparcos Number", "HIP 100243"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.96335681),
        dec: Angle.Degrees(+20.44670860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39260",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39260"},
        {"Smithsonian Astrophysical Observation", "SAO 79871"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.42641427),
        dec: Angle.Degrees(+20.44724395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46292"},
        {"Smithsonian Astrophysical Observation", "SAO 80834"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.60583152),
        dec: Angle.Degrees(+20.44801828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4203"},
        {"Hipparcos Number", "HIP 3502"},
        {"Geneva Identification System", "GEN# +1.00004203"},
        {"Smithsonian Astrophysical Observation", "SAO 74235"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.17135034),
        dec: Angle.Degrees(+20.44922868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284402"},
        {"Hipparcos Number", "HIP 20488"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)23, 27.3300),
        dec: Angle.DegreesMinutesSeconds((int)+20, (int)27, 01.600)
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
    primaryId: "HIP 90176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169490"},
        {"Hipparcos Number", "HIP 90176"},
        {"Geneva Identification System", "GEN# +1.00169490"},
        {"Smithsonian Astrophysical Observation", "SAO 86007"},
        {"Wilson Evans Batten Catalogue", "WEB 15419"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.02343846),
        dec: Angle.Degrees(+20.45225064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7966",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7966"},
        {"Smithsonian Astrophysical Observation", "SAO 74882"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.58680423),
        dec: Angle.Degrees(+20.45303368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56203",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56203"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.82929583),
        dec: Angle.Degrees(+20.45387767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156584"},
        {"Hipparcos Number", "HIP 84604"},
        {"Smithsonian Astrophysical Observation", "SAO 84981"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.41184958),
        dec: Angle.Degrees(+20.45656194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65418"},
        {"Geneva Identification System", "GEN# +9.80063026"},
    },
    visualMagnitude: 12.18,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.12774634),
        dec: Angle.Degrees(+20.45663151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164215"},
        {"Hipparcos Number", "HIP 88076"},
        {"Smithsonian Astrophysical Observation", "SAO 85607"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.82153476),
        dec: Angle.Degrees(+20.45711148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169574"},
        {"Hipparcos Number", "HIP 90222"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.13455779),
        dec: Angle.Degrees(+20.45927978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47377",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47377"},
        {"Smithsonian Astrophysical Observation", "SAO 80955"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.78874502),
        dec: Angle.Degrees(+20.45993228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78764"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.20759756),
        dec: Angle.Degrees(+20.46240046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207563"},
        {"Hipparcos Number", "HIP 107734"},
        {"Fundamental Katalog 5th Edition", "FK5 3744"},
        {"Geneva Identification System", "GEN# +1.00207563"},
        {"Smithsonian Astrophysical Observation", "SAO 90027"},
        {"Wilson Evans Batten Catalogue", "WEB 19430"},
    },
    visualMagnitude: 6.27,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.36194087),
        dec: Angle.Degrees(+20.46244382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116718"},
        {"Smithsonian Astrophysical Observation", "SAO 91402"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.81329871),
        dec: Angle.Degrees(+20.46298129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209345"},
        {"Hipparcos Number", "HIP 108791"},
        {"Renson", "Renson 58250"},
        {"Smithsonian Astrophysical Observation", "SAO 90185"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.57595040),
        dec: Angle.Degrees(+20.46395922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193325"},
        {"Hipparcos Number", "HIP 100160"},
        {"Geneva Identification System", "GEN# +1.00193325"},
        {"Renson", "Renson 53960"},
        {"Smithsonian Astrophysical Observation", "SAO 88504"},
        {"Wilson Evans Batten Catalogue", "WEB 18041"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.75398201),
        dec: Angle.Degrees(+20.46416504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52958"},
        {"Geneva Identification System", "GEN# +0.02102244"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.47000698),
        dec: Angle.Degrees(+20.49184471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -239.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16143",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2546 AB"},
        {"Henry Draper", "HD 21437"},
        {"Hipparcos Number", "HIP 16143"},
        {"Renson", "Renson 5350"},
        {"Smithsonian Astrophysical Observation", "SAO 75940"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.00582031),
        dec: Angle.Degrees(+20.46427262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119411"},
        {"Hipparcos Number", "HIP 66915"},
        {"Geneva Identification System", "GEN# +1.00119411"},
        {"Smithsonian Astrophysical Observation", "SAO 82959"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.70420256),
        dec: Angle.Degrees(+20.46481102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56913"},
        {"Hipparcos Number", "HIP 35510"},
        {"Smithsonian Astrophysical Observation", "SAO 79288"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.95141359),
        dec: Angle.Degrees(+20.46512605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61645",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61645"},
        {"Geneva Identification System", "GEN# +0.02102437"},
        {"Smithsonian Astrophysical Observation", "SAO 82409"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.56498412),
        dec: Angle.Degrees(+20.46553458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137807"},
        {"Hipparcos Number", "HIP 75660"},
        {"Smithsonian Astrophysical Observation", "SAO 83829"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.87107160),
        dec: Angle.Degrees(+20.46621795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51353"},
        {"Hipparcos Number", "HIP 33496"},
        {"Smithsonian Astrophysical Observation", "SAO 78915"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.44173308),
        dec: Angle.Degrees(+20.46642196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171487"},
        {"Hipparcos Number", "HIP 91041"},
        {"Fundamental Katalog 5th Edition", "FK5 3476"},
        {"Geneva Identification System", "GEN# +1.00171487"},
        {"Smithsonian Astrophysical Observation", "SAO 86203"},
        {"Wilson Evans Batten Catalogue", "WEB 15623"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.58152725),
        dec: Angle.Degrees(+20.46642488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8388"},
        {"Hipparcos Number", "HIP 6492"},
        {"Geneva Identification System", "GEN# +1.00008388"},
        {"Smithsonian Astrophysical Observation", "SAO 74682"},
        {"Wilson Evans Batten Catalogue", "WEB 1431"},
    },
    visualMagnitude: 5.97,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.85396862),
        dec: Angle.Degrees(+20.46898990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123844"},
        {"Hipparcos Number", "HIP 69171"},
        {"Geneva Identification System", "GEN# +1.00123844"},
        {"Smithsonian Astrophysical Observation", "SAO 83196"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.38182344),
        dec: Angle.Degrees(+20.47173654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119768"},
        {"Hipparcos Number", "HIP 67076"},
        {"Geneva Identification System", "GEN# +1.00119768"},
        {"Smithsonian Astrophysical Observation", "SAO 82980"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.21447205),
        dec: Angle.Degrees(+20.47233870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36589"},
        {"Hipparcos Number", "HIP 26072"},
        {"Celescope Catalog", "CEL 783"},
        {"Geneva Identification System", "GEN# +1.00036589"},
        {"Renson", "Renson 9520"},
        {"Smithsonian Astrophysical Observation", "SAO 77255"},
        {"Wilson Evans Batten Catalogue", "WEB 5074"},
    },
    visualMagnitude: 6.19,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.41181839),
        dec: Angle.Degrees(+20.47423451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198568"},
        {"Hipparcos Number", "HIP 102889"},
        {"Smithsonian Astrophysical Observation", "SAO 89199"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.67283453),
        dec: Angle.Degrees(+20.47557502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349495"},
        {"Hipparcos Number", "HIP 92752"},
        {"Smithsonian Astrophysical Observation", "SAO 86555"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.51642756),
        dec: Angle.Degrees(+20.47594694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194841"},
        {"Hipparcos Number", "HIP 100876"},
        {"Smithsonian Astrophysical Observation", "SAO 88693"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.80912244),
        dec: Angle.Degrees(+20.47650539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42628",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6930 AB"},
        {"Henry Draper", "HD 73871"},
        {"Hipparcos Number", "HIP 42628"},
        {"Smithsonian Astrophysical Observation", "SAO 80354"},
        {"Wilson Evans Batten Catalogue", "WEB 8232"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.31379013),
        dec: Angle.Degrees(+20.47690205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185859"},
        {"Hipparcos Number", "HIP 96789"},
        {"Geneva Identification System", "GEN# +1.00185859"},
        {"Smithsonian Astrophysical Observation", "SAO 87542"},
        {"Wilson Evans Batten Catalogue", "WEB 16979"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.11801947),
        dec: Angle.Degrees(+20.47708907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169954"},
        {"Hipparcos Number", "HIP 90363"},
        {"Smithsonian Astrophysical Observation", "SAO 86045"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.58640210),
        dec: Angle.Degrees(+20.47841097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148897"},
        {"Hipparcos Number", "HIP 80843"},
        {"Geneva Identification System", "GEN# +1.00148897"},
        {"Smithsonian Astrophysical Observation", "SAO 84416"},
        {"Wilson Evans Batten Catalogue", "WEB 13673"},
    },
    visualMagnitude: 5.24,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.64001746),
        dec: Angle.Degrees(+20.47934589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9034"},
        {"Hipparcos Number", "HIP 6937"},
        {"Smithsonian Astrophysical Observation", "SAO 74748"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.34561494),
        dec: Angle.Degrees(+20.48168739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96395"},
        {"Hipparcos Number", "HIP 54338"},
        {"Smithsonian Astrophysical Observation", "SAO 81672"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.73064879),
        dec: Angle.Degrees(+20.48351506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81058"},
        {"Smithsonian Astrophysical Observation", "SAO 84450"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.33036984),
        dec: Angle.Degrees(+20.48396430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113109"},
        {"Smithsonian Astrophysical Observation", "SAO 90868"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.58672441),
        dec: Angle.Degrees(+20.48667900)
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
    primaryId: "HIP 99421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191721"},
        {"Hipparcos Number", "HIP 99421"},
        {"Smithsonian Astrophysical Observation", "SAO 88299"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.68812006),
        dec: Angle.Degrees(+20.48686322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73142"},
        {"Hipparcos Number", "HIP 42298"},
        {"Geneva Identification System", "GEN# +1.00073142"},
        {"Smithsonian Astrophysical Observation", "SAO 80294"},
        {"Wilson Evans Batten Catalogue", "WEB 8124"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.36008065),
        dec: Angle.Degrees(+20.48709095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60755"},
        {"Hipparcos Number", "HIP 37054"},
        {"Geneva Identification System", "GEN# +1.00060755"},
        {"Smithsonian Astrophysical Observation", "SAO 79546"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.22624031),
        dec: Angle.Degrees(+20.48727375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14609"},
        {"Hipparcos Number", "HIP 11032"},
        {"Smithsonian Astrophysical Observation", "SAO 75309"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.52060432),
        dec: Angle.Degrees(+20.48736935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42088"},
        {"Hipparcos Number", "HIP 29216"},
        {"Celescope Catalog", "CEL 1093"},
        {"Geneva Identification System", "GEN# +1.00042088"},
        {"Smithsonian Astrophysical Observation", "SAO 78049"},
        {"Wilson Evans Batten Catalogue", "WEB 5731"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.41488553),
        dec: Angle.Degrees(+20.48763137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84497"},
        {"Hipparcos Number", "HIP 47946"},
        {"Geneva Identification System", "GEN# +1.00084497"},
        {"Smithsonian Astrophysical Observation", "SAO 81009"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.55519168),
        dec: Angle.Degrees(+20.48918173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197703"},
        {"Hipparcos Number", "HIP 102384"},
        {"Fundamental Katalog 5th Edition", "FK5 5827"},
        {"Geneva Identification System", "GEN# +1.00197703"},
        {"Smithsonian Astrophysical Observation", "SAO 89079"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.19500049),
        dec: Angle.Degrees(+20.48981012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58016"},
        {"Geneva Identification System", "GEN# +0.02102373"},
        {"Smithsonian Astrophysical Observation", "SAO 82039"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.49496842),
        dec: Angle.Degrees(+20.49001228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129536"},
        {"Hipparcos Number", "HIP 71921"},
        {"Smithsonian Astrophysical Observation", "SAO 83477"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.64813290),
        dec: Angle.Degrees(+20.49159341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59430"},
        {"Hipparcos Number", "HIP 36506"},
        {"Smithsonian Astrophysical Observation", "SAO 79451"},
        {"Wilson Evans Batten Catalogue", "WEB 7259"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.66221330),
        dec: Angle.Degrees(+20.49161625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146538"},
        {"Hipparcos Number", "HIP 79707"},
        {"Smithsonian Astrophysical Observation", "SAO 84270"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.01552945),
        dec: Angle.Degrees(+20.49256633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59078",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8425 AB"},
        {"Henry Draper", "HD 105217"},
        {"Hipparcos Number", "HIP 59078"},
        {"Fundamental Katalog 5th Edition", "FK5 5070"},
        {"Geneva Identification System", "GEN# +1.00105217J"},
        {"Smithsonian Astrophysical Observation", "SAO 82140"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.73203569),
        dec: Angle.Degrees(+20.49293416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82808",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82808"},
        {"Smithsonian Astrophysical Observation", "SAO 84696"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.85414671),
        dec: Angle.Degrees(+20.49444820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58246"},
        {"Hipparcos Number", "HIP 36035"},
        {"Geneva Identification System", "GEN# +1.00058246"},
        {"Wilson Evans Batten Catalogue", "WEB 7176"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.39706638),
        dec: Angle.Degrees(+20.49519778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45394"},
        {"Hipparcos Number", "HIP 30769"},
        {"Geneva Identification System", "GEN# +1.00045394"},
        {"Smithsonian Astrophysical Observation", "SAO 78402"},
        {"Wilson Evans Batten Catalogue", "WEB 6134"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.98620696),
        dec: Angle.Degrees(+20.49628855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172397"},
        {"Hipparcos Number", "HIP 91462"},
        {"Geneva Identification System", "GEN# +1.00172397"},
        {"Smithsonian Astrophysical Observation", "SAO 86287"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.81195440),
        dec: Angle.Degrees(+20.49759900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13229"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.57730112),
        dec: Angle.Degrees(+20.49840995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5667"},
        {"Smithsonian Astrophysical Observation", "SAO 74558"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.20001535),
        dec: Angle.Degrees(+20.50148483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109548",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109548"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.84990966),
        dec: Angle.Degrees(+20.50194802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7550"},
        {"Hipparcos Number", "HIP 5906"},
        {"Geneva Identification System", "GEN# +1.00007550"},
        {"Smithsonian Astrophysical Observation", "SAO 74592"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.97173139),
        dec: Angle.Degrees(+20.50229336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102617"},
        {"Hipparcos Number", "HIP 57620"},
        {"Geneva Identification System", "GEN# +1.00102617"},
        {"Smithsonian Astrophysical Observation", "SAO 82003"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.21620623),
        dec: Angle.Degrees(+20.50486732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202799"},
        {"Hipparcos Number", "HIP 105128"},
        {"Smithsonian Astrophysical Observation", "SAO 89587"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.42812730),
        dec: Angle.Degrees(+20.50538050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20716"},
        {"Hipparcos Number", "HIP 15597"},
        {"Smithsonian Astrophysical Observation", "SAO 75883"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.21441502),
        dec: Angle.Degrees(+20.50948591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78050"},
        {"Hipparcos Number", "HIP 44716"},
        {"Geneva Identification System", "GEN# +1.00078050"},
        {"Smithsonian Astrophysical Observation", "SAO 80634"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.67906251),
        dec: Angle.Degrees(+20.51031551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179584"},
        {"Hipparcos Number", "HIP 94362"},
        {"Smithsonian Astrophysical Observation", "SAO 86926"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.09493981),
        dec: Angle.Degrees(+20.51240448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195052"},
        {"Hipparcos Number", "HIP 100976"},
        {"Geneva Identification System", "GEN# +1.00195052"},
        {"Smithsonian Astrophysical Observation", "SAO 88715"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.09962823),
        dec: Angle.Degrees(+20.51248124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284337"},
        {"Hipparcos Number", "HIP 19997"},
        {"Smithsonian Astrophysical Observation", "SAO 76533"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.33070015),
        dec: Angle.Degrees(+20.51258343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11285"},
        {"Hipparcos Number", "HIP 8619"},
        {"Geneva Identification System", "GEN# +1.00011285"},
        {"Smithsonian Astrophysical Observation", "SAO 74983"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.78939433),
        dec: Angle.Degrees(+20.51441898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69940"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.69073362),
        dec: Angle.Degrees(+20.51555282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33154"},
        {"Hipparcos Number", "HIP 23963"},
        {"Geneva Identification System", "GEN# +1.00033154"},
        {"Smithsonian Astrophysical Observation", "SAO 76982"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.26409963),
        dec: Angle.Degrees(+20.51560198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55649"},
        {"Hipparcos Number", "HIP 35011"},
        {"Smithsonian Astrophysical Observation", "SAO 79197"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.64180637),
        dec: Angle.Degrees(+20.51690016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53872"},
        {"Hipparcos Number", "HIP 34369"},
        {"Smithsonian Astrophysical Observation", "SAO 79078"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.85863027),
        dec: Angle.Degrees(+20.51704610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99419"},
        {"Hipparcos Number", "HIP 55823"},
        {"Geneva Identification System", "GEN# +1.00099419"},
        {"Smithsonian Astrophysical Observation", "SAO 81825"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.61355592),
        dec: Angle.Degrees(+20.51827273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190844"},
        {"Hipparcos Number", "HIP 99028"},
        {"Geneva Identification System", "GEN# +1.00190844"},
        {"Smithsonian Astrophysical Observation", "SAO 88191"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.56082678),
        dec: Angle.Degrees(+20.51904271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126010"},
        {"Hipparcos Number", "HIP 70260"},
        {"Smithsonian Astrophysical Observation", "SAO 83314"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.64275643),
        dec: Angle.Degrees(+20.52311647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54872",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Zosma"},
        {"Henry Draper", "HD 97603"},
        {"Hipparcos Number", "HIP 54872"},
        {"Fundamental Katalog 5th Edition", "FK5 422"},
        {"Geneva Identification System", "GEN# +1.00097603"},
        {"Smithsonian Astrophysical Observation", "SAO 81727"},
        {"Wilson Evans Batten Catalogue", "WEB 9902"},
    },
    visualMagnitude: 2.56,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.52671705),
        dec: Angle.Degrees(+20.52403384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106684"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.13454954),
        dec: Angle.Degrees(+20.52828893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131914"},
        {"Hipparcos Number", "HIP 73060"},
        {"Smithsonian Astrophysical Observation", "SAO 83583"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.95568515),
        dec: Angle.Degrees(+20.52995048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349993"},
        {"Hipparcos Number", "HIP 95389"},
        {"Geneva Identification System", "GEN# +1.00349993"},
        {"Smithsonian Astrophysical Observation", "SAO 87157"},
        {"Wilson Evans Batten Catalogue", "WEB 16674"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.07556682),
        dec: Angle.Degrees(+20.53087140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81831"},
        {"Smithsonian Astrophysical Observation", "SAO 84554"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.72210545),
        dec: Angle.Degrees(+20.53170992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -245.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94371"},
        {"Hipparcos Number", "HIP 53287"},
        {"Smithsonian Astrophysical Observation", "SAO 81569"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.47447623),
        dec: Angle.Degrees(+20.53330681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62686",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8680 AB"},
        {"Hipparcos Number", "HIP 62686"},
        {"Geneva Identification System", "GEN# +0.02102462"},
        {"Smithsonian Astrophysical Observation", "SAO 82529"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.67475972),
        dec: Angle.Degrees(+20.53480866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191259"},
        {"Hipparcos Number", "HIP 99199"},
        {"Geneva Identification System", "GEN# +1.00191259"},
        {"Smithsonian Astrophysical Observation", "SAO 88229"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.08248403),
        dec: Angle.Degrees(+20.53616427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68437"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.16118741),
        dec: Angle.Degrees(+20.53672630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53678",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53678"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.74530425),
        dec: Angle.Degrees(+20.53706367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158611"},
        {"Hipparcos Number", "HIP 85602"},
        {"Smithsonian Astrophysical Observation", "SAO 85140"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.38158419),
        dec: Angle.Degrees(+20.53983828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98255",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13177 AB"},
        {"Henry Draper", "HD 350851"},
        {"Hipparcos Number", "HIP 98255"},
        {"Smithsonian Astrophysical Observation", "SAO 87985"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.48652328),
        dec: Angle.Degrees(+20.54088571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106057"},
        {"Hipparcos Number", "HIP 59501"},
        {"Fundamental Katalog 5th Edition", "FK5 2977"},
        {"Geneva Identification System", "GEN# +1.00106057"},
        {"Smithsonian Astrophysical Observation", "SAO 82182"},
        {"Wilson Evans Batten Catalogue", "WEB 10579"},
    },
    visualMagnitude: 5.60,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.03874666),
        dec: Angle.Degrees(+20.54210573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63729",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63729"},
        {"Geneva Identification System", "GEN# +0.02102483"},
        {"Smithsonian Astrophysical Observation", "SAO 82629"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.90186416),
        dec: Angle.Degrees(+20.54221303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60038"},
        {"Geneva Identification System", "GEN# +0.02102408"},
        {"Smithsonian Astrophysical Observation", "SAO 82231"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.68447069),
        dec: Angle.Degrees(+20.54342766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5693"},
        {"Hipparcos Number", "HIP 4596"},
        {"Smithsonian Astrophysical Observation", "SAO 74414"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.71196990),
        dec: Angle.Degrees(+20.54382031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80328"},
        {"Hipparcos Number", "HIP 45747"},
        {"Smithsonian Astrophysical Observation", "SAO 80764"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.91446843),
        dec: Angle.Degrees(+20.54654064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92043",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11658 A"},
        {"Henry Draper", "HD 173667"},
        {"Hipparcos Number", "HIP 92043"},
        {"Fundamental Katalog 5th Edition", "FK5 703"},
        {"Geneva Identification System", "GEN# +1.00173667A"},
        {"Smithsonian Astrophysical Observation", "SAO 86406"},
        {"Wilson Evans Batten Catalogue", "WEB 15864"},
    },
    visualMagnitude: 4.19,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.41554660),
        dec: Angle.Degrees(+20.54712356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -335.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44072"},
        {"Cincinnati Publication", "Ci 20 500"},
        {"Geneva Identification System", "GEN# +0.02101949"},
        {"Smithsonian Astrophysical Observation", "SAO 80545"},
        {"Wilson Evans Batten Catalogue", "WEB 8469"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.65738199),
        dec: Angle.Degrees(+20.54716860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 657.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284514"},
        {"Hipparcos Number", "HIP 21019"},
        {"Geneva Identification System", "GEN# +1.00284514"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.61081385),
        dec: Angle.Degrees(+20.54786498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29561"},
        {"Hipparcos Number", "HIP 21748"},
        {"Smithsonian Astrophysical Observation", "SAO 76696"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.04007022),
        dec: Angle.Degrees(+20.54827865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192837"},
        {"Hipparcos Number", "HIP 99914"},
        {"Smithsonian Astrophysical Observation", "SAO 88432"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.08315792),
        dec: Angle.Degrees(+20.55048389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36113"},
        {"Hipparcos Number", "HIP 25777"},
        {"Celescope Catalog", "CEL 736"},
        {"Geneva Identification System", "GEN# +1.00036113"},
        {"Smithsonian Astrophysical Observation", "SAO 77215"},
        {"Wilson Evans Batten Catalogue", "WEB 5008"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.56277625),
        dec: Angle.Degrees(+20.55163639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160272"},
        {"Hipparcos Number", "HIP 86319"},
        {"Geneva Identification System", "GEN# +1.00160272"},
        {"Smithsonian Astrophysical Observation", "SAO 85268"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.55998084),
        dec: Angle.Degrees(+20.55239226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18025"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.78364244),
        dec: Angle.Degrees(+20.55295277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74879",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74879"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.54689938),
        dec: Angle.Degrees(+20.55307701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92558"},
        {"Hipparcos Number", "HIP 52317"},
        {"Smithsonian Astrophysical Observation", "SAO 81472"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.35492791),
        dec: Angle.Degrees(+20.55317704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77515"},
        {"Hipparcos Number", "HIP 44467"},
        {"Smithsonian Astrophysical Observation", "SAO 80604"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.89717539),
        dec: Angle.Degrees(+20.55455695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57674"},
        {"Hipparcos Number", "HIP 35801"},
        {"Geneva Identification System", "GEN# +1.00057674"},
        {"Smithsonian Astrophysical Observation", "SAO 79343"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.76539458),
        dec: Angle.Degrees(+20.55544784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236"},
        {"Hipparcos Number", "HIP 598"},
        {"Smithsonian Astrophysical Observation", "SAO 73752"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.81025436),
        dec: Angle.Degrees(+20.55571109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80086",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80086"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.19103904),
        dec: Angle.Degrees(+20.55881609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 130.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115417",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16713 AB"},
        {"Henry Draper", "HD 220334"},
        {"Hipparcos Number", "HIP 115417"},
        {"Geneva Identification System", "GEN# +1.00220334J"},
        {"Smithsonian Astrophysical Observation", "SAO 91222"},
        {"Wilson Evans Batten Catalogue", "WEB 20437"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.70198590),
        dec: Angle.Degrees(+20.55897253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 314.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196"},
        {"Hipparcos Number", "HIP 562"},
        {"Geneva Identification System", "GEN# +1.00000196"},
        {"Smithsonian Astrophysical Observation", "SAO 73749"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.71097517),
        dec: Angle.Degrees(+20.55974087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180739"},
        {"Hipparcos Number", "HIP 94759"},
        {"Smithsonian Astrophysical Observation", "SAO 87022"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.21933316),
        dec: Angle.Degrees(+20.56120189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6468",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6468"},
        {"Smithsonian Astrophysical Observation", "SAO 74676"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.80322445),
        dec: Angle.Degrees(+20.56181864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6665"},
        {"Hipparcos Number", "HIP 5285"},
        {"Geneva Identification System", "GEN# +1.00006665"},
        {"Smithsonian Astrophysical Observation", "SAO 74503"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.90170996),
        dec: Angle.Degrees(+20.56206728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114505"},
    },
    visualMagnitude: 10.64,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.86854172),
        dec: Angle.Degrees(+20.56206792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50524",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7721 AB"},
        {"Henry Draper", "HD 89376"},
        {"Hipparcos Number", "HIP 50524"},
        {"Smithsonian Astrophysical Observation", "SAO 81288"},
        {"Wilson Evans Batten Catalogue", "WEB 9270"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.79476016),
        dec: Angle.Degrees(+20.56340412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49366"},
        {"Hipparcos Number", "HIP 32676"},
        {"Smithsonian Astrophysical Observation", "SAO 78769"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.23830859),
        dec: Angle.Degrees(+20.56389352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162076"},
        {"Hipparcos Number", "HIP 87158"},
        {"Fundamental Katalog 5th Edition", "FK5 1465"},
        {"Geneva Identification System", "GEN# +1.00162076"},
        {"Smithsonian Astrophysical Observation", "SAO 85429"},
        {"Wilson Evans Batten Catalogue", "WEB 14703"},
    },
    visualMagnitude: 5.69,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.10313561),
        dec: Angle.Degrees(+20.56542749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252924"},
        {"Hipparcos Number", "HIP 29354"},
        {"Geneva Identification System", "GEN# +1.00252924"},
        {"Smithsonian Astrophysical Observation", "SAO 78073"},
        {"Wilson Evans Batten Catalogue", "WEB 5765"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.81315662),
        dec: Angle.Degrees(+20.56572464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18019"},
        {"Hipparcos Number", "HIP 13532"},
        {"Smithsonian Astrophysical Observation", "SAO 75627"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.57317314),
        dec: Angle.Degrees(+20.56583503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182335"},
        {"Hipparcos Number", "HIP 95309"},
        {"Geneva Identification System", "GEN# +1.00182335"},
        {"Smithsonian Astrophysical Observation", "SAO 87145"},
        {"Wilson Evans Batten Catalogue", "WEB 16656"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.85283177),
        dec: Angle.Degrees(+20.56923352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33400"},
        {"Hipparcos Number", "HIP 24116"},
        {"Geneva Identification System", "GEN# +1.00033400"},
        {"Smithsonian Astrophysical Observation", "SAO 77012"},
        {"Wilson Evans Batten Catalogue", "WEB 4690"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.69794717),
        dec: Angle.Degrees(+20.56923773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222177"},
        {"Hipparcos Number", "HIP 116636"},
        {"Geneva Identification System", "GEN# +1.00222177"},
        {"Smithsonian Astrophysical Observation", "SAO 91392"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.54184414),
        dec: Angle.Degrees(+20.56926877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41083"},
        {"Smithsonian Astrophysical Observation", "SAO 80141"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.73559093),
        dec: Angle.Degrees(+20.56943972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34088",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Mekbuda"},
        {"Aitken", "ADS 5742 A"},
        {"Henry Draper", "HD 52973"},
        {"Hipparcos Number", "HIP 34088"},
        {"Fundamental Katalog 5th Edition", "FK5 269"},
        {"Geneva Identification System", "GEN# +1.00052973A"},
        {"Smithsonian Astrophysical Observation", "SAO 79031"},
        {"Wilson Evans Batten Catalogue", "WEB 6834"},
    },
    visualMagnitude: 4.01,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.02723079),
        dec: Angle.Degrees(+20.57029939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136138"},
        {"Hipparcos Number", "HIP 74896"},
        {"Fundamental Katalog 5th Edition", "FK5 1400"},
        {"Geneva Identification System", "GEN# +1.00136138"},
        {"Smithsonian Astrophysical Observation", "SAO 83755"},
        {"Wilson Evans Batten Catalogue", "WEB 12773"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.60214092),
        dec: Angle.Degrees(+20.57280967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152307"},
        {"Hipparcos Number", "HIP 82505"},
        {"Smithsonian Astrophysical Observation", "SAO 84650"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.93932826),
        dec: Angle.Degrees(+20.57398656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135403"},
        {"Hipparcos Number", "HIP 74577"},
        {"Smithsonian Astrophysical Observation", "SAO 83725"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.56926558),
        dec: Angle.Degrees(+20.57486952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16302"},
        {"Hipparcos Number", "HIP 12238"},
        {"Geneva Identification System", "GEN# +1.00016302"},
        {"Smithsonian Astrophysical Observation", "SAO 75476"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.39310593),
        dec: Angle.Degrees(+20.57494662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79911"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.66360114),
        dec: Angle.Degrees(+20.57659824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187690"},
        {"Hipparcos Number", "HIP 97628"},
        {"Smithsonian Astrophysical Observation", "SAO 87799"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.63851157),
        dec: Angle.Degrees(+20.57746455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27045"},
        {"Hipparcos Number", "HIP 19990"},
        {"Celescope Catalog", "CEL 378"},
        {"Geneva Identification System", "GEN# +1.00027045"},
        {"Renson", "Renson 6910"},
        {"Smithsonian Astrophysical Observation", "SAO 76532"},
        {"Wilson Evans Batten Catalogue", "WEB 3815"},
    },
    visualMagnitude: 4.93,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.31535896),
        dec: Angle.Degrees(+20.57874033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5774"},
        {"Smithsonian Astrophysical Observation", "SAO 74579"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.52316161),
        dec: Angle.Degrees(+20.57889862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109966",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109966"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.08231906),
        dec: Angle.Degrees(+20.57892233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35188"},
        {"Hipparcos Number", "HIP 25230"},
        {"Smithsonian Astrophysical Observation", "SAO 77141"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.94053443),
        dec: Angle.Degrees(+20.57928447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113269"},
        {"Hipparcos Number", "HIP 63624"},
        {"Geneva Identification System", "GEN# +1.00113269"},
        {"Smithsonian Astrophysical Observation", "SAO 82616"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.59648521),
        dec: Angle.Degrees(+20.57955972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43837"},
        {"Hipparcos Number", "HIP 30041"},
        {"Geneva Identification System", "GEN# +1.00043837"},
        {"Smithsonian Astrophysical Observation", "SAO 78223"},
        {"Wilson Evans Batten Catalogue", "WEB 5966"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.82032864),
        dec: Angle.Degrees(+20.57993237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221876"},
        {"Hipparcos Number", "HIP 116441"},
        {"Cincinnati Publication", "Ci 18 3095"},
        {"Geneva Identification System", "GEN# +1.00221876"},
        {"Smithsonian Astrophysical Observation", "SAO 91366"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.92759217),
        dec: Angle.Degrees(+20.58093499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93362"},
        {"Hipparcos Number", "HIP 52747"},
        {"Smithsonian Astrophysical Observation", "SAO 81515"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.75986664),
        dec: Angle.Degrees(+20.58144350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116054",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116054"},
        {"Smithsonian Astrophysical Observation", "SAO 91312"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.73005989),
        dec: Angle.Degrees(+20.58156956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114183",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16520 A"},
        {"Henry Draper", "HD 218381"},
        {"Hipparcos Number", "HIP 114183"},
        {"Smithsonian Astrophysical Observation", "SAO 91021"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.85631821),
        dec: Angle.Degrees(+20.58170927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194631"},
        {"Hipparcos Number", "HIP 100780"},
        {"Smithsonian Astrophysical Observation", "SAO 88671"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.50509241),
        dec: Angle.Degrees(+20.58220883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4061"},
        {"Geneva Identification System", "GEN# +9.80069027"},
    },
    visualMagnitude: 11.53,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.99979758),
        dec: Angle.Degrees(+20.58313129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35395"},
        {"Hipparcos Number", "HIP 25337"},
        {"Geneva Identification System", "GEN# +1.00035395"},
        {"Smithsonian Astrophysical Observation", "SAO 77157"},
        {"Wilson Evans Batten Catalogue", "WEB 4915"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.29323340),
        dec: Angle.Degrees(+20.58373456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76036"},
        {"Hipparcos Number", "HIP 43730"},
        {"Smithsonian Astrophysical Observation", "SAO 80497"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.58973048),
        dec: Angle.Degrees(+20.58619334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40981"},
        {"Hipparcos Number", "HIP 28659"},
        {"Geneva Identification System", "GEN# +1.00040981"},
        {"Smithsonian Astrophysical Observation", "SAO 77889"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.77913014),
        dec: Angle.Degrees(+20.58629722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1687"},
        {"Geneva Identification System", "GEN# +0.01900048"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.28324472),
        dec: Angle.Degrees(+20.58754511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 288.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -232.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42974"},
        {"Smithsonian Astrophysical Observation", "SAO 80402"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.37714659),
        dec: Angle.Degrees(+20.59019828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126512"},
        {"Hipparcos Number", "HIP 70520"},
        {"Geneva Identification System", "GEN# +1.00126512"},
        {"Smithsonian Astrophysical Observation", "SAO 83342"},
        {"Wilson Evans Batten Catalogue", "WEB 12230"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.37515544),
        dec: Angle.Degrees(+20.59157119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -581.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11246"},
        {"Hipparcos Number", "HIP 8592"},
        {"Smithsonian Astrophysical Observation", "SAO 74978"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.72142912),
        dec: Angle.Degrees(+20.59212317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2095"},
        {"Hipparcos Number", "HIP 2002"},
        {"Smithsonian Astrophysical Observation", "SAO 73969"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.34566145),
        dec: Angle.Degrees(+20.59231746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12831"},
        {"Hipparcos Number", "HIP 9815"},
        {"Geneva Identification System", "GEN# +1.00012831"},
        {"Smithsonian Astrophysical Observation", "SAO 75141"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.56698749),
        dec: Angle.Degrees(+20.59232136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78113"},
        {"Geneva Identification System", "GEN# +0.02102852"},
        {"Smithsonian Astrophysical Observation", "SAO 84091"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.25134009),
        dec: Angle.Degrees(+20.59487702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -235.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85249"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.30611398),
        dec: Angle.Degrees(+20.59488495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58546"},
    },
    visualMagnitude: 11.55,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.07895413),
        dec: Angle.Degrees(+20.59599129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -240.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -323.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160137"},
        {"Hipparcos Number", "HIP 86252"},
        {"Geneva Identification System", "GEN# +1.00160137"},
        {"Smithsonian Astrophysical Observation", "SAO 85261"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.37328109),
        dec: Angle.Degrees(+20.59610142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140367"},
        {"Hipparcos Number", "HIP 76928"},
        {"Smithsonian Astrophysical Observation", "SAO 83954"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.62879513),
        dec: Angle.Degrees(+20.59870581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196380"},
        {"Hipparcos Number", "HIP 101657"},
        {"Smithsonian Astrophysical Observation", "SAO 88887"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.09621940),
        dec: Angle.Degrees(+20.59938194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106903",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15171 A"},
        {"Henry Draper", "HD 206056"},
        {"Hipparcos Number", "HIP 106903"},
        {"Geneva Identification System", "GEN# +1.00206056"},
        {"Smithsonian Astrophysical Observation", "SAO 89872"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.76723122),
        dec: Angle.Degrees(+20.60156255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84739"},
        {"Hipparcos Number", "HIP 48051"},
        {"Smithsonian Astrophysical Observation", "SAO 81017"},
        {"Wilson Evans Batten Catalogue", "WEB 8987"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.92827535),
        dec: Angle.Degrees(+20.60477174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195310"},
        {"Hipparcos Number", "HIP 101119"},
        {"Smithsonian Astrophysical Observation", "SAO 88758"},
    },
    visualMagnitude: 8.56,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.45598760),
        dec: Angle.Degrees(+20.60512829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101213",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13913 A"},
        {"Henry Draper", "HD 195479"},
        {"Hipparcos Number", "HIP 101213"},
        {"Geneva Identification System", "GEN# +1.00195479"},
        {"Renson", "Renson 54460"},
        {"Smithsonian Astrophysical Observation", "SAO 88783"},
        {"Wilson Evans Batten Catalogue", "WEB 18283"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.74206375),
        dec: Angle.Degrees(+20.60600552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18792",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18792"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.39403248),
        dec: Angle.Degrees(+20.60613150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118265"},
        {"Hipparcos Number", "HIP 66302"},
        {"Geneva Identification System", "GEN# +1.00118265"},
        {"Smithsonian Astrophysical Observation", "SAO 82889"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.82474495),
        dec: Angle.Degrees(+20.60720628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2265"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.21452697),
        dec: Angle.Degrees(+20.60856597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200151"},
        {"Hipparcos Number", "HIP 103727"},
        {"Fundamental Katalog 5th Edition", "FK5 5849"},
        {"Smithsonian Astrophysical Observation", "SAO 89370"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.28200610),
        dec: Angle.Degrees(+20.60891591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37868"},
        {"Hipparcos Number", "HIP 26880"},
        {"Smithsonian Astrophysical Observation", "SAO 77433"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.60258294),
        dec: Angle.Degrees(+20.61266526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150279"},
        {"Hipparcos Number", "HIP 81534"},
        {"Smithsonian Astrophysical Observation", "SAO 84510"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.80288119),
        dec: Angle.Degrees(+20.61284201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92800",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11816 AB"},
        {"Henry Draper", "HD 175427"},
        {"Hipparcos Number", "HIP 92800"},
        {"Celescope Catalog", "CEL 4665"},
        {"Smithsonian Astrophysical Observation", "SAO 86563"},
        {"Wilson Evans Batten Catalogue", "WEB 16058"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.63689006),
        dec: Angle.Degrees(+20.61530644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74741"},
        {"Hipparcos Number", "HIP 43061"},
        {"Smithsonian Astrophysical Observation", "SAO 80412"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.58439693),
        dec: Angle.Degrees(+20.61661234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60354"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.63406486),
        dec: Angle.Degrees(+20.61783972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70694",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9269 AB"},
        {"Hipparcos Number", "HIP 70694"},
        {"Smithsonian Astrophysical Observation", "SAO 83363"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.88879486),
        dec: Angle.Degrees(+20.61872773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55677",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8149 AB"},
        {"Henry Draper", "HD 99121"},
        {"Hipparcos Number", "HIP 55677"},
        {"Smithsonian Astrophysical Observation", "SAO 81805"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.12057259),
        dec: Angle.Degrees(+20.62125735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176254"},
        {"Hipparcos Number", "HIP 93171"},
        {"Celescope Catalog", "CEL 4675"},
        {"Geneva Identification System", "GEN# +1.00176254"},
        {"Smithsonian Astrophysical Observation", "SAO 86651"},
        {"Wilson Evans Batten Catalogue", "WEB 16143"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.67247706),
        dec: Angle.Degrees(+20.62317944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45519"},
        {"Smithsonian Astrophysical Observation", "SAO 80735"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.16533301),
        dec: Angle.Degrees(+20.62324156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103817"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.56391918),
        dec: Angle.Degrees(+20.62393133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21511"},
        {"Hipparcos Number", "HIP 16205"},
        {"Smithsonian Astrophysical Observation", "SAO 75946"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.20066770),
        dec: Angle.Degrees(+20.62410420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110868"},
        {"Smithsonian Astrophysical Observation", "SAO 90523"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.92553439),
        dec: Angle.Degrees(+20.62656785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349063"},
        {"Hipparcos Number", "HIP 91410"},
        {"Cincinnati Publication", "Ci 18 2447"},
        {"Geneva Identification System", "GEN# +0.02003876"},
        {"Geneva Identification System 2", "GEN# +1.00349063"},
        {"Smithsonian Astrophysical Observation", "SAO 86273"},
        {"Wilson Evans Batten Catalogue", "WEB 15712"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.64457224),
        dec: Angle.Degrees(+20.62765814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29860"},
        {"Hipparcos Number", "HIP 21953"},
        {"Smithsonian Astrophysical Observation", "SAO 76726"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.77628516),
        dec: Angle.Degrees(+20.62994933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111319"},
        {"Hipparcos Number", "HIP 62494"},
        {"Geneva Identification System", "GEN# +1.00111319"},
        {"Smithsonian Astrophysical Observation", "SAO 82506"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.09716259),
        dec: Angle.Degrees(+20.63709525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162300"},
        {"Hipparcos Number", "HIP 87245"},
        {"Smithsonian Astrophysical Observation", "SAO 85445"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.39292095),
        dec: Angle.Degrees(+20.63734095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220211"},
        {"Hipparcos Number", "HIP 115345"},
        {"Smithsonian Astrophysical Observation", "SAO 91206"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.45529944),
        dec: Angle.Degrees(+20.63781050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5791"},
        {"Hipparcos Number", "HIP 4651"},
        {"Smithsonian Astrophysical Observation", "SAO 74420"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.93993922),
        dec: Angle.Degrees(+20.63895974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163790"},
        {"Hipparcos Number", "HIP 87896"},
        {"Smithsonian Astrophysical Observation", "SAO 85571"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.30993773),
        dec: Angle.Degrees(+20.63911770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121320"},
        {"Hipparcos Number", "HIP 67904"},
        {"Geneva Identification System", "GEN# +1.00121320"},
        {"Smithsonian Astrophysical Observation", "SAO 83070"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.61696153),
        dec: Angle.Degrees(+20.64196507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124270"},
        {"Hipparcos Number", "HIP 69383"},
        {"Geneva Identification System", "GEN# +1.00124270"},
        {"Smithsonian Astrophysical Observation", "SAO 83215"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.04472869),
        dec: Angle.Degrees(+20.64274671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70757"},
        {"Smithsonian Astrophysical Observation", "SAO 83370"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.05119232),
        dec: Angle.Degrees(+20.64535781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31987",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5320 A"},
        {"Henry Draper", "HD 47753"},
        {"Hipparcos Number", "HIP 31987"},
        {"Geneva Identification System", "GEN# +1.00047753"},
        {"Smithsonian Astrophysical Observation", "SAO 78632"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.26358604),
        dec: Angle.Degrees(+20.64546969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118158"},
        {"Hipparcos Number", "HIP 66248"},
        {"Geneva Identification System", "GEN# +1.00118158"},
        {"Smithsonian Astrophysical Observation", "SAO 82885"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.67313378),
        dec: Angle.Degrees(+20.64635163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190606"},
        {"Hipparcos Number", "HIP 98909"},
        {"Geneva Identification System", "GEN# +1.00190606A"},
        {"Wilson Evans Batten Catalogue", "WEB 17558"},
    },
    visualMagnitude: 8.22,
    bvColour: 2.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)05, 05.4300),
        dec: Angle.DegreesMinutesSeconds((int)+20, (int)38, 48.500)
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
    primaryId: "HIP 15608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15608"},
        {"Smithsonian Astrophysical Observation", "SAO 75884"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.24564415),
        dec: Angle.Degrees(+20.64706487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62928"},
        {"Geneva Identification System", "GEN# +0.02102465"},
        {"Smithsonian Astrophysical Observation", "SAO 82552"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.44193331),
        dec: Angle.Degrees(+20.65086294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 351698"},
        {"Hipparcos Number", "HIP 99766"},
        {"Smithsonian Astrophysical Observation", "SAO 88392"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.62088951),
        dec: Angle.Degrees(+20.65236328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114358"},
        {"Hipparcos Number", "HIP 64230"},
        {"Geneva Identification System", "GEN# +1.00114358"},
        {"Smithsonian Astrophysical Observation", "SAO 82684"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.45423601),
        dec: Angle.Degrees(+20.65383557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121711"},
        {"Hipparcos Number", "HIP 68113"},
        {"Geneva Identification System", "GEN# +1.00121711"},
        {"Smithsonian Astrophysical Observation", "SAO 83085"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.17438813),
        dec: Angle.Degrees(+20.65472703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347996"},
        {"Hipparcos Number", "HIP 89077"},
        {"Smithsonian Astrophysical Observation", "SAO 85800"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.69353828),
        dec: Angle.Degrees(+20.65566364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39422"},
    },
    visualMagnitude: 11.91,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.87564023),
        dec: Angle.Degrees(+21.30323716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86666",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86666"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.61548314),
        dec: Angle.Degrees(+20.65646502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111676",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111676"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.34924440),
        dec: Angle.Degrees(+20.65669508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79352"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.92939864),
        dec: Angle.Degrees(+20.65703799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221972"},
        {"Hipparcos Number", "HIP 116502"},
        {"Geneva Identification System", "GEN# +1.00221972"},
        {"Smithsonian Astrophysical Observation", "SAO 91372"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.11616459),
        dec: Angle.Degrees(+20.66540425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225097"},
        {"Hipparcos Number", "HIP 276"},
        {"Geneva Identification System", "GEN# +1.00225097"},
        {"Smithsonian Astrophysical Observation", "SAO 73716"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.85791177),
        dec: Angle.Degrees(+20.66591788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284146"},
        {"Hipparcos Number", "HIP 19146"},
        {"Smithsonian Astrophysical Observation", "SAO 76451"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.54937330),
        dec: Angle.Degrees(+20.66828880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18404"},
        {"Hipparcos Number", "HIP 13834"},
        {"Fundamental Katalog 5th Edition", "FK5 1081"},
        {"Geneva Identification System", "GEN# +5.20250154"},
        {"Smithsonian Astrophysical Observation", "SAO 75662"},
        {"Wilson Evans Batten Catalogue", "WEB 2736"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.52114653),
        dec: Angle.Degrees(+20.66881016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 234.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95646",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12464 ABC"},
        {"Henry Draper", "HD 183161"},
        {"Hipparcos Number", "HIP 95646"},
        {"Celescope Catalog", "CEL 4760"},
        {"Geneva Identification System", "GEN# +1.00183161J"},
        {"Smithsonian Astrophysical Observation", "SAO 87225"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.83688353),
        dec: Angle.Degrees(+20.66889110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39030"},
        {"Hipparcos Number", "HIP 27610"},
        {"Smithsonian Astrophysical Observation", "SAO 77624"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.69463800),
        dec: Angle.Degrees(+20.67185010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79126"},
        {"Hipparcos Number", "HIP 45204"},
        {"Geneva Identification System", "GEN# +1.00079126"},
        {"Smithsonian Astrophysical Observation", "SAO 80693"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.17724446),
        dec: Angle.Degrees(+20.67360751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40329"},
        {"Hipparcos Number", "HIP 28308"},
        {"Geneva Identification System", "GEN# +1.00040329"},
        {"Smithsonian Astrophysical Observation", "SAO 77803"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.73060681),
        dec: Angle.Degrees(+20.67644197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259616"},
        {"Hipparcos Number", "HIP 31327"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.53687715),
        dec: Angle.Degrees(+20.67670277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 352514"},
        {"Hipparcos Number", "HIP 101585"},
        {"Smithsonian Astrophysical Observation", "SAO 88868"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.82027385),
        dec: Angle.Degrees(+20.67689658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18544",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18544"},
        {"Smithsonian Astrophysical Observation", "SAO 76356"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.50700761),
        dec: Angle.Degrees(+20.67692280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28304"},
        {"Hipparcos Number", "HIP 20897"},
        {"Fundamental Katalog 5th Edition", "FK5 4407"},
        {"Geneva Identification System", "GEN# +1.00028304"},
        {"Smithsonian Astrophysical Observation", "SAO 76625"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.17570906),
        dec: Angle.Degrees(+20.67745327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349160"},
        {"Hipparcos Number", "HIP 91770"},
        {"Smithsonian Astrophysical Observation", "SAO 86343"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.70170931),
        dec: Angle.Degrees(+20.67767778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90890"},
        {"Hipparcos Number", "HIP 51404"},
        {"Smithsonian Astrophysical Observation", "SAO 81384"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.48991808),
        dec: Angle.Degrees(+20.67804262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25557"},
        {"Hipparcos Number", "HIP 19002"},
        {"Smithsonian Astrophysical Observation", "SAO 76426"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.07799353),
        dec: Angle.Degrees(+20.67922264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72337"},
        {"Smithsonian Astrophysical Observation", "SAO 83521"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.88308498),
        dec: Angle.Degrees(+20.67971777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29365"},
        {"Hipparcos Number", "HIP 21604"},
        {"Fundamental Katalog 5th Edition", "FK5 2341"},
        {"Geneva Identification System", "GEN# +1.00029365"},
        {"Smithsonian Astrophysical Observation", "SAO 76680"},
        {"Wilson Evans Batten Catalogue", "WEB 4149"},
    },
    visualMagnitude: 5.85,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.56599361),
        dec: Angle.Degrees(+20.68474222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102149",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14170 C"},
        {"Henry Draper", "HD 197248"},
        {"Hipparcos Number", "HIP 102149"},
        {"Geneva Identification System", "GEN# +1.00197248"},
        {"Smithsonian Astrophysical Observation", "SAO 89024"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.47425755),
        dec: Angle.Degrees(+20.68677341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71011"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.84756004),
        dec: Angle.Degrees(+20.68680661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17160"},
        {"Hipparcos Number", "HIP 12899"},
        {"Geneva Identification System", "GEN# +1.00017160"},
        {"Smithsonian Astrophysical Observation", "SAO 75558"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.44934709),
        dec: Angle.Degrees(+20.69270787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48494"},
        {"Hipparcos Number", "HIP 32295"},
        {"Smithsonian Astrophysical Observation", "SAO 78691"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.12530227),
        dec: Angle.Degrees(+20.69302508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79594"},
    },
    visualMagnitude: 11.40,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.58713029),
        dec: Angle.Degrees(+20.69363134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -240.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 199.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38307"},
        {"Hipparcos Number", "HIP 27181"},
        {"Geneva Identification System", "GEN# +1.00038307"},
        {"Smithsonian Astrophysical Observation", "SAO 77516"},
        {"Wilson Evans Batten Catalogue", "WEB 5344"},
    },
    visualMagnitude: 6.87,
    bvColour: 3.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.41421134),
        dec: Angle.Degrees(+20.69505301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39285"},
        {"Hipparcos Number", "HIP 27746"},
        {"Smithsonian Astrophysical Observation", "SAO 77654"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.09705802),
        dec: Angle.Degrees(+20.69644026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88270"},
        {"Hipparcos Number", "HIP 49882"},
        {"Geneva Identification System", "GEN# +1.00088270"},
        {"Smithsonian Astrophysical Observation", "SAO 81220"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.78536193),
        dec: Angle.Degrees(+20.69648652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75076"},
        {"Hipparcos Number", "HIP 43232"},
        {"Smithsonian Astrophysical Observation", "SAO 80435"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.10008145),
        dec: Angle.Degrees(+20.69656038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116288"},
        {"Hipparcos Number", "HIP 65255"},
        {"Geneva Identification System", "GEN# +1.00116288"},
        {"Smithsonian Astrophysical Observation", "SAO 82806"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.60820261),
        dec: Angle.Degrees(+20.69675757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150947"},
        {"Hipparcos Number", "HIP 81885"},
        {"Geneva Identification System", "GEN# +1.00150947"},
        {"Smithsonian Astrophysical Observation", "SAO 84564"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.89591353),
        dec: Angle.Degrees(+20.69733414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69251"},
        {"Smithsonian Astrophysical Observation", "SAO 83205"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.65011489),
        dec: Angle.Degrees(+20.69881112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16221"},
        {"Hipparcos Number", "HIP 12161"},
        {"Geneva Identification System", "GEN# +1.00016221"},
        {"Smithsonian Astrophysical Observation", "SAO 75467"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.18169209),
        dec: Angle.Degrees(+20.70067884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20245"},
        {"Hipparcos Number", "HIP 15198"},
        {"Smithsonian Astrophysical Observation", "SAO 75820"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.97211537),
        dec: Angle.Degrees(+20.70210877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186487"},
        {"Hipparcos Number", "HIP 97090"},
        {"Smithsonian Astrophysical Observation", "SAO 87636"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.97492583),
        dec: Angle.Degrees(+20.70240800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48883"},
        {"Hipparcos Number", "HIP 32456"},
        {"Smithsonian Astrophysical Observation", "SAO 78726"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.60836019),
        dec: Angle.Degrees(+20.70438046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52551",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7910 AB"},
        {"Henry Draper", "HD 92991"},
        {"Hipparcos Number", "HIP 52551"},
        {"Smithsonian Astrophysical Observation", "SAO 81498"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.16637067),
        dec: Angle.Degrees(+20.70516889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46478"},
        {"Cincinnati Publication", "Ci 18 1121"},
        {"Geneva Identification System", "GEN# +0.02102033"},
        {"Smithsonian Astrophysical Observation", "SAO 80851"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.18779392),
        dec: Angle.Degrees(+20.70781538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -385.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68725"},
        {"Hipparcos Number", "HIP 40361"},
        {"Geneva Identification System", "GEN# +1.00068725"},
        {"Renson", "Renson 19060"},
        {"Smithsonian Astrophysical Observation", "SAO 80030"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.61268799),
        dec: Angle.Degrees(+20.70781561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106395",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15076"},
        {"Henry Draper", "HD 205160"},
        {"Hipparcos Number", "HIP 106395"},
        {"Wilson Evans Batten Catalogue", "WEB 19263"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.24305614),
        dec: Angle.Degrees(+20.71158179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159734"},
        {"Hipparcos Number", "HIP 86080"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.87751853),
        dec: Angle.Degrees(+20.71169268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204233"},
        {"Hipparcos Number", "HIP 105880"},
        {"Smithsonian Astrophysical Observation", "SAO 89709"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.65742649),
        dec: Angle.Degrees(+20.71283205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102144",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14170 AB"},
        {"Henry Draper", "HD 197228"},
        {"Hipparcos Number", "HIP 102144"},
        {"Geneva Identification System", "GEN# +1.00197228J"},
        {"Smithsonian Astrophysical Observation", "SAO 89019"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.46536457),
        dec: Angle.Degrees(+20.71417230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150933"},
        {"Hipparcos Number", "HIP 81880"},
        {"Geneva Identification System", "GEN# +1.00150933"},
        {"Smithsonian Astrophysical Observation", "SAO 84562"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.87534203),
        dec: Angle.Degrees(+20.71618771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61677"},
        {"Geneva Identification System", "GEN# +0.02102438"},
        {"Smithsonian Astrophysical Observation", "SAO 82414"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.64988717),
        dec: Angle.Degrees(+20.72087733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92414",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11729 A"},
        {"Henry Draper", "HD 349425"},
        {"Hipparcos Number", "HIP 92414"},
        {"Wilson Evans Batten Catalogue", "WEB 15964"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.50126478),
        dec: Angle.Degrees(+20.72127732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62015"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.66138797),
        dec: Angle.Degrees(+20.72416477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63461"},
        {"Geneva Identification System", "GEN# +0.02102476"},
        {"Smithsonian Astrophysical Observation", "SAO 82603"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.06801900),
        dec: Angle.Degrees(+20.72430257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98425"},
        {"Hipparcos Number", "HIP 55305"},
        {"Smithsonian Astrophysical Observation", "SAO 81770"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.89537436),
        dec: Angle.Degrees(+20.72526477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154100"},
        {"Hipparcos Number", "HIP 83394"},
        {"Smithsonian Astrophysical Observation", "SAO 84781"},
        {"Wilson Evans Batten Catalogue", "WEB 14094"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.66030941),
        dec: Angle.Degrees(+20.72562427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200862"},
        {"Hipparcos Number", "HIP 104109"},
        {"Smithsonian Astrophysical Observation", "SAO 89445"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.38172439),
        dec: Angle.Degrees(+20.72709354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63942"},
        {"Geneva Identification System", "GEN# +0.02102486"},
        {"Smithsonian Astrophysical Observation", "SAO 82649"},
        {"Wilson Evans Batten Catalogue", "WEB 11300"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.56428657),
        dec: Angle.Degrees(+20.72899678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7910"},
        {"Smithsonian Astrophysical Observation", "SAO 74875"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.41656963),
        dec: Angle.Degrees(+20.72911995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41564"},
        {"Hipparcos Number", "HIP 28965"},
        {"Smithsonian Astrophysical Observation", "SAO 77970"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.68280268),
        dec: Angle.Degrees(+20.73004211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14974"},
        {"Smithsonian Astrophysical Observation", "SAO 75797"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.25882919),
        dec: Angle.Degrees(+20.73006661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73735"},
        {"Smithsonian Astrophysical Observation", "SAO 83641"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.08218049),
        dec: Angle.Degrees(+20.73170653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37124"},
        {"Hipparcos Number", "HIP 26381"},
        {"Cincinnati Publication", "Ci 20 340"},
        {"Geneva Identification System", "GEN# +1.00037124"},
        {"Smithsonian Astrophysical Observation", "SAO 77323"},
        {"Wilson Evans Batten Catalogue", "WEB 5201"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.26056715),
        dec: Angle.Degrees(+20.73180857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -419.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65834"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.42814830),
        dec: Angle.Degrees(+20.73191221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284262"},
        {"Hipparcos Number", "HIP 19665"},
        {"Smithsonian Astrophysical Observation", "SAO 76504"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.19940407),
        dec: Angle.Degrees(+20.73526195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81962"},
        {"Geneva Identification System", "GEN# +0.02102978"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.15133181),
        dec: Angle.Degrees(+20.73777279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -265.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -272.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6695"},
        {"Hipparcos Number", "HIP 5310"},
        {"Geneva Identification System", "GEN# +1.00006695"},
        {"Smithsonian Astrophysical Observation", "SAO 74506"},
        {"Wilson Evans Batten Catalogue", "WEB 1139"},
    },
    visualMagnitude: 5.56,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.98795829),
        dec: Angle.Degrees(+20.73932115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76421"},
    },
    visualMagnitude: 10.73,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.11710626),
        dec: Angle.Degrees(+20.73936659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348312"},
        {"Hipparcos Number", "HIP 89854"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.04682325),
        dec: Angle.Degrees(+20.73951096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164396"},
        {"Hipparcos Number", "HIP 88131"},
        {"Geneva Identification System", "GEN# +1.00164396"},
        {"Smithsonian Astrophysical Observation", "SAO 85621"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.02588321),
        dec: Angle.Degrees(+20.74178184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20893"},
        {"Hipparcos Number", "HIP 15737"},
        {"Geneva Identification System", "GEN# +1.00020893"},
        {"Smithsonian Astrophysical Observation", "SAO 75899"},
        {"Wilson Evans Batten Catalogue", "WEB 3011"},
    },
    visualMagnitude: 5.10,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.68863399),
        dec: Angle.Degrees(+20.74210510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113413",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16408 A"},
        {"Henry Draper", "HD 217116"},
        {"Hipparcos Number", "HIP 113413"},
        {"Smithsonian Astrophysical Observation", "SAO 90904"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.53322777),
        dec: Angle.Degrees(+20.74261040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201639"},
        {"Henry Draper 2", "HD 201639A"},
        {"Hipparcos Number", "HIP 104514"},
        {"Geneva Identification System", "GEN# +1.00201639"},
        {"Smithsonian Astrophysical Observation", "SAO 89501"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.55961734),
        dec: Angle.Degrees(+20.74346405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56295"},
        {"Hipparcos Number", "HIP 35280"},
        {"Geneva Identification System", "GEN# +1.00056295"},
        {"Smithsonian Astrophysical Observation", "SAO 79245"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.32808949),
        dec: Angle.Degrees(+20.74464793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284210"},
        {"Hipparcos Number", "HIP 19616"},
        {"Smithsonian Astrophysical Observation", "SAO 76498"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.05294379),
        dec: Angle.Degrees(+20.74521801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112354"},
        {"Hipparcos Number", "HIP 63116"},
        {"Smithsonian Astrophysical Observation", "SAO 82573"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.98505174),
        dec: Angle.Degrees(+20.74566482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69030"},
        {"Hipparcos Number", "HIP 40471"},
        {"Smithsonian Astrophysical Observation", "SAO 80051"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.95495332),
        dec: Angle.Degrees(+20.74583466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69994"},
        {"Hipparcos Number", "HIP 40866"},
        {"Fundamental Katalog 5th Edition", "FK5 2646"},
        {"Geneva Identification System", "GEN# +1.00069994"},
        {"Smithsonian Astrophysical Observation", "SAO 80112"},
        {"Wilson Evans Batten Catalogue", "WEB 7925"},
    },
    visualMagnitude: 5.80,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.08721890),
        dec: Angle.Degrees(+20.74783186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23290"},
        {"Hipparcos Number", "HIP 17481"},
        {"Geneva Identification System", "GEN# +1.00023290"},
        {"Smithsonian Astrophysical Observation", "SAO 76127"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.18684487),
        dec: Angle.Degrees(+20.74811078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49244"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.78435857),
        dec: Angle.Degrees(+20.74860083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 350062"},
        {"Hipparcos Number", "HIP 95923"},
        {"Geneva Identification System", "GEN# +1.00350062"},
        {"Smithsonian Astrophysical Observation", "SAO 87293"},
        {"Wilson Evans Batten Catalogue", "WEB 16799"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.62810159),
        dec: Angle.Degrees(+20.74928085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 873"},
        {"Hipparcos Number", "HIP 1064"},
        {"Smithsonian Astrophysical Observation", "SAO 73821"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.30454895),
        dec: Angle.Degrees(+20.75280824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149786"},
        {"Hipparcos Number", "HIP 81298"},
        {"Smithsonian Astrophysical Observation", "SAO 84477"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.07891877),
        dec: Angle.Degrees(+20.75597298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13394"},
        {"Hipparcos Number", "HIP 10216"},
        {"Smithsonian Astrophysical Observation", "SAO 75193"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.84306404),
        dec: Angle.Degrees(+20.75804815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68732",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9098 A"},
        {"Hipparcos Number", "HIP 68732"},
        {"Geneva Identification System", "GEN# +0.02102602"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.04197903),
        dec: Angle.Degrees(+20.75917058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19549"},
        {"Hipparcos Number", "HIP 14649"},
        {"Smithsonian Astrophysical Observation", "SAO 75755"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.33375029),
        dec: Angle.Degrees(+20.76115147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127106"},
        {"Hipparcos Number", "HIP 70818"},
        {"Smithsonian Astrophysical Observation", "SAO 83376"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.23989587),
        dec: Angle.Degrees(+20.76764006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21774"},
        {"Hipparcos Number", "HIP 16405"},
        {"Geneva Identification System", "GEN# +1.00021774"},
        {"Smithsonian Astrophysical Observation", "SAO 75971"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.81455616),
        dec: Angle.Degrees(+20.76854985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113357",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Helvetios"},
        {"Henry Draper", "HD 217014"},
        {"Hipparcos Number", "HIP 113357"},
        {"Geneva Identification System", "GEN# +1.00217014"},
        {"Smithsonian Astrophysical Observation", "SAO 90896"},
        {"Wilson Evans Batten Catalogue", "WEB 20165"},
    },
    visualMagnitude: 5.45,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.36604441),
        dec: Angle.Degrees(+20.76868410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 208.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165570"},
        {"Hipparcos Number", "HIP 88632"},
        {"Geneva Identification System", "GEN# +1.00165570"},
        {"Smithsonian Astrophysical Observation", "SAO 85721"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.44815444),
        dec: Angle.Degrees(+20.77042001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12591"},
    },
    visualMagnitude: 11.12,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.48335670),
        dec: Angle.Degrees(+20.77042605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46828"},
        {"Smithsonian Astrophysical Observation", "SAO 80896"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.13867126),
        dec: Angle.Degrees(+20.77082092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198917"},
        {"Hipparcos Number", "HIP 103070"},
        {"Smithsonian Astrophysical Observation", "SAO 89237"},
    },
    visualMagnitude: 8.83,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.25395467),
        dec: Angle.Degrees(+20.77162703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24680"},
        {"Hipparcos Number", "HIP 18405"},
        {"Geneva Identification System", "GEN# +1.00024680"},
        {"Smithsonian Astrophysical Observation", "SAO 76328"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.02718556),
        dec: Angle.Degrees(+20.77173455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94469"},
        {"Hipparcos Number", "HIP 53338"},
        {"Smithsonian Astrophysical Observation", "SAO 81575"},
        {"Wilson Evans Batten Catalogue", "WEB 9682"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.63526962),
        dec: Angle.Degrees(+20.77305961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3373",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 597 AB"},
        {"Hipparcos Number", "HIP 3373"},
        {"Smithsonian Astrophysical Observation", "SAO 74218"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.72166272),
        dec: Angle.Degrees(+20.77656817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86122"},
        {"Hipparcos Number", "HIP 48778"},
        {"Smithsonian Astrophysical Observation", "SAO 81100"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.23339418),
        dec: Angle.Degrees(+20.77726827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347850"},
        {"Hipparcos Number", "HIP 88391"},
        {"Smithsonian Astrophysical Observation", "SAO 85681"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.74547080),
        dec: Angle.Degrees(+20.77749372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112645",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112645"},
        {"Smithsonian Astrophysical Observation", "SAO 90804"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.21925155),
        dec: Angle.Degrees(+20.77815377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40054",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40054"},
        {"Smithsonian Astrophysical Observation", "SAO 79998"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.72397782),
        dec: Angle.Degrees(+20.77906370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284612"},
        {"Hipparcos Number", "HIP 21639"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.71725020),
        dec: Angle.Degrees(+20.78077294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64875",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64875"},
        {"Wilson Evans Batten Catalogue", "WEB 11467"},
    },
    visualMagnitude: 11.65,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.46399720),
        dec: Angle.Degrees(+20.78084923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118234"},
        {"Hipparcos Number", "HIP 66286"},
        {"Geneva Identification System", "GEN# +1.00118234"},
        {"Smithsonian Astrophysical Observation", "SAO 82886"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.78415102),
        dec: Angle.Degrees(+20.78197496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185697"},
        {"Hipparcos Number", "HIP 96712"},
        {"Geneva Identification System", "GEN# +1.00185697"},
        {"Smithsonian Astrophysical Observation", "SAO 87518"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.90610433),
        dec: Angle.Degrees(+20.78289743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30756",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5080 B"},
        {"Henry Draper", "HD 257498"},
        {"Hipparcos Number", "HIP 30756"},
        {"Smithsonian Astrophysical Observation", "SAO 78394"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.94143388),
        dec: Angle.Degrees(+20.78322960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185436"},
        {"Hipparcos Number", "HIP 96601"},
        {"Geneva Identification System", "GEN# +1.00185436"},
        {"Smithsonian Astrophysical Observation", "SAO 87489"},
        {"Wilson Evans Batten Catalogue", "WEB 16949"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.57414264),
        dec: Angle.Degrees(+20.78347323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59333"},
        {"Hipparcos Number", "HIP 36468"},
        {"Smithsonian Astrophysical Observation", "SAO 79443"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.56161075),
        dec: Angle.Degrees(+20.78438073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93393"},
        {"Hipparcos Number", "HIP 52761"},
        {"Smithsonian Astrophysical Observation", "SAO 81522"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.82986827),
        dec: Angle.Degrees(+20.78675760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30757",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5080 A"},
        {"Henry Draper", "HD 45352"},
        {"Hipparcos Number", "HIP 30757"},
        {"Smithsonian Astrophysical Observation", "SAO 78395"},
        {"Wilson Evans Batten Catalogue", "WEB 6132"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.94409771),
        dec: Angle.Degrees(+20.78961921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197881"},
        {"Hipparcos Number", "HIP 102470"},
        {"Smithsonian Astrophysical Observation", "SAO 89106"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.46353163),
        dec: Angle.Degrees(+20.79061016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108178"},
        {"Smithsonian Astrophysical Observation", "SAO 90091"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.75536400),
        dec: Angle.Degrees(+20.79285962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105626"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.90473456),
        dec: Angle.Degrees(+20.79358958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85017"},
        {"Hipparcos Number", "HIP 48197"},
        {"Geneva Identification System", "GEN# +1.00085017"},
        {"Smithsonian Astrophysical Observation", "SAO 81032"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.38802736),
        dec: Angle.Degrees(+20.79426855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2423"},
        {"Hipparcos Number", "HIP 2222"},
        {"Smithsonian Astrophysical Observation", "SAO 74020"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.04294638),
        dec: Angle.Degrees(+20.79597251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73428"},
        {"Hipparcos Number", "HIP 42428"},
        {"Smithsonian Astrophysical Observation", "SAO 80320"},
        {"Wilson Evans Batten Catalogue", "WEB 8157"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.78285184),
        dec: Angle.Degrees(+20.79729346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85215"},
        {"Hipparcos Number", "HIP 48303"},
        {"Smithsonian Astrophysical Observation", "SAO 81044"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.71546659),
        dec: Angle.Degrees(+20.79954548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84187"},
        {"Cincinnati Publication", "Ci 18 2292"},
        {"Smithsonian Astrophysical Observation", "SAO 84918"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.13876192),
        dec: Angle.Degrees(+20.80042672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -259.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51419",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7802 AB"},
        {"Henry Draper", "HD 90915"},
        {"Hipparcos Number", "HIP 51419"},
        {"Smithsonian Astrophysical Observation", "SAO 81385"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.52636980),
        dec: Angle.Degrees(+20.80134501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35914"},
        {"Smithsonian Astrophysical Observation", "SAO 79362"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.05804674),
        dec: Angle.Degrees(+20.80226480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209859"},
        {"Hipparcos Number", "HIP 109099"},
        {"Smithsonian Astrophysical Observation", "SAO 90222"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.50521490),
        dec: Angle.Degrees(+20.80342972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21050"},
        {"Hipparcos Number", "HIP 15870"},
        {"Geneva Identification System", "GEN# +1.00021050"},
        {"Smithsonian Astrophysical Observation", "SAO 75915"},
        {"Wilson Evans Batten Catalogue", "WEB 3029"},
    },
    visualMagnitude: 6.07,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.10881233),
        dec: Angle.Degrees(+20.80351283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39624",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39624"},
        {"Smithsonian Astrophysical Observation", "SAO 79933"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.45496596),
        dec: Angle.Degrees(+20.80366193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96076"},
        {"Hipparcos Number", "HIP 54191"},
        {"Smithsonian Astrophysical Observation", "SAO 81655"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.29468033),
        dec: Angle.Degrees(+20.80489783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8903",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sheratan"},
        {"Henry Draper", "HD 11636"},
        {"Hipparcos Number", "HIP 8903"},
        {"Celescope Catalog", "CEL 180"},
        {"Fundamental Katalog 5th Edition", "FK5 66"},
        {"Geneva Identification System", "GEN# +1.00011636"},
        {"Renson", "Renson 2970"},
        {"Smithsonian Astrophysical Observation", "SAO 75012"},
        {"Wilson Evans Batten Catalogue", "WEB 1872"},
    },
    visualMagnitude: 2.64,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.65978771),
        dec: Angle.Degrees(+20.80829949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61816"},
        {"Cincinnati Publication", "Ci 20 728"},
        {"Geneva Identification System", "GEN# +0.02102442"},
        {"Smithsonian Astrophysical Observation", "SAO 82428"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.02880146),
        dec: Angle.Degrees(+20.81001158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -368.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84484"},
        {"Hipparcos Number", "HIP 47941"},
        {"Geneva Identification System", "GEN# +1.00084484"},
        {"Smithsonian Astrophysical Observation", "SAO 81008"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.53942862),
        dec: Angle.Degrees(+20.81191724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116866"},
        {"Hipparcos Number", "HIP 65544"},
        {"Fundamental Katalog 5th Edition", "FK5 5184"},
        {"Geneva Identification System", "GEN# +1.00116866"},
        {"Smithsonian Astrophysical Observation", "SAO 82831"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.54347205),
        dec: Angle.Degrees(+20.81218745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45671",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7294"},
        {"Henry Draper", "HD 80146"},
        {"Hipparcos Number", "HIP 45671"},
        {"Smithsonian Astrophysical Observation", "SAO 80753"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.65105562),
        dec: Angle.Degrees(+20.81384290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88886",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11102 A"},
        {"Henry Draper", "HD 166182"},
        {"Hipparcos Number", "HIP 88886"},
        {"Fundamental Katalog 5th Edition", "FK5 3443"},
        {"Geneva Identification System", "GEN# +1.00166182"},
        {"Smithsonian Astrophysical Observation", "SAO 85769"},
        {"Wilson Evans Batten Catalogue", "WEB 15076"},
    },
    visualMagnitude: 4.37,
    bvColour: -0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.18955260),
        dec: Angle.Degrees(+20.81457203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170829"},
        {"Hipparcos Number", "HIP 90729"},
        {"Geneva Identification System", "GEN# +1.00170829"},
        {"Smithsonian Astrophysical Observation", "SAO 86142"},
        {"Wilson Evans Batten Catalogue", "WEB 15542"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.67350531),
        dec: Angle.Degrees(+20.81568735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -263.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64768"},
        {"Hipparcos Number", "HIP 38777"},
        {"Smithsonian Astrophysical Observation", "SAO 79809"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.06278445),
        dec: Angle.Degrees(+20.81755468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74135"},
        {"Hipparcos Number", "HIP 42766"},
        {"Smithsonian Astrophysical Observation", "SAO 80376"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.72119771),
        dec: Angle.Degrees(+20.81927275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26874"},
        {"Hipparcos Number", "HIP 19870"},
        {"Fundamental Katalog 5th Edition", "FK5 4390"},
        {"Geneva Identification System", "GEN# +5.20250162"},
        {"Smithsonian Astrophysical Observation", "SAO 76525"},
        {"Wilson Evans Batten Catalogue", "WEB 3797"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.92653533),
        dec: Angle.Degrees(+20.81988309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41657"},
        {"Hipparcos Number", "HIP 29010"},
        {"Smithsonian Astrophysical Observation", "SAO 77983"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.82468855),
        dec: Angle.Degrees(+20.82022735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20417",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3158 A"},
        {"Henry Draper", "HD 27639"},
        {"Henry Draper 2", "HD 27640"},
        {"Henry Draper 3", "HD 27639A"},
        {"Hipparcos Number", "HIP 20417"},
        {"Geneva Identification System", "GEN# +1.00027639"},
        {"Smithsonian Astrophysical Observation", "SAO 76571"},
        {"Wilson Evans Batten Catalogue", "WEB 3901"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.59471274),
        dec: Angle.Degrees(+20.82141842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184829"},
        {"Hipparcos Number", "HIP 96360"},
        {"Geneva Identification System", "GEN# +1.00184829J"},
        {"Smithsonian Astrophysical Observation", "SAO 87402"},
        {"Wilson Evans Batten Catalogue", "WEB 16897"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.88266953),
        dec: Angle.Degrees(+20.82202246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111973",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111973"},
        {"Smithsonian Astrophysical Observation", "SAO 90699"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.21861610),
        dec: Angle.Degrees(+20.82283798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349548"},
        {"Hipparcos Number", "HIP 93087"},
        {"Smithsonian Astrophysical Observation", "SAO 86629"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.43881654),
        dec: Angle.Degrees(+20.82554214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52474"},
        {"Hipparcos Number", "HIP 33906"},
        {"Geneva Identification System", "GEN# +1.00052474"},
        {"Smithsonian Astrophysical Observation", "SAO 78993"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.55613263),
        dec: Angle.Degrees(+20.82822710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220318"},
        {"Hipparcos Number", "HIP 115407"},
        {"Fundamental Katalog 5th Edition", "FK5 3873"},
        {"Geneva Identification System", "GEN# +1.00220318"},
        {"Smithsonian Astrophysical Observation", "SAO 91220"},
        {"Wilson Evans Batten Catalogue", "WEB 20436"},
    },
    visualMagnitude: 6.28,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.66875148),
        dec: Angle.Degrees(+20.82874369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2779"},
        {"Hipparcos Number", "HIP 2480"},
        {"Smithsonian Astrophysical Observation", "SAO 74061"},
        {"Wilson Evans Batten Catalogue", "WEB 453"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.87807193),
        dec: Angle.Degrees(+20.82951512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34763"},
        {"Hipparcos Number", "HIP 24945"},
        {"Smithsonian Astrophysical Observation", "SAO 77118"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.15800726),
        dec: Angle.Degrees(+20.82996145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23396",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3614"},
        {"Aitken 2", "ADS 3614 AB"},
        {"Henry Draper", "HD 32127"},
        {"Hipparcos Number", "HIP 23396"},
        {"Smithsonian Astrophysical Observation", "SAO 76905"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.43443138),
        dec: Angle.Degrees(+20.83007077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85464"},
        {"Smithsonian Astrophysical Observation", "SAO 85113"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.96936617),
        dec: Angle.Degrees(+20.83024344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108282"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.06618416),
        dec: Angle.Degrees(+20.83115527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59841"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.06604949),
        dec: Angle.Degrees(+20.83174219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95516"},
        {"Hipparcos Number", "HIP 53898"},
        {"Geneva Identification System", "GEN# +1.00095516"},
        {"Smithsonian Astrophysical Observation", "SAO 81631"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.42301631),
        dec: Angle.Degrees(+20.83179376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176819"},
        {"Hipparcos Number", "HIP 93404"},
        {"Celescope Catalog", "CEL 4688"},
        {"Geneva Identification System", "GEN# +1.00176819"},
        {"Smithsonian Astrophysical Observation", "SAO 86704"},
        {"Wilson Evans Batten Catalogue", "WEB 16202"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.34395849),
        dec: Angle.Degrees(+20.83285573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164852"},
        {"Hipparcos Number", "HIP 88331"},
        {"Geneva Identification System", "GEN# +1.00164852"},
        {"Smithsonian Astrophysical Observation", "SAO 85672"},
        {"Wilson Evans Batten Catalogue", "WEB 14928"},
    },
    visualMagnitude: 5.25,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.59604036),
        dec: Angle.Degrees(+20.83364838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224466"},
        {"Hipparcos Number", "HIP 118167"},
        {"Smithsonian Astrophysical Observation", "SAO 91620"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.54905787),
        dec: Angle.Degrees(+20.83465674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349322"},
        {"Hipparcos Number", "HIP 92287"},
        {"Smithsonian Astrophysical Observation", "SAO 86455"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.13729077),
        dec: Angle.Degrees(+20.83617640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63772"},
        {"Hipparcos Number", "HIP 38352"},
        {"Geneva Identification System", "GEN# +1.00063772"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.82866063),
        dec: Angle.Degrees(+20.83687591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38529"},
        {"Smithsonian Astrophysical Observation", "SAO 79776"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.35085351),
        dec: Angle.Degrees(+20.83688051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38528"},
        {"Smithsonian Astrophysical Observation", "SAO 79775"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.34656672),
        dec: Angle.Degrees(+20.83731131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24778"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.68277057),
        dec: Angle.Degrees(+20.83949716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83162"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.93402406),
        dec: Angle.Degrees(+20.84037035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37298",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37298"},
        {"Smithsonian Astrophysical Observation", "SAO 79587"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.86489766),
        dec: Angle.Degrees(+20.84064021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221662"},
        {"Hipparcos Number", "HIP 116307"},
        {"Geneva Identification System", "GEN# +1.00221662"},
        {"Smithsonian Astrophysical Observation", "SAO 91349"},
        {"Wilson Evans Batten Catalogue", "WEB 20553"},
    },
    visualMagnitude: 6.10,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.48124572),
        dec: Angle.Degrees(+20.84097045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114779"},
        {"Hipparcos Number", "HIP 64439"},
        {"Geneva Identification System", "GEN# +1.00114779"},
        {"Smithsonian Astrophysical Observation", "SAO 82710"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.11422899),
        dec: Angle.Degrees(+20.84217168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148493"},
        {"Hipparcos Number", "HIP 80622"},
        {"Geneva Identification System", "GEN# +1.00148493"},
        {"Smithsonian Astrophysical Observation", "SAO 84389"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.93245792),
        dec: Angle.Degrees(+20.84332328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 263446"},
        {"Hipparcos Number", "HIP 32459"},
        {"Smithsonian Astrophysical Observation", "SAO 78728"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.61951554),
        dec: Angle.Degrees(+20.84360201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349423"},
        {"Hipparcos Number", "HIP 92400"},
    },
    visualMagnitude: 11.29,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.44817181),
        dec: Angle.Degrees(+20.84429434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65430"},
        {"Hipparcos Number", "HIP 39064"},
        {"Cincinnati Publication", "Ci 20 449"},
        {"Geneva Identification System", "GEN# +1.00065430"},
        {"Smithsonian Astrophysical Observation", "SAO 79846"},
        {"Wilson Evans Batten Catalogue", "WEB 7661"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.89092254),
        dec: Angle.Degrees(+20.84521031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -544.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197396"},
        {"Hipparcos Number", "HIP 102226"},
        {"Smithsonian Astrophysical Observation", "SAO 89039"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.70587871),
        dec: Angle.Degrees(+20.84547031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -352.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110548",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15896 AB"},
        {"Henry Draper", "HD 212395"},
        {"Hipparcos Number", "HIP 110548"},
        {"Smithsonian Astrophysical Observation", "SAO 90462"},
        {"Wilson Evans Batten Catalogue", "WEB 19812"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.91398136),
        dec: Angle.Degrees(+20.84826537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 335.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208363"},
        {"Hipparcos Number", "HIP 108212"},
        {"Geneva Identification System", "GEN# +1.00208363"},
        {"Smithsonian Astrophysical Observation", "SAO 90096"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.83739955),
        dec: Angle.Degrees(+20.84905466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218078"},
        {"Hipparcos Number", "HIP 113990"},
        {"Geneva Identification System", "GEN# +1.00218078"},
        {"Smithsonian Astrophysical Observation", "SAO 90994"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.27301533),
        dec: Angle.Degrees(+20.85606868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344956"},
        {"Hipparcos Number", "HIP 97193"},
        {"Smithsonian Astrophysical Observation", "SAO 87664"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.31005194),
        dec: Angle.Degrees(+20.85637141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284145"},
        {"Hipparcos Number", "HIP 19054"},
        {"Smithsonian Astrophysical Observation", "SAO 76434"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.23549287),
        dec: Angle.Degrees(+20.85660466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1334"},
        {"Geneva Identification System", "GEN# +0.02000017"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.17970185),
        dec: Angle.Degrees(+20.85666251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 383.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71847"},
        {"Hipparcos Number", "HIP 41710"},
        {"Smithsonian Astrophysical Observation", "SAO 80215"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.58465366),
        dec: Angle.Degrees(+20.85785543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98629"},
        {"Hipparcos Number", "HIP 55424"},
        {"Geneva Identification System", "GEN# +1.00098629"},
        {"Smithsonian Astrophysical Observation", "SAO 81786"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.24641556),
        dec: Angle.Degrees(+20.85800859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195715"},
        {"Hipparcos Number", "HIP 101326"},
        {"Smithsonian Astrophysical Observation", "SAO 88814"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.06115601),
        dec: Angle.Degrees(+20.85958121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48565"},
        {"Hipparcos Number", "HIP 32329"},
        {"Geneva Identification System", "GEN# +1.00048565"},
        {"Smithsonian Astrophysical Observation", "SAO 78698"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.22859962),
        dec: Angle.Degrees(+20.86062225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14481",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2353 AB"},
        {"Hipparcos Number", "HIP 14481"},
        {"Smithsonian Astrophysical Observation", "SAO 75739"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.71856159),
        dec: Angle.Degrees(+20.86205530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110541",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15896 C"},
        {"Hipparcos Number", "HIP 110541"},
        {"Smithsonian Astrophysical Observation", "SAO 90461"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.89392169),
        dec: Angle.Degrees(+20.86346734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181603"},
        {"Hipparcos Number", "HIP 95047"},
        {"Geneva Identification System", "GEN# +1.00181603"},
        {"Smithsonian Astrophysical Observation", "SAO 87089"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.08523303),
        dec: Angle.Degrees(+20.86358789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100536",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13777"},
        {"Henry Draper", "HD 194113"},
        {"Hipparcos Number", "HIP 100536"},
        {"Smithsonian Astrophysical Observation", "SAO 88610"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.78741939),
        dec: Angle.Degrees(+20.86419985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142328"},
        {"Hipparcos Number", "HIP 77803"},
        {"Smithsonian Astrophysical Observation", "SAO 84055"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.30871965),
        dec: Angle.Degrees(+20.86545288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54076"},
        {"Hipparcos Number", "HIP 34433"},
        {"Geneva Identification System", "GEN# +1.00054076"},
        {"Smithsonian Astrophysical Observation", "SAO 79096"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.08103504),
        dec: Angle.Degrees(+20.86580955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115463"},
        {"Hipparcos Number", "HIP 64813"},
        {"Geneva Identification System", "GEN# +1.00115463"},
        {"Smithsonian Astrophysical Observation", "SAO 82755"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.26357281),
        dec: Angle.Degrees(+20.86760481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7965"},
        {"Hipparcos Number", "HIP 6194"},
        {"Smithsonian Astrophysical Observation", "SAO 74640"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.86766470),
        dec: Angle.Degrees(+20.86862489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51641"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.26927975),
        dec: Angle.Degrees(+20.86938755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27421",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4392 AB"},
        {"Henry Draper", "HD 38670"},
        {"Hipparcos Number", "HIP 27421"},
        {"Celescope Catalog", "CEL 977"},
        {"Geneva Identification System", "GEN# +1.00038670J"},
        {"Smithsonian Astrophysical Observation", "SAO 77578"},
        {"Wilson Evans Batten Catalogue", "WEB 5385"},
    },
    visualMagnitude: 6.03,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.09317755),
        dec: Angle.Degrees(+20.86952409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162385"},
        {"Hipparcos Number", "HIP 87271"},
        {"Smithsonian Astrophysical Observation", "SAO 85452"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.48700067),
        dec: Angle.Degrees(+20.87000705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58471",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8376 A"},
        {"Hipparcos Number", "HIP 58471"},
        {"Smithsonian Astrophysical Observation", "SAO 82089"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.86209099),
        dec: Angle.Degrees(+20.87066478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91916",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11628 AB"},
        {"Henry Draper", "HD 349248"},
        {"Hipparcos Number", "HIP 91916"},
        {"Smithsonian Astrophysical Observation", "SAO 86381"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.07737950),
        dec: Angle.Degrees(+20.87161124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78152",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78152"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.37284470),
        dec: Angle.Degrees(+20.87246272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349418"},
        {"Hipparcos Number", "HIP 92563"},
        {"Smithsonian Astrophysical Observation", "SAO 86511"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.92843974),
        dec: Angle.Degrees(+20.87305095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284507"},
        {"Hipparcos Number", "HIP 20994"},
        {"Smithsonian Astrophysical Observation", "SAO 76633"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.53328681),
        dec: Angle.Degrees(+20.87656360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117816"},
        {"Hipparcos Number", "HIP 66048"},
        {"Geneva Identification System", "GEN# +1.00117816"},
        {"Smithsonian Astrophysical Observation", "SAO 82874"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.10764948),
        dec: Angle.Degrees(+20.87743736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349726"},
        {"Hipparcos Number", "HIP 93899"},
        {"Wilson Evans Batten Catalogue", "WEB 16336"},
        {"Wilson Evans Batten Catalogue 2", "WEB 16335"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.80626789),
        dec: Angle.Degrees(+20.87782548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -481.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -333.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17607",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17607"},
    },
    visualMagnitude: 11.54,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.58053183),
        dec: Angle.Degrees(+20.87989263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198484"},
        {"Hipparcos Number", "HIP 102836"},
        {"Smithsonian Astrophysical Observation", "SAO 89178"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.50449834),
        dec: Angle.Degrees(+20.88007904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241896"},
        {"Hipparcos Number", "HIP 24456"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.70687909),
        dec: Angle.Degrees(+20.88022286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154326"},
        {"Hipparcos Number", "HIP 83507"},
        {"Smithsonian Astrophysical Observation", "SAO 84799"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.99830322),
        dec: Angle.Degrees(+20.88030288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344672"},
        {"Hipparcos Number", "HIP 96456"},
        {"Smithsonian Astrophysical Observation", "SAO 87446"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.15471854),
        dec: Angle.Degrees(+20.88140878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140813"},
        {"Hipparcos Number", "HIP 77128"},
        {"Geneva Identification System", "GEN# +1.00140813"},
        {"Smithsonian Astrophysical Observation", "SAO 83979"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.23221585),
        dec: Angle.Degrees(+20.88143403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122562"},
        {"Hipparcos Number", "HIP 68578"},
        {"Geneva Identification System", "GEN# +1.00122562"},
        {"Smithsonian Astrophysical Observation", "SAO 83135"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.58789341),
        dec: Angle.Degrees(+20.88147659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143875"},
        {"Hipparcos Number", "HIP 78544"},
        {"Smithsonian Astrophysical Observation", "SAO 84153"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.52596165),
        dec: Angle.Degrees(+20.88488140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219311"},
        {"Hipparcos Number", "HIP 114759"},
        {"Cincinnati Publication", "Ci 18 3042"},
        {"Smithsonian Astrophysical Observation", "SAO 91115"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.68556535),
        dec: Angle.Degrees(+20.88728160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 199.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93652"},
        {"Hipparcos Number", "HIP 52891"},
        {"Smithsonian Astrophysical Observation", "SAO 81536"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.25676873),
        dec: Angle.Degrees(+20.88751323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73235",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73235"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.51655060),
        dec: Angle.Degrees(+20.88782120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95885"},
        {"Hipparcos Number", "HIP 54091"},
        {"Smithsonian Astrophysical Observation", "SAO 81650"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.02671581),
        dec: Angle.Degrees(+20.88809968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93873",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93873"},
        {"Cincinnati Publication", "Ci 20 1129"},
    },
    visualMagnitude: 10.77,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.77443107),
        dec: Angle.Degrees(+20.88888827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -480.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -345.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46688"},
        {"Hipparcos Number", "HIP 31483"},
        {"Geneva Identification System", "GEN# +1.00046688"},
        {"Smithsonian Astrophysical Observation", "SAO 78534"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.90270690),
        dec: Angle.Degrees(+20.88891534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39711",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6590 AB"},
        {"Henry Draper", "HD 67048"},
        {"Hipparcos Number", "HIP 39711"},
        {"Smithsonian Astrophysical Observation", "SAO 79953"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.75594245),
        dec: Angle.Degrees(+20.89165279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80625",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10069 A"},
        {"Henry Draper", "HD 148492"},
        {"Hipparcos Number", "HIP 80625"},
        {"Geneva Identification System", "GEN# +1.00148492"},
        {"Smithsonian Astrophysical Observation", "SAO 84390"},
        {"Wilson Evans Batten Catalogue", "WEB 13637"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.94384149),
        dec: Angle.Degrees(+20.89561826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108765"},
        {"Hipparcos Number", "HIP 60957"},
        {"Fundamental Katalog 5th Edition", "FK5 466"},
        {"Geneva Identification System", "GEN# +1.00108765"},
        {"Smithsonian Astrophysical Observation", "SAO 82336"},
        {"Wilson Evans Batten Catalogue", "WEB 10848"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.43009821),
        dec: Angle.Degrees(+20.89618496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109438"},
        {"Hipparcos Number", "HIP 61368"},
        {"Geneva Identification System", "GEN# +1.00109438"},
        {"Smithsonian Astrophysical Observation", "SAO 82385"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.63503744),
        dec: Angle.Degrees(+20.89961001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14818"},
        {"Smithsonian Astrophysical Observation", "SAO 75778"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.82776195),
        dec: Angle.Degrees(+20.90154172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29697"},
        {"Hipparcos Number", "HIP 21818"},
        {"Cincinnati Publication", "Ci 18 605"},
        {"Geneva Identification System", "GEN# +1.00029697"},
        {"Smithsonian Astrophysical Observation", "SAO 76708"},
        {"Wilson Evans Batten Catalogue", "WEB 4195"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.32917244),
        dec: Angle.Degrees(+20.90213088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -233.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -254.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19153"},
        {"Hipparcos Number", "HIP 14378"},
        {"Smithsonian Astrophysical Observation", "SAO 75727"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.37609418),
        dec: Angle.Degrees(+20.90244158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42400"},
        {"Hipparcos Number", "HIP 29367"},
        {"Celescope Catalog", "CEL 1107"},
        {"Geneva Identification System", "GEN# +1.00042400"},
        {"Smithsonian Astrophysical Observation", "SAO 78077"},
        {"Wilson Evans Batten Catalogue", "WEB 5767"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.84658437),
        dec: Angle.Degrees(+20.90542087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59088"},
        {"Hipparcos Number", "HIP 36369"},
        {"Wilson Evans Batten Catalogue", "WEB 7237"},
        {"New General Catalogue", "NGC 2392"},
    },
    visualMagnitude: 10.53,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.29486636),
        dec: Angle.Degrees(+20.91179748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84098"},
        {"Hipparcos Number", "HIP 47673"},
        {"Smithsonian Astrophysical Observation", "SAO 80984"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.81109587),
        dec: Angle.Degrees(+20.91269872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81954"},
        {"Hipparcos Number", "HIP 46527"},
        {"Geneva Identification System", "GEN# +1.00081954"},
        {"Smithsonian Astrophysical Observation", "SAO 80855"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.34502932),
        dec: Angle.Degrees(+20.91475478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99352",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13442 A"},
        {"Henry Draper", "HD 191570"},
        {"Hipparcos Number", "HIP 99352"},
        {"Geneva Identification System", "GEN# +1.00191570A"},
        {"Smithsonian Astrophysical Observation", "SAO 88276"},
        {"Wilson Evans Batten Catalogue", "WEB 17727"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.48587588),
        dec: Angle.Degrees(+20.91478880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22615"},
        {"Hipparcos Number", "HIP 17026"},
        {"Geneva Identification System", "GEN# +5.20223306"},
        {"Renson", "Renson 5760"},
        {"Smithsonian Astrophysical Observation", "SAO 76045"},
        {"Wilson Evans Batten Catalogue", "WEB 3236"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.75026216),
        dec: Angle.Degrees(+20.91584806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9107",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9107"},
        {"Smithsonian Astrophysical Observation", "SAO 75046"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.32831948),
        dec: Angle.Degrees(+20.91682635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99351",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13442 B"},
        {"Hipparcos Number", "HIP 99351"},
        {"Geneva Identification System", "GEN# +1.00191570B"},
        {"Smithsonian Astrophysical Observation", "SAO 88275"},
        {"Wilson Evans Batten Catalogue", "WEB 17729"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.48416632),
        dec: Angle.Degrees(+20.91759355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187958"},
        {"Hipparcos Number", "HIP 97753"},
        {"Smithsonian Astrophysical Observation", "SAO 87835"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.99213464),
        dec: Angle.Degrees(+20.91774872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69868"},
        {"Hipparcos Number", "HIP 40807"},
        {"Smithsonian Astrophysical Observation", "SAO 80099"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.93191094),
        dec: Angle.Degrees(+20.91808208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75961"},
        {"Hipparcos Number", "HIP 43682"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.47930971),
        dec: Angle.Degrees(+20.91845873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217813"},
        {"Hipparcos Number", "HIP 113829"},
        {"Geneva Identification System", "GEN# +1.00217813"},
        {"Smithsonian Astrophysical Observation", "SAO 90973"},
        {"Wilson Evans Batten Catalogue", "WEB 20222"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.77104234),
        dec: Angle.Degrees(+20.91864314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168743"},
        {"Hipparcos Number", "HIP 89885"},
        {"Smithsonian Astrophysical Observation", "SAO 85946"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.11587028),
        dec: Angle.Degrees(+20.91889937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109118"},
        {"Hipparcos Number", "HIP 61180"},
        {"Geneva Identification System", "GEN# +1.00109118"},
        {"Smithsonian Astrophysical Observation", "SAO 82362"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.04145432),
        dec: Angle.Degrees(+20.91922870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162318"},
        {"Hipparcos Number", "HIP 87251"},
        {"Smithsonian Astrophysical Observation", "SAO 85448"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.42668344),
        dec: Angle.Degrees(+20.92275380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21416"},
        {"Hipparcos Number", "HIP 16133"},
        {"Smithsonian Astrophysical Observation", "SAO 75938"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.96339614),
        dec: Angle.Degrees(+20.92522951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4568"},
        {"Hipparcos Number", "HIP 3730"},
        {"Geneva Identification System", "GEN# +1.00004568"},
        {"Smithsonian Astrophysical Observation", "SAO 74280"},
        {"Wilson Evans Batten Catalogue", "WEB 664"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.97803517),
        dec: Angle.Degrees(+20.92531069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186904"},
        {"Hipparcos Number", "HIP 97288"},
        {"Geneva Identification System", "GEN# +1.00186904"},
        {"Smithsonian Astrophysical Observation", "SAO 87693"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.58082774),
        dec: Angle.Degrees(+20.92640949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190026"},
        {"Hipparcos Number", "HIP 98656"},
        {"Fundamental Katalog 5th Edition", "FK5 5767"},
        {"Smithsonian Astrophysical Observation", "SAO 88104"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.57443615),
        dec: Angle.Degrees(+20.92649340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31881"},
        {"Hipparcos Number", "HIP 23253"},
        {"Smithsonian Astrophysical Observation", "SAO 76884"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.05785205),
        dec: Angle.Degrees(+20.92779226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136884"},
        {"Hipparcos Number", "HIP 75232"},
        {"Geneva Identification System", "GEN# +1.00136884"},
        {"Smithsonian Astrophysical Observation", "SAO 83794"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.59982107),
        dec: Angle.Degrees(+20.92849187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23258"},
        {"Hipparcos Number", "HIP 17453"},
        {"Geneva Identification System", "GEN# +1.00023258"},
        {"Smithsonian Astrophysical Observation", "SAO 76121"},
        {"Wilson Evans Batten Catalogue", "WEB 3307"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.11744538),
        dec: Angle.Degrees(+20.92877010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184108"},
        {"Hipparcos Number", "HIP 96075"},
        {"Celescope Catalog", "CEL 4781"},
        {"Geneva Identification System", "GEN# +1.00184108"},
        {"Smithsonian Astrophysical Observation", "SAO 87320"},
        {"Wilson Evans Batten Catalogue", "WEB 16828"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.00754664),
        dec: Angle.Degrees(+20.92943864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6023"},
        {"Smithsonian Astrophysical Observation", "SAO 74610"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.34507203),
        dec: Angle.Degrees(+20.93001796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208038"},
        {"Hipparcos Number", "HIP 108028"},
        {"Smithsonian Astrophysical Observation", "SAO 90074"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.27231906),
        dec: Angle.Degrees(+20.93076463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91468",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11546 AB"},
        {"Henry Draper", "HD 172421"},
        {"Hipparcos Number", "HIP 91468"},
        {"Geneva Identification System", "GEN# +1.00172421J"},
        {"Smithsonian Astrophysical Observation", "SAO 86288"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.82984620),
        dec: Angle.Degrees(+20.93305807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168852"},
        {"Hipparcos Number", "HIP 89941"},
        {"Smithsonian Astrophysical Observation", "SAO 85955"},
        {"Wilson Evans Batten Catalogue", "WEB 15361"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.27568008),
        dec: Angle.Degrees(+20.93481791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102031"},
        {"Hipparcos Number", "HIP 57276"},
        {"Geneva Identification System", "GEN# +1.00102031"},
        {"Smithsonian Astrophysical Observation", "SAO 81967"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.17656524),
        dec: Angle.Degrees(+20.93541928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215361"},
        {"Hipparcos Number", "HIP 112257"},
        {"Smithsonian Astrophysical Observation", "SAO 90752"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.06677290),
        dec: Angle.Degrees(+20.93714770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 262433"},
        {"Hipparcos Number", "HIP 32180"},
        {"Wilson Evans Batten Catalogue", "WEB 6491"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.78130023),
        dec: Angle.Degrees(+20.93911373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59087"},
        {"Hipparcos Number", "HIP 36370"},
        {"Geneva Identification System", "GEN# +1.00059087"},
        {"Smithsonian Astrophysical Observation", "SAO 79428"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.29643269),
        dec: Angle.Degrees(+20.93939153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138526"},
        {"Hipparcos Number", "HIP 76060"},
        {"Geneva Identification System", "GEN# +1.00138526"},
        {"Smithsonian Astrophysical Observation", "SAO 83867"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.00323021),
        dec: Angle.Degrees(+20.94128221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145678"},
        {"Hipparcos Number", "HIP 79328"},
        {"Smithsonian Astrophysical Observation", "SAO 84234"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.85516172),
        dec: Angle.Degrees(+20.94183364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88162"},
        {"Hipparcos Number", "HIP 49831"},
        {"Geneva Identification System", "GEN# +1.00088162"},
        {"Smithsonian Astrophysical Observation", "SAO 81215"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.59449112),
        dec: Angle.Degrees(+20.94555342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200930"},
        {"Hipparcos Number", "HIP 104135"},
        {"Smithsonian Astrophysical Observation", "SAO 89451"},
        {"Wilson Evans Batten Catalogue", "WEB 18968"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.48126912),
        dec: Angle.Degrees(+20.94676953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51964"},
        {"Smithsonian Astrophysical Observation", "SAO 81437"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.24270680),
        dec: Angle.Degrees(+20.94792635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204700"},
        {"Hipparcos Number", "HIP 106136"},
        {"Smithsonian Astrophysical Observation", "SAO 89750"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.47478686),
        dec: Angle.Degrees(+20.94840406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192205"},
        {"Hipparcos Number", "HIP 99618"},
        {"Smithsonian Astrophysical Observation", "SAO 88358"},
        {"Wilson Evans Batten Catalogue", "WEB 17842"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.24951085),
        dec: Angle.Degrees(+20.94847467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60720"},
        {"Geneva Identification System", "GEN# +0.02102418"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.65705672),
        dec: Angle.Degrees(+20.95223837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347988"},
        {"Hipparcos Number", "HIP 89132"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.85494571),
        dec: Angle.Degrees(+20.95243914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344673"},
        {"Hipparcos Number", "HIP 96493"},
        {"Geneva Identification System", "GEN# +1.00344673"},
        {"Smithsonian Astrophysical Observation", "SAO 87456"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.24139242),
        dec: Angle.Degrees(+20.95253243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345531"},
        {"Hipparcos Number", "HIP 98393"},
        {"Smithsonian Astrophysical Observation", "SAO 88023"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.86200883),
        dec: Angle.Degrees(+20.95313174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225150"},
        {"Hipparcos Number", "HIP 314"},
        {"Geneva Identification System", "GEN# +1.00225150"},
        {"Smithsonian Astrophysical Observation", "SAO 73721"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.99172662),
        dec: Angle.Degrees(+20.95381941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121764"},
        {"Hipparcos Number", "HIP 68146"},
        {"Fundamental Katalog 5th Edition", "FK5 5232"},
        {"Geneva Identification System", "GEN# +1.00121764"},
        {"Smithsonian Astrophysical Observation", "SAO 83089"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.27624820),
        dec: Angle.Degrees(+20.95395432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3267"},
        {"Hipparcos Number", "HIP 2821"},
        {"Smithsonian Astrophysical Observation", "SAO 74130"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.96656597),
        dec: Angle.Degrees(+20.95518361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76204"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.49467836),
        dec: Angle.Degrees(+20.95742438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152815"},
        {"Hipparcos Number", "HIP 82764"},
        {"Fundamental Katalog 5th Edition", "FK5 3343"},
        {"Geneva Identification System", "GEN# +1.00152815"},
        {"Smithsonian Astrophysical Observation", "SAO 84687"},
        {"Wilson Evans Batten Catalogue", "WEB 13990"},
    },
    visualMagnitude: 5.39,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.72973020),
        dec: Angle.Degrees(+20.95848435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56762"},
        {"Hipparcos Number", "HIP 35459"},
        {"Smithsonian Astrophysical Observation", "SAO 79282"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.80179683),
        dec: Angle.Degrees(+20.96024709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 256565"},
        {"Hipparcos Number", "HIP 30487"},
        {"Smithsonian Astrophysical Observation", "SAO 78328"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.12866410),
        dec: Angle.Degrees(+20.96163813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181829"},
        {"Hipparcos Number", "HIP 95131"},
        {"Celescope Catalog", "CEL 4740"},
        {"Geneva Identification System", "GEN# +1.00181829"},
        {"Smithsonian Astrophysical Observation", "SAO 87107"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.32214947),
        dec: Angle.Degrees(+20.96281651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349724"},
        {"Hipparcos Number", "HIP 93894"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.79179478),
        dec: Angle.Degrees(+20.96334287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169246"},
        {"Hipparcos Number", "HIP 90077"},
        {"Smithsonian Astrophysical Observation", "SAO 85988"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.73568234),
        dec: Angle.Degrees(+20.96368979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6462"},
        {"Hipparcos Number", "HIP 5145"},
        {"Geneva Identification System", "GEN# +1.00006462"},
        {"Smithsonian Astrophysical Observation", "SAO 74485"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.46422689),
        dec: Angle.Degrees(+20.96447515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250"},
        {"Hipparcos Number", "HIP 601"},
        {"Geneva Identification System", "GEN# +1.00000250"},
        {"Smithsonian Astrophysical Observation", "SAO 73754"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.82562487),
        dec: Angle.Degrees(+20.96559758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38856",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6478 AB"},
        {"Henry Draper", "HD 64959"},
        {"Hipparcos Number", "HIP 38856"},
        {"Smithsonian Astrophysical Observation", "SAO 79818"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.27401776),
        dec: Angle.Degrees(+20.96692831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51102"},
        {"Hipparcos Number", "HIP 33399"},
        {"Smithsonian Astrophysical Observation", "SAO 78896"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.20236730),
        dec: Angle.Degrees(+20.96718331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55157"},
        {"Hipparcos Number", "HIP 34845"},
        {"Smithsonian Astrophysical Observation", "SAO 79169"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.16003052),
        dec: Angle.Degrees(+20.96747458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216123"},
        {"Hipparcos Number", "HIP 112743"},
        {"Smithsonian Astrophysical Observation", "SAO 90815"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.48693973),
        dec: Angle.Degrees(+20.97072842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66670"},
        {"Geneva Identification System", "GEN# +0.02102559"},
        {"Smithsonian Astrophysical Observation", "SAO 82933"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.00715816),
        dec: Angle.Degrees(+20.97176355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85931"},
        {"Hipparcos Number", "HIP 48684"},
        {"Geneva Identification System", "GEN# +1.00085931"},
        {"Renson", "Renson 24530"},
        {"Smithsonian Astrophysical Observation", "SAO 81086"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.93280628),
        dec: Angle.Degrees(+20.97177855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164825"},
        {"Hipparcos Number", "HIP 88313"},
        {"Smithsonian Astrophysical Observation", "SAO 85666"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.54179727),
        dec: Angle.Degrees(+20.97265966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152445"},
        {"Hipparcos Number", "HIP 82566"},
        {"Smithsonian Astrophysical Observation", "SAO 84660"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.16806537),
        dec: Angle.Degrees(+20.97367036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61912"},
        {"Hipparcos Number", "HIP 37540"},
        {"Geneva Identification System", "GEN# +1.00061912"},
        {"Smithsonian Astrophysical Observation", "SAO 79623"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.56449725),
        dec: Angle.Degrees(+20.97653059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75187"},
    },
    visualMagnitude: 10.66,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.47033932),
        dec: Angle.Degrees(+20.97744191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40019"},
        {"Hipparcos Number", "HIP 28169"},
        {"Smithsonian Astrophysical Observation", "SAO 77757"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.28310157),
        dec: Angle.Degrees(+20.97751786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141992"},
        {"Hipparcos Number", "HIP 77661"},
        {"Geneva Identification System", "GEN# +1.00141992"},
        {"Smithsonian Astrophysical Observation", "SAO 84037"},
        {"Wilson Evans Batten Catalogue", "WEB 13142"},
    },
    visualMagnitude: 4.74,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.81642977),
        dec: Angle.Degrees(+20.97787548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171303"},
        {"Hipparcos Number", "HIP 90961"},
        {"Geneva Identification System", "GEN# +1.00171303"},
        {"Smithsonian Astrophysical Observation", "SAO 86186"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.32999175),
        dec: Angle.Degrees(+20.97800520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210516"},
        {"Hipparcos Number", "HIP 109458"},
        {"Fundamental Katalog 5th Edition", "FK5 3772"},
        {"Geneva Identification System", "GEN# +1.00210516"},
        {"Smithsonian Astrophysical Observation", "SAO 90287"},
        {"Wilson Evans Batten Catalogue", "WEB 19668"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.62576981),
        dec: Angle.Degrees(+20.97800691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87831"},
        {"Smithsonian Astrophysical Observation", "SAO 85561"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.13880298),
        dec: Angle.Degrees(+20.98133812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27742"},
        {"Hipparcos Number", "HIP 20493"},
        {"Geneva Identification System", "GEN# +1.00027742"},
        {"Smithsonian Astrophysical Observation", "SAO 76585"},
        {"Wilson Evans Batten Catalogue", "WEB 3921"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.88482040),
        dec: Angle.Degrees(+20.98212975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196035"},
        {"Hipparcos Number", "HIP 101505"},
        {"Geneva Identification System", "GEN# +1.00196035"},
        {"Smithsonian Astrophysical Observation", "SAO 88846"},
        {"Wilson Evans Batten Catalogue", "WEB 18342"},
    },
    visualMagnitude: 6.49,
    bvColour: -0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.54157887),
        dec: Angle.Degrees(+20.98519665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28137"},
        {"Hipparcos Number", "HIP 20785"},
        {"Smithsonian Astrophysical Observation", "SAO 76611"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.78076390),
        dec: Angle.Degrees(+20.99100997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110404"},
        {"Smithsonian Astrophysical Observation", "SAO 90444"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.43486254),
        dec: Angle.Degrees(+20.99183793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9688"},
        {"Hipparcos Number", "HIP 7393"},
        {"Smithsonian Astrophysical Observation", "SAO 74809"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.83119442),
        dec: Angle.Degrees(+20.99484700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107221"},
        {"Smithsonian Astrophysical Observation", "SAO 89922"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.74558984),
        dec: Angle.Degrees(+20.99518115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34218",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5771 AB"},
        {"Henry Draper", "HD 53384"},
        {"Hipparcos Number", "HIP 34218"},
        {"Smithsonian Astrophysical Observation", "SAO 79047"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.42138076),
        dec: Angle.Degrees(+20.99585298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106352"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.09619660),
        dec: Angle.Degrees(+20.99605464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86118",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10655 A"},
        {"Henry Draper", "HD 159834"},
        {"Hipparcos Number", "HIP 86118"},
        {"Geneva Identification System", "GEN# +1.00159834A"},
        {"Smithsonian Astrophysical Observation", "SAO 85232"},
        {"Wilson Evans Batten Catalogue", "WEB 14525"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.99818491),
        dec: Angle.Degrees(+20.99627817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135947"},
        {"Hipparcos Number", "HIP 74803"},
        {"Smithsonian Astrophysical Observation", "SAO 83747"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.31293423),
        dec: Angle.Degrees(+20.99650037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188971"},
        {"Hipparcos Number", "HIP 98169"},
        {"Geneva Identification System", "GEN# +1.00188971"},
        {"Smithsonian Astrophysical Observation", "SAO 87963"},
        {"Wilson Evans Batten Catalogue", "WEB 17304"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.25174571),
        dec: Angle.Degrees(+20.99834521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115614"},
        {"Hipparcos Number", "HIP 64885"},
        {"Geneva Identification System", "GEN# +1.00115614"},
        {"Smithsonian Astrophysical Observation", "SAO 82761"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.50222930),
        dec: Angle.Degrees(+20.99837858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105021"},
        {"Hipparcos Number", "HIP 58973"},
        {"Smithsonian Astrophysical Observation", "SAO 82127"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.38181744),
        dec: Angle.Degrees(+21.00034435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64493",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64493"},
        {"Smithsonian Astrophysical Observation", "SAO 82721"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.29249275),
        dec: Angle.Degrees(+21.00136101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184296"},
        {"Hipparcos Number", "HIP 96153"},
        {"Geneva Identification System", "GEN# +1.00184296"},
        {"Smithsonian Astrophysical Observation", "SAO 87340"},
        {"Wilson Evans Batten Catalogue", "WEB 16845"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.25315181),
        dec: Angle.Degrees(+21.00288241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13802"},
        {"Hipparcos Number", "HIP 10465"},
        {"Smithsonian Astrophysical Observation", "SAO 75227"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.72522272),
        dec: Angle.Degrees(+21.00589097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72365"},
        {"Smithsonian Astrophysical Observation", "SAO 83525"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.95086674),
        dec: Angle.Degrees(+21.00691451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199876"},
        {"Hipparcos Number", "HIP 103590"},
        {"Geneva Identification System", "GEN# +1.00199876"},
        {"Smithsonian Astrophysical Observation", "SAO 89351"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.83206533),
        dec: Angle.Degrees(+21.00808628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66443"},
        {"Hipparcos Number", "HIP 39503"},
        {"Smithsonian Astrophysical Observation", "SAO 79913"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.11699759),
        dec: Angle.Degrees(+21.00813420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78236"},
        {"Hipparcos Number", "HIP 44792"},
        {"Smithsonian Astrophysical Observation", "SAO 80648"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.93143940),
        dec: Angle.Degrees(+21.00909041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57951",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57951"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.28465199),
        dec: Angle.Degrees(+21.00954414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213423"},
        {"Hipparcos Number", "HIP 111130"},
        {"Geneva Identification System", "GEN# +1.00213423"},
        {"Smithsonian Astrophysical Observation", "SAO 90560"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.69530887),
        dec: Angle.Degrees(+21.01239086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63168",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8711 A"},
        {"Hipparcos Number", "HIP 63168"},
        {"Smithsonian Astrophysical Observation", "SAO 82577"},
    },
    visualMagnitude: 9.38,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.13851806),
        dec: Angle.Degrees(+21.01245756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16703"},
        {"Smithsonian Astrophysical Observation", "SAO 76007"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.73934083),
        dec: Angle.Degrees(+21.01765901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16618"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.45536302),
        dec: Angle.Degrees(+21.01960726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3828"},
        {"Hipparcos Number", "HIP 3225"},
        {"Smithsonian Astrophysical Observation", "SAO 74195"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.24671196),
        dec: Angle.Degrees(+21.02047943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153267"},
        {"Hipparcos Number", "HIP 82994"},
        {"Smithsonian Astrophysical Observation", "SAO 84719"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.40084124),
        dec: Angle.Degrees(+21.02086898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158917"},
        {"Hipparcos Number", "HIP 85726"},
        {"Geneva Identification System", "GEN# +1.00158917"},
        {"Smithsonian Astrophysical Observation", "SAO 85165"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.77467105),
        dec: Angle.Degrees(+21.02136147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250268"},
        {"Hipparcos Number", "HIP 28494"},
        {"Geneva Identification System", "GEN# +1.00250268"},
        {"Wilson Evans Batten Catalogue", "WEB 5568"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.22497402),
        dec: Angle.Degrees(+21.02186958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -361.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6947"},
        {"Smithsonian Astrophysical Observation", "SAO 74750"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.36307189),
        dec: Angle.Degrees(+21.02281065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3732",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3732"},
        {"Smithsonian Astrophysical Observation", "SAO 74281"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.98215511),
        dec: Angle.Degrees(+21.02407565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211823"},
        {"Hipparcos Number", "HIP 110221"},
        {"Smithsonian Astrophysical Observation", "SAO 90417"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.89587247),
        dec: Angle.Degrees(+21.02412177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2173"},
        {"Hipparcos Number", "HIP 2050"},
        {"Smithsonian Astrophysical Observation", "SAO 73978"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.49436297),
        dec: Angle.Degrees(+21.02427624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83682"},
        {"Hipparcos Number", "HIP 47484"},
        {"Geneva Identification System", "GEN# +1.00083682"},
        {"Smithsonian Astrophysical Observation", "SAO 80964"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.19794869),
        dec: Angle.Degrees(+21.02460508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224923"},
        {"Hipparcos Number", "HIP 147"},
        {"Smithsonian Astrophysical Observation", "SAO 91662"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.46604367),
        dec: Angle.Degrees(+21.02624872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166602"},
        {"Hipparcos Number", "HIP 89058"},
        {"Smithsonian Astrophysical Observation", "SAO 85799"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.65558161),
        dec: Angle.Degrees(+21.02791747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61742",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61742"},
        {"Smithsonian Astrophysical Observation", "SAO 82422"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.81571353),
        dec: Angle.Degrees(+21.02894437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5198"},
        {"Hipparcos Number", "HIP 4229"},
        {"Smithsonian Astrophysical Observation", "SAO 74348"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.48746308),
        dec: Angle.Degrees(+21.03092836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15563"},
        {"Hipparcos Number", "HIP 11686"},
        {"Geneva Identification System", "GEN# +1.00015563"},
        {"Smithsonian Astrophysical Observation", "SAO 75413"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.68046783),
        dec: Angle.Degrees(+21.03123204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83644"},
        {"Smithsonian Astrophysical Observation", "SAO 84824"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.42824054),
        dec: Angle.Degrees(+21.03213527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12662"},
        {"Hipparcos Number", "HIP 9674"},
        {"Smithsonian Astrophysical Observation", "SAO 75124"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.11069723),
        dec: Angle.Degrees(+21.03343692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7087"},
        {"Hipparcos Number", "HIP 5571"},
        {"Fundamental Katalog 5th Edition", "FK5 1032"},
        {"Geneva Identification System", "GEN# +1.00007087"},
        {"Smithsonian Astrophysical Observation", "SAO 74544"},
        {"Wilson Evans Batten Catalogue", "WEB 1244"},
    },
    visualMagnitude: 4.66,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.86330901),
        dec: Angle.Degrees(+21.03467568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63105"},
        {"Hipparcos Number", "HIP 38046"},
        {"Smithsonian Astrophysical Observation", "SAO 79700"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.98293286),
        dec: Angle.Degrees(+21.03488763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56964",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8263 AB"},
        {"Henry Draper", "HD 101469"},
        {"Hipparcos Number", "HIP 56964"},
        {"Geneva Identification System", "GEN# +1.00101469J"},
        {"Smithsonian Astrophysical Observation", "SAO 81940"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.16118680),
        dec: Angle.Degrees(+21.03636092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 352179"},
        {"Hipparcos Number", "HIP 100745"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.38852300),
        dec: Angle.Degrees(+21.03830336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247966"},
        {"Hipparcos Number", "HIP 27495"},
        {"Smithsonian Astrophysical Observation", "SAO 77600"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.33552074),
        dec: Angle.Degrees(+21.03919493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96679"},
        {"Hipparcos Number", "HIP 54443"},
        {"Geneva Identification System", "GEN# +1.00096679"},
        {"Smithsonian Astrophysical Observation", "SAO 81687"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.09476930),
        dec: Angle.Degrees(+21.03962782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167828"},
        {"Hipparcos Number", "HIP 89532"},
        {"Renson", "Renson 47070"},
        {"Smithsonian Astrophysical Observation", "SAO 85874"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.03771128),
        dec: Angle.Degrees(+21.03985618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27524"},
        {"Hipparcos Number", "HIP 20349"},
        {"Geneva Identification System", "GEN# +5.20250035"},
        {"Smithsonian Astrophysical Observation", "SAO 76564"},
        {"Wilson Evans Batten Catalogue", "WEB 3885"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.38159824),
        dec: Angle.Degrees(+21.03996454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347735"},
        {"Hipparcos Number", "HIP 103212"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.68110167),
        dec: Angle.Degrees(+21.04101345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205897"},
        {"Hipparcos Number", "HIP 106804"},
        {"Geneva Identification System", "GEN# +1.00205897"},
        {"Smithsonian Astrophysical Observation", "SAO 89858"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.48346762),
        dec: Angle.Degrees(+21.04120130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20150"},
        {"Hipparcos Number", "HIP 15110"},
        {"Fundamental Katalog 5th Edition", "FK5 1089"},
        {"Geneva Identification System", "GEN# +1.00020150"},
        {"Renson", "Renson 5000"},
        {"Smithsonian Astrophysical Observation", "SAO 75810"},
        {"Wilson Evans Batten Catalogue", "WEB 2913"},
    },
    visualMagnitude: 4.87,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.72547816),
        dec: Angle.Degrees(+21.04462873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212098"},
        {"Hipparcos Number", "HIP 110381"},
        {"Smithsonian Astrophysical Observation", "SAO 90441"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.36147856),
        dec: Angle.Degrees(+21.04804949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146991"},
        {"Hipparcos Number", "HIP 79885"},
        {"Geneva Identification System", "GEN# +1.00146991"},
        {"Smithsonian Astrophysical Observation", "SAO 84293"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.59218915),
        dec: Angle.Degrees(+21.04806340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138630"},
        {"Hipparcos Number", "HIP 76108"},
        {"Smithsonian Astrophysical Observation", "SAO 83875"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.15868061),
        dec: Angle.Degrees(+21.04915058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210969"},
        {"Hipparcos Number", "HIP 109732"},
        {"Smithsonian Astrophysical Observation", "SAO 90336"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.41749235),
        dec: Angle.Degrees(+21.04968550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190361"},
        {"Hipparcos Number", "HIP 98791"},
        {"Smithsonian Astrophysical Observation", "SAO 88136"},
        {"Wilson Evans Batten Catalogue", "WEB 17506"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.96599197),
        dec: Angle.Degrees(+21.05043767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7659"},
        {"Hipparcos Number", "HIP 5977"},
        {"Geneva Identification System", "GEN# +1.00007659"},
        {"Smithsonian Astrophysical Observation", "SAO 74601"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.20972157),
        dec: Angle.Degrees(+21.05204582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209621"},
        {"Hipparcos Number", "HIP 108953"},
        {"Geneva Identification System", "GEN# +1.00209621"},
        {"Wilson Evans Batten Catalogue", "WEB 19596"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.10464221),
        dec: Angle.Degrees(+21.05252628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111056"},
        {"Hipparcos Number", "HIP 62344"},
        {"Geneva Identification System", "GEN# +1.00111056"},
        {"Smithsonian Astrophysical Observation", "SAO 82488"},
        {"Wilson Evans Batten Catalogue", "WEB 11073"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.62804949),
        dec: Angle.Degrees(+21.05253526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219525"},
        {"Hipparcos Number", "HIP 114881"},
        {"Smithsonian Astrophysical Observation", "SAO 91136"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.05203454),
        dec: Angle.Degrees(+21.05579246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17803"},
        {"Geneva Identification System", "GEN# +9.80006037"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.16165867),
        dec: Angle.Degrees(+21.05705805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244551"},
        {"Hipparcos Number", "HIP 25936"},
        {"Smithsonian Astrophysical Observation", "SAO 77235"},
        {"Wilson Evans Batten Catalogue", "WEB 5044"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.02506183),
        dec: Angle.Degrees(+21.05734506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147866"},
        {"Hipparcos Number", "HIP 80302"},
        {"Smithsonian Astrophysical Observation", "SAO 84343"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.89872812),
        dec: Angle.Degrees(+21.05754825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9307",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1582 D"},
        {"Henry Draper", "HD 12139"},
        {"Hipparcos Number", "HIP 9307"},
        {"Geneva Identification System", "GEN# +1.00012139"},
        {"Smithsonian Astrophysical Observation", "SAO 75077"},
        {"Wilson Evans Batten Catalogue", "WEB 1955"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.89831329),
        dec: Angle.Degrees(+21.05860461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145163"},
        {"Hipparcos Number", "HIP 79096"},
        {"Geneva Identification System", "GEN# +1.00145163"},
        {"Smithsonian Astrophysical Observation", "SAO 84210"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.17687999),
        dec: Angle.Degrees(+21.05886581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 461"},
        {"Hipparcos Number", "HIP 748"},
        {"Smithsonian Astrophysical Observation", "SAO 73775"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.29606736),
        dec: Angle.Degrees(+21.05936782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87582"},
        {"Smithsonian Astrophysical Observation", "SAO 85510"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.37606482),
        dec: Angle.Degrees(+21.05943788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100885"},
        {"Hipparcos Number", "HIP 56638"},
        {"Smithsonian Astrophysical Observation", "SAO 81901"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.18723835),
        dec: Angle.Degrees(+21.05970349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209694"},
        {"Hipparcos Number", "HIP 109003"},
        {"Smithsonian Astrophysical Observation", "SAO 90211"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.23644280),
        dec: Angle.Degrees(+21.06025345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110024"},
        {"Hipparcos Number", "HIP 61724"},
        {"Fundamental Katalog 5th Edition", "FK5 3012"},
        {"Geneva Identification System", "GEN# +1.00110024"},
        {"Smithsonian Astrophysical Observation", "SAO 82421"},
        {"Wilson Evans Batten Catalogue", "WEB 10981"},
    },
    visualMagnitude: 5.49,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.78065686),
        dec: Angle.Degrees(+21.06258094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73639"},
        {"Hipparcos Number", "HIP 42518"},
        {"Smithsonian Astrophysical Observation", "SAO 80334"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.03221381),
        dec: Angle.Degrees(+21.06276754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111269",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111269"},
        {"Smithsonian Astrophysical Observation", "SAO 90580"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.13315543),
        dec: Angle.Degrees(+21.06326481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115829"},
        {"Hipparcos Number", "HIP 65001"},
        {"Geneva Identification System", "GEN# +1.00115829"},
        {"Smithsonian Astrophysical Observation", "SAO 82779"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.85426333),
        dec: Angle.Degrees(+21.06505442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27310"},
        {"Hipparcos Number", "HIP 20181"},
        {"Smithsonian Astrophysical Observation", "SAO 76550"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.89041108),
        dec: Angle.Degrees(+21.06518183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192024"},
        {"Hipparcos Number", "HIP 99545"},
        {"Geneva Identification System", "GEN# +1.00192024"},
        {"Smithsonian Astrophysical Observation", "SAO 88338"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.02402536),
        dec: Angle.Degrees(+21.06816634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75117",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9600 AB"},
        {"Henry Draper", "HD 136596"},
        {"Hipparcos Number", "HIP 75117"},
        {"Smithsonian Astrophysical Observation", "SAO 83776"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.24857372),
        dec: Angle.Degrees(+21.06818937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202050"},
        {"Hipparcos Number", "HIP 104731"},
        {"Smithsonian Astrophysical Observation", "SAO 89530"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.23086420),
        dec: Angle.Degrees(+21.06851941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344853"},
        {"Hipparcos Number", "HIP 96876"},
        {"Geneva Identification System", "GEN# +1.00344853"},
        {"Smithsonian Astrophysical Observation", "SAO 87575"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.39456556),
        dec: Angle.Degrees(+21.06953608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134283"},
        {"Hipparcos Number", "HIP 74085"},
        {"Smithsonian Astrophysical Observation", "SAO 83681"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.09120096),
        dec: Angle.Degrees(+21.06969524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25519"},
        {"Hipparcos Number", "HIP 18976"},
        {"Smithsonian Astrophysical Observation", "SAO 76421"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.99181292),
        dec: Angle.Degrees(+21.07093788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73121",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73121"},
        {"Geneva Identification System", "GEN# +0.02102704"},
        {"Smithsonian Astrophysical Observation", "SAO 83591"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.16963145),
        dec: Angle.Degrees(+21.07113840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168696"},
        {"Hipparcos Number", "HIP 89862"},
        {"Smithsonian Astrophysical Observation", "SAO 85939"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.07577470),
        dec: Angle.Degrees(+21.07361100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91140",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11480 A"},
        {"Henry Draper", "HD 171704"},
        {"Hipparcos Number", "HIP 91140"},
        {"Geneva Identification System", "GEN# +1.00171704"},
        {"Smithsonian Astrophysical Observation", "SAO 86223"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.87975884),
        dec: Angle.Degrees(+21.07419477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3348"},
        {"Hipparcos Number", "HIP 2877"},
        {"Geneva Identification System", "GEN# +1.00003348"},
        {"Smithsonian Astrophysical Observation", "SAO 74140"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.11438023),
        dec: Angle.Degrees(+21.07434391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50156"},
        {"Geneva Identification System", "GEN# +6.20030124"},
        {"Wilson Evans Batten Catalogue", "WEB 9219"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.58027883),
        dec: Angle.Degrees(+21.07525150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191531"},
        {"Hipparcos Number", "HIP 99327"},
        {"Smithsonian Astrophysical Observation", "SAO 88266"},
        {"Wilson Evans Batten Catalogue", "WEB 17723"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.41498401),
        dec: Angle.Degrees(+21.07881008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73591"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.63359007),
        dec: Angle.Degrees(+21.07940256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162135"},
        {"Hipparcos Number", "HIP 87178"},
        {"Smithsonian Astrophysical Observation", "SAO 85431"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.16294188),
        dec: Angle.Degrees(+21.08006584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68813"},
        {"Hipparcos Number", "HIP 40404"},
        {"Geneva Identification System", "GEN# +1.00068813"},
        {"Smithsonian Astrophysical Observation", "SAO 80039"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.73103233),
        dec: Angle.Degrees(+21.08020137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75557"},
        {"Hipparcos Number", "HIP 43479"},
        {"Smithsonian Astrophysical Observation", "SAO 80460"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.84418606),
        dec: Angle.Degrees(+21.08042787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7250",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7250"},
        {"Smithsonian Astrophysical Observation", "SAO 74791"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.35276190),
        dec: Angle.Degrees(+21.15225239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57134",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8275 AB"},
        {"Henry Draper", "HD 101770"},
        {"Hipparcos Number", "HIP 57134"},
        {"Smithsonian Astrophysical Observation", "SAO 81952"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.71220308),
        dec: Angle.Degrees(+21.08048307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96691"},
        {"Hipparcos Number", "HIP 54450"},
        {"Geneva Identification System", "GEN# +1.00096691"},
        {"Smithsonian Astrophysical Observation", "SAO 81688"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.11049486),
        dec: Angle.Degrees(+21.08147097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5295"},
        {"Hipparcos Number", "HIP 4296"},
        {"Smithsonian Astrophysical Observation", "SAO 74362"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.75554427),
        dec: Angle.Degrees(+21.08336982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134247"},
        {"Hipparcos Number", "HIP 74065"},
        {"Smithsonian Astrophysical Observation", "SAO 83679"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.04683870),
        dec: Angle.Degrees(+21.08575640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130003"},
        {"Hipparcos Number", "HIP 72127"},
        {"Smithsonian Astrophysical Observation", "SAO 83503"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.31854266),
        dec: Angle.Degrees(+21.08604192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190048"},
        {"Hipparcos Number", "HIP 98662"},
        {"Wilson Evans Batten Catalogue", "WEB 17457"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.59616742),
        dec: Angle.Degrees(+21.09024606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110759"},
        {"Smithsonian Astrophysical Observation", "SAO 90505"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.57849129),
        dec: Angle.Degrees(+21.09076821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119563"},
        {"Hipparcos Number", "HIP 66980"},
        {"Geneva Identification System", "GEN# +1.00119563"},
        {"Renson", "Renson 34504"},
        {"Smithsonian Astrophysical Observation", "SAO 82967"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.91221708),
        dec: Angle.Degrees(+21.09563986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110734",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110734"},
        {"Smithsonian Astrophysical Observation", "SAO 90500"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.51861468),
        dec: Angle.Degrees(+21.09691726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42106",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42106"},
        {"New General Catalogue", "NGC 2632 4346"},
    },
    visualMagnitude: 11.15,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.74853497),
        dec: Angle.Degrees(+21.09703113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14810"},
        {"Smithsonian Astrophysical Observation", "SAO 75776"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.80930127),
        dec: Angle.Degrees(+21.09748894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344849"},
        {"Hipparcos Number", "HIP 96981"},
        {"Smithsonian Astrophysical Observation", "SAO 87606"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.69719941),
        dec: Angle.Degrees(+21.09769229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349043"},
        {"Hipparcos Number", "HIP 91547"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.04122706),
        dec: Angle.Degrees(+21.09802464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3468"},
        {"Hipparcos Number", "HIP 2965"},
        {"Geneva Identification System", "GEN# +1.00003468"},
        {"Smithsonian Astrophysical Observation", "SAO 74154"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.41955556),
        dec: Angle.Degrees(+21.09977614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284889"},
        {"Hipparcos Number", "HIP 22827"},
        {"Smithsonian Astrophysical Observation", "SAO 76829"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.68525824),
        dec: Angle.Degrees(+21.09979778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61204",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8592 AB"},
        {"Hipparcos Number", "HIP 61204"},
        {"Geneva Identification System", "GEN# +0.02102429J"},
        {"Smithsonian Astrophysical Observation", "SAO 82367"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.12951058),
        dec: Angle.Degrees(+21.10094294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284787"},
        {"Hipparcos Number", "HIP 22350"},
        {"Geneva Identification System", "GEN# +5.20250115"},
        {"Geneva Identification System 2", "GEN# +1.00284787"},
        {"Smithsonian Astrophysical Observation", "SAO 76766"},
        {"Wilson Evans Batten Catalogue", "WEB 4309"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.17530440),
        dec: Angle.Degrees(+21.10109968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43208"},
        {"Hipparcos Number", "HIP 29744"},
        {"Geneva Identification System", "GEN# +1.00043208"},
        {"Smithsonian Astrophysical Observation", "SAO 78153"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.97065358),
        dec: Angle.Degrees(+21.10210048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99191",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13412 AB"},
        {"Henry Draper", "HD 345912"},
        {"Hipparcos Number", "HIP 99191"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.05193941),
        dec: Angle.Degrees(+21.10317706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191065"},
        {"Hipparcos Number", "HIP 99103"},
        {"Smithsonian Astrophysical Observation", "SAO 88215"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.80764819),
        dec: Angle.Degrees(+21.10369184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346567"},
        {"Hipparcos Number", "HIP 100662"},
        {"Smithsonian Astrophysical Observation", "SAO 88635"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.15393427),
        dec: Angle.Degrees(+21.10514877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64351"},
        {"Hipparcos Number", "HIP 38601"},
        {"Smithsonian Astrophysical Observation", "SAO 79782"},
        {"Wilson Evans Batten Catalogue", "WEB 7578"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.55543385),
        dec: Angle.Degrees(+21.10529949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200254"},
        {"Hipparcos Number", "HIP 103784"},
        {"Geneva Identification System", "GEN# +1.00200254"},
        {"Smithsonian Astrophysical Observation", "SAO 89379"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.46219238),
        dec: Angle.Degrees(+21.10534911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28966"},
        {"Hipparcos Number", "HIP 21318"},
        {"Smithsonian Astrophysical Observation", "SAO 76657"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.64747098),
        dec: Angle.Degrees(+21.10582078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39826"},
        {"Geneva Identification System", "GEN# +0.02101764A"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.05571748),
        dec: Angle.Degrees(+21.10593059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -299.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -354.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95624",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12451 C"},
        {"Henry Draper", "HD 183058"},
        {"Hipparcos Number", "HIP 95624"},
        {"Celescope Catalog", "CEL 4755"},
        {"Geneva Identification System", "GEN# +1.00183058"},
        {"Smithsonian Astrophysical Observation", "SAO 87222"},
        {"Wilson Evans Batten Catalogue", "WEB 16727"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.74529483),
        dec: Angle.Degrees(+21.10638294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51420"},
        {"Hipparcos Number", "HIP 33531"},
        {"Smithsonian Astrophysical Observation", "SAO 78920"},
    },
    visualMagnitude: 8.81,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.53150321),
        dec: Angle.Degrees(+21.10943912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2778"},
        {"Hipparcos Number", "HIP 2481"},
        {"Smithsonian Astrophysical Observation", "SAO 74062"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.88050594),
        dec: Angle.Degrees(+21.11023518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69378"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.03975969),
        dec: Angle.Degrees(+21.11079587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96434"},
        {"Hipparcos Number", "HIP 54352"},
        {"Geneva Identification System", "GEN# +1.00096434"},
        {"Smithsonian Astrophysical Observation", "SAO 81675"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.79725034),
        dec: Angle.Degrees(+21.11512631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8608",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1470 A"},
        {"Henry Draper", "HD 11256"},
        {"Hipparcos Number", "HIP 8608"},
        {"Geneva Identification System", "GEN# +1.00011256"},
        {"Smithsonian Astrophysical Observation", "SAO 74981"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.75814678),
        dec: Angle.Degrees(+21.11557759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15734"},
        {"Hipparcos Number", "HIP 11803"},
        {"Geneva Identification System", "GEN# +1.00015734"},
        {"Smithsonian Astrophysical Observation", "SAO 75428"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.06159406),
        dec: Angle.Degrees(+21.11809931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223390"},
        {"Hipparcos Number", "HIP 117465"},
        {"Smithsonian Astrophysical Observation", "SAO 91509"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.26285824),
        dec: Angle.Degrees(+21.11933794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5115",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 896 AB"},
        {"Henry Draper", "HD 6439"},
        {"Hipparcos Number", "HIP 5115"},
        {"Smithsonian Astrophysical Observation", "SAO 74481"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.38506172),
        dec: Angle.Degrees(+21.12079111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81998"},
        {"Geneva Identification System", "GEN# +6.20030773"},
    },
    visualMagnitude: 10.43,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.26281879),
        dec: Angle.Degrees(+21.12153405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37909",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6347 AB"},
        {"Henry Draper", "HD 62720"},
        {"Hipparcos Number", "HIP 37909"},
        {"Geneva Identification System", "GEN# +1.00062720J"},
        {"Smithsonian Astrophysical Observation", "SAO 79680"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.53306860),
        dec: Angle.Degrees(+21.12202095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8607",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1470 B"},
        {"Hipparcos Number", "HIP 8607"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.75786866),
        dec: Angle.Degrees(+21.12271294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129430"},
        {"Hipparcos Number", "HIP 71857"},
        {"Geneva Identification System", "GEN# +1.00129430"},
        {"Smithsonian Astrophysical Observation", "SAO 83474"},
        {"Wilson Evans Batten Catalogue", "WEB 12378"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.47600319),
        dec: Angle.Degrees(+21.12368832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60153"},
        {"Hipparcos Number", "HIP 36789"},
        {"Smithsonian Astrophysical Observation", "SAO 79504"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.50135955),
        dec: Angle.Degrees(+21.12383240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109718"},
        {"Smithsonian Astrophysical Observation", "SAO 90333"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.35787019),
        dec: Angle.Degrees(+21.12772188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56942"},
        {"Hipparcos Number", "HIP 35521"},
        {"Smithsonian Astrophysical Observation", "SAO 79289"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.97890318),
        dec: Angle.Degrees(+21.12813230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86608"},
        {"Smithsonian Astrophysical Observation", "SAO 85329"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.47982312),
        dec: Angle.Degrees(+21.12906339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30202",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4962 A"},
        {"Henry Draper", "HD 44171"},
        {"Hipparcos Number", "HIP 30202"},
        {"Celescope Catalog", "CEL 1188"},
        {"Geneva Identification System", "GEN# +1.00044171"},
        {"Geneva Identification System 2", "GEN# +1.00044171A"},
        {"Smithsonian Astrophysical Observation", "SAO 78264"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.31034068),
        dec: Angle.Degrees(+21.13243408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35481"},
        {"Hipparcos Number", "HIP 25385"},
        {"Smithsonian Astrophysical Observation", "SAO 77161"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.46531453),
        dec: Angle.Degrees(+21.13255336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147266"},
        {"Hipparcos Number", "HIP 80021"},
        {"Geneva Identification System", "GEN# +1.00147266"},
        {"Smithsonian Astrophysical Observation", "SAO 84306"},
        {"Wilson Evans Batten Catalogue", "WEB 13549"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.01787748),
        dec: Angle.Degrees(+21.13273671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218396"},
        {"Hipparcos Number", "HIP 114189"},
        {"Fundamental Katalog 5th Edition", "FK5 3850"},
        {"Geneva Identification System", "GEN# +1.00218396"},
        {"Smithsonian Astrophysical Observation", "SAO 91022"},
        {"Wilson Evans Batten Catalogue", "WEB 20279"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.86936478),
        dec: Angle.Degrees(+21.13437231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191814"},
        {"Hipparcos Number", "HIP 99445"},
        {"Geneva Identification System", "GEN# +1.00191814"},
        {"Smithsonian Astrophysical Observation", "SAO 88309"},
        {"Wilson Evans Batten Catalogue", "WEB 17769"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.76469664),
        dec: Angle.Degrees(+21.13450274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18244"},
    },
    visualMagnitude: 11.16,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.53127916),
        dec: Angle.Degrees(+21.13506021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38796"},
        {"Hipparcos Number", "HIP 27486"},
        {"Celescope Catalog", "CEL 987"},
        {"Geneva Identification System", "GEN# +1.00038796"},
        {"Smithsonian Astrophysical Observation", "SAO 77596"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.30329227),
        dec: Angle.Degrees(+21.13604799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250430"},
        {"Hipparcos Number", "HIP 28555"},
        {"Smithsonian Astrophysical Observation", "SAO 77857"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.41468074),
        dec: Angle.Degrees(+21.13691775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27973"},
        {"Hipparcos Number", "HIP 20680"},
        {"Smithsonian Astrophysical Observation", "SAO 76606"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.44806341),
        dec: Angle.Degrees(+21.13810760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35703"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.50073853),
        dec: Angle.Degrees(+21.13843689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94848"},
        {"Hipparcos Number", "HIP 53550"},
        {"Geneva Identification System", "GEN# +1.00094848"},
        {"Smithsonian Astrophysical Observation", "SAO 81598"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.32371205),
        dec: Angle.Degrees(+21.14057981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27295"},
        {"Hipparcos Number", "HIP 20171"},
        {"Celescope Catalog", "CEL 385"},
        {"Geneva Identification System", "GEN# +1.00027295"},
        {"Renson", "Renson 7000"},
        {"Smithsonian Astrophysical Observation", "SAO 76548"},
        {"Wilson Evans Batten Catalogue", "WEB 3846"},
    },
    visualMagnitude: 5.50,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.85866225),
        dec: Angle.Degrees(+21.14241058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26451",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tianguan"},
        {"Henry Draper", "HD 37202"},
        {"Hipparcos Number", "HIP 26451"},
        {"Celescope Catalog", "CEL 864"},
        {"Fundamental Katalog 5th Edition", "FK5 211"},
        {"Geneva Identification System", "GEN# +1.00037202"},
        {"Smithsonian Astrophysical Observation", "SAO 77336"},
        {"Wilson Evans Batten Catalogue", "WEB 5213"},
    },
    visualMagnitude: 2.97,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.41118447),
        dec: Angle.Degrees(+21.14259299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109406"},
        {"Smithsonian Astrophysical Observation", "SAO 90280"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.48561946),
        dec: Angle.Degrees(+21.14395662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131807"},
        {"Hipparcos Number", "HIP 73001"},
        {"Smithsonian Astrophysical Observation", "SAO 83578"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.78843145),
        dec: Angle.Degrees(+21.14400325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20756"},
        {"Hipparcos Number", "HIP 15627"},
        {"Fundamental Katalog 5th Edition", "FK5 1094"},
        {"Geneva Identification System", "GEN# +1.00020756"},
        {"Smithsonian Astrophysical Observation", "SAO 75886"},
        {"Wilson Evans Batten Catalogue", "WEB 2997"},
    },
    visualMagnitude: 5.27,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.30671225),
        dec: Angle.Degrees(+21.14714057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16956"},
        {"Hipparcos Number", "HIP 12733"},
        {"Geneva Identification System", "GEN# +1.00016956"},
        {"Renson", "Renson 4310"},
        {"Smithsonian Astrophysical Observation", "SAO 75537"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.92118289),
        dec: Angle.Degrees(+21.14716003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71428"},
        {"Hipparcos Number", "HIP 41524"},
        {"Fundamental Katalog 5th Edition", "FK5 4762"},
        {"Geneva Identification System", "GEN# +1.00071428"},
        {"Smithsonian Astrophysical Observation", "SAO 80201"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.02978810),
        dec: Angle.Degrees(+21.14880803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224671"},
        {"Hipparcos Number", "HIP 118313"},
        {"Geneva Identification System", "GEN# +1.00224671"},
        {"Smithsonian Astrophysical Observation", "SAO 91641"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.95581726),
        dec: Angle.Degrees(+21.14973973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96512"},
        {"Hipparcos Number", "HIP 54377"},
        {"Smithsonian Astrophysical Observation", "SAO 81678"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.87724904),
        dec: Angle.Degrees(+21.15080621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284552"},
        {"Hipparcos Number", "HIP 21256"},
        {"Geneva Identification System", "GEN# +5.20252066"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.40463599),
        dec: Angle.Degrees(+21.15096365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242663"},
        {"Hipparcos Number", "HIP 24888"},
        {"Smithsonian Astrophysical Observation", "SAO 77111"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.02250552),
        dec: Angle.Degrees(+21.15161116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71339"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.83830951),
        dec: Angle.Degrees(+21.15238386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113848"},
        {"Hipparcos Number", "HIP 63948"},
        {"Fundamental Katalog 5th Edition", "FK5 1339"},
        {"Geneva Identification System", "GEN# +1.00113848"},
        {"Smithsonian Astrophysical Observation", "SAO 82650"},
        {"Wilson Evans Batten Catalogue", "WEB 11303"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.58867941),
        dec: Angle.Degrees(+21.15351000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65324"},
        {"Hipparcos Number", "HIP 39002"},
        {"Smithsonian Astrophysical Observation", "SAO 79833"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.72651264),
        dec: Angle.Degrees(+21.15378376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157375"},
        {"Hipparcos Number", "HIP 84972"},
        {"Smithsonian Astrophysical Observation", "SAO 85036"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.50470029),
        dec: Angle.Degrees(+21.15469459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102779"},
        {"Hipparcos Number", "HIP 57711"},
        {"Geneva Identification System", "GEN# +1.00102779"},
        {"Smithsonian Astrophysical Observation", "SAO 82009"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.53266111),
        dec: Angle.Degrees(+21.15663858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188188"},
        {"Hipparcos Number", "HIP 97863"},
        {"Smithsonian Astrophysical Observation", "SAO 87866"},
        {"Wilson Evans Batten Catalogue", "WEB 17216"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.29891758),
        dec: Angle.Degrees(+21.15791973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23951"},
        {"Hipparcos Number", "HIP 17909"},
        {"Smithsonian Astrophysical Observation", "SAO 76246"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.44770818),
        dec: Angle.Degrees(+21.16008063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208551"},
        {"Hipparcos Number", "HIP 108316"},
        {"Smithsonian Astrophysical Observation", "SAO 90117"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.14978103),
        dec: Angle.Degrees(+21.16113832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33179",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5553 AB"},
        {"Henry Draper", "HD 50482"},
        {"Hipparcos Number", "HIP 33179"},
        {"Smithsonian Astrophysical Observation", "SAO 78852"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.58877565),
        dec: Angle.Degrees(+21.16146391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95612",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12451 AB"},
        {"Henry Draper", "HD 183014"},
        {"Hipparcos Number", "HIP 95612"},
        {"Celescope Catalog", "CEL 4753"},
        {"Smithsonian Astrophysical Observation", "SAO 87218"},
        {"Wilson Evans Batten Catalogue", "WEB 16722"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.70157410),
        dec: Angle.Degrees(+21.16284702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87718"},
        {"Hipparcos Number", "HIP 49585"},
        {"Smithsonian Astrophysical Observation", "SAO 81191"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.83405794),
        dec: Angle.Degrees(+21.16341764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4833"},
        {"Hipparcos Number", "HIP 3936"},
        {"Geneva Identification System", "GEN# +1.00004833"},
        {"Smithsonian Astrophysical Observation", "SAO 74303"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.63459887),
        dec: Angle.Degrees(+21.16352423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60773"},
        {"Hipparcos Number", "HIP 37067"},
        {"Smithsonian Astrophysical Observation", "SAO 79552"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.26137333),
        dec: Angle.Degrees(+21.16356263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184850"},
        {"Hipparcos Number", "HIP 96369"},
        {"Geneva Identification System", "GEN# +1.00184850"},
        {"Smithsonian Astrophysical Observation", "SAO 87406"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.89861213),
        dec: Angle.Degrees(+21.16437639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15189"},
        {"Smithsonian Astrophysical Observation", "SAO 75819"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.94178464),
        dec: Angle.Degrees(+21.16512889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224204"},
        {"Hipparcos Number", "HIP 117990"},
        {"Geneva Identification System", "GEN# +1.00224204"},
        {"Smithsonian Astrophysical Observation", "SAO 91585"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.99323314),
        dec: Angle.Degrees(+21.16591425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76780"},
        {"Hipparcos Number", "HIP 44097"},
        {"Geneva Identification System", "GEN# +1.00076780"},
        {"Smithsonian Astrophysical Observation", "SAO 80552"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.73241393),
        dec: Angle.Degrees(+21.16639805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92321",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11715 AB"},
        {"Henry Draper", "HD 174261"},
        {"Hipparcos Number", "HIP 92321"},
        {"Geneva Identification System", "GEN# +1.00174261J"},
        {"Smithsonian Astrophysical Observation", "SAO 86458"},
        {"Wilson Evans Batten Catalogue", "WEB 15939"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.24097057),
        dec: Angle.Degrees(+21.16703166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88737"},
        {"Hipparcos Number", "HIP 50174"},
        {"Geneva Identification System", "GEN# +1.00088737"},
        {"Smithsonian Astrophysical Observation", "SAO 81250"},
        {"Wilson Evans Batten Catalogue", "WEB 9220"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.62432406),
        dec: Angle.Degrees(+21.16823270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139894"},
        {"Hipparcos Number", "HIP 76718"},
        {"Smithsonian Astrophysical Observation", "SAO 83936"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.99076363),
        dec: Angle.Degrees(+21.16890165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248641"},
        {"Hipparcos Number", "HIP 27785"},
        {"Smithsonian Astrophysical Observation", "SAO 77663"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.19636388),
        dec: Angle.Degrees(+21.16899396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70391"},
        {"Smithsonian Astrophysical Observation", "SAO 83328"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.02924170),
        dec: Angle.Degrees(+21.16903472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112057"},
        {"Wilson Evans Batten Catalogue", "WEB 20004"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.45156401),
        dec: Angle.Degrees(+21.17017589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152629"},
        {"Hipparcos Number", "HIP 82654"},
        {"Smithsonian Astrophysical Observation", "SAO 84674"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.44077992),
        dec: Angle.Degrees(+21.17288811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62130",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8649 A"},
        {"Henry Draper", "HD 110721"},
        {"Hipparcos Number", "HIP 62130"},
        {"Geneva Identification System", "GEN# +1.00110721"},
        {"Smithsonian Astrophysical Observation", "SAO 82462"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.99944150),
        dec: Angle.Degrees(+21.17296098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52712"},
        {"Hipparcos Number", "HIP 33992"},
        {"Geneva Identification System", "GEN# +1.00052712"},
        {"Smithsonian Astrophysical Observation", "SAO 79005"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.79424133),
        dec: Angle.Degrees(+21.17481475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345055"},
        {"Hipparcos Number", "HIP 97563"},
        {"Geneva Identification System", "GEN# +8.02210013"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.44889755),
        dec: Angle.Degrees(+21.17581733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9558"},
        {"Hipparcos Number", "HIP 7317"},
        {"Smithsonian Astrophysical Observation", "SAO 74800"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.55169212),
        dec: Angle.Degrees(+21.17701284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138021"},
        {"Hipparcos Number", "HIP 75766"},
        {"Smithsonian Astrophysical Observation", "SAO 83842"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.17492367),
        dec: Angle.Degrees(+21.17735072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40650"},
        {"Smithsonian Astrophysical Observation", "SAO 80075"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.46817356),
        dec: Angle.Degrees(+21.17760494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77179",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77179"},
        {"Cincinnati Publication", "Ci 18 2110"},
        {"Smithsonian Astrophysical Observation", "SAO 83988"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.37579245),
        dec: Angle.Degrees(+21.17853852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -250.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347191"},
        {"Hipparcos Number", "HIP 101945"},
        {"Geneva Identification System", "GEN# +1.00347191"},
        {"Smithsonian Astrophysical Observation", "SAO 88966"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.88413605),
        dec: Angle.Degrees(+21.20457709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85040"},
        {"Hipparcos Number", "HIP 48218"},
        {"Fundamental Katalog 5th Edition", "FK5 2785"},
        {"Geneva Identification System", "GEN# +1.00085040"},
        {"Renson", "Renson 24280"},
        {"Smithsonian Astrophysical Observation", "SAO 81035"},
        {"Wilson Evans Batten Catalogue", "WEB 8999"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.45884141),
        dec: Angle.Degrees(+21.17945754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43725"},
        {"Hipparcos Number", "HIP 29981"},
        {"Geneva Identification System", "GEN# +1.00043725"},
        {"Smithsonian Astrophysical Observation", "SAO 78208"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.66677456),
        dec: Angle.Degrees(+21.18065340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218791"},
        {"Hipparcos Number", "HIP 114442"},
        {"Smithsonian Astrophysical Observation", "SAO 91060"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.65954802),
        dec: Angle.Degrees(+21.18323636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10883"},
        {"Hipparcos Number", "HIP 8308"},
        {"Smithsonian Astrophysical Observation", "SAO 74930"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.79069770),
        dec: Angle.Degrees(+21.18374556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85490"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.06593850),
        dec: Angle.Degrees(+21.18563421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67944"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.71161848),
        dec: Angle.Degrees(+21.18770220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16629"},
        {"Hipparcos Number", "HIP 12468"},
        {"Smithsonian Astrophysical Observation", "SAO 75509"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.13209781),
        dec: Angle.Degrees(+21.18780804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179167"},
        {"Hipparcos Number", "HIP 94207"},
        {"Smithsonian Astrophysical Observation", "SAO 86893"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.68674760),
        dec: Angle.Degrees(+21.18908344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220043"},
        {"Hipparcos Number", "HIP 115249"},
        {"Smithsonian Astrophysical Observation", "SAO 91184"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.15880905),
        dec: Angle.Degrees(+21.18938870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11559"},
        {"Smithsonian Astrophysical Observation", "SAO 75395"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.22882780),
        dec: Angle.Degrees(+21.18962786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70989"},
        {"Hipparcos Number", "HIP 41311"},
        {"Smithsonian Astrophysical Observation", "SAO 80176"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.43412773),
        dec: Angle.Degrees(+21.19062116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69066",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9118 AB"},
        {"Henry Draper", "HD 123613"},
        {"Hipparcos Number", "HIP 69066"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.06468488),
        dec: Angle.Degrees(+21.19314786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83470"},
        {"Hipparcos Number", "HIP 47383"},
        {"Geneva Identification System", "GEN# +1.00083470"},
        {"Smithsonian Astrophysical Observation", "SAO 80956"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.80438575),
        dec: Angle.Degrees(+21.19747499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61584",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8611 AB"},
        {"Henry Draper", "HD 109782"},
        {"Hipparcos Number", "HIP 61584"},
        {"Renson", "Renson 31830"},
        {"Smithsonian Astrophysical Observation", "SAO 82402"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.29505481),
        dec: Angle.Degrees(+21.19798210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30211",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4962 D"},
        {"Henry Draper", "HD 44193"},
        {"Hipparcos Number", "HIP 30211"},
        {"Celescope Catalog", "CEL 1190"},
        {"Geneva Identification System", "GEN# +1.00044193"},
        {"Geneva Identification System 2", "GEN# +1.00044171D"},
        {"Smithsonian Astrophysical Observation", "SAO 78267"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.34230912),
        dec: Angle.Degrees(+21.19977552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196724"},
        {"Hipparcos Number", "HIP 101867"},
        {"Fundamental Katalog 5th Edition", "FK5 1539"},
        {"Geneva Identification System", "GEN# +1.00196724"},
        {"Smithsonian Astrophysical Observation", "SAO 88944"},
        {"Wilson Evans Batten Catalogue", "WEB 18404"},
    },
    visualMagnitude: 4.81,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.63038481),
        dec: Angle.Degrees(+21.20117964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93076"},
        {"Hipparcos Number", "HIP 52592"},
        {"Smithsonian Astrophysical Observation", "SAO 81501"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.30943982),
        dec: Angle.Degrees(+21.20465293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8382",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8382"},
        {"Cincinnati Publication", "Ci 20 128"},
    },
    visualMagnitude: 12.24,
    bvColour: 1.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.01565093),
        dec: Angle.Degrees(+21.20726838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 341.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193314"},
        {"Hipparcos Number", "HIP 100147"},
        {"Smithsonian Astrophysical Observation", "SAO 88500"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.71676033),
        dec: Angle.Degrees(+21.21009863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13555"},
        {"Hipparcos Number", "HIP 10306"},
        {"Geneva Identification System", "GEN# +1.00013555"},
        {"Smithsonian Astrophysical Observation", "SAO 75204"},
        {"Wilson Evans Batten Catalogue", "WEB 2149"},
    },
    visualMagnitude: 5.23,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.19993262),
        dec: Angle.Degrees(+21.21098318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78869"},
        {"Smithsonian Astrophysical Observation", "SAO 84194"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.48642515),
        dec: Angle.Degrees(+21.21290918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59567"},
        {"Geneva Identification System", "GEN# +0.02202450"},
        {"Smithsonian Astrophysical Observation", "SAO 82188"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.23352655),
        dec: Angle.Degrees(+21.21338190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15939",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15939"},
        {"Smithsonian Astrophysical Observation", "SAO 75923"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.30844527),
        dec: Angle.Degrees(+21.21410615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155395"},
        {"Hipparcos Number", "HIP 84020"},
        {"Geneva Identification System", "GEN# +1.00155395"},
        {"Smithsonian Astrophysical Observation", "SAO 84891"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.62752912),
        dec: Angle.Degrees(+21.21554847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217557"},
        {"Hipparcos Number", "HIP 113668"},
        {"Smithsonian Astrophysical Observation", "SAO 90953"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.32213946),
        dec: Angle.Degrees(+21.21637072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217385"},
        {"Hipparcos Number", "HIP 113560"},
        {"Geneva Identification System", "GEN# +1.00217385"},
        {"Smithsonian Astrophysical Observation", "SAO 90930"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.01577262),
        dec: Angle.Degrees(+21.21972395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76012"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.86975044),
        dec: Angle.Degrees(+21.22196200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16644"},
        {"Hipparcos Number", "HIP 12487"},
        {"Geneva Identification System", "GEN# +1.00016644"},
        {"Smithsonian Astrophysical Observation", "SAO 75511"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.16645047),
        dec: Angle.Degrees(+21.22247670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33864"},
        {"Hipparcos Number", "HIP 24403"},
        {"Smithsonian Astrophysical Observation", "SAO 77043"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.52390675),
        dec: Angle.Degrees(+21.22370663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148453"},
        {"Hipparcos Number", "HIP 80602"},
        {"Geneva Identification System", "GEN# +1.00148453"},
        {"Smithsonian Astrophysical Observation", "SAO 84383"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.85701161),
        dec: Angle.Degrees(+21.22413911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179528"},
        {"Hipparcos Number", "HIP 94355"},
        {"Smithsonian Astrophysical Observation", "SAO 86924"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.07765263),
        dec: Angle.Degrees(+21.22473222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343341"},
        {"Hipparcos Number", "HIP 92699"},
        {"Smithsonian Astrophysical Observation", "SAO 86541"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.32308089),
        dec: Angle.Degrees(+21.22573792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78522"},
    },
    visualMagnitude: 11.24,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.46338922),
        dec: Angle.Degrees(+21.22596607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214526"},
        {"Hipparcos Number", "HIP 111774"},
        {"Smithsonian Astrophysical Observation", "SAO 90668"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.62006558),
        dec: Angle.Degrees(+21.22742518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155642"},
        {"Hipparcos Number", "HIP 84137"},
        {"Geneva Identification System", "GEN# +1.00155642J"},
        {"Smithsonian Astrophysical Observation", "SAO 84910"},
        {"Wilson Evans Batten Catalogue", "WEB 14209"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.02524002),
        dec: Angle.Degrees(+21.22899459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206525"},
        {"Hipparcos Number", "HIP 107139"},
        {"Smithsonian Astrophysical Observation", "SAO 89913"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.52458921),
        dec: Angle.Degrees(+21.22960776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344279"},
        {"Hipparcos Number", "HIP 95165"},
        {"Geneva Identification System", "GEN# +1.00344279"},
        {"Smithsonian Astrophysical Observation", "SAO 87112"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.41406304),
        dec: Angle.Degrees(+21.23027542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69221"},
        {"Hipparcos Number", "HIP 40544"},
        {"Geneva Identification System", "GEN# +1.00069221"},
        {"Smithsonian Astrophysical Observation", "SAO 80063"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.18952333),
        dec: Angle.Degrees(+21.23104902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180317"},
        {"Hipparcos Number", "HIP 94620"},
        {"Geneva Identification System", "GEN# +1.00180317"},
        {"Smithsonian Astrophysical Observation", "SAO 86987"},
        {"Wilson Evans Batten Catalogue", "WEB 16491"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.82224652),
        dec: Angle.Degrees(+21.23209944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242169"},
        {"Hipparcos Number", "HIP 24602"},
        {"Geneva Identification System", "GEN# +0.02100804"},
        {"Geneva Identification System 2", "GEN# +1.00242169"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.15558910),
        dec: Angle.Degrees(+21.23252432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198239"},
        {"Hipparcos Number", "HIP 102678"},
        {"Smithsonian Astrophysical Observation", "SAO 89144"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.09782771),
        dec: Angle.Degrees(+21.23328890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114520"},
        {"Hipparcos Number", "HIP 64312"},
        {"Geneva Identification System", "GEN# +1.00114520J"},
        {"Smithsonian Astrophysical Observation", "SAO 82692"},
        {"Wilson Evans Batten Catalogue", "WEB 11366"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.71808031),
        dec: Angle.Degrees(+21.23388837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150363"},
        {"Hipparcos Number", "HIP 81601"},
        {"Smithsonian Astrophysical Observation", "SAO 84525"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.96753550),
        dec: Angle.Degrees(+21.23797565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95035"},
        {"Hipparcos Number", "HIP 53653"},
        {"Smithsonian Astrophysical Observation", "SAO 81604"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.65388776),
        dec: Angle.Degrees(+21.23806342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191672"},
        {"Hipparcos Number", "HIP 99386"},
        {"Geneva Identification System", "GEN# +1.00191672"},
        {"Smithsonian Astrophysical Observation", "SAO 88287"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.58885059),
        dec: Angle.Degrees(+21.23936188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208527"},
        {"Hipparcos Number", "HIP 108296"},
        {"Fundamental Katalog 5th Edition", "FK5 1579"},
        {"Geneva Identification System", "GEN# +1.00208527"},
        {"Smithsonian Astrophysical Observation", "SAO 90112"},
        {"Wilson Evans Batten Catalogue", "WEB 19509"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.09993076),
        dec: Angle.Degrees(+21.23982286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177699"},
        {"Hipparcos Number", "HIP 93721"},
        {"Smithsonian Astrophysical Observation", "SAO 86782"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.24617427),
        dec: Angle.Degrees(+21.24005264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 255676"},
        {"Hipparcos Number", "HIP 30241"},
        {"Smithsonian Astrophysical Observation", "SAO 78270"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.43080094),
        dec: Angle.Degrees(+21.24135321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124986"},
        {"Hipparcos Number", "HIP 69715"},
        {"Geneva Identification System", "GEN# +1.00124986"},
        {"Smithsonian Astrophysical Observation", "SAO 83257"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.04686646),
        dec: Angle.Degrees(+21.24275234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346824"},
        {"Hipparcos Number", "HIP 101232"},
        {"Geneva Identification System", "GEN# +1.00346824"},
        {"Smithsonian Astrophysical Observation", "SAO 88790"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.79703154),
        dec: Angle.Degrees(+21.24407498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62886",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8695 AB"},
        {"Henry Draper", "HD 112033"},
        {"Hipparcos Number", "HIP 62886"},
        {"Geneva Identification System", "GEN# +1.00112033"},
        {"Smithsonian Astrophysical Observation", "SAO 82550"},
        {"Wilson Evans Batten Catalogue", "WEB 11149"},
    },
    visualMagnitude: 4.89,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.32404513),
        dec: Angle.Degrees(+21.24502058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70178"},
        {"Smithsonian Astrophysical Observation", "SAO 83305"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.37499884),
        dec: Angle.Degrees(+21.24582721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142909"},
        {"Hipparcos Number", "HIP 78070"},
        {"Smithsonian Astrophysical Observation", "SAO 84086"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.10975535),
        dec: Angle.Degrees(+21.24591934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23388"},
        {"Hipparcos Number", "HIP 17552"},
        {"Geneva Identification System", "GEN# +5.20223316"},
        {"Smithsonian Astrophysical Observation", "SAO 76150"},
        {"Wilson Evans Batten Catalogue", "WEB 3330"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.38323055),
        dec: Angle.Degrees(+21.24680852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141848"},
        {"Hipparcos Number", "HIP 77589"},
        {"Smithsonian Astrophysical Observation", "SAO 84027"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.61553080),
        dec: Angle.Degrees(+21.24785570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54563"},
        {"Hipparcos Number", "HIP 34608"},
        {"Cincinnati Publication", "Ci 20 412"},
        {"Cincinnati Publication 2", "Ci 18 861"},
        {"Geneva Identification System", "GEN# +1.00054563"},
        {"Smithsonian Astrophysical Observation", "SAO 79131"},
        {"Wilson Evans Batten Catalogue", "WEB 6926"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.52828376),
        dec: Angle.Degrees(+21.24813537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -473.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104874",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104874"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.65970417),
        dec: Angle.Degrees(+21.24908396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5871"},
        {"Hipparcos Number", "HIP 4703"},
        {"Smithsonian Astrophysical Observation", "SAO 74426"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.11659198),
        dec: Angle.Degrees(+21.24915918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3651"},
        {"Hipparcos Number", "HIP 3093"},
        {"Cincinnati Publication", "Ci 20 42"},
        {"Geneva Identification System", "GEN# +1.00003651"},
        {"Smithsonian Astrophysical Observation", "SAO 74175"},
        {"Wilson Evans Batten Catalogue", "WEB 552"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.84206107),
        dec: Angle.Degrees(+21.25137390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -461.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -370.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120636"},
        {"Hipparcos Number", "HIP 67540"},
        {"Geneva Identification System", "GEN# +1.00120636"},
        {"Smithsonian Astrophysical Observation", "SAO 83021"},
        {"Wilson Evans Batten Catalogue", "WEB 11876"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.58594456),
        dec: Angle.Degrees(+21.25557997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69787"},
        {"Hipparcos Number", "HIP 40781"},
        {"Geneva Identification System", "GEN# +1.00069787"},
        {"Smithsonian Astrophysical Observation", "SAO 80094"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.84990880),
        dec: Angle.Degrees(+21.25731309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116772"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.98723274),
        dec: Angle.Degrees(+21.25774628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2147",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 362 AB"},
        {"Henry Draper", "HD 2316"},
        {"Hipparcos Number", "HIP 2147"},
        {"Smithsonian Astrophysical Observation", "SAO 74000"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.79632118),
        dec: Angle.Degrees(+21.25807581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17511"},
        {"Hipparcos Number", "HIP 13152"},
        {"Smithsonian Astrophysical Observation", "SAO 75591"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.28820231),
        dec: Angle.Degrees(+21.25918499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 253343"},
        {"Hipparcos Number", "HIP 29492"},
        {"Smithsonian Astrophysical Observation", "SAO 78110"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.22120979),
        dec: Angle.Degrees(+21.26014151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120753"},
        {"Hipparcos Number", "HIP 67591"},
        {"Geneva Identification System", "GEN# +1.00120753"},
        {"Smithsonian Astrophysical Observation", "SAO 83031"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.75085351),
        dec: Angle.Degrees(+21.26031640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94279",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12140 AB"},
        {"Henry Draper", "HD 179310"},
        {"Hipparcos Number", "HIP 94279"},
        {"Smithsonian Astrophysical Observation", "SAO 86907"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.84502880),
        dec: Angle.Degrees(+21.26089822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9985"},
        {"Hipparcos Number", "HIP 7603"},
        {"Smithsonian Astrophysical Observation", "SAO 74837"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.48387437),
        dec: Angle.Degrees(+21.26111848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199022"},
        {"Hipparcos Number", "HIP 103123"},
        {"Geneva Identification System", "GEN# +1.00199022"},
        {"Smithsonian Astrophysical Observation", "SAO 89247"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.41514681),
        dec: Angle.Degrees(+21.26209487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86608"},
        {"Hipparcos Number", "HIP 49026"},
        {"Wilson Evans Batten Catalogue", "WEB 9095"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.00800218),
        dec: Angle.Degrees(+21.26235472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284141"},
        {"Hipparcos Number", "HIP 19262"},
        {"Geneva Identification System", "GEN# +1.00284141"},
        {"Smithsonian Astrophysical Observation", "SAO 76465"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.92918305),
        dec: Angle.Degrees(+21.26273891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284142"},
        {"Hipparcos Number", "HIP 19216"},
        {"Smithsonian Astrophysical Observation", "SAO 76464"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.78523298),
        dec: Angle.Degrees(+21.26290848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159140"},
        {"Hipparcos Number", "HIP 85821"},
        {"Smithsonian Astrophysical Observation", "SAO 85184"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.04813787),
        dec: Angle.Degrees(+21.26388091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120539"},
        {"Hipparcos Number", "HIP 67480"},
        {"Fundamental Katalog 5th Edition", "FK5 3098"},
        {"Geneva Identification System", "GEN# +1.00120539"},
        {"Smithsonian Astrophysical Observation", "SAO 83015"},
        {"Wilson Evans Batten Catalogue", "WEB 11867"},
    },
    visualMagnitude: 4.92,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.42841642),
        dec: Angle.Degrees(+21.26406422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105713",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14951 A"},
        {"Hipparcos Number", "HIP 105713"},
        {"Smithsonian Astrophysical Observation", "SAO 89686"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.16859308),
        dec: Angle.Degrees(+21.26523348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81142"},
        {"Smithsonian Astrophysical Observation", "SAO 84457"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.58895773),
        dec: Angle.Degrees(+21.26529017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177392"},
        {"Hipparcos Number", "HIP 93603"},
        {"Geneva Identification System", "GEN# +1.00177392"},
        {"Smithsonian Astrophysical Observation", "SAO 86753"},
        {"Wilson Evans Batten Catalogue", "WEB 16257"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.92697879),
        dec: Angle.Degrees(+21.26835163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113170"},
        {"Hipparcos Number", "HIP 63566"},
        {"Geneva Identification System", "GEN# +1.00113170"},
        {"Smithsonian Astrophysical Observation", "SAO 82613"},
        {"Wilson Evans Batten Catalogue", "WEB 11250"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.39644859),
        dec: Angle.Degrees(+21.26898849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19628"},
        {"Hipparcos Number", "HIP 14727"},
        {"Smithsonian Astrophysical Observation", "SAO 75768"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.56053029),
        dec: Angle.Degrees(+21.27195250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8101"},
        {"Smithsonian Astrophysical Observation", "SAO 74895"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.01313665),
        dec: Angle.Degrees(+21.27286292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343978"},
        {"Hipparcos Number", "HIP 94213"},
        {"Geneva Identification System", "GEN# +1.00343978"},
        {"Smithsonian Astrophysical Observation", "SAO 86896"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.69923458),
        dec: Angle.Degrees(+21.27290405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207932"},
        {"Hipparcos Number", "HIP 107956"},
        {"Smithsonian Astrophysical Observation", "SAO 90059"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.07572282),
        dec: Angle.Degrees(+21.27310284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6219",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6219"},
        {"Smithsonian Astrophysical Observation", "SAO 74641"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.93212070),
        dec: Angle.Degrees(+21.27358235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120651"},
        {"Hipparcos Number", "HIP 67543"},
        {"Geneva Identification System", "GEN# +1.00120651"},
        {"Smithsonian Astrophysical Observation", "SAO 83022"},
        {"Wilson Evans Batten Catalogue", "WEB 11878"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.59802829),
        dec: Angle.Degrees(+21.27658839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32482"},
        {"Hipparcos Number", "HIP 23589"},
        {"Geneva Identification System", "GEN# +1.00032482"},
        {"Smithsonian Astrophysical Observation", "SAO 76939"},
        {"Wilson Evans Batten Catalogue", "WEB 4597"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.08991531),
        dec: Angle.Degrees(+21.27799175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211180"},
        {"Hipparcos Number", "HIP 109858"},
        {"Geneva Identification System", "GEN# +1.00211180"},
        {"Smithsonian Astrophysical Observation", "SAO 90352"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.75706938),
        dec: Angle.Degrees(+21.27844393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107626"},
        {"Smithsonian Astrophysical Observation", "SAO 90004"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.00114898),
        dec: Angle.Degrees(+21.28027497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79660"},
        {"Hipparcos Number", "HIP 45473"},
        {"Smithsonian Astrophysical Observation", "SAO 80727"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.99709934),
        dec: Angle.Degrees(+21.28029948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12572"},
        {"Hipparcos Number", "HIP 9618"},
        {"Geneva Identification System", "GEN# +1.00012572"},
        {"Smithsonian Astrophysical Observation", "SAO 75115"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.90385710),
        dec: Angle.Degrees(+21.28060272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23041"},
        {"Hipparcos Number", "HIP 17340"},
        {"Geneva Identification System", "GEN# +1.00023041"},
        {"Smithsonian Astrophysical Observation", "SAO 76092"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.67147928),
        dec: Angle.Degrees(+21.28164742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79248"},
        {"Hipparcos Number", "HIP 45272"},
        {"Geneva Identification System", "GEN# +1.00079248"},
        {"Smithsonian Astrophysical Observation", "SAO 80702"},
        {"Wilson Evans Batten Catalogue", "WEB 8626"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.40529629),
        dec: Angle.Degrees(+21.28323198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38364"},
        {"Hipparcos Number", "HIP 27214"},
        {"Geneva Identification System", "GEN# +1.00038364"},
        {"Smithsonian Astrophysical Observation", "SAO 77530"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.51614318),
        dec: Angle.Degrees(+21.28546013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37558"},
        {"Hipparcos Number", "HIP 26684"},
        {"Smithsonian Astrophysical Observation", "SAO 77376"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.05850599),
        dec: Angle.Degrees(+21.28601758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216286"},
        {"Hipparcos Number", "HIP 112875"},
        {"Smithsonian Astrophysical Observation", "SAO 90832"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.86727187),
        dec: Angle.Degrees(+21.28621094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188261"},
        {"Hipparcos Number", "HIP 97889"},
        {"Geneva Identification System", "GEN# +1.00188261"},
        {"Smithsonian Astrophysical Observation", "SAO 87885"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.38557712),
        dec: Angle.Degrees(+21.28881829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224657"},
        {"Hipparcos Number", "HIP 118301"},
        {"Geneva Identification System", "GEN# +1.00224657"},
        {"Renson", "Renson 61580"},
        {"Smithsonian Astrophysical Observation", "SAO 91639"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.93006920),
        dec: Angle.Degrees(+21.28920256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62041",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62041"},
        {"Geneva Identification System", "GEN# +9.80059036"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.75708352),
        dec: Angle.Degrees(+21.29084953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129501"},
        {"Hipparcos Number", "HIP 71899"},
        {"Geneva Identification System", "GEN# +1.00129501"},
        {"Smithsonian Astrophysical Observation", "SAO 83476"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.59653442),
        dec: Angle.Degrees(+21.29316598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45251"},
        {"Hipparcos Number", "HIP 30726"},
        {"Geneva Identification System", "GEN# +1.00045251"},
        {"Smithsonian Astrophysical Observation", "SAO 78390"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.82904805),
        dec: Angle.Degrees(+21.29366294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245134"},
        {"Hipparcos Number", "HIP 26250"},
        {"Smithsonian Astrophysical Observation", "SAO 77288"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.86592966),
        dec: Angle.Degrees(+21.29439700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26696"},
    },
    visualMagnitude: 11.27,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.10369967),
        dec: Angle.Degrees(+21.29502198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59630",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8465 AB"},
        {"Hipparcos Number", "HIP 59630"},
        {"Geneva Identification System", "GEN# +0.02202453"},
        {"Smithsonian Astrophysical Observation", "SAO 82196"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.43260710),
        dec: Angle.Degrees(+21.29523429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -199.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29077",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4716 AB"},
        {"Henry Draper", "HD 41786"},
        {"Hipparcos Number", "HIP 29077"},
        {"Geneva Identification System", "GEN# +1.00041786J"},
        {"Smithsonian Astrophysical Observation", "SAO 78006"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.01005071),
        dec: Angle.Degrees(+21.29544106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55543"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.65081091),
        dec: Angle.Degrees(+21.29606042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105209"},
        {"Smithsonian Astrophysical Observation", "SAO 89603"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.66909546),
        dec: Angle.Degrees(+21.29644701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104992",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104992"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.96722154),
        dec: Angle.Degrees(+21.29685193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207222"},
        {"Hipparcos Number", "HIP 107547"},
        {"Smithsonian Astrophysical Observation", "SAO 89985"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.73438276),
        dec: Angle.Degrees(+21.29746179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98078"},
        {"Hipparcos Number", "HIP 55118"},
        {"Cincinnati Publication", "Ci 20 625"},
        {"Geneva Identification System", "GEN# +1.00098078"},
        {"Smithsonian Astrophysical Observation", "SAO 81752"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.27231124),
        dec: Angle.Degrees(+21.29766262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -206.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -515.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49970",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7677 AB"},
        {"Henry Draper", "HD 88417"},
        {"Hipparcos Number", "HIP 49970"},
        {"Smithsonian Astrophysical Observation", "SAO 81226"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.02104456),
        dec: Angle.Degrees(+21.29849228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20136",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3118 A"},
        {"Henry Draper", "HD 27249"},
        {"Hipparcos Number", "HIP 20136"},
        {"Celescope Catalog", "CEL 383"},
        {"Geneva Identification System", "GEN# +1.00027249"},
        {"Smithsonian Astrophysical Observation", "SAO 76546"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.75485699),
        dec: Angle.Degrees(+21.29943580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64584",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64584"},
        {"Smithsonian Astrophysical Observation", "SAO 82732"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.56666383),
        dec: Angle.Degrees(+21.30286466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107550"},
        {"Hipparcos Number", "HIP 60282"},
        {"Geneva Identification System", "GEN# +1.00107550"},
        {"Smithsonian Astrophysical Observation", "SAO 82265"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.41403355),
        dec: Angle.Degrees(+21.30322180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104134",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14623 AB"},
        {"Henry Draper", "HD 200929"},
        {"Hipparcos Number", "HIP 104134"},
        {"Smithsonian Astrophysical Observation", "SAO 89452"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.48018258),
        dec: Angle.Degrees(+21.30368229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125352"},
        {"Hipparcos Number", "HIP 69899"},
        {"Smithsonian Astrophysical Observation", "SAO 83283"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.58917606),
        dec: Angle.Degrees(+21.30436274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81245"},
        {"Smithsonian Astrophysical Observation", "SAO 84468"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.90295998),
        dec: Angle.Degrees(+21.30537208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8920"},
        {"Smithsonian Astrophysical Observation", "SAO 75016"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.70966526),
        dec: Angle.Degrees(+21.30629451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35673",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35673"},
        {"Smithsonian Astrophysical Observation", "SAO 79321"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.41250173),
        dec: Angle.Degrees(+21.30776477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46038"},
        {"Smithsonian Astrophysical Observation", "SAO 80796"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.84429273),
        dec: Angle.Degrees(+21.30917761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14666"},
        {"Hipparcos Number", "HIP 11076"},
        {"Smithsonian Astrophysical Observation", "SAO 75320"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.64209568),
        dec: Angle.Degrees(+21.31253882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101290"},
        {"Hipparcos Number", "HIP 56865"},
        {"Geneva Identification System", "GEN# +1.00101290"},
        {"Smithsonian Astrophysical Observation", "SAO 81925"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.88158972),
        dec: Angle.Degrees(+21.31292169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58161"},
    },
    visualMagnitude: 11.04,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.92349836),
        dec: Angle.Degrees(+21.31487940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30468"},
        {"Hipparcos Number", "HIP 22352"},
        {"Fundamental Katalog 5th Edition", "FK5 4439"},
        {"Smithsonian Astrophysical Observation", "SAO 76767"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.18276347),
        dec: Angle.Degrees(+21.31580795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35967"},
        {"Hipparcos Number", "HIP 25694"},
        {"Smithsonian Astrophysical Observation", "SAO 77202"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.31496655),
        dec: Angle.Degrees(+21.31596090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203427"},
        {"Hipparcos Number", "HIP 105444"},
        {"Smithsonian Astrophysical Observation", "SAO 89645"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.36482480),
        dec: Angle.Degrees(+21.31671885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197656"},
        {"Hipparcos Number", "HIP 102364"},
        {"Smithsonian Astrophysical Observation", "SAO 89070"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.11179185),
        dec: Angle.Degrees(+21.31714530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27205",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4349 AB"},
        {"Henry Draper", "HD 38363"},
        {"Hipparcos Number", "HIP 27205"},
        {"Smithsonian Astrophysical Observation", "SAO 77527"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.50334251),
        dec: Angle.Degrees(+21.31790449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50017"},
        {"Smithsonian Astrophysical Observation", "SAO 81234"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.16778431),
        dec: Angle.Degrees(+21.31842828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130556"},
        {"Hipparcos Number", "HIP 72408"},
        {"Geneva Identification System", "GEN# +1.00130556"},
        {"Smithsonian Astrophysical Observation", "SAO 83533"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.08655434),
        dec: Angle.Degrees(+21.31865322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206431"},
        {"Hipparcos Number", "HIP 107102"},
        {"Smithsonian Astrophysical Observation", "SAO 89912"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.41315116),
        dec: Angle.Degrees(+21.31877609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32174"},
        {"Hipparcos Number", "HIP 23426"},
        {"Smithsonian Astrophysical Observation", "SAO 76907"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.52290508),
        dec: Angle.Degrees(+21.32082807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86516"},
        {"Hipparcos Number", "HIP 48977"},
        {"Fundamental Katalog 5th Edition", "FK5 4888"},
        {"Renson", "Renson 24750"},
        {"Smithsonian Astrophysical Observation", "SAO 81128"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.86731083),
        dec: Angle.Degrees(+21.32144983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163971"},
        {"Hipparcos Number", "HIP 87959"},
        {"Smithsonian Astrophysical Observation", "SAO 85591"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.52158897),
        dec: Angle.Degrees(+21.32302350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24777"},
        {"Hipparcos Number", "HIP 18490"},
        {"Smithsonian Astrophysical Observation", "SAO 76347"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.29704112),
        dec: Angle.Degrees(+21.32358085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87579"},
        {"Geneva Identification System", "GEN# +0.02103245"},
        {"Smithsonian Astrophysical Observation", "SAO 85511"},
        {"Wilson Evans Batten Catalogue", "WEB 14776"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.37492306),
        dec: Angle.Degrees(+21.32515234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3254"},
        {"Hipparcos Number", "HIP 2829"},
        {"Smithsonian Astrophysical Observation", "SAO 74131"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.97133007),
        dec: Angle.Degrees(+21.32763787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23734"},
        {"Hipparcos Number", "HIP 17763"},
        {"Geneva Identification System", "GEN# +1.00023734"},
        {"Smithsonian Astrophysical Observation", "SAO 76212"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.04414295),
        dec: Angle.Degrees(+21.32910229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183562"},
        {"Hipparcos Number", "HIP 95831"},
        {"Geneva Identification System", "GEN# +1.00183562"},
        {"Renson", "Renson 50710"},
        {"Smithsonian Astrophysical Observation", "SAO 87273"},
        {"Wilson Evans Batten Catalogue", "WEB 16780"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.37318894),
        dec: Angle.Degrees(+21.33249985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117610"},
        {"Hipparcos Number", "HIP 65945"},
        {"Geneva Identification System", "GEN# +1.00117610"},
        {"Smithsonian Astrophysical Observation", "SAO 82871"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.79352677),
        dec: Angle.Degrees(+21.33327909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91252",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11501 AB"},
        {"Henry Draper", "HD 171973"},
        {"Hipparcos Number", "HIP 91252"},
        {"Smithsonian Astrophysical Observation", "SAO 86242"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.20006926),
        dec: Angle.Degrees(+21.33399701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74618"},
        {"Smithsonian Astrophysical Observation", "SAO 83730"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.69180692),
        dec: Angle.Degrees(+21.33489635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97103"},
        {"Hipparcos Number", "HIP 54626"},
        {"Geneva Identification System", "GEN# +1.00097103"},
        {"Smithsonian Astrophysical Observation", "SAO 81707"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.71560072),
        dec: Angle.Degrees(+21.33555923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209090"},
        {"Hipparcos Number", "HIP 108629"},
        {"Smithsonian Astrophysical Observation", "SAO 90164"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.10349719),
        dec: Angle.Degrees(+21.34012316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13914",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2257 AB"},
        {"Hipparcos Number", "HIP 13914"},
    },
    visualMagnitude: 4.63,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.80305773),
        dec: Angle.Degrees(+21.34044477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23853"},
        {"Hipparcos Number", "HIP 17837"},
        {"Smithsonian Astrophysical Observation", "SAO 76227"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.25086920),
        dec: Angle.Degrees(+21.34218533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16908"},
        {"Geneva Identification System", "GEN# +5.20250005"},
        {"Smithsonian Astrophysical Observation", "SAO 76035"},
        {"Wilson Evans Batten Catalogue", "WEB 3217"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.39535518),
        dec: Angle.Degrees(+21.34324066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17317"},
        {"Hipparcos Number", "HIP 13029"},
        {"Geneva Identification System", "GEN# +1.00017317"},
        {"Renson", "Renson 4360"},
        {"Smithsonian Astrophysical Observation", "SAO 75574"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.86668629),
        dec: Angle.Degrees(+21.34532363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166437"},
        {"Hipparcos Number", "HIP 88985"},
        {"Geneva Identification System", "GEN# +1.00166437"},
        {"Smithsonian Astrophysical Observation", "SAO 85788"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.44264876),
        dec: Angle.Degrees(+21.34835029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76541"},
        {"Hipparcos Number", "HIP 43985"},
        {"Smithsonian Astrophysical Observation", "SAO 80534"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.35953952),
        dec: Angle.Degrees(+21.35088911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99472",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13479 A"},
        {"Henry Draper", "HD 191856"},
        {"Hipparcos Number", "HIP 99472"},
        {"Smithsonian Astrophysical Observation", "SAO 88314"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.82261261),
        dec: Angle.Degrees(+21.35203022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34856",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5873 A"},
        {"Henry Draper", "HD 55201"},
        {"Hipparcos Number", "HIP 34856"},
        {"Geneva Identification System", "GEN# +1.00055201"},
        {"Smithsonian Astrophysical Observation", "SAO 79174"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.19301077),
        dec: Angle.Degrees(+21.35257743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101484"},
        {"Hipparcos Number", "HIP 56975"},
        {"Fundamental Katalog 5th Edition", "FK5 2936"},
        {"Geneva Identification System", "GEN# +1.00101484"},
        {"Smithsonian Astrophysical Observation", "SAO 81941"},
        {"Wilson Evans Batten Catalogue", "WEB 10255"},
    },
    visualMagnitude: 5.26,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.19627319),
        dec: Angle.Degrees(+21.35284143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220475"},
        {"Hipparcos Number", "HIP 115512"},
        {"Smithsonian Astrophysical Observation", "SAO 91232"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.98086245),
        dec: Angle.Degrees(+21.35744473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126410"},
        {"Hipparcos Number", "HIP 70468"},
        {"Smithsonian Astrophysical Observation", "SAO 83336"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.20214016),
        dec: Angle.Degrees(+21.35798677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65169"},
    },
    visualMagnitude: 11.09,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.33606992),
        dec: Angle.Degrees(+21.36071747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220964"},
        {"Hipparcos Number", "HIP 115834"},
        {"Geneva Identification System", "GEN# +1.00220964"},
        {"Smithsonian Astrophysical Observation", "SAO 91281"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.00291431),
        dec: Angle.Degrees(+21.36215414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110218"},
        {"Cincinnati Publication", "Ci 20 1353"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.89219577),
        dec: Angle.Degrees(+21.36666866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 370.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 204.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12444"},
        {"Hipparcos Number", "HIP 9520"},
        {"Smithsonian Astrophysical Observation", "SAO 75103"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.61653640),
        dec: Angle.Degrees(+21.36826443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11974"},
        {"Hipparcos Number", "HIP 9159"},
        {"Smithsonian Astrophysical Observation", "SAO 75053"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.48481674),
        dec: Angle.Degrees(+21.36894525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18684"},
        {"Smithsonian Astrophysical Observation", "SAO 76380"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.01560402),
        dec: Angle.Degrees(+21.37033322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341872"},
        {"Hipparcos Number", "HIP 89576"},
        {"Smithsonian Astrophysical Observation", "SAO 85886"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.17967804),
        dec: Angle.Degrees(+21.37131141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60819"},
        {"Hipparcos Number", "HIP 37084"},
        {"Smithsonian Astrophysical Observation", "SAO 79556"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.30678336),
        dec: Angle.Degrees(+21.37301170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15673"},
        {"Hipparcos Number", "HIP 11762"},
        {"Smithsonian Astrophysical Observation", "SAO 75422"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.94926237),
        dec: Angle.Degrees(+21.37530792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187257"},
        {"Hipparcos Number", "HIP 97442"},
        {"Smithsonian Astrophysical Observation", "SAO 87737"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.07463361),
        dec: Angle.Degrees(+21.37582139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70728"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.97819735),
        dec: Angle.Degrees(+21.37631403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13382"},
        {"Hipparcos Number", "HIP 10218"},
        {"Geneva Identification System", "GEN# +1.00013382"},
        {"Smithsonian Astrophysical Observation", "SAO 75191"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.84573402),
        dec: Angle.Degrees(+21.37737657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 274.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102000"},
        {"Hipparcos Number", "HIP 57255"},
        {"Geneva Identification System", "GEN# +1.00102000"},
        {"Smithsonian Astrophysical Observation", "SAO 81961"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.11740991),
        dec: Angle.Degrees(+21.37789650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76761",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9741 AB"},
        {"Henry Draper", "HD 139952"},
        {"Hipparcos Number", "HIP 76761"},
        {"Smithsonian Astrophysical Observation", "SAO 83937"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.09874307),
        dec: Angle.Degrees(+21.37866956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139781"},
        {"Hipparcos Number", "HIP 76670"},
        {"Smithsonian Astrophysical Observation", "SAO 83930"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.84509919),
        dec: Angle.Degrees(+21.37884969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91656"},
        {"Hipparcos Number", "HIP 51826"},
        {"Geneva Identification System", "GEN# +1.00091656"},
        {"Smithsonian Astrophysical Observation", "SAO 81427"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.82254247),
        dec: Angle.Degrees(+21.37897311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27732"},
        {"Hipparcos Number", "HIP 20480"},
        {"Geneva Identification System", "GEN# +5.20250042"},
        {"Smithsonian Astrophysical Observation", "SAO 76580"},
        {"Wilson Evans Batten Catalogue", "WEB 3915"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.84278238),
        dec: Angle.Degrees(+21.37919012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175886"},
        {"Hipparcos Number", "HIP 92992"},
        {"Smithsonian Astrophysical Observation", "SAO 86604"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.17189755),
        dec: Angle.Degrees(+21.37925338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217478"},
        {"Hipparcos Number", "HIP 113635"},
        {"Smithsonian Astrophysical Observation", "SAO 90939"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.20486891),
        dec: Angle.Degrees(+21.38146670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115301"},
        {"Hipparcos Number", "HIP 64722"},
        {"Geneva Identification System", "GEN# +1.00115301"},
        {"Smithsonian Astrophysical Observation", "SAO 82742"},
        {"Wilson Evans Batten Catalogue", "WEB 11444"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.99054479),
        dec: Angle.Degrees(+21.38186107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101417"},
        {"Hipparcos Number", "HIP 56926"},
        {"Smithsonian Astrophysical Observation", "SAO 81934"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.05874527),
        dec: Angle.Degrees(+21.38613488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41318"},
        {"Hipparcos Number", "HIP 28843"},
        {"Smithsonian Astrophysical Observation", "SAO 77939"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.32200265),
        dec: Angle.Degrees(+21.38706740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122945"},
        {"Hipparcos Number", "HIP 68767"},
        {"Fundamental Katalog 5th Edition", "FK5 5248"},
        {"Geneva Identification System", "GEN# +1.00122945"},
        {"Smithsonian Astrophysical Observation", "SAO 83149"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.12661371),
        dec: Angle.Degrees(+21.38815018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246606"},
        {"Hipparcos Number", "HIP 26912"},
        {"Smithsonian Astrophysical Observation", "SAO 77438"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.70283696),
        dec: Angle.Degrees(+21.38914503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18266"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.61591783),
        dec: Angle.Degrees(+21.38986035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222940"},
        {"Hipparcos Number", "HIP 117155"},
        {"Smithsonian Astrophysical Observation", "SAO 91464"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.26665565),
        dec: Angle.Degrees(+21.38991624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82266",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10223 A"},
        {"Henry Draper", "HD 151750"},
        {"Hipparcos Number", "HIP 82266"},
        {"Smithsonian Astrophysical Observation", "SAO 84617"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.13965973),
        dec: Angle.Degrees(+21.39038271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94703",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12243 A"},
        {"Henry Draper", "HD 180554"},
        {"Hipparcos Number", "HIP 94703"},
        {"Fundamental Katalog 5th Edition", "FK5 3540"},
        {"Geneva Identification System", "GEN# +1.00180554"},
        {"Smithsonian Astrophysical Observation", "SAO 87010"},
        {"Wilson Evans Batten Catalogue", "WEB 16515"},
    },
    visualMagnitude: 4.76,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.05433156),
        dec: Angle.Degrees(+21.39044277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83318",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83318"},
        {"Smithsonian Astrophysical Observation", "SAO 84768"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.42526089),
        dec: Angle.Degrees(+21.39097171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66352",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8965 AB"},
        {"Hipparcos Number", "HIP 66352"},
        {"Smithsonian Astrophysical Observation", "SAO 82891"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.99712438),
        dec: Angle.Degrees(+21.39161460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213143"},
        {"Hipparcos Number", "HIP 110983"},
        {"Geneva Identification System", "GEN# +1.00213143"},
        {"Renson", "Renson 59080"},
        {"Smithsonian Astrophysical Observation", "SAO 90541"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.27694245),
        dec: Angle.Degrees(+21.39313854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89730"},
        {"Hipparcos Number", "HIP 50744"},
        {"Smithsonian Astrophysical Observation", "SAO 81310"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.42849027),
        dec: Angle.Degrees(+21.39379353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137336"},
        {"Hipparcos Number", "HIP 75446"},
        {"Smithsonian Astrophysical Observation", "SAO 83808"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.20038517),
        dec: Angle.Degrees(+21.39401667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -282.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110926",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110926"},
        {"Smithsonian Astrophysical Observation", "SAO 90530"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.11134172),
        dec: Angle.Degrees(+21.39460120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41239"},
        {"Hipparcos Number", "HIP 28785"},
        {"Geneva Identification System", "GEN# +1.00041239"},
        {"Smithsonian Astrophysical Observation", "SAO 77926"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.16021398),
        dec: Angle.Degrees(+21.39540583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84669"},
        {"Smithsonian Astrophysical Observation", "SAO 84997"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.65141934),
        dec: Angle.Degrees(+21.39768302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10045"},
        {"Hipparcos Number", "HIP 7658"},
        {"Fundamental Katalog 5th Edition", "FK5 2110"},
        {"Geneva Identification System", "GEN# +1.00010045"},
        {"Smithsonian Astrophysical Observation", "SAO 74845"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.65520332),
        dec: Angle.Degrees(+21.39823153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197573"},
        {"Hipparcos Number", "HIP 102331"},
        {"Smithsonian Astrophysical Observation", "SAO 89061"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.00014225),
        dec: Angle.Degrees(+21.40063967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193859"},
        {"Hipparcos Number", "HIP 100425"},
        {"Smithsonian Astrophysical Observation", "SAO 88572"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.46063033),
        dec: Angle.Degrees(+21.40298255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36879"},
        {"Hipparcos Number", "HIP 26272"},
        {"Celescope Catalog", "CEL 824"},
        {"Geneva Identification System", "GEN# +1.00036879"},
        {"Smithsonian Astrophysical Observation", "SAO 77293"},
        {"Wilson Evans Batten Catalogue", "WEB 5156"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.91887583),
        dec: Angle.Degrees(+21.40327647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345764"},
        {"Hipparcos Number", "HIP 98936"},
        {"Geneva Identification System", "GEN# +1.00345764"},
        {"Smithsonian Astrophysical Observation", "SAO 88171"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.32818913),
        dec: Angle.Degrees(+21.40360646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106582",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15109 AB"},
        {"Henry Draper", "HD 205497"},
        {"Hipparcos Number", "HIP 106582"},
        {"Smithsonian Astrophysical Observation", "SAO 89810"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.79987300),
        dec: Angle.Degrees(+21.40413678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4558",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 805 AB"},
        {"Henry Draper", "HD 5641"},
        {"Hipparcos Number", "HIP 4558"},
        {"Geneva Identification System", "GEN# +1.00005641J"},
        {"Smithsonian Astrophysical Observation", "SAO 74402"},
        {"Wilson Evans Batten Catalogue", "WEB 831"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.57874183),
        dec: Angle.Degrees(+21.40450332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192894"},
        {"Hipparcos Number", "HIP 99933"},
        {"Smithsonian Astrophysical Observation", "SAO 88443"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.14396676),
        dec: Angle.Degrees(+21.40468528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 872"},
        {"Hipparcos Number", "HIP 1061"},
        {"Smithsonian Astrophysical Observation", "SAO 73819"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.30053080),
        dec: Angle.Degrees(+21.40528208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17148",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2673 AB"},
        {"Henry Draper", "HD 22767"},
        {"Hipparcos Number", "HIP 17148"},
        {"Renson", "Renson 5810"},
        {"Smithsonian Astrophysical Observation", "SAO 76070"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.08992871),
        dec: Angle.Degrees(+21.40572337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114953"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.24773549),
        dec: Angle.Degrees(+21.40586094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39678"},
        {"Hipparcos Number", "HIP 27979"},
        {"Smithsonian Astrophysical Observation", "SAO 77714"},
    },
    visualMagnitude: 8.18,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.75182145),
        dec: Angle.Degrees(+21.40596110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199343"},
        {"Hipparcos Number", "HIP 103325"},
        {"Geneva Identification System", "GEN# +1.00199343"},
        {"Renson", "Renson 55550"},
        {"Smithsonian Astrophysical Observation", "SAO 89293"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.99817655),
        dec: Angle.Degrees(+21.40654828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59828"},
        {"Hipparcos Number", "HIP 36663"},
        {"Geneva Identification System", "GEN# +1.00059828"},
        {"Smithsonian Astrophysical Observation", "SAO 79483"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.14387223),
        dec: Angle.Degrees(+21.40784578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71249"},
        {"Smithsonian Astrophysical Observation", "SAO 83409"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.56060563),
        dec: Angle.Degrees(+21.40830400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194577"},
        {"Hipparcos Number", "HIP 100754"},
        {"Fundamental Katalog 5th Edition", "FK5 3634"},
        {"Geneva Identification System", "GEN# +1.00194577"},
        {"Smithsonian Astrophysical Observation", "SAO 88664"},
        {"Wilson Evans Batten Catalogue", "WEB 18210"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.41884950),
        dec: Angle.Degrees(+21.40966274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5036"},
        {"Hipparcos Number", "HIP 4087"},
        {"Geneva Identification System", "GEN# +1.00005036"},
        {"Smithsonian Astrophysical Observation", "SAO 74333"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.11723996),
        dec: Angle.Degrees(+21.41009210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219614"},
        {"Hipparcos Number", "HIP 114955"},
        {"Smithsonian Astrophysical Observation", "SAO 91142"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.25269300),
        dec: Angle.Degrees(+21.41092290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134192"},
        {"Hipparcos Number", "HIP 74041"},
        {"Smithsonian Astrophysical Observation", "SAO 83675"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.97550554),
        dec: Angle.Degrees(+21.41223729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220526"},
        {"Hipparcos Number", "HIP 115548"},
        {"Geneva Identification System", "GEN# +1.00220526"},
        {"Smithsonian Astrophysical Observation", "SAO 91238"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.07891363),
        dec: Angle.Degrees(+21.41313917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124714"},
        {"Hipparcos Number", "HIP 69594"},
        {"Geneva Identification System", "GEN# +1.00124714"},
        {"Smithsonian Astrophysical Observation", "SAO 83241"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.67119974),
        dec: Angle.Degrees(+21.41397545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12240"},
        {"Smithsonian Astrophysical Observation", "SAO 75478"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.40027788),
        dec: Angle.Degrees(+21.41598651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37999"},
        {"Hipparcos Number", "HIP 26967"},
        {"Smithsonian Astrophysical Observation", "SAO 77451"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.84167554),
        dec: Angle.Degrees(+21.41603924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88560"},
        {"Hipparcos Number", "HIP 50056"},
        {"Geneva Identification System", "GEN# +1.00088560"},
        {"Smithsonian Astrophysical Observation", "SAO 81239"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.29964257),
        dec: Angle.Degrees(+21.41996087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116281",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116281"},
        {"Smithsonian Astrophysical Observation", "SAO 91342"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.40289822),
        dec: Angle.Degrees(+21.42402593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174933"},
        {"Hipparcos Number", "HIP 92614"},
        {"Celescope Catalog", "CEL 4660"},
        {"Geneva Identification System", "GEN# +1.00174933"},
        {"Renson", "Renson 48970"},
        {"Smithsonian Astrophysical Observation", "SAO 86521"},
        {"Wilson Evans Batten Catalogue", "WEB 16023"},
    },
    visualMagnitude: 5.43,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.06846943),
        dec: Angle.Degrees(+21.42516648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88624",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11060 G"},
        {"Henry Draper", "HD 165569"},
        {"Hipparcos Number", "HIP 88624"},
        {"Geneva Identification System", "GEN# +1.00165569"},
        {"Smithsonian Astrophysical Observation", "SAO 85720"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.42317368),
        dec: Angle.Degrees(+21.42633449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46467"},
        {"Hipparcos Number", "HIP 31353"},
        {"Smithsonian Astrophysical Observation", "SAO 78514"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.61500816),
        dec: Angle.Degrees(+21.42736382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18283"},
        {"Hipparcos Number", "HIP 13723"},
        {"Smithsonian Astrophysical Observation", "SAO 75652"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.19190755),
        dec: Angle.Degrees(+21.42811546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49824"},
        {"Hipparcos Number", "HIP 32885"},
        {"Smithsonian Astrophysical Observation", "SAO 78798"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.78323607),
        dec: Angle.Degrees(+21.42829377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110823"},
        {"Smithsonian Astrophysical Observation", "SAO 90515"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.78118186),
        dec: Angle.Degrees(+21.42949061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155923"},
        {"Hipparcos Number", "HIP 84275"},
        {"Fundamental Katalog 5th Edition", "FK5 5521"},
        {"Smithsonian Astrophysical Observation", "SAO 84934"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.41346031),
        dec: Angle.Degrees(+21.43130924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112063",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16185"},
        {"Henry Draper", "HD 215013"},
        {"Hipparcos Number", "HIP 112063"},
        {"Geneva Identification System", "GEN# +1.00215013J"},
        {"Smithsonian Astrophysical Observation", "SAO 90719"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.46513186),
        dec: Angle.Degrees(+21.43152760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69860"},
    },
    visualMagnitude: 11.58,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.44951441),
        dec: Angle.Degrees(+21.43419326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3138",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 558 A"},
        {"Henry Draper", "HD 3690"},
        {"Hipparcos Number", "HIP 3138"},
        {"Geneva Identification System", "GEN# +1.00003690J"},
        {"Geneva Identification System 2", "GEN# +1.00003690A"},
        {"Smithsonian Astrophysical Observation", "SAO 74182"},
        {"Wilson Evans Batten Catalogue", "WEB 560"},
    },
    visualMagnitude: 5.36,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.98147468),
        dec: Angle.Degrees(+21.43856440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15651"},
        {"Smithsonian Astrophysical Observation", "SAO 75888"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.37393779),
        dec: Angle.Degrees(+21.43867719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63572",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63572"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.41450205),
        dec: Angle.Degrees(+21.43903935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88639",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11060 C"},
        {"Henry Draper", "HD 165590C"},
        {"Hipparcos Number", "HIP 88639"},
        {"Geneva Identification System", "GEN# +1.00165590C"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)05, 50.2600),
        dec: Angle.DegreesMinutesSeconds((int)+21, (int)26, 22.000)
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
    primaryId: "HIP 103335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199360"},
        {"Hipparcos Number", "HIP 103335"},
        {"Geneva Identification System", "GEN# +1.00199360"},
        {"Renson", "Renson 55560"},
        {"Smithsonian Astrophysical Observation", "SAO 89298"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.03547244),
        dec: Angle.Degrees(+21.44037857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139512"},
        {"Hipparcos Number", "HIP 76538"},
        {"Geneva Identification System", "GEN# +1.00139512"},
        {"Smithsonian Astrophysical Observation", "SAO 83917"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.47419837),
        dec: Angle.Degrees(+21.44065672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74971"},
        {"Hipparcos Number", "HIP 43188"},
        {"Smithsonian Astrophysical Observation", "SAO 80433"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.97785932),
        dec: Angle.Degrees(+21.44259980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46120"},
        {"Hipparcos Number", "HIP 31172"},
        {"Smithsonian Astrophysical Observation", "SAO 78471"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.10604334),
        dec: Angle.Degrees(+21.44362197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35817"},
        {"Hipparcos Number", "HIP 25613"},
        {"Smithsonian Astrophysical Observation", "SAO 77190"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.08054534),
        dec: Angle.Degrees(+21.44368357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140812"},
        {"Hipparcos Number", "HIP 77129"},
        {"Geneva Identification System", "GEN# +1.00140812"},
        {"Smithsonian Astrophysical Observation", "SAO 83980"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.23263511),
        dec: Angle.Degrees(+21.44407250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 131.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36238",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6089 A"},
        {"Henry Draper", "HD 58728"},
        {"Hipparcos Number", "HIP 36238"},
        {"Geneva Identification System", "GEN# +1.00058728A"},
        {"Smithsonian Astrophysical Observation", "SAO 79403"},
        {"Wilson Evans Batten Catalogue", "WEB 7215"},
    },
    visualMagnitude: 5.20,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.93497685),
        dec: Angle.Degrees(+21.44554856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103764"},
        {"Smithsonian Astrophysical Observation", "SAO 89377"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.40705437),
        dec: Angle.Degrees(+21.44566895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88637",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11060"},
        {"Aitken 2", "ADS 11060 AB"},
        {"Henry Draper", "HD 165590"},
        {"Hipparcos Number", "HIP 88637"},
        {"Geneva Identification System", "GEN# +1.00165590"},
        {"Smithsonian Astrophysical Observation", "SAO 85723"},
        {"Wilson Evans Batten Catalogue", "WEB 15013"},
        {"Wilson Evans Batten Catalogue 2", "WEB 15014"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.45718732),
        dec: Angle.Degrees(+21.44599665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102808"},
        {"Hipparcos Number", "HIP 57729"},
        {"Smithsonian Astrophysical Observation", "SAO 82011"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.57770525),
        dec: Angle.Degrees(+21.44643489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61660"},
        {"Hipparcos Number", "HIP 37442"},
        {"Fundamental Katalog 5th Edition", "FK5 4692"},
        {"Smithsonian Astrophysical Observation", "SAO 79613"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.30288162),
        dec: Angle.Degrees(+21.44699484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344939"},
        {"Hipparcos Number", "HIP 97152"},
        {"Smithsonian Astrophysical Observation", "SAO 87656"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.21032415),
        dec: Angle.Degrees(+21.45094523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126328"},
        {"Hipparcos Number", "HIP 70411"},
        {"Smithsonian Astrophysical Observation", "SAO 83332"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.07136109),
        dec: Angle.Degrees(+21.45420648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77065"},
        {"Hipparcos Number", "HIP 44259"},
        {"Cincinnati Publication", "Ci 20 503"},
        {"Geneva Identification System", "GEN# +1.00077065"},
        {"Smithsonian Astrophysical Observation", "SAO 80574"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.19698312),
        dec: Angle.Degrees(+21.45454721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 269.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -342.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84000"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.56523383),
        dec: Angle.Degrees(+21.45490156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64175",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8799 AB"},
        {"Henry Draper", "HD 114255"},
        {"Hipparcos Number", "HIP 64175"},
        {"Smithsonian Astrophysical Observation", "SAO 82677"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.28550031),
        dec: Angle.Degrees(+21.45612305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175085"},
        {"Hipparcos Number", "HIP 92659"},
        {"Smithsonian Astrophysical Observation", "SAO 86536"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.23112452),
        dec: Angle.Degrees(+21.45660897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35909",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6038 AB"},
        {"Henry Draper", "HD 57900"},
        {"Hipparcos Number", "HIP 35909"},
        {"Smithsonian Astrophysical Observation", "SAO 79361"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.03725085),
        dec: Angle.Degrees(+21.45778567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86682"},
        {"Hipparcos Number", "HIP 49050"},
        {"Smithsonian Astrophysical Observation", "SAO 81136"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.14045270),
        dec: Angle.Degrees(+21.45828828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81011"},
        {"Smithsonian Astrophysical Observation", "SAO 84444"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.15942547),
        dec: Angle.Degrees(+21.45858103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58858",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8406 AB"},
        {"Henry Draper", "HD 104827"},
        {"Hipparcos Number", "HIP 58858"},
        {"Geneva Identification System", "GEN# +1.00104827"},
        {"Smithsonian Astrophysical Observation", "SAO 82123"},
        {"Wilson Evans Batten Catalogue", "WEB 10482"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.06906686),
        dec: Angle.Degrees(+21.45916332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137556"},
        {"Hipparcos Number", "HIP 75548"},
        {"Smithsonian Astrophysical Observation", "SAO 83816"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.51296892),
        dec: Angle.Degrees(+21.45990235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284680"},
        {"Hipparcos Number", "HIP 22118"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.40115848),
        dec: Angle.Degrees(+21.46043165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250389"},
        {"Hipparcos Number", "HIP 28541"},
        {"Smithsonian Astrophysical Observation", "SAO 77855"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.37857396),
        dec: Angle.Degrees(+21.46045733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67309"},
        {"Geneva Identification System", "GEN# +0.02202632"},
    },
    visualMagnitude: 11.58,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.92646584),
        dec: Angle.Degrees(+21.46067943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186180"},
        {"Hipparcos Number", "HIP 96911"},
        {"Smithsonian Astrophysical Observation", "SAO 87585"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.50083065),
        dec: Angle.Degrees(+21.46080306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 143",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 143"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.45518210),
        dec: Angle.Degrees(+21.46213750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 150.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5132",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 899 B"},
        {"Henry Draper", "HD 6457"},
        {"Hipparcos Number", "HIP 5132"},
        {"Geneva Identification System", "GEN# +1.00006457"},
        {"Smithsonian Astrophysical Observation", "SAO 74483"},
        {"Wilson Evans Batten Catalogue", "WEB 1056"},
    },
    visualMagnitude: 5.55,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.42365838),
        dec: Angle.Degrees(+21.46547318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5770"},
        {"Smithsonian Astrophysical Observation", "SAO 74577"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.51861270),
        dec: Angle.Degrees(+21.46578262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177597"},
        {"Hipparcos Number", "HIP 93676"},
        {"Smithsonian Astrophysical Observation", "SAO 86770"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.14939938),
        dec: Angle.Degrees(+21.46841319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284677"},
        {"Hipparcos Number", "HIP 21848"},
        {"Smithsonian Astrophysical Observation", "SAO 76715"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.46113278),
        dec: Angle.Degrees(+21.46850920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42806",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Asellus Borealis"},
        {"Henry Draper", "HD 74198"},
        {"Hipparcos Number", "HIP 42806"},
        {"Fundamental Katalog 5th Edition", "FK5 1228"},
        {"Geneva Identification System", "GEN# +1.00074198"},
        {"Smithsonian Astrophysical Observation", "SAO 80378"},
        {"Wilson Evans Batten Catalogue", "WEB 8267"},
    },
    visualMagnitude: 4.66,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.82172127),
        dec: Angle.Degrees(+21.46859609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55187"},
        {"Smithsonian Astrophysical Observation", "SAO 81759"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.49071000),
        dec: Angle.Degrees(+21.46865808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28033"},
        {"Hipparcos Number", "HIP 20712"},
        {"Geneva Identification System", "GEN# +5.20250062"},
        {"Smithsonian Astrophysical Observation", "SAO 76609"},
        {"Wilson Evans Batten Catalogue", "WEB 3971"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.57680549),
        dec: Angle.Degrees(+21.47052306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346685"},
        {"Hipparcos Number", "HIP 100917"},
        {"Smithsonian Astrophysical Observation", "SAO 88701"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.91883130),
        dec: Angle.Degrees(+21.47122976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19018"},
        {"Hipparcos Number", "HIP 14292"},
        {"Smithsonian Astrophysical Observation", "SAO 75715"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.06332966),
        dec: Angle.Degrees(+21.47290709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5131",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 899 A"},
        {"Henry Draper", "HD 6456"},
        {"Hipparcos Number", "HIP 5131"},
        {"Geneva Identification System", "GEN# +1.00006456"},
        {"Smithsonian Astrophysical Observation", "SAO 74482"},
        {"Wilson Evans Batten Catalogue", "WEB 1055"},
    },
    visualMagnitude: 5.33,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.42053152),
        dec: Angle.Degrees(+21.47321620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125376"},
        {"Hipparcos Number", "HIP 69918"},
        {"Smithsonian Astrophysical Observation", "SAO 83285"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.63027273),
        dec: Angle.Degrees(+21.47322009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17316",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17316"},
        {"Geneva Identification System", "GEN# +5.20223311"},
        {"Smithsonian Astrophysical Observation", "SAO 76090"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.59992368),
        dec: Angle.Degrees(+21.47360744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97713"},
        {"Hipparcos Number", "HIP 54921"},
        {"Geneva Identification System", "GEN# +1.00097713"},
        {"Smithsonian Astrophysical Observation", "SAO 81732"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.70115425),
        dec: Angle.Degrees(+21.47376328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204660"},
        {"Hipparcos Number", "HIP 106097"},
        {"Smithsonian Astrophysical Observation", "SAO 89744"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.37787440),
        dec: Angle.Degrees(+21.47513264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1430"},
        {"Hipparcos Number", "HIP 1482"},
        {"Smithsonian Astrophysical Observation", "SAO 73882"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.61365789),
        dec: Angle.Degrees(+21.47766557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247088"},
        {"Hipparcos Number", "HIP 27120"},
        {"Smithsonian Astrophysical Observation", "SAO 77499"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.26503181),
        dec: Angle.Degrees(+21.47783165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73411",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9473 AB"},
        {"Hipparcos Number", "HIP 73411"},
        {"Smithsonian Astrophysical Observation", "SAO 83610"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.04165371),
        dec: Angle.Degrees(+21.48021594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136796"},
        {"Hipparcos Number", "HIP 75192"},
        {"Smithsonian Astrophysical Observation", "SAO 83788"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.48457486),
        dec: Angle.Degrees(+21.48069367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66828"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.44735636),
        dec: Angle.Degrees(+21.48552417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -210.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171569"},
        {"Hipparcos Number", "HIP 91088"},
        {"Smithsonian Astrophysical Observation", "SAO 86209"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.69565817),
        dec: Angle.Degrees(+21.48623382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5556"},
        {"Hipparcos Number", "HIP 4486"},
        {"Geneva Identification System", "GEN# +1.00005556"},
        {"Smithsonian Astrophysical Observation", "SAO 74393"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.37412576),
        dec: Angle.Degrees(+21.48625027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52479",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52479"},
        {"Smithsonian Astrophysical Observation", "SAO 81493"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.93482894),
        dec: Angle.Degrees(+21.48854325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194495"},
        {"Hipparcos Number", "HIP 100719"},
        {"Smithsonian Astrophysical Observation", "SAO 88648"},
        {"Wilson Evans Batten Catalogue", "WEB 18201"},
    },
    visualMagnitude: 7.07,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.29501492),
        dec: Angle.Degrees(+21.48857228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80816",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Kornephoros"},
        {"Henry Draper", "HD 148856"},
        {"Hipparcos Number", "HIP 80816"},
        {"Fundamental Katalog 5th Edition", "FK5 618"},
        {"Geneva Identification System", "GEN# +1.00148856"},
        {"Smithsonian Astrophysical Observation", "SAO 84411"},
        {"Wilson Evans Batten Catalogue", "WEB 13667"},
    },
    visualMagnitude: 2.78,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.55525697),
        dec: Angle.Degrees(+21.48964850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38042"},
        {"Smithsonian Astrophysical Observation", "SAO 79698"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.95826190),
        dec: Angle.Degrees(+21.49110905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152878"},
        {"Hipparcos Number", "HIP 82803"},
        {"Geneva Identification System", "GEN# +1.00152878"},
        {"Smithsonian Astrophysical Observation", "SAO 84695"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.84423062),
        dec: Angle.Degrees(+21.49245560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72615"},
        {"Hipparcos Number", "HIP 42083"},
        {"Smithsonian Astrophysical Observation", "SAO 80262"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.66325832),
        dec: Angle.Degrees(+21.49306574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113663"},
        {"Hipparcos Number", "HIP 63842"},
        {"Geneva Identification System", "GEN# +1.00113663"},
        {"Smithsonian Astrophysical Observation", "SAO 82638"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.26479313),
        dec: Angle.Degrees(+21.49393298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
