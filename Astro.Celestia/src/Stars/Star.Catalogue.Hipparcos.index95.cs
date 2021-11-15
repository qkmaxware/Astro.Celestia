using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_95() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47882"},
        {"Hipparcos Number", "HIP 32125"},
        {"Geneva Identification System", "GEN# +1.00047882"},
        {"Smithsonian Astrophysical Observation", "SAO 59387"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.64334390),
        dec: Angle.Degrees(+38.89225093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40085"},
        {"Hipparcos Number", "HIP 28281"},
        {"Geneva Identification System", "GEN# +1.00040085"},
        {"Smithsonian Astrophysical Observation", "SAO 58619"},
        {"Wilson Evans Batten Catalogue", "WEB 5530"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.63833291),
        dec: Angle.Degrees(+38.89340429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59507"},
        {"Hipparcos Number", "HIP 36624"},
        {"Geneva Identification System", "GEN# +1.00059507"},
        {"Smithsonian Astrophysical Observation", "SAO 60148"},
        {"Wilson Evans Batten Catalogue", "WEB 7278"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.98193320),
        dec: Angle.Degrees(+38.89612387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3892"},
        {"Hipparcos Number", "HIP 3284"},
        {"Celescope Catalog", "CEL 85"},
        {"Geneva Identification System", "GEN# +1.00003892"},
        {"Smithsonian Astrophysical Observation", "SAO 54085"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.46339847),
        dec: Angle.Degrees(+38.89631677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185894"},
        {"Hipparcos Number", "HIP 96727"},
        {"Geneva Identification System", "GEN# +1.00185894"},
        {"Smithsonian Astrophysical Observation", "SAO 68660"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.95086584),
        dec: Angle.Degrees(+38.89666149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13344"},
    },
    visualMagnitude: 10.19,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.93330494),
        dec: Angle.Degrees(+38.89677464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5052",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 880 A"},
        {"Henry Draper", "HD 6321"},
        {"Hipparcos Number", "HIP 5052"},
        {"Geneva Identification System", "GEN# +1.00006321"},
        {"Smithsonian Astrophysical Observation", "SAO 54399"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.16641061),
        dec: Angle.Degrees(+38.89796836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192934"},
        {"Hipparcos Number", "HIP 99893"},
        {"Celescope Catalog", "CEL 5002"},
        {"Geneva Identification System", "GEN# +1.00192934"},
        {"Renson", "Renson 53850"},
        {"Smithsonian Astrophysical Observation", "SAO 69720"},
        {"Wilson Evans Batten Catalogue", "WEB 17967"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.01429331),
        dec: Angle.Degrees(+38.89808634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177858"},
        {"Hipparcos Number", "HIP 93687"},
        {"Smithsonian Astrophysical Observation", "SAO 67780"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.18075894),
        dec: Angle.Degrees(+38.89822097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193032"},
        {"Hipparcos Number", "HIP 99944"},
        {"Geneva Identification System", "GEN# +1.00193032"},
        {"Smithsonian Astrophysical Observation", "SAO 69740"},
        {"Wilson Evans Batten Catalogue", "WEB 17982"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.16834929),
        dec: Angle.Degrees(+38.89930574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9822",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1653 AB"},
        {"Henry Draper", "HD 12804"},
        {"Hipparcos Number", "HIP 9822"},
        {"Smithsonian Astrophysical Observation", "SAO 55264"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.60271591),
        dec: Angle.Degrees(+38.89973105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178971"},
        {"Hipparcos Number", "HIP 94071"},
        {"Geneva Identification System", "GEN# +1.00178971"},
        {"Smithsonian Astrophysical Observation", "SAO 67881"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.25806704),
        dec: Angle.Degrees(+38.89992906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25518"},
        {"Hipparcos Number", "HIP 19040"},
        {"Geneva Identification System", "GEN# +1.00025518"},
        {"Smithsonian Astrophysical Observation", "SAO 56948"},
        {"Wilson Evans Batten Catalogue", "WEB 3659"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.18261061),
        dec: Angle.Degrees(+38.90059174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17708"},
        {"Hipparcos Number", "HIP 13340"},
        {"Smithsonian Astrophysical Observation", "SAO 55948"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.92636262),
        dec: Angle.Degrees(+38.90144278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199397"},
        {"Hipparcos Number", "HIP 103295"},
        {"Geneva Identification System", "GEN# +1.00199397"},
        {"Smithsonian Astrophysical Observation", "SAO 70675"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.90311046),
        dec: Angle.Degrees(+38.90235204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36099"},
        {"Hipparcos Number", "HIP 25852"},
        {"Smithsonian Astrophysical Observation", "SAO 58136"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.77742040),
        dec: Angle.Degrees(+38.90345080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75524"},
        {"Hipparcos Number", "HIP 43522"},
        {"Geneva Identification System", "GEN# +1.00075524"},
        {"Smithsonian Astrophysical Observation", "SAO 61091"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.96551030),
        dec: Angle.Degrees(+38.90530038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179396"},
        {"Hipparcos Number", "HIP 94211"},
        {"Smithsonian Astrophysical Observation", "SAO 67925"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.69501610),
        dec: Angle.Degrees(+38.90549686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37587"},
        {"Hipparcos Number", "HIP 26789"},
        {"Geneva Identification System", "GEN# +1.00037587"},
        {"Smithsonian Astrophysical Observation", "SAO 58330"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.35208387),
        dec: Angle.Degrees(+38.90788400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153896"},
        {"Hipparcos Number", "HIP 83228"},
        {"Geneva Identification System", "GEN# +1.00153896"},
        {"Smithsonian Astrophysical Observation", "SAO 65719"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.13302082),
        dec: Angle.Degrees(+38.90844971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46314"},
        {"Smithsonian Astrophysical Observation", "SAO 61491"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.66615954),
        dec: Angle.Degrees(+38.91070386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214433"},
        {"Hipparcos Number", "HIP 111681"},
        {"Celescope Catalog", "CEL 5497"},
        {"Geneva Identification System", "GEN# +1.00214433"},
        {"Renson", "Renson 59390"},
        {"Smithsonian Astrophysical Observation", "SAO 72546"},
    },
    visualMagnitude: 9.14,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.36513641),
        dec: Angle.Degrees(+38.91175771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227315"},
        {"Hipparcos Number", "HIP 98703"},
        {"Smithsonian Astrophysical Observation", "SAO 69311"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.70508268),
        dec: Angle.Degrees(+38.91182125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97556"},
        {"Geneva Identification System", "GEN# +0.03803773"},
        {"Smithsonian Astrophysical Observation", "SAO 68918"},
    },
    visualMagnitude: 8.54,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.42987112),
        dec: Angle.Degrees(+38.91241809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48566"},
        {"Fundamental Katalog 5th Edition", "FK5 4881"},
        {"Geneva Identification System", "GEN# +0.03902287"},
        {"Smithsonian Astrophysical Observation", "SAO 61745"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.58782796),
        dec: Angle.Degrees(+38.91244875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187298"},
        {"Hipparcos Number", "HIP 97396"},
        {"Geneva Identification System", "GEN# +1.00187298"},
        {"Smithsonian Astrophysical Observation", "SAO 68868"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.92954313),
        dec: Angle.Degrees(+38.91362778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218609"},
        {"Hipparcos Number", "HIP 114305"},
        {"Geneva Identification System", "GEN# +1.00218609"},
        {"Smithsonian Astrophysical Observation", "SAO 73036"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.23781032),
        dec: Angle.Degrees(+38.91518951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81151",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81151"},
        {"Smithsonian Astrophysical Observation", "SAO 65399"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.61546759),
        dec: Angle.Degrees(+38.91521825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87526"},
        {"Smithsonian Astrophysical Observation", "SAO 66425"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.22937110),
        dec: Angle.Degrees(+38.91572569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111679"},
        {"Smithsonian Astrophysical Observation", "SAO 72545"},
    },
    visualMagnitude: 9.44,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.36187164),
        dec: Angle.Degrees(+38.91715927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16284"},
        {"Hipparcos Number", "HIP 12265"},
        {"Geneva Identification System", "GEN# +1.00016284"},
        {"Smithsonian Astrophysical Observation", "SAO 55722"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.47702693),
        dec: Angle.Degrees(+38.91860896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81963"},
        {"Hipparcos Number", "HIP 46596"},
        {"Geneva Identification System", "GEN# +1.00081963"},
        {"Smithsonian Astrophysical Observation", "SAO 61520"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.52684423),
        dec: Angle.Degrees(+38.92193895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81056",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10117 AB"},
        {"Hipparcos Number", "HIP 81056"},
        {"Smithsonian Astrophysical Observation", "SAO 65381"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.32026581),
        dec: Angle.Degrees(+38.92224199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150997"},
        {"Hipparcos Number", "HIP 81833"},
        {"Fundamental Katalog 5th Edition", "FK5 626"},
        {"Geneva Identification System", "GEN# +1.00150997"},
        {"Smithsonian Astrophysical Observation", "SAO 65504"},
        {"Wilson Evans Batten Catalogue", "WEB 13825"},
    },
    visualMagnitude: 3.48,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.72391068),
        dec: Angle.Degrees(+38.92246103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65469",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65469"},
        {"Geneva Identification System", "GEN# +0.03902643"},
        {"Smithsonian Astrophysical Observation", "SAO 63527"},
        {"Wilson Evans Batten Catalogue", "WEB 11553"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.28370521),
        dec: Angle.Degrees(+38.92255054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106879",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106879"},
        {"Geneva Identification System", "GEN# +0.03804564"},
        {"Smithsonian Astrophysical Observation", "SAO 71557"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.71433611),
        dec: Angle.Degrees(+38.92486804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90840"},
        {"Hipparcos Number", "HIP 51420"},
        {"Geneva Identification System", "GEN# +1.00090840"},
        {"Smithsonian Astrophysical Observation", "SAO 62076"},
        {"Wilson Evans Batten Catalogue", "WEB 9386"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.52691646),
        dec: Angle.Degrees(+38.92514300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100215"},
        {"Hipparcos Number", "HIP 56275"},
        {"Geneva Identification System", "GEN# +1.00100215"},
        {"Renson", "Renson 28810"},
        {"Smithsonian Astrophysical Observation", "SAO 62589"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.05366916),
        dec: Angle.Degrees(+38.92585188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8284",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1404 C"},
        {"Henry Draper", "HD 10815C"},
        {"Hipparcos Number", "HIP 8284"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.68664745),
        dec: Angle.Degrees(+38.92624914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113075"},
        {"Hipparcos Number", "HIP 63511"},
        {"Geneva Identification System", "GEN# +1.00113075"},
        {"Smithsonian Astrophysical Observation", "SAO 63296"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.20480939),
        dec: Angle.Degrees(+38.92651224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208837"},
        {"Hipparcos Number", "HIP 108447"},
        {"Geneva Identification System", "GEN# +1.00208837"},
        {"Smithsonian Astrophysical Observation", "SAO 71890"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.52655351),
        dec: Angle.Degrees(+38.92691018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133209"},
        {"Hipparcos Number", "HIP 73561"},
        {"Geneva Identification System", "GEN# +1.00133209"},
        {"Smithsonian Astrophysical Observation", "SAO 64468"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.50656554),
        dec: Angle.Degrees(+38.92709428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8282",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1404 AB"},
        {"Henry Draper", "HD 10815"},
        {"Hipparcos Number", "HIP 8282"},
        {"Smithsonian Astrophysical Observation", "SAO 54970"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.68263131),
        dec: Angle.Degrees(+38.92777602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41990"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.38197284),
        dec: Angle.Degrees(+38.92802913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93954",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12075 AB"},
        {"Henry Draper", "HD 178661"},
        {"Hipparcos Number", "HIP 93954"},
        {"Geneva Identification System", "GEN# +1.00178661J"},
        {"Smithsonian Astrophysical Observation", "SAO 67846"},
        {"Wilson Evans Batten Catalogue", "WEB 16350"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.94832256),
        dec: Angle.Degrees(+38.92821647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175331"},
        {"Hipparcos Number", "HIP 92691"},
        {"Celescope Catalog", "CEL 4663"},
        {"Geneva Identification System", "GEN# +1.00175331"},
        {"Smithsonian Astrophysical Observation", "SAO 67527"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.30724876),
        dec: Angle.Degrees(+38.93112129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5690"},
        {"Hipparcos Number", "HIP 4605"},
        {"Geneva Identification System", "GEN# +1.00005690"},
        {"Smithsonian Astrophysical Observation", "SAO 54313"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.75760473),
        dec: Angle.Degrees(+38.93398311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228778"},
        {"Hipparcos Number", "HIP 100029"},
        {"Smithsonian Astrophysical Observation", "SAO 69770"},
        {"Wilson Evans Batten Catalogue", "WEB 18012"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.41460755),
        dec: Angle.Degrees(+38.93405125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86237"},
        {"Hipparcos Number", "HIP 48878"},
        {"Geneva Identification System", "GEN# +1.00086237"},
        {"Smithsonian Astrophysical Observation", "SAO 61780"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.53453671),
        dec: Angle.Degrees(+38.93623916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82529"},
        {"Smithsonian Astrophysical Observation", "SAO 65619"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.04236502),
        dec: Angle.Degrees(+38.93780593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52601"},
        {"Smithsonian Astrophysical Observation", "SAO 62231"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.34220953),
        dec: Angle.Degrees(+38.93872232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80147",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80147"},
        {"Smithsonian Astrophysical Observation", "SAO 65250"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.39292716),
        dec: Angle.Degrees(+38.93894928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194280"},
        {"Hipparcos Number", "HIP 100557"},
        {"Geneva Identification System", "GEN# +1.00194280"},
        {"Smithsonian Astrophysical Observation", "SAO 69942"},
        {"Wilson Evans Batten Catalogue", "WEB 18167"},
        {"New General Catalogue", "NGC 6913 145"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.85964281),
        dec: Angle.Degrees(+38.93918942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93070",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93070"},
        {"Smithsonian Astrophysical Observation", "SAO 67631"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.37993621),
        dec: Angle.Degrees(+38.93932574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71230",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71230"},
        {"Smithsonian Astrophysical Observation", "SAO 64219"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.49264475),
        dec: Angle.Degrees(+38.93940589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195393"},
        {"Hipparcos Number", "HIP 101092"},
        {"Celescope Catalog", "CEL 5081"},
        {"Geneva Identification System", "GEN# +1.00195393"},
        {"Smithsonian Astrophysical Observation", "SAO 70105"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.39119492),
        dec: Angle.Degrees(+38.94161570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115163"},
        {"Smithsonian Astrophysical Observation", "SAO 73173"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.91547154),
        dec: Angle.Degrees(+38.94451892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88960",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88960"},
        {"Smithsonian Astrophysical Observation", "SAO 66697"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.38416874),
        dec: Angle.Degrees(+38.94484712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119410"},
        {"Hipparcos Number", "HIP 66863"},
        {"Geneva Identification System", "GEN# +1.00119410"},
        {"Smithsonian Astrophysical Observation", "SAO 63698"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.56617170),
        dec: Angle.Degrees(+38.94832626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214489"},
        {"Hipparcos Number", "HIP 111729"},
        {"Celescope Catalog", "CEL 5501"},
        {"Geneva Identification System", "GEN# +1.00214489"},
        {"Smithsonian Astrophysical Observation", "SAO 72553"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.48518378),
        dec: Angle.Degrees(+38.94950386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 214.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47527",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7477 AB"},
        {"Henry Draper", "HD 83698"},
        {"Hipparcos Number", "HIP 47527"},
        {"Geneva Identification System", "GEN# +1.00083698"},
        {"Smithsonian Astrophysical Observation", "SAO 61629"},
        {"Wilson Evans Batten Catalogue", "WEB 8915"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.34115905),
        dec: Angle.Degrees(+38.95052447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6029",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6029"},
        {"Wilson Evans Batten Catalogue", "WEB 1365"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.36404296),
        dec: Angle.Degrees(+38.95064884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134920"},
        {"Hipparcos Number", "HIP 74298"},
        {"Geneva Identification System", "GEN# +1.00134920"},
        {"Smithsonian Astrophysical Observation", "SAO 64545"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.79251714),
        dec: Angle.Degrees(+38.95073513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96456"},
        {"Hipparcos Number", "HIP 54376"},
        {"Smithsonian Astrophysical Observation", "SAO 62415"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.87698451),
        dec: Angle.Degrees(+38.95115975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195377"},
        {"Hipparcos Number", "HIP 101086"},
        {"Geneva Identification System", "GEN# +1.00195377"},
        {"Smithsonian Astrophysical Observation", "SAO 70100"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.36771886),
        dec: Angle.Degrees(+38.95153372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85958"},
        {"Smithsonian Astrophysical Observation", "SAO 66142"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.51901517),
        dec: Angle.Degrees(+38.95153814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40887"},
        {"Smithsonian Astrophysical Observation", "SAO 60742"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.15185215),
        dec: Angle.Degrees(+38.95168814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15442"},
        {"Hipparcos Number", "HIP 11643"},
        {"Smithsonian Astrophysical Observation", "SAO 55606"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.55184954),
        dec: Angle.Degrees(+38.95206584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2773"},
        {"Smithsonian Astrophysical Observation", "SAO 54002"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.84539054),
        dec: Angle.Degrees(+38.95354662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207967"},
        {"Hipparcos Number", "HIP 107934"},
        {"Smithsonian Astrophysical Observation", "SAO 71782"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.01012803),
        dec: Angle.Degrees(+38.95452872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196627"},
        {"Hipparcos Number", "HIP 101723"},
        {"Geneva Identification System", "GEN# +1.00196627"},
        {"Smithsonian Astrophysical Observation", "SAO 70276"},
    },
    visualMagnitude: 8.99,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.29361410),
        dec: Angle.Degrees(+38.95496408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207489"},
        {"Hipparcos Number", "HIP 107653"},
        {"Geneva Identification System", "GEN# +1.00207489"},
        {"Smithsonian Astrophysical Observation", "SAO 71720"},
        {"Wilson Evans Batten Catalogue", "WEB 19422"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.07677090),
        dec: Angle.Degrees(+38.95613191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35477"},
        {"Hipparcos Number", "HIP 25464"},
        {"Geneva Identification System", "GEN# +1.00035477"},
        {"Smithsonian Astrophysical Observation", "SAO 58025"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.68646938),
        dec: Angle.Degrees(+38.95725306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32582"},
        {"Smithsonian Astrophysical Observation", "SAO 59488"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.97607116),
        dec: Angle.Degrees(+38.95736493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219562"},
        {"Hipparcos Number", "HIP 114897"},
        {"Smithsonian Astrophysical Observation", "SAO 73128"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.09602560),
        dec: Angle.Degrees(+38.95909825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95803"},
        {"Hipparcos Number", "HIP 54073"},
        {"Geneva Identification System", "GEN# +1.00095803"},
        {"Smithsonian Astrophysical Observation", "SAO 62382"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.97072045),
        dec: Angle.Degrees(+38.96097603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201795"},
        {"Hipparcos Number", "HIP 104548"},
        {"Celescope Catalog", "CEL 5258"},
        {"Geneva Identification System", "GEN# +1.00201795"},
        {"Smithsonian Astrophysical Observation", "SAO 71018"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.66060917),
        dec: Angle.Degrees(+38.96123379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109043",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15613 AB"},
        {"Hipparcos Number", "HIP 109043"},
        {"Smithsonian Astrophysical Observation", "SAO 72012"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.34509529),
        dec: Angle.Degrees(+38.96129124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166894"},
        {"Hipparcos Number", "HIP 89085"},
        {"Geneva Identification System", "GEN# +1.00166894"},
        {"Renson", "Renson 46950"},
        {"Smithsonian Astrophysical Observation", "SAO 66722"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.72701246),
        dec: Angle.Degrees(+38.96144816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67488"},
    },
    visualMagnitude: 11.38,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.44269506),
        dec: Angle.Degrees(+38.96188822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30860",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Lucilinburhuc"},
        {"Henry Draper", "HD 45350"},
        {"Hipparcos Number", "HIP 30860"},
        {"Geneva Identification System", "GEN# +1.00045350"},
        {"Smithsonian Astrophysical Observation", "SAO 59126"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.19059648),
        dec: Angle.Degrees(+38.96309296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50194"},
    },
    visualMagnitude: 11.64,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.70209990),
        dec: Angle.Degrees(+38.96322249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -342.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224491"},
        {"Hipparcos Number", "HIP 118183"},
        {"Geneva Identification System", "GEN# +1.00224491"},
        {"Smithsonian Astrophysical Observation", "SAO 73641"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.59604057),
        dec: Angle.Degrees(+38.96336131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40698",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6721 D"},
        {"Hipparcos Number", "HIP 40698"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.61236630),
        dec: Angle.Degrees(+38.96389803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -393.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194480"},
        {"Hipparcos Number", "HIP 100644"},
        {"Celescope Catalog", "CEL 5053"},
        {"Geneva Identification System", "GEN# +1.00194480"},
        {"Smithsonian Astrophysical Observation", "SAO 69973"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.10831573),
        dec: Angle.Degrees(+38.96502185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45562"},
        {"Hipparcos Number", "HIP 30974"},
        {"Smithsonian Astrophysical Observation", "SAO 59149"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.51604607),
        dec: Angle.Degrees(+38.96533388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33919"},
    },
    visualMagnitude: 11.34,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.58109860),
        dec: Angle.Degrees(+38.96576040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125390"},
        {"Hipparcos Number", "HIP 69888"},
        {"Geneva Identification System", "GEN# +1.00125390"},
        {"Smithsonian Astrophysical Observation", "SAO 64056"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.53887148),
        dec: Angle.Degrees(+38.96701722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19909"},
        {"Hipparcos Number", "HIP 15006"},
        {"Smithsonian Astrophysical Observation", "SAO 56261"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.35171807),
        dec: Angle.Degrees(+38.96772368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87906"},
        {"Smithsonian Astrophysical Observation", "SAO 66511"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.34542685),
        dec: Angle.Degrees(+38.96838354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7773",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1305 AB"},
        {"Henry Draper", "HD 10156"},
        {"Hipparcos Number", "HIP 7773"},
        {"Geneva Identification System", "GEN# +1.00010156J"},
        {"Smithsonian Astrophysical Observation", "SAO 54884"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.01456194),
        dec: Angle.Degrees(+38.96960427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48589"},
        {"Hipparcos Number", "HIP 32410"},
        {"Geneva Identification System", "GEN# +1.00048589"},
        {"Smithsonian Astrophysical Observation", "SAO 59457"},
    },
    visualMagnitude: 7.29,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.49626891),
        dec: Angle.Degrees(+38.97021371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19882"},
        {"Hipparcos Number", "HIP 14981"},
        {"Geneva Identification System", "GEN# +1.00019882"},
        {"Smithsonian Astrophysical Observation", "SAO 56254"},
        {"Wilson Evans Batten Catalogue", "WEB 2891"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.28131021),
        dec: Angle.Degrees(+38.97264066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111916"},
        {"Celescope Catalog", "CEL 5509"},
        {"Smithsonian Astrophysical Observation", "SAO 72602"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.05226720),
        dec: Angle.Degrees(+38.97349623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27154"},
        {"Smithsonian Astrophysical Observation", "SAO 58400"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.34617217),
        dec: Angle.Degrees(+38.97394110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45042"},
        {"Hipparcos Number", "HIP 30695"},
        {"Geneva Identification System", "GEN# +1.00045042"},
        {"Smithsonian Astrophysical Observation", "SAO 59086"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.74619738),
        dec: Angle.Degrees(+38.97522680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60681",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60681"},
        {"Geneva Identification System", "GEN# +0.03902524"},
        {"Smithsonian Astrophysical Observation", "SAO 63004"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.54055297),
        dec: Angle.Degrees(+38.97539439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74211",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9527 A"},
        {"Henry Draper", "HD 134679"},
        {"Hipparcos Number", "HIP 74211"},
        {"Geneva Identification System", "GEN# +1.00134679A"},
        {"Smithsonian Astrophysical Observation", "SAO 64528"},
        {"Wilson Evans Batten Catalogue", "WEB 12671"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.47587122),
        dec: Angle.Degrees(+38.97578253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149732"},
        {"Hipparcos Number", "HIP 81202"},
        {"Geneva Identification System", "GEN# +1.00149732"},
        {"Smithsonian Astrophysical Observation", "SAO 65408"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.78866048),
        dec: Angle.Degrees(+38.97602651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92506"},
        {"Smithsonian Astrophysical Observation", "SAO 67475"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.78133043),
        dec: Angle.Degrees(+38.97642536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180186"},
        {"Hipparcos Number", "HIP 94498"},
        {"Smithsonian Astrophysical Observation", "SAO 68017"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.49685971),
        dec: Angle.Degrees(+38.97685149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46264",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46264"},
        {"Smithsonian Astrophysical Observation", "SAO 61482"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.49606865),
        dec: Angle.Degrees(+38.97986084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2766"},
        {"Hipparcos Number", "HIP 2473"},
        {"Geneva Identification System", "GEN# +1.00002766"},
        {"Smithsonian Astrophysical Observation", "SAO 53955"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.85450255),
        dec: Angle.Degrees(+38.98060201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17890",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2788"},
        {"Henry Draper", "HD 275877"},
        {"Hipparcos Number", "HIP 17890"},
        {"Smithsonian Astrophysical Observation", "SAO 56726"},
    },
    visualMagnitude: 9.33,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.40137968),
        dec: Angle.Degrees(+38.98211502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34131"},
        {"Smithsonian Astrophysical Observation", "SAO 59743"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.15786172),
        dec: Angle.Degrees(+38.98211583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135519"},
        {"Hipparcos Number", "HIP 74569"},
        {"Smithsonian Astrophysical Observation", "SAO 64576"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.54139166),
        dec: Angle.Degrees(+38.98260795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96299"},
        {"Smithsonian Astrophysical Observation", "SAO 68528"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.69545490),
        dec: Angle.Degrees(+38.98281316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156012"},
        {"Hipparcos Number", "HIP 84259"},
        {"Geneva Identification System", "GEN# +1.00156012"},
        {"Smithsonian Astrophysical Observation", "SAO 65878"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.36337611),
        dec: Angle.Degrees(+38.98509446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40681",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6721"},
        {"Aitken 2", "ADS 6721 AB"},
        {"Hipparcos Number", "HIP 40681"},
        {"Smithsonian Astrophysical Observation", "SAO 60711"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.58186756),
        dec: Angle.Degrees(+38.98610935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134043"},
        {"Hipparcos Number", "HIP 73934"},
        {"Cincinnati Publication", "Ci 18 2009"},
        {"Smithsonian Astrophysical Observation", "SAO 64504"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.63365580),
        dec: Angle.Degrees(+38.98631830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -322.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125858"},
        {"Hipparcos Number", "HIP 70135"},
        {"Geneva Identification System", "GEN# +1.00125858"},
        {"Smithsonian Astrophysical Observation", "SAO 64090"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.27019185),
        dec: Angle.Degrees(+38.98748144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135162"},
        {"Hipparcos Number", "HIP 74404"},
        {"Geneva Identification System", "GEN# +1.00135162"},
        {"Smithsonian Astrophysical Observation", "SAO 64557"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.09608665),
        dec: Angle.Degrees(+38.98754540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113969"},
        {"Hipparcos Number", "HIP 63987"},
        {"Geneva Identification System", "GEN# +1.00113969"},
        {"Smithsonian Astrophysical Observation", "SAO 63347"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.68998357),
        dec: Angle.Degrees(+38.98901573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6239"},
    },
    visualMagnitude: 12.03,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.01381157),
        dec: Angle.Degrees(+38.98999015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 325.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 179.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161674"},
        {"Hipparcos Number", "HIP 86886"},
        {"Smithsonian Astrophysical Observation", "SAO 66307"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.28889779),
        dec: Angle.Degrees(+38.99081249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38401"},
        {"Hipparcos Number", "HIP 27327"},
        {"Geneva Identification System", "GEN# +1.00038401"},
        {"Smithsonian Astrophysical Observation", "SAO 58428"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.83263874),
        dec: Angle.Degrees(+38.99216337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205999"},
        {"Hipparcos Number", "HIP 106823"},
        {"Smithsonian Astrophysical Observation", "SAO 71545"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.52645120),
        dec: Angle.Degrees(+38.99243785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70805",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70805"},
        {"Smithsonian Astrophysical Observation", "SAO 64166"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.20582913),
        dec: Angle.Degrees(+38.99479367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57263"},
        {"Hipparcos Number", "HIP 35725"},
        {"Geneva Identification System", "GEN# +1.00057263"},
        {"Smithsonian Astrophysical Observation", "SAO 60012"},
        {"Wilson Evans Batten Catalogue", "WEB 7118"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.55587170),
        dec: Angle.Degrees(+38.99603466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79801",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79801"},
        {"Smithsonian Astrophysical Observation", "SAO 65202"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.30296227),
        dec: Angle.Degrees(+38.99608727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165758"},
        {"Hipparcos Number", "HIP 88638"},
        {"Geneva Identification System", "GEN# +1.00165758"},
        {"Smithsonian Astrophysical Observation", "SAO 66629"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.45874653),
        dec: Angle.Degrees(+38.99811773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115441",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115441"},
        {"Smithsonian Astrophysical Observation", "SAO 73212"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.75153143),
        dec: Angle.Degrees(+38.99916224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207648"},
        {"Hipparcos Number", "HIP 107738"},
        {"Smithsonian Astrophysical Observation", "SAO 71743"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.37613766),
        dec: Angle.Degrees(+39.00172333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88112"},
        {"Geneva Identification System", "GEN# +0.03903294"},
        {"Smithsonian Astrophysical Observation", "SAO 66543"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.92929440),
        dec: Angle.Degrees(+39.00195103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33016"},
        {"Hipparcos Number", "HIP 23965"},
        {"Geneva Identification System", "GEN# +1.00033016"},
        {"Wilson Evans Batten Catalogue", "WEB 4672"},
    },
    visualMagnitude: 8.96,
    bvColour: 2.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.27278574),
        dec: Angle.Degrees(+39.00236531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36992"},
        {"Hipparcos Number", "HIP 26409"},
        {"Geneva Identification System", "GEN# +1.00036992"},
        {"Smithsonian Astrophysical Observation", "SAO 58252"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.31417244),
        dec: Angle.Degrees(+39.00319301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100155",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13690 AB"},
        {"Henry Draper", "HD 193469"},
        {"Hipparcos Number", "HIP 100155"},
        {"Geneva Identification System", "GEN# +1.00193469J"},
        {"Smithsonian Astrophysical Observation", "SAO 69820"},
        {"Wilson Evans Batten Catalogue", "WEB 18042"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.73974671),
        dec: Angle.Degrees(+39.00420342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57245",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8286 AB"},
        {"Henry Draper", "HD 101977"},
        {"Hipparcos Number", "HIP 57245"},
        {"Geneva Identification System", "GEN# +1.00101977J"},
        {"Smithsonian Astrophysical Observation", "SAO 62678"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.07677863),
        dec: Angle.Degrees(+39.00683324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89528"},
        {"Smithsonian Astrophysical Observation", "SAO 66811"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.02366963),
        dec: Angle.Degrees(+39.00725055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139153"},
        {"Hipparcos Number", "HIP 76307"},
        {"Geneva Identification System", "GEN# +1.00139153"},
        {"Smithsonian Astrophysical Observation", "SAO 64790"},
        {"Wilson Evans Batten Catalogue", "WEB 12955"},
    },
    visualMagnitude: 5.14,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.81208385),
        dec: Angle.Degrees(+39.01004619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70297",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70297"},
        {"Smithsonian Astrophysical Observation", "SAO 64112"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.74926057),
        dec: Angle.Degrees(+39.01048618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2756"},
        {"Hipparcos Number", "HIP 2469"},
        {"Geneva Identification System", "GEN# +1.00002756"},
        {"Smithsonian Astrophysical Observation", "SAO 53953"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.83799837),
        dec: Angle.Degrees(+39.01095458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72110"},
        {"Smithsonian Astrophysical Observation", "SAO 64305"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.25341070),
        dec: Angle.Degrees(+39.01251389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71050"},
        {"Hipparcos Number", "HIP 41411"},
        {"Smithsonian Astrophysical Observation", "SAO 60814"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.70486343),
        dec: Angle.Degrees(+39.01308622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33061"},
        {"Hipparcos Number", "HIP 23994"},
        {"Celescope Catalog", "CEL 544"},
        {"Geneva Identification System", "GEN# +1.00033061"},
        {"Smithsonian Astrophysical Observation", "SAO 57685"},
        {"Wilson Evans Batten Catalogue", "WEB 4675"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.36649093),
        dec: Angle.Degrees(+39.01688321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108225"},
        {"Hipparcos Number", "HIP 60646"},
        {"Fundamental Katalog 5th Edition", "FK5 461"},
        {"Geneva Identification System", "GEN# +1.00108225"},
        {"Smithsonian Astrophysical Observation", "SAO 63000"},
        {"Wilson Evans Batten Catalogue", "WEB 10787"},
    },
    visualMagnitude: 5.01,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.46248809),
        dec: Angle.Degrees(+39.01869867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90990"},
        {"Hipparcos Number", "HIP 51497"},
        {"Geneva Identification System", "GEN# +1.00090990"},
        {"Smithsonian Astrophysical Observation", "SAO 62091"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.76194119),
        dec: Angle.Degrees(+39.02080146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1129"},
        {"Hipparcos Number", "HIP 1256"},
        {"Smithsonian Astrophysical Observation", "SAO 53761"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.93757958),
        dec: Angle.Degrees(+39.02084840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33687"},
        {"Hipparcos Number", "HIP 24376"},
        {"Geneva Identification System", "GEN# +1.00033687"},
        {"Smithsonian Astrophysical Observation", "SAO 57766"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.44603571),
        dec: Angle.Degrees(+39.02100796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102234"},
        {"Smithsonian Astrophysical Observation", "SAO 70415"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.73489601),
        dec: Angle.Degrees(+39.02377814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26293",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26293"},
        {"Smithsonian Astrophysical Observation", "SAO 58220"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.98428424),
        dec: Angle.Degrees(+39.02406357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8481"},
        {"Hipparcos Number", "HIP 6578"},
        {"Geneva Identification System", "GEN# +1.00008481"},
        {"Smithsonian Astrophysical Observation", "SAO 54667"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.12856200),
        dec: Angle.Degrees(+39.02507826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211645"},
        {"Hipparcos Number", "HIP 110076"},
        {"Geneva Identification System", "GEN# +1.00211645"},
        {"Smithsonian Astrophysical Observation", "SAO 72214"},
        {"Wilson Evans Batten Catalogue", "WEB 19760"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.45787181),
        dec: Angle.Degrees(+39.02595339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164823"},
        {"Hipparcos Number", "HIP 88243"},
        {"Smithsonian Astrophysical Observation", "SAO 66559"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.29243038),
        dec: Angle.Degrees(+39.02850442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181022"},
        {"Hipparcos Number", "HIP 94781"},
        {"Smithsonian Astrophysical Observation", "SAO 68084"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.28780976),
        dec: Angle.Degrees(+39.02856639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4479"},
        {"Hipparcos Number", "HIP 3692"},
        {"Geneva Identification System", "GEN# +1.00004479"},
        {"Smithsonian Astrophysical Observation", "SAO 54147"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.83384165),
        dec: Angle.Degrees(+39.02965364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122326"},
        {"Hipparcos Number", "HIP 68418"},
        {"Geneva Identification System", "GEN# +1.00122326"},
        {"Smithsonian Astrophysical Observation", "SAO 63881"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.09759465),
        dec: Angle.Degrees(+39.02993946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193855"},
        {"Hipparcos Number", "HIP 100351"},
        {"Geneva Identification System", "GEN# +1.00193855"},
        {"Smithsonian Astrophysical Observation", "SAO 69880"},
        {"Wilson Evans Batten Catalogue", "WEB 18106"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.28142972),
        dec: Angle.Degrees(+39.03159398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36833"},
        {"Hipparcos Number", "HIP 26320"},
        {"Smithsonian Astrophysical Observation", "SAO 58229"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.08586622),
        dec: Angle.Degrees(+39.03232896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107053"},
        {"Smithsonian Astrophysical Observation", "SAO 71591"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.22285032),
        dec: Angle.Degrees(+39.03298582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222327"},
        {"Hipparcos Number", "HIP 116736"},
        {"Smithsonian Astrophysical Observation", "SAO 73412"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.86032031),
        dec: Angle.Degrees(+39.03368082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32110",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5338 A"},
        {"Henry Draper", "HD 47834"},
        {"Hipparcos Number", "HIP 32110"},
        {"Smithsonian Astrophysical Observation", "SAO 59385"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.61300666),
        dec: Angle.Degrees(+39.03431647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 291"},
        {"Hipparcos Number", "HIP 630"},
        {"Fundamental Katalog 5th Edition", "FK5 4016"},
        {"Geneva Identification System", "GEN# +1.00000291"},
        {"Smithsonian Astrophysical Observation", "SAO 53662"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.91877912),
        dec: Angle.Degrees(+39.03491283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2074"},
        {"Hipparcos Number", "HIP 1984"},
        {"Geneva Identification System", "GEN# +1.00002074"},
        {"Smithsonian Astrophysical Observation", "SAO 53875"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.27683433),
        dec: Angle.Degrees(+39.03592175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90008"},
        {"Hipparcos Number", "HIP 50927"},
        {"Geneva Identification System", "GEN# +1.00090008"},
        {"Smithsonian Astrophysical Observation", "SAO 62015"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.01768744),
        dec: Angle.Degrees(+39.03606071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63351"},
        {"Smithsonian Astrophysical Observation", "SAO 63277"},
    },
    visualMagnitude: 11.14,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.72118532),
        dec: Angle.Degrees(+39.03688003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112942"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.11394424),
        dec: Angle.Degrees(+39.03764328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42231",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42231"},
    },
    visualMagnitude: 11.84,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.15797663),
        dec: Angle.Degrees(+39.03829686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -498.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68437"},
        {"Hipparcos Number", "HIP 40319"},
        {"Geneva Identification System", "GEN# +1.00068437"},
        {"Smithsonian Astrophysical Observation", "SAO 60655"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.49044163),
        dec: Angle.Degrees(+39.03837673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210771"},
        {"Hipparcos Number", "HIP 109581"},
        {"Geneva Identification System", "GEN# +1.00210771"},
        {"Smithsonian Astrophysical Observation", "SAO 72118"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.97563915),
        dec: Angle.Degrees(+39.03873608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 765"},
        {"Hipparcos Number", "HIP 978"},
        {"Smithsonian Astrophysical Observation", "SAO 53713"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.02532163),
        dec: Angle.Degrees(+39.03890984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10176",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1683 A"},
        {"Henry Draper", "HD 13294"},
        {"Hipparcos Number", "HIP 10176"},
        {"Celescope Catalog", "CEL 216"},
        {"Geneva Identification System", "GEN# +1.00013294"},
        {"Smithsonian Astrophysical Observation", "SAO 55330"},
        {"Wilson Evans Batten Catalogue", "WEB 2123"},
    },
    visualMagnitude: 6.09,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.72014334),
        dec: Angle.Degrees(+39.03957814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105725"},
        {"Smithsonian Astrophysical Observation", "SAO 71304"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.20194736),
        dec: Angle.Degrees(+39.04010622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110872"},
        {"Smithsonian Astrophysical Observation", "SAO 72368"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.93614654),
        dec: Angle.Degrees(+39.04250027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5072"},
        {"Hipparcos Number", "HIP 4144"},
        {"Geneva Identification System", "GEN# +1.00005072"},
        {"Smithsonian Astrophysical Observation", "SAO 54227"},
        {"Wilson Evans Batten Catalogue", "WEB 737"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.24718195),
        dec: Angle.Degrees(+39.04300372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 153.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10180",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1683 B"},
        {"Henry Draper", "HD 13295"},
        {"Hipparcos Number", "HIP 10180"},
        {"Geneva Identification System", "GEN# +1.00013295"},
        {"Smithsonian Astrophysical Observation", "SAO 55331"},
        {"Wilson Evans Batten Catalogue", "WEB 2124"},
        {"Wilson Evans Batten Catalogue 2", "WEB 2126"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.72364037),
        dec: Angle.Degrees(+39.04333440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62577"},
        {"Geneva Identification System", "GEN# +0.03902566"},
        {"Smithsonian Astrophysical Observation", "SAO 63210"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.32884019),
        dec: Angle.Degrees(+39.04536538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222240"},
        {"Hipparcos Number", "HIP 116674"},
        {"Smithsonian Astrophysical Observation", "SAO 73401"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.66994599),
        dec: Angle.Degrees(+39.04566263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34093"},
        {"Hipparcos Number", "HIP 24605"},
        {"Geneva Identification System", "GEN# +1.00034093J"},
        {"Smithsonian Astrophysical Observation", "SAO 57821"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.16678042),
        dec: Angle.Degrees(+39.04579429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59683"},
        {"Hipparcos Number", "HIP 36679"},
        {"Geneva Identification System", "GEN# +1.00059683"},
        {"Smithsonian Astrophysical Observation", "SAO 60163"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.18967368),
        dec: Angle.Degrees(+39.04813772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25672"},
        {"Wilson Evans Batten Catalogue", "WEB 4984"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.24972769),
        dec: Angle.Degrees(+39.04843222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3286"},
        {"Smithsonian Astrophysical Observation", "SAO 54087"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.47882302),
        dec: Angle.Degrees(+39.04927572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70986"},
        {"Hipparcos Number", "HIP 41382"},
        {"Smithsonian Astrophysical Observation", "SAO 60813"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.63660811),
        dec: Angle.Degrees(+39.04929657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227393"},
        {"Hipparcos Number", "HIP 98749"},
        {"Smithsonian Astrophysical Observation", "SAO 69327"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.86094057),
        dec: Angle.Degrees(+39.05000679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111841",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16148 A"},
        {"Henry Draper", "HD 214680"},
        {"Hipparcos Number", "HIP 111841"},
        {"Celescope Catalog", "CEL 5504"},
        {"Fundamental Katalog 5th Edition", "FK5 852"},
        {"Geneva Identification System", "GEN# +1.00214680A"},
        {"Smithsonian Astrophysical Observation", "SAO 72575"},
        {"Wilson Evans Batten Catalogue", "WEB 19979"},
    },
    visualMagnitude: 4.89,
    bvColour: -0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.81532883),
        dec: Angle.Degrees(+39.05028301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106552",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106552"},
    },
    visualMagnitude: 10.23,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.69357529),
        dec: Angle.Degrees(+39.05031449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21048"},
        {"Hipparcos Number", "HIP 15935"},
        {"Smithsonian Astrophysical Observation", "SAO 56427"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.30418661),
        dec: Angle.Degrees(+39.05144782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53620"},
        {"Smithsonian Astrophysical Observation", "SAO 62333"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.55137784),
        dec: Angle.Degrees(+39.05215893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27831"},
        {"Hipparcos Number", "HIP 20633"},
        {"Geneva Identification System", "GEN# +1.00027831"},
        {"Smithsonian Astrophysical Observation", "SAO 57219"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.33276029),
        dec: Angle.Degrees(+39.05267679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37517"},
        {"Hipparcos Number", "HIP 26746"},
        {"Geneva Identification System", "GEN# +1.00037517"},
        {"Smithsonian Astrophysical Observation", "SAO 58324"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.24725263),
        dec: Angle.Degrees(+39.05325324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89926",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89926"},
        {"Smithsonian Astrophysical Observation", "SAO 66888"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.23732829),
        dec: Angle.Degrees(+39.05362943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145957"},
        {"Hipparcos Number", "HIP 79385"},
        {"Geneva Identification System", "GEN# +1.00145957"},
        {"Smithsonian Astrophysical Observation", "SAO 65139"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.02727947),
        dec: Angle.Degrees(+39.05557580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20499"},
        {"Hipparcos Number", "HIP 15456"},
        {"Geneva Identification System", "GEN# +1.00020499"},
        {"Smithsonian Astrophysical Observation", "SAO 56345"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.82958354),
        dec: Angle.Degrees(+39.05562989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52129",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52129"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.75229875),
        dec: Angle.Degrees(+39.05680007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116952",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16939 AB"},
        {"Henry Draper", "HD 222648"},
        {"Hipparcos Number", "HIP 116952"},
        {"Smithsonian Astrophysical Observation", "SAO 73450"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.60177297),
        dec: Angle.Degrees(+39.05817888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73992"},
        {"Hipparcos Number", "HIP 42744"},
        {"Smithsonian Astrophysical Observation", "SAO 60998"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.67390994),
        dec: Angle.Degrees(+39.06144056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8467"},
        {"Hipparcos Number", "HIP 6575"},
        {"Geneva Identification System", "GEN# +1.00008467"},
        {"Smithsonian Astrophysical Observation", "SAO 54666"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.11600570),
        dec: Angle.Degrees(+39.06213484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57893",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57893"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.11195927),
        dec: Angle.Degrees(+39.06286978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166410"},
        {"Hipparcos Number", "HIP 88880"},
        {"Geneva Identification System", "GEN# +1.00166410"},
        {"Smithsonian Astrophysical Observation", "SAO 66676"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.17902077),
        dec: Angle.Degrees(+39.06441146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18246"},
        {"Hipparcos Number", "HIP 13755"},
        {"Geneva Identification System", "GEN# +1.00018246"},
        {"Smithsonian Astrophysical Observation", "SAO 56024"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.26800943),
        dec: Angle.Degrees(+39.06507391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21156"},
        {"Hipparcos Number", "HIP 16020"},
        {"Geneva Identification System", "GEN# +1.00021156"},
        {"Smithsonian Astrophysical Observation", "SAO 56446"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.57116534),
        dec: Angle.Degrees(+39.06737586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5212"},
        {"Hipparcos Number", "HIP 4255"},
        {"Renson", "Renson 1380"},
        {"Smithsonian Astrophysical Observation", "SAO 54249"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.56874578),
        dec: Angle.Degrees(+39.06807735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7226"},
        {"Hipparcos Number", "HIP 5689"},
        {"Geneva Identification System", "GEN# +1.00007226"},
        {"Smithsonian Astrophysical Observation", "SAO 54521"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.29240790),
        dec: Angle.Degrees(+39.07029170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173631"},
        {"Hipparcos Number", "HIP 91951"},
        {"Geneva Identification System", "GEN# +1.00173631"},
        {"Smithsonian Astrophysical Observation", "SAO 67317"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.14740578),
        dec: Angle.Degrees(+39.07091919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56303",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56303"},
        {"Smithsonian Astrophysical Observation", "SAO 62595"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.13650382),
        dec: Angle.Degrees(+39.07200826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106386",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15078 AB"},
        {"Henry Draper", "HD 205223"},
        {"Hipparcos Number", "HIP 106386"},
        {"Geneva Identification System", "GEN# +1.00205223J"},
        {"Smithsonian Astrophysical Observation", "SAO 71452"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.20690184),
        dec: Angle.Degrees(+39.07224712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64245"},
        {"Geneva Identification System", "GEN# +0.03902612"},
        {"Smithsonian Astrophysical Observation", "SAO 63379"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.51115366),
        dec: Angle.Degrees(+39.07425000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38246"},
        {"Hipparcos Number", "HIP 27228"},
        {"Geneva Identification System", "GEN# +1.00038246"},
        {"Smithsonian Astrophysical Observation", "SAO 58414"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.55497685),
        dec: Angle.Degrees(+39.07525422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166757"},
        {"Hipparcos Number", "HIP 89033"},
        {"Geneva Identification System", "GEN# +1.00166757"},
        {"Smithsonian Astrophysical Observation", "SAO 66711"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.57200732),
        dec: Angle.Degrees(+39.07583889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50988"},
        {"Smithsonian Astrophysical Observation", "SAO 62025"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.23927320),
        dec: Angle.Degrees(+39.07661596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84049",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84049"},
        {"Smithsonian Astrophysical Observation", "SAO 65851"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.74344210),
        dec: Angle.Degrees(+39.07858227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218180"},
        {"Hipparcos Number", "HIP 114023"},
        {"Smithsonian Astrophysical Observation", "SAO 72986"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.36877830),
        dec: Angle.Degrees(+39.07887845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38546"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.40078754),
        dec: Angle.Degrees(+39.07944018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12509",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2032 AP"},
        {"Hipparcos Number", "HIP 12509"},
        {"Geneva Identification System", "GEN# +0.03800536J"},
        {"Smithsonian Astrophysical Observation", "SAO 55779"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.24413229),
        dec: Angle.Degrees(+39.07971204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95733",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95733"},
    },
    visualMagnitude: 11.02,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.08756072),
        dec: Angle.Degrees(+39.08071418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207530"},
        {"Hipparcos Number", "HIP 107671"},
        {"Smithsonian Astrophysical Observation", "SAO 71724"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.15217964),
        dec: Angle.Degrees(+39.08204970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197226"},
        {"Hipparcos Number", "HIP 102062"},
        {"Celescope Catalog", "CEL 5141"},
        {"Fundamental Katalog 5th Edition", "FK5 3653"},
        {"Geneva Identification System", "GEN# +1.00197226"},
        {"Smithsonian Astrophysical Observation", "SAO 70367"},
        {"Wilson Evans Batten Catalogue", "WEB 18455"},
    },
    visualMagnitude: 6.51,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.25149914),
        dec: Angle.Degrees(+39.08232275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80705",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80705"},
        {"Smithsonian Astrophysical Observation", "SAO 65326"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.16066759),
        dec: Angle.Degrees(+39.08238640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14144"},
        {"Hipparcos Number", "HIP 10755"},
        {"Smithsonian Astrophysical Observation", "SAO 55443"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.58793376),
        dec: Angle.Degrees(+39.08488537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39977",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39977"},
        {"Smithsonian Astrophysical Observation", "SAO 60607"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.46059116),
        dec: Angle.Degrees(+39.08559278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86492"},
        {"Smithsonian Astrophysical Observation", "SAO 66244"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.12746224),
        dec: Angle.Degrees(+39.08625760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19301"},
        {"Hipparcos Number", "HIP 14522"},
        {"Geneva Identification System", "GEN# +1.00019301"},
        {"Smithsonian Astrophysical Observation", "SAO 56176"},
        {"Wilson Evans Batten Catalogue", "WEB 2822"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.88377578),
        dec: Angle.Degrees(+39.08677485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29319",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29319"},
        {"Smithsonian Astrophysical Observation", "SAO 58834"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.73919190),
        dec: Angle.Degrees(+39.08824121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2248",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 381 A"},
        {"Henry Draper", "HD 2461"},
        {"Hipparcos Number", "HIP 2248"},
        {"Geneva Identification System", "GEN# +1.00002461J"},
        {"Smithsonian Astrophysical Observation", "SAO 53923"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.15311157),
        dec: Angle.Degrees(+39.09013947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168794"},
        {"Hipparcos Number", "HIP 89814"},
        {"Geneva Identification System", "GEN# +1.00168794"},
        {"Smithsonian Astrophysical Observation", "SAO 66868"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.94099709),
        dec: Angle.Degrees(+39.09144233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43421"},
        {"Hipparcos Number", "HIP 29925"},
        {"Smithsonian Astrophysical Observation", "SAO 58953"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.49898964),
        dec: Angle.Degrees(+39.09160472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57047"},
        {"Hipparcos Number", "HIP 35640"},
        {"Geneva Identification System", "GEN# +1.00057047"},
        {"Smithsonian Astrophysical Observation", "SAO 59994"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.31573223),
        dec: Angle.Degrees(+39.09185160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8008"},
        {"Hipparcos Number", "HIP 6248"},
        {"Fundamental Katalog 5th Edition", "FK5 4121"},
        {"Geneva Identification System", "GEN# +1.00008008"},
        {"Smithsonian Astrophysical Observation", "SAO 54608"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.03951595),
        dec: Angle.Degrees(+39.09355082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112364"},
        {"Smithsonian Astrophysical Observation", "SAO 72694"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.38808254),
        dec: Angle.Degrees(+39.09427349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41374"},
        {"Hipparcos Number", "HIP 28947"},
        {"Smithsonian Astrophysical Observation", "SAO 58750"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.65153801),
        dec: Angle.Degrees(+39.09593188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202682"},
        {"Hipparcos Number", "HIP 105021"},
        {"Geneva Identification System", "GEN# +1.00202682"},
        {"Smithsonian Astrophysical Observation", "SAO 71147"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.08563483),
        dec: Angle.Degrees(+39.09614362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25271"},
        {"Hipparcos Number", "HIP 18851"},
        {"Geneva Identification System", "GEN# +1.00025271"},
        {"Smithsonian Astrophysical Observation", "SAO 56916"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.62243306),
        dec: Angle.Degrees(+39.09734453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157327"},
        {"Hipparcos Number", "HIP 84873"},
        {"Geneva Identification System", "GEN# +1.00157327"},
        {"Smithsonian Astrophysical Observation", "SAO 65967"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.19049170),
        dec: Angle.Degrees(+39.09754917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191045"},
        {"Hipparcos Number", "HIP 99035"},
        {"Geneva Identification System", "GEN# +1.00191045"},
        {"Smithsonian Astrophysical Observation", "SAO 69417"},
        {"Wilson Evans Batten Catalogue", "WEB 17607"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.60417604),
        dec: Angle.Degrees(+39.09859975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153832"},
        {"Hipparcos Number", "HIP 83186"},
        {"Geneva Identification System", "GEN# +1.00153832"},
        {"Smithsonian Astrophysical Observation", "SAO 65717"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.02273132),
        dec: Angle.Degrees(+39.10034967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 117.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166956"},
        {"Hipparcos Number", "HIP 89110"},
        {"Geneva Identification System", "GEN# +1.00166956"},
        {"Smithsonian Astrophysical Observation", "SAO 66730"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.80419306),
        dec: Angle.Degrees(+39.10055912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48032"},
        {"Smithsonian Astrophysical Observation", "SAO 61685"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.87069409),
        dec: Angle.Degrees(+39.10241900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131301"},
        {"Hipparcos Number", "HIP 72682"},
        {"Geneva Identification System", "GEN# +1.00131301"},
        {"Smithsonian Astrophysical Observation", "SAO 64365"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.90917447),
        dec: Angle.Degrees(+39.10331431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82953"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.27158649),
        dec: Angle.Degrees(+39.10490901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39314"},
        {"Hipparcos Number", "HIP 27859"},
        {"Smithsonian Astrophysical Observation", "SAO 58538"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.41201354),
        dec: Angle.Degrees(+39.10502322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151614"},
        {"Hipparcos Number", "HIP 82139"},
        {"Geneva Identification System", "GEN# +1.00151614"},
        {"Smithsonian Astrophysical Observation", "SAO 65554"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.70926245),
        dec: Angle.Degrees(+39.10508091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97913",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13091 A"},
        {"Henry Draper", "HD 188501"},
        {"Hipparcos Number", "HIP 97913"},
        {"Geneva Identification System", "GEN# +1.00188501"},
        {"Renson", "Renson 52070"},
        {"Smithsonian Astrophysical Observation", "SAO 69045"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.46578601),
        dec: Angle.Degrees(+39.10716634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217659"},
        {"Hipparcos Number", "HIP 113717"},
        {"Geneva Identification System", "GEN# +1.00217659"},
        {"Smithsonian Astrophysical Observation", "SAO 72941"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.46412232),
        dec: Angle.Degrees(+39.10799124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44540"},
        {"Hipparcos Number", "HIP 30454"},
        {"Geneva Identification System", "GEN# +1.00044540"},
        {"Smithsonian Astrophysical Observation", "SAO 59039"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.02338597),
        dec: Angle.Degrees(+39.11015168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45311"},
        {"Hipparcos Number", "HIP 30822"},
        {"Geneva Identification System", "GEN# +1.00045311"},
        {"Smithsonian Astrophysical Observation", "SAO 59117"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.13202523),
        dec: Angle.Degrees(+39.11047626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141142"},
        {"Hipparcos Number", "HIP 77222"},
        {"Geneva Identification System", "GEN# +1.00141142"},
        {"Smithsonian Astrophysical Observation", "SAO 64886"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.50520959),
        dec: Angle.Degrees(+39.11048749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50487",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7719 AB"},
        {"Henry Draper", "HD 89252"},
        {"Hipparcos Number", "HIP 50487"},
        {"Geneva Identification System", "GEN# +1.00089252"},
        {"Smithsonian Astrophysical Observation", "SAO 61977"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.63928847),
        dec: Angle.Degrees(+39.11053354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224576"},
        {"Hipparcos Number", "HIP 118230"},
        {"Geneva Identification System", "GEN# +1.00224576"},
        {"Smithsonian Astrophysical Observation", "SAO 73651"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.72146307),
        dec: Angle.Degrees(+39.11115513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124695"},
        {"Hipparcos Number", "HIP 69534"},
        {"Geneva Identification System", "GEN# +1.00124695"},
        {"Smithsonian Astrophysical Observation", "SAO 64010"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.51979917),
        dec: Angle.Degrees(+39.11138985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17201"},
        {"Hipparcos Number", "HIP 12968"},
        {"Smithsonian Astrophysical Observation", "SAO 55863"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.69932256),
        dec: Angle.Degrees(+39.11274788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17190",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2677 A"},
        {"Henry Draper", "HD 22733"},
        {"Hipparcos Number", "HIP 17190"},
        {"Geneva Identification System", "GEN# +1.00022733"},
        {"Smithsonian Astrophysical Observation", "SAO 56623"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.20896541),
        dec: Angle.Degrees(+39.11719621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85718"},
        {"Hipparcos Number", "HIP 48604"},
        {"Smithsonian Astrophysical Observation", "SAO 61751"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.68001949),
        dec: Angle.Degrees(+39.11925897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47048"},
        {"Hipparcos Number", "HIP 31757"},
        {"Smithsonian Astrophysical Observation", "SAO 59313"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.64239240),
        dec: Angle.Degrees(+39.11979960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225173"},
        {"Hipparcos Number", "HIP 325"},
        {"Smithsonian Astrophysical Observation", "SAO 53613"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.04362757),
        dec: Angle.Degrees(+39.12012608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181069"},
        {"Hipparcos Number", "HIP 94799"},
        {"Geneva Identification System", "GEN# +1.00181069"},
        {"Smithsonian Astrophysical Observation", "SAO 68089"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.33320656),
        dec: Angle.Degrees(+39.12112485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34158"},
        {"Smithsonian Astrophysical Observation", "SAO 59750"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.24408462),
        dec: Angle.Degrees(+39.12114204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43402"},
        {"Hipparcos Number", "HIP 29914"},
        {"Geneva Identification System", "GEN# +1.00043402"},
        {"Smithsonian Astrophysical Observation", "SAO 58950"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.46583029),
        dec: Angle.Degrees(+39.12146427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17188",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2677 B"},
        {"Hipparcos Number", "HIP 17188"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.20682288),
        dec: Angle.Degrees(+39.12244247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170027"},
        {"Hipparcos Number", "HIP 90314"},
        {"Smithsonian Astrophysical Observation", "SAO 66961"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.41300693),
        dec: Angle.Degrees(+39.12259987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117177",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117177"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.35184178),
        dec: Angle.Degrees(+39.12361484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 267.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205051"},
        {"Hipparcos Number", "HIP 106292"},
        {"Geneva Identification System", "GEN# +1.00205051"},
        {"Smithsonian Astrophysical Observation", "SAO 71428"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.92196918),
        dec: Angle.Degrees(+39.12717117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36266"},
        {"Smithsonian Astrophysical Observation", "SAO 60096"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.01097494),
        dec: Angle.Degrees(+39.12887922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105881"},
        {"Hipparcos Number", "HIP 59405"},
        {"Geneva Identification System", "GEN# +1.00105881"},
        {"Smithsonian Astrophysical Observation", "SAO 62883"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.79048627),
        dec: Angle.Degrees(+39.13014945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57700"},
        {"Hipparcos Number", "HIP 35908"},
        {"Geneva Identification System", "GEN# +1.00057700"},
        {"Smithsonian Astrophysical Observation", "SAO 60047"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.03622000),
        dec: Angle.Degrees(+39.13197182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46052",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7332 AB"},
        {"Henry Draper", "HD 80902"},
        {"Hipparcos Number", "HIP 46052"},
        {"Geneva Identification System", "GEN# +1.00080902J"},
        {"Smithsonian Astrophysical Observation", "SAO 61441"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.86823061),
        dec: Angle.Degrees(+39.13481273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191703"},
        {"Hipparcos Number", "HIP 99346"},
        {"Geneva Identification System", "GEN# +1.00191703"},
        {"Smithsonian Astrophysical Observation", "SAO 69530"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.46002336),
        dec: Angle.Degrees(+39.13694127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15420"},
        {"Hipparcos Number", "HIP 11623"},
        {"Geneva Identification System", "GEN# +1.00015420"},
        {"Smithsonian Astrophysical Observation", "SAO 55605"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.48256621),
        dec: Angle.Degrees(+39.13711153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8682",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8682"},
        {"Smithsonian Astrophysical Observation", "SAO 55042"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.93004330),
        dec: Angle.Degrees(+39.14065873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21352",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3303 AB"},
        {"Henry Draper", "HD 276666"},
        {"Hipparcos Number", "HIP 21352"},
        {"Smithsonian Astrophysical Observation", "SAO 57317"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.72155700),
        dec: Angle.Degrees(+39.14193954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57245"},
        {"Hipparcos Number", "HIP 35715"},
        {"Geneva Identification System", "GEN# +1.00057245"},
        {"Smithsonian Astrophysical Observation", "SAO 60011"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.53241331),
        dec: Angle.Degrees(+39.14431708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112906"},
    },
    visualMagnitude: 9.49,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.95910740),
        dec: Angle.Degrees(+39.14491034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15019",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2409 A"},
        {"Henry Draper", "HD 19923"},
        {"Hipparcos Number", "HIP 15019"},
        {"Smithsonian Astrophysical Observation", "SAO 56265"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.39715413),
        dec: Angle.Degrees(+39.14493355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1981"},
        {"Smithsonian Astrophysical Observation", "SAO 53874"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.27022870),
        dec: Angle.Degrees(+39.14585596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94481",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Aladfar"},
        {"Aitken", "ADS 12197 A"},
        {"Henry Draper", "HD 180163"},
        {"Hipparcos Number", "HIP 94481"},
        {"Celescope Catalog", "CEL 4724"},
        {"Geneva Identification System", "GEN# +1.00180163A"},
        {"Smithsonian Astrophysical Observation", "SAO 68010"},
        {"Wilson Evans Batten Catalogue", "WEB 16467"},
    },
    visualMagnitude: 4.43,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.43953645),
        dec: Angle.Degrees(+39.14596968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15017",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2409 B"},
        {"Henry Draper", "HD 19923B"},
        {"Hipparcos Number", "HIP 15017"},
        {"Smithsonian Astrophysical Observation", "SAO 56264"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.39398585),
        dec: Angle.Degrees(+39.14706910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21651"},
        {"Hipparcos Number", "HIP 16398"},
        {"Fundamental Katalog 5th Edition", "FK5 4318"},
        {"Geneva Identification System", "GEN# +1.00021651"},
        {"Smithsonian Astrophysical Observation", "SAO 56505"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.78794751),
        dec: Angle.Degrees(+39.14780409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27673",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4440 A"},
        {"Henry Draper", "HD 39003"},
        {"Hipparcos Number", "HIP 27673"},
        {"Fundamental Katalog 5th Edition", "FK5 221"},
        {"Geneva Identification System", "GEN# +1.00039003A"},
        {"Smithsonian Astrophysical Observation", "SAO 58502"},
        {"Wilson Evans Batten Catalogue", "WEB 5432"},
    },
    visualMagnitude: 3.97,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.87246934),
        dec: Angle.Degrees(+39.14847936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65633"},
        {"Geneva Identification System", "GEN# +0.03902647"},
        {"Smithsonian Astrophysical Observation", "SAO 63547"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.84760104),
        dec: Angle.Degrees(+39.14950528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16386"},
        {"Hipparcos Number", "HIP 12335"},
        {"Geneva Identification System", "GEN# +1.00016386"},
        {"Smithsonian Astrophysical Observation", "SAO 55746"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.71519797),
        dec: Angle.Degrees(+39.15021014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151427"},
        {"Hipparcos Number", "HIP 82050"},
        {"Smithsonian Astrophysical Observation", "SAO 65536"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.40656742),
        dec: Angle.Degrees(+39.15047810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9032"},
        {"Smithsonian Astrophysical Observation", "SAO 55110"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.08121343),
        dec: Angle.Degrees(+39.15147263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73870"},
        {"Hipparcos Number", "HIP 42686"},
        {"Smithsonian Astrophysical Observation", "SAO 60989"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.50106612),
        dec: Angle.Degrees(+39.15207749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276662"},
        {"Hipparcos Number", "HIP 21638"},
        {"Smithsonian Astrophysical Observation", "SAO 57356"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.71667888),
        dec: Angle.Degrees(+39.15251324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156496"},
        {"Hipparcos Number", "HIP 84474"},
        {"Smithsonian Astrophysical Observation", "SAO 65903"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.04254567),
        dec: Angle.Degrees(+39.15335663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82623"},
        {"Hipparcos Number", "HIP 46955"},
        {"Smithsonian Astrophysical Observation", "SAO 61569"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.56797600),
        dec: Angle.Degrees(+39.15367435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178770"},
        {"Hipparcos Number", "HIP 93989"},
        {"Smithsonian Astrophysical Observation", "SAO 67859"},
        {"Wilson Evans Batten Catalogue", "WEB 16357"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.05493986),
        dec: Angle.Degrees(+39.15487316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93483",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93483"},
        {"Smithsonian Astrophysical Observation", "SAO 67726"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.58061951),
        dec: Angle.Degrees(+39.15492171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145069"},
        {"Hipparcos Number", "HIP 78986"},
        {"Geneva Identification System", "GEN# +1.00145069"},
        {"Smithsonian Astrophysical Observation", "SAO 65094"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.84336340),
        dec: Angle.Degrees(+39.15575573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144579"},
        {"Hipparcos Number", "HIP 78775"},
        {"Cincinnati Publication", "Ci 20 965"},
        {"Geneva Identification System", "GEN# +1.00144579"},
        {"Smithsonian Astrophysical Observation", "SAO 65065"},
        {"Wilson Evans Batten Catalogue", "WEB 13319"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.23842890),
        dec: Angle.Degrees(+39.15638126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -571.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170259"},
        {"Hipparcos Number", "HIP 90401"},
        {"Smithsonian Astrophysical Observation", "SAO 66983"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.67777016),
        dec: Angle.Degrees(+39.15685133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5084"},
        {"Hipparcos Number", "HIP 4152"},
        {"Geneva Identification System", "GEN# +1.00005084"},
        {"Smithsonian Astrophysical Observation", "SAO 54230"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.26765134),
        dec: Angle.Degrees(+39.15841402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192536"},
        {"Hipparcos Number", "HIP 99704"},
        {"Fundamental Katalog 5th Edition", "FK5 5780"},
        {"Geneva Identification System", "GEN# +1.00192536"},
        {"Renson", "Renson 53660"},
        {"Smithsonian Astrophysical Observation", "SAO 69649"},
        {"Wilson Evans Batten Catalogue", "WEB 17887"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.48100449),
        dec: Angle.Degrees(+39.15896836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203920"},
        {"Hipparcos Number", "HIP 105654"},
        {"Smithsonian Astrophysical Observation", "SAO 71283"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.00914772),
        dec: Angle.Degrees(+39.15935098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115450"},
        {"Smithsonian Astrophysical Observation", "SAO 73214"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.79042907),
        dec: Angle.Degrees(+39.16033061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275812"},
        {"Hipparcos Number", "HIP 17719"},
        {"Geneva Identification System", "GEN# +0.03800807"},
    },
    visualMagnitude: 10.23,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.92005845),
        dec: Angle.Degrees(+39.16038643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 247.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4269",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 745 B"},
        {"Hipparcos Number", "HIP 4269"},
        {"Smithsonian Astrophysical Observation", "SAO 54255"},
    },
    visualMagnitude: 9.34,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.65716797),
        dec: Angle.Degrees(+39.16288444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22137"},
        {"Hipparcos Number", "HIP 16750"},
        {"Smithsonian Astrophysical Observation", "SAO 56563"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.87339754),
        dec: Angle.Degrees(+39.16378472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83584",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83584"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.24944391),
        dec: Angle.Degrees(+39.16450016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218586"},
        {"Hipparcos Number", "HIP 114278"},
        {"Geneva Identification System", "GEN# +1.00218586"},
        {"Smithsonian Astrophysical Observation", "SAO 73035"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.19205681),
        dec: Angle.Degrees(+39.16778771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2750",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 481 A"},
        {"Hipparcos Number", "HIP 2750"},
        {"Geneva Identification System", "GEN# +0.03800072"},
        {"Smithsonian Astrophysical Observation", "SAO 53997"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.77147489),
        dec: Angle.Degrees(+39.16796641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5374"},
        {"Hipparcos Number", "HIP 4367"},
        {"Geneva Identification System", "GEN# +1.00005374"},
        {"Smithsonian Astrophysical Observation", "SAO 54271"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.99430294),
        dec: Angle.Degrees(+39.16913840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13787"},
        {"Hipparcos Number", "HIP 10495"},
        {"Geneva Identification System", "GEN# +1.00013787"},
        {"Smithsonian Astrophysical Observation", "SAO 55391"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.83084036),
        dec: Angle.Degrees(+39.16934321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4268",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 745 A"},
        {"Henry Draper", "HD 5245"},
        {"Hipparcos Number", "HIP 4268"},
        {"Smithsonian Astrophysical Observation", "SAO 54254"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.65631982),
        dec: Angle.Degrees(+39.16939308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16326"},
        {"Hipparcos Number", "HIP 12298"},
        {"Wilson Evans Batten Catalogue", "WEB 2521"},
    },
    visualMagnitude: 10.01,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.59910441),
        dec: Angle.Degrees(+39.16942831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50185"},
        {"Hipparcos Number", "HIP 33120"},
        {"Smithsonian Astrophysical Observation", "SAO 59588"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.47122922),
        dec: Angle.Degrees(+39.16970313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179421"},
        {"Hipparcos Number", "HIP 94221"},
        {"Geneva Identification System", "GEN# +1.00179421"},
        {"Smithsonian Astrophysical Observation", "SAO 67927"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.71083601),
        dec: Angle.Degrees(+39.17160188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101178"},
        {"Hipparcos Number", "HIP 56818"},
        {"Geneva Identification System", "GEN# +1.00101178"},
        {"Smithsonian Astrophysical Observation", "SAO 62640"},
        {"Wilson Evans Batten Catalogue", "WEB 10229"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.70801976),
        dec: Angle.Degrees(+39.17256292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15993"},
        {"Hipparcos Number", "HIP 12046"},
        {"Smithsonian Astrophysical Observation", "SAO 55678"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.82212972),
        dec: Angle.Degrees(+39.17271560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78448",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9887 A"},
        {"Henry Draper", "HD 143806"},
        {"Hipparcos Number", "HIP 78448"},
        {"Geneva Identification System", "GEN# +1.00143806"},
        {"Renson", "Renson 40730"},
        {"Smithsonian Astrophysical Observation", "SAO 65025"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.22889566),
        dec: Angle.Degrees(+39.17748897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66514",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8981 AB"},
        {"Henry Draper", "HD 118742"},
        {"Hipparcos Number", "HIP 66514"},
        {"Cincinnati Publication", "Ci 18 1770"},
        {"Geneva Identification System", "GEN# +1.00118742"},
        {"Smithsonian Astrophysical Observation", "SAO 63656"},
        {"Wilson Evans Batten Catalogue", "WEB 11740"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.50884521),
        dec: Angle.Degrees(+39.17844144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -225.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41888"},
        {"Hipparcos Number", "HIP 29211"},
        {"Geneva Identification System", "GEN# +1.00041888"},
        {"Smithsonian Astrophysical Observation", "SAO 58802"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.40268139),
        dec: Angle.Degrees(+39.17983877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27483",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4398 A"},
        {"Henry Draper", "HD 38656"},
        {"Hipparcos Number", "HIP 27483"},
        {"Geneva Identification System", "GEN# +1.00038656"},
        {"Smithsonian Astrophysical Observation", "SAO 58465"},
        {"Wilson Evans Batten Catalogue", "WEB 5398"},
    },
    visualMagnitude: 4.51,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.29358126),
        dec: Angle.Degrees(+39.18113322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222519"},
        {"Hipparcos Number", "HIP 116857"},
        {"Smithsonian Astrophysical Observation", "SAO 73435"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.30241725),
        dec: Angle.Degrees(+39.18244607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224957"},
        {"Hipparcos Number", "HIP 167"},
        {"Geneva Identification System", "GEN# +1.00224957"},
        {"Smithsonian Astrophysical Observation", "SAO 73702"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.52780714),
        dec: Angle.Degrees(+39.18321360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181879"},
        {"Hipparcos Number", "HIP 95069"},
        {"Smithsonian Astrophysical Observation", "SAO 68170"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.14320949),
        dec: Angle.Degrees(+39.18467237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157947"},
        {"Hipparcos Number", "HIP 85194"},
        {"Geneva Identification System", "GEN# +1.00157947"},
        {"Smithsonian Astrophysical Observation", "SAO 66020"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.15263511),
        dec: Angle.Degrees(+39.18562462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101007"},
        {"Smithsonian Astrophysical Observation", "SAO 70086"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.17419297),
        dec: Angle.Degrees(+39.18817133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73088"},
        {"Smithsonian Astrophysical Observation", "SAO 64415"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.05581859),
        dec: Angle.Degrees(+39.19002758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18541"},
        {"Hipparcos Number", "HIP 13983"},
        {"Geneva Identification System", "GEN# +1.00018541A"},
        {"Smithsonian Astrophysical Observation", "SAO 56066"},
        {"Wilson Evans Batten Catalogue", "WEB 2759"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.02380148),
        dec: Angle.Degrees(+39.19030349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28113"},
        {"Smithsonian Astrophysical Observation", "SAO 58587"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.13692174),
        dec: Angle.Degrees(+39.19090699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56630"},
        {"Cincinnati Publication", "Ci 20 651"},
        {"Geneva Identification System", "GEN# +0.04002442"},
        {"Wilson Evans Batten Catalogue", "WEB 10179"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.16899098),
        dec: Angle.Degrees(+39.19161005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 440.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -405.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27793"},
        {"Smithsonian Astrophysical Observation", "SAO 58529"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.22333393),
        dec: Angle.Degrees(+39.19425143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196489"},
        {"Hipparcos Number", "HIP 101660"},
        {"Geneva Identification System", "GEN# +1.00196489"},
        {"Smithsonian Astrophysical Observation", "SAO 70259"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.10108001),
        dec: Angle.Degrees(+39.19464822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22466"},
        {"Hipparcos Number", "HIP 16969"},
        {"Geneva Identification System", "GEN# +1.00022466"},
        {"Smithsonian Astrophysical Observation", "SAO 56598"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.56927793),
        dec: Angle.Degrees(+39.19563054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79850"},
        {"Hipparcos Number", "HIP 45602"},
        {"Geneva Identification System", "GEN# +1.00079850"},
        {"Smithsonian Astrophysical Observation", "SAO 61383"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.42246280),
        dec: Angle.Degrees(+39.19746745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45126"},
        {"Smithsonian Astrophysical Observation", "SAO 61319"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.92018161),
        dec: Angle.Degrees(+39.19906800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215473"},
        {"Hipparcos Number", "HIP 112305"},
        {"Geneva Identification System", "GEN# +1.00215473"},
        {"Smithsonian Astrophysical Observation", "SAO 72682"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.22069959),
        dec: Angle.Degrees(+39.20107570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209330"},
        {"Hipparcos Number", "HIP 108750"},
        {"Geneva Identification System", "GEN# +1.00209330"},
        {"Smithsonian Astrophysical Observation", "SAO 71959"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.44450680),
        dec: Angle.Degrees(+39.20424240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201818"},
        {"Hipparcos Number", "HIP 104561"},
        {"Smithsonian Astrophysical Observation", "SAO 71026"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.70923467),
        dec: Angle.Degrees(+39.20614251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189845"},
        {"Hipparcos Number", "HIP 98490"},
        {"Celescope Catalog", "CEL 4907"},
        {"Geneva Identification System", "GEN# +1.00189845"},
        {"Smithsonian Astrophysical Observation", "SAO 69249"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.13741163),
        dec: Angle.Degrees(+39.20737798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73725"},
        {"Smithsonian Astrophysical Observation", "SAO 64490"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.06583523),
        dec: Angle.Degrees(+39.20836331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157946"},
        {"Hipparcos Number", "HIP 85201"},
        {"Smithsonian Astrophysical Observation", "SAO 66021"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.16179406),
        dec: Angle.Degrees(+39.20950450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41598"},
        {"Hipparcos Number", "HIP 29079"},
        {"Geneva Identification System", "GEN# +1.00041598"},
        {"Smithsonian Astrophysical Observation", "SAO 58770"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.01685006),
        dec: Angle.Degrees(+39.20965280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141305"},
        {"Hipparcos Number", "HIP 77299"},
        {"Smithsonian Astrophysical Observation", "SAO 64901"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.72002115),
        dec: Angle.Degrees(+39.20979321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202880"},
        {"Hipparcos Number", "HIP 105116"},
        {"Geneva Identification System", "GEN# +1.00202880"},
        {"Smithsonian Astrophysical Observation", "SAO 71169"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.40145610),
        dec: Angle.Degrees(+39.21006104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100518",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13783 A"},
        {"Henry Draper", "HD 194206"},
        {"Hipparcos Number", "HIP 100518"},
        {"Celescope Catalog", "CEL 5043"},
        {"Geneva Identification System", "GEN# +1.00194206"},
        {"Smithsonian Astrophysical Observation", "SAO 69929"},
        {"Wilson Evans Batten Catalogue", "WEB 18158"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.74021639),
        dec: Angle.Degrees(+39.21103629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61499"},
        {"Hipparcos Number", "HIP 37443"},
        {"Geneva Identification System", "GEN# +1.00061499"},
        {"Smithsonian Astrophysical Observation", "SAO 60267"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.30528732),
        dec: Angle.Degrees(+39.21173712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182671"},
        {"Hipparcos Number", "HIP 95377"},
        {"Geneva Identification System", "GEN# +1.00182671"},
        {"Smithsonian Astrophysical Observation", "SAO 68262"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.04148127),
        dec: Angle.Degrees(+39.21175402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95310"},
        {"Hipparcos Number", "HIP 53838"},
        {"Geneva Identification System", "GEN# +1.00095310"},
        {"Renson", "Renson 27470"},
        {"Smithsonian Astrophysical Observation", "SAO 62354"},
        {"Wilson Evans Batten Catalogue", "WEB 9752"},
    },
    visualMagnitude: 5.06,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.21033423),
        dec: Angle.Degrees(+39.21213189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68769",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68769"},
        {"Smithsonian Astrophysical Observation", "SAO 63922"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.13075704),
        dec: Angle.Degrees(+39.21322307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199316"},
        {"Hipparcos Number", "HIP 103255"},
        {"Smithsonian Astrophysical Observation", "SAO 70666"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.77271150),
        dec: Angle.Degrees(+39.21636503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139747"},
        {"Hipparcos Number", "HIP 76588"},
        {"Geneva Identification System", "GEN# +1.00139747"},
        {"Smithsonian Astrophysical Observation", "SAO 64823"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.62444346),
        dec: Angle.Degrees(+39.21664278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176582"},
        {"Hipparcos Number", "HIP 93210"},
        {"Celescope Catalog", "CEL 4682"},
        {"Geneva Identification System", "GEN# +1.00176582"},
        {"Renson", "Renson 49280"},
        {"Smithsonian Astrophysical Observation", "SAO 67675"},
        {"Wilson Evans Batten Catalogue", "WEB 16160"},
    },
    visualMagnitude: 6.43,
    bvColour: -0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.80121716),
        dec: Angle.Degrees(+39.21732410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52531",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52531"},
        {"Geneva Identification System", "GEN# +6.20028047"},
    },
    visualMagnitude: 11.28,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.10601739),
        dec: Angle.Degrees(+39.21841115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92006",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11655 C"},
        {"Hipparcos Number", "HIP 92006"},
    },
    visualMagnitude: 10.31,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.29261894),
        dec: Angle.Degrees(+39.21923927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91286"},
        {"Hipparcos Number", "HIP 51651"},
        {"Geneva Identification System", "GEN# +1.00091286"},
        {"Smithsonian Astrophysical Observation", "SAO 62117"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.28706050),
        dec: Angle.Degrees(+39.22160655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61364"},
    },
    visualMagnitude: 11.04,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.62065798),
        dec: Angle.Degrees(+39.22259632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -223.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13883"},
        {"Hipparcos Number", "HIP 10580"},
        {"Smithsonian Astrophysical Observation", "SAO 55400"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.04276437),
        dec: Angle.Degrees(+39.22453285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92005",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11655 AB"},
        {"Hipparcos Number", "HIP 92005"},
        {"Smithsonian Astrophysical Observation", "SAO 67331"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.29164371),
        dec: Angle.Degrees(+39.22578070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26200"},
        {"Hipparcos Number", "HIP 19480"},
        {"Fundamental Katalog 5th Edition", "FK5 4378"},
        {"Geneva Identification System", "GEN# +1.00026200"},
        {"Smithsonian Astrophysical Observation", "SAO 57033"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.58861145),
        dec: Angle.Degrees(+39.22578710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52791",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52791"},
        {"Smithsonian Astrophysical Observation", "SAO 62253"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.90079758),
        dec: Angle.Degrees(+39.22692923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30099"},
        {"Hipparcos Number", "HIP 22180"},
        {"Smithsonian Astrophysical Observation", "SAO 57420"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.58463687),
        dec: Angle.Degrees(+39.22787582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211005"},
        {"Hipparcos Number", "HIP 109714"},
        {"Geneva Identification System", "GEN# +1.00211005"},
        {"Smithsonian Astrophysical Observation", "SAO 72145"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.34948472),
        dec: Angle.Degrees(+39.22803466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53171",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53171"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.15959584),
        dec: Angle.Degrees(+39.23024791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96279",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96279"},
        {"Geneva Identification System", "GEN# +0.03803659"},
        {"Smithsonian Astrophysical Observation", "SAO 68523"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.65456136),
        dec: Angle.Degrees(+39.23232427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108601"},
        {"Fundamental Katalog 5th Edition", "FK5 5943"},
        {"Smithsonian Astrophysical Observation", "SAO 71924"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.00554268),
        dec: Angle.Degrees(+39.23287612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47572"},
        {"Hipparcos Number", "HIP 31995"},
        {"Geneva Identification System", "GEN# +1.00047572"},
        {"Smithsonian Astrophysical Observation", "SAO 59356"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.28923333),
        dec: Angle.Degrees(+39.23447205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116076",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Veritate"},
        {"Henry Draper", "HD 221345"},
        {"Hipparcos Number", "HIP 116076"},
        {"Geneva Identification System", "GEN# +1.00221345"},
        {"Smithsonian Astrophysical Observation", "SAO 73311"},
        {"Wilson Evans Batten Catalogue", "WEB 20520"},
    },
    visualMagnitude: 5.22,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.82165645),
        dec: Angle.Degrees(+39.23640180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 287.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68461"},
        {"Smithsonian Astrophysical Observation", "SAO 63886"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.23282562),
        dec: Angle.Degrees(+39.23922300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87676",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87676"},
        {"Smithsonian Astrophysical Observation", "SAO 66454"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.61869823),
        dec: Angle.Degrees(+39.23941850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70754"},
        {"Hipparcos Number", "HIP 41272"},
        {"Smithsonian Astrophysical Observation", "SAO 60795"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.30697656),
        dec: Angle.Degrees(+39.24072533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143392"},
        {"Hipparcos Number", "HIP 78248"},
        {"Geneva Identification System", "GEN# +1.00143392"},
        {"Smithsonian Astrophysical Observation", "SAO 64998"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.64861970),
        dec: Angle.Degrees(+39.24083991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69046",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69046"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.99762091),
        dec: Angle.Degrees(+39.24245720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152109"},
        {"Hipparcos Number", "HIP 82356"},
        {"Smithsonian Astrophysical Observation", "SAO 65584"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.42546264),
        dec: Angle.Degrees(+39.24273093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202404"},
        {"Hipparcos Number", "HIP 104852"},
        {"Geneva Identification System", "GEN# +1.00202404"},
        {"Smithsonian Astrophysical Observation", "SAO 71113"},
        {"Wilson Evans Batten Catalogue", "WEB 19066"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.59803242),
        dec: Angle.Degrees(+39.24318067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213520"},
        {"Hipparcos Number", "HIP 111167"},
        {"Geneva Identification System", "GEN# +1.00213520"},
        {"Smithsonian Astrophysical Observation", "SAO 72427"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.81973522),
        dec: Angle.Degrees(+39.24395201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104593"},
        {"Smithsonian Astrophysical Observation", "SAO 71039"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.81452308),
        dec: Angle.Degrees(+39.24404007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181097"},
        {"Hipparcos Number", "HIP 94808"},
        {"Smithsonian Astrophysical Observation", "SAO 68092"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.37218153),
        dec: Angle.Degrees(+39.24458972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39223"},
        {"Hipparcos Number", "HIP 27801"},
        {"Smithsonian Astrophysical Observation", "SAO 58530"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.24742055),
        dec: Angle.Degrees(+39.24472111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107332"},
        {"Smithsonian Astrophysical Observation", "SAO 71658"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.09082566),
        dec: Angle.Degrees(+39.24542471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108695",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15549"},
        {"Henry Draper", "HD 209260"},
        {"Hipparcos Number", "HIP 108695"},
        {"Geneva Identification System", "GEN# +1.00209260"},
        {"Renson", "Renson 58205"},
        {"Smithsonian Astrophysical Observation", "SAO 71949"},
        {"Wilson Evans Batten Catalogue", "WEB 19560"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.27787772),
        dec: Angle.Degrees(+39.24595474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47581",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7485 AB"},
        {"Henry Draper", "HD 83819"},
        {"Hipparcos Number", "HIP 47581"},
        {"Smithsonian Astrophysical Observation", "SAO 61638"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.52828649),
        dec: Angle.Degrees(+39.24727375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108846"},
        {"Hipparcos Number", "HIP 61010"},
        {"Geneva Identification System", "GEN# +1.00108846"},
        {"Smithsonian Astrophysical Observation", "SAO 63027"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.55253346),
        dec: Angle.Degrees(+39.24736365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58218"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.10325130),
        dec: Angle.Degrees(+39.24776686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66954"},
        {"Geneva Identification System", "GEN# +0.03902675"},
        {"Smithsonian Astrophysical Observation", "SAO 63707"},
        {"Wilson Evans Batten Catalogue", "WEB 11802"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.84587262),
        dec: Angle.Degrees(+39.24933115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219170"},
        {"Hipparcos Number", "HIP 114657"},
        {"Geneva Identification System", "GEN# +1.00219170"},
        {"Smithsonian Astrophysical Observation", "SAO 73095"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.40041373),
        dec: Angle.Degrees(+39.25189637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6664"},
        {"Hipparcos Number", "HIP 5313"},
        {"Geneva Identification System", "GEN# +1.00006664"},
        {"Smithsonian Astrophysical Observation", "SAO 54443"},
        {"Wilson Evans Batten Catalogue", "WEB 1141"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.99501278),
        dec: Angle.Degrees(+39.25253121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31380"},
        {"Hipparcos Number", "HIP 23030"},
        {"Smithsonian Astrophysical Observation", "SAO 57521"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.28322257),
        dec: Angle.Degrees(+39.25466904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75895"},
        {"Hipparcos Number", "HIP 43714"},
        {"Geneva Identification System", "GEN# +1.00075895"},
        {"Smithsonian Astrophysical Observation", "SAO 61121"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.53882794),
        dec: Angle.Degrees(+39.25472261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117841",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17087 D"},
        {"Hipparcos Number", "HIP 117841"},
        {"Smithsonian Astrophysical Observation", "SAO 73594"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.49282944),
        dec: Angle.Degrees(+39.25544351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84102",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10391 CD"},
        {"Hipparcos Number", "HIP 84102"},
    },
    visualMagnitude: 8.80,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.90032954),
        dec: Angle.Degrees(+39.25712693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169413"},
        {"Hipparcos Number", "HIP 90056"},
        {"Geneva Identification System", "GEN# +1.00169413"},
        {"Smithsonian Astrophysical Observation", "SAO 66920"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.66731772),
        dec: Angle.Degrees(+39.25833377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84100",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10391 AB"},
        {"Henry Draper", "HD 155727"},
        {"Hipparcos Number", "HIP 84100"},
        {"Geneva Identification System", "GEN# +1.00155727J"},
        {"Smithsonian Astrophysical Observation", "SAO 65857"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.89522092),
        dec: Angle.Degrees(+39.25870898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46586"},
    },
    visualMagnitude: 11.45,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.51612856),
        dec: Angle.Degrees(+39.26063353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -232.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103782",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14558 AB"},
        {"Henry Draper", "HD 200370"},
        {"Hipparcos Number", "HIP 103782"},
        {"Smithsonian Astrophysical Observation", "SAO 70808"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.45865168),
        dec: Angle.Degrees(+39.26065857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86945"},
        {"Hipparcos Number", "HIP 49226"},
        {"Geneva Identification System", "GEN# +1.00086945"},
        {"Smithsonian Astrophysical Observation", "SAO 61823"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.72359999),
        dec: Angle.Degrees(+39.26181374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64729",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64729"},
        {"Geneva Identification System", "GEN# +0.04002640"},
        {"Smithsonian Astrophysical Observation", "SAO 63435"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.01150175),
        dec: Angle.Degrees(+39.26211562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132772"},
        {"Hipparcos Number", "HIP 73369"},
        {"Fundamental Katalog 5th Edition", "FK5 3182"},
        {"Geneva Identification System", "GEN# +1.00132772"},
        {"Smithsonian Astrophysical Observation", "SAO 64449"},
        {"Wilson Evans Batten Catalogue", "WEB 12563"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.90404577),
        dec: Angle.Degrees(+39.26523166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168638"},
        {"Hipparcos Number", "HIP 89754"},
        {"Geneva Identification System", "GEN# +1.00168638"},
        {"Smithsonian Astrophysical Observation", "SAO 66852"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.74641185),
        dec: Angle.Degrees(+39.26706494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94924",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12310 AB"},
        {"Henry Draper", "HD 181469"},
        {"Hipparcos Number", "HIP 94924"},
        {"Geneva Identification System", "GEN# +1.00181469"},
        {"Smithsonian Astrophysical Observation", "SAO 68130"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.74259518),
        dec: Angle.Degrees(+39.26717470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90276"},
        {"Hipparcos Number", "HIP 51065"},
        {"Geneva Identification System", "GEN# +1.00090276"},
        {"Smithsonian Astrophysical Observation", "SAO 62039"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.51114617),
        dec: Angle.Degrees(+39.26725537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96283",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96283"},
        {"Smithsonian Astrophysical Observation", "SAO 68524"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.66298256),
        dec: Angle.Degrees(+39.26914806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276220"},
        {"Hipparcos Number", "HIP 20177"},
        {"Smithsonian Astrophysical Observation", "SAO 57150"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.87619172),
        dec: Angle.Degrees(+39.27036051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195918"},
        {"Hipparcos Number", "HIP 101370"},
        {"Celescope Catalog", "CEL 5104"},
        {"Geneva Identification System", "GEN# +1.00195918A"},
        {"Smithsonian Astrophysical Observation", "SAO 70175"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.18128898),
        dec: Angle.Degrees(+39.27104968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215910"},
        {"Hipparcos Number", "HIP 112582"},
        {"Geneva Identification System", "GEN# +1.00215910"},
        {"Smithsonian Astrophysical Observation", "SAO 72730"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.02872709),
        dec: Angle.Degrees(+39.27133373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193514"},
        {"Hipparcos Number", "HIP 100173"},
        {"Geneva Identification System", "GEN# +1.00193514"},
        {"Smithsonian Astrophysical Observation", "SAO 69826"},
        {"Wilson Evans Batten Catalogue", "WEB 18044"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.78541938),
        dec: Angle.Degrees(+39.27341424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276219"},
        {"Hipparcos Number", "HIP 19891"},
        {"Smithsonian Astrophysical Observation", "SAO 57107"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.99684767),
        dec: Angle.Degrees(+39.27481598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35353",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35353"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.53476111),
        dec: Angle.Degrees(+39.27509180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -212.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107763"},
        {"Hipparcos Number", "HIP 60383"},
        {"Geneva Identification System", "GEN# +1.00107763"},
        {"Smithsonian Astrophysical Observation", "SAO 62976"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.71002776),
        dec: Angle.Degrees(+39.27561261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124796"},
        {"Hipparcos Number", "HIP 69580"},
        {"Geneva Identification System", "GEN# +1.00124796"},
        {"Smithsonian Astrophysical Observation", "SAO 64019"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.63899986),
        dec: Angle.Degrees(+39.27641657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82333",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82333"},
        {"Wilson Evans Batten Catalogue", "WEB 13898"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.35260260),
        dec: Angle.Degrees(+39.27691508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -278.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71412"},
        {"Smithsonian Astrophysical Observation", "SAO 64234"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.05725853),
        dec: Angle.Degrees(+39.27713819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110897"},
        {"Hipparcos Number", "HIP 62207"},
        {"Geneva Identification System", "GEN# +1.00110897"},
        {"Smithsonian Astrophysical Observation", "SAO 63177"},
        {"Wilson Evans Batten Catalogue", "WEB 11051"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.24865101),
        dec: Angle.Degrees(+39.27857766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -359.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32460"},
        {"Hipparcos Number", "HIP 23664"},
        {"Geneva Identification System", "GEN# +1.00032460"},
        {"Smithsonian Astrophysical Observation", "SAO 57618"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.27994708),
        dec: Angle.Degrees(+39.27887198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24137",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3739 A"},
        {"Henry Draper", "HD 33298"},
        {"Hipparcos Number", "HIP 24137"},
        {"Geneva Identification System", "GEN# +1.00033298"},
        {"Smithsonian Astrophysical Observation", "SAO 57717"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.75957180),
        dec: Angle.Degrees(+39.28200965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117844",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17087 A"},
        {"Henry Draper", "HD 223971"},
        {"Hipparcos Number", "HIP 117844"},
        {"Geneva Identification System", "GEN# +1.00223971"},
        {"Renson", "Renson 61370"},
        {"Smithsonian Astrophysical Observation", "SAO 73597"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.51665361),
        dec: Angle.Degrees(+39.28246347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24141",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3739 B"},
        {"Hipparcos Number", "HIP 24141"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.76507163),
        dec: Angle.Degrees(+39.28312368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20346"},
        {"Hipparcos Number", "HIP 15334"},
        {"Fundamental Katalog 5th Edition", "FK5 2230"},
        {"Geneva Identification System", "GEN# +1.00020346"},
        {"Renson", "Renson 5080"},
        {"Smithsonian Astrophysical Observation", "SAO 56322"},
        {"Wilson Evans Batten Catalogue", "WEB 2951"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.44057220),
        dec: Angle.Degrees(+39.28341373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30793"},
        {"Hipparcos Number", "HIP 22661"},
        {"Geneva Identification System", "GEN# +1.00030793"},
        {"Smithsonian Astrophysical Observation", "SAO 57470"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.11585240),
        dec: Angle.Degrees(+39.28423360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64488"},
        {"Hipparcos Number", "HIP 38744"},
        {"Geneva Identification System", "GEN# +1.00064488"},
        {"Smithsonian Astrophysical Observation", "SAO 60456"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.97796224),
        dec: Angle.Degrees(+39.28677111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47957"},
        {"Hipparcos Number", "HIP 32158"},
        {"Smithsonian Astrophysical Observation", "SAO 59396"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.73029667),
        dec: Angle.Degrees(+39.28705983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102648",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14314 ABC"},
        {"Henry Draper", "HD 198288"},
        {"Henry Draper 2", "HD 198287"},
        {"Hipparcos Number", "HIP 102648"},
        {"Geneva Identification System", "GEN# +1.00198287"},
        {"Geneva Identification System 2", "GEN# +1.00198288"},
        {"Smithsonian Astrophysical Observation", "SAO 70517"},
        {"Wilson Evans Batten Catalogue", "WEB 18605"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.99828147),
        dec: Angle.Degrees(+39.28771090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 810"},
        {"Hipparcos Number", "HIP 1014"},
        {"Smithsonian Astrophysical Observation", "SAO 53722"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.16236754),
        dec: Angle.Degrees(+39.28794887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87168"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.14645069),
        dec: Angle.Degrees(+39.28826286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -254.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11895"},
        {"Hipparcos Number", "HIP 9129"},
        {"Smithsonian Astrophysical Observation", "SAO 55136"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.42342149),
        dec: Angle.Degrees(+39.28846870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186701"},
        {"Hipparcos Number", "HIP 97124"},
        {"Geneva Identification System", "GEN# +1.00186701"},
        {"Smithsonian Astrophysical Observation", "SAO 68780"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.09476010),
        dec: Angle.Degrees(+39.28880063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219952"},
        {"Hipparcos Number", "HIP 115179"},
        {"Geneva Identification System", "GEN# +1.00219952"},
        {"Smithsonian Astrophysical Observation", "SAO 73174"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.93510353),
        dec: Angle.Degrees(+39.28896927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14960"},
        {"Hipparcos Number", "HIP 11327"},
        {"Smithsonian Astrophysical Observation", "SAO 55543"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.44445243),
        dec: Angle.Degrees(+39.28987825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22979",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3537 AB"},
        {"Henry Draper", "HD 31342"},
        {"Hipparcos Number", "HIP 22979"},
        {"Smithsonian Astrophysical Observation", "SAO 57514"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.17845484),
        dec: Angle.Degrees(+39.28987918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61299"},
        {"Geneva Identification System", "GEN# +0.04002548"},
        {"Smithsonian Astrophysical Observation", "SAO 63068"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.39809600),
        dec: Angle.Degrees(+39.29001487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198456"},
        {"Hipparcos Number", "HIP 102750"},
        {"Geneva Identification System", "GEN# +1.00198456J"},
        {"Smithsonian Astrophysical Observation", "SAO 70546"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.28986907),
        dec: Angle.Degrees(+39.29005483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157135"},
        {"Hipparcos Number", "HIP 84775"},
        {"Smithsonian Astrophysical Observation", "SAO 65949"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.92861806),
        dec: Angle.Degrees(+39.29014366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117875"},
        {"Hipparcos Number", "HIP 66053"},
        {"Geneva Identification System", "GEN# +1.00117875"},
        {"Smithsonian Astrophysical Observation", "SAO 63595"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.12992035),
        dec: Angle.Degrees(+39.29123006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16720"},
        {"Hipparcos Number", "HIP 12601"},
        {"Smithsonian Astrophysical Observation", "SAO 55791"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.50445765),
        dec: Angle.Degrees(+39.29206690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95913",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95913"},
        {"Smithsonian Astrophysical Observation", "SAO 68407"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.58404633),
        dec: Angle.Degrees(+39.29472122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93133"},
        {"Smithsonian Astrophysical Observation", "SAO 67654"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.58745685),
        dec: Angle.Degrees(+39.29569139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34956"},
        {"Hipparcos Number", "HIP 25168"},
        {"Smithsonian Astrophysical Observation", "SAO 57956"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.76575581),
        dec: Angle.Degrees(+39.29720975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27234"},
        {"Hipparcos Number", "HIP 20207"},
        {"Smithsonian Astrophysical Observation", "SAO 57158"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.95227191),
        dec: Angle.Degrees(+39.29793781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37620"},
        {"Smithsonian Astrophysical Observation", "SAO 60294"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.79235536),
        dec: Angle.Degrees(+39.29852936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173383"},
        {"Hipparcos Number", "HIP 91820"},
        {"Geneva Identification System", "GEN# +1.00173383"},
        {"Smithsonian Astrophysical Observation", "SAO 67287"},
        {"Wilson Evans Batten Catalogue", "WEB 15800"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.81904610),
        dec: Angle.Degrees(+39.30008217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90866",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90866"},
        {"Smithsonian Astrophysical Observation", "SAO 67084"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.04786751),
        dec: Angle.Degrees(+39.30450198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96108",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 12.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)32, 25.7800),
        dec: Angle.DegreesMinutesSeconds((int)+39, (int)18, 19.700)
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
    primaryId: "HIP 16636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21974"},
        {"Hipparcos Number", "HIP 16636"},
        {"Geneva Identification System", "GEN# +1.00021974"},
        {"Smithsonian Astrophysical Observation", "SAO 56544"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.50942270),
        dec: Angle.Degrees(+39.30626977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56002",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8175 D"},
        {"Henry Draper", "HD 99720"},
        {"Hipparcos Number", "HIP 56002"},
        {"Smithsonian Astrophysical Observation", "SAO 62571"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.14948826),
        dec: Angle.Degrees(+39.30800015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217101"},
        {"Hipparcos Number", "HIP 113371"},
        {"Fundamental Katalog 5th Edition", "FK5 3835"},
        {"Geneva Identification System", "GEN# +1.00217101"},
        {"Smithsonian Astrophysical Observation", "SAO 72883"},
        {"Wilson Evans Batten Catalogue", "WEB 20168"},
    },
    visualMagnitude: 6.17,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.41974256),
        dec: Angle.Degrees(+39.30878922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109995"},
        {"Hipparcos Number", "HIP 61696"},
        {"Geneva Identification System", "GEN# +1.00109995"},
        {"Smithsonian Astrophysical Observation", "SAO 63116"},
        {"Wilson Evans Batten Catalogue", "WEB 10975"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.69868959),
        dec: Angle.Degrees(+39.30913395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184334"},
        {"Hipparcos Number", "HIP 96106"},
        {"Geneva Identification System", "GEN# +1.00184334"},
        {"Smithsonian Astrophysical Observation", "SAO 68461"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.09950877),
        dec: Angle.Degrees(+39.30922294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22158"},
        {"Hipparcos Number", "HIP 16761"},
        {"Geneva Identification System", "GEN# +1.00022158"},
        {"Smithsonian Astrophysical Observation", "SAO 56568"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.92512015),
        dec: Angle.Degrees(+39.30980752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50502"},
        {"Smithsonian Astrophysical Observation", "SAO 61980"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.69349529),
        dec: Angle.Degrees(+39.31154398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64888",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64888"},
        {"Geneva Identification System", "GEN# +0.04002641"},
        {"Smithsonian Astrophysical Observation", "SAO 63457"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.51829608),
        dec: Angle.Degrees(+39.31267979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187191"},
        {"Hipparcos Number", "HIP 97343"},
        {"Geneva Identification System", "GEN# +1.00187191"},
        {"Smithsonian Astrophysical Observation", "SAO 68850"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.76455539),
        dec: Angle.Degrees(+39.31468385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86985"},
        {"Hipparcos Number", "HIP 49237"},
        {"Geneva Identification System", "GEN# +1.00086985"},
        {"Smithsonian Astrophysical Observation", "SAO 61827"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.76710146),
        dec: Angle.Degrees(+39.31502516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58451"},
        {"Hipparcos Number", "HIP 36207"},
        {"Geneva Identification System", "GEN# +1.00058451"},
        {"Smithsonian Astrophysical Observation", "SAO 60086"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.85000181),
        dec: Angle.Degrees(+39.31523613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72300"},
        {"Wilson Evans Batten Catalogue", "WEB 12435"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.77412875),
        dec: Angle.Degrees(+39.31709905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205952"},
        {"Hipparcos Number", "HIP 106790"},
        {"Celescope Catalog", "CEL 5354"},
        {"Geneva Identification System", "GEN# +1.00205952"},
        {"Smithsonian Astrophysical Observation", "SAO 71538"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.45273083),
        dec: Angle.Degrees(+39.31717473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86986",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86986"},
        {"Geneva Identification System", "GEN# +0.03903226"},
    },
    visualMagnitude: 10.21,
    bvColour: -0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.63290282),
        dec: Angle.Degrees(+39.31919309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54716"},
        {"Hipparcos Number", "HIP 34752"},
        {"Fundamental Katalog 5th Edition", "FK5 274"},
        {"Geneva Identification System", "GEN# +1.00054716"},
        {"Smithsonian Astrophysical Observation", "SAO 59866"},
        {"Wilson Evans Batten Catalogue", "WEB 6946"},
    },
    visualMagnitude: 4.91,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.91371845),
        dec: Angle.Degrees(+39.32054373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174958"},
        {"Hipparcos Number", "HIP 92537"},
        {"Celescope Catalog", "CEL 4658"},
        {"Geneva Identification System", "GEN# +1.00174958"},
        {"Smithsonian Astrophysical Observation", "SAO 67484"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.86179513),
        dec: Angle.Degrees(+39.32056580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212019"},
        {"Hipparcos Number", "HIP 110308"},
        {"Smithsonian Astrophysical Observation", "SAO 72249"},
    },
    visualMagnitude: 9.48,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.14045331),
        dec: Angle.Degrees(+39.32096149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100337"},
        {"Hipparcos Number", "HIP 56352"},
        {"Smithsonian Astrophysical Observation", "SAO 62599"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.26708472),
        dec: Angle.Degrees(+39.32167676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59085"},
        {"Hipparcos Number", "HIP 36460"},
        {"Smithsonian Astrophysical Observation", "SAO 60130"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.53120164),
        dec: Angle.Degrees(+39.32220226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86946",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10782 A"},
        {"Henry Draper", "HD 161832"},
        {"Hipparcos Number", "HIP 86946"},
        {"Geneva Identification System", "GEN# +1.00161832A"},
        {"Smithsonian Astrophysical Observation", "SAO 66317"},
        {"Wilson Evans Batten Catalogue", "WEB 14668"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.49352006),
        dec: Angle.Degrees(+39.32250373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14743"},
        {"Smithsonian Astrophysical Observation", "SAO 56215"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.58584112),
        dec: Angle.Degrees(+39.32293047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113649"},
        {"Hipparcos Number", "HIP 63804"},
        {"Fundamental Katalog 5th Edition", "FK5 5157"},
        {"Geneva Identification System", "GEN# +1.00113649"},
        {"Smithsonian Astrophysical Observation", "SAO 63329"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.16393320),
        dec: Angle.Degrees(+39.32349306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59361"},
        {"Geneva Identification System", "GEN# +0.04002507"},
        {"Smithsonian Astrophysical Observation", "SAO 62878"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.68215436),
        dec: Angle.Degrees(+39.32372973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201035"},
        {"Hipparcos Number", "HIP 104133"},
        {"Geneva Identification System", "GEN# +1.00201035"},
        {"Smithsonian Astrophysical Observation", "SAO 70904"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.46701453),
        dec: Angle.Degrees(+39.32649085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10735",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1762"},
        {"Aitken 2", "ADS 1762 AB"},
        {"Hipparcos Number", "HIP 10735"},
        {"Smithsonian Astrophysical Observation", "SAO 55438"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.54215485),
        dec: Angle.Degrees(+39.32780964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126265"},
        {"Hipparcos Number", "HIP 70344"},
        {"Fundamental Katalog 5th Edition", "FK5 5273"},
        {"Geneva Identification System", "GEN# +1.00126265"},
        {"Smithsonian Astrophysical Observation", "SAO 64118"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.88044759),
        dec: Angle.Degrees(+39.32815191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195194"},
        {"Hipparcos Number", "HIP 100979"},
        {"Geneva Identification System", "GEN# +1.00195194"},
        {"Smithsonian Astrophysical Observation", "SAO 70075"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.10741993),
        dec: Angle.Degrees(+39.32892009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34468",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34468"},
        {"Smithsonian Astrophysical Observation", "SAO 59811"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.16166742),
        dec: Angle.Degrees(+39.33045765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2775"},
        {"Hipparcos Number", "HIP 2485"},
        {"Smithsonian Astrophysical Observation", "SAO 53959"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.88901822),
        dec: Angle.Degrees(+39.33133181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90493"},
        {"Hipparcos Number", "HIP 51206"},
        {"Geneva Identification System", "GEN# +1.00090493"},
        {"Smithsonian Astrophysical Observation", "SAO 62051"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.88972881),
        dec: Angle.Degrees(+39.33240535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111400",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16064 AB"},
        {"Henry Draper", "HD 213918"},
        {"Hipparcos Number", "HIP 111400"},
        {"Celescope Catalog", "CEL 5486"},
        {"Renson", "Renson 59330"},
        {"Smithsonian Astrophysical Observation", "SAO 72473"},
    },
    visualMagnitude: 8.71,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.53033198),
        dec: Angle.Degrees(+39.33554428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185171"},
        {"Hipparcos Number", "HIP 96419"},
        {"Geneva Identification System", "GEN# +1.00185171"},
        {"Smithsonian Astrophysical Observation", "SAO 68567"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.04199434),
        dec: Angle.Degrees(+39.33669504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99787"},
        {"Hipparcos Number", "HIP 56034"},
        {"Geneva Identification System", "GEN# +1.00099787J"},
        {"Smithsonian Astrophysical Observation", "SAO 62572"},
        {"Wilson Evans Batten Catalogue", "WEB 10060"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.26734378),
        dec: Angle.Degrees(+39.33694235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176845"},
        {"Hipparcos Number", "HIP 93318"},
        {"Geneva Identification System", "GEN# +1.00176845"},
        {"Smithsonian Astrophysical Observation", "SAO 67694"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.10628732),
        dec: Angle.Degrees(+39.33759157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189279"},
        {"Hipparcos Number", "HIP 98221"},
        {"Geneva Identification System", "GEN# +1.00189279"},
        {"Smithsonian Astrophysical Observation", "SAO 69160"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.40439258),
        dec: Angle.Degrees(+39.33767996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88578"},
        {"Hipparcos Number", "HIP 50096"},
        {"Smithsonian Astrophysical Observation", "SAO 61939"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.43191920),
        dec: Angle.Degrees(+39.33883830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220750"},
        {"Hipparcos Number", "HIP 115667"},
        {"Geneva Identification System", "GEN# +1.00220750"},
        {"Smithsonian Astrophysical Observation", "SAO 73250"},
        {"Wilson Evans Batten Catalogue", "WEB 20470"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.50410508),
        dec: Angle.Degrees(+39.33954205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174809"},
        {"Hipparcos Number", "HIP 92468"},
        {"Geneva Identification System", "GEN# +1.00174809"},
        {"Smithsonian Astrophysical Observation", "SAO 67463"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.66679960),
        dec: Angle.Degrees(+39.34016962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90444"},
        {"Smithsonian Astrophysical Observation", "SAO 66995"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.81543004),
        dec: Angle.Degrees(+39.34024585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199070"},
        {"Hipparcos Number", "HIP 103098"},
        {"Smithsonian Astrophysical Observation", "SAO 70632"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.33840283),
        dec: Angle.Degrees(+39.34071985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61609"},
        {"Smithsonian Astrophysical Observation", "SAO 63106"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.38553358),
        dec: Angle.Degrees(+39.34122664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106449"},
        {"Hipparcos Number", "HIP 59701"},
        {"Geneva Identification System", "GEN# +1.00106449"},
        {"Smithsonian Astrophysical Observation", "SAO 62911"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.65410014),
        dec: Angle.Degrees(+39.34229163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210182"},
        {"Hipparcos Number", "HIP 109232"},
        {"Smithsonian Astrophysical Observation", "SAO 72051"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.93840889),
        dec: Angle.Degrees(+39.34323953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24890",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3898 A"},
        {"Henry Draper", "HD 34545"},
        {"Hipparcos Number", "HIP 24890"},
        {"Geneva Identification System", "GEN# +2.18570001"},
        {"Smithsonian Astrophysical Observation", "SAO 57903"},
        {"New General Catalogue", "NGC 1857 1"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.02617832),
        dec: Angle.Degrees(+39.34335165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185980"},
        {"Hipparcos Number", "HIP 96762"},
        {"Smithsonian Astrophysical Observation", "SAO 68669"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.03231952),
        dec: Angle.Degrees(+39.34397416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278253"},
        {"Hipparcos Number", "HIP 25705"},
        {"Geneva Identification System", "GEN# +9.00053013"},
        {"Smithsonian Astrophysical Observation", "SAO 58088"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.33593616),
        dec: Angle.Degrees(+39.34413931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43925"},
        {"Hipparcos Number", "HIP 30161"},
        {"Smithsonian Astrophysical Observation", "SAO 58995"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.19829902),
        dec: Angle.Degrees(+39.34417095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105910"},
        {"Smithsonian Astrophysical Observation", "SAO 71354"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.75431264),
        dec: Angle.Degrees(+39.34418934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227507"},
        {"Hipparcos Number", "HIP 98882"},
        {"Smithsonian Astrophysical Observation", "SAO 69372"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.20119867),
        dec: Angle.Degrees(+39.34436539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227238"},
        {"Hipparcos Number", "HIP 98649"},
        {"Smithsonian Astrophysical Observation", "SAO 69295"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.55601584),
        dec: Angle.Degrees(+39.34536992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19206"},
        {"Hipparcos Number", "HIP 14467"},
        {"Geneva Identification System", "GEN# +1.00019206"},
        {"Smithsonian Astrophysical Observation", "SAO 56160"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.67975440),
        dec: Angle.Degrees(+39.34546400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14799"},
        {"Hipparcos Number", "HIP 11195"},
        {"Geneva Identification System", "GEN# +1.00014799"},
        {"Smithsonian Astrophysical Observation", "SAO 55514"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.04510809),
        dec: Angle.Degrees(+39.34610424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81245"},
        {"Hipparcos Number", "HIP 46252"},
        {"Smithsonian Astrophysical Observation", "SAO 61479"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.44254089),
        dec: Angle.Degrees(+39.34738032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53144"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.07250969),
        dec: Angle.Degrees(+39.34744047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202087"},
        {"Hipparcos Number", "HIP 104694"},
        {"Geneva Identification System", "GEN# +1.00202087"},
        {"Smithsonian Astrophysical Observation", "SAO 71064"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.11608812),
        dec: Angle.Degrees(+39.34746714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13071"},
        {"Hipparcos Number", "HIP 10006"},
        {"Geneva Identification System", "GEN# +1.00013071"},
        {"Smithsonian Astrophysical Observation", "SAO 55295"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.22060204),
        dec: Angle.Degrees(+39.34868077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117952"},
        {"Hipparcos Number", "HIP 66107"},
        {"Smithsonian Astrophysical Observation", "SAO 63601"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.26922347),
        dec: Angle.Degrees(+39.34954373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88432",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11023 AB"},
        {"Hipparcos Number", "HIP 88432"},
        {"Smithsonian Astrophysical Observation", "SAO 66591"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.82242959),
        dec: Angle.Degrees(+39.34957740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203783"},
        {"Hipparcos Number", "HIP 105595"},
        {"Geneva Identification System", "GEN# +1.00203783"},
        {"Smithsonian Astrophysical Observation", "SAO 71273"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.82299409),
        dec: Angle.Degrees(+39.34966708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3466"},
        {"Hipparcos Number", "HIP 2978"},
        {"Geneva Identification System", "GEN# +1.00003466"},
        {"Smithsonian Astrophysical Observation", "SAO 54041"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.48107932),
        dec: Angle.Degrees(+39.35008702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34350"},
        {"Hipparcos Number", "HIP 24767"},
        {"Geneva Identification System", "GEN# +1.00034350"},
        {"Smithsonian Astrophysical Observation", "SAO 57862"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.63914990),
        dec: Angle.Degrees(+39.35123248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227594"},
        {"Hipparcos Number", "HIP 98956"},
        {"Smithsonian Astrophysical Observation", "SAO 69386"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.36832348),
        dec: Angle.Degrees(+39.35288340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202989"},
        {"Hipparcos Number", "HIP 105160"},
        {"Geneva Identification System", "GEN# +1.00202989"},
        {"Smithsonian Astrophysical Observation", "SAO 71180"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.54294205),
        dec: Angle.Degrees(+39.35471854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9997"},
        {"Hipparcos Number", "HIP 7631"},
        {"Geneva Identification System", "GEN# +1.00009997"},
        {"Smithsonian Astrophysical Observation", "SAO 54857"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.58266349),
        dec: Angle.Degrees(+39.35490556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41830"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.91800790),
        dec: Angle.Degrees(+39.35876336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 217.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38919"},
        {"Smithsonian Astrophysical Observation", "SAO 60476"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.46594572),
        dec: Angle.Degrees(+39.35879613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79448",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9970 AB"},
        {"Henry Draper", "HD 146100"},
        {"Hipparcos Number", "HIP 79448"},
        {"Cincinnati Publication", "Ci 18 2174"},
        {"Geneva Identification System", "GEN# +1.00146100"},
        {"Smithsonian Astrophysical Observation", "SAO 65149"},
        {"Wilson Evans Batten Catalogue", "WEB 13436"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.20129694),
        dec: Angle.Degrees(+39.35922968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -264.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 278.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113297",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113297"},
        {"Smithsonian Astrophysical Observation", "SAO 72864"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.15674823),
        dec: Angle.Degrees(+39.35930752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117942"},
        {"Smithsonian Astrophysical Observation", "SAO 73613"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.85042957),
        dec: Angle.Degrees(+39.35978048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58273"},
        {"Smithsonian Astrophysical Observation", "SAO 62769"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.26626724),
        dec: Angle.Degrees(+39.36057495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161748"},
        {"Hipparcos Number", "HIP 86904"},
        {"Smithsonian Astrophysical Observation", "SAO 66310"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.35725298),
        dec: Angle.Degrees(+39.36214603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33772"},
        {"Hipparcos Number", "HIP 24422"},
        {"Geneva Identification System", "GEN# +1.00033772"},
        {"Smithsonian Astrophysical Observation", "SAO 57776"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.60048069),
        dec: Angle.Degrees(+39.36375417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35102"},
        {"Hipparcos Number", "HIP 25262"},
        {"Geneva Identification System", "GEN# +9.00053001"},
        {"Smithsonian Astrophysical Observation", "SAO 57974"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.03887848),
        dec: Angle.Degrees(+39.36580948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16834"},
        {"Hipparcos Number", "HIP 12704"},
        {"Geneva Identification System", "GEN# +1.00016834"},
        {"Smithsonian Astrophysical Observation", "SAO 55808"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.81126922),
        dec: Angle.Degrees(+39.36624713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92765",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92765"},
        {"Smithsonian Astrophysical Observation", "SAO 67552"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.55310944),
        dec: Angle.Degrees(+39.36724663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48412"},
        {"Hipparcos Number", "HIP 32350"},
        {"Geneva Identification System", "GEN# +1.00048412"},
        {"Smithsonian Astrophysical Observation", "SAO 59441"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.29056119),
        dec: Angle.Degrees(+39.36846756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90962"},
        {"Smithsonian Astrophysical Observation", "SAO 67104"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.33229491),
        dec: Angle.Degrees(+39.36883283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224344"},
        {"Hipparcos Number", "HIP 118065"},
        {"Smithsonian Astrophysical Observation", "SAO 73626"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.25602451),
        dec: Angle.Degrees(+39.36978174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71728"},
        {"Hipparcos Number", "HIP 41713"},
        {"Geneva Identification System", "GEN# +1.00071728"},
        {"Smithsonian Astrophysical Observation", "SAO 60857"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.59594917),
        dec: Angle.Degrees(+39.37004854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39201"},
        {"Smithsonian Astrophysical Observation", "SAO 60515"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.27957852),
        dec: Angle.Degrees(+39.37005939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28853"},
        {"Smithsonian Astrophysical Observation", "SAO 58720"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.35765943),
        dec: Angle.Degrees(+39.37024429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202329"},
        {"Hipparcos Number", "HIP 104801"},
        {"Smithsonian Astrophysical Observation", "SAO 71097"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.47378268),
        dec: Angle.Degrees(+39.37027135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15670"},
        {"Hipparcos Number", "HIP 11811"},
        {"Geneva Identification System", "GEN# +1.00015670"},
        {"Smithsonian Astrophysical Observation", "SAO 55639"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.09160672),
        dec: Angle.Degrees(+39.37166681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109296",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15662 A"},
        {"Henry Draper", "HD 210290"},
        {"Hipparcos Number", "HIP 109296"},
        {"Smithsonian Astrophysical Observation", "SAO 72055"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.13099769),
        dec: Angle.Degrees(+39.37173396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88150"},
        {"Hipparcos Number", "HIP 49854"},
        {"Smithsonian Astrophysical Observation", "SAO 61909"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.70587088),
        dec: Angle.Degrees(+39.37186891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6438"},
        {"Hipparcos Number", "HIP 5142"},
        {"Smithsonian Astrophysical Observation", "SAO 54414"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.45816667),
        dec: Angle.Degrees(+39.37422238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10999",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1798 AB"},
        {"Henry Draper", "HD 14511"},
        {"Hipparcos Number", "HIP 10999"},
        {"Smithsonian Astrophysical Observation", "SAO 55483"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.43420158),
        dec: Angle.Degrees(+39.37785304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116246"},
        {"Hipparcos Number", "HIP 65210"},
        {"Fundamental Katalog 5th Edition", "FK5 5181"},
        {"Geneva Identification System", "GEN# +1.00116246"},
        {"Smithsonian Astrophysical Observation", "SAO 63497"},
        {"Wilson Evans Batten Catalogue", "WEB 11510"},
    },
    visualMagnitude: 8.74,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.45898478),
        dec: Angle.Degrees(+39.38103654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111685",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111685"},
        {"Smithsonian Astrophysical Observation", "SAO 72548"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.37453363),
        dec: Angle.Degrees(+39.38183912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -340.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24871",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3898 E"},
        {"Henry Draper", "HD 34520"},
        {"Hipparcos Number", "HIP 24871"},
        {"Geneva Identification System", "GEN# +2.18570203"},
        {"Smithsonian Astrophysical Observation", "SAO 57900"},
        {"New General Catalogue", "NGC 1857 203"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.98096021),
        dec: Angle.Degrees(+39.38229613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151408"},
        {"Hipparcos Number", "HIP 82039"},
        {"Smithsonian Astrophysical Observation", "SAO 65533"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.38001999),
        dec: Angle.Degrees(+39.38303109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168037"},
        {"Hipparcos Number", "HIP 89522"},
        {"Smithsonian Astrophysical Observation", "SAO 66810"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.01447617),
        dec: Angle.Degrees(+39.38422740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217090"},
        {"Hipparcos Number", "HIP 113365"},
        {"Fundamental Katalog 5th Edition", "FK5 6032"},
        {"Geneva Identification System", "GEN# +1.00217090"},
        {"Smithsonian Astrophysical Observation", "SAO 72882"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.40383729),
        dec: Angle.Degrees(+39.38874753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40946"},
        {"Smithsonian Astrophysical Observation", "SAO 60750"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.34606938),
        dec: Angle.Degrees(+39.38923671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7074",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7074"},
        {"Smithsonian Astrophysical Observation", "SAO 54752"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.78823158),
        dec: Angle.Degrees(+39.39028935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109013"},
        {"Smithsonian Astrophysical Observation", "SAO 72008"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.27411016),
        dec: Angle.Degrees(+39.39096574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47070"},
        {"Hipparcos Number", "HIP 31771"},
        {"Fundamental Katalog 5th Edition", "FK5 250"},
        {"Geneva Identification System", "GEN# +1.00047070"},
        {"Smithsonian Astrophysical Observation", "SAO 59316"},
        {"Wilson Evans Batten Catalogue", "WEB 6378"},
    },
    visualMagnitude: 5.70,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.66480928),
        dec: Angle.Degrees(+39.39111530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75681"},
        {"Hipparcos Number", "HIP 43596"},
        {"Smithsonian Astrophysical Observation", "SAO 61103"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.19192703),
        dec: Angle.Degrees(+39.39157643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198797"},
        {"Hipparcos Number", "HIP 102947"},
        {"Geneva Identification System", "GEN# +1.00198797"},
        {"Smithsonian Astrophysical Observation", "SAO 70588"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.86562792),
        dec: Angle.Degrees(+39.39237069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202850"},
        {"Hipparcos Number", "HIP 105102"},
        {"Celescope Catalog", "CEL 5285"},
        {"Fundamental Katalog 5th Edition", "FK5 1558"},
        {"Geneva Identification System", "GEN# +1.00202850"},
        {"Smithsonian Astrophysical Observation", "SAO 71165"},
        {"Wilson Evans Batten Catalogue", "WEB 19091"},
    },
    visualMagnitude: 4.22,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.35396892),
        dec: Angle.Degrees(+39.39469016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23261",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3589 A"},
        {"Henry Draper", "HD 31761"},
        {"Henry Draper 2", "HD 31761A"},
        {"Hipparcos Number", "HIP 23261"},
        {"Geneva Identification System", "GEN# +1.00031761"},
        {"Smithsonian Astrophysical Observation", "SAO 57559"},
        {"Wilson Evans Batten Catalogue", "WEB 4520"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.07644704),
        dec: Angle.Degrees(+39.39470389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102226"},
        {"Hipparcos Number", "HIP 57389"},
        {"Geneva Identification System", "GEN# +1.00102226"},
        {"Smithsonian Astrophysical Observation", "SAO 62696"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.49308741),
        dec: Angle.Degrees(+39.39526708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38191"},
        {"Smithsonian Astrophysical Observation", "SAO 60361"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.37717321),
        dec: Angle.Degrees(+39.39547580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13025"},
        {"Hipparcos Number", "HIP 9973"},
        {"Smithsonian Astrophysical Observation", "SAO 55287"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.10603896),
        dec: Angle.Degrees(+39.39651106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60286"},
        {"Smithsonian Astrophysical Observation", "SAO 62968"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.43616735),
        dec: Angle.Degrees(+39.39679441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -188.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102242"},
        {"Hipparcos Number", "HIP 57408"},
        {"Geneva Identification System", "GEN# +1.00102242"},
        {"Smithsonian Astrophysical Observation", "SAO 62698"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.54006939),
        dec: Angle.Degrees(+39.40153124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55819"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.60506748),
        dec: Angle.Degrees(+39.40287253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100268",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13728 ABC"},
        {"Henry Draper", "HD 193702"},
        {"Hipparcos Number", "HIP 100268"},
        {"Celescope Catalog", "CEL 5030"},
        {"Geneva Identification System", "GEN# +1.00193702J"},
        {"Smithsonian Astrophysical Observation", "SAO 69856"},
        {"Wilson Evans Batten Catalogue", "WEB 18083"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.06342626),
        dec: Angle.Degrees(+39.40328172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12592"},
        {"Hipparcos Number", "HIP 9667"},
        {"Smithsonian Astrophysical Observation", "SAO 55238"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.08248878),
        dec: Angle.Degrees(+39.40363617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54579"},
    },
    visualMagnitude: 11.05,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.53408509),
        dec: Angle.Degrees(+39.40376171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188724"},
        {"Hipparcos Number", "HIP 97999"},
        {"Smithsonian Astrophysical Observation", "SAO 69083"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.73823035),
        dec: Angle.Degrees(+39.40391959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92265"},
        {"Hipparcos Number", "HIP 52195"},
        {"Smithsonian Astrophysical Observation", "SAO 62185"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.95559693),
        dec: Angle.Degrees(+39.40467298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129601"},
        {"Hipparcos Number", "HIP 71889"},
        {"Geneva Identification System", "GEN# +1.00129601"},
        {"Smithsonian Astrophysical Observation", "SAO 64283"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.55270083),
        dec: Angle.Degrees(+39.40791549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189393"},
        {"Hipparcos Number", "HIP 98285"},
        {"Smithsonian Astrophysical Observation", "SAO 69179"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.54664712),
        dec: Angle.Degrees(+39.40879307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10388"},
        {"Hipparcos Number", "HIP 7951"},
        {"Geneva Identification System", "GEN# +1.00010388"},
        {"Smithsonian Astrophysical Observation", "SAO 54913"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.53244394),
        dec: Angle.Degrees(+39.41220094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68633"},
        {"Geneva Identification System", "GEN# +0.04002722"},
        {"Smithsonian Astrophysical Observation", "SAO 63910"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.73612913),
        dec: Angle.Degrees(+39.41277811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78657"},
        {"Smithsonian Astrophysical Observation", "SAO 65052"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.86790314),
        dec: Angle.Degrees(+39.41608231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128253"},
        {"Hipparcos Number", "HIP 71291"},
        {"Cincinnati Publication", "Ci 18 1919"},
        {"Smithsonian Astrophysical Observation", "SAO 64228"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.69883930),
        dec: Angle.Degrees(+39.41617988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -274.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215760"},
        {"Hipparcos Number", "HIP 112475"},
        {"Geneva Identification System", "GEN# +1.00215760"},
        {"Smithsonian Astrophysical Observation", "SAO 72716"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.73246705),
        dec: Angle.Degrees(+39.41713252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114661",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114661"},
        {"Cincinnati Publication", "Ci 20 1407"},
        {"Geneva Identification System", "GEN# +0.03804955"},
        {"Wilson Evans Batten Catalogue", "WEB 20336"},
    },
    visualMagnitude: 11.02,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.41120285),
        dec: Angle.Degrees(+39.41815108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -313.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6604",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6604"},
        {"Smithsonian Astrophysical Observation", "SAO 54672"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.20253111),
        dec: Angle.Degrees(+39.41857512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72862"},
        {"Hipparcos Number", "HIP 42237"},
        {"Geneva Identification System", "GEN# +1.00072862"},
        {"Smithsonian Astrophysical Observation", "SAO 60919"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.16836380),
        dec: Angle.Degrees(+39.41885680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179733"},
        {"Hipparcos Number", "HIP 94328"},
        {"Geneva Identification System", "GEN# +1.00179733"},
        {"Smithsonian Astrophysical Observation", "SAO 67956"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.00131795),
        dec: Angle.Degrees(+39.42073601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80417",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10053 AB"},
        {"Hipparcos Number", "HIP 80417"},
        {"Smithsonian Astrophysical Observation", "SAO 65286"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.20654953),
        dec: Angle.Degrees(+39.42212547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210323"},
        {"Hipparcos Number", "HIP 109310"},
        {"Smithsonian Astrophysical Observation", "SAO 72060"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.19035056),
        dec: Angle.Degrees(+39.42457295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209470"},
        {"Hipparcos Number", "HIP 108833"},
        {"Smithsonian Astrophysical Observation", "SAO 71979"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.71136452),
        dec: Angle.Degrees(+39.42740431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69253"},
        {"Smithsonian Astrophysical Observation", "SAO 63974"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.65319407),
        dec: Angle.Degrees(+39.42766453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104260"},
        {"Hipparcos Number", "HIP 58561"},
        {"Smithsonian Astrophysical Observation", "SAO 62793"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.12247594),
        dec: Angle.Degrees(+39.42879146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18009"},
        {"Hipparcos Number", "HIP 13581"},
        {"Smithsonian Astrophysical Observation", "SAO 55993"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.73206029),
        dec: Angle.Degrees(+39.42913221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142978"},
        {"Hipparcos Number", "HIP 78048"},
        {"Fundamental Katalog 5th Edition", "FK5 5408"},
        {"Geneva Identification System", "GEN# +1.00142978"},
        {"Smithsonian Astrophysical Observation", "SAO 64978"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.02954001),
        dec: Angle.Degrees(+39.42933791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116494"},
        {"Hipparcos Number", "HIP 65330"},
        {"Geneva Identification System", "GEN# +1.00116494"},
        {"Smithsonian Astrophysical Observation", "SAO 63510"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.85279290),
        dec: Angle.Degrees(+39.42958156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134588"},
        {"Hipparcos Number", "HIP 74173"},
        {"Smithsonian Astrophysical Observation", "SAO 64525"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.33436611),
        dec: Angle.Degrees(+39.43018974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92613"},
        {"Smithsonian Astrophysical Observation", "SAO 67502"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.06268205),
        dec: Angle.Degrees(+39.43036535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212585"},
        {"Hipparcos Number", "HIP 110626"},
        {"Geneva Identification System", "GEN# +1.00212585"},
        {"Smithsonian Astrophysical Observation", "SAO 72310"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.15715048),
        dec: Angle.Degrees(+39.43052527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 192.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109619"},
    },
    visualMagnitude: 11.81,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.09006209),
        dec: Angle.Degrees(+39.43218226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105663"},
        {"Hipparcos Number", "HIP 59295"},
        {"Geneva Identification System", "GEN# +1.00105663"},
        {"Smithsonian Astrophysical Observation", "SAO 62869"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.47382270),
        dec: Angle.Degrees(+39.43351900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43828"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.89841306),
        dec: Angle.Degrees(+39.43506621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12637"},
        {"Hipparcos Number", "HIP 9700"},
        {"Fundamental Katalog 5th Edition", "FK5 4187"},
        {"Geneva Identification System", "GEN# +1.00012637"},
        {"Smithsonian Astrophysical Observation", "SAO 55243"},
        {"Wilson Evans Batten Catalogue", "WEB 2040"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.19085257),
        dec: Angle.Degrees(+39.43510605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214432"},
        {"Hipparcos Number", "HIP 111683"},
        {"Celescope Catalog", "CEL 5498"},
        {"Geneva Identification System", "GEN# +1.00214432"},
        {"Smithsonian Astrophysical Observation", "SAO 72547"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.36968325),
        dec: Angle.Degrees(+39.43887838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87802",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10911 AB"},
        {"Henry Draper", "HD 163789"},
        {"Hipparcos Number", "HIP 87802"},
        {"Smithsonian Astrophysical Observation", "SAO 66487"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.05000469),
        dec: Angle.Degrees(+39.43920463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3701"},
        {"Hipparcos Number", "HIP 3155"},
        {"Smithsonian Astrophysical Observation", "SAO 54063"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.02869637),
        dec: Angle.Degrees(+39.44065324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107808",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15375 AB"},
        {"Henry Draper", "HD 207782"},
        {"Hipparcos Number", "HIP 107808"},
        {"Geneva Identification System", "GEN# +1.00207782J"},
        {"Smithsonian Astrophysical Observation", "SAO 71756"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.61166763),
        dec: Angle.Degrees(+39.44220640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105787"},
        {"Smithsonian Astrophysical Observation", "SAO 71323"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.36689521),
        dec: Angle.Degrees(+39.44433454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151748"},
        {"Hipparcos Number", "HIP 82200"},
        {"Smithsonian Astrophysical Observation", "SAO 65560"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.89596413),
        dec: Angle.Degrees(+39.44576526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46157"},
        {"Hipparcos Number", "HIP 31288"},
        {"Smithsonian Astrophysical Observation", "SAO 59221"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.42402525),
        dec: Angle.Degrees(+39.44622312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38995"},
        {"Smithsonian Astrophysical Observation", "SAO 60491"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.71325004),
        dec: Angle.Degrees(+39.44717436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227579"},
        {"Hipparcos Number", "HIP 98939"},
        {"Smithsonian Astrophysical Observation", "SAO 69383"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.32834553),
        dec: Angle.Degrees(+39.44861423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50776"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.53051889),
        dec: Angle.Degrees(+39.44873402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21612",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3348 A"},
        {"Henry Draper", "HD 29283"},
        {"Hipparcos Number", "HIP 21612"},
        {"Geneva Identification System", "GEN# +1.00029283"},
        {"Smithsonian Astrophysical Observation", "SAO 57351"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.59545200),
        dec: Angle.Degrees(+39.44948917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7392"},
        {"Hipparcos Number", "HIP 5827"},
        {"Geneva Identification System", "GEN# +1.00007392"},
        {"Smithsonian Astrophysical Observation", "SAO 54543"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.68382215),
        dec: Angle.Degrees(+39.44968221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11044"},
        {"Hipparcos Number", "HIP 8478"},
        {"Smithsonian Astrophysical Observation", "SAO 55001"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.32586644),
        dec: Angle.Degrees(+39.45187987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222047"},
        {"Hipparcos Number", "HIP 116548"},
        {"Smithsonian Astrophysical Observation", "SAO 73380"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.29375750),
        dec: Angle.Degrees(+39.45271164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87581"},
        {"Smithsonian Astrophysical Observation", "SAO 66441"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.37604235),
        dec: Angle.Degrees(+39.45323021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36758"},
        {"Smithsonian Astrophysical Observation", "SAO 60177"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.39495009),
        dec: Angle.Degrees(+39.45410291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92606",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92606"},
        {"Smithsonian Astrophysical Observation", "SAO 67501"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.04461392),
        dec: Angle.Degrees(+39.45439671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275988"},
        {"Hipparcos Number", "HIP 18552"},
        {"Smithsonian Astrophysical Observation", "SAO 56848"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.55707368),
        dec: Angle.Degrees(+39.45557632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106694"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.16136849),
        dec: Angle.Degrees(+39.45609314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3817"},
        {"Hipparcos Number", "HIP 3231"},
        {"Fundamental Katalog 5th Edition", "FK5 2043"},
        {"Geneva Identification System", "GEN# +1.00003817"},
        {"Smithsonian Astrophysical Observation", "SAO 54079"},
        {"Wilson Evans Batten Catalogue", "WEB 578"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.27998074),
        dec: Angle.Degrees(+39.45867141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197667"},
        {"Hipparcos Number", "HIP 102314"},
        {"Smithsonian Astrophysical Observation", "SAO 70435"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.95889219),
        dec: Angle.Degrees(+39.45966458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7437"},
        {"Smithsonian Astrophysical Observation", "SAO 54815"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.94880241),
        dec: Angle.Degrees(+39.46083248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194909"},
        {"Hipparcos Number", "HIP 100838"},
        {"Geneva Identification System", "GEN# +1.00194909"},
        {"Smithsonian Astrophysical Observation", "SAO 70037"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.69265143),
        dec: Angle.Degrees(+39.46224919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226373"},
        {"Hipparcos Number", "HIP 97864"},
        {"Smithsonian Astrophysical Observation", "SAO 69032"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.30291556),
        dec: Angle.Degrees(+39.46252244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121647"},
        {"Hipparcos Number", "HIP 68037"},
        {"Geneva Identification System", "GEN# +1.00121647"},
        {"Smithsonian Astrophysical Observation", "SAO 63836"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.97091716),
        dec: Angle.Degrees(+39.46316873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24638",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3851 AB"},
        {"Henry Draper", "HD 34175"},
        {"Hipparcos Number", "HIP 24638"},
        {"Smithsonian Astrophysical Observation", "SAO 57832"},
        {"Wilson Evans Batten Catalogue", "WEB 4767"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.30173993),
        dec: Angle.Degrees(+39.46365876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87634"},
        {"Smithsonian Astrophysical Observation", "SAO 66451"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.51715450),
        dec: Angle.Degrees(+39.46368492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13341"},
        {"Hipparcos Number", "HIP 10223"},
        {"Smithsonian Astrophysical Observation", "SAO 55336"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.86356740),
        dec: Angle.Degrees(+39.46444387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276148"},
        {"Hipparcos Number", "HIP 19653"},
        {"Smithsonian Astrophysical Observation", "SAO 57068"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.16228837),
        dec: Angle.Degrees(+39.46495562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31354"},
        {"Smithsonian Astrophysical Observation", "SAO 59235"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.62331280),
        dec: Angle.Degrees(+39.46503692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112241",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16228 AB"},
        {"Henry Draper", "HD 215359"},
        {"Hipparcos Number", "HIP 112241"},
        {"Geneva Identification System", "GEN# +1.00215359J"},
        {"Smithsonian Astrophysical Observation", "SAO 72675"},
        {"Wilson Evans Batten Catalogue", "WEB 20028"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.02171745),
        dec: Angle.Degrees(+39.46541736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130916"},
        {"Hipparcos Number", "HIP 72515"},
        {"Geneva Identification System", "GEN# +1.00130916"},
        {"Smithsonian Astrophysical Observation", "SAO 64347"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.39795683),
        dec: Angle.Degrees(+39.46623764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10347"},
        {"Hipparcos Number", "HIP 7923"},
        {"Geneva Identification System", "GEN# +1.00010347"},
        {"Smithsonian Astrophysical Observation", "SAO 54909"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.45981948),
        dec: Angle.Degrees(+39.46767625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30897",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30897"},
        {"Smithsonian Astrophysical Observation", "SAO 59133"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.28690654),
        dec: Angle.Degrees(+39.46771216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156632"},
        {"Hipparcos Number", "HIP 84532"},
        {"Geneva Identification System", "GEN# +1.00156632"},
        {"Smithsonian Astrophysical Observation", "SAO 65910"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.22509104),
        dec: Angle.Degrees(+39.46811903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 146.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218725"},
        {"Hipparcos Number", "HIP 114373"},
        {"Geneva Identification System", "GEN# +1.00218725"},
        {"Renson", "Renson 60190"},
        {"Smithsonian Astrophysical Observation", "SAO 73049"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.46850622),
        dec: Angle.Degrees(+39.46920875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68165"},
        {"Hipparcos Number", "HIP 40224"},
        {"Smithsonian Astrophysical Observation", "SAO 60644"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.22870998),
        dec: Angle.Degrees(+39.47320231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101008"},
        {"Smithsonian Astrophysical Observation", "SAO 70088"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.17739410),
        dec: Angle.Degrees(+39.47368020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43381"},
        {"Hipparcos Number", "HIP 29901"},
        {"Smithsonian Astrophysical Observation", "SAO 58946"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.43741858),
        dec: Angle.Degrees(+39.47388559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107080",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15224 AB"},
        {"Henry Draper", "HD 206462"},
        {"Hipparcos Number", "HIP 107080"},
        {"Smithsonian Astrophysical Observation", "SAO 71604"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.32853191),
        dec: Angle.Degrees(+39.47400466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5597"},
        {"Hipparcos Number", "HIP 4542"},
        {"Geneva Identification System", "GEN# +1.00005597"},
        {"Smithsonian Astrophysical Observation", "SAO 54299"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.54116845),
        dec: Angle.Degrees(+39.47544065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14273"},
        {"Hipparcos Number", "HIP 10847"},
        {"Geneva Identification System", "GEN# +1.00014273"},
        {"Smithsonian Astrophysical Observation", "SAO 55454"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.90387396),
        dec: Angle.Degrees(+39.47551314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6086"},
        {"Hipparcos Number", "HIP 4863"},
        {"Geneva Identification System", "GEN# +1.00006086"},
        {"Smithsonian Astrophysical Observation", "SAO 54368"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.63297566),
        dec: Angle.Degrees(+39.47562100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199835"},
        {"Hipparcos Number", "HIP 103526"},
        {"Geneva Identification System", "GEN# +1.00199835"},
        {"Smithsonian Astrophysical Observation", "SAO 70740"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.60675891),
        dec: Angle.Degrees(+39.47784564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106687"},
        {"Smithsonian Astrophysical Observation", "SAO 71518"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.13756722),
        dec: Angle.Degrees(+39.47897256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49344"},
        {"Hipparcos Number", "HIP 32757"},
        {"Smithsonian Astrophysical Observation", "SAO 59519"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.45832096),
        dec: Angle.Degrees(+39.47910981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7669"},
        {"Hipparcos Number", "HIP 6010"},
        {"Celescope Catalog", "CEL 134"},
        {"Geneva Identification System", "GEN# +1.00007669"},
        {"Smithsonian Astrophysical Observation", "SAO 54579"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.31922765),
        dec: Angle.Degrees(+39.48054928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165434"},
        {"Hipparcos Number", "HIP 88488"},
        {"Smithsonian Astrophysical Observation", "SAO 66603"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.02867755),
        dec: Angle.Degrees(+39.48078860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31434"},
        {"Hipparcos Number", "HIP 23054"},
        {"Smithsonian Astrophysical Observation", "SAO 57527"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.41843139),
        dec: Angle.Degrees(+39.48116079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64019"},
        {"Hipparcos Number", "HIP 38530"},
        {"Smithsonian Astrophysical Observation", "SAO 60412"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.35108432),
        dec: Angle.Degrees(+39.48195995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209792"},
        {"Hipparcos Number", "HIP 109014"},
        {"Geneva Identification System", "GEN# +1.00209792"},
        {"Smithsonian Astrophysical Observation", "SAO 72010"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.27835203),
        dec: Angle.Degrees(+39.48267514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18380"},
        {"Hipparcos Number", "HIP 13858"},
        {"Geneva Identification System", "GEN# +1.00018380"},
        {"Smithsonian Astrophysical Observation", "SAO 56042"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.60419664),
        dec: Angle.Degrees(+39.48267518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182237"},
        {"Hipparcos Number", "HIP 95201"},
        {"Smithsonian Astrophysical Observation", "SAO 68209"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.50764229),
        dec: Angle.Degrees(+39.48746096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23954",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3718 A"},
        {"Henry Draper", "HD 32989"},
        {"Hipparcos Number", "HIP 23954"},
        {"Celescope Catalog", "CEL 542"},
        {"Geneva Identification System", "GEN# +1.00032989"},
        {"Smithsonian Astrophysical Observation", "SAO 57677"},
        {"Wilson Evans Batten Catalogue", "WEB 4671"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.22478943),
        dec: Angle.Degrees(+39.48826983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75632"},
        {"Smithsonian Astrophysical Observation", "SAO 64711"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.78751006),
        dec: Angle.Degrees(+39.49329241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196653"},
        {"Hipparcos Number", "HIP 101753"},
        {"Smithsonian Astrophysical Observation", "SAO 70291"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.34307704),
        dec: Angle.Degrees(+39.49414733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9177"},
        {"Hipparcos Number", "HIP 7064"},
        {"Celescope Catalog", "CEL 143"},
        {"Fundamental Katalog 5th Edition", "FK5 4137"},
        {"Geneva Identification System", "GEN# +1.00009177"},
        {"Smithsonian Astrophysical Observation", "SAO 54750"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.76029147),
        dec: Angle.Degrees(+39.49462514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93167"},
        {"Hipparcos Number", "HIP 52659"},
        {"Geneva Identification System", "GEN# +1.00093167"},
        {"Smithsonian Astrophysical Observation", "SAO 62240"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.52349021),
        dec: Angle.Degrees(+39.49465368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194885"},
        {"Hipparcos Number", "HIP 100834"},
        {"Celescope Catalog", "CEL 5063"},
        {"Geneva Identification System", "GEN# +1.00194885"},
        {"Smithsonian Astrophysical Observation", "SAO 70033"},
        {"Wilson Evans Batten Catalogue", "WEB 18219"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.68235169),
        dec: Angle.Degrees(+39.49591929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201273"},
        {"Hipparcos Number", "HIP 104237"},
        {"Renson", "Renson 56154"},
        {"Smithsonian Astrophysical Observation", "SAO 70937"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.78973482),
        dec: Angle.Degrees(+39.49708416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179909"},
        {"Hipparcos Number", "HIP 94388"},
        {"Celescope Catalog", "CEL 4723"},
        {"Geneva Identification System", "GEN# +1.00179909"},
        {"Smithsonian Astrophysical Observation", "SAO 67984"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.17840391),
        dec: Angle.Degrees(+39.49731083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87748"},
        {"Smithsonian Astrophysical Observation", "SAO 66474"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.85453314),
        dec: Angle.Degrees(+39.49822147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70648"},
        {"Hipparcos Number", "HIP 41220"},
        {"Smithsonian Astrophysical Observation", "SAO 60789"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.16065495),
        dec: Angle.Degrees(+39.49955491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26033"},
        {"Smithsonian Astrophysical Observation", "SAO 58171"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.30797052),
        dec: Angle.Degrees(+39.49987499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198916"},
        {"Hipparcos Number", "HIP 103012"},
        {"Smithsonian Astrophysical Observation", "SAO 70612"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.05922949),
        dec: Angle.Degrees(+39.50128340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186959"},
        {"Hipparcos Number", "HIP 97236"},
        {"Geneva Identification System", "GEN# +1.00186959"},
        {"Smithsonian Astrophysical Observation", "SAO 68811"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.43572592),
        dec: Angle.Degrees(+39.50366983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87531"},
        {"Hipparcos Number", "HIP 49511"},
        {"Smithsonian Astrophysical Observation", "SAO 61863"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.63461751),
        dec: Angle.Degrees(+39.50382128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17292"},
        {"Hipparcos Number", "HIP 13057"},
        {"Smithsonian Astrophysical Observation", "SAO 55884"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.94952645),
        dec: Angle.Degrees(+39.50414380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58775"},
        {"Smithsonian Astrophysical Observation", "SAO 62817"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.82053935),
        dec: Angle.Degrees(+39.50466859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46383",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46383"},
        {"Geneva Identification System", "GEN# +0.04002208"},
        {"Wilson Evans Batten Catalogue", "WEB 8767"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.86784714),
        dec: Angle.Degrees(+39.50536275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36387"},
        {"Hipparcos Number", "HIP 26037"},
        {"Geneva Identification System", "GEN# +1.00036387"},
        {"Smithsonian Astrophysical Observation", "SAO 58174"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.32052116),
        dec: Angle.Degrees(+39.50603796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90191",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alathfar"},
        {"Henry Draper", "HD 169702"},
        {"Hipparcos Number", "HIP 90191"},
        {"Fundamental Katalog 5th Edition", "FK5 3463"},
        {"Geneva Identification System", "GEN# +1.00169702"},
        {"Smithsonian Astrophysical Observation", "SAO 66943"},
        {"Wilson Evans Batten Catalogue", "WEB 15424"},
    },
    visualMagnitude: 5.11,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.05750733),
        dec: Angle.Degrees(+39.50724983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42978"},
        {"Hipparcos Number", "HIP 29734"},
        {"Smithsonian Astrophysical Observation", "SAO 58902"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.92569760),
        dec: Angle.Degrees(+39.50750781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103822",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14567 A"},
        {"Henry Draper", "HD 200465"},
        {"Hipparcos Number", "HIP 103822"},
        {"Geneva Identification System", "GEN# +1.00200465"},
        {"Smithsonian Astrophysical Observation", "SAO 70818"},
        {"Wilson Evans Batten Catalogue", "WEB 18900"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.58732037),
        dec: Angle.Degrees(+39.50903218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18986",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2959 AB"},
        {"Henry Draper", "HD 25444"},
        {"Hipparcos Number", "HIP 18986"},
        {"Geneva Identification System", "GEN# +1.00025444J"},
        {"Smithsonian Astrophysical Observation", "SAO 56936"},
        {"Wilson Evans Batten Catalogue", "WEB 3650"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.02910699),
        dec: Angle.Degrees(+39.50995671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106851"},
        {"Smithsonian Astrophysical Observation", "SAO 71550"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.62497780),
        dec: Angle.Degrees(+39.51076149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187122"},
        {"Hipparcos Number", "HIP 97311"},
        {"Smithsonian Astrophysical Observation", "SAO 68840"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.64979325),
        dec: Angle.Degrees(+39.51119813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34832"},
        {"Hipparcos Number", "HIP 25075"},
        {"Geneva Identification System", "GEN# +1.00034832"},
        {"Smithsonian Astrophysical Observation", "SAO 57943"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.52799481),
        dec: Angle.Degrees(+39.51263751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157965"},
        {"Hipparcos Number", "HIP 85199"},
        {"Smithsonian Astrophysical Observation", "SAO 66023"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.15791566),
        dec: Angle.Degrees(+39.51337720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106548",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106548"},
        {"Smithsonian Astrophysical Observation", "SAO 71479"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.68509652),
        dec: Angle.Degrees(+39.51441075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106969",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15191 A"},
        {"Henry Draper", "HD 206261"},
        {"Hipparcos Number", "HIP 106969"},
        {"Renson", "Renson 57460"},
        {"Smithsonian Astrophysical Observation", "SAO 71574"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.97385406),
        dec: Angle.Degrees(+39.51494062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51454"},
        {"Smithsonian Astrophysical Observation", "SAO 62082"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.64554754),
        dec: Angle.Degrees(+39.51635708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169488"},
        {"Hipparcos Number", "HIP 90084"},
        {"Smithsonian Astrophysical Observation", "SAO 66923"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.76006529),
        dec: Angle.Degrees(+39.51649572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76938"},
        {"Smithsonian Astrophysical Observation", "SAO 64863"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.65983925),
        dec: Angle.Degrees(+39.51676688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197377"},
        {"Hipparcos Number", "HIP 102151"},
        {"Smithsonian Astrophysical Observation", "SAO 70397"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.47611482),
        dec: Angle.Degrees(+39.51802079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66588"},
        {"Smithsonian Astrophysical Observation", "SAO 63661"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.74994249),
        dec: Angle.Degrees(+39.52352845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -162.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69124"},
        {"Smithsonian Astrophysical Observation", "SAO 63958"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.24482560),
        dec: Angle.Degrees(+39.52493120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162703"},
        {"Hipparcos Number", "HIP 87323"},
        {"Smithsonian Astrophysical Observation", "SAO 66374"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.64254211),
        dec: Angle.Degrees(+39.52528909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209236"},
        {"Hipparcos Number", "HIP 108667"},
        {"Smithsonian Astrophysical Observation", "SAO 71944"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.21965235),
        dec: Angle.Degrees(+39.52584691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206602"},
        {"Hipparcos Number", "HIP 107150"},
        {"Smithsonian Astrophysical Observation", "SAO 71619"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.56151060),
        dec: Angle.Degrees(+39.52629129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124085"},
        {"Hipparcos Number", "HIP 69227"},
        {"Smithsonian Astrophysical Observation", "SAO 63968"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.60751358),
        dec: Angle.Degrees(+39.52640373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61234"},
        {"Smithsonian Astrophysical Observation", "SAO 63057"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.21473922),
        dec: Angle.Degrees(+39.52641592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187956"},
        {"Hipparcos Number", "HIP 97682"},
        {"Geneva Identification System", "GEN# +1.00187956"},
        {"Smithsonian Astrophysical Observation", "SAO 68965"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.77499686),
        dec: Angle.Degrees(+39.52771549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226382"},
        {"Hipparcos Number", "HIP 97875"},
        {"Smithsonian Astrophysical Observation", "SAO 69035"},
    },
    visualMagnitude: 8.72,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.33721614),
        dec: Angle.Degrees(+39.52837165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3741"},
        {"Hipparcos Number", "HIP 3184"},
        {"Smithsonian Astrophysical Observation", "SAO 54070"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.13476947),
        dec: Angle.Degrees(+39.52986860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38604"},
        {"Hipparcos Number", "HIP 27458"},
        {"Geneva Identification System", "GEN# +1.00038604"},
        {"Smithsonian Astrophysical Observation", "SAO 58460"},
        {"Wilson Evans Batten Catalogue", "WEB 5391"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.21591081),
        dec: Angle.Degrees(+39.53366650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51351"},
        {"Hipparcos Number", "HIP 33597"},
        {"Smithsonian Astrophysical Observation", "SAO 59655"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.71110912),
        dec: Angle.Degrees(+39.53589727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226222"},
        {"Hipparcos Number", "HIP 97728"},
        {"Smithsonian Astrophysical Observation", "SAO 68977"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.89965750),
        dec: Angle.Degrees(+39.53608999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207857"},
        {"Hipparcos Number", "HIP 107856"},
        {"Celescope Catalog", "CEL 5394"},
        {"Geneva Identification System", "GEN# +1.00207857"},
        {"Renson", "Renson 57790"},
        {"Smithsonian Astrophysical Observation", "SAO 71767"},
        {"Wilson Evans Batten Catalogue", "WEB 19449"},
    },
    visualMagnitude: 6.20,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.77072409),
        dec: Angle.Degrees(+39.53664936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276946"},
        {"Hipparcos Number", "HIP 22418"},
        {"Smithsonian Astrophysical Observation", "SAO 57442"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.36527256),
        dec: Angle.Degrees(+39.53692611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19011"},
        {"Hipparcos Number", "HIP 14331"},
        {"Smithsonian Astrophysical Observation", "SAO 56134"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.20759231),
        dec: Angle.Degrees(+39.53699533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12174"},
        {"Hipparcos Number", "HIP 9370"},
        {"Geneva Identification System", "GEN# +1.00012174"},
        {"Smithsonian Astrophysical Observation", "SAO 55179"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.10060516),
        dec: Angle.Degrees(+39.53701671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50226"},
        {"Geneva Identification System", "GEN# +0.04002309B"},
        {"Wilson Evans Batten Catalogue", "WEB 9226"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.79942617),
        dec: Angle.Degrees(+39.53710916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 174.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16680"},
        {"Hipparcos Number", "HIP 12569"},
        {"Smithsonian Astrophysical Observation", "SAO 55788"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.41336045),
        dec: Angle.Degrees(+39.53793266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63874"},
        {"Hipparcos Number", "HIP 38458"},
        {"Geneva Identification System", "GEN# +1.00063874"},
        {"Smithsonian Astrophysical Observation", "SAO 60399"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.16691094),
        dec: Angle.Degrees(+39.53833256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189959"},
        {"Hipparcos Number", "HIP 98545"},
        {"Renson", "Renson 52690"},
        {"Smithsonian Astrophysical Observation", "SAO 69265"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.28183419),
        dec: Angle.Degrees(+39.54073138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194424"},
        {"Hipparcos Number", "HIP 100603"},
        {"Celescope Catalog", "CEL 5049"},
        {"Geneva Identification System", "GEN# +1.00194424"},
        {"Smithsonian Astrophysical Observation", "SAO 69962"},
        {"Wilson Evans Batten Catalogue", "WEB 18181"},
    },
    visualMagnitude: 7.85,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.01170474),
        dec: Angle.Degrees(+39.54151890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120499"},
        {"Hipparcos Number", "HIP 67410"},
        {"Geneva Identification System", "GEN# +1.00120499"},
        {"Smithsonian Astrophysical Observation", "SAO 63763"},
        {"Wilson Evans Batten Catalogue", "WEB 11856"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.23767644),
        dec: Angle.Degrees(+39.54256359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80292"},
        {"Hipparcos Number", "HIP 45782"},
        {"Smithsonian Astrophysical Observation", "SAO 61403"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.02211418),
        dec: Angle.Degrees(+39.54261451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1547"},
        {"Hipparcos Number", "HIP 1594"},
        {"Smithsonian Astrophysical Observation", "SAO 53816"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.98074437),
        dec: Angle.Degrees(+39.54285880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107368"},
        {"Smithsonian Astrophysical Observation", "SAO 71663"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.20207401),
        dec: Angle.Degrees(+39.54298587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81260",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81260"},
        {"Geneva Identification System", "GEN# +0.03903017"},
        {"Smithsonian Astrophysical Observation", "SAO 65423"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.95790920),
        dec: Angle.Degrees(+39.54319175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153971"},
        {"Hipparcos Number", "HIP 83245"},
        {"Geneva Identification System", "GEN# +1.00153971"},
        {"Smithsonian Astrophysical Observation", "SAO 65725"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.22610166),
        dec: Angle.Degrees(+39.54397228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62454"},
        {"Hipparcos Number", "HIP 37863"},
        {"Geneva Identification System", "GEN# +1.00062454"},
        {"Smithsonian Astrophysical Observation", "SAO 60320"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.42651592),
        dec: Angle.Degrees(+39.54697864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196790"},
        {"Hipparcos Number", "HIP 101836"},
        {"Geneva Identification System", "GEN# +1.00196790"},
        {"Smithsonian Astrophysical Observation", "SAO 70318"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.55466718),
        dec: Angle.Degrees(+39.54700461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83683",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83683"},
        {"Smithsonian Astrophysical Observation", "SAO 65789"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.54825917),
        dec: Angle.Degrees(+39.54773772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16053"},
        {"Hipparcos Number", "HIP 12089"},
        {"Smithsonian Astrophysical Observation", "SAO 55686"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.95500048),
        dec: Angle.Degrees(+39.54815716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74617"},
    },
    visualMagnitude: 11.11,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.68421080),
        dec: Angle.Degrees(+39.54874160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15714"},
        {"Hipparcos Number", "HIP 11833"},
        {"Smithsonian Astrophysical Observation", "SAO 55644"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.18497704),
        dec: Angle.Degrees(+39.54988847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66912",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66912"},
        {"Geneva Identification System", "GEN# +0.04002685"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.69600303),
        dec: Angle.Degrees(+39.55049315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162733"},
        {"Hipparcos Number", "HIP 87331"},
        {"Geneva Identification System", "GEN# +1.00162733"},
        {"Smithsonian Astrophysical Observation", "SAO 66377"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.66279931),
        dec: Angle.Degrees(+39.55488293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56745",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56745"},
        {"Geneva Identification System", "GEN# +0.04002445"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.51947304),
        dec: Angle.Degrees(+39.55580887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62301"},
        {"Hipparcos Number", "HIP 37789"},
        {"Cincinnati Publication", "Ci 20 435"},
        {"Fundamental Katalog 5th Edition", "FK5 4699"},
        {"Geneva Identification System", "GEN# +1.00062301"},
        {"Smithsonian Astrophysical Observation", "SAO 60313"},
        {"Wilson Evans Batten Catalogue", "WEB 7465"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.23404331),
        dec: Angle.Degrees(+39.55802931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -683.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71641"},
    },
    visualMagnitude: 11.50,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.80440649),
        dec: Angle.Degrees(+39.55892118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104273"},
        {"Smithsonian Astrophysical Observation", "SAO 70945"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.86007222),
        dec: Angle.Degrees(+39.55954764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108841",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15576 A"},
        {"Henry Draper", "HD 209483"},
        {"Hipparcos Number", "HIP 108841"},
        {"Smithsonian Astrophysical Observation", "SAO 71981"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.72762786),
        dec: Angle.Degrees(+39.56271669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39065"},
        {"Hipparcos Number", "HIP 27702"},
        {"Renson", "Renson 10490"},
        {"Smithsonian Astrophysical Observation", "SAO 58512"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.98493093),
        dec: Angle.Degrees(+39.56311514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125961"},
        {"Hipparcos Number", "HIP 70190"},
        {"Geneva Identification System", "GEN# +1.00125961"},
        {"Smithsonian Astrophysical Observation", "SAO 64094"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.40752430),
        dec: Angle.Degrees(+39.57128698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171518"},
        {"Hipparcos Number", "HIP 90980"},
        {"Smithsonian Astrophysical Observation", "SAO 67108"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.37180997),
        dec: Angle.Degrees(+39.57139641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36319"},
        {"Hipparcos Number", "HIP 25987"},
        {"Geneva Identification System", "GEN# +1.00036319"},
        {"Smithsonian Astrophysical Observation", "SAO 58161"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.18550475),
        dec: Angle.Degrees(+39.57156779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141826"},
        {"Hipparcos Number", "HIP 77501"},
        {"Geneva Identification System", "GEN# +1.00141826"},
        {"Smithsonian Astrophysical Observation", "SAO 64929"},
        {"Wilson Evans Batten Catalogue", "WEB 13120"},
    },
    visualMagnitude: 10.10,
    bvColour: 4.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.38044819),
        dec: Angle.Degrees(+39.57167230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14020",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2273 AB"},
        {"Henry Draper", "HD 18567"},
        {"Hipparcos Number", "HIP 14020"},
        {"Smithsonian Astrophysical Observation", "SAO 56079"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.12995244),
        dec: Angle.Degrees(+39.57259062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34807"},
        {"Hipparcos Number", "HIP 25060"},
        {"Geneva Identification System", "GEN# +1.00034807"},
        {"Smithsonian Astrophysical Observation", "SAO 57938"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.48073211),
        dec: Angle.Degrees(+39.57303709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140772"},
        {"Hipparcos Number", "HIP 77053"},
        {"Smithsonian Astrophysical Observation", "SAO 64873"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.00769991),
        dec: Angle.Degrees(+39.57386172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39182"},
        {"Hipparcos Number", "HIP 27777"},
        {"Geneva Identification System", "GEN# +1.00039182"},
        {"Smithsonian Astrophysical Observation", "SAO 58524"},
        {"Wilson Evans Batten Catalogue", "WEB 5445"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.16527675),
        dec: Angle.Degrees(+39.57472245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213801"},
        {"Hipparcos Number", "HIP 111337"},
        {"Celescope Catalog", "CEL 5484"},
        {"Geneva Identification System", "GEN# +1.00213801"},
        {"Smithsonian Astrophysical Observation", "SAO 72461"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.34778877),
        dec: Angle.Degrees(+39.57516559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38777"},
        {"Hipparcos Number", "HIP 27553"},
        {"Celescope Catalog", "CEL 994"},
        {"Geneva Identification System", "GEN# +1.00038777J"},
        {"Smithsonian Astrophysical Observation", "SAO 58483"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.51418971),
        dec: Angle.Degrees(+39.57629844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150255"},
        {"Hipparcos Number", "HIP 81445"},
        {"Geneva Identification System", "GEN# +1.00150255"},
        {"Smithsonian Astrophysical Observation", "SAO 65444"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.51688055),
        dec: Angle.Degrees(+39.57736836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45674"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.66615440),
        dec: Angle.Degrees(+39.58143752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137071"},
        {"Hipparcos Number", "HIP 75257"},
        {"Geneva Identification System", "GEN# +1.00137071"},
        {"Smithsonian Astrophysical Observation", "SAO 64667"},
        {"Wilson Evans Batten Catalogue", "WEB 12835"},
    },
    visualMagnitude: 5.56,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.65570869),
        dec: Angle.Degrees(+39.58149619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108973"},
        {"Hipparcos Number", "HIP 61078"},
        {"Geneva Identification System", "GEN# +1.00108973"},
        {"Smithsonian Astrophysical Observation", "SAO 63040"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.76820548),
        dec: Angle.Degrees(+39.58206053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49466",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7633 A"},
        {"Henry Draper", "HD 87442"},
        {"Hipparcos Number", "HIP 49466"},
        {"Geneva Identification System", "GEN# +1.00087442A"},
        {"Smithsonian Astrophysical Observation", "SAO 61855"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.48301919),
        dec: Angle.Degrees(+39.58213224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107217",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107217"},
        {"Smithsonian Astrophysical Observation", "SAO 71638"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.73584197),
        dec: Angle.Degrees(+39.58575993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111505",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16095 E"},
        {"Henry Draper", "HD 214112"},
        {"Hipparcos Number", "HIP 111505"},
        {"Celescope Catalog", "CEL 5489"},
        {"Geneva Identification System", "GEN# +1.00214112"},
        {"Smithsonian Astrophysical Observation", "SAO 72500"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.86466749),
        dec: Angle.Degrees(+39.58576760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104437"},
        {"Hipparcos Number", "HIP 58656"},
        {"Fundamental Katalog 5th Edition", "FK5 5058"},
        {"Geneva Identification System", "GEN# +1.00104437"},
        {"Smithsonian Astrophysical Observation", "SAO 62803"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.41996633),
        dec: Angle.Degrees(+39.58675709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10169"},
        {"Hipparcos Number", "HIP 7793"},
        {"Smithsonian Astrophysical Observation", "SAO 54887"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.07144470),
        dec: Angle.Degrees(+39.58778465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43367",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7019 AB"},
        {"Henry Draper", "HD 75189"},
        {"Hipparcos Number", "HIP 43367"},
        {"Smithsonian Astrophysical Observation", "SAO 61067"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.49946889),
        dec: Angle.Degrees(+39.58983306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85995"},
        {"Smithsonian Astrophysical Observation", "SAO 66148"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.63679620),
        dec: Angle.Degrees(+39.58994783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182593"},
        {"Hipparcos Number", "HIP 95342"},
        {"Smithsonian Astrophysical Observation", "SAO 68251"},
        {"Wilson Evans Batten Catalogue", "WEB 16664"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.94903630),
        dec: Angle.Degrees(+39.59036380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10023",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1672"},
        {"Henry Draper", "HD 13079"},
        {"Hipparcos Number", "HIP 10023"},
        {"Smithsonian Astrophysical Observation", "SAO 55300"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.25965022),
        dec: Angle.Degrees(+39.59233070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106784"},
        {"Hipparcos Number", "HIP 59868"},
        {"Geneva Identification System", "GEN# +1.00106784J"},
        {"Smithsonian Astrophysical Observation", "SAO 62930"},
        {"Wilson Evans Batten Catalogue", "WEB 10638"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.17578030),
        dec: Angle.Degrees(+39.59290932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193182"},
        {"Hipparcos Number", "HIP 100013"},
        {"Celescope Catalog", "CEL 5015"},
        {"Geneva Identification System", "GEN# +1.00193182"},
        {"Smithsonian Astrophysical Observation", "SAO 69764"},
        {"Wilson Evans Batten Catalogue", "WEB 18001"},
    },
    visualMagnitude: 6.57,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.35489078),
        dec: Angle.Degrees(+39.59353909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168811"},
        {"Hipparcos Number", "HIP 89818"},
        {"Geneva Identification System", "GEN# +1.00168811"},
        {"Smithsonian Astrophysical Observation", "SAO 66870"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.95398882),
        dec: Angle.Degrees(+39.59493553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69661"},
        {"Hipparcos Number", "HIP 40788"},
        {"Smithsonian Astrophysical Observation", "SAO 60726"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.87404220),
        dec: Angle.Degrees(+39.59541755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74872"},
        {"Hipparcos Number", "HIP 43198"},
        {"Smithsonian Astrophysical Observation", "SAO 61054"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.00560174),
        dec: Angle.Degrees(+39.59746671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275199"},
        {"Hipparcos Number", "HIP 15716"},
        {"Smithsonian Astrophysical Observation", "SAO 56385"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.60823145),
        dec: Angle.Degrees(+39.59827269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52321"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.36162280),
        dec: Angle.Degrees(+39.59971087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60951",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60951"},
        {"Geneva Identification System", "GEN# +0.04002540"},
        {"Smithsonian Astrophysical Observation", "SAO 63025"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.41270296),
        dec: Angle.Degrees(+39.60160621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34420"},
        {"Smithsonian Astrophysical Observation", "SAO 59800"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.03592114),
        dec: Angle.Degrees(+39.60203282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34809",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5856 A"},
        {"Hipparcos Number", "HIP 34809"},
        {"Smithsonian Astrophysical Observation", "SAO 59881"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.08194158),
        dec: Angle.Degrees(+39.60316093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95859",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95859"},
        {"Smithsonian Astrophysical Observation", "SAO 68397"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.45054058),
        dec: Angle.Degrees(+39.60337078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3827"},
        {"Hipparcos Number", "HIP 3237"},
        {"Celescope Catalog", "CEL 84"},
        {"Geneva Identification System", "GEN# +1.00003827"},
        {"Smithsonian Astrophysical Observation", "SAO 54080"},
        {"Wilson Evans Batten Catalogue", "WEB 579"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.30068354),
        dec: Angle.Degrees(+39.60382498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113811"},
        {"Hipparcos Number", "HIP 63907"},
        {"Geneva Identification System", "GEN# +1.00113811"},
        {"Smithsonian Astrophysical Observation", "SAO 63339"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.44494127),
        dec: Angle.Degrees(+39.60428698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80155"},
        {"Smithsonian Astrophysical Observation", "SAO 65251"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.41546714),
        dec: Angle.Degrees(+39.60469744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82589"},
        {"Smithsonian Astrophysical Observation", "SAO 65630"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.24744326),
        dec: Angle.Degrees(+39.60561638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228852"},
        {"Hipparcos Number", "HIP 100114"},
        {"Smithsonian Astrophysical Observation", "SAO 69807"},
        {"Wilson Evans Batten Catalogue", "WEB 18031"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.63947428),
        dec: Angle.Degrees(+39.60677560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162525"},
        {"Hipparcos Number", "HIP 87249"},
        {"Smithsonian Astrophysical Observation", "SAO 66361"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.41919347),
        dec: Angle.Degrees(+39.60778609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111155"},
        {"Smithsonian Astrophysical Observation", "SAO 72423"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.79629145),
        dec: Angle.Degrees(+39.60794277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73961"},
        {"Smithsonian Astrophysical Observation", "SAO 64508"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.72564786),
        dec: Angle.Degrees(+39.60858475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207827"},
        {"Hipparcos Number", "HIP 107841"},
        {"Geneva Identification System", "GEN# +1.00207827"},
        {"Smithsonian Astrophysical Observation", "SAO 71764"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.72058218),
        dec: Angle.Degrees(+39.60911582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136327"},
        {"Hipparcos Number", "HIP 74922"},
        {"Geneva Identification System", "GEN# +1.00136327"},
        {"Smithsonian Astrophysical Observation", "SAO 64623"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.65640593),
        dec: Angle.Degrees(+39.60949530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103324"},
        {"Hipparcos Number", "HIP 58014"},
        {"Geneva Identification System", "GEN# +1.00103324"},
        {"Smithsonian Astrophysical Observation", "SAO 62746"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.49037084),
        dec: Angle.Degrees(+39.60973764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193889"},
        {"Hipparcos Number", "HIP 100366"},
        {"Smithsonian Astrophysical Observation", "SAO 69887"},
        {"Wilson Evans Batten Catalogue", "WEB 18111"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.31592049),
        dec: Angle.Degrees(+39.61013112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52853"},
        {"Smithsonian Astrophysical Observation", "SAO 62259"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.11103995),
        dec: Angle.Degrees(+39.61049512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17178 AB"},
        {"Henry Draper", "HD 224873"},
        {"Hipparcos Number", "HIP 110"},
        {"Geneva Identification System", "GEN# +1.00224873"},
        {"Smithsonian Astrophysical Observation", "SAO 73690"},
        {"Wilson Evans Batten Catalogue", "WEB 14"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.34870816),
        dec: Angle.Degrees(+39.61081788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10758"},
        {"Hipparcos Number", "HIP 8238"},
        {"Smithsonian Astrophysical Observation", "SAO 54959"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.51194065),
        dec: Angle.Degrees(+39.61129199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14817",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Gorgonea Quarta"},
        {"Henry Draper", "HD 19656"},
        {"Hipparcos Number", "HIP 14817"},
        {"Geneva Identification System", "GEN# +1.00019656"},
        {"Smithsonian Astrophysical Observation", "SAO 56224"},
        {"Wilson Evans Batten Catalogue", "WEB 2860"},
    },
    visualMagnitude: 4.61,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.82250605),
        dec: Angle.Degrees(+39.61157075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41270"},
        {"Smithsonian Astrophysical Observation", "SAO 60793"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.29780790),
        dec: Angle.Degrees(+39.61245774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91926",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11635 CD"},
        {"Henry Draper", "HD 173607J"},
        {"Hipparcos Number", "HIP 91926"},
        {"Geneva Identification System", "GEN# +1.00173607"},
    },
    visualMagnitude: 4.59,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.09489936),
        dec: Angle.Degrees(+39.61259557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35365"},
    },
    visualMagnitude: 11.20,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.57804496),
        dec: Angle.Degrees(+39.61444621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39256"},
        {"Smithsonian Astrophysical Observation", "SAO 60519"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.41922487),
        dec: Angle.Degrees(+39.61605218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3361"},
        {"Hipparcos Number", "HIP 2906"},
        {"Smithsonian Astrophysical Observation", "SAO 54031"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.20541132),
        dec: Angle.Degrees(+39.61749170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127185"},
        {"Hipparcos Number", "HIP 70813"},
        {"Smithsonian Astrophysical Observation", "SAO 64167"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.23025245),
        dec: Angle.Degrees(+39.61866712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5703"},
        {"Hipparcos Number", "HIP 4613"},
        {"Geneva Identification System", "GEN# +1.00005703"},
        {"Smithsonian Astrophysical Observation", "SAO 54315"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.77922305),
        dec: Angle.Degrees(+39.61875886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221075"},
        {"Hipparcos Number", "HIP 115880"},
        {"Geneva Identification System", "GEN# +1.00221075"},
        {"Smithsonian Astrophysical Observation", "SAO 73281"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.16739208),
        dec: Angle.Degrees(+39.61904371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112600"},
        {"Smithsonian Astrophysical Observation", "SAO 72736"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.08167568),
        dec: Angle.Degrees(+39.62021537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82741"},
        {"Hipparcos Number", "HIP 47029"},
        {"Fundamental Katalog 5th Edition", "FK5 2762"},
        {"Geneva Identification System", "GEN# +1.00082741"},
        {"Smithsonian Astrophysical Observation", "SAO 61578"},
        {"Wilson Evans Batten Catalogue", "WEB 8861"},
    },
    visualMagnitude: 4.81,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.76605199),
        dec: Angle.Degrees(+39.62144313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4387"},
        {"Hipparcos Number", "HIP 3639"},
        {"Smithsonian Astrophysical Observation", "SAO 54140"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.65775155),
        dec: Angle.Degrees(+39.62168176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158715"},
        {"Hipparcos Number", "HIP 85546"},
        {"Smithsonian Astrophysical Observation", "SAO 66079"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.24546821),
        dec: Angle.Degrees(+39.62186441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34668"},
        {"Hipparcos Number", "HIP 24987"},
        {"Smithsonian Astrophysical Observation", "SAO 57923"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.25638516),
        dec: Angle.Degrees(+39.62192931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55447"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.33730966),
        dec: Angle.Degrees(+39.62198748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85291"},
        {"Hipparcos Number", "HIP 48382"},
        {"Smithsonian Astrophysical Observation", "SAO 61718"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.94358480),
        dec: Angle.Degrees(+39.62244910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199396"},
        {"Hipparcos Number", "HIP 103299"},
        {"Geneva Identification System", "GEN# +1.00199396"},
        {"Smithsonian Astrophysical Observation", "SAO 70678"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.91092894),
        dec: Angle.Degrees(+39.62292911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107211"},
        {"Hipparcos Number", "HIP 60094"},
        {"Geneva Identification System", "GEN# +1.00107211"},
        {"Smithsonian Astrophysical Observation", "SAO 62949"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.85386804),
        dec: Angle.Degrees(+39.62466869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12210"},
        {"Hipparcos Number", "HIP 9401"},
        {"Geneva Identification System", "GEN# +1.00012210"},
        {"Smithsonian Astrophysical Observation", "SAO 55186"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.19851574),
        dec: Angle.Degrees(+39.62553114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114957"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.25926572),
        dec: Angle.Degrees(+39.62683259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6074"},
        {"Hipparcos Number", "HIP 4853"},
        {"Smithsonian Astrophysical Observation", "SAO 54366"},
    },
    visualMagnitude: 9.00,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.61458376),
        dec: Angle.Degrees(+39.62705351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111544",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16095 B"},
        {"Henry Draper", "HD 214167"},
        {"Hipparcos Number", "HIP 111544"},
        {"Smithsonian Astrophysical Observation", "SAO 72508"},
        {"Wilson Evans Batten Catalogue", "WEB 19940"},
    },
    visualMagnitude: 6.60,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.96709329),
        dec: Angle.Degrees(+39.62816044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81828"},
    },
    visualMagnitude: 10.71,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.71593677),
        dec: Angle.Degrees(+39.62823934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209962"},
        {"Hipparcos Number", "HIP 109129"},
        {"Smithsonian Astrophysical Observation", "SAO 72031"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.56459863),
        dec: Angle.Degrees(+39.62839021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228960"},
        {"Hipparcos Number", "HIP 100254"},
        {"Smithsonian Astrophysical Observation", "SAO 69852"},
        {"Wilson Evans Batten Catalogue", "WEB 18075"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.99517822),
        dec: Angle.Degrees(+39.63027067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229296"},
        {"Hipparcos Number", "HIP 100767"},
        {"Smithsonian Astrophysical Observation", "SAO 70009"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.46226182),
        dec: Angle.Degrees(+39.63133740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5954"},
        {"Hipparcos Number", "HIP 4787"},
        {"Smithsonian Astrophysical Observation", "SAO 54351"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.36788323),
        dec: Angle.Degrees(+39.63148986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85029"},
        {"Hipparcos Number", "HIP 48256"},
        {"Geneva Identification System", "GEN# +1.00085029"},
        {"Smithsonian Astrophysical Observation", "SAO 61707"},
        {"Wilson Evans Batten Catalogue", "WEB 9002"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.55777265),
        dec: Angle.Degrees(+39.63169264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31451"},
        {"Hipparcos Number", "HIP 23071"},
        {"Geneva Identification System", "GEN# +1.00031451"},
        {"Smithsonian Astrophysical Observation", "SAO 57529"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.46085780),
        dec: Angle.Degrees(+39.63241619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67874",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67874"},
        {"Geneva Identification System", "GEN# +0.04002704"},
        {"Smithsonian Astrophysical Observation", "SAO 63818"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.53001461),
        dec: Angle.Degrees(+39.63304300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111546",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16095 A"},
        {"Henry Draper", "HD 214168"},
        {"Hipparcos Number", "HIP 111546"},
        {"Celescope Catalog", "CEL 5491"},
        {"Geneva Identification System", "GEN# +1.00214167"},
        {"Smithsonian Astrophysical Observation", "SAO 72509"},
        {"Wilson Evans Batten Catalogue", "WEB 19939"},
    },
    visualMagnitude: 5.73,
    bvColour: -0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.96785192),
        dec: Angle.Degrees(+39.63434136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212333"},
        {"Hipparcos Number", "HIP 110482"},
        {"Smithsonian Astrophysical Observation", "SAO 72281"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.69152582),
        dec: Angle.Degrees(+39.63534375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37516"},
        {"Hipparcos Number", "HIP 26763"},
        {"Geneva Identification System", "GEN# +1.00037516"},
        {"Smithsonian Astrophysical Observation", "SAO 58326"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.27364338),
        dec: Angle.Degrees(+39.63546706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10774"},
        {"Hipparcos Number", "HIP 8248"},
        {"Smithsonian Astrophysical Observation", "SAO 54961"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.54709254),
        dec: Angle.Degrees(+39.63683128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63706"},
        {"Geneva Identification System", "GEN# +0.04002613"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.83446758),
        dec: Angle.Degrees(+39.63715155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116476"},
        {"Hipparcos Number", "HIP 65318"},
        {"Geneva Identification System", "GEN# +1.00116476"},
        {"Smithsonian Astrophysical Observation", "SAO 63508"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.80871024),
        dec: Angle.Degrees(+39.63778854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1737"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.49378276),
        dec: Angle.Degrees(+39.63811959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62079",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62079"},
        {"Fundamental Katalog 5th Edition", "FK5 5120"},
        {"Smithsonian Astrophysical Observation", "SAO 63159"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.85089343),
        dec: Angle.Degrees(+39.63914672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7325"},
        {"Smithsonian Astrophysical Observation", "SAO 54789"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.58250744),
        dec: Angle.Degrees(+39.63956053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176392"},
        {"Hipparcos Number", "HIP 93129"},
        {"Celescope Catalog", "CEL 4677"},
        {"Smithsonian Astrophysical Observation", "SAO 67653"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.58346823),
        dec: Angle.Degrees(+39.64183209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13478"},
        {"Hipparcos Number", "HIP 10302"},
        {"Smithsonian Astrophysical Observation", "SAO 55350"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.18604766),
        dec: Angle.Degrees(+39.64405368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21630"},
        {"Hipparcos Number", "HIP 16388"},
        {"Geneva Identification System", "GEN# +1.00021630"},
        {"Smithsonian Astrophysical Observation", "SAO 56504"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.76665077),
        dec: Angle.Degrees(+39.64479609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132736"},
        {"Hipparcos Number", "HIP 73353"},
        {"Geneva Identification System", "GEN# +1.00132736"},
        {"Smithsonian Astrophysical Observation", "SAO 64447"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.85407437),
        dec: Angle.Degrees(+39.64481741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73094"},
        {"Hipparcos Number", "HIP 42341"},
        {"Smithsonian Astrophysical Observation", "SAO 60930"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.48406922),
        dec: Angle.Degrees(+39.64482608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35424"},
        {"Hipparcos Number", "HIP 25439"},
        {"Smithsonian Astrophysical Observation", "SAO 58020"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.60358636),
        dec: Angle.Degrees(+39.64655914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94413"},
        {"Smithsonian Astrophysical Observation", "SAO 67990"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.23524467),
        dec: Angle.Degrees(+39.64777578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45444"},
        {"Hipparcos Number", "HIP 30911"},
        {"Geneva Identification System", "GEN# +1.00045444"},
        {"Smithsonian Astrophysical Observation", "SAO 59134"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.32170588),
        dec: Angle.Degrees(+39.64819807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73053",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9441"},
        {"Henry Draper", "HD 132027"},
        {"Hipparcos Number", "HIP 73053"},
        {"Geneva Identification System", "GEN# +1.00132027J"},
        {"Smithsonian Astrophysical Observation", "SAO 64407"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.94403051),
        dec: Angle.Degrees(+39.64841651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75435",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75435"},
        {"Wilson Evans Batten Catalogue", "WEB 12867"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.17335378),
        dec: Angle.Degrees(+39.64885783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 557"},
        {"Hipparcos Number", "HIP 828"},
        {"Geneva Identification System", "GEN# +1.00000557"},
        {"Smithsonian Astrophysical Observation", "SAO 53689"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.53029756),
        dec: Angle.Degrees(+39.64894107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101116"},
        {"Smithsonian Astrophysical Observation", "SAO 70110"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.44225151),
        dec: Angle.Degrees(+39.65043150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180312"},
        {"Hipparcos Number", "HIP 94536"},
        {"Smithsonian Astrophysical Observation", "SAO 68024"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.60610496),
        dec: Angle.Degrees(+39.65236452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198783"},
        {"Hipparcos Number", "HIP 102942"},
        {"Geneva Identification System", "GEN# +1.00198783"},
        {"Smithsonian Astrophysical Observation", "SAO 70584"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.85024370),
        dec: Angle.Degrees(+39.65290666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131971"},
        {"Hipparcos Number", "HIP 73029"},
        {"Smithsonian Astrophysical Observation", "SAO 64403"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.87171467),
        dec: Angle.Degrees(+39.65299667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19072"},
        {"Hipparcos Number", "HIP 14374"},
        {"Smithsonian Astrophysical Observation", "SAO 56142"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.35954512),
        dec: Angle.Degrees(+39.65343926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8786"},
        {"Hipparcos Number", "HIP 6782"},
        {"Geneva Identification System", "GEN# +1.00008786"},
        {"Smithsonian Astrophysical Observation", "SAO 54706"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.80986368),
        dec: Angle.Degrees(+39.65449556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31780"},
        {"Hipparcos Number", "HIP 23268"},
        {"Smithsonian Astrophysical Observation", "SAO 57560"},
        {"Wilson Evans Batten Catalogue", "WEB 4524"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.09672824),
        dec: Angle.Degrees(+39.65465960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105405"},
        {"Hipparcos Number", "HIP 59175"},
        {"Geneva Identification System", "GEN# +1.00105405"},
        {"Smithsonian Astrophysical Observation", "SAO 62852"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.02946992),
        dec: Angle.Degrees(+39.65551569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215304"},
        {"Hipparcos Number", "HIP 112215"},
        {"Geneva Identification System", "GEN# +1.00215304"},
        {"Renson", "Renson 59480"},
        {"Smithsonian Astrophysical Observation", "SAO 72668"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.90851257),
        dec: Angle.Degrees(+39.65609577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135144"},
        {"Hipparcos Number", "HIP 74396"},
        {"Geneva Identification System", "GEN# +1.00135144"},
        {"Smithsonian Astrophysical Observation", "SAO 64554"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.07372891),
        dec: Angle.Degrees(+39.65615618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57091",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8272 B"},
        {"Henry Draper", "HD 101675B"},
        {"Hipparcos Number", "HIP 57091"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.56042805),
        dec: Angle.Degrees(+39.65779948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275376"},
        {"Hipparcos Number", "HIP 16328"},
        {"Wilson Evans Batten Catalogue", "WEB 3120"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.62617333),
        dec: Angle.Degrees(+39.65813584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105904"},
        {"Smithsonian Astrophysical Observation", "SAO 71352"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.73488282),
        dec: Angle.Degrees(+39.65873038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226775"},
        {"Hipparcos Number", "HIP 98205"},
        {"Smithsonian Astrophysical Observation", "SAO 69151"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.33271103),
        dec: Angle.Degrees(+39.65900476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57090",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8272 A"},
        {"Henry Draper", "HD 101675"},
        {"Hipparcos Number", "HIP 57090"},
        {"Geneva Identification System", "GEN# +1.00101675"},
        {"Smithsonian Astrophysical Observation", "SAO 62662"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.55716528),
        dec: Angle.Degrees(+39.65979217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48465"},
        {"Smithsonian Astrophysical Observation", "SAO 61733"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.22731092),
        dec: Angle.Degrees(+39.66235218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199694"},
        {"Hipparcos Number", "HIP 103452"},
        {"Celescope Catalog", "CEL 5219"},
        {"Geneva Identification System", "GEN# +1.00199694"},
        {"Smithsonian Astrophysical Observation", "SAO 70721"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.39823681),
        dec: Angle.Degrees(+39.66269249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184469"},
        {"Hipparcos Number", "HIP 96145"},
        {"Celescope Catalog", "CEL 4783"},
        {"Geneva Identification System", "GEN# +1.00184469"},
        {"Smithsonian Astrophysical Observation", "SAO 68478"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.23306947),
        dec: Angle.Degrees(+39.66269977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13879",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Gorgonea Secunda"},
        {"Henry Draper", "HD 18411"},
        {"Hipparcos Number", "HIP 13879"},
        {"Fundamental Katalog 5th Edition", "FK5 2207"},
        {"Geneva Identification System", "GEN# +1.00018411"},
        {"Smithsonian Astrophysical Observation", "SAO 56047"},
        {"Wilson Evans Batten Catalogue", "WEB 2741"},
    },
    visualMagnitude: 4.68,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.69021034),
        dec: Angle.Degrees(+39.66282739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47491",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47491"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.21013535),
        dec: Angle.Degrees(+39.66404288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12057",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1961 A"},
        {"Henry Draper", "HD 16004"},
        {"Hipparcos Number", "HIP 12057"},
        {"Geneva Identification System", "GEN# +1.00016004"},
        {"Renson", "Renson 4000"},
        {"Smithsonian Astrophysical Observation", "SAO 55680"},
        {"Wilson Evans Batten Catalogue", "WEB 2482"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.86619953),
        dec: Angle.Degrees(+39.66446182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186997"},
        {"Hipparcos Number", "HIP 97254"},
        {"Smithsonian Astrophysical Observation", "SAO 68821"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.48417641),
        dec: Angle.Degrees(+39.66547411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80492"},
        {"Hipparcos Number", "HIP 45875"},
        {"Geneva Identification System", "GEN# +1.00080492"},
        {"Smithsonian Astrophysical Observation", "SAO 61417"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.31462382),
        dec: Angle.Degrees(+39.66651832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134384"},
        {"Hipparcos Number", "HIP 74069"},
        {"Geneva Identification System", "GEN# +1.00134384"},
        {"Smithsonian Astrophysical Observation", "SAO 64516"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.05676792),
        dec: Angle.Degrees(+39.66780269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75010"},
        {"Smithsonian Astrophysical Observation", "SAO 64634"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.90998912),
        dec: Angle.Degrees(+39.66818266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172380"},
        {"Hipparcos Number", "HIP 91373"},
        {"Geneva Identification System", "GEN# +1.00172380"},
        {"Smithsonian Astrophysical Observation", "SAO 67193"},
        {"Wilson Evans Batten Catalogue", "WEB 15701"},
    },
    visualMagnitude: 6.02,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.52696572),
        dec: Angle.Degrees(+39.66830549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120950"},
        {"Hipparcos Number", "HIP 67662"},
        {"Fundamental Katalog 5th Edition", "FK5 5224"},
        {"Geneva Identification System", "GEN# +1.00120950"},
        {"Smithsonian Astrophysical Observation", "SAO 63794"},
        {"Wilson Evans Batten Catalogue", "WEB 11904"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.94622319),
        dec: Angle.Degrees(+39.66946780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91919",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11635 AB"},
        {"Henry Draper", "HD 173582J"},
        {"Hipparcos Number", "HIP 91919"},
        {"Geneva Identification System", "GEN# +1.00173582J"},
    },
    visualMagnitude: 4.67,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.08473883),
        dec: Angle.Degrees(+39.66997686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201444"},
        {"Hipparcos Number", "HIP 104347"},
        {"Geneva Identification System", "GEN# +1.00201444"},
        {"Smithsonian Astrophysical Observation", "SAO 70966"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.09137802),
        dec: Angle.Degrees(+39.67124785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212941"},
        {"Hipparcos Number", "HIP 110816"},
        {"Smithsonian Astrophysical Observation", "SAO 72350"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.77144251),
        dec: Angle.Degrees(+39.67184665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42736"},
        {"Hipparcos Number", "HIP 29606"},
        {"Geneva Identification System", "GEN# +1.00042736"},
        {"Smithsonian Astrophysical Observation", "SAO 58877"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.58497594),
        dec: Angle.Degrees(+39.67304914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141791"},
        {"Hipparcos Number", "HIP 77488"},
        {"Smithsonian Astrophysical Observation", "SAO 64925"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.33216293),
        dec: Angle.Degrees(+39.67424675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59534"},
    },
    visualMagnitude: 11.38,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.12215777),
        dec: Angle.Degrees(+39.67474782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5748"},
        {"Hipparcos Number", "HIP 4640"},
        {"Smithsonian Astrophysical Observation", "SAO 54325"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.89456348),
        dec: Angle.Degrees(+39.67494449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34025",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5726 AB"},
        {"Hipparcos Number", "HIP 34025"},
        {"Smithsonian Astrophysical Observation", "SAO 59723"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.89186280),
        dec: Angle.Degrees(+39.67614253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124968"},
        {"Hipparcos Number", "HIP 69666"},
        {"Geneva Identification System", "GEN# +1.00124968"},
        {"Smithsonian Astrophysical Observation", "SAO 64028"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.89704281),
        dec: Angle.Degrees(+39.67650753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138594"},
        {"Hipparcos Number", "HIP 76035"},
        {"Smithsonian Astrophysical Observation", "SAO 64758"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.93470509),
        dec: Angle.Degrees(+39.67873152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28410"},
        {"Smithsonian Astrophysical Observation", "SAO 58640"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.00605401),
        dec: Angle.Degrees(+39.67939944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209815"},
        {"Hipparcos Number", "HIP 109031"},
        {"Smithsonian Astrophysical Observation", "SAO 72011"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.31135306),
        dec: Angle.Degrees(+39.68005668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26570"},
        {"Hipparcos Number", "HIP 19729"},
        {"Geneva Identification System", "GEN# +1.00026570"},
        {"Smithsonian Astrophysical Observation", "SAO 57079"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.43290479),
        dec: Angle.Degrees(+39.68032589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61418"},
        {"Hipparcos Number", "HIP 37409"},
        {"Smithsonian Astrophysical Observation", "SAO 60264"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.21091792),
        dec: Angle.Degrees(+39.68037220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3482"},
        {"Hipparcos Number", "HIP 2995"},
        {"Geneva Identification System", "GEN# +1.00003482"},
        {"Smithsonian Astrophysical Observation", "SAO 54043"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.51924365),
        dec: Angle.Degrees(+39.68245939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186020"},
        {"Hipparcos Number", "HIP 96775"},
        {"Smithsonian Astrophysical Observation", "SAO 68673"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.06426487),
        dec: Angle.Degrees(+39.68290707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109615"},
        {"Hipparcos Number", "HIP 61471"},
        {"Geneva Identification System", "GEN# +1.00109615"},
        {"Smithsonian Astrophysical Observation", "SAO 63089"},
        {"Wilson Evans Batten Catalogue", "WEB 10940"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.94727143),
        dec: Angle.Degrees(+39.68374138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32239"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.95832038),
        dec: Angle.Degrees(+39.68643805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202197"},
        {"Hipparcos Number", "HIP 104741"},
        {"Smithsonian Astrophysical Observation", "SAO 71078"},
    },
    visualMagnitude: 8.92,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.28451959),
        dec: Angle.Degrees(+39.69001999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216152"},
        {"Hipparcos Number", "HIP 112751"},
        {"Geneva Identification System", "GEN# +1.00216152"},
        {"Smithsonian Astrophysical Observation", "SAO 72765"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.50794772),
        dec: Angle.Degrees(+39.69061402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81225"},
        {"Hipparcos Number", "HIP 46237"},
        {"Geneva Identification System", "GEN# +1.00081225"},
        {"Smithsonian Astrophysical Observation", "SAO 61474"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.40232454),
        dec: Angle.Degrees(+39.69092995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58365"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.52020878),
        dec: Angle.Degrees(+39.69242986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143209"},
        {"Hipparcos Number", "HIP 78153"},
        {"Geneva Identification System", "GEN# +1.00143209"},
        {"Smithsonian Astrophysical Observation", "SAO 64988"},
        {"Wilson Evans Batten Catalogue", "WEB 13216"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.37447650),
        dec: Angle.Degrees(+39.69496436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75908"},
        {"Smithsonian Astrophysical Observation", "SAO 64740"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.57258285),
        dec: Angle.Degrees(+39.69562218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127598"},
        {"Hipparcos Number", "HIP 70990"},
        {"Geneva Identification System", "GEN# +1.00127598"},
        {"Smithsonian Astrophysical Observation", "SAO 64195"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.79855507),
        dec: Angle.Degrees(+39.69579563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193063"},
        {"Hipparcos Number", "HIP 99954"},
        {"Celescope Catalog", "CEL 5011"},
        {"Geneva Identification System", "GEN# +1.00193063J"},
        {"Smithsonian Astrophysical Observation", "SAO 69749"},
        {"Wilson Evans Batten Catalogue", "WEB 17987"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.20220739),
        dec: Angle.Degrees(+39.69732703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17251",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2686 A"},
        {"Henry Draper", "HD 22847"},
        {"Hipparcos Number", "HIP 17251"},
        {"Smithsonian Astrophysical Observation", "SAO 56633"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.40926200),
        dec: Angle.Degrees(+39.69969114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40175"},
        {"Smithsonian Astrophysical Observation", "SAO 60634"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.07039035),
        dec: Angle.Degrees(+39.69979365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76321"},
        {"Smithsonian Astrophysical Observation", "SAO 64792"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.84171228),
        dec: Angle.Degrees(+39.70214987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36453",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36453"},
        {"Smithsonian Astrophysical Observation", "SAO 60129"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.51482718),
        dec: Angle.Degrees(+39.70701018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147365"},
        {"Hipparcos Number", "HIP 80008"},
        {"Fundamental Katalog 5th Edition", "FK5 3293"},
        {"Geneva Identification System", "GEN# +1.00147365"},
        {"Smithsonian Astrophysical Observation", "SAO 65233"},
        {"Wilson Evans Batten Catalogue", "WEB 13544"},
    },
    visualMagnitude: 5.48,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.98017016),
        dec: Angle.Degrees(+39.70859042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153527"},
        {"Hipparcos Number", "HIP 83064"},
        {"Geneva Identification System", "GEN# +1.00153527"},
        {"Smithsonian Astrophysical Observation", "SAO 65690"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.59518864),
        dec: Angle.Degrees(+39.71022470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52118",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52118"},
    },
    visualMagnitude: 11.51,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.72444771),
        dec: Angle.Degrees(+39.71098386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4193",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4193"},
        {"Smithsonian Astrophysical Observation", "SAO 54238"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.39080131),
        dec: Angle.Degrees(+39.71148957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210698"},
        {"Hipparcos Number", "HIP 109543"},
        {"Smithsonian Astrophysical Observation", "SAO 72107"},
        {"Wilson Evans Batten Catalogue", "WEB 19680"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.84025707),
        dec: Angle.Degrees(+39.71164570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25997"},
        {"Hipparcos Number", "HIP 19345"},
        {"Smithsonian Astrophysical Observation", "SAO 57007"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.16611634),
        dec: Angle.Degrees(+39.71248719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97858"},
        {"Hipparcos Number", "HIP 55005"},
        {"Smithsonian Astrophysical Observation", "SAO 62466"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.93377409),
        dec: Angle.Degrees(+39.71320490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64323"},
        {"Hipparcos Number", "HIP 38664"},
        {"Smithsonian Astrophysical Observation", "SAO 60436"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.74482978),
        dec: Angle.Degrees(+39.71345363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214783"},
        {"Hipparcos Number", "HIP 111887"},
        {"Celescope Catalog", "CEL 5507"},
        {"Geneva Identification System", "GEN# +1.00214783"},
        {"Renson", "Renson 59420"},
        {"Smithsonian Astrophysical Observation", "SAO 72594"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.95864403),
        dec: Angle.Degrees(+39.71367860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77093"},
        {"Hipparcos Number", "HIP 44331"},
        {"Geneva Identification System", "GEN# +1.00077093"},
        {"Smithsonian Astrophysical Observation", "SAO 61203"},
        {"Wilson Evans Batten Catalogue", "WEB 8498"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.41996619),
        dec: Angle.Degrees(+39.71370429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226221"},
        {"Hipparcos Number", "HIP 97724"},
        {"Smithsonian Astrophysical Observation", "SAO 68976"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.89015038),
        dec: Angle.Degrees(+39.71383466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112903",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16322 AB"},
        {"Henry Draper", "HD 216354"},
        {"Hipparcos Number", "HIP 112903"},
        {"Smithsonian Astrophysical Observation", "SAO 72792"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.94982801),
        dec: Angle.Degrees(+39.71455227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109754",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15758 A"},
        {"Aitken 2", "ADS 15758"},
        {"Henry Draper", "HD 211073"},
        {"Hipparcos Number", "HIP 109754"},
        {"Fundamental Katalog 5th Edition", "FK5 1583"},
        {"Geneva Identification System", "GEN# +1.00211073"},
        {"Smithsonian Astrophysical Observation", "SAO 72155"},
        {"Wilson Evans Batten Catalogue", "WEB 19717"},
    },
    visualMagnitude: 4.50,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.46958944),
        dec: Angle.Degrees(+39.71488928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154142"},
        {"Hipparcos Number", "HIP 83333"},
        {"Geneva Identification System", "GEN# +1.00154142"},
        {"Smithsonian Astrophysical Observation", "SAO 65743"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.46387929),
        dec: Angle.Degrees(+39.71718533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63015"},
        {"Geneva Identification System", "GEN# +0.04002590"},
        {"Smithsonian Astrophysical Observation", "SAO 63249"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.71241248),
        dec: Angle.Degrees(+39.72243394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69475"},
        {"Hipparcos Number", "HIP 40729"},
        {"Smithsonian Astrophysical Observation", "SAO 60717"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.69240320),
        dec: Angle.Degrees(+39.72483543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49448"},
        {"Hipparcos Number", "HIP 32808"},
        {"Geneva Identification System", "GEN# +1.00049448"},
        {"Smithsonian Astrophysical Observation", "SAO 59531"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.58924769),
        dec: Angle.Degrees(+39.72505956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160421"},
        {"Hipparcos Number", "HIP 86298"},
        {"Geneva Identification System", "GEN# +1.00160421"},
        {"Smithsonian Astrophysical Observation", "SAO 66200"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.50176492),
        dec: Angle.Degrees(+39.72737616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20366"},
        {"Hipparcos Number", "HIP 15355"},
        {"Smithsonian Astrophysical Observation", "SAO 56324"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.49860751),
        dec: Angle.Degrees(+39.72739921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184629"},
        {"Hipparcos Number", "HIP 96201"},
        {"Smithsonian Astrophysical Observation", "SAO 68504"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.42998809),
        dec: Angle.Degrees(+39.72797683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66726"},
        {"Geneva Identification System", "GEN# +0.04002678"},
        {"Smithsonian Astrophysical Observation", "SAO 63682"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.16654263),
        dec: Angle.Degrees(+39.72917943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228182"},
        {"Hipparcos Number", "HIP 99454"},
        {"Smithsonian Astrophysical Observation", "SAO 69571"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.78481876),
        dec: Angle.Degrees(+39.73060518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228298"},
        {"Hipparcos Number", "HIP 99571"},
        {"Smithsonian Astrophysical Observation", "SAO 69601"},
        {"Wilson Evans Batten Catalogue", "WEB 17817"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.10327832),
        dec: Angle.Degrees(+39.73218308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21405",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3315 AB"},
        {"Henry Draper", "HD 28989"},
        {"Hipparcos Number", "HIP 21405"},
        {"Smithsonian Astrophysical Observation", "SAO 57326"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.92089496),
        dec: Angle.Degrees(+39.73450010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142174"},
        {"Hipparcos Number", "HIP 77681"},
        {"Smithsonian Astrophysical Observation", "SAO 64951"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.88714753),
        dec: Angle.Degrees(+39.73593950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89318",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89318"},
        {"Smithsonian Astrophysical Observation", "SAO 66774"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.37625234),
        dec: Angle.Degrees(+39.73802145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276029"},
        {"Hipparcos Number", "HIP 18973"},
        {"Geneva Identification System", "GEN# +1.00276029"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.97935451),
        dec: Angle.Degrees(+39.73916514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 274.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -206.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94762"},
        {"Hipparcos Number", "HIP 53521"},
        {"Smithsonian Astrophysical Observation", "SAO 43538"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.22966006),
        dec: Angle.Degrees(+39.73931261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66319"},
        {"Hipparcos Number", "HIP 39523"},
        {"Geneva Identification System", "GEN# +1.00066319"},
        {"Smithsonian Astrophysical Observation", "SAO 60543"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.16750151),
        dec: Angle.Degrees(+39.74080018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93458"},
        {"Hipparcos Number", "HIP 52822"},
        {"Geneva Identification System", "GEN# +1.00093458"},
        {"Smithsonian Astrophysical Observation", "SAO 43474"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.00316712),
        dec: Angle.Degrees(+39.74240308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31747",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31747"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.61176689),
        dec: Angle.Degrees(+39.74281732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24096"},
        {"Hipparcos Number", "HIP 18074"},
        {"Geneva Identification System", "GEN# +1.00024096"},
        {"Smithsonian Astrophysical Observation", "SAO 56754"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.95901311),
        dec: Angle.Degrees(+39.74323061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144837"},
        {"Hipparcos Number", "HIP 78887"},
        {"Smithsonian Astrophysical Observation", "SAO 65079"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.55903319),
        dec: Angle.Degrees(+39.74371274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45115"},
        {"Smithsonian Astrophysical Observation", "SAO 61314"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.87672031),
        dec: Angle.Degrees(+39.74416723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125111"},
        {"Hipparcos Number", "HIP 69735"},
        {"Geneva Identification System", "GEN# +1.00125111"},
        {"Smithsonian Astrophysical Observation", "SAO 64040"},
        {"Wilson Evans Batten Catalogue", "WEB 12141"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.10158657),
        dec: Angle.Degrees(+39.74469367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105117",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14828 AB"},
        {"Henry Draper", "HD 202879"},
        {"Hipparcos Number", "HIP 105117"},
        {"Smithsonian Astrophysical Observation", "SAO 71170"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.40327037),
        dec: Angle.Degrees(+39.74615626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115277"},
        {"Smithsonian Astrophysical Observation", "SAO 73189"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.21982529),
        dec: Angle.Degrees(+39.74636234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197771"},
        {"Hipparcos Number", "HIP 102360"},
        {"Smithsonian Astrophysical Observation", "SAO 70445"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.09988728),
        dec: Angle.Degrees(+39.74903647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105237",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14850 A"},
        {"Henry Draper", "HD 203112"},
        {"Hipparcos Number", "HIP 105237"},
        {"Celescope Catalog", "CEL 5292"},
        {"Geneva Identification System", "GEN# +1.00203112"},
        {"Smithsonian Astrophysical Observation", "SAO 71195"},
    },
    visualMagnitude: 6.68,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.75011223),
        dec: Angle.Degrees(+39.74932359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44450"},
        {"Hipparcos Number", "HIP 30427"},
        {"Smithsonian Astrophysical Observation", "SAO 59035"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.96321934),
        dec: Angle.Degrees(+39.74965933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191395"},
        {"Hipparcos Number", "HIP 99181"},
        {"Geneva Identification System", "GEN# +1.00191395"},
        {"Smithsonian Astrophysical Observation", "SAO 69477"},
        {"Wilson Evans Batten Catalogue", "WEB 17656"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.03246334),
        dec: Angle.Degrees(+39.75080989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160821"},
        {"Hipparcos Number", "HIP 86473"},
        {"Smithsonian Astrophysical Observation", "SAO 66237"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.02951540),
        dec: Angle.Degrees(+39.75154092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112431"},
        {"Hipparcos Number", "HIP 63135"},
        {"Geneva Identification System", "GEN# +1.00112431"},
        {"Renson", "Renson 32660"},
        {"Smithsonian Astrophysical Observation", "SAO 44391"},
        {"Wilson Evans Batten Catalogue", "WEB 11194"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.04701168),
        dec: Angle.Degrees(+39.75368130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45720"},
        {"Hipparcos Number", "HIP 31058"},
        {"Smithsonian Astrophysical Observation", "SAO 59164"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.76291694),
        dec: Angle.Degrees(+39.75469053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34286"},
        {"Smithsonian Astrophysical Observation", "SAO 59776"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.62145017),
        dec: Angle.Degrees(+39.75753645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83805"},
        {"Hipparcos Number", "HIP 47570"},
        {"Fundamental Katalog 5th Edition", "FK5 2773"},
        {"Geneva Identification System", "GEN# +1.00083805"},
        {"Smithsonian Astrophysical Observation", "SAO 61636"},
        {"Wilson Evans Batten Catalogue", "WEB 8920"},
    },
    visualMagnitude: 5.61,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.50158521),
        dec: Angle.Degrees(+39.75796859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81609"},
        {"Smithsonian Astrophysical Observation", "SAO 65473"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.01588551),
        dec: Angle.Degrees(+39.75908005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12743"},
        {"Hipparcos Number", "HIP 9779"},
        {"Geneva Identification System", "GEN# +1.00012743"},
        {"Smithsonian Astrophysical Observation", "SAO 55257"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.44279422),
        dec: Angle.Degrees(+39.75981521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115434",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115434"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.73870061),
        dec: Angle.Degrees(+39.76144513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90747"},
        {"Hipparcos Number", "HIP 51361"},
        {"Smithsonian Astrophysical Observation", "SAO 43360"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.36162249),
        dec: Angle.Degrees(+39.76902931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54392",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54392"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.94382923),
        dec: Angle.Degrees(+39.76997154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72861"},
        {"Hipparcos Number", "HIP 42238"},
        {"Smithsonian Astrophysical Observation", "SAO 60918"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.16895528),
        dec: Angle.Degrees(+39.77053296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63366"},
        {"Hipparcos Number", "HIP 38257"},
        {"Smithsonian Astrophysical Observation", "SAO 60369"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.55633485),
        dec: Angle.Degrees(+39.77078432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60616"},
        {"Hipparcos Number", "HIP 37075"},
        {"Smithsonian Astrophysical Observation", "SAO 60226"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.27739788),
        dec: Angle.Degrees(+39.77261336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33103"},
        {"Smithsonian Astrophysical Observation", "SAO 59583"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.42323373),
        dec: Angle.Degrees(+39.77551334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211275"},
        {"Hipparcos Number", "HIP 109881"},
        {"Geneva Identification System", "GEN# +1.00211275"},
        {"Smithsonian Astrophysical Observation", "SAO 72176"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.82323913),
        dec: Angle.Degrees(+39.77629652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 230.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80692",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80692"},
        {"Geneva Identification System", "GEN# +0.04003020"},
        {"Smithsonian Astrophysical Observation", "SAO 65324"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.13700157),
        dec: Angle.Degrees(+39.77664652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176410"},
        {"Hipparcos Number", "HIP 93146"},
        {"Smithsonian Astrophysical Observation", "SAO 67658"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.61319376),
        dec: Angle.Degrees(+39.77803994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111259",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16031 A"},
        {"Henry Draper", "HD 213660"},
        {"Hipparcos Number", "HIP 111259"},
        {"Celescope Catalog", "CEL 5483"},
        {"Fundamental Katalog 5th Edition", "FK5 3805"},
        {"Geneva Identification System", "GEN# +1.00213660"},
        {"Smithsonian Astrophysical Observation", "SAO 72446"},
        {"Wilson Evans Batten Catalogue", "WEB 19905"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.10989375),
        dec: Angle.Degrees(+39.77975511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6834"},
        {"Hipparcos Number", "HIP 5441"},
        {"Geneva Identification System", "GEN# +1.00006834"},
        {"Smithsonian Astrophysical Observation", "SAO 54467"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.39694344),
        dec: Angle.Degrees(+39.78114016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142829"},
        {"Hipparcos Number", "HIP 77950"},
        {"Smithsonian Astrophysical Observation", "SAO 64971"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.77878664),
        dec: Angle.Degrees(+39.78274536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31227",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5167 AB"},
        {"Henry Draper", "HD 46049"},
        {"Hipparcos Number", "HIP 31227"},
        {"Smithsonian Astrophysical Observation", "SAO 59207"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.24933188),
        dec: Angle.Degrees(+39.78464291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46923"},
        {"Hipparcos Number", "HIP 31708"},
        {"Smithsonian Astrophysical Observation", "SAO 59303"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.48938906),
        dec: Angle.Degrees(+39.78527810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78697"},
        {"Hipparcos Number", "HIP 45073"},
        {"Geneva Identification System", "GEN# +1.00078697"},
        {"Smithsonian Astrophysical Observation", "SAO 61307"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.71291992),
        dec: Angle.Degrees(+39.78778126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29458"},
        {"Hipparcos Number", "HIP 21738"},
        {"Smithsonian Astrophysical Observation", "SAO 57364"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.02135136),
        dec: Angle.Degrees(+39.78851345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34535"},
        {"Hipparcos Number", "HIP 24884"},
        {"Smithsonian Astrophysical Observation", "SAO 57901"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.01911958),
        dec: Angle.Degrees(+39.78964930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198436"},
        {"Hipparcos Number", "HIP 102731"},
        {"Celescope Catalog", "CEL 5174"},
        {"Geneva Identification System", "GEN# +1.00198436A"},
        {"Smithsonian Astrophysical Observation", "SAO 70541"},
        {"Wilson Evans Batten Catalogue", "WEB 18626"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.25266026),
        dec: Angle.Degrees(+39.79164682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217209"},
        {"Hipparcos Number", "HIP 113455"},
        {"Geneva Identification System", "GEN# +1.00217209"},
        {"Smithsonian Astrophysical Observation", "SAO 72897"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.65580382),
        dec: Angle.Degrees(+39.79272699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211695"},
        {"Hipparcos Number", "HIP 110096"},
        {"Smithsonian Astrophysical Observation", "SAO 72220"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.52941241),
        dec: Angle.Degrees(+39.79295648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194670"},
        {"Hipparcos Number", "HIP 100741"},
        {"Celescope Catalog", "CEL 5057"},
        {"Geneva Identification System", "GEN# +1.00194670"},
        {"Smithsonian Astrophysical Observation", "SAO 69999"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.36906424),
        dec: Angle.Degrees(+39.79351784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110986"},
        {"Hipparcos Number", "HIP 62269"},
        {"Geneva Identification System", "GEN# +1.00110986"},
        {"Smithsonian Astrophysical Observation", "SAO 44321"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.40914560),
        dec: Angle.Degrees(+39.79483118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96197"},
        {"Hipparcos Number", "HIP 54267"},
        {"Geneva Identification System", "GEN# +1.00096197"},
        {"Smithsonian Astrophysical Observation", "SAO 43610"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.52826633),
        dec: Angle.Degrees(+39.79523945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275867"},
        {"Hipparcos Number", "HIP 18090"},
        {"Smithsonian Astrophysical Observation", "SAO 56759"},
        {"Wilson Evans Batten Catalogue", "WEB 3491"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.00114328),
        dec: Angle.Degrees(+39.79581850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114214",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16527 AB"},
        {"Henry Draper", "HD 218453"},
        {"Hipparcos Number", "HIP 114214"},
        {"Smithsonian Astrophysical Observation", "SAO 73019"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.94942428),
        dec: Angle.Degrees(+39.79630420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107852"},
        {"Hipparcos Number", "HIP 60437"},
        {"Geneva Identification System", "GEN# +1.00107852"},
        {"Smithsonian Astrophysical Observation", "SAO 44154"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.86717849),
        dec: Angle.Degrees(+39.79638791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191529"},
        {"Hipparcos Number", "HIP 99248"},
        {"Celescope Catalog", "CEL 4948"},
        {"Smithsonian Astrophysical Observation", "SAO 69502"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.20211404),
        dec: Angle.Degrees(+39.79833965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61317"},
        {"Hipparcos Number", "HIP 37374"},
        {"Smithsonian Astrophysical Observation", "SAO 60258"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.08509035),
        dec: Angle.Degrees(+39.79892300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107030"},
        {"Hipparcos Number", "HIP 60008"},
        {"Geneva Identification System", "GEN# +1.00107030"},
        {"Smithsonian Astrophysical Observation", "SAO 44115"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.60289827),
        dec: Angle.Degrees(+39.80136679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207992"},
        {"Hipparcos Number", "HIP 107958"},
        {"Cincinnati Publication", "Ci 20 1319"},
        {"Cincinnati Publication 2", "Ci 18 2845"},
        {"Geneva Identification System", "GEN# +1.00207992"},
        {"Smithsonian Astrophysical Observation", "SAO 71788"},
        {"Wilson Evans Batten Catalogue", "WEB 19468"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.08054635),
        dec: Angle.Degrees(+39.80171233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 436.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145956"},
        {"Hipparcos Number", "HIP 79381"},
        {"Smithsonian Astrophysical Observation", "SAO 65136"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.01236811),
        dec: Angle.Degrees(+39.80188114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76382",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9716 AB"},
        {"Henry Draper", "HD 139341"},
        {"Hipparcos Number", "HIP 76382"},
        {"Cincinnati Publication", "Ci 20 940"},
        {"Cincinnati Publication 2", "Ci 18 2087"},
        {"Geneva Identification System", "GEN# +1.00139341J"},
        {"Smithsonian Astrophysical Observation", "SAO 64800"},
        {"Wilson Evans Batten Catalogue", "WEB 12968"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.01078571),
        dec: Angle.Degrees(+39.80240648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -482.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111180"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.84690411),
        dec: Angle.Degrees(+39.80389604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101759"},
        {"Smithsonian Astrophysical Observation", "SAO 70294"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.35662695),
        dec: Angle.Degrees(+39.80611979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33842"},
        {"Smithsonian Astrophysical Observation", "SAO 59699"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.38201603),
        dec: Angle.Degrees(+39.80682430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212978"},
        {"Hipparcos Number", "HIP 110849"},
        {"Geneva Identification System", "GEN# +1.00212978"},
        {"Smithsonian Astrophysical Observation", "SAO 72358"},
        {"Wilson Evans Batten Catalogue", "WEB 19852"},
    },
    visualMagnitude: 6.16,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.86041347),
        dec: Angle.Degrees(+39.81004053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216038"},
        {"Hipparcos Number", "HIP 112665"},
        {"Smithsonian Astrophysical Observation", "SAO 72753"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.24761463),
        dec: Angle.Degrees(+39.81179056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94735"},
        {"Hipparcos Number", "HIP 53508"},
        {"Smithsonian Astrophysical Observation", "SAO 43536"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.19060976),
        dec: Angle.Degrees(+39.81206266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29030"},
        {"Smithsonian Astrophysical Observation", "SAO 58761"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.87458570),
        dec: Angle.Degrees(+39.81264781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28059"},
        {"Smithsonian Astrophysical Observation", "SAO 58576"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.99484183),
        dec: Angle.Degrees(+39.81444079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57726"},
        {"Geneva Identification System", "GEN# +0.04002471"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.57503951),
        dec: Angle.Degrees(+39.81839847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43701"},
        {"Hipparcos Number", "HIP 30059"},
        {"Geneva Identification System", "GEN# +1.00043701"},
        {"Smithsonian Astrophysical Observation", "SAO 58983"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.89953441),
        dec: Angle.Degrees(+39.81844242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182592"},
        {"Hipparcos Number", "HIP 95339"},
        {"Smithsonian Astrophysical Observation", "SAO 68249"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.94201618),
        dec: Angle.Degrees(+39.81909022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143596"},
        {"Hipparcos Number", "HIP 78344"},
        {"Smithsonian Astrophysical Observation", "SAO 65012"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.95512169),
        dec: Angle.Degrees(+39.82038618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146211"},
        {"Hipparcos Number", "HIP 79506"},
        {"Smithsonian Astrophysical Observation", "SAO 65159"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.36517692),
        dec: Angle.Degrees(+39.82438769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30531"},
        {"Hipparcos Number", "HIP 22487"},
        {"Smithsonian Astrophysical Observation", "SAO 57448"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.56679033),
        dec: Angle.Degrees(+39.82466332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36041"},
        {"Hipparcos Number", "HIP 25810"},
        {"Geneva Identification System", "GEN# +1.00036041A"},
        {"Smithsonian Astrophysical Observation", "SAO 58129"},
        {"Wilson Evans Batten Catalogue", "WEB 5012"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.68777820),
        dec: Angle.Degrees(+39.82600304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59904"},
        {"Smithsonian Astrophysical Observation", "SAO 44106"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.30991038),
        dec: Angle.Degrees(+39.82751075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36027"},
        {"Hipparcos Number", "HIP 25802"},
        {"Geneva Identification System", "GEN# +1.00036041B"},
        {"Smithsonian Astrophysical Observation", "SAO 58126"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.66048560),
        dec: Angle.Degrees(+39.82832653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14807"},
        {"Hipparcos Number", "HIP 11206"},
        {"Geneva Identification System", "GEN# +1.00014807"},
        {"Smithsonian Astrophysical Observation", "SAO 55516"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.06908029),
        dec: Angle.Degrees(+39.82884446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193946"},
        {"Hipparcos Number", "HIP 100391"},
        {"Geneva Identification System", "GEN# +1.00193946"},
        {"Smithsonian Astrophysical Observation", "SAO 69895"},
        {"Wilson Evans Batten Catalogue", "WEB 18119"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.38635762),
        dec: Angle.Degrees(+39.82934238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113713",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113713"},
        {"Smithsonian Astrophysical Observation", "SAO 72939"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.45175094),
        dec: Angle.Degrees(+39.82957994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2092"},
        {"Hipparcos Number", "HIP 2008"},
        {"Smithsonian Astrophysical Observation", "SAO 53879"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.35237362),
        dec: Angle.Degrees(+39.82984292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76375",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9716 C"},
        {"Henry Draper", "HD 139323"},
        {"Hipparcos Number", "HIP 76375"},
        {"Cincinnati Publication", "Ci 18 2086"},
        {"Cincinnati Publication 2", "Ci 20 939"},
        {"Geneva Identification System", "GEN# +1.00139323"},
        {"Geneva Identification System 2", "GEN# +1.00139341C"},
        {"Smithsonian Astrophysical Observation", "SAO 64799"},
        {"Wilson Evans Batten Catalogue", "WEB 12966"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.98711299),
        dec: Angle.Degrees(+39.83099529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -448.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117663"},
        {"Smithsonian Astrophysical Observation", "SAO 73562"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.94154359),
        dec: Angle.Degrees(+39.83270429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14272"},
        {"Hipparcos Number", "HIP 10848"},
        {"Celescope Catalog", "CEL 254"},
        {"Geneva Identification System", "GEN# +1.00014272"},
        {"Smithsonian Astrophysical Observation", "SAO 55453"},
        {"Wilson Evans Batten Catalogue", "WEB 2289"},
    },
    visualMagnitude: 6.63,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.90525263),
        dec: Angle.Degrees(+39.83498139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48045"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.91124278),
        dec: Angle.Degrees(+39.83569605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276455"},
        {"Hipparcos Number", "HIP 20983"},
        {"Smithsonian Astrophysical Observation", "SAO 57256"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.50306626),
        dec: Angle.Degrees(+39.83646181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9700"},
        {"Hipparcos Number", "HIP 7432"},
        {"Smithsonian Astrophysical Observation", "SAO 54813"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.93383442),
        dec: Angle.Degrees(+39.83657561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275800"},
        {"Hipparcos Number", "HIP 17723"},
        {"Geneva Identification System", "GEN# +1.00275800"},
        {"Smithsonian Astrophysical Observation", "SAO 56704"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.92948367),
        dec: Angle.Degrees(+39.83709127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84388"},
        {"Hipparcos Number", "HIP 47934"},
        {"Geneva Identification System", "GEN# +1.00084388"},
        {"Smithsonian Astrophysical Observation", "SAO 43023"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.52267999),
        dec: Angle.Degrees(+39.83799077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194576"},
        {"Hipparcos Number", "HIP 100702"},
        {"Smithsonian Astrophysical Observation", "SAO 69995"},
        {"Wilson Evans Batten Catalogue", "WEB 18199"},
    },
    visualMagnitude: 8.67,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.24494461),
        dec: Angle.Degrees(+39.83937442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39765",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39765"},
        {"Smithsonian Astrophysical Observation", "SAO 60576"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.91293846),
        dec: Angle.Degrees(+39.84175898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113710"},
    },
    visualMagnitude: 11.41,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.44337267),
        dec: Angle.Degrees(+39.84341627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94497",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94497"},
        {"Smithsonian Astrophysical Observation", "SAO 68018"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.49510594),
        dec: Angle.Degrees(+39.84371444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112814"},
        {"Hipparcos Number", "HIP 63356"},
        {"Geneva Identification System", "GEN# +1.00112814"},
        {"Smithsonian Astrophysical Observation", "SAO 44408"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.73642897),
        dec: Angle.Degrees(+39.84425589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176869"},
        {"Hipparcos Number", "HIP 93329"},
        {"Celescope Catalog", "CEL 4684"},
        {"Geneva Identification System", "GEN# +1.00176869"},
        {"Smithsonian Astrophysical Observation", "SAO 67695"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.14260154),
        dec: Angle.Degrees(+39.84494351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111574"},
        {"Hipparcos Number", "HIP 62620"},
        {"Geneva Identification System", "GEN# +1.00111574"},
        {"Smithsonian Astrophysical Observation", "SAO 44345"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.47032250),
        dec: Angle.Degrees(+39.84528195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67804",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67804"},
        {"Geneva Identification System", "GEN# +0.04002703"},
        {"Smithsonian Astrophysical Observation", "SAO 44788"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.35693789),
        dec: Angle.Degrees(+39.84825987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207220"},
        {"Hipparcos Number", "HIP 107506"},
        {"Smithsonian Astrophysical Observation", "SAO 71684"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.60631964),
        dec: Angle.Degrees(+39.85064851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32849"},
        {"Hipparcos Number", "HIP 23878"},
        {"Smithsonian Astrophysical Observation", "SAO 57659"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.96963014),
        dec: Angle.Degrees(+39.85172985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155559"},
        {"Hipparcos Number", "HIP 84022"},
        {"Geneva Identification System", "GEN# +1.00155559"},
        {"Smithsonian Astrophysical Observation", "SAO 65845"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.63369182),
        dec: Angle.Degrees(+39.85185719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111858",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 11.89,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)39, 28.7100),
        dec: Angle.DegreesMinutesSeconds((int)+39, (int)51, 18.200)
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
    primaryId: "HIP 82801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153032"},
        {"Hipparcos Number", "HIP 82801"},
        {"Geneva Identification System", "GEN# +1.00153032"},
        {"Smithsonian Astrophysical Observation", "SAO 65657"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.84238541),
        dec: Angle.Degrees(+39.85614324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43333"},
        {"Hipparcos Number", "HIP 29886"},
        {"Fundamental Katalog 5th Edition", "FK5 4569"},
        {"Geneva Identification System", "GEN# +1.00043333"},
        {"Smithsonian Astrophysical Observation", "SAO 58942"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.40016035),
        dec: Angle.Degrees(+39.85845995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34050"},
        {"Hipparcos Number", "HIP 24583"},
        {"Smithsonian Astrophysical Observation", "SAO 57815"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.11334193),
        dec: Angle.Degrees(+39.85862184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109537",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109537"},
    },
    visualMagnitude: 11.11,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.82130935),
        dec: Angle.Degrees(+41.01466674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 231.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33424",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33424"},
        {"Smithsonian Astrophysical Observation", "SAO 59630"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.25874785),
        dec: Angle.Degrees(+39.85919463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275931"},
        {"Hipparcos Number", "HIP 18313"},
        {"Smithsonian Astrophysical Observation", "SAO 56807"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.73294307),
        dec: Angle.Degrees(+39.85971108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53171"},
        {"Hipparcos Number", "HIP 34242"},
        {"Fundamental Katalog 5th Edition", "FK5 4640"},
        {"Geneva Identification System", "GEN# +1.00053171"},
        {"Smithsonian Astrophysical Observation", "SAO 59764"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.48664603),
        dec: Angle.Degrees(+39.86223626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107934"},
        {"Hipparcos Number", "HIP 60495"},
        {"Geneva Identification System", "GEN# +1.00107934"},
        {"Smithsonian Astrophysical Observation", "SAO 44159"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.03277516),
        dec: Angle.Degrees(+39.86320543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46560"},
        {"Smithsonian Astrophysical Observation", "SAO 42890"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.42682026),
        dec: Angle.Degrees(+39.86568242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176895"},
        {"Hipparcos Number", "HIP 93335"},
        {"Geneva Identification System", "GEN# +1.00176895"},
        {"Smithsonian Astrophysical Observation", "SAO 67697"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.14885091),
        dec: Angle.Degrees(+39.86626740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195990"},
        {"Hipparcos Number", "HIP 101413"},
        {"Celescope Catalog", "CEL 5109"},
        {"Geneva Identification System", "GEN# +1.00195990"},
        {"Smithsonian Astrophysical Observation", "SAO 70187"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.28036432),
        dec: Angle.Degrees(+39.86689650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116286"},
        {"Hipparcos Number", "HIP 65231"},
        {"Smithsonian Astrophysical Observation", "SAO 44581"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.51742676),
        dec: Angle.Degrees(+39.86884136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63401"},
        {"Geneva Identification System", "GEN# +0.04002601"},
        {"Smithsonian Astrophysical Observation", "SAO 44414"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.87946723),
        dec: Angle.Degrees(+39.86915855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44646",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44646"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.46156475),
        dec: Angle.Degrees(+39.86943832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55103"},
        {"Smithsonian Astrophysical Observation", "SAO 43678"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.22530432),
        dec: Angle.Degrees(+39.87054758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47933",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47933"},
        {"Smithsonian Astrophysical Observation", "SAO 43025"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.52161483),
        dec: Angle.Degrees(+39.87096349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179459"},
        {"Hipparcos Number", "HIP 94232"},
        {"Smithsonian Astrophysical Observation", "SAO 67931"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.73819419),
        dec: Angle.Degrees(+39.87344235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28393"},
        {"Hipparcos Number", "HIP 21017"},
        {"Smithsonian Astrophysical Observation", "SAO 57261"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.60315907),
        dec: Angle.Degrees(+39.87398597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29911"},
        {"Hipparcos Number", "HIP 22050"},
        {"Smithsonian Astrophysical Observation", "SAO 57397"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.13736809),
        dec: Angle.Degrees(+39.87556381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108101"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.54279157),
        dec: Angle.Degrees(+39.87721494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40382"},
        {"Hipparcos Number", "HIP 28443"},
        {"Geneva Identification System", "GEN# +1.00040382"},
        {"Smithsonian Astrophysical Observation", "SAO 58643"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.08713220),
        dec: Angle.Degrees(+39.87726687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68261"},
        {"Geneva Identification System", "GEN# +0.04002710"},
        {"Smithsonian Astrophysical Observation", "SAO 44821"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.60815339),
        dec: Angle.Degrees(+39.87772579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168954"},
        {"Hipparcos Number", "HIP 89891"},
        {"Geneva Identification System", "GEN# +1.00168954"},
        {"Smithsonian Astrophysical Observation", "SAO 66881"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.12860431),
        dec: Angle.Degrees(+39.87803953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223741"},
        {"Hipparcos Number", "HIP 117698"},
        {"Geneva Identification System", "GEN# +1.00223741"},
        {"Smithsonian Astrophysical Observation", "SAO 73569"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.04586850),
        dec: Angle.Degrees(+39.88029319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11474"},
        {"Hipparcos Number", "HIP 8838"},
        {"Geneva Identification System", "GEN# +1.00011474"},
        {"Smithsonian Astrophysical Observation", "SAO 55066"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.41191609),
        dec: Angle.Degrees(+39.88303564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166656"},
        {"Hipparcos Number", "HIP 88997"},
        {"Geneva Identification System", "GEN# +1.00166656"},
        {"Smithsonian Astrophysical Observation", "SAO 66704"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.46960176),
        dec: Angle.Degrees(+39.88309401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112831"},
    },
    visualMagnitude: 11.38,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.74356883),
        dec: Angle.Degrees(+39.88408123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2651"},
        {"Smithsonian Astrophysical Observation", "SAO 53986"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.40340120),
        dec: Angle.Degrees(+39.88423972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69750"},
        {"Hipparcos Number", "HIP 40823"},
        {"Smithsonian Astrophysical Observation", "SAO 42293"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.98260136),
        dec: Angle.Degrees(+39.88471556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228834"},
        {"Hipparcos Number", "HIP 100085"},
        {"Smithsonian Astrophysical Observation", "SAO 69798"},
        {"Wilson Evans Batten Catalogue", "WEB 18025"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.56521824),
        dec: Angle.Degrees(+39.88494382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75259"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.65907211),
        dec: Angle.Degrees(+39.88700771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 134.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74854"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.44982798),
        dec: Angle.Degrees(+39.88827454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80590",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10068 AB"},
        {"Henry Draper", "HD 148552"},
        {"Hipparcos Number", "HIP 80590"},
        {"Smithsonian Astrophysical Observation", "SAO 65315"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.81004391),
        dec: Angle.Degrees(+39.88865364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108298"},
        {"Hipparcos Number", "HIP 60698"},
        {"Geneva Identification System", "GEN# +1.00108298"},
        {"Smithsonian Astrophysical Observation", "SAO 44178"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.60221780),
        dec: Angle.Degrees(+39.88912453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64627"},
        {"Geneva Identification System", "GEN# +0.04002634"},
        {"Smithsonian Astrophysical Observation", "SAO 44526"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.70089144),
        dec: Angle.Degrees(+39.88975454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
