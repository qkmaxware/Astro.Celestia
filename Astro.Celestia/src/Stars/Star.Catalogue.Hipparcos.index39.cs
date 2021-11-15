using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_39() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89075"},
        {"Hipparcos Number", "HIP 50284"},
        {"Geneva Identification System", "GEN# +1.00089075"},
        {"Renson", "Renson 25510"},
        {"Smithsonian Astrophysical Observation", "SAO 178596"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.00432507),
        dec: Angle.Degrees(-26.59459436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10797"},
        {"Hipparcos Number", "HIP 8167"},
        {"Smithsonian Astrophysical Observation", "SAO 167266"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.25675255),
        dec: Angle.Degrees(-26.59440425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82161"},
        {"Hipparcos Number", "HIP 46558"},
        {"Geneva Identification System", "GEN# +1.00082161"},
        {"Smithsonian Astrophysical Observation", "SAO 177539"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.41873760),
        dec: Angle.Degrees(-26.59416033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170141B"},
        {"Hipparcos Number", "HIP 90575"},
        {"Smithsonian Astrophysical Observation", "SAO 186862"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.23853478),
        dec: Angle.Degrees(-26.59370050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65944"},
        {"Hipparcos Number", "HIP 39132"},
        {"Geneva Identification System", "GEN# +1.00065944"},
        {"Smithsonian Astrophysical Observation", "SAO 174961"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.07665330),
        dec: Angle.Degrees(-26.59166107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61874"},
        {"Hipparcos Number", "HIP 37371"},
        {"Geneva Identification System", "GEN# +1.00061874"},
        {"Renson", "Renson 16990"},
        {"Smithsonian Astrophysical Observation", "SAO 174254"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.07653346),
        dec: Angle.Degrees(-26.59039224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63702"},
        {"Hipparcos Number", "HIP 38171"},
        {"Geneva Identification System", "GEN# +1.00063702"},
        {"Smithsonian Astrophysical Observation", "SAO 174604"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.32892497),
        dec: Angle.Degrees(-26.58988347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46578",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7405 A"},
        {"Henry Draper", "HD 82205"},
        {"Hipparcos Number", "HIP 46578"},
        {"Geneva Identification System", "GEN# +1.00082205J"},
        {"Smithsonian Astrophysical Observation", "SAO 177546"},
        {"Wilson Evans Batten Catalogue", "WEB 8788"},
    },
    visualMagnitude: 5.49,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.47716139),
        dec: Angle.Degrees(-26.58961727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86858",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10745 A"},
        {"Henry Draper", "HD 161117"},
        {"Henry Draper 2", "HD 161117A"},
        {"Hipparcos Number", "HIP 86858"},
        {"Smithsonian Astrophysical Observation", "SAO 185684"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.20292462),
        dec: Angle.Degrees(-26.58883595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117781"},
        {"Hipparcos Number", "HIP 66094"},
        {"Smithsonian Astrophysical Observation", "SAO 181742"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.22470045),
        dec: Angle.Degrees(-26.58763851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112375"},
        {"Hipparcos Number", "HIP 63162"},
        {"Geneva Identification System", "GEN# +1.00112375"},
        {"Smithsonian Astrophysical Observation", "SAO 181245"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.12980175),
        dec: Angle.Degrees(-26.58634360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57146"},
        {"Hipparcos Number", "HIP 35427"},
        {"Celescope Catalog", "CEL 1769"},
        {"Geneva Identification System", "GEN# +1.00057146"},
        {"Smithsonian Astrophysical Observation", "SAO 173453"},
        {"Wilson Evans Batten Catalogue", "WEB 7070"},
    },
    visualMagnitude: 5.29,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.71366298),
        dec: Angle.Degrees(-26.58587077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35994"},
        {"Hipparcos Number", "HIP 25517"},
        {"Smithsonian Astrophysical Observation", "SAO 170440"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.85333999),
        dec: Angle.Degrees(-26.58491251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43658"},
        {"Hipparcos Number", "HIP 29784"},
        {"Smithsonian Astrophysical Observation", "SAO 171486"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.06486462),
        dec: Angle.Degrees(-26.58265451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170141"},
        {"Hipparcos Number", "HIP 90576"},
        {"Geneva Identification System", "GEN# +1.00170141A"},
        {"Smithsonian Astrophysical Observation", "SAO 186863"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.23899145),
        dec: Angle.Degrees(-26.58205851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32952",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5539 AB"},
        {"Henry Draper", "HD 50379"},
        {"Hipparcos Number", "HIP 32952"},
        {"Smithsonian Astrophysical Observation", "SAO 172461"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.95575680),
        dec: Angle.Degrees(-26.58178361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129274"},
        {"Hipparcos Number", "HIP 71902"},
        {"Smithsonian Astrophysical Observation", "SAO 182781"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.60524178),
        dec: Angle.Degrees(-26.58078648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154365"},
        {"Hipparcos Number", "HIP 83674"},
        {"Geneva Identification System", "GEN# +1.00154365"},
        {"Smithsonian Astrophysical Observation", "SAO 185020"},
        {"Wilson Evans Batten Catalogue", "WEB 14147"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.52290748),
        dec: Angle.Degrees(-26.58056284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68891",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9106 AB"},
        {"Henry Draper", "HD 123107"},
        {"Hipparcos Number", "HIP 68891"},
        {"Smithsonian Astrophysical Observation", "SAO 182242"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.57921493),
        dec: Angle.Degrees(-26.57924494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94295"},
        {"Hipparcos Number", "HIP 53181"},
        {"Smithsonian Astrophysical Observation", "SAO 179297"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.17640705),
        dec: Angle.Degrees(-26.57894683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128259"},
        {"Hipparcos Number", "HIP 71443"},
        {"Smithsonian Astrophysical Observation", "SAO 182698"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.16502852),
        dec: Angle.Degrees(-26.57890926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3363"},
        {"Hipparcos Number", "HIP 2874"},
        {"Smithsonian Astrophysical Observation", "SAO 166404"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.10721331),
        dec: Angle.Degrees(-26.57541070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167664"},
        {"Hipparcos Number", "HIP 89614"},
        {"Smithsonian Astrophysical Observation", "SAO 186590"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.31280783),
        dec: Angle.Degrees(-26.57525347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137130"},
        {"Hipparcos Number", "HIP 75480"},
        {"Smithsonian Astrophysical Observation", "SAO 183449"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.28919868),
        dec: Angle.Degrees(-26.57519845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31821",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5310 AB"},
        {"Henry Draper", "HD 47787"},
        {"Hipparcos Number", "HIP 31821"},
        {"Smithsonian Astrophysical Observation", "SAO 172095"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.79856276),
        dec: Angle.Degrees(-26.57194157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8749"},
        {"Geneva Identification System", "GEN# -0.02700646"},
        {"Smithsonian Astrophysical Observation", "SAO 167370"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.14657027),
        dec: Angle.Degrees(-26.57124639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171498"},
        {"Hipparcos Number", "HIP 91188"},
        {"Smithsonian Astrophysical Observation", "SAO 187029"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.03880417),
        dec: Angle.Degrees(-26.56963589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147955"},
        {"Hipparcos Number", "HIP 80493"},
        {"Geneva Identification System", "GEN# +1.00147955"},
        {"Smithsonian Astrophysical Observation", "SAO 184386"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.46111331),
        dec: Angle.Degrees(-26.56838118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34997"},
        {"Hipparcos Number", "HIP 24915"},
        {"Smithsonian Astrophysical Observation", "SAO 170328"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.09573070),
        dec: Angle.Degrees(-26.56808615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52945"},
        {"Hipparcos Number", "HIP 33888"},
        {"Smithsonian Astrophysical Observation", "SAO 172807"},
    },
    visualMagnitude: 9.18,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.51459830),
        dec: Angle.Degrees(-26.56788073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106648"},
        {"Hipparcos Number", "HIP 59818"},
        {"Smithsonian Astrophysical Observation", "SAO 180627"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.00002175),
        dec: Angle.Degrees(-26.56448017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77462"},
        {"Hipparcos Number", "HIP 44343"},
        {"Geneva Identification System", "GEN# +1.00077462"},
        {"Smithsonian Astrophysical Observation", "SAO 176847"},
        {"Wilson Evans Batten Catalogue", "WEB 8503"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.45483398),
        dec: Angle.Degrees(-26.56421132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -259.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 287.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194310"},
        {"Hipparcos Number", "HIP 100765"},
        {"Smithsonian Astrophysical Observation", "SAO 189273"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.45257191),
        dec: Angle.Degrees(-26.55645249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103657"},
        {"Smithsonian Astrophysical Observation", "SAO 189913"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.02715758),
        dec: Angle.Degrees(-26.55615212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24250",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3787 A"},
        {"Henry Draper", "HD 33889"},
        {"Hipparcos Number", "HIP 24250"},
        {"Geneva Identification System", "GEN# +1.00033889"},
        {"Smithsonian Astrophysical Observation", "SAO 170185"},
        {"Wilson Evans Batten Catalogue", "WEB 4709"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.08895284),
        dec: Angle.Degrees(-26.55251996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7161",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1212 A"},
        {"Henry Draper", "HD 9451"},
        {"Hipparcos Number", "HIP 7161"},
        {"Geneva Identification System", "GEN# +1.00009451A"},
        {"Renson", "Renson 2276"},
        {"Smithsonian Astrophysical Observation", "SAO 167119"},
        {"Wilson Evans Batten Catalogue", "WEB 1547"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.07995604),
        dec: Angle.Degrees(-26.55235075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114576"},
        {"Hipparcos Number", "HIP 64375"},
        {"Fundamental Katalog 5th Edition", "FK5 1341"},
        {"Geneva Identification System", "GEN# +1.00114576J"},
        {"Smithsonian Astrophysical Observation", "SAO 181446"},
        {"Wilson Evans Batten Catalogue", "WEB 11378"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.91351870),
        dec: Angle.Degrees(-26.55172563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7163",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1212 B"},
        {"Henry Draper", "HD 9451B"},
        {"Hipparcos Number", "HIP 7163"},
        {"Geneva Identification System", "GEN# +1.00009451B"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.08526383),
        dec: Angle.Degrees(-26.55084407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188377"},
        {"Hipparcos Number", "HIP 98069"},
        {"Geneva Identification System", "GEN# +1.00188377"},
        {"Smithsonian Astrophysical Observation", "SAO 188724"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.96737192),
        dec: Angle.Degrees(-26.55016241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6895"},
        {"Smithsonian Astrophysical Observation", "SAO 167079"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.19667414),
        dec: Angle.Degrees(-26.54988934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156780"},
        {"Hipparcos Number", "HIP 84851"},
        {"Smithsonian Astrophysical Observation", "SAO 185282"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.12800805),
        dec: Angle.Degrees(-26.54976149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48763",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7591 AB"},
        {"Henry Draper", "HD 86266"},
        {"Hipparcos Number", "HIP 48763"},
        {"Geneva Identification System", "GEN# +1.00086266J"},
        {"Smithsonian Astrophysical Observation", "SAO 178214"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.19538618),
        dec: Angle.Degrees(-26.54974395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63635"},
        {"Hipparcos Number", "HIP 38142"},
        {"Geneva Identification System", "GEN# +1.00063635"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.24982184),
        dec: Angle.Degrees(-26.54538191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24764"},
        {"Hipparcos Number", "HIP 18348"},
        {"Smithsonian Astrophysical Observation", "SAO 168955"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.84010354),
        dec: Angle.Degrees(-26.54462369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156026"},
        {"Hipparcos Number", "HIP 84478"},
        {"Cincinnati Publication", "Ci 20 1027"},
        {"Geneva Identification System", "GEN# +1.00156026"},
        {"Smithsonian Astrophysical Observation", "SAO 185213"},
        {"Wilson Evans Batten Catalogue", "WEB 14259"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.05698088),
        dec: Angle.Degrees(-26.54341625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -479.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1123.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97113"},
    },
    visualMagnitude: 11.23,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.04202634),
        dec: Angle.Degrees(-26.54314595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215902"},
        {"Hipparcos Number", "HIP 112643"},
        {"Geneva Identification System", "GEN# +1.00215902"},
        {"Smithsonian Astrophysical Observation", "SAO 191420"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.21581402),
        dec: Angle.Degrees(-26.54243176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219095"},
        {"Hipparcos Number", "HIP 114651"},
        {"Smithsonian Astrophysical Observation", "SAO 191735"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.38064307),
        dec: Angle.Degrees(-26.54053903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48645",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7580 ABC"},
        {"Henry Draper", "HD 85994"},
        {"Hipparcos Number", "HIP 48645"},
        {"Geneva Identification System", "GEN# +1.00085994J"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)55, 06.5900),
        dec: Angle.DegreesMinutesSeconds((int)-26, (int)32, 18.600)
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
    primaryId: "HIP 106012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204301"},
        {"Hipparcos Number", "HIP 106012"},
        {"Smithsonian Astrophysical Observation", "SAO 190363"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.08059547),
        dec: Angle.Degrees(-26.53767484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148760"},
        {"Hipparcos Number", "HIP 80910"},
        {"Geneva Identification System", "GEN# +1.00148760"},
        {"Smithsonian Astrophysical Observation", "SAO 184437"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.84528782),
        dec: Angle.Degrees(-26.53755183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103710"},
        {"Hipparcos Number", "HIP 58227"},
        {"Smithsonian Astrophysical Observation", "SAO 180318"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.13543021),
        dec: Angle.Degrees(-26.53715174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50330"},
        {"Hipparcos Number", "HIP 32929"},
        {"Smithsonian Astrophysical Observation", "SAO 172454"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.90594357),
        dec: Angle.Degrees(-26.53515769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32591",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5470 AB"},
        {"Henry Draper", "HD 49575"},
        {"Hipparcos Number", "HIP 32591"},
        {"Smithsonian Astrophysical Observation", "SAO 172346"},
    },
    visualMagnitude: 8.56,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.99423671),
        dec: Angle.Degrees(-26.53496766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141092"},
        {"Hipparcos Number", "HIP 77405"},
        {"Smithsonian Astrophysical Observation", "SAO 183804"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.03274781),
        dec: Angle.Degrees(-26.53485951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47207"},
        {"Hipparcos Number", "HIP 31557"},
        {"Smithsonian Astrophysical Observation", "SAO 172016"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.08078267),
        dec: Angle.Degrees(-26.53478180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119062"},
        {"Hipparcos Number", "HIP 66796"},
        {"Smithsonian Astrophysical Observation", "SAO 181860"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.36338800),
        dec: Angle.Degrees(-26.53130587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155849"},
        {"Hipparcos Number", "HIP 84391"},
        {"Smithsonian Astrophysical Observation", "SAO 185195"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.80513979),
        dec: Angle.Degrees(-26.53062365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27264",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27264"},
        {"Smithsonian Astrophysical Observation", "SAO 170828"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.68897540),
        dec: Angle.Degrees(-26.52949759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141555"},
        {"Hipparcos Number", "HIP 77611"},
        {"Geneva Identification System", "GEN# +1.00141555"},
        {"Smithsonian Astrophysical Observation", "SAO 183849"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.66690070),
        dec: Angle.Degrees(-26.52946380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109715",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109715"},
    },
    visualMagnitude: 12.14,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.35325576),
        dec: Angle.Degrees(-26.52945589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5768"},
        {"Hipparcos Number", "HIP 4604"},
        {"Geneva Identification System", "GEN# +1.00005768"},
        {"Smithsonian Astrophysical Observation", "SAO 166718"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.75541778),
        dec: Angle.Degrees(-26.52762273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118283",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17150 B"},
        {"Hipparcos Number", "HIP 118283"},
        {"Smithsonian Astrophysical Observation", "SAO 192296"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.87692922),
        dec: Angle.Degrees(-26.52663268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7169"},
        {"Smithsonian Astrophysical Observation", "SAO 167122"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.10944751),
        dec: Angle.Degrees(-26.52616545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100474"},
        {"Hipparcos Number", "HIP 56390"},
        {"Smithsonian Astrophysical Observation", "SAO 179987"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.40359303),
        dec: Angle.Degrees(-26.52614725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197920"},
        {"Hipparcos Number", "HIP 102603"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.89430522),
        dec: Angle.Degrees(-26.52575328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209030"},
        {"Hipparcos Number", "HIP 108666"},
        {"Smithsonian Astrophysical Observation", "SAO 190823"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.21928914),
        dec: Angle.Degrees(-26.52548235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28114",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4540 AB"},
        {"Henry Draper", "HD 40247"},
        {"Hipparcos Number", "HIP 28114"},
        {"Smithsonian Astrophysical Observation", "SAO 171046"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.13714569),
        dec: Angle.Degrees(-26.52393361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118284",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17150 A"},
        {"Henry Draper", "HD 224641"},
        {"Hipparcos Number", "HIP 118284"},
        {"Smithsonian Astrophysical Observation", "SAO 192295"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.87634724),
        dec: Angle.Degrees(-26.52373854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14021"},
        {"Hipparcos Number", "HIP 10525"},
        {"Geneva Identification System", "GEN# +1.00014021"},
        {"Smithsonian Astrophysical Observation", "SAO 167665"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.90790706),
        dec: Angle.Degrees(-26.52367597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109932"},
        {"Hipparcos Number", "HIP 61699"},
        {"Geneva Identification System", "GEN# +1.00109932"},
        {"Smithsonian Astrophysical Observation", "SAO 180979"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.70722600),
        dec: Angle.Degrees(-26.51884013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220880"},
        {"Hipparcos Number", "HIP 115797"},
        {"Smithsonian Astrophysical Observation", "SAO 191921"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.89078794),
        dec: Angle.Degrees(-26.51871749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25401"},
        {"Hipparcos Number", "HIP 18776"},
        {"Geneva Identification System", "GEN# +1.00025401"},
        {"Smithsonian Astrophysical Observation", "SAO 169040"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.33715229),
        dec: Angle.Degrees(-26.51682320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3479",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Cocibolca"},
        {"Henry Draper", "HD 4208"},
        {"Hipparcos Number", "HIP 3479"},
        {"Cincinnati Publication", "Ci 18 97"},
        {"Geneva Identification System", "GEN# +1.00004208"},
        {"Smithsonian Astrophysical Observation", "SAO 166526"},
        {"Wilson Evans Batten Catalogue", "WEB 615"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.11019153),
        dec: Angle.Degrees(-26.51604473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 313.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 150.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114884"},
        {"Hipparcos Number", "HIP 64544"},
        {"Geneva Identification System", "GEN# +1.00114884"},
        {"Smithsonian Astrophysical Observation", "SAO 181469"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.43846470),
        dec: Angle.Degrees(-26.51582255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76224"},
        {"Hipparcos Number", "HIP 43691"},
        {"Geneva Identification System", "GEN# +1.00076224"},
        {"Smithsonian Astrophysical Observation", "SAO 176661"},
        {"Wilson Evans Batten Catalogue", "WEB 8413"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.49123202),
        dec: Angle.Degrees(-26.51572091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66961"},
        {"Hipparcos Number", "HIP 39551"},
        {"Smithsonian Astrophysical Observation", "SAO 175129"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.23129723),
        dec: Angle.Degrees(-26.51566430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60030"},
        {"Hipparcos Number", "HIP 36598"},
        {"Smithsonian Astrophysical Observation", "SAO 173925"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.90825042),
        dec: Angle.Degrees(-26.51503110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52545"},
        {"Smithsonian Astrophysical Observation", "SAO 179185"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.15823899),
        dec: Angle.Degrees(-26.51454141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68047"},
        {"Hipparcos Number", "HIP 39976"},
        {"Smithsonian Astrophysical Observation", "SAO 175296"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.45798459),
        dec: Angle.Degrees(-26.51407585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154481"},
        {"Hipparcos Number", "HIP 83740"},
        {"Fundamental Katalog 5th Edition", "FK5 1447"},
        {"Geneva Identification System", "GEN# +1.00154481"},
        {"Smithsonian Astrophysical Observation", "SAO 185033"},
        {"Wilson Evans Batten Catalogue", "WEB 14159"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.72177870),
        dec: Angle.Degrees(-26.51299082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31078"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.82272553),
        dec: Angle.Degrees(-26.51249036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 285.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17041"},
        {"Hipparcos Number", "HIP 12713"},
        {"Smithsonian Astrophysical Observation", "SAO 168000"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.84590688),
        dec: Angle.Degrees(-26.51202551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39367"},
        {"Hipparcos Number", "HIP 27637"},
        {"Smithsonian Astrophysical Observation", "SAO 170920"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.75932720),
        dec: Angle.Degrees(-26.51161606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12168"},
        {"Hipparcos Number", "HIP 9252"},
        {"Geneva Identification System", "GEN# +1.00012168"},
        {"Smithsonian Astrophysical Observation", "SAO 167449"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.73199426),
        dec: Angle.Degrees(-26.50946021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35926",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35926"},
        {"Smithsonian Astrophysical Observation", "SAO 173660"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.08642578),
        dec: Angle.Degrees(-26.50771480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149168"},
        {"Hipparcos Number", "HIP 81118"},
        {"Geneva Identification System", "GEN# +1.00149168"},
        {"Smithsonian Astrophysical Observation", "SAO 184463"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.51404041),
        dec: Angle.Degrees(-26.50513596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52929"},
        {"Hipparcos Number", "HIP 33883"},
        {"Smithsonian Astrophysical Observation", "SAO 172805"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.49497492),
        dec: Angle.Degrees(-26.50381357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6136",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1066 AB"},
        {"Henry Draper", "HD 7969"},
        {"Hipparcos Number", "HIP 6136"},
        {"Geneva Identification System", "GEN# +1.00007969"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.68393503),
        dec: Angle.Degrees(-26.50239036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 229.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 201.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210523"},
        {"Hipparcos Number", "HIP 109553"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.87075261),
        dec: Angle.Degrees(-26.50214701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216053"},
        {"Hipparcos Number", "HIP 112739"},
        {"Smithsonian Astrophysical Observation", "SAO 191433"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.48098417),
        dec: Angle.Degrees(-26.50176613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156955"},
        {"Hipparcos Number", "HIP 84931"},
        {"Smithsonian Astrophysical Observation", "SAO 185305"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.35826626),
        dec: Angle.Degrees(-26.50119472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20387"},
        {"Hipparcos Number", "HIP 15196"},
        {"Smithsonian Astrophysical Observation", "SAO 168422"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.95840698),
        dec: Angle.Degrees(-26.50050727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45942"},
        {"Hipparcos Number", "HIP 30913"},
        {"Smithsonian Astrophysical Observation", "SAO 171829"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.32650634),
        dec: Angle.Degrees(-26.50048830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89391"},
        {"Hipparcos Number", "HIP 50478"},
        {"Geneva Identification System", "GEN# +1.00089391"},
        {"Smithsonian Astrophysical Observation", "SAO 178654"},
        {"Wilson Evans Batten Catalogue", "WEB 9261"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.60451287),
        dec: Angle.Degrees(-26.50024123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201148"},
        {"Hipparcos Number", "HIP 104358"},
        {"Smithsonian Astrophysical Observation", "SAO 190046"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.11789725),
        dec: Angle.Degrees(-26.49986465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134140"},
        {"Hipparcos Number", "HIP 74131"},
        {"Geneva Identification System", "GEN# +1.00134140"},
        {"Smithsonian Astrophysical Observation", "SAO 183211"},
        {"Wilson Evans Batten Catalogue", "WEB 12664"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.23965076),
        dec: Angle.Degrees(-26.49727367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72971"},
        {"Hipparcos Number", "HIP 42097"},
        {"Smithsonian Astrophysical Observation", "SAO 176116"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.71390539),
        dec: Angle.Degrees(-26.49628483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170768"},
        {"Hipparcos Number", "HIP 90869"},
        {"Geneva Identification System", "GEN# +1.00170768"},
        {"Smithsonian Astrophysical Observation", "SAO 186934"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.05222376),
        dec: Angle.Degrees(-26.49619886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11828"},
        {"Hipparcos Number", "HIP 8974"},
        {"Geneva Identification System", "GEN# +1.00011828"},
        {"Smithsonian Astrophysical Observation", "SAO 167400"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.92258759),
        dec: Angle.Degrees(-26.49577690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66400",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8966 A"},
        {"Henry Draper", "HD 118349A"},
        {"Hipparcos Number", "HIP 66400"},
        {"Geneva Identification System", "GEN# +1.00118349A"},
        {"Smithsonian Astrophysical Observation", "SAO 181790"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.20212206),
        dec: Angle.Degrees(-26.49523551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139094"},
        {"Hipparcos Number", "HIP 76473"},
        {"Geneva Identification System", "GEN# +1.00139094"},
        {"Renson", "Renson 39590"},
        {"Smithsonian Astrophysical Observation", "SAO 183622"},
        {"Wilson Evans Batten Catalogue", "WEB 12982"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.27871576),
        dec: Angle.Degrees(-26.49237401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63005"},
        {"Hipparcos Number", "HIP 37875"},
        {"Geneva Identification System", "GEN# +1.00063005"},
        {"Renson", "Renson 17340"},
        {"Smithsonian Astrophysical Observation", "SAO 174476"},
    },
    visualMagnitude: 9.13,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.45431143),
        dec: Angle.Degrees(-26.49207450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206768"},
        {"Hipparcos Number", "HIP 107384"},
        {"Smithsonian Astrophysical Observation", "SAO 190596"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.25208038),
        dec: Angle.Degrees(-26.49077439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186694"},
        {"Hipparcos Number", "HIP 97340"},
        {"Smithsonian Astrophysical Observation", "SAO 188559"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.75158713),
        dec: Angle.Degrees(-26.49046767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30203",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30203"},
        {"Smithsonian Astrophysical Observation", "SAO 171616"},
    },
    visualMagnitude: 8.24,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.31148262),
        dec: Angle.Degrees(-26.48999119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33012"},
        {"Hipparcos Number", "HIP 23738"},
        {"Smithsonian Astrophysical Observation", "SAO 170065"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.53990659),
        dec: Angle.Degrees(-26.48838834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27667"},
        {"Hipparcos Number", "HIP 20293"},
        {"Smithsonian Astrophysical Observation", "SAO 169358"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.23540687),
        dec: Angle.Degrees(-26.48775053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59364"},
        {"Hipparcos Number", "HIP 36323"},
        {"Celescope Catalog", "CEL 1876"},
        {"Geneva Identification System", "GEN# +1.00059364"},
        {"Smithsonian Astrophysical Observation", "SAO 173826"},
    },
    visualMagnitude: 9.08,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.15222704),
        dec: Angle.Degrees(-26.48508480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202609"},
        {"Hipparcos Number", "HIP 105121"},
        {"Smithsonian Astrophysical Observation", "SAO 190204"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.41059887),
        dec: Angle.Degrees(-26.48478666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222677"},
        {"Hipparcos Number", "HIP 116977"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.70196958),
        dec: Angle.Degrees(-26.48435696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91135"},
        {"Hipparcos Number", "HIP 51475"},
        {"Geneva Identification System", "GEN# +1.00091135"},
        {"Smithsonian Astrophysical Observation", "SAO 178917"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.71429936),
        dec: Angle.Degrees(-26.48380237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110591"},
        {"Hipparcos Number", "HIP 62083"},
        {"Geneva Identification System", "GEN# +1.00110591"},
        {"Smithsonian Astrophysical Observation", "SAO 181050"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.86631883),
        dec: Angle.Degrees(-26.48319763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201574"},
        {"Hipparcos Number", "HIP 104586"},
        {"Smithsonian Astrophysical Observation", "SAO 190095"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.79536839),
        dec: Angle.Degrees(-26.48251933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42729"},
        {"Hipparcos Number", "HIP 29347"},
        {"Geneva Identification System", "GEN# +1.00042729"},
        {"Smithsonian Astrophysical Observation", "SAO 171356"},
    },
    visualMagnitude: 6.08,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.80690013),
        dec: Angle.Degrees(-26.48211370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113480"},
        {"Hipparcos Number", "HIP 63787"},
        {"Smithsonian Astrophysical Observation", "SAO 181366"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.10796539),
        dec: Angle.Degrees(-26.48150568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25677"},
        {"Hipparcos Number", "HIP 18934"},
        {"Smithsonian Astrophysical Observation", "SAO 169079"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.87982387),
        dec: Angle.Degrees(-26.48128877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197082"},
        {"Hipparcos Number", "HIP 102169"},
        {"Smithsonian Astrophysical Observation", "SAO 189590"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.53437921),
        dec: Angle.Degrees(-26.48046519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104358"},
        {"Hipparcos Number", "HIP 58601"},
        {"Smithsonian Astrophysical Observation", "SAO 180380"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.25302003),
        dec: Angle.Degrees(-26.47977387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145481"},
        {"Hipparcos Number", "HIP 79397"},
        {"Smithsonian Astrophysical Observation", "SAO 184220"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.06068501),
        dec: Angle.Degrees(-26.47938426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208483"},
        {"Hipparcos Number", "HIP 108346"},
        {"Geneva Identification System", "GEN# +1.00208483"},
        {"Smithsonian Astrophysical Observation", "SAO 190765"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.25913626),
        dec: Angle.Degrees(-26.47928474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81211",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10119 AB"},
        {"Henry Draper", "HD 149367"},
        {"Hipparcos Number", "HIP 81211"},
        {"Geneva Identification System", "GEN# +1.00149367"},
        {"Smithsonian Astrophysical Observation", "SAO 184475"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.81338851),
        dec: Angle.Degrees(-26.47834317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222880"},
        {"Hipparcos Number", "HIP 117116"},
        {"Smithsonian Astrophysical Observation", "SAO 192117"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.14205284),
        dec: Angle.Degrees(-26.47615185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52138"},
        {"Hipparcos Number", "HIP 33611"},
        {"Celescope Catalog", "CEL 1477"},
        {"Geneva Identification System", "GEN# +1.00052138J"},
        {"Smithsonian Astrophysical Observation", "SAO 172685"},
    },
    visualMagnitude: 7.17,
    bvColour: -0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.75247819),
        dec: Angle.Degrees(-26.47443587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61686"},
        {"Hipparcos Number", "HIP 37309"},
        {"Geneva Identification System", "GEN# +1.00061686"},
        {"Smithsonian Astrophysical Observation", "SAO 174225"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.89716308),
        dec: Angle.Degrees(-26.47432757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107796"},
        {"Hipparcos Number", "HIP 60426"},
        {"Renson", "Renson 31256"},
        {"Smithsonian Astrophysical Observation", "SAO 180748"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.84146766),
        dec: Angle.Degrees(-26.47150074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48647"},
        {"Hipparcos Number", "HIP 32205"},
        {"Geneva Identification System", "GEN# +1.00048647"},
        {"Smithsonian Astrophysical Observation", "SAO 172230"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.83223553),
        dec: Angle.Degrees(-26.47057265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101987"},
        {"Hipparcos Number", "HIP 57235"},
        {"Smithsonian Astrophysical Observation", "SAO 180145"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.03195078),
        dec: Angle.Degrees(-26.46693778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3125"},
        {"Geneva Identification System", "GEN# -0.02700194"},
    },
    visualMagnitude: 10.22,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.93497867),
        dec: Angle.Degrees(-26.46595942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 244.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97528"},
        {"Hipparcos Number", "HIP 54807"},
        {"Geneva Identification System", "GEN# +1.00097528"},
        {"Smithsonian Astrophysical Observation", "SAO 179648"},
        {"Wilson Evans Batten Catalogue", "WEB 9890"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.30212525),
        dec: Angle.Degrees(-26.46509597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87009"},
        {"Hipparcos Number", "HIP 49142"},
        {"Smithsonian Astrophysical Observation", "SAO 178317"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.43631798),
        dec: Angle.Degrees(-26.46422028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111799"},
        {"Hipparcos Number", "HIP 62800"},
        {"Geneva Identification System", "GEN# +1.00111799"},
        {"Smithsonian Astrophysical Observation", "SAO 181173"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.03122101),
        dec: Angle.Degrees(-26.46114489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39196",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39196"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.25558351),
        dec: Angle.Degrees(-26.46035240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112374"},
        {"Hipparcos Number", "HIP 63159"},
        {"Geneva Identification System", "GEN# +1.00112374"},
        {"Smithsonian Astrophysical Observation", "SAO 181244"},
        {"Wilson Evans Batten Catalogue", "WEB 11197"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.12551047),
        dec: Angle.Degrees(-26.46023919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150589"},
        {"Hipparcos Number", "HIP 81851"},
        {"Geneva Identification System", "GEN# +1.00150589"},
        {"Smithsonian Astrophysical Observation", "SAO 184569"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.77247068),
        dec: Angle.Degrees(-26.45850117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109143"},
        {"Hipparcos Number", "HIP 61213"},
        {"Smithsonian Astrophysical Observation", "SAO 180880"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.15476300),
        dec: Angle.Degrees(-26.45800740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -191.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8716"},
        {"Hipparcos Number", "HIP 6664"},
        {"Geneva Identification System", "GEN# +1.00008716"},
        {"Smithsonian Astrophysical Observation", "SAO 167040"},
        {"Wilson Evans Batten Catalogue", "WEB 1454"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.37885022),
        dec: Angle.Degrees(-26.45768823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220928"},
        {"Hipparcos Number", "HIP 115828"},
        {"Geneva Identification System", "GEN# +1.00220928"},
        {"Smithsonian Astrophysical Observation", "SAO 191928"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.98733812),
        dec: Angle.Degrees(-26.45432196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150147"},
        {"Hipparcos Number", "HIP 81617"},
        {"Geneva Identification System", "GEN# +1.00150147"},
        {"Smithsonian Astrophysical Observation", "SAO 184533"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.04938837),
        dec: Angle.Degrees(-26.45383906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219882"},
        {"Hipparcos Number", "HIP 115154"},
        {"Smithsonian Astrophysical Observation", "SAO 191820"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.87937438),
        dec: Angle.Degrees(-26.45275423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181084"},
        {"Hipparcos Number", "HIP 95027"},
        {"Smithsonian Astrophysical Observation", "SAO 187981"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.02988343),
        dec: Angle.Degrees(-26.45001457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64592"},
        {"Hipparcos Number", "HIP 38554"},
        {"Geneva Identification System", "GEN# +2.24670078"},
        {"Smithsonian Astrophysical Observation", "SAO 174750"},
        {"New General Catalogue", "NGC 2467 78"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.41797839),
        dec: Angle.Degrees(-26.44755638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169118"},
        {"Hipparcos Number", "HIP 90184"},
        {"Geneva Identification System", "GEN# +1.00169118"},
        {"Smithsonian Astrophysical Observation", "SAO 186770"},
        {"Wilson Evans Batten Catalogue", "WEB 15422"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.04187326),
        dec: Angle.Degrees(-26.44730302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20280"},
        {"Hipparcos Number", "HIP 15095"},
        {"Geneva Identification System", "GEN# +1.00020280"},
        {"Smithsonian Astrophysical Observation", "SAO 168403"},
        {"Wilson Evans Batten Catalogue", "WEB 2909"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.68534577),
        dec: Angle.Degrees(-26.44648673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 216.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19613"},
        {"Hipparcos Number", "HIP 14605"},
        {"Smithsonian Astrophysical Observation", "SAO 168329"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.15629392),
        dec: Angle.Degrees(-26.44636843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45074"},
        {"Hipparcos Number", "HIP 30461"},
        {"Geneva Identification System", "GEN# +1.00045074"},
        {"Smithsonian Astrophysical Observation", "SAO 171693"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.05445584),
        dec: Angle.Degrees(-26.44502472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185883"},
        {"Hipparcos Number", "HIP 96940"},
        {"Fundamental Katalog 5th Edition", "FK5 5737"},
        {"Smithsonian Astrophysical Observation", "SAO 188469"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.59799920),
        dec: Angle.Degrees(-26.44380760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7336"},
        {"Hipparcos Number", "HIP 5690"},
        {"Smithsonian Astrophysical Observation", "SAO 166880"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.29425317),
        dec: Angle.Degrees(-26.44253686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1251"},
        {"Smithsonian Astrophysical Observation", "SAO 166152"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.92174703),
        dec: Angle.Degrees(-26.44222152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34344"},
        {"Hipparcos Number", "HIP 24521"},
        {"Smithsonian Astrophysical Observation", "SAO 170244"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.91396059),
        dec: Angle.Degrees(-26.44184692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70656"},
        {"Hipparcos Number", "HIP 41005"},
        {"Smithsonian Astrophysical Observation", "SAO 175686"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.53370354),
        dec: Angle.Degrees(-26.44105313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14389"},
        {"Hipparcos Number", "HIP 10782"},
        {"Smithsonian Astrophysical Observation", "SAO 167696"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.70314823),
        dec: Angle.Degrees(-26.44023454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145031"},
        {"Hipparcos Number", "HIP 79192"},
        {"Geneva Identification System", "GEN# +1.00145031"},
        {"Smithsonian Astrophysical Observation", "SAO 184177"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.44076294),
        dec: Angle.Degrees(-26.43995401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84114"},
        {"Smithsonian Astrophysical Observation", "SAO 185129"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.94799404),
        dec: Angle.Degrees(-26.43932309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26769"},
        {"Hipparcos Number", "HIP 19687"},
        {"Geneva Identification System", "GEN# +1.00026769"},
        {"Smithsonian Astrophysical Observation", "SAO 169232"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.25999666),
        dec: Angle.Degrees(-26.43512163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156917"},
        {"Hipparcos Number", "HIP 84930"},
        {"Geneva Identification System", "GEN# +1.00156917"},
        {"Smithsonian Astrophysical Observation", "SAO 185304"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.35282487),
        dec: Angle.Degrees(-26.43491572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190618"},
        {"Hipparcos Number", "HIP 99070"},
        {"Smithsonian Astrophysical Observation", "SAO 188920"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.69455745),
        dec: Angle.Degrees(-26.43483649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149310"},
        {"Hipparcos Number", "HIP 81190"},
        {"Geneva Identification System", "GEN# +1.00149310"},
        {"Smithsonian Astrophysical Observation", "SAO 184472"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.75773083),
        dec: Angle.Degrees(-26.43409233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121331"},
        {"Hipparcos Number", "HIP 67984"},
        {"Smithsonian Astrophysical Observation", "SAO 182081"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.83058548),
        dec: Angle.Degrees(-26.43244843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12206"},
        {"Hipparcos Number", "HIP 9285"},
        {"Geneva Identification System", "GEN# +1.00012206"},
        {"Smithsonian Astrophysical Observation", "SAO 167461"},
        {"Wilson Evans Batten Catalogue", "WEB 1950"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.83140342),
        dec: Angle.Degrees(-26.43226448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31341B"},
        {"Hipparcos Number", "HIP 22766"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.46121193),
        dec: Angle.Degrees(-26.43223332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80763",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Antares"},
        {"Aitken", "ADS 10074 A"},
        {"Henry Draper", "HD 148478"},
        {"Hipparcos Number", "HIP 80763"},
        {"Fundamental Katalog 5th Edition", "FK5 616"},
        {"Geneva Identification System", "GEN# +1.00148478"},
        {"Geneva Identification System 2", "GEN# +1.00148479"},
        {"Smithsonian Astrophysical Observation", "SAO 184415"},
        {"Wilson Evans Batten Catalogue", "WEB 13658"},
    },
    visualMagnitude: 1.06,
    bvColour: 1.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.35194804),
        dec: Angle.Degrees(-26.43194608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15426"},
        {"Hipparcos Number", "HIP 11495"},
        {"Smithsonian Astrophysical Observation", "SAO 167808"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.06522999),
        dec: Angle.Degrees(-26.43034622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22424"},
        {"Hipparcos Number", "HIP 16752"},
        {"Geneva Identification System", "GEN# +1.00022424"},
        {"Smithsonian Astrophysical Observation", "SAO 168662"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.87877166),
        dec: Angle.Degrees(-26.42991502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64315"},
        {"Hipparcos Number", "HIP 38430"},
        {"Geneva Identification System", "GEN# +2.24670019"},
        {"Smithsonian Astrophysical Observation", "SAO 174700"},
        {"New General Catalogue", "NGC 2467 19"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.08452328),
        dec: Angle.Degrees(-26.42963963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29397"},
        {"Hipparcos Number", "HIP 21471"},
        {"Geneva Identification System", "GEN# +1.00029397"},
        {"Smithsonian Astrophysical Observation", "SAO 169610"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.16597701),
        dec: Angle.Degrees(-26.42937349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31341"},
        {"Hipparcos Number", "HIP 22761"},
        {"Smithsonian Astrophysical Observation", "SAO 169861"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.45699973),
        dec: Angle.Degrees(-26.42915060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129010"},
        {"Hipparcos Number", "HIP 71774"},
        {"Geneva Identification System", "GEN# +1.00129010"},
        {"Smithsonian Astrophysical Observation", "SAO 182760"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.23274091),
        dec: Angle.Degrees(-26.42872263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82640"},
        {"Hipparcos Number", "HIP 46824"},
        {"Geneva Identification System", "GEN# +1.00082640"},
        {"Smithsonian Astrophysical Observation", "SAO 177623"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.12794507),
        dec: Angle.Degrees(-26.42654805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43301",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7028 AB"},
        {"Henry Draper", "HD 75458"},
        {"Hipparcos Number", "HIP 43301"},
        {"Smithsonian Astrophysical Observation", "SAO 176523"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.32414830),
        dec: Angle.Degrees(-26.42441162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108768"},
        {"Hipparcos Number", "HIP 60973"},
        {"Smithsonian Astrophysical Observation", "SAO 180846"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.48111809),
        dec: Angle.Degrees(-26.42030466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212852"},
        {"Hipparcos Number", "HIP 110861"},
        {"Geneva Identification System", "GEN# +1.00212852"},
        {"Smithsonian Astrophysical Observation", "SAO 191156"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.91366035),
        dec: Angle.Degrees(-26.41878953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1971",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1971"},
        {"Smithsonian Astrophysical Observation", "SAO 166254"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.23595477),
        dec: Angle.Degrees(-26.41821333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17207"},
        {"Cincinnati Publication", "Ci 18 491"},
        {"Geneva Identification System", "GEN# +0.00300515"},
        {"Smithsonian Astrophysical Observation", "SAO 111352"},
        {"Wilson Evans Batten Catalogue", "WEB 3261"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.29394467),
        dec: Angle.Degrees(+03.61195407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -236.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144396"},
        {"Hipparcos Number", "HIP 78919"},
        {"Renson", "Renson 40910"},
        {"Smithsonian Astrophysical Observation", "SAO 184119"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.66253335),
        dec: Angle.Degrees(-26.41709975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73335"},
        {"Hipparcos Number", "HIP 42263"},
        {"Smithsonian Astrophysical Observation", "SAO 176170"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.26559701),
        dec: Angle.Degrees(-26.41633327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102584",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14280 AB"},
        {"Henry Draper", "HD 197889"},
        {"Hipparcos Number", "HIP 102584"},
        {"Smithsonian Astrophysical Observation", "SAO 189697"},
    },
    visualMagnitude: 7.13,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.83370731),
        dec: Angle.Degrees(-26.41518664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225098"},
        {"Hipparcos Number", "HIP 272"},
        {"Geneva Identification System", "GEN# +1.00225098"},
        {"Smithsonian Astrophysical Observation", "SAO 166020"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.85551618),
        dec: Angle.Degrees(-26.41518293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48125",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7524 AB"},
        {"Henry Draper", "HD 85043"},
        {"Hipparcos Number", "HIP 48125"},
        {"Smithsonian Astrophysical Observation", "SAO 178027"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.17891571),
        dec: Angle.Degrees(-26.41453057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152500"},
        {"Hipparcos Number", "HIP 82756"},
        {"Geneva Identification System", "GEN# +1.00152500"},
        {"Smithsonian Astrophysical Observation", "SAO 184784"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.70839751),
        dec: Angle.Degrees(-26.41307315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124500"},
        {"Hipparcos Number", "HIP 69590"},
        {"Geneva Identification System", "GEN# +1.00124500"},
        {"Smithsonian Astrophysical Observation", "SAO 182367"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.66332877),
        dec: Angle.Degrees(-26.40488187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9731",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9731"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.29723777),
        dec: Angle.Degrees(-26.40339787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117033"},
        {"Hipparcos Number", "HIP 65682"},
        {"Smithsonian Astrophysical Observation", "SAO 181674"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.00784601),
        dec: Angle.Degrees(-26.40222506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203143"},
        {"Hipparcos Number", "HIP 105417"},
        {"Geneva Identification System", "GEN# +1.00203143"},
        {"Smithsonian Astrophysical Observation", "SAO 190253"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.28620376),
        dec: Angle.Degrees(-26.40189857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105145"},
        {"Hipparcos Number", "HIP 59047"},
        {"Smithsonian Astrophysical Observation", "SAO 180467"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.58906246),
        dec: Angle.Degrees(-26.39873087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26400"},
    },
    visualMagnitude: 11.34,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.29569829),
        dec: Angle.Degrees(-26.39869287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93626"},
        {"Hipparcos Number", "HIP 52828"},
        {"Geneva Identification System", "GEN# +1.00093626"},
        {"Smithsonian Astrophysical Observation", "SAO 179236"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.02362969),
        dec: Angle.Degrees(-26.39837737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5067"},
        {"Hipparcos Number", "HIP 4079"},
        {"Geneva Identification System", "GEN# +1.00005067"},
        {"Smithsonian Astrophysical Observation", "SAO 166641"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.07619292),
        dec: Angle.Degrees(-26.39823765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86735"},
        {"Hipparcos Number", "HIP 49006"},
        {"Smithsonian Astrophysical Observation", "SAO 178286"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.96701200),
        dec: Angle.Degrees(-26.39781961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93411"},
        {"Hipparcos Number", "HIP 52726"},
        {"Smithsonian Astrophysical Observation", "SAO 179218"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.69212376),
        dec: Angle.Degrees(-26.39718798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10831"},
        {"Hipparcos Number", "HIP 8206"},
        {"Smithsonian Astrophysical Observation", "SAO 167273"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.38819620),
        dec: Angle.Degrees(-26.39710291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34444",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Wezen"},
        {"Henry Draper", "HD 54605"},
        {"Hipparcos Number", "HIP 34444"},
        {"Fundamental Katalog 5th Edition", "FK5 273"},
        {"Geneva Identification System", "GEN# +5.11210031"},
        {"Smithsonian Astrophysical Observation", "SAO 173047"},
        {"Wilson Evans Batten Catalogue", "WEB 6902"},
    },
    visualMagnitude: 1.83,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.09785853),
        dec: Angle.Degrees(-26.39320776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220365"},
        {"Hipparcos Number", "HIP 115465"},
        {"Smithsonian Astrophysical Observation", "SAO 191863"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.84715461),
        dec: Angle.Degrees(-26.39236690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20386"},
        {"Hipparcos Number", "HIP 15195"},
        {"Smithsonian Astrophysical Observation", "SAO 168421"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.95777308),
        dec: Angle.Degrees(-26.39229067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10492"},
        {"Hipparcos Number", "HIP 7922"},
        {"Smithsonian Astrophysical Observation", "SAO 167237"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.45684456),
        dec: Angle.Degrees(-26.39009414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34140"},
        {"Hipparcos Number", "HIP 24400"},
        {"Smithsonian Astrophysical Observation", "SAO 170221"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.51471336),
        dec: Angle.Degrees(-26.38974677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117308"},
    },
    visualMagnitude: 11.29,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.79585765),
        dec: Angle.Degrees(-26.38962679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -210.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63147"},
        {"Hipparcos Number", "HIP 37933"},
        {"Geneva Identification System", "GEN# +1.00063147"},
        {"Smithsonian Astrophysical Observation", "SAO 174503"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.60613551),
        dec: Angle.Degrees(-26.38936121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91713"},
        {"Hipparcos Number", "HIP 51800"},
        {"Smithsonian Astrophysical Observation", "SAO 178998"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.75836652),
        dec: Angle.Degrees(-26.38174410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44933"},
        {"Hipparcos Number", "HIP 30390"},
        {"Smithsonian Astrophysical Observation", "SAO 171672"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.85715187),
        dec: Angle.Degrees(-26.37959314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123541"},
        {"Hipparcos Number", "HIP 69119"},
        {"Smithsonian Astrophysical Observation", "SAO 182284"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.23028713),
        dec: Angle.Degrees(-26.37928517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -225.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140838"},
        {"Hipparcos Number", "HIP 77288"},
        {"Smithsonian Astrophysical Observation", "SAO 183779"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.68999709),
        dec: Angle.Degrees(-26.37819663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31859"},
        {"Hipparcos Number", "HIP 23096"},
        {"Smithsonian Astrophysical Observation", "SAO 169929"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.54814119),
        dec: Angle.Degrees(-26.37592451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212359"},
        {"Hipparcos Number", "HIP 110577"},
        {"Geneva Identification System", "GEN# +1.00212359"},
        {"Smithsonian Astrophysical Observation", "SAO 191113"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.02719648),
        dec: Angle.Degrees(-26.37325599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147491"},
        {"Henry Draper 2", "HD 147491A"},
        {"Hipparcos Number", "HIP 80290"},
        {"Geneva Identification System", "GEN# +1.00147491"},
        {"Smithsonian Astrophysical Observation", "SAO 184354"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.84560797),
        dec: Angle.Degrees(-26.37113940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86307"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.52556326),
        dec: Angle.Degrees(-26.37050318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30263"},
        {"Smithsonian Astrophysical Observation", "SAO 171633"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.49238067),
        dec: Angle.Degrees(-26.36970922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36065",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36065"},
        {"Renson", "Renson 16050"},
        {"Smithsonian Astrophysical Observation", "SAO 173716"},
    },
    visualMagnitude: 10.10,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.48143349),
        dec: Angle.Degrees(-26.36961511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4672"},
        {"Hipparcos Number", "HIP 3775"},
        {"Smithsonian Astrophysical Observation", "SAO 166591"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.13076426),
        dec: Angle.Degrees(-26.36908325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185048"},
        {"Hipparcos Number", "HIP 96605"},
        {"Smithsonian Astrophysical Observation", "SAO 188371"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.60424302),
        dec: Angle.Degrees(-26.36763391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145571"},
        {"Hipparcos Number", "HIP 79442"},
        {"Smithsonian Astrophysical Observation", "SAO 184227"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.19010347),
        dec: Angle.Degrees(-26.36549226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61986"},
        {"Hipparcos Number", "HIP 37419"},
        {"Cincinnati Publication", "Ci 20 433"},
        {"Geneva Identification System", "GEN# +1.00061986"},
        {"Smithsonian Astrophysical Observation", "SAO 174280"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.22568983),
        dec: Angle.Degrees(-26.36282660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 324.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -281.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218721"},
        {"Hipparcos Number", "HIP 114436"},
        {"Geneva Identification System", "GEN# +1.00218721"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.64082052),
        dec: Angle.Degrees(-26.36282042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191680"},
        {"Hipparcos Number", "HIP 99536"},
        {"Smithsonian Astrophysical Observation", "SAO 189006"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.01062454),
        dec: Angle.Degrees(-26.36260970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81885"},
        {"Hipparcos Number", "HIP 46401"},
        {"Smithsonian Astrophysical Observation", "SAO 177483"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.93202212),
        dec: Angle.Degrees(-26.36204567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10803"},
        {"Hipparcos Number", "HIP 8187"},
        {"Smithsonian Astrophysical Observation", "SAO 167270"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.31512295),
        dec: Angle.Degrees(-26.36015565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99791"},
        {"Hipparcos Number", "HIP 56011"},
        {"Smithsonian Astrophysical Observation", "SAO 179919"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.18658923),
        dec: Angle.Degrees(-26.35963956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90307"},
        {"Hipparcos Number", "HIP 51000"},
        {"Smithsonian Astrophysical Observation", "SAO 178795"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.26993544),
        dec: Angle.Degrees(-26.35806129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213329"},
        {"Hipparcos Number", "HIP 111150"},
        {"Geneva Identification System", "GEN# +1.00213329"},
        {"Smithsonian Astrophysical Observation", "SAO 191199"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.78032251),
        dec: Angle.Degrees(-26.35383833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26776",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4281 B"},
        {"Hipparcos Number", "HIP 26776"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.32402127),
        dec: Angle.Degrees(-26.35319997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96465"},
        {"Hipparcos Number", "HIP 54321"},
        {"Smithsonian Astrophysical Observation", "SAO 179543"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.68756746),
        dec: Angle.Degrees(-26.34601744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56014"},
        {"Hipparcos Number", "HIP 34981"},
        {"Celescope Catalog", "CEL 1698"},
        {"Geneva Identification System", "GEN# +1.00056014J"},
        {"Smithsonian Astrophysical Observation", "SAO 173264"},
        {"Wilson Evans Batten Catalogue", "WEB 6996"},
    },
    visualMagnitude: 4.42,
    bvColour: -0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.56340179),
        dec: Angle.Degrees(-26.35251617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20584"},
        {"Hipparcos Number", "HIP 15343"},
        {"Geneva Identification System", "GEN# +1.00020584"},
        {"Smithsonian Astrophysical Observation", "SAO 168446"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.46153680),
        dec: Angle.Degrees(-26.35238791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105312",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14847"},
        {"Henry Draper", "HD 202940"},
        {"Hipparcos Number", "HIP 105312"},
        {"Cincinnati Publication", "Ci 20 1277"},
        {"Geneva Identification System", "GEN# +1.00202940"},
        {"Smithsonian Astrophysical Observation", "SAO 190236"},
        {"Wilson Evans Batten Catalogue", "WEB 19126"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.94168340),
        dec: Angle.Degrees(-26.35201100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -582.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -357.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94709"},
        {"Hipparcos Number", "HIP 53416"},
        {"Geneva Identification System", "GEN# +1.00094709"},
        {"Smithsonian Astrophysical Observation", "SAO 179343"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.90157942),
        dec: Angle.Degrees(-26.35181995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -230.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75740"},
        {"Hipparcos Number", "HIP 43444"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.72530795),
        dec: Angle.Degrees(-26.35155149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62412"},
        {"Hipparcos Number", "HIP 37590"},
        {"Geneva Identification System", "GEN# +1.00062412"},
        {"Smithsonian Astrophysical Observation", "SAO 174356"},
        {"Wilson Evans Batten Catalogue", "WEB 7431"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.70064325),
        dec: Angle.Degrees(-26.35125398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59716"},
        {"Hipparcos Number", "HIP 36469"},
        {"Renson", "Renson 16310"},
        {"Smithsonian Astrophysical Observation", "SAO 173882"},
    },
    visualMagnitude: 9.65,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.56197459),
        dec: Angle.Degrees(-26.35100574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76892"},
        {"Hipparcos Number", "HIP 44048"},
        {"Smithsonian Astrophysical Observation", "SAO 176754"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.56119048),
        dec: Angle.Degrees(-26.34984024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120368"},
        {"Hipparcos Number", "HIP 67458"},
        {"Geneva Identification System", "GEN# +1.00120368"},
        {"Smithsonian Astrophysical Observation", "SAO 181989"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.36338145),
        dec: Angle.Degrees(-26.34958539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123456"},
        {"Hipparcos Number", "HIP 69081"},
        {"Smithsonian Astrophysical Observation", "SAO 182277"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.10323269),
        dec: Angle.Degrees(-26.34907422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64657"},
        {"Hipparcos Number", "HIP 38580"},
        {"Smithsonian Astrophysical Observation", "SAO 174762"},
        {"Wilson Evans Batten Catalogue", "WEB 7577"},
        {"New General Catalogue", "NGC 2467 83"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.49458874),
        dec: Angle.Degrees(-26.34881861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39174"},
        {"Hipparcos Number", "HIP 27514"},
        {"Smithsonian Astrophysical Observation", "SAO 170887"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.40060289),
        dec: Angle.Degrees(-26.34875233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41074",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6782 AB"},
        {"Henry Draper", "HD 70761"},
        {"Hipparcos Number", "HIP 41074"},
        {"Geneva Identification System", "GEN# +1.00070761J"},
        {"Smithsonian Astrophysical Observation", "SAO 175709"},
        {"Wilson Evans Batten Catalogue", "WEB 7958"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.70808174),
        dec: Angle.Degrees(-26.34823475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5455"},
        {"Hipparcos Number", "HIP 4379"},
        {"Smithsonian Astrophysical Observation", "SAO 166689"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.02662696),
        dec: Angle.Degrees(-26.34708420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26775",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4281 A"},
        {"Henry Draper", "HD 37987"},
        {"Hipparcos Number", "HIP 26775"},
        {"Geneva Identification System", "GEN# +1.00037987"},
        {"Smithsonian Astrophysical Observation", "SAO 170697"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.32056886),
        dec: Angle.Degrees(-26.34668648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11723"},
        {"Hipparcos Number", "HIP 8890"},
        {"Smithsonian Astrophysical Observation", "SAO 167385"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.61154691),
        dec: Angle.Degrees(-26.34494707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69947"},
        {"Hipparcos Number", "HIP 40682"},
        {"Smithsonian Astrophysical Observation", "SAO 175554"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.58387315),
        dec: Angle.Degrees(-26.34457516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123969"},
        {"Hipparcos Number", "HIP 69329"},
        {"Smithsonian Astrophysical Observation", "SAO 182323"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.83752933),
        dec: Angle.Degrees(-26.34418586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146438"},
        {"Hipparcos Number", "HIP 79815"},
        {"Geneva Identification System", "GEN# +1.00146438"},
        {"Smithsonian Astrophysical Observation", "SAO 184289"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.33850466),
        dec: Angle.Degrees(-26.34262272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63735"},
        {"Hipparcos Number", "HIP 38182"},
        {"Geneva Identification System", "GEN# +1.00063735"},
        {"Smithsonian Astrophysical Observation", "SAO 174610"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.36688931),
        dec: Angle.Degrees(-26.34122493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156933"},
        {"Hipparcos Number", "HIP 84933"},
        {"Smithsonian Astrophysical Observation", "SAO 185308"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.37566363),
        dec: Angle.Degrees(-26.33768050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85368"},
        {"Hipparcos Number", "HIP 48293"},
        {"Smithsonian Astrophysical Observation", "SAO 178083"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.69509829),
        dec: Angle.Degrees(-26.33345747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134373"},
        {"Hipparcos Number", "HIP 74239"},
        {"Geneva Identification System", "GEN# +1.00134373"},
        {"Smithsonian Astrophysical Observation", "SAO 183237"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.57771621),
        dec: Angle.Degrees(-26.33260080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85387",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10547 AB"},
        {"Henry Draper", "HD 157865"},
        {"Hipparcos Number", "HIP 85387"},
        {"Smithsonian Astrophysical Observation", "SAO 185404"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.71154926),
        dec: Angle.Degrees(-26.33178052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91644"},
        {"Hipparcos Number", "HIP 51754"},
        {"Smithsonian Astrophysical Observation", "SAO 178984"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.61461059),
        dec: Angle.Degrees(-26.33018742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46679"},
        {"Hipparcos Number", "HIP 31284"},
        {"Smithsonian Astrophysical Observation", "SAO 171950"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.41600411),
        dec: Angle.Degrees(-26.32964751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190102"},
        {"Hipparcos Number", "HIP 98839"},
        {"Geneva Identification System", "GEN# +1.00190102"},
        {"Smithsonian Astrophysical Observation", "SAO 188873"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.07532850),
        dec: Angle.Degrees(-26.32935247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38483",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38483"},
        {"Geneva Identification System", "GEN# +2.24670047"},
        {"New General Catalogue", "NGC 2467 47"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.21830687),
        dec: Angle.Degrees(-26.32906644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23920"},
        {"Hipparcos Number", "HIP 17745"},
        {"Smithsonian Astrophysical Observation", "SAO 168841"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.99608238),
        dec: Angle.Degrees(-26.32861614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210739"},
        {"Hipparcos Number", "HIP 109667"},
        {"Geneva Identification System", "GEN# +1.00210739"},
        {"Smithsonian Astrophysical Observation", "SAO 190967"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.23958651),
        dec: Angle.Degrees(-26.32772421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2653",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 466 B"},
        {"Hipparcos Number", "HIP 2653"},
        {"Smithsonian Astrophysical Observation", "SAO 166365"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.40705709),
        dec: Angle.Degrees(-26.08894577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144690"},
        {"Hipparcos Number", "HIP 79050"},
        {"Geneva Identification System", "GEN# +1.00144690"},
        {"Smithsonian Astrophysical Observation", "SAO 184144"},
        {"Wilson Evans Batten Catalogue", "WEB 13361"},
    },
    visualMagnitude: 5.35,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.03133733),
        dec: Angle.Degrees(-26.32666483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21816"},
        {"Hipparcos Number", "HIP 16301"},
        {"Smithsonian Astrophysical Observation", "SAO 168593"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.53216988),
        dec: Angle.Degrees(-26.32558389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 901"},
        {"Hipparcos Number", "HIP 1069"},
        {"Smithsonian Astrophysical Observation", "SAO 166124"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.31443363),
        dec: Angle.Degrees(-26.32530812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150804"},
        {"Hipparcos Number", "HIP 81950"},
        {"Smithsonian Astrophysical Observation", "SAO 184592"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.09067924),
        dec: Angle.Degrees(-26.32495428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41739"},
        {"Hipparcos Number", "HIP 28876"},
        {"Smithsonian Astrophysical Observation", "SAO 171225"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.44890451),
        dec: Angle.Degrees(-26.32446810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13652"},
        {"Hipparcos Number", "HIP 10292"},
        {"Geneva Identification System", "GEN# +1.00013652"},
        {"Smithsonian Astrophysical Observation", "SAO 167634"},
        {"Wilson Evans Batten Catalogue", "WEB 2147"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.14368876),
        dec: Angle.Degrees(-26.32242863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150146"},
        {"Hipparcos Number", "HIP 81621"},
        {"Smithsonian Astrophysical Observation", "SAO 184535"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.05523534),
        dec: Angle.Degrees(-26.32214994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11911"},
    },
    visualMagnitude: 11.67,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.43254506),
        dec: Angle.Degrees(-26.32169047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12422"},
        {"Smithsonian Astrophysical Observation", "SAO 167959"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.97371498),
        dec: Angle.Degrees(-26.32078899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198839"},
        {"Hipparcos Number", "HIP 103148"},
        {"Geneva Identification System", "GEN# +1.00198839"},
        {"Smithsonian Astrophysical Observation", "SAO 189812"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.48237513),
        dec: Angle.Degrees(-26.31955395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95604",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12432 A"},
        {"Henry Draper", "HD 182649"},
        {"Hipparcos Number", "HIP 95604"},
        {"Smithsonian Astrophysical Observation", "SAO 188125"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.67572087),
        dec: Angle.Degrees(-26.31835611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16623"},
        {"Hipparcos Number", "HIP 12364"},
        {"Geneva Identification System", "GEN# +1.00016623"},
        {"Smithsonian Astrophysical Observation", "SAO 167952"},
        {"Wilson Evans Batten Catalogue", "WEB 2534"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.78983744),
        dec: Angle.Degrees(-26.31814507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -233.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115154"},
        {"Hipparcos Number", "HIP 64703"},
        {"Smithsonian Astrophysical Observation", "SAO 181492"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.91640735),
        dec: Angle.Degrees(-26.31787130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -199.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141867"},
        {"Hipparcos Number", "HIP 77736"},
        {"Smithsonian Astrophysical Observation", "SAO 183876"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.06392651),
        dec: Angle.Degrees(-26.31785058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61512"},
        {"Hipparcos Number", "HIP 37215"},
        {"Celescope Catalog", "CEL 1958"},
        {"Geneva Identification System", "GEN# +1.00061512"},
        {"Renson", "Renson 16880"},
        {"Smithsonian Astrophysical Observation", "SAO 174190"},
    },
    visualMagnitude: 7.15,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.66547490),
        dec: Angle.Degrees(-26.31669742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221591"},
        {"Hipparcos Number", "HIP 116269"},
        {"Smithsonian Astrophysical Observation", "SAO 191989"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.37577541),
        dec: Angle.Degrees(-26.31455861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83846"},
        {"Hipparcos Number", "HIP 47465"},
        {"Smithsonian Astrophysical Observation", "SAO 177827"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.13642554),
        dec: Angle.Degrees(-26.31442086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144911"},
        {"Hipparcos Number", "HIP 79140"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.30300335),
        dec: Angle.Degrees(-26.31435424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74334"},
        {"Hipparcos Number", "HIP 42735"},
        {"Smithsonian Astrophysical Observation", "SAO 176339"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.63350706),
        dec: Angle.Degrees(-26.31224166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217379"},
        {"Hipparcos Number", "HIP 113597"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.11616530),
        dec: Angle.Degrees(-26.31149447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13576"},
        {"Hipparcos Number", "HIP 10255"},
        {"Smithsonian Astrophysical Observation", "SAO 167623"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.97929777),
        dec: Angle.Degrees(-26.30828823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41721"},
    },
    visualMagnitude: 11.38,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.61803681),
        dec: Angle.Degrees(-26.30777515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6517"},
        {"Hipparcos Number", "HIP 5140"},
        {"Geneva Identification System", "GEN# +1.00006517A"},
        {"Smithsonian Astrophysical Observation", "SAO 166792"},
        {"Wilson Evans Batten Catalogue", "WEB 1061"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.45518435),
        dec: Angle.Degrees(-26.30692913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7582"},
    },
    visualMagnitude: 11.44,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.41075668),
        dec: Angle.Degrees(-26.30362982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30447"},
        {"Hipparcos Number", "HIP 22226"},
        {"Geneva Identification System", "GEN# +1.00030447"},
        {"Smithsonian Astrophysical Observation", "SAO 169759"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.70627759),
        dec: Angle.Degrees(-26.30244655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69756"},
        {"Hipparcos Number", "HIP 40611"},
        {"Fundamental Katalog 5th Edition", "FK5 4744"},
        {"Geneva Identification System", "GEN# +1.00069756"},
        {"Smithsonian Astrophysical Observation", "SAO 175520"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.37123742),
        dec: Angle.Degrees(-26.30197067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110602"},
        {"Hipparcos Number", "HIP 62090"},
        {"Fundamental Katalog 5th Edition", "FK5 5121"},
        {"Smithsonian Astrophysical Observation", "SAO 181053"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.88361850),
        dec: Angle.Degrees(-26.30148792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138872"},
        {"Hipparcos Number", "HIP 76352"},
        {"Geneva Identification System", "GEN# +1.00138872"},
        {"Smithsonian Astrophysical Observation", "SAO 183599"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.91811608),
        dec: Angle.Degrees(-26.30108330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26150"},
        {"Hipparcos Number", "HIP 19236"},
        {"Smithsonian Astrophysical Observation", "SAO 169145"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.84800251),
        dec: Angle.Degrees(-26.30000007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98066",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Terebellum"},
        {"Henry Draper", "HD 188376"},
        {"Hipparcos Number", "HIP 98066"},
        {"Geneva Identification System", "GEN# +1.00188376"},
        {"Smithsonian Astrophysical Observation", "SAO 188722"},
        {"Wilson Evans Batten Catalogue", "WEB 17278"},
    },
    visualMagnitude: 4.70,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.95927101),
        dec: Angle.Degrees(-26.29968718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140599"},
        {"Hipparcos Number", "HIP 77170"},
        {"Smithsonian Astrophysical Observation", "SAO 183758"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.35947973),
        dec: Angle.Degrees(-26.29923753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13217"},
        {"Hipparcos Number", "HIP 9985"},
        {"Smithsonian Astrophysical Observation", "SAO 167582"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.15146604),
        dec: Angle.Degrees(-26.29915113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152421"},
        {"Hipparcos Number", "HIP 82705"},
        {"Smithsonian Astrophysical Observation", "SAO 184773"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.57947055),
        dec: Angle.Degrees(-26.29883440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92855",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Nunki"},
        {"Henry Draper", "HD 175191"},
        {"Hipparcos Number", "HIP 92855"},
        {"Fundamental Katalog 5th Edition", "FK5 706"},
        {"Geneva Identification System", "GEN# +1.00175191"},
        {"Smithsonian Astrophysical Observation", "SAO 187448"},
        {"Wilson Evans Batten Catalogue", "WEB 16074"},
    },
    visualMagnitude: 2.05,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.81631956),
        dec: Angle.Degrees(-26.29659428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199260"},
        {"Hipparcos Number", "HIP 103389"},
        {"Geneva Identification System", "GEN# +1.00199260"},
        {"Smithsonian Astrophysical Observation", "SAO 189856"},
        {"Wilson Evans Batten Catalogue", "WEB 18796"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.19695920),
        dec: Angle.Degrees(-26.29621951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172548"},
        {"Hipparcos Number", "HIP 91684"},
        {"Geneva Identification System", "GEN# +1.00172548"},
        {"Smithsonian Astrophysical Observation", "SAO 187143"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.45541220),
        dec: Angle.Degrees(-26.29562677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165409"},
        {"Hipparcos Number", "HIP 88739"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.73159174),
        dec: Angle.Degrees(-26.29421141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1523"},
        {"Smithsonian Astrophysical Observation", "SAO 166181"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.74339926),
        dec: Angle.Degrees(-26.29371154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215300"},
        {"Hipparcos Number", "HIP 112272"},
        {"Smithsonian Astrophysical Observation", "SAO 191365"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.12053194),
        dec: Angle.Degrees(-26.29258571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39575"},
        {"Hipparcos Number", "HIP 27748"},
        {"Geneva Identification System", "GEN# +1.00039575"},
        {"Renson", "Renson 10600"},
        {"Smithsonian Astrophysical Observation", "SAO 170953"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.09933682),
        dec: Angle.Degrees(-26.29118423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15958"},
        {"Hipparcos Number", "HIP 11887"},
        {"Smithsonian Astrophysical Observation", "SAO 167870"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.32133904),
        dec: Angle.Degrees(-26.29098735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145811"},
        {"Hipparcos Number", "HIP 79546"},
        {"Smithsonian Astrophysical Observation", "SAO 184243"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.47619380),
        dec: Angle.Degrees(-26.29021845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141554"},
        {"Hipparcos Number", "HIP 77606"},
        {"Smithsonian Astrophysical Observation", "SAO 183847"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.64545503),
        dec: Angle.Degrees(-26.28955430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171595"},
        {"Hipparcos Number", "HIP 91253"},
        {"Smithsonian Astrophysical Observation", "SAO 187041"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.20097232),
        dec: Angle.Degrees(-26.28933665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20852"},
        {"Hipparcos Number", "HIP 15582"},
        {"Geneva Identification System", "GEN# +1.00020852"},
        {"Smithsonian Astrophysical Observation", "SAO 168474"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.18567122),
        dec: Angle.Degrees(-26.28814419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 141.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78985"},
        {"Hipparcos Number", "HIP 45044"},
        {"Geneva Identification System", "GEN# +1.00078985"},
        {"Smithsonian Astrophysical Observation", "SAO 177072"},
        {"Wilson Evans Batten Catalogue", "WEB 8599"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.61904335),
        dec: Angle.Degrees(-26.28687583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 943"},
        {"Hipparcos Number", "HIP 1099"},
        {"Geneva Identification System", "GEN# +1.00000943"},
        {"Smithsonian Astrophysical Observation", "SAO 166131"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.43491480),
        dec: Angle.Degrees(-26.28498303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131885"},
        {"Hipparcos Number", "HIP 73150"},
        {"Fundamental Katalog 5th Edition", "FK5 5324"},
        {"Smithsonian Astrophysical Observation", "SAO 183025"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.23944984),
        dec: Angle.Degrees(-26.28496284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28675",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4645 AB"},
        {"Henry Draper", "HD 41312"},
        {"Hipparcos Number", "HIP 28675"},
        {"Geneva Identification System", "GEN# +1.00041312J"},
        {"Smithsonian Astrophysical Observation", "SAO 171180"},
        {"Wilson Evans Batten Catalogue", "WEB 5608"},
    },
    visualMagnitude: 5.03,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.81483793),
        dec: Angle.Degrees(-26.28475048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165290"},
        {"Hipparcos Number", "HIP 88687"},
        {"Smithsonian Astrophysical Observation", "SAO 186276"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.57245097),
        dec: Angle.Degrees(-26.28371172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13299"},
        {"Hipparcos Number", "HIP 10046"},
        {"Geneva Identification System", "GEN# +1.00013299"},
        {"Smithsonian Astrophysical Observation", "SAO 167595"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.33796546),
        dec: Angle.Degrees(-26.28246285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28243"},
        {"Hipparcos Number", "HIP 20716"},
        {"Smithsonian Astrophysical Observation", "SAO 169447"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.59211374),
        dec: Angle.Degrees(-26.28078506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139160"},
        {"Hipparcos Number", "HIP 76503"},
        {"Geneva Identification System", "GEN# +1.00139160"},
        {"Renson", "Renson 39630"},
        {"Smithsonian Astrophysical Observation", "SAO 183631"},
        {"Wilson Evans Batten Catalogue", "WEB 12984"},
    },
    visualMagnitude: 6.19,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.36877505),
        dec: Angle.Degrees(-26.27980785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172624"},
        {"Hipparcos Number", "HIP 91721"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.55956796),
        dec: Angle.Degrees(-26.27953325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44736"},
        {"Hipparcos Number", "HIP 30288"},
        {"Smithsonian Astrophysical Observation", "SAO 171642"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.56605785),
        dec: Angle.Degrees(-26.27733832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28599"},
        {"Hipparcos Number", "HIP 20953"},
        {"Smithsonian Astrophysical Observation", "SAO 169503"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.38588535),
        dec: Angle.Degrees(-26.27593395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52928"},
        {"Hipparcos Number", "HIP 33882"},
        {"Smithsonian Astrophysical Observation", "SAO 172803"},
    },
    visualMagnitude: 9.64,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.49119157),
        dec: Angle.Degrees(-26.27591310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28365"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.88871655),
        dec: Angle.Degrees(-26.27585463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32436"},
        {"Hipparcos Number", "HIP 23430"},
        {"Fundamental Katalog 5th Edition", "FK5 2377"},
        {"Geneva Identification System", "GEN# +1.00032436"},
        {"Smithsonian Astrophysical Observation", "SAO 169997"},
        {"Wilson Evans Batten Catalogue", "WEB 4553"},
    },
    visualMagnitude: 5.01,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.54069171),
        dec: Angle.Degrees(-26.27484321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147592"},
        {"Hipparcos Number", "HIP 80311"},
        {"Geneva Identification System", "GEN# +1.00147592"},
        {"Smithsonian Astrophysical Observation", "SAO 184356"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.94657333),
        dec: Angle.Degrees(-26.27100134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158704"},
        {"Hipparcos Number", "HIP 85783"},
        {"Geneva Identification System", "GEN# +1.00158704"},
        {"Renson", "Renson 44660"},
        {"Smithsonian Astrophysical Observation", "SAO 185474"},
        {"Wilson Evans Batten Catalogue", "WEB 14475"},
    },
    visualMagnitude: 6.05,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.93489630),
        dec: Angle.Degrees(-26.26965423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13790",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13790"},
    },
    visualMagnitude: 10.33,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.38803310),
        dec: Angle.Degrees(-26.26828705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79457"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.22373945),
        dec: Angle.Degrees(+03.64710000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83147",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83147"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.88826284),
        dec: Angle.Degrees(-26.26718398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -299.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80448"},
        {"Hipparcos Number", "HIP 45708"},
        {"Smithsonian Astrophysical Observation", "SAO 177270"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.77395221),
        dec: Angle.Degrees(-26.26680759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122156"},
        {"Hipparcos Number", "HIP 68434"},
        {"Geneva Identification System", "GEN# +1.00122156"},
        {"Smithsonian Astrophysical Observation", "SAO 182161"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.15048079),
        dec: Angle.Degrees(-26.26603193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142445"},
        {"Hipparcos Number", "HIP 77984"},
        {"Celescope Catalog", "CEL 4405"},
        {"Geneva Identification System", "GEN# +1.00142445"},
        {"Smithsonian Astrophysical Observation", "SAO 183931"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.87542764),
        dec: Angle.Degrees(-26.26592073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194812"},
        {"Hipparcos Number", "HIP 101003"},
        {"Smithsonian Astrophysical Observation", "SAO 189327"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.16144267),
        dec: Angle.Degrees(-26.26396153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89817"},
        {"Hipparcos Number", "HIP 50724"},
        {"Smithsonian Astrophysical Observation", "SAO 178720"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.35123745),
        dec: Angle.Degrees(-26.26216922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64616"},
        {"Hipparcos Number", "HIP 38571"},
        {"Geneva Identification System", "GEN# +2.24670081"},
        {"Smithsonian Astrophysical Observation", "SAO 174755"},
        {"New General Catalogue", "NGC 2467 81"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.45535455),
        dec: Angle.Degrees(-26.26210298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1692"},
        {"Hipparcos Number", "HIP 1685"},
        {"Geneva Identification System", "GEN# +1.00001692"},
        {"Smithsonian Astrophysical Observation", "SAO 166205"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.27866635),
        dec: Angle.Degrees(-26.26127851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8637"},
        {"Hipparcos Number", "HIP 6608"},
        {"Geneva Identification System", "GEN# +1.00008637"},
        {"Smithsonian Astrophysical Observation", "SAO 167030"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.20561534),
        dec: Angle.Degrees(-26.26082732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84639"},
        {"Hipparcos Number", "HIP 47923"},
        {"Smithsonian Astrophysical Observation", "SAO 177953"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.50204776),
        dec: Angle.Degrees(-26.25993387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20102"},
        {"Hipparcos Number", "HIP 14966"},
        {"Geneva Identification System", "GEN# +1.00020102"},
        {"Smithsonian Astrophysical Observation", "SAO 168386"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.23219395),
        dec: Angle.Degrees(-26.25904685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71733",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9333 AB"},
        {"Henry Draper", "HD 128928"},
        {"Hipparcos Number", "HIP 71733"},
        {"Smithsonian Astrophysical Observation", "SAO 182752"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.10461770),
        dec: Angle.Degrees(-26.25570116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46115"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.06822209),
        dec: Angle.Degrees(-26.25526021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73495"},
        {"Hipparcos Number", "HIP 42334"},
        {"Fundamental Katalog 5th Edition", "FK5 2676"},
        {"Geneva Identification System", "GEN# +1.00073495"},
        {"Smithsonian Astrophysical Observation", "SAO 176189"},
        {"Wilson Evans Batten Catalogue", "WEB 8138"},
    },
    visualMagnitude: 5.24,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.46736838),
        dec: Angle.Degrees(-26.25497008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11100"},
        {"Hipparcos Number", "HIP 8417"},
        {"Geneva Identification System", "GEN# +1.00011100"},
        {"Smithsonian Astrophysical Observation", "SAO 167312"},
        {"Wilson Evans Batten Catalogue", "WEB 1795"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.14977657),
        dec: Angle.Degrees(-26.25365006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135777"},
        {"Hipparcos Number", "HIP 74840"},
        {"Geneva Identification System", "GEN# +1.00135777"},
        {"Smithsonian Astrophysical Observation", "SAO 183345"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.41660305),
        dec: Angle.Degrees(-26.25202991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92166"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.77289484),
        dec: Angle.Degrees(-26.25073594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117107",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16963 A"},
        {"Henry Draper", "HD 222872"},
        {"Hipparcos Number", "HIP 117107"},
        {"Geneva Identification System", "GEN# +1.00222872"},
        {"Smithsonian Astrophysical Observation", "SAO 192116"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.12124378),
        dec: Angle.Degrees(-26.24658154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77561"},
        {"Hipparcos Number", "HIP 44383"},
        {"Smithsonian Astrophysical Observation", "SAO 176863"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.62184509),
        dec: Angle.Degrees(-26.24261368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211794"},
        {"Hipparcos Number", "HIP 110269"},
        {"Smithsonian Astrophysical Observation", "SAO 191065"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.03313842),
        dec: Angle.Degrees(-26.24172052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199424"},
        {"Hipparcos Number", "HIP 103467"},
        {"Smithsonian Astrophysical Observation", "SAO 189878"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.44369163),
        dec: Angle.Degrees(-26.23957994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101551"},
        {"Hipparcos Number", "HIP 56995"},
        {"Smithsonian Astrophysical Observation", "SAO 180095"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.25630585),
        dec: Angle.Degrees(-26.23898557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58823"},
        {"Hipparcos Number", "HIP 36096"},
        {"Celescope Catalog", "CEL 1851"},
        {"Geneva Identification System", "GEN# +1.00058823"},
        {"Smithsonian Astrophysical Observation", "SAO 173727"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.54644288),
        dec: Angle.Degrees(-26.23613273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207290"},
        {"Hipparcos Number", "HIP 107663"},
        {"Geneva Identification System", "GEN# +1.00207290"},
        {"Smithsonian Astrophysical Observation", "SAO 190639"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.11630182),
        dec: Angle.Degrees(-26.23520804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64568"},
        {"Hipparcos Number", "HIP 38548"},
        {"Geneva Identification System", "GEN# +2.24670077"},
        {"Smithsonian Astrophysical Observation", "SAO 174748"},
        {"New General Catalogue", "NGC 2467 77"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.40918947),
        dec: Angle.Degrees(-26.23406544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211440"},
        {"Hipparcos Number", "HIP 110057"},
        {"Smithsonian Astrophysical Observation", "SAO 191025"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.36975342),
        dec: Angle.Degrees(-26.23159234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28997"},
        {"Hipparcos Number", "HIP 21215"},
        {"Smithsonian Astrophysical Observation", "SAO 169558"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.26195528),
        dec: Angle.Degrees(-26.23072731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191089"},
        {"Hipparcos Number", "HIP 99273"},
        {"Geneva Identification System", "GEN# +1.00191089"},
        {"Smithsonian Astrophysical Observation", "SAO 188955"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.27162269),
        dec: Angle.Degrees(-26.22386913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189419"},
        {"Hipparcos Number", "HIP 98521"},
        {"Smithsonian Astrophysical Observation", "SAO 188817"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.22884205),
        dec: Angle.Degrees(-26.22368381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 454"},
        {"Hipparcos Number", "HIP 721"},
        {"Smithsonian Astrophysical Observation", "SAO 166078"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.23047849),
        dec: Angle.Degrees(-26.22362939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5630"},
        {"Hipparcos Number", "HIP 4505"},
        {"Geneva Identification System", "GEN# +1.00005630"},
        {"Smithsonian Astrophysical Observation", "SAO 166705"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.43241564),
        dec: Angle.Degrees(-26.22291493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12330"},
        {"Hipparcos Number", "HIP 9375"},
        {"Smithsonian Astrophysical Observation", "SAO 167477"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.11879455),
        dec: Angle.Degrees(-26.22268298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157381"},
        {"Hipparcos Number", "HIP 85152"},
        {"Smithsonian Astrophysical Observation", "SAO 185356"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.01222604),
        dec: Angle.Degrees(-26.22254488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22923"},
        {"Hipparcos Number", "HIP 17115"},
        {"Geneva Identification System", "GEN# +1.00022923"},
        {"Smithsonian Astrophysical Observation", "SAO 168721"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.98595010),
        dec: Angle.Degrees(-26.22242510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188659"},
        {"Hipparcos Number", "HIP 98197"},
        {"Geneva Identification System", "GEN# +1.00188659"},
        {"Smithsonian Astrophysical Observation", "SAO 188749"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.31451508),
        dec: Angle.Degrees(-26.21758600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21146"},
        {"Hipparcos Number", "HIP 15834"},
        {"Smithsonian Astrophysical Observation", "SAO 168512"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.99520127),
        dec: Angle.Degrees(-26.21666212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21145"},
        {"Hipparcos Number", "HIP 15833"},
        {"Smithsonian Astrophysical Observation", "SAO 168511"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.98879758),
        dec: Angle.Degrees(-26.21618392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173595"},
        {"Hipparcos Number", "HIP 92176"},
        {"Smithsonian Astrophysical Observation", "SAO 187275"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.79466944),
        dec: Angle.Degrees(-26.21544301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157094"},
        {"Hipparcos Number", "HIP 84996"},
        {"Smithsonian Astrophysical Observation", "SAO 185328"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.59297755),
        dec: Angle.Degrees(-26.21540044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24798"},
        {"Hipparcos Number", "HIP 18364"},
        {"Smithsonian Astrophysical Observation", "SAO 168961"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.90126011),
        dec: Angle.Degrees(-26.21503288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125169"},
        {"Hipparcos Number", "HIP 69900"},
        {"Smithsonian Astrophysical Observation", "SAO 182429"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.59244341),
        dec: Angle.Degrees(-26.21033862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34198"},
        {"Hipparcos Number", "HIP 24430"},
        {"Smithsonian Astrophysical Observation", "SAO 170230"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.62721357),
        dec: Angle.Degrees(-26.20853486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7016",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1193 AB"},
        {"Henry Draper", "HD 9228"},
        {"Hipparcos Number", "HIP 7016"},
        {"Geneva Identification System", "GEN# +1.00009228J"},
        {"Smithsonian Astrophysical Observation", "SAO 167093"},
        {"Wilson Evans Batten Catalogue", "WEB 1518"},
    },
    visualMagnitude: 5.92,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.59531980),
        dec: Angle.Degrees(-26.20785462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40538"},
        {"Hipparcos Number", "HIP 28262"},
        {"Smithsonian Astrophysical Observation", "SAO 171087"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.57855110),
        dec: Angle.Degrees(-26.20527580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194623"},
        {"Hipparcos Number", "HIP 100909"},
        {"Renson", "Renson 54280"},
        {"Smithsonian Astrophysical Observation", "SAO 189304"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.89470021),
        dec: Angle.Degrees(-26.20322419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79582"},
        {"Hipparcos Number", "HIP 45331"},
        {"Smithsonian Astrophysical Observation", "SAO 177154"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.58498446),
        dec: Angle.Degrees(-26.20159350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222412"},
        {"Hipparcos Number", "HIP 116807"},
        {"Geneva Identification System", "GEN# +1.00222412"},
        {"Smithsonian Astrophysical Observation", "SAO 192077"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.10908879),
        dec: Angle.Degrees(-26.20092177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161387"},
        {"Hipparcos Number", "HIP 86971"},
        {"Geneva Identification System", "GEN# +1.00161387"},
        {"Smithsonian Astrophysical Observation", "SAO 185724"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.60579239),
        dec: Angle.Degrees(-26.20030793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18350"},
        {"Hipparcos Number", "HIP 13675"},
        {"Smithsonian Astrophysical Observation", "SAO 168156"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.03076973),
        dec: Angle.Degrees(-26.19978015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182797"},
        {"Hipparcos Number", "HIP 95655"},
        {"Smithsonian Astrophysical Observation", "SAO 188138"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.85336214),
        dec: Angle.Degrees(-26.19937328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165303"},
        {"Hipparcos Number", "HIP 88695"},
        {"Smithsonian Astrophysical Observation", "SAO 186279"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.60156341),
        dec: Angle.Degrees(-26.19888865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209252"},
        {"Hipparcos Number", "HIP 108803"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.62078035),
        dec: Angle.Degrees(-26.19767144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132800"},
        {"Hipparcos Number", "HIP 73532"},
        {"Smithsonian Astrophysical Observation", "SAO 183094"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.43962500),
        dec: Angle.Degrees(-26.19746063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212358"},
        {"Hipparcos Number", "HIP 110576"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.01696360),
        dec: Angle.Degrees(-26.19708119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189005"},
        {"Hipparcos Number", "HIP 98353"},
        {"Geneva Identification System", "GEN# +1.00189005"},
        {"Smithsonian Astrophysical Observation", "SAO 188778"},
        {"Wilson Evans Batten Catalogue", "WEB 17351"},
    },
    visualMagnitude: 4.84,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.73823470),
        dec: Angle.Degrees(-26.19582739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7006"},
        {"Hipparcos Number", "HIP 5472"},
        {"Fundamental Katalog 5th Edition", "FK5 2076"},
        {"Smithsonian Astrophysical Observation", "SAO 166846"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.51378234),
        dec: Angle.Degrees(-26.19371963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74539",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9538 AB"},
        {"Henry Draper", "HD 135051"},
        {"Hipparcos Number", "HIP 74539"},
        {"Geneva Identification System", "GEN# +1.00135051J"},
        {"Smithsonian Astrophysical Observation", "SAO 183285"},
        {"Wilson Evans Batten Catalogue", "WEB 12717"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.47217392),
        dec: Angle.Degrees(-26.19355939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8515"},
        {"Hipparcos Number", "HIP 6519"},
        {"Smithsonian Astrophysical Observation", "SAO 167012"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.92628375),
        dec: Angle.Degrees(-26.19188833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191863"},
        {"Hipparcos Number", "HIP 99613"},
        {"Smithsonian Astrophysical Observation", "SAO 189030"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.23324896),
        dec: Angle.Degrees(-26.19071879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170940"},
        {"Hipparcos Number", "HIP 90944"},
        {"Smithsonian Astrophysical Observation", "SAO 186953"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.26994979),
        dec: Angle.Degrees(-26.18883223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4010"},
        {"Hipparcos Number", "HIP 3335"},
        {"Geneva Identification System", "GEN# +1.00004010"},
        {"Smithsonian Astrophysical Observation", "SAO 166499"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.63521676),
        dec: Angle.Degrees(-26.18795317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151334"},
        {"Hipparcos Number", "HIP 82211"},
        {"Smithsonian Astrophysical Observation", "SAO 184645"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.93410475),
        dec: Angle.Degrees(-26.18687031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223219"},
        {"Hipparcos Number", "HIP 117358"},
        {"Smithsonian Astrophysical Observation", "SAO 192155"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.93662678),
        dec: Angle.Degrees(-26.18604612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116770"},
        {"Hipparcos Number", "HIP 65546"},
        {"Smithsonian Astrophysical Observation", "SAO 181649"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.54873930),
        dec: Angle.Degrees(-26.18557048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9391"},
        {"Smithsonian Astrophysical Observation", "SAO 167482"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.17585663),
        dec: Angle.Degrees(-26.18352846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113954",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16492 AB"},
        {"Henry Draper", "HD 217974"},
        {"Hipparcos Number", "HIP 113954"},
        {"Smithsonian Astrophysical Observation", "SAO 191629"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.15850955),
        dec: Angle.Degrees(-26.18297676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176204"},
        {"Hipparcos Number", "HIP 93303"},
        {"Smithsonian Astrophysical Observation", "SAO 187558"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.06639682),
        dec: Angle.Degrees(-26.18291367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6254"},
        {"Hipparcos Number", "HIP 4930"},
        {"Geneva Identification System", "GEN# +1.00006254"},
        {"Smithsonian Astrophysical Observation", "SAO 166771"},
        {"Wilson Evans Batten Catalogue", "WEB 983"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.81545739),
        dec: Angle.Degrees(-26.17995291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187779"},
        {"Hipparcos Number", "HIP 97828"},
        {"Geneva Identification System", "GEN# +1.00187779"},
        {"Smithsonian Astrophysical Observation", "SAO 188662"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.19319903),
        dec: Angle.Degrees(-26.17767504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78386",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9869 A"},
        {"Henry Draper", "HD 143231"},
        {"Hipparcos Number", "HIP 78386"},
        {"Smithsonian Astrophysical Observation", "SAO 184011"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.04891850),
        dec: Angle.Degrees(-26.17741582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86719"},
        {"Smithsonian Astrophysical Observation", "SAO 185653"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.78389561),
        dec: Angle.Degrees(-26.17696699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197729"},
        {"Hipparcos Number", "HIP 102498"},
        {"Smithsonian Astrophysical Observation", "SAO 189670"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.58424756),
        dec: Angle.Degrees(-26.17622028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7951"},
        {"Hipparcos Number", "HIP 6138"},
        {"Geneva Identification System", "GEN# +1.00007951"},
        {"Smithsonian Astrophysical Observation", "SAO 166950"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.68500722),
        dec: Angle.Degrees(-26.17342196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78385",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9869 C"},
        {"Hipparcos Number", "HIP 78385"},
    },
    visualMagnitude: 11.04,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.04699212),
        dec: Angle.Degrees(-26.17309874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90128",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11296 AB"},
        {"Henry Draper", "HD 168991"},
        {"Hipparcos Number", "HIP 90128"},
        {"Smithsonian Astrophysical Observation", "SAO 186752"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.88863167),
        dec: Angle.Degrees(-26.17147753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205471"},
        {"Hipparcos Number", "HIP 106654"},
        {"Geneva Identification System", "GEN# +1.00205471"},
        {"Renson", "Renson 57250"},
        {"Smithsonian Astrophysical Observation", "SAO 190478"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.04543329),
        dec: Angle.Degrees(-26.17145712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17353"},
        {"Hipparcos Number", "HIP 12927"},
        {"Smithsonian Astrophysical Observation", "SAO 168036"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.56338903),
        dec: Angle.Degrees(-26.17116987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97642",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12994 AB"},
        {"Henry Draper", "HD 187384"},
        {"Hipparcos Number", "HIP 97642"},
        {"Smithsonian Astrophysical Observation", "SAO 188620"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.67341091),
        dec: Angle.Degrees(-26.17114326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20876"},
        {"Hipparcos Number", "HIP 15616"},
        {"Smithsonian Astrophysical Observation", "SAO 168478"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.26872243),
        dec: Angle.Degrees(-26.17110023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193069"},
        {"Henry Draper 2", "HD 193069A"},
        {"Hipparcos Number", "HIP 100182"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.80969032),
        dec: Angle.Degrees(-26.16766105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181480"},
        {"Hipparcos Number", "HIP 95177"},
        {"Geneva Identification System", "GEN# +1.00181480"},
        {"Smithsonian Astrophysical Observation", "SAO 188017"},
        {"Wilson Evans Batten Catalogue", "WEB 16623"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.43414435),
        dec: Angle.Degrees(-26.16628495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81168"},
        {"Hipparcos Number", "HIP 46037"},
        {"Smithsonian Astrophysical Observation", "SAO 177379"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.84413995),
        dec: Angle.Degrees(-26.16566603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167817"},
        {"Hipparcos Number", "HIP 89673"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.50089219),
        dec: Angle.Degrees(-26.16458840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43293"},
        {"Hipparcos Number", "HIP 29603"},
        {"Smithsonian Astrophysical Observation", "SAO 171438"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.57649410),
        dec: Angle.Degrees(-26.16352724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183899"},
        {"Hipparcos Number", "HIP 96130"},
        {"Geneva Identification System", "GEN# +1.00183899"},
        {"Smithsonian Astrophysical Observation", "SAO 188259"},
        {"Wilson Evans Batten Catalogue", "WEB 16841"},
    },
    visualMagnitude: 9.80,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.18824707),
        dec: Angle.Degrees(-26.16295417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104068"},
        {"Smithsonian Astrophysical Observation", "SAO 189992"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.25952048),
        dec: Angle.Degrees(-26.16244967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1836"},
        {"Smithsonian Astrophysical Observation", "SAO 166231"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.81361204),
        dec: Angle.Degrees(-26.16203797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193690"},
        {"Hipparcos Number", "HIP 100474"},
        {"Geneva Identification System", "GEN# +1.00193690"},
        {"Smithsonian Astrophysical Observation", "SAO 189208"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.63044308),
        dec: Angle.Degrees(-26.15980206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98593"},
        {"Hipparcos Number", "HIP 55385"},
        {"Geneva Identification System", "GEN# +1.00098593"},
        {"Smithsonian Astrophysical Observation", "SAO 179784"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.11451422),
        dec: Angle.Degrees(-26.15724177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18013"},
    },
    visualMagnitude: 12.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.75551049),
        dec: Angle.Degrees(-26.15673948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49027"},
        {"Hipparcos Number", "HIP 32371"},
        {"Smithsonian Astrophysical Observation", "SAO 172276"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.35206694),
        dec: Angle.Degrees(-26.15582335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18100"},
        {"Hipparcos Number", "HIP 13489"},
        {"Geneva Identification System", "GEN# +1.00018100"},
        {"Smithsonian Astrophysical Observation", "SAO 168124"},
    },
    visualMagnitude: 8.47,
    bvColour: -0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.42003868),
        dec: Angle.Degrees(-26.15565533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113332"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.27827125),
        dec: Angle.Degrees(-26.15533037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18670"},
        {"Hipparcos Number", "HIP 13922"},
        {"Smithsonian Astrophysical Observation", "SAO 168206"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.83788960),
        dec: Angle.Degrees(-26.15476660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54446",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54446"},
        {"Geneva Identification System", "GEN# -0.02508473"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.09917860),
        dec: Angle.Degrees(-26.15433815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60861"},
        {"Hipparcos Number", "HIP 36932"},
        {"Celescope Catalog", "CEL 1940"},
        {"Geneva Identification System", "GEN# +1.00060861"},
        {"Smithsonian Astrophysical Observation", "SAO 174063"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.88570799),
        dec: Angle.Degrees(-26.15379925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217343"},
        {"Hipparcos Number", "HIP 113579"},
        {"Geneva Identification System", "GEN# +1.00217343"},
        {"Smithsonian Astrophysical Observation", "SAO 191562"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.08006668),
        dec: Angle.Degrees(-26.15335940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32890"},
        {"Hipparcos Number", "HIP 23668"},
        {"Geneva Identification System", "GEN# +1.00032890"},
        {"Smithsonian Astrophysical Observation", "SAO 170050"},
    },
    visualMagnitude: 5.71,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.31745462),
        dec: Angle.Degrees(-26.15223983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11124"},
        {"Hipparcos Number", "HIP 8444"},
        {"Smithsonian Astrophysical Observation", "SAO 167318"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.21571742),
        dec: Angle.Degrees(-26.15105188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126145"},
        {"Hipparcos Number", "HIP 70422"},
        {"Smithsonian Astrophysical Observation", "SAO 182511"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.09774333),
        dec: Angle.Degrees(-26.15094415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139926"},
        {"Hipparcos Number", "HIP 76872"},
        {"Smithsonian Astrophysical Observation", "SAO 183709"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.45473049),
        dec: Angle.Degrees(-26.14928731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193337"},
        {"Hipparcos Number", "HIP 100311"},
        {"Smithsonian Astrophysical Observation", "SAO 189174"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.16954868),
        dec: Angle.Degrees(-26.14887236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143617"},
        {"Hipparcos Number", "HIP 78563"},
        {"Smithsonian Astrophysical Observation", "SAO 184047"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.62114912),
        dec: Angle.Degrees(-26.14802178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157589"},
        {"Hipparcos Number", "HIP 85257"},
        {"Smithsonian Astrophysical Observation", "SAO 185378"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.32416342),
        dec: Angle.Degrees(-26.14604927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2924"},
        {"Smithsonian Astrophysical Observation", "SAO 166416"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.27410033),
        dec: Angle.Degrees(-26.14489315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38266"},
        {"Hipparcos Number", "HIP 26976"},
        {"Smithsonian Astrophysical Observation", "SAO 170735"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.86440029),
        dec: Angle.Degrees(-26.14436636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202153"},
        {"Hipparcos Number", "HIP 104880"},
        {"Smithsonian Astrophysical Observation", "SAO 190155"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.68300433),
        dec: Angle.Degrees(-26.14402871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127892"},
        {"Hipparcos Number", "HIP 71275"},
        {"Smithsonian Astrophysical Observation", "SAO 182671"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.65450295),
        dec: Angle.Degrees(-26.14374394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103836"},
        {"Hipparcos Number", "HIP 58293"},
        {"Geneva Identification System", "GEN# +1.00103836"},
        {"Smithsonian Astrophysical Observation", "SAO 180326"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.31882854),
        dec: Angle.Degrees(-26.14175129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -350.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 146.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177316"},
        {"Hipparcos Number", "HIP 93736"},
        {"Smithsonian Astrophysical Observation", "SAO 187650"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.29763683),
        dec: Angle.Degrees(-26.13886982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97343"},
        {"Hipparcos Number", "HIP 54704"},
        {"Geneva Identification System", "GEN# +1.00097343"},
        {"Smithsonian Astrophysical Observation", "SAO 179630"},
        {"Wilson Evans Batten Catalogue", "WEB 9875"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.00422650),
        dec: Angle.Degrees(-26.13651081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 271.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73339"},
        {"Smithsonian Astrophysical Observation", "SAO 183066"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.80465377),
        dec: Angle.Degrees(-26.13519874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71688"},
        {"Hipparcos Number", "HIP 41504"},
        {"Geneva Identification System", "GEN# +1.00071688"},
        {"Smithsonian Astrophysical Observation", "SAO 175883"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.97377647),
        dec: Angle.Degrees(-26.13294457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30858"},
        {"Hipparcos Number", "HIP 22481"},
        {"Geneva Identification System", "GEN# +1.00030858"},
        {"Smithsonian Astrophysical Observation", "SAO 169804"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.55366698),
        dec: Angle.Degrees(-26.13100588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98124"},
        {"Hipparcos Number", "HIP 55112"},
        {"Smithsonian Astrophysical Observation", "SAO 179738"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.26153065),
        dec: Angle.Degrees(-26.13098664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30951"},
        {"Hipparcos Number", "HIP 22530"},
        {"Smithsonian Astrophysical Observation", "SAO 169813"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.72482729),
        dec: Angle.Degrees(-26.12942427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106555"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.70204895),
        dec: Angle.Degrees(-26.12719107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -296.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3187"},
        {"Hipparcos Number", "HIP 2745"},
        {"Fundamental Katalog 5th Edition", "FK5 4051"},
        {"Geneva Identification System", "GEN# +1.00003187"},
        {"Smithsonian Astrophysical Observation", "SAO 166381"},
        {"Wilson Evans Batten Catalogue", "WEB 494"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.75815503),
        dec: Angle.Degrees(-26.12569193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31554",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5254 A"},
        {"Henry Draper", "HD 47185"},
        {"Hipparcos Number", "HIP 31554"},
        {"Smithsonian Astrophysical Observation", "SAO 172014"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.06924036),
        dec: Angle.Degrees(-26.12364693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71074"},
        {"Hipparcos Number", "HIP 41206"},
        {"Smithsonian Astrophysical Observation", "SAO 175765"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.13145333),
        dec: Angle.Degrees(-26.12256953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31553",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5254 B"},
        {"Hipparcos Number", "HIP 31553"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.06631060),
        dec: Angle.Degrees(-26.12196920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36892",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6195 A"},
        {"Henry Draper", "HD 60765"},
        {"Hipparcos Number", "HIP 36892"},
        {"Smithsonian Astrophysical Observation", "SAO 174050"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.77780560),
        dec: Angle.Degrees(-26.11946318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45919"},
        {"Hipparcos Number", "HIP 30903"},
        {"Smithsonian Astrophysical Observation", "SAO 171826"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.29988884),
        dec: Angle.Degrees(-26.11884750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17004"},
        {"Hipparcos Number", "HIP 12682"},
        {"Smithsonian Astrophysical Observation", "SAO 167998"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.74071137),
        dec: Angle.Degrees(-26.11881657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75721"},
        {"Hipparcos Number", "HIP 43434"},
        {"Geneva Identification System", "GEN# +1.00075721"},
        {"Smithsonian Astrophysical Observation", "SAO 176571"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.69683704),
        dec: Angle.Degrees(-26.11834546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60629"},
        {"Hipparcos Number", "HIP 36837"},
        {"Celescope Catalog", "CEL 1934"},
        {"Geneva Identification System", "GEN# +1.00060629"},
        {"Smithsonian Astrophysical Observation", "SAO 174028"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.62022447),
        dec: Angle.Degrees(-26.11678230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50538"},
        {"Hipparcos Number", "HIP 33008"},
        {"Smithsonian Astrophysical Observation", "SAO 172494"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.17164707),
        dec: Angle.Degrees(-26.11660886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21078"},
        {"Hipparcos Number", "HIP 15769"},
        {"Smithsonian Astrophysical Observation", "SAO 168502"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.80111018),
        dec: Angle.Degrees(-26.11653147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119752"},
        {"Hipparcos Number", "HIP 67143"},
        {"Geneva Identification System", "GEN# +1.00119752"},
        {"Smithsonian Astrophysical Observation", "SAO 181931"},
        {"Wilson Evans Batten Catalogue", "WEB 11820"},
    },
    visualMagnitude: 5.81,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.40390701),
        dec: Angle.Degrees(-26.11598461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88937",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11096 AD"},
        {"Henry Draper", "HD 165896"},
        {"Hipparcos Number", "HIP 88937"},
        {"Geneva Identification System", "GEN# +1.00165896"},
        {"Smithsonian Astrophysical Observation", "SAO 186362"},
        {"Wilson Evans Batten Catalogue", "WEB 15084"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.31286537),
        dec: Angle.Degrees(-26.11596048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -338.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57616"},
        {"Hipparcos Number", "HIP 35625"},
        {"Celescope Catalog", "CEL 1798"},
        {"Geneva Identification System", "GEN# +1.00057616"},
        {"Smithsonian Astrophysical Observation", "SAO 173528"},
    },
    visualMagnitude: 8.70,
    bvColour: -0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.26377590),
        dec: Angle.Degrees(-26.11551044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117612"},
        {"Hipparcos Number", "HIP 65998"},
        {"Geneva Identification System", "GEN# +1.00117612"},
        {"Smithsonian Astrophysical Observation", "SAO 181727"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.96506600),
        dec: Angle.Degrees(-26.11452680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78265",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Fang"},
        {"Aitken", "ADS 9862 A"},
        {"Henry Draper", "HD 143018"},
        {"Hipparcos Number", "HIP 78265"},
        {"Celescope Catalog", "CEL 4409"},
        {"Fundamental Katalog 5th Edition", "FK5 592"},
        {"Geneva Identification System", "GEN# +1.00143018A"},
        {"Smithsonian Astrophysical Observation", "SAO 183987"},
        {"Wilson Evans Batten Catalogue", "WEB 13235"},
    },
    visualMagnitude: 2.89,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.71300283),
        dec: Angle.Degrees(-26.11404280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186970"},
        {"Hipparcos Number", "HIP 97448"},
        {"Geneva Identification System", "GEN# +1.00186970"},
        {"Smithsonian Astrophysical Observation", "SAO 188587"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.09727095),
        dec: Angle.Degrees(-26.11341599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95114"},
        {"Hipparcos Number", "HIP 53658"},
        {"Smithsonian Astrophysical Observation", "SAO 179390"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.66840837),
        dec: Angle.Degrees(-26.11162171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72509"},
        {"Geneva Identification System", "GEN# -0.02510553B"},
    },
    visualMagnitude: 12.07,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.38618849),
        dec: Angle.Degrees(-26.11117761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1421.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217004"},
        {"Hipparcos Number", "HIP 113386"},
        {"Geneva Identification System", "GEN# +1.00217004J"},
        {"Smithsonian Astrophysical Observation", "SAO 191529"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.45037063),
        dec: Angle.Degrees(-26.10756515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -280.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166128"},
        {"Hipparcos Number", "HIP 89032"},
        {"Smithsonian Astrophysical Observation", "SAO 186392"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.56201717),
        dec: Angle.Degrees(-26.10755534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133651"},
        {"Hipparcos Number", "HIP 73919"},
        {"Smithsonian Astrophysical Observation", "SAO 183172"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.58955824),
        dec: Angle.Degrees(-26.10729296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107181"},
        {"Hipparcos Number", "HIP 60096"},
        {"Geneva Identification System", "GEN# +1.00107181"},
        {"Smithsonian Astrophysical Observation", "SAO 180680"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.86376409),
        dec: Angle.Degrees(-26.10712516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10446"},
        {"Hipparcos Number", "HIP 7876"},
        {"Smithsonian Astrophysical Observation", "SAO 167232"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.32838204),
        dec: Angle.Degrees(-26.10678251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72511",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72511"},
        {"Geneva Identification System", "GEN# -0.02510553A"},
    },
    visualMagnitude: 11.72,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.38963876),
        dec: Angle.Degrees(-26.10603370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1389.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 135.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203816"},
        {"Hipparcos Number", "HIP 105757"},
        {"Smithsonian Astrophysical Observation", "SAO 190312"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.29715622),
        dec: Angle.Degrees(-26.10463174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45479"},
        {"Hipparcos Number", "HIP 30657"},
        {"Smithsonian Astrophysical Observation", "SAO 171751"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.63686310),
        dec: Angle.Degrees(-26.10400010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7474"},
        {"Smithsonian Astrophysical Observation", "SAO 167171"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.06349697),
        dec: Angle.Degrees(-26.10394897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11076"},
        {"Hipparcos Number", "HIP 8395"},
        {"Smithsonian Astrophysical Observation", "SAO 167308"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.08026690),
        dec: Angle.Degrees(-26.10074207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20293"},
        {"Hipparcos Number", "HIP 15125"},
        {"Geneva Identification System", "GEN# +1.00020293"},
        {"Renson", "Renson 5050"},
        {"Smithsonian Astrophysical Observation", "SAO 168406"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.75115546),
        dec: Angle.Degrees(-26.10040647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11582"},
        {"Geneva Identification System", "GEN# -0.02600892"},
        {"Wilson Evans Batten Catalogue", "WEB 2414"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.31375818),
        dec: Angle.Degrees(-26.09878140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1136",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1136"},
        {"Smithsonian Astrophysical Observation", "SAO 166134"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.55035668),
        dec: Angle.Degrees(-26.09743369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91134"},
        {"Hipparcos Number", "HIP 51480"},
        {"Geneva Identification System", "GEN# +1.00091134"},
        {"Renson", "Renson 26210"},
        {"Smithsonian Astrophysical Observation", "SAO 178918"},
    },
    visualMagnitude: 8.42,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.72616651),
        dec: Angle.Degrees(-26.09575655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52597"},
        {"Hipparcos Number", "HIP 33769"},
        {"Celescope Catalog", "CEL 1503"},
        {"Geneva Identification System", "GEN# +1.00052597"},
        {"Smithsonian Astrophysical Observation", "SAO 172753"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.19808085),
        dec: Angle.Degrees(-26.09344875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17537"},
        {"Hipparcos Number", "HIP 13067"},
        {"Geneva Identification System", "GEN# +1.00017537"},
        {"Smithsonian Astrophysical Observation", "SAO 168060"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.99388098),
        dec: Angle.Degrees(-26.09335448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18374"},
        {"Hipparcos Number", "HIP 13695"},
        {"Smithsonian Astrophysical Observation", "SAO 168162"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.09474911),
        dec: Angle.Degrees(-26.09181183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2649",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 466 A"},
        {"Henry Draper", "HD 3045"},
        {"Hipparcos Number", "HIP 2649"},
        {"Smithsonian Astrophysical Observation", "SAO 166362"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.40144995),
        dec: Angle.Degrees(-26.09180422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82425",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10226 AB"},
        {"Henry Draper", "HD 151800"},
        {"Hipparcos Number", "HIP 82425"},
        {"Smithsonian Astrophysical Observation", "SAO 184698"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.67672573),
        dec: Angle.Degrees(-26.08892662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130259"},
        {"Hipparcos Number", "HIP 72357"},
        {"Fundamental Katalog 5th Edition", "FK5 1385"},
        {"Geneva Identification System", "GEN# +1.00130259"},
        {"Smithsonian Astrophysical Observation", "SAO 182882"},
        {"Wilson Evans Batten Catalogue", "WEB 12441"},
    },
    visualMagnitude: 5.23,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.93658830),
        dec: Angle.Degrees(-26.08747990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195247"},
        {"Hipparcos Number", "HIP 101217"},
        {"Smithsonian Astrophysical Observation", "SAO 189379"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.75729660),
        dec: Angle.Degrees(-26.08661901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168525"},
        {"Hipparcos Number", "HIP 89954"},
        {"Smithsonian Astrophysical Observation", "SAO 186687"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.30169213),
        dec: Angle.Degrees(-26.08512440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31310"},
        {"Hipparcos Number", "HIP 22749"},
        {"Smithsonian Astrophysical Observation", "SAO 169859"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.40598534),
        dec: Angle.Degrees(-26.08161438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29791"},
        {"Hipparcos Number", "HIP 21773"},
        {"Smithsonian Astrophysical Observation", "SAO 169659"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.14409657),
        dec: Angle.Degrees(-26.07820443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45644"},
        {"Hipparcos Number", "HIP 30739"},
        {"Smithsonian Astrophysical Observation", "SAO 171786"},
    },
    visualMagnitude: 8.83,
    bvColour: -0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.88247000),
        dec: Angle.Degrees(-26.07751720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213296"},
        {"Hipparcos Number", "HIP 111138"},
        {"Fundamental Katalog 5th Edition", "FK5 5986"},
        {"Geneva Identification System", "GEN# +1.00213296"},
        {"Smithsonian Astrophysical Observation", "SAO 191196"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.72394611),
        dec: Angle.Degrees(-26.07356883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73363"},
        {"Hipparcos Number", "HIP 42269"},
        {"Smithsonian Astrophysical Observation", "SAO 176173"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.28527587),
        dec: Angle.Degrees(-26.07311360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66377"},
        {"Hipparcos Number", "HIP 39316"},
        {"Smithsonian Astrophysical Observation", "SAO 175033"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.57617215),
        dec: Angle.Degrees(-26.06502344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32685",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5492 AB"},
        {"Henry Draper", "HD 49790"},
        {"Hipparcos Number", "HIP 32685"},
        {"Smithsonian Astrophysical Observation", "SAO 172373"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.27782090),
        dec: Angle.Degrees(-26.06344035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223861"},
        {"Hipparcos Number", "HIP 117786"},
        {"Smithsonian Astrophysical Observation", "SAO 192216"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.29628390),
        dec: Angle.Degrees(-26.06038041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153069"},
        {"Hipparcos Number", "HIP 83055"},
        {"Smithsonian Astrophysical Observation", "SAO 184849"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.56953005),
        dec: Angle.Degrees(-26.05897987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117321"},
        {"Hipparcos Number", "HIP 65850"},
        {"Smithsonian Astrophysical Observation", "SAO 181700"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.48014032),
        dec: Angle.Degrees(-26.05877493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90094"},
        {"Hipparcos Number", "HIP 50890"},
        {"Geneva Identification System", "GEN# +1.00090094"},
        {"Smithsonian Astrophysical Observation", "SAO 178761"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.87515062),
        dec: Angle.Degrees(-26.05634882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127950"},
        {"Hipparcos Number", "HIP 71304"},
        {"Smithsonian Astrophysical Observation", "SAO 182675"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.72991286),
        dec: Angle.Degrees(-26.05560430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214193"},
        {"Hipparcos Number", "HIP 111641"},
        {"Smithsonian Astrophysical Observation", "SAO 191268"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.24445354),
        dec: Angle.Degrees(-26.05347050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26486"},
        {"Hipparcos Number", "HIP 19490"},
        {"Fundamental Katalog 5th Edition", "FK5 4379"},
        {"Geneva Identification System", "GEN# +1.00026486"},
        {"Smithsonian Astrophysical Observation", "SAO 169193"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.62403985),
        dec: Angle.Degrees(-26.05175835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42889"},
        {"Hipparcos Number", "HIP 29437"},
        {"Smithsonian Astrophysical Observation", "SAO 171378"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.03123631),
        dec: Angle.Degrees(-26.04991794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3760"},
        {"Hipparcos Number", "HIP 3157"},
        {"Smithsonian Astrophysical Observation", "SAO 166469"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.03736576),
        dec: Angle.Degrees(-26.04932392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9775"},
        {"Smithsonian Astrophysical Observation", "SAO 167546"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.42816956),
        dec: Angle.Degrees(-26.04913645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224607"},
        {"Hipparcos Number", "HIP 118261"},
        {"Smithsonian Astrophysical Observation", "SAO 192290"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.80770183),
        dec: Angle.Degrees(-26.04877698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -232.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93410"},
        {"Hipparcos Number", "HIP 52721"},
        {"Fundamental Katalog 5th Edition", "FK5 1280"},
        {"Geneva Identification System", "GEN# +1.00093410"},
        {"Smithsonian Astrophysical Observation", "SAO 179217"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.67848136),
        dec: Angle.Degrees(-26.04827287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102638"},
        {"Hipparcos Number", "HIP 57623"},
        {"Smithsonian Astrophysical Observation", "SAO 180209"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.22213468),
        dec: Angle.Degrees(-26.04806877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61031"},
        {"Geneva Identification System", "GEN# -0.02509286"},
        {"Smithsonian Astrophysical Observation", "SAO 180855"},
        {"Wilson Evans Batten Catalogue", "WEB 10865"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.62719541),
        dec: Angle.Degrees(-26.04756759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92314",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11691 AB"},
        {"Henry Draper", "HD 173918"},
        {"Hipparcos Number", "HIP 92314"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.22466506),
        dec: Angle.Degrees(-26.04697725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92698"},
        {"Hipparcos Number", "HIP 52344"},
        {"Smithsonian Astrophysical Observation", "SAO 179128"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.46925158),
        dec: Angle.Degrees(-26.04663834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189829"},
        {"Hipparcos Number", "HIP 98715"},
        {"Smithsonian Astrophysical Observation", "SAO 188849"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.75384894),
        dec: Angle.Degrees(-26.04159693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31486",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5243 AB"},
        {"Henry Draper", "HD 47041"},
        {"Hipparcos Number", "HIP 31486"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.90718446),
        dec: Angle.Degrees(-26.04152119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17753"},
        {"Hipparcos Number", "HIP 13220"},
        {"Smithsonian Astrophysical Observation", "SAO 168084"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.54778528),
        dec: Angle.Degrees(-26.04057679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30304"},
        {"Hipparcos Number", "HIP 22097"},
        {"Smithsonian Astrophysical Observation", "SAO 169736"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.32740402),
        dec: Angle.Degrees(-26.03910774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72641"},
        {"Hipparcos Number", "HIP 41959"},
        {"Smithsonian Astrophysical Observation", "SAO 176065"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.29221167),
        dec: Angle.Degrees(-26.03875931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21163"},
        {"Hipparcos Number", "HIP 15842"},
        {"Geneva Identification System", "GEN# +1.00021163"},
        {"Smithsonian Astrophysical Observation", "SAO 168515"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.01605849),
        dec: Angle.Degrees(-26.03657209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166194"},
        {"Hipparcos Number", "HIP 89049"},
        {"Smithsonian Astrophysical Observation", "SAO 186403"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.63979740),
        dec: Angle.Degrees(-26.03289824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24070"},
        {"Hipparcos Number", "HIP 17838"},
        {"Geneva Identification System", "GEN# +1.00024070"},
        {"Smithsonian Astrophysical Observation", "SAO 168858"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.25112017),
        dec: Angle.Degrees(-26.03255032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99348"},
        {"Hipparcos Number", "HIP 55788"},
        {"Smithsonian Astrophysical Observation", "SAO 179871"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.45333356),
        dec: Angle.Degrees(-26.02930977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46752"},
        {"Hipparcos Number", "HIP 31320"},
        {"Geneva Identification System", "GEN# +1.00046752"},
        {"Smithsonian Astrophysical Observation", "SAO 171960"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.52163206),
        dec: Angle.Degrees(-26.02824064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183924"},
        {"Hipparcos Number", "HIP 96139"},
        {"Geneva Identification System", "GEN# +1.00183924"},
        {"Smithsonian Astrophysical Observation", "SAO 188263"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.22053304),
        dec: Angle.Degrees(-26.02811361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30904"},
        {"Hipparcos Number", "HIP 22502"},
        {"Smithsonian Astrophysical Observation", "SAO 169807"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.62038825),
        dec: Angle.Degrees(-26.02788445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207832"},
        {"Hipparcos Number", "HIP 107985"},
        {"Geneva Identification System", "GEN# +1.00207832"},
        {"Smithsonian Astrophysical Observation", "SAO 190699"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.15081919),
        dec: Angle.Degrees(-26.02621177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170331"},
        {"Hipparcos Number", "HIP 90655"},
        {"Geneva Identification System", "GEN# +1.00170331"},
        {"Smithsonian Astrophysical Observation", "SAO 186884"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.46649751),
        dec: Angle.Degrees(-26.02516397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43864"},
        {"Hipparcos Number", "HIP 29877"},
        {"Smithsonian Astrophysical Observation", "SAO 171517"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.37103206),
        dec: Angle.Degrees(-26.02376466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 942"},
        {"Hipparcos Number", "HIP 1096"},
        {"Geneva Identification System", "GEN# +1.00000942"},
        {"Smithsonian Astrophysical Observation", "SAO 166130"},
    },
    visualMagnitude: 5.94,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.42591849),
        dec: Angle.Degrees(-26.02215399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26388"},
        {"Hipparcos Number", "HIP 19418"},
        {"Smithsonian Astrophysical Observation", "SAO 169179"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.38215405),
        dec: Angle.Degrees(-26.02076122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166467"},
        {"Hipparcos Number", "HIP 89165"},
        {"Smithsonian Astrophysical Observation", "SAO 186441"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.94892981),
        dec: Angle.Degrees(-26.02021258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109746"},
        {"Hipparcos Number", "HIP 61590"},
        {"Smithsonian Astrophysical Observation", "SAO 180959"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.30898551),
        dec: Angle.Degrees(-26.01863929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174358"},
        {"Hipparcos Number", "HIP 92511"},
        {"Smithsonian Astrophysical Observation", "SAO 187356"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.79787143),
        dec: Angle.Degrees(-26.01855615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82235"},
        {"Hipparcos Number", "HIP 46603"},
        {"Geneva Identification System", "GEN# +1.00082235"},
        {"Smithsonian Astrophysical Observation", "SAO 177559"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.54823749),
        dec: Angle.Degrees(-26.01439560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107893"},
        {"Hipparcos Number", "HIP 60491"},
        {"Smithsonian Astrophysical Observation", "SAO 180755"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.01659424),
        dec: Angle.Degrees(-26.01399673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126973"},
        {"Hipparcos Number", "HIP 70866"},
        {"Smithsonian Astrophysical Observation", "SAO 182593"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.37975283),
        dec: Angle.Degrees(-26.01335047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129544"},
        {"Hipparcos Number", "HIP 72018"},
        {"Smithsonian Astrophysical Observation", "SAO 182808"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.95677200),
        dec: Angle.Degrees(-26.01259837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148841"},
        {"Hipparcos Number", "HIP 80959"},
        {"Geneva Identification System", "GEN# +1.00148841"},
        {"Smithsonian Astrophysical Observation", "SAO 184444"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.97466844),
        dec: Angle.Degrees(-26.01136956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58011"},
        {"Hipparcos Number", "HIP 35769"},
        {"Geneva Identification System", "GEN# +1.00058011"},
        {"Smithsonian Astrophysical Observation", "SAO 173581"},
        {"Wilson Evans Batten Catalogue", "WEB 7130"},
    },
    visualMagnitude: 7.15,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.68048715),
        dec: Angle.Degrees(-26.01135120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40459"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.91645411),
        dec: Angle.Degrees(-26.00941920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113746"},
        {"Hipparcos Number", "HIP 63934"},
        {"Smithsonian Astrophysical Observation", "SAO 181385"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.54374926),
        dec: Angle.Degrees(-26.00570195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176514"},
        {"Hipparcos Number", "HIP 93430"},
        {"Smithsonian Astrophysical Observation", "SAO 187583"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.42322143),
        dec: Angle.Degrees(-26.00554321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142288"},
        {"Hipparcos Number", "HIP 77908"},
        {"Geneva Identification System", "GEN# +1.00142288"},
        {"Smithsonian Astrophysical Observation", "SAO 183913"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.66074350),
        dec: Angle.Degrees(-26.00442587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -229.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196947"},
        {"Hipparcos Number", "HIP 102094"},
        {"Geneva Identification System", "GEN# +1.00196947"},
        {"Smithsonian Astrophysical Observation", "SAO 189575"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.35106663),
        dec: Angle.Degrees(-25.99985039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69139"},
        {"Hipparcos Number", "HIP 40381"},
        {"Smithsonian Astrophysical Observation", "SAO 175439"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.66591915),
        dec: Angle.Degrees(-25.99961551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121758"},
        {"Hipparcos Number", "HIP 68224"},
        {"Smithsonian Astrophysical Observation", "SAO 182126"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.49523972),
        dec: Angle.Degrees(-25.99808989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206438"},
        {"Hipparcos Number", "HIP 107204"},
        {"Geneva Identification System", "GEN# +1.00206438"},
        {"Smithsonian Astrophysical Observation", "SAO 190570"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.70332122),
        dec: Angle.Degrees(-25.99727419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97111"},
        {"Hipparcos Number", "HIP 54605"},
        {"Geneva Identification System", "GEN# +1.00097111"},
        {"Smithsonian Astrophysical Observation", "SAO 179616"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.63257302),
        dec: Angle.Degrees(-25.99593721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68020"},
    },
    visualMagnitude: 12.06,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.93432522),
        dec: Angle.Degrees(-25.99584654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -211.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 166.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31184"},
        {"Hipparcos Number", "HIP 22668"},
        {"Smithsonian Astrophysical Observation", "SAO 169835"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.14500425),
        dec: Angle.Degrees(-25.99451709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111115"},
        {"Hipparcos Number", "HIP 62392"},
        {"Smithsonian Astrophysical Observation", "SAO 181097"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.80306663),
        dec: Angle.Degrees(-25.99288603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28426"},
        {"Hipparcos Number", "HIP 20846"},
        {"Smithsonian Astrophysical Observation", "SAO 169481"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.01326161),
        dec: Angle.Degrees(-25.99230950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96941"},
        {"Hipparcos Number", "HIP 54530"},
        {"Geneva Identification System", "GEN# +1.00096941"},
        {"Smithsonian Astrophysical Observation", "SAO 179592"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.37472449),
        dec: Angle.Degrees(-25.99058751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 229.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76946"},
        {"Smithsonian Astrophysical Observation", "SAO 183720"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.67306106),
        dec: Angle.Degrees(-25.99044994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136295"},
        {"Hipparcos Number", "HIP 75092"},
        {"Fundamental Katalog 5th Edition", "FK5 5360"},
        {"Smithsonian Astrophysical Observation", "SAO 183392"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.17266292),
        dec: Angle.Degrees(-25.99001387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141063"},
        {"Hipparcos Number", "HIP 77394"},
        {"Geneva Identification System", "GEN# +1.00141063"},
        {"Smithsonian Astrophysical Observation", "SAO 183797"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.98510162),
        dec: Angle.Degrees(-25.98693148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108095"},
        {"Hipparcos Number", "HIP 60598"},
        {"Geneva Identification System", "GEN# +1.00108095"},
        {"Smithsonian Astrophysical Observation", "SAO 180783"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.30900104),
        dec: Angle.Degrees(-25.98655355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35323",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5966 A"},
        {"Henry Draper", "HD 56875"},
        {"Hipparcos Number", "HIP 35323"},
        {"Smithsonian Astrophysical Observation", "SAO 173409"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.44581320),
        dec: Angle.Degrees(-25.98574111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20044"},
        {"Smithsonian Astrophysical Observation", "SAO 169314"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.47743799),
        dec: Angle.Degrees(-25.97778794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42955",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6984 AB"},
        {"Henry Draper", "HD 74819"},
        {"Hipparcos Number", "HIP 42955"},
        {"Smithsonian Astrophysical Observation", "SAO 176426"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.34057747),
        dec: Angle.Degrees(-25.97602596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23294"},
        {"Hipparcos Number", "HIP 17367"},
        {"Smithsonian Astrophysical Observation", "SAO 168767"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.77876052),
        dec: Angle.Degrees(-25.97583429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49806",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49806"},
        {"Geneva Identification System", "GEN# -0.02507802"},
    },
    visualMagnitude: 10.81,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.49961435),
        dec: Angle.Degrees(-25.97514733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -279.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79641"},
        {"Hipparcos Number", "HIP 45355"},
        {"Smithsonian Astrophysical Observation", "SAO 177159"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.64199412),
        dec: Angle.Degrees(-25.97290381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160547"},
        {"Hipparcos Number", "HIP 86583"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.41526167),
        dec: Angle.Degrees(-25.97232607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29217"},
        {"Hipparcos Number", "HIP 21364"},
        {"Smithsonian Astrophysical Observation", "SAO 169587"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.75889646),
        dec: Angle.Degrees(-25.97196277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192814"},
        {"Hipparcos Number", "HIP 100038"},
        {"Smithsonian Astrophysical Observation", "SAO 189109"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.43527433),
        dec: Angle.Degrees(-25.96933653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211085"},
        {"Hipparcos Number", "HIP 109870"},
        {"Geneva Identification System", "GEN# +1.00211085"},
        {"Smithsonian Astrophysical Observation", "SAO 190999"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.79520105),
        dec: Angle.Degrees(-25.96700470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80874"},
        {"Hipparcos Number", "HIP 45902"},
        {"Fundamental Katalog 5th Edition", "FK5 1243"},
        {"Geneva Identification System", "GEN# +1.00080874"},
        {"Smithsonian Astrophysical Observation", "SAO 177322"},
        {"Wilson Evans Batten Catalogue", "WEB 8706"},
    },
    visualMagnitude: 4.71,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.37332838),
        dec: Angle.Degrees(-25.96541642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87661",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10870 AB"},
        {"Henry Draper", "HD 162871"},
        {"Hipparcos Number", "HIP 87661"},
        {"Smithsonian Astrophysical Observation", "SAO 185915"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.57644672),
        dec: Angle.Degrees(-25.96213483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83214"},
        {"Hipparcos Number", "HIP 47125"},
        {"Smithsonian Astrophysical Observation", "SAO 177723"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.04328075),
        dec: Angle.Degrees(-25.96204013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102435"},
        {"Hipparcos Number", "HIP 57515"},
        {"Renson", "Renson 29526"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.83312000),
        dec: Angle.Degrees(-25.96149115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123218"},
        {"Hipparcos Number", "HIP 68953"},
        {"Geneva Identification System", "GEN# +1.00123218"},
        {"Renson", "Renson 35325"},
        {"Smithsonian Astrophysical Observation", "SAO 182251"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.72631609),
        dec: Angle.Degrees(-25.95824537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84314"},
        {"Hipparcos Number", "HIP 47732"},
        {"Smithsonian Astrophysical Observation", "SAO 177902"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.95082878),
        dec: Angle.Degrees(-25.95813991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -234.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27509"},
        {"Hipparcos Number", "HIP 20185"},
        {"Geneva Identification System", "GEN# +1.00027509"},
        {"Smithsonian Astrophysical Observation", "SAO 169340"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.89349249),
        dec: Angle.Degrees(-25.95676110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114052"},
    },
    visualMagnitude: 11.23,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.46061432),
        dec: Angle.Degrees(-25.95617984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23112"},
        {"Smithsonian Astrophysical Observation", "SAO 169931"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.59595988),
        dec: Angle.Degrees(-25.95127560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52698"},
        {"Hipparcos Number", "HIP 33817"},
        {"Geneva Identification System", "GEN# +1.00052698"},
        {"Smithsonian Astrophysical Observation", "SAO 172768"},
        {"Wilson Evans Batten Catalogue", "WEB 6789"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.30669354),
        dec: Angle.Degrees(-25.94881574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14412"},
        {"Hipparcos Number", "HIP 10798"},
        {"Cincinnati Publication", "Ci 20 166"},
        {"Geneva Identification System", "GEN# +1.00014412"},
        {"Smithsonian Astrophysical Observation", "SAO 167697"},
        {"Wilson Evans Batten Catalogue", "WEB 2274"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.74435827),
        dec: Angle.Degrees(-25.94676773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 444.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157864"},
        {"Hipparcos Number", "HIP 85391"},
        {"Geneva Identification System", "GEN# +1.00157864"},
        {"Smithsonian Astrophysical Observation", "SAO 185406"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.73043254),
        dec: Angle.Degrees(-25.94339733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39533"},
        {"Hipparcos Number", "HIP 27712"},
        {"Fundamental Katalog 5th Edition", "FK5 2445"},
        {"Geneva Identification System", "GEN# +1.00039533"},
        {"Smithsonian Astrophysical Observation", "SAO 170946"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.03149697),
        dec: Angle.Degrees(-25.94333887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219793"},
        {"Hipparcos Number", "HIP 115107"},
        {"Smithsonian Astrophysical Observation", "SAO 191813"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.71544603),
        dec: Angle.Degrees(-25.94285670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50855"},
        {"Hipparcos Number", "HIP 33125"},
        {"Renson", "Renson 13986"},
    },
    visualMagnitude: 10.13,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.47784664),
        dec: Angle.Degrees(-25.94274023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55522"},
        {"Hipparcos Number", "HIP 34798"},
        {"Celescope Catalog", "CEL 1668"},
        {"Geneva Identification System", "GEN# +1.00055522"},
        {"Renson", "Renson 15094"},
        {"Smithsonian Astrophysical Observation", "SAO 173193"},
        {"Wilson Evans Batten Catalogue", "WEB 6955"},
    },
    visualMagnitude: 5.91,
    bvColour: -0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.05090950),
        dec: Angle.Degrees(-25.94260947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106007"},
        {"Hipparcos Number", "HIP 59482"},
        {"Fundamental Katalog 5th Edition", "FK5 5081"},
        {"Smithsonian Astrophysical Observation", "SAO 180556"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.99594234),
        dec: Angle.Degrees(-25.94146509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38070",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6384 A"},
        {"Henry Draper", "HD 63462"},
        {"Hipparcos Number", "HIP 38070"},
        {"Geneva Identification System", "GEN# +1.00063462"},
        {"Smithsonian Astrophysical Observation", "SAO 174558"},
        {"Wilson Evans Batten Catalogue", "WEB 7506"},
    },
    visualMagnitude: 4.40,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.02156206),
        dec: Angle.Degrees(-25.93718054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1616"},
        {"Smithsonian Astrophysical Observation", "SAO 166195"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.05503762),
        dec: Angle.Degrees(-25.93660985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8912"},
        {"Hipparcos Number", "HIP 6795"},
        {"Geneva Identification System", "GEN# +1.00008912"},
        {"Smithsonian Astrophysical Observation", "SAO 167057"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.86346004),
        dec: Angle.Degrees(-25.93656338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142540"},
        {"Hipparcos Number", "HIP 78041"},
        {"Smithsonian Astrophysical Observation", "SAO 183942"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.02133511),
        dec: Angle.Degrees(-25.93572549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220645"},
        {"Hipparcos Number", "HIP 115642"},
        {"Smithsonian Astrophysical Observation", "SAO 191893"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.39823137),
        dec: Angle.Degrees(-25.93549160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167980"},
        {"Hipparcos Number", "HIP 89732"},
        {"Smithsonian Astrophysical Observation", "SAO 186628"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.67487782),
        dec: Angle.Degrees(-25.93525897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46710"},
    },
    visualMagnitude: 10.05,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.83010991),
        dec: Angle.Degrees(-25.93380989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18276"},
        {"Hipparcos Number", "HIP 13613"},
        {"Smithsonian Astrophysical Observation", "SAO 168148"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.85339469),
        dec: Angle.Degrees(-25.93360373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191052"},
        {"Hipparcos Number", "HIP 99254"},
        {"Smithsonian Astrophysical Observation", "SAO 188951"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.21449359),
        dec: Angle.Degrees(-25.93270212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95904"},
        {"Hipparcos Number", "HIP 54054"},
        {"Smithsonian Astrophysical Observation", "SAO 179485"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.91718802),
        dec: Angle.Degrees(-25.93269570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85859"},
        {"Hipparcos Number", "HIP 48559"},
        {"Fundamental Katalog 5th Edition", "FK5 2792"},
        {"Geneva Identification System", "GEN# +1.00085859"},
        {"Smithsonian Astrophysical Observation", "SAO 178158"},
        {"Wilson Evans Batten Catalogue", "WEB 9043"},
    },
    visualMagnitude: 4.87,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.55182725),
        dec: Angle.Degrees(-25.93248205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -183.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64922"},
        {"Hipparcos Number", "HIP 38692"},
        {"Geneva Identification System", "GEN# +4.35090062"},
        {"Smithsonian Astrophysical Observation", "SAO 174799"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.82640221),
        dec: Angle.Degrees(-25.93197452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114411"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.56366641),
        dec: Angle.Degrees(-25.93136597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 716.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18045",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2821 A"},
        {"Henry Draper", "HD 24339"},
        {"Hipparcos Number", "HIP 18045"},
        {"Geneva Identification System", "GEN# +1.00024339"},
        {"Wilson Evans Batten Catalogue", "WEB 3479"},
    },
    visualMagnitude: 11.20,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)51, 25.0100),
        dec: Angle.DegreesMinutesSeconds((int)-25, (int)55, 45.000)
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
    primaryId: "HIP 24860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34912"},
        {"Hipparcos Number", "HIP 24860"},
        {"Geneva Identification System", "GEN# +1.00034912"},
        {"Smithsonian Astrophysical Observation", "SAO 170319"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.94306138),
        dec: Angle.Degrees(-25.92770750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24797"},
        {"Hipparcos Number", "HIP 18363"},
        {"Smithsonian Astrophysical Observation", "SAO 168960"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.89901789),
        dec: Angle.Degrees(-25.92728333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36125"},
        {"Geneva Identification System", "GEN# -0.02504523"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.61769570),
        dec: Angle.Degrees(-25.92679124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56281"},
        {"Hipparcos Number", "HIP 35089"},
        {"Celescope Catalog", "CEL 1717"},
        {"Smithsonian Astrophysical Observation", "SAO 173308"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.84951701),
        dec: Angle.Degrees(-25.92556506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155772"},
        {"Hipparcos Number", "HIP 84356"},
        {"Smithsonian Astrophysical Observation", "SAO 185188"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.69056526),
        dec: Angle.Degrees(-25.92389825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59616"},
    },
    visualMagnitude: 11.46,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.38642138),
        dec: Angle.Degrees(-25.92267440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 267.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -345.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4124"},
        {"Hipparcos Number", "HIP 3411"},
        {"Geneva Identification System", "GEN# +1.00004124"},
        {"Smithsonian Astrophysical Observation", "SAO 166514"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.85527884),
        dec: Angle.Degrees(-25.92243072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9892"},
        {"Hipparcos Number", "HIP 7468"},
        {"Geneva Identification System", "GEN# +1.00009892"},
        {"Smithsonian Astrophysical Observation", "SAO 167167"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.04483793),
        dec: Angle.Degrees(-25.92164979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30149"},
        {"Hipparcos Number", "HIP 22016"},
        {"Geneva Identification System", "GEN# +1.00030149"},
        {"Smithsonian Astrophysical Observation", "SAO 169707"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.00836275),
        dec: Angle.Degrees(-25.91882462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48185"},
        {"Hipparcos Number", "HIP 31986"},
        {"Smithsonian Astrophysical Observation", "SAO 172154"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.26132648),
        dec: Angle.Degrees(-25.91729437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1389"},
        {"Hipparcos Number", "HIP 1440"},
        {"Geneva Identification System", "GEN# +1.00001389"},
        {"Smithsonian Astrophysical Observation", "SAO 166171"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.48485951),
        dec: Angle.Degrees(-25.91663038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169636"},
        {"Hipparcos Number", "HIP 90396"},
        {"Smithsonian Astrophysical Observation", "SAO 186818"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.66540034),
        dec: Angle.Degrees(-25.91647338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164680"},
        {"Hipparcos Number", "HIP 88440"},
        {"Smithsonian Astrophysical Observation", "SAO 186178"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.84168190),
        dec: Angle.Degrees(-25.91625160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23616"},
        {"Hipparcos Number", "HIP 17553"},
        {"Fundamental Katalog 5th Edition", "FK5 4342"},
        {"Smithsonian Astrophysical Observation", "SAO 168809"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.38807811),
        dec: Angle.Degrees(-25.91547727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13979"},
        {"Hipparcos Number", "HIP 10497"},
        {"Geneva Identification System", "GEN# +1.00013979"},
        {"Smithsonian Astrophysical Observation", "SAO 167660"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.83680965),
        dec: Angle.Degrees(-25.91512341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 337"},
        {"Geneva Identification System", "GEN# -0.02616890"},
        {"Smithsonian Astrophysical Observation", "SAO 166028"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.06725539),
        dec: Angle.Degrees(-25.91498946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215782"},
        {"Hipparcos Number", "HIP 112567"},
        {"Fundamental Katalog 5th Edition", "FK5 3824"},
        {"Geneva Identification System", "GEN# +1.00215782"},
        {"Smithsonian Astrophysical Observation", "SAO 191412"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.98388582),
        dec: Angle.Degrees(-25.91174758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104882",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14770 AB"},
        {"Henry Draper", "HD 202152"},
        {"Hipparcos Number", "HIP 104882"},
        {"Renson", "Renson 56360"},
        {"Smithsonian Astrophysical Observation", "SAO 190156"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.68945397),
        dec: Angle.Degrees(-25.91125869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120414"},
    },
    visualMagnitude: 10.58,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)51, 37.0000),
        dec: Angle.DegreesMinutesSeconds((int)-25, (int)54, 40.300)
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
    primaryId: "HIP 46992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82979"},
        {"Hipparcos Number", "HIP 46992"},
        {"Smithsonian Astrophysical Observation", "SAO 177687"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.66896211),
        dec: Angle.Degrees(-25.91086956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33667"},
        {"Hipparcos Number", "HIP 24114"},
        {"Geneva Identification System", "GEN# +1.00033667"},
        {"Smithsonian Astrophysical Observation", "SAO 170151"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.68580376),
        dec: Angle.Degrees(-25.91052699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27802"},
        {"Hipparcos Number", "HIP 20418"},
        {"Smithsonian Astrophysical Observation", "SAO 169379"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.60010068),
        dec: Angle.Degrees(-25.90917393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58436",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8371 AB"},
        {"Henry Draper", "HD 104039"},
        {"Hipparcos Number", "HIP 58436"},
        {"Geneva Identification System", "GEN# +1.00104039J"},
        {"Smithsonian Astrophysical Observation", "SAO 180349"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.72663478),
        dec: Angle.Degrees(-25.90880286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117581",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17041 AB"},
        {"Henry Draper", "HD 223575"},
        {"Hipparcos Number", "HIP 117581"},
        {"Smithsonian Astrophysical Observation", "SAO 192197"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.67742735),
        dec: Angle.Degrees(-25.90837954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224227"},
        {"Hipparcos Number", "HIP 118001"},
        {"Smithsonian Astrophysical Observation", "SAO 192248"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.02943656),
        dec: Angle.Degrees(-25.90798615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55296"},
        {"Hipparcos Number", "HIP 34697"},
        {"Smithsonian Astrophysical Observation", "SAO 173151"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.80386417),
        dec: Angle.Degrees(-25.90784437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -292.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179323"},
        {"Hipparcos Number", "HIP 94434"},
        {"Fundamental Katalog 5th Edition", "FK5 3533"},
        {"Geneva Identification System", "GEN# +1.00179323"},
        {"Smithsonian Astrophysical Observation", "SAO 187835"},
        {"Wilson Evans Batten Catalogue", "WEB 16456"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.30695700),
        dec: Angle.Degrees(-25.90676384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110922"},
    },
    visualMagnitude: 11.97,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.09753455),
        dec: Angle.Degrees(-25.90131026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -340.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184553"},
        {"Hipparcos Number", "HIP 96409"},
        {"Geneva Identification System", "GEN# +1.00184553"},
        {"Wilson Evans Batten Catalogue", "WEB 16913"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.01566761),
        dec: Angle.Degrees(-25.90109140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7950"},
        {"Hipparcos Number", "HIP 6125"},
        {"Geneva Identification System", "GEN# +1.00007950"},
        {"Smithsonian Astrophysical Observation", "SAO 166946"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.65796993),
        dec: Angle.Degrees(-25.89905383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211291"},
        {"Hipparcos Number", "HIP 109990"},
        {"Geneva Identification System", "GEN# +1.00211291"},
        {"Smithsonian Astrophysical Observation", "SAO 191016"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.15599677),
        dec: Angle.Degrees(-25.89813249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189326"},
        {"Hipparcos Number", "HIP 98479"},
        {"Smithsonian Astrophysical Observation", "SAO 188806"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.10288773),
        dec: Angle.Degrees(-25.89758939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20046"},
        {"Hipparcos Number", "HIP 14928"},
        {"Smithsonian Astrophysical Observation", "SAO 168379"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.13523764),
        dec: Angle.Degrees(-25.89510733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129636"},
        {"Hipparcos Number", "HIP 72058"},
        {"Smithsonian Astrophysical Observation", "SAO 182824"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.08812523),
        dec: Angle.Degrees(-25.89473521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225175"},
        {"Hipparcos Number", "HIP 321"},
        {"Geneva Identification System", "GEN# +1.00225175"},
        {"Smithsonian Astrophysical Observation", "SAO 166027"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.03267114),
        dec: Angle.Degrees(-25.89254967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32677"},
        {"Hipparcos Number", "HIP 23558"},
        {"Smithsonian Astrophysical Observation", "SAO 170030"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.97723158),
        dec: Angle.Degrees(-25.89198416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57615"},
        {"Hipparcos Number", "HIP 35626"},
        {"Geneva Identification System", "GEN# +1.00057615"},
        {"Smithsonian Astrophysical Observation", "SAO 173529"},
        {"Wilson Evans Batten Catalogue", "WEB 7101"},
    },
    visualMagnitude: 5.87,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.26808505),
        dec: Angle.Degrees(-25.89167605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8008"},
    },
    visualMagnitude: 11.65,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.70577455),
        dec: Angle.Degrees(-25.89001545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6088"},
        {"Hipparcos Number", "HIP 4819"},
        {"Geneva Identification System", "GEN# +1.00006088"},
        {"Smithsonian Astrophysical Observation", "SAO 166758"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.45535790),
        dec: Angle.Degrees(-25.88686413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85480"},
        {"Hipparcos Number", "HIP 48357"},
        {"Smithsonian Astrophysical Observation", "SAO 178099"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.87518535),
        dec: Angle.Degrees(-25.88659533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145428"},
        {"Hipparcos Number", "HIP 79364"},
        {"Geneva Identification System", "GEN# +1.00145428"},
        {"Smithsonian Astrophysical Observation", "SAO 184209"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.96390482),
        dec: Angle.Degrees(-25.88342910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108960",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15592 AB"},
        {"Henry Draper", "HD 209506"},
        {"Hipparcos Number", "HIP 108960"},
        {"Smithsonian Astrophysical Observation", "SAO 190862"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.12464727),
        dec: Angle.Degrees(-25.88330637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12167"},
        {"Hipparcos Number", "HIP 9256"},
        {"Geneva Identification System", "GEN# +1.00012167"},
        {"Smithsonian Astrophysical Observation", "SAO 167453"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.74373259),
        dec: Angle.Degrees(-25.88057532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -335.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30857"},
        {"Hipparcos Number", "HIP 22482"},
        {"Geneva Identification System", "GEN# +1.00030857"},
        {"Smithsonian Astrophysical Observation", "SAO 169803"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.55385803),
        dec: Angle.Degrees(-25.87837212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 116.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74368"},
        {"Hipparcos Number", "HIP 42752"},
        {"Smithsonian Astrophysical Observation", "SAO 176343"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.69249931),
        dec: Angle.Degrees(-25.87781352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207238"},
        {"Hipparcos Number", "HIP 107640"},
        {"Geneva Identification System", "GEN# +1.00207238"},
        {"Smithsonian Astrophysical Observation", "SAO 190635"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.03866999),
        dec: Angle.Degrees(-25.87774642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38639"},
        {"Hipparcos Number", "HIP 27220"},
        {"Smithsonian Astrophysical Observation", "SAO 170808"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.53780920),
        dec: Angle.Degrees(-25.87732299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5676"},
        {"Hipparcos Number", "HIP 4547"},
        {"Smithsonian Astrophysical Observation", "SAO 166713"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.55180795),
        dec: Angle.Degrees(-25.87660591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37515",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37515"},
        {"Geneva Identification System", "GEN# -0.02504923"},
        {"Smithsonian Astrophysical Observation", "SAO 174319"},
        {"Wilson Evans Batten Catalogue", "WEB 7422"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.49585558),
        dec: Angle.Degrees(-25.87618664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 562"},
        {"Hipparcos Number", "HIP 810"},
        {"Geneva Identification System", "GEN# +1.00000562"},
        {"Smithsonian Astrophysical Observation", "SAO 166089"},
        {"Wilson Evans Batten Catalogue", "WEB 138"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.49611767),
        dec: Angle.Degrees(-25.87473632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39350"},
        {"Hipparcos Number", "HIP 27631"},
        {"Smithsonian Astrophysical Observation", "SAO 170919"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.74794764),
        dec: Angle.Degrees(-25.87451981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16566"},
        {"Wilson Evans Batten Catalogue", "WEB 3162"},
        {"New General Catalogue", "NGC 1360"},
    },
    visualMagnitude: 11.34,
    bvColour: -0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.31102673),
        dec: Angle.Degrees(-25.87172571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185181"},
        {"Hipparcos Number", "HIP 96635"},
        {"Smithsonian Astrophysical Observation", "SAO 188385"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.71431166),
        dec: Angle.Degrees(-25.87150784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -245.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119356"},
        {"Hipparcos Number", "HIP 66947"},
        {"Smithsonian Astrophysical Observation", "SAO 181898"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.81667817),
        dec: Angle.Degrees(-25.86940477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140968"},
        {"Hipparcos Number", "HIP 77347"},
        {"Smithsonian Astrophysical Observation", "SAO 183789"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.84725988),
        dec: Angle.Degrees(-25.86764587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143787"},
        {"Hipparcos Number", "HIP 78650"},
        {"Geneva Identification System", "GEN# +1.00143787"},
        {"Smithsonian Astrophysical Observation", "SAO 184068"},
        {"Wilson Evans Batten Catalogue", "WEB 13294"},
    },
    visualMagnitude: 4.96,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.83611243),
        dec: Angle.Degrees(-25.86514891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222012"},
        {"Hipparcos Number", "HIP 116547"},
        {"Geneva Identification System", "GEN# +1.00222012"},
        {"Smithsonian Astrophysical Observation", "SAO 192036"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.29166077),
        dec: Angle.Degrees(-25.86473391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146331"},
        {"Hipparcos Number", "HIP 79771"},
        {"Geneva Identification System", "GEN# +1.00146331"},
        {"Smithsonian Astrophysical Observation", "SAO 184282"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.21096868),
        dec: Angle.Degrees(-25.86291846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6838"},
        {"Hipparcos Number", "HIP 5373"},
        {"Geneva Identification System", "GEN# +1.00006838"},
        {"Smithsonian Astrophysical Observation", "SAO 166833"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.19028697),
        dec: Angle.Degrees(-25.86120192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99625"},
        {"Hipparcos Number", "HIP 55912"},
        {"Smithsonian Astrophysical Observation", "SAO 179904"},
        {"Wilson Evans Batten Catalogue", "WEB 10041"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.90700656),
        dec: Angle.Degrees(-25.86091272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206340"},
        {"Hipparcos Number", "HIP 107135"},
        {"Smithsonian Astrophysical Observation", "SAO 190561"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.51775000),
        dec: Angle.Degrees(-25.86004408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44824",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7202 A"},
        {"Henry Draper", "HD 78541"},
        {"Hipparcos Number", "HIP 44824"},
        {"Geneva Identification System", "GEN# +1.00078541"},
        {"Smithsonian Astrophysical Observation", "SAO 177002"},
        {"Wilson Evans Batten Catalogue", "WEB 8566"},
    },
    visualMagnitude: 4.62,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.01190516),
        dec: Angle.Degrees(-25.85853691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146998"},
        {"Hipparcos Number", "HIP 80027"},
        {"Geneva Identification System", "GEN# +1.00146998"},
        {"Renson", "Renson 41520"},
        {"Smithsonian Astrophysical Observation", "SAO 184319"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.04099356),
        dec: Angle.Degrees(-25.85728870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95405"},
        {"Hipparcos Number", "HIP 53810"},
        {"Geneva Identification System", "GEN# +1.00095405"},
        {"Smithsonian Astrophysical Observation", "SAO 179425"},
        {"Wilson Evans Batten Catalogue", "WEB 9749"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.14299690),
        dec: Angle.Degrees(-25.85626143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45588"},
        {"Hipparcos Number", "HIP 30711"},
        {"Geneva Identification System", "GEN# +1.00045588"},
        {"Smithsonian Astrophysical Observation", "SAO 171774"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.79782098),
        dec: Angle.Degrees(-25.85597162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -215.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92310"},
        {"Hipparcos Number", "HIP 52145"},
        {"Fundamental Katalog 5th Edition", "FK5 4946"},
        {"Geneva Identification System", "GEN# +1.00092310"},
        {"Smithsonian Astrophysical Observation", "SAO 179075"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.79009472),
        dec: Angle.Degrees(-25.85132917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182323"},
        {"Hipparcos Number", "HIP 95461"},
        {"Smithsonian Astrophysical Observation", "SAO 188096"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.28522416),
        dec: Angle.Degrees(-25.85042200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10796"},
        {"Hipparcos Number", "HIP 8179"},
        {"Smithsonian Astrophysical Observation", "SAO 167269"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.28413452),
        dec: Angle.Degrees(-25.85018789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219998"},
        {"Hipparcos Number", "HIP 115248"},
        {"Geneva Identification System", "GEN# +1.00219998"},
        {"Renson", "Renson 60410"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.15694004),
        dec: Angle.Degrees(-25.85014718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25676"},
        {"Hipparcos Number", "HIP 18939"},
        {"Smithsonian Astrophysical Observation", "SAO 169080"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.89119499),
        dec: Angle.Degrees(-25.84788229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14988"},
        {"Hipparcos Number", "HIP 11212"},
        {"Fundamental Katalog 5th Edition", "FK5 2163"},
        {"Geneva Identification System", "GEN# +1.00014988"},
        {"Smithsonian Astrophysical Observation", "SAO 167757"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.08373505),
        dec: Angle.Degrees(-25.84749833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61758"},
        {"Hipparcos Number", "HIP 37341"},
        {"Smithsonian Astrophysical Observation", "SAO 174240"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.97599930),
        dec: Angle.Degrees(-25.84599775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195498"},
        {"Hipparcos Number", "HIP 101360"},
        {"Smithsonian Astrophysical Observation", "SAO 189411"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.14021965),
        dec: Angle.Degrees(-25.84465036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93961"},
    },
    visualMagnitude: 12.05,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.97456841),
        dec: Angle.Degrees(-25.84413413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118599"},
        {"Hipparcos Number", "HIP 66536"},
        {"Smithsonian Astrophysical Observation", "SAO 181820"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.58539408),
        dec: Angle.Degrees(-25.84236591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212231"},
        {"Hipparcos Number", "HIP 110512"},
        {"Cincinnati Publication", "Ci 20 1360"},
        {"Geneva Identification System", "GEN# +1.00212231"},
        {"Smithsonian Astrophysical Observation", "SAO 191101"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.80928773),
        dec: Angle.Degrees(-25.84205653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 376.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111530"},
        {"Hipparcos Number", "HIP 62639"},
        {"Smithsonian Astrophysical Observation", "SAO 181141"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.53186220),
        dec: Angle.Degrees(-25.84166363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116211"},
        {"Hipparcos Number", "HIP 65257"},
        {"Geneva Identification System", "GEN# +1.00116211"},
        {"Smithsonian Astrophysical Observation", "SAO 181598"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.61482127),
        dec: Angle.Degrees(-25.84088899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210451"},
        {"Hipparcos Number", "HIP 109507"},
        {"Smithsonian Astrophysical Observation", "SAO 190944"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.75696988),
        dec: Angle.Degrees(-25.84064193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46994"},
        {"Hipparcos Number", "HIP 31436"},
        {"Smithsonian Astrophysical Observation", "SAO 171989"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.80467173),
        dec: Angle.Degrees(-25.84022587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78643"},
        {"Henry Draper 2", "HD 78643A"},
        {"Hipparcos Number", "HIP 44874"},
        {"Geneva Identification System", "GEN# +1.00078643"},
        {"Smithsonian Astrophysical Observation", "SAO 177018"},
        {"Wilson Evans Batten Catalogue", "WEB 8573"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.15343755),
        dec: Angle.Degrees(-25.83943910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -332.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41067"},
        {"Hipparcos Number", "HIP 28571"},
        {"Smithsonian Astrophysical Observation", "SAO 171146"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.44654295),
        dec: Angle.Degrees(-25.83831928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87657"},
        {"Hipparcos Number", "HIP 49469"},
        {"Smithsonian Astrophysical Observation", "SAO 178400"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.48732818),
        dec: Angle.Degrees(-25.83725796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4086",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4086"},
        {"Geneva Identification System", "GEN# +9.80268063"},
    },
    visualMagnitude: 12.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.10948370),
        dec: Angle.Degrees(-25.83662131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103331"},
        {"Hipparcos Number", "HIP 58004"},
        {"Smithsonian Astrophysical Observation", "SAO 180276"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.46161143),
        dec: Angle.Degrees(-25.83589393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194102"},
        {"Hipparcos Number", "HIP 100663"},
        {"Smithsonian Astrophysical Observation", "SAO 189249"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.15457891),
        dec: Angle.Degrees(-25.83373491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218522"},
        {"Hipparcos Number", "HIP 114291"},
        {"Geneva Identification System", "GEN# +1.00218522"},
        {"Smithsonian Astrophysical Observation", "SAO 191676"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.21517998),
        dec: Angle.Degrees(-25.83051383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152429"},
        {"Hipparcos Number", "HIP 82708"},
        {"Geneva Identification System", "GEN# +1.00152429"},
        {"Smithsonian Astrophysical Observation", "SAO 184775"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.58626394),
        dec: Angle.Degrees(-25.82928643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125967"},
        {"Hipparcos Number", "HIP 70328"},
        {"Smithsonian Astrophysical Observation", "SAO 182490"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.84614954),
        dec: Angle.Degrees(-25.82888488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58613"},
        {"Hipparcos Number", "HIP 36010"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.32247319),
        dec: Angle.Degrees(-25.82581418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197336"},
        {"Hipparcos Number", "HIP 102316"},
        {"Smithsonian Astrophysical Observation", "SAO 189620"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.96459756),
        dec: Angle.Degrees(-25.82518537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70323"},
        {"Hipparcos Number", "HIP 40868"},
        {"Geneva Identification System", "GEN# +1.00070323"},
        {"Smithsonian Astrophysical Observation", "SAO 175632"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.09421234),
        dec: Angle.Degrees(-25.82015716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163813"},
        {"Hipparcos Number", "HIP 88074"},
        {"Celescope Catalog", "CEL 4583"},
        {"Geneva Identification System", "GEN# +1.00163813"},
        {"Smithsonian Astrophysical Observation", "SAO 186047"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.81744177),
        dec: Angle.Degrees(-25.81882964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64199"},
        {"Hipparcos Number", "HIP 38381"},
        {"Geneva Identification System", "GEN# +1.00064199"},
        {"Smithsonian Astrophysical Observation", "SAO 174685"},
    },
    visualMagnitude: 8.93,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.94230445),
        dec: Angle.Degrees(-25.81667295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69965",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9212 A"},
        {"Henry Draper", "HD 125276"},
        {"Hipparcos Number", "HIP 69965"},
        {"Cincinnati Publication", "Ci 20 846"},
        {"Geneva Identification System", "GEN# +1.00125276"},
        {"Smithsonian Astrophysical Observation", "SAO 182433"},
        {"Wilson Evans Batten Catalogue", "WEB 12167"},
    },
    visualMagnitude: 5.87,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.75469177),
        dec: Angle.Degrees(-25.81631724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -356.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 366.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62358",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62358"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.67245767),
        dec: Angle.Degrees(-25.81612075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67673"},
        {"Hipparcos Number", "HIP 39815"},
        {"Smithsonian Astrophysical Observation", "SAO 175236"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.03567869),
        dec: Angle.Degrees(-25.81525996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5877"},
        {"Geneva Identification System", "GEN# -0.02600411J"},
        {"Smithsonian Astrophysical Observation", "SAO 166912"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.86709863),
        dec: Angle.Degrees(-25.81505800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149150"},
        {"Hipparcos Number", "HIP 81114"},
        {"Smithsonian Astrophysical Observation", "SAO 184462"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.50141224),
        dec: Angle.Degrees(-25.81392881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178787"},
        {"Hipparcos Number", "HIP 94244"},
        {"Smithsonian Astrophysical Observation", "SAO 187780"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.75825501),
        dec: Angle.Degrees(-25.81352439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188224"},
        {"Hipparcos Number", "HIP 98021"},
        {"Smithsonian Astrophysical Observation", "SAO 188710"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.79085507),
        dec: Angle.Degrees(-25.80738788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51255",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7787"},
        {"Henry Draper", "HD 90737"},
        {"Hipparcos Number", "HIP 51255"},
        {"Smithsonian Astrophysical Observation", "SAO 178853"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.04390786),
        dec: Angle.Degrees(-25.80733856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198231"},
        {"Hipparcos Number", "HIP 102812"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.42641789),
        dec: Angle.Degrees(-25.80558051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35002",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35002"},
        {"New General Catalogue", "NGC 2354 248"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.62779297),
        dec: Angle.Degrees(-25.80316184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44982",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7220 AB"},
        {"Henry Draper", "HD 78876"},
        {"Hipparcos Number", "HIP 44982"},
        {"Smithsonian Astrophysical Observation", "SAO 177055"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.44084121),
        dec: Angle.Degrees(-25.80312548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128356"},
        {"Hipparcos Number", "HIP 71481"},
        {"Geneva Identification System", "GEN# +1.00128356"},
        {"Smithsonian Astrophysical Observation", "SAO 182707"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.27041701),
        dec: Angle.Degrees(-25.80223159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113416"},
        {"Hipparcos Number", "HIP 63743"},
        {"Geneva Identification System", "GEN# +1.00113416"},
        {"Smithsonian Astrophysical Observation", "SAO 181359"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.96359157),
        dec: Angle.Degrees(-25.80191159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138472"},
        {"Hipparcos Number", "HIP 76140"},
        {"Smithsonian Astrophysical Observation", "SAO 183563"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.28165802),
        dec: Angle.Degrees(-25.80079320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152912"},
        {"Hipparcos Number", "HIP 82977"},
        {"Geneva Identification System", "GEN# +1.00152912"},
        {"Wilson Evans Batten Catalogue", "WEB 14028"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.34434333),
        dec: Angle.Degrees(-25.79959389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100012"},
        {"Hipparcos Number", "HIP 56130"},
        {"Smithsonian Astrophysical Observation", "SAO 179943"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.58620758),
        dec: Angle.Degrees(-25.79860856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 146",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17173 AB"},
        {"Henry Draper", "HD 224927"},
        {"Hipparcos Number", "HIP 146"},
        {"Cincinnati Publication", "Ci 18 3156"},
        {"Geneva Identification System", "GEN# +1.00224927J"},
        {"Smithsonian Astrophysical Observation", "SAO 192327"},
        {"Wilson Evans Batten Catalogue", "WEB 25"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.45619148),
        dec: Angle.Degrees(-25.79769516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -341.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91967",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11622 AB"},
        {"Henry Draper", "HD 173099"},
        {"Hipparcos Number", "HIP 91967"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.18519927),
        dec: Angle.Degrees(-25.79739630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133529"},
        {"Hipparcos Number", "HIP 73865"},
        {"Geneva Identification System", "GEN# +1.00133529"},
        {"Smithsonian Astrophysical Observation", "SAO 183163"},
        {"Wilson Evans Batten Catalogue", "WEB 12616"},
    },
    visualMagnitude: 6.65,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.44886139),
        dec: Angle.Degrees(-25.78943722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167175"},
        {"Hipparcos Number", "HIP 89435"},
        {"Smithsonian Astrophysical Observation", "SAO 186540"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.79838253),
        dec: Angle.Degrees(-25.78910060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195063"},
        {"Hipparcos Number", "HIP 101122"},
        {"Smithsonian Astrophysical Observation", "SAO 189355"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.47288488),
        dec: Angle.Degrees(-25.78490267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198174"},
        {"Hipparcos Number", "HIP 102772"},
        {"Geneva Identification System", "GEN# +1.00198174"},
        {"Renson", "Renson 55160"},
        {"Smithsonian Astrophysical Observation", "SAO 189733"},
        {"Wilson Evans Batten Catalogue", "WEB 18635"},
    },
    visualMagnitude: 5.86,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.32335608),
        dec: Angle.Degrees(-25.78119469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54257"},
        {"Hipparcos Number", "HIP 34335"},
        {"Smithsonian Astrophysical Observation", "SAO 172991"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.76180656),
        dec: Angle.Degrees(-25.78087869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19225"},
        {"Hipparcos Number", "HIP 14323"},
        {"Geneva Identification System", "GEN# +1.00019225"},
        {"Smithsonian Astrophysical Observation", "SAO 168285"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.18109214),
        dec: Angle.Degrees(-25.77900258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142382"},
        {"Hipparcos Number", "HIP 77955"},
        {"Smithsonian Astrophysical Observation", "SAO 183923"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.80143989),
        dec: Angle.Degrees(-25.77880621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50093"},
        {"Hipparcos Number", "HIP 32827"},
        {"Geneva Identification System", "GEN# +1.00050093"},
        {"Smithsonian Astrophysical Observation", "SAO 172420"},
    },
    visualMagnitude: 6.32,
    bvColour: -0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.65400772),
        dec: Angle.Degrees(-25.77840876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208013"},
        {"Hipparcos Number", "HIP 108086"},
        {"Renson", "Renson 57830"},
        {"Smithsonian Astrophysical Observation", "SAO 190719"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.48324544),
        dec: Angle.Degrees(-25.77702322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31193"},
        {"Hipparcos Number", "HIP 22683"},
        {"Geneva Identification System", "GEN# +1.00031193"},
        {"Smithsonian Astrophysical Observation", "SAO 169837"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.17273161),
        dec: Angle.Degrees(-25.77482088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221632"},
        {"Hipparcos Number", "HIP 116303"},
        {"Smithsonian Astrophysical Observation", "SAO 191993"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.46951500),
        dec: Angle.Degrees(-25.77333630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162389"},
        {"Hipparcos Number", "HIP 87422"},
        {"Smithsonian Astrophysical Observation", "SAO 185854"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.97939254),
        dec: Angle.Degrees(-25.77293928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29790"},
        {"Hipparcos Number", "HIP 21775"},
        {"Geneva Identification System", "GEN# +1.00029790"},
        {"Smithsonian Astrophysical Observation", "SAO 169660"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.15764154),
        dec: Angle.Degrees(-25.77199046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17945"},
        {"Smithsonian Astrophysical Observation", "SAO 168875"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.55498253),
        dec: Angle.Degrees(-25.77168581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55374"},
        {"Hipparcos Number", "HIP 34742"},
        {"Smithsonian Astrophysical Observation", "SAO 173166"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.89373963),
        dec: Angle.Degrees(-25.77053162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210139"},
        {"Hipparcos Number", "HIP 109312"},
        {"Renson", "Renson 58476"},
        {"Smithsonian Astrophysical Observation", "SAO 190913"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.19086596),
        dec: Angle.Degrees(-25.77023579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60642"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.43143629),
        dec: Angle.Degrees(-25.76779809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35793",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6033 AB"},
        {"Henry Draper", "HD 58061"},
        {"Hipparcos Number", "HIP 35793"},
        {"Geneva Identification System", "GEN# +1.00058061J"},
        {"Smithsonian Astrophysical Observation", "SAO 173591"},
        {"Wilson Evans Batten Catalogue", "WEB 7134"},
    },
    visualMagnitude: 8.08,
    bvColour: 2.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.74302121),
        dec: Angle.Degrees(-25.76755010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34991",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34991"},
        {"New General Catalogue", "NGC 2354 217"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.59316089),
        dec: Angle.Degrees(-25.76747077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136987"},
        {"Hipparcos Number", "HIP 75408"},
        {"Smithsonian Astrophysical Observation", "SAO 183438"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.11827177),
        dec: Angle.Degrees(-25.76277981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166295"},
        {"Hipparcos Number", "HIP 89097"},
        {"Smithsonian Astrophysical Observation", "SAO 186420"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.77175409),
        dec: Angle.Degrees(-25.76233462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146851"},
        {"Hipparcos Number", "HIP 79969"},
        {"Geneva Identification System", "GEN# +1.00146851"},
        {"Smithsonian Astrophysical Observation", "SAO 184310"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.84414384),
        dec: Angle.Degrees(-25.76063950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215543"},
        {"Hipparcos Number", "HIP 112421"},
        {"Smithsonian Astrophysical Observation", "SAO 191390"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.56874090),
        dec: Angle.Degrees(-25.76017221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217867"},
        {"Hipparcos Number", "HIP 113891"},
        {"Smithsonian Astrophysical Observation", "SAO 191615"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.97764309),
        dec: Angle.Degrees(-25.75636175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161452"},
        {"Hipparcos Number", "HIP 87009"},
        {"Smithsonian Astrophysical Observation", "SAO 185734"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.67939969),
        dec: Angle.Degrees(-25.75488379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141637"},
        {"Hipparcos Number", "HIP 77635"},
        {"Celescope Catalog", "CEL 4397"},
        {"Geneva Identification System", "GEN# +1.00141637"},
        {"Smithsonian Astrophysical Observation", "SAO 183854"},
        {"Wilson Evans Batten Catalogue", "WEB 13136"},
    },
    visualMagnitude: 4.63,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.74480683),
        dec: Angle.Degrees(-25.75123489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21253"},
        {"Hipparcos Number", "HIP 15907"},
        {"Smithsonian Astrophysical Observation", "SAO 168526"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.21442569),
        dec: Angle.Degrees(-25.75046951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5934"},
        {"Hipparcos Number", "HIP 4716"},
        {"Geneva Identification System", "GEN# +1.00005934"},
        {"Smithsonian Astrophysical Observation", "SAO 166740"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.13922233),
        dec: Angle.Degrees(-25.74902703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16600"},
        {"Hipparcos Number", "HIP 12340"},
        {"Geneva Identification System", "GEN# +1.00016600"},
        {"Smithsonian Astrophysical Observation", "SAO 167945"},
        {"Wilson Evans Batten Catalogue", "WEB 2531"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.72765599),
        dec: Angle.Degrees(-25.74518450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29052"},
    },
    visualMagnitude: 11.87,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.93273415),
        dec: Angle.Degrees(-25.74436845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221387"},
        {"Hipparcos Number", "HIP 116141"},
        {"Smithsonian Astrophysical Observation", "SAO 191972"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.98329140),
        dec: Angle.Degrees(-25.74418915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13232"},
        {"Hipparcos Number", "HIP 9988"},
        {"Geneva Identification System", "GEN# +1.00013232"},
        {"Renson", "Renson 3420"},
        {"Smithsonian Astrophysical Observation", "SAO 167583"},
        {"Wilson Evans Batten Catalogue", "WEB 2093"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.16552672),
        dec: Angle.Degrees(-25.74109290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129273"},
        {"Hipparcos Number", "HIP 71906"},
        {"Smithsonian Astrophysical Observation", "SAO 182783"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.61729508),
        dec: Angle.Degrees(-25.74049532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192613"},
        {"Hipparcos Number", "HIP 99937"},
        {"Smithsonian Astrophysical Observation", "SAO 189093"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.15805918),
        dec: Angle.Degrees(-25.73886026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37212"},
        {"Hipparcos Number", "HIP 26284"},
        {"Geneva Identification System", "GEN# +1.00037212"},
        {"Smithsonian Astrophysical Observation", "SAO 170582"},
        {"Wilson Evans Batten Catalogue", "WEB 5161"},
    },
    visualMagnitude: 7.66,
    bvColour: 2.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.94881892),
        dec: Angle.Degrees(-25.73850195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183575"},
        {"Hipparcos Number", "HIP 96012"},
        {"Smithsonian Astrophysical Observation", "SAO 188231"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.81902543),
        dec: Angle.Degrees(-25.73691869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30733",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5092 AB"},
        {"Henry Draper", "HD 45609"},
        {"Hipparcos Number", "HIP 30733"},
        {"Geneva Identification System", "GEN# +1.00045609"},
        {"Smithsonian Astrophysical Observation", "SAO 171781"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.85044012),
        dec: Angle.Degrees(-25.73478437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138813"},
        {"Hipparcos Number", "HIP 76310"},
        {"Geneva Identification System", "GEN# +1.00138813"},
        {"Smithsonian Astrophysical Observation", "SAO 183594"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.81715826),
        dec: Angle.Degrees(-25.73410763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20347",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3159"},
        {"Henry Draper", "HD 27710"},
        {"Hipparcos Number", "HIP 20347"},
        {"Geneva Identification System", "GEN# +1.00027710J"},
        {"Smithsonian Astrophysical Observation", "SAO 169368"},
        {"Wilson Evans Batten Catalogue", "WEB 3887"},
    },
    visualMagnitude: 6.08,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.38038046),
        dec: Angle.Degrees(-25.72845717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31517"},
        {"Hipparcos Number", "HIP 22897"},
        {"Geneva Identification System", "GEN# +1.00031517"},
        {"Smithsonian Astrophysical Observation", "SAO 169889"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.87571450),
        dec: Angle.Degrees(-25.72781189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38990"},
        {"Smithsonian Astrophysical Observation", "SAO 174917"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.69266153),
        dec: Angle.Degrees(-25.72622607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5721"},
        {"Smithsonian Astrophysical Observation", "SAO 166882"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.39037474),
        dec: Angle.Degrees(-25.72610589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49464"},
        {"Hipparcos Number", "HIP 32541"},
        {"Geneva Identification System", "GEN# +1.00049464"},
        {"Smithsonian Astrophysical Observation", "SAO 172331"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.86109767),
        dec: Angle.Degrees(-25.72538812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95442"},
        {"Hipparcos Number", "HIP 53823"},
        {"Geneva Identification System", "GEN# +1.00095442"},
        {"Renson", "Renson 27500"},
        {"Smithsonian Astrophysical Observation", "SAO 179428"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.18353833),
        dec: Angle.Degrees(-25.71732860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8736",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8736"},
        {"Smithsonian Astrophysical Observation", "SAO 167367"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.10385472),
        dec: Angle.Degrees(-25.71537161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103462"},
        {"Hipparcos Number", "HIP 58082"},
        {"Fundamental Katalog 5th Edition", "FK5 2950"},
        {"Geneva Identification System", "GEN# +1.00103462"},
        {"Smithsonian Astrophysical Observation", "SAO 180288"},
        {"Wilson Evans Batten Catalogue", "WEB 10399"},
    },
    visualMagnitude: 5.26,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.67711574),
        dec: Angle.Degrees(-25.71406632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62680"},
        {"Hipparcos Number", "HIP 37733"},
        {"Smithsonian Astrophysical Observation", "SAO 174425"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.08406166),
        dec: Angle.Degrees(-25.71387508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69015"},
        {"Hipparcos Number", "HIP 40329"},
        {"Smithsonian Astrophysical Observation", "SAO 175423"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.51948384),
        dec: Angle.Degrees(-25.71177695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2870"},
        {"Hipparcos Number", "HIP 2513"},
        {"Geneva Identification System", "GEN# +1.00002870"},
        {"Smithsonian Astrophysical Observation", "SAO 166336"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.96970050),
        dec: Angle.Degrees(-25.71114740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202702"},
        {"Hipparcos Number", "HIP 105173"},
        {"Smithsonian Astrophysical Observation", "SAO 190212"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.57528274),
        dec: Angle.Degrees(-25.71089317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204668"},
        {"Hipparcos Number", "HIP 106206"},
        {"Smithsonian Astrophysical Observation", "SAO 190396"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.68433793),
        dec: Angle.Degrees(-25.70971102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147702"},
        {"Hipparcos Number", "HIP 80377"},
        {"Geneva Identification System", "GEN# +1.00147702"},
        {"Smithsonian Astrophysical Observation", "SAO 184364"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.10647474),
        dec: Angle.Degrees(-25.70702873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27292",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4382 AB"},
        {"Henry Draper", "HD 38760"},
        {"Hipparcos Number", "HIP 27292"},
        {"Smithsonian Astrophysical Observation", "SAO 170831"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.74677795),
        dec: Angle.Degrees(-25.70671502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29626"},
        {"Hipparcos Number", "HIP 21649"},
        {"Smithsonian Astrophysical Observation", "SAO 169635"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.73338509),
        dec: Angle.Degrees(-25.70594543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177971"},
        {"Hipparcos Number", "HIP 93963"},
        {"Geneva Identification System", "GEN# +1.00177971"},
        {"Smithsonian Astrophysical Observation", "SAO 187710"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.97768087),
        dec: Angle.Degrees(-25.70219902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2139"},
        {"Smithsonian Astrophysical Observation", "SAO 166279"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.77336132),
        dec: Angle.Degrees(-25.70044366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21624"},
        {"Hipparcos Number", "HIP 16187"},
        {"Smithsonian Astrophysical Observation", "SAO 168571"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.12822984),
        dec: Angle.Degrees(-25.69991736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115850"},
    },
    visualMagnitude: 11.13,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.06462397),
        dec: Angle.Degrees(-25.69984115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39514",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6566 AB"},
        {"Henry Draper", "HD 66885"},
        {"Hipparcos Number", "HIP 39514"},
        {"Smithsonian Astrophysical Observation", "SAO 175114"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.13603787),
        dec: Angle.Degrees(-25.69969807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55014"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.95563896),
        dec: Angle.Degrees(-25.69843361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -327.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154021"},
        {"Hipparcos Number", "HIP 83508"},
        {"Geneva Identification System", "GEN# +1.00154021"},
        {"Smithsonian Astrophysical Observation", "SAO 184982"},
    },
    visualMagnitude: 6.66,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.00340639),
        dec: Angle.Degrees(-25.69794542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151001"},
        {"Hipparcos Number", "HIP 82052"},
        {"Geneva Identification System", "GEN# +1.00151001"},
        {"Smithsonian Astrophysical Observation", "SAO 184614"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.41227631),
        dec: Angle.Degrees(-25.69680964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30215"},
        {"Hipparcos Number", "HIP 22057"},
        {"Geneva Identification System", "GEN# +1.00030215"},
        {"Smithsonian Astrophysical Observation", "SAO 169717"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.15524208),
        dec: Angle.Degrees(-25.69650305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10968"},
        {"Hipparcos Number", "HIP 8310"},
        {"Smithsonian Astrophysical Observation", "SAO 167291"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.79321834),
        dec: Angle.Degrees(-25.69427269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217958"},
        {"Hipparcos Number", "HIP 113948"},
        {"Geneva Identification System", "GEN# +1.00217958"},
        {"Smithsonian Astrophysical Observation", "SAO 191627"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.13718288),
        dec: Angle.Degrees(-25.69073654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170636"},
        {"Hipparcos Number", "HIP 90822"},
        {"Smithsonian Astrophysical Observation", "SAO 186917"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.91739362),
        dec: Angle.Degrees(-25.69038388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223885"},
        {"Hipparcos Number", "HIP 117796"},
        {"Smithsonian Astrophysical Observation", "SAO 192219"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.33656555),
        dec: Angle.Degrees(-25.68925696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176662"},
        {"Hipparcos Number", "HIP 93492"},
        {"Smithsonian Astrophysical Observation", "SAO 187596"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.60030633),
        dec: Angle.Degrees(-25.68856909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184931"},
        {"Hipparcos Number", "HIP 96553"},
        {"Smithsonian Astrophysical Observation", "SAO 188359"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.43921873),
        dec: Angle.Degrees(-25.68658595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48460"},
        {"Hipparcos Number", "HIP 32109"},
        {"Smithsonian Astrophysical Observation", "SAO 172199"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.60903606),
        dec: Angle.Degrees(-25.68647798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49463"},
        {"Hipparcos Number", "HIP 32552"},
        {"Smithsonian Astrophysical Observation", "SAO 172333"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.88229151),
        dec: Angle.Degrees(-25.68478800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185949"},
        {"Hipparcos Number", "HIP 96971"},
        {"Smithsonian Astrophysical Observation", "SAO 188471"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.66023497),
        dec: Angle.Degrees(-25.68332695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41811",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6863 AB"},
        {"Henry Draper", "HD 72346"},
        {"Hipparcos Number", "HIP 41811"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.86678595),
        dec: Angle.Degrees(-25.68218399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215061"},
        {"Hipparcos Number", "HIP 112137"},
        {"Smithsonian Astrophysical Observation", "SAO 191346"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.72060214),
        dec: Angle.Degrees(-25.68134833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134215"},
        {"Hipparcos Number", "HIP 74175"},
        {"Smithsonian Astrophysical Observation", "SAO 183221"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.33728206),
        dec: Angle.Degrees(-25.68120869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220800"},
        {"Hipparcos Number", "HIP 115740"},
        {"Smithsonian Astrophysical Observation", "SAO 191908"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.72855157),
        dec: Angle.Degrees(-25.67744973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74205"},
        {"Hipparcos Number", "HIP 42668"},
        {"Geneva Identification System", "GEN# +1.00074205"},
        {"Smithsonian Astrophysical Observation", "SAO 176321"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.44790502),
        dec: Angle.Degrees(-25.67623750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7730"},
        {"Hipparcos Number", "HIP 5959"},
        {"Geneva Identification System", "GEN# +1.00007730"},
        {"Smithsonian Astrophysical Observation", "SAO 166921"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.16386119),
        dec: Angle.Degrees(-25.67409339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163227"},
        {"Hipparcos Number", "HIP 87809"},
        {"Smithsonian Astrophysical Observation", "SAO 185960"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.06330332),
        dec: Angle.Degrees(-25.67277559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37906"},
        {"Hipparcos Number", "HIP 26725"},
        {"Smithsonian Astrophysical Observation", "SAO 170682"},
    },
    visualMagnitude: 8.83,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.18732075),
        dec: Angle.Degrees(-25.67267487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178786"},
        {"Hipparcos Number", "HIP 94237"},
        {"Renson", "Renson 49700"},
        {"Smithsonian Astrophysical Observation", "SAO 187778"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.74515051),
        dec: Angle.Degrees(-25.67213680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62030"},
        {"Smithsonian Astrophysical Observation", "SAO 181041"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.71356422),
        dec: Angle.Degrees(-25.67092558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138601"},
        {"Hipparcos Number", "HIP 76205"},
        {"Smithsonian Astrophysical Observation", "SAO 183573"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.49874340),
        dec: Angle.Degrees(-25.67076404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116884",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16931 AB"},
        {"Henry Draper", "HD 222535"},
        {"Hipparcos Number", "HIP 116884"},
        {"Smithsonian Astrophysical Observation", "SAO 192088"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.37507749),
        dec: Angle.Degrees(-25.67060452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171665"},
        {"Hipparcos Number", "HIP 91287"},
        {"Fundamental Katalog 5th Edition", "FK5 5636"},
        {"Geneva Identification System", "GEN# +1.00171665"},
        {"Smithsonian Astrophysical Observation", "SAO 187054"},
        {"Wilson Evans Batten Catalogue", "WEB 15686"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.30303766),
        dec: Angle.Degrees(-25.67058294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -281.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179205"},
        {"Hipparcos Number", "HIP 94389"},
        {"Smithsonian Astrophysical Observation", "SAO 187821"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.17915687),
        dec: Angle.Degrees(-25.66936217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9554"},
        {"Hipparcos Number", "HIP 7236"},
        {"Smithsonian Astrophysical Observation", "SAO 167135"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.31600772),
        dec: Angle.Degrees(-25.66712041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137035"},
        {"Hipparcos Number", "HIP 75433"},
        {"Smithsonian Astrophysical Observation", "SAO 183442"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.16384349),
        dec: Angle.Degrees(-25.66692487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180091"},
        {"Hipparcos Number", "HIP 94699"},
        {"Smithsonian Astrophysical Observation", "SAO 187898"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.04730317),
        dec: Angle.Degrees(-25.66668459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215117"},
        {"Hipparcos Number", "HIP 112181"},
        {"Geneva Identification System", "GEN# +1.00215117"},
        {"Smithsonian Astrophysical Observation", "SAO 191352"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.81284856),
        dec: Angle.Degrees(-25.66666857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213694"},
        {"Hipparcos Number", "HIP 111370"},
        {"Smithsonian Astrophysical Observation", "SAO 191226"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.43696508),
        dec: Angle.Degrees(-25.66599907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196496"},
        {"Hipparcos Number", "HIP 101873"},
        {"Smithsonian Astrophysical Observation", "SAO 189519"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.65873365),
        dec: Angle.Degrees(-25.66576018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101922"},
        {"Hipparcos Number", "HIP 57196"},
        {"Geneva Identification System", "GEN# +1.00101922"},
        {"Smithsonian Astrophysical Observation", "SAO 180137"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.93319062),
        dec: Angle.Degrees(-25.66389236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77956"},
        {"Hipparcos Number", "HIP 44566"},
        {"Smithsonian Astrophysical Observation", "SAO 176915"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.20314915),
        dec: Angle.Degrees(-25.66248547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22053"},
        {"Hipparcos Number", "HIP 16503"},
        {"Smithsonian Astrophysical Observation", "SAO 168619"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.11115295),
        dec: Angle.Degrees(-25.65846883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222907"},
        {"Hipparcos Number", "HIP 117139"},
        {"Smithsonian Astrophysical Observation", "SAO 192125"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.21149741),
        dec: Angle.Degrees(-25.65746783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1282"},
        {"Smithsonian Astrophysical Observation", "SAO 166158"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.01381667),
        dec: Angle.Degrees(-25.65715070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117505"},
        {"Hipparcos Number", "HIP 65942"},
        {"Smithsonian Astrophysical Observation", "SAO 181716"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.78092750),
        dec: Angle.Degrees(-25.65690242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214405"},
        {"Hipparcos Number", "HIP 111749"},
        {"Geneva Identification System", "GEN# +1.00214405"},
        {"Smithsonian Astrophysical Observation", "SAO 191286"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.55123783),
        dec: Angle.Degrees(-25.65631923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75344"},
        {"Hipparcos Number", "HIP 43248"},
        {"Renson", "Renson 21104"},
        {"Smithsonian Astrophysical Observation", "SAO 176508"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.15708131),
        dec: Angle.Degrees(-25.65426158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155380"},
        {"Hipparcos Number", "HIP 84160"},
        {"Smithsonian Astrophysical Observation", "SAO 185140"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.08483902),
        dec: Angle.Degrees(-25.65383575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53373"},
        {"Hipparcos Number", "HIP 34048"},
        {"Celescope Catalog", "CEL 1546"},
        {"Geneva Identification System", "GEN# +1.00053373"},
        {"Smithsonian Astrophysical Observation", "SAO 172876"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.94759265),
        dec: Angle.Degrees(-25.65339525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31429"},
        {"Hipparcos Number", "HIP 22836"},
        {"Smithsonian Astrophysical Observation", "SAO 169882"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.70467189),
        dec: Angle.Degrees(-25.65287550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209365"},
        {"Hipparcos Number", "HIP 108877"},
        {"Smithsonian Astrophysical Observation", "SAO 190852"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.83413609),
        dec: Angle.Degrees(-25.65155404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135110"},
        {"Hipparcos Number", "HIP 74573"},
        {"Smithsonian Astrophysical Observation", "SAO 183295"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.54945733),
        dec: Angle.Degrees(-25.65029939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211065"},
        {"Hipparcos Number", "HIP 109868"},
        {"Smithsonian Astrophysical Observation", "SAO 190997"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.78194483),
        dec: Angle.Degrees(-25.64798668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154132"},
        {"Hipparcos Number", "HIP 83566"},
        {"Geneva Identification System", "GEN# +1.00154132"},
        {"Smithsonian Astrophysical Observation", "SAO 184995"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.18137104),
        dec: Angle.Degrees(-25.64514224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10209"},
    },
    visualMagnitude: 11.37,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.83072808),
        dec: Angle.Degrees(-25.64465538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204367"},
        {"Hipparcos Number", "HIP 106034"},
        {"Renson", "Renson 56910"},
        {"Smithsonian Astrophysical Observation", "SAO 190368"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.17156505),
        dec: Angle.Degrees(-25.64405526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33770",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5699 AB"},
        {"Henry Draper", "HD 52596"},
        {"Hipparcos Number", "HIP 33770"},
        {"Celescope Catalog", "CEL 1504"},
        {"Geneva Identification System", "GEN# +1.00052596J"},
        {"Smithsonian Astrophysical Observation", "SAO 172750"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.19813501),
        dec: Angle.Degrees(-25.64381339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49002"},
        {"Hipparcos Number", "HIP 32360"},
        {"Smithsonian Astrophysical Observation", "SAO 172270"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.31108282),
        dec: Angle.Degrees(-25.64014489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36037"},
        {"Hipparcos Number", "HIP 25551"},
        {"Fundamental Katalog 5th Edition", "FK5 2411"},
        {"Geneva Identification System", "GEN# +1.00036037"},
        {"Smithsonian Astrophysical Observation", "SAO 170450"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.93597194),
        dec: Angle.Degrees(-25.63681811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9968"},
        {"Hipparcos Number", "HIP 7530"},
        {"Smithsonian Astrophysical Observation", "SAO 167177"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.24866072),
        dec: Angle.Degrees(-25.63497745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12462"},
        {"Hipparcos Number", "HIP 9453"},
        {"Smithsonian Astrophysical Observation", "SAO 167496"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.39552981),
        dec: Angle.Degrees(-25.63412349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42568"},
        {"Hipparcos Number", "HIP 29280"},
        {"Geneva Identification System", "GEN# +1.00042568"},
        {"Smithsonian Astrophysical Observation", "SAO 171330"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.59097871),
        dec: Angle.Degrees(-25.63213046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78736"},
        {"Hipparcos Number", "HIP 44929"},
        {"Smithsonian Astrophysical Observation", "SAO 177033"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.27903768),
        dec: Angle.Degrees(-25.63031375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37746",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37746"},
        {"Geneva Identification System", "GEN# -0.02504991"},
    },
    visualMagnitude: 11.02,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.13145904),
        dec: Angle.Degrees(-25.62849712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80639"},
        {"Hipparcos Number", "HIP 45793"},
        {"Smithsonian Astrophysical Observation", "SAO 177297"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.05825063),
        dec: Angle.Degrees(-25.62782601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217358"},
        {"Hipparcos Number", "HIP 113593"},
        {"Geneva Identification System", "GEN# +1.00217358"},
        {"Smithsonian Astrophysical Observation", "SAO 191565"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.10242074),
        dec: Angle.Degrees(-25.62674394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186806"},
        {"Hipparcos Number", "HIP 97390"},
        {"Smithsonian Astrophysical Observation", "SAO 188570"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.91504287),
        dec: Angle.Degrees(-25.62642032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164315"},
        {"Hipparcos Number", "HIP 88292"},
        {"Smithsonian Astrophysical Observation", "SAO 186129"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.44525518),
        dec: Angle.Degrees(-25.62640988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65486"},
        {"Hipparcos Number", "HIP 38939"},
        {"Cincinnati Publication", "Ci 20 448"},
        {"Geneva Identification System", "GEN# +1.00065486"},
        {"Smithsonian Astrophysical Observation", "SAO 174889"},
        {"Wilson Evans Batten Catalogue", "WEB 7633"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.51723268),
        dec: Angle.Degrees(-25.62603145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 362.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -245.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29241",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4775 A"},
        {"Henry Draper", "HD 42499"},
        {"Hipparcos Number", "HIP 29241"},
        {"Geneva Identification System", "GEN# +1.00042499"},
        {"Smithsonian Astrophysical Observation", "SAO 171321"},
        {"Wilson Evans Batten Catalogue", "WEB 5734"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.48401563),
        dec: Angle.Degrees(-25.62582628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160350"},
        {"Hipparcos Number", "HIP 86498"},
        {"Fundamental Katalog 5th Edition", "FK5 5552"},
        {"Smithsonian Astrophysical Observation", "SAO 185606"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.14568964),
        dec: Angle.Degrees(-25.62435258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130158"},
        {"Hipparcos Number", "HIP 72323"},
        {"Geneva Identification System", "GEN# +1.00130158"},
        {"Renson", "Renson 37080"},
        {"Smithsonian Astrophysical Observation", "SAO 182875"},
        {"Wilson Evans Batten Catalogue", "WEB 12437"},
    },
    visualMagnitude: 5.61,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.84399993),
        dec: Angle.Degrees(-25.62423321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224778"},
        {"Hipparcos Number", "HIP 46"},
        {"Geneva Identification System", "GEN# +1.00224778"},
        {"Smithsonian Astrophysical Observation", "SAO 192313"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.13454429),
        dec: Angle.Degrees(-25.62225277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38265"},
        {"Hipparcos Number", "HIP 26977"},
        {"Geneva Identification System", "GEN# +1.00038265"},
        {"Smithsonian Astrophysical Observation", "SAO 170736"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.86902778),
        dec: Angle.Degrees(-25.62198228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11975"},
        {"Hipparcos Number", "HIP 9086"},
        {"Smithsonian Astrophysical Observation", "SAO 167422"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.24961018),
        dec: Angle.Degrees(-25.62020898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53095"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.93228711),
        dec: Angle.Degrees(-25.61815161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -287.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9151"},
        {"Hipparcos Number", "HIP 6971"},
        {"Fundamental Katalog 5th Edition", "FK5 2098"},
        {"Smithsonian Astrophysical Observation", "SAO 167087"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.42829333),
        dec: Angle.Degrees(-25.61778011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54670"},
        {"Hipparcos Number", "HIP 34483"},
        {"Smithsonian Astrophysical Observation", "SAO 173062"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.19252701),
        dec: Angle.Degrees(-25.61768311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56600"},
        {"Smithsonian Astrophysical Observation", "SAO 180025"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.06829409),
        dec: Angle.Degrees(-25.61710516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137319"},
        {"Hipparcos Number", "HIP 75553"},
        {"Geneva Identification System", "GEN# +1.00137319"},
        {"Smithsonian Astrophysical Observation", "SAO 183463"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.52270583),
        dec: Angle.Degrees(-25.61697798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82341"},
        {"Hipparcos Number", "HIP 46647"},
        {"Smithsonian Astrophysical Observation", "SAO 177577"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.67044714),
        dec: Angle.Degrees(-25.61612083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131623"},
        {"Hipparcos Number", "HIP 73027"},
        {"Smithsonian Astrophysical Observation", "SAO 183002"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.86167519),
        dec: Angle.Degrees(-25.61555217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121426"},
        {"Hipparcos Number", "HIP 68028"},
        {"Smithsonian Astrophysical Observation", "SAO 182093"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.95410350),
        dec: Angle.Degrees(-25.61526419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4691"},
        {"Geneva Identification System", "GEN# -0.02600323"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.07590349),
        dec: Angle.Degrees(-25.61460962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 422.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21997"},
        {"Hipparcos Number", "HIP 16449"},
        {"Geneva Identification System", "GEN# +1.00021997"},
        {"Smithsonian Astrophysical Observation", "SAO 168612"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.97338360),
        dec: Angle.Degrees(-25.61411273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174032"},
        {"Hipparcos Number", "HIP 92389"},
        {"Smithsonian Astrophysical Observation", "SAO 187321"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.41599387),
        dec: Angle.Degrees(-25.61323302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22788"},
        {"Hipparcos Number", "HIP 17006"},
        {"Smithsonian Astrophysical Observation", "SAO 168700"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.69823314),
        dec: Angle.Degrees(-25.60847353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97044"},
        {"Hipparcos Number", "HIP 54576"},
        {"Smithsonian Astrophysical Observation", "SAO 179609"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.52092548),
        dec: Angle.Degrees(-25.60750489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61102"},
        {"Geneva Identification System", "GEN# -0.02410403"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.83825944),
        dec: Angle.Degrees(-25.60698759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194711"},
        {"Hipparcos Number", "HIP 100947"},
        {"Fundamental Katalog 5th Edition", "FK5 3636"},
        {"Geneva Identification System", "GEN# +1.00194711"},
        {"Smithsonian Astrophysical Observation", "SAO 189309"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.00528061),
        dec: Angle.Degrees(-25.60651379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34962"},
        {"New General Catalogue", "NGC 2354 29"},
    },
    visualMagnitude: 11.67,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.50495818),
        dec: Angle.Degrees(-25.60584467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5354"},
        {"Hipparcos Number", "HIP 4319"},
        {"Geneva Identification System", "GEN# +1.00005354"},
        {"Smithsonian Astrophysical Observation", "SAO 166678"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.81184338),
        dec: Angle.Degrees(-25.60570141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164972"},
        {"Hipparcos Number", "HIP 88541"},
        {"Geneva Identification System", "GEN# +1.00164972"},
        {"Smithsonian Astrophysical Observation", "SAO 186235"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.20202909),
        dec: Angle.Degrees(-25.60569313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167979"},
        {"Hipparcos Number", "HIP 89731"},
        {"Geneva Identification System", "GEN# +1.00167979"},
        {"Smithsonian Astrophysical Observation", "SAO 186629"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.67400884),
        dec: Angle.Degrees(-25.60471619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6378"},
        {"Hipparcos Number", "HIP 5027"},
        {"Geneva Identification System", "GEN# +1.00006378"},
        {"Smithsonian Astrophysical Observation", "SAO 166780"},
        {"Wilson Evans Batten Catalogue", "WEB 1027"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.10072304),
        dec: Angle.Degrees(-25.60422804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -316.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54337"},
        {"Hipparcos Number", "HIP 34371"},
        {"Smithsonian Astrophysical Observation", "SAO 173009"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.86618190),
        dec: Angle.Degrees(-25.60352405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131321"},
        {"Hipparcos Number", "HIP 72867"},
        {"Smithsonian Astrophysical Observation", "SAO 182968"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.41036490),
        dec: Angle.Degrees(-25.60096877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79268"},
        {"Henry Draper 2", "HD 79267"},
        {"Hipparcos Number", "HIP 45182"},
        {"Smithsonian Astrophysical Observation", "SAO 177111"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.10633292),
        dec: Angle.Degrees(-25.60087933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82538",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10232 AB"},
        {"Henry Draper", "HD 152071"},
        {"Hipparcos Number", "HIP 82538"},
        {"Smithsonian Astrophysical Observation", "SAO 184735"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.06694183),
        dec: Angle.Degrees(-25.60057893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3059"},
        {"Smithsonian Astrophysical Observation", "SAO 166444"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.70806478),
        dec: Angle.Degrees(-25.60052471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3622"},
        {"Hipparcos Number", "HIP 3064"},
        {"Geneva Identification System", "GEN# +1.00003622J"},
        {"Smithsonian Astrophysical Observation", "SAO 166446"},
        {"Wilson Evans Batten Catalogue", "WEB 547"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.72114799),
        dec: Angle.Degrees(-25.59572649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115683"},
        {"Hipparcos Number", "HIP 64970"},
        {"Geneva Identification System", "GEN# +1.00115683"},
        {"Smithsonian Astrophysical Observation", "SAO 181546"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.74324212),
        dec: Angle.Degrees(-25.59556049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41368"},
        {"Hipparcos Number", "HIP 28702"},
        {"Smithsonian Astrophysical Observation", "SAO 171189"},
    },
    visualMagnitude: 9.72,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.92831958),
        dec: Angle.Degrees(-25.59336359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80112",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alniyat"},
        {"Aitken", "ADS 10009 A"},
        {"Henry Draper", "HD 147165"},
        {"Hipparcos Number", "HIP 80112"},
        {"Fundamental Katalog 5th Edition", "FK5 607"},
        {"Geneva Identification System", "GEN# +1.00147165A"},
        {"Smithsonian Astrophysical Observation", "SAO 184336"},
        {"Wilson Evans Batten Catalogue", "WEB 13560"},
    },
    visualMagnitude: 2.90,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.29717718),
        dec: Angle.Degrees(-25.59275259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14239"},
    },
    visualMagnitude: 11.04,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.90236062),
        dec: Angle.Degrees(-25.59268724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 213.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139731"},
        {"Hipparcos Number", "HIP 76782"},
        {"Geneva Identification System", "GEN# +1.00139731"},
        {"Smithsonian Astrophysical Observation", "SAO 183692"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.15768509),
        dec: Angle.Degrees(-25.59242023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4659"},
        {"Smithsonian Astrophysical Observation", "SAO 166729"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.96530774),
        dec: Angle.Degrees(-25.59063199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82574"},
        {"Hipparcos Number", "HIP 46797"},
        {"Smithsonian Astrophysical Observation", "SAO 177617"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.04047553),
        dec: Angle.Degrees(-25.59023200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20980"},
        {"Hipparcos Number", "HIP 15700"},
        {"Fundamental Katalog 5th Edition", "FK5 2237"},
        {"Geneva Identification System", "GEN# +1.00020980"},
        {"Smithsonian Astrophysical Observation", "SAO 168493"},
        {"Wilson Evans Batten Catalogue", "WEB 3009"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.56784370),
        dec: Angle.Degrees(-25.58780402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24405"},
        {"Hipparcos Number", "HIP 18086"},
        {"Smithsonian Astrophysical Observation", "SAO 168900"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.99318051),
        dec: Angle.Degrees(-25.58685307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94783"},
        {"Hipparcos Number", "HIP 53468"},
        {"Smithsonian Astrophysical Observation", "SAO 179355"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.06623129),
        dec: Angle.Degrees(-25.58494178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182662"},
        {"Hipparcos Number", "HIP 95606"},
        {"Fundamental Katalog 5th Edition", "FK5 5710"},
        {"Smithsonian Astrophysical Observation", "SAO 188126"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.68547697),
        dec: Angle.Degrees(-25.58382672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35285"},
        {"Hipparcos Number", "HIP 25108"},
        {"Geneva Identification System", "GEN# +1.00035285"},
        {"Smithsonian Astrophysical Observation", "SAO 170360"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.63595219),
        dec: Angle.Degrees(-25.58359425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22333"},
        {"Hipparcos Number", "HIP 16697"},
        {"Geneva Identification System", "GEN# +1.00022333"},
        {"Smithsonian Astrophysical Observation", "SAO 168648"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.71821945),
        dec: Angle.Degrees(-25.58290648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198449"},
        {"Hipparcos Number", "HIP 102928"},
        {"Smithsonian Astrophysical Observation", "SAO 189767"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.79739319),
        dec: Angle.Degrees(-25.58255032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20738"},
        {"Hipparcos Number", "HIP 15486"},
        {"Geneva Identification System", "GEN# +1.00020738"},
        {"Smithsonian Astrophysical Observation", "SAO 168464"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.90588500),
        dec: Angle.Degrees(-25.57883826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81181",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81181"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.72280783),
        dec: Angle.Degrees(-25.57786920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -267.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63446"},
        {"Hipparcos Number", "HIP 38063"},
        {"Geneva Identification System", "GEN# +1.00063446"},
        {"Wilson Evans Batten Catalogue", "WEB 7505"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.01605331),
        dec: Angle.Degrees(-25.57779135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45018"},
        {"Hipparcos Number", "HIP 30436"},
        {"Fundamental Katalog 5th Edition", "FK5 2490"},
        {"Geneva Identification System", "GEN# +1.00045018"},
        {"Smithsonian Astrophysical Observation", "SAO 171688"},
        {"Wilson Evans Batten Catalogue", "WEB 6057"},
    },
    visualMagnitude: 5.61,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.98297443),
        dec: Angle.Degrees(-25.57752992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190577"},
        {"Hipparcos Number", "HIP 99051"},
        {"Smithsonian Astrophysical Observation", "SAO 188916"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.65180353),
        dec: Angle.Degrees(-25.57658276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198924"},
        {"Hipparcos Number", "HIP 103192"},
        {"Smithsonian Astrophysical Observation", "SAO 189818"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.59974470),
        dec: Angle.Degrees(-25.57638629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95793"},
        {"Hipparcos Number", "HIP 54019"},
        {"Fundamental Katalog 5th Edition", "FK5 4975"},
        {"Smithsonian Astrophysical Observation", "SAO 179469"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.77115192),
        dec: Angle.Degrees(-25.57507891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131398"},
        {"Hipparcos Number", "HIP 72913"},
        {"Smithsonian Astrophysical Observation", "SAO 182980"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.52770635),
        dec: Angle.Degrees(-25.57426103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208708"},
        {"Hipparcos Number", "HIP 108495"},
        {"Smithsonian Astrophysical Observation", "SAO 190785"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.68469465),
        dec: Angle.Degrees(-25.57180435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165530"},
        {"Hipparcos Number", "HIP 88798"},
        {"Smithsonian Astrophysical Observation", "SAO 186309"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.89427429),
        dec: Angle.Degrees(-25.56988205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14803"},
        {"Hipparcos Number", "HIP 11073"},
        {"Smithsonian Astrophysical Observation", "SAO 167737"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.63542961),
        dec: Angle.Degrees(-25.56975425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16650"},
        {"Hipparcos Number", "HIP 12384"},
        {"Fundamental Katalog 5th Edition", "FK5 4246"},
        {"Smithsonian Astrophysical Observation", "SAO 167955"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.85888157),
        dec: Angle.Degrees(-25.56908886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212630"},
        {"Hipparcos Number", "HIP 110744"},
        {"Smithsonian Astrophysical Observation", "SAO 191142"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.54078565),
        dec: Angle.Degrees(-25.56881539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10037"},
        {"Hipparcos Number", "HIP 7586"},
        {"Geneva Identification System", "GEN# +1.00010037"},
        {"Smithsonian Astrophysical Observation", "SAO 167183"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.42177926),
        dec: Angle.Degrees(-25.56779271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57193"},
        {"Hipparcos Number", "HIP 35453"},
        {"Celescope Catalog", "CEL 1775"},
        {"Geneva Identification System", "GEN# +1.00057193"},
        {"Smithsonian Astrophysical Observation", "SAO 173462"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.79129435),
        dec: Angle.Degrees(-25.56589727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90227"},
        {"Hipparcos Number", "HIP 50959"},
        {"Smithsonian Astrophysical Observation", "SAO 178776"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.10891048),
        dec: Angle.Degrees(-25.56578239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201388"},
        {"Hipparcos Number", "HIP 104482"},
        {"Smithsonian Astrophysical Observation", "SAO 190077"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.49396200),
        dec: Angle.Degrees(-25.56379816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219259"},
        {"Hipparcos Number", "HIP 114758"},
        {"Smithsonian Astrophysical Observation", "SAO 191750"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.68522533),
        dec: Angle.Degrees(-25.56311225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200884"},
        {"Hipparcos Number", "HIP 104222"},
        {"Smithsonian Astrophysical Observation", "SAO 190019"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.72369271),
        dec: Angle.Degrees(-25.56245470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105674",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14936 AB"},
        {"Henry Draper", "HD 203653"},
        {"Hipparcos Number", "HIP 105674"},
        {"Renson", "Renson 56700"},
        {"Smithsonian Astrophysical Observation", "SAO 190296"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.06234897),
        dec: Angle.Degrees(-25.56112309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3479"},
        {"Hipparcos Number", "HIP 2964"},
        {"Geneva Identification System", "GEN# +1.00003479"},
        {"Smithsonian Astrophysical Observation", "SAO 166421"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.41319004),
        dec: Angle.Degrees(-25.56050855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29013"},
        {"Hipparcos Number", "HIP 21225"},
        {"Geneva Identification System", "GEN# +1.00029013"},
        {"Smithsonian Astrophysical Observation", "SAO 169560"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.29103764),
        dec: Angle.Degrees(-25.55989236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151596"},
        {"Hipparcos Number", "HIP 82328"},
        {"Smithsonian Astrophysical Observation", "SAO 184674"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.33119842),
        dec: Angle.Degrees(-25.55773991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157174"},
        {"Hipparcos Number", "HIP 85034"},
        {"Smithsonian Astrophysical Observation", "SAO 185336"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.69341418),
        dec: Angle.Degrees(-25.55761758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29434"},
        {"Hipparcos Number", "HIP 21511"},
        {"Geneva Identification System", "GEN# +1.00029434"},
        {"Smithsonian Astrophysical Observation", "SAO 169618"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.29036581),
        dec: Angle.Degrees(-25.55629547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107939"},
        {"Hipparcos Number", "HIP 60515"},
        {"Smithsonian Astrophysical Observation", "SAO 180765"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.07813277),
        dec: Angle.Degrees(-25.55531622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19506"},
        {"Hipparcos Number", "HIP 14508"},
        {"Geneva Identification System", "GEN# +1.00019506"},
        {"Smithsonian Astrophysical Observation", "SAO 168316"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.83753798),
        dec: Angle.Degrees(-25.55400299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58348"},
        {"Hipparcos Number", "HIP 35921"},
        {"Smithsonian Astrophysical Observation", "SAO 173658"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.07260617),
        dec: Angle.Degrees(-25.55128392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74912",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74912"},
        {"Smithsonian Astrophysical Observation", "SAO 183355"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.63549940),
        dec: Angle.Degrees(-25.55080226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149228"},
        {"Hipparcos Number", "HIP 81146"},
        {"Geneva Identification System", "GEN# +1.00149228"},
        {"Renson", "Renson 42200"},
        {"Smithsonian Astrophysical Observation", "SAO 184468"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.60078727),
        dec: Angle.Degrees(-25.54972753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112699"},
        {"Smithsonian Astrophysical Observation", "SAO 191430"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.33065946),
        dec: Angle.Degrees(-25.54924499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 715",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 715"},
        {"Smithsonian Astrophysical Observation", "SAO 166076"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.21598889),
        dec: Angle.Degrees(-25.54780455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122067"},
        {"Hipparcos Number", "HIP 68397"},
        {"Smithsonian Astrophysical Observation", "SAO 182154"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.01888560),
        dec: Angle.Degrees(-25.54772698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37044"},
        {"Hipparcos Number", "HIP 26152"},
        {"Smithsonian Astrophysical Observation", "SAO 170571"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.63254478),
        dec: Angle.Degrees(-25.54723391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2363"},
        {"Hipparcos Number", "HIP 2159"},
        {"Fundamental Katalog 5th Edition", "FK5 2025"},
        {"Geneva Identification System", "GEN# +1.00002363"},
        {"Smithsonian Astrophysical Observation", "SAO 166282"},
        {"Wilson Evans Batten Catalogue", "WEB 400"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.81119663),
        dec: Angle.Degrees(-25.54713325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70893",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9280 A"},
        {"Henry Draper", "HD 127037"},
        {"Hipparcos Number", "HIP 70893"},
        {"Smithsonian Astrophysical Observation", "SAO 182599"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.45810905),
        dec: Angle.Degrees(-25.54278826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70895",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9280 B"},
        {"Hipparcos Number", "HIP 70895"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.46138618),
        dec: Angle.Degrees(-25.54089624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35055"},
        {"Hipparcos Number", "HIP 24966"},
        {"Smithsonian Astrophysical Observation", "SAO 170337"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.21480859),
        dec: Angle.Degrees(-25.53858133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114333"},
        {"Hipparcos Number", "HIP 64253"},
        {"Geneva Identification System", "GEN# +1.00114333"},
        {"Smithsonian Astrophysical Observation", "SAO 181424"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.54726398),
        dec: Angle.Degrees(-25.53744918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151997"},
        {"Hipparcos Number", "HIP 82511"},
        {"Geneva Identification System", "GEN# +1.00151997"},
        {"Smithsonian Astrophysical Observation", "SAO 184725"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.96166587),
        dec: Angle.Degrees(-25.53498696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48758"},
        {"Hipparcos Number", "HIP 32243"},
        {"Fundamental Katalog 5th Edition", "FK5 4612"},
        {"Geneva Identification System", "GEN# +1.00048758"},
        {"Smithsonian Astrophysical Observation", "SAO 172238"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.97316683),
        dec: Angle.Degrees(-25.53497131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37689"},
        {"Hipparcos Number", "HIP 26608"},
        {"Geneva Identification System", "GEN# +1.00037689"},
        {"Smithsonian Astrophysical Observation", "SAO 170648"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.84696217),
        dec: Angle.Degrees(-25.53478086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112100"},
        {"Hipparcos Number", "HIP 62979"},
        {"Geneva Identification System", "GEN# +1.00112100"},
        {"Smithsonian Astrophysical Observation", "SAO 181208"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.56831854),
        dec: Angle.Degrees(-25.53443222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183500"},
        {"Hipparcos Number", "HIP 95971"},
        {"Smithsonian Astrophysical Observation", "SAO 188217"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.73998092),
        dec: Angle.Degrees(-25.53413166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52779"},
        {"Hipparcos Number", "HIP 33843"},
        {"Smithsonian Astrophysical Observation", "SAO 172784"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.38179313),
        dec: Angle.Degrees(-25.53400421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152657"},
        {"Hipparcos Number", "HIP 82839"},
        {"Geneva Identification System", "GEN# +1.00152657"},
        {"Smithsonian Astrophysical Observation", "SAO 184805"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.93490705),
        dec: Angle.Degrees(-25.53389877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93409"},
        {"Hipparcos Number", "HIP 52728"},
        {"Smithsonian Astrophysical Observation", "SAO 179219"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.69428389),
        dec: Angle.Degrees(-25.53380410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141495"},
        {"Hipparcos Number", "HIP 77576"},
        {"Smithsonian Astrophysical Observation", "SAO 183843"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.56850882),
        dec: Angle.Degrees(-25.53338517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181293"},
        {"Hipparcos Number", "HIP 95114"},
        {"Geneva Identification System", "GEN# +1.00181293"},
        {"Smithsonian Astrophysical Observation", "SAO 187998"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.24261314),
        dec: Angle.Degrees(-25.53268979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23693"},
        {"Hipparcos Number", "HIP 17599"},
        {"Smithsonian Astrophysical Observation", "SAO 168816"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.55229300),
        dec: Angle.Degrees(-25.53188783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35800",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35800"},
        {"Smithsonian Astrophysical Observation", "SAO 173595"},
    },
    visualMagnitude: 9.19,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.76568431),
        dec: Angle.Degrees(-25.53144484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19723",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3075 A"},
        {"Henry Draper", "HD 26817"},
        {"Hipparcos Number", "HIP 19723"},
        {"Smithsonian Astrophysical Observation", "SAO 169239"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.40329364),
        dec: Angle.Degrees(-25.52928193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151179"},
        {"Hipparcos Number", "HIP 82140"},
        {"Fundamental Katalog 5th Edition", "FK5 5482"},
        {"Geneva Identification System", "GEN# +1.00151179"},
        {"Smithsonian Astrophysical Observation", "SAO 184630"},
        {"Wilson Evans Batten Catalogue", "WEB 13873"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.71394679),
        dec: Angle.Degrees(-25.52853630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82181"},
        {"Hipparcos Number", "HIP 46564"},
        {"Smithsonian Astrophysical Observation", "SAO 177540"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.44116395),
        dec: Angle.Degrees(-25.52814831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27904",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4504 B"},
        {"Hipparcos Number", "HIP 27904"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.57438703),
        dec: Angle.Degrees(-25.52748765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27908",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4504 A"},
        {"Henry Draper", "HD 39871"},
        {"Hipparcos Number", "HIP 27908"},
        {"Geneva Identification System", "GEN# +1.00039871"},
        {"Smithsonian Astrophysical Observation", "SAO 170992"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.57984659),
        dec: Angle.Degrees(-25.52696949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77338"},
        {"Hipparcos Number", "HIP 44291"},
        {"Smithsonian Astrophysical Observation", "SAO 176832"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.30194792),
        dec: Angle.Degrees(-25.52640470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -270.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14072"},
        {"Hipparcos Number", "HIP 10566"},
        {"Smithsonian Astrophysical Observation", "SAO 167670"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.00555282),
        dec: Angle.Degrees(-25.52464931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3484",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3484"},
        {"Smithsonian Astrophysical Observation", "SAO 166527"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.11832935),
        dec: Angle.Degrees(-25.52420037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145263"},
        {"Hipparcos Number", "HIP 79288"},
        {"Smithsonian Astrophysical Observation", "SAO 184196"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.72964040),
        dec: Angle.Degrees(-25.52262244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93999"},
        {"Hipparcos Number", "HIP 53010"},
        {"Smithsonian Astrophysical Observation", "SAO 179269"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.67339504),
        dec: Angle.Degrees(-25.52258882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35798",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35798"},
        {"Geneva Identification System", "GEN# -0.02504446"},
        {"Smithsonian Astrophysical Observation", "SAO 173594"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.76161612),
        dec: Angle.Degrees(-25.52139183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115576"},
        {"Hipparcos Number", "HIP 64912"},
        {"Smithsonian Astrophysical Observation", "SAO 181535"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.57810569),
        dec: Angle.Degrees(-25.52087411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33323",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5606 AB"},
        {"Henry Draper", "HD 51343"},
        {"Hipparcos Number", "HIP 33323"},
        {"Smithsonian Astrophysical Observation", "SAO 172591"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.97063677),
        dec: Angle.Degrees(-25.51814454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216391"},
        {"Hipparcos Number", "HIP 112977"},
        {"Geneva Identification System", "GEN# +1.00216391"},
        {"Smithsonian Astrophysical Observation", "SAO 191461"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.20071626),
        dec: Angle.Degrees(-25.51380995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94673",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94673"},
    },
    visualMagnitude: 11.29,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.97334739),
        dec: Angle.Degrees(-25.51349356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60954"},
        {"Hipparcos Number", "HIP 36972"},
        {"Smithsonian Astrophysical Observation", "SAO 174088"},
    },
    visualMagnitude: 8.80,
    bvColour: -0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.99896612),
        dec: Angle.Degrees(-25.51187120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85521",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10564 AB"},
        {"Henry Draper", "HD 158140"},
        {"Hipparcos Number", "HIP 85521"},
        {"Renson", "Renson 44460"},
        {"Smithsonian Astrophysical Observation", "SAO 185433"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.16150873),
        dec: Angle.Degrees(-25.51059094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25855"},
        {"Hipparcos Number", "HIP 19051"},
        {"Smithsonian Astrophysical Observation", "SAO 169100"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.22709551),
        dec: Angle.Degrees(-25.51025244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37949"},
        {"Hipparcos Number", "HIP 26755"},
        {"Smithsonian Astrophysical Observation", "SAO 170691"},
    },
    visualMagnitude: 8.24,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.26041638),
        dec: Angle.Degrees(-25.50736568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32889"},
        {"Hipparcos Number", "HIP 23670"},
        {"Geneva Identification System", "GEN# +1.00032889"},
        {"Smithsonian Astrophysical Observation", "SAO 170049"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.32064253),
        dec: Angle.Degrees(-25.50716390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26603"},
        {"Smithsonian Astrophysical Observation", "SAO 170643"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.81973715),
        dec: Angle.Degrees(-25.50701519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27390"},
        {"Hipparcos Number", "HIP 20088"},
        {"Smithsonian Astrophysical Observation", "SAO 169321"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.59942123),
        dec: Angle.Degrees(-25.50535988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172193"},
        {"Hipparcos Number", "HIP 91524"},
        {"Smithsonian Astrophysical Observation", "SAO 187106"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.96781300),
        dec: Angle.Degrees(-25.50459257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124226"},
        {"Hipparcos Number", "HIP 69433"},
        {"Smithsonian Astrophysical Observation", "SAO 182350"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.23482688),
        dec: Angle.Degrees(-25.50429111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77665"},
        {"Hipparcos Number", "HIP 44431"},
        {"Geneva Identification System", "GEN# +1.00077665"},
        {"Smithsonian Astrophysical Observation", "SAO 176881"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.78678624),
        dec: Angle.Degrees(-25.50420137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62555"},
        {"Hipparcos Number", "HIP 37660"},
        {"Geneva Identification System", "GEN# +1.00062555J"},
        {"Smithsonian Astrophysical Observation", "SAO 174395"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.91296944),
        dec: Angle.Degrees(-25.50383857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24159"},
        {"Hipparcos Number", "HIP 17919"},
        {"Geneva Identification System", "GEN# +1.00024159"},
        {"Smithsonian Astrophysical Observation", "SAO 168868"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.47843974),
        dec: Angle.Degrees(-25.50315302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119623"},
        {"Hipparcos Number", "HIP 67071"},
        {"Geneva Identification System", "GEN# +1.00119623"},
        {"Smithsonian Astrophysical Observation", "SAO 181921"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.19042582),
        dec: Angle.Degrees(-25.50087935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91515",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11539 C"},
        {"Henry Draper", "HD 172178"},
        {"Hipparcos Number", "HIP 91515"},
        {"Smithsonian Astrophysical Observation", "SAO 187103"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.95198479),
        dec: Angle.Degrees(-25.50070510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208382"},
        {"Hipparcos Number", "HIP 108306"},
        {"Geneva Identification System", "GEN# +1.00208382"},
        {"Smithsonian Astrophysical Observation", "SAO 190750"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.12420940),
        dec: Angle.Degrees(-25.49966412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91459"},
        {"Hipparcos Number", "HIP 51654"},
        {"Smithsonian Astrophysical Observation", "SAO 178964"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.29725400),
        dec: Angle.Degrees(-25.49912445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12779",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2098 B"},
        {"Henry Draper", "HD 17134B"},
        {"Hipparcos Number", "HIP 12779"},
        {"Smithsonian Astrophysical Observation", "SAO 168011"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.05968141),
        dec: Angle.Degrees(-25.49888025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140672"},
        {"Hipparcos Number", "HIP 77197"},
        {"Fundamental Katalog 5th Edition", "FK5 5396"},
        {"Smithsonian Astrophysical Observation", "SAO 183766"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.44354156),
        dec: Angle.Degrees(-25.49557278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12780",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2098 AP"},
        {"Henry Draper", "HD 17134"},
        {"Hipparcos Number", "HIP 12780"},
        {"Fundamental Katalog 5th Edition", "FK5 1078"},
        {"Geneva Identification System", "GEN# +1.00017134J"},
        {"Smithsonian Astrophysical Observation", "SAO 168012"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.06045270),
        dec: Angle.Degrees(-25.49551901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 164.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130360"},
        {"Hipparcos Number", "HIP 72420"},
        {"Geneva Identification System", "GEN# +1.00130360"},
        {"Smithsonian Astrophysical Observation", "SAO 182888"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.12132039),
        dec: Angle.Degrees(-25.48743409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 168.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42553"},
        {"Hipparcos Number", "HIP 29278"},
        {"Smithsonian Astrophysical Observation", "SAO 171328"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.58308622),
        dec: Angle.Degrees(-25.48443283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142991"},
        {"Hipparcos Number", "HIP 78253"},
        {"Smithsonian Astrophysical Observation", "SAO 183984"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.65275390),
        dec: Angle.Degrees(-25.48223270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58270",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8360 AB"},
        {"Henry Draper", "HD 103787"},
        {"Hipparcos Number", "HIP 58270"},
        {"Smithsonian Astrophysical Observation", "SAO 180323"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.25954452),
        dec: Angle.Degrees(-25.48176759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6516"},
        {"Hipparcos Number", "HIP 5146"},
        {"Geneva Identification System", "GEN# +1.00006516"},
        {"Smithsonian Astrophysical Observation", "SAO 166795"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.46877669),
        dec: Angle.Degrees(-25.48110880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195954"},
        {"Hipparcos Number", "HIP 101577"},
        {"Smithsonian Astrophysical Observation", "SAO 189457"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.79397952),
        dec: Angle.Degrees(-25.48089862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154241"},
        {"Hipparcos Number", "HIP 83615"},
        {"Geneva Identification System", "GEN# +1.00154241"},
        {"Smithsonian Astrophysical Observation", "SAO 185008"},
        {"Wilson Evans Batten Catalogue", "WEB 14141"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.34414910),
        dec: Angle.Degrees(-25.47747162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146001"},
        {"Hipparcos Number", "HIP 79622"},
        {"Geneva Identification System", "GEN# +1.00146001"},
        {"Renson", "Renson 41310"},
        {"Smithsonian Astrophysical Observation", "SAO 184258"},
        {"Wilson Evans Batten Catalogue", "WEB 13476"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.72265106),
        dec: Angle.Degrees(-25.47692204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88905",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11069 A"},
        {"Henry Draper", "HD 165814"},
        {"Hipparcos Number", "HIP 88905"},
        {"Celescope Catalog", "CEL 4627"},
        {"Geneva Identification System", "GEN# +1.00165814J"},
        {"Smithsonian Astrophysical Observation", "SAO 186350"},
        {"Wilson Evans Batten Catalogue", "WEB 15077"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.22518498),
        dec: Angle.Degrees(-25.47303602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181868"},
        {"Hipparcos Number", "HIP 95288"},
        {"Smithsonian Astrophysical Observation", "SAO 188051"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.79072273),
        dec: Angle.Degrees(-25.47147365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88908",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11069 B"},
        {"Henry Draper", "HD 165814B"},
        {"Hipparcos Number", "HIP 88908"},
        {"Renson", "Renson 46706"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.22892322),
        dec: Angle.Degrees(-25.47143424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148642"},
        {"Hipparcos Number", "HIP 80844"},
        {"Smithsonian Astrophysical Observation", "SAO 184431"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.64201355),
        dec: Angle.Degrees(-25.47052437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54063"},
        {"Hipparcos Number", "HIP 34281"},
        {"Smithsonian Astrophysical Observation", "SAO 172968"},
    },
    visualMagnitude: 8.83,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.61397424),
        dec: Angle.Degrees(-25.46990983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85847"},
        {"Hipparcos Number", "HIP 48554"},
        {"Smithsonian Astrophysical Observation", "SAO 178155"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.52805473),
        dec: Angle.Degrees(-25.46953984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87345"},
        {"Hipparcos Number", "HIP 49309"},
        {"Smithsonian Astrophysical Observation", "SAO 178360"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.97703624),
        dec: Angle.Degrees(-25.46839918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96082"},
    },
    visualMagnitude: 11.17,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.02388438),
        dec: Angle.Degrees(-25.46808066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183174"},
        {"Hipparcos Number", "HIP 95807"},
        {"Smithsonian Astrophysical Observation", "SAO 188181"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.31414192),
        dec: Angle.Degrees(-25.46761513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6352"},
    },
    visualMagnitude: 11.80,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.39363302),
        dec: Angle.Degrees(-25.46668382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1655"},
        {"Hipparcos Number", "HIP 1655"},
        {"Geneva Identification System", "GEN# +1.00001655"},
        {"Smithsonian Astrophysical Observation", "SAO 166200"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.18548897),
        dec: Angle.Degrees(-25.46661666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175602"},
        {"Hipparcos Number", "HIP 93041"},
        {"Smithsonian Astrophysical Observation", "SAO 187490"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.28933174),
        dec: Angle.Degrees(-25.46508437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130094"},
        {"Hipparcos Number", "HIP 72288"},
        {"Smithsonian Astrophysical Observation", "SAO 182870"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.75119401),
        dec: Angle.Degrees(-25.46466897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97851",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13048 AB"},
        {"Henry Draper", "HD 187858"},
        {"Hipparcos Number", "HIP 97851"},
        {"Smithsonian Astrophysical Observation", "SAO 188673"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.28460414),
        dec: Angle.Degrees(-25.46144274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5079",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5079"},
        {"Smithsonian Astrophysical Observation", "SAO 166787"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.26437652),
        dec: Angle.Degrees(-25.46095672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136603"},
        {"Hipparcos Number", "HIP 75227"},
        {"Smithsonian Astrophysical Observation", "SAO 183408"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.59092456),
        dec: Angle.Degrees(-25.45950315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154663"},
        {"Hipparcos Number", "HIP 83823"},
        {"Smithsonian Astrophysical Observation", "SAO 185048"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.96339529),
        dec: Angle.Degrees(-25.45855992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10190",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1692 AB"},
        {"Henry Draper", "HD 13460"},
        {"Hipparcos Number", "HIP 10190"},
        {"Smithsonian Astrophysical Observation", "SAO 167615"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.74811379),
        dec: Angle.Degrees(-25.45762775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131183"},
        {"Hipparcos Number", "HIP 72779"},
        {"Geneva Identification System", "GEN# +1.00131183"},
        {"Smithsonian Astrophysical Observation", "SAO 182950"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.15504111),
        dec: Angle.Degrees(-25.45448812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148321"},
        {"Hipparcos Number", "HIP 80673"},
        {"Geneva Identification System", "GEN# +1.00148321"},
        {"Renson", "Renson 41900"},
        {"Smithsonian Astrophysical Observation", "SAO 184403"},
        {"Wilson Evans Batten Catalogue", "WEB 13643"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.06280882),
        dec: Angle.Degrees(-25.45402538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18946"},
        {"Hipparcos Number", "HIP 14122"},
        {"Smithsonian Astrophysical Observation", "SAO 168242"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.52836967),
        dec: Angle.Degrees(-25.45379473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171058"},
        {"Hipparcos Number", "HIP 90995"},
        {"Smithsonian Astrophysical Observation", "SAO 186975"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.43794660),
        dec: Angle.Degrees(-25.44882784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216969"},
        {"Hipparcos Number", "HIP 113367"},
        {"Smithsonian Astrophysical Observation", "SAO 191525"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.41025156),
        dec: Angle.Degrees(-25.44798191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 164.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99520"},
        {"Hipparcos Number", "HIP 55858"},
        {"Geneva Identification System", "GEN# +1.00099520"},
        {"Smithsonian Astrophysical Observation", "SAO 179891"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.72299814),
        dec: Angle.Degrees(-25.44594680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61619"},
        {"Hipparcos Number", "HIP 37270"},
        {"Smithsonian Astrophysical Observation", "SAO 174210"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.80101658),
        dec: Angle.Degrees(-25.44535646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205771"},
        {"Hipparcos Number", "HIP 106826"},
        {"Geneva Identification System", "GEN# +1.00205771"},
        {"Smithsonian Astrophysical Observation", "SAO 190510"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.54409054),
        dec: Angle.Degrees(-25.44515128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75360"},
        {"Hipparcos Number", "HIP 43256"},
        {"Smithsonian Astrophysical Observation", "SAO 176509"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.17814133),
        dec: Angle.Degrees(-25.44503579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19797"},
        {"Hipparcos Number", "HIP 14728"},
        {"Geneva Identification System", "GEN# +1.00019797"},
        {"Smithsonian Astrophysical Observation", "SAO 168350"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.56133524),
        dec: Angle.Degrees(-25.44435261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86038"},
        {"Smithsonian Astrophysical Observation", "SAO 185522"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.74863690),
        dec: Angle.Degrees(-25.44427694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72197",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9375"},
        {"Henry Draper", "HD 129926"},
        {"Hipparcos Number", "HIP 72197"},
        {"Geneva Identification System", "GEN# +1.00129926J"},
        {"Smithsonian Astrophysical Observation", "SAO 182855"},
        {"Wilson Evans Batten Catalogue", "WEB 12419"},
    },
    visualMagnitude: 5.15,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.50074084),
        dec: Angle.Degrees(-25.44291557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131992"},
        {"Hipparcos Number", "HIP 73189"},
        {"Smithsonian Astrophysical Observation", "SAO 183042"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.38306685),
        dec: Angle.Degrees(-25.44178337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88375"},
        {"Hipparcos Number", "HIP 49856"},
        {"Smithsonian Astrophysical Observation", "SAO 178505"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.71650928),
        dec: Angle.Degrees(-25.43775450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93529"},
        {"Hipparcos Number", "HIP 52781"},
        {"Geneva Identification System", "GEN# +1.00093529"},
        {"Smithsonian Astrophysical Observation", "SAO 179228"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.87094347),
        dec: Angle.Degrees(-25.43726961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221996"},
        {"Hipparcos Number", "HIP 116531"},
        {"Smithsonian Astrophysical Observation", "SAO 192035"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.25795000),
        dec: Angle.Degrees(-25.43497628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72225"},
        {"Hipparcos Number", "HIP 41742"},
        {"Smithsonian Astrophysical Observation", "SAO 175979"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.68611428),
        dec: Angle.Degrees(-25.43460549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82017"},
        {"Hipparcos Number", "HIP 46469"},
        {"Smithsonian Astrophysical Observation", "SAO 177507"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.16155390),
        dec: Angle.Degrees(-25.43350095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6993"},
        {"Hipparcos Number", "HIP 5467"},
        {"Geneva Identification System", "GEN# +1.00006993"},
        {"Smithsonian Astrophysical Observation", "SAO 166845"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.49842693),
        dec: Angle.Degrees(-25.43298791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77450"},
        {"Hipparcos Number", "HIP 44334"},
        {"Smithsonian Astrophysical Observation", "SAO 176844"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.42984236),
        dec: Angle.Degrees(-25.43284771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9820"},
        {"Hipparcos Number", "HIP 7408"},
        {"Smithsonian Astrophysical Observation", "SAO 167161"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.87133506),
        dec: Angle.Degrees(-25.43259305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15418",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2466 AB"},
        {"Henry Draper", "HD 20657"},
        {"Hipparcos Number", "HIP 15418"},
        {"Smithsonian Astrophysical Observation", "SAO 168456"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.68317454),
        dec: Angle.Degrees(-25.42886192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151814"},
        {"Hipparcos Number", "HIP 82427"},
        {"Smithsonian Astrophysical Observation", "SAO 184700"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.68104184),
        dec: Angle.Degrees(-25.42750615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112175"},
        {"Hipparcos Number", "HIP 63019"},
        {"Smithsonian Astrophysical Observation", "SAO 181216"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.71785204),
        dec: Angle.Degrees(-25.42715427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26519"},
        {"Hipparcos Number", "HIP 19501"},
        {"Geneva Identification System", "GEN# +1.00026519"},
        {"Smithsonian Astrophysical Observation", "SAO 169196"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.67231063),
        dec: Angle.Degrees(-25.42557439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70186"},
        {"Hipparcos Number", "HIP 40801"},
        {"Smithsonian Astrophysical Observation", "SAO 175604"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.92019847),
        dec: Angle.Degrees(-25.42376409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50120"},
        {"Hipparcos Number", "HIP 32833"},
        {"Smithsonian Astrophysical Observation", "SAO 172423"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.66699370),
        dec: Angle.Degrees(-25.42186332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171878"},
        {"Hipparcos Number", "HIP 91380"},
        {"Smithsonian Astrophysical Observation", "SAO 187073"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.56351720),
        dec: Angle.Degrees(-25.42145441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
