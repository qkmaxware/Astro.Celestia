using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_28() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18149"},
        {"Hipparcos Number", "HIP 13473"},
        {"Fundamental Katalog 5th Edition", "FK5 2200"},
        {"Geneva Identification System", "GEN# +1.00018149"},
        {"Smithsonian Astrophysical Observation", "SAO 193965"},
        {"Wilson Evans Batten Catalogue", "WEB 2692"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.39313847),
        dec: Angle.Degrees(-38.43708698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49003"},
        {"Hipparcos Number", "HIP 32301"},
        {"Smithsonian Astrophysical Observation", "SAO 197159"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.15605002),
        dec: Angle.Degrees(-38.43675252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152002"},
        {"Hipparcos Number", "HIP 82561"},
        {"Geneva Identification System", "GEN# +1.00152002"},
        {"Smithsonian Astrophysical Observation", "SAO 208121"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.13472310),
        dec: Angle.Degrees(-38.43609754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211586"},
        {"Hipparcos Number", "HIP 110164"},
        {"Smithsonian Astrophysical Observation", "SAO 213724"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.71351123),
        dec: Angle.Degrees(-38.43369810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217777"},
        {"Hipparcos Number", "HIP 113861"},
        {"Smithsonian Astrophysical Observation", "SAO 214273"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.87415303),
        dec: Angle.Degrees(-38.43344264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152767"},
        {"Hipparcos Number", "HIP 82943"},
        {"Smithsonian Astrophysical Observation", "SAO 208225"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.24875800),
        dec: Angle.Degrees(-38.43334165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178557"},
        {"Hipparcos Number", "HIP 94203"},
        {"Smithsonian Astrophysical Observation", "SAO 211012"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.67549183),
        dec: Angle.Degrees(-38.43331310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213926"},
        {"Hipparcos Number", "HIP 111507"},
        {"Smithsonian Astrophysical Observation", "SAO 213932"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.86800869),
        dec: Angle.Degrees(-38.43298790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123583"},
        {"Hipparcos Number", "HIP 69162"},
        {"Smithsonian Astrophysical Observation", "SAO 205241"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.36192416),
        dec: Angle.Degrees(-38.43272164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9339"},
        {"Hipparcos Number", "HIP 7087"},
        {"Smithsonian Astrophysical Observation", "SAO 193159"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.82028268),
        dec: Angle.Degrees(-38.42959770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27426"},
        {"Hipparcos Number", "HIP 20048"},
        {"Geneva Identification System", "GEN# +1.00027426"},
        {"Smithsonian Astrophysical Observation", "SAO 194906"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.49315565),
        dec: Angle.Degrees(-38.42889449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22662"},
        {"Hipparcos Number", "HIP 16878"},
        {"Smithsonian Astrophysical Observation", "SAO 194407"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.29315478),
        dec: Angle.Degrees(-38.42431087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97146"},
        {"Hipparcos Number", "HIP 54600"},
        {"Smithsonian Astrophysical Observation", "SAO 202163"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.62259799),
        dec: Angle.Degrees(-38.42376631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52898"},
        {"Hipparcos Number", "HIP 33811"},
        {"Geneva Identification System", "GEN# +1.00052898"},
        {"Smithsonian Astrophysical Observation", "SAO 197485"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.29308849),
        dec: Angle.Degrees(-38.42336869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195387"},
        {"Hipparcos Number", "HIP 101342"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.09413673),
        dec: Angle.Degrees(-38.42242403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4211"},
        {"Hipparcos Number", "HIP 3456"},
        {"Fundamental Katalog 5th Edition", "FK5 26"},
        {"Geneva Identification System", "GEN# +1.00004211"},
        {"Smithsonian Astrophysical Observation", "SAO 192703"},
        {"Wilson Evans Batten Catalogue", "WEB 612"},
    },
    visualMagnitude: 5.90,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.04964742),
        dec: Angle.Degrees(-38.42197898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 247.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64975"},
        {"Hipparcos Number", "HIP 38654"},
        {"Smithsonian Astrophysical Observation", "SAO 198588"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.71936034),
        dec: Angle.Degrees(-38.41998185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77366"},
        {"Hipparcos Number", "HIP 44251"},
        {"Geneva Identification System", "GEN# +1.00077366"},
        {"Smithsonian Astrophysical Observation", "SAO 199881"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.17530485),
        dec: Angle.Degrees(-38.41949574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116430"},
        {"Smithsonian Astrophysical Observation", "SAO 214638"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.89879473),
        dec: Angle.Degrees(-38.41819640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189469"},
        {"Hipparcos Number", "HIP 98598"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.40637436),
        dec: Angle.Degrees(-38.41729448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170282"},
        {"Hipparcos Number", "HIP 90694"},
        {"Wilson Evans Batten Catalogue", "WEB 15534"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.56325282),
        dec: Angle.Degrees(-38.41694502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16257"},
        {"Smithsonian Astrophysical Observation", "SAO 194335"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.38318789),
        dec: Angle.Degrees(-38.41664080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82414"},
        {"Hipparcos Number", "HIP 46658"},
        {"Smithsonian Astrophysical Observation", "SAO 200448"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.69436586),
        dec: Angle.Degrees(-38.41506834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152456"},
        {"Hipparcos Number", "HIP 82786"},
        {"Geneva Identification System", "GEN# +1.00152456"},
        {"Renson", "Renson 43160"},
        {"Smithsonian Astrophysical Observation", "SAO 208182"},
    },
    visualMagnitude: 7.25,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.77555010),
        dec: Angle.Degrees(-38.41318850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40394"},
        {"Smithsonian Astrophysical Observation", "SAO 198990"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.70935733),
        dec: Angle.Degrees(-38.41270713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213299"},
        {"Hipparcos Number", "HIP 111144"},
        {"Smithsonian Astrophysical Observation", "SAO 213877"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.76449321),
        dec: Angle.Degrees(-38.41255746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209619"},
        {"Hipparcos Number", "HIP 109061"},
        {"Smithsonian Astrophysical Observation", "SAO 213535"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.40228658),
        dec: Angle.Degrees(-38.41208436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166810"},
        {"Hipparcos Number", "HIP 89361"},
        {"Smithsonian Astrophysical Observation", "SAO 209880"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.52899305),
        dec: Angle.Degrees(-38.41195204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155133"},
        {"Hipparcos Number", "HIP 84087"},
        {"Smithsonian Astrophysical Observation", "SAO 208505"},
    },
    visualMagnitude: 9.39,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.85831448),
        dec: Angle.Degrees(-38.41164549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208322"},
        {"Hipparcos Number", "HIP 108302"},
        {"Smithsonian Astrophysical Observation", "SAO 213415"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.11457725),
        dec: Angle.Degrees(-38.41160554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181132"},
        {"Hipparcos Number", "HIP 95103"},
        {"Smithsonian Astrophysical Observation", "SAO 211196"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.21514526),
        dec: Angle.Degrees(-38.41090236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84084",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84084"},
    },
    visualMagnitude: 12.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.85253534),
        dec: Angle.Degrees(-38.40958029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85804"},
        {"Hipparcos Number", "HIP 48493"},
        {"Geneva Identification System", "GEN# +1.00085804"},
        {"Smithsonian Astrophysical Observation", "SAO 200841"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.34554169),
        dec: Angle.Degrees(-38.40896556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89459"},
        {"Hipparcos Number", "HIP 50497"},
        {"Smithsonian Astrophysical Observation", "SAO 201268"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.67230975),
        dec: Angle.Degrees(-38.40872699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96701"},
        {"Hipparcos Number", "HIP 54395"},
        {"Smithsonian Astrophysical Observation", "SAO 202115"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.96591064),
        dec: Angle.Degrees(-38.40741902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184440"},
        {"Hipparcos Number", "HIP 96404"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.00410455),
        dec: Angle.Degrees(-38.40455871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76438"},
        {"Hipparcos Number", "HIP 43758"},
        {"Smithsonian Astrophysical Observation", "SAO 199779"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.70623922),
        dec: Angle.Degrees(-38.40454079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116213"},
        {"Hipparcos Number", "HIP 65281"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.68801826),
        dec: Angle.Degrees(-38.40427764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82165"},
        {"Hipparcos Number", "HIP 46517"},
        {"Geneva Identification System", "GEN# +1.00082165"},
        {"Smithsonian Astrophysical Observation", "SAO 200419"},
        {"Wilson Evans Batten Catalogue", "WEB 8780"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.31771878),
        dec: Angle.Degrees(-38.40354893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11262"},
        {"Hipparcos Number", "HIP 8514"},
        {"Geneva Identification System", "GEN# +1.00011262"},
        {"Smithsonian Astrophysical Observation", "SAO 193326"},
        {"Wilson Evans Batten Catalogue", "WEB 1809"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.45359409),
        dec: Angle.Degrees(-38.40348295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 282.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202611"},
        {"Hipparcos Number", "HIP 105157"},
        {"Smithsonian Astrophysical Observation", "SAO 212875"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.52595389),
        dec: Angle.Degrees(-38.40285942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187538"},
        {"Hipparcos Number", "HIP 97754"},
        {"Smithsonian Astrophysical Observation", "SAO 211611"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.99363313),
        dec: Angle.Degrees(-38.40228121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95925"},
        {"Hipparcos Number", "HIP 54043"},
        {"Geneva Identification System", "GEN# +1.00095925"},
        {"Smithsonian Astrophysical Observation", "SAO 202044"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.88230625),
        dec: Angle.Degrees(-38.40057324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98126"},
        {"Hipparcos Number", "HIP 55100"},
        {"Fundamental Katalog 5th Edition", "FK5 2901"},
        {"Smithsonian Astrophysical Observation", "SAO 202276"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.22135038),
        dec: Angle.Degrees(-38.39880398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48543"},
        {"Hipparcos Number", "HIP 32091"},
        {"Geneva Identification System", "GEN# +1.00048543J"},
        {"Smithsonian Astrophysical Observation", "SAO 197108"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.56829883),
        dec: Angle.Degrees(-38.39879925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117597"},
        {"Hipparcos Number", "HIP 66019"},
        {"Geneva Identification System", "GEN# +1.00117597"},
        {"Smithsonian Astrophysical Observation", "SAO 204561"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.02245004),
        dec: Angle.Degrees(-38.39875387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94002"},
        {"Hipparcos Number", "HIP 53001"},
        {"Smithsonian Astrophysical Observation", "SAO 201815"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.63264805),
        dec: Angle.Degrees(-38.39796491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42611",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42611"},
        {"Smithsonian Astrophysical Observation", "SAO 199503"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.26656491),
        dec: Angle.Degrees(-38.39774627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121539"},
        {"Hipparcos Number", "HIP 68128"},
        {"Smithsonian Astrophysical Observation", "SAO 205017"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.20939427),
        dec: Angle.Degrees(-38.39729342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143118"},
        {"Hipparcos Number", "HIP 78384"},
        {"Geneva Identification System", "GEN# +1.00143118J"},
        {"Smithsonian Astrophysical Observation", "SAO 207208"},
        {"Wilson Evans Batten Catalogue", "WEB 13247"},
    },
    visualMagnitude: 3.42,
    bvColour: -0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.03058543),
        dec: Angle.Degrees(-38.39664079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160047"},
        {"Hipparcos Number", "HIP 86429"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.89417107),
        dec: Angle.Degrees(-38.39571860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208737"},
        {"Hipparcos Number", "HIP 108543"},
        {"Geneva Identification System", "GEN# +1.00208737"},
        {"Smithsonian Astrophysical Observation", "SAO 213452"},
        {"Wilson Evans Batten Catalogue", "WEB 19539"},
    },
    visualMagnitude: 5.50,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.82450083),
        dec: Angle.Degrees(-38.39509330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55570"},
        {"Hipparcos Number", "HIP 34756"},
        {"Smithsonian Astrophysical Observation", "SAO 197683"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.92195309),
        dec: Angle.Degrees(-38.39104651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25632"},
        {"Hipparcos Number", "HIP 18857"},
        {"Smithsonian Astrophysical Observation", "SAO 194713"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.63990992),
        dec: Angle.Degrees(-38.39034131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149090"},
        {"Hipparcos Number", "HIP 81136"},
        {"Geneva Identification System", "GEN# +1.00149090"},
        {"Smithsonian Astrophysical Observation", "SAO 207777"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.54359061),
        dec: Angle.Degrees(-38.39023377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115966",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115966"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.43138354),
        dec: Angle.Degrees(-38.38869129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 335.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82915"},
        {"Hipparcos Number", "HIP 46925"},
        {"Smithsonian Astrophysical Observation", "SAO 200504"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.46552286),
        dec: Angle.Degrees(-38.38804213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220457"},
        {"Hipparcos Number", "HIP 115523"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.01793038),
        dec: Angle.Degrees(-38.38793162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1791"},
        {"Hipparcos Number", "HIP 1749"},
        {"Geneva Identification System", "GEN# +1.00001791"},
        {"Smithsonian Astrophysical Observation", "SAO 192485"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.53611806),
        dec: Angle.Degrees(-38.38486597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180445"},
        {"Hipparcos Number", "HIP 94863"},
        {"Geneva Identification System", "GEN# +1.00180445"},
        {"Smithsonian Astrophysical Observation", "SAO 211142"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.55236701),
        dec: Angle.Degrees(-38.38434513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16975"},
        {"Hipparcos Number", "HIP 12608"},
        {"Geneva Identification System", "GEN# +1.00016975"},
        {"Smithsonian Astrophysical Observation", "SAO 193873"},
        {"Wilson Evans Batten Catalogue", "WEB 2569"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.52746495),
        dec: Angle.Degrees(-38.38371780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148657"},
        {"Hipparcos Number", "HIP 80897"},
        {"Geneva Identification System", "GEN# +1.00148657"},
        {"Smithsonian Astrophysical Observation", "SAO 207729"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.79869704),
        dec: Angle.Degrees(-38.38292705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54153"},
        {"Hipparcos Number", "HIP 34253"},
        {"Geneva Identification System", "GEN# +1.00054153"},
        {"Smithsonian Astrophysical Observation", "SAO 197572"},
        {"Wilson Evans Batten Catalogue", "WEB 6861"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.50941790),
        dec: Angle.Degrees(-38.38288828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38384"},
        {"New General Catalogue", "NGC 2477 189"},
    },
    visualMagnitude: 11.09,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.94921186),
        dec: Angle.Degrees(-38.38243424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164953"},
        {"Hipparcos Number", "HIP 88596"},
        {"Smithsonian Astrophysical Observation", "SAO 209681"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.35305661),
        dec: Angle.Degrees(-38.38161416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89835"},
        {"Hipparcos Number", "HIP 50718"},
        {"Smithsonian Astrophysical Observation", "SAO 201307"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.33347416),
        dec: Angle.Degrees(-38.38155154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124469"},
        {"Hipparcos Number", "HIP 69605"},
        {"Geneva Identification System", "GEN# +1.00124469"},
        {"Smithsonian Astrophysical Observation", "SAO 205340"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.68964228),
        dec: Angle.Degrees(-38.38116392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98222"},
        {"Hipparcos Number", "HIP 55159"},
        {"Geneva Identification System", "GEN# +1.00098222"},
        {"Smithsonian Astrophysical Observation", "SAO 202287"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.39708522),
        dec: Angle.Degrees(-38.38088722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -254.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171375"},
        {"Hipparcos Number", "HIP 91204"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.08333884),
        dec: Angle.Degrees(-38.37978638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20651"},
        {"Hipparcos Number", "HIP 15370"},
        {"Fundamental Katalog 5th Edition", "FK5 4301"},
        {"Geneva Identification System", "GEN# +1.00020651"},
        {"Smithsonian Astrophysical Observation", "SAO 194220"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.54333613),
        dec: Angle.Degrees(-38.37943370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21150"},
        {"Hipparcos Number", "HIP 15793"},
        {"Smithsonian Astrophysical Observation", "SAO 194267"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.87903077),
        dec: Angle.Degrees(-38.37777546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116368"},
        {"Hipparcos Number", "HIP 65368"},
        {"Smithsonian Astrophysical Observation", "SAO 204426"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.95756628),
        dec: Angle.Degrees(-38.37612624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148289"},
        {"Hipparcos Number", "HIP 80702"},
        {"Smithsonian Astrophysical Observation", "SAO 207692"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.15758000),
        dec: Angle.Degrees(-38.37605827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182880"},
        {"Hipparcos Number", "HIP 95736"},
        {"Smithsonian Astrophysical Observation", "SAO 211284"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.09265936),
        dec: Angle.Degrees(-38.37083621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72787"},
        {"Hipparcos Number", "HIP 41970"},
        {"Celescope Catalog", "CEL 2643"},
        {"Geneva Identification System", "GEN# +1.00072787"},
        {"Smithsonian Astrophysical Observation", "SAO 199363"},
        {"Wilson Evans Batten Catalogue", "WEB 8077"},
    },
    visualMagnitude: 6.48,
    bvColour: -0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.33278556),
        dec: Angle.Degrees(-38.37068960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160096"},
        {"Hipparcos Number", "HIP 86445"},
        {"Smithsonian Astrophysical Observation", "SAO 209091"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.94700080),
        dec: Angle.Degrees(-38.36837290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115220"},
        {"Hipparcos Number", "HIP 64757"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.07320077),
        dec: Angle.Degrees(-38.36764397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13462"},
        {"Hipparcos Number", "HIP 10161"},
        {"Smithsonian Astrophysical Observation", "SAO 193553"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.66684608),
        dec: Angle.Degrees(-38.36711088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84991"},
        {"Hipparcos Number", "HIP 48072"},
        {"Geneva Identification System", "GEN# +1.00084991"},
        {"Smithsonian Astrophysical Observation", "SAO 200749"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.00110125),
        dec: Angle.Degrees(-38.36455562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 126.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113812"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.71812503),
        dec: Angle.Degrees(-38.36308992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97073"},
        {"Hipparcos Number", "HIP 54577"},
        {"Geneva Identification System", "GEN# +1.00097073J"},
        {"Smithsonian Astrophysical Observation", "SAO 202153"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.53121827),
        dec: Angle.Degrees(-38.36305340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161512"},
        {"Hipparcos Number", "HIP 87078"},
        {"Smithsonian Astrophysical Observation", "SAO 209257"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.90739204),
        dec: Angle.Degrees(-38.36005007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34419"},
        {"Hipparcos Number", "HIP 24517"},
        {"Smithsonian Astrophysical Observation", "SAO 195693"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.89230487),
        dec: Angle.Degrees(-38.35946917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172280"},
        {"Hipparcos Number", "HIP 91618"},
        {"Geneva Identification System", "GEN# +1.00172280"},
        {"Smithsonian Astrophysical Observation", "SAO 210447"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.27437429),
        dec: Angle.Degrees(-38.35848214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163940"},
        {"Hipparcos Number", "HIP 88180"},
        {"Smithsonian Astrophysical Observation", "SAO 209581"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.13092610),
        dec: Angle.Degrees(-38.35725605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26542",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26542"},
        {"Geneva Identification System", "GEN# -0.03802136"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.66846091),
        dec: Angle.Degrees(-38.35686650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -252.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169791"},
        {"Hipparcos Number", "HIP 90507"},
        {"Smithsonian Astrophysical Observation", "SAO 210188"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.02433576),
        dec: Angle.Degrees(-38.35661994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191866"},
        {"Hipparcos Number", "HIP 99660"},
        {"Smithsonian Astrophysical Observation", "SAO 211909"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.35991614),
        dec: Angle.Degrees(-38.35630493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11436"},
        {"Hipparcos Number", "HIP 8660"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.90145897),
        dec: Angle.Degrees(-38.35596534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58676"},
        {"Hipparcos Number", "HIP 35985"},
        {"Geneva Identification System", "GEN# +1.00058676"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.23817238),
        dec: Angle.Degrees(-38.35167573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148580"},
        {"Hipparcos Number", "HIP 80849"},
        {"Smithsonian Astrophysical Observation", "SAO 207723"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.66260547),
        dec: Angle.Degrees(-38.35145676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67795",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67795"},
    },
    visualMagnitude: 12.51,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.30948996),
        dec: Angle.Degrees(-38.34974431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -385.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88904"},
        {"Hipparcos Number", "HIP 50163"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.58845918),
        dec: Angle.Degrees(-38.34974206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35992",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35992"},
        {"Geneva Identification System", "GEN# -0.03803367"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.24997822),
        dec: Angle.Degrees(-38.34940983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85207"},
        {"Hipparcos Number", "HIP 48188"},
        {"Geneva Identification System", "GEN# +1.00085207"},
        {"Smithsonian Astrophysical Observation", "SAO 200776"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.35302033),
        dec: Angle.Degrees(-38.34930840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204454"},
        {"Hipparcos Number", "HIP 106116"},
        {"Geneva Identification System", "GEN# +1.00204454"},
        {"Smithsonian Astrophysical Observation", "SAO 213040"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.41754784),
        dec: Angle.Degrees(-38.34578733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202853"},
        {"Hipparcos Number", "HIP 105304"},
        {"Smithsonian Astrophysical Observation", "SAO 212904"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.92918612),
        dec: Angle.Degrees(-38.34551920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213771"},
        {"Hipparcos Number", "HIP 111419"},
        {"Smithsonian Astrophysical Observation", "SAO 213923"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.60253153),
        dec: Angle.Degrees(-38.34532087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220992"},
        {"Hipparcos Number", "HIP 115876"},
        {"Smithsonian Astrophysical Observation", "SAO 214570"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.14415045),
        dec: Angle.Degrees(-38.34309858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118930"},
        {"Hipparcos Number", "HIP 66744"},
        {"Geneva Identification System", "GEN# +1.00118930"},
        {"Smithsonian Astrophysical Observation", "SAO 204722"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.19800759),
        dec: Angle.Degrees(-38.34288291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101720"},
        {"Hipparcos Number", "HIP 57088"},
        {"Smithsonian Astrophysical Observation", "SAO 202724"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.54913039),
        dec: Angle.Degrees(-38.34192960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108770"},
        {"Hipparcos Number", "HIP 60985"},
        {"Smithsonian Astrophysical Observation", "SAO 203530"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.50274779),
        dec: Angle.Degrees(-38.33918211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103194"},
        {"Hipparcos Number", "HIP 57926"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.19710776),
        dec: Angle.Degrees(-38.33875228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65147"},
        {"Hipparcos Number", "HIP 38727"},
        {"Celescope Catalog", "CEL 2100"},
        {"Smithsonian Astrophysical Observation", "SAO 198602"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.93040411),
        dec: Angle.Degrees(-38.33676449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155912"},
        {"Hipparcos Number", "HIP 84475"},
        {"Geneva Identification System", "GEN# +1.00155912"},
        {"Smithsonian Astrophysical Observation", "SAO 208607"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.04536516),
        dec: Angle.Degrees(-38.33666832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28162"},
        {"Hipparcos Number", "HIP 20608"},
        {"Geneva Identification System", "GEN# +1.00028162"},
        {"Smithsonian Astrophysical Observation", "SAO 194997"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.21655695),
        dec: Angle.Degrees(-38.33455456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102630"},
        {"Hipparcos Number", "HIP 57619"},
        {"Smithsonian Astrophysical Observation", "SAO 202832"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.21582730),
        dec: Angle.Degrees(-38.33385592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222909"},
        {"Hipparcos Number", "HIP 117141"},
        {"Smithsonian Astrophysical Observation", "SAO 214749"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.21997837),
        dec: Angle.Degrees(-38.33259896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199564"},
        {"Hipparcos Number", "HIP 103582"},
        {"Smithsonian Astrophysical Observation", "SAO 212593"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.81456971),
        dec: Angle.Degrees(-38.33244624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75155"},
    },
    visualMagnitude: 11.96,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.38505336),
        dec: Angle.Degrees(-38.33183004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157708"},
        {"Hipparcos Number", "HIP 85359"},
        {"Smithsonian Astrophysical Observation", "SAO 208815"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.64404759),
        dec: Angle.Degrees(-38.32884668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76514"},
        {"Hipparcos Number", "HIP 43806"},
        {"Smithsonian Astrophysical Observation", "SAO 199789"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.82681907),
        dec: Angle.Degrees(-38.32781531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221250"},
        {"Hipparcos Number", "HIP 116029"},
        {"Geneva Identification System", "GEN# +1.00221250"},
        {"Smithsonian Astrophysical Observation", "SAO 214592"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.66344914),
        dec: Angle.Degrees(-38.32771879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48290"},
        {"Hipparcos Number", "HIP 31970"},
        {"Smithsonian Astrophysical Observation", "SAO 197083"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.22765243),
        dec: Angle.Degrees(-38.32678653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188339"},
        {"Hipparcos Number", "HIP 98099"},
        {"Smithsonian Astrophysical Observation", "SAO 211664"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.04410010),
        dec: Angle.Degrees(-38.32649211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172777"},
        {"Hipparcos Number", "HIP 91875"},
        {"Geneva Identification System", "GEN# +1.00172777A"},
        {"Smithsonian Astrophysical Observation", "SAO 210501"},
        {"Wilson Evans Batten Catalogue", "WEB 15816"},
    },
    visualMagnitude: 5.11,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.94558795),
        dec: Angle.Degrees(-38.32331062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118563"},
        {"Hipparcos Number", "HIP 66547"},
        {"Geneva Identification System", "GEN# +1.00118563"},
        {"Smithsonian Astrophysical Observation", "SAO 204685"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.61854905),
        dec: Angle.Degrees(-38.32029428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132175"},
        {"Hipparcos Number", "HIP 73306"},
        {"Geneva Identification System", "GEN# +1.00132175"},
        {"Smithsonian Astrophysical Observation", "SAO 206159"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.71787986),
        dec: Angle.Degrees(-38.31987851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121527"},
        {"Hipparcos Number", "HIP 68114"},
        {"Smithsonian Astrophysical Observation", "SAO 205016"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.17958724),
        dec: Angle.Degrees(-38.31908475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56733"},
        {"Hipparcos Number", "HIP 35202"},
        {"Celescope Catalog", "CEL 1736"},
        {"Geneva Identification System", "GEN# +1.00056733"},
        {"Smithsonian Astrophysical Observation", "SAO 197785"},
    },
    visualMagnitude: 5.81,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.13273708),
        dec: Angle.Degrees(-38.31894033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133098"},
        {"Hipparcos Number", "HIP 73698"},
        {"Smithsonian Astrophysical Observation", "SAO 206253"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.95266614),
        dec: Angle.Degrees(-38.31866186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78740"},
        {"Hipparcos Number", "HIP 44873"},
        {"Geneva Identification System", "GEN# +1.00078740"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.15258832),
        dec: Angle.Degrees(-38.31743184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -213.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132744"},
        {"Hipparcos Number", "HIP 73545"},
        {"Smithsonian Astrophysical Observation", "SAO 206220"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.47086047),
        dec: Angle.Degrees(-38.31727803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26980"},
        {"Hipparcos Number", "HIP 19775"},
        {"Geneva Identification System", "GEN# +1.00026980"},
        {"Smithsonian Astrophysical Observation", "SAO 194861"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.59392278),
        dec: Angle.Degrees(-38.31710959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82693"},
        {"Hipparcos Number", "HIP 46823"},
        {"Smithsonian Astrophysical Observation", "SAO 200480"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.12756638),
        dec: Angle.Degrees(-38.31626169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45963"},
        {"Hipparcos Number", "HIP 30870"},
        {"Geneva Identification System", "GEN# +1.00045963"},
        {"Smithsonian Astrophysical Observation", "SAO 196870"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.21370014),
        dec: Angle.Degrees(-38.31532523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85120"},
        {"Hipparcos Number", "HIP 48134"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.19522800),
        dec: Angle.Degrees(-38.31448380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75743"},
        {"Hipparcos Number", "HIP 43395"},
        {"Smithsonian Astrophysical Observation", "SAO 199691"},
    },
    visualMagnitude: 8.39,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.59367523),
        dec: Angle.Degrees(-38.31389057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21385"},
        {"Hipparcos Number", "HIP 15964"},
        {"Geneva Identification System", "GEN# +1.00021385"},
        {"Smithsonian Astrophysical Observation", "SAO 194285"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.39507584),
        dec: Angle.Degrees(-38.31264297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30566"},
        {"Hipparcos Number", "HIP 22235"},
        {"Geneva Identification System", "GEN# +1.00030566"},
        {"Smithsonian Astrophysical Observation", "SAO 195291"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.75500769),
        dec: Angle.Degrees(-38.30893671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98741"},
        {"Hipparcos Number", "HIP 55456"},
        {"Smithsonian Astrophysical Observation", "SAO 202351"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.36325820),
        dec: Angle.Degrees(-38.30887227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61831"},
        {"Hipparcos Number", "HIP 37297"},
        {"Celescope Catalog", "CEL 1966"},
        {"Geneva Identification System", "GEN# +2.24510175"},
        {"Smithsonian Astrophysical Observation", "SAO 198253"},
        {"Wilson Evans Batten Catalogue", "WEB 7385"},
        {"New General Catalogue", "NGC 2451 175"},
    },
    visualMagnitude: 4.84,
    bvColour: -0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.86397492),
        dec: Angle.Degrees(-38.30806020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113131"},
        {"Hipparcos Number", "HIP 63597"},
        {"Geneva Identification System", "GEN# +1.00113131"},
        {"Smithsonian Astrophysical Observation", "SAO 204053"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.49182184),
        dec: Angle.Degrees(-38.30580226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75058"},
        {"Hipparcos Number", "HIP 43066"},
        {"Smithsonian Astrophysical Observation", "SAO 199601"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.59170271),
        dec: Angle.Degrees(-38.30537795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21243",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21243"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.35575376),
        dec: Angle.Degrees(-38.30344672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 467.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 150.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90335"},
        {"Hipparcos Number", "HIP 50987"},
        {"Smithsonian Astrophysical Observation", "SAO 201369"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.23739605),
        dec: Angle.Degrees(-38.30324857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210571"},
        {"Hipparcos Number", "HIP 109595"},
        {"Smithsonian Astrophysical Observation", "SAO 213631"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.00939146),
        dec: Angle.Degrees(-38.30286168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107434"},
        {"Hipparcos Number", "HIP 60239"},
        {"Geneva Identification System", "GEN# +1.00107434"},
        {"Smithsonian Astrophysical Observation", "SAO 203374"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.29004930),
        dec: Angle.Degrees(-38.30267549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20696"},
        {"Hipparcos Number", "HIP 15402"},
        {"Smithsonian Astrophysical Observation", "SAO 194224"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.64782688),
        dec: Angle.Degrees(-38.30230286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17253"},
        {"Hipparcos Number", "HIP 12835"},
        {"Smithsonian Astrophysical Observation", "SAO 193891"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.24789688),
        dec: Angle.Degrees(-38.29749683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203243"},
        {"Hipparcos Number", "HIP 105505"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.53381125),
        dec: Angle.Degrees(-38.29740232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25244"},
        {"Hipparcos Number", "HIP 18615"},
        {"Smithsonian Astrophysical Observation", "SAO 194674"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.74228404),
        dec: Angle.Degrees(-38.29704925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210637"},
        {"Hipparcos Number", "HIP 109636"},
        {"Smithsonian Astrophysical Observation", "SAO 213642"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.14221102),
        dec: Angle.Degrees(-38.29700923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27097"},
        {"Hipparcos Number", "HIP 19838"},
        {"Geneva Identification System", "GEN# +1.00027097"},
        {"Smithsonian Astrophysical Observation", "SAO 194872"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.79832933),
        dec: Angle.Degrees(-38.29509818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155536"},
        {"Hipparcos Number", "HIP 84290"},
        {"Geneva Identification System", "GEN# +1.00155536J"},
        {"Smithsonian Astrophysical Observation", "SAO 208556"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.47485185),
        dec: Angle.Degrees(-38.29490406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3365"},
        {"Hipparcos Number", "HIP 2863"},
        {"Geneva Identification System", "GEN# +1.00003365"},
        {"Smithsonian Astrophysical Observation", "SAO 192631"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.07238474),
        dec: Angle.Degrees(-38.29404756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 248.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179234"},
        {"Hipparcos Number", "HIP 94455"},
        {"Smithsonian Astrophysical Observation", "SAO 211056"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.36036715),
        dec: Angle.Degrees(-38.29236779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187388"},
        {"Hipparcos Number", "HIP 97691"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.80954564),
        dec: Angle.Degrees(-38.29184060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130055"},
        {"Hipparcos Number", "HIP 72296"},
        {"Geneva Identification System", "GEN# +1.00130055"},
        {"Smithsonian Astrophysical Observation", "SAO 205937"},
    },
    visualMagnitude: 5.90,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.77107748),
        dec: Angle.Degrees(-38.29043787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 477"},
        {"Hipparcos Number", "HIP 745"},
        {"Smithsonian Astrophysical Observation", "SAO 192375"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.28833154),
        dec: Angle.Degrees(-38.28947361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 164.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4735"},
        {"Hipparcos Number", "HIP 3816"},
        {"Geneva Identification System", "GEN# +1.00004735"},
        {"Smithsonian Astrophysical Observation", "SAO 192760"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.25804459),
        dec: Angle.Degrees(-38.28857027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70946"},
        {"Hipparcos Number", "HIP 41107"},
        {"Geneva Identification System", "GEN# +1.00070946"},
        {"Smithsonian Astrophysical Observation", "SAO 199166"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.82055829),
        dec: Angle.Degrees(-38.28606380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22633"},
        {"Hipparcos Number", "HIP 16861"},
        {"Smithsonian Astrophysical Observation", "SAO 194403"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.24961247),
        dec: Angle.Degrees(-38.28564299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195386"},
        {"Hipparcos Number", "HIP 101344"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.09712686),
        dec: Angle.Degrees(-38.28450165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29087"},
        {"Hipparcos Number", "HIP 21213"},
        {"Smithsonian Astrophysical Observation", "SAO 195118"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.25635898),
        dec: Angle.Degrees(-38.28341151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23484"},
        {"Hipparcos Number", "HIP 17439"},
        {"Geneva Identification System", "GEN# +1.00023484"},
        {"Smithsonian Astrophysical Observation", "SAO 194491"},
        {"Wilson Evans Batten Catalogue", "WEB 3300"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.03757350),
        dec: Angle.Degrees(-38.28247293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 209.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 288.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172550"},
        {"Hipparcos Number", "HIP 91747"},
        {"Geneva Identification System", "GEN# +1.00172550"},
        {"Smithsonian Astrophysical Observation", "SAO 210481"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.63940488),
        dec: Angle.Degrees(-38.28184956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 663"},
        {"Geneva Identification System", "GEN# -0.03800011"},
        {"Smithsonian Astrophysical Observation", "SAO 192368"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.04976404),
        dec: Angle.Degrees(-38.28106844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6808"},
        {"Hipparcos Number", "HIP 5334"},
        {"Smithsonian Astrophysical Observation", "SAO 192942"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.04887568),
        dec: Angle.Degrees(-38.27984831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58170"},
        {"Geneva Identification System", "GEN# +9.85961058"},
    },
    visualMagnitude: 12.01,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.95288715),
        dec: Angle.Degrees(-38.27964825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 620.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -294.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181815"},
        {"Hipparcos Number", "HIP 95327"},
        {"Geneva Identification System", "GEN# +1.00181815"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.91331181),
        dec: Angle.Degrees(-38.27953403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2937"},
        {"Hipparcos Number", "HIP 2554"},
        {"Smithsonian Astrophysical Observation", "SAO 192595"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.11450037),
        dec: Angle.Degrees(-38.27767604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160893"},
        {"Hipparcos Number", "HIP 86800"},
        {"Smithsonian Astrophysical Observation", "SAO 209201"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.05406440),
        dec: Angle.Degrees(-38.27610773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28755"},
        {"Hipparcos Number", "HIP 21009"},
        {"Geneva Identification System", "GEN# +1.00028755"},
        {"Smithsonian Astrophysical Observation", "SAO 195083"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.57590969),
        dec: Angle.Degrees(-38.27462523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41087"},
        {"Hipparcos Number", "HIP 28518"},
        {"Geneva Identification System", "GEN# +1.00041087"},
        {"Smithsonian Astrophysical Observation", "SAO 196414"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.29341246),
        dec: Angle.Degrees(-38.27348849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58618"},
        {"Hipparcos Number", "HIP 35947"},
        {"Geneva Identification System", "GEN# +1.00058618"},
        {"Smithsonian Astrophysical Observation", "SAO 197969"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.15654276),
        dec: Angle.Degrees(-38.27329386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58880"},
        {"Geneva Identification System", "GEN# +9.86469072"},
    },
    visualMagnitude: 11.77,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.15042282),
        dec: Angle.Degrees(-38.27304045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 640.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45244"},
        {"Hipparcos Number", "HIP 30495"},
        {"Smithsonian Astrophysical Observation", "SAO 196791"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.15812171),
        dec: Angle.Degrees(-38.27252732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113428"},
        {"Smithsonian Astrophysical Observation", "SAO 214213"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.58652926),
        dec: Angle.Degrees(-38.27049532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68416"},
        {"Hipparcos Number", "HIP 40045"},
        {"Smithsonian Astrophysical Observation", "SAO 198892"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.69908224),
        dec: Angle.Degrees(-38.26888830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198383"},
        {"Hipparcos Number", "HIP 102932"},
        {"Geneva Identification System", "GEN# +1.00198383"},
        {"Smithsonian Astrophysical Observation", "SAO 212490"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.80914366),
        dec: Angle.Degrees(-38.26780083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221708"},
        {"Hipparcos Number", "HIP 116356"},
        {"Smithsonian Astrophysical Observation", "SAO 214631"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.66143336),
        dec: Angle.Degrees(-38.26757128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108683"},
        {"Hipparcos Number", "HIP 60934"},
        {"Geneva Identification System", "GEN# +1.00108683"},
        {"Wilson Evans Batten Catalogue", "WEB 10844"},
    },
    visualMagnitude: 9.39,
    bvColour: 3.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.33759202),
        dec: Angle.Degrees(-38.26397537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120123"},
        {"Hipparcos Number", "HIP 67353"},
        {"Smithsonian Astrophysical Observation", "SAO 204854"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.06288663),
        dec: Angle.Degrees(-38.26251622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61899"},
        {"Hipparcos Number", "HIP 37329"},
        {"Celescope Catalog", "CEL 1970"},
        {"Geneva Identification System", "GEN# +2.24510184"},
        {"Smithsonian Astrophysical Observation", "SAO 198268"},
        {"Wilson Evans Batten Catalogue", "WEB 7387"},
        {"New General Catalogue", "NGC 2451 184"},
    },
    visualMagnitude: 5.76,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.94951052),
        dec: Angle.Degrees(-38.26067563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26979"},
        {"Hipparcos Number", "HIP 19769"},
        {"Geneva Identification System", "GEN# +1.00026979"},
        {"Smithsonian Astrophysical Observation", "SAO 194858"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.58263768),
        dec: Angle.Degrees(-38.26015596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140958"},
        {"Hipparcos Number", "HIP 77388"},
        {"Geneva Identification System", "GEN# +1.00140958"},
        {"Smithsonian Astrophysical Observation", "SAO 206984"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.96321618),
        dec: Angle.Degrees(-38.25993684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131402"},
        {"Hipparcos Number", "HIP 72949"},
        {"Smithsonian Astrophysical Observation", "SAO 206073"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.63256243),
        dec: Angle.Degrees(-38.25893633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97943"},
        {"Hipparcos Number", "HIP 54986"},
        {"Smithsonian Astrophysical Observation", "SAO 202250"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.89204677),
        dec: Angle.Degrees(-38.25833910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162288"},
        {"Hipparcos Number", "HIP 87443"},
        {"Geneva Identification System", "GEN# +1.00162288"},
        {"Smithsonian Astrophysical Observation", "SAO 209375"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.01627063),
        dec: Angle.Degrees(-38.25825708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117850"},
        {"Hipparcos Number", "HIP 66163"},
        {"Smithsonian Astrophysical Observation", "SAO 204596"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.43779908),
        dec: Angle.Degrees(-38.25815988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131165"},
        {"Hipparcos Number", "HIP 72823"},
        {"Geneva Identification System", "GEN# +1.00131165"},
        {"Smithsonian Astrophysical Observation", "SAO 206048"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.27765857),
        dec: Angle.Degrees(-38.25694293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188315"},
        {"Hipparcos Number", "HIP 98091"},
        {"Smithsonian Astrophysical Observation", "SAO 211663"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.02697954),
        dec: Angle.Degrees(-38.25673495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119338"},
        {"Hipparcos Number", "HIP 66957"},
        {"Geneva Identification System", "GEN# +1.00119338"},
        {"Smithsonian Astrophysical Observation", "SAO 204768"},
    },
    visualMagnitude: 8.92,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.85541964),
        dec: Angle.Degrees(-38.25654064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151726"},
        {"Hipparcos Number", "HIP 82430"},
        {"Smithsonian Astrophysical Observation", "SAO 208083"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.68969650),
        dec: Angle.Degrees(-38.25636359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98580"},
        {"Hipparcos Number", "HIP 55358"},
        {"Smithsonian Astrophysical Observation", "SAO 202333"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.03679227),
        dec: Angle.Degrees(-38.25375564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176723"},
        {"Hipparcos Number", "HIP 93552"},
        {"Geneva Identification System", "GEN# +1.00176723"},
        {"Renson", "Renson 49330"},
        {"Smithsonian Astrophysical Observation", "SAO 210859"},
        {"Wilson Evans Batten Catalogue", "WEB 16248"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.82369335),
        dec: Angle.Degrees(-38.25318227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118311"},
    },
    visualMagnitude: 11.85,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.95468546),
        dec: Angle.Degrees(-38.25260253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 337.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116773"},
        {"Smithsonian Astrophysical Observation", "SAO 214693"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.99702380),
        dec: Angle.Degrees(-38.24882534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52745",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52745"},
        {"Smithsonian Astrophysical Observation", "SAO 201743"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.75260337),
        dec: Angle.Degrees(-38.24837848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7269"},
        {"Hipparcos Number", "HIP 5632"},
        {"Geneva Identification System", "GEN# +1.00007269"},
        {"Smithsonian Astrophysical Observation", "SAO 192978"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.08352649),
        dec: Angle.Degrees(-38.24763766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40078"},
        {"Hipparcos Number", "HIP 27958"},
        {"Smithsonian Astrophysical Observation", "SAO 196308"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.72511797),
        dec: Angle.Degrees(-38.24696791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19582"},
    },
    visualMagnitude: 11.38,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.95106742),
        dec: Angle.Degrees(-38.24534754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 136.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9578"},
        {"Hipparcos Number", "HIP 7240"},
        {"Geneva Identification System", "GEN# +1.00009578"},
        {"Smithsonian Astrophysical Observation", "SAO 193177"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.32153199),
        dec: Angle.Degrees(-38.24492313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78241"},
        {"Hipparcos Number", "HIP 44648"},
        {"Geneva Identification System", "GEN# +1.00078241"},
        {"Smithsonian Astrophysical Observation", "SAO 199969"},
        {"Wilson Evans Batten Catalogue", "WEB 8541"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.46534629),
        dec: Angle.Degrees(-38.24469199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19050"},
        {"Hipparcos Number", "HIP 14162"},
        {"Smithsonian Astrophysical Observation", "SAO 194053"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.64734916),
        dec: Angle.Degrees(-38.24108162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198234"},
        {"Hipparcos Number", "HIP 102854"},
        {"Smithsonian Astrophysical Observation", "SAO 212475"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.55439418),
        dec: Angle.Degrees(-38.24102249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29844"},
        {"Hipparcos Number", "HIP 21766"},
        {"Geneva Identification System", "GEN# +1.00029844"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.12537454),
        dec: Angle.Degrees(-38.23525019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182465"},
        {"Hipparcos Number", "HIP 95573"},
        {"Smithsonian Astrophysical Observation", "SAO 211260"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.60161974),
        dec: Angle.Degrees(-38.23439152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53983"},
        {"Hipparcos Number", "HIP 34192"},
        {"Celescope Catalog", "CEL 1574"},
        {"Geneva Identification System", "GEN# +1.00053983"},
        {"Smithsonian Astrophysical Observation", "SAO 197554"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.35058375),
        dec: Angle.Degrees(-38.23389525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6575"},
        {"Hipparcos Number", "HIP 5173"},
        {"Smithsonian Astrophysical Observation", "SAO 192920"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.54003829),
        dec: Angle.Degrees(-38.23306421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38921"},
        {"Hipparcos Number", "HIP 27331"},
        {"Smithsonian Astrophysical Observation", "SAO 196174"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.84247490),
        dec: Angle.Degrees(-38.23090928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207481"},
        {"Hipparcos Number", "HIP 107794"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.54996209),
        dec: Angle.Degrees(-38.23019343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167729"},
        {"Hipparcos Number", "HIP 89692"},
        {"Smithsonian Astrophysical Observation", "SAO 209969"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.56468882),
        dec: Angle.Degrees(-38.22972150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224529"},
        {"Hipparcos Number", "HIP 118210"},
        {"Geneva Identification System", "GEN# +1.00224529"},
        {"Smithsonian Astrophysical Observation", "SAO 214892"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.67532690),
        dec: Angle.Degrees(-38.22581283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128818"},
        {"Hipparcos Number", "HIP 71722"},
        {"Smithsonian Astrophysical Observation", "SAO 205817"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.06616963),
        dec: Angle.Degrees(-38.22509738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200684"},
        {"Hipparcos Number", "HIP 104156"},
        {"Smithsonian Astrophysical Observation", "SAO 212708"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.53105129),
        dec: Angle.Degrees(-38.22308470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215724"},
        {"Hipparcos Number", "HIP 112554"},
        {"Geneva Identification System", "GEN# +1.00215724"},
        {"Smithsonian Astrophysical Observation", "SAO 214087"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.94664458),
        dec: Angle.Degrees(-38.22191604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23981"},
        {"Smithsonian Astrophysical Observation", "SAO 195604"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.31303025),
        dec: Angle.Degrees(-38.22048352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112776"},
        {"Hipparcos Number", "HIP 63404"},
        {"Smithsonian Astrophysical Observation", "SAO 204009"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.88710181),
        dec: Angle.Degrees(-38.22004493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139868"},
        {"Hipparcos Number", "HIP 76890"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.50509475),
        dec: Angle.Degrees(-38.21927740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47085"},
    },
    visualMagnitude: 12.27,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.93326374),
        dec: Angle.Degrees(-38.21899437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -228.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 125.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136347"},
        {"Hipparcos Number", "HIP 75151"},
        {"Geneva Identification System", "GEN# +1.00136347J"},
        {"Smithsonian Astrophysical Observation", "SAO 206543"},
    },
    visualMagnitude: 6.57,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.37544028),
        dec: Angle.Degrees(-38.21863928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139142"},
        {"Hipparcos Number", "HIP 76541"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.48330060),
        dec: Angle.Degrees(-38.21849884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125474"},
        {"Hipparcos Number", "HIP 70096"},
        {"Geneva Identification System", "GEN# +1.00125474"},
        {"Smithsonian Astrophysical Observation", "SAO 205455"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.15226017),
        dec: Angle.Degrees(-38.21785877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50472"},
        {"Hipparcos Number", "HIP 32930"},
        {"Celescope Catalog", "CEL 1413"},
        {"Geneva Identification System", "GEN# +1.00050472"},
        {"Smithsonian Astrophysical Observation", "SAO 197290"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.90824076),
        dec: Angle.Degrees(-38.21502157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6080"},
        {"Hipparcos Number", "HIP 4794"},
        {"Smithsonian Astrophysical Observation", "SAO 192874"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.39255801),
        dec: Angle.Degrees(-38.21455968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15724"},
        {"Hipparcos Number", "HIP 11674"},
        {"Smithsonian Astrophysical Observation", "SAO 193746"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.65161534),
        dec: Angle.Degrees(-38.21420244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155775"},
        {"Hipparcos Number", "HIP 84409"},
        {"Geneva Identification System", "GEN# +1.00155775"},
        {"Smithsonian Astrophysical Observation", "SAO 208582"},
        {"Wilson Evans Batten Catalogue", "WEB 14247"},
    },
    visualMagnitude: 6.71,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.84300628),
        dec: Angle.Degrees(-38.21295330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143380"},
        {"Hipparcos Number", "HIP 78500"},
        {"Smithsonian Astrophysical Observation", "SAO 207237"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.38346875),
        dec: Angle.Degrees(-38.21178493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212409"},
        {"Hipparcos Number", "HIP 110633"},
        {"Smithsonian Astrophysical Observation", "SAO 213797"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.16862747),
        dec: Angle.Degrees(-38.21019576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24385"},
        {"Hipparcos Number", "HIP 18034"},
        {"Smithsonian Astrophysical Observation", "SAO 194582"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.82312706),
        dec: Angle.Degrees(-38.21006338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95149"},
        {"Hipparcos Number", "HIP 53655"},
        {"Smithsonian Astrophysical Observation", "SAO 201962"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.65633756),
        dec: Angle.Degrees(-38.20554563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203333"},
        {"Hipparcos Number", "HIP 105553"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.66420725),
        dec: Angle.Degrees(-38.20549141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11321"},
    },
    visualMagnitude: 11.43,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.42529352),
        dec: Angle.Degrees(-38.20438596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63738"},
        {"Hipparcos Number", "HIP 38129"},
        {"Geneva Identification System", "GEN# +2.24510300"},
        {"Smithsonian Astrophysical Observation", "SAO 198475"},
        {"New General Catalogue", "NGC 2451 300"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.20580160),
        dec: Angle.Degrees(-38.20396155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153426"},
        {"Hipparcos Number", "HIP 83281"},
        {"Geneva Identification System", "GEN# +1.00153426"},
        {"Smithsonian Astrophysical Observation", "SAO 208304"},
        {"Wilson Evans Batten Catalogue", "WEB 14073"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.30419803),
        dec: Angle.Degrees(-38.20330198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85965"},
        {"Hipparcos Number", "HIP 48581"},
        {"Smithsonian Astrophysical Observation", "SAO 200856"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.62307510),
        dec: Angle.Degrees(-38.18723215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157040"},
        {"Hipparcos Number", "HIP 85022"},
        {"Smithsonian Astrophysical Observation", "SAO 208742"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.67477204),
        dec: Angle.Degrees(-38.20225877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62712"},
        {"Hipparcos Number", "HIP 37666"},
        {"Celescope Catalog", "CEL 1999"},
        {"Geneva Identification System", "GEN# +2.24510233"},
        {"Renson", "Renson 17260"},
        {"Smithsonian Astrophysical Observation", "SAO 198352"},
        {"Wilson Evans Batten Catalogue", "WEB 7445"},
        {"New General Catalogue", "NGC 2451 233"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.92888042),
        dec: Angle.Degrees(-38.20191748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119967"},
        {"Hipparcos Number", "HIP 67272"},
        {"Smithsonian Astrophysical Observation", "SAO 204837"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.80622690),
        dec: Angle.Degrees(-38.20119759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192015"},
        {"Hipparcos Number", "HIP 99734"},
        {"Smithsonian Astrophysical Observation", "SAO 211925"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.54884875),
        dec: Angle.Degrees(-38.20087313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70659"},
        {"Hipparcos Number", "HIP 40975"},
        {"Smithsonian Astrophysical Observation", "SAO 199129"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.42485341),
        dec: Angle.Degrees(-38.20010599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36747"},
        {"Hipparcos Number", "HIP 25952"},
        {"Geneva Identification System", "GEN# +1.00036747"},
        {"Smithsonian Astrophysical Observation", "SAO 195938"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.06031358),
        dec: Angle.Degrees(-38.19759640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66703"},
        {"Hipparcos Number", "HIP 39390"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.79350567),
        dec: Angle.Degrees(-38.19655775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166220"},
        {"Hipparcos Number", "HIP 89131"},
        {"Geneva Identification System", "GEN# +1.00166220"},
        {"Smithsonian Astrophysical Observation", "SAO 209823"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.85337554),
        dec: Angle.Degrees(-38.19622777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160812"},
        {"Hipparcos Number", "HIP 86762"},
        {"Geneva Identification System", "GEN# +1.00160812"},
        {"Smithsonian Astrophysical Observation", "SAO 209185"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.92968715),
        dec: Angle.Degrees(-38.19591595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213629"},
        {"Hipparcos Number", "HIP 111347"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.36994823),
        dec: Angle.Degrees(-38.19558206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1981"},
        {"Hipparcos Number", "HIP 1890"},
        {"Smithsonian Astrophysical Observation", "SAO 192502"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.97021929),
        dec: Angle.Degrees(-38.19224795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18546"},
        {"Hipparcos Number", "HIP 13789"},
        {"Geneva Identification System", "GEN# +1.00018546"},
        {"Smithsonian Astrophysical Observation", "SAO 194007"},
    },
    visualMagnitude: 6.41,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.38593897),
        dec: Angle.Degrees(-38.19095170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147668"},
        {"Hipparcos Number", "HIP 80407"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.18871205),
        dec: Angle.Degrees(-38.18974583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84926"},
        {"Hipparcos Number", "HIP 48037"},
        {"Smithsonian Astrophysical Observation", "SAO 200739"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.89519467),
        dec: Angle.Degrees(-38.18971247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85552"},
        {"Hipparcos Number", "HIP 48369"},
        {"Geneva Identification System", "GEN# +1.00085552"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.90796027),
        dec: Angle.Degrees(-38.18863618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166402"},
        {"Hipparcos Number", "HIP 89201"},
        {"Geneva Identification System", "GEN# +1.00166402"},
        {"Smithsonian Astrophysical Observation", "SAO 209842"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.05860367),
        dec: Angle.Degrees(-38.18486037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191347"},
        {"Hipparcos Number", "HIP 99429"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.72634098),
        dec: Angle.Degrees(-38.18238388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8743"},
        {"Hipparcos Number", "HIP 6672"},
        {"Geneva Identification System", "GEN# +1.00008743"},
        {"Smithsonian Astrophysical Observation", "SAO 193109"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.40727029),
        dec: Angle.Degrees(-38.18211488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27455"},
        {"Hipparcos Number", "HIP 20077"},
        {"Smithsonian Astrophysical Observation", "SAO 194911"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.57579595),
        dec: Angle.Degrees(-38.18170973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138994"},
        {"Hipparcos Number", "HIP 76457"},
        {"Geneva Identification System", "GEN# +1.00138994"},
        {"Smithsonian Astrophysical Observation", "SAO 206803"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.22295639),
        dec: Angle.Degrees(-38.18075633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167506"},
        {"Hipparcos Number", "HIP 89617"},
        {"Geneva Identification System", "GEN# +1.00167506"},
        {"Smithsonian Astrophysical Observation", "SAO 209949"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.32392345),
        dec: Angle.Degrees(-38.17769924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70193"},
        {"Hipparcos Number", "HIP 40752"},
        {"Smithsonian Astrophysical Observation", "SAO 199077"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.78387744),
        dec: Angle.Degrees(-38.17728414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210328"},
        {"Hipparcos Number", "HIP 109455"},
        {"Smithsonian Astrophysical Observation", "SAO 213606"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.62342166),
        dec: Angle.Degrees(-38.17675011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72690"},
        {"Hipparcos Number", "HIP 41932"},
        {"Smithsonian Astrophysical Observation", "SAO 199355"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.22668036),
        dec: Angle.Degrees(-38.17512730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203121"},
        {"Hipparcos Number", "HIP 105434"},
        {"Smithsonian Astrophysical Observation", "SAO 212939"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.34358547),
        dec: Angle.Degrees(-38.17476207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39967"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.41579864),
        dec: Angle.Degrees(-38.17456977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55696"},
        {"Hipparcos Number", "HIP 34801"},
        {"Geneva Identification System", "GEN# +1.00055696"},
        {"Smithsonian Astrophysical Observation", "SAO 197692"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.06247239),
        dec: Angle.Degrees(-38.17448480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60330"},
        {"Hipparcos Number", "HIP 36653"},
        {"Smithsonian Astrophysical Observation", "SAO 198103"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.07028089),
        dec: Angle.Degrees(-38.17422688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29379"},
        {"Hipparcos Number", "HIP 21422"},
        {"Renson", "Renson 7510"},
        {"Smithsonian Astrophysical Observation", "SAO 195152"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.98686225),
        dec: Angle.Degrees(-38.17372785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163521"},
        {"Hipparcos Number", "HIP 87978"},
        {"Smithsonian Astrophysical Observation", "SAO 209530"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.57433342),
        dec: Angle.Degrees(-38.17330050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137015"},
        {"Hipparcos Number", "HIP 75476"},
        {"Geneva Identification System", "GEN# +1.00137015J"},
        {"Smithsonian Astrophysical Observation", "SAO 206607"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.27686739),
        dec: Angle.Degrees(-38.16918035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157720"},
        {"Hipparcos Number", "HIP 85364"},
        {"Smithsonian Astrophysical Observation", "SAO 208817"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.65631150),
        dec: Angle.Degrees(-38.16879551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175626"},
        {"Hipparcos Number", "HIP 93099"},
        {"Geneva Identification System", "GEN# +1.00175626"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.49374369),
        dec: Angle.Degrees(-38.16857709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40907"},
        {"Hipparcos Number", "HIP 28419"},
        {"Smithsonian Astrophysical Observation", "SAO 196399"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.03119374),
        dec: Angle.Degrees(-38.16758393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7725"},
        {"Smithsonian Astrophysical Observation", "SAO 193232"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.85515156),
        dec: Angle.Degrees(-38.16580365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198505"},
        {"Hipparcos Number", "HIP 103000"},
        {"Geneva Identification System", "GEN# +1.00198505J"},
        {"Smithsonian Astrophysical Observation", "SAO 212498"},
        {"Wilson Evans Batten Catalogue", "WEB 18695"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.01751984),
        dec: Angle.Degrees(-38.16502083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156232"},
        {"Hipparcos Number", "HIP 84634"},
        {"Smithsonian Astrophysical Observation", "SAO 208650"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.52279303),
        dec: Angle.Degrees(-38.16398354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31430"},
        {"Hipparcos Number", "HIP 22786"},
        {"Smithsonian Astrophysical Observation", "SAO 195387"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.51713371),
        dec: Angle.Degrees(-38.16288626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68301"},
        {"Hipparcos Number", "HIP 40003"},
        {"Smithsonian Astrophysical Observation", "SAO 198876"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.54988486),
        dec: Angle.Degrees(-38.16177515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210999"},
        {"Hipparcos Number", "HIP 109850"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.72681821),
        dec: Angle.Degrees(-38.16069653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220559"},
        {"Hipparcos Number", "HIP 115594"},
        {"Smithsonian Astrophysical Observation", "SAO 214533"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.22904151),
        dec: Angle.Degrees(-38.16065902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107274",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107274"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.93640486),
        dec: Angle.Degrees(-38.15981148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44553"},
        {"Hipparcos Number", "HIP 30148"},
        {"Smithsonian Astrophysical Observation", "SAO 196714"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.15999725),
        dec: Angle.Degrees(-38.15973413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17322"},
        {"Hipparcos Number", "HIP 12889"},
        {"Geneva Identification System", "GEN# +1.00017322"},
        {"Smithsonian Astrophysical Observation", "SAO 193895"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.42029195),
        dec: Angle.Degrees(-38.15930069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 240.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181013"},
        {"Hipparcos Number", "HIP 95048"},
        {"Geneva Identification System", "GEN# +1.00181013"},
        {"Smithsonian Astrophysical Observation", "SAO 211185"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.10055778),
        dec: Angle.Degrees(-38.15906250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173539"},
        {"Hipparcos Number", "HIP 92207"},
        {"Geneva Identification System", "GEN# +1.00173539"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.88464149),
        dec: Angle.Degrees(-38.15896984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48087"},
        {"Hipparcos Number", "HIP 31886"},
        {"Geneva Identification System", "GEN# +1.00048087"},
        {"Smithsonian Astrophysical Observation", "SAO 197064"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.98697222),
        dec: Angle.Degrees(-38.15891339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141665"},
        {"Hipparcos Number", "HIP 77691"},
        {"Smithsonian Astrophysical Observation", "SAO 207051"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.92160106),
        dec: Angle.Degrees(-38.15814911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99508"},
        {"Hipparcos Number", "HIP 55841"},
        {"Geneva Identification System", "GEN# +1.00099508"},
        {"Smithsonian Astrophysical Observation", "SAO 202453"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.67645038),
        dec: Angle.Degrees(-38.15812290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137057"},
        {"Hipparcos Number", "HIP 75491"},
        {"Smithsonian Astrophysical Observation", "SAO 206611"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.31694467),
        dec: Angle.Degrees(-38.15784242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137231"},
        {"Hipparcos Number", "HIP 75561"},
        {"Smithsonian Astrophysical Observation", "SAO 206642"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.54870992),
        dec: Angle.Degrees(-38.15695782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223193"},
        {"Hipparcos Number", "HIP 117337"},
        {"Fundamental Katalog 5th Edition", "FK5 6108"},
        {"Geneva Identification System", "GEN# +1.00223193"},
        {"Smithsonian Astrophysical Observation", "SAO 214776"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.88119585),
        dec: Angle.Degrees(-38.15639668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150608"},
        {"Hipparcos Number", "HIP 81904"},
        {"Geneva Identification System", "GEN# +1.00150608"},
        {"Smithsonian Astrophysical Observation", "SAO 207966"},
    },
    visualMagnitude: 6.05,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.94834906),
        dec: Angle.Degrees(-38.15624103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98235",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98235"},
    },
    visualMagnitude: 11.19,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.44309579),
        dec: Angle.Degrees(-38.15612756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162105"},
        {"Hipparcos Number", "HIP 87372"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.78260092),
        dec: Angle.Degrees(-38.15436231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88888"},
        {"Hipparcos Number", "HIP 50160"},
        {"Smithsonian Astrophysical Observation", "SAO 201199"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.58756746),
        dec: Angle.Degrees(-38.15380946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183767"},
        {"Hipparcos Number", "HIP 96119"},
        {"Smithsonian Astrophysical Observation", "SAO 211344"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.15500485),
        dec: Angle.Degrees(-38.15317134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153890"},
        {"Hipparcos Number", "HIP 83491"},
        {"Geneva Identification System", "GEN# +2.62810001"},
        {"Smithsonian Astrophysical Observation", "SAO 208355"},
        {"Wilson Evans Batten Catalogue", "WEB 14111"},
        {"New General Catalogue", "NGC 6281 1"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.96197569),
        dec: Angle.Degrees(-38.15248750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34707"},
        {"Hipparcos Number", "HIP 24697"},
        {"Smithsonian Astrophysical Observation", "SAO 195726"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.45062151),
        dec: Angle.Degrees(-38.15198642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102315"},
        {"Hipparcos Number", "HIP 57447"},
        {"Smithsonian Astrophysical Observation", "SAO 202795"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.64786766),
        dec: Angle.Degrees(-38.15012136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113473"},
        {"Hipparcos Number", "HIP 63793"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.12012994),
        dec: Angle.Degrees(-38.14879471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3993"},
        {"Smithsonian Astrophysical Observation", "SAO 192778"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.82819027),
        dec: Angle.Degrees(-38.14877792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102256"},
        {"Hipparcos Number", "HIP 57402"},
        {"Geneva Identification System", "GEN# +1.00102256"},
        {"Smithsonian Astrophysical Observation", "SAO 202788"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.52708335),
        dec: Angle.Degrees(-38.14705762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47463"},
        {"Hipparcos Number", "HIP 31617"},
        {"Geneva Identification System", "GEN# +1.00047463"},
        {"Smithsonian Astrophysical Observation", "SAO 197011"},
    },
    visualMagnitude: 6.03,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.25787432),
        dec: Angle.Degrees(-38.14661562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80591"},
        {"Hipparcos Number", "HIP 45746"},
        {"Smithsonian Astrophysical Observation", "SAO 200239"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.90378311),
        dec: Angle.Degrees(-38.14597031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129548"},
        {"Hipparcos Number", "HIP 72045"},
        {"Geneva Identification System", "GEN# +1.00129548"},
        {"Smithsonian Astrophysical Observation", "SAO 205880"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.05034166),
        dec: Angle.Degrees(-38.14548110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31349"},
        {"Hipparcos Number", "HIP 22724"},
        {"Smithsonian Astrophysical Observation", "SAO 195381"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.32040335),
        dec: Angle.Degrees(-38.14427982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206532"},
        {"Hipparcos Number", "HIP 107269"},
        {"Smithsonian Astrophysical Observation", "SAO 213237"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.90579074),
        dec: Angle.Degrees(-38.14315458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93122"},
        {"Hipparcos Number", "HIP 52548"},
        {"Smithsonian Astrophysical Observation", "SAO 201699"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.16290049),
        dec: Angle.Degrees(-38.14206530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128445"},
        {"Hipparcos Number", "HIP 71558"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.52876025),
        dec: Angle.Degrees(-38.14101241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208624"},
        {"Hipparcos Number", "HIP 108470"},
        {"Smithsonian Astrophysical Observation", "SAO 213443"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.60403837),
        dec: Angle.Degrees(-38.13933967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61878"},
        {"Henry Draper 2", "HD 61878A"},
        {"Hipparcos Number", "HIP 37322"},
        {"Celescope Catalog", "CEL 1969"},
        {"Geneva Identification System", "GEN# +2.24510182"},
        {"Smithsonian Astrophysical Observation", "SAO 198265"},
        {"Wilson Evans Batten Catalogue", "WEB 7386"},
        {"New General Catalogue", "NGC 2451 182"},
    },
    visualMagnitude: 5.73,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.93262285),
        dec: Angle.Degrees(-38.13932810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5123"},
        {"Hipparcos Number", "HIP 4111"},
        {"Smithsonian Astrophysical Observation", "SAO 192792"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.17538781),
        dec: Angle.Degrees(-38.13793864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120548"},
        {"Hipparcos Number", "HIP 67575"},
        {"Geneva Identification System", "GEN# +1.00120548"},
        {"Smithsonian Astrophysical Observation", "SAO 204901"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.70733626),
        dec: Angle.Degrees(-38.13677519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10049"},
        {"Hipparcos Number", "HIP 7574"},
        {"Smithsonian Astrophysical Observation", "SAO 193214"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.38560427),
        dec: Angle.Degrees(-38.13490573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161653"},
        {"Hipparcos Number", "HIP 87164"},
        {"Geneva Identification System", "GEN# +1.00161653"},
        {"Smithsonian Astrophysical Observation", "SAO 209278"},
        {"Wilson Evans Batten Catalogue", "WEB 14705"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.11722501),
        dec: Angle.Degrees(-38.13349469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10481"},
        {"Hipparcos Number", "HIP 7886"},
        {"Geneva Identification System", "GEN# +1.00010481"},
        {"Smithsonian Astrophysical Observation", "SAO 193255"},
        {"Wilson Evans Batten Catalogue", "WEB 1684"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.36368452),
        dec: Angle.Degrees(-38.13296410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185346"},
        {"Hipparcos Number", "HIP 96768"},
        {"Smithsonian Astrophysical Observation", "SAO 211457"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.05062765),
        dec: Angle.Degrees(-38.13203497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91691"},
        {"Hipparcos Number", "HIP 51761"},
        {"Smithsonian Astrophysical Observation", "SAO 201525"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.63516477),
        dec: Angle.Degrees(-38.12874911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172952"},
        {"Hipparcos Number", "HIP 91957"},
        {"Geneva Identification System", "GEN# +1.00172952"},
        {"Smithsonian Astrophysical Observation", "SAO 210513"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.16714126),
        dec: Angle.Degrees(-38.12849429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3381",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3381"},
        {"Smithsonian Astrophysical Observation", "SAO 192692"},
    },
    visualMagnitude: 10.47,
    bvColour: -0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.74281697),
        dec: Angle.Degrees(-38.12701048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12320"},
        {"Hipparcos Number", "HIP 9336"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.97059132),
        dec: Angle.Degrees(-38.12595550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25841"},
        {"Hipparcos Number", "HIP 18991"},
        {"Smithsonian Astrophysical Observation", "SAO 194733"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.03798083),
        dec: Angle.Degrees(-38.12562764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14960",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14960"},
        {"Smithsonian Astrophysical Observation", "SAO 194162"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.21037357),
        dec: Angle.Degrees(-38.12410241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122137"},
        {"Hipparcos Number", "HIP 68446"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.18807622),
        dec: Angle.Degrees(-38.12398865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59704"},
        {"Hipparcos Number", "HIP 36414"},
        {"Geneva Identification System", "GEN# +1.00059704"},
        {"Smithsonian Astrophysical Observation", "SAO 198055"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.38098000),
        dec: Angle.Degrees(-38.12282841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183377"},
        {"Hipparcos Number", "HIP 95956"},
        {"Geneva Identification System", "GEN# +1.00183377"},
        {"Smithsonian Astrophysical Observation", "SAO 211321"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.70417139),
        dec: Angle.Degrees(-38.12193551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124028"},
        {"Hipparcos Number", "HIP 69370"},
        {"Renson", "Renson 35490"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.99725731),
        dec: Angle.Degrees(-38.12102917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102515"},
        {"Hipparcos Number", "HIP 57554"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.95274989),
        dec: Angle.Degrees(-38.12038176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107845"},
        {"Hipparcos Number", "HIP 60461"},
        {"Geneva Identification System", "GEN# +1.00107845"},
        {"Smithsonian Astrophysical Observation", "SAO 203422"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.92772199),
        dec: Angle.Degrees(-38.12024023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7753"},
        {"Hipparcos Number", "HIP 5960"},
        {"Smithsonian Astrophysical Observation", "SAO 193020"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.16680316),
        dec: Angle.Degrees(-38.11975436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30475"},
        {"Hipparcos Number", "HIP 22179"},
        {"Smithsonian Astrophysical Observation", "SAO 195282"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.58271754),
        dec: Angle.Degrees(-38.11390322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160321"},
        {"Hipparcos Number", "HIP 86530"},
        {"Smithsonian Astrophysical Observation", "SAO 209127"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.25027430),
        dec: Angle.Degrees(-38.11334542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3047"},
        {"Hipparcos Number", "HIP 2645"},
        {"Geneva Identification System", "GEN# +1.00003047"},
        {"Smithsonian Astrophysical Observation", "SAO 192606"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.38488884),
        dec: Angle.Degrees(-38.11333796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90575"},
        {"Hipparcos Number", "HIP 51129"},
        {"Geneva Identification System", "GEN# +1.00090575"},
        {"Smithsonian Astrophysical Observation", "SAO 201396"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.67683894),
        dec: Angle.Degrees(-38.11231335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161390"},
        {"Hipparcos Number", "HIP 87042"},
        {"Geneva Identification System", "GEN# +1.00161390J"},
        {"Smithsonian Astrophysical Observation", "SAO 209246"},
        {"Wilson Evans Batten Catalogue", "WEB 14682"},
    },
    visualMagnitude: 6.41,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.78039682),
        dec: Angle.Degrees(-38.11209711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27454"},
        {"Hipparcos Number", "HIP 20079"},
        {"Geneva Identification System", "GEN# +1.00027454"},
        {"Smithsonian Astrophysical Observation", "SAO 194912"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.57745214),
        dec: Angle.Degrees(-38.10960352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132957"},
        {"Hipparcos Number", "HIP 73640"},
        {"Smithsonian Astrophysical Observation", "SAO 206240"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.78761577),
        dec: Angle.Degrees(-38.10904287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56910"},
        {"Smithsonian Astrophysical Observation", "SAO 202691"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.99991096),
        dec: Angle.Degrees(-38.10871794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101406"},
        {"Hipparcos Number", "HIP 56909"},
        {"Smithsonian Astrophysical Observation", "SAO 202689"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.99390657),
        dec: Angle.Degrees(-38.10831530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16961"},
        {"Hipparcos Number", "HIP 12596"},
        {"Smithsonian Astrophysical Observation", "SAO 193869"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.49114659),
        dec: Angle.Degrees(-38.10769001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83573"},
        {"Geneva Identification System", "GEN# +2.62810005"},
        {"Smithsonian Astrophysical Observation", "SAO 208372"},
        {"New General Catalogue", "NGC 6281 5"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.20285011),
        dec: Angle.Degrees(-38.10728272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145444"},
        {"Hipparcos Number", "HIP 79419"},
        {"Geneva Identification System", "GEN# +1.00145444J"},
        {"Smithsonian Astrophysical Observation", "SAO 207444"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.12652272),
        dec: Angle.Degrees(-38.10649799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105227"},
        {"Hipparcos Number", "HIP 59077"},
        {"Geneva Identification System", "GEN# +1.00105227"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.72816912),
        dec: Angle.Degrees(-38.10633648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54575"},
        {"Smithsonian Astrophysical Observation", "SAO 202152"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.52015282),
        dec: Angle.Degrees(-38.10495377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40216"},
        {"Hipparcos Number", "HIP 28036"},
        {"Geneva Identification System", "GEN# +1.00040216"},
        {"Smithsonian Astrophysical Observation", "SAO 196320"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.92977570),
        dec: Angle.Degrees(-38.10454164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159340"},
        {"Hipparcos Number", "HIP 86119"},
        {"Renson", "Renson 44820"},
        {"Smithsonian Astrophysical Observation", "SAO 209004"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.00270158),
        dec: Angle.Degrees(-38.10211186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77293",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77293"},
        {"Geneva Identification System", "GEN# -0.00403974"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.71195267),
        dec: Angle.Degrees(-05.25660828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108540"},
        {"Hipparcos Number", "HIP 60852"},
        {"Geneva Identification System", "GEN# +1.00108540"},
        {"Smithsonian Astrophysical Observation", "SAO 203507"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.08088644),
        dec: Angle.Degrees(-38.10188966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170641"},
        {"Hipparcos Number", "HIP 90873"},
        {"Geneva Identification System", "GEN# +1.00170641"},
        {"Smithsonian Astrophysical Observation", "SAO 210275"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.05790226),
        dec: Angle.Degrees(-38.09880814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4969",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4969"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.92149094),
        dec: Angle.Degrees(-38.09875453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113404"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.50567894),
        dec: Angle.Degrees(-38.09836052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152331"},
        {"Hipparcos Number", "HIP 82709"},
        {"Smithsonian Astrophysical Observation", "SAO 208162"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.59216046),
        dec: Angle.Degrees(-38.09819468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87023"},
        {"Hipparcos Number", "HIP 49112"},
        {"Smithsonian Astrophysical Observation", "SAO 200968"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.35165525),
        dec: Angle.Degrees(-38.09807709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69525"},
        {"Smithsonian Astrophysical Observation", "SAO 205326"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.48484557),
        dec: Angle.Degrees(-38.09625290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118449"},
        {"Hipparcos Number", "HIP 66478"},
        {"Smithsonian Astrophysical Observation", "SAO 204671"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.43932501),
        dec: Angle.Degrees(-38.09552206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212451"},
        {"Hipparcos Number", "HIP 110656"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.26112194),
        dec: Angle.Degrees(-38.09539296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114075"},
        {"Hipparcos Number", "HIP 64129"},
        {"Smithsonian Astrophysical Observation", "SAO 204162"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.15375030),
        dec: Angle.Degrees(-38.09378627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224046"},
        {"Hipparcos Number", "HIP 117889"},
        {"Smithsonian Astrophysical Observation", "SAO 214857"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.69833937),
        dec: Angle.Degrees(-38.09295844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82048"},
        {"Hipparcos Number", "HIP 46451"},
        {"Smithsonian Astrophysical Observation", "SAO 200401"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.10680695),
        dec: Angle.Degrees(-38.09265062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192882"},
        {"Hipparcos Number", "HIP 100119"},
        {"Smithsonian Astrophysical Observation", "SAO 211986"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.65351458),
        dec: Angle.Degrees(-38.09199050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87041"},
        {"Hipparcos Number", "HIP 49118"},
        {"Smithsonian Astrophysical Observation", "SAO 200972"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.37772513),
        dec: Angle.Degrees(-38.09106130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195814"},
        {"Hipparcos Number", "HIP 101558"},
        {"Geneva Identification System", "GEN# +1.00195814"},
        {"Renson", "Renson 54580"},
        {"Smithsonian Astrophysical Observation", "SAO 212246"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.73109205),
        dec: Angle.Degrees(-38.08986196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215437"},
        {"Hipparcos Number", "HIP 112384"},
        {"Smithsonian Astrophysical Observation", "SAO 214060"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.42625672),
        dec: Angle.Degrees(-38.08609354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204421"},
        {"Hipparcos Number", "HIP 106098"},
        {"Geneva Identification System", "GEN# +1.00204421"},
        {"Smithsonian Astrophysical Observation", "SAO 213036"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.37910449),
        dec: Angle.Degrees(-38.08582468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174197"},
        {"Hipparcos Number", "HIP 92495"},
        {"Smithsonian Astrophysical Observation", "SAO 210627"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.75517341),
        dec: Angle.Degrees(-38.08561933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61583",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61583"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.29300143),
        dec: Angle.Degrees(-38.08257975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77486"},
        {"Hipparcos Number", "HIP 44319"},
        {"Geneva Identification System", "GEN# +1.00077486"},
        {"Smithsonian Astrophysical Observation", "SAO 199893"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.38687171),
        dec: Angle.Degrees(-38.08253054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 176.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164129"},
        {"Hipparcos Number", "HIP 88270"},
        {"Smithsonian Astrophysical Observation", "SAO 209602"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.38260223),
        dec: Angle.Degrees(-38.08220811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79183",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79183"},
        {"Geneva Identification System", "GEN# -0.03710718"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.41801278),
        dec: Angle.Degrees(-38.08037247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81543"},
        {"Hipparcos Number", "HIP 46192"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.27803220),
        dec: Angle.Degrees(-38.07983715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193502"},
        {"Hipparcos Number", "HIP 100433"},
        {"Smithsonian Astrophysical Observation", "SAO 212044"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.50809805),
        dec: Angle.Degrees(-38.07937505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150260"},
        {"Hipparcos Number", "HIP 81708"},
        {"Smithsonian Astrophysical Observation", "SAO 207920"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.34523462),
        dec: Angle.Degrees(-38.07798679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109145"},
        {"Hipparcos Number", "HIP 61226"},
        {"Smithsonian Astrophysical Observation", "SAO 203575"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.19287187),
        dec: Angle.Degrees(-38.07679335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17945"},
        {"Hipparcos Number", "HIP 13353"},
        {"Smithsonian Astrophysical Observation", "SAO 193952"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.95533273),
        dec: Angle.Degrees(-38.07586634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157939"},
        {"Hipparcos Number", "HIP 85478"},
        {"Smithsonian Astrophysical Observation", "SAO 208845"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.02211549),
        dec: Angle.Degrees(-38.07462267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114387"},
        {"Hipparcos Number", "HIP 64297"},
        {"Smithsonian Astrophysical Observation", "SAO 204194"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.67752694),
        dec: Angle.Degrees(-38.07449015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200216"},
        {"Hipparcos Number", "HIP 103921"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.83356597),
        dec: Angle.Degrees(-38.07432254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151396"},
        {"Hipparcos Number", "HIP 82279"},
        {"Smithsonian Astrophysical Observation", "SAO 208054"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.17988141),
        dec: Angle.Degrees(-38.07397751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40706"},
        {"Hipparcos Number", "HIP 28297"},
        {"Smithsonian Astrophysical Observation", "SAO 196376"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.71309735),
        dec: Angle.Degrees(-38.07388782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46476"},
        {"Hipparcos Number", "HIP 31124"},
        {"Geneva Identification System", "GEN# +1.00046476"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.96310729),
        dec: Angle.Degrees(-38.07149510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138285"},
        {"Hipparcos Number", "HIP 76098"},
        {"Geneva Identification System", "GEN# +1.00138285"},
        {"Smithsonian Astrophysical Observation", "SAO 206742"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.12879285),
        dec: Angle.Degrees(-38.07115398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72436"},
    },
    visualMagnitude: 11.67,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.17763055),
        dec: Angle.Degrees(-38.07072057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -210.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189630"},
        {"Hipparcos Number", "HIP 98667"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.61018642),
        dec: Angle.Degrees(-38.07066805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218415"},
        {"Hipparcos Number", "HIP 114239"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.06040297),
        dec: Angle.Degrees(-38.06859578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48987"},
        {"Hipparcos Number", "HIP 32291"},
        {"Smithsonian Astrophysical Observation", "SAO 197155"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.11660400),
        dec: Angle.Degrees(-38.06817113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176891"},
        {"Hipparcos Number", "HIP 93625"},
        {"Geneva Identification System", "GEN# +1.00176891J"},
        {"Smithsonian Astrophysical Observation", "SAO 210867"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.99347437),
        dec: Angle.Degrees(-38.06722381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159633"},
        {"Hipparcos Number", "HIP 86246"},
        {"Geneva Identification System", "GEN# +1.00159633"},
        {"Smithsonian Astrophysical Observation", "SAO 209034"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.36215923),
        dec: Angle.Degrees(-38.06635738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224163"},
        {"Hipparcos Number", "HIP 117967"},
        {"Smithsonian Astrophysical Observation", "SAO 214863"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.91829360),
        dec: Angle.Degrees(-38.06635069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62435",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62435"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.93829936),
        dec: Angle.Degrees(-38.06559912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -235.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197501"},
        {"Hipparcos Number", "HIP 102441"},
        {"Smithsonian Astrophysical Observation", "SAO 212408"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.36883067),
        dec: Angle.Degrees(-38.06544626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30639"},
        {"Hipparcos Number", "HIP 22276"},
        {"Smithsonian Astrophysical Observation", "SAO 195301"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.94347621),
        dec: Angle.Degrees(-38.06528101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214875"},
        {"Hipparcos Number", "HIP 112059"},
        {"Smithsonian Astrophysical Observation", "SAO 214017"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.45877338),
        dec: Angle.Degrees(-38.06482886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42426"},
        {"Hipparcos Number", "HIP 29152"},
        {"Smithsonian Astrophysical Observation", "SAO 196532"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.24103175),
        dec: Angle.Degrees(-38.06480423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157830"},
        {"Hipparcos Number", "HIP 85425"},
        {"Geneva Identification System", "GEN# +1.00157830"},
        {"Smithsonian Astrophysical Observation", "SAO 208832"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.84201147),
        dec: Angle.Degrees(-38.06142218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28233"},
        {"Hipparcos Number", "HIP 20665"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.41126451),
        dec: Angle.Degrees(-38.05954246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53220"},
        {"Hipparcos Number", "HIP 33930"},
        {"Geneva Identification System", "GEN# +1.00053220"},
        {"Smithsonian Astrophysical Observation", "SAO 197510"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.61726172),
        dec: Angle.Degrees(-38.05916776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90917"},
        {"Hipparcos Number", "HIP 51333"},
        {"Geneva Identification System", "GEN# +1.00090917"},
        {"Smithsonian Astrophysical Observation", "SAO 201435"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.27882692),
        dec: Angle.Degrees(-38.05908900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188642"},
        {"Hipparcos Number", "HIP 98226"},
        {"Geneva Identification System", "GEN# +1.00188642"},
        {"Smithsonian Astrophysical Observation", "SAO 211686"},
        {"Wilson Evans Batten Catalogue", "WEB 17328"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.42183233),
        dec: Angle.Degrees(-38.05861811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132604"},
        {"Hipparcos Number", "HIP 73493"},
        {"Geneva Identification System", "GEN# +1.00132604"},
        {"Smithsonian Astrophysical Observation", "SAO 206208"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.30447474),
        dec: Angle.Degrees(-38.05831465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65831"},
        {"Hipparcos Number", "HIP 39030"},
        {"Geneva Identification System", "GEN# +1.00065831"},
        {"Smithsonian Astrophysical Observation", "SAO 198665"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.78224581),
        dec: Angle.Degrees(-38.05106596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1995"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.31584623),
        dec: Angle.Degrees(-38.05082307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122196"},
        {"Hipparcos Number", "HIP 68464"},
        {"Celescope Catalog", "CEL 4292"},
        {"Geneva Identification System", "GEN# +1.00122196"},
        {"Smithsonian Astrophysical Observation", "SAO 205092"},
        {"Wilson Evans Batten Catalogue", "WEB 11997"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.26022758),
        dec: Angle.Degrees(-38.05069609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -452.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200853"},
        {"Hipparcos Number", "HIP 104249"},
        {"Smithsonian Astrophysical Observation", "SAO 212723"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.81197479),
        dec: Angle.Degrees(-38.04776471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215787"},
        {"Hipparcos Number", "HIP 112591"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.04813467),
        dec: Angle.Degrees(-38.04751571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82514",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Xamidimura"},
        {"Henry Draper", "HD 151890"},
        {"Hipparcos Number", "HIP 82514"},
        {"Fundamental Katalog 5th Edition", "FK5 1439"},
        {"Geneva Identification System", "GEN# +1.00151890"},
        {"Smithsonian Astrophysical Observation", "SAO 208102"},
        {"Wilson Evans Batten Catalogue", "WEB 13932"},
    },
    visualMagnitude: 3.00,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.96766195),
        dec: Angle.Degrees(-38.04732717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126337"},
        {"Hipparcos Number", "HIP 70544"},
        {"Smithsonian Astrophysical Observation", "SAO 205545"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.46665155),
        dec: Angle.Degrees(-38.04600220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4750"},
        {"Geneva Identification System", "GEN# -0.03800342"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.26830916),
        dec: Angle.Degrees(-38.04165737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 234.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144503"},
        {"Hipparcos Number", "HIP 79019"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.93477441),
        dec: Angle.Degrees(-38.04000454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24766"},
        {"Hipparcos Number", "HIP 18294"},
        {"Geneva Identification System", "GEN# +1.00024766"},
        {"Smithsonian Astrophysical Observation", "SAO 194619"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.68483107),
        dec: Angle.Degrees(-38.03905415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216678"},
        {"Hipparcos Number", "HIP 113193"},
        {"Fundamental Katalog 5th Edition", "FK5 6026"},
        {"Smithsonian Astrophysical Observation", "SAO 214183"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.84428282),
        dec: Angle.Degrees(-38.03903960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144225"},
        {"Hipparcos Number", "HIP 78881"},
        {"Smithsonian Astrophysical Observation", "SAO 207327"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.53915827),
        dec: Angle.Degrees(-38.03833161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57355"},
        {"Hipparcos Number", "HIP 35450"},
        {"Fundamental Katalog 5th Edition", "FK5 4658"},
        {"Smithsonian Astrophysical Observation", "SAO 197843"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.78575761),
        dec: Angle.Degrees(-38.03808748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213589"},
        {"Hipparcos Number", "HIP 111320"},
        {"Smithsonian Astrophysical Observation", "SAO 213899"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.28258347),
        dec: Angle.Degrees(-38.03725569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106181"},
        {"Hipparcos Number", "HIP 59584"},
        {"Geneva Identification System", "GEN# +1.00106181"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.28122571),
        dec: Angle.Degrees(-38.03645608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52734"},
        {"Hipparcos Number", "HIP 33741"},
        {"Geneva Identification System", "GEN# +1.00052734"},
        {"Smithsonian Astrophysical Observation", "SAO 197472"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.14429878),
        dec: Angle.Degrees(-38.03592690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140974"},
        {"Hipparcos Number", "HIP 77395"},
        {"Smithsonian Astrophysical Observation", "SAO 206987"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.98719564),
        dec: Angle.Degrees(-38.03427182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22286"},
        {"Hipparcos Number", "HIP 16617"},
        {"Geneva Identification System", "GEN# +1.00022286"},
        {"Smithsonian Astrophysical Observation", "SAO 194376"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.45473528),
        dec: Angle.Degrees(-38.03406312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116448"},
        {"Hipparcos Number", "HIP 65409"},
        {"Geneva Identification System", "GEN# +1.00116448"},
        {"Smithsonian Astrophysical Observation", "SAO 204431"},
        {"Wilson Evans Batten Catalogue", "WEB 11543"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.09603640),
        dec: Angle.Degrees(-38.03339214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28741"},
        {"Hipparcos Number", "HIP 20999"},
        {"Smithsonian Astrophysical Observation", "SAO 195077"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.54548527),
        dec: Angle.Degrees(-38.02942359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44914"},
    },
    visualMagnitude: 11.09,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.25280244),
        dec: Angle.Degrees(-38.02874044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 194.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54841"},
        {"Hipparcos Number", "HIP 34475"},
        {"Smithsonian Astrophysical Observation", "SAO 197628"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.18112614),
        dec: Angle.Degrees(-38.02840595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169942"},
        {"Hipparcos Number", "HIP 90562"},
        {"Geneva Identification System", "GEN# +1.00169942"},
        {"Smithsonian Astrophysical Observation", "SAO 210203"},
        {"Wilson Evans Batten Catalogue", "WEB 15510"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.19355726),
        dec: Angle.Degrees(-38.02836192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62948",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62948"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.48935042),
        dec: Angle.Degrees(-38.02641506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196104"},
        {"Hipparcos Number", "HIP 101678"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.14906171),
        dec: Angle.Degrees(-38.02549288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37496"},
        {"Hipparcos Number", "HIP 26420"},
        {"Smithsonian Astrophysical Observation", "SAO 196029"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.34070943),
        dec: Angle.Degrees(-38.02289300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156688"},
        {"Hipparcos Number", "HIP 84865"},
        {"Geneva Identification System", "GEN# +1.00156688"},
        {"Smithsonian Astrophysical Observation", "SAO 208703"},
        {"Wilson Evans Batten Catalogue", "WEB 14327"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.17900372),
        dec: Angle.Degrees(-38.02059022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19988"},
        {"Hipparcos Number", "HIP 14820"},
        {"Geneva Identification System", "GEN# +1.00019988"},
        {"Smithsonian Astrophysical Observation", "SAO 194143"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.84099205),
        dec: Angle.Degrees(-38.01879999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82545",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Pipirima"},
        {"Henry Draper", "HD 151985"},
        {"Hipparcos Number", "HIP 82545"},
        {"Geneva Identification System", "GEN# +1.00151985"},
        {"Smithsonian Astrophysical Observation", "SAO 208116"},
        {"Wilson Evans Batten Catalogue", "WEB 13939"},
    },
    visualMagnitude: 3.56,
    bvColour: -0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.08397295),
        dec: Angle.Degrees(-38.01747781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203950"},
        {"Hipparcos Number", "HIP 105851"},
        {"Smithsonian Astrophysical Observation", "SAO 212997"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.58504979),
        dec: Angle.Degrees(-38.01729144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26852"},
        {"Hipparcos Number", "HIP 19695"},
        {"Smithsonian Astrophysical Observation", "SAO 194839"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.28750499),
        dec: Angle.Degrees(-38.01596053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98161"},
        {"Hipparcos Number", "HIP 55130"},
        {"Geneva Identification System", "GEN# +1.00098161"},
        {"Smithsonian Astrophysical Observation", "SAO 202283"},
        {"Wilson Evans Batten Catalogue", "WEB 9938"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.30025601),
        dec: Angle.Degrees(-38.01438940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122174"},
        {"Hipparcos Number", "HIP 68460"},
        {"Geneva Identification System", "GEN# +1.00122174"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.22619952),
        dec: Angle.Degrees(-38.01380303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134343"},
        {"Hipparcos Number", "HIP 74258"},
        {"Smithsonian Astrophysical Observation", "SAO 206361"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.64286925),
        dec: Angle.Degrees(-38.01354886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172004"},
        {"Hipparcos Number", "HIP 91474"},
        {"Geneva Identification System", "GEN# +1.00172004"},
        {"Smithsonian Astrophysical Observation", "SAO 210407"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.85221757),
        dec: Angle.Degrees(-38.01295109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21764"},
        {"Hipparcos Number", "HIP 16232"},
        {"Smithsonian Astrophysical Observation", "SAO 194330"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.29724763),
        dec: Angle.Degrees(-38.01163190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59392"},
        {"Hipparcos Number", "HIP 36269"},
        {"Geneva Identification System", "GEN# +1.00059392"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.01292754),
        dec: Angle.Degrees(-38.01080953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -270.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63488"},
        {"Hipparcos Number", "HIP 38030"},
        {"Celescope Catalog", "CEL 2037"},
        {"Geneva Identification System", "GEN# +2.24510284"},
        {"Smithsonian Astrophysical Observation", "SAO 198446"},
        {"New General Catalogue", "NGC 2451 284"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.90052229),
        dec: Angle.Degrees(-38.01076777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61453"},
        {"Hipparcos Number", "HIP 37128"},
        {"Geneva Identification System", "GEN# +2.24510154"},
        {"Smithsonian Astrophysical Observation", "SAO 198210"},
        {"New General Catalogue", "NGC 2451 154"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.43762447),
        dec: Angle.Degrees(-38.01057175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8631",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8631"},
    },
    visualMagnitude: 11.48,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.83399013),
        dec: Angle.Degrees(-38.00998842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 198.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90132"},
        {"Hipparcos Number", "HIP 50888"},
        {"Fundamental Katalog 5th Edition", "FK5 1269"},
        {"Geneva Identification System", "GEN# +1.00090132"},
        {"Smithsonian Astrophysical Observation", "SAO 201346"},
        {"Wilson Evans Batten Catalogue", "WEB 9310"},
    },
    visualMagnitude: 5.34,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.87255727),
        dec: Angle.Degrees(-38.00970922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73653"},
        {"Hipparcos Number", "HIP 42354"},
        {"Celescope Catalog", "CEL 2726"},
        {"Geneva Identification System", "GEN# +1.00073653"},
        {"Smithsonian Astrophysical Observation", "SAO 199447"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.52365041),
        dec: Angle.Degrees(-38.00901018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105713"},
        {"Hipparcos Number", "HIP 59322"},
        {"Geneva Identification System", "GEN# +1.00105713"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.54852678),
        dec: Angle.Degrees(-38.00874175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58688"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.55520156),
        dec: Angle.Degrees(-38.00740883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -249.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10613"},
        {"Hipparcos Number", "HIP 8002"},
        {"Geneva Identification System", "GEN# +1.00010613"},
        {"Smithsonian Astrophysical Observation", "SAO 193265"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.68743054),
        dec: Angle.Degrees(-38.00532090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75444"},
        {"Hipparcos Number", "HIP 43258"},
        {"Smithsonian Astrophysical Observation", "SAO 199652"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.18066297),
        dec: Angle.Degrees(-38.00392692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48524"},
        {"Hipparcos Number", "HIP 32075"},
        {"Smithsonian Astrophysical Observation", "SAO 197103"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.52303604),
        dec: Angle.Degrees(-38.00379925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156468"},
        {"Hipparcos Number", "HIP 84745"},
        {"Geneva Identification System", "GEN# +1.00156468"},
        {"Smithsonian Astrophysical Observation", "SAO 208681"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.85061094),
        dec: Angle.Degrees(-38.00368116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176554"},
        {"Hipparcos Number", "HIP 93503"},
        {"Smithsonian Astrophysical Observation", "SAO 210849"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.64410254),
        dec: Angle.Degrees(-38.00201270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3597"},
        {"Hipparcos Number", "HIP 3027"},
        {"Geneva Identification System", "GEN# +1.00003597"},
        {"Smithsonian Astrophysical Observation", "SAO 192650"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.63468032),
        dec: Angle.Degrees(-37.99889156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214123"},
        {"Hipparcos Number", "HIP 111618"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.18365745),
        dec: Angle.Degrees(-37.99822175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49795"},
        {"Hipparcos Number", "HIP 32625"},
        {"Smithsonian Astrophysical Observation", "SAO 197233"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.09194151),
        dec: Angle.Degrees(-37.99807541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3173"},
        {"Hipparcos Number", "HIP 2723"},
        {"Smithsonian Astrophysical Observation", "SAO 192621"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.66823111),
        dec: Angle.Degrees(-37.99600207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47805"},
        {"Hipparcos Number", "HIP 31773"},
        {"Celescope Catalog", "CEL 1341"},
        {"Geneva Identification System", "GEN# +1.00047805"},
        {"Smithsonian Astrophysical Observation", "SAO 197035"},
    },
    visualMagnitude: 7.15,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.66509173),
        dec: Angle.Degrees(-37.99593520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32277"},
        {"Hipparcos Number", "HIP 23249"},
        {"Smithsonian Astrophysical Observation", "SAO 195477"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.04881010),
        dec: Angle.Degrees(-37.99456989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38952"},
        {"Hipparcos Number", "HIP 27357"},
        {"Renson", "Renson 10470"},
        {"Smithsonian Astrophysical Observation", "SAO 196178"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.90988697),
        dec: Angle.Degrees(-37.99427699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186914"},
        {"Hipparcos Number", "HIP 97467"},
        {"Smithsonian Astrophysical Observation", "SAO 211567"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.16315289),
        dec: Angle.Degrees(-37.99387501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18636"},
        {"Hipparcos Number", "HIP 13865"},
        {"Fundamental Katalog 5th Edition", "FK5 4271"},
        {"Geneva Identification System", "GEN# +1.00018636"},
        {"Smithsonian Astrophysical Observation", "SAO 194015"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.63939619),
        dec: Angle.Degrees(-37.99231894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 322658"},
        {"Hipparcos Number", "HIP 83559"},
        {"Geneva Identification System", "GEN# +2.62810004"},
        {"New General Catalogue", "NGC 6281 4"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.14990054),
        dec: Angle.Degrees(-37.99194831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142017"},
        {"Hipparcos Number", "HIP 77837"},
        {"Smithsonian Astrophysical Observation", "SAO 207087"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.40047732),
        dec: Angle.Degrees(-37.99114634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16589"},
        {"Hipparcos Number", "HIP 12300"},
        {"Fundamental Katalog 5th Edition", "FK5 2184"},
        {"Geneva Identification System", "GEN# +1.00016589"},
        {"Smithsonian Astrophysical Observation", "SAO 193834"},
        {"Wilson Evans Batten Catalogue", "WEB 2522"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.60312581),
        dec: Angle.Degrees(-37.99039371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114654",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114654"},
        {"Smithsonian Astrophysical Observation", "SAO 214391"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.38628337),
        dec: Angle.Degrees(-37.98711551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217434"},
        {"Hipparcos Number", "HIP 113655"},
        {"Smithsonian Astrophysical Observation", "SAO 214249"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.27536991),
        dec: Angle.Degrees(-37.98693792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103174"},
        {"Hipparcos Number", "HIP 57912"},
        {"Geneva Identification System", "GEN# +1.00103174"},
        {"Smithsonian Astrophysical Observation", "SAO 202899"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.17595314),
        dec: Angle.Degrees(-37.98680707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117524"},
        {"Smithsonian Astrophysical Observation", "SAO 214800"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.51276851),
        dec: Angle.Degrees(-37.98587048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -275.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4113"},
        {"Hipparcos Number", "HIP 3391"},
        {"Geneva Identification System", "GEN# +1.00004113"},
        {"Smithsonian Astrophysical Observation", "SAO 192693"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.80233084),
        dec: Angle.Degrees(-37.98235299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116551"},
        {"Hipparcos Number", "HIP 65454"},
        {"Smithsonian Astrophysical Observation", "SAO 204444"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.22947038),
        dec: Angle.Degrees(-37.98176548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64502"},
        {"Hipparcos Number", "HIP 38459"},
        {"Geneva Identification System", "GEN# +1.00064502"},
        {"Smithsonian Astrophysical Observation", "SAO 198546"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.17374862),
        dec: Angle.Degrees(-37.97960204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24835"},
        {"Hipparcos Number", "HIP 18355"},
        {"Geneva Identification System", "GEN# +1.00024835"},
        {"Smithsonian Astrophysical Observation", "SAO 194628"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.86159557),
        dec: Angle.Degrees(-37.97880536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181376"},
        {"Hipparcos Number", "HIP 95190"},
        {"Smithsonian Astrophysical Observation", "SAO 211207"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.46409097),
        dec: Angle.Degrees(-37.97828598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99882",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99882"},
        {"Smithsonian Astrophysical Observation", "SAO 211938"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.97308889),
        dec: Angle.Degrees(-37.97781509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174760"},
        {"Hipparcos Number", "HIP 92734"},
        {"Smithsonian Astrophysical Observation", "SAO 210683"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.45606391),
        dec: Angle.Degrees(-37.97652573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223009"},
        {"Hipparcos Number", "HIP 117213"},
        {"Geneva Identification System", "GEN# +1.00223009"},
        {"Smithsonian Astrophysical Observation", "SAO 214760"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.49869759),
        dec: Angle.Degrees(-37.97586513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104659"},
        {"Hipparcos Number", "HIP 58764"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.77623814),
        dec: Angle.Degrees(-37.97428774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148546"},
        {"Hipparcos Number", "HIP 80829"},
        {"Geneva Identification System", "GEN# +1.00148546"},
        {"Smithsonian Astrophysical Observation", "SAO 207720"},
        {"Wilson Evans Batten Catalogue", "WEB 13670"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.59713503),
        dec: Angle.Degrees(-37.97253585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49751"},
        {"Hipparcos Number", "HIP 32605"},
        {"Smithsonian Astrophysical Observation", "SAO 197228"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.04125744),
        dec: Angle.Degrees(-37.97079027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5229"},
        {"Hipparcos Number", "HIP 4204"},
        {"Geneva Identification System", "GEN# +1.00005229"},
        {"Smithsonian Astrophysical Observation", "SAO 192799"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.41476493),
        dec: Angle.Degrees(-37.97040328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210382"},
        {"Hipparcos Number", "HIP 109489"},
        {"Smithsonian Astrophysical Observation", "SAO 213612"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.70757113),
        dec: Angle.Degrees(-37.96985175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 274.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63032"},
        {"Hipparcos Number", "HIP 37819"},
        {"Fundamental Katalog 5th Edition", "FK5 2605"},
        {"Geneva Identification System", "GEN# +2.24510254"},
        {"Smithsonian Astrophysical Observation", "SAO 198398"},
        {"Wilson Evans Batten Catalogue", "WEB 7470"},
        {"New General Catalogue", "NGC 2451 254"},
    },
    visualMagnitude: 3.62,
    bvColour: 1.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.31376631),
        dec: Angle.Degrees(-37.96859848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108633"},
        {"Hipparcos Number", "HIP 60901"},
        {"Smithsonian Astrophysical Observation", "SAO 203515"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.22241903),
        dec: Angle.Degrees(-37.96688518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74771"},
        {"Hipparcos Number", "HIP 42901"},
        {"Smithsonian Astrophysical Observation", "SAO 199569"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.14185448),
        dec: Angle.Degrees(-37.96462059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199243"},
        {"Hipparcos Number", "HIP 103416"},
        {"Smithsonian Astrophysical Observation", "SAO 212571"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.29518931),
        dec: Angle.Degrees(-37.96317720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41424"},
        {"Hipparcos Number", "HIP 28670"},
        {"Smithsonian Astrophysical Observation", "SAO 196448"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.80336904),
        dec: Angle.Degrees(-37.96282454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33074"},
        {"Hipparcos Number", "HIP 23725"},
        {"Smithsonian Astrophysical Observation", "SAO 195560"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.51173964),
        dec: Angle.Degrees(-37.96253576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201578"},
        {"Hipparcos Number", "HIP 104625"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.90728957),
        dec: Angle.Degrees(-37.96006803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9066"},
        {"Hipparcos Number", "HIP 6877"},
        {"Smithsonian Astrophysical Observation", "SAO 193133"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.14215938),
        dec: Angle.Degrees(-37.95952708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124595"},
        {"Hipparcos Number", "HIP 69660"},
        {"Geneva Identification System", "GEN# +1.00124595"},
        {"Smithsonian Astrophysical Observation", "SAO 205357"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.85336030),
        dec: Angle.Degrees(-37.95887411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129764"},
        {"Hipparcos Number", "HIP 72155"},
        {"Geneva Identification System", "GEN# +1.00129764"},
        {"Smithsonian Astrophysical Observation", "SAO 205906"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.37810455),
        dec: Angle.Degrees(-37.95653732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176424"},
        {"Hipparcos Number", "HIP 93447"},
        {"Smithsonian Astrophysical Observation", "SAO 210835"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.47148680),
        dec: Angle.Degrees(-37.95286815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61452"},
        {"Hipparcos Number", "HIP 37123"},
        {"Geneva Identification System", "GEN# +2.24510153"},
        {"Smithsonian Astrophysical Observation", "SAO 198208"},
        {"New General Catalogue", "NGC 2451 153"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.42491355),
        dec: Angle.Degrees(-37.95254850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155416"},
        {"Hipparcos Number", "HIP 84238"},
        {"Geneva Identification System", "GEN# +1.00155416"},
        {"Smithsonian Astrophysical Observation", "SAO 208541"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.28927097),
        dec: Angle.Degrees(-37.95236921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207104"},
        {"Hipparcos Number", "HIP 107593"},
        {"Geneva Identification System", "GEN# +1.00207104"},
        {"Smithsonian Astrophysical Observation", "SAO 213288"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.89421827),
        dec: Angle.Degrees(-37.95198170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124920"},
        {"Hipparcos Number", "HIP 69812"},
        {"Smithsonian Astrophysical Observation", "SAO 205390"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.31523819),
        dec: Angle.Degrees(-37.94873148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 211"},
        {"Smithsonian Astrophysical Observation", "SAO 192334"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.66317884),
        dec: Angle.Degrees(-37.94768074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133716"},
        {"Hipparcos Number", "HIP 73974"},
        {"Celescope Catalog", "CEL 4338"},
        {"Geneva Identification System", "GEN# +1.00133716"},
        {"Smithsonian Astrophysical Observation", "SAO 206306"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.77584990),
        dec: Angle.Degrees(-37.94562528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211175"},
        {"Hipparcos Number", "HIP 109948"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.02461315),
        dec: Angle.Degrees(-37.94553556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209118"},
        {"Hipparcos Number", "HIP 108764"},
        {"Smithsonian Astrophysical Observation", "SAO 213485"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.48618725),
        dec: Angle.Degrees(-37.94481904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110387"},
        {"Hipparcos Number", "HIP 61975"},
        {"Smithsonian Astrophysical Observation", "SAO 203722"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.50878336),
        dec: Angle.Degrees(-37.94348624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62893"},
        {"Hipparcos Number", "HIP 37752"},
        {"Celescope Catalog", "CEL 2009"},
        {"Geneva Identification System", "GEN# +2.24510246"},
        {"Smithsonian Astrophysical Observation", "SAO 198379"},
        {"Wilson Evans Batten Catalogue", "WEB 7463"},
        {"New General Catalogue", "NGC 2451 246"},
    },
    visualMagnitude: 5.89,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.14249707),
        dec: Angle.Degrees(-37.94295545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71625"},
        {"Hipparcos Number", "HIP 41436"},
        {"Smithsonian Astrophysical Observation", "SAO 199242"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.76447051),
        dec: Angle.Degrees(-37.94276731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189831"},
        {"Hipparcos Number", "HIP 98761"},
        {"Fundamental Katalog 5th Edition", "FK5 3602"},
        {"Geneva Identification System", "GEN# +1.00189831"},
        {"Smithsonian Astrophysical Observation", "SAO 211767"},
        {"Wilson Evans Batten Catalogue", "WEB 17496"},
    },
    visualMagnitude: 4.77,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.88921406),
        dec: Angle.Degrees(-37.94049103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34046"},
        {"Hipparcos Number", "HIP 24291"},
        {"Geneva Identification System", "GEN# +1.00034046"},
        {"Smithsonian Astrophysical Observation", "SAO 195656"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.19439587),
        dec: Angle.Degrees(-37.93901114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 205.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153330"},
        {"Hipparcos Number", "HIP 83214"},
        {"Geneva Identification System", "GEN# +1.00153330"},
        {"Smithsonian Astrophysical Observation", "SAO 208287"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.10615741),
        dec: Angle.Degrees(-37.93718598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216988"},
        {"Hipparcos Number", "HIP 113392"},
        {"Smithsonian Astrophysical Observation", "SAO 214208"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.47181511),
        dec: Angle.Degrees(-37.93502182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63215"},
        {"Hipparcos Number", "HIP 37915"},
        {"Celescope Catalog", "CEL 2024"},
        {"Geneva Identification System", "GEN# +2.24510267"},
        {"Smithsonian Astrophysical Observation", "SAO 198416"},
        {"Wilson Evans Batten Catalogue", "WEB 7483"},
        {"New General Catalogue", "NGC 2451 267"},
    },
    visualMagnitude: 5.87,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.54399474),
        dec: Angle.Degrees(-37.93370008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77648"},
        {"Hipparcos Number", "HIP 44389"},
        {"Smithsonian Astrophysical Observation", "SAO 199911"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.63386396),
        dec: Angle.Degrees(-37.93328001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206343"},
        {"Hipparcos Number", "HIP 107170"},
        {"Smithsonian Astrophysical Observation", "SAO 213217"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.62114671),
        dec: Angle.Degrees(-37.93321772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201228"},
        {"Hipparcos Number", "HIP 104434"},
        {"Geneva Identification System", "GEN# +1.00201228"},
        {"Smithsonian Astrophysical Observation", "SAO 212751"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.32581443),
        dec: Angle.Degrees(-37.93311048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58014"},
        {"Hipparcos Number", "HIP 35711"},
        {"Smithsonian Astrophysical Observation", "SAO 197903"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.51171598),
        dec: Angle.Degrees(-37.93264763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136332"},
        {"Hipparcos Number", "HIP 75146"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.35718952),
        dec: Angle.Degrees(-37.93063291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107172"},
        {"Smithsonian Astrophysical Observation", "SAO 213218"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.62711181),
        dec: Angle.Degrees(-37.93045963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72964"},
    },
    visualMagnitude: 11.20,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.67172265),
        dec: Angle.Degrees(-37.93012215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49591"},
        {"Hipparcos Number", "HIP 32537"},
        {"Celescope Catalog", "CEL 1388"},
        {"Fundamental Katalog 5th Edition", "FK5 1178"},
        {"Geneva Identification System", "GEN# +1.00049591"},
        {"Smithsonian Astrophysical Observation", "SAO 197215"},
        {"Wilson Evans Batten Catalogue", "WEB 6563"},
    },
    visualMagnitude: 5.27,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.83919491),
        dec: Angle.Degrees(-37.92967246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243"},
        {"Hipparcos Number", "HIP 587"},
        {"Geneva Identification System", "GEN# +1.00000243"},
        {"Smithsonian Astrophysical Observation", "SAO 192362"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.78443728),
        dec: Angle.Degrees(-37.92914178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96316"},
        {"Hipparcos Number", "HIP 54247"},
        {"Smithsonian Astrophysical Observation", "SAO 202082"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.46684237),
        dec: Angle.Degrees(-37.92904535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17084"},
        {"Hipparcos Number", "HIP 12716"},
        {"Geneva Identification System", "GEN# +1.00017084"},
        {"Smithsonian Astrophysical Observation", "SAO 193879"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.85628572),
        dec: Angle.Degrees(-37.92830354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121205"},
        {"Hipparcos Number", "HIP 67941"},
        {"Geneva Identification System", "GEN# +1.00121205"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.70171091),
        dec: Angle.Degrees(-37.92817065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103176"},
        {"Smithsonian Astrophysical Observation", "SAO 212529"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.56675716),
        dec: Angle.Degrees(-37.92703755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14926"},
        {"Hipparcos Number", "HIP 11144"},
        {"Smithsonian Astrophysical Observation", "SAO 193684"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.84876445),
        dec: Angle.Degrees(-37.92557687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195264"},
        {"Hipparcos Number", "HIP 101275"},
        {"Geneva Identification System", "GEN# +1.00195264"},
        {"Smithsonian Astrophysical Observation", "SAO 212200"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.92594720),
        dec: Angle.Degrees(-37.92465582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68862"},
        {"Hipparcos Number", "HIP 40220"},
        {"Celescope Catalog", "CEL 2241"},
        {"Geneva Identification System", "GEN# +2.25460575"},
        {"Smithsonian Astrophysical Observation", "SAO 198942"},
        {"New General Catalogue", "NGC 2546 575"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.21482669),
        dec: Angle.Degrees(-37.92446687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14390"},
        {"Hipparcos Number", "HIP 10762"},
        {"Smithsonian Astrophysical Observation", "SAO 193637"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.62684316),
        dec: Angle.Degrees(-37.92289433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52190"},
    },
    visualMagnitude: 11.02,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.93420037),
        dec: Angle.Degrees(-37.92011347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140076"},
        {"Hipparcos Number", "HIP 76987"},
        {"Smithsonian Astrophysical Observation", "SAO 206896"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.79569415),
        dec: Angle.Degrees(-37.91820040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72572"},
        {"Hipparcos Number", "HIP 41870"},
        {"Geneva Identification System", "GEN# +1.00072572"},
        {"Smithsonian Astrophysical Observation", "SAO 199343"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.06738711),
        dec: Angle.Degrees(-37.91809219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140901"},
        {"Hipparcos Number", "HIP 77358"},
        {"Cincinnati Publication", "Ci 20 946"},
        {"Geneva Identification System", "GEN# +1.00140901A"},
        {"Smithsonian Astrophysical Observation", "SAO 206976"},
        {"Wilson Evans Batten Catalogue", "WEB 13102"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.87253619),
        dec: Angle.Degrees(-37.91579230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -416.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -213.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205474"},
        {"Hipparcos Number", "HIP 106680"},
        {"Smithsonian Astrophysical Observation", "SAO 213132"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.11839540),
        dec: Angle.Degrees(-37.91423741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115051"},
        {"Hipparcos Number", "HIP 64649"},
        {"Smithsonian Astrophysical Observation", "SAO 204281"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.78939368),
        dec: Angle.Degrees(-37.91342212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198357"},
        {"Hipparcos Number", "HIP 102916"},
        {"Geneva Identification System", "GEN# +1.00198357"},
        {"Smithsonian Astrophysical Observation", "SAO 212488"},
        {"Wilson Evans Batten Catalogue", "WEB 18667"},
    },
    visualMagnitude: 5.52,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.75317995),
        dec: Angle.Degrees(-37.91328991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154769"},
        {"Hipparcos Number", "HIP 83922"},
        {"Smithsonian Astrophysical Observation", "SAO 208470"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.28464147),
        dec: Angle.Degrees(-37.91259972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190531"},
        {"Hipparcos Number", "HIP 99073"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.70505450),
        dec: Angle.Degrees(-37.91227337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120629"},
        {"Hipparcos Number", "HIP 67624"},
        {"Smithsonian Astrophysical Observation", "SAO 204908"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.84667667),
        dec: Angle.Degrees(-37.91212497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73440"},
        {"Hipparcos Number", "HIP 42268"},
        {"Smithsonian Astrophysical Observation", "SAO 199429"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.28459950),
        dec: Angle.Degrees(-37.91058537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2585"},
        {"Hipparcos Number", "HIP 2286"},
        {"Geneva Identification System", "GEN# +1.00002585"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.30052001),
        dec: Angle.Degrees(-37.90848297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 322659"},
        {"Hipparcos Number", "HIP 83561"},
        {"Geneva Identification System", "GEN# +2.62810011"},
        {"New General Catalogue", "NGC 6281 11"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.15155719),
        dec: Angle.Degrees(-37.90752191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123890"},
        {"Hipparcos Number", "HIP 69307"},
        {"Smithsonian Astrophysical Observation", "SAO 205274"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.78767634),
        dec: Angle.Degrees(-37.90502337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94114",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Meridiana"},
        {"Henry Draper", "HD 178253"},
        {"Hipparcos Number", "HIP 94114"},
        {"Fundamental Katalog 5th Edition", "FK5 718"},
        {"Geneva Identification System", "GEN# +1.00178253"},
        {"Smithsonian Astrophysical Observation", "SAO 210990"},
        {"Wilson Evans Batten Catalogue", "WEB 16389"},
    },
    visualMagnitude: 4.11,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.36782635),
        dec: Angle.Degrees(-37.90423953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110456"},
        {"Hipparcos Number", "HIP 62009"},
        {"Geneva Identification System", "GEN# +1.00110456"},
        {"Smithsonian Astrophysical Observation", "SAO 203731"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.63416352),
        dec: Angle.Degrees(-37.90277983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224949"},
        {"Hipparcos Number", "HIP 158"},
        {"Smithsonian Astrophysical Observation", "SAO 214933"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.50047134),
        dec: Angle.Degrees(-37.90179046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31838"},
        {"Hipparcos Number", "HIP 23042"},
        {"Geneva Identification System", "GEN# +1.00031838"},
        {"Smithsonian Astrophysical Observation", "SAO 195431"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.33443821),
        dec: Angle.Degrees(-37.89907408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6790"},
        {"Hipparcos Number", "HIP 5311"},
        {"Geneva Identification System", "GEN# +1.00006790"},
        {"Smithsonian Astrophysical Observation", "SAO 192940"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.99001318),
        dec: Angle.Degrees(-37.89820801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63251"},
        {"Hipparcos Number", "HIP 37925"},
        {"Geneva Identification System", "GEN# +2.24510268"},
        {"Smithsonian Astrophysical Observation", "SAO 198419"},
        {"Wilson Evans Batten Catalogue", "WEB 7485"},
        {"New General Catalogue", "NGC 2451 268"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.57882740),
        dec: Angle.Degrees(-37.89774821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45680"},
        {"Hipparcos Number", "HIP 30706"},
        {"Geneva Identification System", "GEN# +1.00045680"},
        {"Smithsonian Astrophysical Observation", "SAO 196842"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.78160751),
        dec: Angle.Degrees(-37.89561574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166149"},
        {"Hipparcos Number", "HIP 89101"},
        {"Smithsonian Astrophysical Observation", "SAO 209819"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.77686180),
        dec: Angle.Degrees(-37.89350694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150211"},
        {"Hipparcos Number", "HIP 81675"},
        {"Smithsonian Astrophysical Observation", "SAO 207915"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.26974572),
        dec: Angle.Degrees(-37.89159027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21534"},
        {"Hipparcos Number", "HIP 16080"},
        {"Geneva Identification System", "GEN# +1.00021534"},
        {"Smithsonian Astrophysical Observation", "SAO 194307"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.77494548),
        dec: Angle.Degrees(-37.89074595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155507"},
        {"Hipparcos Number", "HIP 84280"},
        {"Smithsonian Astrophysical Observation", "SAO 208554"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.43505265),
        dec: Angle.Degrees(-37.89003326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16078"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.77155110),
        dec: Angle.Degrees(-37.88839016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62991"},
        {"Hipparcos Number", "HIP 37803"},
        {"Celescope Catalog", "CEL 2014"},
        {"Geneva Identification System", "GEN# +2.24510251"},
        {"Smithsonian Astrophysical Observation", "SAO 198390"},
        {"Wilson Evans Batten Catalogue", "WEB 7468"},
        {"New General Catalogue", "NGC 2451 251"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.26992147),
        dec: Angle.Degrees(-37.88788349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205046"},
        {"Hipparcos Number", "HIP 106443"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.39437158),
        dec: Angle.Degrees(-37.88662749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125473"},
        {"Hipparcos Number", "HIP 70090"},
        {"Celescope Catalog", "CEL 4314"},
        {"Fundamental Katalog 5th Edition", "FK5 1373"},
        {"Geneva Identification System", "GEN# +1.00125473"},
        {"Smithsonian Astrophysical Observation", "SAO 205453"},
        {"Wilson Evans Batten Catalogue", "WEB 12185"},
    },
    visualMagnitude: 4.05,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.13949709),
        dec: Angle.Degrees(-37.88526711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23669"},
        {"Hipparcos Number", "HIP 17551"},
        {"Smithsonian Astrophysical Observation", "SAO 194507"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.38269110),
        dec: Angle.Degrees(-37.88325848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163726"},
        {"Hipparcos Number", "HIP 88081"},
        {"Wilson Evans Batten Catalogue", "WEB 14878"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.83460235),
        dec: Angle.Degrees(-37.88126745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132238"},
        {"Hipparcos Number", "HIP 73341"},
        {"Fundamental Katalog 5th Edition", "FK5 3180"},
        {"Geneva Identification System", "GEN# +1.00132238"},
        {"Smithsonian Astrophysical Observation", "SAO 206167"},
        {"Wilson Evans Batten Catalogue", "WEB 12559"},
    },
    visualMagnitude: 6.45,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.80807905),
        dec: Angle.Degrees(-37.88118275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88453"},
        {"Hipparcos Number", "HIP 49891"},
        {"Fundamental Katalog 5th Edition", "FK5 4906"},
        {"Smithsonian Astrophysical Observation", "SAO 201142"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.80178654),
        dec: Angle.Degrees(-37.87742838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74978"},
        {"Hipparcos Number", "HIP 43005"},
        {"Smithsonian Astrophysical Observation", "SAO 199590"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.46296885),
        dec: Angle.Degrees(-37.87733728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189931"},
        {"Hipparcos Number", "HIP 98813"},
        {"Cincinnati Publication", "Ci 20 1182"},
        {"Geneva Identification System", "GEN# +1.00189931"},
        {"Smithsonian Astrophysical Observation", "SAO 211778"},
        {"Wilson Evans Batten Catalogue", "WEB 17511"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.01091585),
        dec: Angle.Degrees(-37.87554693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -388.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132433"},
        {"Hipparcos Number", "HIP 73426"},
        {"Smithsonian Astrophysical Observation", "SAO 206193"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.07971925),
        dec: Angle.Degrees(-37.87063781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105776"},
        {"Hipparcos Number", "HIP 59353"},
        {"Fundamental Katalog 5th Edition", "FK5 2974"},
        {"Geneva Identification System", "GEN# +1.00105776"},
        {"Smithsonian Astrophysical Observation", "SAO 203195"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.64075945),
        dec: Angle.Degrees(-37.87026816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222467"},
        {"Hipparcos Number", "HIP 116844"},
        {"Smithsonian Astrophysical Observation", "SAO 214705"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.25406470),
        dec: Angle.Degrees(-37.86783834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143928"},
        {"Hipparcos Number", "HIP 78747"},
        {"Geneva Identification System", "GEN# +1.00143928"},
        {"Smithsonian Astrophysical Observation", "SAO 207297"},
        {"Wilson Evans Batten Catalogue", "WEB 13315"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.15379632),
        dec: Angle.Degrees(-37.86266825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159704"},
        {"Hipparcos Number", "HIP 86286"},
        {"Geneva Identification System", "GEN# +1.00159704"},
        {"Smithsonian Astrophysical Observation", "SAO 209047"},
        {"Wilson Evans Batten Catalogue", "WEB 14558"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.46339186),
        dec: Angle.Degrees(-37.86107735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105173"},
        {"Hipparcos Number", "HIP 59055"},
        {"Smithsonian Astrophysical Observation", "SAO 203137"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.65781827),
        dec: Angle.Degrees(-37.86010136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89327"},
        {"Hipparcos Number", "HIP 50406"},
        {"Smithsonian Astrophysical Observation", "SAO 201253"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.38705924),
        dec: Angle.Degrees(-37.85880854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118314"},
        {"Smithsonian Astrophysical Observation", "SAO 214905"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.95682420),
        dec: Angle.Degrees(-37.85795617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47187"},
        {"Hipparcos Number", "HIP 31471"},
        {"Smithsonian Astrophysical Observation", "SAO 196983"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.88170006),
        dec: Angle.Degrees(-37.85759575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110128"},
        {"Hipparcos Number", "HIP 61828"},
        {"Smithsonian Astrophysical Observation", "SAO 203688"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.06662127),
        dec: Angle.Degrees(-37.85697404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7312"},
        {"Hipparcos Number", "HIP 5661"},
        {"Fundamental Katalog 5th Edition", "FK5 44"},
        {"Geneva Identification System", "GEN# +1.00007312"},
        {"Smithsonian Astrophysical Observation", "SAO 192980"},
        {"Wilson Evans Batten Catalogue", "WEB 1279"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.18902960),
        dec: Angle.Degrees(-37.85640391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216008"},
        {"Hipparcos Number", "HIP 112730"},
        {"Geneva Identification System", "GEN# +1.00216008"},
        {"Smithsonian Astrophysical Observation", "SAO 214117"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.44225318),
        dec: Angle.Degrees(-37.85390125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105686"},
    },
    visualMagnitude: 12.29,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.09027249),
        dec: Angle.Degrees(-37.85383022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67245"},
        {"Smithsonian Astrophysical Observation", "SAO 204834"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.73492503),
        dec: Angle.Degrees(-37.85363722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155164"},
        {"Hipparcos Number", "HIP 84104"},
        {"Smithsonian Astrophysical Observation", "SAO 208509"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.90501947),
        dec: Angle.Degrees(-37.85322128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14120"},
        {"Hipparcos Number", "HIP 10578"},
        {"Smithsonian Astrophysical Observation", "SAO 193614"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.03497095),
        dec: Angle.Degrees(-37.85313166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19641"},
        {"Hipparcos Number", "HIP 14596"},
        {"Geneva Identification System", "GEN# +1.00019641"},
        {"Smithsonian Astrophysical Observation", "SAO 194108"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.11015968),
        dec: Angle.Degrees(-37.85252221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 117.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93008"},
        {"Hipparcos Number", "HIP 52489"},
        {"Smithsonian Astrophysical Observation", "SAO 201687"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.96798602),
        dec: Angle.Degrees(-37.85149734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42663"},
        {"Hipparcos Number", "HIP 29272"},
        {"Smithsonian Astrophysical Observation", "SAO 196556"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.56002413),
        dec: Angle.Degrees(-37.85093738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50652"},
        {"Hipparcos Number", "HIP 32994"},
        {"Geneva Identification System", "GEN# +1.00050652"},
        {"Smithsonian Astrophysical Observation", "SAO 197303"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.10445714),
        dec: Angle.Degrees(-37.85065507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40503"},
        {"Hipparcos Number", "HIP 28193"},
        {"Geneva Identification System", "GEN# +1.00040503"},
        {"Smithsonian Astrophysical Observation", "SAO 196353"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.36997886),
        dec: Angle.Degrees(-37.84840526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159279"},
        {"Hipparcos Number", "HIP 86079"},
        {"Geneva Identification System", "GEN# +1.00159279"},
        {"Smithsonian Astrophysical Observation", "SAO 208993"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.87628058),
        dec: Angle.Degrees(-37.84777149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161492"},
        {"Hipparcos Number", "HIP 87067"},
        {"Smithsonian Astrophysical Observation", "SAO 209255"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.88027522),
        dec: Angle.Degrees(-37.84632043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39131"},
        {"Smithsonian Astrophysical Observation", "SAO 198687"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.07261400),
        dec: Angle.Degrees(-37.84596031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186192"},
        {"Hipparcos Number", "HIP 97133"},
        {"Smithsonian Astrophysical Observation", "SAO 211521"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.11922655),
        dec: Angle.Degrees(-37.84452237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153919"},
        {"Hipparcos Number", "HIP 83499"},
        {"Geneva Identification System", "GEN# +2.62810002"},
        {"Smithsonian Astrophysical Observation", "SAO 208356"},
        {"Wilson Evans Batten Catalogue", "WEB 14113"},
        {"New General Catalogue", "NGC 6281 2"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.98654601),
        dec: Angle.Degrees(-37.84415453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94995"},
        {"Hipparcos Number", "HIP 53566"},
        {"Smithsonian Astrophysical Observation", "SAO 201943"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.37319447),
        dec: Angle.Degrees(-37.84245164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18253"},
        {"Hipparcos Number", "HIP 13552"},
        {"Geneva Identification System", "GEN# +1.00018253"},
        {"Smithsonian Astrophysical Observation", "SAO 193978"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.64224934),
        dec: Angle.Degrees(-37.84174346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216405"},
        {"Hipparcos Number", "HIP 113010"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.29869570),
        dec: Angle.Degrees(-37.83901053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200999"},
        {"Hipparcos Number", "HIP 104328"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.00723123),
        dec: Angle.Degrees(-37.83684793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177611"},
        {"Hipparcos Number", "HIP 93874"},
        {"Smithsonian Astrophysical Observation", "SAO 210938"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.77576316),
        dec: Angle.Degrees(-37.83655246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133514"},
        {"Hipparcos Number", "HIP 73893"},
        {"Smithsonian Astrophysical Observation", "SAO 206289"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.54045773),
        dec: Angle.Degrees(-37.83444413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95667"},
        {"Hipparcos Number", "HIP 53920"},
        {"Smithsonian Astrophysical Observation", "SAO 202021"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.50333000),
        dec: Angle.Degrees(-37.83347528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83518"},
        {"Hipparcos Number", "HIP 47251"},
        {"Geneva Identification System", "GEN# +1.00083518"},
        {"Smithsonian Astrophysical Observation", "SAO 200580"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.46976773),
        dec: Angle.Degrees(-37.83300200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82120"},
        {"Hipparcos Number", "HIP 46491"},
        {"Smithsonian Astrophysical Observation", "SAO 200413"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.23421944),
        dec: Angle.Degrees(-37.83297969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203949"},
        {"Hipparcos Number", "HIP 105854"},
        {"Fundamental Katalog 5th Edition", "FK5 3710"},
        {"Geneva Identification System", "GEN# +1.00203949"},
        {"Smithsonian Astrophysical Observation", "SAO 212998"},
    },
    visualMagnitude: 5.64,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.59479220),
        dec: Angle.Degrees(-37.82940289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4405"},
        {"Geneva Identification System", "GEN# -0.03800318"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.12173018),
        dec: Angle.Degrees(-37.82880273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98035"},
        {"Hipparcos Number", "HIP 55053"},
        {"Geneva Identification System", "GEN# +1.00098035"},
        {"Smithsonian Astrophysical Observation", "SAO 202263"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.05294923),
        dec: Angle.Degrees(-37.82638033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29427"},
        {"Hipparcos Number", "HIP 21456"},
        {"Geneva Identification System", "GEN# +1.00029427"},
        {"Smithsonian Astrophysical Observation", "SAO 195155"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.10686823),
        dec: Angle.Degrees(-37.82586226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 902"},
        {"Hipparcos Number", "HIP 1066"},
        {"Fundamental Katalog 5th Edition", "FK5 4024"},
        {"Geneva Identification System", "GEN# +1.00000902"},
        {"Smithsonian Astrophysical Observation", "SAO 192406"},
        {"Wilson Evans Batten Catalogue", "WEB 186"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.30755619),
        dec: Angle.Degrees(-37.82286519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202374"},
        {"Hipparcos Number", "HIP 105029"},
        {"Smithsonian Astrophysical Observation", "SAO 212852"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.10885989),
        dec: Angle.Degrees(-37.82280411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46726"},
        {"Hipparcos Number", "HIP 31243"},
        {"Geneva Identification System", "GEN# +1.00046726"},
        {"Smithsonian Astrophysical Observation", "SAO 196931"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.29933446),
        dec: Angle.Degrees(-37.82196457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142560"},
        {"Hipparcos Number", "HIP 78094"},
        {"Geneva Identification System", "GEN# +1.00142560"},
        {"Wilson Evans Batten Catalogue", "WEB 13206"},
    },
    visualMagnitude: 11.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.17633232),
        dec: Angle.Degrees(-37.82090877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110903"},
        {"Hipparcos Number", "HIP 62271"},
        {"Smithsonian Astrophysical Observation", "SAO 203779"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.41340874),
        dec: Angle.Degrees(-37.82076327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165064"},
        {"Hipparcos Number", "HIP 88643"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.46779856),
        dec: Angle.Degrees(-37.82042532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112658"},
        {"Hipparcos Number", "HIP 63332"},
        {"Smithsonian Astrophysical Observation", "SAO 203995"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.67079744),
        dec: Angle.Degrees(-37.82025954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11899"},
        {"Hipparcos Number", "HIP 9015"},
        {"Smithsonian Astrophysical Observation", "SAO 193391"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.01228733),
        dec: Angle.Degrees(-37.81899695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221507"},
        {"Hipparcos Number", "HIP 116231"},
        {"Fundamental Katalog 5th Edition", "FK5 886"},
        {"Geneva Identification System", "GEN# +1.00221507"},
        {"Renson", "Renson 60710"},
        {"Smithsonian Astrophysical Observation", "SAO 214615"},
        {"Wilson Evans Batten Catalogue", "WEB 20542"},
    },
    visualMagnitude: 4.38,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.24245060),
        dec: Angle.Degrees(-37.81835895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20108"},
        {"Hipparcos Number", "HIP 14934"},
        {"Geneva Identification System", "GEN# +1.00020108"},
        {"Smithsonian Astrophysical Observation", "SAO 194158"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.14487427),
        dec: Angle.Degrees(-37.81785489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33771"},
        {"Hipparcos Number", "HIP 24120"},
        {"Geneva Identification System", "GEN# +1.00033771"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.70651407),
        dec: Angle.Degrees(-37.81746275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127423"},
        {"Hipparcos Number", "HIP 71103"},
        {"Geneva Identification System", "GEN# +1.00127423"},
        {"Smithsonian Astrophysical Observation", "SAO 205665"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.10269163),
        dec: Angle.Degrees(-37.81722495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143927"},
        {"Hipparcos Number", "HIP 78754"},
        {"Geneva Identification System", "GEN# +1.00143927"},
        {"Smithsonian Astrophysical Observation", "SAO 207300"},
        {"Wilson Evans Batten Catalogue", "WEB 13317"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.17638847),
        dec: Angle.Degrees(-37.81607038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84624"},
        {"Hipparcos Number", "HIP 47888"},
        {"Geneva Identification System", "GEN# +1.00084624"},
        {"Smithsonian Astrophysical Observation", "SAO 200705"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.40512593),
        dec: Angle.Degrees(-37.81227926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12985"},
        {"Hipparcos Number", "HIP 9806"},
        {"Smithsonian Astrophysical Observation", "SAO 193504"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.54435451),
        dec: Angle.Degrees(-37.81155812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92403"},
        {"Hipparcos Number", "HIP 52168"},
        {"Fundamental Katalog 5th Edition", "FK5 4949"},
        {"Geneva Identification System", "GEN# +1.00092403"},
        {"Smithsonian Astrophysical Observation", "SAO 201606"},
        {"Smithsonian Astrophysical Observation 2", "SAO 201604"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.87511604),
        dec: Angle.Degrees(-37.81149739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59466"},
        {"Hipparcos Number", "HIP 36304"},
        {"Celescope Catalog", "CEL 1877"},
        {"Geneva Identification System", "GEN# +1.00059466"},
        {"Smithsonian Astrophysical Observation", "SAO 198031"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.09576437),
        dec: Angle.Degrees(-37.81005448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16516"},
        {"Hipparcos Number", "HIP 12256"},
        {"Geneva Identification System", "GEN# +1.00016516"},
        {"Smithsonian Astrophysical Observation", "SAO 193825"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.45314076),
        dec: Angle.Degrees(-37.80979275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177565"},
        {"Hipparcos Number", "HIP 93858"},
        {"Cincinnati Publication", "Ci 20 1125"},
        {"Geneva Identification System", "GEN# +1.00177565"},
        {"Smithsonian Astrophysical Observation", "SAO 210937"},
        {"Wilson Evans Batten Catalogue", "WEB 16321"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.71918034),
        dec: Angle.Degrees(-37.80976697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -187.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -366.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70816"},
        {"Hipparcos Number", "HIP 41049"},
        {"Celescope Catalog", "CEL 2437"},
        {"Geneva Identification System", "GEN# +1.00070816"},
        {"Smithsonian Astrophysical Observation", "SAO 199147"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.65036409),
        dec: Angle.Degrees(-37.80503003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16225"},
        {"Hipparcos Number", "HIP 12033"},
        {"Smithsonian Astrophysical Observation", "SAO 193790"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.79174184),
        dec: Angle.Degrees(-37.80484278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157039"},
        {"Henry Draper 2", "HD 157038"},
        {"Hipparcos Number", "HIP 85020"},
        {"Smithsonian Astrophysical Observation", "SAO 208740"},
        {"Wilson Evans Batten Catalogue", "WEB 14357"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.66340872),
        dec: Angle.Degrees(-37.80463731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107263"},
        {"Hipparcos Number", "HIP 60149"},
        {"Geneva Identification System", "GEN# +1.00107263"},
        {"Smithsonian Astrophysical Observation", "SAO 203356"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.02021318),
        dec: Angle.Degrees(-37.80319915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114613"},
        {"Hipparcos Number", "HIP 64408"},
        {"Fundamental Katalog 5th Edition", "FK5 3051"},
        {"Geneva Identification System", "GEN# +1.00114613"},
        {"Smithsonian Astrophysical Observation", "SAO 204227"},
        {"Wilson Evans Batten Catalogue", "WEB 11383"},
    },
    visualMagnitude: 4.85,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.01444495),
        dec: Angle.Degrees(-37.80313606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -382.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131120"},
        {"Hipparcos Number", "HIP 72800"},
        {"Fundamental Katalog 5th Edition", "FK5 3173"},
        {"Geneva Identification System", "GEN# +1.00131120"},
        {"Renson", "Renson 37270"},
        {"Smithsonian Astrophysical Observation", "SAO 206037"},
        {"Wilson Evans Batten Catalogue", "WEB 12507"},
    },
    visualMagnitude: 5.02,
    bvColour: -0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.21287023),
        dec: Angle.Degrees(-37.80311642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10120"},
        {"Hipparcos Number", "HIP 7627"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.56475328),
        dec: Angle.Degrees(-37.80295327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12836"},
        {"Hipparcos Number", "HIP 9713"},
        {"Smithsonian Astrophysical Observation", "SAO 193496"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.24183602),
        dec: Angle.Degrees(-37.79875303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 218.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129116"},
        {"Hipparcos Number", "HIP 71865"},
        {"Geneva Identification System", "GEN# +1.00129116"},
        {"Smithsonian Astrophysical Observation", "SAO 205839"},
        {"Wilson Evans Batten Catalogue", "WEB 12379"},
    },
    visualMagnitude: 4.01,
    bvColour: -0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.49005323),
        dec: Angle.Degrees(-37.79342394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210917"},
        {"Hipparcos Number", "HIP 109808"},
        {"Smithsonian Astrophysical Observation", "SAO 213658"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.61309886),
        dec: Angle.Degrees(-37.79248924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24071"},
        {"Geneva Identification System", "GEN# -0.03702057"},
        {"Smithsonian Astrophysical Observation", "SAO 195617"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.57830323),
        dec: Angle.Degrees(-37.79155269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165876"},
        {"Hipparcos Number", "HIP 89001"},
        {"Smithsonian Astrophysical Observation", "SAO 209787"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.47843413),
        dec: Angle.Degrees(-37.79132219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24091"},
        {"Geneva Identification System", "GEN# -0.03702059"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.63624768),
        dec: Angle.Degrees(-37.79030928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207276"},
        {"Hipparcos Number", "HIP 107673"},
        {"Smithsonian Astrophysical Observation", "SAO 213301"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.16848431),
        dec: Angle.Degrees(-37.79013086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9292"},
        {"Hipparcos Number", "HIP 7036"},
        {"Geneva Identification System", "GEN# +1.00009292"},
        {"Smithsonian Astrophysical Observation", "SAO 193153"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.68489122),
        dec: Angle.Degrees(-37.78955235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2764"},
        {"Hipparcos Number", "HIP 2428"},
        {"Smithsonian Astrophysical Observation", "SAO 192581"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.73671310),
        dec: Angle.Degrees(-37.78777611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27804"},
        {"Hipparcos Number", "HIP 20372"},
        {"Geneva Identification System", "GEN# +1.00027804"},
        {"Smithsonian Astrophysical Observation", "SAO 194956"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.44029257),
        dec: Angle.Degrees(-37.78173959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187085"},
        {"Hipparcos Number", "HIP 97546"},
        {"Geneva Identification System", "GEN# +1.00187085"},
        {"Smithsonian Astrophysical Observation", "SAO 211579"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.39150244),
        dec: Angle.Degrees(-37.78029734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210113"},
        {"Hipparcos Number", "HIP 109318"},
        {"Smithsonian Astrophysical Observation", "SAO 213585"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.20701022),
        dec: Angle.Degrees(-37.77936395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11694"},
        {"Hipparcos Number", "HIP 8854"},
        {"Smithsonian Astrophysical Observation", "SAO 193373"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.47137860),
        dec: Angle.Degrees(-37.77677604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218653"},
        {"Hipparcos Number", "HIP 114405"},
        {"Smithsonian Astrophysical Observation", "SAO 214352"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.53702792),
        dec: Angle.Degrees(-37.77674240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49336"},
        {"Hipparcos Number", "HIP 32434"},
        {"Celescope Catalog", "CEL 1384"},
        {"Geneva Identification System", "GEN# +1.00049336"},
        {"Smithsonian Astrophysical Observation", "SAO 197195"},
        {"Wilson Evans Batten Catalogue", "WEB 6540"},
    },
    visualMagnitude: 6.19,
    bvColour: -0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.55064809),
        dec: Angle.Degrees(-37.77534788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48836"},
        {"Hipparcos Number", "HIP 32223"},
        {"Smithsonian Astrophysical Observation", "SAO 197139"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.90487323),
        dec: Angle.Degrees(-37.77381588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63291"},
        {"Hipparcos Number", "HIP 37939"},
        {"Geneva Identification System", "GEN# +2.24510269"},
        {"Smithsonian Astrophysical Observation", "SAO 198423"},
        {"New General Catalogue", "NGC 2451 269"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.63937426),
        dec: Angle.Degrees(-37.77249301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122665"},
        {"Hipparcos Number", "HIP 68720"},
        {"Smithsonian Astrophysical Observation", "SAO 205137"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.01216777),
        dec: Angle.Degrees(-37.77236702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77417"},
        {"Hipparcos Number", "HIP 44279"},
        {"Geneva Identification System", "GEN# +1.00077417"},
        {"Smithsonian Astrophysical Observation", "SAO 199886"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.27324248),
        dec: Angle.Degrees(-37.77183421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118780"},
        {"Hipparcos Number", "HIP 66649"},
        {"Smithsonian Astrophysical Observation", "SAO 204710"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.93721317),
        dec: Angle.Degrees(-37.76679905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38936"},
        {"Hipparcos Number", "HIP 27339"},
        {"Smithsonian Astrophysical Observation", "SAO 196177"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.86018550),
        dec: Angle.Degrees(-37.76390819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152884"},
        {"Hipparcos Number", "HIP 83009"},
        {"Geneva Identification System", "GEN# +1.00152884"},
        {"Smithsonian Astrophysical Observation", "SAO 208236"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.43062101),
        dec: Angle.Degrees(-37.76377185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108375",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Itonda"},
        {"Henry Draper", "HD 208487"},
        {"Hipparcos Number", "HIP 108375"},
        {"Geneva Identification System", "GEN# +1.00208487"},
        {"Smithsonian Astrophysical Observation", "SAO 213432"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.33238710),
        dec: Angle.Degrees(-37.76333471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126728"},
        {"Hipparcos Number", "HIP 70763"},
        {"Geneva Identification System", "GEN# +1.00126728"},
        {"Smithsonian Astrophysical Observation", "SAO 205588"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.07300188),
        dec: Angle.Degrees(-37.76150011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141537"},
        {"Hipparcos Number", "HIP 77639"},
        {"Smithsonian Astrophysical Observation", "SAO 207041"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.76587771),
        dec: Angle.Degrees(-37.76106625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113284"},
        {"Smithsonian Astrophysical Observation", "SAO 214196"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.09946079),
        dec: Angle.Degrees(-37.76089832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1541"},
        {"Hipparcos Number", "HIP 1561"},
        {"Geneva Identification System", "GEN# +1.00001541"},
        {"Renson", "Renson 320"},
        {"Smithsonian Astrophysical Observation", "SAO 192461"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.85380921),
        dec: Angle.Degrees(-37.75893787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37716"},
        {"Hipparcos Number", "HIP 26562"},
        {"Smithsonian Astrophysical Observation", "SAO 196048"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.72138688),
        dec: Angle.Degrees(-37.75877432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217450"},
        {"Hipparcos Number", "HIP 113661"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.29352378),
        dec: Angle.Degrees(-37.75728108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220981"},
        {"Hipparcos Number", "HIP 115861"},
        {"Geneva Identification System", "GEN# +1.00220981"},
        {"Smithsonian Astrophysical Observation", "SAO 214566"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.11160876),
        dec: Angle.Degrees(-37.75707567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81309"},
        {"Hipparcos Number", "HIP 46075"},
        {"Geneva Identification System", "GEN# +1.00081309"},
        {"Renson", "Renson 23090"},
        {"Smithsonian Astrophysical Observation", "SAO 200320"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.93717495),
        dec: Angle.Degrees(-37.75696435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215768"},
        {"Hipparcos Number", "HIP 112581"},
        {"Geneva Identification System", "GEN# +1.00215768"},
        {"Smithsonian Astrophysical Observation", "SAO 214093"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.02834566),
        dec: Angle.Degrees(-37.75666476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146418"},
        {"Hipparcos Number", "HIP 79835"},
        {"Geneva Identification System", "GEN# +1.00146418"},
        {"Smithsonian Astrophysical Observation", "SAO 207519"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.43902801),
        dec: Angle.Degrees(-37.75373525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103123"},
        {"Hipparcos Number", "HIP 57879"},
        {"Geneva Identification System", "GEN# +1.00103123"},
        {"Smithsonian Astrophysical Observation", "SAO 202892"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.06442652),
        dec: Angle.Degrees(-37.75248486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150003"},
        {"Hipparcos Number", "HIP 81595"},
        {"Smithsonian Astrophysical Observation", "SAO 207892"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.94837092),
        dec: Angle.Degrees(-37.75080641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31776"},
        {"Hipparcos Number", "HIP 22997"},
        {"Smithsonian Astrophysical Observation", "SAO 195423"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.20709112),
        dec: Angle.Degrees(-37.74999110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210339"},
        {"Hipparcos Number", "HIP 109470"},
        {"Geneva Identification System", "GEN# +1.00210339"},
        {"Smithsonian Astrophysical Observation", "SAO 213609"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.65398996),
        dec: Angle.Degrees(-37.74958302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 227.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100118"},
        {"Hipparcos Number", "HIP 56189"},
        {"Smithsonian Astrophysical Observation", "SAO 202524"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.76160047),
        dec: Angle.Degrees(-37.74912794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103437"},
        {"Hipparcos Number", "HIP 58057"},
        {"Geneva Identification System", "GEN# +1.00103437J"},
        {"Smithsonian Astrophysical Observation", "SAO 202926"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.60857677),
        dec: Angle.Degrees(-37.74907386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -331.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194569"},
        {"Hipparcos Number", "HIP 100928"},
        {"Smithsonian Astrophysical Observation", "SAO 212137"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.94934271),
        dec: Angle.Degrees(-37.74810025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99333"},
        {"Hipparcos Number", "HIP 55763"},
        {"Geneva Identification System", "GEN# +1.00099333J"},
        {"Smithsonian Astrophysical Observation", "SAO 202430"},
    },
    visualMagnitude: 5.87,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.38803347),
        dec: Angle.Degrees(-37.74754766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208435"},
        {"Hipparcos Number", "HIP 108347"},
        {"Geneva Identification System", "GEN# +1.00208435"},
        {"Smithsonian Astrophysical Observation", "SAO 213427"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.25892785),
        dec: Angle.Degrees(-37.74685621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188641"},
        {"Hipparcos Number", "HIP 98222"},
        {"Geneva Identification System", "GEN# +1.00188641"},
        {"Smithsonian Astrophysical Observation", "SAO 211685"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.40477572),
        dec: Angle.Degrees(-37.74514894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197190"},
        {"Hipparcos Number", "HIP 102282"},
        {"Smithsonian Astrophysical Observation", "SAO 212379"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.86478381),
        dec: Angle.Degrees(-37.74463974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113853"},
        {"Hipparcos Number", "HIP 64011"},
        {"Smithsonian Astrophysical Observation", "SAO 204135"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.74660644),
        dec: Angle.Degrees(-37.74429122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36583"},
        {"Hipparcos Number", "HIP 25842"},
        {"Smithsonian Astrophysical Observation", "SAO 195919"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.75399769),
        dec: Angle.Degrees(-37.74277671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92244"},
        {"Geneva Identification System", "GEN# -0.03712867"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.99019142),
        dec: Angle.Degrees(-37.73952899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105479"},
        {"Hipparcos Number", "HIP 59214"},
        {"Smithsonian Astrophysical Observation", "SAO 203167"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.16172125),
        dec: Angle.Degrees(-37.73947494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17483"},
        {"Hipparcos Number", "HIP 12989"},
        {"Geneva Identification System", "GEN# +1.00017483"},
        {"Smithsonian Astrophysical Observation", "SAO 193912"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.76342574),
        dec: Angle.Degrees(-37.73939902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43899"},
        {"Hipparcos Number", "HIP 29842"},
        {"Geneva Identification System", "GEN# +1.00043899"},
        {"Smithsonian Astrophysical Observation", "SAO 196653"},
        {"Wilson Evans Batten Catalogue", "WEB 5903"},
    },
    visualMagnitude: 5.54,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.25512509),
        dec: Angle.Degrees(-37.73764950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24199"},
        {"Hipparcos Number", "HIP 17897"},
        {"Smithsonian Astrophysical Observation", "SAO 194560"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.41584892),
        dec: Angle.Degrees(-37.73539804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195111"},
        {"Hipparcos Number", "HIP 101200"},
        {"Geneva Identification System", "GEN# +1.00195111"},
        {"Smithsonian Astrophysical Observation", "SAO 212191"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.69540057),
        dec: Angle.Degrees(-37.73360513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84610"},
        {"Hipparcos Number", "HIP 47881"},
        {"Geneva Identification System", "GEN# +1.00084610"},
        {"Smithsonian Astrophysical Observation", "SAO 200704"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.37134081),
        dec: Angle.Degrees(-37.73360399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76998"},
        {"Geneva Identification System", "GEN# -0.00403956"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.82394346),
        dec: Angle.Degrees(-05.25343388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112867"},
        {"Hipparcos Number", "HIP 63456"},
        {"Smithsonian Astrophysical Observation", "SAO 204017"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.03816412),
        dec: Angle.Degrees(-37.73270018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88262"},
        {"Hipparcos Number", "HIP 49784"},
        {"Smithsonian Astrophysical Observation", "SAO 201114"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.43941396),
        dec: Angle.Degrees(-37.73206931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189222"},
        {"Hipparcos Number", "HIP 98481"},
        {"Smithsonian Astrophysical Observation", "SAO 211723"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.10537505),
        dec: Angle.Degrees(-37.73087078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71836"},
        {"Hipparcos Number", "HIP 41531"},
        {"Smithsonian Astrophysical Observation", "SAO 199266"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.05089781),
        dec: Angle.Degrees(-37.73025932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123003"},
        {"Hipparcos Number", "HIP 68853"},
        {"Geneva Identification System", "GEN# +1.00123003"},
        {"Smithsonian Astrophysical Observation", "SAO 205173"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.48709023),
        dec: Angle.Degrees(-37.72920574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206036"},
        {"Hipparcos Number", "HIP 107018"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.11364957),
        dec: Angle.Degrees(-37.72786514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 270.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24448"},
        {"Hipparcos Number", "HIP 18079"},
        {"Smithsonian Astrophysical Observation", "SAO 194588"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.96424402),
        dec: Angle.Degrees(-37.72759861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135562"},
        {"Hipparcos Number", "HIP 74788"},
        {"Geneva Identification System", "GEN# +1.00135562"},
        {"Smithsonian Astrophysical Observation", "SAO 206481"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.26638159),
        dec: Angle.Degrees(-37.72463025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98458"},
        {"Hipparcos Number", "HIP 55279"},
        {"Smithsonian Astrophysical Observation", "SAO 202317"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.81720807),
        dec: Angle.Degrees(-37.72461799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84902"},
        {"Hipparcos Number", "HIP 48031"},
        {"Smithsonian Astrophysical Observation", "SAO 200735"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.86930778),
        dec: Angle.Degrees(-37.72449372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94971"},
        {"Hipparcos Number", "HIP 53557"},
        {"Smithsonian Astrophysical Observation", "SAO 201941"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.33545731),
        dec: Angle.Degrees(-37.72361921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62737"},
        {"Hipparcos Number", "HIP 37684"},
        {"Celescope Catalog", "CEL 2004"},
        {"Geneva Identification System", "GEN# +2.24510237"},
        {"Smithsonian Astrophysical Observation", "SAO 198357"},
        {"Wilson Evans Batten Catalogue", "WEB 7450"},
        {"New General Catalogue", "NGC 2451 237"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.96944203),
        dec: Angle.Degrees(-37.72050552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199349"},
        {"Henry Draper 2", "HD 199349A"},
        {"Hipparcos Number", "HIP 103475"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.46436664),
        dec: Angle.Degrees(-37.71970905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83758"},
        {"Hipparcos Number", "HIP 47416"},
        {"Smithsonian Astrophysical Observation", "SAO 200605"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.92662352),
        dec: Angle.Degrees(-37.71718798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76937"},
        {"Hipparcos Number", "HIP 44029"},
        {"Smithsonian Astrophysical Observation", "SAO 199831"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.49310689),
        dec: Angle.Degrees(-37.71677137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43283",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 10.83,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)49, 02.8500),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)13, 59.300)
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
    primaryId: "HIP 44944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78880"},
        {"Hipparcos Number", "HIP 44944"},
        {"Smithsonian Astrophysical Observation", "SAO 200043"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.32518137),
        dec: Angle.Degrees(-37.71646767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115682",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115682"},
        {"Smithsonian Astrophysical Observation", "SAO 214546"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.55212973),
        dec: Angle.Degrees(-37.71611416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190289"},
        {"Hipparcos Number", "HIP 98979"},
        {"Geneva Identification System", "GEN# +1.00190289"},
        {"Smithsonian Astrophysical Observation", "SAO 211799"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.42164651),
        dec: Angle.Degrees(-37.71477543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193283"},
        {"Hipparcos Number", "HIP 100335"},
        {"Smithsonian Astrophysical Observation", "SAO 212024"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.22407920),
        dec: Angle.Degrees(-37.71452563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17899"},
        {"Hipparcos Number", "HIP 13310"},
        {"Geneva Identification System", "GEN# +1.00017899"},
        {"Smithsonian Astrophysical Observation", "SAO 193949"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.82225805),
        dec: Angle.Degrees(-37.71368983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79757"},
        {"Hipparcos Number", "HIP 45362"},
        {"Smithsonian Astrophysical Observation", "SAO 200145"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.65635953),
        dec: Angle.Degrees(-37.71273684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212116"},
        {"Hipparcos Number", "HIP 110474"},
        {"Smithsonian Astrophysical Observation", "SAO 213770"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.66045237),
        dec: Angle.Degrees(-37.71153688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54232"},
        {"Hipparcos Number", "HIP 34275"},
        {"Celescope Catalog", "CEL 1592"},
        {"Geneva Identification System", "GEN# +1.00054232"},
        {"Smithsonian Astrophysical Observation", "SAO 197579"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.58623116),
        dec: Angle.Degrees(-37.70960717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38396"},
        {"Hipparcos Number", "HIP 27002"},
        {"Geneva Identification System", "GEN# +1.00038396"},
        {"Smithsonian Astrophysical Observation", "SAO 196119"},
        {"Wilson Evans Batten Catalogue", "WEB 5319"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.92157744),
        dec: Angle.Degrees(-37.70897522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170998"},
        {"Hipparcos Number", "HIP 91017"},
        {"Geneva Identification System", "GEN# +1.00170998"},
        {"Smithsonian Astrophysical Observation", "SAO 210310"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.50662792),
        dec: Angle.Degrees(-37.70794287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110619"},
        {"Hipparcos Number", "HIP 62107"},
        {"Cincinnati Publication", "Ci 20 733"},
        {"Geneva Identification System", "GEN# +1.00110619"},
        {"Smithsonian Astrophysical Observation", "SAO 203750"},
        {"Wilson Evans Batten Catalogue", "WEB 11040"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.92994488),
        dec: Angle.Degrees(-37.70763748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -626.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96147"},
        {"Hipparcos Number", "HIP 54170"},
        {"Smithsonian Astrophysical Observation", "SAO 202066"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.21900859),
        dec: Angle.Degrees(-37.70370217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8449"},
        {"Hipparcos Number", "HIP 6457"},
        {"Smithsonian Astrophysical Observation", "SAO 193083"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.76027700),
        dec: Angle.Degrees(-37.70235740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39693"},
        {"Hipparcos Number", "HIP 27736"},
        {"Smithsonian Astrophysical Observation", "SAO 196262"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.08032568),
        dec: Angle.Degrees(-37.70233859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171982"},
        {"Hipparcos Number", "HIP 91471"},
        {"Geneva Identification System", "GEN# +1.00171982"},
        {"Smithsonian Astrophysical Observation", "SAO 210405"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.83215847),
        dec: Angle.Degrees(-37.70179641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189195"},
        {"Hipparcos Number", "HIP 98461"},
        {"Geneva Identification System", "GEN# +1.00189195"},
        {"Smithsonian Astrophysical Observation", "SAO 211719"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.06632739),
        dec: Angle.Degrees(-37.70171669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33241"},
        {"Hipparcos Number", "HIP 23815"},
        {"Smithsonian Astrophysical Observation", "SAO 195568"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.77570085),
        dec: Angle.Degrees(-37.70045558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113175"},
        {"Hipparcos Number", "HIP 63609"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.54947898),
        dec: Angle.Degrees(-37.69793219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46568"},
        {"Hipparcos Number", "HIP 31165"},
        {"Geneva Identification System", "GEN# +1.00046568"},
        {"Smithsonian Astrophysical Observation", "SAO 196917"},
        {"Wilson Evans Batten Catalogue", "WEB 6227"},
    },
    visualMagnitude: 5.25,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.08888798),
        dec: Angle.Degrees(-37.69651376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204475"},
        {"Hipparcos Number", "HIP 106123"},
        {"Geneva Identification System", "GEN# +1.00204475"},
        {"Smithsonian Astrophysical Observation", "SAO 213044"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.45717358),
        dec: Angle.Degrees(-37.69241537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207214"},
        {"Hipparcos Number", "HIP 107652"},
        {"Smithsonian Astrophysical Observation", "SAO 213296"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.07256334),
        dec: Angle.Degrees(-37.69210197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108231"},
        {"Hipparcos Number", "HIP 60682"},
        {"Smithsonian Astrophysical Observation", "SAO 203465"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.54601020),
        dec: Angle.Degrees(-37.69063685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220052"},
        {"Hipparcos Number", "HIP 115290"},
        {"Smithsonian Astrophysical Observation", "SAO 214479"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.24323263),
        dec: Angle.Degrees(-37.68733713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168123"},
        {"Hipparcos Number", "HIP 89834"},
        {"Smithsonian Astrophysical Observation", "SAO 209994"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.98247599),
        dec: Angle.Degrees(-37.68310252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158601"},
        {"Hipparcos Number", "HIP 85801"},
        {"Smithsonian Astrophysical Observation", "SAO 208922"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.98421036),
        dec: Angle.Degrees(-37.68183030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67888"},
        {"Hipparcos Number", "HIP 39866"},
        {"Celescope Catalog", "CEL 2178"},
        {"Fundamental Katalog 5th Edition", "FK5 2631"},
        {"Geneva Identification System", "GEN# +1.00067888"},
        {"Smithsonian Astrophysical Observation", "SAO 198848"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.15686745),
        dec: Angle.Degrees(-37.68124187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102889"},
        {"Hipparcos Number", "HIP 57747"},
        {"Smithsonian Astrophysical Observation", "SAO 202863"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.64873973),
        dec: Angle.Degrees(-37.68092326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69083"},
        {"Hipparcos Number", "HIP 40316"},
        {"Smithsonian Astrophysical Observation", "SAO 198968"},
        {"New General Catalogue", "NGC 2546 540"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.48286296),
        dec: Angle.Degrees(-37.67848402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126485"},
        {"Hipparcos Number", "HIP 70629"},
        {"Smithsonian Astrophysical Observation", "SAO 205562"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.71477195),
        dec: Angle.Degrees(-37.67812036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101126"},
        {"Hipparcos Number", "HIP 56741"},
        {"Smithsonian Astrophysical Observation", "SAO 202650"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.50763308),
        dec: Angle.Degrees(-37.67668144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140973"},
        {"Hipparcos Number", "HIP 77396"},
        {"Geneva Identification System", "GEN# +1.00140973"},
        {"Smithsonian Astrophysical Observation", "SAO 206991"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.00604560),
        dec: Angle.Degrees(-37.67537172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4291"},
        {"Hipparcos Number", "HIP 3523"},
        {"Geneva Identification System", "GEN# +1.00004291"},
        {"Smithsonian Astrophysical Observation", "SAO 192715"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.24257917),
        dec: Angle.Degrees(-37.67443560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93972"},
        {"Hipparcos Number", "HIP 52982"},
        {"Smithsonian Astrophysical Observation", "SAO 201811"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.57648626),
        dec: Angle.Degrees(-37.67229430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51539"},
        {"Geneva Identification System", "GEN# -0.03806535"},
    },
    visualMagnitude: 11.02,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.90154661),
        dec: Angle.Degrees(-37.67147394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39751"},
        {"Hipparcos Number", "HIP 27780"},
        {"Smithsonian Astrophysical Observation", "SAO 196269"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.17862277),
        dec: Angle.Degrees(-37.67113621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215051"},
        {"Hipparcos Number", "HIP 112171"},
        {"Smithsonian Astrophysical Observation", "SAO 214039"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.76837527),
        dec: Angle.Degrees(-37.67050542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222071"},
        {"Hipparcos Number", "HIP 116588"},
        {"Smithsonian Astrophysical Observation", "SAO 214667"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.40752218),
        dec: Angle.Degrees(-37.66869642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8976"},
        {"Hipparcos Number", "HIP 6827"},
        {"Geneva Identification System", "GEN# +1.00008976"},
        {"Renson", "Renson 2180"},
        {"Smithsonian Astrophysical Observation", "SAO 193128"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.95468900),
        dec: Angle.Degrees(-37.66814594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115663"},
        {"Hipparcos Number", "HIP 64985"},
        {"Geneva Identification System", "GEN# +1.00115663"},
        {"Smithsonian Astrophysical Observation", "SAO 204352"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.78539712),
        dec: Angle.Degrees(-37.66778755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165711"},
        {"Hipparcos Number", "HIP 88919"},
        {"Geneva Identification System", "GEN# +1.00165711"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.25743191),
        dec: Angle.Degrees(-37.66587724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183178"},
        {"Hipparcos Number", "HIP 95858"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.45010080),
        dec: Angle.Degrees(-37.66576427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40083"},
        {"Geneva Identification System", "GEN# +2.25460099"},
        {"New General Catalogue", "NGC 2546 99"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.81497337),
        dec: Angle.Degrees(-37.66573776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62875"},
        {"Hipparcos Number", "HIP 37742"},
        {"Celescope Catalog", "CEL 2008"},
        {"Geneva Identification System", "GEN# +2.24510243"},
        {"Smithsonian Astrophysical Observation", "SAO 198374"},
        {"New General Catalogue", "NGC 2451 243"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.11484593),
        dec: Angle.Degrees(-37.66335464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187699"},
        {"Hipparcos Number", "HIP 97829"},
        {"Smithsonian Astrophysical Observation", "SAO 211620"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.19553623),
        dec: Angle.Degrees(-37.66188205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214387"},
        {"Hipparcos Number", "HIP 111757"},
        {"Smithsonian Astrophysical Observation", "SAO 213973"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.58946618),
        dec: Angle.Degrees(-37.66019476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3635",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3635"},
    },
    visualMagnitude: 11.97,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.65076930),
        dec: Angle.Degrees(-37.65930178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208434"},
        {"Hipparcos Number", "HIP 108349"},
        {"Smithsonian Astrophysical Observation", "SAO 213428"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.25923911),
        dec: Angle.Degrees(-37.65876844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157076"},
        {"Hipparcos Number", "HIP 85036"},
        {"Smithsonian Astrophysical Observation", "SAO 208743"},
    },
    visualMagnitude: 8.75,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.69435576),
        dec: Angle.Degrees(-37.65603224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119360"},
        {"Hipparcos Number", "HIP 66967"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.87881419),
        dec: Angle.Degrees(-37.65582447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171452"},
        {"Hipparcos Number", "HIP 91242"},
        {"Geneva Identification System", "GEN# +1.00171452"},
        {"Smithsonian Astrophysical Observation", "SAO 210365"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.16904942),
        dec: Angle.Degrees(-37.65500911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116662"},
        {"Hipparcos Number", "HIP 65506"},
        {"Smithsonian Astrophysical Observation", "SAO 204457"},
    },
    visualMagnitude: 9.58,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.39896334),
        dec: Angle.Degrees(-37.65433752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172279"},
        {"Hipparcos Number", "HIP 91616"},
        {"Smithsonian Astrophysical Observation", "SAO 210446"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.26625543),
        dec: Angle.Degrees(-37.65384592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212014"},
        {"Hipparcos Number", "HIP 110420"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.49142796),
        dec: Angle.Degrees(-37.65360749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113597"},
        {"Hipparcos Number", "HIP 63861"},
        {"Smithsonian Astrophysical Observation", "SAO 204111"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.32013538),
        dec: Angle.Degrees(-37.65283120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103897"},
        {"Hipparcos Number", "HIP 58328"},
        {"Smithsonian Astrophysical Observation", "SAO 202986"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.42942393),
        dec: Angle.Degrees(-37.65060528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166906"},
        {"Hipparcos Number", "HIP 89389"},
        {"Smithsonian Astrophysical Observation", "SAO 209894"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.61617129),
        dec: Angle.Degrees(-37.65048564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61247"},
        {"Smithsonian Astrophysical Observation", "SAO 203580"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.27412419),
        dec: Angle.Degrees(-37.64697341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138189"},
        {"Hipparcos Number", "HIP 76044"},
        {"Smithsonian Astrophysical Observation", "SAO 206728"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.95205221),
        dec: Angle.Degrees(-37.64625939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100111"},
        {"Hipparcos Number", "HIP 56168"},
        {"Geneva Identification System", "GEN# +1.00100111"},
        {"Smithsonian Astrophysical Observation", "SAO 202523"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.71796232),
        dec: Angle.Degrees(-37.64404258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58980"},
        {"Hipparcos Number", "HIP 36106"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.56988407),
        dec: Angle.Degrees(-37.64080215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70778"},
        {"Hipparcos Number", "HIP 41034"},
        {"Smithsonian Astrophysical Observation", "SAO 199144"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.61694951),
        dec: Angle.Degrees(-37.64011628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97457"},
        {"Smithsonian Astrophysical Observation", "SAO 211566"},
    },
    visualMagnitude: 11.04,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.13591301),
        dec: Angle.Degrees(-37.63884380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85044"},
        {"Hipparcos Number", "HIP 48105"},
        {"Smithsonian Astrophysical Observation", "SAO 200755"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.11688948),
        dec: Angle.Degrees(-37.63608290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136482"},
        {"Hipparcos Number", "HIP 75210"},
        {"Geneva Identification System", "GEN# +1.00136482"},
        {"Smithsonian Astrophysical Observation", "SAO 206559"},
    },
    visualMagnitude: 6.65,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.54695837),
        dec: Angle.Degrees(-37.63556763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64267"},
        {"Hipparcos Number", "HIP 38365"},
        {"Geneva Identification System", "GEN# +1.00064267"},
        {"Smithsonian Astrophysical Observation", "SAO 198528"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.87780395),
        dec: Angle.Degrees(-37.63452675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201620"},
        {"Hipparcos Number", "HIP 104649"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.97861182),
        dec: Angle.Degrees(-37.63345571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130373"},
        {"Hipparcos Number", "HIP 72448"},
        {"Geneva Identification System", "GEN# +1.00130373"},
        {"Smithsonian Astrophysical Observation", "SAO 205971"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.22305642),
        dec: Angle.Degrees(-37.63277468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89551"},
        {"Hipparcos Number", "HIP 50529"},
        {"Smithsonian Astrophysical Observation", "SAO 201277"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.80854566),
        dec: Angle.Degrees(-37.63236341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14381",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14381"},
        {"Smithsonian Astrophysical Observation", "SAO 194077"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.38493717),
        dec: Angle.Degrees(-37.63112571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39720"},
        {"Hipparcos Number", "HIP 27766"},
        {"Geneva Identification System", "GEN# +1.00039720"},
        {"Smithsonian Astrophysical Observation", "SAO 196266"},
        {"Wilson Evans Batten Catalogue", "WEB 5444"},
    },
    visualMagnitude: 5.62,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.13817716),
        dec: Angle.Degrees(-37.63099079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140517"},
        {"Hipparcos Number", "HIP 77167"},
        {"Geneva Identification System", "GEN# +1.00140517J"},
        {"Smithsonian Astrophysical Observation", "SAO 206937"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.35667257),
        dec: Angle.Degrees(-37.63039356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54035"},
        {"Hipparcos Number", "HIP 34216"},
        {"Smithsonian Astrophysical Observation", "SAO 197562"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.41538675),
        dec: Angle.Degrees(-37.62954160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137617"},
        {"Hipparcos Number", "HIP 75738"},
        {"Smithsonian Astrophysical Observation", "SAO 206677"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.08956521),
        dec: Angle.Degrees(-37.62934722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79961"},
        {"Hipparcos Number", "HIP 45459"},
        {"Smithsonian Astrophysical Observation", "SAO 200168"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.96429497),
        dec: Angle.Degrees(-37.62931153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183926"},
        {"Hipparcos Number", "HIP 96181"},
        {"Geneva Identification System", "GEN# +1.00183926"},
        {"Smithsonian Astrophysical Observation", "SAO 211357"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.34931103),
        dec: Angle.Degrees(-37.62916223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155587"},
        {"Hipparcos Number", "HIP 84310"},
        {"Geneva Identification System", "GEN# +1.00155587"},
        {"Smithsonian Astrophysical Observation", "SAO 208563"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.55066678),
        dec: Angle.Degrees(-37.62865050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117883",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117883"},
        {"Smithsonian Astrophysical Observation", "SAO 214854"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.66676988),
        dec: Angle.Degrees(-37.62775373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 248.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23532"},
        {"Hipparcos Number", "HIP 17454"},
        {"Smithsonian Astrophysical Observation", "SAO 194497"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.11824216),
        dec: Angle.Degrees(-37.62673049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102184"},
        {"Hipparcos Number", "HIP 57344"},
        {"Geneva Identification System", "GEN# +1.00102184"},
        {"Smithsonian Astrophysical Observation", "SAO 202775"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.36486287),
        dec: Angle.Degrees(-37.62242382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -192.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39368"},
        {"Hipparcos Number", "HIP 27579"},
        {"Smithsonian Astrophysical Observation", "SAO 196231"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.61901621),
        dec: Angle.Degrees(-37.62130304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166833"},
        {"Hipparcos Number", "HIP 89364"},
        {"Smithsonian Astrophysical Observation", "SAO 209886"},
    },
    visualMagnitude: 7.63,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.54114572),
        dec: Angle.Degrees(-37.62097683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72926",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72926"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.56848887),
        dec: Angle.Degrees(-37.62057804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153072"},
        {"Hipparcos Number", "HIP 83100"},
        {"Geneva Identification System", "GEN# +1.00153072J"},
        {"Smithsonian Astrophysical Observation", "SAO 208259"},
        {"Wilson Evans Batten Catalogue", "WEB 14047"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.71772463),
        dec: Angle.Degrees(-37.62041528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17797",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17797"},
        {"Geneva Identification System", "GEN# +1.00024072"},
    },
    visualMagnitude: 4.30,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.14926223),
        dec: Angle.Degrees(-37.62012878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34705"},
        {"Hipparcos Number", "HIP 24682"},
        {"Geneva Identification System", "GEN# +1.00034705"},
        {"Smithsonian Astrophysical Observation", "SAO 195724"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.42160242),
        dec: Angle.Degrees(-37.61843842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40939"},
        {"Hipparcos Number", "HIP 28430"},
        {"Smithsonian Astrophysical Observation", "SAO 196400"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.06101270),
        dec: Angle.Degrees(-37.61648565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185135"},
        {"Hipparcos Number", "HIP 96664"},
        {"Smithsonian Astrophysical Observation", "SAO 211442"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.79554987),
        dec: Angle.Degrees(-37.61542137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30011"},
        {"Hipparcos Number", "HIP 21869"},
        {"Smithsonian Astrophysical Observation", "SAO 195241"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.53396790),
        dec: Angle.Degrees(-37.61349462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28550"},
        {"Hipparcos Number", "HIP 20879"},
        {"Geneva Identification System", "GEN# +1.00028550"},
        {"Smithsonian Astrophysical Observation", "SAO 195052"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.11587440),
        dec: Angle.Degrees(-37.61276477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28130"},
        {"Hipparcos Number", "HIP 20593"},
        {"Geneva Identification System", "GEN# +1.00028130"},
        {"Smithsonian Astrophysical Observation", "SAO 194991"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.16249137),
        dec: Angle.Degrees(-37.61129641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72993"},
        {"Hipparcos Number", "HIP 42070"},
        {"Geneva Identification System", "GEN# +1.00072993J"},
        {"Smithsonian Astrophysical Observation", "SAO 199389"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.62192854),
        dec: Angle.Degrees(-37.61119548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157644"},
        {"Hipparcos Number", "HIP 85319"},
        {"Renson", "Renson 44260"},
        {"Smithsonian Astrophysical Observation", "SAO 208806"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.52624102),
        dec: Angle.Degrees(-37.60976041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1186"},
        {"Smithsonian Astrophysical Observation", "SAO 192415"},
    },
    visualMagnitude: 9.89,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.70482562),
        dec: Angle.Degrees(-37.60895849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152001"},
        {"Hipparcos Number", "HIP 82551"},
        {"Geneva Identification System", "GEN# +1.00152001"},
        {"Smithsonian Astrophysical Observation", "SAO 208119"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.10392751),
        dec: Angle.Degrees(-37.60739881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196289"},
        {"Hipparcos Number", "HIP 101791"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.44147666),
        dec: Angle.Degrees(-37.60505881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2784"},
        {"Hipparcos Number", "HIP 2447"},
        {"Geneva Identification System", "GEN# +1.00002784"},
        {"Smithsonian Astrophysical Observation", "SAO 192584"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.77841508),
        dec: Angle.Degrees(-37.60494621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79807"},
        {"Hipparcos Number", "HIP 45386"},
        {"Geneva Identification System", "GEN# +1.00079807"},
        {"Smithsonian Astrophysical Observation", "SAO 200152"},
    },
    visualMagnitude: 5.85,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.73819127),
        dec: Angle.Degrees(-37.60236629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192436"},
        {"Hipparcos Number", "HIP 99911"},
        {"Smithsonian Astrophysical Observation", "SAO 211944"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.07325644),
        dec: Angle.Degrees(-37.60071309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103394"},
        {"Hipparcos Number", "HIP 58043"},
        {"Smithsonian Astrophysical Observation", "SAO 202923"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.55766057),
        dec: Angle.Degrees(-37.60008923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124666"},
        {"Hipparcos Number", "HIP 69679"},
        {"Smithsonian Astrophysical Observation", "SAO 205365"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.95236798),
        dec: Angle.Degrees(-37.59975679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6536",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6536"},
        {"Smithsonian Astrophysical Observation", "SAO 193094"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.00452822),
        dec: Angle.Degrees(-37.59970954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152040"},
        {"Hipparcos Number", "HIP 82565"},
        {"Geneva Identification System", "GEN# +1.00152040"},
        {"Smithsonian Astrophysical Observation", "SAO 208125"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.15024455),
        dec: Angle.Degrees(-37.59932507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49794"},
        {"Hipparcos Number", "HIP 32632"},
        {"Smithsonian Astrophysical Observation", "SAO 197234"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.10536512),
        dec: Angle.Degrees(-37.59796425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63079"},
        {"Hipparcos Number", "HIP 37838"},
        {"Celescope Catalog", "CEL 2017"},
        {"Geneva Identification System", "GEN# +2.24510256"},
        {"Renson", "Renson 17380"},
        {"Smithsonian Astrophysical Observation", "SAO 198401"},
        {"New General Catalogue", "NGC 2451 256"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.36408923),
        dec: Angle.Degrees(-37.59631429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121896"},
        {"Hipparcos Number", "HIP 68319"},
        {"Smithsonian Astrophysical Observation", "SAO 205062"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.78784634),
        dec: Angle.Degrees(-37.59624409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126256"},
        {"Hipparcos Number", "HIP 70516"},
        {"Smithsonian Astrophysical Observation", "SAO 205540"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.36891098),
        dec: Angle.Degrees(-37.59494920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170501"},
        {"Hipparcos Number", "HIP 90800"},
        {"Geneva Identification System", "GEN# +1.00170501"},
        {"Smithsonian Astrophysical Observation", "SAO 210262"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.85083213),
        dec: Angle.Degrees(-37.59312840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123345"},
        {"Hipparcos Number", "HIP 69026"},
        {"Smithsonian Astrophysical Observation", "SAO 205210"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.96412726),
        dec: Angle.Degrees(-37.59298964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65980",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65980"},
        {"Smithsonian Astrophysical Observation", "SAO 204553"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.91205486),
        dec: Angle.Degrees(-37.59292082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216474"},
        {"Hipparcos Number", "HIP 113054"},
        {"Smithsonian Astrophysical Observation", "SAO 214168"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.42647401),
        dec: Angle.Degrees(-37.59219606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200719"},
        {"Hipparcos Number", "HIP 104168"},
        {"Geneva Identification System", "GEN# +1.00200719"},
        {"Smithsonian Astrophysical Observation", "SAO 212713"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.58926309),
        dec: Angle.Degrees(-37.58759672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178937"},
        {"Hipparcos Number", "HIP 94344"},
        {"Geneva Identification System", "GEN# +1.00178937"},
        {"Smithsonian Astrophysical Observation", "SAO 211037"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.04073835),
        dec: Angle.Degrees(-37.58309057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196664"},
        {"Hipparcos Number", "HIP 102003"},
        {"Geneva Identification System", "GEN# +1.00196664"},
        {"Smithsonian Astrophysical Observation", "SAO 212327"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.05622323),
        dec: Angle.Degrees(-37.58217643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80774"},
        {"Hipparcos Number", "HIP 45814"},
        {"Geneva Identification System", "GEN# +1.00080774"},
        {"Smithsonian Astrophysical Observation", "SAO 200257"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.12367944),
        dec: Angle.Degrees(-37.58163503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91370",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91370"},
    },
    visualMagnitude: 11.02,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.51933969),
        dec: Angle.Degrees(-37.58024624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65615"},
        {"Hipparcos Number", "HIP 38942"},
        {"Celescope Catalog", "CEL 2118"},
        {"Geneva Identification System", "GEN# +1.00065615"},
        {"Smithsonian Astrophysical Observation", "SAO 198643"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.52015949),
        dec: Angle.Degrees(-37.58007344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3785"},
        {"Hipparcos Number", "HIP 3160"},
        {"Geneva Identification System", "GEN# +1.00003785"},
        {"Smithsonian Astrophysical Observation", "SAO 192666"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.05658587),
        dec: Angle.Degrees(-37.57963135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61925"},
        {"Hipparcos Number", "HIP 37345"},
        {"Celescope Catalog", "CEL 1973"},
        {"Geneva Identification System", "GEN# +2.24510187"},
        {"Smithsonian Astrophysical Observation", "SAO 198273"},
        {"Wilson Evans Batten Catalogue", "WEB 7394"},
        {"New General Catalogue", "NGC 2451 187"},
    },
    visualMagnitude: 5.99,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.99163231),
        dec: Angle.Degrees(-37.57941274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52400"},
    },
    visualMagnitude: 11.60,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.65503936),
        dec: Angle.Degrees(-37.57845241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54724",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54724"},
        {"Geneva Identification System", "GEN# -0.03607031"},
        {"Smithsonian Astrophysical Observation", "SAO 202198"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.05603245),
        dec: Angle.Degrees(-37.57724161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -220.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14890"},
        {"Hipparcos Number", "HIP 11121"},
        {"Geneva Identification System", "GEN# +1.00014890"},
        {"Smithsonian Astrophysical Observation", "SAO 193679"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.77750969),
        dec: Angle.Degrees(-37.57606333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135985"},
        {"Hipparcos Number", "HIP 74990"},
        {"Smithsonian Astrophysical Observation", "SAO 206521"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.85919071),
        dec: Angle.Degrees(-37.57429943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68624"},
        {"Hipparcos Number", "HIP 40142"},
        {"Geneva Identification System", "GEN# +2.25460030"},
        {"Renson", "Renson 19040"},
        {"Smithsonian Astrophysical Observation", "SAO 198919"},
        {"New General Catalogue", "NGC 2546 30"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.96399111),
        dec: Angle.Degrees(-37.57409016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34539"},
        {"Hipparcos Number", "HIP 24590"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.12622484),
        dec: Angle.Degrees(-37.57272707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153137"},
        {"Hipparcos Number", "HIP 83124"},
        {"Smithsonian Astrophysical Observation", "SAO 208268"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.80787678),
        dec: Angle.Degrees(-37.57222717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212537"},
        {"Hipparcos Number", "HIP 110697"},
        {"Geneva Identification System", "GEN# +1.00212537"},
        {"Smithsonian Astrophysical Observation", "SAO 213810"},
        {"Wilson Evans Batten Catalogue", "WEB 19831"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.42056736),
        dec: Angle.Degrees(-37.56914941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88067"},
        {"Hipparcos Number", "HIP 49665"},
        {"Smithsonian Astrophysical Observation", "SAO 201089"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.08417673),
        dec: Angle.Degrees(-37.56804639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136855"},
        {"Hipparcos Number", "HIP 75380"},
        {"Smithsonian Astrophysical Observation", "SAO 206588"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.05589623),
        dec: Angle.Degrees(-37.56642923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147628"},
        {"Hipparcos Number", "HIP 80390"},
        {"Geneva Identification System", "GEN# +1.00147628J"},
        {"Smithsonian Astrophysical Observation", "SAO 207637"},
        {"Wilson Evans Batten Catalogue", "WEB 13600"},
    },
    visualMagnitude: 5.42,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.13235569),
        dec: Angle.Degrees(-37.56597007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116323"},
        {"Hipparcos Number", "HIP 65346"},
        {"Smithsonian Astrophysical Observation", "SAO 204424"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.89031024),
        dec: Angle.Degrees(-37.56440847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6466"},
        {"Hipparcos Number", "HIP 5085"},
        {"Geneva Identification System", "GEN# +1.00006466"},
        {"Smithsonian Astrophysical Observation", "SAO 192913"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.28564595),
        dec: Angle.Degrees(-37.56362150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98610"},
        {"Hipparcos Number", "HIP 55380"},
        {"Renson", "Renson 28410"},
        {"Smithsonian Astrophysical Observation", "SAO 202337"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.10586471),
        dec: Angle.Degrees(-37.56199999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1188"},
        {"Hipparcos Number", "HIP 1287"},
        {"Smithsonian Astrophysical Observation", "SAO 192431"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.03380201),
        dec: Angle.Degrees(-37.56153886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117220"},
        {"Hipparcos Number", "HIP 65819"},
        {"Geneva Identification System", "GEN# +1.00117220"},
        {"Smithsonian Astrophysical Observation", "SAO 204519"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.39837612),
        dec: Angle.Degrees(-37.55989454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43325"},
        {"Hipparcos Number", "HIP 29572"},
        {"Smithsonian Astrophysical Observation", "SAO 196609"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.46747837),
        dec: Angle.Degrees(-37.55975943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134156"},
        {"Hipparcos Number", "HIP 74185"},
    },
    visualMagnitude: 9.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.37959249),
        dec: Angle.Degrees(-37.55939161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224484"},
        {"Hipparcos Number", "HIP 118175"},
        {"Smithsonian Astrophysical Observation", "SAO 214886"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.57905408),
        dec: Angle.Degrees(-37.55782919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192528"},
        {"Hipparcos Number", "HIP 99949"},
        {"Smithsonian Astrophysical Observation", "SAO 211956"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.19250049),
        dec: Angle.Degrees(-37.55702648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38351"},
        {"Smithsonian Astrophysical Observation", "SAO 135179"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.82437438),
        dec: Angle.Degrees(-05.19720501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118059"},
        {"Hipparcos Number", "HIP 66282"},
        {"Smithsonian Astrophysical Observation", "SAO 204617"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.77154515),
        dec: Angle.Degrees(-37.55567769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203227"},
        {"Hipparcos Number", "HIP 105495"},
        {"Smithsonian Astrophysical Observation", "SAO 212945"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.50006832),
        dec: Angle.Degrees(-37.55439257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105007"},
        {"Hipparcos Number", "HIP 58969"},
        {"Smithsonian Astrophysical Observation", "SAO 203114"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.36681303),
        dec: Angle.Degrees(-37.55231878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173505"},
        {"Hipparcos Number", "HIP 92188"},
        {"Smithsonian Astrophysical Observation", "SAO 210570"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.82930998),
        dec: Angle.Degrees(-37.54860695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16830"},
        {"Hipparcos Number", "HIP 12498"},
        {"Geneva Identification System", "GEN# +1.00016830"},
        {"Smithsonian Astrophysical Observation", "SAO 193851"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.20222332),
        dec: Angle.Degrees(-37.54807921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182185"},
        {"Hipparcos Number", "HIP 95454"},
        {"Smithsonian Astrophysical Observation", "SAO 211244"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.25874659),
        dec: Angle.Degrees(-37.54785851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41393"},
        {"Hipparcos Number", "HIP 28654"},
        {"Smithsonian Astrophysical Observation", "SAO 196443"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.76320863),
        dec: Angle.Degrees(-37.54711099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26232"},
        {"Smithsonian Astrophysical Observation", "SAO 195993"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.83899278),
        dec: Angle.Degrees(-37.54473518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129363"},
        {"Hipparcos Number", "HIP 71977"},
        {"Smithsonian Astrophysical Observation", "SAO 205862"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.81923210),
        dec: Angle.Degrees(-37.54026122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201577"},
        {"Hipparcos Number", "HIP 104624"},
        {"Smithsonian Astrophysical Observation", "SAO 212777"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.90618412),
        dec: Angle.Degrees(-37.53981125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186042"},
        {"Hipparcos Number", "HIP 97067"},
        {"Fundamental Katalog 5th Edition", "FK5 3576"},
        {"Geneva Identification System", "GEN# +1.00186042"},
        {"Smithsonian Astrophysical Observation", "SAO 211506"},
        {"Wilson Evans Batten Catalogue", "WEB 17034"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.90673775),
        dec: Angle.Degrees(-37.53872252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184081"},
        {"Hipparcos Number", "HIP 96250"},
        {"Geneva Identification System", "GEN# +1.00184081"},
        {"Smithsonian Astrophysical Observation", "SAO 211372"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.57303481),
        dec: Angle.Degrees(-37.53692085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27747"},
        {"Hipparcos Number", "HIP 20320"},
        {"Geneva Identification System", "GEN# +1.00027747"},
        {"Smithsonian Astrophysical Observation", "SAO 194948"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.29621773),
        dec: Angle.Degrees(-37.53494034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143473"},
        {"Hipparcos Number", "HIP 78533"},
        {"Geneva Identification System", "GEN# +1.00143473"},
        {"Renson", "Renson 40620"},
        {"Smithsonian Astrophysical Observation", "SAO 207245"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.49530548),
        dec: Angle.Degrees(-37.53430930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45201"},
        {"Hipparcos Number", "HIP 30475"},
        {"Smithsonian Astrophysical Observation", "SAO 196783"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.10113570),
        dec: Angle.Degrees(-37.53375074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39915"},
        {"Hipparcos Number", "HIP 27873"},
        {"Renson", "Renson 10660"},
        {"Smithsonian Astrophysical Observation", "SAO 196294"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.47112509),
        dec: Angle.Degrees(-37.53344054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13946"},
        {"Hipparcos Number", "HIP 10459"},
        {"Smithsonian Astrophysical Observation", "SAO 193597"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.69985631),
        dec: Angle.Degrees(-37.53284823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47907"},
        {"Hipparcos Number", "HIP 31815"},
        {"Smithsonian Astrophysical Observation", "SAO 197046"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.77428017),
        dec: Angle.Degrees(-37.53271624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128284"},
        {"Hipparcos Number", "HIP 71488"},
        {"Smithsonian Astrophysical Observation", "SAO 205766"},
    },
    visualMagnitude: 7.51,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.28941763),
        dec: Angle.Degrees(-37.53197647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80018"},
        {"Geneva Identification System", "GEN# -0.03710765"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.01688193),
        dec: Angle.Degrees(-37.53142026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -729.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 991.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191153"},
        {"Hipparcos Number", "HIP 99348"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.46205314),
        dec: Angle.Degrees(-37.53067595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143020"},
        {"Hipparcos Number", "HIP 78308"},
        {"Smithsonian Astrophysical Observation", "SAO 207193"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.83960467),
        dec: Angle.Degrees(-37.52997967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113912",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113912"},
        {"Smithsonian Astrophysical Observation", "SAO 214282"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.01822527),
        dec: Angle.Degrees(-37.52963363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68714"},
        {"Hipparcos Number", "HIP 40171"},
        {"Geneva Identification System", "GEN# +2.25460134"},
        {"Smithsonian Astrophysical Observation", "SAO 198928"},
        {"New General Catalogue", "NGC 2546 134"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.06420444),
        dec: Angle.Degrees(-37.52922024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200344"},
        {"Hipparcos Number", "HIP 103990"},
        {"Geneva Identification System", "GEN# +1.00200344"},
        {"Smithsonian Astrophysical Observation", "SAO 212681"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.03638785),
        dec: Angle.Degrees(-37.52900887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189854"},
        {"Hipparcos Number", "HIP 98766"},
        {"Smithsonian Astrophysical Observation", "SAO 211770"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.89996001),
        dec: Angle.Degrees(-37.52831311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106130"},
        {"Hipparcos Number", "HIP 59552"},
        {"Fundamental Katalog 5th Edition", "FK5 5084"},
        {"Smithsonian Astrophysical Observation", "SAO 203238"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.20014409),
        dec: Angle.Degrees(-37.52709258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74731"},
        {"Hipparcos Number", "HIP 42879"},
        {"Smithsonian Astrophysical Observation", "SAO 199564"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.07798143),
        dec: Angle.Degrees(-37.52683786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13612",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13612"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.84854883),
        dec: Angle.Degrees(-37.52557051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18545"},
        {"Hipparcos Number", "HIP 13798"},
        {"Smithsonian Astrophysical Observation", "SAO 194008"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.40816418),
        dec: Angle.Degrees(-37.52512366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15671"},
        {"Smithsonian Astrophysical Observation", "SAO 130443"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.47501422),
        dec: Angle.Degrees(-05.10131683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24498"},
        {"Hipparcos Number", "HIP 18114"},
        {"Smithsonian Astrophysical Observation", "SAO 194596"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.09156574),
        dec: Angle.Degrees(-37.52416556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179029"},
        {"Hipparcos Number", "HIP 94378"},
        {"Smithsonian Astrophysical Observation", "SAO 211042"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.14392490),
        dec: Angle.Degrees(-37.52399761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93545"},
        {"Hipparcos Number", "HIP 52778"},
        {"Celescope Catalog", "CEL 3704"},
        {"Geneva Identification System", "GEN# +1.00093545"},
        {"Smithsonian Astrophysical Observation", "SAO 201748"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.85995777),
        dec: Angle.Degrees(-37.52376838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5403"},
        {"Hipparcos Number", "HIP 4332"},
        {"Geneva Identification System", "GEN# +1.00005403"},
        {"Smithsonian Astrophysical Observation", "SAO 192818"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.86149028),
        dec: Angle.Degrees(-37.52369476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46508",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46508"},
        {"Geneva Identification System", "GEN# -0.03605714"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.28101687),
        dec: Angle.Degrees(-37.52362004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51605"},
        {"Hipparcos Number", "HIP 33365"},
        {"Celescope Catalog", "CEL 1447"},
        {"Geneva Identification System", "GEN# +1.00051605"},
        {"Smithsonian Astrophysical Observation", "SAO 197383"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.08716934),
        dec: Angle.Degrees(-37.52147984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151771"},
        {"Hipparcos Number", "HIP 82453"},
        {"Geneva Identification System", "GEN# +1.00151771J"},
        {"Smithsonian Astrophysical Observation", "SAO 208089"},
        {"Wilson Evans Batten Catalogue", "WEB 13919"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.75015920),
        dec: Angle.Degrees(-37.51448120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39213"},
        {"Hipparcos Number", "HIP 27491"},
        {"Smithsonian Astrophysical Observation", "SAO 196210"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.31808273),
        dec: Angle.Degrees(-37.51327330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144100"},
        {"Hipparcos Number", "HIP 78835"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.39933835),
        dec: Angle.Degrees(-37.51325803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111670"},
        {"Hipparcos Number", "HIP 62721"},
        {"Smithsonian Astrophysical Observation", "SAO 203866"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.79949771),
        dec: Angle.Degrees(-37.51213656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142234"},
        {"Hipparcos Number", "HIP 77931"},
        {"Smithsonian Astrophysical Observation", "SAO 207105"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.72906271),
        dec: Angle.Degrees(-37.51126067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133275"},
        {"Hipparcos Number", "HIP 73774"},
        {"Smithsonian Astrophysical Observation", "SAO 206264"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.19794946),
        dec: Angle.Degrees(-37.50737478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215602"},
        {"Hipparcos Number", "HIP 112466"},
        {"Smithsonian Astrophysical Observation", "SAO 214073"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.71642247),
        dec: Angle.Degrees(-37.50729282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139232"},
        {"Hipparcos Number", "HIP 76583"},
        {"Smithsonian Astrophysical Observation", "SAO 206825"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.60746454),
        dec: Angle.Degrees(-37.50686706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57411"},
        {"Hipparcos Number", "HIP 35483"},
        {"Celescope Catalog", "CEL 1785"},
        {"Geneva Identification System", "GEN# +1.00057411"},
        {"Smithsonian Astrophysical Observation", "SAO 197850"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.86306927),
        dec: Angle.Degrees(-37.50664733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172125"},
        {"Hipparcos Number", "HIP 91540"},
        {"Smithsonian Astrophysical Observation", "SAO 210422"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.02361922),
        dec: Angle.Degrees(-37.50518875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134503"},
        {"Hipparcos Number", "HIP 74324"},
        {"Smithsonian Astrophysical Observation", "SAO 206374"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.86684829),
        dec: Angle.Degrees(-37.50508700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87931"},
        {"Hipparcos Number", "HIP 49599"},
        {"Geneva Identification System", "GEN# +1.00087931"},
        {"Smithsonian Astrophysical Observation", "SAO 201074"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.86795652),
        dec: Angle.Degrees(-37.50393700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142889"},
        {"Hipparcos Number", "HIP 78236"},
        {"Geneva Identification System", "GEN# +1.00142889"},
        {"Smithsonian Astrophysical Observation", "SAO 207178"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.62835853),
        dec: Angle.Degrees(-37.50382460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44528"},
        {"Hipparcos Number", "HIP 30134"},
        {"Geneva Identification System", "GEN# +1.00044528"},
        {"Smithsonian Astrophysical Observation", "SAO 196706"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.12212143),
        dec: Angle.Degrees(-37.50366274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88701"},
        {"Hipparcos Number", "HIP 50042"},
        {"Renson", "Renson 25390"},
        {"Smithsonian Astrophysical Observation", "SAO 201181"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.25098806),
        dec: Angle.Degrees(-37.50347425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16122"},
        {"Hipparcos Number", "HIP 11958"},
        {"Geneva Identification System", "GEN# +1.00016122"},
        {"Smithsonian Astrophysical Observation", "SAO 193778"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.57097497),
        dec: Angle.Degrees(-37.50183187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136991"},
        {"Hipparcos Number", "HIP 75459"},
        {"Smithsonian Astrophysical Observation", "SAO 206606"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.23391892),
        dec: Angle.Degrees(-37.50146724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135411"},
        {"Hipparcos Number", "HIP 74714"},
        {"Smithsonian Astrophysical Observation", "SAO 206467"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.03561002),
        dec: Angle.Degrees(-37.50136563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51289"},
        {"Hipparcos Number", "HIP 33249"},
        {"Celescope Catalog", "CEL 1439"},
        {"Geneva Identification System", "GEN# +1.00051289"},
        {"Smithsonian Astrophysical Observation", "SAO 197360"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.76748733),
        dec: Angle.Degrees(-37.50035450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193851"},
        {"Hipparcos Number", "HIP 100584"},
        {"Geneva Identification System", "GEN# +1.00193851"},
        {"Smithsonian Astrophysical Observation", "SAO 212075"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.96049692),
        dec: Angle.Degrees(-37.50020166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51375"},
        {"Smithsonian Astrophysical Observation", "SAO 201443"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.39251545),
        dec: Angle.Degrees(-37.50004819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165137"},
        {"Hipparcos Number", "HIP 88680"},
        {"Geneva Identification System", "GEN# +1.00165137"},
        {"Smithsonian Astrophysical Observation", "SAO 209702"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.55236829),
        dec: Angle.Degrees(-37.49894214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26070"},
        {"Hipparcos Number", "HIP 19133"},
        {"Smithsonian Astrophysical Observation", "SAO 194760"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.51560175),
        dec: Angle.Degrees(-37.49809375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164022"},
        {"Hipparcos Number", "HIP 88210"},
        {"Smithsonian Astrophysical Observation", "SAO 209587"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.20134540),
        dec: Angle.Degrees(-37.49754828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175073"},
        {"Hipparcos Number", "HIP 92858"},
        {"Cincinnati Publication", "Ci 20 1115"},
        {"Geneva Identification System", "GEN# +1.00175073"},
        {"Smithsonian Astrophysical Observation", "SAO 210713"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.82791823),
        dec: Angle.Degrees(-37.49748357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -357.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161121"},
        {"Hipparcos Number", "HIP 86903"},
        {"Smithsonian Astrophysical Observation", "SAO 209221"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.35483289),
        dec: Angle.Degrees(-37.49693092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12033"},
        {"Hipparcos Number", "HIP 9106"},
        {"Geneva Identification System", "GEN# +1.00012033"},
        {"Smithsonian Astrophysical Observation", "SAO 193407"},
        {"Wilson Evans Batten Catalogue", "WEB 1912"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.31723945),
        dec: Angle.Degrees(-37.49645422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44610"},
        {"Hipparcos Number", "HIP 30172"},
        {"Geneva Identification System", "GEN# +1.00044610"},
        {"Smithsonian Astrophysical Observation", "SAO 196717"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.22801497),
        dec: Angle.Degrees(-37.49346935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187497"},
        {"Hipparcos Number", "HIP 97735"},
        {"Smithsonian Astrophysical Observation", "SAO 211608"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.92335718),
        dec: Angle.Degrees(-37.49234760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107783"},
        {"Hipparcos Number", "HIP 60414"},
        {"Smithsonian Astrophysical Observation", "SAO 203418"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.80983016),
        dec: Angle.Degrees(-37.48980737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38596"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.54725287),
        dec: Angle.Degrees(-37.48793790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168357"},
        {"Hipparcos Number", "HIP 89920"},
        {"Geneva Identification System", "GEN# +1.00168357"},
        {"Smithsonian Astrophysical Observation", "SAO 210017"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.22995361),
        dec: Angle.Degrees(-37.48763070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111532"},
        {"Hipparcos Number", "HIP 62640"},
        {"Smithsonian Astrophysical Observation", "SAO 203852"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.54430436),
        dec: Angle.Degrees(-37.48135457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57589"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.10109093),
        dec: Angle.Degrees(-37.48026478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104327"},
        {"Hipparcos Number", "HIP 58580"},
        {"Geneva Identification System", "GEN# +1.00104327"},
        {"Smithsonian Astrophysical Observation", "SAO 203034"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.20091835),
        dec: Angle.Degrees(-37.47929832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173683"},
        {"Hipparcos Number", "HIP 92263"},
        {"Geneva Identification System", "GEN# +1.00173683"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.05179225),
        dec: Angle.Degrees(-37.47928628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148121"},
        {"Hipparcos Number", "HIP 80603"},
        {"Smithsonian Astrophysical Observation", "SAO 207677"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.85925262),
        dec: Angle.Degrees(-37.47693909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53044"},
        {"Geneva Identification System", "GEN# -0.03606742"},
        {"Smithsonian Astrophysical Observation", "SAO 201826"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.79750921),
        dec: Angle.Degrees(-37.47347240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10268"},
        {"Hipparcos Number", "HIP 7742"},
        {"Geneva Identification System", "GEN# +1.00010268"},
        {"Smithsonian Astrophysical Observation", "SAO 193237"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.92289345),
        dec: Angle.Degrees(-37.47337966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4169"},
        {"Hipparcos Number", "HIP 3434"},
        {"Geneva Identification System", "GEN# +1.00004169"},
        {"Smithsonian Astrophysical Observation", "SAO 192698"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.95296967),
        dec: Angle.Degrees(-37.47278427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10257"},
        {"Hipparcos Number", "HIP 7739"},
        {"Geneva Identification System", "GEN# +1.00010257"},
        {"Smithsonian Astrophysical Observation", "SAO 193236"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.91601151),
        dec: Angle.Degrees(-37.47270526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164999"},
        {"Hipparcos Number", "HIP 88614"},
        {"Smithsonian Astrophysical Observation", "SAO 209684"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.38720138),
        dec: Angle.Degrees(-37.47176457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73881"},
        {"Hipparcos Number", "HIP 42441"},
        {"Smithsonian Astrophysical Observation", "SAO 199470"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.80938438),
        dec: Angle.Degrees(-37.47020560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122195"},
        {"Hipparcos Number", "HIP 68474"},
        {"Smithsonian Astrophysical Observation", "SAO 205093"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.28480830),
        dec: Angle.Degrees(-37.46991822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72645"},
        {"Hipparcos Number", "HIP 41911"},
        {"Geneva Identification System", "GEN# +1.00072645"},
        {"Smithsonian Astrophysical Observation", "SAO 199350"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.17902475),
        dec: Angle.Degrees(-37.46945351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138793"},
        {"Hipparcos Number", "HIP 76346"},
        {"Geneva Identification System", "GEN# +1.00138793"},
        {"Smithsonian Astrophysical Observation", "SAO 206787"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.90937240),
        dec: Angle.Degrees(-37.46933104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56562",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56562"},
        {"Smithsonian Astrophysical Observation", "SAO 202608"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.94611311),
        dec: Angle.Degrees(-37.46828544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188517"},
        {"Hipparcos Number", "HIP 98167"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.24524794),
        dec: Angle.Degrees(-37.46764896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44310"},
        {"Hipparcos Number", "HIP 30045"},
        {"Geneva Identification System", "GEN# +1.00044310"},
        {"Smithsonian Astrophysical Observation", "SAO 196684"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.82920087),
        dec: Angle.Degrees(-37.46283179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -215.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145211"},
        {"Hipparcos Number", "HIP 79317"},
        {"Fundamental Katalog 5th Edition", "FK5 5426"},
        {"Geneva Identification System", "GEN# +1.00145211"},
        {"Smithsonian Astrophysical Observation", "SAO 207427"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.81258674),
        dec: Angle.Degrees(-37.46107970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38211"},
        {"Hipparcos Number", "HIP 26874"},
        {"Geneva Identification System", "GEN# +1.00038211"},
        {"Smithsonian Astrophysical Observation", "SAO 196100"},
        {"Wilson Evans Batten Catalogue", "WEB 5297"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.58539984),
        dec: Angle.Degrees(-37.45809962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107574"},
        {"Smithsonian Astrophysical Observation", "SAO 213283"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.80683443),
        dec: Angle.Degrees(-37.45665654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30500"},
        {"Hipparcos Number", "HIP 22205"},
        {"Smithsonian Astrophysical Observation", "SAO 195286"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.63301999),
        dec: Angle.Degrees(-37.45592518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18809"},
        {"Hipparcos Number", "HIP 14007"},
        {"Geneva Identification System", "GEN# +1.00018809"},
        {"Smithsonian Astrophysical Observation", "SAO 194029"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.08210459),
        dec: Angle.Degrees(-37.45455908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200202"},
        {"Hipparcos Number", "HIP 103912"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.81258483),
        dec: Angle.Degrees(-37.45337470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216089"},
        {"Hipparcos Number", "HIP 112793"},
        {"Smithsonian Astrophysical Observation", "SAO 214126"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.61969323),
        dec: Angle.Degrees(-37.45091021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195472"},
        {"Hipparcos Number", "HIP 101395"},
        {"Smithsonian Astrophysical Observation", "SAO 212224"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.23369646),
        dec: Angle.Degrees(-37.45065299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162783"},
        {"Hipparcos Number", "HIP 87672"},
        {"Smithsonian Astrophysical Observation", "SAO 209444"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.61374431),
        dec: Angle.Degrees(-37.45013283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20914"},
        {"Hipparcos Number", "HIP 15607"},
        {"Smithsonian Astrophysical Observation", "SAO 194245"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.24487482),
        dec: Angle.Degrees(-37.44982063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110875"},
        {"Hipparcos Number", "HIP 62254"},
        {"Smithsonian Astrophysical Observation", "SAO 203777"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.36632409),
        dec: Angle.Degrees(-37.44923821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47145"},
        {"Hipparcos Number", "HIP 31449"},
        {"Smithsonian Astrophysical Observation", "SAO 196977"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.83723248),
        dec: Angle.Degrees(-37.44908339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109398",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109398"},
        {"Smithsonian Astrophysical Observation", "SAO 213597"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.44460867),
        dec: Angle.Degrees(-37.44874265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2091"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.59797365),
        dec: Angle.Degrees(-37.44859444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113208"},
        {"Hipparcos Number", "HIP 63630"},
        {"Smithsonian Astrophysical Observation", "SAO 204062"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.62249804),
        dec: Angle.Degrees(-37.44855082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16166"},
        {"Smithsonian Astrophysical Observation", "SAO 194320"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.07774516),
        dec: Angle.Degrees(-37.44724395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126194"},
        {"Hipparcos Number", "HIP 70483"},
        {"Celescope Catalog", "CEL 4318"},
        {"Geneva Identification System", "GEN# +1.00126194"},
        {"Smithsonian Astrophysical Observation", "SAO 205531"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.25434570),
        dec: Angle.Degrees(-37.44695904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61087"},
        {"Hipparcos Number", "HIP 36963"},
        {"Celescope Catalog", "CEL 1946"},
        {"Geneva Identification System", "GEN# +2.24510131"},
        {"Smithsonian Astrophysical Observation", "SAO 198174"},
        {"New General Catalogue", "NGC 2451 131"},
    },
    visualMagnitude: 7.25,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.98151522),
        dec: Angle.Degrees(-37.44575775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162188"},
        {"Hipparcos Number", "HIP 87387"},
        {"Smithsonian Astrophysical Observation", "SAO 209359"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.86158490),
        dec: Angle.Degrees(-37.44372837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92374"},
        {"Hipparcos Number", "HIP 52156"},
        {"Smithsonian Astrophysical Observation", "SAO 201600"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.83156520),
        dec: Angle.Degrees(-37.44050655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213970"},
        {"Hipparcos Number", "HIP 111530"},
        {"Smithsonian Astrophysical Observation", "SAO 213937"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.93906228),
        dec: Angle.Degrees(-37.44023034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185907"},
        {"Hipparcos Number", "HIP 97000"},
        {"Geneva Identification System", "GEN# +1.00185907"},
        {"Smithsonian Astrophysical Observation", "SAO 211493"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.73162480),
        dec: Angle.Degrees(-37.43979656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159312"},
        {"Hipparcos Number", "HIP 86098"},
        {"Geneva Identification System", "GEN# +1.00159312"},
        {"Smithsonian Astrophysical Observation", "SAO 209001"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.92947954),
        dec: Angle.Degrees(-37.43979190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153232"},
        {"Hipparcos Number", "HIP 83159"},
        {"Smithsonian Astrophysical Observation", "SAO 208278"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.92698376),
        dec: Angle.Degrees(-37.43796901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141643"},
        {"Hipparcos Number", "HIP 77685"},
        {"Smithsonian Astrophysical Observation", "SAO 207048"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.89662236),
        dec: Angle.Degrees(-37.43734209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158409"},
        {"Hipparcos Number", "HIP 85700"},
        {"Smithsonian Astrophysical Observation", "SAO 208897"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.69985554),
        dec: Angle.Degrees(-37.43690986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213808"},
        {"Hipparcos Number", "HIP 111450"},
        {"Geneva Identification System", "GEN# +1.00213808"},
        {"Smithsonian Astrophysical Observation", "SAO 213925"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.67432110),
        dec: Angle.Degrees(-37.43613959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67680"},
        {"Hipparcos Number", "HIP 39763"},
        {"Smithsonian Astrophysical Observation", "SAO 198824"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.90870810),
        dec: Angle.Degrees(-37.43564106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212084"},
        {"Hipparcos Number", "HIP 110455"},
        {"Smithsonian Astrophysical Observation", "SAO 213769"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.59816022),
        dec: Angle.Degrees(-37.43454066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222536"},
        {"Hipparcos Number", "HIP 116892"},
        {"Geneva Identification System", "GEN# +1.00222536"},
        {"Smithsonian Astrophysical Observation", "SAO 214713"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.40329865),
        dec: Angle.Degrees(-37.43341857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92432"},
        {"Hipparcos Number", "HIP 52188"},
        {"Smithsonian Astrophysical Observation", "SAO 201610"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.92618018),
        dec: Angle.Degrees(-37.43323352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3950"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.67366018),
        dec: Angle.Degrees(-37.43313021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165121"},
        {"Hipparcos Number", "HIP 88662"},
        {"Smithsonian Astrophysical Observation", "SAO 209698"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.51939774),
        dec: Angle.Degrees(-37.43310860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125969"},
        {"Hipparcos Number", "HIP 70355"},
        {"Smithsonian Astrophysical Observation", "SAO 205509"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.92370709),
        dec: Angle.Degrees(-37.43175955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101327"},
        {"Hipparcos Number", "HIP 56863"},
        {"Smithsonian Astrophysical Observation", "SAO 202675"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.87277162),
        dec: Angle.Degrees(-37.43143470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53657"},
        {"Hipparcos Number", "HIP 34090"},
        {"Smithsonian Astrophysical Observation", "SAO 197536"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.03159995),
        dec: Angle.Degrees(-37.42633352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115067"},
        {"Hipparcos Number", "HIP 64658"},
        {"Geneva Identification System", "GEN# +1.00115067"},
        {"Smithsonian Astrophysical Observation", "SAO 204285"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.80985474),
        dec: Angle.Degrees(-37.42498582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139980"},
        {"Hipparcos Number", "HIP 76939"},
        {"Fundamental Katalog 5th Edition", "FK5 3242"},
        {"Geneva Identification System", "GEN# +1.00139980"},
        {"Smithsonian Astrophysical Observation", "SAO 206887"},
        {"Wilson Evans Batten Catalogue", "WEB 13047"},
    },
    visualMagnitude: 5.23,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.65980143),
        dec: Angle.Degrees(-37.42489640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147371"},
        {"Hipparcos Number", "HIP 80267"},
        {"Smithsonian Astrophysical Observation", "SAO 207611"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.78192066),
        dec: Angle.Degrees(-37.42445994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83011"},
        {"Hipparcos Number", "HIP 46976"},
        {"Smithsonian Astrophysical Observation", "SAO 200520"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.61770016),
        dec: Angle.Degrees(-37.42200499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60977"},
        {"Hipparcos Number", "HIP 36926"},
        {"Smithsonian Astrophysical Observation", "SAO 198159"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.86072466),
        dec: Angle.Degrees(-37.42039168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73903"},
    },
    visualMagnitude: 12.79,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.56075473),
        dec: Angle.Degrees(-37.41970952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -404.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1082.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34072"},
        {"Hipparcos Number", "HIP 24314"},
        {"Smithsonian Astrophysical Observation", "SAO 195658"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.26383628),
        dec: Angle.Degrees(-37.41870976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70289"},
        {"Hipparcos Number", "HIP 40811"},
        {"Geneva Identification System", "GEN# +1.00070289"},
        {"Smithsonian Astrophysical Observation", "SAO 199090"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.93933397),
        dec: Angle.Degrees(-37.41775688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98554"},
        {"Hipparcos Number", "HIP 55346"},
        {"Smithsonian Astrophysical Observation", "SAO 202330"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.01246480),
        dec: Angle.Degrees(-37.41340129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79940"},
        {"Hipparcos Number", "HIP 45448"},
        {"Geneva Identification System", "GEN# +1.00079940J"},
        {"Smithsonian Astrophysical Observation", "SAO 200163"},
        {"Wilson Evans Batten Catalogue", "WEB 8646"},
    },
    visualMagnitude: 4.63,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.93778941),
        dec: Angle.Degrees(-37.41312644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50880"},
    },
    visualMagnitude: 10.76,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.83998155),
        dec: Angle.Degrees(-37.41086529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1999"},
        {"Hipparcos Number", "HIP 1904"},
        {"Geneva Identification System", "GEN# +1.00001999"},
        {"Smithsonian Astrophysical Observation", "SAO 192504"},
        {"Wilson Evans Batten Catalogue", "WEB 347"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.01520523),
        dec: Angle.Degrees(-37.41058116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156005"},
        {"Hipparcos Number", "HIP 84528"},
        {"Smithsonian Astrophysical Observation", "SAO 208613"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.19889198),
        dec: Angle.Degrees(-37.40938693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207644"},
        {"Hipparcos Number", "HIP 107876"},
        {"Geneva Identification System", "GEN# +1.00207644"},
        {"Smithsonian Astrophysical Observation", "SAO 213337"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.85092041),
        dec: Angle.Degrees(-37.40877537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3736"},
        {"Hipparcos Number", "HIP 3135"},
        {"Geneva Identification System", "GEN# +1.00003736"},
        {"Smithsonian Astrophysical Observation", "SAO 192662"},
        {"Wilson Evans Batten Catalogue", "WEB 562"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.96421771),
        dec: Angle.Degrees(-37.40823583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163900"},
        {"Hipparcos Number", "HIP 88147"},
        {"Smithsonian Astrophysical Observation", "SAO 209576"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.06279366),
        dec: Angle.Degrees(-37.40815948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223948"},
        {"Hipparcos Number", "HIP 117838"},
        {"Geneva Identification System", "GEN# +1.00223948J"},
        {"Smithsonian Astrophysical Observation", "SAO 214843"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.48332117),
        dec: Angle.Degrees(-37.40800262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16048"},
        {"Hipparcos Number", "HIP 11903"},
        {"Smithsonian Astrophysical Observation", "SAO 193770"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.39777618),
        dec: Angle.Degrees(-37.40735629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153788"},
        {"Hipparcos Number", "HIP 83418"},
        {"Smithsonian Astrophysical Observation", "SAO 208342"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.75894087),
        dec: Angle.Degrees(-37.40640700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204334"},
        {"Hipparcos Number", "HIP 106056"},
        {"Smithsonian Astrophysical Observation", "SAO 213032"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.22421063),
        dec: Angle.Degrees(-37.40414854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1855"},
        {"Hipparcos Number", "HIP 1804"},
        {"Smithsonian Astrophysical Observation", "SAO 192493"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.71613215),
        dec: Angle.Degrees(-37.40339893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24542"},
        {"Hipparcos Number", "HIP 18150"},
        {"Smithsonian Astrophysical Observation", "SAO 194598"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.20150850),
        dec: Angle.Degrees(-37.40286008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194433"},
        {"Hipparcos Number", "HIP 100852"},
        {"Geneva Identification System", "GEN# +1.00194433J"},
        {"Smithsonian Astrophysical Observation", "SAO 212126"},
        {"Wilson Evans Batten Catalogue", "WEB 18222"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.72140299),
        dec: Angle.Degrees(-37.40262700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -255.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107381",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107381"},
        {"Smithsonian Astrophysical Observation", "SAO 213257"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.24533065),
        dec: Angle.Degrees(-37.40211397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97868"},
    },
    visualMagnitude: 11.95,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.32058635),
        dec: Angle.Degrees(-37.40145687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185321"},
        {"Hipparcos Number", "HIP 96752"},
        {"Smithsonian Astrophysical Observation", "SAO 211455"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.02075930),
        dec: Angle.Degrees(-37.40129776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17627"},
        {"Hipparcos Number", "HIP 13112"},
        {"Smithsonian Astrophysical Observation", "SAO 193926"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.15826498),
        dec: Angle.Degrees(-37.40113732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63020"},
        {"Smithsonian Astrophysical Observation", "SAO 203930"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.71862980),
        dec: Angle.Degrees(-37.40072792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115898"},
        {"Smithsonian Astrophysical Observation", "SAO 214572"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.21551672),
        dec: Angle.Degrees(-37.39940098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130589"},
        {"Hipparcos Number", "HIP 72559"},
        {"Geneva Identification System", "GEN# +1.00130589"},
        {"Smithsonian Astrophysical Observation", "SAO 205991"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.52334187),
        dec: Angle.Degrees(-37.39859303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84162"},
        {"Hipparcos Number", "HIP 47585"},
        {"Geneva Identification System", "GEN# +1.00084162"},
        {"Smithsonian Astrophysical Observation", "SAO 200648"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.53678143),
        dec: Angle.Degrees(-37.39856859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141885"},
        {"Hipparcos Number", "HIP 77772"},
        {"Geneva Identification System", "GEN# +1.00141885"},
        {"Smithsonian Astrophysical Observation", "SAO 207076"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.21699367),
        dec: Angle.Degrees(-37.39851211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80332"},
        {"Hipparcos Number", "HIP 45623"},
        {"Geneva Identification System", "GEN# +1.00080332"},
        {"Smithsonian Astrophysical Observation", "SAO 200204"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.48517404),
        dec: Angle.Degrees(-37.39798824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114548"},
        {"Hipparcos Number", "HIP 64381"},
        {"Smithsonian Astrophysical Observation", "SAO 204216"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.93156045),
        dec: Angle.Degrees(-37.39750061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9946"},
        {"Smithsonian Astrophysical Observation", "SAO 129711"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.00397802),
        dec: Angle.Degrees(-04.98281052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181087"},
        {"Hipparcos Number", "HIP 95070"},
        {"Geneva Identification System", "GEN# +1.00181087"},
        {"Smithsonian Astrophysical Observation", "SAO 211190"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.14404716),
        dec: Angle.Degrees(-37.39670628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33872"},
        {"Hipparcos Number", "HIP 24189"},
        {"Geneva Identification System", "GEN# +1.00033872"},
        {"Smithsonian Astrophysical Observation", "SAO 195639"},
        {"Wilson Evans Batten Catalogue", "WEB 4697"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.89934414),
        dec: Angle.Degrees(-37.39530522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120638"},
        {"Hipparcos Number", "HIP 67629"},
        {"Smithsonian Astrophysical Observation", "SAO 204909"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.86010834),
        dec: Angle.Degrees(-37.39233706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93228"},
        {"Hipparcos Number", "HIP 52606"},
        {"Smithsonian Astrophysical Observation", "SAO 201716"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.36096616),
        dec: Angle.Degrees(-37.39231190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6392"},
        {"Hipparcos Number", "HIP 5019"},
        {"Smithsonian Astrophysical Observation", "SAO 192904"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.07927981),
        dec: Angle.Degrees(-37.39202511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106141"},
        {"Hipparcos Number", "HIP 59557"},
        {"Geneva Identification System", "GEN# +1.00106141"},
        {"Smithsonian Astrophysical Observation", "SAO 203239"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.21606123),
        dec: Angle.Degrees(-37.38956949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137952"},
        {"Hipparcos Number", "HIP 75922"},
        {"Smithsonian Astrophysical Observation", "SAO 206705"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.60447450),
        dec: Angle.Degrees(-37.38705899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196151"},
        {"Hipparcos Number", "HIP 101707"},
        {"Smithsonian Astrophysical Observation", "SAO 212280"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.22951741),
        dec: Angle.Degrees(-37.38687596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91645"},
        {"Hipparcos Number", "HIP 51739"},
        {"Celescope Catalog", "CEL 3581"},
        {"Geneva Identification System", "GEN# +1.00091645J"},
        {"Smithsonian Astrophysical Observation", "SAO 201523"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.57080080),
        dec: Angle.Degrees(-37.38680247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175093"},
        {"Hipparcos Number", "HIP 92866"},
        {"Smithsonian Astrophysical Observation", "SAO 210716"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.84813605),
        dec: Angle.Degrees(-37.38660171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179642"},
        {"Hipparcos Number", "HIP 94587"},
        {"Smithsonian Astrophysical Observation", "SAO 211083"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.74200595),
        dec: Angle.Degrees(-37.38441621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138066"},
        {"Hipparcos Number", "HIP 75975"},
        {"Smithsonian Astrophysical Observation", "SAO 206716"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.73302911),
        dec: Angle.Degrees(-37.38315466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 756"},
    },
    visualMagnitude: 11.26,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.32522728),
        dec: Angle.Degrees(-37.38291472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 294.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74417"},
        {"Hipparcos Number", "HIP 42740"},
        {"Smithsonian Astrophysical Observation", "SAO 199528"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.65804047),
        dec: Angle.Degrees(-37.38284069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149036"},
        {"Hipparcos Number", "HIP 81083"},
        {"Smithsonian Astrophysical Observation", "SAO 207767"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.42104668),
        dec: Angle.Degrees(-37.38277797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54761",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54761"},
        {"Smithsonian Astrophysical Observation", "SAO 202206"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.18149985),
        dec: Angle.Degrees(-37.38171869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13410"},
        {"Hipparcos Number", "HIP 10110"},
        {"Geneva Identification System", "GEN# +1.00013410"},
        {"Smithsonian Astrophysical Observation", "SAO 193549"},
        {"Wilson Evans Batten Catalogue", "WEB 2114"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.51803584),
        dec: Angle.Degrees(-37.38022402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169811"},
        {"Hipparcos Number", "HIP 90511"},
        {"Geneva Identification System", "GEN# +1.00169811"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.02617330),
        dec: Angle.Degrees(-37.37642340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119192"},
        {"Hipparcos Number", "HIP 66887"},
        {"Smithsonian Astrophysical Observation", "SAO 204751"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.61231596),
        dec: Angle.Degrees(-37.37632244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70003"},
        {"Hipparcos Number", "HIP 40673"},
        {"Celescope Catalog", "CEL 2336"},
        {"Geneva Identification System", "GEN# +1.00070003"},
        {"Smithsonian Astrophysical Observation", "SAO 199059"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.55335174),
        dec: Angle.Degrees(-37.37461575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61924"},
        {"Hipparcos Number", "HIP 37348"},
        {"Geneva Identification System", "GEN# +2.24510188"},
        {"Smithsonian Astrophysical Observation", "SAO 198274"},
        {"New General Catalogue", "NGC 2451 188"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.99540680),
        dec: Angle.Degrees(-37.37460792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138924"},
        {"Hipparcos Number", "HIP 76419"},
        {"Geneva Identification System", "GEN# +1.00138924"},
        {"Smithsonian Astrophysical Observation", "SAO 206797"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.11518070),
        dec: Angle.Degrees(-37.37308916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43622",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43622"},
        {"Smithsonian Astrophysical Observation", "SAO 199745"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.27119216),
        dec: Angle.Degrees(-37.37230752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21938"},
        {"Hipparcos Number", "HIP 16365"},
        {"Geneva Identification System", "GEN# +1.00021938"},
        {"Smithsonian Astrophysical Observation", "SAO 194347"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.71036276),
        dec: Angle.Degrees(-37.37223860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
