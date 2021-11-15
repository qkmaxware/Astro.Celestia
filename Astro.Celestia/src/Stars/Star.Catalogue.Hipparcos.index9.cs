using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_9() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1382"},
        {"Hipparcos Number", "HIP 1413"},
        {"Geneva Identification System", "GEN# +1.00001382"},
        {"Smithsonian Astrophysical Observation", "SAO 248154"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.42085649),
        dec: Angle.Degrees(-60.79920970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19241"},
        {"Hipparcos Number", "HIP 14188"},
        {"Smithsonian Astrophysical Observation", "SAO 248714"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.73280696),
        dec: Angle.Degrees(-60.79776238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211525"},
        {"Hipparcos Number", "HIP 110212"},
        {"Geneva Identification System", "GEN# +1.00211525"},
        {"Smithsonian Astrophysical Observation", "SAO 255196"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.87608114),
        dec: Angle.Degrees(-60.79264864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185260"},
        {"Hipparcos Number", "HIP 96897"},
        {"Geneva Identification System", "GEN# +1.00185260"},
        {"Smithsonian Astrophysical Observation", "SAO 254630"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.45759755),
        dec: Angle.Degrees(-60.79192515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30550",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30550"},
    },
    visualMagnitude: 11.31,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.32922663),
        dec: Angle.Degrees(-60.79140775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70870"},
        {"Geneva Identification System", "GEN# +2.56170137"},
        {"New General Catalogue", "NGC 5617 137"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.38852223),
        dec: Angle.Degrees(-60.79111170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10615"},
        {"Hipparcos Number", "HIP 7921"},
        {"Fundamental Katalog 5th Edition", "FK5 2116"},
        {"Geneva Identification System", "GEN# +1.00010615"},
        {"Smithsonian Astrophysical Observation", "SAO 248421"},
        {"Wilson Evans Batten Catalogue", "WEB 1693"},
    },
    visualMagnitude: 5.70,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.44980076),
        dec: Angle.Degrees(-60.78924102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124788"},
        {"Hipparcos Number", "HIP 69847"},
        {"Geneva Identification System", "GEN# +1.00124788"},
        {"Smithsonian Astrophysical Observation", "SAO 252687"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.42224618),
        dec: Angle.Degrees(-60.78861693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37005"},
        {"Hipparcos Number", "HIP 25874"},
        {"Smithsonian Astrophysical Observation", "SAO 249298"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.85250954),
        dec: Angle.Degrees(-60.78681817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33034",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33034"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.24286511),
        dec: Angle.Degrees(-60.78630782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 205.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25088"},
        {"Hipparcos Number", "HIP 18378"},
        {"Smithsonian Astrophysical Observation", "SAO 248909"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.92160777),
        dec: Angle.Degrees(-60.78355022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163671"},
        {"Hipparcos Number", "HIP 88252"},
        {"Smithsonian Astrophysical Observation", "SAO 254110"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.31579973),
        dec: Angle.Degrees(-60.78269186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35402"},
        {"Hipparcos Number", "HIP 24929"},
        {"Smithsonian Astrophysical Observation", "SAO 249254"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.11753443),
        dec: Angle.Degrees(-60.77991815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133495"},
        {"Hipparcos Number", "HIP 74011"},
        {"Geneva Identification System", "GEN# +1.00133495"},
        {"Smithsonian Astrophysical Observation", "SAO 253021"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.87535416),
        dec: Angle.Degrees(-60.77681148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2576"},
        {"Hipparcos Number", "HIP 2260"},
        {"Smithsonian Astrophysical Observation", "SAO 248195"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.20653870),
        dec: Angle.Degrees(-60.77468864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193886"},
        {"Hipparcos Number", "HIP 100772"},
        {"Smithsonian Astrophysical Observation", "SAO 254790"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.47969105),
        dec: Angle.Degrees(-60.77011937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26788"},
        {"Hipparcos Number", "HIP 19502"},
        {"Smithsonian Astrophysical Observation", "SAO 248958"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.67495493),
        dec: Angle.Degrees(-60.76867212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208654"},
        {"Hipparcos Number", "HIP 108590"},
        {"Smithsonian Astrophysical Observation", "SAO 255123"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.96581022),
        dec: Angle.Degrees(-60.76486588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223368"},
        {"Hipparcos Number", "HIP 117470"},
        {"Smithsonian Astrophysical Observation", "SAO 255573"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.29343324),
        dec: Angle.Degrees(-60.76304167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83337"},
        {"Hipparcos Number", "HIP 47041"},
        {"Celescope Catalog", "CEL 3335"},
        {"Geneva Identification System", "GEN# +1.00083337"},
        {"Smithsonian Astrophysical Observation", "SAO 250630"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.80701981),
        dec: Angle.Degrees(-60.75940689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13551"},
        {"Hipparcos Number", "HIP 10119"},
        {"Geneva Identification System", "GEN# +1.00013551"},
        {"Smithsonian Astrophysical Observation", "SAO 248503"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.53472818),
        dec: Angle.Degrees(-60.75820380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223068"},
        {"Hipparcos Number", "HIP 117264"},
        {"Smithsonian Astrophysical Observation", "SAO 255564"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.64705012),
        dec: Angle.Degrees(-60.75755649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28456"},
        {"Hipparcos Number", "HIP 20657"},
        {"Smithsonian Astrophysical Observation", "SAO 249020"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.39757043),
        dec: Angle.Degrees(-60.75695852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60751"},
        {"Geneva Identification System", "GEN# +5.12580003"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.75891478),
        dec: Angle.Degrees(-60.75450254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108295"},
        {"Hipparcos Number", "HIP 60737"},
        {"Celescope Catalog", "CEL 4106"},
        {"Geneva Identification System", "GEN# +5.12580002"},
        {"Smithsonian Astrophysical Observation", "SAO 251907"},
    },
    visualMagnitude: 9.41,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.71815556),
        dec: Angle.Degrees(-60.75386176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74170"},
        {"Hipparcos Number", "HIP 42448"},
        {"Smithsonian Astrophysical Observation", "SAO 250292"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.81734195),
        dec: Angle.Degrees(-60.75324347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120132"},
        {"Hipparcos Number", "HIP 67435"},
        {"Smithsonian Astrophysical Observation", "SAO 252464"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.31260166),
        dec: Angle.Degrees(-60.75252395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 306077"},
        {"Hipparcos Number", "HIP 54621"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.68584725),
        dec: Angle.Degrees(-60.75028692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168338"},
        {"Hipparcos Number", "HIP 90089"},
        {"Smithsonian Astrophysical Observation", "SAO 254225"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.76863999),
        dec: Angle.Degrees(-60.74916255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60814",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60814"},
        {"Geneva Identification System", "GEN# +5.12580021"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.96554546),
        dec: Angle.Degrees(-60.74909351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78933"},
        {"Hipparcos Number", "HIP 44837"},
        {"Smithsonian Astrophysical Observation", "SAO 250454"},
    },
    visualMagnitude: 8.41,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.03356383),
        dec: Angle.Degrees(-60.74865238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221070"},
        {"Hipparcos Number", "HIP 115948"},
        {"Geneva Identification System", "GEN# +1.00221070"},
        {"Smithsonian Astrophysical Observation", "SAO 255500"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.36800749),
        dec: Angle.Degrees(-60.74863961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86674"},
        {"Hipparcos Number", "HIP 48859"},
        {"Smithsonian Astrophysical Observation", "SAO 250763"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.48424886),
        dec: Angle.Degrees(-60.74816387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141913"},
        {"Hipparcos Number", "HIP 77927"},
        {"Geneva Identification System", "GEN# +1.00141913J"},
        {"Smithsonian Astrophysical Observation", "SAO 253344"},
        {"Wilson Evans Batten Catalogue", "WEB 13177"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.71932400),
        dec: Angle.Degrees(-60.74364091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138509"},
        {"Hipparcos Number", "HIP 76344"},
        {"Smithsonian Astrophysical Observation", "SAO 253218"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.90553079),
        dec: Angle.Degrees(-60.74342471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113163"},
        {"Hipparcos Number", "HIP 63658"},
        {"Geneva Identification System", "GEN# +1.00113163"},
        {"Smithsonian Astrophysical Observation", "SAO 252135"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.69797085),
        dec: Angle.Degrees(-60.74288517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 305784"},
        {"Hipparcos Number", "HIP 53593"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.46116130),
        dec: Angle.Degrees(-60.74209254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133906"},
        {"Hipparcos Number", "HIP 74201"},
        {"Smithsonian Astrophysical Observation", "SAO 253039"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.44492220),
        dec: Angle.Degrees(-60.74069712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147883"},
        {"Hipparcos Number", "HIP 80654"},
        {"Smithsonian Astrophysical Observation", "SAO 253559"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.00125292),
        dec: Angle.Degrees(-60.73919552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89187"},
        {"Hipparcos Number", "HIP 50240"},
        {"Smithsonian Astrophysical Observation", "SAO 250895"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.87680261),
        dec: Angle.Degrees(-60.73790362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189009"},
        {"Hipparcos Number", "HIP 98576"},
        {"Smithsonian Astrophysical Observation", "SAO 254708"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.35125907),
        dec: Angle.Degrees(-60.73604079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99325"},
        {"Hipparcos Number", "HIP 55726"},
        {"Geneva Identification System", "GEN# +1.00099325"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.27401259),
        dec: Angle.Degrees(-60.73462604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154577"},
        {"Hipparcos Number", "HIP 83990"},
        {"Cincinnati Publication", "Ci 20 1020"},
        {"Geneva Identification System", "GEN# +1.00154577"},
        {"Smithsonian Astrophysical Observation", "SAO 253819"},
        {"Wilson Evans Batten Catalogue", "WEB 14190"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.54277606),
        dec: Angle.Degrees(-60.73020472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 589.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141606"},
        {"Hipparcos Number", "HIP 77799"},
        {"Smithsonian Astrophysical Observation", "SAO 253327"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.29774939),
        dec: Angle.Degrees(-60.72948318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46069"},
        {"Hipparcos Number", "HIP 30714"},
        {"Smithsonian Astrophysical Observation", "SAO 249552"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.80046455),
        dec: Angle.Degrees(-60.72861488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6596"},
        {"Hipparcos Number", "HIP 5127"},
        {"Smithsonian Astrophysical Observation", "SAO 248314"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.41364909),
        dec: Angle.Degrees(-60.72819898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186582"},
        {"Hipparcos Number", "HIP 97483"},
        {"Smithsonian Astrophysical Observation", "SAO 254653"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.20804545),
        dec: Angle.Degrees(-60.72729094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207454"},
        {"Hipparcos Number", "HIP 107860"},
        {"Geneva Identification System", "GEN# +1.00207454"},
        {"Smithsonian Astrophysical Observation", "SAO 255092"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.78451967),
        dec: Angle.Degrees(-60.72507252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215037"},
        {"Hipparcos Number", "HIP 112223"},
        {"Geneva Identification System", "GEN# +1.00215037"},
        {"Smithsonian Astrophysical Observation", "SAO 255297"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.92795965),
        dec: Angle.Degrees(-60.72413063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38974"},
        {"Hipparcos Number", "HIP 27160"},
        {"Smithsonian Astrophysical Observation", "SAO 249349"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.36806437),
        dec: Angle.Degrees(-60.72192149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121404"},
        {"Hipparcos Number", "HIP 68140"},
        {"Geneva Identification System", "GEN# +1.00121404"},
        {"Smithsonian Astrophysical Observation", "SAO 252528"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.26449465),
        dec: Angle.Degrees(-60.71650949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72487"},
        {"Hipparcos Number", "HIP 41696"},
        {"Smithsonian Astrophysical Observation", "SAO 250247"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.50375935),
        dec: Angle.Degrees(-60.71495338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47476"},
        {"Hipparcos Number", "HIP 31399"},
        {"Smithsonian Astrophysical Observation", "SAO 249591"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.72838450),
        dec: Angle.Degrees(-60.71402247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152670"},
        {"Hipparcos Number", "HIP 83071"},
        {"Smithsonian Astrophysical Observation", "SAO 253754"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.62272678),
        dec: Angle.Degrees(-60.70811291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12673"},
        {"Hipparcos Number", "HIP 9483"},
        {"Smithsonian Astrophysical Observation", "SAO 248483"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.50394318),
        dec: Angle.Degrees(-60.70739287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142586"},
        {"Hipparcos Number", "HIP 78258"},
        {"Smithsonian Astrophysical Observation", "SAO 253363"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.68284327),
        dec: Angle.Degrees(-60.70732562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43526"},
        {"Smithsonian Astrophysical Observation", "SAO 250355"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.97796948),
        dec: Angle.Degrees(-60.70181244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140709"},
        {"Hipparcos Number", "HIP 77423"},
        {"Smithsonian Astrophysical Observation", "SAO 253300"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.09087207),
        dec: Angle.Degrees(-60.70157195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5771"},
        {"Hipparcos Number", "HIP 4563"},
        {"Geneva Identification System", "GEN# +1.00005771"},
        {"Renson", "Renson 1500"},
        {"Smithsonian Astrophysical Observation", "SAO 248293"},
        {"Wilson Evans Batten Catalogue", "WEB 836"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.59240996),
        dec: Angle.Degrees(-60.69629569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100277"},
        {"Hipparcos Number", "HIP 56249"},
        {"Geneva Identification System", "GEN# +1.00100277"},
        {"Smithsonian Astrophysical Observation", "SAO 251444"},
        {"Wilson Evans Batten Catalogue", "WEB 10110"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.95292786),
        dec: Angle.Degrees(-60.69344807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220804"},
        {"Hipparcos Number", "HIP 115785"},
        {"Smithsonian Astrophysical Observation", "SAO 255489"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.85354083),
        dec: Angle.Degrees(-60.69232611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225062"},
        {"Hipparcos Number", "HIP 243"},
        {"Smithsonian Astrophysical Observation", "SAO 248107"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.75337695),
        dec: Angle.Degrees(-60.69189462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148430"},
        {"Hipparcos Number", "HIP 80935"},
        {"Smithsonian Astrophysical Observation", "SAO 253587"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.90378595),
        dec: Angle.Degrees(-60.69116816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48858"},
        {"Hipparcos Number", "HIP 32038"},
        {"Geneva Identification System", "GEN# +1.00048858"},
        {"Smithsonian Astrophysical Observation", "SAO 249622"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.38842594),
        dec: Angle.Degrees(-60.68814570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33392",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33392"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.18162884),
        dec: Angle.Degrees(-60.68644397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4190"},
        {"Hipparcos Number", "HIP 3426"},
        {"Smithsonian Astrophysical Observation", "SAO 248241"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.90754148),
        dec: Angle.Degrees(-60.68549381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212209"},
        {"Hipparcos Number", "HIP 110585"},
        {"Smithsonian Astrophysical Observation", "SAO 255212"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.05271362),
        dec: Angle.Degrees(-60.68532297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103465"},
        {"Hipparcos Number", "HIP 58087"},
        {"Geneva Identification System", "GEN# +1.00103465"},
        {"Smithsonian Astrophysical Observation", "SAO 251638"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.68941694),
        dec: Angle.Degrees(-60.68487981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97949"},
        {"Hipparcos Number", "HIP 54944"},
        {"Geneva Identification System", "GEN# +1.00097949"},
        {"Smithsonian Astrophysical Observation", "SAO 251333"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.76967022),
        dec: Angle.Degrees(-60.68468344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120403"},
        {"Geneva Identification System", "GEN# +2.25160011"},
        {"Wilson Evans Batten Catalogue", "WEB 7627"},
        {"New General Catalogue", "NGC 2516 11"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.45492680),
        dec: Angle.Degrees(-60.68365819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158094"},
        {"Hipparcos Number", "HIP 85727"},
        {"Fundamental Katalog 5th Edition", "FK5 648"},
        {"Geneva Identification System", "GEN# +1.00158094A"},
        {"Smithsonian Astrophysical Observation", "SAO 253945"},
        {"Wilson Evans Batten Catalogue", "WEB 14467"},
    },
    visualMagnitude: 3.60,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.77490395),
        dec: Angle.Degrees(-60.68360667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14732"},
        {"Hipparcos Number", "HIP 10899"},
        {"Smithsonian Astrophysical Observation", "SAO 248536"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.06810415),
        dec: Angle.Degrees(-60.68107853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36478"},
        {"Hipparcos Number", "HIP 25581"},
        {"Smithsonian Astrophysical Observation", "SAO 249282"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.00526103),
        dec: Angle.Degrees(-60.67957354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163171"},
        {"Hipparcos Number", "HIP 88009"},
        {"Smithsonian Astrophysical Observation", "SAO 254094"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.66049140),
        dec: Angle.Degrees(-60.67954510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217154"},
        {"Hipparcos Number", "HIP 113530"},
        {"Geneva Identification System", "GEN# +1.00217154"},
        {"Smithsonian Astrophysical Observation", "SAO 255368"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.89692850),
        dec: Angle.Degrees(-60.67886161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54668"},
        {"Geneva Identification System", "GEN# +4.35180001"},
    },
    visualMagnitude: 9.12,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.86286894),
        dec: Angle.Degrees(-60.67833062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152186"},
        {"Hipparcos Number", "HIP 82827"},
        {"Smithsonian Astrophysical Observation", "SAO 253736"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.89353540),
        dec: Angle.Degrees(-60.67736761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161315"},
        {"Hipparcos Number", "HIP 87183"},
        {"Smithsonian Astrophysical Observation", "SAO 254042"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.18008827),
        dec: Angle.Degrees(-60.67694387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81991"},
        {"Hipparcos Number", "HIP 46312"},
        {"Smithsonian Astrophysical Observation", "SAO 250579"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.66205586),
        dec: Angle.Degrees(-60.67650027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39608"},
        {"Hipparcos Number", "HIP 27516"},
        {"Smithsonian Astrophysical Observation", "SAO 249364"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.40186087),
        dec: Angle.Degrees(-60.67632010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203414"},
        {"Hipparcos Number", "HIP 105698"},
        {"Smithsonian Astrophysical Observation", "SAO 254994"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.11086474),
        dec: Angle.Degrees(-60.67520190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106942"},
        {"Hipparcos Number", "HIP 59981"},
        {"Smithsonian Astrophysical Observation", "SAO 251836"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.51960100),
        dec: Angle.Degrees(-60.67478092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156942"},
        {"Hipparcos Number", "HIP 85169"},
        {"Geneva Identification System", "GEN# +1.00156942"},
        {"Smithsonian Astrophysical Observation", "SAO 253908"},
        {"Wilson Evans Batten Catalogue", "WEB 14382"},
    },
    visualMagnitude: 5.76,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.07831712),
        dec: Angle.Degrees(-60.67376920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2981"},
        {"Hipparcos Number", "HIP 2555"},
        {"Smithsonian Astrophysical Observation", "SAO 248207"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.11677965),
        dec: Angle.Degrees(-60.67281256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210273"},
        {"Hipparcos Number", "HIP 109513"},
        {"Geneva Identification System", "GEN# +1.00210273"},
        {"Smithsonian Astrophysical Observation", "SAO 255164"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.76956385),
        dec: Angle.Degrees(-60.67182350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112999"},
        {"Hipparcos Number", "HIP 63565"},
        {"Geneva Identification System", "GEN# +1.00112999"},
        {"Smithsonian Astrophysical Observation", "SAO 252129"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.39545798),
        dec: Angle.Degrees(-60.67137886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90189"},
        {"Hipparcos Number", "HIP 50846"},
        {"Smithsonian Astrophysical Observation", "SAO 250937"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.73997626),
        dec: Angle.Degrees(-60.66975059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131945"},
        {"Hipparcos Number", "HIP 73343"},
        {"Geneva Identification System", "GEN# +1.00131945"},
        {"Smithsonian Astrophysical Observation", "SAO 252983"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.81427689),
        dec: Angle.Degrees(-60.66941998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26943"},
        {"Hipparcos Number", "HIP 19596"},
        {"Smithsonian Astrophysical Observation", "SAO 248961"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.99538431),
        dec: Angle.Degrees(-60.66491838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111331"},
        {"Henry Draper 2", "HD 111332"},
        {"Hipparcos Number", "HIP 62571"},
        {"Geneva Identification System", "GEN# +1.00111331"},
        {"Geneva Identification System 2", "GEN# +1.00111332"},
        {"Smithsonian Astrophysical Observation", "SAO 252040"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.30592192),
        dec: Angle.Degrees(-60.66200563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161256"},
        {"Hipparcos Number", "HIP 87154"},
        {"Geneva Identification System", "GEN# +1.00161256"},
        {"Smithsonian Astrophysical Observation", "SAO 254038"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.09264501),
        dec: Angle.Degrees(-60.66065000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28340"},
        {"Hipparcos Number", "HIP 20578"},
        {"Smithsonian Astrophysical Observation", "SAO 249014"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.12049277),
        dec: Angle.Degrees(-60.65908258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136359"},
        {"Hipparcos Number", "HIP 75308"},
        {"Geneva Identification System", "GEN# +1.00136359"},
        {"Smithsonian Astrophysical Observation", "SAO 253136"},
        {"Wilson Evans Batten Catalogue", "WEB 12845"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.79417262),
        dec: Angle.Degrees(-60.65710865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71921"},
        {"Hipparcos Number", "HIP 41396"},
        {"Smithsonian Astrophysical Observation", "SAO 250230"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.67860761),
        dec: Angle.Degrees(-60.65442668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101222"},
        {"Hipparcos Number", "HIP 56771"},
        {"Smithsonian Astrophysical Observation", "SAO 251508"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.58740201),
        dec: Angle.Degrees(-60.65411888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44013"},
        {"Hipparcos Number", "HIP 29698"},
        {"Smithsonian Astrophysical Observation", "SAO 249493"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.84878473),
        dec: Angle.Degrees(-60.65184399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71448"},
        {"Hipparcos Number", "HIP 41182"},
        {"Smithsonian Astrophysical Observation", "SAO 250216"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.05771485),
        dec: Angle.Degrees(-60.64948357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32713"},
        {"Hipparcos Number", "HIP 23346"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.32526078),
        dec: Angle.Degrees(-60.64926688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126640"},
        {"Hipparcos Number", "HIP 70832"},
        {"Geneva Identification System", "GEN# +2.56170055"},
        {"New General Catalogue", "NGC 5617 55"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.27656790),
        dec: Angle.Degrees(-60.64645863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88500"},
        {"Hipparcos Number", "HIP 49838"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.63299271),
        dec: Angle.Degrees(-60.64512389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76728"},
        {"Hipparcos Number", "HIP 43783"},
        {"Celescope Catalog", "CEL 3087"},
        {"Fundamental Katalog 5th Edition", "FK5 336"},
        {"Geneva Identification System", "GEN# +1.00076728"},
        {"Smithsonian Astrophysical Observation", "SAO 250374"},
        {"Wilson Evans Batten Catalogue", "WEB 8421"},
    },
    visualMagnitude: 3.84,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.76192355),
        dec: Angle.Degrees(-60.64471195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 305974"},
        {"Hipparcos Number", "HIP 54066"},
        {"Wilson Evans Batten Catalogue", "WEB 9779"},
    },
    visualMagnitude: 10.13,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.93837975),
        dec: Angle.Degrees(-60.64227516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 309"},
        {"Hipparcos Number", "HIP 618"},
        {"Smithsonian Astrophysical Observation", "SAO 248119"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.89458828),
        dec: Angle.Degrees(-60.64172798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86215"},
        {"Hipparcos Number", "HIP 48626"},
        {"Smithsonian Astrophysical Observation", "SAO 250747"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.74016821),
        dec: Angle.Degrees(-60.64076015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157770"},
        {"Hipparcos Number", "HIP 85568"},
        {"Smithsonian Astrophysical Observation", "SAO 253937"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.30340154),
        dec: Angle.Degrees(-60.63990256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130208"},
        {"Hipparcos Number", "HIP 72500"},
        {"Smithsonian Astrophysical Observation", "SAO 252905"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.36491057),
        dec: Angle.Degrees(-60.63869686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75713"},
        {"Hipparcos Number", "HIP 43253"},
        {"Smithsonian Astrophysical Observation", "SAO 250331"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.16891019),
        dec: Angle.Degrees(-60.63811160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31485"},
        {"Hipparcos Number", "HIP 22660"},
        {"Smithsonian Astrophysical Observation", "SAO 249127"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.10864802),
        dec: Angle.Degrees(-60.63639506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20496"},
        {"Hipparcos Number", "HIP 15112"},
        {"Geneva Identification System", "GEN# +1.00020496"},
        {"Smithsonian Astrophysical Observation", "SAO 248761"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.72928650),
        dec: Angle.Degrees(-60.63579388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115636"},
        {"Hipparcos Number", "HIP 65015"},
        {"Smithsonian Astrophysical Observation", "SAO 252263"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.91005888),
        dec: Angle.Degrees(-60.63517600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196050"},
        {"Hipparcos Number", "HIP 101806"},
        {"Geneva Identification System", "GEN# +1.00196050"},
        {"Smithsonian Astrophysical Observation", "SAO 254837"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.46640563),
        dec: Angle.Degrees(-60.63432569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65896"},
        {"Hipparcos Number", "HIP 120401"},
        {"Geneva Identification System", "GEN# +2.25160012"},
        {"Renson", "Renson 18050"},
        {"Smithsonian Astrophysical Observation", "SAO 250032"},
        {"New General Catalogue", "NGC 2516 12"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.38227544),
        dec: Angle.Degrees(-60.63092936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62091"},
        {"Hipparcos Number", "HIP 37212"},
        {"Smithsonian Astrophysical Observation", "SAO 249907"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.65845662),
        dec: Angle.Degrees(-60.62948032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120444"},
        {"Hipparcos Number", "HIP 67610"},
        {"Geneva Identification System", "GEN# +1.00120444"},
        {"Smithsonian Astrophysical Observation", "SAO 252480"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.80655411),
        dec: Angle.Degrees(-60.62923358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8652"},
        {"Hipparcos Number", "HIP 6531"},
        {"Smithsonian Astrophysical Observation", "SAO 248376"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.98667719),
        dec: Angle.Degrees(-60.62896886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83111"},
        {"Hipparcos Number", "HIP 46912"},
        {"Smithsonian Astrophysical Observation", "SAO 250621"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.43277929),
        dec: Angle.Degrees(-60.62775111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68372"},
        {"Hipparcos Number", "HIP 39879"},
        {"Geneva Identification System", "GEN# +1.00068372"},
        {"Smithsonian Astrophysical Observation", "SAO 250129"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.18525814),
        dec: Angle.Degrees(-60.62583833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174453"},
        {"Hipparcos Number", "HIP 92786"},
        {"Smithsonian Astrophysical Observation", "SAO 254406"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.61781330),
        dec: Angle.Degrees(-60.62166102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75853"},
        {"Hipparcos Number", "HIP 43314"},
        {"Smithsonian Astrophysical Observation", "SAO 250337"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.35707498),
        dec: Angle.Degrees(-60.62045906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71044"},
        {"Hipparcos Number", "HIP 40998"},
        {"Geneva Identification System", "GEN# +1.00071044"},
        {"Smithsonian Astrophysical Observation", "SAO 250205"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.50162611),
        dec: Angle.Degrees(-60.62036945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6947"},
        {"Hipparcos Number", "HIP 5374"},
        {"Smithsonian Astrophysical Observation", "SAO 248327"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.19232020),
        dec: Angle.Degrees(-60.62019275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42961"},
        {"Smithsonian Astrophysical Observation", "SAO 250319"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.35308163),
        dec: Angle.Degrees(-60.61857661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154459"},
        {"Hipparcos Number", "HIP 83938"},
        {"Geneva Identification System", "GEN# +1.00154459"},
        {"Smithsonian Astrophysical Observation", "SAO 253815"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.35310663),
        dec: Angle.Degrees(-60.61816600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65987"},
        {"Hipparcos Number", "HIP 120404"},
        {"Geneva Identification System", "GEN# +2.25160015"},
        {"Renson", "Renson 18130"},
        {"Smithsonian Astrophysical Observation", "SAO 250040"},
        {"Wilson Evans Batten Catalogue", "WEB 7631"},
        {"New General Catalogue", "NGC 2516 15"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.51215354),
        dec: Angle.Degrees(-60.61481210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137022"},
        {"Hipparcos Number", "HIP 75597"},
        {"Smithsonian Astrophysical Observation", "SAO 253167"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.68486853),
        dec: Angle.Degrees(-60.61465238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96581"},
    },
    visualMagnitude: 12.64,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.51409255),
        dec: Angle.Degrees(-60.61098802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196130"},
        {"Hipparcos Number", "HIP 101859"},
        {"Smithsonian Astrophysical Observation", "SAO 254839"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.60626438),
        dec: Angle.Degrees(-60.61021942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65949"},
        {"Hipparcos Number", "HIP 120402"},
        {"Geneva Identification System", "GEN# +2.25160091"},
        {"Renson", "Renson 18100"},
        {"Smithsonian Astrophysical Observation", "SAO 250037"},
        {"New General Catalogue", "NGC 2516 91"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.44866083),
        dec: Angle.Degrees(-60.60972637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169505"},
        {"Hipparcos Number", "HIP 90567"},
        {"Smithsonian Astrophysical Observation", "SAO 254259"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.20592743),
        dec: Angle.Degrees(-60.60970073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18515"},
        {"Hipparcos Number", "HIP 13651"},
        {"Smithsonian Astrophysical Observation", "SAO 248686"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.94144459),
        dec: Angle.Degrees(-60.60959284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193529"},
        {"Hipparcos Number", "HIP 100589"},
        {"Smithsonian Astrophysical Observation", "SAO 254784"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.96887689),
        dec: Angle.Degrees(-60.60952800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80349"},
        {"Hipparcos Number", "HIP 45525"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.17219407),
        dec: Angle.Degrees(-60.60917688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208577"},
        {"Hipparcos Number", "HIP 108527"},
        {"Geneva Identification System", "GEN# +1.00208577"},
        {"Smithsonian Astrophysical Observation", "SAO 255116"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.78974106),
        dec: Angle.Degrees(-60.60781557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100276"},
        {"Hipparcos Number", "HIP 56247"},
        {"Geneva Identification System", "GEN# +1.00100276"},
        {"Smithsonian Astrophysical Observation", "SAO 251443"},
        {"Wilson Evans Batten Catalogue", "WEB 10109"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.95015770),
        dec: Angle.Degrees(-60.60637158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30791"},
        {"Hipparcos Number", "HIP 22229"},
        {"Geneva Identification System", "GEN# +1.00030791"},
        {"Smithsonian Astrophysical Observation", "SAO 249105"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.71748619),
        dec: Angle.Degrees(-60.60384543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93502"},
        {"Hipparcos Number", "HIP 52679"},
        {"Celescope Catalog", "CEL 3696"},
        {"Geneva Identification System", "GEN# +1.00093502J"},
        {"Smithsonian Astrophysical Observation", "SAO 251113"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.57132204),
        dec: Angle.Degrees(-60.60289257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42028"},
        {"Hipparcos Number", "HIP 28771"},
        {"Smithsonian Astrophysical Observation", "SAO 249438"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.12868946),
        dec: Angle.Degrees(-60.60276854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57720"},
        {"Hipparcos Number", "HIP 35420"},
        {"Geneva Identification System", "GEN# +1.00057720"},
        {"Smithsonian Astrophysical Observation", "SAO 249815"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.69326002),
        dec: Angle.Degrees(-60.60261152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152511"},
        {"Hipparcos Number", "HIP 82985"},
        {"Smithsonian Astrophysical Observation", "SAO 253748"},
    },
    visualMagnitude: 6.52,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.37467511),
        dec: Angle.Degrees(-60.60009222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118835"},
        {"Hipparcos Number", "HIP 66752"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.22731641),
        dec: Angle.Degrees(-60.59882197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18630"},
        {"Hipparcos Number", "HIP 13738"},
        {"Smithsonian Astrophysical Observation", "SAO 248689"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.22484566),
        dec: Angle.Degrees(-60.59680865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112784"},
        {"Hipparcos Number", "HIP 63449"},
        {"Celescope Catalog", "CEL 4189"},
        {"Geneva Identification System", "GEN# +1.00112784"},
        {"Smithsonian Astrophysical Observation", "SAO 252119"},
        {"Wilson Evans Batten Catalogue", "WEB 11227"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.02350471),
        dec: Angle.Degrees(-60.59367009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85741"},
        {"Hipparcos Number", "HIP 48377"},
        {"Geneva Identification System", "GEN# +1.00085741"},
        {"Smithsonian Astrophysical Observation", "SAO 250728"},
        {"Wilson Evans Batten Catalogue", "WEB 9024"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.92229168),
        dec: Angle.Degrees(-60.59361255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85513"},
        {"Hipparcos Number", "HIP 48247"},
        {"Smithsonian Astrophysical Observation", "SAO 250713"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.53919132),
        dec: Angle.Degrees(-60.59327594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25119"},
        {"Hipparcos Number", "HIP 18400"},
        {"Geneva Identification System", "GEN# +1.00025119"},
        {"Smithsonian Astrophysical Observation", "SAO 248910"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.01325500),
        dec: Angle.Degrees(-60.59283476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191853"},
        {"Hipparcos Number", "HIP 99828"},
        {"Smithsonian Astrophysical Observation", "SAO 254760"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.82627303),
        dec: Angle.Degrees(-60.59249339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188321"},
        {"Hipparcos Number", "HIP 98267"},
        {"Geneva Identification System", "GEN# +1.00188321"},
        {"Smithsonian Astrophysical Observation", "SAO 254695"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.50419876),
        dec: Angle.Degrees(-60.58960022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47307"},
        {"Hipparcos Number", "HIP 31315"},
        {"Smithsonian Astrophysical Observation", "SAO 249585"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.51416683),
        dec: Angle.Degrees(-60.58784494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66342"},
        {"Hipparcos Number", "HIP 39070"},
        {"Geneva Identification System", "GEN# +2.25160110"},
        {"Smithsonian Astrophysical Observation", "SAO 250063"},
        {"Wilson Evans Batten Catalogue", "WEB 7663"},
        {"New General Catalogue", "NGC 2516 110"},
    },
    visualMagnitude: 5.19,
    bvColour: 1.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.90644286),
        dec: Angle.Degrees(-60.58708857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218994"},
        {"Hipparcos Number", "HIP 114629"},
        {"Smithsonian Astrophysical Observation", "SAO 255430"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.31662990),
        dec: Angle.Degrees(-60.58407094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40693"},
        {"Hipparcos Number", "HIP 28105"},
        {"Smithsonian Astrophysical Observation", "SAO 249397"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.10299233),
        dec: Angle.Degrees(-60.58352161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195627"},
        {"Hipparcos Number", "HIP 101612"},
        {"Geneva Identification System", "GEN# +1.00195627"},
        {"Smithsonian Astrophysical Observation", "SAO 254823"},
        {"Wilson Evans Batten Catalogue", "WEB 18357"},
    },
    visualMagnitude: 4.75,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.89486744),
        dec: Angle.Degrees(-60.58129819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195174"},
        {"Hipparcos Number", "HIP 101394"},
        {"Smithsonian Astrophysical Observation", "SAO 254814"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.23248352),
        dec: Angle.Degrees(-60.57893131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65662"},
        {"Hipparcos Number", "HIP 38783"},
        {"Geneva Identification System", "GEN# +2.25160119"},
        {"Smithsonian Astrophysical Observation", "SAO 250019"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.07772578),
        dec: Angle.Degrees(-60.52646168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55433"},
        {"Hipparcos Number", "HIP 34517"},
        {"Smithsonian Astrophysical Observation", "SAO 249750"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.28079452),
        dec: Angle.Degrees(-60.57530399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22359"},
        {"Hipparcos Number", "HIP 16523"},
        {"Geneva Identification System", "GEN# +1.00022359"},
        {"Smithsonian Astrophysical Observation", "SAO 248832"},
        {"Wilson Evans Batten Catalogue", "WEB 3157"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.18181949),
        dec: Angle.Degrees(-60.57441849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5593"},
        {"Hipparcos Number", "HIP 4430"},
        {"Smithsonian Astrophysical Observation", "SAO 248285"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.18011845),
        dec: Angle.Degrees(-60.57011926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208153"},
        {"Hipparcos Number", "HIP 108304"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.11886906),
        dec: Angle.Degrees(-60.56891244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98133"},
        {"Hipparcos Number", "HIP 55069"},
        {"Smithsonian Astrophysical Observation", "SAO 251337"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.11843370),
        dec: Angle.Degrees(-60.56796680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93070"},
        {"Hipparcos Number", "HIP 52468"},
        {"Geneva Identification System", "GEN# +1.00093070"},
        {"Smithsonian Astrophysical Observation", "SAO 251090"},
        {"Wilson Evans Batten Catalogue", "WEB 9556"},
    },
    visualMagnitude: 4.58,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.88461543),
        dec: Angle.Degrees(-60.56662705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78231"},
        {"Hipparcos Number", "HIP 44523"},
        {"Fundamental Katalog 5th Edition", "FK5 4808"},
        {"Smithsonian Astrophysical Observation", "SAO 250429"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.07577508),
        dec: Angle.Degrees(-60.56604535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218631"},
        {"Hipparcos Number", "HIP 114428"},
        {"Geneva Identification System", "GEN# +1.00218631"},
        {"Smithsonian Astrophysical Observation", "SAO 255421"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.61263586),
        dec: Angle.Degrees(-60.56433991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 305560"},
        {"Hipparcos Number", "HIP 52697"},
        {"Geneva Identification System", "GEN# +1.00305560"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.61859166),
        dec: Angle.Degrees(-60.56410179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151539"},
        {"Hipparcos Number", "HIP 82497"},
        {"Geneva Identification System", "GEN# +1.00151539"},
        {"Smithsonian Astrophysical Observation", "SAO 253720"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.90246744),
        dec: Angle.Degrees(-60.56360599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150548"},
        {"Hipparcos Number", "HIP 82034"},
        {"Smithsonian Astrophysical Observation", "SAO 253686"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.36552408),
        dec: Angle.Degrees(-60.56355491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135786"},
        {"Hipparcos Number", "HIP 75032"},
        {"Geneva Identification System", "GEN# +1.00135786"},
        {"Smithsonian Astrophysical Observation", "SAO 253113"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.97527151),
        dec: Angle.Degrees(-60.56124837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118717"},
        {"Hipparcos Number", "HIP 66676"},
        {"Smithsonian Astrophysical Observation", "SAO 252401"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.03197848),
        dec: Angle.Degrees(-60.55673462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207014"},
        {"Hipparcos Number", "HIP 107639"},
        {"Smithsonian Astrophysical Observation", "SAO 255074"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.03686764),
        dec: Angle.Degrees(-60.55343885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84309"},
        {"Hipparcos Number", "HIP 47580"},
        {"Smithsonian Astrophysical Observation", "SAO 250667"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.52584240),
        dec: Angle.Degrees(-60.55260694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21160"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.04568941),
        dec: Angle.Degrees(-60.52544351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110863"},
        {"Hipparcos Number", "HIP 62291"},
        {"Geneva Identification System", "GEN# +1.00110863"},
        {"Smithsonian Astrophysical Observation", "SAO 252017"},
        {"Wilson Evans Batten Catalogue", "WEB 11063"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.47485100),
        dec: Angle.Degrees(-60.55151466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138679"},
        {"Hipparcos Number", "HIP 76434"},
        {"Geneva Identification System", "GEN# +1.00138679"},
        {"Smithsonian Astrophysical Observation", "SAO 253230"},
    },
    visualMagnitude: 8.93,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.16712820),
        dec: Angle.Degrees(-60.55029722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92314"},
        {"Hipparcos Number", "HIP 52046"},
        {"Smithsonian Astrophysical Observation", "SAO 251040"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.52972519),
        dec: Angle.Degrees(-60.54899479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210303"},
        {"Hipparcos Number", "HIP 109536"},
        {"Geneva Identification System", "GEN# +1.00210303"},
        {"Smithsonian Astrophysical Observation", "SAO 255166"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.81810187),
        dec: Angle.Degrees(-60.54802797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196378"},
        {"Hipparcos Number", "HIP 101983"},
        {"Cincinnati Publication", "Ci 20 1217"},
        {"Geneva Identification System", "GEN# +1.00196378"},
        {"Smithsonian Astrophysical Observation", "SAO 254846"},
        {"Wilson Evans Batten Catalogue", "WEB 18433"},
    },
    visualMagnitude: 5.11,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.00944347),
        dec: Angle.Degrees(-60.54750937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 312.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -568.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16816"},
        {"Hipparcos Number", "HIP 12372"},
        {"Smithsonian Astrophysical Observation", "SAO 248613"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.81985612),
        dec: Angle.Degrees(-60.54741061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99683"},
        {"Hipparcos Number", "HIP 55896"},
        {"Geneva Identification System", "GEN# +1.00099683"},
        {"Smithsonian Astrophysical Observation", "SAO 251410"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.85819935),
        dec: Angle.Degrees(-60.54618212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103180"},
        {"Hipparcos Number", "HIP 57914"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.17760709),
        dec: Angle.Degrees(-60.54058725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126593"},
        {"Hipparcos Number", "HIP 70808"},
        {"Geneva Identification System", "GEN# +1.00126593J"},
        {"Smithsonian Astrophysical Observation", "SAO 252755"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.21199951),
        dec: Angle.Degrees(-60.54030140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34534"},
        {"Smithsonian Astrophysical Observation", "SAO 249753"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.33308974),
        dec: Angle.Degrees(-60.53554015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79905"},
        {"Hipparcos Number", "HIP 45311"},
        {"Smithsonian Astrophysical Observation", "SAO 250496"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.52870541),
        dec: Angle.Degrees(-60.53539635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164725"},
        {"Hipparcos Number", "HIP 88697"},
        {"Smithsonian Astrophysical Observation", "SAO 254137"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.60990951),
        dec: Angle.Degrees(-60.53313863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102270"},
        {"Hipparcos Number", "HIP 57390"},
        {"Geneva Identification System", "GEN# +1.00102270"},
        {"Smithsonian Astrophysical Observation", "SAO 251578"},
    },
    visualMagnitude: 9.73,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.49377389),
        dec: Angle.Degrees(-60.53302800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90836"},
        {"Hipparcos Number", "HIP 51215"},
        {"Geneva Identification System", "GEN# +1.00090836"},
        {"Smithsonian Astrophysical Observation", "SAO 250968"},
    },
    visualMagnitude: 8.96,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.92033842),
        dec: Angle.Degrees(-60.53074309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85596"},
        {"Hipparcos Number", "HIP 48281"},
        {"Smithsonian Astrophysical Observation", "SAO 250718"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.65794101),
        dec: Angle.Degrees(-60.52774634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61482",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61482"},
        {"Celescope Catalog", "CEL 4127"},
        {"Geneva Identification System", "GEN# -0.05904330"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.96418777),
        dec: Angle.Degrees(-60.52478715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200980"},
        {"Hipparcos Number", "HIP 104445"},
        {"Smithsonian Astrophysical Observation", "SAO 254946"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.36327654),
        dec: Angle.Degrees(-60.52467149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82920"},
        {"Hipparcos Number", "HIP 46825"},
        {"Fundamental Katalog 5th Edition", "FK5 4847"},
        {"Geneva Identification System", "GEN# +1.00082920"},
        {"Smithsonian Astrophysical Observation", "SAO 250615"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.13313450),
        dec: Angle.Degrees(-60.52344523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198779"},
        {"Hipparcos Number", "HIP 103293"},
        {"Smithsonian Astrophysical Observation", "SAO 254901"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.89931217),
        dec: Angle.Degrees(-60.52222297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156372"},
        {"Hipparcos Number", "HIP 84900"},
        {"Smithsonian Astrophysical Observation", "SAO 253879"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.26565791),
        dec: Angle.Degrees(-60.52076723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219764"},
        {"Hipparcos Number", "HIP 115123"},
        {"Geneva Identification System", "GEN# +1.00219764"},
        {"Smithsonian Astrophysical Observation", "SAO 255457"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.77295718),
        dec: Angle.Degrees(-60.52055767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131283"},
        {"Hipparcos Number", "HIP 73017"},
        {"Smithsonian Astrophysical Observation", "SAO 252959"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.83630117),
        dec: Angle.Degrees(-60.51834744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94776"},
        {"Hipparcos Number", "HIP 53394"},
        {"Geneva Identification System", "GEN# +1.00094776"},
        {"Smithsonian Astrophysical Observation", "SAO 251178"},
        {"Wilson Evans Batten Catalogue", "WEB 9691"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.82192922),
        dec: Angle.Degrees(-60.51720824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143449"},
        {"Hipparcos Number", "HIP 78683"},
        {"Geneva Identification System", "GEN# +2.60250002"},
        {"Smithsonian Astrophysical Observation", "SAO 253407"},
        {"New General Catalogue", "NGC 6025 2"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.93554206),
        dec: Angle.Degrees(-60.51316799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98724"},
        {"Hipparcos Number", "HIP 55407"},
        {"Geneva Identification System", "GEN# +1.00098724"},
        {"Smithsonian Astrophysical Observation", "SAO 251365"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.19969134),
        dec: Angle.Degrees(-60.51171741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10180"},
        {"Hipparcos Number", "HIP 7599"},
        {"Geneva Identification System", "GEN# +1.00010180"},
        {"Smithsonian Astrophysical Observation", "SAO 248411"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.47330813),
        dec: Angle.Degrees(-60.51154249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155117"},
        {"Hipparcos Number", "HIP 84263"},
        {"Geneva Identification System", "GEN# +1.00155117"},
        {"Smithsonian Astrophysical Observation", "SAO 253830"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.37606752),
        dec: Angle.Degrees(-60.51118045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211918"},
        {"Hipparcos Number", "HIP 110442"},
        {"Geneva Identification System", "GEN# +1.00211918"},
        {"Smithsonian Astrophysical Observation", "SAO 255208"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.56591295),
        dec: Angle.Degrees(-60.50740585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202640"},
        {"Hipparcos Number", "HIP 105297"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.91790483),
        dec: Angle.Degrees(-60.50201760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215121"},
        {"Hipparcos Number", "HIP 112259"},
        {"Geneva Identification System", "GEN# +1.00215121"},
        {"Smithsonian Astrophysical Observation", "SAO 255299"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.06864746),
        dec: Angle.Degrees(-60.49966689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79173"},
        {"Hipparcos Number", "HIP 44981"},
        {"Smithsonian Astrophysical Observation", "SAO 250462"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.43894066),
        dec: Angle.Degrees(-60.49901224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143448"},
        {"Hipparcos Number", "HIP 78682"},
        {"Fundamental Katalog 5th Edition", "FK5 3265"},
        {"Geneva Identification System", "GEN# +2.60250001"},
        {"Smithsonian Astrophysical Observation", "SAO 253406"},
        {"Wilson Evans Batten Catalogue", "WEB 13299"},
        {"New General Catalogue", "NGC 6025 1"},
    },
    visualMagnitude: 7.12,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.93529659),
        dec: Angle.Degrees(-60.49845717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130612"},
        {"Hipparcos Number", "HIP 72690"},
        {"Geneva Identification System", "GEN# +1.00130612"},
        {"Smithsonian Astrophysical Observation", "SAO 252922"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.93447208),
        dec: Angle.Degrees(-60.49840555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135591"},
        {"Hipparcos Number", "HIP 74941"},
        {"Geneva Identification System", "GEN# +1.00135591"},
        {"Smithsonian Astrophysical Observation", "SAO 253101"},
        {"Wilson Evans Batten Catalogue", "WEB 12783"},
    },
    visualMagnitude: 5.43,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.70477850),
        dec: Angle.Degrees(-60.49632329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99736"},
        {"Hipparcos Number", "HIP 55928"},
        {"Smithsonian Astrophysical Observation", "SAO 251412"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.92952101),
        dec: Angle.Degrees(-60.49584058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20977"},
        {"Hipparcos Number", "HIP 15528"},
        {"Geneva Identification System", "GEN# +1.00020977"},
        {"Smithsonian Astrophysical Observation", "SAO 248780"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.01576773),
        dec: Angle.Degrees(-60.49498562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68249"},
        {"Hipparcos Number", "HIP 39831"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.06719119),
        dec: Angle.Degrees(-60.49438735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41327"},
        {"Hipparcos Number", "HIP 28452"},
        {"Geneva Identification System", "GEN# +1.00041327"},
        {"Smithsonian Astrophysical Observation", "SAO 249414"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.11310541),
        dec: Angle.Degrees(-60.49413056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105541"},
        {"Hipparcos Number", "HIP 59251"},
        {"Geneva Identification System", "GEN# +1.00105541"},
        {"Smithsonian Astrophysical Observation", "SAO 251760"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.30888225),
        dec: Angle.Degrees(-60.49404093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177481"},
        {"Hipparcos Number", "HIP 94035"},
        {"Smithsonian Astrophysical Observation", "SAO 254473"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.17299269),
        dec: Angle.Degrees(-60.49141492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137641"},
        {"Hipparcos Number", "HIP 75902"},
        {"Smithsonian Astrophysical Observation", "SAO 253188"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.54833680),
        dec: Angle.Degrees(-60.49086049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20442"},
        {"Hipparcos Number", "HIP 15075"},
        {"Smithsonian Astrophysical Observation", "SAO 248759"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.58750052),
        dec: Angle.Degrees(-60.48864509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143413"},
        {"Hipparcos Number", "HIP 78659"},
        {"Geneva Identification System", "GEN# +2.60250003"},
        {"Smithsonian Astrophysical Observation", "SAO 253402"},
        {"New General Catalogue", "NGC 6025 3"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.87040395),
        dec: Angle.Degrees(-60.48687468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80962"},
        {"Hipparcos Number", "HIP 45791"},
        {"Geneva Identification System", "GEN# +1.00080962"},
        {"Smithsonian Astrophysical Observation", "SAO 250538"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.04927634),
        dec: Angle.Degrees(-60.48653102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41451"},
        {"Hipparcos Number", "HIP 28521"},
        {"Geneva Identification System", "GEN# +1.00041451"},
        {"Smithsonian Astrophysical Observation", "SAO 249421"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.31101518),
        dec: Angle.Degrees(-60.48563439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91325"},
        {"Smithsonian Astrophysical Observation", "SAO 254312"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.40819107),
        dec: Angle.Degrees(-60.48354014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142139"},
        {"Hipparcos Number", "HIP 78045"},
        {"Geneva Identification System", "GEN# +1.00142139"},
        {"Smithsonian Astrophysical Observation", "SAO 253353"},
        {"Wilson Evans Batten Catalogue", "WEB 13196"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.02482214),
        dec: Angle.Degrees(-60.48230498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19861"},
        {"Hipparcos Number", "HIP 14612"},
        {"Smithsonian Astrophysical Observation", "SAO 248743"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.17565748),
        dec: Angle.Degrees(-60.47702068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101528"},
        {"Hipparcos Number", "HIP 56957"},
        {"Geneva Identification System", "GEN# +1.00101528"},
        {"Smithsonian Astrophysical Observation", "SAO 251532"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.13906919),
        dec: Angle.Degrees(-60.47676217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76918"},
        {"Hipparcos Number", "HIP 43875"},
        {"Smithsonian Astrophysical Observation", "SAO 250382"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.07156172),
        dec: Angle.Degrees(-60.47199552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120131"},
        {"Hipparcos Number", "HIP 67432"},
        {"Smithsonian Astrophysical Observation", "SAO 252463"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.30316749),
        dec: Angle.Degrees(-60.46811255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34122"},
        {"Smithsonian Astrophysical Observation", "SAO 249723"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.13063494),
        dec: Angle.Degrees(-60.46730171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133066"},
        {"Hipparcos Number", "HIP 73817"},
        {"Geneva Identification System", "GEN# +1.00133066"},
        {"Smithsonian Astrophysical Observation", "SAO 253012"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.30830839),
        dec: Angle.Degrees(-60.46707526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158729"},
        {"Hipparcos Number", "HIP 86004"},
        {"Smithsonian Astrophysical Observation", "SAO 253963"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.66489541),
        dec: Angle.Degrees(-60.46686514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79315"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.80311789),
        dec: Angle.Degrees(-60.46583601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209368"},
        {"Hipparcos Number", "HIP 108986"},
        {"Smithsonian Astrophysical Observation", "SAO 255139"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.18540088),
        dec: Angle.Degrees(-60.46472118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120001"},
        {"Hipparcos Number", "HIP 67367"},
        {"Geneva Identification System", "GEN# +1.00120001"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.11192667),
        dec: Angle.Degrees(-60.46451273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204354"},
        {"Hipparcos Number", "HIP 106178"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.59283941),
        dec: Angle.Degrees(-60.46407328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59455",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59455"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.92424864),
        dec: Angle.Degrees(-60.46117694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 140.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102028"},
        {"Hipparcos Number", "HIP 57230"},
        {"Geneva Identification System", "GEN# +1.00102028"},
        {"Smithsonian Astrophysical Observation", "SAO 251563"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.01567909),
        dec: Angle.Degrees(-60.45950148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155915"},
        {"Hipparcos Number", "HIP 84642"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.56129542),
        dec: Angle.Degrees(-60.45742407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94910"},
        {"Hipparcos Number", "HIP 53461"},
        {"Celescope Catalog", "CEL 3763"},
        {"Geneva Identification System", "GEN# +1.00094910"},
        {"Smithsonian Astrophysical Observation", "SAO 251185"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.04826639),
        dec: Angle.Degrees(-60.45356305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103901"},
        {"Hipparcos Number", "HIP 58334"},
        {"Smithsonian Astrophysical Observation", "SAO 251660"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.44272797),
        dec: Angle.Degrees(-60.45135584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185777"},
        {"Hipparcos Number", "HIP 97123"},
        {"Smithsonian Astrophysical Observation", "SAO 254638"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.07940916),
        dec: Angle.Degrees(-60.45094713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26431"},
        {"Hipparcos Number", "HIP 19231"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.83168391),
        dec: Angle.Degrees(-60.44728416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149837"},
        {"Hipparcos Number", "HIP 81657"},
        {"Geneva Identification System", "GEN# +1.00149837"},
        {"Smithsonian Astrophysical Observation", "SAO 253651"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.21006109),
        dec: Angle.Degrees(-60.44626468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219011"},
        {"Hipparcos Number", "HIP 114638"},
        {"Geneva Identification System", "GEN# +1.00219011"},
        {"Smithsonian Astrophysical Observation", "SAO 255432"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.34322143),
        dec: Angle.Degrees(-60.44560136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150426"},
        {"Hipparcos Number", "HIP 81956"},
        {"Smithsonian Astrophysical Observation", "SAO 253681"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.13739685),
        dec: Angle.Degrees(-60.44309410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5044"},
        {"Hipparcos Number", "HIP 4011"},
        {"Smithsonian Astrophysical Observation", "SAO 248266"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.86173528),
        dec: Angle.Degrees(-60.44231723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196499"},
        {"Hipparcos Number", "HIP 102045"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.20456770),
        dec: Angle.Degrees(-60.44139685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82369"},
        {"Hipparcos Number", "HIP 46499"},
        {"Smithsonian Astrophysical Observation", "SAO 250593"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.25040119),
        dec: Angle.Degrees(-60.44061294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205310"},
        {"Hipparcos Number", "HIP 106704"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.21166228),
        dec: Angle.Degrees(-60.44016659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158177"},
        {"Hipparcos Number", "HIP 85765"},
        {"Smithsonian Astrophysical Observation", "SAO 253948"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.87608955),
        dec: Angle.Degrees(-60.44005202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33984"},
        {"Hipparcos Number", "HIP 24064"},
        {"Smithsonian Astrophysical Observation", "SAO 249208"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.55659156),
        dec: Angle.Degrees(-60.43907072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117472"},
        {"Hipparcos Number", "HIP 66010"},
        {"Geneva Identification System", "GEN# +1.00117472"},
        {"Smithsonian Astrophysical Observation", "SAO 252349"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.99430381),
        dec: Angle.Degrees(-60.43892237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209234"},
        {"Hipparcos Number", "HIP 108912"},
        {"Geneva Identification System", "GEN# +1.00209234"},
        {"Smithsonian Astrophysical Observation", "SAO 255134"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.92623920),
        dec: Angle.Degrees(-60.43746373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 305696"},
        {"Hipparcos Number", "HIP 53312"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.55355302),
        dec: Angle.Degrees(-60.43562895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119243"},
        {"Hipparcos Number", "HIP 66978"},
        {"Geneva Identification System", "GEN# +1.00119243"},
        {"Smithsonian Astrophysical Observation", "SAO 252427"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.90982054),
        dec: Angle.Degrees(-60.43541199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213479"},
        {"Hipparcos Number", "HIP 111322"},
        {"Geneva Identification System", "GEN# +1.00213479"},
        {"Smithsonian Astrophysical Observation", "SAO 255248"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.29674859),
        dec: Angle.Degrees(-60.43301868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14861"},
        {"Hipparcos Number", "HIP 10986"},
        {"Smithsonian Astrophysical Observation", "SAO 248542"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.40219139),
        dec: Angle.Degrees(-60.43098298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84524"},
        {"Hipparcos Number", "HIP 47713"},
        {"Smithsonian Astrophysical Observation", "SAO 250677"},
    },
    visualMagnitude: 8.70,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.91163227),
        dec: Angle.Degrees(-60.43068383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211745"},
        {"Hipparcos Number", "HIP 110342"},
        {"Smithsonian Astrophysical Observation", "SAO 255204"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.23248680),
        dec: Angle.Degrees(-60.43053151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125670"},
        {"Hipparcos Number", "HIP 70311"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.78007336),
        dec: Angle.Degrees(-60.42997912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91644"},
        {"Geneva Identification System", "GEN# +6.20145017"},
    },
    visualMagnitude: 11.24,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.33235223),
        dec: Angle.Degrees(-60.42956157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24501"},
        {"Hipparcos Number", "HIP 17968"},
        {"Fundamental Katalog 5th Edition", "FK5 4348"},
        {"Smithsonian Astrophysical Observation", "SAO 248891"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.62454885),
        dec: Angle.Degrees(-60.42773464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102728"},
        {"Hipparcos Number", "HIP 57653"},
        {"Fundamental Katalog 5th Edition", "FK5 5042"},
        {"Smithsonian Astrophysical Observation", "SAO 251600"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.35229439),
        dec: Angle.Degrees(-60.42577829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129935"},
        {"Hipparcos Number", "HIP 72367"},
        {"Smithsonian Astrophysical Observation", "SAO 252890"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.95400489),
        dec: Angle.Degrees(-60.42391860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87283"},
        {"Hipparcos Number", "HIP 49164"},
        {"Geneva Identification System", "GEN# +2.31140048"},
        {"Smithsonian Astrophysical Observation", "SAO 250782"},
        {"New General Catalogue", "NGC 3114 48"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.50043754),
        dec: Angle.Degrees(-60.42089968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153937"},
        {"Hipparcos Number", "HIP 83686"},
        {"Fundamental Katalog 5th Edition", "FK5 5506"},
        {"Smithsonian Astrophysical Observation", "SAO 253792"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.54967676),
        dec: Angle.Degrees(-60.42077043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62949",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62949"},
        {"Geneva Identification System", "GEN# +2.47550006"},
        {"Smithsonian Astrophysical Observation", "SAO 252078"},
        {"New General Catalogue", "NGC 4755 6"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.48976787),
        dec: Angle.Degrees(-60.41613397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115335"},
        {"Hipparcos Number", "HIP 64863"},
        {"Geneva Identification System", "GEN# +1.00115335"},
        {"Smithsonian Astrophysical Observation", "SAO 252247"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.43084076),
        dec: Angle.Degrees(-60.41592745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36435"},
        {"Hipparcos Number", "HIP 25544"},
        {"Geneva Identification System", "GEN# +1.00036435"},
        {"Smithsonian Astrophysical Observation", "SAO 249280"},
        {"Wilson Evans Batten Catalogue", "WEB 4958"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.91469745),
        dec: Angle.Degrees(-60.41576917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17766"},
        {"Hipparcos Number", "HIP 13101"},
        {"Smithsonian Astrophysical Observation", "SAO 248655"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.10980433),
        dec: Angle.Degrees(-60.41472163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31732"},
        {"Hipparcos Number", "HIP 22814"},
        {"Smithsonian Astrophysical Observation", "SAO 249141"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.62723766),
        dec: Angle.Degrees(-60.41428425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156981"},
        {"Hipparcos Number", "HIP 85180"},
        {"Geneva Identification System", "GEN# +1.00156981"},
        {"Smithsonian Astrophysical Observation", "SAO 253910"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.11152911),
        dec: Angle.Degrees(-60.41351020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184464"},
        {"Hipparcos Number", "HIP 96592"},
        {"Smithsonian Astrophysical Observation", "SAO 254615"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.54612735),
        dec: Angle.Degrees(-60.41261912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186758"},
        {"Hipparcos Number", "HIP 97566"},
        {"Smithsonian Astrophysical Observation", "SAO 254663"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.45594449),
        dec: Angle.Degrees(-60.41189666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95414"},
        {"Hipparcos Number", "HIP 53743"},
        {"Celescope Catalog", "CEL 3772"},
        {"Geneva Identification System", "GEN# +2.34960001"},
        {"Smithsonian Astrophysical Observation", "SAO 251208"},
        {"New General Catalogue", "NGC 3496 1"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.94762443),
        dec: Angle.Degrees(-60.41168255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9295"},
        {"Hipparcos Number", "HIP 6991"},
        {"Smithsonian Astrophysical Observation", "SAO 248390"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.50046027),
        dec: Angle.Degrees(-60.40934927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64868"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.43677243),
        dec: Angle.Degrees(-60.40914079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111011"},
        {"Hipparcos Number", "HIP 62373"},
        {"Geneva Identification System", "GEN# +1.00111011"},
        {"Smithsonian Astrophysical Observation", "SAO 252027"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.75416131),
        dec: Angle.Degrees(-60.40731106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21885"},
        {"Smithsonian Astrophysical Observation", "SAO 249082"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.57384107),
        dec: Angle.Degrees(-60.40712927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157715"},
        {"Hipparcos Number", "HIP 85528"},
        {"Smithsonian Astrophysical Observation", "SAO 253934"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.17865783),
        dec: Angle.Degrees(-60.40601640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143340"},
        {"Hipparcos Number", "HIP 78643"},
        {"Geneva Identification System", "GEN# +2.60250007"},
        {"Smithsonian Astrophysical Observation", "SAO 253398"},
        {"New General Catalogue", "NGC 6025 7"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.80828270),
        dec: Angle.Degrees(-60.40593563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224324"},
        {"Hipparcos Number", "HIP 118069"},
        {"Geneva Identification System", "GEN# +1.00224324"},
        {"Smithsonian Astrophysical Observation", "SAO 255605"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.26326030),
        dec: Angle.Degrees(-60.40344123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200304"},
        {"Hipparcos Number", "HIP 104100"},
        {"Fundamental Katalog 5th Edition", "FK5 5855"},
        {"Smithsonian Astrophysical Observation", "SAO 254934"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.35879037),
        dec: Angle.Degrees(-60.40258301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60260",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Ginan"},
        {"Henry Draper", "HD 107446"},
        {"Hipparcos Number", "HIP 60260"},
        {"Fundamental Katalog 5th Edition", "FK5 2989"},
        {"Geneva Identification System", "GEN# +1.00107446"},
        {"Smithsonian Astrophysical Observation", "SAO 251862"},
        {"Wilson Evans Batten Catalogue", "WEB 10716"},
    },
    visualMagnitude: 3.59,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.34088036),
        dec: Angle.Degrees(-60.40136988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48446"},
        {"Hipparcos Number", "HIP 31858"},
        {"Geneva Identification System", "GEN# +1.00048446"},
        {"Smithsonian Astrophysical Observation", "SAO 249615"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.89763544),
        dec: Angle.Degrees(-60.40100486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73424"},
        {"Hipparcos Number", "HIP 42128"},
        {"Geneva Identification System", "GEN# +1.00073424"},
        {"Smithsonian Astrophysical Observation", "SAO 250274"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.81438337),
        dec: Angle.Degrees(-60.40070484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111463"},
        {"Hipparcos Number", "HIP 62646"},
        {"Geneva Identification System", "GEN# +1.00111463"},
        {"Smithsonian Astrophysical Observation", "SAO 252047"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.54925155),
        dec: Angle.Degrees(-60.40051611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115802"},
        {"Smithsonian Astrophysical Observation", "SAO 255493"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.90535815),
        dec: Angle.Degrees(-60.39790402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 214.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115399"},
        {"Hipparcos Number", "HIP 64894"},
        {"Smithsonian Astrophysical Observation", "SAO 252251"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.52291418),
        dec: Angle.Degrees(-60.39728085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134450"},
        {"Hipparcos Number", "HIP 74438"},
        {"Geneva Identification System", "GEN# +1.00134450"},
        {"Smithsonian Astrophysical Observation", "SAO 253056"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.18977493),
        dec: Angle.Degrees(-60.39350176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161918"},
        {"Hipparcos Number", "HIP 87447"},
        {"Geneva Identification System", "GEN# +1.00161918"},
        {"Smithsonian Astrophysical Observation", "SAO 254059"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.01965128),
        dec: Angle.Degrees(-60.39344475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94878"},
        {"Hipparcos Number", "HIP 53444"},
        {"Geneva Identification System", "GEN# +1.00094878"},
        {"Smithsonian Astrophysical Observation", "SAO 251181"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.99551570),
        dec: Angle.Degrees(-60.39262946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10889"},
        {"Hipparcos Number", "HIP 8185"},
        {"Geneva Identification System", "GEN# +1.00010889"},
        {"Smithsonian Astrophysical Observation", "SAO 248429"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.29674786),
        dec: Angle.Degrees(-60.38810493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67515"},
        {"Hipparcos Number", "HIP 39562"},
        {"Smithsonian Astrophysical Observation", "SAO 250102"},
    },
    visualMagnitude: 7.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.26019165),
        dec: Angle.Degrees(-60.38801102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116950"},
        {"Hipparcos Number", "HIP 65722"},
        {"Smithsonian Astrophysical Observation", "SAO 252322"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.10922186),
        dec: Angle.Degrees(-60.38625891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81037"},
        {"Hipparcos Number", "HIP 45831"},
        {"Smithsonian Astrophysical Observation", "SAO 250541"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.17139156),
        dec: Angle.Degrees(-60.38385672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55527"},
        {"Hipparcos Number", "HIP 34543"},
        {"Smithsonian Astrophysical Observation", "SAO 249754"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.35402071),
        dec: Angle.Degrees(-60.38047213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199964"},
        {"Hipparcos Number", "HIP 103911"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.81069640),
        dec: Angle.Degrees(-60.37935117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170967"},
        {"Hipparcos Number", "HIP 91170"},
        {"Smithsonian Astrophysical Observation", "SAO 254303"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.99250824),
        dec: Angle.Degrees(-60.37880858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166577"},
        {"Hipparcos Number", "HIP 89428"},
        {"Smithsonian Astrophysical Observation", "SAO 254188"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.76830166),
        dec: Angle.Degrees(-60.37698704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111973"},
        {"Hipparcos Number", "HIP 62931"},
        {"Geneva Identification System", "GEN# +2.47550002"},
        {"Smithsonian Astrophysical Observation", "SAO 252077"},
        {"Wilson Evans Batten Catalogue", "WEB 11158"},
        {"New General Catalogue", "NGC 4755 2"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.45384782),
        dec: Angle.Degrees(-60.37624027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70981"},
        {"Hipparcos Number", "HIP 40980"},
        {"Smithsonian Astrophysical Observation", "SAO 250204"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.44325934),
        dec: Angle.Degrees(-60.37612217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112842"},
        {"Hipparcos Number", "HIP 63489"},
        {"Geneva Identification System", "GEN# +1.00112842"},
        {"Smithsonian Astrophysical Observation", "SAO 252122"},
        {"Wilson Evans Batten Catalogue", "WEB 11234"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.13138627),
        dec: Angle.Degrees(-60.37536375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135692"},
        {"Hipparcos Number", "HIP 74983"},
        {"Geneva Identification System", "GEN# +1.00135692"},
        {"Smithsonian Astrophysical Observation", "SAO 253109"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.84185951),
        dec: Angle.Degrees(-60.37518069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173069"},
        {"Hipparcos Number", "HIP 92196"},
        {"Smithsonian Astrophysical Observation", "SAO 254368"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.84533463),
        dec: Angle.Degrees(-60.37505764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62937"},
        {"Geneva Identification System", "GEN# +2.47550307"},
        {"New General Catalogue", "NGC 4755 307"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)53, 52.1700),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)22, 27.500)
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
    primaryId: "HIP 68702",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Agena"},
        {"Common Name 2", "Hadar"},
        {"Henry Draper", "HD 122451"},
        {"Hipparcos Number", "HIP 68702"},
        {"Celescope Catalog", "CEL 4298"},
        {"Fundamental Katalog 5th Edition", "FK5 518"},
        {"Geneva Identification System", "GEN# +1.00122451"},
        {"Smithsonian Astrophysical Observation", "SAO 252582"},
        {"Wilson Evans Batten Catalogue", "WEB 12025"},
    },
    visualMagnitude: 0.61,
    bvColour: -0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.95601898),
        dec: Angle.Degrees(-60.37297840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165356"},
        {"Hipparcos Number", "HIP 88951"},
        {"Smithsonian Astrophysical Observation", "SAO 254153"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.35393432),
        dec: Angle.Degrees(-60.36990873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4774"},
        {"Hipparcos Number", "HIP 3804"},
        {"Fundamental Katalog 5th Edition", "FK5 4070"},
        {"Geneva Identification System", "GEN# +1.00004774"},
        {"Smithsonian Astrophysical Observation", "SAO 248257"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.21878606),
        dec: Angle.Degrees(-60.36982238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140826"},
        {"Hipparcos Number", "HIP 77463"},
        {"Geneva Identification System", "GEN# +1.00140826"},
        {"Smithsonian Astrophysical Observation", "SAO 253302"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.23583172),
        dec: Angle.Degrees(-60.36779419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91229"},
        {"Hipparcos Number", "HIP 51442"},
        {"Smithsonian Astrophysical Observation", "SAO 250988"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.59314368),
        dec: Angle.Degrees(-60.36538157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101103"},
        {"Hipparcos Number", "HIP 56701"},
        {"Smithsonian Astrophysical Observation", "SAO 251496"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.39165810),
        dec: Angle.Degrees(-60.36490769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135497"},
        {"Hipparcos Number", "HIP 74883"},
        {"Smithsonian Astrophysical Observation", "SAO 253096"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.55717754),
        dec: Angle.Degrees(-60.36463683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106847"},
        {"Hipparcos Number", "HIP 59919"},
        {"Geneva Identification System", "GEN# +1.00106847"},
        {"Smithsonian Astrophysical Observation", "SAO 251829"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.37113631),
        dec: Angle.Degrees(-60.36125114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190122"},
        {"Hipparcos Number", "HIP 99072"},
        {"Smithsonian Astrophysical Observation", "SAO 254727"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.69833086),
        dec: Angle.Degrees(-60.36080393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24650"},
        {"Hipparcos Number", "HIP 18069"},
        {"Geneva Identification System", "GEN# +1.00024650"},
        {"Smithsonian Astrophysical Observation", "SAO 248898"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.92858084),
        dec: Angle.Degrees(-60.35997283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165735"},
        {"Hipparcos Number", "HIP 89118"},
        {"Smithsonian Astrophysical Observation", "SAO 254163"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.82000002),
        dec: Angle.Degrees(-60.35989455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116938"},
        {"Hipparcos Number", "HIP 65710"},
        {"Smithsonian Astrophysical Observation", "SAO 252320"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.07954075),
        dec: Angle.Degrees(-60.35715665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111934"},
        {"Hipparcos Number", "HIP 62913"},
        {"Geneva Identification System", "GEN# +2.47550106"},
        {"Smithsonian Astrophysical Observation", "SAO 252070"},
        {"Wilson Evans Batten Catalogue", "WEB 11154"},
        {"New General Catalogue", "NGC 4755 106"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.40677076),
        dec: Angle.Degrees(-60.35705978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132946"},
        {"Hipparcos Number", "HIP 73756"},
        {"Geneva Identification System", "GEN# +1.00132946"},
        {"Smithsonian Astrophysical Observation", "SAO 253006"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.14801715),
        dec: Angle.Degrees(-60.35537333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76538"},
        {"Hipparcos Number", "HIP 43669"},
        {"Celescope Catalog", "CEL 3069"},
        {"Geneva Identification System", "GEN# +1.00076538"},
        {"Smithsonian Astrophysical Observation", "SAO 250369"},
        {"Wilson Evans Batten Catalogue", "WEB 8408"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.45278722),
        dec: Angle.Degrees(-60.35393124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201697"},
        {"Hipparcos Number", "HIP 104798"},
        {"Smithsonian Astrophysical Observation", "SAO 254958"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.46154544),
        dec: Angle.Degrees(-60.35072544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87222"},
        {"Hipparcos Number", "HIP 49123"},
        {"Geneva Identification System", "GEN# +2.31140023"},
        {"Renson", "Renson 24940"},
        {"Smithsonian Astrophysical Observation", "SAO 250780"},
        {"New General Catalogue", "NGC 3114 23"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.38783046),
        dec: Angle.Degrees(-60.34947531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62918"},
        {"Geneva Identification System", "GEN# +2.47550004"},
        {"Smithsonian Astrophysical Observation", "SAO 252073"},
        {"New General Catalogue", "NGC 4755 4"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.42224084),
        dec: Angle.Degrees(-60.34942955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224010"},
        {"Hipparcos Number", "HIP 117878"},
        {"Geneva Identification System", "GEN# +1.00224010"},
        {"Smithsonian Astrophysical Observation", "SAO 255596"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.65213484),
        dec: Angle.Degrees(-60.34929905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68057"},
        {"Hipparcos Number", "HIP 39744"},
        {"Geneva Identification System", "GEN# +1.00068057"},
        {"Smithsonian Astrophysical Observation", "SAO 250116"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.85176744),
        dec: Angle.Degrees(-60.34878822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120976"},
        {"Hipparcos Number", "HIP 67909"},
        {"Smithsonian Astrophysical Observation", "SAO 252512"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.63947502),
        dec: Angle.Degrees(-60.34262643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143287"},
        {"Hipparcos Number", "HIP 78604"},
        {"Geneva Identification System", "GEN# +2.60250011"},
        {"Smithsonian Astrophysical Observation", "SAO 253393"},
        {"New General Catalogue", "NGC 6025 11"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.72161304),
        dec: Angle.Degrees(-60.33618331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111990"},
        {"Hipparcos Number", "HIP 62953"},
        {"Geneva Identification System", "GEN# +2.47550003"},
        {"Smithsonian Astrophysical Observation", "SAO 252080"},
        {"Wilson Evans Batten Catalogue", "WEB 11162"},
        {"New General Catalogue", "NGC 4755 3"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.49918560),
        dec: Angle.Degrees(-60.33541696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130663"},
        {"Hipparcos Number", "HIP 72713"},
        {"Smithsonian Astrophysical Observation", "SAO 252923"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.99393263),
        dec: Angle.Degrees(-60.33470464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44872"},
        {"Smithsonian Astrophysical Observation", "SAO 250456"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.14657041),
        dec: Angle.Degrees(-60.33308162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15811"},
        {"Hipparcos Number", "HIP 11638"},
        {"Renson", "Renson 3950"},
        {"Smithsonian Astrophysical Observation", "SAO 248577"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.53396002),
        dec: Angle.Degrees(-60.33152691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85701"},
        {"Hipparcos Number", "HIP 48349"},
        {"Geneva Identification System", "GEN# +1.00085701"},
        {"Smithsonian Astrophysical Observation", "SAO 250726"},
        {"Wilson Evans Batten Catalogue", "WEB 9018"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.83270962),
        dec: Angle.Degrees(-60.33129757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28002"},
        {"Hipparcos Number", "HIP 20363"},
        {"Smithsonian Astrophysical Observation", "SAO 249006"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.41282017),
        dec: Angle.Degrees(-60.32979727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111613"},
        {"Hipparcos Number", "HIP 62732"},
        {"Geneva Identification System", "GEN# +2.47550020"},
        {"Smithsonian Astrophysical Observation", "SAO 252054"},
        {"Wilson Evans Batten Catalogue", "WEB 11123"},
        {"New General Catalogue", "NGC 4755 20"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.82492384),
        dec: Angle.Degrees(-60.32978611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111904"},
        {"Hipparcos Number", "HIP 62894"},
        {"Celescope Catalog", "CEL 4163"},
        {"Geneva Identification System", "GEN# +2.47550001"},
        {"Renson", "Renson 32480"},
        {"Smithsonian Astrophysical Observation", "SAO 252069"},
        {"Wilson Evans Batten Catalogue", "WEB 11151"},
        {"New General Catalogue", "NGC 4755 1"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.34124905),
        dec: Angle.Degrees(-60.32848627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73701"},
        {"Hipparcos Number", "HIP 42236"},
        {"Geneva Identification System", "GEN# +1.00073701"},
        {"Smithsonian Astrophysical Observation", "SAO 250282"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.16812993),
        dec: Angle.Degrees(-60.32763966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162861"},
        {"Hipparcos Number", "HIP 87872"},
        {"Smithsonian Astrophysical Observation", "SAO 254086"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.24622214),
        dec: Angle.Degrees(-60.32440820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76971"},
        {"Hipparcos Number", "HIP 43900"},
        {"Smithsonian Astrophysical Observation", "SAO 250388"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.14317295),
        dec: Angle.Degrees(-60.32345487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182530"},
        {"Hipparcos Number", "HIP 95765"},
        {"Smithsonian Astrophysical Observation", "SAO 254583"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.16222829),
        dec: Angle.Degrees(-60.32236179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100135"},
        {"Hipparcos Number", "HIP 56167"},
        {"Geneva Identification System", "GEN# +1.00100135"},
        {"Smithsonian Astrophysical Observation", "SAO 251433"},
        {"Wilson Evans Batten Catalogue", "WEB 10090"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.71455136),
        dec: Angle.Degrees(-60.31806863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97534"},
        {"Hipparcos Number", "HIP 54751"},
        {"Geneva Identification System", "GEN# +1.00097534"},
        {"Smithsonian Astrophysical Observation", "SAO 251316"},
        {"Wilson Evans Batten Catalogue", "WEB 9883"},
    },
    visualMagnitude: 4.59,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.15008453),
        dec: Angle.Degrees(-60.31763070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74148"},
        {"Hipparcos Number", "HIP 42440"},
        {"Geneva Identification System", "GEN# +1.00074148"},
        {"Smithsonian Astrophysical Observation", "SAO 250291"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.80518300),
        dec: Angle.Degrees(-60.31733717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39446"},
        {"Hipparcos Number", "HIP 27448"},
        {"Smithsonian Astrophysical Observation", "SAO 249360"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.17762897),
        dec: Angle.Degrees(-60.31696115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84384"},
        {"Hipparcos Number", "HIP 47638"},
        {"Smithsonian Astrophysical Observation", "SAO 250675"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.69370537),
        dec: Angle.Degrees(-60.31576429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70333"},
        {"Hipparcos Number", "HIP 40666"},
        {"Smithsonian Astrophysical Observation", "SAO 250181"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.52097036),
        dec: Angle.Degrees(-60.31392584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11944"},
        {"Hipparcos Number", "HIP 8957"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.83206122),
        dec: Angle.Degrees(-60.31238593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15233"},
        {"Hipparcos Number", "HIP 11258"},
        {"Fundamental Katalog 5th Edition", "FK5 84"},
        {"Geneva Identification System", "GEN# +1.00015233"},
        {"Renson", "Renson 3790"},
        {"Smithsonian Astrophysical Observation", "SAO 248555"},
        {"Wilson Evans Batten Catalogue", "WEB 2357"},
    },
    visualMagnitude: 5.36,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.22497693),
        dec: Angle.Degrees(-60.31162902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70385"},
        {"Hipparcos Number", "HIP 40690"},
        {"Geneva Identification System", "GEN# +1.00070385"},
        {"Smithsonian Astrophysical Observation", "SAO 250184"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.59583358),
        dec: Angle.Degrees(-60.31121018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97398"},
        {"Hipparcos Number", "HIP 54684"},
        {"Celescope Catalog", "CEL 3837"},
        {"Geneva Identification System", "GEN# +1.00097398"},
        {"Smithsonian Astrophysical Observation", "SAO 251308"},
    },
    visualMagnitude: 6.68,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.91835714),
        dec: Angle.Degrees(-60.31079901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114082"},
        {"Hipparcos Number", "HIP 64184"},
        {"Geneva Identification System", "GEN# +1.00114082"},
        {"Smithsonian Astrophysical Observation", "SAO 252171"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.31766344),
        dec: Angle.Degrees(-60.30830037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91633"},
        {"Smithsonian Astrophysical Observation", "SAO 254334"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.31522187),
        dec: Angle.Degrees(-60.30810785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65907"},
        {"Henry Draper 2", "HD 65907A"},
        {"Hipparcos Number", "HIP 38908"},
        {"Cincinnati Publication", "Ci 20 453"},
        {"Geneva Identification System", "GEN# +2.25160124"},
        {"Smithsonian Astrophysical Observation", "SAO 250035"},
        {"Wilson Evans Batten Catalogue", "WEB 7623"},
    },
    visualMagnitude: 5.59,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.44293578),
        dec: Angle.Degrees(-60.30336068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 518.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37576",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37576"},
        {"Smithsonian Astrophysical Observation", "SAO 249930"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.66929477),
        dec: Angle.Degrees(-60.30328755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81502"},
        {"Hipparcos Number", "HIP 46049"},
        {"Geneva Identification System", "GEN# +1.00081502"},
        {"Smithsonian Astrophysical Observation", "SAO 250561"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.86388943),
        dec: Angle.Degrees(-60.30232993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164629"},
        {"Hipparcos Number", "HIP 88646"},
        {"Smithsonian Astrophysical Observation", "SAO 254135"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.47914119),
        dec: Angle.Degrees(-60.30201259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222227"},
        {"Hipparcos Number", "HIP 116710"},
        {"Smithsonian Astrophysical Observation", "SAO 255537"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.78682700),
        dec: Angle.Degrees(-60.29963316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116071"},
        {"Hipparcos Number", "HIP 65258"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.61563065),
        dec: Angle.Degrees(-60.29272322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39743"},
        {"Smithsonian Astrophysical Observation", "SAO 250115"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.85203810),
        dec: Angle.Degrees(-60.29117407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139915"},
        {"Hipparcos Number", "HIP 77042"},
        {"Geneva Identification System", "GEN# +1.00139915"},
        {"Smithsonian Astrophysical Observation", "SAO 253269"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.98033174),
        dec: Angle.Degrees(-60.28720496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130437"},
        {"Hipparcos Number", "HIP 72616"},
        {"Geneva Identification System", "GEN# +1.00130437"},
        {"Wilson Evans Batten Catalogue", "WEB 12483"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.70940853),
        dec: Angle.Degrees(-60.28620289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1913"},
        {"Hipparcos Number", "HIP 1817"},
        {"Renson", "Renson 430"},
        {"Smithsonian Astrophysical Observation", "SAO 248176"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.75451027),
        dec: Angle.Degrees(-60.28404410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64185"},
        {"Henry Draper 2", "HD 64185A"},
        {"Henry Draper 3", "HD 64185B"},
        {"Hipparcos Number", "HIP 38160"},
        {"Fundamental Katalog 5th Edition", "FK5 1206"},
        {"Geneva Identification System", "GEN# +1.00064185"},
        {"Smithsonian Astrophysical Observation", "SAO 249975"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.30394188),
        dec: Angle.Degrees(-60.28402896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 140.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 304636"},
        {"Hipparcos Number", "HIP 45908"},
        {"Cincinnati Publication", "Ci 20 522"},
        {"Geneva Identification System", "GEN# +1.00304636"},
        {"Geneva Identification System 2", "GEN# -0.05902351"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.41079374),
        dec: Angle.Degrees(-60.28239508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -838.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 181.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197416"},
        {"Hipparcos Number", "HIP 102525"},
        {"Geneva Identification System", "GEN# +1.00197416"},
        {"Smithsonian Astrophysical Observation", "SAO 254868"},
        {"Wilson Evans Batten Catalogue", "WEB 18572"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.65290784),
        dec: Angle.Degrees(-60.28152076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45557"},
        {"Hipparcos Number", "HIP 30463"},
        {"Geneva Identification System", "GEN# +1.00045557"},
        {"Smithsonian Astrophysical Observation", "SAO 249535"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.05783068),
        dec: Angle.Degrees(-60.28139797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2440"},
        {"Hipparcos Number", "HIP 2188"},
        {"Smithsonian Astrophysical Observation", "SAO 248191"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.91335415),
        dec: Angle.Degrees(-60.28036307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100428"},
        {"Hipparcos Number", "HIP 56333"},
        {"Geneva Identification System", "GEN# +1.00100428"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.22968550),
        dec: Angle.Degrees(-60.28004302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46099"},
        {"Hipparcos Number", "HIP 30736"},
        {"Geneva Identification System", "GEN# +1.00046099"},
        {"Smithsonian Astrophysical Observation", "SAO 249553"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.86697132),
        dec: Angle.Degrees(-60.27726608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140380"},
        {"Hipparcos Number", "HIP 77258"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.61104277),
        dec: Angle.Degrees(-60.27685168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148777"},
        {"Hipparcos Number", "HIP 81107"},
        {"Fundamental Katalog 5th Edition", "FK5 5465"},
        {"Smithsonian Astrophysical Observation", "SAO 253603"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.48216510),
        dec: Angle.Degrees(-60.27527413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155742"},
        {"Hipparcos Number", "HIP 84567"},
        {"Smithsonian Astrophysical Observation", "SAO 253858"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.31589326),
        dec: Angle.Degrees(-60.27325113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178085"},
        {"Hipparcos Number", "HIP 94235"},
        {"Geneva Identification System", "GEN# +1.00178085"},
        {"Smithsonian Astrophysical Observation", "SAO 254486"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.74098787),
        dec: Angle.Degrees(-60.27195805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118771"},
        {"Hipparcos Number", "HIP 66711"},
        {"Smithsonian Astrophysical Observation", "SAO 252405"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.11485722),
        dec: Angle.Degrees(-60.27048787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183237"},
        {"Hipparcos Number", "HIP 96090"},
        {"Smithsonian Astrophysical Observation", "SAO 254592"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.04950955),
        dec: Angle.Degrees(-60.26963654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181297"},
        {"Hipparcos Number", "HIP 95328"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.91303363),
        dec: Angle.Degrees(-60.26888712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6014"},
        {"Hipparcos Number", "HIP 4701"},
        {"Smithsonian Astrophysical Observation", "SAO 248299"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.11576484),
        dec: Angle.Degrees(-60.26709348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114756"},
        {"Geneva Identification System", "GEN# +6.20145129"},
    },
    visualMagnitude: 11.50,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.68095761),
        dec: Angle.Degrees(-60.26611706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118734"},
        {"Hipparcos Number", "HIP 66693"},
        {"Geneva Identification System", "GEN# +1.00118734"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.07018677),
        dec: Angle.Degrees(-60.26598810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 458"},
        {"Hipparcos Number", "HIP 713"},
        {"Smithsonian Astrophysical Observation", "SAO 248126"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.20792389),
        dec: Angle.Degrees(-60.26452754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173396"},
        {"Hipparcos Number", "HIP 92315"},
        {"Smithsonian Astrophysical Observation", "SAO 254376"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.22504389),
        dec: Angle.Degrees(-60.26438584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162463"},
        {"Hipparcos Number", "HIP 87709"},
        {"Smithsonian Astrophysical Observation", "SAO 254074"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.73939585),
        dec: Angle.Degrees(-60.26323314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4088"},
        {"Hipparcos Number", "HIP 3352"},
        {"Geneva Identification System", "GEN# +1.00004088"},
        {"Smithsonian Astrophysical Observation", "SAO 248238"},
        {"Wilson Evans Batten Catalogue", "WEB 595"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.67349903),
        dec: Angle.Degrees(-60.26268184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 263.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49690"},
        {"Hipparcos Number", "HIP 32401"},
        {"Smithsonian Astrophysical Observation", "SAO 249641"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.46802161),
        dec: Angle.Degrees(-60.26210810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78690"},
        {"Hipparcos Number", "HIP 44729"},
        {"Celescope Catalog", "CEL 3192"},
        {"Smithsonian Astrophysical Observation", "SAO 250443"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.71369823),
        dec: Angle.Degrees(-60.26149993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211416"},
        {"Hipparcos Number", "HIP 110130"},
        {"Fundamental Katalog 5th Edition", "FK5 841"},
        {"Geneva Identification System", "GEN# +1.00211416J"},
        {"Smithsonian Astrophysical Observation", "SAO 255193"},
        {"Wilson Evans Batten Catalogue", "WEB 19767"},
    },
    visualMagnitude: 2.87,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.62574257),
        dec: Angle.Degrees(-60.25949486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31028"},
        {"Hipparcos Number", "HIP 22358"},
        {"Smithsonian Astrophysical Observation", "SAO 249114"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.19594306),
        dec: Angle.Degrees(-60.25893744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43434"},
        {"Hipparcos Number", "HIP 29447"},
        {"Smithsonian Astrophysical Observation", "SAO 249472"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.06852450),
        dec: Angle.Degrees(-60.25602502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18102"},
        {"Hipparcos Number", "HIP 13348"},
        {"Geneva Identification System", "GEN# +1.00018102"},
        {"Smithsonian Astrophysical Observation", "SAO 248665"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.94185498),
        dec: Angle.Degrees(-60.25523825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93263"},
        {"Smithsonian Astrophysical Observation", "SAO 254430"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.97010193),
        dec: Angle.Degrees(-60.25381332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58311"},
        {"Hipparcos Number", "HIP 35650"},
        {"Smithsonian Astrophysical Observation", "SAO 249830"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.34421376),
        dec: Angle.Degrees(-60.25321389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50571"},
        {"Hipparcos Number", "HIP 32775"},
        {"Geneva Identification System", "GEN# +1.00050571"},
        {"Smithsonian Astrophysical Observation", "SAO 249654"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.50420544),
        dec: Angle.Degrees(-60.24940871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98409"},
        {"Hipparcos Number", "HIP 55222"},
        {"Smithsonian Astrophysical Observation", "SAO 238953"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.63058733),
        dec: Angle.Degrees(-60.24400187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99735"},
        {"Hipparcos Number", "HIP 55931"},
        {"Smithsonian Astrophysical Observation", "SAO 239090"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.94406074),
        dec: Angle.Degrees(-60.24391774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84301"},
    },
    visualMagnitude: 10.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.52968731),
        dec: Angle.Degrees(-60.24383539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61122"},
        {"Hipparcos Number", "HIP 36801"},
        {"Smithsonian Astrophysical Observation", "SAO 249880"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.52988198),
        dec: Angle.Degrees(-60.24353638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65599"},
        {"Hipparcos Number", "HIP 38759"},
        {"Geneva Identification System", "GEN# +2.25160118"},
        {"Smithsonian Astrophysical Observation", "SAO 250017"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.02013393),
        dec: Angle.Degrees(-60.24272466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7470"},
        {"Hipparcos Number", "HIP 5712"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.36795866),
        dec: Angle.Degrees(-60.24202676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157479"},
        {"Hipparcos Number", "HIP 85415"},
        {"Smithsonian Astrophysical Observation", "SAO 253925"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.81697007),
        dec: Angle.Degrees(-60.23869676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140044"},
        {"Hipparcos Number", "HIP 77113"},
        {"Fundamental Katalog 5th Edition", "FK5 5395"},
        {"Geneva Identification System", "GEN# +1.00140044"},
        {"Smithsonian Astrophysical Observation", "SAO 253273"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.18729838),
        dec: Angle.Degrees(-60.23842484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121012"},
        {"Hipparcos Number", "HIP 67926"},
        {"Smithsonian Astrophysical Observation", "SAO 241273"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.67001947),
        dec: Angle.Degrees(-60.23835912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162422"},
        {"Hipparcos Number", "HIP 87696"},
        {"Smithsonian Astrophysical Observation", "SAO 254072"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.68456260),
        dec: Angle.Degrees(-60.23823576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135017"},
        {"Hipparcos Number", "HIP 74681"},
        {"Smithsonian Astrophysical Observation", "SAO 253076"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.93906801),
        dec: Angle.Degrees(-60.23166968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101711"},
        {"Hipparcos Number", "HIP 57064"},
        {"Geneva Identification System", "GEN# +1.00101711"},
        {"Smithsonian Astrophysical Observation", "SAO 239302"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.47385116),
        dec: Angle.Degrees(-60.23081229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208119"},
        {"Hipparcos Number", "HIP 108276"},
        {"Geneva Identification System", "GEN# +1.00208119"},
        {"Smithsonian Astrophysical Observation", "SAO 255104"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.04070409),
        dec: Angle.Degrees(-60.22944469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89875"},
        {"Hipparcos Number", "HIP 50630"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.12400204),
        dec: Angle.Degrees(-60.22757650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116186"},
        {"Hipparcos Number", "HIP 65321"},
        {"Fundamental Katalog 5th Edition", "FK5 5182"},
        {"Geneva Identification System", "GEN# +1.00116186"},
        {"Smithsonian Astrophysical Observation", "SAO 240791"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.81747006),
        dec: Angle.Degrees(-60.22719186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12058"},
        {"Hipparcos Number", "HIP 9044"},
        {"Geneva Identification System", "GEN# +1.00012058"},
        {"Smithsonian Astrophysical Observation", "SAO 248469"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.13320582),
        dec: Angle.Degrees(-60.22710031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 446.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 190.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87109"},
        {"Hipparcos Number", "HIP 49069"},
        {"Geneva Identification System", "GEN# +2.31140006"},
        {"Smithsonian Astrophysical Observation", "SAO 237596"},
        {"New General Catalogue", "NGC 3114 6"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.22642283),
        dec: Angle.Degrees(-60.22621767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41540"},
        {"Hipparcos Number", "HIP 28577"},
        {"Geneva Identification System", "GEN# +1.00041540"},
        {"Smithsonian Astrophysical Observation", "SAO 249423"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.46734700),
        dec: Angle.Degrees(-60.22583584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102349"},
        {"Hipparcos Number", "HIP 57440"},
        {"Smithsonian Astrophysical Observation", "SAO 239368"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.62932298),
        dec: Angle.Degrees(-60.22341421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174099"},
        {"Hipparcos Number", "HIP 92645"},
        {"Smithsonian Astrophysical Observation", "SAO 254399"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.16202462),
        dec: Angle.Degrees(-60.22330711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114588"},
        {"Hipparcos Number", "HIP 64446"},
        {"Smithsonian Astrophysical Observation", "SAO 240647"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.14018060),
        dec: Angle.Degrees(-60.22296853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41785"},
    },
    visualMagnitude: 10.99,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.80117709),
        dec: Angle.Degrees(-60.22207187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123638"},
        {"Hipparcos Number", "HIP 69276"},
        {"Geneva Identification System", "GEN# +1.00123638"},
        {"Smithsonian Astrophysical Observation", "SAO 241503"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.72362891),
        dec: Angle.Degrees(-60.22204152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16904"},
        {"Hipparcos Number", "HIP 12437"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.01500417),
        dec: Angle.Degrees(-60.22150540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149646"},
        {"Hipparcos Number", "HIP 81570"},
        {"Smithsonian Astrophysical Observation", "SAO 253641"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.89296574),
        dec: Angle.Degrees(-60.22102024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68540"},
        {"Hipparcos Number", "HIP 39952"},
        {"Smithsonian Astrophysical Observation", "SAO 250134"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.38205246),
        dec: Angle.Degrees(-60.22065653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88421"},
        {"Hipparcos Number", "HIP 49801"},
        {"Smithsonian Astrophysical Observation", "SAO 237752"},
    },
    visualMagnitude: 8.81,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.48454726),
        dec: Angle.Degrees(-60.21949679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45270"},
        {"Hipparcos Number", "HIP 30314"},
        {"Fundamental Katalog 5th Edition", "FK5 2489"},
        {"Geneva Identification System", "GEN# +1.00045270"},
        {"Smithsonian Astrophysical Observation", "SAO 249526"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.62897591),
        dec: Angle.Degrees(-60.21880842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125767"},
        {"Hipparcos Number", "HIP 70358"},
        {"Smithsonian Astrophysical Observation", "SAO 241687"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.93007097),
        dec: Angle.Degrees(-60.21278205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198677"},
        {"Hipparcos Number", "HIP 103229"},
        {"Smithsonian Astrophysical Observation", "SAO 254898"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.70318631),
        dec: Angle.Degrees(-60.21001441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158482"},
        {"Hipparcos Number", "HIP 85910"},
        {"Smithsonian Astrophysical Observation", "SAO 253959"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.33786146),
        dec: Angle.Degrees(-60.20859291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27212"},
        {"Hipparcos Number", "HIP 19771"},
        {"Geneva Identification System", "GEN# +1.00027212"},
        {"Smithsonian Astrophysical Observation", "SAO 248968"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.58541588),
        dec: Angle.Degrees(-60.20855194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66341"},
        {"Hipparcos Number", "HIP 39073"},
        {"Geneva Identification System", "GEN# +2.25160136"},
        {"Renson", "Renson 18310"},
        {"Smithsonian Astrophysical Observation", "SAO 250064"},
        {"Wilson Evans Batten Catalogue", "WEB 7665"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.91705080),
        dec: Angle.Degrees(-60.20737695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204353"},
        {"Henry Draper 2", "HD 204353A"},
        {"Hipparcos Number", "HIP 106183"},
        {"Geneva Identification System", "GEN# +1.00204353"},
        {"Smithsonian Astrophysical Observation", "SAO 255009"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.60398074),
        dec: Angle.Degrees(-60.20685644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175652"},
        {"Henry Draper 2", "HD 175653"},
        {"Hipparcos Number", "HIP 93295"},
        {"Geneva Identification System", "GEN# +1.00175652"},
        {"Smithsonian Astrophysical Observation", "SAO 254433"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.04892601),
        dec: Angle.Degrees(-60.20368282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107082"},
        {"Hipparcos Number", "HIP 60058"},
        {"Smithsonian Astrophysical Observation", "SAO 239836"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.74771460),
        dec: Angle.Degrees(-60.20272521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93028"},
        {"Hipparcos Number", "HIP 52444"},
        {"Celescope Catalog", "CEL 3667"},
        {"Geneva Identification System", "GEN# +5.12280027"},
        {"Smithsonian Astrophysical Observation", "SAO 238385"},
        {"Wilson Evans Batten Catalogue", "WEB 9552"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.81394586),
        dec: Angle.Degrees(-60.20117963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175329"},
        {"Hipparcos Number", "HIP 93163"},
        {"Fundamental Katalog 5th Edition", "FK5 3511"},
        {"Geneva Identification System", "GEN# +1.00175329"},
        {"Smithsonian Astrophysical Observation", "SAO 254423"},
        {"Wilson Evans Batten Catalogue", "WEB 16140"},
    },
    visualMagnitude: 5.14,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.65247792),
        dec: Angle.Degrees(-60.20062859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142415"},
        {"Hipparcos Number", "HIP 78169"},
        {"Geneva Identification System", "GEN# +1.00142415"},
        {"Smithsonian Astrophysical Observation", "SAO 253358"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.42051884),
        dec: Angle.Degrees(-60.20000850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87526"},
        {"Hipparcos Number", "HIP 49290"},
        {"Geneva Identification System", "GEN# +2.31140170"},
        {"Smithsonian Astrophysical Observation", "SAO 237655"},
        {"New General Catalogue", "NGC 3114 170"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.91243285),
        dec: Angle.Degrees(-60.19983338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85254"},
        {"Hipparcos Number", "HIP 48097"},
        {"Smithsonian Astrophysical Observation", "SAO 237366"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.09854811),
        dec: Angle.Degrees(-60.19679995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9385"},
        {"Smithsonian Astrophysical Observation", "SAO 248477"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.14611926),
        dec: Angle.Degrees(-60.19654524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19437"},
        {"Hipparcos Number", "HIP 14321"},
        {"Smithsonian Astrophysical Observation", "SAO 248725"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.17931235),
        dec: Angle.Degrees(-60.19651838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70468"},
        {"Hipparcos Number", "HIP 40741"},
        {"Smithsonian Astrophysical Observation", "SAO 250188"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.74206389),
        dec: Angle.Degrees(-60.19454992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64441",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64441"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.12113717),
        dec: Angle.Degrees(-60.19379126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12044"},
        {"Hipparcos Number", "HIP 9036"},
        {"Smithsonian Astrophysical Observation", "SAO 248467"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.09563847),
        dec: Angle.Degrees(-60.19244320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116003"},
        {"Hipparcos Number", "HIP 65236"},
        {"Celescope Catalog", "CEL 4242"},
        {"Geneva Identification System", "GEN# +1.00116003"},
        {"Smithsonian Astrophysical Observation", "SAO 240776"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.53092223),
        dec: Angle.Degrees(-60.18498381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79779"},
        {"Hipparcos Number", "HIP 45256"},
        {"Smithsonian Astrophysical Observation", "SAO 236734"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.35253802),
        dec: Angle.Degrees(-60.18345860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48246"},
        {"Hipparcos Number", "HIP 31768"},
        {"Smithsonian Astrophysical Observation", "SAO 249607"},
    },
    visualMagnitude: 7.06,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.66029171),
        dec: Angle.Degrees(-60.18305239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72389"},
        {"Hipparcos Number", "HIP 41643"},
        {"Geneva Identification System", "GEN# +1.00072389"},
        {"Smithsonian Astrophysical Observation", "SAO 250244"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.37253774),
        dec: Angle.Degrees(-60.17929828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87436"},
        {"Hipparcos Number", "HIP 49233"},
        {"Celescope Catalog", "CEL 3431"},
        {"Geneva Identification System", "GEN# +2.31140125"},
        {"Renson", "Renson 25060"},
        {"Smithsonian Astrophysical Observation", "SAO 237640"},
        {"New General Catalogue", "NGC 3114 125"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.74979136),
        dec: Angle.Degrees(-60.17868581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104616"},
        {"Hipparcos Number", "HIP 58736"},
        {"Geneva Identification System", "GEN# +1.00104616"},
        {"Smithsonian Astrophysical Observation", "SAO 239611"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.70426356),
        dec: Angle.Degrees(-60.17761017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142049"},
        {"Hipparcos Number", "HIP 77990"},
        {"Geneva Identification System", "GEN# +1.00142049J"},
        {"Renson", "Renson 40310"},
        {"Smithsonian Astrophysical Observation", "SAO 253349"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.88508797),
        dec: Angle.Degrees(-60.17747419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102968"},
        {"Hipparcos Number", "HIP 57796"},
        {"Geneva Identification System", "GEN# +1.00102968"},
        {"Smithsonian Astrophysical Observation", "SAO 239427"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.76946836),
        dec: Angle.Degrees(-60.17658966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50808",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50808"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.60081560),
        dec: Angle.Degrees(-60.17612897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 344.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -412.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19819"},
        {"Hipparcos Number", "HIP 14587"},
        {"Geneva Identification System", "GEN# +1.00019819"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.09244910),
        dec: Angle.Degrees(-60.17287053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209202"},
        {"Hipparcos Number", "HIP 108896"},
        {"Renson", "Renson 58200"},
        {"Smithsonian Astrophysical Observation", "SAO 255132"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.87701704),
        dec: Angle.Degrees(-60.16743223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161814"},
        {"Hipparcos Number", "HIP 87393"},
        {"Geneva Identification System", "GEN# +1.00161814"},
        {"Smithsonian Astrophysical Observation", "SAO 254057"},
    },
    visualMagnitude: 5.78,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.89779898),
        dec: Angle.Degrees(-60.16401809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44377",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44377"},
        {"Smithsonian Astrophysical Observation", "SAO 236532"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.58303518),
        dec: Angle.Degrees(-60.16365694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187215"},
        {"Hipparcos Number", "HIP 97784"},
        {"Smithsonian Astrophysical Observation", "SAO 254673"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.05563073),
        dec: Angle.Degrees(-60.16177026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14079"},
        {"Hipparcos Number", "HIP 10439"},
        {"Smithsonian Astrophysical Observation", "SAO 248516"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.62940462),
        dec: Angle.Degrees(-60.16152265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98733"},
        {"Hipparcos Number", "HIP 55420"},
        {"Celescope Catalog", "CEL 3884"},
        {"Geneva Identification System", "GEN# +1.00098733"},
        {"Smithsonian Astrophysical Observation", "SAO 238987"},
        {"Wilson Evans Batten Catalogue", "WEB 9973"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.23863955),
        dec: Angle.Degrees(-60.16150398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152321"},
        {"Hipparcos Number", "HIP 82882"},
        {"Smithsonian Astrophysical Observation", "SAO 253744"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.07222399),
        dec: Angle.Degrees(-60.16037830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117947"},
        {"Hipparcos Number", "HIP 66296"},
        {"Geneva Identification System", "GEN# +1.00117947"},
        {"Smithsonian Astrophysical Observation", "SAO 240970"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.81021398),
        dec: Angle.Degrees(-60.15773065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217110"},
        {"Hipparcos Number", "HIP 113511"},
        {"Fundamental Katalog 5th Edition", "FK5 6036"},
        {"Smithsonian Astrophysical Observation", "SAO 255364"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.82163890),
        dec: Angle.Degrees(-60.15659379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83587"},
        {"Hipparcos Number", "HIP 47214"},
        {"Geneva Identification System", "GEN# +1.00083587"},
        {"Smithsonian Astrophysical Observation", "SAO 237154"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.32819090),
        dec: Angle.Degrees(-60.15211564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17600"},
        {"Hipparcos Number", "HIP 12973"},
        {"Smithsonian Astrophysical Observation", "SAO 248649"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.71673345),
        dec: Angle.Degrees(-60.14950650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160359"},
        {"Hipparcos Number", "HIP 86729"},
        {"Smithsonian Astrophysical Observation", "SAO 254009"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.83135591),
        dec: Angle.Degrees(-60.14604966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97222"},
        {"Hipparcos Number", "HIP 54606"},
        {"Geneva Identification System", "GEN# +2.35720124"},
        {"New General Catalogue", "NGC 3572 124"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.63519075),
        dec: Angle.Degrees(-60.14404136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213590"},
        {"Hipparcos Number", "HIP 111392"},
        {"Renson", "Renson 59240"},
        {"Smithsonian Astrophysical Observation", "SAO 255255"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.50661499),
        dec: Angle.Degrees(-60.14353739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166154"},
        {"Hipparcos Number", "HIP 89285"},
        {"Geneva Identification System", "GEN# +1.00166154"},
        {"Smithsonian Astrophysical Observation", "SAO 254174"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.28314124),
        dec: Angle.Degrees(-60.14311523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112365"},
        {"Hipparcos Number", "HIP 63205"},
        {"Geneva Identification System", "GEN# +1.00112365"},
        {"Smithsonian Astrophysical Observation", "SAO 240402"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.24628740),
        dec: Angle.Degrees(-60.14291976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22516"},
        {"Hipparcos Number", "HIP 16637"},
        {"Geneva Identification System", "GEN# +1.00022516"},
        {"Smithsonian Astrophysical Observation", "SAO 248839"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.51376715),
        dec: Angle.Degrees(-60.14120360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145400"},
        {"Hipparcos Number", "HIP 79569"},
        {"Smithsonian Astrophysical Observation", "SAO 253469"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.53145560),
        dec: Angle.Degrees(-60.14110388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165905"},
        {"Hipparcos Number", "HIP 89191"},
        {"Smithsonian Astrophysical Observation", "SAO 254169"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.02910414),
        dec: Angle.Degrees(-60.14049917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147157"},
        {"Hipparcos Number", "HIP 80304"},
        {"Smithsonian Astrophysical Observation", "SAO 253530"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.90856638),
        dec: Angle.Degrees(-60.13771825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163878"},
        {"Hipparcos Number", "HIP 88328"},
        {"Fundamental Katalog 5th Edition", "FK5 3431"},
        {"Smithsonian Astrophysical Observation", "SAO 254118"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.59496893),
        dec: Angle.Degrees(-60.13726882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33243"},
        {"Hipparcos Number", "HIP 23660"},
        {"Smithsonian Astrophysical Observation", "SAO 249181"},
        {"Wilson Evans Batten Catalogue", "WEB 4616"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.27547914),
        dec: Angle.Degrees(-60.13662729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135674"},
        {"Hipparcos Number", "HIP 74967"},
        {"Geneva Identification System", "GEN# +1.00135674"},
        {"Smithsonian Astrophysical Observation", "SAO 242402"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.78936874),
        dec: Angle.Degrees(-60.13368875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101946"},
        {"Hipparcos Number", "HIP 57184"},
        {"Geneva Identification System", "GEN# +1.00101946"},
        {"Smithsonian Astrophysical Observation", "SAO 239327"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.89752428),
        dec: Angle.Degrees(-60.13287310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85313"},
        {"Hipparcos Number", "HIP 48127"},
        {"Geneva Identification System", "GEN# +1.00085313"},
        {"Smithsonian Astrophysical Observation", "SAO 237374"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.18320513),
        dec: Angle.Degrees(-60.13269269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126528"},
        {"Hipparcos Number", "HIP 70758"},
        {"Geneva Identification System", "GEN# +1.00126528"},
        {"Smithsonian Astrophysical Observation", "SAO 241734"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.06107265),
        dec: Angle.Degrees(-60.12909841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91651"},
        {"Hipparcos Number", "HIP 51681"},
        {"Celescope Catalog", "CEL 3578"},
        {"Geneva Identification System", "GEN# +1.00091651"},
        {"Wilson Evans Batten Catalogue", "WEB 9426"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.37628181),
        dec: Angle.Degrees(-60.12779454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37167"},
        {"Hipparcos Number", "HIP 25982"},
        {"Smithsonian Astrophysical Observation", "SAO 249306"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.17778170),
        dec: Angle.Degrees(-60.12496350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72275"},
        {"Hipparcos Number", "HIP 41588"},
        {"Geneva Identification System", "GEN# +1.00072275"},
        {"Smithsonian Astrophysical Observation", "SAO 236021"},
        {"Wilson Evans Batten Catalogue", "WEB 8026"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.18207809),
        dec: Angle.Degrees(-60.12258086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93131"},
        {"Hipparcos Number", "HIP 52488"},
        {"Celescope Catalog", "CEL 3671"},
        {"Geneva Identification System", "GEN# +5.12280003"},
        {"Smithsonian Astrophysical Observation", "SAO 238394"},
    },
    visualMagnitude: 6.45,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.96777327),
        dec: Angle.Degrees(-60.11778800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112295"},
        {"Smithsonian Astrophysical Observation", "SAO 255304"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.18518363),
        dec: Angle.Degrees(-60.11701569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215171"},
        {"Hipparcos Number", "HIP 112291"},
        {"Geneva Identification System", "GEN# +1.00215171"},
        {"Smithsonian Astrophysical Observation", "SAO 255303"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.16779807),
        dec: Angle.Degrees(-60.11688043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53867"},
    },
    visualMagnitude: 11.63,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.30999353),
        dec: Angle.Degrees(-60.11658082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7633"},
        {"Hipparcos Number", "HIP 5844"},
        {"Smithsonian Astrophysical Observation", "SAO 248340"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.75234809),
        dec: Angle.Degrees(-60.11529279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131342"},
        {"Hipparcos Number", "HIP 73036"},
        {"Fundamental Katalog 5th Edition", "FK5 3174"},
        {"Geneva Identification System", "GEN# +1.00131342"},
        {"Smithsonian Astrophysical Observation", "SAO 242111"},
        {"Wilson Evans Batten Catalogue", "WEB 12524"},
    },
    visualMagnitude: 5.18,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.89461516),
        dec: Angle.Degrees(-60.11389133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87241"},
        {"Hipparcos Number", "HIP 49138"},
        {"Geneva Identification System", "GEN# +2.31140024"},
        {"Renson", "Renson 24960"},
        {"Smithsonian Astrophysical Observation", "SAO 237617"},
        {"New General Catalogue", "NGC 3114 24"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.42405376),
        dec: Angle.Degrees(-60.11294993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19623"},
        {"Hipparcos Number", "HIP 14461"},
        {"Smithsonian Astrophysical Observation", "SAO 248732"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.66237540),
        dec: Angle.Degrees(-60.11040437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60232"},
        {"Hipparcos Number", "HIP 36428"},
        {"Geneva Identification System", "GEN# +1.00060232"},
        {"Smithsonian Astrophysical Observation", "SAO 249865"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.45077904),
        dec: Angle.Degrees(-60.10950049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176864"},
        {"Hipparcos Number", "HIP 93786"},
        {"Smithsonian Astrophysical Observation", "SAO 254462"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.49244712),
        dec: Angle.Degrees(-60.10923716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168809"},
        {"Hipparcos Number", "HIP 90309"},
        {"Smithsonian Astrophysical Observation", "SAO 254240"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.39330811),
        dec: Angle.Degrees(-60.10665486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37402"},
        {"Hipparcos Number", "HIP 26144"},
        {"Geneva Identification System", "GEN# +1.00037402"},
        {"Smithsonian Astrophysical Observation", "SAO 249313"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.60882034),
        dec: Angle.Degrees(-60.10426687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70622"},
        {"Hipparcos Number", "HIP 40808"},
        {"Geneva Identification System", "GEN# +1.00070622"},
        {"Smithsonian Astrophysical Observation", "SAO 235894"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.93367532),
        dec: Angle.Degrees(-60.10314059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145583"},
        {"Hipparcos Number", "HIP 79641"},
        {"Smithsonian Astrophysical Observation", "SAO 243488"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.78444582),
        dec: Angle.Degrees(-60.09966161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91041"},
        {"Hipparcos Number", "HIP 51323"},
        {"Celescope Catalog", "CEL 3553"},
        {"Geneva Identification System", "GEN# +1.00091041"},
        {"Smithsonian Astrophysical Observation", "SAO 238107"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.25002454),
        dec: Angle.Degrees(-60.09949326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6334"},
        {"Hipparcos Number", "HIP 4934"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.82517242),
        dec: Angle.Degrees(-60.09725949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41586"},
        {"Hipparcos Number", "HIP 28596"},
        {"Geneva Identification System", "GEN# +1.00041586"},
        {"Smithsonian Astrophysical Observation", "SAO 249424"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.53881794),
        dec: Angle.Degrees(-60.09684953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97151"},
        {"Hipparcos Number", "HIP 54572"},
        {"Celescope Catalog", "CEL 3828"},
        {"Geneva Identification System", "GEN# +1.00097151"},
        {"Smithsonian Astrophysical Observation", "SAO 238831"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.50976085),
        dec: Angle.Degrees(-60.09513708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214164"},
        {"Hipparcos Number", "HIP 111722"},
        {"Geneva Identification System", "GEN# +1.00214164"},
        {"Smithsonian Astrophysical Observation", "SAO 255266"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.46228888),
        dec: Angle.Degrees(-60.09463658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60875",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60875"},
        {"Geneva Identification System", "GEN# +2.44390003"},
        {"New General Catalogue", "NGC 4439 3"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.14982336),
        dec: Angle.Degrees(-60.09305040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134449"},
        {"Hipparcos Number", "HIP 74429"},
        {"Geneva Identification System", "GEN# +1.00134449"},
        {"Smithsonian Astrophysical Observation", "SAO 242305"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.16886749),
        dec: Angle.Degrees(-60.09160202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40275"},
        {"Hipparcos Number", "HIP 27872"},
        {"Geneva Identification System", "GEN# +1.00040275"},
        {"Smithsonian Astrophysical Observation", "SAO 249387"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.46956621),
        dec: Angle.Degrees(-60.08783552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115844"},
        {"Hipparcos Number", "HIP 65146"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.24550886),
        dec: Angle.Degrees(-60.08738902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210785"},
        {"Hipparcos Number", "HIP 109805"},
        {"Smithsonian Astrophysical Observation", "SAO 255179"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.60567163),
        dec: Angle.Degrees(-60.08537117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107861"},
        {"Hipparcos Number", "HIP 60483"},
        {"Smithsonian Astrophysical Observation", "SAO 239917"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.99324570),
        dec: Angle.Degrees(-60.08424811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218007"},
        {"Hipparcos Number", "HIP 114039"},
        {"Smithsonian Astrophysical Observation", "SAO 255401"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.41461482),
        dec: Angle.Degrees(-60.07977305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130207"},
        {"Hipparcos Number", "HIP 72490"},
        {"Smithsonian Astrophysical Observation", "SAO 242028"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.33565057),
        dec: Angle.Degrees(-60.07967301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23127"},
        {"Hipparcos Number", "HIP 17054"},
        {"Geneva Identification System", "GEN# +1.00023127"},
        {"Smithsonian Astrophysical Observation", "SAO 248860"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.84813032),
        dec: Angle.Degrees(-60.07819077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 143.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113012"},
        {"Hipparcos Number", "HIP 63576"},
        {"Celescope Catalog", "CEL 4192"},
        {"Geneva Identification System", "GEN# +1.00113012"},
        {"Smithsonian Astrophysical Observation", "SAO 240483"},
        {"Wilson Evans Batten Catalogue", "WEB 11251"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.42308714),
        dec: Angle.Degrees(-60.07643282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160417"},
        {"Hipparcos Number", "HIP 86748"},
        {"Smithsonian Astrophysical Observation", "SAO 254010"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.89386537),
        dec: Angle.Degrees(-60.07596885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215532"},
        {"Hipparcos Number", "HIP 112489"},
        {"Geneva Identification System", "GEN# +1.00215532"},
        {"Smithsonian Astrophysical Observation", "SAO 255314"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.77762160),
        dec: Angle.Degrees(-60.07583047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110772"},
        {"Hipparcos Number", "HIP 62219"},
        {"Fundamental Katalog 5th Edition", "FK5 5129"},
        {"Geneva Identification System", "GEN# +1.00110772"},
        {"Smithsonian Astrophysical Observation", "SAO 240208"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.27504306),
        dec: Angle.Degrees(-60.07576233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60857"},
        {"Geneva Identification System", "GEN# +2.44390001"},
        {"New General Catalogue", "NGC 4439 1"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.09491830),
        dec: Angle.Degrees(-60.07489586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8214"},
        {"Hipparcos Number", "HIP 6253"},
        {"Smithsonian Astrophysical Observation", "SAO 248365"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.05234668),
        dec: Angle.Degrees(-60.07424341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223399"},
        {"Hipparcos Number", "HIP 117486"},
        {"Geneva Identification System", "GEN# +1.00223399"},
        {"Smithsonian Astrophysical Observation", "SAO 255574"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.34047995),
        dec: Angle.Degrees(-60.07306622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260"},
        {"Hipparcos Number", "HIP 594"},
        {"Smithsonian Astrophysical Observation", "SAO 248118"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.80277966),
        dec: Angle.Degrees(-60.07079486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189061"},
        {"Hipparcos Number", "HIP 98584"},
        {"Smithsonian Astrophysical Observation", "SAO 254710"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.37354051),
        dec: Angle.Degrees(-60.07059036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171002"},
        {"Hipparcos Number", "HIP 91189"},
        {"Smithsonian Astrophysical Observation", "SAO 254304"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.04285591),
        dec: Angle.Degrees(-60.06982206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106086"},
        {"Hipparcos Number", "HIP 59528"},
        {"Geneva Identification System", "GEN# +1.00106086"},
        {"Smithsonian Astrophysical Observation", "SAO 239751"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.10605400),
        dec: Angle.Degrees(-60.06781026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115211"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.03290961),
        dec: Angle.Degrees(-60.06486952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -317.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17112"},
        {"Hipparcos Number", "HIP 12612"},
        {"Smithsonian Astrophysical Observation", "SAO 248629"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.53556727),
        dec: Angle.Degrees(-60.06442444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142138"},
        {"Hipparcos Number", "HIP 78036"},
        {"Smithsonian Astrophysical Observation", "SAO 243129"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.00946964),
        dec: Angle.Degrees(-60.06132283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43258"},
        {"Hipparcos Number", "HIP 29366"},
        {"Geneva Identification System", "GEN# +1.00043258"},
        {"Smithsonian Astrophysical Observation", "SAO 249467"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.84156483),
        dec: Angle.Degrees(-60.05999794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37934"},
        {"Hipparcos Number", "HIP 26502"},
        {"Geneva Identification System", "GEN# +1.00037934"},
        {"Smithsonian Astrophysical Observation", "SAO 249325"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.54491062),
        dec: Angle.Degrees(-60.05911855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51491"},
        {"Hipparcos Number", "HIP 33117"},
        {"Geneva Identification System", "GEN# +1.00051491"},
        {"Smithsonian Astrophysical Observation", "SAO 234777"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.45854614),
        dec: Angle.Degrees(-60.05640707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17288"},
        {"Hipparcos Number", "HIP 12772"},
        {"Geneva Identification System", "GEN# +1.00017288"},
        {"Smithsonian Astrophysical Observation", "SAO 248635"},
        {"Wilson Evans Batten Catalogue", "WEB 2596"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.03989291),
        dec: Angle.Degrees(-60.05605190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 357.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207256"},
        {"Hipparcos Number", "HIP 107762"},
        {"Smithsonian Astrophysical Observation", "SAO 255082"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.46059036),
        dec: Angle.Degrees(-60.05584649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220263"},
        {"Hipparcos Number", "HIP 115433"},
        {"Geneva Identification System", "GEN# +1.00220263"},
        {"Smithsonian Astrophysical Observation", "SAO 255474"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.73616120),
        dec: Angle.Degrees(-60.05582988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212878"},
        {"Hipparcos Number", "HIP 110965"},
        {"Smithsonian Astrophysical Observation", "SAO 255229"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.23226620),
        dec: Angle.Degrees(-60.05401404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 306247"},
        {"Hipparcos Number", "HIP 54891"},
        {"Wilson Evans Batten Catalogue", "WEB 9906"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.58842114),
        dec: Angle.Degrees(-60.05292878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121192"},
        {"Hipparcos Number", "HIP 68014"},
        {"Geneva Identification System", "GEN# +1.00121192"},
        {"Smithsonian Astrophysical Observation", "SAO 241298"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.92055517),
        dec: Angle.Degrees(-60.05286723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64320"},
        {"Hipparcos Number", "HIP 38226"},
        {"Geneva Identification System", "GEN# +1.00064320"},
        {"Smithsonian Astrophysical Observation", "SAO 235553"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.47821011),
        dec: Angle.Degrees(-60.05146778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114307"},
        {"Hipparcos Number", "HIP 64314"},
        {"Geneva Identification System", "GEN# +1.00114307"},
        {"Smithsonian Astrophysical Observation", "SAO 240622"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.72564503),
        dec: Angle.Degrees(-60.05011088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201486"},
        {"Hipparcos Number", "HIP 104705"},
        {"Smithsonian Astrophysical Observation", "SAO 254955"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.14395579),
        dec: Angle.Degrees(-60.04865225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168548"},
        {"Hipparcos Number", "HIP 90162"},
        {"Smithsonian Astrophysical Observation", "SAO 254230"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.98580306),
        dec: Angle.Degrees(-60.04753329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177999"},
        {"Hipparcos Number", "HIP 94198"},
        {"Geneva Identification System", "GEN# +1.00177999J"},
        {"Smithsonian Astrophysical Observation", "SAO 254482"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.65901082),
        dec: Angle.Degrees(-60.04575471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195044"},
        {"Hipparcos Number", "HIP 101303"},
        {"Smithsonian Astrophysical Observation", "SAO 254808"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.00194731),
        dec: Angle.Degrees(-60.04375082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 306493"},
        {"Hipparcos Number", "HIP 55977"},
        {"Geneva Identification System", "GEN# +1.00306493"},
        {"Wilson Evans Batten Catalogue", "WEB 10049"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.06799074),
        dec: Angle.Degrees(-60.04108150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106110"},
        {"Hipparcos Number", "HIP 59546"},
        {"Smithsonian Astrophysical Observation", "SAO 239755"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.17962419),
        dec: Angle.Degrees(-60.04065648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69134"},
        {"Hipparcos Number", "HIP 40172"},
        {"Fundamental Katalog 5th Edition", "FK5 4739"},
        {"Smithsonian Astrophysical Observation", "SAO 235813"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.06540052),
        dec: Angle.Degrees(-60.03933358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78151"},
        {"Hipparcos Number", "HIP 44495"},
        {"Smithsonian Astrophysical Observation", "SAO 236556"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.98525550),
        dec: Angle.Degrees(-60.03870575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165904"},
        {"Hipparcos Number", "HIP 89184"},
        {"Geneva Identification System", "GEN# +1.00165904"},
        {"Smithsonian Astrophysical Observation", "SAO 254168"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.01761317),
        dec: Angle.Degrees(-60.03247828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129721"},
        {"Hipparcos Number", "HIP 72260"},
        {"Smithsonian Astrophysical Observation", "SAO 241980"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.65438131),
        dec: Angle.Degrees(-60.03016196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33780",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33780"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.21580470),
        dec: Angle.Degrees(-60.02947453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 201.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84464"},
        {"Hipparcos Number", "HIP 47676"},
        {"Celescope Catalog", "CEL 3369"},
        {"Geneva Identification System", "GEN# +1.00084464"},
        {"Smithsonian Astrophysical Observation", "SAO 237263"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.81933209),
        dec: Angle.Degrees(-60.02934504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47677"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.82512068),
        dec: Angle.Degrees(-60.02748476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40307"},
        {"Hipparcos Number", "HIP 27887"},
        {"Geneva Identification System", "GEN# +1.00040307"},
        {"Smithsonian Astrophysical Observation", "SAO 249388"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.51792247),
        dec: Angle.Degrees(-60.02332467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35167"},
        {"Hipparcos Number", "HIP 24806"},
        {"Smithsonian Astrophysical Observation", "SAO 249245"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.77055117),
        dec: Angle.Degrees(-60.02318734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194003"},
        {"Hipparcos Number", "HIP 100809"},
        {"Smithsonian Astrophysical Observation", "SAO 254792"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.60278262),
        dec: Angle.Degrees(-60.02218784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45058"},
        {"Hipparcos Number", "HIP 30215"},
        {"Geneva Identification System", "GEN# +1.00045058"},
        {"Smithsonian Astrophysical Observation", "SAO 234464"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.35432163),
        dec: Angle.Degrees(-60.02197289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188723"},
        {"Hipparcos Number", "HIP 98426"},
        {"Smithsonian Astrophysical Observation", "SAO 254703"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.98064826),
        dec: Angle.Degrees(-60.02133122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190543"},
        {"Hipparcos Number", "HIP 99251"},
        {"Smithsonian Astrophysical Observation", "SAO 254734"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.20931832),
        dec: Angle.Degrees(-60.02073777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120768"},
        {"Hipparcos Number", "HIP 67781"},
        {"Geneva Identification System", "GEN# +1.00120768"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.29230761),
        dec: Angle.Degrees(-60.02042042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120767"},
        {"Hipparcos Number", "HIP 67783"},
        {"Geneva Identification System", "GEN# +1.00120767"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.29898375),
        dec: Angle.Degrees(-60.01837056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127724"},
        {"Hipparcos Number", "HIP 71333"},
        {"Geneva Identification System", "GEN# +1.00127724"},
        {"Smithsonian Astrophysical Observation", "SAO 241811"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.82114888),
        dec: Angle.Degrees(-60.01557865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100900"},
        {"Hipparcos Number", "HIP 56595"},
        {"Geneva Identification System", "GEN# +1.00100900"},
        {"Smithsonian Astrophysical Observation", "SAO 239212"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.05005213),
        dec: Angle.Degrees(-60.01125762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82280"},
        {"Hipparcos Number", "HIP 46467"},
        {"Celescope Catalog", "CEL 3308"},
        {"Smithsonian Astrophysical Observation", "SAO 237020"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.15201234),
        dec: Angle.Degrees(-60.00963884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101992"},
        {"Hipparcos Number", "HIP 57212"},
        {"Smithsonian Astrophysical Observation", "SAO 239331"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.97723048),
        dec: Angle.Degrees(-60.00709393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85531"},
        {"Hipparcos Number", "HIP 48245"},
        {"Smithsonian Astrophysical Observation", "SAO 237395"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.53752857),
        dec: Angle.Degrees(-60.00291810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94096"},
        {"Hipparcos Number", "HIP 52991"},
        {"Smithsonian Astrophysical Observation", "SAO 238523"},
    },
    visualMagnitude: 7.75,
    bvColour: 2.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.60961283),
        dec: Angle.Degrees(-59.98238485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62597"},
        {"Hipparcos Number", "HIP 37454"},
        {"Smithsonian Astrophysical Observation", "SAO 235419"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.32352808),
        dec: Angle.Degrees(-60.00196819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103572"},
        {"Hipparcos Number", "HIP 58134"},
        {"Smithsonian Astrophysical Observation", "SAO 239489"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.85058904),
        dec: Angle.Degrees(-60.00176312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219697"},
        {"Hipparcos Number", "HIP 115085"},
        {"Smithsonian Astrophysical Observation", "SAO 255456"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.64737461),
        dec: Angle.Degrees(-59.99976602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19240"},
        {"Hipparcos Number", "HIP 14189"},
        {"Smithsonian Astrophysical Observation", "SAO 248713"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.73539913),
        dec: Angle.Degrees(-59.99966565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113199"},
        {"Hipparcos Number", "HIP 63678"},
        {"Geneva Identification System", "GEN# +1.00113199"},
        {"Smithsonian Astrophysical Observation", "SAO 240499"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.75221405),
        dec: Angle.Degrees(-59.99831191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54819"},
        {"Hipparcos Number", "HIP 34291"},
        {"Smithsonian Astrophysical Observation", "SAO 234936"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.63704738),
        dec: Angle.Degrees(-59.99680417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23447"},
        {"Hipparcos Number", "HIP 17283"},
        {"Smithsonian Astrophysical Observation", "SAO 248869"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.50774150),
        dec: Angle.Degrees(-59.99605076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161032"},
        {"Hipparcos Number", "HIP 87043"},
        {"Geneva Identification System", "GEN# +1.00161032"},
        {"Smithsonian Astrophysical Observation", "SAO 245015"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.78078090),
        dec: Angle.Degrees(-59.99424555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93206"},
        {"Hipparcos Number", "HIP 52526"},
        {"Celescope Catalog", "CEL 3682"},
        {"Smithsonian Astrophysical Observation", "SAO 238414"},
        {"Wilson Evans Batten Catalogue", "WEB 9569"},
    },
    visualMagnitude: 6.32,
    bvColour: -0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.09549553),
        dec: Angle.Degrees(-59.99332651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213517"},
        {"Hipparcos Number", "HIP 111339"},
        {"Geneva Identification System", "GEN# +1.00213517"},
        {"Smithsonian Astrophysical Observation", "SAO 255253"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.34959492),
        dec: Angle.Degrees(-59.99194728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200655"},
        {"Hipparcos Number", "HIP 104269"},
        {"Fundamental Katalog 5th Edition", "FK5 3685"},
        {"Geneva Identification System", "GEN# +1.00200655"},
        {"Smithsonian Astrophysical Observation", "SAO 254939"},
        {"Wilson Evans Batten Catalogue", "WEB 18991"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.85298028),
        dec: Angle.Degrees(-59.99191222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206164"},
        {"Hipparcos Number", "HIP 107171"},
        {"Smithsonian Astrophysical Observation", "SAO 255053"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.62266018),
        dec: Angle.Degrees(-59.99188006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104551"},
        {"Hipparcos Number", "HIP 58699"},
        {"Geneva Identification System", "GEN# +1.00104551"},
        {"Smithsonian Astrophysical Observation", "SAO 239605"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.58745875),
        dec: Angle.Degrees(-59.98792824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214277"},
        {"Hipparcos Number", "HIP 111778"},
        {"Smithsonian Astrophysical Observation", "SAO 255269"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.62271032),
        dec: Angle.Degrees(-59.98443535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34377"},
        {"Hipparcos Number", "HIP 24320"},
        {"Smithsonian Astrophysical Observation", "SAO 249219"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.28448257),
        dec: Angle.Degrees(-59.98333470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 145.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25053"},
        {"Hipparcos Number", "HIP 18360"},
        {"Geneva Identification System", "GEN# +1.00025053"},
        {"Smithsonian Astrophysical Observation", "SAO 248908"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.89054562),
        dec: Angle.Degrees(-59.98223401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87266"},
        {"Hipparcos Number", "HIP 49149"},
        {"Celescope Catalog", "CEL 3426"},
        {"Geneva Identification System", "GEN# +2.31140033"},
        {"Renson", "Renson 24980"},
        {"Smithsonian Astrophysical Observation", "SAO 237620"},
        {"New General Catalogue", "NGC 3114 33"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.46644225),
        dec: Angle.Degrees(-59.98197002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21900"},
        {"Hipparcos Number", "HIP 16204"},
        {"Smithsonian Astrophysical Observation", "SAO 248816"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.19541077),
        dec: Angle.Degrees(-59.97672212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14929"},
        {"Hipparcos Number", "HIP 11047"},
        {"Smithsonian Astrophysical Observation", "SAO 248544"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.55353913),
        dec: Angle.Degrees(-59.97650219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220193"},
        {"Hipparcos Number", "HIP 115391"},
        {"Smithsonian Astrophysical Observation", "SAO 255471"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.62021809),
        dec: Angle.Degrees(-59.97471254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181407"},
        {"Hipparcos Number", "HIP 95351"},
        {"Smithsonian Astrophysical Observation", "SAO 254557"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.98376264),
        dec: Angle.Degrees(-59.97266275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45077"},
        {"Smithsonian Astrophysical Observation", "SAO 236695"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.73461933),
        dec: Angle.Degrees(-59.96858321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133618"},
        {"Hipparcos Number", "HIP 74073"},
        {"Geneva Identification System", "GEN# +1.00133618"},
        {"Smithsonian Astrophysical Observation", "SAO 242241"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.06283885),
        dec: Angle.Degrees(-59.96852721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11483"},
        {"Hipparcos Number", "HIP 8610"},
        {"Smithsonian Astrophysical Observation", "SAO 248450"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.76457289),
        dec: Angle.Degrees(-59.96758952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79948"},
        {"Hipparcos Number", "HIP 45351"},
        {"Geneva Identification System", "GEN# +1.00079948"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.61928035),
        dec: Angle.Degrees(-59.96645882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193696"},
        {"Hipparcos Number", "HIP 100693"},
        {"Smithsonian Astrophysical Observation", "SAO 254786"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.20685754),
        dec: Angle.Degrees(-59.96469137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49966"},
        {"Hipparcos Number", "HIP 32515"},
        {"Smithsonian Astrophysical Observation", "SAO 234712"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.78595169),
        dec: Angle.Degrees(-59.96271307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53167"},
        {"Hipparcos Number", "HIP 33720"},
        {"Smithsonian Astrophysical Observation", "SAO 234853"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.07603597),
        dec: Angle.Degrees(-59.96136770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87405"},
        {"Hipparcos Number", "HIP 49218"},
        {"Geneva Identification System", "GEN# +2.31140108"},
        {"Renson", "Renson 25040"},
        {"Smithsonian Astrophysical Observation", "SAO 237631"},
        {"New General Catalogue", "NGC 3114 108"},
    },
    visualMagnitude: 8.50,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.70087682),
        dec: Angle.Degrees(-59.95839692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94173"},
        {"Hipparcos Number", "HIP 53029"},
        {"Celescope Catalog", "CEL 3736"},
        {"Geneva Identification System", "GEN# +1.00094173J"},
        {"Smithsonian Astrophysical Observation", "SAO 238529"},
    },
    visualMagnitude: 6.79,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.74432108),
        dec: Angle.Degrees(-59.95731071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104298"},
        {"Hipparcos Number", "HIP 58565"},
        {"Geneva Identification System", "GEN# +1.00104298"},
        {"Smithsonian Astrophysical Observation", "SAO 239574"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.13590720),
        dec: Angle.Degrees(-59.95643813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133633"},
        {"Hipparcos Number", "HIP 74075"},
        {"Geneva Identification System", "GEN# +1.00133633"},
        {"Smithsonian Astrophysical Observation", "SAO 242242"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.06424203),
        dec: Angle.Degrees(-59.95418144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75712"},
        {"Hipparcos Number", "HIP 43249"},
        {"Smithsonian Astrophysical Observation", "SAO 236301"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.16339501),
        dec: Angle.Degrees(-59.95276304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1399"},
    },
    visualMagnitude: 11.30,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.37630834),
        dec: Angle.Degrees(-59.95106542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148311"},
        {"Hipparcos Number", "HIP 80860"},
        {"Geneva Identification System", "GEN# +1.00148311"},
        {"Smithsonian Astrophysical Observation", "SAO 243891"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.67597445),
        dec: Angle.Degrees(-59.95070132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96446"},
        {"Hipparcos Number", "HIP 54266"},
        {"Celescope Catalog", "CEL 3805"},
        {"Geneva Identification System", "GEN# +1.00096446"},
        {"Renson", "Renson 27790"},
        {"Smithsonian Astrophysical Observation", "SAO 238766"},
        {"Wilson Evans Batten Catalogue", "WEB 9804"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.52430904),
        dec: Angle.Degrees(-59.94988767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211850"},
        {"Hipparcos Number", "HIP 110402"},
        {"Smithsonian Astrophysical Observation", "SAO 255207"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.42989335),
        dec: Angle.Degrees(-59.94807799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88733"},
        {"Hipparcos Number", "HIP 49983"},
        {"Celescope Catalog", "CEL 3463"},
        {"Smithsonian Astrophysical Observation", "SAO 237786"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.07016296),
        dec: Angle.Degrees(-59.94513147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103324",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103324"},
    },
    visualMagnitude: 11.47,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.99701101),
        dec: Angle.Degrees(-59.94488526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 512.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -314.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31702"},
        {"Hipparcos Number", "HIP 22800"},
        {"Smithsonian Astrophysical Observation", "SAO 249140"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.56738270),
        dec: Angle.Degrees(-59.94353343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24060"},
        {"Hipparcos Number", "HIP 17632"},
        {"Smithsonian Astrophysical Observation", "SAO 248885"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.67226044),
        dec: Angle.Degrees(-59.94064288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191171"},
        {"Henry Draper 2", "HD 191155"},
        {"Hipparcos Number", "HIP 99512"},
        {"Smithsonian Astrophysical Observation", "SAO 254747"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.94095668),
        dec: Angle.Degrees(-59.93686945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77569"},
        {"Hipparcos Number", "HIP 44240"},
        {"Geneva Identification System", "GEN# +1.00077569"},
        {"Smithsonian Astrophysical Observation", "SAO 236504"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.14243331),
        dec: Angle.Degrees(-59.93418168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223101"},
        {"Hipparcos Number", "HIP 117275"},
        {"Smithsonian Astrophysical Observation", "SAO 255565"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.71325995),
        dec: Angle.Degrees(-59.93290923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18170"},
        {"Hipparcos Number", "HIP 13399"},
        {"Smithsonian Astrophysical Observation", "SAO 248672"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.11003225),
        dec: Angle.Degrees(-59.93162426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128588"},
        {"Hipparcos Number", "HIP 71709"},
        {"Geneva Identification System", "GEN# +1.00128588"},
        {"Smithsonian Astrophysical Observation", "SAO 241888"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.02283755),
        dec: Angle.Degrees(-59.93134504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163749"},
        {"Hipparcos Number", "HIP 88282"},
        {"Geneva Identification System", "GEN# +1.00163749"},
        {"Smithsonian Astrophysical Observation", "SAO 245172"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.41535398),
        dec: Angle.Degrees(-59.93030715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147945"},
        {"Hipparcos Number", "HIP 80674"},
        {"Smithsonian Astrophysical Observation", "SAO 243834"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.06306962),
        dec: Angle.Degrees(-59.92884148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91155"},
        {"Hipparcos Number", "HIP 51408"},
        {"Smithsonian Astrophysical Observation", "SAO 238124"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.49788983),
        dec: Angle.Degrees(-59.92423589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27134",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27134"},
        {"Smithsonian Astrophysical Observation", "SAO 234124"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.30594015),
        dec: Angle.Degrees(-59.92407867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109800"},
        {"Hipparcos Number", "HIP 61638"},
        {"Geneva Identification System", "GEN# +1.00109800"},
        {"Smithsonian Astrophysical Observation", "SAO 240103"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.52991835),
        dec: Angle.Degrees(-59.92302706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120157"},
        {"Hipparcos Number", "HIP 67454"},
        {"Smithsonian Astrophysical Observation", "SAO 241200"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.35732186),
        dec: Angle.Degrees(-59.92255519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128454"},
        {"Hipparcos Number", "HIP 71650"},
        {"Smithsonian Astrophysical Observation", "SAO 241876"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.82775754),
        dec: Angle.Degrees(-59.92133766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114529"},
        {"Hipparcos Number", "HIP 64425"},
        {"Celescope Catalog", "CEL 4216"},
        {"Geneva Identification System", "GEN# +1.00114529J"},
        {"Smithsonian Astrophysical Observation", "SAO 240645"},
        {"Wilson Evans Batten Catalogue", "WEB 11387"},
    },
    visualMagnitude: 4.58,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.07345539),
        dec: Angle.Degrees(-59.92053651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93737"},
        {"Hipparcos Number", "HIP 52827"},
        {"Celescope Catalog", "CEL 3718"},
        {"Fundamental Katalog 5th Edition", "FK5 2862"},
        {"Geneva Identification System", "GEN# +1.00093737"},
        {"Smithsonian Astrophysical Observation", "SAO 238493"},
        {"Wilson Evans Batten Catalogue", "WEB 9618"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.02256620),
        dec: Angle.Degrees(-59.91916925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221553"},
        {"Hipparcos Number", "HIP 116275"},
        {"Fundamental Katalog 5th Edition", "FK5 6084"},
        {"Geneva Identification System", "GEN# +1.00221553"},
        {"Smithsonian Astrophysical Observation", "SAO 255514"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.38170093),
        dec: Angle.Degrees(-59.91912489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88825"},
        {"Hipparcos Number", "HIP 50044"},
        {"Celescope Catalog", "CEL 3467"},
        {"Geneva Identification System", "GEN# +1.00088825"},
        {"Smithsonian Astrophysical Observation", "SAO 237799"},
        {"Wilson Evans Batten Catalogue", "WEB 9200"},
    },
    visualMagnitude: 6.07,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.25485242),
        dec: Angle.Degrees(-59.91809443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162824"},
        {"Hipparcos Number", "HIP 87845"},
        {"Smithsonian Astrophysical Observation", "SAO 245128"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.19644456),
        dec: Angle.Degrees(-59.91384255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124601"},
        {"Hipparcos Number", "HIP 69754"},
        {"Geneva Identification System", "GEN# +1.00124601"},
        {"Smithsonian Astrophysical Observation", "SAO 241580"},
        {"Wilson Evans Batten Catalogue", "WEB 12146"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.14304634),
        dec: Angle.Degrees(-59.91367573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139211"},
        {"Hipparcos Number", "HIP 76716"},
        {"Fundamental Katalog 5th Edition", "FK5 3236"},
        {"Geneva Identification System", "GEN# +1.00139211"},
        {"Smithsonian Astrophysical Observation", "SAO 242803"},
        {"Wilson Evans Batten Catalogue", "WEB 13020"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.98619135),
        dec: Angle.Degrees(-59.90781512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -215.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182307"},
        {"Hipparcos Number", "HIP 95675"},
        {"Fundamental Katalog 5th Edition", "FK5 5711"},
        {"Smithsonian Astrophysical Observation", "SAO 254580"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.91355056),
        dec: Angle.Degrees(-59.90779526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22168"},
        {"Smithsonian Astrophysical Observation", "SAO 233677"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.53904509),
        dec: Angle.Degrees(-59.90771620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63954"},
        {"Hipparcos Number", "HIP 38060"},
        {"Smithsonian Astrophysical Observation", "SAO 235531"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.01049076),
        dec: Angle.Degrees(-59.90521144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 926"},
        {"Hipparcos Number", "HIP 1081"},
        {"Geneva Identification System", "GEN# +1.00000926"},
        {"Smithsonian Astrophysical Observation", "SAO 248137"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.36705819),
        dec: Angle.Degrees(-59.90519935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89263"},
        {"Hipparcos Number", "HIP 50287"},
        {"Celescope Catalog", "CEL 3486"},
        {"Geneva Identification System", "GEN# +1.00089263J"},
        {"Renson", "Renson 25620"},
        {"Smithsonian Astrophysical Observation", "SAO 237853"},
        {"Wilson Evans Batten Catalogue", "WEB 9235"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.01356689),
        dec: Angle.Degrees(-59.90343640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66918"},
        {"Hipparcos Number", "HIP 39317"},
        {"Geneva Identification System", "GEN# +1.00066918"},
        {"Smithsonian Astrophysical Observation", "SAO 235707"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.58354011),
        dec: Angle.Degrees(-59.89934929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150942"},
        {"Hipparcos Number", "HIP 82223"},
        {"Geneva Identification System", "GEN# +1.00150942"},
        {"Smithsonian Astrophysical Observation", "SAO 244140"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.96121258),
        dec: Angle.Degrees(-59.89928338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15879"},
        {"Hipparcos Number", "HIP 11693"},
        {"Smithsonian Astrophysical Observation", "SAO 248581"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.70493499),
        dec: Angle.Degrees(-59.89736297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208497"},
        {"Hipparcos Number", "HIP 108480"},
        {"Smithsonian Astrophysical Observation", "SAO 255114"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.62656151),
        dec: Angle.Degrees(-59.89732700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109091"},
        {"Hipparcos Number", "HIP 61202"},
        {"Celescope Catalog", "CEL 4120"},
        {"Geneva Identification System", "GEN# +1.00109091"},
        {"Smithsonian Astrophysical Observation", "SAO 240041"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.12385981),
        dec: Angle.Degrees(-59.89676944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83614"},
        {"Hipparcos Number", "HIP 47227"},
        {"Geneva Identification System", "GEN# +1.00083614"},
        {"Renson", "Renson 23830"},
        {"Smithsonian Astrophysical Observation", "SAO 237160"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.37995071),
        dec: Angle.Degrees(-59.88994490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10896"},
        {"Hipparcos Number", "HIP 8184"},
        {"Smithsonian Astrophysical Observation", "SAO 248428"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.29483096),
        dec: Angle.Degrees(-59.88903756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167272"},
        {"Hipparcos Number", "HIP 89697"},
        {"Smithsonian Astrophysical Observation", "SAO 245382"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.58538964),
        dec: Angle.Degrees(-59.88881695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89699"},
    },
    visualMagnitude: 12.28,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.58999452),
        dec: Angle.Degrees(-59.88661472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121556"},
        {"Hipparcos Number", "HIP 68218"},
        {"Geneva Identification System", "GEN# +1.00121556"},
        {"Smithsonian Astrophysical Observation", "SAO 241328"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.49072836),
        dec: Angle.Degrees(-59.88468125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88648"},
        {"Hipparcos Number", "HIP 49927"},
        {"Smithsonian Astrophysical Observation", "SAO 237774"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.90118852),
        dec: Angle.Degrees(-59.88378815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83348"},
        {"Hipparcos Number", "HIP 47061"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.86001407),
        dec: Angle.Degrees(-59.88301376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153696"},
        {"Hipparcos Number", "HIP 83562"},
        {"Geneva Identification System", "GEN# +1.00153696"},
        {"Smithsonian Astrophysical Observation", "SAO 244403"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.16324394),
        dec: Angle.Degrees(-59.88166760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216169"},
        {"Hipparcos Number", "HIP 112895"},
        {"Fundamental Katalog 5th Edition", "FK5 3826"},
        {"Geneva Identification System", "GEN# +1.00216169"},
        {"Smithsonian Astrophysical Observation", "SAO 255336"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.93750305),
        dec: Angle.Degrees(-59.88134724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51555"},
        {"Hipparcos Number", "HIP 33122"},
        {"Celescope Catalog", "CEL 1437"},
        {"Smithsonian Astrophysical Observation", "SAO 234778"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.47563701),
        dec: Angle.Degrees(-59.88092673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119385"},
        {"Hipparcos Number", "HIP 67056"},
        {"Smithsonian Astrophysical Observation", "SAO 241119"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.12431505),
        dec: Angle.Degrees(-59.88042083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2340"},
        {"Hipparcos Number", "HIP 2112"},
        {"Smithsonian Astrophysical Observation", "SAO 248187"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.70482785),
        dec: Angle.Degrees(-59.87794433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33475"},
        {"Hipparcos Number", "HIP 23792"},
        {"Smithsonian Astrophysical Observation", "SAO 233832"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.68599280),
        dec: Angle.Degrees(-59.87787502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138910"},
        {"Hipparcos Number", "HIP 76554"},
        {"Geneva Identification System", "GEN# +1.00138910"},
        {"Smithsonian Astrophysical Observation", "SAO 242777"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.51725871),
        dec: Angle.Degrees(-59.87661543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26307"},
        {"Hipparcos Number", "HIP 19141"},
        {"Geneva Identification System", "GEN# +1.00026307"},
        {"Smithsonian Astrophysical Observation", "SAO 248942"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.54412325),
        dec: Angle.Degrees(-59.87596056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164328"},
        {"Hipparcos Number", "HIP 88510"},
        {"Smithsonian Astrophysical Observation", "SAO 245210"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.10900912),
        dec: Angle.Degrees(-59.87545286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93695"},
        {"Hipparcos Number", "HIP 52806"},
        {"Celescope Catalog", "CEL 3712"},
        {"Geneva Identification System", "GEN# +1.00093695"},
        {"Smithsonian Astrophysical Observation", "SAO 238483"},
        {"Wilson Evans Batten Catalogue", "WEB 9613"},
    },
    visualMagnitude: 6.47,
    bvColour: -0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.93472992),
        dec: Angle.Degrees(-59.87525692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96670"},
        {"Hipparcos Number", "HIP 54358"},
        {"Celescope Catalog", "CEL 3816"},
        {"Geneva Identification System", "GEN# +1.00096670"},
        {"Smithsonian Astrophysical Observation", "SAO 238793"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.80808991),
        dec: Angle.Degrees(-59.87310951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84588"},
        {"Hipparcos Number", "HIP 47751"},
        {"Smithsonian Astrophysical Observation", "SAO 237282"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.02436973),
        dec: Angle.Degrees(-59.87121291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96159"},
        {"Hipparcos Number", "HIP 54122"},
        {"Celescope Catalog", "CEL 3791"},
        {"Geneva Identification System", "GEN# +1.00096159"},
        {"Smithsonian Astrophysical Observation", "SAO 238735"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.10708318),
        dec: Angle.Degrees(-59.86836268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91507"},
        {"Hipparcos Number", "HIP 51601"},
        {"Geneva Identification System", "GEN# +1.00091507"},
        {"Smithsonian Astrophysical Observation", "SAO 238161"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.11563737),
        dec: Angle.Degrees(-59.86580573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207255"},
        {"Hipparcos Number", "HIP 107761"},
        {"Smithsonian Astrophysical Observation", "SAO 255083"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.45850447),
        dec: Angle.Degrees(-59.86523481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213885"},
        {"Hipparcos Number", "HIP 111553"},
        {"Geneva Identification System", "GEN# +1.00213885"},
        {"Smithsonian Astrophysical Observation", "SAO 255261"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.98517143),
        dec: Angle.Degrees(-59.86426105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203061"},
        {"Hipparcos Number", "HIP 105527"},
        {"Smithsonian Astrophysical Observation", "SAO 254987"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.59606917),
        dec: Angle.Degrees(-59.86379933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113823"},
        {"Hipparcos Number", "HIP 64033"},
        {"Celescope Catalog", "CEL 4200"},
        {"Geneva Identification System", "GEN# +1.00113823J"},
        {"Smithsonian Astrophysical Observation", "SAO 240566"},
        {"Wilson Evans Batten Catalogue", "WEB 11319"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.85129190),
        dec: Angle.Degrees(-59.86049011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96248"},
        {"Hipparcos Number", "HIP 54179"},
        {"Celescope Catalog", "CEL 3797"},
        {"Geneva Identification System", "GEN# +1.00096248"},
        {"Smithsonian Astrophysical Observation", "SAO 238743"},
        {"Wilson Evans Batten Catalogue", "WEB 9789"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.23988789),
        dec: Angle.Degrees(-59.85890272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184734"},
        {"Hipparcos Number", "HIP 96678"},
        {"Smithsonian Astrophysical Observation", "SAO 246197"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.82823849),
        dec: Angle.Degrees(-59.85822955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14122"},
        {"Hipparcos Number", "HIP 10464"},
        {"Smithsonian Astrophysical Observation", "SAO 248519"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.72492852),
        dec: Angle.Degrees(-59.85772280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22189"},
        {"Hipparcos Number", "HIP 16417"},
        {"Smithsonian Astrophysical Observation", "SAO 248827"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.85198923),
        dec: Angle.Degrees(-59.85697854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104932"},
        {"Hipparcos Number", "HIP 58922"},
        {"Geneva Identification System", "GEN# +1.00104932"},
        {"Smithsonian Astrophysical Observation", "SAO 239647"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.23990683),
        dec: Angle.Degrees(-59.85691188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74583"},
        {"Hipparcos Number", "HIP 42675"},
        {"Smithsonian Astrophysical Observation", "SAO 236199"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.46558887),
        dec: Angle.Degrees(-59.85577059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20254"},
        {"Hipparcos Number", "HIP 14905"},
        {"Smithsonian Astrophysical Observation", "SAO 248754"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.09321626),
        dec: Angle.Degrees(-59.85340798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91464"},
        {"Hipparcos Number", "HIP 51586"},
        {"Smithsonian Astrophysical Observation", "SAO 238158"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.05598504),
        dec: Angle.Degrees(-59.84876498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147882"},
        {"Hipparcos Number", "HIP 80640"},
        {"Smithsonian Astrophysical Observation", "SAO 243825"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.97577643),
        dec: Angle.Degrees(-59.84871388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101025"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.21352973),
        dec: Angle.Degrees(-59.84739308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158895"},
        {"Hipparcos Number", "HIP 86088"},
        {"Geneva Identification System", "GEN# +1.00158895"},
        {"Smithsonian Astrophysical Observation", "SAO 244866"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.89584304),
        dec: Angle.Degrees(-59.84609702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60863"},
        {"Geneva Identification System", "GEN# +4.21140007"},
    },
    visualMagnitude: 11.34,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.12578703),
        dec: Angle.Degrees(-59.84601409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12713"},
        {"Hipparcos Number", "HIP 9528"},
        {"Fundamental Katalog 5th Edition", "FK5 4185"},
        {"Smithsonian Astrophysical Observation", "SAO 248486"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.63705222),
        dec: Angle.Degrees(-59.84363206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118452"},
        {"Hipparcos Number", "HIP 66557"},
        {"Smithsonian Astrophysical Observation", "SAO 241022"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.65193110),
        dec: Angle.Degrees(-59.84221665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134877"},
        {"Hipparcos Number", "HIP 74634"},
        {"Geneva Identification System", "GEN# +1.00134877"},
        {"Geneva Identification System 2", "GEN# +6.42301004"},
    },
    visualMagnitude: 11.34,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.74051037),
        dec: Angle.Degrees(-59.84172368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87458"},
        {"Hipparcos Number", "HIP 49245"},
        {"Geneva Identification System", "GEN# +2.31140136"},
        {"Smithsonian Astrophysical Observation", "SAO 237645"},
        {"New General Catalogue", "NGC 3114 136"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.78424522),
        dec: Angle.Degrees(-59.84108660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167806"},
        {"Hipparcos Number", "HIP 89902"},
        {"Smithsonian Astrophysical Observation", "SAO 245405"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.17565842),
        dec: Angle.Degrees(-59.83987251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195960"},
        {"Hipparcos Number", "HIP 101742"},
        {"Smithsonian Astrophysical Observation", "SAO 254834"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.32088314),
        dec: Angle.Degrees(-59.83943957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56146"},
        {"Hipparcos Number", "HIP 34792"},
        {"Smithsonian Astrophysical Observation", "SAO 235009"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.04231921),
        dec: Angle.Degrees(-59.83942878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39579"},
        {"Hipparcos Number", "HIP 27524"},
        {"Smithsonian Astrophysical Observation", "SAO 234156"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.42191350),
        dec: Angle.Degrees(-59.83931887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76381"},
        {"Hipparcos Number", "HIP 43611"},
        {"Smithsonian Astrophysical Observation", "SAO 236369"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.23477737),
        dec: Angle.Degrees(-59.83775908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74498"},
        {"Hipparcos Number", "HIP 42646"},
        {"Smithsonian Astrophysical Observation", "SAO 236189"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.35593712),
        dec: Angle.Degrees(-59.83695804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119975"},
        {"Hipparcos Number", "HIP 67346"},
        {"Smithsonian Astrophysical Observation", "SAO 241182"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.04691215),
        dec: Angle.Degrees(-59.83192205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156769"},
        {"Hipparcos Number", "HIP 85073"},
        {"Smithsonian Astrophysical Observation", "SAO 244680"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.80074852),
        dec: Angle.Degrees(-59.83134836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12"},
        {"Hipparcos Number", "HIP 414"},
        {"Geneva Identification System", "GEN# +1.00000012"},
        {"Smithsonian Astrophysical Observation", "SAO 248111"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.26224739),
        dec: Angle.Degrees(-59.82810463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27356"},
        {"Hipparcos Number", "HIP 19866"},
        {"Smithsonian Astrophysical Observation", "SAO 233459"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.90697367),
        dec: Angle.Degrees(-59.82440593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41979"},
        {"Hipparcos Number", "HIP 28749"},
        {"Smithsonian Astrophysical Observation", "SAO 234292"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.06976492),
        dec: Angle.Degrees(-59.82210835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23025"},
        {"Hipparcos Number", "HIP 16992"},
        {"Smithsonian Astrophysical Observation", "SAO 233201"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.63720726),
        dec: Angle.Degrees(-59.82047789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134820"},
        {"Hipparcos Number", "HIP 74609"},
        {"Geneva Identification System", "GEN# +1.00134820"},
        {"Smithsonian Astrophysical Observation", "SAO 242335"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.66629390),
        dec: Angle.Degrees(-59.82044995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74606",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74606"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.65988975),
        dec: Angle.Degrees(-59.81941369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18958"},
        {"Hipparcos Number", "HIP 13992"},
        {"Geneva Identification System", "GEN# +1.00018958"},
        {"Smithsonian Astrophysical Observation", "SAO 248706"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.04164262),
        dec: Angle.Degrees(-59.81936989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114630"},
        {"Hipparcos Number", "HIP 64478"},
        {"Geneva Identification System", "GEN# +1.00114630"},
        {"Smithsonian Astrophysical Observation", "SAO 240653"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.23211260),
        dec: Angle.Degrees(-59.81634245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3278"},
        {"Hipparcos Number", "HIP 2761"},
        {"Smithsonian Astrophysical Observation", "SAO 248219"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.81021350),
        dec: Angle.Degrees(-59.81590041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105125"},
        {"Geneva Identification System", "GEN# +6.20145075"},
    },
    visualMagnitude: 11.17,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.42396896),
        dec: Angle.Degrees(-59.81568456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54"},
        {"Hipparcos Number", "HIP 444"},
        {"Smithsonian Astrophysical Observation", "SAO 248113"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.33660254),
        dec: Angle.Degrees(-59.81448691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63581"},
        {"Hipparcos Number", "HIP 37918"},
        {"Geneva Identification System", "GEN# +1.00063581"},
        {"Smithsonian Astrophysical Observation", "SAO 235503"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.56201166),
        dec: Angle.Degrees(-59.81445732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 149.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132249"},
        {"Hipparcos Number", "HIP 73458"},
        {"Fundamental Katalog 5th Edition", "FK5 5336"},
        {"Geneva Identification System", "GEN# +1.00132249"},
        {"Smithsonian Astrophysical Observation", "SAO 242164"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.18707228),
        dec: Angle.Degrees(-59.81167532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22348"},
        {"Hipparcos Number", "HIP 16526"},
        {"Smithsonian Astrophysical Observation", "SAO 233155"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.19275009),
        dec: Angle.Degrees(-59.81157989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29382"},
        {"Hipparcos Number", "HIP 21286"},
        {"Geneva Identification System", "GEN# +1.00029382"},
        {"Smithsonian Astrophysical Observation", "SAO 233567"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.51035966),
        dec: Angle.Degrees(-59.81011953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63608"},
        {"Hipparcos Number", "HIP 37923"},
        {"Geneva Identification System", "GEN# +1.00063608"},
        {"Smithsonian Astrophysical Observation", "SAO 235504"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.57092429),
        dec: Angle.Degrees(-59.80987184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 148.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163502"},
        {"Hipparcos Number", "HIP 88146"},
        {"Smithsonian Astrophysical Observation", "SAO 245158"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.06059230),
        dec: Angle.Degrees(-59.80558639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123893"},
        {"Hipparcos Number", "HIP 69385"},
        {"Smithsonian Astrophysical Observation", "SAO 241522"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.05073335),
        dec: Angle.Degrees(-59.80443671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138334"},
        {"Hipparcos Number", "HIP 76244"},
        {"Smithsonian Astrophysical Observation", "SAO 242699"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.61089486),
        dec: Angle.Degrees(-59.80086126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43144"},
        {"Hipparcos Number", "HIP 29311"},
        {"Geneva Identification System", "GEN# +1.00043144"},
        {"Smithsonian Astrophysical Observation", "SAO 234362"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.70809438),
        dec: Angle.Degrees(-59.80084179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86033"},
        {"Smithsonian Astrophysical Observation", "SAO 244858"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.73499655),
        dec: Angle.Degrees(-59.79807512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132986"},
        {"Hipparcos Number", "HIP 73775"},
        {"Smithsonian Astrophysical Observation", "SAO 242206"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.19946677),
        dec: Angle.Degrees(-59.79488119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206686"},
        {"Hipparcos Number", "HIP 107452"},
        {"Smithsonian Astrophysical Observation", "SAO 255065"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.45762254),
        dec: Angle.Degrees(-59.79459073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2698"},
        {"Hipparcos Number", "HIP 2349"},
        {"Fundamental Katalog 5th Edition", "FK5 4048"},
        {"Geneva Identification System", "GEN# +1.00002698"},
        {"Smithsonian Astrophysical Observation", "SAO 248198"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.49670462),
        dec: Angle.Degrees(-59.79433240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114999"},
        {"Hipparcos Number", "HIP 64664"},
        {"Geneva Identification System", "GEN# +1.00114999"},
        {"Smithsonian Astrophysical Observation", "SAO 240676"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.82396848),
        dec: Angle.Degrees(-59.79286747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12043"},
        {"Hipparcos Number", "HIP 9038"},
        {"Smithsonian Astrophysical Observation", "SAO 248468"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.10369545),
        dec: Angle.Degrees(-59.79239173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202794"},
        {"Hipparcos Number", "HIP 105386"},
        {"Smithsonian Astrophysical Observation", "SAO 254979"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.20390902),
        dec: Angle.Degrees(-59.79149377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2281"},
        {"Hipparcos Number", "HIP 2078"},
        {"Smithsonian Astrophysical Observation", "SAO 248185"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.56092449),
        dec: Angle.Degrees(-59.78758536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19239"},
        {"Hipparcos Number", "HIP 14192"},
        {"Smithsonian Astrophysical Observation", "SAO 232974"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.74787512),
        dec: Angle.Degrees(-59.78704661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127610"},
        {"Hipparcos Number", "HIP 71282"},
        {"Geneva Identification System", "GEN# +1.00127610"},
        {"Smithsonian Astrophysical Observation", "SAO 241803"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.66639335),
        dec: Angle.Degrees(-59.78454765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116507"},
        {"Hipparcos Number", "HIP 65492"},
        {"Celescope Catalog", "CEL 4254"},
        {"Geneva Identification System", "GEN# +1.00116507"},
        {"Smithsonian Astrophysical Observation", "SAO 240822"},
    },
    visualMagnitude: 8.83,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.33874330),
        dec: Angle.Degrees(-59.78146933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219395"},
        {"Hipparcos Number", "HIP 114880"},
        {"Geneva Identification System", "GEN# +1.00219395"},
        {"Smithsonian Astrophysical Observation", "SAO 255441"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.04277371),
        dec: Angle.Degrees(-59.78067920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4895"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.71253220),
        dec: Angle.Degrees(-59.77993106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222742"},
        {"Hipparcos Number", "HIP 117033"},
        {"Geneva Identification System", "GEN# +1.00222742"},
        {"Smithsonian Astrophysical Observation", "SAO 255551"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.87696712),
        dec: Angle.Degrees(-59.77904101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91596"},
        {"Hipparcos Number", "HIP 51646"},
        {"Smithsonian Astrophysical Observation", "SAO 238175"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.27823849),
        dec: Angle.Degrees(-59.77891239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22989"},
        {"Hipparcos Number", "HIP 16959"},
        {"Geneva Identification System", "GEN# +1.00022989"},
        {"Smithsonian Astrophysical Observation", "SAO 233197"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.54253190),
        dec: Angle.Degrees(-59.77648614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22960"},
        {"Hipparcos Number", "HIP 16942"},
        {"Geneva Identification System", "GEN# +1.00022960"},
        {"Smithsonian Astrophysical Observation", "SAO 233195"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.51089042),
        dec: Angle.Degrees(-59.77601143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222082"},
        {"Hipparcos Number", "HIP 116609"},
        {"Smithsonian Astrophysical Observation", "SAO 255528"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.47139355),
        dec: Angle.Degrees(-59.77541272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126807"},
        {"Hipparcos Number", "HIP 70905"},
        {"Geneva Identification System", "GEN# +1.00126807"},
        {"Smithsonian Astrophysical Observation", "SAO 241749"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.49427957),
        dec: Angle.Degrees(-59.77526286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158630"},
        {"Hipparcos Number", "HIP 85960"},
        {"Geneva Identification System", "GEN# +1.00158630"},
        {"Smithsonian Astrophysical Observation", "SAO 244841"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.52217542),
        dec: Angle.Degrees(-59.77479858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -404.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48115"},
        {"Hipparcos Number", "HIP 31712"},
        {"Geneva Identification System", "GEN# +1.00048115"},
        {"Smithsonian Astrophysical Observation", "SAO 234628"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.50226158),
        dec: Angle.Degrees(-59.77342493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46332"},
        {"Hipparcos Number", "HIP 30882"},
        {"Geneva Identification System", "GEN# +1.00046332"},
        {"Smithsonian Astrophysical Observation", "SAO 234533"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.23552691),
        dec: Angle.Degrees(-59.77305859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115778"},
        {"Hipparcos Number", "HIP 65108"},
        {"Geneva Identification System", "GEN# +1.00115778"},
        {"Smithsonian Astrophysical Observation", "SAO 240756"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.14610013),
        dec: Angle.Degrees(-59.77275811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123721"},
        {"Hipparcos Number", "HIP 69320"},
        {"Geneva Identification System", "GEN# +1.00123721"},
        {"Smithsonian Astrophysical Observation", "SAO 241511"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.81758575),
        dec: Angle.Degrees(-59.77169042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176339"},
        {"Hipparcos Number", "HIP 93567"},
        {"Geneva Identification System", "GEN# +1.00176339"},
        {"Smithsonian Astrophysical Observation", "SAO 245883"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.86411166),
        dec: Angle.Degrees(-59.77021361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105580"},
        {"Hipparcos Number", "HIP 59266"},
        {"Geneva Identification System", "GEN# +1.00105580"},
        {"Smithsonian Astrophysical Observation", "SAO 239702"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.34829586),
        dec: Angle.Degrees(-59.76926204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147672"},
        {"Hipparcos Number", "HIP 80545"},
        {"Smithsonian Astrophysical Observation", "SAO 243798"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.67077423),
        dec: Angle.Degrees(-59.76912730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46417"},
        {"Hipparcos Number", "HIP 30933"},
        {"Geneva Identification System", "GEN# +1.00046417"},
        {"Smithsonian Astrophysical Observation", "SAO 234544"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.37127345),
        dec: Angle.Degrees(-59.76751971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38371"},
        {"Hipparcos Number", "HIP 26794"},
        {"Geneva Identification System", "GEN# +1.00038371"},
        {"Smithsonian Astrophysical Observation", "SAO 234099"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.35936322),
        dec: Angle.Degrees(-59.76735415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29115"},
        {"Hipparcos Number", "HIP 21106"},
        {"Geneva Identification System", "GEN# +1.00029115"},
        {"Smithsonian Astrophysical Observation", "SAO 233550"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.84865530),
        dec: Angle.Degrees(-59.76688703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5571"},
        {"Hipparcos Number", "HIP 4404"},
        {"Smithsonian Astrophysical Observation", "SAO 248284"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.11750666),
        dec: Angle.Degrees(-59.76389020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74375"},
        {"Hipparcos Number", "HIP 42568"},
        {"Celescope Catalog", "CEL 2780"},
        {"Fundamental Katalog 5th Edition", "FK5 2685"},
        {"Geneva Identification System", "GEN# +1.00074375"},
        {"Smithsonian Astrophysical Observation", "SAO 236181"},
        {"Wilson Evans Batten Catalogue", "WEB 8214"},
    },
    visualMagnitude: 4.31,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.15431317),
        dec: Angle.Degrees(-59.76101468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153163"},
        {"Hipparcos Number", "HIP 83294"},
        {"Geneva Identification System", "GEN# +1.00153163"},
        {"Smithsonian Astrophysical Observation", "SAO 244358"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.34372703),
        dec: Angle.Degrees(-59.76031240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107899"},
        {"Hipparcos Number", "HIP 60508"},
        {"Geneva Identification System", "GEN# +1.00107899"},
        {"Smithsonian Astrophysical Observation", "SAO 239921"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.06549185),
        dec: Angle.Degrees(-59.75979376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14928"},
        {"Hipparcos Number", "HIP 11044"},
        {"Geneva Identification System", "GEN# +1.00014928"},
        {"Smithsonian Astrophysical Observation", "SAO 232732"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.54943783),
        dec: Angle.Degrees(-59.75932106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103962"},
        {"Hipparcos Number", "HIP 58391"},
        {"Geneva Identification System", "GEN# +1.00103962"},
        {"Renson", "Renson 30040"},
        {"Smithsonian Astrophysical Observation", "SAO 239538"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.58823289),
        dec: Angle.Degrees(-59.75523498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105193"},
        {"Hipparcos Number", "HIP 59064"},
        {"Geneva Identification System", "GEN# +1.00105193"},
        {"Smithsonian Astrophysical Observation", "SAO 239668"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.69111612),
        dec: Angle.Degrees(-59.75393934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137661"},
        {"Hipparcos Number", "HIP 75901"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)30, 11.5200),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)45, 12.100)
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
    primaryId: "HIP 70014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125117"},
        {"Hipparcos Number", "HIP 70014"},
        {"Geneva Identification System", "GEN# +1.00125117"},
        {"Smithsonian Astrophysical Observation", "SAO 241633"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.88998727),
        dec: Angle.Degrees(-59.75261248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108569"},
        {"Cincinnati Publication", "Ci 20 1324"},
        {"Geneva Identification System", "GEN# -0.06007821"},
        {"Geneva Identification System 2", "GEN# -0.06007528"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.89032084),
        dec: Angle.Degrees(-59.75250920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 886.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136613"},
        {"Hipparcos Number", "HIP 75410"},
        {"Smithsonian Astrophysical Observation", "SAO 242479"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.11983718),
        dec: Angle.Degrees(-59.75161882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140096"},
        {"Hipparcos Number", "HIP 77130"},
        {"Geneva Identification System", "GEN# +1.00140096"},
        {"Smithsonian Astrophysical Observation", "SAO 242898"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.23365636),
        dec: Angle.Degrees(-59.74959302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114340"},
        {"Hipparcos Number", "HIP 64324"},
        {"Geneva Identification System", "GEN# +1.00114340"},
        {"Smithsonian Astrophysical Observation", "SAO 240626"},
        {"Wilson Evans Batten Catalogue", "WEB 11370"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.76594459),
        dec: Angle.Degrees(-59.74575511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81893"},
        {"Hipparcos Number", "HIP 46274"},
        {"Smithsonian Astrophysical Observation", "SAO 236973"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.51737330),
        dec: Angle.Degrees(-59.74408882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159773"},
        {"Hipparcos Number", "HIP 86480"},
        {"Smithsonian Astrophysical Observation", "SAO 244927"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.06572055),
        dec: Angle.Degrees(-59.74401298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176463"},
        {"Hipparcos Number", "HIP 93638"},
        {"Geneva Identification System", "GEN# +1.00176463"},
        {"Smithsonian Astrophysical Observation", "SAO 245895"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.02604967),
        dec: Angle.Degrees(-59.74268976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112364"},
        {"Hipparcos Number", "HIP 63206"},
        {"Celescope Catalog", "CEL 4174"},
        {"Geneva Identification System", "GEN# +1.00112364"},
        {"Smithsonian Astrophysical Observation", "SAO 240403"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.24858546),
        dec: Angle.Degrees(-59.74250242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95880"},
        {"Hipparcos Number", "HIP 53996"},
        {"Geneva Identification System", "GEN# +1.00095880J"},
        {"Smithsonian Astrophysical Observation", "SAO 238715"},
        {"Wilson Evans Batten Catalogue", "WEB 9768"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.69258683),
        dec: Angle.Degrees(-59.74099315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100293"},
        {"Hipparcos Number", "HIP 56264"},
        {"Smithsonian Astrophysical Observation", "SAO 239149"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.99907859),
        dec: Angle.Degrees(-59.74050409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77244"},
        {"Hipparcos Number", "HIP 44068"},
        {"Celescope Catalog", "CEL 3127"},
        {"Geneva Identification System", "GEN# +1.00077244"},
        {"Smithsonian Astrophysical Observation", "SAO 236460"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.64419940),
        dec: Angle.Degrees(-59.73805542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19319"},
        {"Hipparcos Number", "HIP 14240"},
        {"Fundamental Katalog 5th Edition", "FK5 110"},
        {"Geneva Identification System", "GEN# +1.00019319"},
        {"Smithsonian Astrophysical Observation", "SAO 232981"},
        {"Wilson Evans Batten Catalogue", "WEB 2791"},
    },
    visualMagnitude: 5.12,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.90376552),
        dec: Angle.Degrees(-59.73761994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126357"},
        {"Hipparcos Number", "HIP 70659"},
        {"Geneva Identification System", "GEN# +1.00126357"},
        {"Smithsonian Astrophysical Observation", "SAO 241721"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.78641756),
        dec: Angle.Degrees(-59.73645908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218392"},
        {"Hipparcos Number", "HIP 114270"},
        {"Geneva Identification System", "GEN# +1.00218392"},
        {"Smithsonian Astrophysical Observation", "SAO 255413"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.15638614),
        dec: Angle.Degrees(-59.73640335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18488"},
        {"Hipparcos Number", "HIP 13648"},
        {"Smithsonian Astrophysical Observation", "SAO 232940"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.92976646),
        dec: Angle.Degrees(-59.73554376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134785"},
        {"Hipparcos Number", "HIP 74598"},
        {"Smithsonian Astrophysical Observation", "SAO 242334"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.62931958),
        dec: Angle.Degrees(-59.73519557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114267"},
        {"Smithsonian Astrophysical Observation", "SAO 255412"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.14935056),
        dec: Angle.Degrees(-59.73513461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204579"},
        {"Hipparcos Number", "HIP 106308"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.96036089),
        dec: Angle.Degrees(-59.73488145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -298.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30478"},
        {"Hipparcos Number", "HIP 22040"},
        {"Fundamental Katalog 5th Edition", "FK5 2354"},
        {"Geneva Identification System", "GEN# +1.00030478"},
        {"Smithsonian Astrophysical Observation", "SAO 233664"},
        {"Wilson Evans Batten Catalogue", "WEB 4235"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.08799653),
        dec: Angle.Degrees(-59.73284052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95109"},
        {"Hipparcos Number", "HIP 53589"},
        {"Geneva Identification System", "GEN# +1.00095109"},
        {"Smithsonian Astrophysical Observation", "SAO 238635"},
        {"Wilson Evans Batten Catalogue", "WEB 9723"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.45080678),
        dec: Angle.Degrees(-59.73219545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26419"},
        {"Hipparcos Number", "HIP 19234"},
        {"Geneva Identification System", "GEN# +1.00026419"},
        {"Smithsonian Astrophysical Observation", "SAO 233405"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.84238895),
        dec: Angle.Degrees(-59.73046038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152066"},
        {"Hipparcos Number", "HIP 82749"},
        {"Smithsonian Astrophysical Observation", "SAO 244259"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.68744803),
        dec: Angle.Degrees(-59.72403927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167187"},
        {"Hipparcos Number", "HIP 89657"},
        {"Smithsonian Astrophysical Observation", "SAO 245375"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.46027231),
        dec: Angle.Degrees(-59.72298276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10888"},
        {"Hipparcos Number", "HIP 8172"},
        {"Smithsonian Astrophysical Observation", "SAO 232516"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.26893834),
        dec: Angle.Degrees(-59.71815344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100380"},
        {"Hipparcos Number", "HIP 56301"},
        {"Geneva Identification System", "GEN# +1.00100380"},
        {"Smithsonian Astrophysical Observation", "SAO 239153"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.13518563),
        dec: Angle.Degrees(-59.71783231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3375"},
        {"Hipparcos Number", "HIP 2841"},
        {"Fundamental Katalog 5th Edition", "FK5 2038"},
        {"Geneva Identification System", "GEN# +1.00003375"},
        {"Smithsonian Astrophysical Observation", "SAO 232105"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.00332958),
        dec: Angle.Degrees(-59.71719483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123296"},
        {"Hipparcos Number", "HIP 69105"},
        {"Geneva Identification System", "GEN# +1.00123296"},
        {"Smithsonian Astrophysical Observation", "SAO 241475"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.18764328),
        dec: Angle.Degrees(-59.71705459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54967"},
        {"Hipparcos Number", "HIP 34350"},
        {"Geneva Identification System", "GEN# +1.00054967"},
        {"Smithsonian Astrophysical Observation", "SAO 234944"},
        {"Wilson Evans Batten Catalogue", "WEB 6884"},
    },
    visualMagnitude: 6.46,
    bvColour: -0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.81784892),
        dec: Angle.Degrees(-59.71643858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122879"},
        {"Hipparcos Number", "HIP 68902"},
        {"Geneva Identification System", "GEN# +1.00122879"},
        {"Smithsonian Astrophysical Observation", "SAO 241439"},
        {"Wilson Evans Batten Catalogue", "WEB 12039"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.60483587),
        dec: Angle.Degrees(-59.71590250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130885"},
        {"Hipparcos Number", "HIP 72831"},
        {"Smithsonian Astrophysical Observation", "SAO 242084"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.30356250),
        dec: Angle.Degrees(-59.71545785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186878"},
        {"Hipparcos Number", "HIP 97606"},
        {"Smithsonian Astrophysical Observation", "SAO 246287"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.57221193),
        dec: Angle.Degrees(-59.71441993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86619"},
        {"Hipparcos Number", "HIP 48832"},
        {"Smithsonian Astrophysical Observation", "SAO 237537"},
        {"Wilson Evans Batten Catalogue", "WEB 9077"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.41776988),
        dec: Angle.Degrees(-59.71437175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96261"},
        {"Hipparcos Number", "HIP 54184"},
        {"Celescope Catalog", "CEL 3799"},
        {"Geneva Identification System", "GEN# +1.00096261A"},
        {"Smithsonian Astrophysical Observation", "SAO 238749"},
        {"Wilson Evans Batten Catalogue", "WEB 9790"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.26371774),
        dec: Angle.Degrees(-59.71363041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96261B"},
        {"Hipparcos Number", "HIP 54181"},
        {"Smithsonian Astrophysical Observation", "SAO 238746"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.25410793),
        dec: Angle.Degrees(-59.71323065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50923"},
        {"Hipparcos Number", "HIP 32917"},
        {"Geneva Identification System", "GEN# +1.00050923"},
        {"Smithsonian Astrophysical Observation", "SAO 234755"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.87761844),
        dec: Angle.Degrees(-59.70959956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201802"},
        {"Hipparcos Number", "HIP 104857"},
        {"Smithsonian Astrophysical Observation", "SAO 246920"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.61666909),
        dec: Angle.Degrees(-59.70925057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198534"},
        {"Hipparcos Number", "HIP 103135"},
        {"Smithsonian Astrophysical Observation", "SAO 246773"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.43595291),
        dec: Angle.Degrees(-59.70837858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116780"},
        {"Hipparcos Number", "HIP 65611"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.79314079),
        dec: Angle.Degrees(-59.70460010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21210"},
        {"Hipparcos Number", "HIP 15715"},
        {"Smithsonian Astrophysical Observation", "SAO 233088"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.60560306),
        dec: Angle.Degrees(-59.70373790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4724"},
        {"Hipparcos Number", "HIP 3774"},
        {"Smithsonian Astrophysical Observation", "SAO 232190"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.12613867),
        dec: Angle.Degrees(-59.70104237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163072"},
        {"Hipparcos Number", "HIP 87953"},
        {"Geneva Identification System", "GEN# +1.00163072"},
        {"Smithsonian Astrophysical Observation", "SAO 245135"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.51083591),
        dec: Angle.Degrees(-59.70099771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204730"},
        {"Hipparcos Number", "HIP 106398"},
        {"Smithsonian Astrophysical Observation", "SAO 247075"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.24760618),
        dec: Angle.Degrees(-59.70001266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66042"},
        {"Hipparcos Number", "HIP 38964"},
        {"Smithsonian Astrophysical Observation", "SAO 235650"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.59146475),
        dec: Angle.Degrees(-59.69755236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105233"},
        {"Hipparcos Number", "HIP 59084"},
        {"Geneva Identification System", "GEN# +1.00105233"},
        {"Smithsonian Astrophysical Observation", "SAO 239674"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.75294810),
        dec: Angle.Degrees(-59.69465073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156091"},
        {"Hipparcos Number", "HIP 84731"},
        {"Geneva Identification System", "GEN# +1.00156091"},
        {"Smithsonian Astrophysical Observation", "SAO 244613"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.80212875),
        dec: Angle.Degrees(-59.69459145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219302"},
        {"Hipparcos Number", "HIP 114820"},
        {"Smithsonian Astrophysical Observation", "SAO 247800"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.87626261),
        dec: Angle.Degrees(-59.69423629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146504"},
        {"Hipparcos Number", "HIP 80014"},
        {"Smithsonian Astrophysical Observation", "SAO 243634"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.00057611),
        dec: Angle.Degrees(-59.69387387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205158"},
        {"Hipparcos Number", "HIP 106615"},
        {"Geneva Identification System", "GEN# +1.00205158"},
        {"Smithsonian Astrophysical Observation", "SAO 247097"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.91894446),
        dec: Angle.Degrees(-59.69313697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210591"},
        {"Hipparcos Number", "HIP 109682"},
        {"Smithsonian Astrophysical Observation", "SAO 247360"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.27428394),
        dec: Angle.Degrees(-59.69170749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1542"},
        {"Hipparcos Number", "HIP 1560"},
        {"Geneva Identification System", "GEN# +1.00001542"},
        {"Smithsonian Astrophysical Observation", "SAO 231999"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.85085222),
        dec: Angle.Degrees(-59.69074657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178611"},
        {"Hipparcos Number", "HIP 94410"},
        {"Fundamental Katalog 5th Edition", "FK5 5690"},
        {"Geneva Identification System", "GEN# +1.00178611"},
        {"Smithsonian Astrophysical Observation", "SAO 245972"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.22626805),
        dec: Angle.Degrees(-59.68880304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62434",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Mimosa"},
        {"Henry Draper", "HD 111123"},
        {"Hipparcos Number", "HIP 62434"},
        {"Celescope Catalog", "CEL 4154"},
        {"Fundamental Katalog 5th Edition", "FK5 481"},
        {"Geneva Identification System", "GEN# +1.00111123"},
        {"Smithsonian Astrophysical Observation", "SAO 240259"},
        {"Wilson Evans Batten Catalogue", "WEB 11084"},
    },
    visualMagnitude: 1.25,
    bvColour: -0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.93049537),
        dec: Angle.Degrees(-59.68873246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110335"},
        {"Hipparcos Number", "HIP 61966"},
        {"Celescope Catalog", "CEL 4140"},
        {"Geneva Identification System", "GEN# +1.00110335"},
        {"Smithsonian Astrophysical Observation", "SAO 240161"},
        {"Wilson Evans Batten Catalogue", "WEB 11017"},
    },
    visualMagnitude: 4.91,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.48582000),
        dec: Angle.Degrees(-59.68581085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10020"},
        {"Hipparcos Number", "HIP 7477"},
        {"Smithsonian Astrophysical Observation", "SAO 232476"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.07221529),
        dec: Angle.Degrees(-59.68436965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16381"},
        {"Hipparcos Number", "HIP 12044"},
        {"Smithsonian Astrophysical Observation", "SAO 232826"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.81620538),
        dec: Angle.Degrees(-59.68428852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160777"},
        {"Hipparcos Number", "HIP 86913"},
        {"Geneva Identification System", "GEN# +1.00160777"},
        {"Smithsonian Astrophysical Observation", "SAO 244995"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.38310974),
        dec: Angle.Degrees(-59.68234353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120562"},
        {"Hipparcos Number", "HIP 67684"},
        {"Geneva Identification System", "GEN# +1.00120562"},
        {"Smithsonian Astrophysical Observation", "SAO 241234"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.98411226),
        dec: Angle.Degrees(-59.68228030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100613"},
        {"Hipparcos Number", "HIP 56422"},
        {"Geneva Identification System", "GEN# +1.00100613"},
        {"Smithsonian Astrophysical Observation", "SAO 239177"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.52906041),
        dec: Angle.Degrees(-59.68153291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192157"},
        {"Hipparcos Number", "HIP 99946"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.17064545),
        dec: Angle.Degrees(-59.68093425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13246"},
        {"Hipparcos Number", "HIP 9902"},
        {"Geneva Identification System", "GEN# +1.00013246"},
        {"Smithsonian Astrophysical Observation", "SAO 232642"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.85840805),
        dec: Angle.Degrees(-59.67938421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195762"},
        {"Hipparcos Number", "HIP 101638"},
        {"Smithsonian Astrophysical Observation", "SAO 246649"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.01979852),
        dec: Angle.Degrees(-59.67866945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97557"},
        {"Hipparcos Number", "HIP 54764"},
        {"Celescope Catalog", "CEL 3850"},
        {"Geneva Identification System", "GEN# +1.00097557"},
        {"Smithsonian Astrophysical Observation", "SAO 238864"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.18452803),
        dec: Angle.Degrees(-59.67761244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92740"},
        {"Hipparcos Number", "HIP 52308"},
        {"Celescope Catalog", "CEL 3643"},
        {"Geneva Identification System", "GEN# +1.00092740"},
        {"Smithsonian Astrophysical Observation", "SAO 238353"},
        {"Wilson Evans Batten Catalogue", "WEB 9523"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.32301986),
        dec: Angle.Degrees(-59.67692226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4406"},
        {"Smithsonian Astrophysical Observation", "SAO 232231"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.12244058),
        dec: Angle.Degrees(-59.67317258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 302924"},
        {"Hipparcos Number", "HIP 51142"},
        {"Smithsonian Astrophysical Observation", "SAO 238071"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.71201783),
        dec: Angle.Degrees(-59.66955533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150886"},
        {"Hipparcos Number", "HIP 82187"},
        {"Smithsonian Astrophysical Observation", "SAO 244134"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.85529529),
        dec: Angle.Degrees(-59.66932214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114024"},
        {"Hipparcos Number", "HIP 64136"},
        {"Geneva Identification System", "GEN# +1.00114024"},
        {"Wilson Evans Batten Catalogue", "WEB 11337"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.16806669),
        dec: Angle.Degrees(-59.66776627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154175"},
        {"Hipparcos Number", "HIP 83794"},
        {"Smithsonian Astrophysical Observation", "SAO 244443"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.87713545),
        dec: Angle.Degrees(-59.66711145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96043"},
        {"Hipparcos Number", "HIP 54062"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.93478082),
        dec: Angle.Degrees(-59.66626427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9379"},
        {"Hipparcos Number", "HIP 7040"},
        {"Geneva Identification System", "GEN# +1.00009379"},
        {"Smithsonian Astrophysical Observation", "SAO 232444"},
        {"Wilson Evans Batten Catalogue", "WEB 1522"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.69189073),
        dec: Angle.Degrees(-59.65937826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106132"},
        {"Hipparcos Number", "HIP 59560"},
        {"Geneva Identification System", "GEN# +1.00106132"},
        {"Smithsonian Astrophysical Observation", "SAO 239757"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.21713305),
        dec: Angle.Degrees(-59.65531297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99312"},
        {"Hipparcos Number", "HIP 55719"},
        {"Geneva Identification System", "GEN# +1.00099312"},
        {"Smithsonian Astrophysical Observation", "SAO 239048"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.25142292),
        dec: Angle.Degrees(-59.65165035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180578"},
        {"Hipparcos Number", "HIP 95065"},
        {"Smithsonian Astrophysical Observation", "SAO 246034"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.13606415),
        dec: Angle.Degrees(-59.64690583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34328"},
        {"Hipparcos Number", "HIP 24316"},
        {"Cincinnati Publication", "Ci 20 324"},
        {"Geneva Identification System", "GEN# +1.00034328"},
        {"Smithsonian Astrophysical Observation", "SAO 233878"},
        {"Wilson Evans Batten Catalogue", "WEB 4716"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.26748077),
        dec: Angle.Degrees(-59.64688139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 935.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 515.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80628"},
        {"Hipparcos Number", "HIP 45654"},
        {"Smithsonian Astrophysical Observation", "SAO 236836"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.58958302),
        dec: Angle.Degrees(-59.64635021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64507"},
        {"Hipparcos Number", "HIP 38310"},
        {"Geneva Identification System", "GEN# +1.00064507"},
        {"Smithsonian Astrophysical Observation", "SAO 235562"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.73680489),
        dec: Angle.Degrees(-59.64624458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78053"},
    },
    visualMagnitude: 11.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.03836282),
        dec: Angle.Degrees(-37.93498523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121011"},
        {"Hipparcos Number", "HIP 67932"},
        {"Geneva Identification System", "GEN# +1.00121011"},
        {"Smithsonian Astrophysical Observation", "SAO 241274"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.67970477),
        dec: Angle.Degrees(-59.64495472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207415"},
        {"Hipparcos Number", "HIP 107842"},
        {"Smithsonian Astrophysical Observation", "SAO 247202"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.72356657),
        dec: Angle.Degrees(-59.64476598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220758"},
        {"Hipparcos Number", "HIP 115736"},
        {"Geneva Identification System", "GEN# +1.00220758"},
        {"Smithsonian Astrophysical Observation", "SAO 247875"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.71258983),
        dec: Angle.Degrees(-59.64430726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132401"},
        {"Hipparcos Number", "HIP 73519"},
        {"Smithsonian Astrophysical Observation", "SAO 242172"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.39898925),
        dec: Angle.Degrees(-59.64393974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -237.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192217"},
        {"Hipparcos Number", "HIP 99970"},
        {"Smithsonian Astrophysical Observation", "SAO 246511"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.23230310),
        dec: Angle.Degrees(-59.64315069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97628"},
        {"Hipparcos Number", "HIP 54809"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.30480526),
        dec: Angle.Degrees(-59.64167022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21089"},
        {"Hipparcos Number", "HIP 15631"},
        {"Geneva Identification System", "GEN# +1.00021089"},
        {"Smithsonian Astrophysical Observation", "SAO 233081"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.32322017),
        dec: Angle.Degrees(-59.63988267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118226"},
        {"Hipparcos Number", "HIP 66415"},
        {"Smithsonian Astrophysical Observation", "SAO 240997"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.24262920),
        dec: Angle.Degrees(-59.63944547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116794"},
        {"Hipparcos Number", "HIP 65617"},
        {"Smithsonian Astrophysical Observation", "SAO 240853"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.80095913),
        dec: Angle.Degrees(-59.63727527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6946"},
        {"Hipparcos Number", "HIP 5381"},
        {"Geneva Identification System", "GEN# +1.00006946"},
        {"Smithsonian Astrophysical Observation", "SAO 232310"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.20859384),
        dec: Angle.Degrees(-59.63721426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89047"},
        {"Hipparcos Number", "HIP 50189"},
        {"Renson", "Renson 25490"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.67784381),
        dec: Angle.Degrees(-59.63690921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209529"},
        {"Hipparcos Number", "HIP 109081"},
        {"Geneva Identification System", "GEN# +1.00209529"},
        {"Smithsonian Astrophysical Observation", "SAO 247303"},
    },
    visualMagnitude: 5.62,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.46229754),
        dec: Angle.Degrees(-59.63594171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70733",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70733"},
        {"Geneva Identification System", "GEN# +2.56060003"},
        {"Smithsonian Astrophysical Observation", "SAO 241730"},
        {"New General Catalogue", "NGC 5606 3"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.98900756),
        dec: Angle.Degrees(-59.63542984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183437"},
        {"Hipparcos Number", "HIP 96157"},
        {"Smithsonian Astrophysical Observation", "SAO 246150"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.27382871),
        dec: Angle.Degrees(-59.63532706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35703"},
        {"Hipparcos Number", "HIP 25140"},
        {"Fundamental Katalog 5th Edition", "FK5 4494"},
        {"Geneva Identification System", "GEN# +1.00035703"},
        {"Smithsonian Astrophysical Observation", "SAO 233956"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.70406369),
        dec: Angle.Degrees(-59.63467762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129558"},
        {"Hipparcos Number", "HIP 72157"},
        {"Smithsonian Astrophysical Observation", "SAO 241974"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.38182265),
        dec: Angle.Degrees(-59.57096802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220496"},
        {"Hipparcos Number", "HIP 115581"},
        {"Smithsonian Astrophysical Observation", "SAO 247861"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.18366876),
        dec: Angle.Degrees(-59.63458297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218272"},
        {"Hipparcos Number", "HIP 114198"},
        {"Geneva Identification System", "GEN# +1.00218272"},
        {"Smithsonian Astrophysical Observation", "SAO 247743"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.90036066),
        dec: Angle.Degrees(-59.63367899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100078"},
        {"Hipparcos Number", "HIP 56137"},
        {"Smithsonian Astrophysical Observation", "SAO 239125"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.60659879),
        dec: Angle.Degrees(-59.62731660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69732"},
        {"Hipparcos Number", "HIP 40418"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.76860550),
        dec: Angle.Degrees(-59.62694495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106982"},
        {"Hipparcos Number", "HIP 60012"},
        {"Geneva Identification System", "GEN# +1.00106982"},
        {"Renson", "Renson 30940"},
        {"Smithsonian Astrophysical Observation", "SAO 239827"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.61116523),
        dec: Angle.Degrees(-59.62541617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70730",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70730"},
        {"Geneva Identification System", "GEN# +2.56060004"},
        {"Smithsonian Astrophysical Observation", "SAO 241728"},
        {"New General Catalogue", "NGC 5606 4"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.98133982),
        dec: Angle.Degrees(-59.62520734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90177"},
        {"Hipparcos Number", "HIP 50843"},
        {"Geneva Identification System", "GEN# +1.00090177"},
        {"Smithsonian Astrophysical Observation", "SAO 238005"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.72436945),
        dec: Angle.Degrees(-59.62455505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121947"},
        {"Hipparcos Number", "HIP 68422"},
        {"Geneva Identification System", "GEN# +1.00121947"},
        {"Smithsonian Astrophysical Observation", "SAO 241364"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.10432759),
        dec: Angle.Degrees(-59.62313580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221475"},
        {"Hipparcos Number", "HIP 116232"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.24529049),
        dec: Angle.Degrees(-59.62079477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97670"},
        {"Hipparcos Number", "HIP 54829"},
        {"Celescope Catalog", "CEL 3857"},
        {"Geneva Identification System", "GEN# +1.00097670"},
        {"Smithsonian Astrophysical Observation", "SAO 238877"},
        {"Wilson Evans Batten Catalogue", "WEB 9892"},
    },
    visualMagnitude: 5.74,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.37829647),
        dec: Angle.Degrees(-59.61931670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115437"},
        {"Hipparcos Number", "HIP 64913"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.57875725),
        dec: Angle.Degrees(-59.61799656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46214"},
        {"Hipparcos Number", "HIP 30803"},
        {"Geneva Identification System", "GEN# +1.00046214"},
        {"Smithsonian Astrophysical Observation", "SAO 234527"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.07558057),
        dec: Angle.Degrees(-59.61786384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168596"},
        {"Hipparcos Number", "HIP 90206"},
        {"Smithsonian Astrophysical Observation", "SAO 245441"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.09752819),
        dec: Angle.Degrees(-59.61613285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61544"},
        {"Hipparcos Number", "HIP 36991"},
        {"Geneva Identification System", "GEN# +1.00061544"},
        {"Smithsonian Astrophysical Observation", "SAO 235352"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.05487201),
        dec: Angle.Degrees(-59.61547295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112830"},
        {"Geneva Identification System", "GEN# +6.20145117"},
    },
    visualMagnitude: 11.77,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.75609816),
        dec: Angle.Degrees(-59.61397614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6232"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.98171045),
        dec: Angle.Degrees(-59.61388349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64784"},
        {"Henry Draper 2", "HD 64784A"},
        {"Hipparcos Number", "HIP 38416"},
        {"Renson", "Renson 17760"},
        {"Smithsonian Astrophysical Observation", "SAO 235582"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.05551622),
        dec: Angle.Degrees(-59.61369091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113211"},
        {"Hipparcos Number", "HIP 63686"},
        {"Geneva Identification System", "GEN# +1.00113211"},
        {"Smithsonian Astrophysical Observation", "SAO 240501"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.76739332),
        dec: Angle.Degrees(-59.60949009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164919"},
        {"Hipparcos Number", "HIP 88763"},
        {"Smithsonian Astrophysical Observation", "SAO 245244"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.81588890),
        dec: Angle.Degrees(-59.60906094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40434"},
        {"Hipparcos Number", "HIP 27964"},
        {"Smithsonian Astrophysical Observation", "SAO 234205"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.73563368),
        dec: Angle.Degrees(-59.60849947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20777"},
        {"Hipparcos Number", "HIP 15346"},
        {"Smithsonian Astrophysical Observation", "SAO 233067"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.46897897),
        dec: Angle.Degrees(-59.60846524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41746"},
        {"Hipparcos Number", "HIP 28665"},
        {"Smithsonian Astrophysical Observation", "SAO 234277"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.78930993),
        dec: Angle.Degrees(-59.60691249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182653"},
        {"Hipparcos Number", "HIP 95799"},
        {"Smithsonian Astrophysical Observation", "SAO 246115"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.29088118),
        dec: Angle.Degrees(-59.60562010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91494"},
        {"Hipparcos Number", "HIP 51596"},
        {"Smithsonian Astrophysical Observation", "SAO 238160"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.09497894),
        dec: Angle.Degrees(-59.60412192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88716"},
        {"Hipparcos Number", "HIP 49975"},
        {"Geneva Identification System", "GEN# +1.00088716"},
        {"Smithsonian Astrophysical Observation", "SAO 237783"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.04291389),
        dec: Angle.Degrees(-59.60306864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113251"},
        {"Hipparcos Number", "HIP 63705"},
        {"Smithsonian Astrophysical Observation", "SAO 240504"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.83085811),
        dec: Angle.Degrees(-59.60111272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92402",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92402"},
        {"Smithsonian Astrophysical Observation", "SAO 245732"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.45281545),
        dec: Angle.Degrees(-59.59938841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197219"},
        {"Hipparcos Number", "HIP 102424"},
        {"Geneva Identification System", "GEN# +1.00197219"},
        {"Smithsonian Astrophysical Observation", "SAO 246714"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.32725247),
        dec: Angle.Degrees(-59.59751976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60149"},
        {"Hipparcos Number", "HIP 36421"},
        {"Smithsonian Astrophysical Observation", "SAO 235241"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.41777139),
        dec: Angle.Degrees(-59.59549767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186113"},
        {"Hipparcos Number", "HIP 97250"},
        {"Smithsonian Astrophysical Observation", "SAO 246252"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.47775720),
        dec: Angle.Degrees(-59.59315394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204640"},
        {"Hipparcos Number", "HIP 106344"},
        {"Smithsonian Astrophysical Observation", "SAO 247070"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.06408630),
        dec: Angle.Degrees(-59.59299458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99435"},
        {"Hipparcos Number", "HIP 55793"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.46132517),
        dec: Angle.Degrees(-59.59280292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103938"},
        {"Hipparcos Number", "HIP 58367"},
        {"Geneva Identification System", "GEN# +1.00103938"},
        {"Smithsonian Astrophysical Observation", "SAO 239531"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.52488886),
        dec: Angle.Degrees(-59.59274983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9468"},
        {"Hipparcos Number", "HIP 7106"},
        {"Geneva Identification System", "GEN# +1.00009468"},
        {"Smithsonian Astrophysical Observation", "SAO 232451"},
        {"Wilson Evans Batten Catalogue", "WEB 1534"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.88993515),
        dec: Angle.Degrees(-59.59256423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46479"},
        {"Hipparcos Number", "HIP 30959"},
        {"Geneva Identification System", "GEN# +1.00046479"},
        {"Smithsonian Astrophysical Observation", "SAO 234549"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.48034026),
        dec: Angle.Degrees(-59.59067571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74922"},
        {"Hipparcos Number", "HIP 42849"},
        {"Celescope Catalog", "CEL 2841"},
        {"Geneva Identification System", "GEN# +1.00074922"},
        {"Smithsonian Astrophysical Observation", "SAO 236229"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.97111815),
        dec: Angle.Degrees(-59.58734099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99049"},
        {"Henry Draper 2", "HD 99050"},
        {"Hipparcos Number", "HIP 55591"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.81787938),
        dec: Angle.Degrees(-59.58713130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110061"},
        {"Hipparcos Number", "HIP 61808"},
        {"Geneva Identification System", "GEN# +1.00110061"},
        {"Smithsonian Astrophysical Observation", "SAO 240126"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.00632352),
        dec: Angle.Degrees(-59.58641889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207753"},
        {"Hipparcos Number", "HIP 108037"},
        {"Smithsonian Astrophysical Observation", "SAO 247216"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.32521627),
        dec: Angle.Degrees(-59.58586738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34395"},
        {"Hipparcos Number", "HIP 24333"},
        {"Smithsonian Astrophysical Observation", "SAO 233883"},
        {"Wilson Evans Batten Catalogue", "WEB 4723"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.32722825),
        dec: Angle.Degrees(-59.58573552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142102"},
        {"Hipparcos Number", "HIP 78013"},
        {"Smithsonian Astrophysical Observation", "SAO 243122"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.94906978),
        dec: Angle.Degrees(-59.58281503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163088"},
        {"Hipparcos Number", "HIP 87963"},
        {"Geneva Identification System", "GEN# +1.00163088"},
        {"Smithsonian Astrophysical Observation", "SAO 245136"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.52758966),
        dec: Angle.Degrees(-59.58034763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25903"},
        {"Hipparcos Number", "HIP 18883"},
        {"Smithsonian Astrophysical Observation", "SAO 233379"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.72439135),
        dec: Angle.Degrees(-59.57951023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81990"},
        {"Hipparcos Number", "HIP 46333"},
        {"Celescope Catalog", "CEL 3302"},
        {"Geneva Identification System", "GEN# +1.00081990"},
        {"Smithsonian Astrophysical Observation", "SAO 236990"},
    },
    visualMagnitude: 6.52,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.69608178),
        dec: Angle.Degrees(-59.57880559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59579"},
        {"Hipparcos Number", "HIP 36169"},
        {"Fundamental Katalog 5th Edition", "FK5 4670"},
        {"Smithsonian Astrophysical Observation", "SAO 235207"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.74967997),
        dec: Angle.Degrees(-59.57871885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43236",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43236"},
        {"Smithsonian Astrophysical Observation", "SAO 236297"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.10920789),
        dec: Angle.Degrees(-59.57380851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13397"},
        {"Smithsonian Astrophysical Observation", "SAO 232927"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.10257922),
        dec: Angle.Degrees(-58.87452630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98614"},
        {"Hipparcos Number", "HIP 55344"},
        {"Celescope Catalog", "CEL 3879"},
        {"Geneva Identification System", "GEN# +1.00098614"},
        {"Smithsonian Astrophysical Observation", "SAO 238976"},
        {"Wilson Evans Batten Catalogue", "WEB 9962"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.00964182),
        dec: Angle.Degrees(-59.57034441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208664"},
        {"Hipparcos Number", "HIP 108584"},
        {"Geneva Identification System", "GEN# +1.00208664"},
        {"Smithsonian Astrophysical Observation", "SAO 247255"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.94889401),
        dec: Angle.Degrees(-59.57002151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16853"},
        {"Hipparcos Number", "HIP 12405"},
        {"Geneva Identification System", "GEN# +1.00016853"},
        {"Smithsonian Astrophysical Observation", "SAO 232852"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.93583811),
        dec: Angle.Degrees(-59.56872007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4804"},
        {"Hipparcos Number", "HIP 3838"},
        {"Smithsonian Astrophysical Observation", "SAO 232198"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.31393468),
        dec: Angle.Degrees(-59.56853640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16852"},
        {"Hipparcos Number", "HIP 12401"},
        {"Smithsonian Astrophysical Observation", "SAO 232851"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.91594603),
        dec: Angle.Degrees(-59.56749273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13897"},
        {"Hipparcos Number", "HIP 10346"},
        {"Smithsonian Astrophysical Observation", "SAO 232677"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.31603957),
        dec: Angle.Degrees(-59.56694570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93250"},
        {"Hipparcos Number", "HIP 52558"},
        {"Celescope Catalog", "CEL 3687"},
        {"Geneva Identification System", "GEN# +4.35140101"},
        {"Geneva Identification System 2", "GEN# +4.35160180"},
        {"Geneva Identification System 3", "GEN# +4.35160101"},
        {"Smithsonian Astrophysical Observation", "SAO 238423"},
        {"Wilson Evans Batten Catalogue", "WEB 9575"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.18764839),
        dec: Angle.Degrees(-59.56519691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92063"},
        {"Hipparcos Number", "HIP 51912"},
        {"Geneva Identification System", "GEN# +1.00092063"},
        {"Smithsonian Astrophysical Observation", "SAO 238242"},
        {"Wilson Evans Batten Catalogue", "WEB 9476"},
    },
    visualMagnitude: 5.08,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.08568462),
        dec: Angle.Degrees(-59.56429542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43247"},
        {"Smithsonian Astrophysical Observation", "SAO 236298"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.15635552),
        dec: Angle.Degrees(-59.56307765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170195"},
        {"Hipparcos Number", "HIP 90841"},
        {"Smithsonian Astrophysical Observation", "SAO 245527"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.98429431),
        dec: Angle.Degrees(-59.56252648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144863"},
        {"Hipparcos Number", "HIP 79318"},
        {"Geneva Identification System", "GEN# +1.00144863"},
        {"Smithsonian Astrophysical Observation", "SAO 243407"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.81806556),
        dec: Angle.Degrees(-59.56227177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133306"},
        {"Hipparcos Number", "HIP 73924"},
        {"Smithsonian Astrophysical Observation", "SAO 242222"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.60310062),
        dec: Angle.Degrees(-59.56176704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99038"},
        {"Hipparcos Number", "HIP 55582"},
        {"Smithsonian Astrophysical Observation", "SAO 239018"},
    },
    visualMagnitude: 9.27,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.78619969),
        dec: Angle.Degrees(-59.56158651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154709"},
        {"Hipparcos Number", "HIP 84030"},
        {"Smithsonian Astrophysical Observation", "SAO 244480"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.66706046),
        dec: Angle.Degrees(-59.56137241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214067"},
        {"Hipparcos Number", "HIP 111648"},
        {"Geneva Identification System", "GEN# +1.00214067"},
        {"Smithsonian Astrophysical Observation", "SAO 247512"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.26675184),
        dec: Angle.Degrees(-59.55949222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -253.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145419"},
        {"Hipparcos Number", "HIP 79575"},
        {"Smithsonian Astrophysical Observation", "SAO 243466"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.53991209),
        dec: Angle.Degrees(-59.55818351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79054"},
        {"Hipparcos Number", "HIP 44924"},
        {"Smithsonian Astrophysical Observation", "SAO 236665"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.26876020),
        dec: Angle.Degrees(-59.55722230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81435"},
        {"Hipparcos Number", "HIP 46014"},
        {"Smithsonian Astrophysical Observation", "SAO 236920"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.76599151),
        dec: Angle.Degrees(-59.55647388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177901"},
        {"Hipparcos Number", "HIP 94171"},
        {"Geneva Identification System", "GEN# +1.00177901"},
        {"Smithsonian Astrophysical Observation", "SAO 245946"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.54663933),
        dec: Angle.Degrees(-59.54838726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74236"},
        {"Hipparcos Number", "HIP 42505"},
        {"Celescope Catalog", "CEL 2767"},
        {"Geneva Identification System", "GEN# +1.00074236"},
        {"Smithsonian Astrophysical Observation", "SAO 236166"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.99661733),
        dec: Angle.Degrees(-59.54692084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207044"},
        {"Hipparcos Number", "HIP 107656"},
        {"Smithsonian Astrophysical Observation", "SAO 247188"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.09572354),
        dec: Angle.Degrees(-59.54659553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6930"},
        {"Hipparcos Number", "HIP 5366"},
        {"Renson", "Renson 1770"},
        {"Smithsonian Astrophysical Observation", "SAO 232308"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.15892295),
        dec: Angle.Degrees(-59.54429482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135917"},
        {"Hipparcos Number", "HIP 75079"},
        {"Geneva Identification System", "GEN# +1.00135917"},
        {"Smithsonian Astrophysical Observation", "SAO 242425"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.13550435),
        dec: Angle.Degrees(-59.54376291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73466"},
        {"Hipparcos Number", "HIP 42158"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.91054115),
        dec: Angle.Degrees(-59.54306920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223967"},
        {"Hipparcos Number", "HIP 117853"},
        {"Renson", "Renson 61360"},
        {"Smithsonian Astrophysical Observation", "SAO 248057"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.55317976),
        dec: Angle.Degrees(-59.54206075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107820"},
        {"Hipparcos Number", "HIP 60447"},
        {"Geneva Identification System", "GEN# +1.00107820"},
        {"Smithsonian Astrophysical Observation", "SAO 239911"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.89494936),
        dec: Angle.Degrees(-59.54173703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68518"},
        {"Hipparcos Number", "HIP 39949"},
        {"Geneva Identification System", "GEN# +1.00068518"},
        {"Smithsonian Astrophysical Observation", "SAO 235786"},
    },
    visualMagnitude: 6.60,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.37730302),
        dec: Angle.Degrees(-59.54159838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42286"},
        {"Hipparcos Number", "HIP 28898"},
        {"Geneva Identification System", "GEN# +1.00042286"},
        {"Smithsonian Astrophysical Observation", "SAO 234311"},
        {"Wilson Evans Batten Catalogue", "WEB 5658"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.51568173),
        dec: Angle.Degrees(-59.54137568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -742.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108889"},
        {"Hipparcos Number", "HIP 61079"},
        {"Geneva Identification System", "GEN# +1.00108889"},
        {"Smithsonian Astrophysical Observation", "SAO 240017"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.77192321),
        dec: Angle.Degrees(-59.54074081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189836"},
        {"Hipparcos Number", "HIP 98941"},
        {"Smithsonian Astrophysical Observation", "SAO 246422"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.33101372),
        dec: Angle.Degrees(-59.54054091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25902"},
        {"Hipparcos Number", "HIP 18881"},
        {"Smithsonian Astrophysical Observation", "SAO 233378"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.72183595),
        dec: Angle.Degrees(-59.53384665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224290"},
        {"Hipparcos Number", "HIP 118043"},
        {"Smithsonian Astrophysical Observation", "SAO 248072"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.15382463),
        dec: Angle.Degrees(-59.53275872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224584"},
        {"Hipparcos Number", "HIP 118246"},
        {"Smithsonian Astrophysical Observation", "SAO 248088"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.76143463),
        dec: Angle.Degrees(-59.53015147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74681"},
        {"Hipparcos Number", "HIP 42729"},
        {"Celescope Catalog", "CEL 2814"},
        {"Geneva Identification System", "GEN# +1.00074681J"},
        {"Smithsonian Astrophysical Observation", "SAO 236210"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.62176193),
        dec: Angle.Degrees(-59.52733658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19333",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19333"},
        {"Smithsonian Astrophysical Observation", "SAO 233415"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.14922867),
        dec: Angle.Degrees(-59.52653074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188303"},
        {"Hipparcos Number", "HIP 98240"},
        {"Smithsonian Astrophysical Observation", "SAO 246352"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.46094238),
        dec: Angle.Degrees(-59.52581874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216024"},
        {"Hipparcos Number", "HIP 112791"},
        {"Geneva Identification System", "GEN# +1.00216024"},
        {"Smithsonian Astrophysical Observation", "SAO 247610"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.61772789),
        dec: Angle.Degrees(-59.52553461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113278"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.07601241),
        dec: Angle.Degrees(-59.52481686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220402"},
        {"Hipparcos Number", "HIP 115517"},
        {"Smithsonian Astrophysical Observation", "SAO 247855"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.00362165),
        dec: Angle.Degrees(-59.52261587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94877"},
        {"Hipparcos Number", "HIP 53448"},
        {"Geneva Identification System", "GEN# +1.00094877"},
        {"Smithsonian Astrophysical Observation", "SAO 238607"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.00489297),
        dec: Angle.Degrees(-59.52225265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42918"},
        {"Hipparcos Number", "HIP 29213"},
        {"Smithsonian Astrophysical Observation", "SAO 234356"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.40772873),
        dec: Angle.Degrees(-59.52217283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166202"},
        {"Hipparcos Number", "HIP 89304"},
        {"Renson", "Renson 46800"},
        {"Smithsonian Astrophysical Observation", "SAO 245317"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.33833413),
        dec: Angle.Degrees(-59.51818778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160602"},
        {"Hipparcos Number", "HIP 86834"},
        {"Geneva Identification System", "GEN# +1.00160602"},
        {"Smithsonian Astrophysical Observation", "SAO 244980"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.14719658),
        dec: Angle.Degrees(-59.51709536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217767"},
        {"Hipparcos Number", "HIP 113885"},
        {"Geneva Identification System", "GEN# +1.00217767"},
        {"Smithsonian Astrophysical Observation", "SAO 247703"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.96408408),
        dec: Angle.Degrees(-59.51636995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106067"},
        {"Hipparcos Number", "HIP 59515"},
        {"Smithsonian Astrophysical Observation", "SAO 239749"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.08798691),
        dec: Angle.Degrees(-59.51567468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100262"},
        {"Hipparcos Number", "HIP 56250"},
        {"Fundamental Katalog 5th Edition", "FK5 2920"},
        {"Geneva Identification System", "GEN# +1.00100262"},
        {"Smithsonian Astrophysical Observation", "SAO 239146"},
        {"Wilson Evans Batten Catalogue", "WEB 10108"},
    },
    visualMagnitude: 5.12,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.95336415),
        dec: Angle.Degrees(-59.51564932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3751"},
        {"Hipparcos Number", "HIP 3110"},
        {"Smithsonian Astrophysical Observation", "SAO 232136"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.90207860),
        dec: Angle.Degrees(-59.51356220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20485"},
        {"Hipparcos Number", "HIP 15108"},
        {"Smithsonian Astrophysical Observation", "SAO 233050"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.72093405),
        dec: Angle.Degrees(-59.51350902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90313"},
        {"Hipparcos Number", "HIP 50919"},
        {"Geneva Identification System", "GEN# +1.00090313"},
        {"Smithsonian Astrophysical Observation", "SAO 238025"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.97907462),
        dec: Angle.Degrees(-59.51330241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94546"},
        {"Hipparcos Number", "HIP 53274"},
        {"Geneva Identification System", "GEN# +1.00094546"},
        {"Wilson Evans Batten Catalogue", "WEB 9676"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.43677231),
        dec: Angle.Degrees(-59.51297006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117854"},
        {"Hipparcos Number", "HIP 66230"},
        {"Geneva Identification System", "GEN# +1.00117854"},
        {"Smithsonian Astrophysical Observation", "SAO 240951"},
        {"Wilson Evans Batten Catalogue", "WEB 11702"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.60720975),
        dec: Angle.Degrees(-59.51189167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -277.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123042"},
        {"Hipparcos Number", "HIP 68978"},
        {"Geneva Identification System", "GEN# +1.00123042"},
        {"Smithsonian Astrophysical Observation", "SAO 241455"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.83009916),
        dec: Angle.Degrees(-59.51157643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117812"},
        {"Hipparcos Number", "HIP 66210"},
        {"Smithsonian Astrophysical Observation", "SAO 240949"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.55648499),
        dec: Angle.Degrees(-59.51095427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41037",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Avior"},
        {"Hipparcos Number", "HIP 41037"},
        {"Fundamental Katalog 5th Edition", "FK5 315"},
        {"Geneva Identification System", "GEN# +1.00071129"},
        {"Smithsonian Astrophysical Observation", "SAO 235932"},
    },
    visualMagnitude: 1.86,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.62860299),
        dec: Angle.Degrees(-59.50953829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205595"},
        {"Hipparcos Number", "HIP 106858"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.64013433),
        dec: Angle.Degrees(-59.50855519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 858"},
        {"Hipparcos Number", "HIP 1016"},
        {"Smithsonian Astrophysical Observation", "SAO 231972"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.16511126),
        dec: Angle.Degrees(-59.50786377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109667"},
        {"Hipparcos Number", "HIP 61569"},
        {"Celescope Catalog", "CEL 4130"},
        {"Geneva Identification System", "GEN# +1.00109667"},
        {"Smithsonian Astrophysical Observation", "SAO 240090"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.23315014),
        dec: Angle.Degrees(-59.50756196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63256"},
        {"Hipparcos Number", "HIP 37753"},
        {"Smithsonian Astrophysical Observation", "SAO 235479"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.14460997),
        dec: Angle.Degrees(-59.50573199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130576"},
        {"Hipparcos Number", "HIP 72655"},
        {"Smithsonian Astrophysical Observation", "SAO 242063"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.84038768),
        dec: Angle.Degrees(-59.50349744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147747"},
        {"Hipparcos Number", "HIP 80577"},
        {"Smithsonian Astrophysical Observation", "SAO 243808"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.77850648),
        dec: Angle.Degrees(-59.50093122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8787"},
        {"Hipparcos Number", "HIP 6651"},
        {"Geneva Identification System", "GEN# +1.00008787"},
        {"Smithsonian Astrophysical Observation", "SAO 232418"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.33265698),
        dec: Angle.Degrees(-59.49868169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193383"},
        {"Hipparcos Number", "HIP 100521"},
        {"Smithsonian Astrophysical Observation", "SAO 246551"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.74818847),
        dec: Angle.Degrees(-59.49808090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37729"},
        {"Hipparcos Number", "HIP 26378"},
        {"Smithsonian Astrophysical Observation", "SAO 234053"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.25517519),
        dec: Angle.Degrees(-59.49669791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210727"},
        {"Hipparcos Number", "HIP 109774"},
        {"Smithsonian Astrophysical Observation", "SAO 247364"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.52042817),
        dec: Angle.Degrees(-59.49486410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112308"},
        {"Hipparcos Number", "HIP 63166"},
        {"Geneva Identification System", "GEN# +1.00112308"},
        {"Smithsonian Astrophysical Observation", "SAO 240391"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.13402278),
        dec: Angle.Degrees(-59.49414591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64831"},
        {"Hipparcos Number", "HIP 38433"},
        {"Smithsonian Astrophysical Observation", "SAO 235585"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.09281476),
        dec: Angle.Degrees(-59.49313898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181462"},
        {"Hipparcos Number", "HIP 95361"},
        {"Smithsonian Astrophysical Observation", "SAO 246066"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.01122700),
        dec: Angle.Degrees(-59.49306874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122878"},
        {"Hipparcos Number", "HIP 68897"},
        {"Smithsonian Astrophysical Observation", "SAO 241437"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.59985834),
        dec: Angle.Degrees(-59.49261827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6652"},
        {"Smithsonian Astrophysical Observation", "SAO 232417"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.33275700),
        dec: Angle.Degrees(-59.49165834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221998"},
        {"Hipparcos Number", "HIP 116557"},
        {"Geneva Identification System", "GEN# +1.00221998"},
        {"Smithsonian Astrophysical Observation", "SAO 247951"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.31901972),
        dec: Angle.Degrees(-59.49035046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105472"},
        {"Hipparcos Number", "HIP 59213"},
        {"Geneva Identification System", "GEN# +1.00105472"},
        {"Smithsonian Astrophysical Observation", "SAO 239693"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.15661418),
        dec: Angle.Degrees(-59.48808062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209897"},
        {"Hipparcos Number", "HIP 109291"},
        {"Smithsonian Astrophysical Observation", "SAO 247320"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.11062881),
        dec: Angle.Degrees(-59.48791550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82244"},
        {"Hipparcos Number", "HIP 46461"},
        {"Geneva Identification System", "GEN# +1.00082244"},
        {"Smithsonian Astrophysical Observation", "SAO 237019"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.12977679),
        dec: Angle.Degrees(-59.48763507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174786"},
        {"Hipparcos Number", "HIP 92924"},
        {"Smithsonian Astrophysical Observation", "SAO 245808"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.98640633),
        dec: Angle.Degrees(-59.48431524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76092"},
        {"Hipparcos Number", "HIP 43467"},
        {"Smithsonian Astrophysical Observation", "SAO 236333"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.81187682),
        dec: Angle.Degrees(-59.48375132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33615"},
        {"Hipparcos Number", "HIP 23863"},
        {"Smithsonian Astrophysical Observation", "SAO 233838"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.93092877),
        dec: Angle.Degrees(-59.48374773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80883"},
        {"Hipparcos Number", "HIP 45749"},
        {"Geneva Identification System", "GEN# +1.00080883"},
        {"Smithsonian Astrophysical Observation", "SAO 236856"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.93424255),
        dec: Angle.Degrees(-59.47751731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13629"},
        {"Hipparcos Number", "HIP 10177"},
        {"Smithsonian Astrophysical Observation", "SAO 232664"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.72122404),
        dec: Angle.Degrees(-59.47747461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84759"},
        {"Hipparcos Number", "HIP 47850"},
        {"Smithsonian Astrophysical Observation", "SAO 237307"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.30314472),
        dec: Angle.Degrees(-59.47588474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208262"},
        {"Hipparcos Number", "HIP 108344"},
        {"Smithsonian Astrophysical Observation", "SAO 247238"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.25861507),
        dec: Angle.Degrees(-59.47459392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 191.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150359"},
        {"Hipparcos Number", "HIP 81930"},
        {"Smithsonian Astrophysical Observation", "SAO 244093"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.01970681),
        dec: Angle.Degrees(-59.47430850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115600"},
        {"Hipparcos Number", "HIP 64995"},
        {"Geneva Identification System", "GEN# +1.00115600"},
        {"Smithsonian Astrophysical Observation", "SAO 240737"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.83157742),
        dec: Angle.Degrees(-59.47230026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77387"},
        {"Hipparcos Number", "HIP 44150"},
        {"Geneva Identification System", "GEN# +1.00077387"},
        {"Smithsonian Astrophysical Observation", "SAO 236479"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.86936742),
        dec: Angle.Degrees(-59.47201622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175819"},
        {"Hipparcos Number", "HIP 93344"},
        {"Smithsonian Astrophysical Observation", "SAO 245858"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.19073942),
        dec: Angle.Degrees(-59.46933980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85530"},
        {"Hipparcos Number", "HIP 48260"},
        {"Fundamental Katalog 5th Edition", "FK5 4874"},
        {"Geneva Identification System", "GEN# +1.00085530"},
        {"Smithsonian Astrophysical Observation", "SAO 237398"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.57451126),
        dec: Angle.Degrees(-59.46668157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42764"},
        {"Hipparcos Number", "HIP 29141"},
        {"Smithsonian Astrophysical Observation", "SAO 234348"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.20021330),
        dec: Angle.Degrees(-59.46573607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122450"},
        {"Hipparcos Number", "HIP 68704"},
        {"Geneva Identification System", "GEN# +1.00122450"},
        {"Smithsonian Astrophysical Observation", "SAO 241405"},
        {"Wilson Evans Batten Catalogue", "WEB 12026"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.96527212),
        dec: Angle.Degrees(-59.46310721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217505"},
        {"Hipparcos Number", "HIP 113735"},
        {"Geneva Identification System", "GEN# +1.00217505"},
        {"Smithsonian Astrophysical Observation", "SAO 247688"},
    },
    visualMagnitude: 9.15,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.51025375),
        dec: Angle.Degrees(-59.46288458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3823"},
        {"Hipparcos Number", "HIP 3170"},
        {"Cincinnati Publication", "Ci 20 46"},
        {"Geneva Identification System", "GEN# +1.00003823"},
        {"Smithsonian Astrophysical Observation", "SAO 232143"},
        {"Wilson Evans Batten Catalogue", "WEB 567"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.10273354),
        dec: Angle.Degrees(-59.45568115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 883.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 443.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153927"},
        {"Hipparcos Number", "HIP 83661"},
        {"Smithsonian Astrophysical Observation", "SAO 244427"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.49266741),
        dec: Angle.Degrees(-59.45567512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189158"},
        {"Hipparcos Number", "HIP 98629"},
        {"Smithsonian Astrophysical Observation", "SAO 246391"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.48102826),
        dec: Angle.Degrees(-59.44787451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130246"},
        {"Hipparcos Number", "HIP 72497"},
        {"Smithsonian Astrophysical Observation", "SAO 242030"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.35589830),
        dec: Angle.Degrees(-59.44651568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3438"},
        {"Hipparcos Number", "HIP 2898"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.18348414),
        dec: Angle.Degrees(-59.44643083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196685"},
        {"Hipparcos Number", "HIP 102145"},
        {"Smithsonian Astrophysical Observation", "SAO 246694"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.46653636),
        dec: Angle.Degrees(-59.44515427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113740"},
        {"Hipparcos Number", "HIP 63990"},
        {"Geneva Identification System", "GEN# +1.00113740"},
        {"Smithsonian Astrophysical Observation", "SAO 240556"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.69806136),
        dec: Angle.Degrees(-59.44396125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100261"},
        {"Hipparcos Number", "HIP 56243"},
        {"Geneva Identification System", "GEN# +1.00100261A"},
        {"Smithsonian Astrophysical Observation", "SAO 239145"},
        {"Wilson Evans Batten Catalogue", "WEB 10107"},
    },
    visualMagnitude: 5.07,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.94197140),
        dec: Angle.Degrees(-59.44206384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115716"},
        {"Hipparcos Number", "HIP 65058"},
        {"Smithsonian Astrophysical Observation", "SAO 240749"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.03380124),
        dec: Angle.Degrees(-59.44102985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156335"},
        {"Hipparcos Number", "HIP 84859"},
        {"Smithsonian Astrophysical Observation", "SAO 244638"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.15461891),
        dec: Angle.Degrees(-59.44044206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68036"},
        {"Hipparcos Number", "HIP 39746"},
        {"Smithsonian Astrophysical Observation", "SAO 235760"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.85279293),
        dec: Angle.Degrees(-59.43802118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99546"},
        {"Hipparcos Number", "HIP 55833"},
        {"Celescope Catalog", "CEL 3901"},
        {"Geneva Identification System", "GEN# +1.00099546"},
        {"Smithsonian Astrophysical Observation", "SAO 239071"},
        {"Wilson Evans Batten Catalogue", "WEB 10035"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.65379913),
        dec: Angle.Degrees(-59.43711396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220986"},
        {"Hipparcos Number", "HIP 115893"},
        {"Smithsonian Astrophysical Observation", "SAO 247893"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.20485273),
        dec: Angle.Degrees(-59.43658979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155539"},
        {"Hipparcos Number", "HIP 84447"},
        {"Smithsonian Astrophysical Observation", "SAO 244558"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.97129319),
        dec: Angle.Degrees(-59.43654083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71826"},
        {"Hipparcos Number", "HIP 41371"},
        {"Smithsonian Astrophysical Observation", "SAO 235980"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.59852800),
        dec: Angle.Degrees(-59.43604588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159328"},
        {"Hipparcos Number", "HIP 86290"},
        {"Smithsonian Astrophysical Observation", "SAO 244892"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.47715246),
        dec: Angle.Degrees(-59.43291552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100927"},
        {"Hipparcos Number", "HIP 56609"},
        {"Smithsonian Astrophysical Observation", "SAO 239215"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.10138922),
        dec: Angle.Degrees(-59.43143547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172081"},
        {"Hipparcos Number", "HIP 91688"},
        {"Geneva Identification System", "GEN# +1.00172081"},
        {"Smithsonian Astrophysical Observation", "SAO 245636"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.46252690),
        dec: Angle.Degrees(-59.43021813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85655"},
        {"Hipparcos Number", "HIP 48339"},
        {"Fundamental Katalog 5th Edition", "FK5 2789"},
        {"Geneva Identification System", "GEN# +1.00085655"},
        {"Smithsonian Astrophysical Observation", "SAO 237418"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.80013966),
        dec: Angle.Degrees(-59.42567316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76842"},
        {"Hipparcos Number", "HIP 43848"},
        {"Smithsonian Astrophysical Observation", "SAO 236414"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.96736219),
        dec: Angle.Degrees(-59.42468192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39611",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39611"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.41690208),
        dec: Angle.Degrees(-59.42404958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108968"},
        {"Hipparcos Number", "HIP 61136"},
        {"Geneva Identification System", "GEN# +1.00108968"},
        {"Smithsonian Astrophysical Observation", "SAO 240027"},
        {"Wilson Evans Batten Catalogue", "WEB 10885"},
    },
    visualMagnitude: 5.49,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.91810373),
        dec: Angle.Degrees(-59.42391403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40707"},
        {"Hipparcos Number", "HIP 28134"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.19996603),
        dec: Angle.Degrees(-59.42265923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207526"},
        {"Hipparcos Number", "HIP 107888"},
        {"Smithsonian Astrophysical Observation", "SAO 247205"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.89284452),
        dec: Angle.Degrees(-59.42137465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134260"},
        {"Hipparcos Number", "HIP 74339"},
        {"Smithsonian Astrophysical Observation", "SAO 242290"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.89885379),
        dec: Angle.Degrees(-59.42073303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106109"},
        {"Hipparcos Number", "HIP 59544"},
        {"Smithsonian Astrophysical Observation", "SAO 239754"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.16906124),
        dec: Angle.Degrees(-59.41987967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222898"},
        {"Hipparcos Number", "HIP 117147"},
        {"Smithsonian Astrophysical Observation", "SAO 248003"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.24237856),
        dec: Angle.Degrees(-59.41857154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 401.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152237"},
        {"Hipparcos Number", "HIP 82837"},
        {"Geneva Identification System", "GEN# +1.00152237"},
        {"Smithsonian Astrophysical Observation", "SAO 244272"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.92767205),
        dec: Angle.Degrees(-59.41733489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142305"},
        {"Hipparcos Number", "HIP 78111"},
        {"Smithsonian Astrophysical Observation", "SAO 243140"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.24513737),
        dec: Angle.Degrees(-59.41693719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24838"},
        {"Hipparcos Number", "HIP 18211"},
        {"Geneva Identification System", "GEN# +1.00024838"},
        {"Smithsonian Astrophysical Observation", "SAO 233316"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.41077559),
        dec: Angle.Degrees(-59.41621777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79698"},
        {"Hipparcos Number", "HIP 45219"},
        {"Geneva Identification System", "GEN# +1.00079698"},
        {"Smithsonian Astrophysical Observation", "SAO 236723"},
        {"Wilson Evans Batten Catalogue", "WEB 8621"},
    },
    visualMagnitude: 5.54,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.23176998),
        dec: Angle.Degrees(-59.41396656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127995"},
        {"Hipparcos Number", "HIP 71456"},
        {"Smithsonian Astrophysical Observation", "SAO 241838"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.19325952),
        dec: Angle.Degrees(-59.41340051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 303310"},
        {"Hipparcos Number", "HIP 52562"},
        {"Smithsonian Astrophysical Observation", "SAO 238424"},
    },
    visualMagnitude: 8.56,
    bvColour: 2.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.19648645),
        dec: Angle.Degrees(-59.41337477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11702"},
        {"Hipparcos Number", "HIP 8799"},
        {"Smithsonian Astrophysical Observation", "SAO 232560"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.28155837),
        dec: Angle.Degrees(-59.41278466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96880"},
        {"Hipparcos Number", "HIP 54448"},
        {"Geneva Identification System", "GEN# +1.00096880"},
        {"Smithsonian Astrophysical Observation", "SAO 238809"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.10233546),
        dec: Angle.Degrees(-59.41261388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27894"},
        {"Hipparcos Number", "HIP 20277"},
        {"Geneva Identification System", "GEN# +1.00027894"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.19515966),
        dec: Angle.Degrees(-59.41149907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 272.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216975"},
        {"Hipparcos Number", "HIP 113429"},
        {"Smithsonian Astrophysical Observation", "SAO 247660"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.58749127),
        dec: Angle.Degrees(-59.40831469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93403"},
        {"Hipparcos Number", "HIP 52628"},
        {"Celescope Catalog", "CEL 3691"},
        {"Geneva Identification System", "GEN# +1.00093403"},
        {"Smithsonian Astrophysical Observation", "SAO 238445"},
        {"Wilson Evans Batten Catalogue", "WEB 9585"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.43386515),
        dec: Angle.Degrees(-59.40782336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201172"},
        {"Hipparcos Number", "HIP 104525"},
        {"Geneva Identification System", "GEN# +1.00201172"},
        {"Smithsonian Astrophysical Observation", "SAO 246893"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.60209665),
        dec: Angle.Degrees(-59.40771450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130206"},
        {"Henry Draper 2", "HD 130205"},
        {"Hipparcos Number", "HIP 72482"},
        {"Geneva Identification System", "GEN# +1.00130205J"},
        {"Smithsonian Astrophysical Observation", "SAO 242025"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.31221001),
        dec: Angle.Degrees(-59.40733710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204478"},
        {"Hipparcos Number", "HIP 106246"},
        {"Smithsonian Astrophysical Observation", "SAO 247057"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.79173984),
        dec: Angle.Degrees(-59.40674584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117255"},
        {"Hipparcos Number", "HIP 65895"},
        {"Geneva Identification System", "GEN# +1.00117255"},
        {"Smithsonian Astrophysical Observation", "SAO 240898"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.61578835),
        dec: Angle.Degrees(-59.40603344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219024"},
        {"Hipparcos Number", "HIP 114646"},
        {"Geneva Identification System", "GEN# +1.00219024"},
        {"Smithsonian Astrophysical Observation", "SAO 247782"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.37334718),
        dec: Angle.Degrees(-59.40556134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166913"},
        {"Hipparcos Number", "HIP 89554"},
        {"Geneva Identification System", "GEN# +1.00166913"},
        {"Smithsonian Astrophysical Observation", "SAO 245358"},
        {"Wilson Evans Batten Catalogue", "WEB 15250"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.10825155),
        dec: Angle.Degrees(-59.40281518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -259.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
