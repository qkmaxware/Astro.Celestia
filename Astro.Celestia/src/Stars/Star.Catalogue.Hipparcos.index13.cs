using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_13() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91593"},
        {"Hipparcos Number", "HIP 51662"},
        {"Celescope Catalog", "CEL 3573"},
        {"Geneva Identification System", "GEN# +1.00091593"},
        {"Smithsonian Astrophysical Observation", "SAO 238180"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.31954428),
        dec: Angle.Degrees(-55.38069580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180987"},
        {"Hipparcos Number", "HIP 95153"},
        {"Geneva Identification System", "GEN# +1.00180987"},
        {"Smithsonian Astrophysical Observation", "SAO 246045"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.39539051),
        dec: Angle.Degrees(-55.37790657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182141"},
        {"Hipparcos Number", "HIP 95563"},
        {"Smithsonian Astrophysical Observation", "SAO 246097"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.57692280),
        dec: Angle.Degrees(-55.37439553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188908"},
        {"Hipparcos Number", "HIP 98457"},
        {"Smithsonian Astrophysical Observation", "SAO 246378"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.06140347),
        dec: Angle.Degrees(-55.37361140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85871"},
        {"Hipparcos Number", "HIP 48469"},
        {"Celescope Catalog", "CEL 3396"},
        {"Geneva Identification System", "GEN# +1.00085871"},
        {"Smithsonian Astrophysical Observation", "SAO 237448"},
        {"Wilson Evans Batten Catalogue", "WEB 9037"},
    },
    visualMagnitude: 6.50,
    bvColour: -0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.25043836),
        dec: Angle.Degrees(-55.37321732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198131"},
        {"Hipparcos Number", "HIP 102882"},
        {"Smithsonian Astrophysical Observation", "SAO 246751"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.66427080),
        dec: Angle.Degrees(-55.37102031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92043"},
        {"Hipparcos Number", "HIP 51926"},
        {"Smithsonian Astrophysical Observation", "SAO 238241"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.10404680),
        dec: Angle.Degrees(-55.36698559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71405"},
        {"Hipparcos Number", "HIP 41223"},
        {"Smithsonian Astrophysical Observation", "SAO 235952"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.17081160),
        dec: Angle.Degrees(-55.36439008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71807"},
        {"Hipparcos Number", "HIP 41408"},
        {"Smithsonian Astrophysical Observation", "SAO 235986"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.69683225),
        dec: Angle.Degrees(-55.36291568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165986"},
        {"Hipparcos Number", "HIP 89152"},
        {"Smithsonian Astrophysical Observation", "SAO 245295"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.93000148),
        dec: Angle.Degrees(-55.36165011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123464"},
        {"Hipparcos Number", "HIP 69164"},
        {"Geneva Identification System", "GEN# +1.00123464"},
        {"Smithsonian Astrophysical Observation", "SAO 241487"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.36618203),
        dec: Angle.Degrees(-55.36153187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93821"},
        {"Hipparcos Number", "HIP 52878"},
        {"Geneva Identification System", "GEN# +1.00093821"},
        {"Renson", "Renson 27150"},
        {"Smithsonian Astrophysical Observation", "SAO 238505"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.20899862),
        dec: Angle.Degrees(-55.35942728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 299800"},
        {"Hipparcos Number", "HIP 43639"},
        {"Smithsonian Astrophysical Observation", "SAO 236376"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.32890774),
        dec: Angle.Degrees(-55.35917053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106014"},
        {"Hipparcos Number", "HIP 59498"},
        {"Geneva Identification System", "GEN# +1.00106014"},
        {"Smithsonian Astrophysical Observation", "SAO 239744"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.02622144),
        dec: Angle.Degrees(-55.35734499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114441"},
        {"Hipparcos Number", "HIP 64359"},
        {"Celescope Catalog", "CEL 4213"},
        {"Geneva Identification System", "GEN# +1.00114441"},
        {"Smithsonian Astrophysical Observation", "SAO 240636"},
        {"Wilson Evans Batten Catalogue", "WEB 11374"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.87303721),
        dec: Angle.Degrees(-55.35683729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179254"},
        {"Hipparcos Number", "HIP 94579"},
        {"Smithsonian Astrophysical Observation", "SAO 245987"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.72106833),
        dec: Angle.Degrees(-55.35678519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166891"},
        {"Hipparcos Number", "HIP 89496"},
        {"Geneva Identification System", "GEN# +1.00166891"},
        {"Smithsonian Astrophysical Observation", "SAO 245351"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.95316596),
        dec: Angle.Degrees(-55.35582133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96916"},
        {"Hipparcos Number", "HIP 54476"},
        {"Smithsonian Astrophysical Observation", "SAO 238814"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.18031942),
        dec: Angle.Degrees(-55.35436396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161419"},
        {"Hipparcos Number", "HIP 87167"},
        {"Smithsonian Astrophysical Observation", "SAO 245043"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.14501231),
        dec: Angle.Degrees(-55.35339455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123272"},
        {"Hipparcos Number", "HIP 69070"},
        {"Geneva Identification System", "GEN# +1.00123272"},
        {"Smithsonian Astrophysical Observation", "SAO 241470"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.07642557),
        dec: Angle.Degrees(-55.35240122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24332"},
        {"Hipparcos Number", "HIP 17885"},
        {"Smithsonian Astrophysical Observation", "SAO 233293"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.38526858),
        dec: Angle.Degrees(-55.34860742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113632"},
        {"Hipparcos Number", "HIP 63914"},
        {"Smithsonian Astrophysical Observation", "SAO 240539"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.46139245),
        dec: Angle.Degrees(-55.34823111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155241"},
        {"Hipparcos Number", "HIP 84257"},
        {"Geneva Identification System", "GEN# +1.00155241"},
        {"Smithsonian Astrophysical Observation", "SAO 244527"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.35164092),
        dec: Angle.Degrees(-55.34653466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134270"},
        {"Hipparcos Number", "HIP 74305"},
        {"Fundamental Katalog 5th Edition", "FK5 3198"},
        {"Geneva Identification System", "GEN# +1.00134270J"},
        {"Smithsonian Astrophysical Observation", "SAO 242287"},
        {"Wilson Evans Batten Catalogue", "WEB 12685"},
    },
    visualMagnitude: 5.45,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.81660117),
        dec: Angle.Degrees(-55.34601439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90244"},
        {"Hipparcos Number", "HIP 50906"},
        {"Smithsonian Astrophysical Observation", "SAO 238016"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.92414245),
        dec: Angle.Degrees(-55.34446563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47910"},
        {"Hipparcos Number", "HIP 31661"},
        {"Smithsonian Astrophysical Observation", "SAO 234623"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.40083776),
        dec: Angle.Degrees(-55.34379982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76214"},
        {"Hipparcos Number", "HIP 43571"},
        {"Celescope Catalog", "CEL 3028"},
        {"Geneva Identification System", "GEN# +1.00076214J"},
        {"Smithsonian Astrophysical Observation", "SAO 236358"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.10300188),
        dec: Angle.Degrees(-55.34167760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108868"},
        {"Hipparcos Number", "HIP 61055"},
        {"Geneva Identification System", "GEN# +1.00108868"},
        {"Smithsonian Astrophysical Observation", "SAO 240012"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.71306366),
        dec: Angle.Degrees(-55.34130518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115031"},
        {"Hipparcos Number", "HIP 64673"},
        {"Geneva Identification System", "GEN# +1.00115031"},
        {"Smithsonian Astrophysical Observation", "SAO 240681"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.83645956),
        dec: Angle.Degrees(-55.34126109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -231.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205979"},
        {"Hipparcos Number", "HIP 107043"},
        {"Smithsonian Astrophysical Observation", "SAO 247133"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.19060655),
        dec: Angle.Degrees(-55.33874135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89598"},
        {"Hipparcos Number", "HIP 50511"},
        {"Geneva Identification System", "GEN# +1.00089598"},
        {"Smithsonian Astrophysical Observation", "SAO 237906"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.74626828),
        dec: Angle.Degrees(-55.33645321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200284"},
        {"Hipparcos Number", "HIP 104049"},
        {"Smithsonian Astrophysical Observation", "SAO 246849"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.19170965),
        dec: Angle.Degrees(-55.33580458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48190"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.36489257),
        dec: Angle.Degrees(-55.33535366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82111"},
        {"Hipparcos Number", "HIP 46420"},
        {"Celescope Catalog", "CEL 3306"},
        {"Geneva Identification System", "GEN# +1.00082111"},
        {"Smithsonian Astrophysical Observation", "SAO 237007"},
    },
    visualMagnitude: 7.79,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.98874480),
        dec: Angle.Degrees(-55.33490625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200191"},
        {"Hipparcos Number", "HIP 103995"},
        {"Smithsonian Astrophysical Observation", "SAO 246842"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)04, 12.4800),
        dec: Angle.DegreesMinutesSeconds((int)-55, (int)20, 03.900)
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
    primaryId: "HIP 103996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200192"},
        {"Hipparcos Number", "HIP 103996"},
        {"Smithsonian Astrophysical Observation", "SAO 246843"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)04, 13.3100),
        dec: Angle.DegreesMinutesSeconds((int)-55, (int)19, 58.400)
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
    primaryId: "HIP 69440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124082"},
        {"Hipparcos Number", "HIP 69440"},
        {"Celescope Catalog", "CEL 4305"},
        {"Geneva Identification System", "GEN# +1.00124082"},
        {"Smithsonian Astrophysical Observation", "SAO 241534"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.24941275),
        dec: Angle.Degrees(-55.33238806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98719"},
        {"Hipparcos Number", "HIP 55422"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.24281735),
        dec: Angle.Degrees(-55.32884591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3075"},
        {"Hipparcos Number", "HIP 2642"},
        {"Smithsonian Astrophysical Observation", "SAO 232087"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.37375745),
        dec: Angle.Degrees(-55.32833837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180472"},
        {"Hipparcos Number", "HIP 94979"},
        {"Smithsonian Astrophysical Observation", "SAO 246027"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.91089469),
        dec: Angle.Degrees(-55.32548922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78789"},
        {"Hipparcos Number", "HIP 44809"},
        {"Smithsonian Astrophysical Observation", "SAO 236636"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.97532216),
        dec: Angle.Degrees(-55.32435119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119556"},
        {"Hipparcos Number", "HIP 67111"},
        {"Geneva Identification System", "GEN# +1.00119556"},
        {"Smithsonian Astrophysical Observation", "SAO 241137"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.33184883),
        dec: Angle.Degrees(-55.32367513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213685"},
        {"Hipparcos Number", "HIP 111421"},
        {"Smithsonian Astrophysical Observation", "SAO 247493"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.60320082),
        dec: Angle.Degrees(-55.32296040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89841"},
        {"Hipparcos Number", "HIP 50655"},
        {"Geneva Identification System", "GEN# +1.00089841"},
        {"Smithsonian Astrophysical Observation", "SAO 237949"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.17099334),
        dec: Angle.Degrees(-55.32140586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104704"},
        {"Hipparcos Number", "HIP 58782"},
        {"Smithsonian Astrophysical Observation", "SAO 239616"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.84277578),
        dec: Angle.Degrees(-55.32139977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71257"},
        {"Hipparcos Number", "HIP 41147"},
        {"Geneva Identification System", "GEN# +1.00071257"},
        {"Smithsonian Astrophysical Observation", "SAO 235943"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.92673102),
        dec: Angle.Degrees(-55.32040424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100015"},
        {"Hipparcos Number", "HIP 56095"},
        {"Smithsonian Astrophysical Observation", "SAO 239118"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.47898547),
        dec: Angle.Degrees(-55.31877750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28754"},
        {"Cincinnati Publication", "Ci 20 369"},
        {"Geneva Identification System", "GEN# +9.86181001"},
    },
    visualMagnitude: 12.14,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.08191622),
        dec: Angle.Degrees(-55.31384214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 679.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 341.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132668"},
        {"Hipparcos Number", "HIP 73598"},
        {"Geneva Identification System", "GEN# +1.00132668"},
        {"Smithsonian Astrophysical Observation", "SAO 242186"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.65370965),
        dec: Angle.Degrees(-55.31316707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62826"},
        {"Hipparcos Number", "HIP 37597"},
        {"Geneva Identification System", "GEN# +1.00062826"},
        {"Smithsonian Astrophysical Observation", "SAO 235437"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.71369207),
        dec: Angle.Degrees(-55.31286094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139717"},
        {"Hipparcos Number", "HIP 76918"},
        {"Geneva Identification System", "GEN# +1.00139717"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.58716892),
        dec: Angle.Degrees(-55.31192153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155760"},
        {"Hipparcos Number", "HIP 84508"},
        {"Smithsonian Astrophysical Observation", "SAO 244572"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.14433054),
        dec: Angle.Degrees(-55.31047171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172182"},
        {"Hipparcos Number", "HIP 91692"},
        {"Smithsonian Astrophysical Observation", "SAO 245638"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.46847918),
        dec: Angle.Degrees(-55.30157333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151611"},
        {"Hipparcos Number", "HIP 82490"},
        {"Smithsonian Astrophysical Observation", "SAO 244200"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.88655686),
        dec: Angle.Degrees(-55.29989134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210768"},
        {"Hipparcos Number", "HIP 109769"},
        {"Smithsonian Astrophysical Observation", "SAO 247366"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.50929239),
        dec: Angle.Degrees(-55.29909661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48188"},
        {"Hipparcos Number", "HIP 31804"},
        {"Geneva Identification System", "GEN# +1.00048188"},
        {"Smithsonian Astrophysical Observation", "SAO 234636"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.74091271),
        dec: Angle.Degrees(-55.29876917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150024"},
        {"Hipparcos Number", "HIP 81700"},
        {"Smithsonian Astrophysical Observation", "SAO 244063"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.33211801),
        dec: Angle.Degrees(-55.29777211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89007"},
        {"Hipparcos Number", "HIP 50179"},
        {"Geneva Identification System", "GEN# +1.00089007"},
        {"Smithsonian Astrophysical Observation", "SAO 237826"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.64167937),
        dec: Angle.Degrees(-55.29345419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201019"},
        {"Hipparcos Number", "HIP 104408"},
        {"Geneva Identification System", "GEN# +1.00201019"},
        {"Smithsonian Astrophysical Observation", "SAO 246886"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.26892120),
        dec: Angle.Degrees(-55.29340485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81804"},
        {"Hipparcos Number", "HIP 46251"},
        {"Celescope Catalog", "CEL 3291"},
        {"Geneva Identification System", "GEN# +1.00081804"},
        {"Smithsonian Astrophysical Observation", "SAO 236960"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.43940802),
        dec: Angle.Degrees(-55.28793277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97267"},
        {"Hipparcos Number", "HIP 54638"},
        {"Geneva Identification System", "GEN# +1.00097267"},
        {"Smithsonian Astrophysical Observation", "SAO 238840"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.75002947),
        dec: Angle.Degrees(-55.28228300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223224"},
        {"Hipparcos Number", "HIP 117369"},
        {"Geneva Identification System", "GEN# +1.00223224"},
        {"Smithsonian Astrophysical Observation", "SAO 248021"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.96878546),
        dec: Angle.Degrees(-55.28128890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4741"},
        {"Smithsonian Astrophysical Observation", "SAO 232260"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.22363543),
        dec: Angle.Degrees(-55.28092978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204519"},
        {"Hipparcos Number", "HIP 106247"},
        {"Geneva Identification System", "GEN# +1.00204519"},
        {"Smithsonian Astrophysical Observation", "SAO 247060"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.79585775),
        dec: Angle.Degrees(-55.28085135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57554"},
        {"Hipparcos Number", "HIP 35418"},
        {"Smithsonian Astrophysical Observation", "SAO 235088"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.69059419),
        dec: Angle.Degrees(-55.28064395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14181"},
        {"Hipparcos Number", "HIP 10547"},
        {"Geneva Identification System", "GEN# +1.00014181"},
        {"Smithsonian Astrophysical Observation", "SAO 232690"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.96205735),
        dec: Angle.Degrees(-55.27912311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110518"},
        {"Hipparcos Number", "HIP 62069"},
        {"Smithsonian Astrophysical Observation", "SAO 240182"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.81420029),
        dec: Angle.Degrees(-55.27744794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146378"},
        {"Hipparcos Number", "HIP 79935"},
        {"Smithsonian Astrophysical Observation", "SAO 243595"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.72232293),
        dec: Angle.Degrees(-55.27149296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85485"},
        {"Hipparcos Number", "HIP 48259"},
        {"Smithsonian Astrophysical Observation", "SAO 237392"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.57290431),
        dec: Angle.Degrees(-55.27125541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185349"},
        {"Hipparcos Number", "HIP 96884"},
        {"Fundamental Katalog 5th Edition", "FK5 5734"},
        {"Smithsonian Astrophysical Observation", "SAO 246216"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.40888646),
        dec: Angle.Degrees(-55.26613673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217504"},
        {"Hipparcos Number", "HIP 113733"},
        {"Smithsonian Astrophysical Observation", "SAO 247689"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.49843866),
        dec: Angle.Degrees(-55.26514402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100014"},
        {"Hipparcos Number", "HIP 56097"},
        {"Geneva Identification System", "GEN# +1.00100014"},
        {"Smithsonian Astrophysical Observation", "SAO 239120"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.48753707),
        dec: Angle.Degrees(-55.26414646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126284"},
        {"Hipparcos Number", "HIP 70592"},
        {"Smithsonian Astrophysical Observation", "SAO 241713"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.59284224),
        dec: Angle.Degrees(-55.25919799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51608"},
        {"Hipparcos Number", "HIP 33229"},
        {"Geneva Identification System", "GEN# +1.00051608"},
        {"Smithsonian Astrophysical Observation", "SAO 234781"},
        {"Wilson Evans Batten Catalogue", "WEB 6684"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.71403823),
        dec: Angle.Degrees(-55.25893804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118150"},
        {"Hipparcos Number", "HIP 66366"},
        {"Smithsonian Astrophysical Observation", "SAO 240988"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.05238282),
        dec: Angle.Degrees(-55.25760846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37349"},
        {"Hipparcos Number", "HIP 26165"},
        {"Smithsonian Astrophysical Observation", "SAO 234033"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.67741792),
        dec: Angle.Degrees(-55.25603562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104230"},
        {"Hipparcos Number", "HIP 58523"},
        {"Smithsonian Astrophysical Observation", "SAO 239564"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.02923613),
        dec: Angle.Degrees(-55.25498983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213701"},
        {"Hipparcos Number", "HIP 111439"},
        {"Smithsonian Astrophysical Observation", "SAO 247495"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.64114987),
        dec: Angle.Degrees(-55.25416316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66866"},
        {"Hipparcos Number", "HIP 39350"},
        {"Smithsonian Astrophysical Observation", "SAO 235708"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.65373929),
        dec: Angle.Degrees(-55.25353769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80881"},
        {"Hipparcos Number", "HIP 45784"},
        {"Smithsonian Astrophysical Observation", "SAO 236859"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.02487741),
        dec: Angle.Degrees(-55.25323963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172518"},
        {"Hipparcos Number", "HIP 91873"},
        {"Geneva Identification System", "GEN# +1.00172518"},
        {"Smithsonian Astrophysical Observation", "SAO 245659"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.94186693),
        dec: Angle.Degrees(-55.25318716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115434"},
        {"Hipparcos Number", "HIP 64899"},
        {"Smithsonian Astrophysical Observation", "SAO 240717"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.53520372),
        dec: Angle.Degrees(-55.25226358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22120"},
        {"Hipparcos Number", "HIP 16409"},
        {"Fundamental Katalog 5th Edition", "FK5 2253"},
        {"Smithsonian Astrophysical Observation", "SAO 233144"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.82081882),
        dec: Angle.Degrees(-55.24925169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10283"},
        {"Hipparcos Number", "HIP 7698"},
        {"Smithsonian Astrophysical Observation", "SAO 232487"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.78015177),
        dec: Angle.Degrees(-55.24897550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222540"},
        {"Hipparcos Number", "HIP 116897"},
        {"Smithsonian Astrophysical Observation", "SAO 247982"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.42854789),
        dec: Angle.Degrees(-55.24773223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5348",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Wurren"},
        {"Henry Draper", "HD 6882"},
        {"Hipparcos Number", "HIP 5348"},
        {"Geneva Identification System", "GEN# +1.00006882"},
        {"Smithsonian Astrophysical Observation", "SAO 232306"},
        {"Wilson Evans Batten Catalogue", "WEB 1158"},
    },
    visualMagnitude: 3.94,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.09608370),
        dec: Angle.Degrees(-55.24583235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59370"},
        {"Hipparcos Number", "HIP 36146"},
        {"Smithsonian Astrophysical Observation", "SAO 235198"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.68168758),
        dec: Angle.Degrees(-55.24430809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26247"},
        {"Hipparcos Number", "HIP 19151"},
        {"Smithsonian Astrophysical Observation", "SAO 233398"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.57350359),
        dec: Angle.Degrees(-55.24419745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7479"},
        {"Hipparcos Number", "HIP 5758"},
        {"Smithsonian Astrophysical Observation", "SAO 232348"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.47488745),
        dec: Angle.Degrees(-55.24219106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8393"},
        {"Hipparcos Number", "HIP 6387"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.51768395),
        dec: Angle.Degrees(-55.24059052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103978"},
        {"Hipparcos Number", "HIP 58387"},
        {"Smithsonian Astrophysical Observation", "SAO 239537"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.58147061),
        dec: Angle.Degrees(-55.23951366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42587"},
        {"Hipparcos Number", "HIP 29098"},
        {"Smithsonian Astrophysical Observation", "SAO 234337"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.07115527),
        dec: Angle.Degrees(-55.23922979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47233"},
        {"Hipparcos Number", "HIP 31343"},
        {"Smithsonian Astrophysical Observation", "SAO 234585"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.58839227),
        dec: Angle.Degrees(-55.23920943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9934"},
        {"Hipparcos Number", "HIP 7429"},
        {"Geneva Identification System", "GEN# +1.00009934"},
        {"Smithsonian Astrophysical Observation", "SAO 232472"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.92425950),
        dec: Angle.Degrees(-55.23844148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 188.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215985"},
        {"Hipparcos Number", "HIP 112750"},
        {"Geneva Identification System", "GEN# +1.00215985"},
        {"Smithsonian Astrophysical Observation", "SAO 247605"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.50392253),
        dec: Angle.Degrees(-55.23409150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13850"},
        {"Smithsonian Astrophysical Observation", "SAO 232954"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.57431864),
        dec: Angle.Degrees(-55.23357849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223659"},
        {"Hipparcos Number", "HIP 117648"},
        {"Smithsonian Astrophysical Observation", "SAO 248040"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.89696472),
        dec: Angle.Degrees(-55.23314188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40364"},
        {"Hipparcos Number", "HIP 27977"},
        {"Smithsonian Astrophysical Observation", "SAO 234203"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.75081473),
        dec: Angle.Degrees(-55.23066442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192550"},
        {"Hipparcos Number", "HIP 100070"},
        {"Smithsonian Astrophysical Observation", "SAO 246519"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.53037912),
        dec: Angle.Degrees(-55.22766267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186423"},
        {"Hipparcos Number", "HIP 97352"},
        {"Geneva Identification System", "GEN# +1.00186423"},
        {"Smithsonian Astrophysical Observation", "SAO 246266"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.79210382),
        dec: Angle.Degrees(-55.22383802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207282"},
        {"Hipparcos Number", "HIP 107739"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.37814989),
        dec: Angle.Degrees(-55.22360740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75132"},
        {"Hipparcos Number", "HIP 42985"},
        {"Smithsonian Astrophysical Observation", "SAO 236250"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.40971552),
        dec: Angle.Degrees(-55.22348590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147606"},
        {"Hipparcos Number", "HIP 80482"},
        {"Smithsonian Astrophysical Observation", "SAO 243785"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.43434212),
        dec: Angle.Degrees(-55.22345174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198956"},
        {"Hipparcos Number", "HIP 103340"},
        {"Smithsonian Astrophysical Observation", "SAO 246797"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.04533447),
        dec: Angle.Degrees(-55.22244271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135090"},
        {"Hipparcos Number", "HIP 74677"},
        {"Smithsonian Astrophysical Observation", "SAO 242358"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.91833434),
        dec: Angle.Degrees(-55.22172418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70979"},
        {"Hipparcos Number", "HIP 41026"},
        {"Smithsonian Astrophysical Observation", "SAO 235925"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.59423803),
        dec: Angle.Degrees(-55.22169618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126655"},
        {"Hipparcos Number", "HIP 70796"},
        {"Smithsonian Astrophysical Observation", "SAO 241739"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.17408729),
        dec: Angle.Degrees(-55.22147936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147347"},
        {"Hipparcos Number", "HIP 80361"},
        {"Geneva Identification System", "GEN# +1.00147347"},
        {"Smithsonian Astrophysical Observation", "SAO 243748"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.06777769),
        dec: Angle.Degrees(-55.21952666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216056"},
        {"Hipparcos Number", "HIP 112798"},
        {"Smithsonian Astrophysical Observation", "SAO 247614"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.64151418),
        dec: Angle.Degrees(-55.21932957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214468"},
        {"Hipparcos Number", "HIP 111860"},
        {"Geneva Identification System", "GEN# +1.00214468"},
        {"Smithsonian Astrophysical Observation", "SAO 247534"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.87144533),
        dec: Angle.Degrees(-55.21658791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57041"},
        {"Hipparcos Number", "HIP 35203"},
        {"Geneva Identification System", "GEN# +1.00057041"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.13396678),
        dec: Angle.Degrees(-55.21656432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66339"},
        {"Hipparcos Number", "HIP 39119"},
        {"Smithsonian Astrophysical Observation", "SAO 235669"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.05225701),
        dec: Angle.Degrees(-55.21589423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96444"},
        {"Hipparcos Number", "HIP 54271"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.53418135),
        dec: Angle.Degrees(-55.21508041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28496"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.22802524),
        dec: Angle.Degrees(-34.22456469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84228"},
        {"Hipparcos Number", "HIP 47559"},
        {"Celescope Catalog", "CEL 3361"},
        {"Geneva Identification System", "GEN# +1.00084228"},
        {"Smithsonian Astrophysical Observation", "SAO 237237"},
    },
    visualMagnitude: 5.99,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.44974998),
        dec: Angle.Degrees(-55.21376962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146203"},
        {"Hipparcos Number", "HIP 79849"},
        {"Smithsonian Astrophysical Observation", "SAO 243552"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.46757272),
        dec: Angle.Degrees(-55.21141239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28493"},
        {"Hipparcos Number", "HIP 20733"},
        {"Smithsonian Astrophysical Observation", "SAO 233523"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.65233504),
        dec: Angle.Degrees(-55.20977494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116198"},
        {"Hipparcos Number", "HIP 65314"},
        {"Smithsonian Astrophysical Observation", "SAO 240792"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.79364202),
        dec: Angle.Degrees(-55.20955332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98052"},
        {"Hipparcos Number", "HIP 55036"},
        {"Geneva Identification System", "GEN# +1.00098052"},
        {"Smithsonian Astrophysical Observation", "SAO 238919"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.99774031),
        dec: Angle.Degrees(-55.20856148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106290"},
        {"Hipparcos Number", "HIP 59642"},
        {"Smithsonian Astrophysical Observation", "SAO 239769"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.47029652),
        dec: Angle.Degrees(-55.20746978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101929"},
        {"Hipparcos Number", "HIP 57182"},
        {"Smithsonian Astrophysical Observation", "SAO 239324"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.89494802),
        dec: Angle.Degrees(-55.19560259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92156"},
        {"Hipparcos Number", "HIP 51971"},
        {"Geneva Identification System", "GEN# +1.00092156"},
        {"Smithsonian Astrophysical Observation", "SAO 238259"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.27947401),
        dec: Angle.Degrees(-55.19532829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72322"},
        {"Hipparcos Number", "HIP 41653"},
        {"Geneva Identification System", "GEN# +1.00072322J"},
        {"Smithsonian Astrophysical Observation", "SAO 236032"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.40165094),
        dec: Angle.Degrees(-55.19090363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112620"},
        {"Hipparcos Number", "HIP 63337"},
        {"Smithsonian Astrophysical Observation", "SAO 240438"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.68678063),
        dec: Angle.Degrees(-55.18713855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80781"},
        {"Hipparcos Number", "HIP 45742"},
        {"Celescope Catalog", "CEL 3267"},
        {"Geneva Identification System", "GEN# +1.00080781"},
        {"Smithsonian Astrophysical Observation", "SAO 236851"},
        {"Wilson Evans Batten Catalogue", "WEB 8679"},
    },
    visualMagnitude: 6.28,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.88536568),
        dec: Angle.Degrees(-55.18649115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213830"},
        {"Hipparcos Number", "HIP 111501"},
        {"Geneva Identification System", "GEN# +1.00213830"},
        {"Smithsonian Astrophysical Observation", "SAO 247498"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.85826138),
        dec: Angle.Degrees(-55.18416189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129107"},
        {"Hipparcos Number", "HIP 71937"},
        {"Smithsonian Astrophysical Observation", "SAO 241929"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.69376543),
        dec: Angle.Degrees(-55.18180465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158829"},
        {"Hipparcos Number", "HIP 85993"},
        {"Smithsonian Astrophysical Observation", "SAO 244855"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.63003224),
        dec: Angle.Degrees(-55.17990485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103385"},
        {"Hipparcos Number", "HIP 58038"},
        {"Smithsonian Astrophysical Observation", "SAO 239474"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.54184031),
        dec: Angle.Degrees(-55.17963969)
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
    primaryId: "HIP 111851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214453"},
        {"Hipparcos Number", "HIP 111851"},
        {"Smithsonian Astrophysical Observation", "SAO 247532"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.85216774),
        dec: Angle.Degrees(-55.15384998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62663"},
        {"Hipparcos Number", "HIP 37533"},
        {"Smithsonian Astrophysical Observation", "SAO 235428"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.54847315),
        dec: Angle.Degrees(-55.17898205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194491"},
        {"Hipparcos Number", "HIP 100980"},
        {"Smithsonian Astrophysical Observation", "SAO 246597"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.10864764),
        dec: Angle.Degrees(-55.17746676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58403"},
        {"Hipparcos Number", "HIP 35743"},
        {"Geneva Identification System", "GEN# +1.00058403"},
        {"Smithsonian Astrophysical Observation", "SAO 235150"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.58895717),
        dec: Angle.Degrees(-55.17729524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221721"},
        {"Hipparcos Number", "HIP 116373"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.71595604),
        dec: Angle.Degrees(-55.17641513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3329"},
        {"Hipparcos Number", "HIP 2809"},
        {"Fundamental Katalog 5th Edition", "FK5 4052"},
        {"Smithsonian Astrophysical Observation", "SAO 232103"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.94037506),
        dec: Angle.Degrees(-55.17044592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191683"},
        {"Hipparcos Number", "HIP 99693"},
        {"Geneva Identification System", "GEN# +1.00191683"},
        {"Smithsonian Astrophysical Observation", "SAO 246491"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.45570206),
        dec: Angle.Degrees(-55.16968483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157819"},
        {"Hipparcos Number", "HIP 85520"},
        {"Geneva Identification System", "GEN# +1.00157819"},
        {"Smithsonian Astrophysical Observation", "SAO 244770"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.16213171),
        dec: Angle.Degrees(-55.16966503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217686"},
        {"Hipparcos Number", "HIP 113842"},
        {"Geneva Identification System", "GEN# +1.00217686"},
        {"Smithsonian Astrophysical Observation", "SAO 247699"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.81587751),
        dec: Angle.Degrees(-55.16848238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207428"},
        {"Hipparcos Number", "HIP 107825"},
        {"Smithsonian Astrophysical Observation", "SAO 247201"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.66590420),
        dec: Angle.Degrees(-55.16500559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163260"},
        {"Hipparcos Number", "HIP 87988"},
        {"Smithsonian Astrophysical Observation", "SAO 245144"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.60068108),
        dec: Angle.Degrees(-55.16285994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45700"},
        {"Hipparcos Number", "HIP 30590"},
        {"Smithsonian Astrophysical Observation", "SAO 234504"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.43002671),
        dec: Angle.Degrees(-55.16176005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20058"},
        {"Hipparcos Number", "HIP 14788"},
        {"Smithsonian Astrophysical Observation", "SAO 233026"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.74734598),
        dec: Angle.Degrees(-55.16170947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217"},
        {"Hipparcos Number", "HIP 568"},
        {"Fundamental Katalog 5th Edition", "FK5 4013"},
        {"Smithsonian Astrophysical Observation", "SAO 231928"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.72236956),
        dec: Angle.Degrees(-55.16079775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60734"},
        {"Hipparcos Number", "HIP 36702"},
        {"Geneva Identification System", "GEN# +1.00060734"},
        {"Smithsonian Astrophysical Observation", "SAO 235287"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.24566632),
        dec: Angle.Degrees(-55.15967585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 128.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150199"},
        {"Hipparcos Number", "HIP 81797"},
        {"Geneva Identification System", "GEN# +1.00150199"},
        {"Smithsonian Astrophysical Observation", "SAO 244077"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.60500446),
        dec: Angle.Degrees(-55.15942277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62622",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62622"},
    },
    visualMagnitude: 11.18,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)49, 54.6600),
        dec: Angle.DegreesMinutesSeconds((int)-54, (int)18, 25.900)
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
    primaryId: "HIP 56629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100940"},
        {"Hipparcos Number", "HIP 56629"},
        {"Smithsonian Astrophysical Observation", "SAO 239218"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.16770502),
        dec: Angle.Degrees(-55.15165520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112596"},
        {"Hipparcos Number", "HIP 63319"},
        {"Smithsonian Astrophysical Observation", "SAO 240434"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.63468133),
        dec: Angle.Degrees(-55.15030685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10372"},
        {"Hipparcos Number", "HIP 7753"},
        {"Smithsonian Astrophysical Observation", "SAO 232491"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.95385537),
        dec: Angle.Degrees(-55.14933883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174060"},
        {"Hipparcos Number", "HIP 92561"},
        {"Smithsonian Astrophysical Observation", "SAO 245755"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.92718018),
        dec: Angle.Degrees(-55.14728952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12525"},
        {"Hipparcos Number", "HIP 9439"},
        {"Smithsonian Astrophysical Observation", "SAO 232604"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.30821685),
        dec: Angle.Degrees(-55.14472519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188095"},
        {"Hipparcos Number", "HIP 98102"},
        {"Smithsonian Astrophysical Observation", "SAO 246342"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.05810773),
        dec: Angle.Degrees(-55.14348966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107079"},
        {"Hipparcos Number", "HIP 60059"},
        {"Fundamental Katalog 5th Edition", "FK5 2985"},
        {"Geneva Identification System", "GEN# +1.00107079"},
        {"Smithsonian Astrophysical Observation", "SAO 239838"},
        {"Wilson Evans Batten Catalogue", "WEB 10673"},
    },
    visualMagnitude: 5.01,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.74928553),
        dec: Angle.Degrees(-55.14297519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88970"},
        {"Hipparcos Number", "HIP 50158"},
        {"Celescope Catalog", "CEL 3477"},
        {"Geneva Identification System", "GEN# +1.00088970"},
        {"Smithsonian Astrophysical Observation", "SAO 237821"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.58191820),
        dec: Angle.Degrees(-55.14057501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178183"},
        {"Hipparcos Number", "HIP 94188"},
        {"Smithsonian Astrophysical Observation", "SAO 245952"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.63176615),
        dec: Angle.Degrees(-55.13971299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146690"},
        {"Hipparcos Number", "HIP 80054"},
        {"Geneva Identification System", "GEN# +1.00146690"},
        {"Smithsonian Astrophysical Observation", "SAO 243654"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.10512753),
        dec: Angle.Degrees(-55.13967135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94286"},
        {"Hipparcos Number", "HIP 53113"},
        {"Smithsonian Astrophysical Observation", "SAO 238543"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.99437748),
        dec: Angle.Degrees(-55.13835458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159286"},
        {"Hipparcos Number", "HIP 86200"},
        {"Renson", "Renson 44790"},
        {"Smithsonian Astrophysical Observation", "SAO 244885"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.23566322),
        dec: Angle.Degrees(-55.13784685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17854"},
        {"Hipparcos Number", "HIP 13203"},
        {"Smithsonian Astrophysical Observation", "SAO 232909"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.47956330),
        dec: Angle.Degrees(-55.13570825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196192"},
        {"Hipparcos Number", "HIP 101835"},
        {"Smithsonian Astrophysical Observation", "SAO 246669"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.55415040),
        dec: Angle.Degrees(-55.13253961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114476"},
        {"Hipparcos Number", "HIP 64377"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.91875590),
        dec: Angle.Degrees(-55.13253521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88640",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88640"},
    },
    visualMagnitude: 11.03,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.45933459),
        dec: Angle.Degrees(-53.70884647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144320"},
        {"Hipparcos Number", "HIP 79038"},
        {"Geneva Identification System", "GEN# +1.00144320"},
        {"Smithsonian Astrophysical Observation", "SAO 243347"},
        {"Wilson Evans Batten Catalogue", "WEB 13358"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.99908499),
        dec: Angle.Degrees(-55.13045296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202487"},
        {"Hipparcos Number", "HIP 105171"},
        {"Geneva Identification System", "GEN# +1.00202487"},
        {"Smithsonian Astrophysical Observation", "SAO 246953"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.57301761),
        dec: Angle.Degrees(-55.12968023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105736"},
        {"Hipparcos Number", "HIP 59340"},
        {"Geneva Identification System", "GEN# +1.00105736"},
        {"Smithsonian Astrophysical Observation", "SAO 239715"},
        {"Wilson Evans Batten Catalogue", "WEB 10555"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.59125059),
        dec: Angle.Degrees(-55.12829396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189803"},
        {"Hipparcos Number", "HIP 98868"},
        {"Smithsonian Astrophysical Observation", "SAO 246419"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.15927029),
        dec: Angle.Degrees(-55.12420326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72858"},
        {"Hipparcos Number", "HIP 41897"},
        {"Celescope Catalog", "CEL 2635"},
        {"Geneva Identification System", "GEN# +1.00072858"},
        {"Smithsonian Astrophysical Observation", "SAO 236073"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.14837931),
        dec: Angle.Degrees(-55.12359662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88642"},
        {"Geneva Identification System", "GEN# +6.20145009"},
    },
    visualMagnitude: 11.58,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.46542280),
        dec: Angle.Degrees(-55.12337622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125652"},
        {"Hipparcos Number", "HIP 70265"},
        {"Geneva Identification System", "GEN# +1.00125652"},
        {"Smithsonian Astrophysical Observation", "SAO 241675"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.65510075),
        dec: Angle.Degrees(-55.11970841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194702"},
        {"Hipparcos Number", "HIP 101103"},
        {"Geneva Identification System", "GEN# +1.00194702"},
        {"Smithsonian Astrophysical Observation", "SAO 246610"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.41645082),
        dec: Angle.Degrees(-55.11832751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156241"},
        {"Hipparcos Number", "HIP 84760"},
        {"Smithsonian Astrophysical Observation", "SAO 244623"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.87729552),
        dec: Angle.Degrees(-55.11648923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48945"},
        {"Hipparcos Number", "HIP 32156"},
        {"Smithsonian Astrophysical Observation", "SAO 234667"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.72350818),
        dec: Angle.Degrees(-55.11520595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92405"},
        {"Hipparcos Number", "HIP 52130"},
        {"Geneva Identification System", "GEN# +1.00092405"},
        {"Smithsonian Astrophysical Observation", "SAO 238301"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.75195631),
        dec: Angle.Degrees(-55.11377980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183028"},
        {"Hipparcos Number", "HIP 95932"},
        {"Geneva Identification System", "GEN# +1.00183028"},
        {"Smithsonian Astrophysical Observation", "SAO 246131"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.64405170),
        dec: Angle.Degrees(-55.11002087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64465"},
        {"Smithsonian Astrophysical Observation", "SAO 240652"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.19924885),
        dec: Angle.Degrees(-55.10862203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76412"},
        {"Hipparcos Number", "HIP 43657"},
        {"Smithsonian Astrophysical Observation", "SAO 236380"},
    },
    visualMagnitude: 8.65,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.40390963),
        dec: Angle.Degrees(-55.10681277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181819"},
        {"Hipparcos Number", "HIP 95448"},
        {"Geneva Identification System", "GEN# +1.00181819"},
        {"Smithsonian Astrophysical Observation", "SAO 246075"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.24569903),
        dec: Angle.Degrees(-55.10649065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218993"},
        {"Hipparcos Number", "HIP 114613"},
        {"Fundamental Katalog 5th Edition", "FK5 6051"},
        {"Smithsonian Astrophysical Observation", "SAO 247779"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.27723008),
        dec: Angle.Degrees(-55.10628510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153054"},
        {"Hipparcos Number", "HIP 83201"},
        {"Smithsonian Astrophysical Observation", "SAO 244341"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.05737780),
        dec: Angle.Degrees(-55.10595660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73369"},
        {"Hipparcos Number", "HIP 42152"},
        {"Smithsonian Astrophysical Observation", "SAO 236107"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.87464875),
        dec: Angle.Degrees(-55.10275110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140176"},
        {"Hipparcos Number", "HIP 77117"},
        {"Geneva Identification System", "GEN# +1.00140176"},
        {"Smithsonian Astrophysical Observation", "SAO 242902"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.20019691),
        dec: Angle.Degrees(-55.10082690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101568"},
        {"Hipparcos Number", "HIP 56985"},
        {"Smithsonian Astrophysical Observation", "SAO 239287"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.22049375),
        dec: Angle.Degrees(-55.09848006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28043"},
        {"Hipparcos Number", "HIP 20428"},
        {"Geneva Identification System", "GEN# +1.00028043"},
        {"Smithsonian Astrophysical Observation", "SAO 233499"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.64493975),
        dec: Angle.Degrees(-55.09636653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168808"},
        {"Hipparcos Number", "HIP 90243"},
        {"Smithsonian Astrophysical Observation", "SAO 245448"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.19697950),
        dec: Angle.Degrees(-55.09476130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135885"},
        {"Hipparcos Number", "HIP 75034"},
        {"Geneva Identification System", "GEN# +1.00135885"},
        {"Smithsonian Astrophysical Observation", "SAO 242416"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.98084421),
        dec: Angle.Degrees(-55.09408990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27874",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27874"},
        {"Smithsonian Astrophysical Observation", "SAO 234190"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.47636645),
        dec: Angle.Degrees(-55.09364762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106633"},
        {"Hipparcos Number", "HIP 59822"},
        {"Geneva Identification System", "GEN# +1.00106633"},
        {"Smithsonian Astrophysical Observation", "SAO 239798"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.00701053),
        dec: Angle.Degrees(-55.09337531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84645"},
        {"Hipparcos Number", "HIP 47821"},
        {"Smithsonian Astrophysical Observation", "SAO 237293"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.22140306),
        dec: Angle.Degrees(-55.09139145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47816"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.21223237),
        dec: Angle.Degrees(-55.09036196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61169"},
        {"Hipparcos Number", "HIP 36885"},
        {"Smithsonian Astrophysical Observation", "SAO 235323"},
    },
    visualMagnitude: 9.00,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.74889527),
        dec: Angle.Degrees(-55.08592724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106826"},
        {"Hipparcos Number", "HIP 59907"},
        {"Geneva Identification System", "GEN# +1.00106826"},
        {"Smithsonian Astrophysical Observation", "SAO 239810"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.31728389),
        dec: Angle.Degrees(-55.08580514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86427"},
        {"Hipparcos Number", "HIP 48758"},
        {"Geneva Identification System", "GEN# +1.00086427J"},
        {"Smithsonian Astrophysical Observation", "SAO 237519"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.18204934),
        dec: Angle.Degrees(-55.08319881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13109"},
        {"Hipparcos Number", "HIP 9825"},
        {"Geneva Identification System", "GEN# +1.00013109"},
        {"Smithsonian Astrophysical Observation", "SAO 232634"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.61837855),
        dec: Angle.Degrees(-55.08286883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8953"},
        {"Hipparcos Number", "HIP 6768"},
        {"Geneva Identification System", "GEN# +1.00008953"},
        {"Smithsonian Astrophysical Observation", "SAO 232426"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.76025339),
        dec: Angle.Degrees(-55.08171617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182529"},
        {"Hipparcos Number", "HIP 95706"},
        {"Smithsonian Astrophysical Observation", "SAO 246111"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.00775212),
        dec: Angle.Degrees(-55.08160535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39565"},
        {"Hipparcos Number", "HIP 27559"},
        {"Geneva Identification System", "GEN# +1.00039565"},
        {"Smithsonian Astrophysical Observation", "SAO 234158"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.54962573),
        dec: Angle.Degrees(-55.08138903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46918"},
        {"Hipparcos Number", "HIP 31207"},
        {"Geneva Identification System", "GEN# +1.00046918"},
        {"Smithsonian Astrophysical Observation", "SAO 234568"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.20044376),
        dec: Angle.Degrees(-55.07926649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64162"},
        {"Hipparcos Number", "HIP 38203"},
        {"Smithsonian Astrophysical Observation", "SAO 235543"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.41165171),
        dec: Angle.Degrees(-55.07895552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18003"},
        {"Hipparcos Number", "HIP 13315"},
        {"Fundamental Katalog 5th Edition", "FK5 4261"},
        {"Geneva Identification System", "GEN# +1.00018003"},
        {"Smithsonian Astrophysical Observation", "SAO 232918"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.84089297),
        dec: Angle.Degrees(-55.07477728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35291"},
        {"Hipparcos Number", "HIP 24924"},
        {"Smithsonian Astrophysical Observation", "SAO 233934"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.10572776),
        dec: Angle.Degrees(-55.07446297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152006"},
        {"Hipparcos Number", "HIP 82663"},
        {"Geneva Identification System", "GEN# +1.00152006"},
        {"Smithsonian Astrophysical Observation", "SAO 244250"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.48108195),
        dec: Angle.Degrees(-55.07259141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11956"},
        {"Hipparcos Number", "HIP 8985"},
        {"Geneva Identification System", "GEN# +1.00011956"},
        {"Smithsonian Astrophysical Observation", "SAO 232572"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.95083296),
        dec: Angle.Degrees(-55.07216964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121039"},
        {"Hipparcos Number", "HIP 67913"},
        {"Smithsonian Astrophysical Observation", "SAO 241276"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.64824239),
        dec: Angle.Degrees(-55.07179716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153432"},
        {"Hipparcos Number", "HIP 83387"},
    },
    visualMagnitude: 9.02,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.63783883),
        dec: Angle.Degrees(-55.07108499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1004"},
        {"Hipparcos Number", "HIP 1140"},
        {"Fundamental Katalog 5th Edition", "FK5 2013"},
        {"Geneva Identification System", "GEN# +1.00001004"},
        {"Smithsonian Astrophysical Observation", "SAO 231979"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.56129370),
        dec: Angle.Degrees(-55.06959061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192706"},
        {"Hipparcos Number", "HIP 100143"},
        {"Smithsonian Astrophysical Observation", "SAO 246523"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.70784282),
        dec: Angle.Degrees(-55.06694495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67955"},
        {"Hipparcos Number", "HIP 39762"},
        {"Smithsonian Astrophysical Observation", "SAO 235759"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.90565603),
        dec: Angle.Degrees(-55.06588257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148549"},
        {"Hipparcos Number", "HIP 80950"},
        {"Geneva Identification System", "GEN# +1.00148549J"},
        {"Smithsonian Astrophysical Observation", "SAO 243915"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.94026027),
        dec: Angle.Degrees(-55.06539474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83390"},
    },
    visualMagnitude: 10.95,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.65302306),
        dec: Angle.Degrees(-55.06497502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215424"},
        {"Hipparcos Number", "HIP 112408"},
        {"Smithsonian Astrophysical Observation", "SAO 247572"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.51972648),
        dec: Angle.Degrees(-55.06359042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79264",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79264"},
        {"Smithsonian Astrophysical Observation", "SAO 243400"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.65714813),
        dec: Angle.Degrees(-55.05859210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59823"},
        {"Hipparcos Number", "HIP 36336"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.18481177),
        dec: Angle.Degrees(-55.05820843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206459"},
        {"Hipparcos Number", "HIP 107303"},
        {"Smithsonian Astrophysical Observation", "SAO 247154"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.00571280),
        dec: Angle.Degrees(-55.05670909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141318"},
        {"Hipparcos Number", "HIP 77645"},
        {"Geneva Identification System", "GEN# +1.00141318A"},
        {"Smithsonian Astrophysical Observation", "SAO 243044"},
        {"Wilson Evans Batten Catalogue", "WEB 13137"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.77836547),
        dec: Angle.Degrees(-55.05552532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168714"},
        {"Hipparcos Number", "HIP 90193"},
        {"Smithsonian Astrophysical Observation", "SAO 245443"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.06124329),
        dec: Angle.Degrees(-55.05518985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6430"},
        {"Hipparcos Number", "HIP 5014"},
        {"Smithsonian Astrophysical Observation", "SAO 232282"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.06705173),
        dec: Angle.Degrees(-55.05457243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39577"},
        {"Hipparcos Number", "HIP 27564"},
        {"Smithsonian Astrophysical Observation", "SAO 234160"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.56889515),
        dec: Angle.Degrees(-55.05349110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90065"},
        {"Hipparcos Number", "HIP 50797"},
        {"Geneva Identification System", "GEN# +1.00090065"},
        {"Smithsonian Astrophysical Observation", "SAO 237991"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.57727388),
        dec: Angle.Degrees(-55.05209993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159670"},
        {"Hipparcos Number", "HIP 86384"},
        {"Smithsonian Astrophysical Observation", "SAO 244911"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.77311671),
        dec: Angle.Degrees(-55.05193111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193002"},
        {"Hipparcos Number", "HIP 100300"},
        {"Fundamental Katalog 5th Edition", "FK5 3626"},
        {"Geneva Identification System", "GEN# +1.00193002"},
        {"Smithsonian Astrophysical Observation", "SAO 246535"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.13460168),
        dec: Angle.Degrees(-55.05080338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4280"},
    },
    visualMagnitude: 11.80,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.70120901),
        dec: Angle.Degrees(-55.05056736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57585"},
        {"Hipparcos Number", "HIP 35426"},
        {"Smithsonian Astrophysical Observation", "SAO 235091"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.71265044),
        dec: Angle.Degrees(-55.05018701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131122"},
        {"Hipparcos Number", "HIP 72897"},
        {"Geneva Identification System", "GEN# +1.00131122"},
        {"Smithsonian Astrophysical Observation", "SAO 242100"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.47521082),
        dec: Angle.Degrees(-55.04809924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52198"},
        {"Hipparcos Number", "HIP 33431"},
        {"Smithsonian Astrophysical Observation", "SAO 234807"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.27541554),
        dec: Angle.Degrees(-55.04743623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188745"},
        {"Hipparcos Number", "HIP 98389"},
        {"Geneva Identification System", "GEN# +1.00188745"},
        {"Smithsonian Astrophysical Observation", "SAO 246371"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.85392092),
        dec: Angle.Degrees(-55.04528880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102269"},
        {"Hipparcos Number", "HIP 57397"},
        {"Smithsonian Astrophysical Observation", "SAO 239356"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.50053770),
        dec: Angle.Degrees(-55.04521769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29305"},
        {"Hipparcos Number", "HIP 21281"},
        {"Fundamental Katalog 5th Edition", "FK5 171"},
        {"Geneva Identification System", "GEN# +1.00029305J"},
        {"Renson", "Renson 7490"},
        {"Smithsonian Astrophysical Observation", "SAO 233564"},
        {"Wilson Evans Batten Catalogue", "WEB 4091"},
    },
    visualMagnitude: 3.30,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.49882684),
        dec: Angle.Degrees(-55.04500559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39328",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39328"},
    },
    visualMagnitude: 10.26,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.61047779),
        dec: Angle.Degrees(-55.04364660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118976"},
        {"Hipparcos Number", "HIP 66827"},
        {"Geneva Identification System", "GEN# +1.00118976"},
        {"Smithsonian Astrophysical Observation", "SAO 241077"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.44195497),
        dec: Angle.Degrees(-55.04363688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105084"},
        {"Hipparcos Number", "HIP 59009"},
        {"Smithsonian Astrophysical Observation", "SAO 239660"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.49786219),
        dec: Angle.Degrees(-55.04352109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147156"},
        {"Hipparcos Number", "HIP 80246"},
        {"Smithsonian Astrophysical Observation", "SAO 243716"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.73315082),
        dec: Angle.Degrees(-55.03776803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66820"},
        {"Hipparcos Number", "HIP 39333"},
        {"Smithsonian Astrophysical Observation", "SAO 235702"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.61811869),
        dec: Angle.Degrees(-55.03688349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39178"},
        {"Hipparcos Number", "HIP 27349"},
        {"Renson", "Renson 10510"},
        {"Smithsonian Astrophysical Observation", "SAO 234141"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.88998570),
        dec: Angle.Degrees(-55.03664339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2727"},
        {"Hipparcos Number", "HIP 2372"},
        {"Smithsonian Astrophysical Observation", "SAO 232069"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.57340267),
        dec: Angle.Degrees(-55.03564814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45893"},
        {"Hipparcos Number", "HIP 30694"},
        {"Renson", "Renson 12270"},
        {"Smithsonian Astrophysical Observation", "SAO 234514"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.74508306),
        dec: Angle.Degrees(-55.03332202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 299896"},
        {"Hipparcos Number", "HIP 45096"},
        {"Geneva Identification System", "GEN# +1.00299896"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.79212874),
        dec: Angle.Degrees(-55.03168687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77795"},
        {"Hipparcos Number", "HIP 44380"},
        {"Celescope Catalog", "CEL 3160"},
        {"Geneva Identification System", "GEN# +1.00077795"},
        {"Smithsonian Astrophysical Observation", "SAO 236528"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.60320527),
        dec: Angle.Degrees(-55.03042112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89682"},
        {"Hipparcos Number", "HIP 50555"},
        {"Fundamental Katalog 5th Edition", "FK5 2830"},
        {"Geneva Identification System", "GEN# +1.00089682"},
        {"Smithsonian Astrophysical Observation", "SAO 237916"},
        {"Wilson Evans Batten Catalogue", "WEB 9273"},
    },
    visualMagnitude: 4.59,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.90318833),
        dec: Angle.Degrees(-55.02931452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183784"},
        {"Hipparcos Number", "HIP 96239"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.54002183),
        dec: Angle.Degrees(-55.02857740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 162.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105192"},
        {"Hipparcos Number", "HIP 59062"},
        {"Geneva Identification System", "GEN# +1.00105192"},
        {"Smithsonian Astrophysical Observation", "SAO 239669"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.69000146),
        dec: Angle.Degrees(-55.02746167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19905"},
        {"Hipparcos Number", "HIP 14685"},
        {"Smithsonian Astrophysical Observation", "SAO 233012"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.42657460),
        dec: Angle.Degrees(-55.02490914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217829"},
        {"Hipparcos Number", "HIP 113921"},
        {"Smithsonian Astrophysical Observation", "SAO 247709"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.05018134),
        dec: Angle.Degrees(-55.02477601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106131"},
        {"Hipparcos Number", "HIP 59556"},
        {"Smithsonian Astrophysical Observation", "SAO 239758"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.21533606),
        dec: Angle.Degrees(-55.02452864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118548"},
        {"Hipparcos Number", "HIP 66580"},
        {"Renson", "Renson 34250"},
        {"Smithsonian Astrophysical Observation", "SAO 241032"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.72568037),
        dec: Angle.Degrees(-55.02447954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126526"},
        {"Hipparcos Number", "HIP 70732"},
        {"Smithsonian Astrophysical Observation", "SAO 241733"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.98791598),
        dec: Angle.Degrees(-55.02358798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211916"},
        {"Hipparcos Number", "HIP 110416"},
        {"Smithsonian Astrophysical Observation", "SAO 247420"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.48801508),
        dec: Angle.Degrees(-55.02164277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107374"},
        {"Hipparcos Number", "HIP 60223"},
        {"Smithsonian Astrophysical Observation", "SAO 239864"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.23803561),
        dec: Angle.Degrees(-55.02160392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121122"},
        {"Hipparcos Number", "HIP 67956"},
        {"Smithsonian Astrophysical Observation", "SAO 241287"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.74707172),
        dec: Angle.Degrees(-55.02151231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126115"},
        {"Hipparcos Number", "HIP 70508"},
        {"Geneva Identification System", "GEN# +1.00126115"},
        {"Smithsonian Astrophysical Observation", "SAO 241702"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.34551595),
        dec: Angle.Degrees(-55.01816986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137160"},
        {"Hipparcos Number", "HIP 75608"},
        {"Geneva Identification System", "GEN# +1.00137160"},
        {"Renson", "Renson 38970"},
        {"Smithsonian Astrophysical Observation", "SAO 242529"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.71479246),
        dec: Angle.Degrees(-55.01772467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14592"},
        {"Hipparcos Number", "HIP 10852"},
        {"Smithsonian Astrophysical Observation", "SAO 232714"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.91784170),
        dec: Angle.Degrees(-55.01720433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106130"},
        {"Geneva Identification System", "GEN# +6.20145082"},
    },
    visualMagnitude: 11.56,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.46508368),
        dec: Angle.Degrees(-55.01697917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190422"},
        {"Hipparcos Number", "HIP 99137"},
        {"Geneva Identification System", "GEN# +1.00190422"},
        {"Smithsonian Astrophysical Observation", "SAO 246444"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.89613313),
        dec: Angle.Degrees(-55.01610030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175838"},
        {"Hipparcos Number", "HIP 93308"},
        {"Smithsonian Astrophysical Observation", "SAO 245856"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.07398423),
        dec: Angle.Degrees(-55.01562560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77306"},
        {"Hipparcos Number", "HIP 44152"},
        {"Smithsonian Astrophysical Observation", "SAO 236473"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.87800300),
        dec: Angle.Degrees(-55.01534462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18637"},
        {"Hipparcos Number", "HIP 13794"},
        {"Fundamental Katalog 5th Edition", "FK5 2208"},
        {"Geneva Identification System", "GEN# +1.00018637"},
        {"Smithsonian Astrophysical Observation", "SAO 232950"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.40300837),
        dec: Angle.Degrees(-55.01334760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172419"},
        {"Hipparcos Number", "HIP 91810"},
        {"Smithsonian Astrophysical Observation", "SAO 245651"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.79265365),
        dec: Angle.Degrees(-55.01289739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12431"},
        {"Hipparcos Number", "HIP 9362"},
        {"Geneva Identification System", "GEN# +1.00012431"},
        {"Smithsonian Astrophysical Observation", "SAO 232600"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.07014392),
        dec: Angle.Degrees(-55.01280664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71919"},
        {"Hipparcos Number", "HIP 41464"},
        {"Geneva Identification System", "GEN# +1.00071919J"},
        {"Smithsonian Astrophysical Observation", "SAO 236001"},
    },
    visualMagnitude: 6.52,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.86483435),
        dec: Angle.Degrees(-55.01124006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81188"},
        {"Hipparcos Number", "HIP 45941"},
        {"Celescope Catalog", "CEL 3276"},
        {"Fundamental Katalog 5th Edition", "FK5 353"},
        {"Geneva Identification System", "GEN# +1.00081188"},
        {"Renson", "Renson 23050"},
        {"Smithsonian Astrophysical Observation", "SAO 236891"},
        {"Wilson Evans Batten Catalogue", "WEB 8713"},
    },
    visualMagnitude: 2.47,
    bvColour: -0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.52845511),
        dec: Angle.Degrees(-55.01069531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130518"},
        {"Hipparcos Number", "HIP 72610"},
        {"Fundamental Katalog 5th Edition", "FK5 5317"},
        {"Smithsonian Astrophysical Observation", "SAO 242057"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.68322420),
        dec: Angle.Degrees(-55.00925546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81768"},
        {"Hipparcos Number", "HIP 46234"},
        {"Smithsonian Astrophysical Observation", "SAO 236958"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.39663062),
        dec: Angle.Degrees(-55.00683627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5456"},
        {"Hipparcos Number", "HIP 4337"},
        {"Geneva Identification System", "GEN# +1.00005456"},
        {"Smithsonian Astrophysical Observation", "SAO 232225"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.89081833),
        dec: Angle.Degrees(-55.00463604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87221"},
        {"Hipparcos Number", "HIP 49156"},
        {"Celescope Catalog", "CEL 3425"},
        {"Geneva Identification System", "GEN# +1.00087221"},
        {"Smithsonian Astrophysical Observation", "SAO 237619"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.48388702),
        dec: Angle.Degrees(-55.00329107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60560"},
        {"Hipparcos Number", "HIP 36639"},
        {"Smithsonian Astrophysical Observation", "SAO 235278"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.02069741),
        dec: Angle.Degrees(-55.00311691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223033"},
        {"Hipparcos Number", "HIP 117232"},
        {"Smithsonian Astrophysical Observation", "SAO 248013"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.55494841),
        dec: Angle.Degrees(-55.00245585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24250"},
        {"Hipparcos Number", "HIP 17824"},
        {"Smithsonian Astrophysical Observation", "SAO 233283"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.21256116),
        dec: Angle.Degrees(-55.00005649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127486"},
        {"Hipparcos Number", "HIP 71184"},
        {"Geneva Identification System", "GEN# +1.00127486"},
        {"Smithsonian Astrophysical Observation", "SAO 241792"},
        {"Wilson Evans Batten Catalogue", "WEB 12303"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.38529489),
        dec: Angle.Degrees(-54.99861560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67276"},
        {"Hipparcos Number", "HIP 39496"},
        {"Smithsonian Astrophysical Observation", "SAO 235728"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.09720100),
        dec: Angle.Degrees(-54.99540477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73814"},
        {"Hipparcos Number", "HIP 42323"},
        {"Smithsonian Astrophysical Observation", "SAO 236134"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.42879676),
        dec: Angle.Degrees(-54.99450264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88945"},
        {"Hipparcos Number", "HIP 50135"},
        {"Celescope Catalog", "CEL 3476"},
        {"Geneva Identification System", "GEN# +1.00088945"},
        {"Smithsonian Astrophysical Observation", "SAO 237819"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.52549811),
        dec: Angle.Degrees(-54.99371348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208450"},
        {"Hipparcos Number", "HIP 108431"},
        {"Fundamental Katalog 5th Edition", "FK5 824"},
        {"Geneva Identification System", "GEN# +1.00208450J"},
        {"Smithsonian Astrophysical Observation", "SAO 247244"},
        {"Wilson Evans Batten Catalogue", "WEB 19524"},
    },
    visualMagnitude: 4.40,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.47929577),
        dec: Angle.Degrees(-54.99256660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33514"},
        {"Hipparcos Number", "HIP 23841"},
        {"Geneva Identification System", "GEN# +1.00033514"},
        {"Smithsonian Astrophysical Observation", "SAO 233837"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.89289150),
        dec: Angle.Degrees(-54.98914329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90533"},
        {"Hipparcos Number", "HIP 51049"},
        {"Smithsonian Astrophysical Observation", "SAO 238054"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.44347460),
        dec: Angle.Degrees(-54.98884435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201711"},
        {"Hipparcos Number", "HIP 104776"},
        {"Fundamental Katalog 5th Edition", "FK5 5873"},
        {"Smithsonian Astrophysical Observation", "SAO 246912"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.38587709),
        dec: Angle.Degrees(-54.98873414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140041"},
        {"Hipparcos Number", "HIP 77058"},
        {"Geneva Identification System", "GEN# +1.00140041"},
        {"Smithsonian Astrophysical Observation", "SAO 242884"},
        {"Wilson Evans Batten Catalogue", "WEB 13069"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.01604126),
        dec: Angle.Degrees(-54.98678225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149342"},
        {"Hipparcos Number", "HIP 81361"},
        {"Geneva Identification System", "GEN# +1.00149342"},
        {"Smithsonian Astrophysical Observation", "SAO 243988"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.23843688),
        dec: Angle.Degrees(-54.98519481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88660"},
        {"Hipparcos Number", "HIP 49957"},
        {"Smithsonian Astrophysical Observation", "SAO 237778"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.99448233),
        dec: Angle.Degrees(-54.98498178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84101"},
        {"Hipparcos Number", "HIP 47495"},
        {"Celescope Catalog", "CEL 3360"},
        {"Geneva Identification System", "GEN# +1.00084101"},
        {"Smithsonian Astrophysical Observation", "SAO 237222"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.23360545),
        dec: Angle.Degrees(-54.98344225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179677"},
        {"Hipparcos Number", "HIP 94725"},
        {"Geneva Identification System", "GEN# +1.00179677"},
        {"Smithsonian Astrophysical Observation", "SAO 246000"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.12248002),
        dec: Angle.Degrees(-54.98292530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89281",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89281"},
        {"Smithsonian Astrophysical Observation", "SAO 245319"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.27555488),
        dec: Angle.Degrees(-54.98203791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87254"},
        {"Hipparcos Number", "HIP 49171"},
        {"Geneva Identification System", "GEN# +1.00087254"},
        {"Smithsonian Astrophysical Observation", "SAO 237622"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.52367706),
        dec: Angle.Degrees(-54.98161774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109197"},
        {"Hipparcos Number", "HIP 61265"},
        {"Fundamental Katalog 5th Edition", "FK5 5106"},
        {"Geneva Identification System", "GEN# +1.00109197"},
        {"Smithsonian Astrophysical Observation", "SAO 240056"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.33316541),
        dec: Angle.Degrees(-54.98110658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31644"},
        {"Smithsonian Astrophysical Observation", "SAO 234621"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.34052766),
        dec: Angle.Degrees(-54.97921529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108036"},
        {"Hipparcos Number", "HIP 60586"},
        {"Smithsonian Astrophysical Observation", "SAO 239935"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.26934024),
        dec: Angle.Degrees(-54.97878845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91125"},
        {"Hipparcos Number", "HIP 51402"},
        {"Smithsonian Astrophysical Observation", "SAO 238120"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.47913067),
        dec: Angle.Degrees(-54.97820675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210507"},
        {"Hipparcos Number", "HIP 109612"},
        {"Smithsonian Astrophysical Observation", "SAO 247351"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.07010860),
        dec: Angle.Degrees(-54.97781052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187421"},
        {"Hipparcos Number", "HIP 97819"},
        {"Geneva Identification System", "GEN# +1.00187421"},
        {"Smithsonian Astrophysical Observation", "SAO 246312"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.16297117),
        dec: Angle.Degrees(-54.97645289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89104"},
        {"Hipparcos Number", "HIP 50232"},
        {"Celescope Catalog", "CEL 3481"},
        {"Geneva Identification System", "GEN# +1.00089104"},
        {"Smithsonian Astrophysical Observation", "SAO 237834"},
        {"Wilson Evans Batten Catalogue", "WEB 9228"},
    },
    visualMagnitude: 6.16,
    bvColour: -0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.81938623),
        dec: Angle.Degrees(-54.97421495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94596"},
        {"Hipparcos Number", "HIP 53319"},
        {"Smithsonian Astrophysical Observation", "SAO 238586"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.58709020),
        dec: Angle.Degrees(-54.97324574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187420"},
        {"Hipparcos Number", "HIP 97816"},
        {"Geneva Identification System", "GEN# +1.00187420J"},
        {"Geneva Identification System 2", "GEN# +1.00187420A"},
        {"Smithsonian Astrophysical Observation", "SAO 246311"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.15709206),
        dec: Angle.Degrees(-54.97103652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91405"},
        {"Hipparcos Number", "HIP 51577"},
        {"Smithsonian Astrophysical Observation", "SAO 238153"},
    },
    visualMagnitude: 8.92,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.00858049),
        dec: Angle.Degrees(-54.97038930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2751"},
        {"Hipparcos Number", "HIP 2406"},
        {"Smithsonian Astrophysical Observation", "SAO 232070"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.66525313),
        dec: Angle.Degrees(-54.97028170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42933"},
        {"Hipparcos Number", "HIP 29276"},
        {"Fundamental Katalog 5th Edition", "FK5 235"},
        {"Geneva Identification System", "GEN# +1.00042933"},
        {"Smithsonian Astrophysical Observation", "SAO 234359"},
        {"Wilson Evans Batten Catalogue", "WEB 5745"},
    },
    visualMagnitude: 4.72,
    bvColour: -0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.57463800),
        dec: Angle.Degrees(-54.96866057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19150"},
        {"Hipparcos Number", "HIP 14163"},
        {"Smithsonian Astrophysical Observation", "SAO 232971"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.64771388),
        dec: Angle.Degrees(-54.96812262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80092"},
        {"Hipparcos Number", "HIP 45434"},
        {"Celescope Catalog", "CEL 3248"},
        {"Geneva Identification System", "GEN# +1.00080092"},
        {"Smithsonian Astrophysical Observation", "SAO 236773"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.89003877),
        dec: Angle.Degrees(-54.96621382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8687"},
    },
    visualMagnitude: 11.48,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.94141838),
        dec: Angle.Degrees(-54.96581372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 279.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76653"},
        {"Hipparcos Number", "HIP 43797"},
        {"Geneva Identification System", "GEN# +1.00076653"},
        {"Smithsonian Astrophysical Observation", "SAO 236405"},
        {"Wilson Evans Batten Catalogue", "WEB 8423"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.79898826),
        dec: Angle.Degrees(-54.96554657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135072"},
        {"Hipparcos Number", "HIP 74676"},
        {"Smithsonian Astrophysical Observation", "SAO 242357"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.91388563),
        dec: Angle.Degrees(-54.96412134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114899"},
        {"Hipparcos Number", "HIP 64601"},
        {"Smithsonian Astrophysical Observation", "SAO 240669"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.60949074),
        dec: Angle.Degrees(-54.96211989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56909"},
        {"Hipparcos Number", "HIP 35158"},
        {"Fundamental Katalog 5th Edition", "FK5 4654"},
        {"Smithsonian Astrophysical Observation", "SAO 235057"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.99933510),
        dec: Angle.Degrees(-54.96167415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75168"},
        {"Hipparcos Number", "HIP 43015"},
        {"Geneva Identification System", "GEN# +1.00075168"},
        {"Smithsonian Astrophysical Observation", "SAO 236254"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.49280464),
        dec: Angle.Degrees(-54.96040808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8286"},
        {"Hipparcos Number", "HIP 6310"},
        {"Smithsonian Astrophysical Observation", "SAO 232387"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.26668255),
        dec: Angle.Degrees(-54.95827970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168791"},
        {"Hipparcos Number", "HIP 90231"},
        {"Geneva Identification System", "GEN# +1.00168791"},
        {"Smithsonian Astrophysical Observation", "SAO 245446"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.16179445),
        dec: Angle.Degrees(-54.95714243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200589"},
        {"Hipparcos Number", "HIP 104187"},
        {"Geneva Identification System", "GEN# +1.00200589"},
        {"Smithsonian Astrophysical Observation", "SAO 246870"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.62709706),
        dec: Angle.Degrees(-54.95639540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80825"},
        {"Geneva Identification System", "GEN# -0.05407726"},
    },
    visualMagnitude: 11.23,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.57805594),
        dec: Angle.Degrees(-54.95488166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37877"},
        {"Hipparcos Number", "HIP 26521"},
        {"Smithsonian Astrophysical Observation", "SAO 234063"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.60733634),
        dec: Angle.Degrees(-54.95415977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111884"},
        {"Hipparcos Number", "HIP 62861"},
        {"Geneva Identification System", "GEN# +1.00111884"},
        {"Smithsonian Astrophysical Observation", "SAO 240347"},
        {"Wilson Evans Batten Catalogue", "WEB 11144"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.26776709),
        dec: Angle.Degrees(-54.95248410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41278"},
        {"Hipparcos Number", "HIP 28498"},
        {"Geneva Identification System", "GEN# +1.00041278"},
        {"Smithsonian Astrophysical Observation", "SAO 234253"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.23056150),
        dec: Angle.Degrees(-54.95136555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87653"},
        {"Hipparcos Number", "HIP 49373"},
        {"Renson", "Renson 25130"},
        {"Smithsonian Astrophysical Observation", "SAO 237673"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.19159354),
        dec: Angle.Degrees(-54.95083404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114305"},
        {"Hipparcos Number", "HIP 64290"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.64029474),
        dec: Angle.Degrees(-54.94813636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81735"},
        {"Hipparcos Number", "HIP 46226"},
        {"Smithsonian Astrophysical Observation", "SAO 236954"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.36408148),
        dec: Angle.Degrees(-54.94367054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111088"},
        {"Hipparcos Number", "HIP 62415"},
        {"Smithsonian Astrophysical Observation", "SAO 240251"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.86927177),
        dec: Angle.Degrees(-54.94237518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195818"},
        {"Hipparcos Number", "HIP 101636"},
        {"Geneva Identification System", "GEN# +1.00195818"},
        {"Smithsonian Astrophysical Observation", "SAO 246651"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.00959675),
        dec: Angle.Degrees(-54.94120908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216860"},
        {"Hipparcos Number", "HIP 113352"},
        {"Smithsonian Astrophysical Observation", "SAO 247656"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.34185556),
        dec: Angle.Degrees(-54.93987222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118135"},
        {"Hipparcos Number", "HIP 66355"},
        {"Smithsonian Astrophysical Observation", "SAO 240986"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.02311536),
        dec: Angle.Degrees(-54.93929643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82466"},
        {"Hipparcos Number", "HIP 46606"},
        {"Celescope Catalog", "CEL 3313"},
        {"Geneva Identification System", "GEN# +1.00082466"},
        {"Smithsonian Astrophysical Observation", "SAO 237050"},
    },
    visualMagnitude: 8.48,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.55192283),
        dec: Angle.Degrees(-54.93836463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95903"},
        {"Geneva Identification System", "GEN# +6.20145038"},
    },
    visualMagnitude: 11.33,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.55697790),
        dec: Angle.Degrees(-54.93797726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -314.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33085"},
        {"Hipparcos Number", "HIP 23626"},
        {"Smithsonian Astrophysical Observation", "SAO 233813"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.18779162),
        dec: Angle.Degrees(-54.93768024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188559"},
        {"Hipparcos Number", "HIP 98316"},
        {"Geneva Identification System", "GEN# +1.00188559"},
        {"Smithsonian Astrophysical Observation", "SAO 246359"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.63697548),
        dec: Angle.Degrees(-54.93659116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219570"},
        {"Hipparcos Number", "HIP 114982"},
        {"Smithsonian Astrophysical Observation", "SAO 247813"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.32405453),
        dec: Angle.Degrees(-54.93459343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44878"},
        {"Hipparcos Number", "HIP 30183"},
        {"Smithsonian Astrophysical Observation", "SAO 234459"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.25791845),
        dec: Angle.Degrees(-54.93440051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169743"},
        {"Hipparcos Number", "HIP 90598"},
        {"Geneva Identification System", "GEN# +1.00169743"},
        {"Smithsonian Astrophysical Observation", "SAO 245506"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.30541149),
        dec: Angle.Degrees(-54.93398089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16171"},
        {"Hipparcos Number", "HIP 11913"},
        {"Geneva Identification System", "GEN# +1.00016171"},
        {"Smithsonian Astrophysical Observation", "SAO 232817"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.43498686),
        dec: Angle.Degrees(-54.93351841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8914"},
        {"Hipparcos Number", "HIP 6728"},
        {"Renson", "Renson 2160"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.66650877),
        dec: Angle.Degrees(-54.92699690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133884"},
        {"Hipparcos Number", "HIP 74152"},
        {"Smithsonian Astrophysical Observation", "SAO 242257"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.27387312),
        dec: Angle.Degrees(-54.92674494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13108"},
        {"Hipparcos Number", "HIP 9834"},
        {"Smithsonian Astrophysical Observation", "SAO 232635"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.63608857),
        dec: Angle.Degrees(-54.92645636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109252"},
        {"Hipparcos Number", "HIP 61313"},
        {"Geneva Identification System", "GEN# +1.00109252"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.41771755),
        dec: Angle.Degrees(-54.92341796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68741"},
        {"Hipparcos Number", "HIP 40069"},
        {"Smithsonian Astrophysical Observation", "SAO 235795"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.77620892),
        dec: Angle.Degrees(-54.92164685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199606"},
        {"Hipparcos Number", "HIP 103680"},
        {"Smithsonian Astrophysical Observation", "SAO 246821"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.13515040),
        dec: Angle.Degrees(-54.91995024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65799"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.31657135),
        dec: Angle.Degrees(-54.91836820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99910"},
        {"Hipparcos Number", "HIP 56037"},
        {"Smithsonian Astrophysical Observation", "SAO 239104"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.27502575),
        dec: Angle.Degrees(-54.91812413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117094"},
        {"Hipparcos Number", "HIP 65795"},
        {"Geneva Identification System", "GEN# +1.00117094"},
        {"Smithsonian Astrophysical Observation", "SAO 240880"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.30951477),
        dec: Angle.Degrees(-54.91773879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89206"},
    },
    visualMagnitude: 11.46,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.06841096),
        dec: Angle.Degrees(-54.91742066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186462"},
        {"Hipparcos Number", "HIP 97362"},
        {"Geneva Identification System", "GEN# +1.00186462"},
        {"Smithsonian Astrophysical Observation", "SAO 246267"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.83998107),
        dec: Angle.Degrees(-54.91718581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16"},
    },
    visualMagnitude: 11.71,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.05140852),
        dec: Angle.Degrees(-54.91412819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 257.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8051"},
        {"Hipparcos Number", "HIP 6148"},
        {"Smithsonian Astrophysical Observation", "SAO 232374"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.73267218),
        dec: Angle.Degrees(-54.91406643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93111"},
        {"Hipparcos Number", "HIP 52500"},
        {"Smithsonian Astrophysical Observation", "SAO 238397"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.02131396),
        dec: Angle.Degrees(-54.91127160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39474"},
        {"Hipparcos Number", "HIP 27515"},
        {"Smithsonian Astrophysical Observation", "SAO 234150"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.40168676),
        dec: Angle.Degrees(-54.91087347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60036"},
        {"Hipparcos Number", "HIP 36420"},
        {"Smithsonian Astrophysical Observation", "SAO 235236"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.40643099),
        dec: Angle.Degrees(-54.90814457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174545"},
        {"Hipparcos Number", "HIP 92742"},
        {"Geneva Identification System", "GEN# +1.00174545"},
        {"Smithsonian Astrophysical Observation", "SAO 245791"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.48829188),
        dec: Angle.Degrees(-54.90587481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78444"},
        {"Hipparcos Number", "HIP 44664"},
        {"Celescope Catalog", "CEL 3184"},
        {"Geneva Identification System", "GEN# +1.00078444J"},
        {"Smithsonian Astrophysical Observation", "SAO 236602"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.52782823),
        dec: Angle.Degrees(-54.90397092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37226"},
        {"Hipparcos Number", "HIP 26079"},
        {"Fundamental Katalog 5th Edition", "FK5 2419"},
        {"Geneva Identification System", "GEN# +1.00037226"},
        {"Smithsonian Astrophysical Observation", "SAO 234026"},
        {"Wilson Evans Batten Catalogue", "WEB 5077"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.43457243),
        dec: Angle.Degrees(-54.90231460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122935"},
        {"Hipparcos Number", "HIP 68896"},
        {"Smithsonian Astrophysical Observation", "SAO 241442"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.59478693),
        dec: Angle.Degrees(-54.90139650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64122"},
        {"Hipparcos Number", "HIP 38188"},
        {"Geneva Identification System", "GEN# +1.00064122"},
        {"Smithsonian Astrophysical Observation", "SAO 235542"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.37228144),
        dec: Angle.Degrees(-54.90121950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56351"},
        {"Hipparcos Number", "HIP 34932"},
        {"Geneva Identification System", "GEN# +1.00056351"},
        {"Smithsonian Astrophysical Observation", "SAO 235025"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.42589221),
        dec: Angle.Degrees(-54.90060933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36765"},
        {"Hipparcos Number", "HIP 25827"},
        {"Smithsonian Astrophysical Observation", "SAO 234008"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.71665087),
        dec: Angle.Degrees(-54.89835060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123737"},
        {"Hipparcos Number", "HIP 69296"},
        {"Smithsonian Astrophysical Observation", "SAO 241508"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.75594876),
        dec: Angle.Degrees(-54.89725565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128155"},
        {"Hipparcos Number", "HIP 71498"},
        {"Smithsonian Astrophysical Observation", "SAO 241851"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.33109658),
        dec: Angle.Degrees(-54.89723858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94897"},
        {"Hipparcos Number", "HIP 53469"},
        {"Smithsonian Astrophysical Observation", "SAO 238610"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.06672503),
        dec: Angle.Degrees(-54.89552551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158783"},
        {"Hipparcos Number", "HIP 85969"},
        {"Geneva Identification System", "GEN# +1.00158783"},
        {"Smithsonian Astrophysical Observation", "SAO 244852"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.54922553),
        dec: Angle.Degrees(-54.89505260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -297.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146202"},
        {"Hipparcos Number", "HIP 79842"},
        {"Geneva Identification System", "GEN# +1.00146202"},
        {"Smithsonian Astrophysical Observation", "SAO 243550"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.45461570),
        dec: Angle.Degrees(-54.89463025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21575"},
        {"Hipparcos Number", "HIP 16024"},
        {"Smithsonian Astrophysical Observation", "SAO 233115"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.58415566),
        dec: Angle.Degrees(-54.89319314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29473"},
        {"Hipparcos Number", "HIP 21388"},
        {"Geneva Identification System", "GEN# +1.00029473"},
        {"Smithsonian Astrophysical Observation", "SAO 233582"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.86746081),
        dec: Angle.Degrees(-54.89141809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175555"},
        {"Hipparcos Number", "HIP 93183"},
        {"Smithsonian Astrophysical Observation", "SAO 245839"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.70317533),
        dec: Angle.Degrees(-54.89044237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160719"},
        {"Hipparcos Number", "HIP 86826"},
        {"Smithsonian Astrophysical Observation", "SAO 244983"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.12812525),
        dec: Angle.Degrees(-54.88929699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186757"},
        {"Hipparcos Number", "HIP 97518"},
        {"Smithsonian Astrophysical Observation", "SAO 246278"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.30681499),
        dec: Angle.Degrees(-54.88858124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20072"},
        {"Hipparcos Number", "HIP 14799"},
        {"Geneva Identification System", "GEN# +1.00020072"},
        {"Smithsonian Astrophysical Observation", "SAO 233027"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.78212730),
        dec: Angle.Degrees(-54.88850315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95275"},
        {"Hipparcos Number", "HIP 53686"},
        {"Geneva Identification System", "GEN# +1.00095275"},
        {"Smithsonian Astrophysical Observation", "SAO 238653"},
        {"Wilson Evans Batten Catalogue", "WEB 9727"},
    },
    visualMagnitude: 8.58,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.77172537),
        dec: Angle.Degrees(-54.88756045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99845"},
        {"Hipparcos Number", "HIP 56005"},
        {"Smithsonian Astrophysical Observation", "SAO 239099"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.15945825),
        dec: Angle.Degrees(-54.88351792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51268"},
        {"Hipparcos Number", "HIP 33093"},
        {"Smithsonian Astrophysical Observation", "SAO 234770"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.38981899),
        dec: Angle.Degrees(-54.88313867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12894"},
        {"Hipparcos Number", "HIP 9685"},
        {"Geneva Identification System", "GEN# +1.00012894"},
        {"Smithsonian Astrophysical Observation", "SAO 232620"},
        {"Wilson Evans Batten Catalogue", "WEB 2035"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.14600838),
        dec: Angle.Degrees(-54.88162897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90677"},
        {"Hipparcos Number", "HIP 51140"},
        {"Geneva Identification System", "GEN# +1.00090677"},
        {"Smithsonian Astrophysical Observation", "SAO 238067"},
    },
    visualMagnitude: 5.58,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.70389571),
        dec: Angle.Degrees(-54.87731436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81891"},
        {"Hipparcos Number", "HIP 46296"},
        {"Celescope Catalog", "CEL 3298"},
        {"Geneva Identification System", "GEN# +1.00081891"},
        {"Smithsonian Astrophysical Observation", "SAO 236979"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.61605601),
        dec: Angle.Degrees(-54.87439312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12564"},
        {"Smithsonian Astrophysical Observation", "SAO 232862"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.39470776),
        dec: Angle.Degrees(-54.87107798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203127"},
        {"Hipparcos Number", "HIP 105525"},
        {"Smithsonian Astrophysical Observation", "SAO 246999"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.58737905),
        dec: Angle.Degrees(-54.87079339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30641"},
        {"Hipparcos Number", "HIP 22199"},
        {"Smithsonian Astrophysical Observation", "SAO 233676"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.61686461),
        dec: Angle.Degrees(-54.87041451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16114"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.90022638),
        dec: Angle.Degrees(-54.86631383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 252.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205710"},
        {"Hipparcos Number", "HIP 106894"},
        {"Smithsonian Astrophysical Observation", "SAO 247121"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.75089906),
        dec: Angle.Degrees(-54.86457690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27243"},
        {"Hipparcos Number", "HIP 19848"},
        {"Smithsonian Astrophysical Observation", "SAO 233453"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.82262438),
        dec: Angle.Degrees(-54.86451101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111757"},
        {"Hipparcos Number", "HIP 62806"},
        {"Smithsonian Astrophysical Observation", "SAO 240332"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.04835081),
        dec: Angle.Degrees(-54.86330825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29640"},
        {"Hipparcos Number", "HIP 21505"},
        {"Smithsonian Astrophysical Observation", "SAO 233596"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.28050258),
        dec: Angle.Degrees(-54.86205957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92435"},
        {"Hipparcos Number", "HIP 52146"},
        {"Smithsonian Astrophysical Observation", "SAO 238306"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.79131670),
        dec: Angle.Degrees(-54.86124098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14499"},
        {"Hipparcos Number", "HIP 10779"},
        {"Smithsonian Astrophysical Observation", "SAO 232705"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.68318611),
        dec: Angle.Degrees(-54.85981214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149455"},
        {"Hipparcos Number", "HIP 81427"},
        {"Smithsonian Astrophysical Observation", "SAO 244003"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.45532483),
        dec: Angle.Degrees(-54.85867079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10687"},
        {"Hipparcos Number", "HIP 8024"},
        {"Smithsonian Astrophysical Observation", "SAO 232506"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.75459177),
        dec: Angle.Degrees(-54.85643185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202195"},
        {"Hipparcos Number", "HIP 105028"},
        {"Geneva Identification System", "GEN# +1.00202195"},
        {"Smithsonian Astrophysical Observation", "SAO 246937"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.10568556),
        dec: Angle.Degrees(-54.85623311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155169"},
        {"Hipparcos Number", "HIP 84232"},
        {"Smithsonian Astrophysical Observation", "SAO 244522"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.26404830),
        dec: Angle.Degrees(-54.85203324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129242"},
        {"Hipparcos Number", "HIP 71994"},
        {"Smithsonian Astrophysical Observation", "SAO 241940"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.85472134),
        dec: Angle.Degrees(-54.85162132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24757"},
        {"Hipparcos Number", "HIP 18183"},
        {"Geneva Identification System", "GEN# +1.00024757"},
        {"Smithsonian Astrophysical Observation", "SAO 233314"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.34452210),
        dec: Angle.Degrees(-54.85063071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56501"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.74575025),
        dec: Angle.Degrees(-54.84967725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 177.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86000"},
        {"Hipparcos Number", "HIP 48538"},
        {"Celescope Catalog", "CEL 3399"},
        {"Geneva Identification System", "GEN# +1.00086000"},
        {"Smithsonian Astrophysical Observation", "SAO 237468"},
    },
    visualMagnitude: 8.13,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.49118815),
        dec: Angle.Degrees(-54.84798276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102853"},
        {"Hipparcos Number", "HIP 57728"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.57654518),
        dec: Angle.Degrees(-54.84670654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103004"},
        {"Hipparcos Number", "HIP 57818"},
        {"Geneva Identification System", "GEN# +1.00103004"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.83917408),
        dec: Angle.Degrees(-54.84512956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92021"},
        {"Hipparcos Number", "HIP 51918"},
        {"Geneva Identification System", "GEN# +1.00092021"},
        {"Smithsonian Astrophysical Observation", "SAO 238239"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.09455431),
        dec: Angle.Degrees(-54.84438557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103180"},
        {"Geneva Identification System", "GEN# +6.20145065"},
    },
    visualMagnitude: 12.07,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)54, 18.2600),
        dec: Angle.DegreesMinutesSeconds((int)-53, (int)30, 08.700)
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
    primaryId: "HIP 12342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12342"},
        {"Smithsonian Astrophysical Observation", "SAO 232844"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.73234670),
        dec: Angle.Degrees(-54.84241623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16744"},
        {"Hipparcos Number", "HIP 12345"},
        {"Smithsonian Astrophysical Observation", "SAO 232845"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.73648787),
        dec: Angle.Degrees(-54.83720610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177852"},
        {"Hipparcos Number", "HIP 94100"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.33579296),
        dec: Angle.Degrees(-54.83704718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3393"},
        {"Hipparcos Number", "HIP 2862"},
        {"Smithsonian Astrophysical Observation", "SAO 232109"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.07211134),
        dec: Angle.Degrees(-54.83449120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78189"},
        {"Hipparcos Number", "HIP 44555"},
        {"Smithsonian Astrophysical Observation", "SAO 236572"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.16863519),
        dec: Angle.Degrees(-54.83377582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83549"},
        {"Hipparcos Number", "HIP 47216"},
        {"Geneva Identification System", "GEN# +1.00083549"},
        {"Smithsonian Astrophysical Observation", "SAO 237152"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.33546149),
        dec: Angle.Degrees(-54.83132806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82856"},
        {"Hipparcos Number", "HIP 46839"},
        {"Geneva Identification System", "GEN# +1.00082856"},
        {"Smithsonian Astrophysical Observation", "SAO 237086"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.17160183),
        dec: Angle.Degrees(-54.83083853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65"},
    },
    visualMagnitude: 11.00,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.18797532),
        dec: Angle.Degrees(-54.83034057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112996"},
        {"Smithsonian Astrophysical Observation", "SAO 247627"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.25682014),
        dec: Angle.Degrees(-54.82934519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72388"},
        {"Hipparcos Number", "HIP 41695"},
        {"Geneva Identification System", "GEN# +1.00072388"},
        {"Smithsonian Astrophysical Observation", "SAO 236035"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.50147334),
        dec: Angle.Degrees(-54.82765745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67954"},
        {"Hipparcos Number", "HIP 39774"},
        {"Celescope Catalog", "CEL 2174"},
        {"Geneva Identification System", "GEN# +1.00067954"},
        {"Smithsonian Astrophysical Observation", "SAO 235761"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.92442684),
        dec: Angle.Degrees(-54.82580318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119899"},
        {"Hipparcos Number", "HIP 67284"},
        {"Geneva Identification System", "GEN# +1.00119899"},
        {"Smithsonian Astrophysical Observation", "SAO 241170"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.84263396),
        dec: Angle.Degrees(-54.82429152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108269"},
        {"Hipparcos Number", "HIP 60724"},
        {"Smithsonian Astrophysical Observation", "SAO 239949"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.66968489),
        dec: Angle.Degrees(-54.82320875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3303"},
        {"Hipparcos Number", "HIP 2789"},
        {"Geneva Identification System", "GEN# +1.00003303"},
        {"Smithsonian Astrophysical Observation", "SAO 232099"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.88881583),
        dec: Angle.Degrees(-54.82174811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64582"},
        {"Hipparcos Number", "HIP 38378"},
        {"Smithsonian Astrophysical Observation", "SAO 235569"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.93741273),
        dec: Angle.Degrees(-54.81985531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118884"},
        {"Hipparcos Number", "HIP 66754"},
        {"Geneva Identification System", "GEN# +1.00118884"},
        {"Smithsonian Astrophysical Observation", "SAO 241065"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.23497180),
        dec: Angle.Degrees(-54.81976225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129839"},
        {"Hipparcos Number", "HIP 72277"},
        {"Geneva Identification System", "GEN# +1.00129839"},
        {"Smithsonian Astrophysical Observation", "SAO 241989"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.71359102),
        dec: Angle.Degrees(-54.81968837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38538"},
        {"Hipparcos Number", "HIP 26965"},
        {"Geneva Identification System", "GEN# +1.00038538"},
        {"Smithsonian Astrophysical Observation", "SAO 234107"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.83285247),
        dec: Angle.Degrees(-54.81963521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168595"},
        {"Hipparcos Number", "HIP 90136"},
        {"Smithsonian Astrophysical Observation", "SAO 245438"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.91580738),
        dec: Angle.Degrees(-54.81802801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37782"},
        {"Hipparcos Number", "HIP 26470"},
        {"Smithsonian Astrophysical Observation", "SAO 234057"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.45874491),
        dec: Angle.Degrees(-54.81649535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193231"},
        {"Hipparcos Number", "HIP 100405"},
        {"Geneva Identification System", "GEN# +1.00193231"},
        {"Smithsonian Astrophysical Observation", "SAO 246544"},
        {"Wilson Evans Batten Catalogue", "WEB 18124"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.41080381),
        dec: Angle.Degrees(-54.81216501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -231.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64121"},
        {"Hipparcos Number", "HIP 38181"},
        {"Geneva Identification System", "GEN# +1.00064121"},
        {"Smithsonian Astrophysical Observation", "SAO 235540"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.36516636),
        dec: Angle.Degrees(-54.81210731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22014"},
        {"Hipparcos Number", "HIP 16320"},
        {"Geneva Identification System", "GEN# +1.00022014"},
        {"Smithsonian Astrophysical Observation", "SAO 233139"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.59036862),
        dec: Angle.Degrees(-54.80827424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13886",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13886"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.70419381),
        dec: Angle.Degrees(-54.80446583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87346"},
    },
    visualMagnitude: 12.63,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.71878588),
        dec: Angle.Degrees(-54.80257133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30143"},
        {"Hipparcos Number", "HIP 21857"},
        {"Smithsonian Astrophysical Observation", "SAO 233632"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.49871423),
        dec: Angle.Degrees(-54.80045670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92796"},
        {"Hipparcos Number", "HIP 52334"},
        {"Smithsonian Astrophysical Observation", "SAO 238362"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.42539186),
        dec: Angle.Degrees(-54.79817931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82325"},
        {"Hipparcos Number", "HIP 46520"},
        {"Celescope Catalog", "CEL 3310"},
        {"Geneva Identification System", "GEN# +1.00082325"},
        {"Smithsonian Astrophysical Observation", "SAO 237031"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.32262388),
        dec: Angle.Degrees(-54.79586697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52097"},
        {"Hipparcos Number", "HIP 33398"},
        {"Smithsonian Astrophysical Observation", "SAO 234802"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.19874179),
        dec: Angle.Degrees(-54.79570674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71655"},
        {"Hipparcos Number", "HIP 41327"},
        {"Smithsonian Astrophysical Observation", "SAO 235971"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.48099288),
        dec: Angle.Degrees(-54.79214121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17233"},
        {"Hipparcos Number", "HIP 12748"},
        {"Geneva Identification System", "GEN# +1.00017233"},
        {"Smithsonian Astrophysical Observation", "SAO 232870"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.96680900),
        dec: Angle.Degrees(-54.79120719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118664"},
        {"Hipparcos Number", "HIP 66642"},
        {"Smithsonian Astrophysical Observation", "SAO 241043"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.90221322),
        dec: Angle.Degrees(-54.78563259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16256"},
        {"Smithsonian Astrophysical Observation", "SAO 233135"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.37757796),
        dec: Angle.Degrees(-54.78210577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150314"},
        {"Hipparcos Number", "HIP 81859"},
        {"Smithsonian Astrophysical Observation", "SAO 244088"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.78750112),
        dec: Angle.Degrees(-54.78092043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129838"},
        {"Hipparcos Number", "HIP 72273"},
        {"Geneva Identification System", "GEN# +1.00129838"},
        {"Smithsonian Astrophysical Observation", "SAO 241987"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.70172487),
        dec: Angle.Degrees(-54.77912940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204351"},
        {"Hipparcos Number", "HIP 106138"},
        {"Smithsonian Astrophysical Observation", "SAO 247050"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.47938458),
        dec: Angle.Degrees(-54.77851331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138224"},
        {"Hipparcos Number", "HIP 76150"},
        {"Smithsonian Astrophysical Observation", "SAO 242685"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.30582528),
        dec: Angle.Degrees(-54.77734288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197921"},
        {"Hipparcos Number", "HIP 102753"},
        {"Geneva Identification System", "GEN# +1.00197921"},
        {"Smithsonian Astrophysical Observation", "SAO 246742"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.29170453),
        dec: Angle.Degrees(-54.77705918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 184.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -279.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98180"},
        {"Hipparcos Number", "HIP 55109"},
        {"Geneva Identification System", "GEN# +1.00098180"},
        {"Smithsonian Astrophysical Observation", "SAO 238930"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.25005396),
        dec: Angle.Degrees(-54.77689966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158219"},
        {"Hipparcos Number", "HIP 85728"},
        {"Smithsonian Astrophysical Observation", "SAO 244805"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.77779655),
        dec: Angle.Degrees(-54.77564312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197323"},
        {"Hipparcos Number", "HIP 102432"},
        {"Geneva Identification System", "GEN# +1.00197323"},
        {"Smithsonian Astrophysical Observation", "SAO 246718"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.33989037),
        dec: Angle.Degrees(-54.77476670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88129"},
        {"Hipparcos Number", "HIP 49659"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.06814183),
        dec: Angle.Degrees(-54.77165091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84359"},
        {"Hipparcos Number", "HIP 47653"},
        {"Celescope Catalog", "CEL 3365"},
        {"Geneva Identification System", "GEN# +1.00084359"},
        {"Smithsonian Astrophysical Observation", "SAO 237254"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.73406122),
        dec: Angle.Degrees(-54.76598564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209073"},
        {"Hipparcos Number", "HIP 108786"},
        {"Renson", "Renson 58150"},
        {"Smithsonian Astrophysical Observation", "SAO 247279"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.56336839),
        dec: Angle.Degrees(-54.76209373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91404"},
        {"Hipparcos Number", "HIP 51563"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.99210158),
        dec: Angle.Degrees(-54.76145419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141151"},
        {"Hipparcos Number", "HIP 77567"},
        {"Smithsonian Astrophysical Observation", "SAO 243021"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.54781273),
        dec: Angle.Degrees(-54.76098110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110372"},
        {"Hipparcos Number", "HIP 61982"},
        {"Smithsonian Astrophysical Observation", "SAO 240165"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.52713653),
        dec: Angle.Degrees(-54.76089157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54700"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.97641862),
        dec: Angle.Degrees(-53.19019230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11754"},
        {"Hipparcos Number", "HIP 8848"},
        {"Geneva Identification System", "GEN# +1.00011754"},
        {"Smithsonian Astrophysical Observation", "SAO 232563"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.45403153),
        dec: Angle.Degrees(-54.76033997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77566"},
    },
    visualMagnitude: 11.44,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.54368401),
        dec: Angle.Degrees(-54.75752122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110797",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110797"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.70809859),
        dec: Angle.Degrees(-54.75615525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93110"},
        {"Hipparcos Number", "HIP 52504"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.03351027),
        dec: Angle.Degrees(-54.75534351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74448"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.20632600),
        dec: Angle.Degrees(-54.75526660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83865"},
        {"Hipparcos Number", "HIP 47397"},
        {"Celescope Catalog", "CEL 3355"},
        {"Geneva Identification System", "GEN# +1.00083865"},
        {"Smithsonian Astrophysical Observation", "SAO 237193"},
        {"Wilson Evans Batten Catalogue", "WEB 8897"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.86085141),
        dec: Angle.Degrees(-54.75337214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84731"},
        {"Hipparcos Number", "HIP 47867"},
        {"Smithsonian Astrophysical Observation", "SAO 237306"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.34040282),
        dec: Angle.Degrees(-54.75328632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49922"},
        {"Hipparcos Number", "HIP 32563"},
        {"Renson", "Renson 13540"},
        {"Smithsonian Astrophysical Observation", "SAO 234714"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.91611256),
        dec: Angle.Degrees(-54.75185051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 790"},
        {"Hipparcos Number", "HIP 970"},
        {"Smithsonian Astrophysical Observation", "SAO 231966"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.00581153),
        dec: Angle.Degrees(-54.75088612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157163"},
        {"Hipparcos Number", "HIP 85198"},
        {"Geneva Identification System", "GEN# +1.00157163"},
        {"Smithsonian Astrophysical Observation", "SAO 244711"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.15706747),
        dec: Angle.Degrees(-54.74972840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150111"},
        {"Hipparcos Number", "HIP 81749"},
        {"Geneva Identification System", "GEN# +1.00150111"},
        {"Smithsonian Astrophysical Observation", "SAO 244071"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.46096270),
        dec: Angle.Degrees(-54.74929912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25808"},
        {"Hipparcos Number", "HIP 18860"},
        {"Smithsonian Astrophysical Observation", "SAO 233374"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.65266197),
        dec: Angle.Degrees(-54.74848255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201170"},
        {"Hipparcos Number", "HIP 104497"},
        {"Smithsonian Astrophysical Observation", "SAO 246892"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.51830412),
        dec: Angle.Degrees(-54.74729836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98543"},
        {"Hipparcos Number", "HIP 55318"},
        {"Smithsonian Astrophysical Observation", "SAO 238965"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.92331168),
        dec: Angle.Degrees(-54.74327363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9567"},
        {"Hipparcos Number", "HIP 7187"},
        {"Smithsonian Astrophysical Observation", "SAO 232456"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.14963091),
        dec: Angle.Degrees(-54.74236590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184376"},
        {"Hipparcos Number", "HIP 96498"},
        {"Smithsonian Astrophysical Observation", "SAO 246183"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.27135982),
        dec: Angle.Degrees(-54.74143417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200812"},
        {"Hipparcos Number", "HIP 104322"},
        {"Smithsonian Astrophysical Observation", "SAO 246882"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.99366863),
        dec: Angle.Degrees(-54.74058729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38214"},
        {"Hipparcos Number", "HIP 26751"},
        {"Smithsonian Astrophysical Observation", "SAO 234088"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.25640103),
        dec: Angle.Degrees(-54.73941489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103441"},
        {"Hipparcos Number", "HIP 58075"},
        {"Smithsonian Astrophysical Observation", "SAO 239483"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.64846039),
        dec: Angle.Degrees(-54.73257297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161784"},
        {"Hipparcos Number", "HIP 87316"},
        {"Geneva Identification System", "GEN# +1.00161784"},
        {"Smithsonian Astrophysical Observation", "SAO 245063"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.62580973),
        dec: Angle.Degrees(-54.73079528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49192"},
        {"Hipparcos Number", "HIP 32256"},
        {"Smithsonian Astrophysical Observation", "SAO 234682"},
    },
    visualMagnitude: 6.68,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.04086117),
        dec: Angle.Degrees(-54.73075995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216460"},
        {"Hipparcos Number", "HIP 113071"},
        {"Smithsonian Astrophysical Observation", "SAO 247636"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.50126766),
        dec: Angle.Degrees(-54.72733884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200365"},
        {"Hipparcos Number", "HIP 104085"},
        {"Fundamental Katalog 5th Edition", "FK5 3680"},
        {"Geneva Identification System", "GEN# +1.00200365"},
        {"Smithsonian Astrophysical Observation", "SAO 246854"},
        {"Wilson Evans Batten Catalogue", "WEB 18958"},
    },
    visualMagnitude: 5.17,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.30930513),
        dec: Angle.Degrees(-54.72695035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104344"},
        {"Hipparcos Number", "HIP 58583"},
        {"Smithsonian Astrophysical Observation", "SAO 239580"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.20777488),
        dec: Angle.Degrees(-54.72610620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138623"},
        {"Hipparcos Number", "HIP 76357"},
        {"Smithsonian Astrophysical Observation", "SAO 242733"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.92478198),
        dec: Angle.Degrees(-54.72559104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82377"},
        {"Hipparcos Number", "HIP 46555"},
        {"Smithsonian Astrophysical Observation", "SAO 237038"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.40794121),
        dec: Angle.Degrees(-54.72259545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138130"},
        {"Hipparcos Number", "HIP 76092"},
        {"Smithsonian Astrophysical Observation", "SAO 242662"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.10883655),
        dec: Angle.Degrees(-54.71957863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87103"},
        {"Hipparcos Number", "HIP 49098"},
        {"Geneva Identification System", "GEN# +1.00087103"},
        {"Smithsonian Astrophysical Observation", "SAO 237604"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.31588140),
        dec: Angle.Degrees(-54.71737578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219873"},
        {"Hipparcos Number", "HIP 115181"},
        {"Geneva Identification System", "GEN# +1.00219873A"},
        {"Smithsonian Astrophysical Observation", "SAO 247831"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.94814126),
        dec: Angle.Degrees(-54.71692690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97063"},
        {"Hipparcos Number", "HIP 54542"},
        {"Smithsonian Astrophysical Observation", "SAO 238824"},
    },
    visualMagnitude: 7.07,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.42103074),
        dec: Angle.Degrees(-54.71481676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104764"},
        {"Hipparcos Number", "HIP 58816"},
        {"Geneva Identification System", "GEN# +1.00104764"},
        {"Smithsonian Astrophysical Observation", "SAO 239624"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.94869909),
        dec: Angle.Degrees(-54.71467495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63870"},
        {"Hipparcos Number", "HIP 38081"},
        {"Smithsonian Astrophysical Observation", "SAO 235529"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.06274753),
        dec: Angle.Degrees(-54.71426992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27156"},
        {"Hipparcos Number", "HIP 19783"},
        {"Smithsonian Astrophysical Observation", "SAO 233445"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.60866808),
        dec: Angle.Degrees(-54.71117823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74956"},
        {"Hipparcos Number", "HIP 42913"},
        {"Celescope Catalog", "CEL 2852"},
        {"Geneva Identification System", "GEN# +1.00074956"},
        {"Smithsonian Astrophysical Observation", "SAO 236232"},
        {"Wilson Evans Batten Catalogue", "WEB 8293"},
    },
    visualMagnitude: 1.93,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.17582214),
        dec: Angle.Degrees(-54.70856797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62400"},
        {"Hipparcos Number", "HIP 37414"},
        {"Geneva Identification System", "GEN# +1.00062400"},
        {"Smithsonian Astrophysical Observation", "SAO 235414"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.21797898),
        dec: Angle.Degrees(-54.70704448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109609"},
        {"Hipparcos Number", "HIP 61530"},
        {"Smithsonian Astrophysical Observation", "SAO 240087"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.09337733),
        dec: Angle.Degrees(-54.70576863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149695"},
        {"Hipparcos Number", "HIP 81548"},
        {"Smithsonian Astrophysical Observation", "SAO 244026"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.83123931),
        dec: Angle.Degrees(-54.70519812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80251"},
        {"Hipparcos Number", "HIP 45513"},
        {"Smithsonian Astrophysical Observation", "SAO 236791"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.11929843),
        dec: Angle.Degrees(-54.70462320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121384"},
        {"Hipparcos Number", "HIP 68101"},
        {"Geneva Identification System", "GEN# +1.00121384A"},
        {"Smithsonian Astrophysical Observation", "SAO 241315"},
        {"Wilson Evans Batten Catalogue", "WEB 11954"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.13744030),
        dec: Angle.Degrees(-54.70411568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101145"},
        {"Hipparcos Number", "HIP 56740"},
        {"Geneva Identification System", "GEN# +1.00101145"},
        {"Smithsonian Astrophysical Observation", "SAO 239241"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.50631534),
        dec: Angle.Degrees(-54.70305523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171793"},
        {"Hipparcos Number", "HIP 91517"},
        {"Geneva Identification System", "GEN# +1.00171793"},
        {"Smithsonian Astrophysical Observation", "SAO 245617"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.95304879),
        dec: Angle.Degrees(-54.70030747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76612"},
        {"Hipparcos Number", "HIP 43780"},
        {"Geneva Identification System", "GEN# +1.00076612"},
        {"Smithsonian Astrophysical Observation", "SAO 236400"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.75171456),
        dec: Angle.Degrees(-54.69948794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10671"},
        {"Hipparcos Number", "HIP 8009"},
        {"Renson", "Renson 2650"},
        {"Smithsonian Astrophysical Observation", "SAO 232503"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.70561812),
        dec: Angle.Degrees(-54.69704773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49219"},
        {"Hipparcos Number", "HIP 32269"},
        {"Geneva Identification System", "GEN# +1.00049219"},
        {"Smithsonian Astrophysical Observation", "SAO 234683"},
    },
    visualMagnitude: 6.47,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.05336472),
        dec: Angle.Degrees(-54.69552342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49705"},
        {"Hipparcos Number", "HIP 32477"},
        {"Geneva Identification System", "GEN# +1.00049705J"},
        {"Smithsonian Astrophysical Observation", "SAO 234704"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.67373429),
        dec: Angle.Degrees(-54.69506225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104732"},
        {"Hipparcos Number", "HIP 58801"},
        {"Smithsonian Astrophysical Observation", "SAO 239619"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.90916256),
        dec: Angle.Degrees(-54.69372945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158280"},
        {"Hipparcos Number", "HIP 85753"},
        {"Geneva Identification System", "GEN# +1.00158280"},
        {"Smithsonian Astrophysical Observation", "SAO 244812"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.85044113),
        dec: Angle.Degrees(-54.69349178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65385"},
    },
    visualMagnitude: 12.42,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.00086151),
        dec: Angle.Degrees(-52.89052156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114855"},
        {"Hipparcos Number", "HIP 64572"},
        {"Geneva Identification System", "GEN# +1.00114855"},
        {"Smithsonian Astrophysical Observation", "SAO 240664"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.53448672),
        dec: Angle.Degrees(-54.69294443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27773"},
        {"Hipparcos Number", "HIP 20228"},
        {"Smithsonian Astrophysical Observation", "SAO 233488"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.03749693),
        dec: Angle.Degrees(-54.69246574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169664"},
        {"Hipparcos Number", "HIP 90566"},
        {"Smithsonian Astrophysical Observation", "SAO 245504"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.20575784),
        dec: Angle.Degrees(-54.69204703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93630"},
        {"Hipparcos Number", "HIP 52788"},
        {"Geneva Identification System", "GEN# +1.00093630"},
        {"Smithsonian Astrophysical Observation", "SAO 238479"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.88539317),
        dec: Angle.Degrees(-54.69123938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41232"},
        {"Hipparcos Number", "HIP 28466"},
        {"Smithsonian Astrophysical Observation", "SAO 234249"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.15223341),
        dec: Angle.Degrees(-54.69103310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222839"},
        {"Hipparcos Number", "HIP 117086"},
        {"Smithsonian Astrophysical Observation", "SAO 248000"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.04622994),
        dec: Angle.Degrees(-54.69014762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80230",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80230"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.67621462),
        dec: Angle.Degrees(-54.68821958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76064"},
        {"Hipparcos Number", "HIP 43497"},
        {"Smithsonian Astrophysical Observation", "SAO 236336"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.89395568),
        dec: Angle.Degrees(-54.68476271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119727"},
        {"Hipparcos Number", "HIP 67199"},
        {"Smithsonian Astrophysical Observation", "SAO 241152"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.56058716),
        dec: Angle.Degrees(-54.68331282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115455",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115455"},
    },
    visualMagnitude: 10.97,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.80853769),
        dec: Angle.Degrees(-54.68164715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 124.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44001"},
        {"Hipparcos Number", "HIP 29768"},
        {"Smithsonian Astrophysical Observation", "SAO 234412"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.02672698),
        dec: Angle.Degrees(-54.67818504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194555"},
        {"Hipparcos Number", "HIP 101026"},
        {"Smithsonian Astrophysical Observation", "SAO 246602"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.21396625),
        dec: Angle.Degrees(-54.67781642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179646"},
        {"Hipparcos Number", "HIP 94710"},
        {"Renson", "Renson 49870"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.08042852),
        dec: Angle.Degrees(-54.67250115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122844"},
        {"Hipparcos Number", "HIP 68842"},
        {"Celescope Catalog", "CEL 4299"},
        {"Fundamental Katalog 5th Edition", "FK5 3119"},
        {"Geneva Identification System", "GEN# +1.00122844"},
        {"Smithsonian Astrophysical Observation", "SAO 241430"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.44387814),
        dec: Angle.Degrees(-54.66930165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73169"},
        {"Hipparcos Number", "HIP 42061"},
        {"Smithsonian Astrophysical Observation", "SAO 236094"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.60157582),
        dec: Angle.Degrees(-54.66754952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112823"},
        {"Hipparcos Number", "HIP 63448"},
        {"Smithsonian Astrophysical Observation", "SAO 240464"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.02187891),
        dec: Angle.Degrees(-54.66707045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13527"},
        {"Hipparcos Number", "HIP 10134"},
        {"Smithsonian Astrophysical Observation", "SAO 232660"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.58337927),
        dec: Angle.Degrees(-54.66524765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66706"},
        {"Hipparcos Number", "HIP 39286"},
        {"Geneva Identification System", "GEN# +1.00066706"},
        {"Smithsonian Astrophysical Observation", "SAO 235694"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.49923180),
        dec: Angle.Degrees(-54.66250382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203760"},
        {"Hipparcos Number", "HIP 105841"},
        {"Fundamental Katalog 5th Edition", "FK5 1563"},
        {"Geneva Identification System", "GEN# +1.00203760"},
        {"Smithsonian Astrophysical Observation", "SAO 247031"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.56432591),
        dec: Angle.Degrees(-54.66055359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116604"},
        {"Hipparcos Number", "HIP 65511"},
        {"Smithsonian Astrophysical Observation", "SAO 240830"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.42565506),
        dec: Angle.Degrees(-54.66020669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79845"},
        {"Hipparcos Number", "HIP 45330"},
        {"Smithsonian Astrophysical Observation", "SAO 236748"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.57976638),
        dec: Angle.Degrees(-54.65962869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109231"},
        {"Hipparcos Number", "HIP 61286"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.37812308),
        dec: Angle.Degrees(-54.65939979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85683"},
        {"Hipparcos Number", "HIP 48376"},
        {"Geneva Identification System", "GEN# +1.00085683"},
        {"Smithsonian Astrophysical Observation", "SAO 237423"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.92225149),
        dec: Angle.Degrees(-54.65933716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29671"},
        {"Hipparcos Number", "HIP 21540"},
        {"Smithsonian Astrophysical Observation", "SAO 233597"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.37043129),
        dec: Angle.Degrees(-54.65647674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130827"},
        {"Hipparcos Number", "HIP 72746"},
        {"Smithsonian Astrophysical Observation", "SAO 242074"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.08399434),
        dec: Angle.Degrees(-54.65635493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80268"},
        {"Hipparcos Number", "HIP 45523"},
        {"Celescope Catalog", "CEL 3252"},
        {"Geneva Identification System", "GEN# +1.00080268"},
        {"Smithsonian Astrophysical Observation", "SAO 236801"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.16734633),
        dec: Angle.Degrees(-54.65590837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208740"},
        {"Hipparcos Number", "HIP 108598"},
        {"Geneva Identification System", "GEN# +1.00208740"},
        {"Smithsonian Astrophysical Observation", "SAO 247259"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.98581884),
        dec: Angle.Degrees(-54.65464800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144243"},
        {"Hipparcos Number", "HIP 79002"},
        {"Geneva Identification System", "GEN# +1.00144243"},
        {"Smithsonian Astrophysical Observation", "SAO 243343"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.89860922),
        dec: Angle.Degrees(-54.65344486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207607"},
        {"Hipparcos Number", "HIP 107921"},
        {"Smithsonian Astrophysical Observation", "SAO 247208"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.97384188),
        dec: Angle.Degrees(-54.65210591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218571"},
        {"Hipparcos Number", "HIP 114364"},
        {"Smithsonian Astrophysical Observation", "SAO 247760"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.43278150),
        dec: Angle.Degrees(-54.65112699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219695"},
        {"Hipparcos Number", "HIP 115073"},
        {"Smithsonian Astrophysical Observation", "SAO 247820"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.61358575),
        dec: Angle.Degrees(-54.64945461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6981"},
        {"Hipparcos Number", "HIP 5423"},
        {"Smithsonian Astrophysical Observation", "SAO 232313"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.32052694),
        dec: Angle.Degrees(-54.64894113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224582"},
        {"Hipparcos Number", "HIP 118248"},
        {"Smithsonian Astrophysical Observation", "SAO 248089"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.76329566),
        dec: Angle.Degrees(-54.64633478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170150"},
        {"Hipparcos Number", "HIP 90757"},
        {"Geneva Identification System", "GEN# +1.00170150"},
        {"Smithsonian Astrophysical Observation", "SAO 245520"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.75963170),
        dec: Angle.Degrees(-54.64594919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116476"},
    },
    visualMagnitude: 11.19,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.01713223),
        dec: Angle.Degrees(-54.64544610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159851"},
        {"Hipparcos Number", "HIP 86449"},
        {"Smithsonian Astrophysical Observation", "SAO 244925"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.96173289),
        dec: Angle.Degrees(-54.64524278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77994"},
        {"Geneva Identification System", "GEN# -0.05406791"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.91500963),
        dec: Angle.Degrees(-54.64350792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146268"},
        {"Hipparcos Number", "HIP 79864"},
        {"Smithsonian Astrophysical Observation", "SAO 243562"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.53288774),
        dec: Angle.Degrees(-54.64321987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65250"},
        {"Hipparcos Number", "HIP 38671"},
        {"Smithsonian Astrophysical Observation", "SAO 235616"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.76500032),
        dec: Angle.Degrees(-54.64149724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120"},
        {"Hipparcos Number", "HIP 499"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.49565621),
        dec: Angle.Degrees(-54.64056978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63178"},
        {"Hipparcos Number", "HIP 37767"},
        {"Smithsonian Astrophysical Observation", "SAO 235476"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.16922147),
        dec: Angle.Degrees(-54.64011203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168910"},
        {"Hipparcos Number", "HIP 90277"},
        {"Geneva Identification System", "GEN# +1.00168910"},
        {"Smithsonian Astrophysical Observation", "SAO 245453"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.30500160),
        dec: Angle.Degrees(-54.63908027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26490"},
        {"Hipparcos Number", "HIP 19344"},
        {"Smithsonian Astrophysical Observation", "SAO 233412"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.16525032),
        dec: Angle.Degrees(-54.63811795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61903"},
        {"Hipparcos Number", "HIP 37206"},
        {"Geneva Identification System", "GEN# +1.00061903"},
        {"Smithsonian Astrophysical Observation", "SAO 235383"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.64508217),
        dec: Angle.Degrees(-54.63675085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103440"},
        {"Hipparcos Number", "HIP 58068"},
        {"Geneva Identification System", "GEN# +1.00103440"},
        {"Smithsonian Astrophysical Observation", "SAO 239482"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.63946762),
        dec: Angle.Degrees(-54.63455816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147075"},
        {"Hipparcos Number", "HIP 80209"},
        {"Geneva Identification System", "GEN# +1.00147075"},
        {"Smithsonian Astrophysical Observation", "SAO 243708"},
        {"Wilson Evans Batten Catalogue", "WEB 13577"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.61751564),
        dec: Angle.Degrees(-54.63450542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77226"},
        {"Hipparcos Number", "HIP 44098"},
        {"Celescope Catalog", "CEL 3128"},
        {"Smithsonian Astrophysical Observation", "SAO 236463"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.73228066),
        dec: Angle.Degrees(-54.63419634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93126"},
        {"Hipparcos Number", "HIP 52512"},
        {"Geneva Identification System", "GEN# +1.00093126"},
        {"Smithsonian Astrophysical Observation", "SAO 238405"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.06052846),
        dec: Angle.Degrees(-54.63291197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123800"},
        {"Hipparcos Number", "HIP 69327"},
        {"Geneva Identification System", "GEN# +1.00123800"},
        {"Smithsonian Astrophysical Observation", "SAO 241516"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.83334632),
        dec: Angle.Degrees(-54.63212032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145397"},
        {"Hipparcos Number", "HIP 79509"},
        {"Fundamental Katalog 5th Edition", "FK5 600"},
        {"Geneva Identification System", "GEN# +1.00145397"},
        {"Smithsonian Astrophysical Observation", "SAO 243454"},
        {"Wilson Evans Batten Catalogue", "WEB 13456"},
    },
    visualMagnitude: 4.95,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.36972631),
        dec: Angle.Degrees(-54.63041289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134764"},
        {"Hipparcos Number", "HIP 74546"},
        {"Smithsonian Astrophysical Observation", "SAO 242328"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.48458283),
        dec: Angle.Degrees(-54.63024205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55002"},
        {"Hipparcos Number", "HIP 34427"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.05230605),
        dec: Angle.Degrees(-54.62943051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212606"},
        {"Hipparcos Number", "HIP 110794"},
        {"Smithsonian Astrophysical Observation", "SAO 247449"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.70380971),
        dec: Angle.Degrees(-54.62942285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20495"},
        {"Hipparcos Number", "HIP 15166"},
        {"Smithsonian Astrophysical Observation", "SAO 233053"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.87261117),
        dec: Angle.Degrees(-54.62712262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124195"},
        {"Hipparcos Number", "HIP 69491"},
        {"Celescope Catalog", "CEL 4307"},
        {"Geneva Identification System", "GEN# +1.00124195"},
        {"Smithsonian Astrophysical Observation", "SAO 241552"},
        {"Wilson Evans Batten Catalogue", "WEB 12109"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.41601305),
        dec: Angle.Degrees(-54.62560013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89429"},
        {"Hipparcos Number", "HIP 50437"},
        {"Celescope Catalog", "CEL 3490"},
        {"Geneva Identification System", "GEN# +1.00089429"},
        {"Smithsonian Astrophysical Observation", "SAO 237884"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.47000669),
        dec: Angle.Degrees(-54.62317781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2482"},
        {"Hipparcos Number", "HIP 2226"},
        {"Smithsonian Astrophysical Observation", "SAO 232053"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.05655665),
        dec: Angle.Degrees(-54.62257293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29578"},
        {"Hipparcos Number", "HIP 21460"},
        {"Renson", "Renson 7580"},
        {"Smithsonian Astrophysical Observation", "SAO 233590"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.12816606),
        dec: Angle.Degrees(-54.62122593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41093"},
        {"Hipparcos Number", "HIP 28383"},
        {"Smithsonian Astrophysical Observation", "SAO 234242"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.93726550),
        dec: Angle.Degrees(-54.61790063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44104"},
        {"Hipparcos Number", "HIP 29820"},
        {"Smithsonian Astrophysical Observation", "SAO 234419"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.20017634),
        dec: Angle.Degrees(-54.61703288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181271"},
        {"Hipparcos Number", "HIP 95251"},
        {"Smithsonian Astrophysical Observation", "SAO 246052"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.69765847),
        dec: Angle.Degrees(-54.61544341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114042"},
        {"Hipparcos Number", "HIP 64130"},
        {"Smithsonian Astrophysical Observation", "SAO 240590"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.16004513),
        dec: Angle.Degrees(-54.61428845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220560"},
        {"Hipparcos Number", "HIP 115612"},
        {"Smithsonian Astrophysical Observation", "SAO 247865"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.29947970),
        dec: Angle.Degrees(-54.61276276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110924"},
        {"Hipparcos Number", "HIP 62312"},
        {"Smithsonian Astrophysical Observation", "SAO 240229"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.52289965),
        dec: Angle.Degrees(-54.61220739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119269"},
        {"Hipparcos Number", "HIP 66963"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.86905294),
        dec: Angle.Degrees(-54.61201791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213941"},
        {"Hipparcos Number", "HIP 111565"},
        {"Cincinnati Publication", "Ci 20 1371"},
        {"Geneva Identification System", "GEN# +1.00213941"},
        {"Smithsonian Astrophysical Observation", "SAO 247509"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.03057483),
        dec: Angle.Degrees(-54.60998608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 362.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -261.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88802"},
    },
    visualMagnitude: 12.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.91756454),
        dec: Angle.Degrees(-54.60798806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129088"},
        {"Hipparcos Number", "HIP 71910"},
        {"Smithsonian Astrophysical Observation", "SAO 241923"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.63100446),
        dec: Angle.Degrees(-54.59904978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3799"},
        {"Hipparcos Number", "HIP 3156"},
        {"Smithsonian Astrophysical Observation", "SAO 232139"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.02970931),
        dec: Angle.Degrees(-54.59802572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153053"},
        {"Hipparcos Number", "HIP 83187"},
        {"Geneva Identification System", "GEN# +1.00153053"},
        {"Smithsonian Astrophysical Observation", "SAO 244338"},
        {"Wilson Evans Batten Catalogue", "WEB 14061"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.02619645),
        dec: Angle.Degrees(-54.59700158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85759"},
        {"Hipparcos Number", "HIP 48416"},
        {"Geneva Identification System", "GEN# +1.00085759"},
        {"Smithsonian Astrophysical Observation", "SAO 237430"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.06015233),
        dec: Angle.Degrees(-54.59660533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82875"},
        {"Hipparcos Number", "HIP 46852"},
        {"Smithsonian Astrophysical Observation", "SAO 237089"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.21594628),
        dec: Angle.Degrees(-54.59611378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4838"},
        {"Hipparcos Number", "HIP 3879"},
        {"Geneva Identification System", "GEN# +1.00004838"},
        {"Geneva Identification System 2", "GEN# +6.20145175"},
        {"Smithsonian Astrophysical Observation", "SAO 232200"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.45094373),
        dec: Angle.Degrees(-54.59336435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30278"},
        {"Hipparcos Number", "HIP 21960"},
        {"Geneva Identification System", "GEN# +1.00030278"},
        {"Smithsonian Astrophysical Observation", "SAO 233644"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.80680650),
        dec: Angle.Degrees(-54.59294392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157836"},
        {"Hipparcos Number", "HIP 85529"},
        {"Geneva Identification System", "GEN# +1.00157836"},
        {"Smithsonian Astrophysical Observation", "SAO 244774"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.18207940),
        dec: Angle.Degrees(-54.59279220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87800"},
        {"Hipparcos Number", "HIP 49468"},
        {"Celescope Catalog", "CEL 3441"},
        {"Geneva Identification System", "GEN# +1.00087800"},
        {"Smithsonian Astrophysical Observation", "SAO 237687"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.48576705),
        dec: Angle.Degrees(-54.59270767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5283"},
        {"Hipparcos Number", "HIP 4228"},
        {"Geneva Identification System", "GEN# +1.00005283"},
        {"Smithsonian Astrophysical Observation", "SAO 232221"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.48661235),
        dec: Angle.Degrees(-54.59233089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33847",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33847"},
        {"Smithsonian Astrophysical Observation", "SAO 234865"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.39535132),
        dec: Angle.Degrees(-54.59181568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47065"},
        {"Hipparcos Number", "HIP 31279"},
        {"Smithsonian Astrophysical Observation", "SAO 234578"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.40827924),
        dec: Angle.Degrees(-54.59045424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113277"},
        {"Hipparcos Number", "HIP 63712"},
        {"Smithsonian Astrophysical Observation", "SAO 240506"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.84988273),
        dec: Angle.Degrees(-54.59015457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112381"},
        {"Hipparcos Number", "HIP 63204"},
        {"Celescope Catalog", "CEL 4175"},
        {"Geneva Identification System", "GEN# +1.00112381"},
        {"Renson", "Renson 32630"},
        {"Smithsonian Astrophysical Observation", "SAO 240405"},
    },
    visualMagnitude: 6.48,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.24273367),
        dec: Angle.Degrees(-54.58731036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90049"},
        {"Hipparcos Number", "HIP 50789"},
        {"Geneva Identification System", "GEN# +1.00090049"},
        {"Smithsonian Astrophysical Observation", "SAO 237988"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.55109051),
        dec: Angle.Degrees(-54.58689032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109515"},
        {"Hipparcos Number", "HIP 61454"},
        {"Smithsonian Astrophysical Observation", "SAO 240082"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.90214113),
        dec: Angle.Degrees(-54.58682263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103424"},
        {"Hipparcos Number", "HIP 58054"},
        {"Smithsonian Astrophysical Observation", "SAO 239479"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.60600803),
        dec: Angle.Degrees(-54.58451171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205124"},
        {"Hipparcos Number", "HIP 106577"},
        {"Smithsonian Astrophysical Observation", "SAO 247095"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.77442296),
        dec: Angle.Degrees(-54.58427629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126114"},
        {"Hipparcos Number", "HIP 70506"},
        {"Geneva Identification System", "GEN# +1.00126114"},
        {"Smithsonian Astrophysical Observation", "SAO 241703"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.34197162),
        dec: Angle.Degrees(-54.58340696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111052"},
        {"Hipparcos Number", "HIP 62389"},
        {"Geneva Identification System", "GEN# +1.00111052"},
        {"Smithsonian Astrophysical Observation", "SAO 240247"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.79434201),
        dec: Angle.Degrees(-54.58267125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180934"},
        {"Hipparcos Number", "HIP 95139"},
        {"Geneva Identification System", "GEN# +1.00180934"},
        {"Smithsonian Astrophysical Observation", "SAO 246043"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.34633678),
        dec: Angle.Degrees(-54.58241554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119016"},
        {"Hipparcos Number", "HIP 66851"},
        {"Smithsonian Astrophysical Observation", "SAO 241082"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.50835266),
        dec: Angle.Degrees(-54.58198329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121121"},
        {"Hipparcos Number", "HIP 67954"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.74478612),
        dec: Angle.Degrees(-54.58056927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163360"},
        {"Hipparcos Number", "HIP 88027"},
        {"Smithsonian Astrophysical Observation", "SAO 245151"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.69826435),
        dec: Angle.Degrees(-54.57984665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120764"},
        {"Hipparcos Number", "HIP 67755"},
        {"Geneva Identification System", "GEN# +1.00120764"},
        {"Smithsonian Astrophysical Observation", "SAO 241250"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.20841930),
        dec: Angle.Degrees(-54.57901271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -265.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89514"},
        {"Hipparcos Number", "HIP 50477"},
        {"Smithsonian Astrophysical Observation", "SAO 237896"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.59936542),
        dec: Angle.Degrees(-54.57884255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129087"},
        {"Hipparcos Number", "HIP 71920"},
        {"Smithsonian Astrophysical Observation", "SAO 241924"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.64742277),
        dec: Angle.Degrees(-54.57865522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85122"},
        {"Hipparcos Number", "HIP 48079"},
        {"Smithsonian Astrophysical Observation", "SAO 237352"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.02117197),
        dec: Angle.Degrees(-54.57840775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143101"},
        {"Hipparcos Number", "HIP 78469"},
        {"Geneva Identification System", "GEN# +1.00143101"},
        {"Smithsonian Astrophysical Observation", "SAO 243246"},
        {"Wilson Evans Batten Catalogue", "WEB 13266"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.27710869),
        dec: Angle.Degrees(-54.57779898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203465"},
        {"Hipparcos Number", "HIP 105692"},
        {"Smithsonian Astrophysical Observation", "SAO 247013"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.10033160),
        dec: Angle.Degrees(-54.57767177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78932"},
        {"Hipparcos Number", "HIP 44889"},
        {"Smithsonian Astrophysical Observation", "SAO 236659"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.19371073),
        dec: Angle.Degrees(-54.57521997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176370"},
        {"Hipparcos Number", "HIP 93534"},
        {"Geneva Identification System", "GEN# +1.00176370"},
        {"Smithsonian Astrophysical Observation", "SAO 245881"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.75729009),
        dec: Angle.Degrees(-54.57461736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88756"},
        {"Hipparcos Number", "HIP 50031"},
        {"Geneva Identification System", "GEN# +1.00088756"},
        {"Smithsonian Astrophysical Observation", "SAO 237794"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.21828196),
        dec: Angle.Degrees(-54.57371522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201247"},
        {"Hipparcos Number", "HIP 104526"},
        {"Smithsonian Astrophysical Observation", "SAO 246894"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.60510791),
        dec: Angle.Degrees(-54.57369241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1740"},
        {"Hipparcos Number", "HIP 1697"},
        {"Smithsonian Astrophysical Observation", "SAO 232006"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.33822814),
        dec: Angle.Degrees(-54.57346633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173446"},
        {"Hipparcos Number", "HIP 92274"},
        {"Smithsonian Astrophysical Observation", "SAO 245716"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.08765431),
        dec: Angle.Degrees(-54.56837559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95475"},
        {"Hipparcos Number", "HIP 53789"},
        {"Smithsonian Astrophysical Observation", "SAO 238678"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.07679975),
        dec: Angle.Degrees(-54.56790704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86440"},
        {"Hipparcos Number", "HIP 48774"},
        {"Celescope Catalog", "CEL 3412"},
        {"Fundamental Katalog 5th Edition", "FK5 375"},
        {"Geneva Identification System", "GEN# +1.00086440A"},
        {"Smithsonian Astrophysical Observation", "SAO 237522"},
        {"Wilson Evans Batten Catalogue", "WEB 9069"},
    },
    visualMagnitude: 3.52,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.21564520),
        dec: Angle.Degrees(-54.56779730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49134"},
        {"Hipparcos Number", "HIP 32242"},
        {"Geneva Identification System", "GEN# +1.00049134"},
        {"Smithsonian Astrophysical Observation", "SAO 234678"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.96681089),
        dec: Angle.Degrees(-54.56764850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 151.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175054"},
        {"Hipparcos Number", "HIP 92981"},
        {"Smithsonian Astrophysical Observation", "SAO 245816"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.14331160),
        dec: Angle.Degrees(-54.56708676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26462",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26462"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.44012782),
        dec: Angle.Degrees(-54.56691123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2029"},
        {"Hipparcos Number", "HIP 1912"},
        {"Geneva Identification System", "GEN# +1.00002029"},
        {"Smithsonian Astrophysical Observation", "SAO 232024"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.04983733),
        dec: Angle.Degrees(-54.56650595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77913",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77913"},
        {"Geneva Identification System", "GEN# -0.05406774"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.67839960),
        dec: Angle.Degrees(-54.56642664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37761"},
        {"Hipparcos Number", "HIP 26468"},
        {"Geneva Identification System", "GEN# +1.00037761"},
        {"Smithsonian Astrophysical Observation", "SAO 234056"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.45115461),
        dec: Angle.Degrees(-54.56447001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87986"},
        {"Hipparcos Number", "HIP 49566"},
        {"Geneva Identification System", "GEN# +1.00087986J"},
        {"Smithsonian Astrophysical Observation", "SAO 237707"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.78475166),
        dec: Angle.Degrees(-54.56381453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198492"},
        {"Hipparcos Number", "HIP 103064"},
        {"Smithsonian Astrophysical Observation", "SAO 246766"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.22478991),
        dec: Angle.Degrees(-54.56367719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211970"},
        {"Hipparcos Number", "HIP 110443"},
        {"Geneva Identification System", "GEN# +1.00211970"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.56829764),
        dec: Angle.Degrees(-54.56118326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 232.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153466"},
        {"Hipparcos Number", "HIP 83402"},
        {"Smithsonian Astrophysical Observation", "SAO 244381"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.68436607),
        dec: Angle.Degrees(-54.56113757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94644"},
        {"Hipparcos Number", "HIP 53353"},
        {"Smithsonian Astrophysical Observation", "SAO 238591"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.67423348),
        dec: Angle.Degrees(-54.56030095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118991"},
        {"Hipparcos Number", "HIP 66821"},
        {"Celescope Catalog", "CEL 4277"},
        {"Geneva Identification System", "GEN# +1.00118991"},
        {"Smithsonian Astrophysical Observation", "SAO 241076"},
        {"Wilson Evans Batten Catalogue", "WEB 11779"},
    },
    visualMagnitude: 4.99,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.43672827),
        dec: Angle.Degrees(-54.55936543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202690"},
        {"Hipparcos Number", "HIP 105291"},
        {"Geneva Identification System", "GEN# +1.00202690"},
        {"Smithsonian Astrophysical Observation", "SAO 246963"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.90196201),
        dec: Angle.Degrees(-54.55895133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168713"},
        {"Hipparcos Number", "HIP 90189"},
        {"Smithsonian Astrophysical Observation", "SAO 245442"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.05112983),
        dec: Angle.Degrees(-54.55888157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43850"},
        {"Hipparcos Number", "HIP 29693"},
        {"Geneva Identification System", "GEN# +1.00043850"},
        {"Smithsonian Astrophysical Observation", "SAO 234403"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.82570820),
        dec: Angle.Degrees(-54.55865164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196767"},
        {"Hipparcos Number", "HIP 102143"},
        {"Smithsonian Astrophysical Observation", "SAO 246696"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.46432765),
        dec: Angle.Degrees(-54.55846006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87380"},
        {"Hipparcos Number", "HIP 49234"},
        {"Celescope Catalog", "CEL 3429"},
        {"Geneva Identification System", "GEN# +1.00087380"},
        {"Smithsonian Astrophysical Observation", "SAO 237633"},
        {"Wilson Evans Batten Catalogue", "WEB 9116"},
    },
    visualMagnitude: 9.11,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.75581479),
        dec: Angle.Degrees(-54.55845302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207881"},
        {"Hipparcos Number", "HIP 108079"},
        {"Smithsonian Astrophysical Observation", "SAO 247219"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.46949851),
        dec: Angle.Degrees(-54.55818279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10061"},
        {"Hipparcos Number", "HIP 7533"},
        {"Geneva Identification System", "GEN# +1.00010061"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.25995919),
        dec: Angle.Degrees(-54.55799525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126043"},
        {"Hipparcos Number", "HIP 70477"},
        {"Geneva Identification System", "GEN# +1.00126043"},
        {"Smithsonian Astrophysical Observation", "SAO 241700"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.23687517),
        dec: Angle.Degrees(-54.55752119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97317"},
        {"Hipparcos Number", "HIP 54659"},
        {"Geneva Identification System", "GEN# +1.00097317"},
        {"Smithsonian Astrophysical Observation", "SAO 238844"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.83491998),
        dec: Angle.Degrees(-54.55702150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100611"},
        {"Hipparcos Number", "HIP 56435"},
        {"Smithsonian Astrophysical Observation", "SAO 239179"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.55701691),
        dec: Angle.Degrees(-54.55560868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148217"},
        {"Hipparcos Number", "HIP 80757"},
        {"Geneva Identification System", "GEN# +1.00148217"},
        {"Smithsonian Astrophysical Observation", "SAO 243866"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.33226699),
        dec: Angle.Degrees(-54.55428559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109949"},
        {"Hipparcos Number", "HIP 61736"},
        {"Smithsonian Astrophysical Observation", "SAO 240117"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.80542855),
        dec: Angle.Degrees(-54.55000759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16920"},
        {"Hipparcos Number", "HIP 12484"},
        {"Fundamental Katalog 5th Edition", "FK5 1076"},
        {"Geneva Identification System", "GEN# +1.00016920"},
        {"Smithsonian Astrophysical Observation", "SAO 232857"},
        {"Wilson Evans Batten Catalogue", "WEB 2556"},
    },
    visualMagnitude: 5.21,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.16491631),
        dec: Angle.Degrees(-54.54992422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101582"},
        {"Hipparcos Number", "HIP 56993"},
        {"Geneva Identification System", "GEN# +1.00101582"},
        {"Smithsonian Astrophysical Observation", "SAO 239289"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.25106880),
        dec: Angle.Degrees(-54.54875656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66064"},
        {"Hipparcos Number", "HIP 39019"},
        {"Fundamental Katalog 5th Edition", "FK5 4719"},
        {"Smithsonian Astrophysical Observation", "SAO 235658"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.76959364),
        dec: Angle.Degrees(-54.54691589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218735"},
        {"Hipparcos Number", "HIP 114472"},
        {"Smithsonian Astrophysical Observation", "SAO 247766"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.74593528),
        dec: Angle.Degrees(-54.54582998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157699"},
        {"Hipparcos Number", "HIP 85461"},
        {"Smithsonian Astrophysical Observation", "SAO 244762"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.96286790),
        dec: Angle.Degrees(-54.54534579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192759"},
        {"Hipparcos Number", "HIP 100183"},
        {"Smithsonian Astrophysical Observation", "SAO 246527"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.80884426),
        dec: Angle.Degrees(-54.54469280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81174"},
        {"Hipparcos Number", "HIP 45937"},
        {"Geneva Identification System", "GEN# +1.00081174"},
        {"Smithsonian Astrophysical Observation", "SAO 236889"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.50593834),
        dec: Angle.Degrees(-54.54392184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 121.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15050"},
        {"Hipparcos Number", "HIP 11163"},
        {"Smithsonian Astrophysical Observation", "SAO 232747"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.91084264),
        dec: Angle.Degrees(-54.54314000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193677"},
        {"Hipparcos Number", "HIP 100617"},
        {"Smithsonian Astrophysical Observation", "SAO 246560"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.03770179),
        dec: Angle.Degrees(-54.54302196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15395"},
        {"Hipparcos Number", "HIP 11387"},
        {"Geneva Identification System", "GEN# +1.00015395"},
        {"Smithsonian Astrophysical Observation", "SAO 232771"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.68632897),
        dec: Angle.Degrees(-54.54275724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74304"},
        {"Hipparcos Number", "HIP 42591"},
        {"Geneva Identification System", "GEN# +1.00074304"},
        {"Smithsonian Astrophysical Observation", "SAO 236178"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.21012253),
        dec: Angle.Degrees(-54.54196329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70396"},
        {"Hipparcos Number", "HIP 40757"},
        {"Smithsonian Astrophysical Observation", "SAO 235880"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.79102224),
        dec: Angle.Degrees(-54.53979530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1974"},
        {"Hipparcos Number", "HIP 1875"},
        {"Smithsonian Astrophysical Observation", "SAO 232019"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.92031611),
        dec: Angle.Degrees(-54.53864428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181327"},
        {"Hipparcos Number", "HIP 95270"},
        {"Geneva Identification System", "GEN# +1.00181327"},
        {"Smithsonian Astrophysical Observation", "SAO 246056"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.74549548),
        dec: Angle.Degrees(-54.53784921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189564"},
        {"Hipparcos Number", "HIP 98743"},
        {"Renson", "Renson 52550"},
        {"Smithsonian Astrophysical Observation", "SAO 246409"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.83383826),
        dec: Angle.Degrees(-54.53734583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101762"},
        {"Hipparcos Number", "HIP 57101"},
        {"Smithsonian Astrophysical Observation", "SAO 239307"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.58051341),
        dec: Angle.Degrees(-54.53524364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173757"},
        {"Hipparcos Number", "HIP 92407"},
        {"Smithsonian Astrophysical Observation", "SAO 245737"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.47585878),
        dec: Angle.Degrees(-54.53464681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92908"},
        {"Hipparcos Number", "HIP 52394"},
        {"Smithsonian Astrophysical Observation", "SAO 238375"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.64537399),
        dec: Angle.Degrees(-54.53239483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183579"},
        {"Hipparcos Number", "HIP 96160"},
        {"Geneva Identification System", "GEN# +1.00183579"},
        {"Smithsonian Astrophysical Observation", "SAO 246154"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.28535740),
        dec: Angle.Degrees(-54.53217103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14990"},
        {"Hipparcos Number", "HIP 11122"},
        {"Smithsonian Astrophysical Observation", "SAO 232741"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.78260131),
        dec: Angle.Degrees(-54.53109437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62071"},
        {"Geneva Identification System", "GEN# -0.05305293"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.82165954),
        dec: Angle.Degrees(-54.52798351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80125"},
        {"Hipparcos Number", "HIP 45451"},
        {"Celescope Catalog", "CEL 3249"},
        {"Geneva Identification System", "GEN# +1.00080125"},
        {"Smithsonian Astrophysical Observation", "SAO 236781"},
    },
    visualMagnitude: 8.82,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.94980403),
        dec: Angle.Degrees(-54.52349614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139000"},
        {"Hipparcos Number", "HIP 76549"},
        {"Geneva Identification System", "GEN# +1.00139000"},
        {"Smithsonian Astrophysical Observation", "SAO 242780"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.50912126),
        dec: Angle.Degrees(-54.52198414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110290"},
        {"Hipparcos Number", "HIP 61933"},
        {"Geneva Identification System", "GEN# +1.00110290"},
        {"Smithsonian Astrophysical Observation", "SAO 240155"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.38229437),
        dec: Angle.Degrees(-54.51757027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223519"},
        {"Hipparcos Number", "HIP 117552"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.59251726),
        dec: Angle.Degrees(-54.51677291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66546"},
        {"Hipparcos Number", "HIP 39225"},
        {"Celescope Catalog", "CEL 2144"},
        {"Geneva Identification System", "GEN# +1.00066546"},
        {"Smithsonian Astrophysical Observation", "SAO 235686"},
        {"Wilson Evans Batten Catalogue", "WEB 7692"},
    },
    visualMagnitude: 6.12,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.34603423),
        dec: Angle.Degrees(-54.51554272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128306"},
        {"Hipparcos Number", "HIP 71561"},
        {"Geneva Identification System", "GEN# +1.00128306"},
        {"Smithsonian Astrophysical Observation", "SAO 241865"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.53236936),
        dec: Angle.Degrees(-54.51533333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146481"},
        {"Hipparcos Number", "HIP 79967"},
        {"Geneva Identification System", "GEN# +1.00146481"},
        {"Smithsonian Astrophysical Observation", "SAO 243616"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.83631682),
        dec: Angle.Degrees(-54.51335625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130348"},
        {"Hipparcos Number", "HIP 72519"},
        {"Geneva Identification System", "GEN# +2.57490020"},
        {"New General Catalogue", "NGC 5749 20"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.40716785),
        dec: Angle.Degrees(-54.51253769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117487"},
        {"Hipparcos Number", "HIP 65988"},
        {"Smithsonian Astrophysical Observation", "SAO 240919"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.94629403),
        dec: Angle.Degrees(-54.51252476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22448"},
        {"Hipparcos Number", "HIP 16645"},
        {"Smithsonian Astrophysical Observation", "SAO 233163"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.54180094),
        dec: Angle.Degrees(-54.51174002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128291"},
        {"Hipparcos Number", "HIP 71546"},
        {"Geneva Identification System", "GEN# +1.00128291"},
        {"Smithsonian Astrophysical Observation", "SAO 241864"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.50269244),
        dec: Angle.Degrees(-54.51118802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102682",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102682"},
        {"Geneva Identification System", "GEN# +6.20145064"},
    },
    visualMagnitude: 11.90,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.10436187),
        dec: Angle.Degrees(-54.51111108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127259"},
        {"Hipparcos Number", "HIP 71082"},
        {"Smithsonian Astrophysical Observation", "SAO 241771"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.04733667),
        dec: Angle.Degrees(-54.51007341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116972"},
        {"Hipparcos Number", "HIP 65702"},
        {"Smithsonian Astrophysical Observation", "SAO 240867"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.06521934),
        dec: Angle.Degrees(-54.50940685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42120"},
        {"Hipparcos Number", "HIP 28875"},
        {"Smithsonian Astrophysical Observation", "SAO 234306"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.44504217),
        dec: Angle.Degrees(-54.50934718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113752"},
        {"Hipparcos Number", "HIP 63980"},
        {"Smithsonian Astrophysical Observation", "SAO 240554"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.65754988),
        dec: Angle.Degrees(-54.50595953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113683",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113683"},
        {"Cincinnati Publication", "Ci 20 1397"},
        {"Geneva Identification System", "GEN# -2.05509220"},
    },
    visualMagnitude: 12.31,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.37613816),
        dec: Angle.Degrees(-54.50290098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 449.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -317.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107442"},
        {"Hipparcos Number", "HIP 60257"},
        {"Geneva Identification System", "GEN# +1.00107442"},
        {"Smithsonian Astrophysical Observation", "SAO 239870"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.33762024),
        dec: Angle.Degrees(-54.50158097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221069"},
        {"Hipparcos Number", "HIP 115930"},
        {"Smithsonian Astrophysical Observation", "SAO 247899"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.32049093),
        dec: Angle.Degrees(-54.50144011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191960"},
        {"Hipparcos Number", "HIP 99809"},
        {"Smithsonian Astrophysical Observation", "SAO 246501"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.76867804),
        dec: Angle.Degrees(-54.50012833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159492"},
        {"Hipparcos Number", "HIP 86305"},
        {"Geneva Identification System", "GEN# +1.00159492"},
        {"Smithsonian Astrophysical Observation", "SAO 244896"},
        {"Wilson Evans Batten Catalogue", "WEB 14561"},
    },
    visualMagnitude: 5.25,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.52319296),
        dec: Angle.Degrees(-54.50007025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37048"},
        {"Hipparcos Number", "HIP 25971"},
        {"Smithsonian Astrophysical Observation", "SAO 234019"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.12403322),
        dec: Angle.Degrees(-54.49997965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206443"},
        {"Hipparcos Number", "HIP 107289"},
        {"Fundamental Katalog 5th Edition", "FK5 5918"},
        {"Smithsonian Astrophysical Observation", "SAO 247152"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.97800739),
        dec: Angle.Degrees(-54.49990923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72142"},
        {"Hipparcos Number", "HIP 41583"},
        {"Smithsonian Astrophysical Observation", "SAO 236017"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.17328683),
        dec: Angle.Degrees(-54.49902120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57306"},
        {"Hipparcos Number", "HIP 35318"},
        {"Geneva Identification System", "GEN# +1.00057306"},
        {"Smithsonian Astrophysical Observation", "SAO 235077"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.42820751),
        dec: Angle.Degrees(-54.49872456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215658"},
        {"Hipparcos Number", "HIP 112549"},
        {"Smithsonian Astrophysical Observation", "SAO 247584"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.93475244),
        dec: Angle.Degrees(-54.49670618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80435"},
        {"Hipparcos Number", "HIP 45603"},
        {"Geneva Identification System", "GEN# +1.00080435"},
        {"Smithsonian Astrophysical Observation", "SAO 236819"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.42628604),
        dec: Angle.Degrees(-54.49485748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209072"},
        {"Hipparcos Number", "HIP 108787"},
        {"Geneva Identification System", "GEN# +1.00209072"},
        {"Smithsonian Astrophysical Observation", "SAO 247280"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.56510841),
        dec: Angle.Degrees(-54.49229349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98718"},
        {"Hipparcos Number", "HIP 55425"},
        {"Celescope Catalog", "CEL 3883"},
        {"Fundamental Katalog 5th Edition", "FK5 428"},
        {"Geneva Identification System", "GEN# +1.00098718"},
        {"Smithsonian Astrophysical Observation", "SAO 238986"},
        {"Wilson Evans Batten Catalogue", "WEB 9972"},
    },
    visualMagnitude: 3.90,
    bvColour: -0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.25184266),
        dec: Angle.Degrees(-54.49101395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127532"},
        {"Hipparcos Number", "HIP 71223"},
        {"Geneva Identification System", "GEN# +1.00127532"},
        {"Smithsonian Astrophysical Observation", "SAO 241799"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.46909381),
        dec: Angle.Degrees(-54.48801158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70086"},
        {"Hipparcos Number", "HIP 40606"},
        {"Smithsonian Astrophysical Observation", "SAO 235866"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.35815298),
        dec: Angle.Degrees(-54.48540405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151403"},
        {"Hipparcos Number", "HIP 82380"},
        {"Smithsonian Astrophysical Observation", "SAO 244174"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.51015746),
        dec: Angle.Degrees(-54.48388429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178794"},
        {"Hipparcos Number", "HIP 94414"},
        {"Geneva Identification System", "GEN# +1.00178794"},
        {"Smithsonian Astrophysical Observation", "SAO 245975"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.23961436),
        dec: Angle.Degrees(-54.48362839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219643"},
        {"Hipparcos Number", "HIP 115035"},
        {"Smithsonian Astrophysical Observation", "SAO 247817"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.48150234),
        dec: Angle.Degrees(-54.48326827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55046"},
        {"Hipparcos Number", "HIP 34446"},
        {"Smithsonian Astrophysical Observation", "SAO 234954"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.10298127),
        dec: Angle.Degrees(-54.48306307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71083"},
        {"Hipparcos Number", "HIP 41077"},
        {"Smithsonian Astrophysical Observation", "SAO 235935"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.71120315),
        dec: Angle.Degrees(-54.48177711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76652"},
        {"Hipparcos Number", "HIP 43808"},
        {"Geneva Identification System", "GEN# +1.00076652"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.83535875),
        dec: Angle.Degrees(-54.48144809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91242"},
        {"Hipparcos Number", "HIP 51466"},
        {"Smithsonian Astrophysical Observation", "SAO 238136"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.68433997),
        dec: Angle.Degrees(-54.48133817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172360"},
        {"Hipparcos Number", "HIP 91771"},
        {"Geneva Identification System", "GEN# +1.00172360"},
        {"Smithsonian Astrophysical Observation", "SAO 245647"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.70248297),
        dec: Angle.Degrees(-54.48082276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175554"},
        {"Hipparcos Number", "HIP 93170"},
        {"Smithsonian Astrophysical Observation", "SAO 245838"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.67131011),
        dec: Angle.Degrees(-52.88965387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10070"},
        {"Hipparcos Number", "HIP 7545"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.29690524),
        dec: Angle.Degrees(-54.47882984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 299011"},
        {"Hipparcos Number", "HIP 50230"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.81186511),
        dec: Angle.Degrees(-54.47835956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23660"},
        {"Hipparcos Number", "HIP 17445"},
        {"Smithsonian Astrophysical Observation", "SAO 233250"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.06831789),
        dec: Angle.Degrees(-54.47810974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 117.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130152"},
        {"Hipparcos Number", "HIP 72424"},
        {"Geneva Identification System", "GEN# +2.57490021"},
        {"Geneva Identification System 2", "GEN# +2.57490072"},
        {"Smithsonian Astrophysical Observation", "SAO 242013"},
        {"New General Catalogue", "NGC 5749 21"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.13316724),
        dec: Angle.Degrees(-54.47341475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34914"},
        {"Hipparcos Number", "HIP 24688"},
        {"Smithsonian Astrophysical Observation", "SAO 233916"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.43190337),
        dec: Angle.Degrees(-54.47240713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23497"},
        {"Hipparcos Number", "HIP 17363"},
        {"Smithsonian Astrophysical Observation", "SAO 233239"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.76846066),
        dec: Angle.Degrees(-54.47206611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129106"},
        {"Hipparcos Number", "HIP 71927"},
        {"Smithsonian Astrophysical Observation", "SAO 241926"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.67120952),
        dec: Angle.Degrees(-54.47192560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159622"},
        {"Hipparcos Number", "HIP 86347"},
        {"Geneva Identification System", "GEN# +1.00159622"},
        {"Smithsonian Astrophysical Observation", "SAO 244900"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.66796590),
        dec: Angle.Degrees(-54.46935451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48466"},
        {"Hipparcos Number", "HIP 31936"},
        {"Smithsonian Astrophysical Observation", "SAO 234649"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.10676160),
        dec: Angle.Degrees(-54.46826715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51238"},
        {"Hipparcos Number", "HIP 33091"},
        {"Smithsonian Astrophysical Observation", "SAO 234769"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.38545041),
        dec: Angle.Degrees(-54.46775160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125086"},
        {"Hipparcos Number", "HIP 69957"},
        {"Geneva Identification System", "GEN# +1.00125086"},
        {"Smithsonian Astrophysical Observation", "SAO 241625"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.73265379),
        dec: Angle.Degrees(-54.46611777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81221"},
        {"Hipparcos Number", "HIP 45952"},
        {"Smithsonian Astrophysical Observation", "SAO 236892"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.57970252),
        dec: Angle.Degrees(-54.46549354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11343"},
        {"Hipparcos Number", "HIP 8541"},
        {"Smithsonian Astrophysical Observation", "SAO 232538"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.52591354),
        dec: Angle.Degrees(-54.46484790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122279"},
        {"Hipparcos Number", "HIP 68600"},
        {"Geneva Identification System", "GEN# +1.00122279"},
        {"Smithsonian Astrophysical Observation", "SAO 241383"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.63863439),
        dec: Angle.Degrees(-54.46468931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38244"},
        {"Hipparcos Number", "HIP 26768"},
        {"Smithsonian Astrophysical Observation", "SAO 234090"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.29503659),
        dec: Angle.Degrees(-54.46434544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81720"},
        {"Hipparcos Number", "HIP 46214"},
        {"Smithsonian Astrophysical Observation", "SAO 236952"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.33030447),
        dec: Angle.Degrees(-54.46375229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130244"},
        {"Hipparcos Number", "HIP 72460"},
        {"Geneva Identification System", "GEN# +2.57490016"},
        {"New General Catalogue", "NGC 5749 16"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.25932434),
        dec: Angle.Degrees(-54.46276023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180576"},
        {"Hipparcos Number", "HIP 95010"},
        {"Geneva Identification System", "GEN# +1.00180576"},
        {"Smithsonian Astrophysical Observation", "SAO 246032"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.99082304),
        dec: Angle.Degrees(-54.45893044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91197"},
    },
    visualMagnitude: 12.65,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.05590256),
        dec: Angle.Degrees(-54.45795246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206803"},
        {"Hipparcos Number", "HIP 107499"},
        {"Geneva Identification System", "GEN# +1.00206803"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.59093119),
        dec: Angle.Degrees(-54.45693820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31065"},
        {"Hipparcos Number", "HIP 22448"},
        {"Smithsonian Astrophysical Observation", "SAO 233699"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.45075616),
        dec: Angle.Degrees(-54.45453840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14078"},
        {"Hipparcos Number", "HIP 10461"},
        {"Smithsonian Astrophysical Observation", "SAO 232682"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.71701400),
        dec: Angle.Degrees(-54.45287141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21202"},
        {"Hipparcos Number", "HIP 15741"},
        {"Smithsonian Astrophysical Observation", "SAO 233090"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.70136038),
        dec: Angle.Degrees(-54.44971923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24905"},
        {"Hipparcos Number", "HIP 18310"},
        {"Smithsonian Astrophysical Observation", "SAO 233323"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.71598751),
        dec: Angle.Degrees(-54.44782811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97826"},
        {"Hipparcos Number", "HIP 54909"},
        {"Smithsonian Astrophysical Observation", "SAO 238894"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.64911631),
        dec: Angle.Degrees(-54.44683464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151301"},
        {"Hipparcos Number", "HIP 82340"},
        {"Renson", "Renson 42790"},
        {"Smithsonian Astrophysical Observation", "SAO 244167"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.36800305),
        dec: Angle.Degrees(-54.44662953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80526"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.58572000),
        dec: Angle.Degrees(-54.44563595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17990"},
        {"Hipparcos Number", "HIP 13307"},
        {"Smithsonian Astrophysical Observation", "SAO 232915"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.80588960),
        dec: Angle.Degrees(-54.44289267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198778"},
        {"Hipparcos Number", "HIP 103234"},
        {"Smithsonian Astrophysical Observation", "SAO 246787"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.71052905),
        dec: Angle.Degrees(-54.44242761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104563"},
        {"Hipparcos Number", "HIP 58705"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.61369340),
        dec: Angle.Degrees(-54.44072848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42504"},
        {"Hipparcos Number", "HIP 29071"},
        {"Smithsonian Astrophysical Observation", "SAO 234330"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.98721170),
        dec: Angle.Degrees(-54.43930571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152046"},
        {"Hipparcos Number", "HIP 82678"},
        {"Smithsonian Astrophysical Observation", "SAO 244253"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.51058589),
        dec: Angle.Degrees(-54.43827872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222849"},
        {"Hipparcos Number", "HIP 117099"},
        {"Smithsonian Astrophysical Observation", "SAO 248001"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.07994660),
        dec: Angle.Degrees(-54.43603348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92147",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92147"},
    },
    visualMagnitude: 11.53,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.70870755),
        dec: Angle.Degrees(-54.43578919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117739"},
        {"Hipparcos Number", "HIP 66126"},
        {"Smithsonian Astrophysical Observation", "SAO 240938"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.33747188),
        dec: Angle.Degrees(-54.43144651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205308"},
        {"Hipparcos Number", "HIP 106668"},
        {"Smithsonian Astrophysical Observation", "SAO 247102"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.07218851),
        dec: Angle.Degrees(-54.43120655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2530"},
        {"Hipparcos Number", "HIP 2253"},
        {"Smithsonian Astrophysical Observation", "SAO 232057"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.17139490),
        dec: Angle.Degrees(-54.43115282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31721"},
        {"Hipparcos Number", "HIP 22866"},
        {"Smithsonian Astrophysical Observation", "SAO 233734"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.78629475),
        dec: Angle.Degrees(-54.43081091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58331"},
        {"Hipparcos Number", "HIP 35719"},
        {"Smithsonian Astrophysical Observation", "SAO 235147"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.54117381),
        dec: Angle.Degrees(-54.42785661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181296"},
        {"Hipparcos Number", "HIP 95261"},
        {"Geneva Identification System", "GEN# +1.00181296"},
        {"Smithsonian Astrophysical Observation", "SAO 246055"},
        {"Wilson Evans Batten Catalogue", "WEB 16642"},
    },
    visualMagnitude: 5.03,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.71325245),
        dec: Angle.Degrees(-54.42372882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12421"},
        {"Hipparcos Number", "HIP 9351"},
        {"Smithsonian Astrophysical Observation", "SAO 232598"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.03217640),
        dec: Angle.Degrees(-54.42292519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63854"},
        {"Hipparcos Number", "HIP 38068"},
        {"Smithsonian Astrophysical Observation", "SAO 235526"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.02052728),
        dec: Angle.Degrees(-54.41832129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185075"},
        {"Hipparcos Number", "HIP 96781"},
        {"Geneva Identification System", "GEN# +1.00185075"},
        {"Smithsonian Astrophysical Observation", "SAO 246204"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.07767996),
        dec: Angle.Degrees(-54.41776164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62611"},
        {"Hipparcos Number", "HIP 37513"},
        {"Smithsonian Astrophysical Observation", "SAO 235423"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.48895598),
        dec: Angle.Degrees(-54.41769682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105938"},
        {"Hipparcos Number", "HIP 59448"},
        {"Geneva Identification System", "GEN# +1.00105938"},
        {"Smithsonian Astrophysical Observation", "SAO 239736"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.90854948),
        dec: Angle.Degrees(-54.41764059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113916"},
        {"Hipparcos Number", "HIP 64062"},
        {"Smithsonian Astrophysical Observation", "SAO 240575"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.93218477),
        dec: Angle.Degrees(-54.41740231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16795"},
        {"Hipparcos Number", "HIP 12397"},
        {"Smithsonian Astrophysical Observation", "SAO 232850"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.90807102),
        dec: Angle.Degrees(-54.41686501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79092"},
        {"Hipparcos Number", "HIP 44976"},
        {"Smithsonian Astrophysical Observation", "SAO 236672"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.43041613),
        dec: Angle.Degrees(-54.41424567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84882",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84882"},
        {"Smithsonian Astrophysical Observation", "SAO 244646"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.21910773),
        dec: Angle.Degrees(-54.41376872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94418"},
        {"Hipparcos Number", "HIP 53219"},
        {"Smithsonian Astrophysical Observation", "SAO 238563"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.27200174),
        dec: Angle.Degrees(-54.41280740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112499"},
        {"Smithsonian Astrophysical Observation", "SAO 247582"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.82830819),
        dec: Angle.Degrees(-54.41272716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215561"},
        {"Hipparcos Number", "HIP 112483"},
        {"Geneva Identification System", "GEN# +1.00215561"},
        {"Smithsonian Astrophysical Observation", "SAO 247581"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.76011113),
        dec: Angle.Degrees(-54.41224296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121009"},
        {"Hipparcos Number", "HIP 67899"},
        {"Smithsonian Astrophysical Observation", "SAO 241271"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.60059468),
        dec: Angle.Degrees(-54.41210962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53853"},
    },
    visualMagnitude: 11.41,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.25535567),
        dec: Angle.Degrees(-54.41155293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110517"},
        {"Hipparcos Number", "HIP 62067"},
        {"Geneva Identification System", "GEN# +1.00110517"},
        {"Smithsonian Astrophysical Observation", "SAO 240181"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.81190751),
        dec: Angle.Degrees(-54.41010555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42025"},
        {"Hipparcos Number", "HIP 28839"},
        {"Geneva Identification System", "GEN# +1.00042025"},
        {"Smithsonian Astrophysical Observation", "SAO 234299"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.31435356),
        dec: Angle.Degrees(-54.40839095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33116"},
        {"Hipparcos Number", "HIP 23653"},
        {"Fundamental Katalog 5th Edition", "FK5 2381"},
        {"Geneva Identification System", "GEN# +1.00033116"},
        {"Smithsonian Astrophysical Observation", "SAO 233814"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.25252482),
        dec: Angle.Degrees(-54.40741679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112983"},
        {"Hipparcos Number", "HIP 63544"},
        {"Smithsonian Astrophysical Observation", "SAO 240480"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.31622096),
        dec: Angle.Degrees(-54.40727156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28777"},
        {"Hipparcos Number", "HIP 20927"},
        {"Smithsonian Astrophysical Observation", "SAO 233536"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.30542648),
        dec: Angle.Degrees(-54.40699387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157162"},
        {"Hipparcos Number", "HIP 85214"},
        {"Geneva Identification System", "GEN# +1.00157162"},
        {"Smithsonian Astrophysical Observation", "SAO 244714"},
        {"Wilson Evans Batten Catalogue", "WEB 14389"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.18264369),
        dec: Angle.Degrees(-54.40675634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134890"},
        {"Hipparcos Number", "HIP 74607"},
        {"Smithsonian Astrophysical Observation", "SAO 242339"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.66069515),
        dec: Angle.Degrees(-54.40640554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25591"},
        {"Hipparcos Number", "HIP 18756"},
        {"Smithsonian Astrophysical Observation", "SAO 233364"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.26627513),
        dec: Angle.Degrees(-54.40617535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 659"},
        {"Hipparcos Number", "HIP 872"},
        {"Geneva Identification System", "GEN# +1.00000659"},
        {"Smithsonian Astrophysical Observation", "SAO 231957"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.67691363),
        dec: Angle.Degrees(-54.40037514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107526"},
        {"Hipparcos Number", "HIP 60296"},
        {"Renson", "Renson 31160"},
        {"Smithsonian Astrophysical Observation", "SAO 239876"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.45864396),
        dec: Angle.Degrees(-54.40026798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60228"},
        {"Hipparcos Number", "HIP 36496"},
        {"Fundamental Katalog 5th Edition", "FK5 2586"},
        {"Geneva Identification System", "GEN# +1.00060228"},
        {"Smithsonian Astrophysical Observation", "SAO 235252"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.62877606),
        dec: Angle.Degrees(-54.39943169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89385"},
        {"Hipparcos Number", "HIP 50398"},
        {"Geneva Identification System", "GEN# +1.00089385"},
        {"Renson", "Renson 25650"},
        {"Smithsonian Astrophysical Observation", "SAO 237876"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.37059059),
        dec: Angle.Degrees(-54.39917725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85154"},
        {"Hipparcos Number", "HIP 48088"},
        {"Smithsonian Astrophysical Observation", "SAO 237355"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.05444582),
        dec: Angle.Degrees(-54.39656605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140926"},
        {"Hipparcos Number", "HIP 77452"},
        {"Geneva Identification System", "GEN# +1.00140926"},
        {"Smithsonian Astrophysical Observation", "SAO 242997"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.19945147),
        dec: Angle.Degrees(-54.39564315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72650"},
        {"Hipparcos Number", "HIP 41813"},
        {"Geneva Identification System", "GEN# +1.00072650"},
        {"Smithsonian Astrophysical Observation", "SAO 236055"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.87321243),
        dec: Angle.Degrees(-54.39390506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3488"},
        {"Hipparcos Number", "HIP 2937"},
        {"Geneva Identification System", "GEN# +1.00003488"},
        {"Smithsonian Astrophysical Observation", "SAO 232114"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.32573293),
        dec: Angle.Degrees(-54.39380980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25590"},
        {"Hipparcos Number", "HIP 18750"},
        {"Smithsonian Astrophysical Observation", "SAO 233363"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.24734402),
        dec: Angle.Degrees(-54.39216517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35340"},
        {"Hipparcos Number", "HIP 24979"},
        {"Smithsonian Astrophysical Observation", "SAO 233937"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.23843363),
        dec: Angle.Degrees(-54.39142194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21023"},
        {"Hipparcos Number", "HIP 15618"},
        {"Smithsonian Astrophysical Observation", "SAO 233078"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.27699775),
        dec: Angle.Degrees(-54.39039140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86158"},
        {"Hipparcos Number", "HIP 48633"},
        {"Smithsonian Astrophysical Observation", "SAO 237493"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.75493201),
        dec: Angle.Degrees(-54.38898758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200190"},
        {"Hipparcos Number", "HIP 103999"},
        {"Geneva Identification System", "GEN# +1.00200190"},
        {"Smithsonian Astrophysical Observation", "SAO 246844"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.05942658),
        dec: Angle.Degrees(-54.38706491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166224"},
        {"Hipparcos Number", "HIP 89241"},
        {"Smithsonian Astrophysical Observation", "SAO 245312"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.16503177),
        dec: Angle.Degrees(-54.38694916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84031"},
        {"Hipparcos Number", "HIP 47457"},
        {"Smithsonian Astrophysical Observation", "SAO 237216"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.11331418),
        dec: Angle.Degrees(-54.38480861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176727"},
        {"Hipparcos Number", "HIP 93684"},
        {"Smithsonian Astrophysical Observation", "SAO 245906"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.17164691),
        dec: Angle.Degrees(-54.38336989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112780"},
        {"Hipparcos Number", "HIP 63429"},
        {"Geneva Identification System", "GEN# +1.00112780"},
        {"Smithsonian Astrophysical Observation", "SAO 240458"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.97292424),
        dec: Angle.Degrees(-54.37888929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162895"},
        {"Hipparcos Number", "HIP 87821"},
        {"Smithsonian Astrophysical Observation", "SAO 245127"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.10069179),
        dec: Angle.Degrees(-54.37804544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90176"},
        {"Hipparcos Number", "HIP 50867"},
        {"Geneva Identification System", "GEN# +1.00090176"},
        {"Smithsonian Astrophysical Observation", "SAO 238006"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.79955197),
        dec: Angle.Degrees(-54.37783742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116022"},
        {"Hipparcos Number", "HIP 65215"},
        {"Smithsonian Astrophysical Observation", "SAO 240775"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.48413251),
        dec: Angle.Degrees(-54.37776924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50809"},
        {"Hipparcos Number", "HIP 32944"},
        {"Smithsonian Astrophysical Observation", "SAO 234753"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.93598019),
        dec: Angle.Degrees(-54.37644094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78931"},
        {"Hipparcos Number", "HIP 44879"},
        {"Celescope Catalog", "CEL 3198"},
        {"Geneva Identification System", "GEN# +1.00078931"},
        {"Smithsonian Astrophysical Observation", "SAO 236657"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.16703461),
        dec: Angle.Degrees(-54.37046696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98805"},
        {"Hipparcos Number", "HIP 55476"},
        {"Geneva Identification System", "GEN# +1.00098805"},
        {"Smithsonian Astrophysical Observation", "SAO 238994"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.41858413),
        dec: Angle.Degrees(-54.37043432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155438"},
        {"Hipparcos Number", "HIP 84339"},
        {"Geneva Identification System", "GEN# +1.00155438"},
        {"Smithsonian Astrophysical Observation", "SAO 244546"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.63885652),
        dec: Angle.Degrees(-54.37013904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64722"},
        {"Hipparcos Number", "HIP 38438"},
        {"Celescope Catalog", "CEL 2076"},
        {"Geneva Identification System", "GEN# +1.00064722"},
        {"Smithsonian Astrophysical Observation", "SAO 235579"},
        {"Wilson Evans Batten Catalogue", "WEB 7560"},
    },
    visualMagnitude: 5.70,
    bvColour: -0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.12394382),
        dec: Angle.Degrees(-54.36718432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223843"},
        {"Hipparcos Number", "HIP 117782"},
        {"Smithsonian Astrophysical Observation", "SAO 248053"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.28557810),
        dec: Angle.Degrees(-54.36708074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187671"},
        {"Hipparcos Number", "HIP 97916"},
        {"Smithsonian Astrophysical Observation", "SAO 246324"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.47126352),
        dec: Angle.Degrees(-54.36619193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199304"},
        {"Hipparcos Number", "HIP 103536"},
        {"Smithsonian Astrophysical Observation", "SAO 246812"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.63334704),
        dec: Angle.Degrees(-54.36539558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 789"},
        {"Hipparcos Number", "HIP 979"},
        {"Smithsonian Astrophysical Observation", "SAO 231968"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.02528260),
        dec: Angle.Degrees(-54.36533695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138895"},
        {"Hipparcos Number", "HIP 76497"},
        {"Geneva Identification System", "GEN# +1.00138895"},
        {"Smithsonian Astrophysical Observation", "SAO 242767"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.35856767),
        dec: Angle.Degrees(-54.36452034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135689"},
        {"Hipparcos Number", "HIP 74936"},
        {"Geneva Identification System", "GEN# +1.00135689"},
        {"Smithsonian Astrophysical Observation", "SAO 242399"},
        {"Wilson Evans Batten Catalogue", "WEB 12784"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.69184670),
        dec: Angle.Degrees(-54.36423812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156240"},
        {"Hipparcos Number", "HIP 84755"},
        {"Smithsonian Astrophysical Observation", "SAO 244625"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.87027583),
        dec: Angle.Degrees(-54.36352755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152025"},
        {"Hipparcos Number", "HIP 82660"},
        {"Smithsonian Astrophysical Observation", "SAO 244247"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.45849450),
        dec: Angle.Degrees(-54.36335125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65493"},
        {"Hipparcos Number", "HIP 38775"},
        {"Smithsonian Astrophysical Observation", "SAO 235633"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.05894405),
        dec: Angle.Degrees(-54.36277056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77490"},
        {"Hipparcos Number", "HIP 44250"},
        {"Celescope Catalog", "CEL 3144"},
        {"Geneva Identification System", "GEN# +1.00077490"},
        {"Smithsonian Astrophysical Observation", "SAO 236500"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.17228111),
        dec: Angle.Degrees(-54.36245523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15088"},
        {"Hipparcos Number", "HIP 11186"},
        {"Smithsonian Astrophysical Observation", "SAO 232753"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.01377576),
        dec: Angle.Degrees(-54.36112125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39110"},
        {"Hipparcos Number", "HIP 27317"},
        {"Geneva Identification System", "GEN# +1.00039110"},
        {"Smithsonian Astrophysical Observation", "SAO 234137"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.80552101),
        dec: Angle.Degrees(-54.36073163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215803"},
        {"Hipparcos Number", "HIP 112634"},
        {"Smithsonian Astrophysical Observation", "SAO 247594"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.18288156),
        dec: Angle.Degrees(-54.35989564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173795"},
        {"Hipparcos Number", "HIP 92432"},
        {"Smithsonian Astrophysical Observation", "SAO 245741"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.55698879),
        dec: Angle.Degrees(-54.35954828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163693"},
        {"Hipparcos Number", "HIP 88178"},
        {"Geneva Identification System", "GEN# +1.00163693"},
        {"Smithsonian Astrophysical Observation", "SAO 245165"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.12717412),
        dec: Angle.Degrees(-54.35752154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25210"},
        {"Hipparcos Number", "HIP 18517"},
        {"Geneva Identification System", "GEN# +1.00025210"},
        {"Smithsonian Astrophysical Observation", "SAO 233340"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.39168844),
        dec: Angle.Degrees(-54.35734794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174564"},
        {"Hipparcos Number", "HIP 92755"},
        {"Geneva Identification System", "GEN# +1.00174564A"},
        {"Smithsonian Astrophysical Observation", "SAO 245794"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.52624769),
        dec: Angle.Degrees(-54.35596006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33851"},
        {"Hipparcos Number", "HIP 24050"},
        {"Smithsonian Astrophysical Observation", "SAO 233857"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.52898477),
        dec: Angle.Degrees(-54.35566216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12850"},
        {"Hipparcos Number", "HIP 9663"},
        {"Smithsonian Astrophysical Observation", "SAO 232618"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.07450147),
        dec: Angle.Degrees(-54.35486191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174564B"},
        {"Hipparcos Number", "HIP 92756"},
        {"Geneva Identification System", "GEN# +1.00174564B"},
    },
    visualMagnitude: 10.43,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.52696106),
        dec: Angle.Degrees(-54.35303510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145110"},
        {"Hipparcos Number", "HIP 79372"},
        {"Geneva Identification System", "GEN# +1.00145110"},
        {"Smithsonian Astrophysical Observation", "SAO 243422"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.99139077),
        dec: Angle.Degrees(-54.35289582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44919"},
        {"Hipparcos Number", "HIP 30213"},
        {"Geneva Identification System", "GEN# +1.00044919"},
        {"Smithsonian Astrophysical Observation", "SAO 234462"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.34481674),
        dec: Angle.Degrees(-54.35189619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81949"},
        {"Hipparcos Number", "HIP 46342"},
        {"Geneva Identification System", "GEN# +1.00081949"},
        {"Smithsonian Astrophysical Observation", "SAO 236987"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.72221584),
        dec: Angle.Degrees(-54.35175032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192416"},
        {"Hipparcos Number", "HIP 100008"},
        {"Smithsonian Astrophysical Observation", "SAO 246514"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.34037689),
        dec: Angle.Degrees(-54.34681438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110697"},
        {"Hipparcos Number", "HIP 62171"},
        {"Smithsonian Astrophysical Observation", "SAO 240202"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.11095182),
        dec: Angle.Degrees(-54.34667497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128489"},
        {"Hipparcos Number", "HIP 71633"},
        {"Smithsonian Astrophysical Observation", "SAO 241877"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.76959067),
        dec: Angle.Degrees(-54.34493379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132944"},
        {"Hipparcos Number", "HIP 73711"},
        {"Geneva Identification System", "GEN# +2.58220001"},
        {"Smithsonian Astrophysical Observation", "SAO 242197"},
        {"New General Catalogue", "NGC 5822 1"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.00940980),
        dec: Angle.Degrees(-54.33916890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165165"},
        {"Hipparcos Number", "HIP 88801"},
        {"Smithsonian Astrophysical Observation", "SAO 245252"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.91352246),
        dec: Angle.Degrees(-54.33900668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162660"},
        {"Hipparcos Number", "HIP 87726"},
        {"Smithsonian Astrophysical Observation", "SAO 245113"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.78966464),
        dec: Angle.Degrees(-54.33727117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73782",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73782"},
        {"Geneva Identification System", "GEN# +2.58220009"},
        {"New General Catalogue", "NGC 5822 9"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.21552783),
        dec: Angle.Degrees(-54.33688591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154647"},
        {"Hipparcos Number", "HIP 83960"},
        {"Smithsonian Astrophysical Observation", "SAO 244470"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.43309090),
        dec: Angle.Degrees(-54.33510288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208170"},
        {"Hipparcos Number", "HIP 108266"},
        {"Smithsonian Astrophysical Observation", "SAO 247228"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.01208926),
        dec: Angle.Degrees(-54.33362987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113840"},
        {"Hipparcos Number", "HIP 64025"},
        {"Smithsonian Astrophysical Observation", "SAO 240562"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.80333230),
        dec: Angle.Degrees(-54.33319001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30292"},
        {"Smithsonian Astrophysical Observation", "SAO 234469"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.57960962),
        dec: Angle.Degrees(-54.33291750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167465"},
        {"Hipparcos Number", "HIP 89698"},
        {"Smithsonian Astrophysical Observation", "SAO 245386"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.58492278),
        dec: Angle.Degrees(-54.33241069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142468"},
        {"Hipparcos Number", "HIP 78145"},
        {"Geneva Identification System", "GEN# +1.00142468"},
        {"Smithsonian Astrophysical Observation", "SAO 243156"},
        {"Wilson Evans Batten Catalogue", "WEB 13215"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.35250079),
        dec: Angle.Degrees(-54.33224957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95139"},
        {"Hipparcos Number", "HIP 53614"},
        {"Smithsonian Astrophysical Observation", "SAO 238640"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.52883975),
        dec: Angle.Degrees(-54.33150859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182509"},
        {"Hipparcos Number", "HIP 95690"},
        {"Fundamental Katalog 5th Edition", "FK5 1504"},
        {"Geneva Identification System", "GEN# +1.00182509"},
        {"Smithsonian Astrophysical Observation", "SAO 246110"},
        {"Wilson Evans Batten Catalogue", "WEB 16740"},
    },
    visualMagnitude: 5.70,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.95051131),
        dec: Angle.Degrees(-54.32529723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83762"},
        {"Hipparcos Number", "HIP 47344"},
        {"Smithsonian Astrophysical Observation", "SAO 237184"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.70789285),
        dec: Angle.Degrees(-54.32517304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100453"},
        {"Hipparcos Number", "HIP 56354"},
        {"Geneva Identification System", "GEN# +1.00100453"},
        {"Smithsonian Astrophysical Observation", "SAO 239162"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.27339021),
        dec: Angle.Degrees(-54.32458220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25567"},
        {"Hipparcos Number", "HIP 18741"},
        {"Smithsonian Astrophysical Observation", "SAO 233359"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.21665533),
        dec: Angle.Degrees(-54.32383291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86899"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.33861322),
        dec: Angle.Degrees(-54.32367279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124995"},
        {"Hipparcos Number", "HIP 69906"},
        {"Geneva Identification System", "GEN# +1.00124995"},
        {"Smithsonian Astrophysical Observation", "SAO 241612"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.60256088),
        dec: Angle.Degrees(-54.32243384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22515"},
        {"Hipparcos Number", "HIP 16690"},
        {"Geneva Identification System", "GEN# +1.00022515"},
        {"Smithsonian Astrophysical Observation", "SAO 233169"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.67851149),
        dec: Angle.Degrees(-54.32239503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90371"},
        {"Hipparcos Number", "HIP 50970"},
        {"Smithsonian Astrophysical Observation", "SAO 238040"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.16520036),
        dec: Angle.Degrees(-54.32194382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211261"},
        {"Hipparcos Number", "HIP 110036"},
        {"Fundamental Katalog 5th Edition", "FK5 3781"},
        {"Geneva Identification System", "GEN# +1.00211261"},
        {"Smithsonian Astrophysical Observation", "SAO 247391"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.31130242),
        dec: Angle.Degrees(-54.32127002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140080"},
        {"Hipparcos Number", "HIP 77073"},
        {"Renson", "Renson 39820"},
        {"Smithsonian Astrophysical Observation", "SAO 242891"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.06939780),
        dec: Angle.Degrees(-54.32081460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136969"},
        {"Hipparcos Number", "HIP 75534"},
        {"Smithsonian Astrophysical Observation", "SAO 242505"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.47187281),
        dec: Angle.Degrees(-54.32063561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112334"},
        {"Hipparcos Number", "HIP 63185"},
        {"Smithsonian Astrophysical Observation", "SAO 240395"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.16913261),
        dec: Angle.Degrees(-54.31916579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79440"},
        {"New General Catalogue", "NGC 6067 244"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.18717339),
        dec: Angle.Degrees(-54.31859214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35949"},
        {"Hipparcos Number", "HIP 25339"},
        {"Geneva Identification System", "GEN# +1.00035949"},
        {"Smithsonian Astrophysical Observation", "SAO 233973"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.29590371),
        dec: Angle.Degrees(-54.31796980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190622"},
        {"Hipparcos Number", "HIP 99212"},
        {"Smithsonian Astrophysical Observation", "SAO 246455"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.11415466),
        dec: Angle.Degrees(-54.31739336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112652"},
    },
    visualMagnitude: 11.25,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.22604311),
        dec: Angle.Degrees(-54.31345938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 263.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -355.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107476"},
        {"Geneva Identification System", "GEN# +6.20145087"},
    },
    visualMagnitude: 11.25,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.53573489),
        dec: Angle.Degrees(-54.31282612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190747"},
        {"Hipparcos Number", "HIP 99272"},
        {"Smithsonian Astrophysical Observation", "SAO 246460"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.26980958),
        dec: Angle.Degrees(-54.31164407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152508"},
        {"Hipparcos Number", "HIP 82914"},
        {"Smithsonian Astrophysical Observation", "SAO 244287"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.16225933),
        dec: Angle.Degrees(-54.30988212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101902"},
        {"Hipparcos Number", "HIP 57162"},
        {"Smithsonian Astrophysical Observation", "SAO 239321"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.84664523),
        dec: Angle.Degrees(-54.30584612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178083"},
        {"Hipparcos Number", "HIP 94175"},
        {"Smithsonian Astrophysical Observation", "SAO 245949"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.55444084),
        dec: Angle.Degrees(-54.30341290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73391"},
    },
    visualMagnitude: 11.74,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.97286367),
        dec: Angle.Degrees(-54.30208483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174122"},
        {"Hipparcos Number", "HIP 92592"},
        {"Smithsonian Astrophysical Observation", "SAO 245762"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.00790761),
        dec: Angle.Degrees(-54.30187050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84730"},
        {"Hipparcos Number", "HIP 47875"},
        {"Celescope Catalog", "CEL 3378"},
        {"Geneva Identification System", "GEN# +1.00084730J"},
        {"Smithsonian Astrophysical Observation", "SAO 237309"},
    },
    visualMagnitude: 8.78,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.35909508),
        dec: Angle.Degrees(-54.29943845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213669"},
        {"Hipparcos Number", "HIP 111411"},
        {"Fundamental Katalog 5th Edition", "FK5 5990"},
        {"Smithsonian Astrophysical Observation", "SAO 247490"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.57767523),
        dec: Angle.Degrees(-54.29787154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24185"},
        {"Henry Draper 2", "HD 24186"},
        {"Hipparcos Number", "HIP 17785"},
        {"Geneva Identification System", "GEN# +1.00024185"},
        {"Smithsonian Astrophysical Observation", "SAO 233280"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.10330465),
        dec: Angle.Degrees(-54.29380608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23535"},
        {"Hipparcos Number", "HIP 17382"},
        {"Smithsonian Astrophysical Observation", "SAO 233242"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.84169746),
        dec: Angle.Degrees(-54.29300372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113751"},
        {"Hipparcos Number", "HIP 63974"},
        {"Geneva Identification System", "GEN# +1.00113751"},
        {"Smithsonian Astrophysical Observation", "SAO 240553"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.64857576),
        dec: Angle.Degrees(-54.29251357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91940"},
        {"Hipparcos Number", "HIP 51865"},
        {"Geneva Identification System", "GEN# +1.00091940"},
        {"Smithsonian Astrophysical Observation", "SAO 238227"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.94792867),
        dec: Angle.Degrees(-54.29250536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136113"},
        {"Hipparcos Number", "HIP 75134"},
        {"Geneva Identification System", "GEN# +1.00136113"},
        {"Smithsonian Astrophysical Observation", "SAO 242436"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.30349668),
        dec: Angle.Degrees(-54.29168125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210572"},
        {"Hipparcos Number", "HIP 109642"},
        {"Geneva Identification System", "GEN# +1.00210572"},
        {"Smithsonian Astrophysical Observation", "SAO 247354"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.15987314),
        dec: Angle.Degrees(-54.29061319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59552"},
        {"Hipparcos Number", "HIP 36214"},
        {"Smithsonian Astrophysical Observation", "SAO 235209"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.86806326),
        dec: Angle.Degrees(-54.28744671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218992"},
        {"Hipparcos Number", "HIP 114610"},
        {"Smithsonian Astrophysical Observation", "SAO 247778"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.27168188),
        dec: Angle.Degrees(-54.28705641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108515"},
        {"Hipparcos Number", "HIP 60837"},
        {"Smithsonian Astrophysical Observation", "SAO 239971"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.04787403),
        dec: Angle.Degrees(-54.28553339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156766"},
        {"Hipparcos Number", "HIP 85010"},
        {"Geneva Identification System", "GEN# +1.00156766"},
        {"Smithsonian Astrophysical Observation", "SAO 244672"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.62408711),
        dec: Angle.Degrees(-54.28542442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2575"},
        {"Hipparcos Number", "HIP 2272"},
        {"Smithsonian Astrophysical Observation", "SAO 232061"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.24795532),
        dec: Angle.Degrees(-54.28532130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218039"},
        {"Hipparcos Number", "HIP 114032"},
        {"Smithsonian Astrophysical Observation", "SAO 247721"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.38855873),
        dec: Angle.Degrees(-54.28529604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52250"},
        {"Hipparcos Number", "HIP 33470"},
        {"Smithsonian Astrophysical Observation", "SAO 234811"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.36176978),
        dec: Angle.Degrees(-54.28481654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146462"},
        {"Hipparcos Number", "HIP 79949"},
        {"Smithsonian Astrophysical Observation", "SAO 243608"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.79055540),
        dec: Angle.Degrees(-54.28425652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11439"},
        {"Hipparcos Number", "HIP 8602"},
        {"Smithsonian Astrophysical Observation", "SAO 232544"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.74690839),
        dec: Angle.Degrees(-54.28055339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113540"},
        {"Hipparcos Number", "HIP 63853"},
        {"Smithsonian Astrophysical Observation", "SAO 240530"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.29484684),
        dec: Angle.Degrees(-54.27958208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127654"},
        {"Hipparcos Number", "HIP 71262"},
        {"Smithsonian Astrophysical Observation", "SAO 241804"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.61071709),
        dec: Angle.Degrees(-54.27702051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151948"},
        {"Hipparcos Number", "HIP 82622"},
        {"Smithsonian Astrophysical Observation", "SAO 244238"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.35565330),
        dec: Angle.Degrees(-54.27644129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41659"},
        {"Geneva Identification System", "GEN# -0.05301708"},
        {"Smithsonian Astrophysical Observation", "SAO 236033"},
        {"Wilson Evans Batten Catalogue", "WEB 8039"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.40935865),
        dec: Angle.Degrees(-54.27616847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -427.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99399"},
        {"Hipparcos Number", "HIP 55782"},
    },
    visualMagnitude: 9.50,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.44359940),
        dec: Angle.Degrees(-54.27557972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150852"},
        {"Hipparcos Number", "HIP 82118"},
        {"Smithsonian Astrophysical Observation", "SAO 244128"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.62946962),
        dec: Angle.Degrees(-54.27531443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23697"},
        {"Hipparcos Number", "HIP 17464"},
        {"Geneva Identification System", "GEN# +1.00023697J"},
        {"Smithsonian Astrophysical Observation", "SAO 233252"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.14110276),
        dec: Angle.Degrees(-54.27418613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35473"},
        {"Hipparcos Number", "HIP 25058"},
        {"Smithsonian Astrophysical Observation", "SAO 233949"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.47992086),
        dec: Angle.Degrees(-54.27270122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78501"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.38432458),
        dec: Angle.Degrees(-54.27079353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94300"},
        {"Hipparcos Number", "HIP 53130"},
        {"Smithsonian Astrophysical Observation", "SAO 238546"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.02785370),
        dec: Angle.Degrees(-54.27025424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46917"},
        {"Hipparcos Number", "HIP 31220"},
        {"Smithsonian Astrophysical Observation", "SAO 234569"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.23256692),
        dec: Angle.Degrees(-54.26684599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83864"},
        {"Hipparcos Number", "HIP 47398"},
        {"Geneva Identification System", "GEN# +1.00083864"},
        {"Smithsonian Astrophysical Observation", "SAO 237192"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.86293464),
        dec: Angle.Degrees(-54.26512355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161863"},
        {"Hipparcos Number", "HIP 87366"},
        {"Geneva Identification System", "GEN# +1.00161863"},
        {"Smithsonian Astrophysical Observation", "SAO 245069"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.77248821),
        dec: Angle.Degrees(-54.26506881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100673"},
        {"Hipparcos Number", "HIP 56480"},
        {"Fundamental Katalog 5th Edition", "FK5 2926"},
        {"Geneva Identification System", "GEN# +1.00100673"},
        {"Smithsonian Astrophysical Observation", "SAO 239189"},
        {"Wilson Evans Batten Catalogue", "WEB 10149"},
    },
    visualMagnitude: 4.62,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.69046642),
        dec: Angle.Degrees(-54.26413167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123166"},
        {"Hipparcos Number", "HIP 68998"},
        {"Smithsonian Astrophysical Observation", "SAO 241460"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.88978356),
        dec: Angle.Degrees(-54.26387149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193407"},
        {"Hipparcos Number", "HIP 100488"},
        {"Smithsonian Astrophysical Observation", "SAO 246550"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.66002326),
        dec: Angle.Degrees(-54.26361320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38041",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tapecue"},
        {"Henry Draper", "HD 63765"},
        {"Hipparcos Number", "HIP 38041"},
        {"Geneva Identification System", "GEN# +1.00063765"},
        {"Smithsonian Astrophysical Observation", "SAO 235521"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.95654757),
        dec: Angle.Degrees(-54.26346735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -278.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170573"},
        {"Hipparcos Number", "HIP 90945"},
        {"Smithsonian Astrophysical Observation", "SAO 245545"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.27167380),
        dec: Angle.Degrees(-54.26284479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165274"},
        {"Hipparcos Number", "HIP 88844"},
        {"Smithsonian Astrophysical Observation", "SAO 245257"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.03876597),
        dec: Angle.Degrees(-54.26280389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73727"},
    },
    visualMagnitude: 11.09,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.06842291),
        dec: Angle.Degrees(-54.26077570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105096"},
        {"Hipparcos Number", "HIP 59016"},
        {"Smithsonian Astrophysical Observation", "SAO 239662"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.50568715),
        dec: Angle.Degrees(-54.25781790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82800"},
        {"Hipparcos Number", "HIP 46819"},
        {"Smithsonian Astrophysical Observation", "SAO 237080"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.11611285),
        dec: Angle.Degrees(-54.25620802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12988"},
        {"Hipparcos Number", "HIP 9761"},
        {"Smithsonian Astrophysical Observation", "SAO 232628"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.37503120),
        dec: Angle.Degrees(-54.25515163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18822"},
        {"Hipparcos Number", "HIP 13926"},
        {"Geneva Identification System", "GEN# +1.00018822"},
        {"Smithsonian Astrophysical Observation", "SAO 232960"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.85405113),
        dec: Angle.Degrees(-54.25469618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165936"},
        {"Hipparcos Number", "HIP 89125"},
        {"Smithsonian Astrophysical Observation", "SAO 245293"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.84398225),
        dec: Angle.Degrees(-54.25203243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12024"},
        {"Hipparcos Number", "HIP 9041"},
        {"Smithsonian Astrophysical Observation", "SAO 232576"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.12044923),
        dec: Angle.Degrees(-54.25148495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84688"},
        {"Hipparcos Number", "HIP 47863"},
        {"Celescope Catalog", "CEL 3377"},
        {"Geneva Identification System", "GEN# +1.00084688"},
        {"Smithsonian Astrophysical Observation", "SAO 237305"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.32284054),
        dec: Angle.Degrees(-54.24746619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112229"},
        {"Hipparcos Number", "HIP 63105"},
        {"Smithsonian Astrophysical Observation", "SAO 240383"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.95415631),
        dec: Angle.Degrees(-54.24709205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11717",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11717"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.81187622),
        dec: Angle.Degrees(-54.24208449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141647"},
        {"Hipparcos Number", "HIP 77765"},
        {"Smithsonian Astrophysical Observation", "SAO 243069"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.17779664),
        dec: Angle.Degrees(-54.24173833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33762"},
        {"Hipparcos Number", "HIP 23986"},
        {"Smithsonian Astrophysical Observation", "SAO 233850"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.34291229),
        dec: Angle.Degrees(-54.24150957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62943"},
        {"Hipparcos Number", "HIP 37643"},
        {"Smithsonian Astrophysical Observation", "SAO 235446"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.87345942),
        dec: Angle.Degrees(-54.24132855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129325"},
        {"Hipparcos Number", "HIP 72017"},
        {"Geneva Identification System", "GEN# +1.00129325"},
        {"Smithsonian Astrophysical Observation", "SAO 241946"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.95070692),
        dec: Angle.Degrees(-54.23992944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135460"},
        {"Hipparcos Number", "HIP 74820"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.35583926),
        dec: Angle.Degrees(-54.23737574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77347"},
        {"Hipparcos Number", "HIP 44166"},
        {"Geneva Identification System", "GEN# +1.00077347"},
        {"Renson", "Renson 21850"},
        {"Smithsonian Astrophysical Observation", "SAO 236480"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.93469929),
        dec: Angle.Degrees(-54.23689762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205393"},
        {"Hipparcos Number", "HIP 106700"},
        {"Smithsonian Astrophysical Observation", "SAO 247107"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.18392242),
        dec: Angle.Degrees(-54.23557706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188318"},
        {"Hipparcos Number", "HIP 98196"},
        {"Geneva Identification System", "GEN# +1.00188318J"},
        {"Smithsonian Astrophysical Observation", "SAO 246351"},
        {"Wilson Evans Batten Catalogue", "WEB 17317"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.31422377),
        dec: Angle.Degrees(-54.23265927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15193"},
        {"Hipparcos Number", "HIP 11263"},
        {"Smithsonian Astrophysical Observation", "SAO 232759"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.24499643),
        dec: Angle.Degrees(-54.23128802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106048"},
        {"Hipparcos Number", "HIP 59505"},
        {"Smithsonian Astrophysical Observation", "SAO 239747"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.05015298),
        dec: Angle.Degrees(-54.23043777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120178"},
        {"Hipparcos Number", "HIP 67428"},
        {"Smithsonian Astrophysical Observation", "SAO 241198"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.28849485),
        dec: Angle.Degrees(-54.22837096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56980"},
        {"Hipparcos Number", "HIP 35183"},
        {"Smithsonian Astrophysical Observation", "SAO 235060"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.06643845),
        dec: Angle.Degrees(-54.22627277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50908"},
    },
    visualMagnitude: 10.99,
    bvColour: 1.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.93829657),
        dec: Angle.Degrees(-54.22547713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223053"},
        {"Hipparcos Number", "HIP 117243"},
        {"Smithsonian Astrophysical Observation", "SAO 248014"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.59478487),
        dec: Angle.Degrees(-54.22134363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83625"},
        {"Hipparcos Number", "HIP 47272"},
        {"Celescope Catalog", "CEL 3349"},
        {"Geneva Identification System", "GEN# +1.00083625"},
        {"Renson", "Renson 23850"},
        {"Smithsonian Astrophysical Observation", "SAO 237163"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.51344903),
        dec: Angle.Degrees(-54.21912609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149259"},
        {"Hipparcos Number", "HIP 81313"},
        {"Smithsonian Astrophysical Observation", "SAO 243983"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.10994350),
        dec: Angle.Degrees(-54.21758812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84227"},
        {"Hipparcos Number", "HIP 47563"},
        {"Geneva Identification System", "GEN# +1.00084227"},
        {"Smithsonian Astrophysical Observation", "SAO 237238"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.46491986),
        dec: Angle.Degrees(-54.21696553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200798"},
        {"Hipparcos Number", "HIP 104308"},
        {"Geneva Identification System", "GEN# +1.00200798"},
        {"Smithsonian Astrophysical Observation", "SAO 246880"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.96331188),
        dec: Angle.Degrees(-54.21631965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202663"},
        {"Hipparcos Number", "HIP 105271"},
        {"Smithsonian Astrophysical Observation", "SAO 246961"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.84776006),
        dec: Angle.Degrees(-54.21215479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72303"},
        {"Hipparcos Number", "HIP 41644"},
        {"Renson", "Renson 19990"},
        {"Smithsonian Astrophysical Observation", "SAO 236028"},
    },
    visualMagnitude: 6.44,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.37424503),
        dec: Angle.Degrees(-54.21180200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57854"},
        {"Hipparcos Number", "HIP 35546"},
        {"Smithsonian Astrophysical Observation", "SAO 235108"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.02747650),
        dec: Angle.Degrees(-54.21084856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185187"},
        {"Hipparcos Number", "HIP 96806"},
        {"Smithsonian Astrophysical Observation", "SAO 246208"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.17517861),
        dec: Angle.Degrees(-54.21031881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 772"},
        {"Hipparcos Number", "HIP 958"},
        {"Smithsonian Astrophysical Observation", "SAO 231964"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.96104581),
        dec: Angle.Degrees(-54.20984615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176353"},
        {"Hipparcos Number", "HIP 93524"},
        {"Smithsonian Astrophysical Observation", "SAO 245878"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.71932622),
        dec: Angle.Degrees(-54.20818073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222829"},
        {"Hipparcos Number", "HIP 117079"},
        {"Smithsonian Astrophysical Observation", "SAO 247999"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.02227423),
        dec: Angle.Degrees(-54.20701744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122925"},
        {"Hipparcos Number", "HIP 68877"},
        {"Celescope Catalog", "CEL 4300"},
        {"Geneva Identification System", "GEN# +1.00122925"},
        {"Smithsonian Astrophysical Observation", "SAO 241436"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.55098479),
        dec: Angle.Degrees(-54.20675089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73287"},
        {"Hipparcos Number", "HIP 42121"},
        {"Celescope Catalog", "CEL 2685"},
        {"Geneva Identification System", "GEN# +3.23910001"},
        {"Smithsonian Astrophysical Observation", "SAO 236100"},
        {"Wilson Evans Batten Catalogue", "WEB 8094"},
    },
    visualMagnitude: 7.06,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.79223929),
        dec: Angle.Degrees(-54.20622681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3747",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3747"},
    },
    visualMagnitude: 10.87,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.02551587),
        dec: Angle.Degrees(-54.20089964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22471",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22471"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.53176125),
        dec: Angle.Degrees(-54.19976845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85986",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85986"},
    },
    visualMagnitude: 10.90,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.61022163),
        dec: Angle.Degrees(-54.19863996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75295"},
        {"Hipparcos Number", "HIP 43110"},
        {"Celescope Catalog", "CEL 2906"},
        {"Geneva Identification System", "GEN# +1.00075295"},
        {"Smithsonian Astrophysical Observation", "SAO 236267"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.70055445),
        dec: Angle.Degrees(-54.19811547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108670"},
        {"Hipparcos Number", "HIP 60932"},
        {"Smithsonian Astrophysical Observation", "SAO 239989"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.33289915),
        dec: Angle.Degrees(-54.19783829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96068"},
        {"Hipparcos Number", "HIP 54087"},
        {"Fundamental Katalog 5th Edition", "FK5 2883"},
        {"Smithsonian Astrophysical Observation", "SAO 238729"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.01215858),
        dec: Angle.Degrees(-54.19776193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79466"},
        {"Geneva Identification System", "GEN# +2.60670267"},
        {"Smithsonian Astrophysical Observation", "SAO 243441"},
        {"Wilson Evans Batten Catalogue", "WEB 13443"},
        {"New General Catalogue", "NGC 6067 267"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.25099767),
        dec: Angle.Degrees(-54.19364456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118784"},
        {"Hipparcos Number", "HIP 66688"},
        {"Smithsonian Astrophysical Observation", "SAO 241050"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.05809736),
        dec: Angle.Degrees(-54.19213199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205370"},
        {"Hipparcos Number", "HIP 106683"},
        {"Geneva Identification System", "GEN# +1.00205370"},
        {"Renson", "Renson 57230"},
        {"Smithsonian Astrophysical Observation", "SAO 247104"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.13099863),
        dec: Angle.Degrees(-54.19111916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168220"},
        {"Hipparcos Number", "HIP 89987"},
        {"Geneva Identification System", "GEN# +1.00168220"},
        {"Smithsonian Astrophysical Observation", "SAO 245419"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.40500722),
        dec: Angle.Degrees(-54.18945103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222044"},
        {"Hipparcos Number", "HIP 116586"},
        {"Smithsonian Astrophysical Observation", "SAO 247955"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.39793974),
        dec: Angle.Degrees(-54.18724120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61435"},
        {"Hipparcos Number", "HIP 37013"},
        {"Smithsonian Astrophysical Observation", "SAO 235351"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.10875774),
        dec: Angle.Degrees(-54.18719656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218976"},
        {"Hipparcos Number", "HIP 114598"},
        {"Smithsonian Astrophysical Observation", "SAO 247776"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.23312516),
        dec: Angle.Degrees(-54.18669570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181017"},
        {"Hipparcos Number", "HIP 95171"},
        {"Smithsonian Astrophysical Observation", "SAO 246046"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.42308282),
        dec: Angle.Degrees(-54.18558117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8517"},
        {"Hipparcos Number", "HIP 6461"},
        {"Geneva Identification System", "GEN# +1.00008517"},
        {"Smithsonian Astrophysical Observation", "SAO 232405"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.77605619),
        dec: Angle.Degrees(-54.18352339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49111"},
        {"Hipparcos Number", "HIP 32240"},
        {"Smithsonian Astrophysical Observation", "SAO 234676"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.96248463),
        dec: Angle.Degrees(-54.18207524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 299399"},
        {"Hipparcos Number", "HIP 52887"},
    },
    visualMagnitude: 12.22,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.24942408),
        dec: Angle.Degrees(-54.18178178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103599"},
        {"Hipparcos Number", "HIP 58167"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.93159898),
        dec: Angle.Degrees(-54.18066874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143828"},
        {"Hipparcos Number", "HIP 78810"},
        {"Smithsonian Astrophysical Observation", "SAO 243310"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.33225320),
        dec: Angle.Degrees(-54.17954449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170324"},
        {"Hipparcos Number", "HIP 90824"},
        {"Smithsonian Astrophysical Observation", "SAO 245530"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.92420306),
        dec: Angle.Degrees(-54.17862484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102319"},
        {"Henry Draper 2", "HD 102320"},
        {"Hipparcos Number", "HIP 57435"},
        {"Smithsonian Astrophysical Observation", "SAO 239367"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.61779287),
        dec: Angle.Degrees(-54.17815730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29854"},
        {"Hipparcos Number", "HIP 21678"},
        {"Smithsonian Astrophysical Observation", "SAO 233610"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.80838999),
        dec: Angle.Degrees(-54.17584956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32084"},
        {"Hipparcos Number", "HIP 23050"},
        {"Smithsonian Astrophysical Observation", "SAO 233760"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.40590272),
        dec: Angle.Degrees(-54.17403164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150216"},
        {"Hipparcos Number", "HIP 81793"},
        {"Smithsonian Astrophysical Observation", "SAO 244078"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.59299422),
        dec: Angle.Degrees(-54.17338414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189747"},
        {"Hipparcos Number", "HIP 98822"},
        {"Smithsonian Astrophysical Observation", "SAO 246415"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.03234639),
        dec: Angle.Degrees(-54.17209399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32208"},
        {"Hipparcos Number", "HIP 23122"},
        {"Geneva Identification System", "GEN# +1.00032208"},
        {"Smithsonian Astrophysical Observation", "SAO 233768"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.63532397),
        dec: Angle.Degrees(-54.17165718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99844"},
        {"Hipparcos Number", "HIP 56007"},
        {"Smithsonian Astrophysical Observation", "SAO 239101"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.16484982),
        dec: Angle.Degrees(-54.16931585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83335"},
        {"Hipparcos Number", "HIP 47088"},
        {"Celescope Catalog", "CEL 3336"},
        {"Geneva Identification System", "GEN# +1.00083335"},
        {"Smithsonian Astrophysical Observation", "SAO 237130"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.94725048),
        dec: Angle.Degrees(-54.16879510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40525"},
        {"Hipparcos Number", "HIP 28091"},
        {"Smithsonian Astrophysical Observation", "SAO 234216"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.06923766),
        dec: Angle.Degrees(-54.16675883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114391"},
        {"Hipparcos Number", "HIP 64327"},
        {"Celescope Catalog", "CEL 4211"},
        {"Geneva Identification System", "GEN# +1.00114391"},
        {"Smithsonian Astrophysical Observation", "SAO 240631"},
    },
    visualMagnitude: 8.61,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.77810108),
        dec: Angle.Degrees(-54.16661681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23723"},
        {"Hipparcos Number", "HIP 17485"},
        {"Smithsonian Astrophysical Observation", "SAO 233254"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.19184968),
        dec: Angle.Degrees(-54.16631786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116947"},
        {"Hipparcos Number", "HIP 65694"},
        {"Geneva Identification System", "GEN# +1.00116947"},
        {"Smithsonian Astrophysical Observation", "SAO 240865"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.03262906),
        dec: Angle.Degrees(-54.16530411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183357"},
        {"Hipparcos Number", "HIP 96065"},
        {"Smithsonian Astrophysical Observation", "SAO 246143"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.98807021),
        dec: Angle.Degrees(-54.16521861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4814"},
        {"Hipparcos Number", "HIP 3864"},
        {"Smithsonian Astrophysical Observation", "SAO 232199"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.39615242),
        dec: Angle.Degrees(-54.16416149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6325"},
        {"Hipparcos Number", "HIP 4940"},
        {"Smithsonian Astrophysical Observation", "SAO 232279"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.85207167),
        dec: Angle.Degrees(-54.16225954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192615"},
        {"Hipparcos Number", "HIP 100089"},
        {"Smithsonian Astrophysical Observation", "SAO 246520"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.57499382),
        dec: Angle.Degrees(-54.16210643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25448"},
        {"Hipparcos Number", "HIP 18671"},
        {"Geneva Identification System", "GEN# +1.00025448"},
        {"Smithsonian Astrophysical Observation", "SAO 233351"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.97564806),
        dec: Angle.Degrees(-54.16124655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79642"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.78604371),
        dec: Angle.Degrees(-54.15891401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208999"},
        {"Hipparcos Number", "HIP 108741"},
        {"Geneva Identification System", "GEN# +1.00208999"},
        {"Smithsonian Astrophysical Observation", "SAO 247275"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.41583214),
        dec: Angle.Degrees(-54.15716845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9255"},
        {"Hipparcos Number", "HIP 6980"},
        {"Geneva Identification System", "GEN# +1.00009255"},
        {"Renson", "Renson 2220"},
        {"Smithsonian Astrophysical Observation", "SAO 232440"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.46579241),
        dec: Angle.Degrees(-54.15634078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102597"},
        {"Hipparcos Number", "HIP 57595"},
        {"Smithsonian Astrophysical Observation", "SAO 239384"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.11259739),
        dec: Angle.Degrees(-54.15511900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204901"},
        {"Hipparcos Number", "HIP 106432"},
        {"Geneva Identification System", "GEN# +1.00204901"},
        {"Smithsonian Astrophysical Observation", "SAO 247081"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.36365353),
        dec: Angle.Degrees(-54.15511836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147689"},
        {"Hipparcos Number", "HIP 80510"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.53227154),
        dec: Angle.Degrees(-54.15509868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3034"},
        {"Hipparcos Number", "HIP 2610"},
        {"Smithsonian Astrophysical Observation", "SAO 232084"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.28838698),
        dec: Angle.Degrees(-54.15454127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74537"},
        {"Hipparcos Number", "HIP 42706"},
        {"Geneva Identification System", "GEN# +3.23910033"},
        {"Renson", "Renson 20812"},
        {"Wilson Evans Batten Catalogue", "WEB 8249"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.55148956),
        dec: Angle.Degrees(-54.15379400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184421"},
        {"Hipparcos Number", "HIP 96505"},
        {"Geneva Identification System", "GEN# +1.00184421"},
        {"Smithsonian Astrophysical Observation", "SAO 246184"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.29429703),
        dec: Angle.Degrees(-54.15353527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68407",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68407"},
    },
    visualMagnitude: 12.69,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.05331998),
        dec: Angle.Degrees(-54.15328926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153371"},
        {"Hipparcos Number", "HIP 83352"},
        {"Smithsonian Astrophysical Observation", "SAO 244373"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.52826665),
        dec: Angle.Degrees(-54.15172899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66441"},
        {"Hipparcos Number", "HIP 39184"},
        {"Celescope Catalog", "CEL 2137"},
        {"Fundamental Katalog 5th Edition", "FK5 2622"},
        {"Geneva Identification System", "GEN# +1.00066441"},
        {"Smithsonian Astrophysical Observation", "SAO 235680"},
        {"Wilson Evans Batten Catalogue", "WEB 7684"},
    },
    visualMagnitude: 5.87,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.20818254),
        dec: Angle.Degrees(-54.15129599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121943"},
        {"Hipparcos Number", "HIP 68406"},
        {"Smithsonian Astrophysical Observation", "SAO 241363"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.04894703),
        dec: Angle.Degrees(-54.14875006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118697"},
        {"Hipparcos Number", "HIP 66651"},
        {"Celescope Catalog", "CEL 4274"},
        {"Geneva Identification System", "GEN# +1.00118697"},
        {"Smithsonian Astrophysical Observation", "SAO 241045"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.94064498),
        dec: Angle.Degrees(-54.14809690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69051"},
        {"Hipparcos Number", "HIP 40188"},
        {"Geneva Identification System", "GEN# +1.00069051"},
        {"Smithsonian Astrophysical Observation", "SAO 235810"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.13639023),
        dec: Angle.Degrees(-54.14652908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112909"},
        {"Hipparcos Number", "HIP 63502"},
        {"Smithsonian Astrophysical Observation", "SAO 240472"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.17589331),
        dec: Angle.Degrees(-54.14398917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103588"},
        {"Hipparcos Number", "HIP 58153"},
        {"Geneva Identification System", "GEN# +1.00103588"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.88500768),
        dec: Angle.Degrees(-54.14106983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112199"},
        {"Hipparcos Number", "HIP 63084"},
        {"Smithsonian Astrophysical Observation", "SAO 240382"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.88845132),
        dec: Angle.Degrees(-54.14069699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108590"},
        {"Hipparcos Number", "HIP 60888"},
        {"Smithsonian Astrophysical Observation", "SAO 239981"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.18083657),
        dec: Angle.Degrees(-54.14047947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5592"},
        {"Hipparcos Number", "HIP 4450"},
        {"Smithsonian Astrophysical Observation", "SAO 232235"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.23301220),
        dec: Angle.Degrees(-54.14045751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5895"},
        {"Hipparcos Number", "HIP 4645"},
        {"Smithsonian Astrophysical Observation", "SAO 232249"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.91963847),
        dec: Angle.Degrees(-54.13884691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149922"},
        {"Hipparcos Number", "HIP 81636"},
        {"Geneva Identification System", "GEN# +1.00149922"},
        {"Smithsonian Astrophysical Observation", "SAO 244053"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.15106899),
        dec: Angle.Degrees(-54.13666939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27647"},
        {"Hipparcos Number", "HIP 20117"},
        {"Smithsonian Astrophysical Observation", "SAO 233480"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.70060810),
        dec: Angle.Degrees(-54.13554012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135239"},
        {"Hipparcos Number", "HIP 74731"},
        {"Smithsonian Astrophysical Observation", "SAO 242367"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.08980687),
        dec: Angle.Degrees(-54.13429004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121336"},
        {"Hipparcos Number", "HIP 68080"},
        {"Celescope Catalog", "CEL 4288"},
        {"Geneva Identification System", "GEN# +1.00121336"},
        {"Smithsonian Astrophysical Observation", "SAO 241309"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.08330120),
        dec: Angle.Degrees(-54.13237319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43143"},
        {"Hipparcos Number", "HIP 29383"},
        {"Smithsonian Astrophysical Observation", "SAO 234365"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.89009101),
        dec: Angle.Degrees(-54.13231558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41761"},
        {"Hipparcos Number", "HIP 28720"},
        {"Geneva Identification System", "GEN# +1.00041761"},
        {"Smithsonian Astrophysical Observation", "SAO 234285"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.99943087),
        dec: Angle.Degrees(-54.13225691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98112"},
        {"Smithsonian Astrophysical Observation", "SAO 246345"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.08874834),
        dec: Angle.Degrees(-54.12999939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125011"},
        {"Hipparcos Number", "HIP 69916"},
        {"Smithsonian Astrophysical Observation", "SAO 241615"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.62804564),
        dec: Angle.Degrees(-54.12936041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123361"},
        {"Hipparcos Number", "HIP 69098"},
        {"Smithsonian Astrophysical Observation", "SAO 241476"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.16921603),
        dec: Angle.Degrees(-54.12403502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115145"},
        {"Hipparcos Number", "HIP 64741"},
        {"Smithsonian Astrophysical Observation", "SAO 240696"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.03410490),
        dec: Angle.Degrees(-54.12355735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41554"},
        {"Hipparcos Number", "HIP 28632"},
        {"Smithsonian Astrophysical Observation", "SAO 234267"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.67727002),
        dec: Angle.Degrees(-54.12225078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54343"},
        {"Hipparcos Number", "HIP 34196"},
        {"Smithsonian Astrophysical Observation", "SAO 234913"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.37287534),
        dec: Angle.Degrees(-54.12011872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4082"},
        {"Hipparcos Number", "HIP 3337"},
        {"Geneva Identification System", "GEN# +1.00004082"},
        {"Smithsonian Astrophysical Observation", "SAO 232156"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.63870224),
        dec: Angle.Degrees(-54.11961581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12703"},
    },
    visualMagnitude: 12.16,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.81162889),
        dec: Angle.Degrees(-54.11743171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4083"},
        {"Hipparcos Number", "HIP 3340"},
        {"Geneva Identification System", "GEN# +1.00004083"},
        {"Smithsonian Astrophysical Observation", "SAO 232157"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.64564110),
        dec: Angle.Degrees(-54.11737187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47064"},
        {"Hipparcos Number", "HIP 31282"},
        {"Renson", "Renson 12600"},
        {"Smithsonian Astrophysical Observation", "SAO 234577"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.41440102),
        dec: Angle.Degrees(-54.11723470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61856"},
        {"Hipparcos Number", "HIP 37186"},
        {"Smithsonian Astrophysical Observation", "SAO 235378"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.60265114),
        dec: Angle.Degrees(-54.11687598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102517"},
        {"Hipparcos Number", "HIP 57551"},
        {"Smithsonian Astrophysical Observation", "SAO 239379"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.94261445),
        dec: Angle.Degrees(-54.11542130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75948"},
        {"Hipparcos Number", "HIP 43433"},
        {"Smithsonian Astrophysical Observation", "SAO 236326"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.69630271),
        dec: Angle.Degrees(-54.11298195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12702"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.80311514),
        dec: Angle.Degrees(-54.11192435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208858"},
        {"Hipparcos Number", "HIP 108643"},
        {"Smithsonian Astrophysical Observation", "SAO 247264"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.14748180),
        dec: Angle.Degrees(-54.11148589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74276"},
        {"Hipparcos Number", "HIP 42571"},
        {"Smithsonian Astrophysical Observation", "SAO 236175"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.15630352),
        dec: Angle.Degrees(-54.10937358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92738"},
        {"Hipparcos Number", "HIP 52319"},
        {"Smithsonian Astrophysical Observation", "SAO 238354"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.35859682),
        dec: Angle.Degrees(-54.10676735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130204"},
        {"Hipparcos Number", "HIP 72443"},
        {"Geneva Identification System", "GEN# +1.00130204"},
        {"Smithsonian Astrophysical Observation", "SAO 242020"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.20693776),
        dec: Angle.Degrees(-54.10571306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163905"},
        {"Hipparcos Number", "HIP 88269"},
        {"Smithsonian Astrophysical Observation", "SAO 245179"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.38187967),
        dec: Angle.Degrees(-54.10550153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137250"},
        {"Hipparcos Number", "HIP 75639"},
        {"Smithsonian Astrophysical Observation", "SAO 242540"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.80701188),
        dec: Angle.Degrees(-54.10407687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4520"},
        {"Hipparcos Number", "HIP 3640"},
        {"Smithsonian Astrophysical Observation", "SAO 232179"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.65966929),
        dec: Angle.Degrees(-54.10165072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32832"},
        {"Hipparcos Number", "HIP 23491"},
        {"Smithsonian Astrophysical Observation", "SAO 233802"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.75132040),
        dec: Angle.Degrees(-54.09800518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7620"},
        {"Hipparcos Number", "HIP 5860"},
        {"Smithsonian Astrophysical Observation", "SAO 232357"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.79230479),
        dec: Angle.Degrees(-54.09657062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7283"},
        {"Hipparcos Number", "HIP 5622"},
        {"Geneva Identification System", "GEN# +1.00007283"},
        {"Smithsonian Astrophysical Observation", "SAO 232334"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.03865098),
        dec: Angle.Degrees(-54.09499403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182098"},
        {"Hipparcos Number", "HIP 95529"},
        {"Smithsonian Astrophysical Observation", "SAO 246095"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.47517692),
        dec: Angle.Degrees(-54.09105441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51043"},
        {"Hipparcos Number", "HIP 33016"},
        {"Geneva Identification System", "GEN# +1.00051043"},
        {"Smithsonian Astrophysical Observation", "SAO 234762"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.19593950),
        dec: Angle.Degrees(-54.09035638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2350"},
        {"Hipparcos Number", "HIP 2132"},
        {"Smithsonian Astrophysical Observation", "SAO 232045"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.76050795),
        dec: Angle.Degrees(-54.09029026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72579"},
        {"Hipparcos Number", "HIP 41777"},
        {"Geneva Identification System", "GEN# +1.00072579"},
        {"Smithsonian Astrophysical Observation", "SAO 236048"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.78734402),
        dec: Angle.Degrees(-54.08864322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 151.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170806"},
        {"Hipparcos Number", "HIP 91050"},
        {"Geneva Identification System", "GEN# +1.00170806"},
        {"Smithsonian Astrophysical Observation", "SAO 245556"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.60535895),
        dec: Angle.Degrees(-54.08798071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110733"},
        {"Hipparcos Number", "HIP 62187"},
        {"Smithsonian Astrophysical Observation", "SAO 240204"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.16952980),
        dec: Angle.Degrees(-54.08538459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190219"},
        {"Hipparcos Number", "HIP 99044"},
        {"Smithsonian Astrophysical Observation", "SAO 246434"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.63183405),
        dec: Angle.Degrees(-54.08464078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223658"},
        {"Hipparcos Number", "HIP 117649"},
        {"Smithsonian Astrophysical Observation", "SAO 248041"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.90273908),
        dec: Angle.Degrees(-54.08123987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61560"},
        {"Hipparcos Number", "HIP 37063"},
        {"Smithsonian Astrophysical Observation", "SAO 235362"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.24607826),
        dec: Angle.Degrees(-54.08053198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94758"},
        {"Hipparcos Number", "HIP 53407"},
        {"Smithsonian Astrophysical Observation", "SAO 238598"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.85642430),
        dec: Angle.Degrees(-54.07962397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116996"},
        {"Hipparcos Number", "HIP 65729"},
        {"Smithsonian Astrophysical Observation", "SAO 240870"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.11456567),
        dec: Angle.Degrees(-54.07901641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120594"},
        {"Hipparcos Number", "HIP 67667"},
        {"Smithsonian Astrophysical Observation", "SAO 241235"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.95367385),
        dec: Angle.Degrees(-54.07853293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -215.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62917"},
        {"Hipparcos Number", "HIP 37638"},
        {"Smithsonian Astrophysical Observation", "SAO 235444"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.85076717),
        dec: Angle.Degrees(-54.07573167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218339"},
        {"Hipparcos Number", "HIP 114220"},
        {"Smithsonian Astrophysical Observation", "SAO 247750"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.97029498),
        dec: Angle.Degrees(-54.07508843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78006"},
        {"Hipparcos Number", "HIP 44482"},
        {"Smithsonian Astrophysical Observation", "SAO 236549"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.94638495),
        dec: Angle.Degrees(-54.07501433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86318"},
        {"Hipparcos Number", "HIP 48702"},
        {"Geneva Identification System", "GEN# +1.00086318"},
        {"Smithsonian Astrophysical Observation", "SAO 237507"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.99163291),
        dec: Angle.Degrees(-54.06582828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61056"},
        {"Hipparcos Number", "HIP 36833"},
        {"Geneva Identification System", "GEN# +1.00061056"},
        {"Smithsonian Astrophysical Observation", "SAO 235309"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.61697691),
        dec: Angle.Degrees(-54.06528640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67929"},
        {"Hipparcos Number", "HIP 39766"},
        {"Geneva Identification System", "GEN# +1.00067929"},
        {"Smithsonian Astrophysical Observation", "SAO 235758"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.91376049),
        dec: Angle.Degrees(-54.06492920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96713"},
        {"Hipparcos Number", "HIP 54385"},
        {"Smithsonian Astrophysical Observation", "SAO 238797"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.91098941),
        dec: Angle.Degrees(-54.06217770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85392"},
        {"Hipparcos Number", "HIP 48207"},
        {"Smithsonian Astrophysical Observation", "SAO 237383"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.42328435),
        dec: Angle.Degrees(-54.06192745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
